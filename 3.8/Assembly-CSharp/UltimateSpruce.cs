using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005BF RID: 1471
[Token(Token = "0x20005BF")]
public class UltimateSpruce : Shooter
{
	// Token: 0x06001B64 RID: 7012 RVA: 0x00092B64 File Offset: 0x00090D64
	[Token(Token = "0x6001B64")]
	[Address(RVA = "0x44CAC0", Offset = "0x44B0C0", VA = "0x18044CAC0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 5f;
	}

	// Token: 0x06001B65 RID: 7013 RVA: 0x00092B84 File Offset: 0x00090D84
	[Token(Token = "0x6001B65")]
	[Address(RVA = "0x3EDD00", Offset = "0x3EC300", VA = "0x1803EDD00")]
	public void StealHealth()
	{
	}

	// Token: 0x06001B66 RID: 7014 RVA: 0x00092B94 File Offset: 0x00090D94
	[Token(Token = "0x6001B66")]
	[Address(RVA = "0x503280", Offset = "0x501880", VA = "0x180503280", Slot = "69")]
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
		throw new NullReferenceException();
	}

	// Token: 0x06001B67 RID: 7015 RVA: 0x00092BE4 File Offset: 0x00090DE4
	[Token(Token = "0x6001B67")]
	[Address(RVA = "0x502E70", Offset = "0x501470", VA = "0x180502E70", Slot = "40")]
	protected override void AttributeEvent()
	{
		ulong num2;
		do
		{
			base.UpdateText();
			base.AttributeCountdown = 5f;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
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

	// Token: 0x06001B68 RID: 7016 RVA: 0x00092C58 File Offset: 0x00090E58
	[Token(Token = "0x6001B68")]
	[Address(RVA = "0x5031B0", Offset = "0x5017B0", VA = "0x1805031B0", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001B69 RID: 7017 RVA: 0x00092C78 File Offset: 0x00090E78
	[Token(Token = "0x6001B69")]
	[Address(RVA = "0x44CAF0", Offset = "0x44B0F0", VA = "0x18044CAF0", Slot = "59")]
	public override void InfluenceByIceShroom()
	{
	}

	// Token: 0x06001B6A RID: 7018 RVA: 0x00092C88 File Offset: 0x00090E88
	[Token(Token = "0x6001B6A")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public UltimateSpruce()
	{
	}
}
