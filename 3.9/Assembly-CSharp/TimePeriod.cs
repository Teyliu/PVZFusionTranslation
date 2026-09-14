using System;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;

// Token: 0x02000A21 RID: 2593
[Token(Token = "0x2000A21")]
public static class TimePeriod
{
	// Token: 0x0600353D RID: 13629 RVA: 0x0011A96C File Offset: 0x00118B6C
	[Token(Token = "0x600353D")]
	[Address(RVA = "0x7841C0", Offset = "0x7827C0", VA = "0x1807841C0")]
	public static void StartPeriod(float interval, CancellationToken cancellationToken, [Optional] Action OnStart, [Optional] Action OnCycle, [Optional] Action OnEnd, bool immediately = false, int cycleCount = 1)
	{
	}
}
