using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200077C RID: 1916
[Token(Token = "0x200077C")]
[Serializable]
public class PeriodTimerManager
{
	// Token: 0x060026BB RID: 9915 RVA: 0x000CE934 File Offset: 0x000CCB34
	[Token(Token = "0x60026BB")]
	[Address(RVA = "0x5E6840", Offset = "0x5E4E40", VA = "0x1805E6840")]
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

	// Token: 0x060026BC RID: 9916 RVA: 0x000CE9D4 File Offset: 0x000CCBD4
	[Token(Token = "0x60026BC")]
	[Address(RVA = "0x5E6970", Offset = "0x5E4F70", VA = "0x1805E6970")]
	public PeriodTimerManager()
	{
		List<PeriodTimerManager.Timer> list = new List();
		this.timers = list;
		base..ctor();
	}

	// Token: 0x0400147E RID: 5246
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400147E")]
	private readonly List<PeriodTimerManager.Timer> timers;

	// Token: 0x0200077D RID: 1917
	[Token(Token = "0x200077D")]
	[Serializable]
	private class Timer : IDisposable
	{
		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060026BD RID: 9917 RVA: 0x000CE9F4 File Offset: 0x000CCBF4
		[Token(Token = "0x1700018B")]
		public Action Action
		{
			[Token(Token = "0x60026BD")]
			[Address(RVA = "0x3C9940", Offset = "0x3C7F40", VA = "0x1803C9940")]
			get
			{
				return this.action;
			}
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x000CEA08 File Offset: 0x000CCC08
		[Token(Token = "0x60026BE")]
		[Address(RVA = "0x5EF420", Offset = "0x5EDA20", VA = "0x1805EF420")]
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

		// Token: 0x060026BF RID: 9919 RVA: 0x000CEA44 File Offset: 0x000CCC44
		[Token(Token = "0x60026BF")]
		[Address(RVA = "0x5EF3B0", Offset = "0x5ED9B0", VA = "0x1805EF3B0")]
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

		// Token: 0x060026C0 RID: 9920 RVA: 0x000CEAA0 File Offset: 0x000CCCA0
		[Token(Token = "0x60026C0")]
		[Address(RVA = "0x5EF380", Offset = "0x5ED980", VA = "0x1805EF380", Slot = "4")]
		public void Dispose()
		{
			if (!this.disposed)
			{
				this.action = (ulong)0L;
				this.end = true;
			}
		}

		// Token: 0x0400147F RID: 5247
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400147F")]
		public float Interval;

		// Token: 0x04001480 RID: 5248
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4001480")]
		public float RemainingTime;

		// Token: 0x04001481 RID: 5249
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001481")]
		private Action action;

		// Token: 0x04001482 RID: 5250
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001482")]
		public bool cycle;

		// Token: 0x04001483 RID: 5251
		[FieldOffset(Offset = "0x21")]
		[Token(Token = "0x4001483")]
		public bool end;

		// Token: 0x04001484 RID: 5252
		[FieldOffset(Offset = "0x22")]
		[Token(Token = "0x4001484")]
		private bool disposed;
	}
}
