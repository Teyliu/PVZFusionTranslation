using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200032A RID: 810
[Token(Token = "0x200032A")]
public class CherryChomper : Chomper
{
	// Token: 0x06000ECE RID: 3790 RVA: 0x00056ABC File Offset: 0x00054CBC
	[Token(Token = "0x6000ECE")]
	[Address(RVA = "0x4223F0", Offset = "0x4209F0", VA = "0x1804223F0", Slot = "74")]
	protected override void Chomp(Zombie zombie)
	{
		zombie.Die(2);
		float swallowMaxCountDown = this.swallowMaxCountDown;
		base.AttributeCountdown = swallowMaxCountDown;
		this.canToChew = true;
		this.targetZombie = (ulong)0L;
		this.theStatus = (PlantStatus)((ulong)22L);
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
	}

	// Token: 0x06000ECF RID: 3791 RVA: 0x00056B2C File Offset: 0x00054D2C
	[Token(Token = "0x6000ECF")]
	[Address(RVA = "0x41A920", Offset = "0x418F20", VA = "0x18041A920")]
	public CherryChomper()
	{
		this.swallowMaxCountDown = 40f;
		base..ctor();
	}
}
