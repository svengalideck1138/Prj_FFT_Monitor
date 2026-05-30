# FFT Monitor for STM32

![STM32 FFT Monitor 실행 화면](docs/ProgramScreenshot.png)

> 상단: Raw ADC 파형 / 하단: FFT 스펙트럼 (Fundamental Freq 표시)

STM32 보드에서 시리얼(UART/COM) 포트로 전송하는 **Raw ADC 데이터**와 **FFT 연산 결과**를 PC에서 실시간으로 수신하여 그래프로 표시하는 Windows 모니터링 도구입니다.

C# WinForms 기반이며, `System.Windows.Forms.DataVisualization` 차트를 사용해 두 개의 그래프(Raw / FFT)를 동시에 그립니다.

## 주요 기능

- COM 포트 자동 검색 및 통신 설정(Baud Rate, Data Bits, Stop Bits, Parity) 구성
- 시리얼 흐름 제어 신호(CTS / DSR / DTR / RTS / CD) 표시
- ASCII / HEX 수신 모드 지원
- STM32 커스텀 프로토콜 파싱 (Raw / FFT 패킷 구분)
- Raw ADC 파형과 FFT 스펙트럼을 별도 차트로 실시간 갱신
- 수신 데이터 항상 갱신 / 누적 표시 모드 선택

## 통신 프로토콜

STM32 펌웨어는 다음 포맷으로 패킷을 전송해야 합니다. (big-endian 길이 필드)

| 필드      | 크기(byte) | 값 / 설명                          |
|-----------|-----------|-----------------------------------|
| Sync      | 2         | `0x03`, `0x15`                    |
| ID        | 1         | `0x01` = Raw 데이터, `0x02` = FFT 데이터 |
| Length    | 2         | 페이로드 바이트 수 (`hi << 8 | lo`) |
| Payload   | Length    | 데이터 본문                        |

- **Raw 패킷(ID `0x01`)**: ADC 샘플 값 (정수 배열, 256 샘플 기준)
- **FFT 패킷(ID `0x02`)**: 4바이트 IEEE-754 `float` 단위로 인코딩된 FFT 결과 (`Samples × 4` 바이트). PC 측에서 `BitConverter.ToSingle`로 복원해 앞쪽 절반(`Samples / 2`)만 표시합니다.

> 기본 샘플 수는 `Samples = 256`으로 설정되어 있습니다 (`Form1.cs`).

## 요구 환경

- Windows
- .NET Framework 4.7.2
- Visual Studio 2017 이상 (WinForms 개발 워크로드)

## 빌드 및 실행

Visual Studio에서 `FFT_Monitor_STM32.sln`을 열고 빌드(F5)하거나, MSBuild를 사용합니다:

```sh
msbuild FFT_Monitor_STM32.sln /p:Configuration=Release
```

빌드 결과물은 `bin\Release\FFT_Monitor_STM32.exe` 에 생성됩니다.

## 사용법

1. STM32 보드를 PC에 연결합니다.
2. 프로그램을 실행하고 **Refresh**로 COM 포트를 검색합니다.
3. 포트 / Baud Rate 등 통신 파라미터를 설정한 뒤 **OPEN**을 클릭합니다.
4. 수신 모드(ASCII / HEX)를 선택합니다. (프로토콜 파싱은 HEX 모드 기준)
5. **Start**를 눌러 Raw / FFT 차트 갱신을 시작하고, **Stop**으로 중지합니다.

## 알려진 문제 (Known Issues)

> ⚠️ **스레드 처리 안정성 문제 (가장 중요)**
>
> **시간이 지나면 데이터 수신이 멈추고, 그래프 갱신이 더 이상 반영되지 않는** 현상이 발생합니다.
> 원인은 시리얼 수신 이벤트 핸들러 내부의 블로킹 처리와, 수신 스레드·UI 타이머 간 비동기화 공유 배열 접근입니다.

### 문제 1. `ReadByte()` — 수신 콜백 스레드를 블로킹하고 모달 팝업까지 띄움 (`Form1.cs`)

```csharp
private int ReadByte()
{
    int trial = 50;
    while (trial > 0)                          // ← 최대 50번 반복
    {
        if (serialPort1.BytesToRead > 0)
        {
            return serialPort1.ReadByte();
        }
        Thread.Sleep(1);                       // ← 수신 콜백 스레드를 잠재움
        trial--;
    }
    if (trial == 0)
    {
        MessageBox.Show("데이터가 없습니다.");   // ← 수신 스레드에서 모달 창!
    }
    return 0;
}
```

### 문제 2. `serialPort1_DataReceived` — 위 `ReadByte()`를 바이트마다 반복 호출 + 비동기화 공유 배열 교체 (`Form1.cs`)

```csharp
private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
{
    ...
    sync[0] = this.ReadByte();     // 한 바이트마다 최대 50ms 블로킹 가능
    sync[1] = this.ReadByte();
    id[0]   = this.ReadByte();
    ...
    while (tot_size > 0)
    {
        DataBuffer_Raw.Add(this.ReadByte());    // 수백 바이트 × 블로킹 루프
        tot_size--;
    }
    RawIntDataArray = DataBuffer_Raw.ToArray();  // ← 동기화 없이 공유 배열 교체
}
```

### 문제 3. `timer1_Tick` / `timer2_Tick` — UI 스레드가 같은 공유 배열을 lock 없이 읽음 (`Form1.cs`)

```csharp
private void timer1_Tick(object sender, EventArgs e)
{
    chart1.Series["Series1"].Points.Clear();

    for (int i = 0; i < Samples; i++)
    {
        RawIntArray[i] = RawIntDataArray[i];   // ← 수신 스레드가 교체 중인 배열을 동시 읽기
    }
    for (int i = 0; i < Samples; i++)
    {
        chart1.Series["Series1"].Points.AddXY(i, RawIntArray[i]);
    }
}

private void timer2_Tick(object sender, EventArgs e)
{
    chart2.Series["Series1"].Points.Clear();

    for (int i = 0; i < Samples * 4; i++)
    {
        FFTByteArray[i] = (byte)FFTIntDataArray[i];   // ← 패킷 크기가 다르면 IndexOutOfRange
    }
    for (int i = 0; i < Samples; i++)
    {
        FFTFloatArray[i] = BitConverter.ToSingle(FFTByteArray, i * 4);
    }
    for (int i = 2; i < Samples / 2; i++)
    {
        chart2.Series["Series1"].Points.AddXY(i, FFTFloatArray[i]);
    }
}
```

`Samples(256)` 크기를 고정 가정하므로, 수신 패킷 크기가 다르거나 교체 도중 읽으면 예외가 발생하고, 한 번 예외가 나면 해당 타이머 틱이 죽어 그래프 갱신이 멈춥니다.

### 왜 시간이 지나면 멈추는가

1. **블로킹 누적 → 버퍼 오버런**: `DataReceived`는 직렬화된 단일 콜백 스레드에서 실행됩니다. 이 핸들러 안에서 `ReadByte()`가 `Thread.Sleep(1)`로 바이트마다 대기하면 한 패킷(수백 바이트)을 처리하는 동안 콜백이 길게 점유되고, 그 사이 들어오는 데이터가 드라이버 버퍼에 쌓여 오버런이 발생합니다. 결국 이벤트가 더 이상 정상적으로 올라오지 않습니다.
2. **모달 팝업이 수신 파이프라인을 정지**: 데이터가 잠깐 끊겨 `trial`이 0이 되면 수신 스레드에서 `MessageBox`가 떠, 사용자가 OK를 누르기 전까지 수신 전체가 멈춥니다. "어느 순간 수신이 멈춘다"의 직접적인 원인입니다.
3. **비동기화 공유 배열**: `RawIntDataArray` / `FFTIntDataArray`를 수신 스레드가 lock 없이 교체하고 UI 타이머(`timer1` / `timer2`)가 동시에 읽습니다. 교체 도중 읽으면 깨진 데이터나 예외가 발생하고, 예외가 한 번 나면 해당 타이머 틱이 죽어 그래프가 더 이상 갱신되지 않습니다.

### 개선 방향

- `DataReceived` 핸들러는 **읽기만 빠르게** 수행하고 즉시 반환 (`Thread.Sleep` / `MessageBox` 제거)
- 수신 데이터를 **Producer-Consumer 큐** 또는 별도 파서 스레드로 분리
- 공유 버퍼는 **`lock` 기반 보호** 또는 **더블 버퍼링**으로 보호

## 프로젝트 구조

```
FFT_Monitor_STM32/
├── Form1.cs              # 메인 로직 (시리얼 통신, 프로토콜 파싱, 차트 갱신)
├── Form1.Designer.cs     # UI 레이아웃
├── Program.cs            # 진입점
├── Properties/           # 어셈블리 정보, 리소스, 설정
└── FFT_Monitor_STM32.sln # 솔루션 파일
```
