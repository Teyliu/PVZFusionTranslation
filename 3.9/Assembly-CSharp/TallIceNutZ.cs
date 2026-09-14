using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000725 RID: 1829
[Token(Token = "0x2000725")]
public class TallIceNutZ : WallNutZombie
{
	// Token: 0x0600241C RID: 9244 RVA: 0x000BC674 File Offset: 0x000BA874
	[Token(Token = "0x600241C")]
	[Address(RVA = "0x5F6E80", Offset = "0x5F5480", VA = "0x1805F6E80", Slot = "63")]
	protected override void FirstArmorBroken()
	{
		int num = this.theFirstArmorMaxHealth;
		num += num;
		GameObject theFirstArmor = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)1L);
		SpriteRenderer component = theFirstArmor.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[27];
		component.sprite = sprite;
		GameObject theFirstArmor2 = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)2L);
		SpriteRenderer component2 = theFirstArmor2.GetComponent<SpriteRenderer>();
		Sprite sprite2 = GameAPP.spritePrefab[28];
		component2.sprite = sprite2;
	}

	// Token: 0x0600241D RID: 9245 RVA: 0x000BC6F0 File Offset: 0x000BA8F0
	[Token(Token = "0x600241D")]
	[Address(RVA = "0x5B3BB0", Offset = "0x5B21B0", VA = "0x1805B3BB0", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, freeze);
			return;
		}
	}

	// Token: 0x0600241E RID: 9246 RVA: 0x000BC70C File Offset: 0x000BA90C
	[Token(Token = "0x600241E")]
	[Address(RVA = "0x5B3BD0", Offset = "0x5B21D0", VA = "0x1805B3BD0", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (theFreezeLevel > 0)
		{
			int num = 0;
			base.SetFreeze(time, num);
			return;
		}
	}

	// Token: 0x0600241F RID: 9247 RVA: 0x000BC728 File Offset: 0x000BA928
	[Token(Token = "0x600241F")]
	[Address(RVA = "0x58B130", Offset = "0x589730", VA = "0x18058B130")]
	public TallIceNutZ()
	{
	}
}
