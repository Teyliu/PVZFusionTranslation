using System;
using Cpp2IlInjected;

namespace com.cyborgAssets.internalIBP
{
	// Token: 0x02000D26 RID: 3366
	[Token(Token = "0x2000D26")]
	public enum SerializedParameterType : byte
	{
		// Token: 0x0400320E RID: 12814
		[Token(Token = "0x400320E")]
		Integer,
		// Token: 0x0400320F RID: 12815
		[Token(Token = "0x400320F")]
		Boolean,
		// Token: 0x04003210 RID: 12816
		[Token(Token = "0x4003210")]
		Float,
		// Token: 0x04003211 RID: 12817
		[Token(Token = "0x4003211")]
		String,
		// Token: 0x04003212 RID: 12818
		[Token(Token = "0x4003212")]
		Color,
		// Token: 0x04003213 RID: 12819
		[Token(Token = "0x4003213")]
		ObjectReference,
		// Token: 0x04003214 RID: 12820
		[Token(Token = "0x4003214")]
		Enum,
		// Token: 0x04003215 RID: 12821
		[Token(Token = "0x4003215")]
		Vector2,
		// Token: 0x04003216 RID: 12822
		[Token(Token = "0x4003216")]
		Vector3,
		// Token: 0x04003217 RID: 12823
		[Token(Token = "0x4003217")]
		Vector4,
		// Token: 0x04003218 RID: 12824
		[Token(Token = "0x4003218")]
		Rect,
		// Token: 0x04003219 RID: 12825
		[Token(Token = "0x4003219")]
		AnimationCurve,
		// Token: 0x0400321A RID: 12826
		[Token(Token = "0x400321A")]
		Bounds,
		// Token: 0x0400321B RID: 12827
		[Token(Token = "0x400321B")]
		Quaternion,
		// Token: 0x0400321C RID: 12828
		[Token(Token = "0x400321C")]
		Vector2Int,
		// Token: 0x0400321D RID: 12829
		[Token(Token = "0x400321D")]
		Vector3Int,
		// Token: 0x0400321E RID: 12830
		[Token(Token = "0x400321E")]
		RectInt,
		// Token: 0x0400321F RID: 12831
		[Token(Token = "0x400321F")]
		BoundsInt
	}
}
