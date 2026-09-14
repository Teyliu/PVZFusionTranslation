using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020001E7 RID: 487
[Token(Token = "0x20001E7")]
public class MoveWay_jump : BulletMovement
{
	// Token: 0x0600083A RID: 2106 RVA: 0x00029BB0 File Offset: 0x00027DB0
	[Token(Token = "0x600083A")]
	[Address(RVA = "0x8FB8D0", Offset = "0x8F9ED0", VA = "0x1808FB8D0", Slot = "4")]
	public override void PositionUpdate()
	{
		this.bullet.JumpUpdate();
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x00029BD0 File Offset: 0x00027DD0
	[Token(Token = "0x600083B")]
	[Address(RVA = "0x8FB8F0", Offset = "0x8F9EF0", VA = "0x1808FB8F0", Slot = "6")]
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
		hitFilters4._size = 1;
		List<BulletHitFilter> hitFilters5 = this.bullet.hitFilters;
		int size4 = hitFilters5._size;
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x00029C74 File Offset: 0x00027E74
	[Token(Token = "0x600083C")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public MoveWay_jump()
	{
		base.PositionUpdate();
	}
}
