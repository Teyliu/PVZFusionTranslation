using System;
using Cpp2IlInjected;

// Token: 0x020001EF RID: 495
[Token(Token = "0x20001EF")]
public class MoveWay_superGatling : BaseBulletMovement
{
	// Token: 0x06000852 RID: 2130 RVA: 0x00029FBC File Offset: 0x000281BC
	[Token(Token = "0x6000852")]
	[Address(RVA = "0x8FC130", Offset = "0x8FA730", VA = "0x1808FC130", Slot = "4")]
	public override void PositionUpdate()
	{
		this.bullet.RightFreeUpdate();
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x00029FDC File Offset: 0x000281DC
	[Token(Token = "0x6000853")]
	[Address(RVA = "0x8FB7F0", Offset = "0x8F9DF0", VA = "0x1808FB7F0", Slot = "5")]
	public override void ShadowUpdate()
	{
		base.SetShadowBelowBullet(-0.7f);
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x00029FF4 File Offset: 0x000281F4
	[Token(Token = "0x6000854")]
	[Address(RVA = "0x8FC150", Offset = "0x8FA750", VA = "0x1808FC150", Slot = "6")]
	public override void UpdateHitFilter()
	{
		this.bullet.hitFilters._size = (int)((ulong)0L);
		int size = this.bullet.hitFilters._size;
	}

	// Token: 0x06000855 RID: 2133 RVA: 0x0002A030 File Offset: 0x00028230
	[Token(Token = "0x6000855")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public MoveWay_superGatling()
	{
		base.PositionUpdate();
	}
}
