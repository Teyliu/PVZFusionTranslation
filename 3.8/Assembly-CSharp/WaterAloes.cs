using System;
using Cpp2IlInjected;

// Token: 0x0200049B RID: 1179
[Token(Token = "0x200049B")]
public class WaterAloes : Thrower
{
	// Token: 0x06001616 RID: 5654 RVA: 0x0007A8E0 File Offset: 0x00078AE0
	[Token(Token = "0x6001616")]
	[Address(RVA = "0x4AD4F0", Offset = "0x4ABAF0", VA = "0x1804AD4F0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_water;
	}

	// Token: 0x06001617 RID: 5655 RVA: 0x0007A908 File Offset: 0x00078B08
	[Token(Token = "0x6001617")]
	[Address(RVA = "0x4AD540", Offset = "0x4ABB40", VA = "0x1804AD540", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001618 RID: 5656 RVA: 0x0007A928 File Offset: 0x00078B28
	[Token(Token = "0x6001618")]
	[Address(RVA = "0x44CAF0", Offset = "0x44B0F0", VA = "0x18044CAF0", Slot = "59")]
	public override void InfluenceByIceShroom()
	{
	}

	// Token: 0x06001619 RID: 5657 RVA: 0x0007A938 File Offset: 0x00078B38
	[Token(Token = "0x6001619")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public WaterAloes()
	{
	}
}
