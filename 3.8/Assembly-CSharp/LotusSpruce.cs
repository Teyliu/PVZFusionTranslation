using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003D7 RID: 983
[Token(Token = "0x20003D7")]
public class LotusSpruce : Plant
{
	// Token: 0x0600120C RID: 4620 RVA: 0x00065A88 File Offset: 0x00063C88
	[Token(Token = "0x600120C")]
	[Address(RVA = "0x44D3D0", Offset = "0x44B9D0", VA = "0x18044D3D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 10f;
	}

	// Token: 0x0600120D RID: 4621 RVA: 0x00065AA8 File Offset: 0x00063CA8
	[Token(Token = "0x600120D")]
	[Address(RVA = "0x44D1F0", Offset = "0x44B7F0", VA = "0x18044D1F0")]
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

	// Token: 0x0600120E RID: 4622 RVA: 0x00065B08 File Offset: 0x00063D08
	[Token(Token = "0x600120E")]
	[Address(RVA = "0x44D330", Offset = "0x44B930", VA = "0x18044D330", Slot = "40")]
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

	// Token: 0x0600120F RID: 4623 RVA: 0x00065B5C File Offset: 0x00063D5C
	[Token(Token = "0x600120F")]
	[Address(RVA = "0x44D8A0", Offset = "0x44BEA0", VA = "0x18044D8A0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		float num = this.recoverTimer;
		float deltaTime = Time.deltaTime;
		this.recoverTimer = num;
		this.recoverTimer = 1f;
		this.Recover();
	}

	// Token: 0x06001210 RID: 4624 RVA: 0x00065B9C File Offset: 0x00063D9C
	[Token(Token = "0x6001210")]
	[Address(RVA = "0x44D400", Offset = "0x44BA00", VA = "0x18044D400", Slot = "21")]
	public override void Charge()
	{
		int num = this.attributeCount;
		num++;
		this.attributeCount = num;
		this.anim.SetTrigger("recover");
		this.theStatus = (PlantStatus)((ulong)25L);
		throw new NullReferenceException();
	}

	// Token: 0x06001211 RID: 4625 RVA: 0x00065BDC File Offset: 0x00063DDC
	[Token(Token = "0x6001211")]
	[Address(RVA = "0x44D560", Offset = "0x44BB60", VA = "0x18044D560")]
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

	// Token: 0x06001212 RID: 4626 RVA: 0x00065C38 File Offset: 0x00063E38
	[Token(Token = "0x6001212")]
	[Address(RVA = "0x44D490", Offset = "0x44BA90", VA = "0x18044D490", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001213 RID: 4627 RVA: 0x00065C58 File Offset: 0x00063E58
	[Token(Token = "0x6001213")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public LotusSpruce()
	{
	}

	// Token: 0x04000BF3 RID: 3059
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BF3")]
	private float recoverTimer;
}
