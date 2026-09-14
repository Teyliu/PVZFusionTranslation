using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001BE RID: 446
[Token(Token = "0x20001BE")]
public class Bullet_superMelon : Bullet_melon
{
	// Token: 0x060007AD RID: 1965 RVA: 0x00027730 File Offset: 0x00025930
	[Token(Token = "0x60007AD")]
	[Address(RVA = "0x7E7000", Offset = "0x7E5600", VA = "0x1807E7000", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		int num = 0;
		int num2 = 0;
		base.AttackOtherZombie(num2, (MelonSputterType)num);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x060007AE RID: 1966 RVA: 0x00027794 File Offset: 0x00025994
	[Token(Token = "0x60007AE")]
	[Address(RVA = "0x7E7140", Offset = "0x7E5740", VA = "0x1807E7140", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		PlantType fromType = this.fromType;
		int num = 0;
		base.AttackOtherZombie(zombie, (MelonSputterType)num);
		uint num2;
		uint num3;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num2, (int)num3), 0.5f, 1f);
		CreateBullet instance = CreateBullet.Instance;
		Transform transform3 = base.transform;
		Transform transform4 = base.transform;
		float vy = this.Vy;
		Bullet bullet;
		bullet.Vy = vy;
		float vx = this.Vx;
		bullet.Vx = vx;
		float detaVy = this.detaVy;
		bullet.detaVy = detaVy;
		uint num4;
		bullet.Damage = (int)num4;
		bool melonSputter = this.melonSputter;
		bullet.melonSputter = melonSputter;
		PlantType fromType2 = this.fromType;
		bullet.fromType = fromType2;
		CreateBullet instance2 = CreateBullet.Instance;
		Transform transform5 = base.transform;
		Transform transform6 = base.transform;
		float vy2 = this.Vy;
		Bullet bullet2;
		bullet2.Vy = vy2;
		float vx2 = this.Vx;
		bullet2.Vx = vx2;
		float detaVy2 = this.detaVy;
		bullet2.detaVy = detaVy2;
		uint num5;
		bullet2.Damage = (int)num5;
		bool melonSputter2 = this.melonSputter;
		bullet2.melonSputter = melonSputter2;
		PlantType fromType3 = this.fromType;
		bullet2.fromType = fromType3;
		base.Die();
	}

	// Token: 0x060007AF RID: 1967 RVA: 0x000278F0 File Offset: 0x00025AF0
	[Token(Token = "0x60007AF")]
	[Address(RVA = "0x7E7570", Offset = "0x7E5B70", VA = "0x1807E7570")]
	public Bullet_superMelon()
	{
	}

	// Token: 0x040003B0 RID: 944
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40003B0")]
	public int p;
}
