using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200033A RID: 826
[Token(Token = "0x200033A")]
public class CherryChomper : Chomper
{
	// Token: 0x06000F18 RID: 3864 RVA: 0x00057B3C File Offset: 0x00055D3C
	[Token(Token = "0x6000F18")]
	[Address(RVA = "0x458AD0", Offset = "0x4570D0", VA = "0x180458AD0", Slot = "74")]
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

	// Token: 0x06000F19 RID: 3865 RVA: 0x00057BAC File Offset: 0x00055DAC
	[Token(Token = "0x6000F19")]
	[Address(RVA = "0x458C10", Offset = "0x457210", VA = "0x180458C10")]
	public CherryChomper()
	{
	}
}
