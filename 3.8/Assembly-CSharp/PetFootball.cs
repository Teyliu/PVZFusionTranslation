using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200027B RID: 635
[Token(Token = "0x200027B")]
public class PetFootball : MiniPet
{
	// Token: 0x06000B6C RID: 2924 RVA: 0x00041DAC File Offset: 0x0003FFAC
	[Token(Token = "0x6000B6C")]
	[Address(RVA = "0x3D77A0", Offset = "0x3D5DA0", VA = "0x1803D77A0", Slot = "11")]
	protected override void AttackReady(bool moveOver)
	{
		int num = 0;
		base.AttackReady(moveOver);
		if (this.level == 1)
		{
			float attackRange = this.originalData.attackRange;
			this.attackRange = attackRange;
			float attackRange2 = this.originalData.attackRange;
			this.attackRange = attackRange2;
			float attackRange3 = this.originalData.attackRange;
			this.attackRange = attackRange3;
		}
		if (!moveOver)
		{
			Transform shoot = this.shoot;
			int num2 = this.plantLayer;
			Collider2D[] array;
			if (num >= array.Length)
			{
				this.SetTarget();
				throw new NullReferenceException();
			}
			bool flag;
			if (flag)
			{
			}
			num++;
			this.anim.SetTrigger("shoot");
		}
	}

	// Token: 0x06000B6D RID: 2925 RVA: 0x00041E50 File Offset: 0x00040050
	[Token(Token = "0x6000B6D")]
	[Address(RVA = "0x3D7250", Offset = "0x3D5850", VA = "0x1803D7250", Slot = "9")]
	protected override void AnimAttack()
	{
		int num = 0;
		float num2 = base.Damage * 10f;
		float num3 = base.Damage;
		int level = this.level;
		if (level == 2)
		{
			num2 = base.Damage;
			num3 = base.Damage;
		}
		float num4;
		float damage;
		if (level == 3)
		{
			num2 = base.Damage;
			num4 = num2 * 50f;
			damage = base.Damage;
		}
		Board board = this.board;
		Transform shoot = this.shoot;
		List<Zombie> list;
		int size = list._size;
		Vector3 vector;
		float z = vector.z;
		int num5 = this.plantLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			LayerMask layerMask;
			int mask = layerMask.m_Mask;
			bool flag;
			if (layerMask == 0 || flag)
			{
			}
			num++;
		}
		Transform shoot2 = this.shoot;
		num5 = this.zombieLayer;
		Collider2D[] array2;
		if (num < array2.Length)
		{
			bool flag2;
			bool flag3;
			if (!flag2 || !flag3 || num4 > damage)
			{
			}
			num++;
		}
		uint num6;
		base.GetExperience((int)num6);
		this.SetTarget();
	}

	// Token: 0x06000B6E RID: 2926 RVA: 0x00041F48 File Offset: 0x00040148
	[Token(Token = "0x6000B6E")]
	[Address(RVA = "0x3D79C0", Offset = "0x3D5FC0", VA = "0x1803D79C0", Slot = "18")]
	protected override void SetTarget()
	{
		List<Plant> allPlants = Lawnf.GetAllPlants();
		Func<Plant, float> <>9__2_ = PetFootball.<>c.<>9__2_0;
		if (<>9__2_ == 0)
		{
			Func<Plant, float> func;
			PetFootball.<>c.<>9__2_0 = func;
		}
		Plant plant = Enumerable.FirstOrDefault<Plant>(Enumerable.OrderBy<Plant, float>(allPlants, <>9__2_));
		int num = 0;
		if (plant != num)
		{
			int thePlantMaxHealth = plant.thePlantMaxHealth;
			if (plant.thePlantHealth < thePlantMaxHealth)
			{
				int thePlantColumn = plant.thePlantColumn;
				this.targetGrid = thePlantColumn;
				int thePlantRow = plant.thePlantRow;
				this.targetGrid.m_Y = thePlantRow;
				Transform axis = plant.axis;
				this.moving = true;
			}
		}
	}

	// Token: 0x06000B6F RID: 2927 RVA: 0x00041FDC File Offset: 0x000401DC
	[Token(Token = "0x6000B6F")]
	[Address(RVA = "0x3D7BC0", Offset = "0x3D61C0", VA = "0x1803D7BC0")]
	public PetFootball()
	{
	}
}
