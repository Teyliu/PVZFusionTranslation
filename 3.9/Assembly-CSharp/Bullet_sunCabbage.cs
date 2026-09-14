using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001C2 RID: 450
[Token(Token = "0x20001C2")]
public class Bullet_sunCabbage : Bullet_pierce
{
	// Token: 0x060007AC RID: 1964 RVA: 0x00026A40 File Offset: 0x00024C40
	[Token(Token = "0x60007AC")]
	[Address(RVA = "0x6E4FB0", Offset = "0x6E35B0", VA = "0x1806E4FB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		this.spriteObject = child;
		throw new NullReferenceException();
	}

	// Token: 0x060007AD RID: 1965 RVA: 0x00026A70 File Offset: 0x00024C70
	[Token(Token = "0x60007AD")]
	[Address(RVA = "0x813C40", Offset = "0x812240", VA = "0x180813C40", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		Board instance = Board.Instance;
		uint num;
		this.maxHitCount = (int)num;
	}

	// Token: 0x060007AE RID: 1966 RVA: 0x00026A9C File Offset: 0x00024C9C
	[Token(Token = "0x60007AE")]
	[Address(RVA = "0x813870", Offset = "0x811E70", VA = "0x180813870", Slot = "15")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Transform transform = this.spriteObject;
		float num = Time.deltaTime * -500f;
		int num2 = 0;
		int num3 = 0;
		transform.Rotate((float)num3, (float)num2, num);
	}

	// Token: 0x060007AF RID: 1967 RVA: 0x00026ADC File Offset: 0x00024CDC
	[Token(Token = "0x60007AF")]
	[Address(RVA = "0x813A30", Offset = "0x812030", VA = "0x180813A30", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		base.PlaySound(zombie);
		int num2 = 0;
		float num3 = this.velocity.y * -1f;
		this.velocity.y = num3;
		Vector2 velocity = this.velocity;
		float y = this.velocity.y;
		float num4 = velocity * 0.4f;
		float num5 = y * -0.5f;
		this.velocity = num4;
		this.velocity.y = num5;
		CreateItem instance = CreateItem.Instance;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		ParticleManager instance2 = ParticleManager.Instance;
		Transform transform2 = base.transform;
		int num6 = 0;
		int theZombieRow = zombie.theZombieRow;
		ulong num7;
		Particle particle = instance2.SetParticle((ParticleType)((uint)84), num6, theZombieRow, num7 != 0UL, (float)num2);
	}

	// Token: 0x060007B0 RID: 1968 RVA: 0x00026BB8 File Offset: 0x00024DB8
	[Token(Token = "0x60007B0")]
	[Address(RVA = "0x8138D0", Offset = "0x811ED0", VA = "0x1808138D0", Slot = "17")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)84), num, theBulletRow, num3 != 0UL, (float)num2);
		CreateItem instance2 = CreateItem.Instance;
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		base.HitLand();
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x00026C20 File Offset: 0x00024E20
	[Token(Token = "0x60007B1")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_sunCabbage()
	{
	}

	// Token: 0x040003B3 RID: 947
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40003B3")]
	private Transform spriteObject;
}
