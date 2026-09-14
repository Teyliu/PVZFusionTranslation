using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000730 RID: 1840
[Token(Token = "0x2000730")]
public class UltimateHorse : Zombie
{
	// Token: 0x0600247F RID: 9343 RVA: 0x000BDEA0 File Offset: 0x000BC0A0
	[Token(Token = "0x600247F")]
	[Address(RVA = "0x5FFE20", Offset = "0x5FE420", VA = "0x1805FFE20", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)36L);
		this.attributeCountDown = 0.1f;
		Action action = delegate
		{
			this.shootable = true;
		};
		this.defaultAction = action;
	}

	// Token: 0x06002480 RID: 9344 RVA: 0x000BDEDC File Offset: 0x000BC0DC
	[Token(Token = "0x6002480")]
	[Address(RVA = "0x6007A0", Offset = "0x5FEDA0", VA = "0x1806007A0", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("tohorse");
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int column = base.Column;
		int columnNum = this.board.columnNum;
		Board board = this.board;
		int theZombieRow = this.theZombieRow;
		List<Plant> list = Lawnf.Get1x1Plants(columnNum, theZombieRow);
	}

	// Token: 0x06002481 RID: 9345 RVA: 0x000BDF98 File Offset: 0x000BC198
	[Token(Token = "0x6002481")]
	[Address(RVA = "0x600360", Offset = "0x5FE960", VA = "0x180600360", Slot = "21")]
	protected override void MoveUpdate()
	{
		base.MoveUpdate();
		float num = this.startRunTimer;
		int num2 = 0;
		if (num > (float)num2)
		{
			float deltaTime = Time.deltaTime;
			this.startRunTimer = num;
			Animator anim = this.anim;
			this.startRunTimer = 0f;
			anim.SetTrigger("run");
			base.ChangeStatus((ZombieStatus)((uint)36));
		}
	}

	// Token: 0x06002482 RID: 9346 RVA: 0x000BDFF8 File Offset: 0x000BC1F8
	[Token(Token = "0x6002482")]
	[Address(RVA = "0x600090", Offset = "0x5FE690", VA = "0x180600090", Slot = "28")]
	public override void Die(int reason = 0)
	{
		Animator anim = this.anim;
		this.theStatus = (ZombieStatus)((ulong)1L);
		anim.SetTrigger("GoDie");
	}

	// Token: 0x06002483 RID: 9347 RVA: 0x000BE028 File Offset: 0x000BC228
	[Token(Token = "0x6002483")]
	[Address(RVA = "0x5FFB90", Offset = "0x5FE190", VA = "0x1805FFB90", Slot = "24")]
	protected override void AttributeEvent()
	{
		int num2;
		do
		{
			int num = 0;
			if (this.shootable)
			{
				this.anim.SetTrigger("shoot");
			}
			float theSpeed = this.theSpeed;
			if (0 > (int)theSpeed || theSpeed > 1f)
			{
			}
			long theMaxHealth = this.theMaxHealth;
			this.theHealth = theMaxHealth;
			long theMaxHealth2 = this.theMaxHealth;
			this.theHealth = theMaxHealth2;
			if (global::UnityEngine.Random.Range(0, 3) != 0)
			{
				break;
			}
			List<Plant> allPlants = Lawnf.GetAllPlants();
			num2 = 0;
			bool flag;
			if (flag)
			{
				bool flag2 = num.SetEffect((EffectType)((uint)103), 1f, 0.2f);
			}
		}
		while (num2 != 0);
	}

	// Token: 0x06002484 RID: 9348 RVA: 0x000BE0D0 File Offset: 0x000BC2D0
	[Token(Token = "0x6002484")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002485 RID: 9349 RVA: 0x000BE0E0 File Offset: 0x000BC2E0
	[Token(Token = "0x6002485")]
	[Address(RVA = "0x600420", Offset = "0x5FEA20", VA = "0x180600420")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x06002486 RID: 9350 RVA: 0x000BE194 File Offset: 0x000BC394
	[Token(Token = "0x6002486")]
	[Address(RVA = "0x5FF9E0", Offset = "0x5FDFE0", VA = "0x1805FF9E0")]
	private void AnimShoot()
	{
		Transform shoot = this.shoot;
		int num = 0;
		if (!(shoot == num))
		{
			Transform shoot2 = this.shoot;
			CreateBullet instance = CreateBullet.Instance;
			Bullet bullet;
			bullet.Damage = 80;
			float normalSpeed = bullet.normalSpeed;
			bullet.normalSpeed = normalSpeed;
		}
	}

	// Token: 0x06002487 RID: 9351 RVA: 0x000BE1EC File Offset: 0x000BC3EC
	[Token(Token = "0x6002487")]
	[Address(RVA = "0x5FFEC0", Offset = "0x5FE4C0", VA = "0x1805FFEC0", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num2;
		do
		{
			List<Transform> changeSprites = this.changeSprites;
			bool flag;
			if (flag)
			{
				int num = 0;
				GameObject gameObject;
				Lawnf.ChangeSprite((float)0, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06002488 RID: 9352 RVA: 0x000BE224 File Offset: 0x000BC424
	[Token(Token = "0x6002488")]
	[Address(RVA = "0x5A9160", Offset = "0x5A7760", VA = "0x1805A9160", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		long num;
		return num;
	}

	// Token: 0x06002489 RID: 9353 RVA: 0x000BE238 File Offset: 0x000BC438
	[Token(Token = "0x6002489")]
	[Address(RVA = "0x5FF680", Offset = "0x5FDC80", VA = "0x1805FF680")]
	private void AnimDestoryHorse()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform axis = this.axis;
		int num = 0;
		int num2 = 0;
		int theZombieRow = this.theZombieRow;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)11), num, theZombieRow, num3 != 0UL, (float)num2);
	}

	// Token: 0x0600248A RID: 9354 RVA: 0x000BE278 File Offset: 0x000BC478
	[Token(Token = "0x600248A")]
	[Address(RVA = "0x5FF730", Offset = "0x5FDD30", VA = "0x1805FF730")]
	private void AnimRevive()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform axis = this.axis;
		int num = 0;
		Transform child = axis.GetChild(num);
		Vector3 vector;
		float z = vector.z;
		ScreenShake.TriggerShake(0.15f);
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		global::UnityEngine.Object.Destroy(base.gameObject);
		Transform axis2 = this.axis;
		CreateZombie instance2 = CreateZombie.Instance;
		int num3 = 0;
		Transform child2 = axis2.GetChild(num3);
		int num4 = 0;
		Zombie zombie;
		if (zombie != num4)
		{
			long num5 = this.theMaxHealth;
			num5 -= (long)num4;
			zombie.theHealth = num5;
			long num6 = this.theMaxHealth;
			num6 -= (long)num4;
			zombie.theMaxHealth = num6;
		}
		this.ExplodeCurse();
		this.theStatus = (ZombieStatus)((ulong)0L);
		uint num7;
		base.Die((int)num7);
	}

	// Token: 0x0600248B RID: 9355 RVA: 0x000BE348 File Offset: 0x000BC548
	[Token(Token = "0x600248B")]
	[Address(RVA = "0x6000F0", Offset = "0x5FE6F0", VA = "0x1806000F0")]
	private void ExplodeCurse()
	{
		int num;
		do
		{
			num = 0;
			List<Plant> allPlants = Lawnf.GetAllPlants();
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
			}
		}
		while (num != 0);
	}

	// Token: 0x0600248C RID: 9356 RVA: 0x000BE380 File Offset: 0x000BC580
	[Token(Token = "0x600248C")]
	[Address(RVA = "0x600030", Offset = "0x5FE630", VA = "0x180600030", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		GameAPP.PlaySound(142, 0.5f, 1f);
	}

	// Token: 0x0600248D RID: 9357 RVA: 0x000BE3A4 File Offset: 0x000BC5A4
	[Token(Token = "0x600248D")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x0600248E RID: 9358 RVA: 0x000BE3B4 File Offset: 0x000BC5B4
	[Token(Token = "0x600248E")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x0600248F RID: 9359 RVA: 0x000BE3C4 File Offset: 0x000BC5C4
	[Token(Token = "0x600248F")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06002490 RID: 9360 RVA: 0x000BE3D4 File Offset: 0x000BC5D4
	[Token(Token = "0x6002490")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06002491 RID: 9361 RVA: 0x000BE3E4 File Offset: 0x000BC5E4
	[Token(Token = "0x6002491")]
	[Address(RVA = "0x5A9020", Offset = "0x5A7620", VA = "0x1805A9020", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06002492 RID: 9362 RVA: 0x000BE3F4 File Offset: 0x000BC5F4
	[Token(Token = "0x6002492")]
	[Address(RVA = "0x600290", Offset = "0x5FE890", VA = "0x180600290", Slot = "31")]
	protected override bool Instead(int damage)
	{
		List<Zombie> certainZombies = Lawnf.GetCertainZombies(this.board, (ZombieType)((uint)254));
		return base.Instead(damage);
	}

	// Token: 0x06002493 RID: 9363 RVA: 0x000BE428 File Offset: 0x000BC628
	[Token(Token = "0x6002493")]
	[Address(RVA = "0x600A20", Offset = "0x5FF020", VA = "0x180600A20")]
	public UltimateHorse()
	{
	}

	// Token: 0x0400124B RID: 4683
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x400124B")]
	private bool shootable;

	// Token: 0x0400124C RID: 4684
	[FieldOffset(Offset = "0x27C")]
	[Token(Token = "0x400124C")]
	private float startRunTimer;
}
