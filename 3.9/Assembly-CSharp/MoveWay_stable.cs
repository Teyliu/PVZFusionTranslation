using System;
using Cpp2IlInjected;

// Token: 0x020001EE RID: 494
[Token(Token = "0x20001EE")]
public class MoveWay_stable : BaseBulletMovement
{
	// Token: 0x0600084F RID: 2127 RVA: 0x00029F80 File Offset: 0x00028180
	[Token(Token = "0x600084F")]
	[Address(RVA = "0x8FB7F0", Offset = "0x8F9DF0", VA = "0x1808FB7F0", Slot = "5")]
	public override void ShadowUpdate()
	{
		base.SetShadowBelowBullet(-0.7f);
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x00029F98 File Offset: 0x00028198
	[Token(Token = "0x6000850")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "6")]
	public override void UpdateHitFilter()
	{
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x00029FA8 File Offset: 0x000281A8
	[Token(Token = "0x6000851")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public MoveWay_stable()
	{
		this.UpdateHitFilter();
	}
}
