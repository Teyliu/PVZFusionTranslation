using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000689 RID: 1673
[Token(Token = "0x2000689")]
public class JackboxJumpZombie : SuperPogoZombie
{
	// Token: 0x06002038 RID: 8248 RVA: 0x000AA9C8 File Offset: 0x000A8BC8
	[Token(Token = "0x6002038")]
	[Address(RVA = "0x552A60", Offset = "0x551060", VA = "0x180552A60", Slot = "28")]
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
			if (zombie.read == num)
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

	// Token: 0x06002039 RID: 8249 RVA: 0x000AAA4C File Offset: 0x000A8C4C
	[Token(Token = "0x6002039")]
	[Address(RVA = "0x5529B0", Offset = "0x550FB0", VA = "0x1805529B0", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Transform transform = arm.transform;
		int num = 0;
		Sprite sprite = transform.GetChild(num).GetComponent<SpriteRenderer>().sprite;
		component.sprite = sprite;
	}

	// Token: 0x0600203A RID: 8250 RVA: 0x000AAA88 File Offset: 0x000A8C88
	[Token(Token = "0x600203A")]
	[Address(RVA = "0x552CB0", Offset = "0x5512B0", VA = "0x180552CB0")]
	public JackboxJumpZombie()
	{
	}
}
