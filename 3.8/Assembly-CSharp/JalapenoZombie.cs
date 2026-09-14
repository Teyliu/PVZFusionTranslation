using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000692 RID: 1682
[Token(Token = "0x2000692")]
public class JalapenoZombie : Zombie
{
	// Token: 0x0600207D RID: 8317 RVA: 0x000AC1D8 File Offset: 0x000AA3D8
	[Token(Token = "0x600207D")]
	[Address(RVA = "0x557830", Offset = "0x555E30", VA = "0x180557830", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(13.22f, 22.68f);
		this.attributeCountDown = num;
	}

	// Token: 0x0600207E RID: 8318 RVA: 0x000AC204 File Offset: 0x000AA404
	[Token(Token = "0x600207E")]
	[Address(RVA = "0x5577A0", Offset = "0x555DA0", VA = "0x1805577A0", Slot = "23")]
	protected override void AttributeEvent()
	{
		base.ZombieUpdate();
		base.Die(2);
		BoardAction boardAction = this.board.boardAction;
	}

	// Token: 0x0600207F RID: 8319 RVA: 0x000AC234 File Offset: 0x000AA434
	[Token(Token = "0x600207F")]
	[Address(RVA = "0x54FE70", Offset = "0x54E470", VA = "0x18054FE70")]
	public JalapenoZombie()
	{
	}
}
