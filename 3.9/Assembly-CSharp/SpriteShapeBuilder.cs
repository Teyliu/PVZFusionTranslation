using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.U2D;

// Token: 0x020000F1 RID: 241
[Token(Token = "0x20000F1")]
public class SpriteShapeBuilder : MonoBehaviour
{
	// Token: 0x0600048D RID: 1165 RVA: 0x00017590 File Offset: 0x00015790
	[Token(Token = "0x600048D")]
	[Address(RVA = "0x5E8730", Offset = "0x5E6D30", VA = "0x1805E8730")]
	private void OnDrawGizmos()
	{
		Spline spline = this.spriteShape.m_Spline;
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x000175B0 File Offset: 0x000157B0
	[Token(Token = "0x600048E")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public SpriteShapeBuilder()
	{
	}

	// Token: 0x040002A3 RID: 675
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002A3")]
	public int pointCount;

	// Token: 0x040002A4 RID: 676
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002A4")]
	public SpriteShapeController spriteShape;
}
