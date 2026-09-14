using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005F1 RID: 1521
[Token(Token = "0x20005F1")]
public class UltimateSpruce : Shooter
{
	// Token: 0x06001C57 RID: 7255 RVA: 0x000972C8 File Offset: 0x000954C8
	[Token(Token = "0x6001C57")]
	[Address(RVA = "0x4A1280", Offset = "0x49F880", VA = "0x1804A1280", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 5f;
	}

	// Token: 0x06001C58 RID: 7256 RVA: 0x000972E8 File Offset: 0x000954E8
	[Token(Token = "0x6001C58")]
	[Address(RVA = "0x44A720", Offset = "0x448D20", VA = "0x18044A720")]
	public void StealHealth()
	{
	}

	// Token: 0x06001C59 RID: 7257 RVA: 0x000972F8 File Offset: 0x000954F8
	[Token(Token = "0x6001C59")]
	[Address(RVA = "0x56A9F0", Offset = "0x568FF0", VA = "0x18056A9F0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		bullet.from = this;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		int shootingLevel = this.shootingLevel;
		bullet.shootingLevel = shootingLevel;
		int num = 0;
		if (global::Lawnf.TravelAdvanced((AdvBuff)((uint)12019)))
		{
			int num2 = this.theShieldHealth.MultiplyPercent(0.6f);
			int num3 = this.attackDamage;
			num3 = num2;
			int num4 = Mathf.Min(num3, num);
			bullet.Damage = num;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001C5A RID: 7258 RVA: 0x0009739C File Offset: 0x0009559C
	[Token(Token = "0x6001C5A")]
	[Address(RVA = "0x56A5E0", Offset = "0x568BE0", VA = "0x18056A5E0", Slot = "39")]
	protected override void AttributeEvent()
	{
		ulong num2;
		do
		{
			base.UpdateText();
			base.AttributeCountdown = 5f;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = global::Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
			Predicate<Plant> <>9__3_ = UltimateSpruce.<>c.<>9__3_0;
			if (<>9__3_ == 0)
			{
				Predicate<Plant> predicate;
				UltimateSpruce.<>c.<>9__3_0 = predicate;
			}
			int num = list.RemoveAll(<>9__3_);
			bool flag;
			if (!flag)
			{
			}
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06001C5B RID: 7259 RVA: 0x00097410 File Offset: 0x00095610
	[Token(Token = "0x6001C5B")]
	[Address(RVA = "0x56A920", Offset = "0x568F20", VA = "0x18056A920", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001C5C RID: 7260 RVA: 0x00097430 File Offset: 0x00095630
	[Token(Token = "0x6001C5C")]
	[Address(RVA = "0x4A12B0", Offset = "0x49F8B0", VA = "0x1804A12B0", Slot = "58")]
	public override void InfluenceByIceShroom()
	{
	}

	// Token: 0x06001C5D RID: 7261 RVA: 0x00097440 File Offset: 0x00095640
	[Token(Token = "0x6001C5D")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public UltimateSpruce()
	{
	}
}
