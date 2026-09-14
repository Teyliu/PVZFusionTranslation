using System;
using Cpp2IlInjected;
using UnityEngine.Events;

// Token: 0x020009DE RID: 2526
[Token(Token = "0x20009DE")]
public class EventInfo<T> : IEventInfo
{
	// Token: 0x06003360 RID: 13152 RVA: 0x0010D9AC File Offset: 0x0010BBAC
	[Token(Token = "0x6003360")]
	[Address(RVA = "0x144E3F0", Offset = "0x144C9F0", VA = "0x18144E3F0")]
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

	// Token: 0x04002531 RID: 9521
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4002531")]
	public UnityAction actions;
}
