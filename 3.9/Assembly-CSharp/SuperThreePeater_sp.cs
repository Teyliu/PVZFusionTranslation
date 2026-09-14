using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005B7 RID: 1463
[Token(Token = "0x20005B7")]
public class SuperThreePeater_sp : SuperThreePeater
{
	// Token: 0x06001B08 RID: 6920 RVA: 0x00090D18 File Offset: 0x0008EF18
	[Token(Token = "0x6001B08")]
	[Address(RVA = "0x54C200", Offset = "0x54A800", VA = "0x18054C200", Slot = "15")]
	protected override void Start()
	{
		base.Start();
	}

	// Token: 0x06001B09 RID: 6921 RVA: 0x00090D2C File Offset: 0x0008EF2C
	[Token(Token = "0x6001B09")]
	[Address(RVA = "0x54C230", Offset = "0x54A830", VA = "0x18054C230", Slot = "72")]
	protected virtual void Zhnahou8()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001B0A RID: 6922 RVA: 0x00090D50 File Offset: 0x0008EF50
	[Token(Token = "0x6001B0A")]
	[Address(RVA = "0x54BC20", Offset = "0x54A220", VA = "0x18054BC20", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001B0B RID: 6923 RVA: 0x00090D70 File Offset: 0x0008EF70
	[Token(Token = "0x6001B0B")]
	[Address(RVA = "0x54BF20", Offset = "0x54A520", VA = "0x18054BF20", Slot = "68")]
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

	// Token: 0x06001B0C RID: 6924 RVA: 0x00090DE4 File Offset: 0x0008EFE4
	[Token(Token = "0x6001B0C")]
	[Address(RVA = "0x54C090", Offset = "0x54A690", VA = "0x18054C090", Slot = "69")]
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

	// Token: 0x06001B0D RID: 6925 RVA: 0x00090E58 File Offset: 0x0008F058
	[Token(Token = "0x6001B0D")]
	[Address(RVA = "0x54BCE0", Offset = "0x54A2E0", VA = "0x18054BCE0", Slot = "43")]
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

	// Token: 0x06001B0E RID: 6926 RVA: 0x00090ECC File Offset: 0x0008F0CC
	[Token(Token = "0x6001B0E")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SuperThreePeater_sp()
	{
	}
}
