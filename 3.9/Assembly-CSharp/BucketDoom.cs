using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200030B RID: 779
[Token(Token = "0x200030B")]
public class BucketDoom : DoomShroom
{
	// Token: 0x06000E38 RID: 3640 RVA: 0x00051A8C File Offset: 0x0004FC8C
	[Token(Token = "0x6000E38")]
	[Address(RVA = "0x444660", Offset = "0x442C60", VA = "0x180444660", Slot = "68")]
	public override void AnimExplode()
	{
		int num = 0;
		base.Die((Plant.DieReason)num);
		BoardAction boardAction = this.board.boardAction;
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x06000E39 RID: 3641 RVA: 0x00051AC8 File Offset: 0x0004FCC8
	[Token(Token = "0x6000E39")]
	[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
	private void ExplodeAction(Zombie zombie)
	{
		int num = 0;
		bool flag = zombie == num;
		if (flag || zombie.theStatus == ZombieStatus.Dying || zombie.beforeDying != flag)
		{
			GameObject gameObject = Resources.Load<GameObject>("Items/Bucket");
			Transform axis = this.axis;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = this.board.transform;
		}
	}

	// Token: 0x06000E3A RID: 3642 RVA: 0x00051B24 File Offset: 0x0004FD24
	[Token(Token = "0x6000E3A")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public BucketDoom()
	{
	}
}
