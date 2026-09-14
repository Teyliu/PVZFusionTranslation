using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005B1 RID: 1457
[Token(Token = "0x20005B1")]
public class SuperNutShooter : SuperSnowGatling
{
	// Token: 0x1700017D RID: 381
	// (get) Token: 0x06001AE4 RID: 6884 RVA: 0x000900A8 File Offset: 0x0008E2A8
	[Token(Token = "0x1700017D")]
	public override int LimDamage
	{
		[Token(Token = "0x6001AE4")]
		[Address(RVA = "0x549F70", Offset = "0x548570", VA = "0x180549F70", Slot = "65")]
		get
		{
			return this.thePlantMaxHealth;
		}
	}

	// Token: 0x06001AE5 RID: 6885 RVA: 0x000900C0 File Offset: 0x0008E2C0
	[Token(Token = "0x6001AE5")]
	[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_nut;
	}

	// Token: 0x06001AE6 RID: 6886 RVA: 0x000900D0 File Offset: 0x0008E2D0
	[Token(Token = "0x6001AE6")]
	[Address(RVA = "0x549DA0", Offset = "0x5483A0", VA = "0x180549DA0", Slot = "69")]
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

	// Token: 0x06001AE7 RID: 6887 RVA: 0x0009017C File Offset: 0x0008E37C
	[Token(Token = "0x6001AE7")]
	[Address(RVA = "0x549B50", Offset = "0x548150", VA = "0x180549B50", Slot = "68")]
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

	// Token: 0x06001AE8 RID: 6888 RVA: 0x000901E8 File Offset: 0x0008E3E8
	[Token(Token = "0x6001AE8")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SuperNutShooter()
	{
	}
}
