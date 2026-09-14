using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000289 RID: 649
[Token(Token = "0x2000289")]
public class PetKirov : MiniPet
{
	// Token: 0x06000BAF RID: 2991 RVA: 0x00042C7C File Offset: 0x00040E7C
	[Token(Token = "0x6000BAF")]
	[Address(RVA = "0x427F40", Offset = "0x426540", VA = "0x180427F40")]
	private void Start()
	{
	}

	// Token: 0x06000BB0 RID: 2992 RVA: 0x00042C8C File Offset: 0x00040E8C
	[Token(Token = "0x6000BB0")]
	[Address(RVA = "0x428DE0", Offset = "0x4273E0", VA = "0x180428DE0", Slot = "11")]
	protected override void AttackReady(bool moveOver)
	{
		Zombie zombie = this.FindLeftmostZombie();
		this.target = zombie;
		Zombie zombie2 = this.target;
		int num = 0;
		if (zombie2 == num)
		{
			this.SetTarget();
		}
		Zombie zombie3 = this.target;
		int num2 = 0;
		if (zombie3 != num2)
		{
			base.AttackReady(moveOver);
			List<Zombie> certainZombies = Lawnf.GetCertainZombies(this.board, (ZombieType)((uint)221));
			float num3;
			this.attackTimer = num3;
			this.anim.SetTrigger("shoot");
			base.GetExperience(5);
		}
	}

	// Token: 0x06000BB1 RID: 2993 RVA: 0x00042D18 File Offset: 0x00040F18
	[Token(Token = "0x6000BB1")]
	[Address(RVA = "0x428F40", Offset = "0x427540", VA = "0x180428F40")]
	private Zombie FindLeftmostZombie()
	{
		int num;
		int num2;
		bool flag;
		do
		{
			num = 0;
			num2 = 0;
			int num3 = 0;
			List<Zombie> zombiesByRow = Lawnf.GetZombiesByRow(this.thePetRow, num3 != 0);
		}
		while ((flag && !base.CheckZombie_Search(num)) || num2 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x06000BB2 RID: 2994 RVA: 0x00042D68 File Offset: 0x00040F68
	[Token(Token = "0x6000BB2")]
	[Address(RVA = "0x428810", Offset = "0x426E10", VA = "0x180428810", Slot = "9")]
	protected override void AnimAttack()
	{
		Transform shoot = this.shoot;
		int num = 0;
		if (!(shoot == num))
		{
			Zombie zombie = this.target;
			int num2 = 0;
			if (!(zombie == num2))
			{
				float damage = base.Damage;
				Transform shoot2 = this.shoot;
				CreateBullet instance = CreateBullet.Instance;
				Transform shoot3 = this.shoot;
				Zombie zombie2 = this.target;
				int num3 = 0;
				Transform shoot4 = this.shoot;
				Vector2 velocity = this.target.Velocity;
				Vector2 colliderPosition = this.target.ColliderPosition;
				int num4 = this.cnt;
				num4++;
				this.cnt = num4;
				if (num4 == 3)
				{
					Board board = this.board;
					this.cnt = num3;
					if (num3 < board.rowNum)
					{
						int num5 = 0;
						List<Zombie> zombiesByRow = Lawnf.GetZombiesByRow(num3, num5 != 0);
						Func<Zombie, bool> <>9__5_ = PetKirov.<>c.<>9__5_0;
						if (<>9__5_ == 0)
						{
							PetKirov.<>c.<>9__5_0 = (Zombie z) => Lawnf.InLandStatus(z.theStatus);
						}
						IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(zombiesByRow, <>9__5_);
						Func<Zombie, float> func;
						if (PetKirov.<>c.<>9__5_1 == 0)
						{
							PetKirov.<>c.<>9__5_1 = func;
						}
						Zombie zombie3 = Enumerable.FirstOrDefault<Zombie>(Enumerable.OrderBy<Zombie, float>(enumerable, func));
						int num6 = 0;
						if (zombie3 != num6)
						{
							int num7 = 0;
							uint num8;
							float boxXFromColumn = Lawnf.GetBoxXFromColumn((int)num8);
							float landY = this.mouse.GetLandY(boxXFromColumn, num3);
							CreateBullet instance2 = CreateBullet.Instance;
							Bullet bullet;
							bullet.Damage = num7;
							Vector2 velocity2 = zombie3.Velocity;
							Vector2 colliderPosition2 = zombie3.ColliderPosition;
						}
						Board board2 = this.board;
						num3++;
					}
				}
			}
		}
	}

	// Token: 0x06000BB3 RID: 2995 RVA: 0x00042EEC File Offset: 0x000410EC
	[Token(Token = "0x6000BB3")]
	[Address(RVA = "0x429110", Offset = "0x427710", VA = "0x180429110", Slot = "18")]
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

	// Token: 0x06000BB4 RID: 2996 RVA: 0x00042F4C File Offset: 0x0004114C
	[Token(Token = "0x6000BB4")]
	[Address(RVA = "0x429190", Offset = "0x427790", VA = "0x180429190")]
	public PetKirov()
	{
	}

	// Token: 0x040007B4 RID: 1972
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40007B4")]
	private Zombie target;

	// Token: 0x040007B5 RID: 1973
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40007B5")]
	private int cnt;
}
