using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.U2D;

// Token: 0x020000EC RID: 236
[Token(Token = "0x20000EC")]
public class SpriteShapeBuilder : MonoBehaviour
{
	// Token: 0x06000472 RID: 1138 RVA: 0x00017104 File Offset: 0x00015304
	[Token(Token = "0x6000472")]
	[Address(RVA = "0x5B2CA0", Offset = "0x5B12A0", VA = "0x1805B2CA0")]
	private void OnDrawGizmos()
	{
		Spline spline = this.spriteShape.m_Spline;
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x00017124 File Offset: 0x00015324
	[Token(Token = "0x6000473")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public SpriteShapeBuilder()
	{
	}

	// Token: 0x04000295 RID: 661
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000295")]
	public int pointCount;

	// Token: 0x04000296 RID: 662
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000296")]
	public SpriteShapeController spriteShape;
}
