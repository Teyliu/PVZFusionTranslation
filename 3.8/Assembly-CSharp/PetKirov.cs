using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000283 RID: 643
[Token(Token = "0x2000283")]
public class PetKirov : MiniPet
{
	// Token: 0x06000B93 RID: 2963 RVA: 0x00042E40 File Offset: 0x00041040
	[Token(Token = "0x6000B93")]
	[Address(RVA = "0x3D9DA0", Offset = "0x3D83A0", VA = "0x1803D9DA0")]
	private void Start()
	{
	}

	// Token: 0x06000B94 RID: 2964 RVA: 0x00042E50 File Offset: 0x00041050
	[Token(Token = "0x6000B94")]
	[Address(RVA = "0x3DAC40", Offset = "0x3D9240", VA = "0x1803DAC40", Slot = "11")]
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

	// Token: 0x06000B95 RID: 2965 RVA: 0x00042EDC File Offset: 0x000410DC
	[Token(Token = "0x6000B95")]
	[Address(RVA = "0x3DADA0", Offset = "0x3D93A0", VA = "0x1803DADA0")]
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

	// Token: 0x06000B96 RID: 2966 RVA: 0x00042F2C File Offset: 0x0004112C
	[Token(Token = "0x6000B96")]
	[Address(RVA = "0x3DA670", Offset = "0x3D8C70", VA = "0x1803DA670", Slot = "9")]
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
							Func<Zombie, bool> func;
							PetKirov.<>c.<>9__5_0 = func;
						}
						IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(zombiesByRow, <>9__5_);
						Func<Zombie, float> func2;
						if (PetKirov.<>c.<>9__5_1 == 0)
						{
							PetKirov.<>c.<>9__5_1 = func2;
						}
						Zombie zombie3 = Enumerable.FirstOrDefault<Zombie>(Enumerable.OrderBy<Zombie, float>(enumerable, func2));
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

	// Token: 0x06000B97 RID: 2967 RVA: 0x000430A0 File Offset: 0x000412A0
	[Token(Token = "0x6000B97")]
	[Address(RVA = "0x3DAF70", Offset = "0x3D9570", VA = "0x1803DAF70", Slot = "18")]
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

	// Token: 0x06000B98 RID: 2968 RVA: 0x00043100 File Offset: 0x00041300
	[Token(Token = "0x6000B98")]
	[Address(RVA = "0x3DAFF0", Offset = "0x3D95F0", VA = "0x1803DAFF0")]
	public PetKirov()
	{
	}

	// Token: 0x040007A8 RID: 1960
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40007A8")]
	private Zombie target;

	// Token: 0x040007A9 RID: 1961
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40007A9")]
	private int cnt;
}
