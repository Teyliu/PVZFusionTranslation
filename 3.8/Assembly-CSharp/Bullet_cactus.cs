using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000122 RID: 290
[Token(Token = "0x2000122")]
public class Bullet_cactus : Bullet_pierce
{
	// Token: 0x06000590 RID: 1424 RVA: 0x0001E224 File Offset: 0x0001C424
	[Token(Token = "0x6000590")]
	[Address(RVA = "0x6BC2A0", Offset = "0x6BA8A0", VA = "0x1806BC2A0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		int num = 0;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		base.PlaySound(zombie);
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x0001E25C File Offset: 0x0001C45C
	[Token(Token = "0x6000591")]
	[Address(RVA = "0x6BC220", Offset = "0x6BA820", VA = "0x1806BC220", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x0001E288 File Offset: 0x0001C488
	[Token(Token = "0x6000592")]
	[Address(RVA = "0x6BC310", Offset = "0x6BA910", VA = "0x1806BC310", Slot = "8")]
	public override void InitData()
	{
		base.InitData();
		Bullet_cactus.<RotateTowardsTarget>d__3 <RotateTowardsTarget>d__;
		<RotateTowardsTarget>d__.System.IDisposable.Dispose();
		<RotateTowardsTarget>d__.<>1__state = (int)((ulong)0L);
		<RotateTowardsTarget>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<RotateTowardsTarget>d__);
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x0001E2BC File Offset: 0x0001C4BC
	[Token(Token = "0x6000593")]
	[Address(RVA = "0x6BC3A0", Offset = "0x6BA9A0", VA = "0x1806BC3A0")]
	private IEnumerator RotateTowardsTarget()
	{
		Bullet_cactus.<RotateTowardsTarget>d__3 <RotateTowardsTarget>d__;
		<RotateTowardsTarget>d__.System.IDisposable.Dispose();
		<RotateTowardsTarget>d__.<>1__state = (int)((ulong)0L);
		<RotateTowardsTarget>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x0001E2E0 File Offset: 0x0001C4E0
	[Token(Token = "0x6000594")]
	[Address(RVA = "0x6BC410", Offset = "0x6BAA10", VA = "0x1806BC410", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)0L);
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x0001E2F8 File Offset: 0x0001C4F8
	[Token(Token = "0x6000595")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_cactus()
	{
	}
}
