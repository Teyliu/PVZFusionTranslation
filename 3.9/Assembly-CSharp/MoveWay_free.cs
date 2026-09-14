using System;
using Cpp2IlInjected;

// Token: 0x020001EA RID: 490
[Token(Token = "0x20001EA")]
public class MoveWay_free : BaseBulletMovement
{
	// Token: 0x06000842 RID: 2114 RVA: 0x00029D74 File Offset: 0x00027F74
	[Token(Token = "0x6000842")]
	[Address(RVA = "0x8FB7D0", Offset = "0x8F9DD0", VA = "0x1808FB7D0", Slot = "4")]
	public override void PositionUpdate()
	{
		this.bullet.FreeUpdate();
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x00029D94 File Offset: 0x00027F94
	[Token(Token = "0x6000843")]
	[Address(RVA = "0x8FB7F0", Offset = "0x8F9DF0", VA = "0x1808FB7F0", Slot = "5")]
	public override void ShadowUpdate()
	{
		base.SetShadowBelowBullet(-0.7f);
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x00029DAC File Offset: 0x00027FAC
	[Token(Token = "0x6000844")]
	[Address(RVA = "0x8FB800", Offset = "0x8F9E00", VA = "0x1808FB800", Slot = "6")]
	public override void UpdateHitFilter()
	{
		this.bullet.hitFilters._size = (int)((ulong)0L);
		int size = this.bullet.hitFilters._size;
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x00029DE8 File Offset: 0x00027FE8
	[Token(Token = "0x6000845")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public MoveWay_free()
	{
		base.PositionUpdate();
	}
}
