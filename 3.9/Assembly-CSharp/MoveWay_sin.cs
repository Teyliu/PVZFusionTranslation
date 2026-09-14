using System;
using Cpp2IlInjected;

// Token: 0x020001F1 RID: 497
[Token(Token = "0x20001F1")]
public class MoveWay_sin : BaseBulletMovement
{
	// Token: 0x0600085A RID: 2138 RVA: 0x0002A0EC File Offset: 0x000282EC
	[Token(Token = "0x600085A")]
	[Address(RVA = "0x8FBE20", Offset = "0x8FA420", VA = "0x1808FBE20", Slot = "4")]
	public override void PositionUpdate()
	{
		Bullet bullet = this.bullet;
		float theExistTime = bullet.theExistTime;
		float normalSpeed = bullet.normalSpeed;
		bullet.velocity = normalSpeed;
		float num = theExistTime * 3.1415927f;
		bullet.velocity.y = num;
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x0002A130 File Offset: 0x00028330
	[Token(Token = "0x600085B")]
	[Address(RVA = "0x8FB7F0", Offset = "0x8F9DF0", VA = "0x1808FB7F0", Slot = "5")]
	public override void ShadowUpdate()
	{
		base.SetShadowBelowBullet(-0.7f);
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x0002A148 File Offset: 0x00028348
	[Token(Token = "0x600085C")]
	[Address(RVA = "0x8FBE90", Offset = "0x8FA490", VA = "0x1808FBE90", Slot = "6")]
	public override void UpdateHitFilter()
	{
		this.bullet.hitFilters._size = (int)((ulong)0L);
		int size = this.bullet.hitFilters._size;
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x0002A184 File Offset: 0x00028384
	[Token(Token = "0x600085D")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public MoveWay_sin()
	{
		base.PositionUpdate();
	}
}
