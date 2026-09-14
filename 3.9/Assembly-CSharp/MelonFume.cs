using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000565 RID: 1381
[Token(Token = "0x2000565")]
public class MelonFume : Melonpult
{
	// Token: 0x060019A6 RID: 6566 RVA: 0x0008AA04 File Offset: 0x00088C04
	[Token(Token = "0x60019A6")]
	[Address(RVA = "0x5364D0", Offset = "0x534AD0", VA = "0x1805364D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x060019A7 RID: 6567 RVA: 0x0008AA24 File Offset: 0x00088C24
	[Token(Token = "0x60019A7")]
	[Address(RVA = "0x3FC040", Offset = "0x3FA640", VA = "0x1803FC040", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_bigMelon;
	}

	// Token: 0x060019A8 RID: 6568 RVA: 0x0008AA34 File Offset: 0x00088C34
	[Token(Token = "0x60019A8")]
	[Address(RVA = "0x536440", Offset = "0x534A40", VA = "0x180536440", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.anim.SetTrigger("charge");
		this.theStatus = (PlantStatus)((ulong)17L);
		base.AttributeCountdown = 1f;
		throw new NullReferenceException();
	}

	// Token: 0x060019A9 RID: 6569 RVA: 0x0008AA74 File Offset: 0x00088C74
	[Token(Token = "0x60019A9")]
	[Address(RVA = "0x5366D0", Offset = "0x534CD0", VA = "0x1805366D0", Slot = "38")]
	protected override void OnUpdate()
	{
		base.OnFixedUpdate();
	}

	// Token: 0x060019AA RID: 6570 RVA: 0x0008AA88 File Offset: 0x00088C88
	[Token(Token = "0x60019AA")]
	[Address(RVA = "0x536730", Offset = "0x534D30", VA = "0x180536730", Slot = "79")]
	protected virtual void TimerUpdate()
	{
		float deltaTime = Time.deltaTime;
		this.timer = deltaTime;
	}

	// Token: 0x060019AB RID: 6571 RVA: 0x0008AAA4 File Offset: 0x00088CA4
	[Token(Token = "0x60019AB")]
	[Address(RVA = "0x536700", Offset = "0x534D00", VA = "0x180536700", Slot = "44")]
	protected override void PlantShootUpdate()
	{
		if (this.timer > 1.5f)
		{
			base.PlantShootUpdate();
			return;
		}
	}

	// Token: 0x060019AC RID: 6572 RVA: 0x0008AAC8 File Offset: 0x00088CC8
	[Token(Token = "0x60019AC")]
	[Address(RVA = "0x536820", Offset = "0x534E20", VA = "0x180536820", Slot = "77")]
	protected override void UniqueEffect(Bullet bullet)
	{
		int num = this.attackDamage;
		num -= bullet;
		base.AttributeCountdown = 1f;
		this.timer = 0f;
	}

	// Token: 0x060019AD RID: 6573 RVA: 0x0008AB00 File Offset: 0x00088D00
	[Token(Token = "0x60019AD")]
	[Address(RVA = "0x536500", Offset = "0x534B00", VA = "0x180536500", Slot = "73")]
	protected override bool CheckRange(Zombie zombie)
	{
		Transform axis = zombie.axis;
		Transform axis2 = this.axis;
		Transform axis3 = zombie.axis;
		Transform axis4 = this.axis;
		throw new NullReferenceException();
	}

	// Token: 0x060019AE RID: 6574 RVA: 0x0008AB38 File Offset: 0x00088D38
	[Token(Token = "0x60019AE")]
	[Address(RVA = "0x536600", Offset = "0x534C00", VA = "0x180536600", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060019AF RID: 6575 RVA: 0x0008AB58 File Offset: 0x00088D58
	[Token(Token = "0x60019AF")]
	[Address(RVA = "0x5365D0", Offset = "0x534BD0", VA = "0x1805365D0")]
	private int GetBulletDamage()
	{
		return this.attackDamage;
	}

	// Token: 0x060019B0 RID: 6576 RVA: 0x0008AB70 File Offset: 0x00088D70
	[Token(Token = "0x60019B0")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public MelonFume()
	{
	}

	// Token: 0x04000EEE RID: 3822
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000EEE")]
	[SerializeField]
	protected float timer;
}
