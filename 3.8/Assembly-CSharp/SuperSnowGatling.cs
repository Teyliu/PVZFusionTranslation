using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000581 RID: 1409
[Token(Token = "0x2000581")]
public class SuperSnowGatling : Shooter
{
	// Token: 0x06001A03 RID: 6659 RVA: 0x0008BE78 File Offset: 0x0008A078
	[Token(Token = "0x6001A03")]
	[Address(RVA = "0x4EAB00", Offset = "0x4E9100", VA = "0x1804EAB00", Slot = "73")]
	protected virtual void SuperShoot(float timer = 5f)
	{
		this.timer = timer;
		this.flashCountDown = timer;
		this.AttributeEvent();
		this.anim.SetBool("shooting", true);
		int num = 0;
		ulong num2;
		base.Recover(timer, (DamageType)num, true, num2 != 0UL);
		this.attributeCount = (int)((ulong)0L);
	}

	// Token: 0x06001A04 RID: 6660 RVA: 0x0008BEC8 File Offset: 0x0008A0C8
	[Token(Token = "0x6001A04")]
	[Address(RVA = "0x4EAA30", Offset = "0x4E9030", VA = "0x1804EAA30")]
	protected void SuperShoot2(float timer = 5f)
	{
		this.timer = timer;
		this.flashCountDown = timer;
		this.AttributeEvent();
		this.anim.SetBool("shooting", true);
		int num = 0;
		ulong num2;
		base.Recover(timer, (DamageType)num, true, num2 != 0UL);
		this.attributeCount = (int)((ulong)0L);
	}

	// Token: 0x06001A05 RID: 6661 RVA: 0x0008BF18 File Offset: 0x0008A118
	[Token(Token = "0x6001A05")]
	[Address(RVA = "0x4EA730", Offset = "0x4E8D30", VA = "0x1804EA730", Slot = "69")]
	protected override Bullet Shoot1()
	{
		bool flag;
		if (flag)
		{
		}
		uint num2;
		int num = global::UnityEngine.Random.Range(0, (int)num2);
		bool keepShooting = this.keepShooting;
		Board board = this.board;
		if (!keepShooting)
		{
			Transform shoot = this.shoot;
			CreateBullet instance = CreateBullet.Instance;
			BulletType bulletType = this.GetBulletType();
			int attackDamage = this.attackDamage;
			Bullet bullet;
			bullet.Damage = attackDamage;
			BulletType theBulletType = bullet.theBulletType;
			if (theBulletType == BulletType.Bullet_firePea_yellow)
			{
				int num3 = bullet._damage;
				num3 += 20;
			}
			if (theBulletType == BulletType.Bullet_hypnoPea)
			{
				int num4 = bullet._damage;
				num4 += 10;
				bullet.Damage = num4;
			}
			PlantType thePlantType = this.thePlantType;
			bullet.fromType = thePlantType;
			GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
			return bullet;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001A06 RID: 6662 RVA: 0x0008BFE4 File Offset: 0x0008A1E4
	[Token(Token = "0x6001A06")]
	[Address(RVA = "0x4EA4E0", Offset = "0x4E8AE0", VA = "0x1804EA4E0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		for (;;)
		{
			int num = 0;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
			bool flag;
			ulong num3;
			if (flag)
			{
				int num2 = 0;
				if (num != num2)
				{
					break;
				}
			}
			else if (num3 == (ulong)0L)
			{
				return BulletType.Bullet_snowPea;
			}
		}
		return BulletType.Bullet_extremeSnowPea;
	}

	// Token: 0x06001A07 RID: 6663 RVA: 0x0008C040 File Offset: 0x0008A240
	[Token(Token = "0x6001A07")]
	[Address(RVA = "0x4EAD50", Offset = "0x4E9350", VA = "0x1804EAD50", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
		}
	}

	// Token: 0x06001A08 RID: 6664 RVA: 0x0008C05C File Offset: 0x0008A25C
	[Token(Token = "0x6001A08")]
	[Address(RVA = "0x4EA980", Offset = "0x4E8F80", VA = "0x1804EA980", Slot = "74")]
	protected virtual void ShootingUpdate()
	{
		float num = this.timer;
		int num2 = 0;
		if (num > (float)num2)
		{
			float deltaTime = Time.deltaTime;
			this.timer = num;
			Animator anim = this.anim;
			this.timer = 0f;
			int num3 = 0;
			anim.SetBool("shooting", num3 != 0);
		}
	}

	// Token: 0x06001A09 RID: 6665 RVA: 0x0008C0B0 File Offset: 0x0008A2B0
	[Token(Token = "0x6001A09")]
	[Address(RVA = "0x4EA660", Offset = "0x4E8C60", VA = "0x1804EA660", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.thePlantAttackCountDown = num;
		if (base.Shootable())
		{
			this.anim.SetTrigger("shoot");
		}
	}

	// Token: 0x06001A0A RID: 6666 RVA: 0x0008C0FC File Offset: 0x0008A2FC
	[Token(Token = "0x6001A0A")]
	[Address(RVA = "0x4EAD10", Offset = "0x4E9310", VA = "0x1804EAD10", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		float num = this.timer;
		int num2 = 0;
		if (num > (float)num2)
		{
		}
	}

	// Token: 0x06001A0B RID: 6667 RVA: 0x0008C118 File Offset: 0x0008A318
	[Token(Token = "0x6001A0B")]
	[Address(RVA = "0x4EA4B0", Offset = "0x4E8AB0", VA = "0x1804EA4B0", Slot = "35")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		float num = this.timer;
		int num2 = 0;
		if (num > (float)num2)
		{
		}
		base.Crashed(level, soundID, zombie);
	}

	// Token: 0x06001A0C RID: 6668 RVA: 0x0008C140 File Offset: 0x0008A340
	[Token(Token = "0x6001A0C")]
	[Address(RVA = "0x4EA120", Offset = "0x4E8720", VA = "0x1804EA120", Slot = "40")]
	protected override void AttributeEvent()
	{
		int attackDamage = this.attackDamage;
		bool flag = Lawnf.TravelUltimate((UltiBuff)((uint)51));
		Transform shoot = this.shoot;
		float num = global::UnityEngine.Random.Range(-15f, 15f);
		float num2 = global::UnityEngine.Random.Range(12f, 14f);
		float num3 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		float num4 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		float num5 = global::UnityEngine.Random.Range(-15f, 15f);
		num2 = global::UnityEngine.Random.Range(12f, 14f);
		num3 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		float num6 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		num5 = global::UnityEngine.Random.Range(-15f, 15f);
		num2 = global::UnityEngine.Random.Range(12f, 14f);
		num3 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		float num7 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
		int num8 = 0;
		base.AttributeCountdown = (float)num8;
		Animator anim = this.anim;
		int num9 = 0;
		anim.SetBool("shooting", num9 != 0);
	}

	// Token: 0x06001A0D RID: 6669 RVA: 0x0008C27C File Offset: 0x0008A47C
	[Token(Token = "0x6001A0D")]
	[Address(RVA = "0x4EABD0", Offset = "0x4E91D0", VA = "0x1804EABD0")]
	private void SuperShoot(float angle, float speed, float x, float y, BulletMoveWay mw, int dmg)
	{
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		Bullet bullet;
		Transform transform = bullet.transform;
		int num = 0;
		int num2 = 0;
		transform.Rotate((float)num2, (float)num, x);
		bullet.normalSpeed = speed;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001A0E RID: 6670 RVA: 0x0008C2D4 File Offset: 0x0008A4D4
	[Token(Token = "0x6001A0E")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SuperSnowGatling()
	{
	}

	// Token: 0x04000E4A RID: 3658
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E4A")]
	protected float timer;
}
