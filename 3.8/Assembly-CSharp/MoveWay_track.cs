using System;
using Cpp2IlInjected;

// Token: 0x020001E1 RID: 481
[Token(Token = "0x20001E1")]
public class MoveWay_track : BaseBulletMovement
{
	// Token: 0x0600082B RID: 2091 RVA: 0x00029F34 File Offset: 0x00028134
	[Token(Token = "0x600082B")]
	[Address(RVA = "0x86CBC0", Offset = "0x86B1C0", VA = "0x18086CBC0", Slot = "4")]
	public override void PositionUpdate()
	{
		Bullet bullet = this.bullet;
		throw new NullReferenceException();
	}

	// Token: 0x0600082C RID: 2092 RVA: 0x00029F50 File Offset: 0x00028150
	[Token(Token = "0x600082C")]
	[Address(RVA = "0x86C8F0", Offset = "0x86AEF0", VA = "0x18086C8F0", Slot = "5")]
	public override void ShadowUpdate()
	{
		base.SetShadowBelowBullet(-0.7f);
	}

	// Token: 0x0600082D RID: 2093 RVA: 0x00029F68 File Offset: 0x00028168
	[Token(Token = "0x600082D")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public MoveWay_track()
	{
		base.PositionUpdate();
	}
}
