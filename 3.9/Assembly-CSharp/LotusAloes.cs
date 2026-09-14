using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003EA RID: 1002
[Token(Token = "0x20003EA")]
public class LotusAloes : Plant
{
	// Token: 0x0600125C RID: 4700 RVA: 0x00066F94 File Offset: 0x00065194
	[Token(Token = "0x600125C")]
	[Address(RVA = "0x4A1280", Offset = "0x49F880", VA = "0x1804A1280", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 5f;
	}

	// Token: 0x0600125D RID: 4701 RVA: 0x00066FB4 File Offset: 0x000651B4
	[Token(Token = "0x600125D")]
	[Address(RVA = "0x4A1190", Offset = "0x49F790", VA = "0x1804A1190", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		base.AttributeCountdown = 5f;
		AdvantureData data = AdvantureConfig.data;
		this.anim.SetTrigger("shoot");
	}

	// Token: 0x0600125E RID: 4702 RVA: 0x00066FF0 File Offset: 0x000651F0
	[Token(Token = "0x600125E")]
	[Address(RVA = "0x4A0FA0", Offset = "0x49F5A0", VA = "0x1804A0FA0")]
	private void AnimShoot()
	{
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot = this.shoot;
		Transform shoot2 = this.shoot;
		Transform shoot3 = this.shoot;
		Vector3 vector;
		float z = vector.z;
		Transform axis = this.axis;
		Bullet bullet;
		bullet.targetPlant = this;
		throw new NullReferenceException();
	}

	// Token: 0x0600125F RID: 4703 RVA: 0x00067038 File Offset: 0x00065238
	[Token(Token = "0x600125F")]
	[Address(RVA = "0x4A12E0", Offset = "0x49F8E0", VA = "0x1804A12E0", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001260 RID: 4704 RVA: 0x00067058 File Offset: 0x00065258
	[Token(Token = "0x6001260")]
	[Address(RVA = "0x4A12B0", Offset = "0x49F8B0", VA = "0x1804A12B0", Slot = "58")]
	public override void InfluenceByIceShroom()
	{
	}

	// Token: 0x06001261 RID: 4705 RVA: 0x00067068 File Offset: 0x00065268
	[Token(Token = "0x6001261")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public LotusAloes()
	{
	}
}
