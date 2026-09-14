using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003D4 RID: 980
[Token(Token = "0x20003D4")]
public class LotusAloes : Plant
{
	// Token: 0x060011F9 RID: 4601 RVA: 0x000656DC File Offset: 0x000638DC
	[Token(Token = "0x60011F9")]
	[Address(RVA = "0x44CAC0", Offset = "0x44B0C0", VA = "0x18044CAC0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 5f;
	}

	// Token: 0x060011FA RID: 4602 RVA: 0x000656FC File Offset: 0x000638FC
	[Token(Token = "0x60011FA")]
	[Address(RVA = "0x44C9D0", Offset = "0x44AFD0", VA = "0x18044C9D0", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		base.AttributeCountdown = 5f;
		AdvantureData data = AdvantureConfig.data;
		this.anim.SetTrigger("shoot");
	}

	// Token: 0x060011FB RID: 4603 RVA: 0x00065738 File Offset: 0x00063938
	[Token(Token = "0x60011FB")]
	[Address(RVA = "0x44C760", Offset = "0x44AD60", VA = "0x18044C760")]
	private void AnimShoot()
	{
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot = this.shoot;
		Transform shoot2 = this.shoot;
		Transform shoot3 = this.shoot;
		Vector3 vector;
		float z = vector.z;
		Transform axis = this.axis;
		float[] array;
		float num = array[0];
		Bullet bullet;
		bullet.Vx = num;
		float num2 = array[1];
		bullet.Vy = num2;
		float num3 = array[1];
		bullet.detaVy = num3;
		bullet.targetPlant = this;
		throw new NullReferenceException();
	}

	// Token: 0x060011FC RID: 4604 RVA: 0x000657BC File Offset: 0x000639BC
	[Token(Token = "0x60011FC")]
	[Address(RVA = "0x44CB20", Offset = "0x44B120", VA = "0x18044CB20", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060011FD RID: 4605 RVA: 0x000657DC File Offset: 0x000639DC
	[Token(Token = "0x60011FD")]
	[Address(RVA = "0x44CAF0", Offset = "0x44B0F0", VA = "0x18044CAF0", Slot = "59")]
	public override void InfluenceByIceShroom()
	{
	}

	// Token: 0x060011FE RID: 4606 RVA: 0x000657EC File Offset: 0x000639EC
	[Token(Token = "0x60011FE")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public LotusAloes()
	{
	}
}
