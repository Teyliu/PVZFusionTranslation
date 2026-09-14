using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020001E9 RID: 489
[Token(Token = "0x20001E9")]
public class MoveWay_peaNut : BulletMovement
{
	// Token: 0x0600083F RID: 2111 RVA: 0x00029CBC File Offset: 0x00027EBC
	[Token(Token = "0x600083F")]
	[Address(RVA = "0x8FBB30", Offset = "0x8FA130", VA = "0x1808FBB30", Slot = "4")]
	public override void PositionUpdate()
	{
		this.bullet.RollingUpdate();
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x00029CDC File Offset: 0x00027EDC
	[Token(Token = "0x6000840")]
	[Address(RVA = "0x8FBB50", Offset = "0x8FA150", VA = "0x1808FBB50", Slot = "6")]
	public override void UpdateHitFilter()
	{
		List<BulletHitFilter> hitFilters = this.bullet.hitFilters;
		int num = 0;
		hitFilters._size = num;
		List<BulletHitFilter> hitFilters2 = this.bullet.hitFilters;
		int size = hitFilters2._size;
		hitFilters2._size = 1;
		List<BulletHitFilter> hitFilters3 = this.bullet.hitFilters;
		int size2 = hitFilters3._size;
		hitFilters3._size = 1;
		List<BulletHitFilter> hitFilters4 = this.bullet.hitFilters;
		int size3 = hitFilters4._size;
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x00029D60 File Offset: 0x00027F60
	[Token(Token = "0x6000841")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public MoveWay_peaNut()
	{
		base.PositionUpdate();
	}
}
