using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000580 RID: 1408
[Token(Token = "0x2000580")]
public class SuperNutShooter : SuperSnowGatling
{
	// Token: 0x17000137 RID: 311
	// (get) Token: 0x060019FE RID: 6654 RVA: 0x0008BD10 File Offset: 0x00089F10
	[Token(Token = "0x17000137")]
	public override int LimDamage
	{
		[Token(Token = "0x60019FE")]
		[Address(RVA = "0x4EA110", Offset = "0x4E8710", VA = "0x1804EA110", Slot = "66")]
		get
		{
			return this.thePlantMaxHealth;
		}
	}

	// Token: 0x060019FF RID: 6655 RVA: 0x0008BD28 File Offset: 0x00089F28
	[Token(Token = "0x60019FF")]
	[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_nut;
	}

	// Token: 0x06001A00 RID: 6656 RVA: 0x0008BD38 File Offset: 0x00089F38
	[Token(Token = "0x6001A00")]
	[Address(RVA = "0x4E9F40", Offset = "0x4E8540", VA = "0x1804E9F40", Slot = "70")]
	protected override Bullet Shoot2()
	{
		CreatePlant instance = CreatePlant.Instance;
		int num = 0;
		Dictionary<PlantDamageAdder, float> damageAdder = this.damageAdder;
		Plant plant;
		plant.damageAdder = damageAdder;
		int num2 = 0;
		int num3 = 0;
		plant.ModifyDamage((PlantDamageAdder)((uint)53), (float)num3, num2 != 0, num);
		if (Lawnf.TravelUltimate((UltiBuff)((uint)51)))
		{
			CreatePlant instance2 = CreatePlant.Instance;
			int thePlantRow = this.thePlantRow;
			int thePlantColumn = this.thePlantColumn;
			ulong num4;
			ulong num5;
			Plant plant2 = instance2.SetPlant(thePlantColumn, thePlantRow, (PlantType)((uint)255), num, num, num4 != 0UL, num5 != 0UL, num);
			Dictionary<PlantDamageAdder, float> damageAdder2 = this.damageAdder;
			plant2.damageAdder = damageAdder2;
			int num6 = 0;
			int num7 = 0;
			plant2.ModifyDamage((PlantDamageAdder)((uint)53), (float)num7, num6 != 0, num);
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001A01 RID: 6657 RVA: 0x0008BDE4 File Offset: 0x00089FE4
	[Token(Token = "0x6001A01")]
	[Address(RVA = "0x4E9CF0", Offset = "0x4E82F0", VA = "0x1804E9CF0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		if (Lawnf.TravelUltimate((UltiBuff)((uint)50)))
		{
		}
		int num = global::UnityEngine.Random.Range(0, 100);
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x06001A02 RID: 6658 RVA: 0x0008BE64 File Offset: 0x0008A064
	[Token(Token = "0x6001A02")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SuperNutShooter()
	{
	}
}
