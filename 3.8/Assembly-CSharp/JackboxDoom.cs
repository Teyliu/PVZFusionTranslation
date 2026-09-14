using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000311 RID: 785
[Token(Token = "0x2000311")]
public class JackboxDoom : DoomShroom
{
	// Token: 0x06000E40 RID: 3648 RVA: 0x00051FE4 File Offset: 0x000501E4
	[Token(Token = "0x6000E40")]
	[Address(RVA = "0x403BB0", Offset = "0x4021B0", VA = "0x180403BB0", Slot = "69")]
	public override void AnimExplode()
	{
		int num = 0;
		base.Die((Plant.DieReason)num);
		BoardAction boardAction = this.board.boardAction;
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x06000E41 RID: 3649 RVA: 0x00052020 File Offset: 0x00050220
	[Token(Token = "0x6000E41")]
	[Address(RVA = "0x403CF0", Offset = "0x4022F0", VA = "0x180403CF0")]
	private void ExplodeAction(Zombie zombie)
	{
		int num = 0;
		int num2 = 0;
		if (zombie == num2 || zombie.theStatus == ZombieStatus.Dying || (zombie.beforeDying ? 1 : 0) != num)
		{
			Transform axis = zombie.axis;
			Vector3 vector;
			float z = vector.z;
		}
	}

	// Token: 0x06000E42 RID: 3650 RVA: 0x00052064 File Offset: 0x00050264
	[Token(Token = "0x6000E42")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public JackboxDoom()
	{
	}
}
