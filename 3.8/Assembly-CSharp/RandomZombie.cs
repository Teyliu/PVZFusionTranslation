using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006BF RID: 1727
[Token(Token = "0x20006BF")]
public class RandomZombie : NormalZombie
{
	// Token: 0x060021F1 RID: 8689 RVA: 0x000B25A8 File Offset: 0x000B07A8
	[Token(Token = "0x60021F1")]
	[Address(RVA = "0x56BA40", Offset = "0x56A040", VA = "0x18056BA40", Slot = "62")]
	protected override void FirstArmorFall()
	{
		int num = 0;
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		Board board = this.board;
		int num2 = 0;
		if (((this.buff ? 1 : 0) == num && (global::UnityEngine.Random.Range(0, 50) != 0 || this.board != 0)) || !Lawnf.UnlockRandomTravelBuff(this.board))
		{
			int num3 = 0;
			Zombie zombie;
			if (zombie != num3)
			{
				if ((zombie.isMindControlled ? 1 : 0) == num)
				{
					Board board2 = this.board;
					BoardEntity boardEntity = board2.boardEntity;
					int theWave = board2.theWave;
					boardEntity.AddWaveZombie(theWave, zombie);
				}
				this.RandomEvent(zombie);
			}
		}
		Transform axis2 = this.axis;
		this.summoned = true;
		ParticleManager instance = ParticleManager.Instance;
		Vector3 vector2;
		float z2 = vector2.z;
		int theZombieRow = this.theZombieRow;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)11), num, theZombieRow, num4 != 0UL, (float)num2);
		base.Die(2);
	}

	// Token: 0x060021F2 RID: 8690 RVA: 0x000B268C File Offset: 0x000B088C
	[Token(Token = "0x60021F2")]
	[Address(RVA = "0x56CBF0", Offset = "0x56B1F0", VA = "0x18056CBF0", Slot = "33")]
	protected override void LoseHeadEvent()
	{
		if (!this.summoned)
		{
		}
	}

	// Token: 0x060021F3 RID: 8691 RVA: 0x000B26A4 File Offset: 0x000B08A4
	[Token(Token = "0x60021F3")]
	[Address(RVA = "0x56BD00", Offset = "0x56A300", VA = "0x18056BD00", Slot = "63")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int num = base.FirstArmorTakeDamage(theDamage);
		return 0;
	}

	// Token: 0x060021F4 RID: 8692 RVA: 0x000B26BC File Offset: 0x000B08BC
	[Token(Token = "0x60021F4")]
	[Address(RVA = "0x56CC90", Offset = "0x56B290", VA = "0x18056CC90", Slot = "74")]
	protected virtual Zombie SetRandomZombie(Vector3 pos)
	{
		while (!this.board.isEveStarted)
		{
			List<ZombieType> list = new List();
			Dictionary<ZombieType, GameObject> zombiePrefabs = GameAPP.resourcesManager.zombiePrefabs;
			bool flag;
			if (flag)
			{
				bool flag2;
				while (flag2)
				{
				}
				bool flag3;
				while (flag3)
				{
				}
				bool flag4;
				while (flag4)
				{
				}
			}
			ulong num;
			if (num == (ulong)0L)
			{
				int theBoardLevel = GameAPP.theBoardLevel;
				BoxType boxType;
				if (boxType != BoxType.Water)
				{
					if (RandomZombie.<>c.<>9__5_1 != 0)
					{
						goto IL_0091;
					}
					RandomZombie.<>c.<>9__5_1 = delegate(ZombieType z)
					{
						bool flag5;
						return flag5;
					};
				}
				int num2;
				if (RandomZombie.<>c.<>9__5_0 == 0)
				{
					Predicate<ZombieType> predicate = delegate(ZombieType z)
					{
						bool flag6;
						return flag6;
					};
					num2 = 0;
					RandomZombie.<>c.<>9__5_0 = predicate;
				}
				IL_0091:
				int num3 = 0;
				int num4;
				ulong num5;
				return CreateZombie.Instance.SetZombie(num4, (ZombieType)num3, (float)num2, num5 != 0UL);
			}
		}
		float z2 = pos.z;
		throw new NullReferenceException();
	}

	// Token: 0x060021F5 RID: 8693 RVA: 0x000B27AC File Offset: 0x000B09AC
	[Token(Token = "0x60021F5")]
	[Address(RVA = "0x56BD20", Offset = "0x56A320", VA = "0x18056BD20")]
	private Zombie GetEveZombie(Vector3 pos)
	{
		List<ZombieType> list = new List();
		int size = list._size;
		list._size = 1;
		list._syncRoot = (ulong)0L;
		int size2 = list._size;
		list._size = 1;
		int size3 = list._size;
		list._size = 1;
		int size4 = list._size;
		list._size = 1;
		int size5 = list._size;
		list._size = 1;
		int size6 = list._size;
		list._size = 1;
		int size7 = list._size;
		list._size = 1;
		int size8 = list._size;
		list._size = 1;
		int size9 = list._size;
		list._size = 1;
		int size10 = list._size;
		list._size = 1;
		int size11 = list._size;
		list._size = 1;
		int size12 = list._size;
		list._size = 1;
		int size13 = list._size;
		list._size = 1;
		int size14 = list._size;
		list._size = 1;
		int size15 = list._size;
		list._size = 1;
		int size16 = list._size;
		list._size = 1;
		int size17 = list._size;
		list._size = 1;
		int size18 = list._size;
		list._size = 1;
		int size19 = list._size;
		list._size = 1;
		int size20 = list._size;
		list._size = 1;
		int size21 = list._size;
		list._size = 1;
		int size22 = list._size;
		list._size = 1;
		int size23 = list._size;
		list._size = 1;
		int size24 = list._size;
		list._size = 1;
		int size25 = list._size;
		list._size = 1;
		int size26 = list._size;
		list._size = 1;
		int size27 = list._size;
		list._size = 1;
		int size28 = list._size;
		list._size = 1;
		int size29 = list._size;
		list._size = 1;
		int size30 = list._size;
		list._size = 1;
		int size31 = list._size;
		list._size = 1;
		int size32 = list._size;
		list._size = 1;
		int size33 = list._size;
		list._size = 1;
		int size34 = list._size;
		list._size = 1;
		int size35 = list._size;
		list._size = 1;
		int size36 = list._size;
		list._size = 1;
		int size37 = list._size;
		list._size = 1;
		int size38 = list._size;
		list._size = 1;
		int size39 = list._size;
		list._size = 1;
		int num = list._size;
		num = global::UnityEngine.Random.Range(0, num);
		ZombieType zombieType = list[num];
		CreateZombie instance = CreateZombie.Instance;
		CreateZombie instance2 = CreateZombie.Instance;
		int num2 = 0;
		Zombie zombie;
		if (zombie != num2 && zombie.theZombieType == ZombieType.ChickenImp)
		{
			int num3 = zombie.theHealth;
			num3 -= num2;
			zombie.theHealth = num3;
			int num4 = zombie.theMaxHealth;
			num4 -= num2;
			zombie.theMaxHealth = num4;
		}
		return zombie;
	}

	// Token: 0x060021F6 RID: 8694 RVA: 0x000B2A94 File Offset: 0x000B0C94
	[Token(Token = "0x60021F6")]
	[Address(RVA = "0x56CC10", Offset = "0x56B210", VA = "0x18056CC10", Slot = "75")]
	protected virtual void RandomEvent(Zombie zombie)
	{
		int num = global::UnityEngine.Random.Range(1, 7);
		if (this.board.isEveStarted)
		{
			int num2 = global::UnityEngine.Random.Range(1, 6);
		}
		float num3;
		Lawnf.SetZombieHealth(zombie, num3);
	}

	// Token: 0x060021F7 RID: 8695 RVA: 0x000B2AD0 File Offset: 0x000B0CD0
	[Token(Token = "0x60021F7")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "30")]
	protected override bool Instead(int damage)
	{
		return false;
	}

	// Token: 0x060021F8 RID: 8696 RVA: 0x000B2AE0 File Offset: 0x000B0CE0
	[Token(Token = "0x60021F8")]
	[Address(RVA = "0x5620A0", Offset = "0x5606A0", VA = "0x1805620A0")]
	public RandomZombie()
	{
	}

	// Token: 0x04001124 RID: 4388
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4001124")]
	private bool summoned;

	// Token: 0x04001125 RID: 4389
	[FieldOffset(Offset = "0x269")]
	[Token(Token = "0x4001125")]
	public bool buff;
}
