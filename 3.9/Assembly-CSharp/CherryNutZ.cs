using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000673 RID: 1651
[Token(Token = "0x2000673")]
public class CherryNutZ : WallNutZombie
{
	// Token: 0x06001F5B RID: 8027 RVA: 0x000A6E28 File Offset: 0x000A5028
	[Token(Token = "0x6001F5B")]
	[Address(RVA = "0x59B4A0", Offset = "0x599AA0", VA = "0x18059B4A0", Slot = "63")]
	protected override void FirstArmorBroken()
	{
		int num = this.theFirstArmorMaxHealth;
		num += num;
		GameObject theFirstArmor = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)1L);
		SpriteRenderer component = theFirstArmor.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[16];
		component.sprite = sprite;
		GameObject theFirstArmor2 = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)2L);
		SpriteRenderer component2 = theFirstArmor2.GetComponent<SpriteRenderer>();
		Sprite sprite2 = GameAPP.spritePrefab[17];
		component2.sprite = sprite2;
	}

	// Token: 0x06001F5C RID: 8028 RVA: 0x000A6EA8 File Offset: 0x000A50A8
	[Token(Token = "0x6001F5C")]
	[Address(RVA = "0x58B130", Offset = "0x589730", VA = "0x18058B130")]
	public CherryNutZ()
	{
	}
}
