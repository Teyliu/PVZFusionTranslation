using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200027E RID: 638
[Token(Token = "0x200027E")]
public class PetHorse : MiniPet
{
	// Token: 0x06000B7A RID: 2938 RVA: 0x00042490 File Offset: 0x00040690
	[Token(Token = "0x6000B7A")]
	[Address(RVA = "0x3D90D0", Offset = "0x3D76D0", VA = "0x1803D90D0", Slot = "19")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeTimer = 1f;
	}

	// Token: 0x06000B7B RID: 2939 RVA: 0x000424B0 File Offset: 0x000406B0
	[Token(Token = "0x6000B7B")]
	[Address(RVA = "0x3D9060", Offset = "0x3D7660", VA = "0x1803D9060", Slot = "12")]
	protected override void AttributeEvent()
	{
		this.SetHorse();
		List<Zombie> certainZombies = Lawnf.GetCertainZombies(this.board, (ZombieType)((uint)212));
		this.attributeTimer = 20f;
	}

	// Token: 0x06000B7C RID: 2940 RVA: 0x000424F4 File Offset: 0x000406F4
	[Token(Token = "0x6000B7C")]
	[Address(RVA = "0x3D91E0", Offset = "0x3D77E0", VA = "0x1803D91E0")]
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

	// Token: 0x06000B7D RID: 2941 RVA: 0x000425A0 File Offset: 0x000407A0
	[Token(Token = "0x6000B7D")]
	[Address(RVA = "0x3D90F0", Offset = "0x3D76F0", VA = "0x1803D90F0")]
	private void HorseUpdate(GameObject horse, int row)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000B7E RID: 2942 RVA: 0x000425C4 File Offset: 0x000407C4
	[Token(Token = "0x6000B7E")]
	[Address(RVA = "0x3D8E70", Offset = "0x3D7470", VA = "0x1803D8E70", Slot = "11")]
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

	// Token: 0x06000B7F RID: 2943 RVA: 0x00042638 File Offset: 0x00040838
	[Token(Token = "0x6000B7F")]
	[Address(RVA = "0x3D9480", Offset = "0x3D7A80", VA = "0x1803D9480", Slot = "18")]
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

	// Token: 0x06000B80 RID: 2944 RVA: 0x0004269C File Offset: 0x0004089C
	[Token(Token = "0x6000B80")]
	[Address(RVA = "0x3D8CA0", Offset = "0x3D72A0", VA = "0x1803D8CA0", Slot = "9")]
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

	// Token: 0x06000B81 RID: 2945 RVA: 0x00042704 File Offset: 0x00040904
	[Token(Token = "0x6000B81")]
	[Address(RVA = "0x3D9500", Offset = "0x3D7B00", VA = "0x1803D9500")]
	public PetHorse()
	{
	}

	// Token: 0x0400079E RID: 1950
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400079E")]
	public GameObject horsePrefab;
}
