using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000682 RID: 1666
[Token(Token = "0x2000682")]
public class DoomZombie : Zombie
{
	// Token: 0x06001F9F RID: 8095 RVA: 0x000A8114 File Offset: 0x000A6314
	[Token(Token = "0x6001F9F")]
	[Address(RVA = "0x59F4A0", Offset = "0x59DAA0", VA = "0x18059F4A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		int num = global::UnityEngine.Random.Range(0, 100);
		float num2 = global::UnityEngine.Random.Range(4.4f, 7.54f);
		this.attributeCountDown = num2;
	}

	// Token: 0x06001FA0 RID: 8096 RVA: 0x000A8148 File Offset: 0x000A6348
	[Token(Token = "0x6001FA0")]
	[Address(RVA = "0x59F3E0", Offset = "0x59D9E0", VA = "0x18059F3E0", Slot = "24")]
	protected override void AttributeEvent()
	{
		base.ZombieUpdate();
		base.Die(2);
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
	}

	// Token: 0x06001FA1 RID: 8097 RVA: 0x000A8180 File Offset: 0x000A6380
	[Token(Token = "0x6001FA1")]
	[Address(RVA = "0x59F500", Offset = "0x59DB00", VA = "0x18059F500")]
	public DoomZombie()
	{
	}
}
