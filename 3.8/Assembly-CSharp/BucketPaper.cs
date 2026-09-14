using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000635 RID: 1589
[Token(Token = "0x2000635")]
public class BucketPaper : PaperZombie
{
	// Token: 0x06001E1E RID: 7710 RVA: 0x000A0F34 File Offset: 0x0009F134
	[Token(Token = "0x6001E1E")]
	[Address(RVA = "0x534730", Offset = "0x532D30", VA = "0x180534730", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.ReinforcePaper(50f);
	}

	// Token: 0x06001E1F RID: 7711 RVA: 0x000A0F54 File Offset: 0x0009F154
	[Token(Token = "0x6001E1F")]
	[Address(RVA = "0x534700", Offset = "0x532D00", VA = "0x180534700", Slot = "64")]
	protected override void SecondArmorBroken()
	{
	}

	// Token: 0x06001E20 RID: 7712 RVA: 0x000A0F64 File Offset: 0x0009F164
	[Token(Token = "0x6001E20")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06001E21 RID: 7713 RVA: 0x000A0F74 File Offset: 0x0009F174
	[Token(Token = "0x6001E21")]
	[Address(RVA = "0x5344A0", Offset = "0x532AA0", VA = "0x1805344A0", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06001E22 RID: 7714 RVA: 0x000A0FB4 File Offset: 0x0009F1B4
	[Token(Token = "0x6001E22")]
	[Address(RVA = "0x534460", Offset = "0x532A60", VA = "0x180534460", Slot = "74")]
	public override void AngrySound()
	{
		base.AngrySound();
		this.ReinforcePaper(100f);
	}

	// Token: 0x06001E23 RID: 7715 RVA: 0x000A0FD4 File Offset: 0x0009F1D4
	[Token(Token = "0x6001E23")]
	[Address(RVA = "0x534540", Offset = "0x532B40", VA = "0x180534540")]
	private void ReinforcePaper(float value)
	{
		int num3;
		do
		{
			int num = 0;
			int num2 = 0;
			List<Zombie> zombiesByRow = Lawnf.GetZombiesByRow(this.theZombieRow, num2 != 0);
			num3 = 0;
			bool flag;
			if (flag)
			{
				if (num != 0)
				{
				}
				while (flag)
				{
				}
				while (!flag)
				{
				}
			}
		}
		while (num3 != 0);
	}

	// Token: 0x06001E24 RID: 7716 RVA: 0x000A101C File Offset: 0x0009F21C
	[Token(Token = "0x6001E24")]
	[Address(RVA = "0x534450", Offset = "0x532A50", VA = "0x180534450")]
	public BucketPaper()
	{
	}
}
