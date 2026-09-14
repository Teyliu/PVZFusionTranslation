using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000411 RID: 1041
[Token(Token = "0x2000411")]
public class PeaBlover : Shooter
{
	// Token: 0x06001329 RID: 4905 RVA: 0x0006B0C8 File Offset: 0x000692C8
	[Token(Token = "0x6001329")]
	[Address(RVA = "0x4ADB20", Offset = "0x4AC120", VA = "0x1804ADB20", Slot = "68")]
	protected override Bullet Shoot1()
	{
		float min = 1.5f;
		int thePlantRow = this.thePlantRow;
		List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
		Func<Plant, bool> func = delegate(Plant a)
		{
			float thePlantAttackInterval2 = a.thePlantAttackInterval;
			int num2 = 0;
			if (thePlantAttackInterval2 > (float)num2 && min > thePlantAttackInterval2)
			{
				PeaBlover <>4__this = this;
				return a != <>4__this;
			}
			throw new NullReferenceException();
		};
		Plant plant = Enumerable.FirstOrDefault<Plant>(Enumerable.Where<Plant>(list, func));
		int num = 0;
		if (plant != num)
		{
			float thePlantAttackInterval = plant.thePlantAttackInterval;
			min = thePlantAttackInterval;
		}
		float min2 = min;
		this.thePlantAttackInterval = min2;
		min = 0.2f;
		this.anim.SetFloat("shootSpeed", 0.5f);
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x0600132A RID: 4906 RVA: 0x0006B1AC File Offset: 0x000693AC
	[Token(Token = "0x600132A")]
	[Address(RVA = "0x4ADDD0", Offset = "0x4AC3D0", VA = "0x1804ADDD0")]
	private void UpdateInterval()
	{
		float min = 1.5f;
		int thePlantRow = this.thePlantRow;
		List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
		Func<Plant, bool> func = delegate(Plant a)
		{
			float thePlantAttackInterval2 = a.thePlantAttackInterval;
			int num2 = 0;
			if (thePlantAttackInterval2 > (float)num2 && min > thePlantAttackInterval2)
			{
				PeaBlover <>4__this = this;
				return a != <>4__this;
			}
			throw new NullReferenceException();
		};
		Plant plant = Enumerable.FirstOrDefault<Plant>(Enumerable.Where<Plant>(list, func));
		int num = 0;
		if (plant != num)
		{
			float thePlantAttackInterval = plant.thePlantAttackInterval;
			min = thePlantAttackInterval;
		}
		float min2 = min;
		this.thePlantAttackInterval = min2;
		min = 0.2f;
		this.anim.SetFloat("shootSpeed", 0.5f);
	}

	// Token: 0x0600132B RID: 4907 RVA: 0x0006B258 File Offset: 0x00069458
	[Token(Token = "0x600132B")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public PeaBlover()
	{
	}
}
