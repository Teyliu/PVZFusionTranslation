using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000696 RID: 1686
[Token(Token = "0x2000696")]
public class ElitePaperZombie : PaperZombie
{
	// Token: 0x0600200F RID: 8207 RVA: 0x000A9EC8 File Offset: 0x000A80C8
	[Token(Token = "0x600200F")]
	[Address(RVA = "0x5A6260", Offset = "0x5A4860", VA = "0x1805A6260", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[38];
		component.sprite = sprite;
	}

	// Token: 0x06002010 RID: 8208 RVA: 0x000A9EF8 File Offset: 0x000A80F8
	[Token(Token = "0x6002010")]
	[Address(RVA = "0x5A6520", Offset = "0x5A4B20", VA = "0x1805A6520", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06002011 RID: 8209 RVA: 0x000A9F08 File Offset: 0x000A8108
	[Token(Token = "0x6002011")]
	[Address(RVA = "0x5A6230", Offset = "0x5A4830", VA = "0x1805A6230", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		base.BodyTakeDamage(theDamage);
	}

	// Token: 0x06002012 RID: 8210 RVA: 0x000A9F20 File Offset: 0x000A8120
	[Token(Token = "0x6002012")]
	[Address(RVA = "0x5A6310", Offset = "0x5A4910", VA = "0x1805A6310", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06002013 RID: 8211 RVA: 0x000A9F30 File Offset: 0x000A8130
	[Token(Token = "0x6002013")]
	[Address(RVA = "0x5A6370", Offset = "0x5A4970", VA = "0x1805A6370", Slot = "66")]
	protected override void SecondArmorBroken()
	{
		int num = this.theSecondArmorMaxHealth;
		num += num;
		GameObject theSecondArmor = this.theSecondArmor;
		this.theSecondArmorBroken = (int)((ulong)1L);
		SpriteRenderer component = theSecondArmor.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[42];
		component.sprite = sprite;
		GameObject theSecondArmor2 = this.theSecondArmor;
		this.theSecondArmorBroken = (int)((ulong)2L);
		SpriteRenderer component2 = theSecondArmor2.GetComponent<SpriteRenderer>();
		Sprite sprite2 = GameAPP.spritePrefab[43];
		component2.sprite = sprite2;
	}

	// Token: 0x06002014 RID: 8212 RVA: 0x000A9FAC File Offset: 0x000A81AC
	[Token(Token = "0x6002014")]
	[Address(RVA = "0x5A6240", Offset = "0x5A4840", VA = "0x1805A6240", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = false)
	{
		base.Buttered(time, true);
	}

	// Token: 0x06002015 RID: 8213 RVA: 0x000A9FC4 File Offset: 0x000A81C4
	[Token(Token = "0x6002015")]
	[Address(RVA = "0x5A6500", Offset = "0x5A4B00", VA = "0x1805A6500", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x06002016 RID: 8214 RVA: 0x000A9FE0 File Offset: 0x000A81E0
	[Token(Token = "0x6002016")]
	[Address(RVA = "0x58B130", Offset = "0x589730", VA = "0x18058B130")]
	public ElitePaperZombie()
	{
	}
}
