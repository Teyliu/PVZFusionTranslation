using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020001EC RID: 492
[Token(Token = "0x20001EC")]
public class MoveWay_fly : BulletMovement
{
	// Token: 0x0600084A RID: 2122 RVA: 0x00029EB0 File Offset: 0x000280B0
	[Token(Token = "0x600084A")]
	[Address(RVA = "0x8FB670", Offset = "0x8F9C70", VA = "0x1808FB670", Slot = "4")]
	public override void PositionUpdate()
	{
		this.bullet.RightUpdate();
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x00029ED0 File Offset: 0x000280D0
	[Token(Token = "0x600084B")]
	[Address(RVA = "0x8FB690", Offset = "0x8F9C90", VA = "0x1808FB690", Slot = "6")]
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
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x00029F38 File Offset: 0x00028138
	[Token(Token = "0x600084C")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public MoveWay_fly()
	{
		base.PositionUpdate();
	}
}
