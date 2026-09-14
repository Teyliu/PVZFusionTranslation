using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000283 RID: 643
[Token(Token = "0x2000283")]
public class PetGargantuar : MiniPet
{
	// Token: 0x06000B8F RID: 2959 RVA: 0x00041E8C File Offset: 0x0004008C
	[Token(Token = "0x6000B8F")]
	[Address(RVA = "0x426790", Offset = "0x424D90", VA = "0x180426790", Slot = "11")]
	protected override void AttackReady(bool moveOver)
	{
		int num = 0;
		base.AttackReady(moveOver);
		Board board = this.board;
		PetOriginalData originalData = this.originalData;
		this.attackSpeed = 1f;
		originalData.FirstLoad(this);
		float attackRange = originalData.attackRange;
		this.attackSpeed = 1.5f;
		this.attackRange = attackRange;
		float attackRange2 = this.attackRange;
		this.attackRange = attackRange2;
		Animator anim = this.anim;
		float attackSpeed = this.attackSpeed;
		anim.SetFloat("attackSpeed", attackSpeed);
		Transform shoot = this.shoot;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (base.CheckZombie(num, num3))
				{
					goto IL_00A9;
				}
			}
			num++;
			IL_00A9:
			this.anim.SetTrigger("shoot");
			return;
		}
		this.SetTarget();
		throw new NullReferenceException();
	}

	// Token: 0x06000B90 RID: 2960 RVA: 0x00041F60 File Offset: 0x00040160
	[Token(Token = "0x6000B90")]
	[Address(RVA = "0x426B70", Offset = "0x425170", VA = "0x180426B70", Slot = "18")]
	protected override void SetTarget()
	{
		Board board = this.board;
		Transform transform = base.transform;
		int num = 0;
		Zombie zombie;
		if (zombie != num)
		{
			int column = zombie.Column;
			this.targetGrid = column;
			int theZombieRow = zombie.theZombieRow;
			this.targetGrid.m_Y = theZombieRow;
			Transform axis = zombie.axis;
			Transform transform2 = this.shoot.transform;
			Transform transform3 = base.transform;
			this.moving = true;
			this.targetPosition.y = (float)0;
			this.targetPosition = 0;
		}
	}

	// Token: 0x06000B91 RID: 2961 RVA: 0x00041FF0 File Offset: 0x000401F0
	[Token(Token = "0x6000B91")]
	[Address(RVA = "0x425D60", Offset = "0x424360", VA = "0x180425D60", Slot = "9")]
	protected override void AnimAttack()
	{
		int level = this.level;
		int num = 0;
		if (level == 2)
		{
		}
		if (level == 3)
		{
		}
		Transform transform = base.transform;
		int num2 = this.plantLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			LayerMask layerMask;
			int mask = layerMask.m_Mask;
			bool flag;
			if (layerMask != 0 && flag)
			{
				float damage = base.Damage;
				this.AttributeEvent();
			}
			num++;
		}
		float damage2 = base.Damage;
		int num3 = 0;
		int difficulty = GameAPP.config.difficulty;
		if (difficulty == 4)
		{
			float num4 = damage2 * 1.43f;
		}
		if (difficulty == 5)
		{
		}
		int num5 = this.emptyCount;
		num5++;
		int num6 = num5 * difficulty;
		PetData data = this.data;
		if (data.attributeCount > 3000)
		{
			int num7 = data.attributeCount;
			num7 += -3000;
			num6 += num7;
		}
		Transform shoot = this.shoot;
		LayerMask zombieLayer = this.zombieLayer;
		int num8 = 0;
		int num9 = zombieLayer;
		int num10 = 0;
		int num11 = 0;
		Collider2D[] array2;
		if (num10 < array2.Length)
		{
			bool flag2;
			if (flag2)
			{
				int num12 = 0;
				if (base.CheckZombie(num8, num12))
				{
					float num13 = global::UnityEngine.Random.Range(-0.2f, 0.2f);
					float num14 = global::UnityEngine.Random.Range(-0.2f, 0.2f);
					this.AttributeEvent();
					NumberPopManager instance = NumberPopManager.Instance;
					long num15;
					long num16;
					num15 -= num16;
					int num17 = 0;
					base.GetExperience(num17);
				}
			}
			num11++;
		}
		if (num3 != 0)
		{
			this.emptyCount = (int)((ulong)0L);
		}
		uint num18;
		GameAPP.PlaySound((int)num18, 0.5f, 1f);
		ScreenShake.TriggerShake(0.05f);
	}

	// Token: 0x06000B92 RID: 2962 RVA: 0x0004218C File Offset: 0x0004038C
	[Token(Token = "0x6000B92")]
	[Address(RVA = "0x426A10", Offset = "0x425010", VA = "0x180426A10", Slot = "12")]
	protected override void AttributeEvent()
	{
		ulong num;
		do
		{
			this.attributeTimer = 1f;
			List<Zombie> allZombies = Lawnf.GetAllZombies(false);
			bool flag;
			if (flag)
			{
				this.Skill();
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06000B93 RID: 2963 RVA: 0x000421C8 File Offset: 0x000403C8
	[Token(Token = "0x6000B93")]
	[Address(RVA = "0x426D50", Offset = "0x425350", VA = "0x180426D50")]
	public void Skill()
	{
		if (this.level == 1)
		{
			this.attributeTimer = 15f;
			this.attributeTimer = 45f;
			this.attributeTimer = 60f;
		}
		Time.timeScale = 0.2f;
		Animator anim = this.anim;
		this.anim.SetTrigger("super");
	}

	// Token: 0x06000B94 RID: 2964 RVA: 0x00042228 File Offset: 0x00040428
	[Token(Token = "0x6000B94")]
	[Address(RVA = "0x4264E0", Offset = "0x424AE0", VA = "0x1804264E0")]
	private void AnimSuper()
	{
		ulong num;
		do
		{
			List<Zombie> allZombies = Lawnf.GetAllZombies(false);
			bool flag;
			if (flag)
			{
				int level = this.level;
				if (flag && flag)
				{
					while (level != 1)
					{
					}
				}
			}
		}
		while (num != (ulong)0L);
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		ScreenShake.TriggerShake(0.05f);
		Time.timeScale = GameAPP.config.gameSpeed;
	}

	// Token: 0x06000B95 RID: 2965 RVA: 0x000422AC File Offset: 0x000404AC
	[Token(Token = "0x6000B95")]
	[Address(RVA = "0x426DF0", Offset = "0x4253F0", VA = "0x180426DF0")]
	public PetGargantuar()
	{
	}

	// Token: 0x040007A9 RID: 1961
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40007A9")]
	private int emptyCount;
}
