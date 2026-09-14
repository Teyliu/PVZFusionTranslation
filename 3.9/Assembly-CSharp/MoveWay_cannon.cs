using System;
using Cpp2IlInjected;

// Token: 0x020001E6 RID: 486
[Token(Token = "0x20001E6")]
public class MoveWay_cannon : BulletMovement
{
	// Token: 0x06000837 RID: 2103 RVA: 0x00029B54 File Offset: 0x00027D54
	[Token(Token = "0x6000837")]
	[Address(RVA = "0x8FB600", Offset = "0x8F9C00", VA = "0x1808FB600", Slot = "4")]
	public override void PositionUpdate()
	{
		this.bullet.CannonBulletUpdate();
	}

	// Token: 0x06000838 RID: 2104 RVA: 0x00029B74 File Offset: 0x00027D74
	[Token(Token = "0x6000838")]
	[Address(RVA = "0x8FB620", Offset = "0x8F9C20", VA = "0x1808FB620", Slot = "6")]
	public override void UpdateHitFilter()
	{
		this.bullet.hitFilters._size = (int)((ulong)0L);
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x00029B9C File Offset: 0x00027D9C
	[Token(Token = "0x6000839")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public MoveWay_cannon()
	{
		base.PositionUpdate();
	}
}
