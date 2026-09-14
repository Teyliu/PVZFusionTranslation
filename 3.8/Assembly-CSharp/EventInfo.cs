using System;
using Cpp2IlInjected;
using UnityEngine.Events;

// Token: 0x020009A1 RID: 2465
[Token(Token = "0x20009A1")]
public class EventInfo : IEventInfo
{
	// Token: 0x0600322B RID: 12843 RVA: 0x00108B90 File Offset: 0x00106D90
	[Token(Token = "0x600322B")]
	[Address(RVA = "0x6E55C0", Offset = "0x6E3BC0", VA = "0x1806E55C0")]
	public EventInfo(UnityAction action)
	{
		Delegate @delegate = Delegate.Combine(this.actions, action);
		int num = 0;
		if (@delegate == 0)
		{
			this.actions = num;
		}
		if (@delegate != 0)
		{
			this.actions = @delegate;
			if (@delegate == 0)
			{
				throw new InvalidCastException();
			}
		}
		throw new InvalidCastException();
	}

	// Token: 0x0400241F RID: 9247
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400241F")]
	public UnityAction actions;
}
