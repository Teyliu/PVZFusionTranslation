using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001BB RID: 443
[Token(Token = "0x20001BB")]
public class Bullet_sunSpike_sp : Bullet_sunSpike
{
	// Token: 0x060007A3 RID: 1955 RVA: 0x00027318 File Offset: 0x00025518
	[Token(Token = "0x60007A3")]
	[Address(RVA = "0x7E6B40", Offset = "0x7E5140", VA = "0x1807E6B40", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x0002733C File Offset: 0x0002553C
	[Token(Token = "0x60007A4")]
	[Address(RVA = "0x7E6A30", Offset = "0x7E5030", VA = "0x1807E6A30", Slot = "18")]
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

	// Token: 0x060007A5 RID: 1957 RVA: 0x00027388 File Offset: 0x00025588
	[Token(Token = "0x60007A5")]
	[Address(RVA = "0x7D98C0", Offset = "0x7D7EC0", VA = "0x1807D98C0", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)2147483647L);
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x000273A8 File Offset: 0x000255A8
	[Token(Token = "0x60007A6")]
	[Address(RVA = "0x7E0730", Offset = "0x7DED30", VA = "0x1807E0730")]
	public Bullet_sunSpike_sp()
	{
	}
}
