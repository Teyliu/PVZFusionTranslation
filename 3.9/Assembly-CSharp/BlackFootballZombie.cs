using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200065D RID: 1629
[Token(Token = "0x200065D")]
public class BlackFootballZombie : TallNutFootballZ
{
	// Token: 0x06001ED3 RID: 7891 RVA: 0x000A4648 File Offset: 0x000A2848
	[Token(Token = "0x6001ED3")]
	[Address(RVA = "0x588490", Offset = "0x586A90", VA = "0x180588490", Slot = "63")]
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

	// Token: 0x06001ED4 RID: 7892 RVA: 0x000A46C4 File Offset: 0x000A28C4
	[Token(Token = "0x6001ED4")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "34")]
	protected override void LoseHeadEvent()
	{
	}

	// Token: 0x06001ED5 RID: 7893 RVA: 0x000A46D4 File Offset: 0x000A28D4
	[Token(Token = "0x6001ED5")]
	[Address(RVA = "0x588400", Offset = "0x586A00", VA = "0x180588400", Slot = "70")]
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

	// Token: 0x06001ED6 RID: 7894 RVA: 0x000A4714 File Offset: 0x000A2914
	[Token(Token = "0x6001ED6")]
	[Address(RVA = "0x588620", Offset = "0x586C20", VA = "0x180588620")]
	public BlackFootballZombie()
	{
	}
}
