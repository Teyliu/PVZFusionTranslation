using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000660 RID: 1632
[Token(Token = "0x2000660")]
public class ElitePaperZombie : PaperZombie
{
	// Token: 0x06001F0D RID: 7949 RVA: 0x000A5750 File Offset: 0x000A3950
	[Token(Token = "0x6001F0D")]
	[Address(RVA = "0x543C40", Offset = "0x542240", VA = "0x180543C40", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[38];
		component.sprite = sprite;
	}

	// Token: 0x06001F0E RID: 7950 RVA: 0x000A5780 File Offset: 0x000A3980
	[Token(Token = "0x6001F0E")]
	[Address(RVA = "0x543F00", Offset = "0x542500", VA = "0x180543F00", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06001F0F RID: 7951 RVA: 0x000A5790 File Offset: 0x000A3990
	[Token(Token = "0x6001F0F")]
	[Address(RVA = "0x543C10", Offset = "0x542210", VA = "0x180543C10", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		base.BodyTakeDamage(theDamage);
	}

	// Token: 0x06001F10 RID: 7952 RVA: 0x000A57A8 File Offset: 0x000A39A8
	[Token(Token = "0x6001F10")]
	[Address(RVA = "0x543CF0", Offset = "0x5422F0", VA = "0x180543CF0", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06001F11 RID: 7953 RVA: 0x000A57B8 File Offset: 0x000A39B8
	[Token(Token = "0x6001F11")]
	[Address(RVA = "0x543D50", Offset = "0x542350", VA = "0x180543D50", Slot = "64")]
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

	// Token: 0x06001F12 RID: 7954 RVA: 0x000A5834 File Offset: 0x000A3A34
	[Token(Token = "0x6001F12")]
	[Address(RVA = "0x543C20", Offset = "0x542220", VA = "0x180543C20", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = false)
	{
		base.Buttered(time, true);
	}

	// Token: 0x06001F13 RID: 7955 RVA: 0x000A584C File Offset: 0x000A3A4C
	[Token(Token = "0x6001F13")]
	[Address(RVA = "0x543EE0", Offset = "0x5424E0", VA = "0x180543EE0", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x06001F14 RID: 7956 RVA: 0x000A5868 File Offset: 0x000A3A68
	[Token(Token = "0x6001F14")]
	[Address(RVA = "0x534450", Offset = "0x532A50", VA = "0x180534450")]
	public ElitePaperZombie()
	{
	}
}
