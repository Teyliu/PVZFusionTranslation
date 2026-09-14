using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000164 RID: 356
[Token(Token = "0x2000164")]
public class Bullet_lourCactus : Bullet_cactus
{
	// Token: 0x0600066B RID: 1643 RVA: 0x00021D70 File Offset: 0x0001FF70
	[Token(Token = "0x600066B")]
	[Address(RVA = "0x6C9070", Offset = "0x6C7670", VA = "0x1806C9070", Slot = "8")]
	public override void InitData()
	{
		base.InitData();
		Bullet_cactus.<RotateTowardsTarget>d__3 <RotateTowardsTarget>d__;
		<RotateTowardsTarget>d__.System.IDisposable.Dispose();
		<RotateTowardsTarget>d__.<>1__state = (int)((ulong)0L);
		<RotateTowardsTarget>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<RotateTowardsTarget>d__);
		this.lourTimer = 0f;
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x00021DB0 File Offset: 0x0001FFB0
	[Token(Token = "0x600066C")]
	[Address(RVA = "0x6C9100", Offset = "0x6C7700", VA = "0x1806C9100", Slot = "11")]
	protected override void Update()
	{
		base.Update();
		float deltaTime = Time.deltaTime;
		this.lourTimer = deltaTime;
		if (deltaTime > 0.2f)
		{
			int num = 0;
			base.MoveWay = (BulletMoveWay)num;
		}
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x00021DE4 File Offset: 0x0001FFE4
	[Token(Token = "0x600066D")]
	[Address(RVA = "0x6C8F50", Offset = "0x6C7550", VA = "0x1806C8F50", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		int damage = this._damage;
		bool beforeDying = zombie.beforeDying;
		int theHealth = zombie.theHealth;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		base.PlaySound(zombie);
		if ((!beforeDying && zombie.beforeDying != beforeDying) || (theHealth > 0 && !zombie.beforeDying))
		{
			CattailLour cattailLour = this.lour;
			int num3 = 0;
			if (cattailLour != num3)
			{
				CattailLour cattailLour2 = this.lour;
				int num4 = 0;
				cattailLour2.Supply(num4 != 0);
			}
		}
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x00021E70 File Offset: 0x00020070
	[Token(Token = "0x600066E")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_lourCactus()
	{
	}

	// Token: 0x04000374 RID: 884
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000374")]
	public CattailLour lour;

	// Token: 0x04000375 RID: 885
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000375")]
	private float lourTimer;
}
