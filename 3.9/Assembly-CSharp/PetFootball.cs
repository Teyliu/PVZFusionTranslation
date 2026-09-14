using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000281 RID: 641
[Token(Token = "0x2000281")]
public class PetFootball : MiniPet
{
	// Token: 0x06000B88 RID: 2952 RVA: 0x00041C04 File Offset: 0x0003FE04
	[Token(Token = "0x6000B88")]
	[Address(RVA = "0x4258F0", Offset = "0x423EF0", VA = "0x1804258F0", Slot = "11")]
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

	// Token: 0x06000B89 RID: 2953 RVA: 0x00041CA8 File Offset: 0x0003FEA8
	[Token(Token = "0x6000B89")]
	[Address(RVA = "0x425390", Offset = "0x423990", VA = "0x180425390", Slot = "9")]
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
		if (level == 3)
		{
			num2 = base.Damage;
			num4 = num2 * 50f;
			num3 = base.Damage;
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
			if (flag2 && flag3)
			{
				int num6 = 0;
				if (num4 > (float)num6)
				{
				}
			}
			num++;
		}
		uint num7;
		base.GetExperience((int)num7);
		this.SetTarget();
	}

	// Token: 0x06000B8A RID: 2954 RVA: 0x00041DA0 File Offset: 0x0003FFA0
	[Token(Token = "0x6000B8A")]
	[Address(RVA = "0x425B10", Offset = "0x424110", VA = "0x180425B10", Slot = "18")]
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

	// Token: 0x06000B8B RID: 2955 RVA: 0x00041E34 File Offset: 0x00040034
	[Token(Token = "0x6000B8B")]
	[Address(RVA = "0x425D10", Offset = "0x424310", VA = "0x180425D10")]
	public PetFootball()
	{
	}
}
