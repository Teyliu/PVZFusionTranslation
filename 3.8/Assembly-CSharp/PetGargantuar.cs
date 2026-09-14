using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200027D RID: 637
[Token(Token = "0x200027D")]
public class PetGargantuar : MiniPet
{
	// Token: 0x06000B73 RID: 2931 RVA: 0x00042034 File Offset: 0x00040234
	[Token(Token = "0x6000B73")]
	[Address(RVA = "0x3D85F0", Offset = "0x3D6BF0", VA = "0x1803D85F0", Slot = "11")]
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

	// Token: 0x06000B74 RID: 2932 RVA: 0x00042108 File Offset: 0x00040308
	[Token(Token = "0x6000B74")]
	[Address(RVA = "0x3D89D0", Offset = "0x3D6FD0", VA = "0x1803D89D0", Slot = "18")]
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

	// Token: 0x06000B75 RID: 2933 RVA: 0x00042198 File Offset: 0x00040398
	[Token(Token = "0x6000B75")]
	[Address(RVA = "0x3D7C10", Offset = "0x3D6210", VA = "0x1803D7C10", Slot = "9")]
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
		LayerMask plantLayer = this.plantLayer;
		float attackRange = this.attackRange;
		int num2 = plantLayer;
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
		float num4 = damage2 * 3f;
		int difficulty = GameAPP.config.difficulty;
		if (difficulty == 4)
		{
			float num5 = num4 * 1.43f;
		}
		if (difficulty == 5)
		{
		}
		int num6 = this.emptyCount;
		num6++;
		int num7 = num6 * difficulty;
		PetData data = this.data;
		if (data.attributeCount > 3000)
		{
			int num8 = data.attributeCount;
			num8 += -3000;
			num7 += num8;
		}
		Transform shoot = this.shoot;
		LayerMask zombieLayer = this.zombieLayer;
		int num9 = 0;
		int num10 = zombieLayer;
		int num11 = 0;
		int num12 = 0;
		Collider2D[] array2;
		if (num11 < array2.Length)
		{
			bool flag2;
			if (flag2)
			{
				int num13 = 0;
				if (base.CheckZombie(num9, num13))
				{
					float num14 = global::UnityEngine.Random.Range(-0.2f, 0.2f);
					float num15 = global::UnityEngine.Random.Range(-0.2f, 0.2f);
					this.AttributeEvent();
					Board board = this.board;
					int num16;
					int num17;
					num16 -= num17;
					int num18 = 0;
					int num19 = 0;
					string text;
					ulong num20;
					DamagePopup.SetPopUp(board, num18, text, num19 != 0, (int)num20);
					base.GetExperience(num18);
				}
			}
			num12++;
		}
		if (num3 != 0)
		{
			this.emptyCount = (int)((ulong)0L);
		}
		uint num21;
		GameAPP.PlaySound((int)num21, 0.5f, 1f);
		ScreenShake.TriggerShake(0.05f);
	}

	// Token: 0x06000B76 RID: 2934 RVA: 0x0004235C File Offset: 0x0004055C
	[Token(Token = "0x6000B76")]
	[Address(RVA = "0x3D8870", Offset = "0x3D6E70", VA = "0x1803D8870", Slot = "12")]
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

	// Token: 0x06000B77 RID: 2935 RVA: 0x00042398 File Offset: 0x00040598
	[Token(Token = "0x6000B77")]
	[Address(RVA = "0x3D8BB0", Offset = "0x3D71B0", VA = "0x1803D8BB0")]
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

	// Token: 0x06000B78 RID: 2936 RVA: 0x000423F8 File Offset: 0x000405F8
	[Token(Token = "0x6000B78")]
	[Address(RVA = "0x3D8340", Offset = "0x3D6940", VA = "0x1803D8340")]
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

	// Token: 0x06000B79 RID: 2937 RVA: 0x0004247C File Offset: 0x0004067C
	[Token(Token = "0x6000B79")]
	[Address(RVA = "0x3D8C50", Offset = "0x3D7250", VA = "0x1803D8C50")]
	public PetGargantuar()
	{
	}

	// Token: 0x0400079D RID: 1949
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400079D")]
	private int emptyCount;
}
