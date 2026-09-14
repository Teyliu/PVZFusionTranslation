using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000641 RID: 1601
[Token(Token = "0x2000641")]
public class CoachPaper : PaperZombie
{
	// Token: 0x06001E6A RID: 7786 RVA: 0x000A2980 File Offset: 0x000A0B80
	[Token(Token = "0x6001E6A")]
	[Address(RVA = "0x534700", Offset = "0x532D00", VA = "0x180534700", Slot = "64")]
	protected override void SecondArmorBroken()
	{
	}

	// Token: 0x06001E6B RID: 7787 RVA: 0x000A2990 File Offset: 0x000A0B90
	[Token(Token = "0x6001E6B")]
	[Address(RVA = "0x539790", Offset = "0x537D90", VA = "0x180539790", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06001E6C RID: 7788 RVA: 0x000A29D0 File Offset: 0x000A0BD0
	[Token(Token = "0x6001E6C")]
	[Address(RVA = "0x5396D0", Offset = "0x537CD0", VA = "0x1805396D0", Slot = "74")]
	public override void AngrySound()
	{
		base.AngrySound();
		CreateZombie instance = CreateZombie.Instance;
		int theZombieRow = this.theZombieRow;
		ulong num;
		Zombie zombie = instance.SetZombie(theZombieRow, (ZombieType)((uint)3), 9.9f, num != 0UL);
		float theOriginSpeed = zombie.theOriginSpeed;
		zombie.theOriginSpeed = theOriginSpeed;
	}

	// Token: 0x06001E6D RID: 7789 RVA: 0x000A2A1C File Offset: 0x000A0C1C
	[Token(Token = "0x6001E6D")]
	[Address(RVA = "0x539830", Offset = "0x537E30", VA = "0x180539830", Slot = "18")]
	protected override void ZombieUpdate()
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
				while (num == 0)
				{
				}
				while (num == 0)
				{
				}
				float deltaTime = Time.deltaTime;
				int num4 = 0;
				int num5 = 0;
				Transform transform;
				transform.Translate(deltaTime, (float)num5, (float)num4);
			}
		}
		while (num3 != 0);
	}

	// Token: 0x06001E6E RID: 7790 RVA: 0x000A2A78 File Offset: 0x000A0C78
	[Token(Token = "0x6001E6E")]
	[Address(RVA = "0x534450", Offset = "0x532A50", VA = "0x180534450")]
	public CoachPaper()
	{
	}
}
