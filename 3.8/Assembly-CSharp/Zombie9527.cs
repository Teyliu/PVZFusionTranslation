using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000724 RID: 1828
[Token(Token = "0x2000724")]
public class Zombie9527 : Zombie
{
	// Token: 0x06002511 RID: 9489 RVA: 0x000C2E00 File Offset: 0x000C1000
	[Token(Token = "0x6002511")]
	[Address(RVA = "0x5CDB80", Offset = "0x5CC180", VA = "0x1805CDB80", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06002512 RID: 9490 RVA: 0x000C2E40 File Offset: 0x000C1040
	[Token(Token = "0x6002512")]
	[Address(RVA = "0x5CD950", Offset = "0x5CBF50", VA = "0x1805CD950", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num4;
		do
		{
			int num = 0;
			base.BodyTakeDamage(theDamage);
			List<Transform> changeSprites = this.changeSprites;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				int num3 = 0;
				GameObject gameObject;
				Lawnf.ChangeSprite((float)num4, (float)num3, gameObject);
			}
		}
		while (num4 != (ulong)0L);
		num4 += num4;
	}

	// Token: 0x06002513 RID: 9491 RVA: 0x000C2EA4 File Offset: 0x000C10A4
	[Token(Token = "0x6002513")]
	[Address(RVA = "0x5CDC20", Offset = "0x5CC220", VA = "0x1805CDC20")]
	public Zombie9527()
	{
	}

	// Token: 0x0400128E RID: 4750
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400128E")]
	private bool changeRow;
}
