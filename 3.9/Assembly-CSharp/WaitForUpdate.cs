using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000006 RID: 6
[Token(Token = "0x2000006")]
public class WaitForUpdate : CustomYieldInstruction
{
	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000017 RID: 23 RVA: 0x00002338 File Offset: 0x00000538
	[Token(Token = "0x17000007")]
	public override bool keepWaiting
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "7")]
		get
		{
			return false;
		}
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002348 File Offset: 0x00000548
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x4007C0", Offset = "0x3FEDC0", VA = "0x1804007C0")]
	public WaitForUpdate.MainThreadAwaiter GetAwaiter()
	{
		WaitForUpdate.MainThreadAwaiter mainThreadAwaiter;
		mainThreadAwaiter.GetResult();
		WaitForUpdate.<CoroutineWrapper>d__4 <CoroutineWrapper>d__;
		<CoroutineWrapper>d__.System.IDisposable.Dispose();
		<CoroutineWrapper>d__.<>1__state = (int)((ulong)0L);
		<CoroutineWrapper>d__.theWorker = this;
		<CoroutineWrapper>d__.awaiter = mainThreadAwaiter;
		MainThreadUtil.<>c__DisplayClass9_0 CS$<>8__locals1 = new MainThreadUtil.<>c__DisplayClass9_0();
		CS$<>8__locals1.waitForUpdate = <CoroutineWrapper>d__;
		SynchronizationContext <synchronizationContext>k__BackingField = MainThreadUtil.<synchronizationContext>k__BackingField;
		SendOrPostCallback sendOrPostCallback = delegate(object _)
		{
			MainThreadUtil <Instance>k__BackingField = MainThreadUtil.<Instance>k__BackingField;
			IEnumerator waitForUpdate = CS$<>8__locals1.waitForUpdate;
			Coroutine coroutine = <Instance>k__BackingField.StartCoroutine(waitForUpdate);
		};
		int num = 0;
		<synchronizationContext>k__BackingField.Post(sendOrPostCallback, num);
		return mainThreadAwaiter;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000023B0 File Offset: 0x000005B0
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x400730", Offset = "0x3FED30", VA = "0x180400730")]
	public static IEnumerator CoroutineWrapper(IEnumerator theWorker, WaitForUpdate.MainThreadAwaiter awaiter)
	{
		WaitForUpdate.<CoroutineWrapper>d__4 <CoroutineWrapper>d__;
		<CoroutineWrapper>d__.System.IDisposable.Dispose();
		<CoroutineWrapper>d__.<>1__state = (int)((ulong)0L);
		<CoroutineWrapper>d__.theWorker = theWorker;
		<CoroutineWrapper>d__.awaiter = awaiter;
		return null;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x000023DC File Offset: 0x000005DC
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
	public WaitForUpdate()
	{
	}

	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public class MainThreadAwaiter : INotifyCompletion
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000023F0 File Offset: 0x000005F0
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002404 File Offset: 0x00000604
		[Token(Token = "0x17000008")]
		public bool IsCompleted
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x3FB4D0", Offset = "0x3F9AD0", VA = "0x1803FB4D0")]
			get;
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x3FB4E0", Offset = "0x3F9AE0", VA = "0x1803FB4E0")]
			set;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20")]
		public void GetResult()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002428 File Offset: 0x00000628
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x3FB490", Offset = "0x3F9A90", VA = "0x1803FB490")]
		public void Complete()
		{
			this.<IsCompleted>k__BackingField = true;
			if (this.continuation != 0)
			{
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x3FB4B0", Offset = "0x3F9AB0", VA = "0x1803FB4B0", Slot = "4")]
		void INotifyCompletion.OnCompleted(Action continuation)
		{
			this.continuation = continuation;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public MainThreadAwaiter()
		{
			this.GetResult();
		}

		// Token: 0x04000008 RID: 8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000008")]
		private Action continuation;
	}
}
