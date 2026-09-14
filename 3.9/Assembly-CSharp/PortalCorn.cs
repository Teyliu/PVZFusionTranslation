using System;
using Cpp2IlInjected;

// Token: 0x02000574 RID: 1396
[Token(Token = "0x2000574")]
public class PortalCorn : Cornpult
{
	// Token: 0x060019EB RID: 6635 RVA: 0x0008B8E8 File Offset: 0x00089AE8
	[Token(Token = "0x60019EB")]
	[Address(RVA = "0x539300", Offset = "0x537900", VA = "0x180539300", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.flightTime = 1f;
	}

	// Token: 0x060019EC RID: 6636 RVA: 0x0008B908 File Offset: 0x00089B08
	[Token(Token = "0x60019EC")]
	[Address(RVA = "0x539330", Offset = "0x537930", VA = "0x180539330", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_kernal_portal;
	}

	// Token: 0x060019ED RID: 6637 RVA: 0x0008B918 File Offset: 0x00089B18
	[Token(Token = "0x60019ED")]
	[Address(RVA = "0x539320", Offset = "0x537920", VA = "0x180539320", Slot = "78")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_butter_portal;
	}

	// Token: 0x060019EE RID: 6638 RVA: 0x0008B928 File Offset: 0x00089B28
	[Token(Token = "0x60019EE")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "72")]
	protected override void SetShoot()
	{
	}

	// Token: 0x060019EF RID: 6639 RVA: 0x0008B938 File Offset: 0x00089B38
	[Token(Token = "0x60019EF")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public PortalCorn()
	{
	}
}
