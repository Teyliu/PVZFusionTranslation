using System;
using Cpp2IlInjected;
using UnityEngine.Events;

// Token: 0x020009DD RID: 2525
[Token(Token = "0x20009DD")]
public class EventInfo : IEventInfo
{
	// Token: 0x0600335F RID: 13151 RVA: 0x0010D964 File Offset: 0x0010BB64
	[Token(Token = "0x600335F")]
	[Address(RVA = "0x74AA70", Offset = "0x749070", VA = "0x18074AA70")]
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

	// Token: 0x04002530 RID: 9520
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002530")]
	public UnityAction actions;
}
