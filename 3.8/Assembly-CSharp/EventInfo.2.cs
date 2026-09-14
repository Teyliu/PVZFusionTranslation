using System;
using Cpp2IlInjected;
using UnityEngine.Events;

// Token: 0x020009A2 RID: 2466
[Token(Token = "0x20009A2")]
public class EventInfo<T> : IEventInfo
{
	// Token: 0x0600322C RID: 12844 RVA: 0x00108BD8 File Offset: 0x00106DD8
	[Token(Token = "0x600322C")]
	[Address(RVA = "0x11F4B10", Offset = "0x11F3110", VA = "0x1811F4B10")]
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

	// Token: 0x04002420 RID: 9248
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4002420")]
	public UnityAction actions;
}
