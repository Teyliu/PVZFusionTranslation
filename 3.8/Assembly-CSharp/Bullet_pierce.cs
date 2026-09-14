using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000183 RID: 387
[Token(Token = "0x2000183")]
public class Bullet_pierce : Bullet
{
	// Token: 0x060006D1 RID: 1745 RVA: 0x000239F0 File Offset: 0x00021BF0
	[Token(Token = "0x60006D1")]
	[Address(RVA = "0x7DB9C0", Offset = "0x7D9FC0", VA = "0x1807DB9C0", Slot = "20")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		BulletMoveWay moveWay = this._moveWay;
		if (moveWay != BulletMoveWay.Convolute && moveWay != BulletMoveWay.Pirouette)
		{
			int penetrationTimes = this.penetrationTimes;
			bool flag;
			bool flag2;
			if (flag && flag2)
			{
				BulletMoveWay moveWay2 = this._moveWay;
				if (moveWay2 == BulletMoveWay.Free || moveWay2 == BulletMoveWay.Right_free || moveWay2 == BulletMoveWay.Freefly)
				{
					bool flag3;
					while (flag3)
					{
					}
					return;
				}
				int theBulletRow = this.theBulletRow;
			}
		}
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x00023A50 File Offset: 0x00021C50
	[Token(Token = "0x60006D2")]
	[Address(RVA = "0x7DB990", Offset = "0x7D9F90", VA = "0x1807DB990", Slot = "8")]
	public override void InitData()
	{
		base.InitData();
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x00023A64 File Offset: 0x00021C64
	[Token(Token = "0x60006D3")]
	[Address(RVA = "0x6BB760", Offset = "0x6B9D60", VA = "0x1806BB760", Slot = "27")]
	protected virtual void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)3L);
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x00023A7C File Offset: 0x00021C7C
	[Token(Token = "0x60006D4")]
	[Address(RVA = "0x7DBB90", Offset = "0x7DA190", VA = "0x1807DBB90", Slot = "22")]
	public override void TrackZombie(Zombie zombie)
	{
		Zombie targetZombie = this.targetZombie;
		bool flag = zombie == targetZombie;
		if (flag && !zombie.isMindControlled && zombie.theHealth > 0)
		{
			ZombieStatus theStatus = zombie.theStatus;
			if (theStatus > ZombieStatus.Miner_digging)
			{
				if (theStatus == ZombieStatus.Imp_fly || flag <= true || theStatus == ZombieStatus.Bungi_awake)
				{
					return;
				}
			}
			else if (theStatus <= ZombieStatus.Bungi_awake)
			{
			}
			base.HitZombie(zombie);
			int num = this.hitTimes;
			num++;
			this.hitTimes = num;
			base.Die();
			return;
		}
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x00023AF4 File Offset: 0x00021CF4
	[Token(Token = "0x60006D5")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_pierce()
	{
	}
}
