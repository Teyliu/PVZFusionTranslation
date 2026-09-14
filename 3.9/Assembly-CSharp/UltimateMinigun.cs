using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005E9 RID: 1513
[Token(Token = "0x20005E9")]
public class UltimateMinigun : Shooter
{
	// Token: 0x06001C2C RID: 7212 RVA: 0x00096848 File Offset: 0x00094A48
	[Token(Token = "0x6001C2C")]
	[Address(RVA = "0x568330", Offset = "0x566930", VA = "0x180568330", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.attributeCountdown = 1f;
		float num;
		this.damageMultiplier = num;
	}

	// Token: 0x06001C2D RID: 7213 RVA: 0x00096870 File Offset: 0x00094A70
	[Token(Token = "0x6001C2D")]
	[Address(RVA = "0x5684D0", Offset = "0x566AD0", VA = "0x1805684D0", Slot = "46")]
	protected override bool Shootable()
	{
		bool flag = base.Shootable();
		this.anim.SetBool("shooting", flag);
		if (!flag)
		{
			this.damageMultiplier = 1f;
		}
		if (!flag)
		{
			this.attributeCountdown = 1f;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001C2E RID: 7214 RVA: 0x000968BC File Offset: 0x00094ABC
	[Token(Token = "0x6001C2E")]
	[Address(RVA = "0x568380", Offset = "0x566980", VA = "0x180568380", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		float normalSpeed = bullet.normalSpeed;
		bullet.normalSpeed = normalSpeed;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x06001C2F RID: 7215 RVA: 0x00096908 File Offset: 0x00094B08
	[Token(Token = "0x6001C2F")]
	[Address(RVA = "0x568570", Offset = "0x566B70", VA = "0x180568570")]
	public UltimateMinigun()
	{
	}

	// Token: 0x04000F92 RID: 3986
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000F92")]
	private float damageMultiplier = 1f;
}
