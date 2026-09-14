using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002FB RID: 763
[Token(Token = "0x20002FB")]
public class BucketDoom : DoomShroom
{
	// Token: 0x06000DF0 RID: 3568 RVA: 0x00050B84 File Offset: 0x0004ED84
	[Token(Token = "0x6000DF0")]
	[Address(RVA = "0x400710", Offset = "0x3FED10", VA = "0x180400710", Slot = "69")]
	public override void AnimExplode()
	{
		int num = 0;
		base.Die((Plant.DieReason)num);
		BoardAction boardAction = this.board.boardAction;
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x06000DF1 RID: 3569 RVA: 0x00050BC0 File Offset: 0x0004EDC0
	[Token(Token = "0x6000DF1")]
	[Address(RVA = "0x400850", Offset = "0x3FEE50", VA = "0x180400850")]
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

	// Token: 0x06000DF2 RID: 3570 RVA: 0x00050C1C File Offset: 0x0004EE1C
	[Token(Token = "0x6000DF2")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public BucketDoom()
	{
	}
}
