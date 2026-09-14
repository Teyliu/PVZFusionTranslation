using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006BC RID: 1724
[Token(Token = "0x20006BC")]
public class QuickJacksonZombie : ZombieJackson
{
	// Token: 0x060021E1 RID: 8673 RVA: 0x000B2018 File Offset: 0x000B0218
	[Token(Token = "0x60021E1")]
	[Address(RVA = "0x56AAA0", Offset = "0x5690A0", VA = "0x18056AAA0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		int num2 = 0;
		ParticleSystem component = child.GetChild(num2).GetComponent<ParticleSystem>();
		this.particle = component;
		throw new NullReferenceException();
	}

	// Token: 0x060021E2 RID: 8674 RVA: 0x000B205C File Offset: 0x000B025C
	[Token(Token = "0x60021E2")]
	[Address(RVA = "0x56AC80", Offset = "0x569280", VA = "0x18056AC80", Slot = "74")]
	protected override ZombieType GetZombieType()
	{
		if (!Lawnf.TravelDebuff((TravelDebuff)((uint)12)))
		{
			return base.GetZombieType();
		}
		return ZombieType.SuperDancePolZombie;
	}

	// Token: 0x060021E3 RID: 8675 RVA: 0x000B2080 File Offset: 0x000B0280
	[Token(Token = "0x60021E3")]
	[Address(RVA = "0x56AEA0", Offset = "0x5694A0", VA = "0x18056AEA0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.particle.gameObject.SetActive(true);
	}

	// Token: 0x060021E4 RID: 8676 RVA: 0x000B20AC File Offset: 0x000B02AC
	[Token(Token = "0x60021E4")]
	[Address(RVA = "0x56AEE0", Offset = "0x5694E0", VA = "0x18056AEE0", Slot = "75")]
	protected override void StopMoonWalk()
	{
		base.StopMoonWalk();
		Rigidbody2D rb = this.rb;
		ParticleSystem.MainModule main = this.particle.main;
	}

	// Token: 0x060021E5 RID: 8677 RVA: 0x000B20DC File Offset: 0x000B02DC
	[Token(Token = "0x60021E5")]
	[Address(RVA = "0x56AB40", Offset = "0x569140", VA = "0x18056AB40", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x060021E6 RID: 8678 RVA: 0x000B211C File Offset: 0x000B031C
	[Token(Token = "0x60021E6")]
	[Address(RVA = "0x56ACC0", Offset = "0x5692C0", VA = "0x18056ACC0", Slot = "21")]
	protected override void PositionUpdate()
	{
		base.PositionUpdate();
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		float theSpeed = this.theSpeed;
		float deltaTime = Time.deltaTime;
		Transform axis = this.axis;
		Transform transform3 = base.transform;
		Transform transform4 = base.transform;
		Transform transform5 = base.transform;
		Vector3 vector;
		float z = vector.z;
		this.StopMoonWalk();
	}

	// Token: 0x060021E7 RID: 8679 RVA: 0x000B2188 File Offset: 0x000B0388
	[Token(Token = "0x60021E7")]
	[Address(RVA = "0x56ABE0", Offset = "0x5691E0", VA = "0x18056ABE0", Slot = "27")]
	public override void Die(int reason = 0)
	{
		ParticleSystem.MainModule main = this.particle.main;
		base.Die(reason);
	}

	// Token: 0x060021E8 RID: 8680 RVA: 0x000B21B0 File Offset: 0x000B03B0
	[Token(Token = "0x60021E8")]
	[Address(RVA = "0x56AC40", Offset = "0x569240", VA = "0x18056AC40", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix = false, PlantType fromType = PlantType.Nothing)
	{
		if (theDamage <= 0 || !fix)
		{
		}
		int num;
		return num;
	}

	// Token: 0x060021E9 RID: 8681 RVA: 0x000B21C8 File Offset: 0x000B03C8
	[Token(Token = "0x60021E9")]
	[Address(RVA = "0x56AF90", Offset = "0x569590", VA = "0x18056AF90")]
	public QuickJacksonZombie()
	{
	}

	// Token: 0x04001122 RID: 4386
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4001122")]
	private ParticleSystem particle;
}
