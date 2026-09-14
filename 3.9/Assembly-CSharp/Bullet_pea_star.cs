using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000186 RID: 390
[Token(Token = "0x2000186")]
public class Bullet_pea_star : Bullet
{
	// Token: 0x060006CF RID: 1743 RVA: 0x00022F74 File Offset: 0x00021174
	[Token(Token = "0x60006CF")]
	[Address(RVA = "0x808930", Offset = "0x806F30", VA = "0x180808930", Slot = "9")]
	public override void InitData()
	{
		base.InitData();
		this.timer = 0.3f;
		this.count = (int)((ulong)5L);
	}

	// Token: 0x060006D0 RID: 1744 RVA: 0x00022F9C File Offset: 0x0002119C
	[Token(Token = "0x60006D0")]
	[Address(RVA = "0x808550", Offset = "0x806B50", VA = "0x180808550", Slot = "15")]
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

	// Token: 0x060006D1 RID: 1745 RVA: 0x00023020 File Offset: 0x00021220
	[Token(Token = "0x60006D1")]
	[Address(RVA = "0x808860", Offset = "0x806E60", VA = "0x180808860", Slot = "22")]
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

	// Token: 0x060006D2 RID: 1746 RVA: 0x00023070 File Offset: 0x00021270
	[Token(Token = "0x60006D2")]
	[Address(RVA = "0x808780", Offset = "0x806D80", VA = "0x180808780", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x0002309C File Offset: 0x0002129C
	[Token(Token = "0x60006D3")]
	[Address(RVA = "0x808960", Offset = "0x806F60", VA = "0x180808960")]
	public Bullet_pea_star()
	{
	}

	// Token: 0x0400038E RID: 910
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400038E")]
	private float timer;

	// Token: 0x0400038F RID: 911
	[FieldOffset(Offset = "0x144")]
	[Token(Token = "0x400038F")]
	private int count = (int)((ulong)5L);
}
