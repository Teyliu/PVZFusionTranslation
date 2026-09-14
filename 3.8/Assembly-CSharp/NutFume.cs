using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200053E RID: 1342
[Token(Token = "0x200053E")]
public class NutFume : Shooter
{
	// Token: 0x060018F5 RID: 6389 RVA: 0x0008729C File Offset: 0x0008549C
	[Token(Token = "0x60018F5")]
	[Address(RVA = "0x4D6DE0", Offset = "0x4D53E0", VA = "0x1804D6DE0", Slot = "29")]
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

	// Token: 0x060018F6 RID: 6390 RVA: 0x000872C4 File Offset: 0x000854C4
	[Token(Token = "0x60018F6")]
	[Address(RVA = "0x41A120", Offset = "0x418720", VA = "0x18041A120", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x060018F7 RID: 6391 RVA: 0x000872D4 File Offset: 0x000854D4
	[Token(Token = "0x60018F7")]
	[Address(RVA = "0x4D6F10", Offset = "0x4D5510", VA = "0x1804D6F10", Slot = "69")]
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

	// Token: 0x060018F8 RID: 6392 RVA: 0x00087324 File Offset: 0x00085524
	[Token(Token = "0x60018F8")]
	[Address(RVA = "0x4D7050", Offset = "0x4D5650", VA = "0x1804D7050", Slot = "47")]
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

	// Token: 0x060018F9 RID: 6393 RVA: 0x00087380 File Offset: 0x00085580
	[Token(Token = "0x60018F9")]
	[Address(RVA = "0x4D6BD0", Offset = "0x4D51D0", VA = "0x1804D6BD0", Slot = "45")]
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

	// Token: 0x060018FA RID: 6394 RVA: 0x00087420 File Offset: 0x00085620
	[Token(Token = "0x60018FA")]
	[Address(RVA = "0x4D71D0", Offset = "0x4D57D0", VA = "0x1804D71D0")]
	public NutFume()
	{
		List<GameObject> list = new List();
		this.changes = list;
		base..ctor();
	}

	// Token: 0x04000E34 RID: 3636
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E34")]
	public List<GameObject> changes;
}
