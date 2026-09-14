using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006F4 RID: 1780
[Token(Token = "0x20006F4")]
public class QuickJacksonZombie : ZombieJackson
{
	// Token: 0x060022FB RID: 8955 RVA: 0x000B6D20 File Offset: 0x000B4F20
	[Token(Token = "0x60022FB")]
	[Address(RVA = "0x5CE380", Offset = "0x5CC980", VA = "0x1805CE380", Slot = "10")]
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

	// Token: 0x060022FC RID: 8956 RVA: 0x000B6D64 File Offset: 0x000B4F64
	[Token(Token = "0x60022FC")]
	[Address(RVA = "0x5CE560", Offset = "0x5CCB60", VA = "0x1805CE560", Slot = "76")]
	protected override ZombieType GetZombieType()
	{
		if (!Lawnf.TravelDebuff((TravelDebuff)((uint)12)))
		{
			return base.GetZombieType();
		}
		return ZombieType.SuperDancePolZombie;
	}

	// Token: 0x060022FD RID: 8957 RVA: 0x000B6D88 File Offset: 0x000B4F88
	[Token(Token = "0x60022FD")]
	[Address(RVA = "0x5CE780", Offset = "0x5CCD80", VA = "0x1805CE780", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		this.particle.gameObject.SetActive(true);
	}

	// Token: 0x060022FE RID: 8958 RVA: 0x000B6DB4 File Offset: 0x000B4FB4
	[Token(Token = "0x60022FE")]
	[Address(RVA = "0x5CE7C0", Offset = "0x5CCDC0", VA = "0x1805CE7C0", Slot = "78")]
	protected override void StopMoonWalk()
	{
		base.StopMoonWalk();
		Rigidbody2D rb = this.rb;
		ParticleSystem.MainModule main = this.particle.main;
	}

	// Token: 0x060022FF RID: 8959 RVA: 0x000B6DE4 File Offset: 0x000B4FE4
	[Token(Token = "0x60022FF")]
	[Address(RVA = "0x5CE420", Offset = "0x5CCA20", VA = "0x1805CE420", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06002300 RID: 8960 RVA: 0x000B6E24 File Offset: 0x000B5024
	[Token(Token = "0x6002300")]
	[Address(RVA = "0x5CE5A0", Offset = "0x5CCBA0", VA = "0x1805CE5A0", Slot = "22")]
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

	// Token: 0x06002301 RID: 8961 RVA: 0x000B6E90 File Offset: 0x000B5090
	[Token(Token = "0x6002301")]
	[Address(RVA = "0x5CE4C0", Offset = "0x5CCAC0", VA = "0x1805CE4C0", Slot = "28")]
	public override void Die(int reason = 0)
	{
		ParticleSystem.MainModule main = this.particle.main;
		base.Die(reason);
	}

	// Token: 0x06002302 RID: 8962 RVA: 0x000B6EB8 File Offset: 0x000B50B8
	[Token(Token = "0x6002302")]
	[Address(RVA = "0x5CE520", Offset = "0x5CCB20", VA = "0x1805CE520", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix = false, PlantType fromType = PlantType.Nothing)
	{
		if (!fix)
		{
		}
		long num;
		return num;
	}

	// Token: 0x06002303 RID: 8963 RVA: 0x000B6ED0 File Offset: 0x000B50D0
	[Token(Token = "0x6002303")]
	[Address(RVA = "0x5CE870", Offset = "0x5CCE70", VA = "0x1805CE870")]
	public QuickJacksonZombie()
	{
	}

	// Token: 0x040011EF RID: 4591
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x40011EF")]
	private ParticleSystem particle;
}
