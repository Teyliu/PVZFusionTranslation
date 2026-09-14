using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006F8 RID: 1784
[Token(Token = "0x20006F8")]
public class UltimateHorse : Zombie
{
	// Token: 0x06002363 RID: 9059 RVA: 0x000B92A0 File Offset: 0x000B74A0
	[Token(Token = "0x6002363")]
	[Address(RVA = "0x586F40", Offset = "0x585540", VA = "0x180586F40", Slot = "10")]
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

	// Token: 0x06002364 RID: 9060 RVA: 0x000B92DC File Offset: 0x000B74DC
	[Token(Token = "0x6002364")]
	[Address(RVA = "0x587910", Offset = "0x585F10", VA = "0x180587910", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("tohorse");
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		Transform axis2 = this.axis;
		int columnNum = this.board.columnNum;
		Board board = this.board;
		int theZombieRow = this.theZombieRow;
		List<Plant> list = Lawnf.Get1x1Plants(columnNum, theZombieRow);
	}

	// Token: 0x06002365 RID: 9061 RVA: 0x000B9398 File Offset: 0x000B7598
	[Token(Token = "0x6002365")]
	[Address(RVA = "0x5874B0", Offset = "0x585AB0", VA = "0x1805874B0", Slot = "20")]
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
			this.theStatus = (ZombieStatus)((ulong)36L);
		}
	}

	// Token: 0x06002366 RID: 9062 RVA: 0x000B93F8 File Offset: 0x000B75F8
	[Token(Token = "0x6002366")]
	[Address(RVA = "0x5871B0", Offset = "0x5857B0", VA = "0x1805871B0", Slot = "27")]
	public override void Die(int reason = 0)
	{
		this.isDoom = false;
		base.Die(reason);
		if (this.jian)
		{
			Board board = this.board;
			this.jian = false;
		}
	}

	// Token: 0x06002367 RID: 9063 RVA: 0x000B9430 File Offset: 0x000B7630
	[Token(Token = "0x6002367")]
	[Address(RVA = "0x586CC0", Offset = "0x5852C0", VA = "0x180586CC0", Slot = "23")]
	protected override void AttributeEvent()
	{
		int num2;
		do
		{
			int num = 0;
			if ((this.shootable ? 1 : 0) != num)
			{
				this.anim.SetTrigger("shoot");
			}
			float theSpeed = this.theSpeed;
			if (0 > (int)theSpeed || theSpeed > 1f)
			{
			}
			int theMaxHealth = this.theMaxHealth;
			this.theHealth = theMaxHealth;
			int theMaxHealth2 = this.theMaxHealth;
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

	// Token: 0x06002368 RID: 9064 RVA: 0x000B94D8 File Offset: 0x000B76D8
	[Token(Token = "0x6002368")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002369 RID: 9065 RVA: 0x000B94E8 File Offset: 0x000B76E8
	[Token(Token = "0x6002369")]
	[Address(RVA = "0x587590", Offset = "0x585B90", VA = "0x180587590")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x0600236A RID: 9066 RVA: 0x000B9588 File Offset: 0x000B7788
	[Token(Token = "0x600236A")]
	[Address(RVA = "0x586B10", Offset = "0x585110", VA = "0x180586B10")]
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

	// Token: 0x0600236B RID: 9067 RVA: 0x000B95E0 File Offset: 0x000B77E0
	[Token(Token = "0x600236B")]
	[Address(RVA = "0x586FE0", Offset = "0x5855E0", VA = "0x180586FE0", Slot = "29")]
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
				Lawnf.ChangeSprite((float)num2, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x0600236C RID: 9068 RVA: 0x000B961C File Offset: 0x000B781C
	[Token(Token = "0x600236C")]
	[Address(RVA = "0x546F50", Offset = "0x545550", VA = "0x180546F50", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		int num;
		if (num > 5000)
		{
		}
		return num;
	}

	// Token: 0x0600236D RID: 9069 RVA: 0x000B9638 File Offset: 0x000B7838
	[Token(Token = "0x600236D")]
	[Address(RVA = "0x5867B0", Offset = "0x584DB0", VA = "0x1805867B0")]
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

	// Token: 0x0600236E RID: 9070 RVA: 0x000B9678 File Offset: 0x000B7878
	[Token(Token = "0x600236E")]
	[Address(RVA = "0x587560", Offset = "0x585B60", VA = "0x180587560")]
	private void OnDestroy()
	{
		if (!this.jian)
		{
			this.jian = true;
			Board board = this.board;
		}
	}

	// Token: 0x0600236F RID: 9071 RVA: 0x000B96A4 File Offset: 0x000B78A4
	[Token(Token = "0x600236F")]
	[Address(RVA = "0x586860", Offset = "0x584E60", VA = "0x180586860")]
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
			int num5 = this.theMaxHealth;
			num5 -= num4;
			zombie.theHealth = num5;
			int num6 = this.theMaxHealth;
			num6 -= num4;
			zombie.theMaxHealth = num6;
		}
		if (!this.jian)
		{
			Board board = this.board;
			this.jian = true;
		}
		this.ExplodeCurse();
	}

	// Token: 0x06002370 RID: 9072 RVA: 0x000B977C File Offset: 0x000B797C
	[Token(Token = "0x6002370")]
	[Address(RVA = "0x587200", Offset = "0x585800", VA = "0x180587200")]
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

	// Token: 0x06002371 RID: 9073 RVA: 0x000B97B4 File Offset: 0x000B79B4
	[Token(Token = "0x6002371")]
	[Address(RVA = "0x587150", Offset = "0x585750", VA = "0x180587150", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		GameAPP.PlaySound(142, 0.5f, 1f);
	}

	// Token: 0x06002372 RID: 9074 RVA: 0x000B97D8 File Offset: 0x000B79D8
	[Token(Token = "0x6002372")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06002373 RID: 9075 RVA: 0x000B97E8 File Offset: 0x000B79E8
	[Token(Token = "0x6002373")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002374 RID: 9076 RVA: 0x000B97F8 File Offset: 0x000B79F8
	[Token(Token = "0x6002374")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06002375 RID: 9077 RVA: 0x000B9808 File Offset: 0x000B7A08
	[Token(Token = "0x6002375")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06002376 RID: 9078 RVA: 0x000B9818 File Offset: 0x000B7A18
	[Token(Token = "0x6002376")]
	[Address(RVA = "0x546D50", Offset = "0x545350", VA = "0x180546D50", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06002377 RID: 9079 RVA: 0x000B9828 File Offset: 0x000B7A28
	[Token(Token = "0x6002377")]
	[Address(RVA = "0x5873A0", Offset = "0x5859A0", VA = "0x1805873A0", Slot = "30")]
	protected override bool Instead(int damage)
	{
		List<Zombie> certainZombies = Lawnf.GetCertainZombies(this.board, (ZombieType)((uint)254));
		List<Zombie> certainZombies2 = Lawnf.GetCertainZombies(this.board, (ZombieType)((uint)219));
		return true;
	}

	// Token: 0x06002378 RID: 9080 RVA: 0x000B9868 File Offset: 0x000B7A68
	[Token(Token = "0x6002378")]
	[Address(RVA = "0x587BB0", Offset = "0x5861B0", VA = "0x180587BB0")]
	public UltimateHorse()
	{
	}

	// Token: 0x0400117F RID: 4479
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400117F")]
	private bool shootable;

	// Token: 0x04001180 RID: 4480
	[FieldOffset(Offset = "0x25C")]
	[Token(Token = "0x4001180")]
	private float startRunTimer;

	// Token: 0x04001181 RID: 4481
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4001181")]
	private bool flaged;

	// Token: 0x04001182 RID: 4482
	[FieldOffset(Offset = "0x261")]
	[Token(Token = "0x4001182")]
	private bool jian = true;
}
