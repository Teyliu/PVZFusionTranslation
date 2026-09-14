using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000586 RID: 1414
[Token(Token = "0x2000586")]
public class SuperThreePeater_sp : SuperThreePeater
{
	// Token: 0x06001A22 RID: 6690 RVA: 0x0008C990 File Offset: 0x0008AB90
	[Token(Token = "0x6001A22")]
	[Address(RVA = "0x4EC390", Offset = "0x4EA990", VA = "0x1804EC390", Slot = "15")]
	protected override void Start()
	{
		base.Start();
	}

	// Token: 0x06001A23 RID: 6691 RVA: 0x0008C9A4 File Offset: 0x0008ABA4
	[Token(Token = "0x6001A23")]
	[Address(RVA = "0x4EC3C0", Offset = "0x4EA9C0", VA = "0x1804EC3C0", Slot = "73")]
	protected virtual void Zhnahou8()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001A24 RID: 6692 RVA: 0x0008C9C8 File Offset: 0x0008ABC8
	[Token(Token = "0x6001A24")]
	[Address(RVA = "0x4EBDB0", Offset = "0x4EA3B0", VA = "0x1804EBDB0", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001A25 RID: 6693 RVA: 0x0008C9E8 File Offset: 0x0008ABE8
	[Token(Token = "0x6001A25")]
	[Address(RVA = "0x4EC0B0", Offset = "0x4EA6B0", VA = "0x1804EC0B0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Board board = this.board;
		int num = 0;
		Bullet bullet;
		if (num < board.rowNum)
		{
			Transform shoot = this.shoot;
			CreateBullet instance = CreateBullet.Instance;
			Transform shoot2 = this.shoot;
			BulletType bulletType = base.GetBulletType();
			int attackDamage = this.attackDamage;
			bullet.Damage = attackDamage;
			PlantType thePlantType = this.thePlantType;
			num++;
			bullet.fromType = thePlantType;
			Board board2 = this.board;
		}
		return bullet;
	}

	// Token: 0x06001A26 RID: 6694 RVA: 0x0008CA5C File Offset: 0x0008AC5C
	[Token(Token = "0x6001A26")]
	[Address(RVA = "0x4EC220", Offset = "0x4EA820", VA = "0x1804EC220", Slot = "70")]
	protected override Bullet Shoot2()
	{
		Board board = this.board;
		int num = 0;
		if (num < board.rowNum)
		{
			Transform shoot = this.shoot;
			CreateBullet instance = CreateBullet.Instance;
			Transform shoot2 = this.shoot;
			BulletType bulletType = base.GetBulletType();
			int attackDamage = this.attackDamage;
			Bullet bullet;
			bullet.Damage = attackDamage;
			PlantType thePlantType = this.thePlantType;
			num++;
			bullet.fromType = thePlantType;
			Board board2 = this.board;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001A27 RID: 6695 RVA: 0x0008CAD0 File Offset: 0x0008ACD0
	[Token(Token = "0x6001A27")]
	[Address(RVA = "0x4EBE70", Offset = "0x4EA470", VA = "0x1804EBE70", Slot = "44")]
	protected override GameObject SearchZombie()
	{
		for (;;)
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			ulong num3;
			if (flag)
			{
				int num2 = 0;
				if (num != num2)
				{
					float vision = this.vision;
					Transform axis = this.axis;
					if (base.SearchUniqueZombie(num))
					{
						break;
					}
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_3;
			}
		}
		GameObject gameObject;
		return gameObject;
		Block_3:
		throw new NullReferenceException();
	}

	// Token: 0x06001A28 RID: 6696 RVA: 0x0008CB44 File Offset: 0x0008AD44
	[Token(Token = "0x6001A28")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public SuperThreePeater_sp()
	{
	}
}
