using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000628 RID: 1576
[Token(Token = "0x2000628")]
public class BlackFootballZombie : TallNutFootballZ
{
	// Token: 0x06001DD4 RID: 7636 RVA: 0x000A0034 File Offset: 0x0009E234
	[Token(Token = "0x6001DD4")]
	[Address(RVA = "0x531940", Offset = "0x52FF40", VA = "0x180531940", Slot = "61")]
	protected override void FirstArmorBroken()
	{
		int num = this.theFirstArmorMaxHealth;
		num += num;
		GameObject theFirstArmor = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)1L);
		SpriteRenderer component = theFirstArmor.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[61];
		component.sprite = sprite;
		GameObject theFirstArmor2 = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)2L);
		SpriteRenderer component2 = theFirstArmor2.GetComponent<SpriteRenderer>();
		Sprite sprite2 = GameAPP.spritePrefab[62];
		component2.sprite = sprite2;
	}

	// Token: 0x06001DD5 RID: 7637 RVA: 0x000A00B0 File Offset: 0x0009E2B0
	[Token(Token = "0x6001DD5")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "33")]
	protected override void LoseHeadEvent()
	{
	}

	// Token: 0x06001DD6 RID: 7638 RVA: 0x000A00C0 File Offset: 0x0009E2C0
	[Token(Token = "0x6001DD6")]
	[Address(RVA = "0x5318B0", Offset = "0x52FEB0", VA = "0x1805318B0", Slot = "68")]
	protected override void AttackEffect(Plant plant)
	{
		base.AttackEffect(plant);
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)2)))
		{
			float[] timers = plant.Timers;
		}
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)3)))
		{
			float[] timers2 = plant.Timers;
		}
	}

	// Token: 0x06001DD7 RID: 7639 RVA: 0x000A0100 File Offset: 0x0009E300
	[Token(Token = "0x6001DD7")]
	[Address(RVA = "0x531AD0", Offset = "0x5300D0", VA = "0x180531AD0")]
	public BlackFootballZombie()
	{
	}
}
