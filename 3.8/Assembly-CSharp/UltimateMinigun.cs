using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005B8 RID: 1464
[Token(Token = "0x20005B8")]
public class UltimateMinigun : Shooter
{
	// Token: 0x06001B41 RID: 6977 RVA: 0x00092378 File Offset: 0x00090578
	[Token(Token = "0x6001B41")]
	[Address(RVA = "0x5014D0", Offset = "0x4FFAD0", VA = "0x1805014D0", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.attributeCountdown = 1f;
		float num;
		this.damageMultiplier = num;
	}

	// Token: 0x06001B42 RID: 6978 RVA: 0x000923A0 File Offset: 0x000905A0
	[Token(Token = "0x6001B42")]
	[Address(RVA = "0x501670", Offset = "0x4FFC70", VA = "0x180501670", Slot = "47")]
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

	// Token: 0x06001B43 RID: 6979 RVA: 0x000923EC File Offset: 0x000905EC
	[Token(Token = "0x6001B43")]
	[Address(RVA = "0x501520", Offset = "0x4FFB20", VA = "0x180501520", Slot = "69")]
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

	// Token: 0x06001B44 RID: 6980 RVA: 0x00092438 File Offset: 0x00090638
	[Token(Token = "0x6001B44")]
	[Address(RVA = "0x501710", Offset = "0x4FFD10", VA = "0x180501710")]
	public UltimateMinigun()
	{
	}

	// Token: 0x04000ED3 RID: 3795
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000ED3")]
	private float damageMultiplier = 1f;
}
