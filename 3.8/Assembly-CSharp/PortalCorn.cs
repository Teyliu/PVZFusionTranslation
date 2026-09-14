using System;
using Cpp2IlInjected;

// Token: 0x02000546 RID: 1350
[Token(Token = "0x2000546")]
public class PortalCorn : Cornpult
{
	// Token: 0x06001916 RID: 6422 RVA: 0x00087B40 File Offset: 0x00085D40
	[Token(Token = "0x6001916")]
	[Address(RVA = "0x4DBB80", Offset = "0x4DA180", VA = "0x1804DBB80", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.flightTime = 1f;
	}

	// Token: 0x06001917 RID: 6423 RVA: 0x00087B60 File Offset: 0x00085D60
	[Token(Token = "0x6001917")]
	[Address(RVA = "0x4DBBB0", Offset = "0x4DA1B0", VA = "0x1804DBBB0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_kernal_portal;
	}

	// Token: 0x06001918 RID: 6424 RVA: 0x00087B70 File Offset: 0x00085D70
	[Token(Token = "0x6001918")]
	[Address(RVA = "0x4DBBA0", Offset = "0x4DA1A0", VA = "0x1804DBBA0", Slot = "79")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_butter_portal;
	}

	// Token: 0x06001919 RID: 6425 RVA: 0x00087B80 File Offset: 0x00085D80
	[Token(Token = "0x6001919")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "73")]
	protected override void SetShoot()
	{
	}

	// Token: 0x0600191A RID: 6426 RVA: 0x00087B90 File Offset: 0x00085D90
	[Token(Token = "0x600191A")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public PortalCorn()
	{
	}
}
