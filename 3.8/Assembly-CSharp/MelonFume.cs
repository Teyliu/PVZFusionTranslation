using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000538 RID: 1336
[Token(Token = "0x2000538")]
public class MelonFume : Melonpult
{
	// Token: 0x060018D6 RID: 6358 RVA: 0x00086D4C File Offset: 0x00084F4C
	[Token(Token = "0x60018D6")]
	[Address(RVA = "0x4D5BC0", Offset = "0x4D41C0", VA = "0x1804D5BC0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x060018D7 RID: 6359 RVA: 0x00086D6C File Offset: 0x00084F6C
	[Token(Token = "0x60018D7")]
	[Address(RVA = "0x3AFD80", Offset = "0x3AE380", VA = "0x1803AFD80", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_bigMelon;
	}

	// Token: 0x060018D8 RID: 6360 RVA: 0x00086D7C File Offset: 0x00084F7C
	[Token(Token = "0x60018D8")]
	[Address(RVA = "0x4D5B30", Offset = "0x4D4130", VA = "0x1804D5B30", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.anim.SetTrigger("charge");
		this.theStatus = (PlantStatus)((ulong)17L);
		base.AttributeCountdown = 1f;
		throw new NullReferenceException();
	}

	// Token: 0x060018D9 RID: 6361 RVA: 0x00086DBC File Offset: 0x00084FBC
	[Token(Token = "0x60018D9")]
	[Address(RVA = "0x4D5DC0", Offset = "0x4D43C0", VA = "0x1804D5DC0", Slot = "39")]
	protected override void OnUpdate()
	{
		base.OnFixedUpdate();
	}

	// Token: 0x060018DA RID: 6362 RVA: 0x00086DD0 File Offset: 0x00084FD0
	[Token(Token = "0x60018DA")]
	[Address(RVA = "0x4D5E20", Offset = "0x4D4420", VA = "0x1804D5E20", Slot = "80")]
	protected virtual void TimerUpdate()
	{
		float deltaTime = Time.deltaTime;
		this.timer = deltaTime;
	}

	// Token: 0x060018DB RID: 6363 RVA: 0x00086DEC File Offset: 0x00084FEC
	[Token(Token = "0x60018DB")]
	[Address(RVA = "0x4D5DF0", Offset = "0x4D43F0", VA = "0x1804D5DF0", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		if (this.timer > 1.5f)
		{
			base.PlantShootUpdate();
			return;
		}
	}

	// Token: 0x060018DC RID: 6364 RVA: 0x00086E10 File Offset: 0x00085010
	[Token(Token = "0x60018DC")]
	[Address(RVA = "0x4D5F10", Offset = "0x4D4510", VA = "0x1804D5F10", Slot = "78")]
	protected override void UniqueEffect(Bullet bullet)
	{
		int num = this.attackDamage;
		num -= bullet;
		base.AttributeCountdown = 1f;
		this.timer = 0f;
	}

	// Token: 0x060018DD RID: 6365 RVA: 0x00086E48 File Offset: 0x00085048
	[Token(Token = "0x60018DD")]
	[Address(RVA = "0x4D5BF0", Offset = "0x4D41F0", VA = "0x1804D5BF0", Slot = "74")]
	protected override bool CheckRange(Zombie zombie)
	{
		Transform axis = zombie.axis;
		Transform axis2 = this.axis;
		Transform axis3 = zombie.axis;
		Transform axis4 = this.axis;
		throw new NullReferenceException();
	}

	// Token: 0x060018DE RID: 6366 RVA: 0x00086E80 File Offset: 0x00085080
	[Token(Token = "0x60018DE")]
	[Address(RVA = "0x4D5CF0", Offset = "0x4D42F0", VA = "0x1804D5CF0", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060018DF RID: 6367 RVA: 0x00086EA0 File Offset: 0x000850A0
	[Token(Token = "0x60018DF")]
	[Address(RVA = "0x4D5CC0", Offset = "0x4D42C0", VA = "0x1804D5CC0")]
	private int GetBulletDamage()
	{
		return this.attackDamage;
	}

	// Token: 0x060018E0 RID: 6368 RVA: 0x00086EB8 File Offset: 0x000850B8
	[Token(Token = "0x60018E0")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public MelonFume()
	{
	}

	// Token: 0x04000E33 RID: 3635
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000E33")]
	[SerializeField]
	protected float timer;
}
