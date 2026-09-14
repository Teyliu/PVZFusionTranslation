using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000285 RID: 645
[Token(Token = "0x2000285")]
public class PetSnowBoss : MiniPet
{
	// Token: 0x06000B9D RID: 2973 RVA: 0x00043180 File Offset: 0x00041380
	[Token(Token = "0x6000B9D")]
	[Address(RVA = "0x3DB4F0", Offset = "0x3D9AF0", VA = "0x1803DB4F0", Slot = "11")]
	protected override void AttackReady(bool moveOver)
	{
		int num = 0;
		if (!moveOver)
		{
			int num2 = 0;
			base.AttackReady(num2 != 0);
			this.anim.SetTrigger("shoot");
			base.Invoke("SetTarget", 1f);
			uint num3;
			GameAPP.PlaySound((int)num3, 0.5f, 1f);
			this.lastBullet = num;
			ParticleSystem.MainModule main = this.particle.main;
			uint num4;
			base.GetExperience((int)num4);
			List<Zombie> allZombies = Lawnf.GetAllZombies(false);
			Func<Zombie, bool> <>9__5_ = PetSnowBoss.<>c.<>9__5_0;
			if (<>9__5_ == 0)
			{
				Func<Zombie, bool> func;
				PetSnowBoss.<>c.<>9__5_0 = func;
			}
			int size = Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(allZombies, <>9__5_))._size;
			int num5 = 0;
			this.coldCount = size;
			List<Zombie> allZombies2 = Lawnf.GetAllZombies(num5 != 0);
			Func<Zombie, bool> func2;
			if (PetSnowBoss.<>c.<>9__5_1 == 0)
			{
				PetSnowBoss.<>c.<>9__5_1 = func2;
			}
			int size2 = Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(allZombies2, func2))._size;
			this.freezeCount = size2;
		}
	}

	// Token: 0x06000B9E RID: 2974 RVA: 0x00043264 File Offset: 0x00041464
	[Token(Token = "0x6000B9E")]
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

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x06000B9F RID: 2975 RVA: 0x000432C8 File Offset: 0x000414C8
	// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x000432F0 File Offset: 0x000414F0
	[Token(Token = "0x17000096")]
	public override float Damage
	{
		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x3DB900", Offset = "0x3D9F00", VA = "0x1803DB900", Slot = "7")]
		get
		{
			int level = this.level;
			if (level == 2)
			{
				float num;
				return num;
			}
			if (level == 3)
			{
			}
			float num2;
			return num2;
		}
		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x3B0420", Offset = "0x3AEA20", VA = "0x1803B0420", Slot = "8")]
		set
		{
			this.damage = value;
		}
	}

	// Token: 0x06000BA1 RID: 2977 RVA: 0x00043304 File Offset: 0x00041504
	[Token(Token = "0x6000BA1")]
	[Address(RVA = "0x3DB040", Offset = "0x3D9640", VA = "0x1803DB040", Slot = "9")]
	protected override void AnimAttack()
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		PetSnowBoss.<Shoot>d__11 <Shoot>d__;
		<Shoot>d__.System.IDisposable.Dispose();
		<Shoot>d__.<>1__state = num2;
		<Shoot>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Shoot>d__);
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot2 = this.shoot;
		Bullet bullet;
		Transform transform = bullet.transform;
		Transform shoot3 = this.shoot;
		float normalSpeed = bullet.normalSpeed;
		bullet.normalSpeed = normalSpeed;
		float damage = this.Damage;
		Bullet bullet2 = this.lastBullet;
		int num4 = 0;
		int num5 = 0;
		if (bullet2 != num5)
		{
			this.lastBullet.transform.GetPositionAndRotation(num, num4);
			this.shoot.GetPositionAndRotation(num, num3);
			CreateBullet instance2 = CreateBullet.Instance;
			int num6 = 0;
			Bullet bullet3;
			bullet3.transform.rotation = num6;
			float normalSpeed2 = bullet3.normalSpeed;
			bullet3.normalSpeed = normalSpeed2;
			float damage2 = this.Damage;
			num2++;
		}
		this.lastBullet = bullet;
		ParticleSystem.MainModule main = this.particle.main;
	}

	// Token: 0x06000BA2 RID: 2978 RVA: 0x00043408 File Offset: 0x00041608
	[Token(Token = "0x6000BA2")]
	[Address(RVA = "0x3DB840", Offset = "0x3D9E40", VA = "0x1803DB840")]
	private IEnumerator Shoot()
	{
		PetSnowBoss.<Shoot>d__11 <Shoot>d__;
		<Shoot>d__.System.IDisposable.Dispose();
		<Shoot>d__.<>1__state = (int)((ulong)0L);
		<Shoot>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000BA3 RID: 2979 RVA: 0x0004342C File Offset: 0x0004162C
	[Token(Token = "0x6000BA3")]
	[Address(RVA = "0x3DB8B0", Offset = "0x3D9EB0", VA = "0x1803DB8B0")]
	public PetSnowBoss()
	{
	}

	// Token: 0x040007AD RID: 1965
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40007AD")]
	public ParticleSystem particle;

	// Token: 0x040007AE RID: 1966
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40007AE")]
	public GameObject preShootPrefab;

	// Token: 0x040007AF RID: 1967
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40007AF")]
	private Bullet lastBullet;

	// Token: 0x040007B0 RID: 1968
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40007B0")]
	private int coldCount;

	// Token: 0x040007B1 RID: 1969
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x40007B1")]
	private int freezeCount;
}
