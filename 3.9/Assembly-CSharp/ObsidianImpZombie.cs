using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006DD RID: 1757
[Token(Token = "0x20006DD")]
public class ObsidianImpZombie : Zombie
{
	// Token: 0x06002239 RID: 8761 RVA: 0x000B3F98 File Offset: 0x000B2198
	[Token(Token = "0x6002239")]
	[Address(RVA = "0x5C4F20", Offset = "0x5C3520", VA = "0x1805C4F20")]
	private void SetParticle()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		base.ChangeStatus((ZombieStatus)num);
	}

	// Token: 0x0600223A RID: 8762 RVA: 0x000B3FC8 File Offset: 0x000B21C8
	[Token(Token = "0x600223A")]
	[Address(RVA = "0x586E80", Offset = "0x585480", VA = "0x180586E80", Slot = "71")]
	public override void BeSmall(float scale = 0.5f)
	{
	}

	// Token: 0x0600223B RID: 8763 RVA: 0x000B3FD8 File Offset: 0x000B21D8
	[Token(Token = "0x600223B")]
	[Address(RVA = "0x5C4EE0", Offset = "0x5C34E0", VA = "0x1805C4EE0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)16L);
	}

	// Token: 0x0600223C RID: 8764 RVA: 0x000B3FF8 File Offset: 0x000B21F8
	[Token(Token = "0x600223C")]
	[Address(RVA = "0x5B7450", Offset = "0x5B5A50", VA = "0x1805B7450", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return base.CanAttack(target);
	}

	// Token: 0x0600223D RID: 8765 RVA: 0x000B4010 File Offset: 0x000B2210
	[Token(Token = "0x600223D")]
	[Address(RVA = "0x5C4F00", Offset = "0x5C3500", VA = "0x1805C4F00", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x0600223E RID: 8766 RVA: 0x000B402C File Offset: 0x000B222C
	[Token(Token = "0x600223E")]
	[Address(RVA = "0x5C4F90", Offset = "0x5C3590", VA = "0x1805C4F90")]
	public ObsidianImpZombie()
	{
	}
}
