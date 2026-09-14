using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001E3 RID: 483
[Token(Token = "0x20001E3")]
public class BulletMovement
{
	// Token: 0x0600082B RID: 2091 RVA: 0x00029778 File Offset: 0x00027978
	[Token(Token = "0x600082B")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "4")]
	public virtual void PositionUpdate()
	{
	}

	// Token: 0x0600082C RID: 2092 RVA: 0x00029788 File Offset: 0x00027988
	[Token(Token = "0x600082C")]
	[Address(RVA = "0x8E15E0", Offset = "0x8DFBE0", VA = "0x1808E15E0", Slot = "5")]
	public virtual void ShadowUpdate()
	{
		Bullet bullet = this.bullet;
		Mouse instance = Mouse.Instance;
		Transform transform = bullet.transform;
		Bullet bullet2 = this.bullet;
		Bullet bullet3 = this.bullet;
		Transform shadow = bullet3.shadow;
		Transform transform2 = bullet3.transform;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
	}

	// Token: 0x0600082D RID: 2093 RVA: 0x000297DC File Offset: 0x000279DC
	[Token(Token = "0x600082D")]
	[Address(RVA = "0x8E1750", Offset = "0x8DFD50", VA = "0x1808E1750", Slot = "6")]
	public virtual void UpdateHitFilter()
	{
		List<BulletHitFilter> hitFilters = this.bullet.hitFilters;
		int num = 0;
		hitFilters._size = num;
		List<BulletHitFilter> hitFilters2 = this.bullet.hitFilters;
		int size = hitFilters2._size;
		hitFilters2._size = 1;
		List<BulletHitFilter> hitFilters3 = this.bullet.hitFilters;
		int size2 = hitFilters3._size;
	}

	// Token: 0x0600082E RID: 2094 RVA: 0x00029844 File Offset: 0x00027A44
	[Token(Token = "0x600082E")]
	[Address(RVA = "0x8E0E90", Offset = "0x8DF490", VA = "0x1808E0E90")]
	public bool CanHit(Zombie zombie)
	{
		ulong num2;
		do
		{
			int i = 0;
			int num = 0;
			if (zombie == num)
			{
				break;
			}
			Team <Team>k__BackingField = zombie.<Team>k__BackingField;
			Bullet bullet = this.bullet;
			if (<Team>k__BackingField == bullet.<Team>k__BackingField)
			{
				break;
			}
			List<BulletHitFilter> hitFilters = bullet.hitFilters;
			bool flag;
			if (flag)
			{
				while (i > 6)
				{
				}
				int theZombieRow = zombie.theZombieRow;
				Bullet bullet2 = this.bullet;
				while (theZombieRow == bullet2.theBulletRow)
				{
				}
				Zombie targetZombie = this.bullet.targetZombie;
				if (!(zombie != targetZombie) || !Lawnf.InLandStatus(zombie.theStatus))
				{
					continue;
				}
				while (zombie.theStatus != ZombieStatus.Flying)
				{
				}
				while (zombie.theStatus != ZombieStatus.Snokle_inWater)
				{
				}
				while (zombie.theStatus != ZombieStatus.Miner_digging)
				{
				}
			}
		}
		while (num2 != (ulong)0L);
		throw new NullReferenceException();
	}

	// Token: 0x0600082F RID: 2095 RVA: 0x00029910 File Offset: 0x00027B10
	[Token(Token = "0x600082F")]
	[Address(RVA = "0x8E1160", Offset = "0x8DF760", VA = "0x1808E1160")]
	public bool CanSearch(Zombie zombie)
	{
		ulong num2;
		do
		{
			int i = 0;
			int num = 0;
			if (zombie == num)
			{
				break;
			}
			Team <Team>k__BackingField = zombie.<Team>k__BackingField;
			Bullet bullet = this.bullet;
			if (<Team>k__BackingField == bullet.<Team>k__BackingField)
			{
				break;
			}
			List<BulletHitFilter> hitFilters = bullet.hitFilters;
			bool flag;
			if (flag)
			{
				while (i > 6)
				{
				}
				int theZombieRow = zombie.theZombieRow;
				Bullet bullet2 = this.bullet;
				while (theZombieRow == bullet2.theBulletRow)
				{
				}
				if (zombie.Alive || !Lawnf.InLandStatus(zombie.theStatus))
				{
					continue;
				}
				while (zombie.theStatus != ZombieStatus.Flying)
				{
				}
				while (zombie.theStatus != ZombieStatus.Snokle_inWater)
				{
				}
				while (zombie.theStatus != ZombieStatus.Miner_digging)
				{
				}
			}
		}
		while (num2 != (ulong)0L);
		throw new NullReferenceException();
	}

	// Token: 0x06000830 RID: 2096 RVA: 0x000299C4 File Offset: 0x00027BC4
	[Token(Token = "0x6000830")]
	[Address(RVA = "0x8E1400", Offset = "0x8DFA00", VA = "0x1808E1400")]
	public static BulletMovement GetMovement(BulletMoveWay moveWay)
	{
		if (moveWay <= BulletMoveWay.SuperGatling)
		{
		}
		BulletMovement bulletMovement;
		bulletMovement.PositionUpdate();
		return bulletMovement;
	}

	// Token: 0x06000831 RID: 2097 RVA: 0x000299F0 File Offset: 0x00027BF0
	[Token(Token = "0x6000831")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public BulletMovement()
	{
		this.PositionUpdate();
	}

	// Token: 0x040003D1 RID: 977
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003D1")]
	public Bullet bullet;
}
