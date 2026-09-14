using System;
using Cpp2IlInjected;

// Token: 0x020001F0 RID: 496
[Token(Token = "0x20001F0")]
public class MoveWay_smoothTrack : BaseBulletMovement
{
	// Token: 0x06000856 RID: 2134 RVA: 0x0002A044 File Offset: 0x00028244
	[Token(Token = "0x6000856")]
	[Address(RVA = "0x8FBF60", Offset = "0x8FA560", VA = "0x1808FBF60", Slot = "4")]
	public override void PositionUpdate()
	{
		this.bullet.SmoothTrackUpdate();
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x0002A064 File Offset: 0x00028264
	[Token(Token = "0x6000857")]
	[Address(RVA = "0x8FB7F0", Offset = "0x8F9DF0", VA = "0x1808FB7F0", Slot = "5")]
	public override void ShadowUpdate()
	{
		base.SetShadowBelowBullet(-0.7f);
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x0002A07C File Offset: 0x0002827C
	[Token(Token = "0x6000858")]
	[Address(RVA = "0x8FBF80", Offset = "0x8FA580", VA = "0x1808FBF80", Slot = "6")]
	public override void UpdateHitFilter()
	{
		this.bullet.hitFilters._size = (int)((ulong)0L);
		int size = this.bullet.hitFilters._size;
		int size2 = this.bullet.hitFilters._size;
		int size3 = this.bullet.hitFilters._size;
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x0002A0D8 File Offset: 0x000282D8
	[Token(Token = "0x6000859")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public MoveWay_smoothTrack()
	{
		base.PositionUpdate();
	}
}
