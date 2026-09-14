using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006A6 RID: 1702
[Token(Token = "0x20006A6")]
public class ObsidianImpZombie : Zombie
{
	// Token: 0x06002122 RID: 8482 RVA: 0x000AF2EC File Offset: 0x000AD4EC
	[Token(Token = "0x6002122")]
	[Address(RVA = "0x562130", Offset = "0x560730", VA = "0x180562130")]
	private void SetParticle()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		base.ChangeStatus((ZombieStatus)num);
	}

	// Token: 0x06002123 RID: 8483 RVA: 0x000AF31C File Offset: 0x000AD51C
	[Token(Token = "0x6002123")]
	[Address(RVA = "0x530300", Offset = "0x52E900", VA = "0x180530300", Slot = "69")]
	public override void BeSmall(float scale = 0.5f)
	{
	}

	// Token: 0x06002124 RID: 8484 RVA: 0x000AF32C File Offset: 0x000AD52C
	[Token(Token = "0x6002124")]
	[Address(RVA = "0x5620F0", Offset = "0x5606F0", VA = "0x1805620F0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)16L);
	}

	// Token: 0x06002125 RID: 8485 RVA: 0x000AF34C File Offset: 0x000AD54C
	[Token(Token = "0x6002125")]
	[Address(RVA = "0x5538B0", Offset = "0x551EB0", VA = "0x1805538B0", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return base.CanAttack(target);
	}

	// Token: 0x06002126 RID: 8486 RVA: 0x000AF364 File Offset: 0x000AD564
	[Token(Token = "0x6002126")]
	[Address(RVA = "0x562110", Offset = "0x560710", VA = "0x180562110", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x06002127 RID: 8487 RVA: 0x000AF380 File Offset: 0x000AD580
	[Token(Token = "0x6002127")]
	[Address(RVA = "0x5621A0", Offset = "0x5607A0", VA = "0x1805621A0")]
	public ObsidianImpZombie()
	{
	}
}
