using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001C7 RID: 455
[Token(Token = "0x20001C7")]
public class Bullet_superMelon : Bullet_melon
{
	// Token: 0x060007BF RID: 1983 RVA: 0x000271A4 File Offset: 0x000253A4
	[Token(Token = "0x60007BF")]
	[Address(RVA = "0x814890", Offset = "0x812E90", VA = "0x180814890", Slot = "17")]
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

	// Token: 0x060007C0 RID: 1984 RVA: 0x00027208 File Offset: 0x00025408
	[Token(Token = "0x60007C0")]
	[Address(RVA = "0x8149D0", Offset = "0x812FD0", VA = "0x1808149D0", Slot = "22")]
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
		float y = this.velocity.y;
		Bullet bullet;
		bullet.velocity.y = y;
		Vector2 velocity = this.velocity;
		bullet.velocity = velocity;
		float y2 = this.acceleration.y;
		Vector2 acceleration = this.acceleration;
		bullet.acceleration.y = y2;
		bullet.acceleration = acceleration;
		uint num4;
		bullet.Damage = (int)num4;
		bool melonSputter = this.melonSputter;
		bullet.melonSputter = melonSputter;
		PlantType fromType2 = this.fromType;
		bullet.fromType = fromType2;
		CreateBullet instance2 = CreateBullet.Instance;
		Transform transform5 = base.transform;
		Transform transform6 = base.transform;
		float y3 = this.velocity.y;
		Bullet bullet2;
		bullet2.velocity.y = y3;
		Vector2 velocity2 = this.velocity;
		bullet2.velocity = velocity2;
		Vector2 acceleration2 = this.acceleration;
		float y4 = this.acceleration.y;
		bullet2.acceleration = acceleration2;
		bullet2.acceleration.y = y4;
		uint num5;
		bullet2.Damage = (int)num5;
		bool melonSputter2 = this.melonSputter;
		bullet2.melonSputter = melonSputter2;
		PlantType fromType3 = this.fromType;
		bullet2.fromType = fromType3;
		base.Die();
	}

	// Token: 0x060007C1 RID: 1985 RVA: 0x000273AC File Offset: 0x000255AC
	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x814E20", Offset = "0x813420", VA = "0x180814E20")]
	public Bullet_superMelon()
	{
	}

	// Token: 0x040003B9 RID: 953
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40003B9")]
	public int p;
}
