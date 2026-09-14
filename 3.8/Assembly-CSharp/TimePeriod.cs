using System;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;

// Token: 0x020009E5 RID: 2533
[Token(Token = "0x20009E5")]
public static class TimePeriod
{
	// Token: 0x06003409 RID: 13321 RVA: 0x00115A14 File Offset: 0x00113C14
	[Token(Token = "0x6003409")]
	[Address(RVA = "0x71EC40", Offset = "0x71D240", VA = "0x18071EC40")]
	public static void StartPeriod(float interval, CancellationToken cancellationToken, [Optional] Action OnStart, [Optional] Action OnCycle, [Optional] Action OnEnd, bool immediately = false, int cycleCount = 1)
	{
	}
}
