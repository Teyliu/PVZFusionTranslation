using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200063D RID: 1597
[Token(Token = "0x200063D")]
public class CherryNutZ : WallNutZombie
{
	// Token: 0x06001E59 RID: 7769 RVA: 0x000A26D8 File Offset: 0x000A08D8
	[Token(Token = "0x6001E59")]
	[Address(RVA = "0x538ED0", Offset = "0x5374D0", VA = "0x180538ED0", Slot = "61")]
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

	// Token: 0x06001E5A RID: 7770 RVA: 0x000A2758 File Offset: 0x000A0958
	[Token(Token = "0x6001E5A")]
	[Address(RVA = "0x534450", Offset = "0x532A50", VA = "0x180534450")]
	public CherryNutZ()
	{
	}
}
