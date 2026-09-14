using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006ED RID: 1773
[Token(Token = "0x20006ED")]
public class TallIceNutZ : WallNutZombie
{
	// Token: 0x06002300 RID: 8960 RVA: 0x000B7830 File Offset: 0x000B5A30
	[Token(Token = "0x6002300")]
	[Address(RVA = "0x57C8A0", Offset = "0x57AEA0", VA = "0x18057C8A0", Slot = "61")]
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

	// Token: 0x06002301 RID: 8961 RVA: 0x000B78AC File Offset: 0x000B5AAC
	[Token(Token = "0x6002301")]
	[Address(RVA = "0x550020", Offset = "0x54E620", VA = "0x180550020", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, freeze);
			return;
		}
	}

	// Token: 0x06002302 RID: 8962 RVA: 0x000B78C8 File Offset: 0x000B5AC8
	[Token(Token = "0x6002302")]
	[Address(RVA = "0x550040", Offset = "0x54E640", VA = "0x180550040", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (theFreezeLevel > 0)
		{
			int num = 0;
			base.SetFreeze(time, num);
			return;
		}
	}

	// Token: 0x06002303 RID: 8963 RVA: 0x000B78E4 File Offset: 0x000B5AE4
	[Token(Token = "0x6002303")]
	[Address(RVA = "0x534450", Offset = "0x532A50", VA = "0x180534450")]
	public TallIceNutZ()
	{
	}
}
