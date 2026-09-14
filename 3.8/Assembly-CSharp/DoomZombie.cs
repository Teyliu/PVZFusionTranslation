using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200064C RID: 1612
[Token(Token = "0x200064C")]
public class DoomZombie : Zombie
{
	// Token: 0x06001E9D RID: 7837 RVA: 0x000A39C8 File Offset: 0x000A1BC8
	[Token(Token = "0x6001E9D")]
	[Address(RVA = "0x53CEB0", Offset = "0x53B4B0", VA = "0x18053CEB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		int num = global::UnityEngine.Random.Range(0, 100);
		float num2 = global::UnityEngine.Random.Range(4.4f, 7.54f);
		this.attributeCountDown = num2;
	}

	// Token: 0x06001E9E RID: 7838 RVA: 0x000A39FC File Offset: 0x000A1BFC
	[Token(Token = "0x6001E9E")]
	[Address(RVA = "0x53CDF0", Offset = "0x53B3F0", VA = "0x18053CDF0", Slot = "23")]
	protected override void AttributeEvent()
	{
		base.ZombieUpdate();
		base.Die(2);
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
	}

	// Token: 0x06001E9F RID: 7839 RVA: 0x000A3A34 File Offset: 0x000A1C34
	[Token(Token = "0x6001E9F")]
	[Address(RVA = "0x53CF10", Offset = "0x53B510", VA = "0x18053CF10")]
	public DoomZombie()
	{
	}
}
