using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000284 RID: 644
[Token(Token = "0x2000284")]
public class PetHorse : MiniPet
{
	// Token: 0x06000B96 RID: 2966 RVA: 0x000422C0 File Offset: 0x000404C0
	[Token(Token = "0x6000B96")]
	[Address(RVA = "0x427270", Offset = "0x425870", VA = "0x180427270", Slot = "19")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeTimer = 1f;
	}

	// Token: 0x06000B97 RID: 2967 RVA: 0x000422E0 File Offset: 0x000404E0
	[Token(Token = "0x6000B97")]
	[Address(RVA = "0x427200", Offset = "0x425800", VA = "0x180427200", Slot = "12")]
	protected override void AttributeEvent()
	{
		this.SetHorse();
		List<Zombie> certainZombies = Lawnf.GetCertainZombies(this.board, (ZombieType)((uint)212));
		this.attributeTimer = 20f;
	}

	// Token: 0x06000B98 RID: 2968 RVA: 0x00042324 File Offset: 0x00040524
	[Token(Token = "0x6000B98")]
	[Address(RVA = "0x427380", Offset = "0x425980", VA = "0x180427380")]
	[ProButton]
	private void SetHorse()
	{
		Board board = this.board;
		int num = 0;
		if (num < board.rowNum)
		{
			BoxType[] roadType = this.board.roadType;
			uint num2;
			float boxXFromColumn = Lawnf.GetBoxXFromColumn((int)num2);
			float landY = this.mouse.GetLandY(boxXFromColumn, num);
			GameObject gameObject = this.horsePrefab;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = this.board.transform;
			GameObject gameObject2;
			SortingGroup sortingGroup = gameObject2.AddComponent<SortingGroup>();
			int num3;
			string text = string.Format("bullet{0}", num3);
			sortingGroup.sortingLayerName = text;
			this.HorseUpdate(gameObject2, num);
			Board board2 = this.board;
			num++;
			uint num4;
			num4 += (uint)4;
		}
	}

	// Token: 0x06000B99 RID: 2969 RVA: 0x000423D0 File Offset: 0x000405D0
	[Token(Token = "0x6000B99")]
	[Address(RVA = "0x427290", Offset = "0x425890", VA = "0x180427290")]
	private void HorseUpdate(GameObject horse, int row)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000B9A RID: 2970 RVA: 0x000423F4 File Offset: 0x000405F4
	[Token(Token = "0x6000B9A")]
	[Address(RVA = "0x427010", Offset = "0x425610", VA = "0x180427010", Slot = "11")]
	protected override void AttackReady(bool moveOver)
	{
		ulong num3;
		do
		{
			int num = 0;
			base.AttackReady(moveOver);
			this.SetTarget();
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				int thePetRow = this.thePetRow;
				if (!Lawnf.InLandStatus((ZombieStatus)num))
				{
					continue;
				}
				this.anim.SetTrigger("shoot");
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06000B9B RID: 2971 RVA: 0x00042468 File Offset: 0x00040668
	[Token(Token = "0x6000B9B")]
	[Address(RVA = "0x427620", Offset = "0x425C20", VA = "0x180427620", Slot = "18")]
	protected override void SetTarget()
	{
		int zombieMaxHealthRow = base.GetZombieMaxHealthRow();
		this.moving = true;
		int num = 0;
		this.targetGrid = (ulong)0L;
		this.targetGrid.m_Y = zombieMaxHealthRow;
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(num);
		this.targetPosition = boxXFromColumn;
		float landY = this.mouse.GetLandY(boxXFromColumn, zombieMaxHealthRow);
		this.targetPosition.y = landY;
	}

	// Token: 0x06000B9C RID: 2972 RVA: 0x000424CC File Offset: 0x000406CC
	[Token(Token = "0x6000B9C")]
	[Address(RVA = "0x426E40", Offset = "0x425440", VA = "0x180426E40", Slot = "9")]
	protected override void AnimAttack()
	{
		float damage = base.Damage;
		int num = this.level;
		uint num2;
		num -= (int)num2;
		num -= (int)num2;
		if (num == (int)num2)
		{
		}
		Animator anim = this.anim;
		uint num3;
		base.GetExperience((int)num3);
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot2 = this.shoot;
		Bullet bullet;
		bullet.fromType = (PlantType)((ulong)268L);
	}

	// Token: 0x06000B9D RID: 2973 RVA: 0x00042534 File Offset: 0x00040734
	[Token(Token = "0x6000B9D")]
	[Address(RVA = "0x4276A0", Offset = "0x425CA0", VA = "0x1804276A0")]
	public PetHorse()
	{
	}

	// Token: 0x040007AA RID: 1962
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40007AA")]
	public GameObject horsePrefab;
}
