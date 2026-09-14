using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000321 RID: 801
[Token(Token = "0x2000321")]
public class JackboxDoom : DoomShroom
{
	// Token: 0x06000E89 RID: 3721 RVA: 0x00052F24 File Offset: 0x00051124
	[Token(Token = "0x6000E89")]
	[Address(RVA = "0x447DE0", Offset = "0x4463E0", VA = "0x180447DE0", Slot = "68")]
	public override void AnimExplode()
	{
		int num = 0;
		base.Die((Plant.DieReason)num);
		BoardAction boardAction = this.board.boardAction;
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x06000E8A RID: 3722 RVA: 0x00052F60 File Offset: 0x00051160
	[Token(Token = "0x6000E8A")]
	[Address(RVA = "0x447F20", Offset = "0x446520", VA = "0x180447F20")]
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

	// Token: 0x06000E8B RID: 3723 RVA: 0x00052FA4 File Offset: 0x000511A4
	[Token(Token = "0x6000E8B")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public JackboxDoom()
	{
	}
}
