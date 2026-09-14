using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200059D RID: 1437
[Token(Token = "0x200059D")]
public class UltimateCactus : Cactus
{
	// Token: 0x06001AA8 RID: 6824 RVA: 0x0008F3F8 File Offset: 0x0008D5F8
	[Token(Token = "0x6001AA8")]
	[Address(RVA = "0x4FA380", Offset = "0x4F8980", VA = "0x1804FA380", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Bullet bullet = base.Shoot1();
		bullet.from = this;
		return bullet;
	}

	// Token: 0x06001AA9 RID: 6825 RVA: 0x0008F41C File Offset: 0x0008D61C
	[Token(Token = "0x6001AA9")]
	[Address(RVA = "0x4F9CD0", Offset = "0x4F82D0", VA = "0x1804F9CD0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.shootingLevel = (int)((ulong)200L);
	}

	// Token: 0x06001AAA RID: 6826 RVA: 0x0008F43C File Offset: 0x0008D63C
	[Token(Token = "0x6001AAA")]
	[Address(RVA = "0x4F9D70", Offset = "0x4F8370", VA = "0x1804F9D70", Slot = "20")]
	public override void KillZombie(Zombie zombie)
	{
		base.KillZombie(zombie);
		if (zombie == 0)
		{
			Board board = this.board;
			this.anim.SetTrigger("super");
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001AAB RID: 6827 RVA: 0x0008F474 File Offset: 0x0008D674
	[Token(Token = "0x6001AAB")]
	[Address(RVA = "0x4FA400", Offset = "0x4F8A00", VA = "0x1804FA400", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		Animator anim = this.anim;
		float speed = anim.speed;
		if (anim == 0)
		{
		}
	}

	// Token: 0x06001AAC RID: 6828 RVA: 0x0008F49C File Offset: 0x0008D69C
	[Token(Token = "0x6001AAC")]
	[Address(RVA = "0x4F9CF0", Offset = "0x4F82F0", VA = "0x1804F9CF0", Slot = "35")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		Animator anim = this.anim;
		float speed = anim.speed;
		if (anim == 0)
		{
			base.Crashed(level, soundID, zombie);
		}
	}

	// Token: 0x06001AAD RID: 6829 RVA: 0x0008F4CC File Offset: 0x0008D6CC
	[Token(Token = "0x6001AAD")]
	[Address(RVA = "0x4F9FE0", Offset = "0x4F85E0", VA = "0x1804F9FE0", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		this.anim.SetTrigger("super");
	}

	// Token: 0x06001AAE RID: 6830 RVA: 0x0008F4F0 File Offset: 0x0008D6F0
	[Token(Token = "0x6001AAE")]
	[Address(RVA = "0x3AAC80", Offset = "0x3A9280", VA = "0x1803AAC80", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_ultimateCactus;
	}

	// Token: 0x06001AAF RID: 6831 RVA: 0x0008F500 File Offset: 0x0008D700
	[Token(Token = "0x6001AAF")]
	[Address(RVA = "0x4FA3D0", Offset = "0x4F89D0", VA = "0x1804FA3D0")]
	private void StartShooting()
	{
		this.theStatus = (PlantStatus)((ulong)13L);
		this.flashCountDown = 10f;
	}

	// Token: 0x06001AB0 RID: 6832 RVA: 0x0008F524 File Offset: 0x0008D724
	[Token(Token = "0x6001AB0")]
	[Address(RVA = "0x4FA3F0", Offset = "0x4F89F0", VA = "0x1804FA3F0")]
	private void StopShooting()
	{
		int num = 0;
		this.theStatus = (PlantStatus)num;
		this.flashCountDown = (float)num;
	}

	// Token: 0x06001AB1 RID: 6833 RVA: 0x0008F544 File Offset: 0x0008D744
	[Token(Token = "0x6001AB1")]
	[Address(RVA = "0x4FA030", Offset = "0x4F8630", VA = "0x1804FA030", Slot = "18")]
	protected override void OnFixedUpdate()
	{
		base.OnFixedUpdate();
		Animator anim = this.anim;
		float speed = anim.speed;
		if (anim != 0)
		{
			Transform shoot = this.shoot;
			Vector3 vector;
			float z = vector.z;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
			float attributeSpeed = this.attributeSpeed;
			int num = 0;
			if (1f > attributeSpeed)
			{
			}
			CreateBullet instance = CreateBullet.Instance;
			BulletType bulletType = this.GetBulletType();
			float fixedDeltaTime = Time.fixedDeltaTime;
			float time = Time.time;
			Bullet bullet;
			Transform transform = bullet.transform;
			int attackDamage = this.attackDamage;
			bullet.Damage = attackDamage;
			bullet.from = this;
			PlantType thePlantType = this.thePlantType;
			num++;
			bullet.fromType = thePlantType;
		}
	}

	// Token: 0x06001AB2 RID: 6834 RVA: 0x0008F608 File Offset: 0x0008D808
	[Token(Token = "0x6001AB2")]
	[Address(RVA = "0x4F9E20", Offset = "0x4F8420", VA = "0x1804F9E20", Slot = "24")]
	protected override void OnAfterInitText()
	{
		Board board = this.board;
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001AB3 RID: 6835 RVA: 0x0008F640 File Offset: 0x0008D840
	[Token(Token = "0x6001AB3")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public UltimateCactus()
	{
	}
}
