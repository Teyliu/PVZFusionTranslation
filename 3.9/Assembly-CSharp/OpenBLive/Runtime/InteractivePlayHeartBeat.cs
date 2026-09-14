using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace OpenBLive.Runtime
{
	// Token: 0x02000E2A RID: 3626
	[Token(Token = "0x2000E2A")]
	public class InteractivePlayHeartBeat : IDisposable
	{
		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06004AD1 RID: 19153 RVA: 0x00170654 File Offset: 0x0016E854
		// (remove) Token: 0x06004AD2 RID: 19154 RVA: 0x00170684 File Offset: 0x0016E884
		[Token(Token = "0x14000027")]
		public event HeartBeatSucceed HeartBeatSucceed
		{
			[Token(Token = "0x6004AD1")]
			[Address(RVA = "0x8CD2D0", Offset = "0x8CB8D0", VA = "0x1808CD2D0")]
			[CompilerGenerated]
			add
			{
				HeartBeatSucceed heartBeatSucceed = this.HeartBeatSucceed;
				Delegate @delegate = Delegate.Combine(heartBeatSucceed, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != heartBeatSucceed)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6004AD2")]
			[Address(RVA = "0x8CD410", Offset = "0x8CBA10", VA = "0x1808CD410")]
			[CompilerGenerated]
			remove
			{
				HeartBeatSucceed heartBeatSucceed = this.HeartBeatSucceed;
				Delegate @delegate = Delegate.Remove(heartBeatSucceed, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != heartBeatSucceed)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06004AD3 RID: 19155 RVA: 0x001706B4 File Offset: 0x0016E8B4
		// (remove) Token: 0x06004AD4 RID: 19156 RVA: 0x001706E4 File Offset: 0x0016E8E4
		[Token(Token = "0x14000028")]
		public event HeartBeatError HeartBeatError
		{
			[Token(Token = "0x6004AD3")]
			[Address(RVA = "0x8CD230", Offset = "0x8CB830", VA = "0x1808CD230")]
			[CompilerGenerated]
			add
			{
				HeartBeatError heartBeatError = this.HeartBeatError;
				Delegate @delegate = Delegate.Combine(heartBeatError, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != heartBeatError)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6004AD4")]
			[Address(RVA = "0x8CD370", Offset = "0x8CB970", VA = "0x1808CD370")]
			[CompilerGenerated]
			remove
			{
				HeartBeatError heartBeatError = this.HeartBeatError;
				Delegate @delegate = Delegate.Remove(heartBeatError, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != heartBeatError)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x06004AD5 RID: 19157 RVA: 0x00170714 File Offset: 0x0016E914
		[Token(Token = "0x6004AD5")]
		[Address(RVA = "0x8CD0A0", Offset = "0x8CB6A0", VA = "0x1808CD0A0")]
		public InteractivePlayHeartBeat(string gameId, int time = 20000, [Optional] CancellationTokenSource cancellation)
		{
			this.m_GameIds = new string[] { gameId };
			this.m_Time = time;
			if (cancellation == 0)
			{
				CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			}
			this.m_Cancellation = cancellation;
			throw new NullReferenceException();
		}

		// Token: 0x06004AD6 RID: 19158 RVA: 0x0017075C File Offset: 0x0016E95C
		[Token(Token = "0x6004AD6")]
		[Address(RVA = "0x8CD190", Offset = "0x8CB790", VA = "0x1808CD190")]
		public InteractivePlayHeartBeat(string[] gameIds, int time = 20000, [Optional] CancellationTokenSource cancellation)
		{
			this.m_GameIds = gameIds;
			this.m_Time = time;
			if (cancellation == 0)
			{
				CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			}
			this.m_Cancellation = cancellation;
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x00170790 File Offset: 0x0016E990
		[Token(Token = "0x6004AD7")]
		[Address(RVA = "0x8CCEB0", Offset = "0x8CB4B0", VA = "0x1808CCEB0")]
		private Task HeartBeatTask()
		{
			Task task;
			return task;
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x001707A4 File Offset: 0x0016E9A4
		[Token(Token = "0x6004AD8")]
		[Address(RVA = "0x8CCF80", Offset = "0x8CB580", VA = "0x1808CCF80")]
		public void Start()
		{
			Task task;
			if (task.Status == TaskStatus.Created)
			{
				task.Start();
			}
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x001707CC File Offset: 0x0016E9CC
		[Token(Token = "0x6004AD9")]
		[Address(RVA = "0x8CD080", Offset = "0x8CB680", VA = "0x1808CD080")]
		public void Stop()
		{
			this.m_Cancellation.Cancel();
		}

		// Token: 0x06004ADA RID: 19162 RVA: 0x001707EC File Offset: 0x0016E9EC
		[Token(Token = "0x6004ADA")]
		[Address(RVA = "0x8CCE70", Offset = "0x8CB470", VA = "0x1808CCE70", Slot = "4")]
		public void Dispose()
		{
			this.m_Cancellation.Cancel();
			this.m_Cancellation.Dispose();
		}

		// Token: 0x04003500 RID: 13568
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003500")]
		private readonly CancellationTokenSource m_Cancellation;

		// Token: 0x04003501 RID: 13569
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4003501")]
		private readonly string[] m_GameIds;

		// Token: 0x04003502 RID: 13570
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003502")]
		private readonly int m_Time;
	}
}
