using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200056C RID: 1388
[Token(Token = "0x200056C")]
public class NutFume : Shooter
{
	// Token: 0x060019C9 RID: 6601 RVA: 0x0008B034 File Offset: 0x00089234
	[Token(Token = "0x60019C9")]
	[Address(RVA = "0x537930", Offset = "0x535F30", VA = "0x180537930", Slot = "28")]
	protected override void ReplaceSprite()
	{
		ulong num;
		do
		{
			List<GameObject> list = this.changes;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x060019CA RID: 6602 RVA: 0x0008B05C File Offset: 0x0008925C
	[Token(Token = "0x60019CA")]
	[Address(RVA = "0x466C80", Offset = "0x465280", VA = "0x180466C80", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x060019CB RID: 6603 RVA: 0x0008B06C File Offset: 0x0008926C
	[Token(Token = "0x60019CB")]
	[Address(RVA = "0x537A60", Offset = "0x536060", VA = "0x180537A60", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int attributeCount = this.attributeCount;
		Bullet bullet;
		bullet.Damage = attributeCount;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		this.attributeCount = (int)((ulong)0L);
		return bullet;
	}

	// Token: 0x060019CC RID: 6604 RVA: 0x0008B0BC File Offset: 0x000892BC
	[Token(Token = "0x60019CC")]
	[Address(RVA = "0x537BA0", Offset = "0x5361A0", VA = "0x180537BA0", Slot = "46")]
	protected override bool Shootable()
	{
		bool flag = base.Shootable();
		if (!flag)
		{
			return flag;
		}
		int thePlantRow = this.thePlantRow;
		List<Plant> list = Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
		Predicate<Plant> predicate;
		if (NutFume.<>c.<>9__4_0 == 0)
		{
			NutFume.<>c.<>9__4_0 = predicate;
		}
		Plant plant = list.Find(predicate);
		int num = 0;
		return plant != num;
	}

	// Token: 0x060019CD RID: 6605 RVA: 0x0008B118 File Offset: 0x00089318
	[Token(Token = "0x60019CD")]
	[Address(RVA = "0x537720", Offset = "0x535D20", VA = "0x180537720", Slot = "44")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.thePlantAttackCountDown = num;
		if (this.Shootable())
		{
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
			Predicate<Plant> <>9__5_ = NutFume.<>c.<>9__5_0;
			if (<>9__5_ == 0)
			{
				Predicate<Plant> predicate;
				NutFume.<>c.<>9__5_0 = predicate;
			}
			Plant plant = list.Find(<>9__5_);
			int num2 = 0;
			plant.Die((Plant.DieReason)num2);
			Animator anim = this.anim;
			int thePlantHealth = plant.thePlantHealth;
			this.attributeCount = thePlantHealth;
			anim.SetTrigger("shoot");
		}
	}

	// Token: 0x060019CE RID: 6606 RVA: 0x0008B1B8 File Offset: 0x000893B8
	[Token(Token = "0x60019CE")]
	[Address(RVA = "0x537D20", Offset = "0x536320", VA = "0x180537D20")]
	public NutFume()
	{
		List<GameObject> list = new List();
		this.changes = list;
		base..ctor();
	}

	// Token: 0x04000EF1 RID: 3825
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000EF1")]
	public List<GameObject> changes;
}
