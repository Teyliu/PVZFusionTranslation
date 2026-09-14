using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006BF RID: 1727
[Token(Token = "0x20006BF")]
public class JackboxJumpZombie : SuperPogoZombie
{
	// Token: 0x0600213A RID: 8506 RVA: 0x000AF2F0 File Offset: 0x000AD4F0
	[Token(Token = "0x600213A")]
	[Address(RVA = "0x5B6600", Offset = "0x5B4C00", VA = "0x1805B6600", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		if (reason == 0)
		{
		}
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)8)))
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			int num = 0;
			Transform axis2 = this.axis;
			CreateZombie instance = CreateZombie.Instance;
			Zombie zombie;
			if (zombie.takeDmgMultiplier == (float)num)
			{
			}
			Transform axis3 = this.axis;
			CreateZombie instance2 = CreateZombie.Instance;
			int num2 = 0;
			Zombie zombie2;
			if (zombie2 != num2)
			{
				zombie2.revived = true;
			}
			Corner targetCorner = this.targetCorner;
			zombie2.targetCorner = targetCorner;
		}
	}

	// Token: 0x0600213B RID: 8507 RVA: 0x000AF374 File Offset: 0x000AD574
	[Token(Token = "0x600213B")]
	[Address(RVA = "0x5B6550", Offset = "0x5B4B50", VA = "0x1805B6550", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Transform transform = arm.transform;
		int num = 0;
		Sprite sprite = transform.GetChild(num).GetComponent<SpriteRenderer>().sprite;
		component.sprite = sprite;
	}

	// Token: 0x0600213C RID: 8508 RVA: 0x000AF3B0 File Offset: 0x000AD5B0
	[Token(Token = "0x600213C")]
	[Address(RVA = "0x5B6850", Offset = "0x5B4E50", VA = "0x1805B6850")]
	public JackboxJumpZombie()
	{
	}
}
