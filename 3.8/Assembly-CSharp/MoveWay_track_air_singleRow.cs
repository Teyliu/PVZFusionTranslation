using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001E9 RID: 489
[Token(Token = "0x20001E9")]
public class MoveWay_track_air_singleRow : BaseBulletMovement
{
	// Token: 0x0600083E RID: 2110 RVA: 0x0002A110 File Offset: 0x00028310
	[Token(Token = "0x600083E")]
	[Address(RVA = "0x86CBF0", Offset = "0x86B1F0", VA = "0x18086CBF0", Slot = "4")]
	public override void PositionUpdate()
	{
		Rigidbody2D rb = this.bullet.rb;
		this.bullet.TrackSingleRowUpdate();
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x0002A13C File Offset: 0x0002833C
	[Token(Token = "0x600083F")]
	[Address(RVA = "0x86C8F0", Offset = "0x86AEF0", VA = "0x18086C8F0", Slot = "5")]
	public override void ShadowUpdate()
	{
		base.SetShadowBelowBullet(-0.7f);
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x0002A154 File Offset: 0x00028354
	[Token(Token = "0x6000840")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public MoveWay_track_air_singleRow()
	{
		base.PositionUpdate();
	}
}
