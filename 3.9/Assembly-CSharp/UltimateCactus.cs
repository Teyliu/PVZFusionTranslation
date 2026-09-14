using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005CE RID: 1486
[Token(Token = "0x20005CE")]
public class UltimateCactus : Cactus
{
	// Token: 0x06001B8E RID: 7054 RVA: 0x000937E4 File Offset: 0x000919E4
	[Token(Token = "0x6001B8E")]
	[Address(RVA = "0x5579B0", Offset = "0x555FB0", VA = "0x1805579B0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Bullet bullet = base.Shoot1();
		bullet.from = this;
		return bullet;
	}

	// Token: 0x06001B8F RID: 7055 RVA: 0x00093808 File Offset: 0x00091A08
	[Token(Token = "0x6001B8F")]
	[Address(RVA = "0x557280", Offset = "0x555880", VA = "0x180557280", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.shootingLevel = (int)((ulong)200L);
	}

	// Token: 0x06001B90 RID: 7056 RVA: 0x00093828 File Offset: 0x00091A28
	[Token(Token = "0x6001B90")]
	[Address(RVA = "0x557320", Offset = "0x555920", VA = "0x180557320", Slot = "20")]
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

	// Token: 0x06001B91 RID: 7057 RVA: 0x00093860 File Offset: 0x00091A60
	[Token(Token = "0x6001B91")]
	[Address(RVA = "0x557A30", Offset = "0x556030", VA = "0x180557A30", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		Animator anim = this.anim;
		float speed = anim.speed;
		if (anim == 0)
		{
		}
	}

	// Token: 0x06001B92 RID: 7058 RVA: 0x00093888 File Offset: 0x00091A88
	[Token(Token = "0x6001B92")]
	[Address(RVA = "0x5572A0", Offset = "0x5558A0", VA = "0x1805572A0", Slot = "34")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		Animator anim = this.anim;
		float speed = anim.speed;
		if (anim == 0)
		{
			base.Crashed(level, soundID, zombie);
		}
	}

	// Token: 0x06001B93 RID: 7059 RVA: 0x000938B8 File Offset: 0x00091AB8
	[Token(Token = "0x6001B93")]
	[Address(RVA = "0x557590", Offset = "0x555B90", VA = "0x180557590", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		this.anim.SetTrigger("super");
	}

	// Token: 0x06001B94 RID: 7060 RVA: 0x000938DC File Offset: 0x00091ADC
	[Token(Token = "0x6001B94")]
	[Address(RVA = "0x3F6A80", Offset = "0x3F5080", VA = "0x1803F6A80", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_ultimateCactus;
	}

	// Token: 0x06001B95 RID: 7061 RVA: 0x000938EC File Offset: 0x00091AEC
	[Token(Token = "0x6001B95")]
	[Address(RVA = "0x557A00", Offset = "0x556000", VA = "0x180557A00")]
	private void StartShooting()
	{
		this.theStatus = (PlantStatus)((ulong)13L);
		this.flashCountDown = 10f;
	}

	// Token: 0x06001B96 RID: 7062 RVA: 0x00093910 File Offset: 0x00091B10
	[Token(Token = "0x6001B96")]
	[Address(RVA = "0x557A20", Offset = "0x556020", VA = "0x180557A20")]
	private void StopShooting()
	{
		int num = 0;
		this.theStatus = (PlantStatus)num;
		this.flashCountDown = (float)num;
	}

	// Token: 0x06001B97 RID: 7063 RVA: 0x00093930 File Offset: 0x00091B30
	[Token(Token = "0x6001B97")]
	[Address(RVA = "0x5575E0", Offset = "0x555BE0", VA = "0x1805575E0", Slot = "18")]
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
			Bullet bullet;
			int size = bullet.hitFilters._size;
			float fixedDeltaTime = Time.fixedDeltaTime;
			float time = Time.time;
			Transform transform = bullet.transform;
			int attackDamage = this.attackDamage;
			bullet.Damage = attackDamage;
			bullet.from = this;
			PlantType thePlantType = this.thePlantType;
			num++;
			bullet.fromType = thePlantType;
		}
	}

	// Token: 0x06001B98 RID: 7064 RVA: 0x00093A08 File Offset: 0x00091C08
	[Token(Token = "0x6001B98")]
	[Address(RVA = "0x5573D0", Offset = "0x5559D0", VA = "0x1805573D0", Slot = "23")]
	protected override void OnAfterInitText()
	{
		Board board = this.board;
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001B99 RID: 7065 RVA: 0x00093A40 File Offset: 0x00091C40
	[Token(Token = "0x6001B99")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public UltimateCactus()
	{
	}
}
