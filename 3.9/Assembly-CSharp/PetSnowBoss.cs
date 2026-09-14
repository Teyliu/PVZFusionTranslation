using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200028B RID: 651
[Token(Token = "0x200028B")]
public class PetSnowBoss : MiniPet
{
	// Token: 0x06000BB9 RID: 3001 RVA: 0x00042FCC File Offset: 0x000411CC
	[Token(Token = "0x6000BB9")]
	[Address(RVA = "0x429690", Offset = "0x427C90", VA = "0x180429690", Slot = "11")]
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
				PetSnowBoss.<>c.<>9__5_0 = delegate(Zombie z)
				{
					int num6 = 0;
					return z.HasBuff((EffectType)num6);
				};
			}
			int size = Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(allZombies, <>9__5_))._size;
			int num5 = 0;
			this.coldCount = size;
			List<Zombie> allZombies2 = Lawnf.GetAllZombies(num5 != 0);
			Func<Zombie, bool> func;
			if (PetSnowBoss.<>c.<>9__5_1 == 0)
			{
				func = (Zombie z) => z.HasBuff((EffectType)((uint)2));
				PetSnowBoss.<>c.<>9__5_1 = func;
			}
			int size2 = Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(allZombies2, func))._size;
			this.freezeCount = size2;
		}
	}

	// Token: 0x06000BBA RID: 3002 RVA: 0x000430D0 File Offset: 0x000412D0
	[Token(Token = "0x6000BBA")]
	[Address(RVA = "0x427620", Offset = "0x425C20", VA = "0x180427620", Slot = "18")]
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

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x06000BBB RID: 3003 RVA: 0x00043134 File Offset: 0x00041334
	// (set) Token: 0x06000BBC RID: 3004 RVA: 0x0004315C File Offset: 0x0004135C
	[Token(Token = "0x170000D4")]
	public override float Damage
	{
		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x429AA0", Offset = "0x4280A0", VA = "0x180429AA0", Slot = "7")]
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
		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x3FC6E0", Offset = "0x3FACE0", VA = "0x1803FC6E0", Slot = "8")]
		set
		{
			this.damage = value;
		}
	}

	// Token: 0x06000BBD RID: 3005 RVA: 0x00043170 File Offset: 0x00041370
	[Token(Token = "0x6000BBD")]
	[Address(RVA = "0x4291E0", Offset = "0x4277E0", VA = "0x1804291E0", Slot = "9")]
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

	// Token: 0x06000BBE RID: 3006 RVA: 0x00043274 File Offset: 0x00041474
	[Token(Token = "0x6000BBE")]
	[Address(RVA = "0x4299E0", Offset = "0x427FE0", VA = "0x1804299E0")]
	private IEnumerator Shoot()
	{
		PetSnowBoss.<Shoot>d__11 <Shoot>d__;
		<Shoot>d__.System.IDisposable.Dispose();
		<Shoot>d__.<>1__state = (int)((ulong)0L);
		<Shoot>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000BBF RID: 3007 RVA: 0x00043298 File Offset: 0x00041498
	[Token(Token = "0x6000BBF")]
	[Address(RVA = "0x429A50", Offset = "0x428050", VA = "0x180429A50")]
	public PetSnowBoss()
	{
	}

	// Token: 0x040007B9 RID: 1977
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40007B9")]
	public ParticleSystem particle;

	// Token: 0x040007BA RID: 1978
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40007BA")]
	public GameObject preShootPrefab;

	// Token: 0x040007BB RID: 1979
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40007BB")]
	private Bullet lastBullet;

	// Token: 0x040007BC RID: 1980
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40007BC")]
	private int coldCount;

	// Token: 0x040007BD RID: 1981
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x40007BD")]
	private int freezeCount;
}
