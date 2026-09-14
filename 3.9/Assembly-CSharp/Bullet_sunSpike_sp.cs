using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001C4 RID: 452
[Token(Token = "0x20001C4")]
public class Bullet_sunSpike_sp : Bullet_sunSpike
{
	// Token: 0x060007B5 RID: 1973 RVA: 0x00026D8C File Offset: 0x00024F8C
	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x8143D0", Offset = "0x8129D0", VA = "0x1808143D0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x00026DB0 File Offset: 0x00024FB0
	[Token(Token = "0x60007B6")]
	[Address(RVA = "0x8142C0", Offset = "0x8128C0", VA = "0x1808142C0", Slot = "17")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)84), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x00026DFC File Offset: 0x00024FFC
	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x807150", Offset = "0x805750", VA = "0x180807150", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)2147483647L);
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x00026E1C File Offset: 0x0002501C
	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x80DE70", Offset = "0x80C470", VA = "0x18080DE70")]
	public Bullet_sunSpike_sp()
	{
	}
}
