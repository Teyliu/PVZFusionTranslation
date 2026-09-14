using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005B2 RID: 1458
[Token(Token = "0x20005B2")]
public class SuperSnowGatling : Shooter
{
	// Token: 0x06001AE9 RID: 6889 RVA: 0x000901FC File Offset: 0x0008E3FC
	[Token(Token = "0x6001AE9")]
	[Address(RVA = "0x54A960", Offset = "0x548F60", VA = "0x18054A960", Slot = "72")]
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

	// Token: 0x06001AEA RID: 6890 RVA: 0x0009024C File Offset: 0x0008E44C
	[Token(Token = "0x6001AEA")]
	[Address(RVA = "0x54A890", Offset = "0x548E90", VA = "0x18054A890")]
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

	// Token: 0x06001AEB RID: 6891 RVA: 0x0009029C File Offset: 0x0008E49C
	[Token(Token = "0x6001AEB")]
	[Address(RVA = "0x54A590", Offset = "0x548B90", VA = "0x18054A590", Slot = "68")]
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

	// Token: 0x06001AEC RID: 6892 RVA: 0x00090368 File Offset: 0x0008E568
	[Token(Token = "0x6001AEC")]
	[Address(RVA = "0x54A340", Offset = "0x548940", VA = "0x18054A340", Slot = "70")]
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

	// Token: 0x06001AED RID: 6893 RVA: 0x000903C4 File Offset: 0x0008E5C4
	[Token(Token = "0x6001AED")]
	[Address(RVA = "0x54ABB0", Offset = "0x5491B0", VA = "0x18054ABB0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
		}
	}

	// Token: 0x06001AEE RID: 6894 RVA: 0x000903E0 File Offset: 0x0008E5E0
	[Token(Token = "0x6001AEE")]
	[Address(RVA = "0x54A7E0", Offset = "0x548DE0", VA = "0x18054A7E0", Slot = "73")]
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

	// Token: 0x06001AEF RID: 6895 RVA: 0x00090434 File Offset: 0x0008E634
	[Token(Token = "0x6001AEF")]
	[Address(RVA = "0x54A4C0", Offset = "0x548AC0", VA = "0x18054A4C0", Slot = "44")]
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

	// Token: 0x06001AF0 RID: 6896 RVA: 0x00090480 File Offset: 0x0008E680
	[Token(Token = "0x6001AF0")]
	[Address(RVA = "0x54AB70", Offset = "0x549170", VA = "0x18054AB70", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		float num = this.timer;
		int num2 = 0;
		if (num > (float)num2)
		{
		}
	}

	// Token: 0x06001AF1 RID: 6897 RVA: 0x0009049C File Offset: 0x0008E69C
	[Token(Token = "0x6001AF1")]
	[Address(RVA = "0x54A310", Offset = "0x548910", VA = "0x18054A310", Slot = "34")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		float num = this.timer;
		int num2 = 0;
		if (num > (float)num2)
		{
		}
		base.Crashed(level, soundID, zombie);
	}

	// Token: 0x06001AF2 RID: 6898 RVA: 0x000904C4 File Offset: 0x0008E6C4
	[Token(Token = "0x6001AF2")]
	[Address(RVA = "0x549F80", Offset = "0x548580", VA = "0x180549F80", Slot = "39")]
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

	// Token: 0x06001AF3 RID: 6899 RVA: 0x00090604 File Offset: 0x0008E804
	[Token(Token = "0x6001AF3")]
	[Address(RVA = "0x54AA30", Offset = "0x549030", VA = "0x18054AA30")]
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

	// Token: 0x06001AF4 RID: 6900 RVA: 0x0009065C File Offset: 0x0008E85C
	[Token(Token = "0x6001AF4")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SuperSnowGatling()
	{
	}

	// Token: 0x04000F09 RID: 3849
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000F09")]
	protected float timer;
}
