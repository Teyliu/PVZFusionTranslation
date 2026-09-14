using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000677 RID: 1655
[Token(Token = "0x2000677")]
public class CoachPaper : PaperZombie
{
	// Token: 0x06001F6C RID: 8044 RVA: 0x000A70CC File Offset: 0x000A52CC
	[Token(Token = "0x6001F6C")]
	[Address(RVA = "0x58B3E0", Offset = "0x5899E0", VA = "0x18058B3E0", Slot = "66")]
	protected override void SecondArmorBroken()
	{
	}

	// Token: 0x06001F6D RID: 8045 RVA: 0x000A70DC File Offset: 0x000A52DC
	[Token(Token = "0x6001F6D")]
	[Address(RVA = "0x59BD60", Offset = "0x59A360", VA = "0x18059BD60", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06001F6E RID: 8046 RVA: 0x000A711C File Offset: 0x000A531C
	[Token(Token = "0x6001F6E")]
	[Address(RVA = "0x59BCA0", Offset = "0x59A2A0", VA = "0x18059BCA0", Slot = "76")]
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

	// Token: 0x06001F6F RID: 8047 RVA: 0x000A7168 File Offset: 0x000A5368
	[Token(Token = "0x6001F6F")]
	[Address(RVA = "0x59BE00", Offset = "0x59A400", VA = "0x18059BE00", Slot = "19")]
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

	// Token: 0x06001F70 RID: 8048 RVA: 0x000A71C4 File Offset: 0x000A53C4
	[Token(Token = "0x6001F70")]
	[Address(RVA = "0x58B130", Offset = "0x589730", VA = "0x18058B130")]
	public CoachPaper()
	{
	}
}
