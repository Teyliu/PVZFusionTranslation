using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003ED RID: 1005
[Token(Token = "0x20003ED")]
public class LotusSpruce : Plant
{
	// Token: 0x0600126F RID: 4719 RVA: 0x00067348 File Offset: 0x00065548
	[Token(Token = "0x600126F")]
	[Address(RVA = "0x4A1B90", Offset = "0x4A0190", VA = "0x1804A1B90", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 10f;
	}

	// Token: 0x06001270 RID: 4720 RVA: 0x00067368 File Offset: 0x00065568
	[Token(Token = "0x6001270")]
	[Address(RVA = "0x4A19B0", Offset = "0x49FFB0", VA = "0x1804A19B0")]
	private void AnimShoot()
	{
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot = this.shoot;
		Transform shoot2 = this.shoot;
		GameAPP.PlaySound(68, 0.5f, 1f);
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		float normalSpeed = bullet.normalSpeed;
		bullet.normalSpeed = normalSpeed;
	}

	// Token: 0x06001271 RID: 4721 RVA: 0x000673C8 File Offset: 0x000655C8
	[Token(Token = "0x6001271")]
	[Address(RVA = "0x4A1AF0", Offset = "0x4A00F0", VA = "0x1804A1AF0", Slot = "39")]
	protected override void AttributeEvent()
	{
		int num = this.attributeCount;
		num++;
		this.attributeCount = num;
		this.anim.SetTrigger("recover");
		this.theStatus = (PlantStatus)((ulong)25L);
		base.UpdateText();
		base.AttributeCountdown = 10f;
	}

	// Token: 0x06001272 RID: 4722 RVA: 0x0006741C File Offset: 0x0006561C
	[Token(Token = "0x6001272")]
	[Address(RVA = "0x4A2060", Offset = "0x4A0660", VA = "0x1804A2060", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		float num = this.recoverTimer;
		float deltaTime = Time.deltaTime;
		this.recoverTimer = num;
		this.recoverTimer = 1f;
		this.Recover();
	}

	// Token: 0x06001273 RID: 4723 RVA: 0x0006745C File Offset: 0x0006565C
	[Token(Token = "0x6001273")]
	[Address(RVA = "0x4A1BC0", Offset = "0x4A01C0", VA = "0x1804A1BC0", Slot = "21")]
	public override void Charge()
	{
		int num = this.attributeCount;
		num++;
		this.attributeCount = num;
		this.anim.SetTrigger("recover");
		this.theStatus = (PlantStatus)((ulong)25L);
		throw new NullReferenceException();
	}

	// Token: 0x06001274 RID: 4724 RVA: 0x0006749C File Offset: 0x0006569C
	[Token(Token = "0x6001274")]
	[Address(RVA = "0x4A1D20", Offset = "0x4A0320", VA = "0x1804A1D20")]
	private void Recover()
	{
		ulong num;
		do
		{
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
		ParticleManager instance = ParticleManager.Instance;
		GameAPP.PlaySound(68, 0.5f, 1f);
	}

	// Token: 0x06001275 RID: 4725 RVA: 0x000674F8 File Offset: 0x000656F8
	[Token(Token = "0x6001275")]
	[Address(RVA = "0x4A1C50", Offset = "0x4A0250", VA = "0x1804A1C50", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001276 RID: 4726 RVA: 0x00067518 File Offset: 0x00065718
	[Token(Token = "0x6001276")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public LotusSpruce()
	{
	}

	// Token: 0x04000C5F RID: 3167
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C5F")]
	private float recoverTimer;
}
