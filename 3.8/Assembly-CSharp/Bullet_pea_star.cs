using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200017F RID: 383
[Token(Token = "0x200017F")]
public class Bullet_pea_star : Bullet
{
	// Token: 0x060006C0 RID: 1728 RVA: 0x0002357C File Offset: 0x0002177C
	[Token(Token = "0x60006C0")]
	[Address(RVA = "0x7DAF70", Offset = "0x7D9570", VA = "0x1807DAF70", Slot = "8")]
	public override void InitData()
	{
		base.InitData();
		this.timer = 0.3f;
		this.count = (int)((ulong)5L);
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x000235A4 File Offset: 0x000217A4
	[Token(Token = "0x60006C1")]
	[Address(RVA = "0x7DAB90", Offset = "0x7D9190", VA = "0x1807DAB90", Slot = "16")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (this.count > 0)
		{
			float fixedDeltaTime = Time.fixedDeltaTime;
			this.timer = fixedDeltaTime;
			int num = 0;
			this.timer = (float)num;
			CreateBullet instance = CreateBullet.Instance;
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			PlantType fromType = this.fromType;
			Bullet bullet;
			bullet.fromType = fromType;
			int damage = this._damage;
			bullet.Damage = damage;
			Transform transform3 = bullet.transform;
			uint num2;
			num2 += (uint)72;
		}
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x00023628 File Offset: 0x00021828
	[Token(Token = "0x60006C2")]
	[Address(RVA = "0x7DAEA0", Offset = "0x7D94A0", VA = "0x1807DAEA0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		int num = 0;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x00023678 File Offset: 0x00021878
	[Token(Token = "0x60006C3")]
	[Address(RVA = "0x7DADC0", Offset = "0x7D93C0", VA = "0x1807DADC0", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x000236A4 File Offset: 0x000218A4
	[Token(Token = "0x60006C4")]
	[Address(RVA = "0x7DAFA0", Offset = "0x7D95A0", VA = "0x1807DAFA0")]
	public Bullet_pea_star()
	{
	}

	// Token: 0x04000385 RID: 901
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000385")]
	private float timer;

	// Token: 0x04000386 RID: 902
	[FieldOffset(Offset = "0x124")]
	[Token(Token = "0x4000386")]
	private int count = (int)((ulong)5L);
}
