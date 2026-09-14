using System;
using Cpp2IlInjected;

// Token: 0x020004BD RID: 1213
[Token(Token = "0x20004BD")]
public class WaterAloes : Thrower
{
	// Token: 0x060016B6 RID: 5814 RVA: 0x0007D354 File Offset: 0x0007B554
	[Token(Token = "0x60016B6")]
	[Address(RVA = "0x51BCC0", Offset = "0x51A2C0", VA = "0x18051BCC0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_water;
	}

	// Token: 0x060016B7 RID: 5815 RVA: 0x0007D37C File Offset: 0x0007B57C
	[Token(Token = "0x60016B7")]
	[Address(RVA = "0x51BD10", Offset = "0x51A310", VA = "0x18051BD10", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060016B8 RID: 5816 RVA: 0x0007D39C File Offset: 0x0007B59C
	[Token(Token = "0x60016B8")]
	[Address(RVA = "0x4A12B0", Offset = "0x49F8B0", VA = "0x1804A12B0", Slot = "58")]
	public override void InfluenceByIceShroom()
	{
	}

	// Token: 0x060016B9 RID: 5817 RVA: 0x0007D3AC File Offset: 0x0007B5AC
	[Token(Token = "0x60016B9")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public WaterAloes()
	{
	}
}
