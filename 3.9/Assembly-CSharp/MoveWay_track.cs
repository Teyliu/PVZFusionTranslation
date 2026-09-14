using System;
using Cpp2IlInjected;

// Token: 0x020001EB RID: 491
[Token(Token = "0x20001EB")]
public class MoveWay_track : BaseBulletMovement
{
	// Token: 0x06000846 RID: 2118 RVA: 0x00029DFC File Offset: 0x00027FFC
	[Token(Token = "0x6000846")]
	[Address(RVA = "0x8FC520", Offset = "0x8FAB20", VA = "0x1808FC520", Slot = "4")]
	public override void PositionUpdate()
	{
		Bullet bullet = this.bullet;
		throw new NullReferenceException();
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x00029E18 File Offset: 0x00028018
	[Token(Token = "0x6000847")]
	[Address(RVA = "0x8FB7F0", Offset = "0x8F9DF0", VA = "0x1808FB7F0", Slot = "5")]
	public override void ShadowUpdate()
	{
		base.SetShadowBelowBullet(-0.7f);
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x00029E30 File Offset: 0x00028030
	[Token(Token = "0x6000848")]
	[Address(RVA = "0x8FC550", Offset = "0x8FAB50", VA = "0x1808FC550", Slot = "6")]
	public override void UpdateHitFilter()
	{
		this.bullet.hitFilters._size = (int)((ulong)0L);
		int size = this.bullet.hitFilters._size;
		int size2 = this.bullet.hitFilters._size;
		int size3 = this.bullet.hitFilters._size;
		int size4 = this.bullet.hitFilters._size;
	}

	// Token: 0x06000849 RID: 2121 RVA: 0x00029E9C File Offset: 0x0002809C
	[Token(Token = "0x6000849")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public MoveWay_track()
	{
		base.PositionUpdate();
	}
}
