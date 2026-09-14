using System;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003F7 RID: 1015
[Token(Token = "0x20003F7")]
public class PeaBlover : Shooter
{
	// Token: 0x060012B6 RID: 4790 RVA: 0x00069338 File Offset: 0x00067538
	[Token(Token = "0x60012B6")]
	[Address(RVA = "0x459740", Offset = "0x457D40", VA = "0x180459740", Slot = "69")]
	protected override Bullet Shoot1()
	{
		float min = 1.5f;
		int thePlantRow = this.thePlantRow;
		Func<Plant, bool> func;
		Plant plant = Enumerable.FirstOrDefault<Plant>(Enumerable.Where<Plant>(Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow), func));
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

	// Token: 0x060012B7 RID: 4791 RVA: 0x00069408 File Offset: 0x00067608
	[Token(Token = "0x60012B7")]
	[Address(RVA = "0x4599F0", Offset = "0x457FF0", VA = "0x1804599F0")]
	private void UpdateInterval()
	{
		float min = 1.5f;
		int thePlantRow = this.thePlantRow;
		Func<Plant, bool> func;
		Plant plant = Enumerable.FirstOrDefault<Plant>(Enumerable.Where<Plant>(Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow), func));
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

	// Token: 0x060012B8 RID: 4792 RVA: 0x000694A4 File Offset: 0x000676A4
	[Token(Token = "0x60012B8")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public PeaBlover()
	{
	}
}
