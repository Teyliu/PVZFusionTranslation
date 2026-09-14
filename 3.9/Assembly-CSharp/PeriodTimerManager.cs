using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007B5 RID: 1973
[Token(Token = "0x20007B5")]
[Serializable]
public class PeriodTimerManager
{
	// Token: 0x060027EA RID: 10218 RVA: 0x000D3964 File Offset: 0x000D1B64
	[Token(Token = "0x60027EA")]
	[Address(RVA = "0x649B80", Offset = "0x648180", VA = "0x180649B80")]
	public void OnUpdate()
	{
		int size = this.timers._size;
		int num = size - 1;
		if (size > 0)
		{
			PeriodTimerManager.Timer timer = this.timers[num];
			if (!timer.disposed)
			{
				float remainingTime = timer.RemainingTime;
				float deltaTime = Time.deltaTime;
				timer.RemainingTime = remainingTime;
				Action action = timer.action;
				float interval = timer.Interval;
				timer.RemainingTime = interval;
				if (action != 0)
				{
				}
				if (!timer.cycle)
				{
					timer.end = true;
				}
			}
			if (timer.end)
			{
				this.timers.RemoveAt(num);
			}
		}
	}

	// Token: 0x060027EB RID: 10219 RVA: 0x000D3A04 File Offset: 0x000D1C04
	[Token(Token = "0x60027EB")]
	[Address(RVA = "0x649CB0", Offset = "0x6482B0", VA = "0x180649CB0")]
	public PeriodTimerManager()
	{
		List<PeriodTimerManager.Timer> list = new List();
		this.timers = list;
		base..ctor();
	}

	// Token: 0x0400155A RID: 5466
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400155A")]
	private readonly List<PeriodTimerManager.Timer> timers;

	// Token: 0x020007B6 RID: 1974
	[Token(Token = "0x20007B6")]
	[Serializable]
	private class Timer : IDisposable
	{
		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060027EC RID: 10220 RVA: 0x000D3A24 File Offset: 0x000D1C24
		[Token(Token = "0x170001D5")]
		public Action Action
		{
			[Token(Token = "0x60027EC")]
			[Address(RVA = "0x3FDA60", Offset = "0x3FC060", VA = "0x1803FDA60")]
			get
			{
				return this.action;
			}
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x000D3A38 File Offset: 0x000D1C38
		[Token(Token = "0x60027ED")]
		[Address(RVA = "0x652A00", Offset = "0x651000", VA = "0x180652A00")]
		public Timer(float interval, Action action, bool startImmediately, bool cycle)
		{
			this.Interval = interval;
			this.action = action;
			if (startImmediately)
			{
				int num = 0;
				this.RemainingTime = (float)num;
			}
			this.RemainingTime = interval;
			this.cycle = false;
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x000D3A74 File Offset: 0x000D1C74
		[Token(Token = "0x60027EE")]
		[Address(RVA = "0x652990", Offset = "0x650F90", VA = "0x180652990")]
		public void OnUpdate()
		{
			if (!this.disposed)
			{
				float remainingTime = this.RemainingTime;
				float deltaTime = Time.deltaTime;
				this.RemainingTime = remainingTime;
				Action action = this.action;
				float interval = this.Interval;
				this.RemainingTime = interval;
				if (action != 0)
				{
				}
				if (!this.cycle)
				{
					this.end = true;
				}
			}
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x000D3AD0 File Offset: 0x000D1CD0
		[Token(Token = "0x60027EF")]
		[Address(RVA = "0x652960", Offset = "0x650F60", VA = "0x180652960", Slot = "4")]
		public void Dispose()
		{
			if (!this.disposed)
			{
				this.action = (ulong)0L;
				this.end = true;
			}
		}

		// Token: 0x0400155B RID: 5467
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400155B")]
		public float Interval;

		// Token: 0x0400155C RID: 5468
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400155C")]
		public float RemainingTime;

		// Token: 0x0400155D RID: 5469
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400155D")]
		private Action action;

		// Token: 0x0400155E RID: 5470
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400155E")]
		public bool cycle;

		// Token: 0x0400155F RID: 5471
		[FieldOffset(Offset = "0x21")]
		[Token(Token = "0x400155F")]
		public bool end;

		// Token: 0x04001560 RID: 5472
		[FieldOffset(Offset = "0x22")]
		[Token(Token = "0x4001560")]
		private bool disposed;
	}
}
