using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001D8 RID: 472
[Token(Token = "0x20001D8")]
public class BulletHelper : MonoBehaviour
{
	// Token: 0x06000813 RID: 2067 RVA: 0x00029B1C File Offset: 0x00027D1C
	[Token(Token = "0x6000813")]
	[Address(RVA = "0x852A50", Offset = "0x851050", VA = "0x180852A50")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		if (!this.bullet.hit)
		{
			bool flag = collision.TryGetComponent<Zombie>(num);
			Bullet bullet = this.bullet;
			if (!flag)
			{
				if (bullet.targetProjectiles != (ulong)0L && bullet._moveWay == BulletMoveWay.Track && collision.TryGetComponent<AirProjectile>(num) && this.bullet.targetProjectiles.Contains(num))
				{
					int damage = this.bullet._damage;
					this.bullet.hit = true;
					this.bullet.HitLand();
					this.bullet.Die();
					return;
				}
			}
			else
			{
				BulletMoveWay moveWay = bullet._moveWay;
				if (moveWay > BulletMoveWay.Convolute)
				{
					if (moveWay == BulletMoveWay.Track_air_singleRow)
					{
						this.bullet.TrackZombieSingleRow(num);
						return;
					}
					if (moveWay == BulletMoveWay.Pirouette)
					{
						if (this.bullet.theBulletRow <= 8)
						{
						}
						this.bullet.KeepHiting(num);
						return;
					}
				}
				else
				{
					if (moveWay != BulletMoveWay.Track)
					{
						if (moveWay != BulletMoveWay.Convolute)
						{
							return;
						}
						Bullet bullet2 = this.bullet;
						if (bullet2.theBulletType == BulletType.Bullet_shulkLeaf)
						{
							Physics2D.IgnoreCollision(bullet2.col, collision);
						}
					}
					this.bullet.TrackZombie(num);
				}
			}
		}
	}

	// Token: 0x06000814 RID: 2068 RVA: 0x00029C48 File Offset: 0x00027E48
	[Token(Token = "0x6000814")]
	[Address(RVA = "0x852DA0", Offset = "0x8513A0", VA = "0x180852DA0")]
	private void PirouetteZombie(Zombie zombie)
	{
		if (!zombie.isMindControlled)
		{
			int theBulletRow = this.bullet.theBulletRow;
			if (zombie.theZombieRow == theBulletRow)
			{
				ZombieStatus theStatus = zombie.theStatus;
				if (theStatus > ZombieStatus.Miner_digging)
				{
					if (theBulletRow <= 8)
					{
					}
					if (theStatus == ZombieStatus.Bungi_awake)
					{
						return;
					}
				}
				else
				{
					while (zombie == (ulong)3L)
					{
					}
				}
				throw new NullReferenceException();
			}
		}
	}

	// Token: 0x06000815 RID: 2069 RVA: 0x00029C98 File Offset: 0x00027E98
	[Token(Token = "0x6000815")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public BulletHelper()
	{
	}

	// Token: 0x040003C6 RID: 966
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003C6")]
	public Bullet bullet;
}
