using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001B9 RID: 441
[Token(Token = "0x20001B9")]
public class Bullet_sunCabbage : Bullet_pierce
{
	// Token: 0x0600079A RID: 1946 RVA: 0x00026FF4 File Offset: 0x000251F4
	[Token(Token = "0x600079A")]
	[Address(RVA = "0x6BA0C0", Offset = "0x6B86C0", VA = "0x1806BA0C0", Slot = "9")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		this.spriteObject = child;
		throw new NullReferenceException();
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x00027024 File Offset: 0x00025224
	[Token(Token = "0x600079B")]
	[Address(RVA = "0x7E63B0", Offset = "0x7E49B0", VA = "0x1807E63B0", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		Board instance = Board.Instance;
		uint num;
		this.penetrationTimes = (int)num;
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x00027050 File Offset: 0x00025250
	[Token(Token = "0x600079C")]
	[Address(RVA = "0x7E5FF0", Offset = "0x7E45F0", VA = "0x1807E5FF0", Slot = "16")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Transform transform = this.spriteObject;
		float num = Time.deltaTime * -500f;
		int num2 = 0;
		int num3 = 0;
		transform.Rotate((float)num3, (float)num2, num);
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x00027090 File Offset: 0x00025290
	[Token(Token = "0x600079D")]
	[Address(RVA = "0x7E61B0", Offset = "0x7E47B0", VA = "0x1807E61B0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		base.PlaySound(zombie);
		int num2 = 0;
		float num3 = this.Vy * -1f;
		float num4 = this.Vx * 0.4f;
		float num5 = num3 * -0.5f;
		this.Vx = num4;
		this.Vy = num5;
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

	// Token: 0x0600079E RID: 1950 RVA: 0x00027144 File Offset: 0x00025344
	[Token(Token = "0x600079E")]
	[Address(RVA = "0x7E6050", Offset = "0x7E4650", VA = "0x1807E6050", Slot = "18")]
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

	// Token: 0x0600079F RID: 1951 RVA: 0x000271AC File Offset: 0x000253AC
	[Token(Token = "0x600079F")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_sunCabbage()
	{
	}

	// Token: 0x040003AA RID: 938
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40003AA")]
	private Transform spriteObject;
}
