using System;
using Cpp2IlInjected;

namespace com.cyborgAssets.internalIBP
{
	// Token: 0x02000DF2 RID: 3570
	[Token(Token = "0x2000DF2")]
	public enum SerializedParameterType : byte
	{
		// Token: 0x0400342D RID: 13357
		[Token(Token = "0x400342D")]
		Integer,
		// Token: 0x0400342E RID: 13358
		[Token(Token = "0x400342E")]
		Boolean,
		// Token: 0x0400342F RID: 13359
		[Token(Token = "0x400342F")]
		Float,
		// Token: 0x04003430 RID: 13360
		[Token(Token = "0x4003430")]
		String,
		// Token: 0x04003431 RID: 13361
		[Token(Token = "0x4003431")]
		Color,
		// Token: 0x04003432 RID: 13362
		[Token(Token = "0x4003432")]
		ObjectReference,
		// Token: 0x04003433 RID: 13363
		[Token(Token = "0x4003433")]
		Enum,
		// Token: 0x04003434 RID: 13364
		[Token(Token = "0x4003434")]
		Vector2,
		// Token: 0x04003435 RID: 13365
		[Token(Token = "0x4003435")]
		Vector3,
		// Token: 0x04003436 RID: 13366
		[Token(Token = "0x4003436")]
		Vector4,
		// Token: 0x04003437 RID: 13367
		[Token(Token = "0x4003437")]
		Rect,
		// Token: 0x04003438 RID: 13368
		[Token(Token = "0x4003438")]
		AnimationCurve,
		// Token: 0x04003439 RID: 13369
		[Token(Token = "0x4003439")]
		Bounds,
		// Token: 0x0400343A RID: 13370
		[Token(Token = "0x400343A")]
		Quaternion,
		// Token: 0x0400343B RID: 13371
		[Token(Token = "0x400343B")]
		Vector2Int,
		// Token: 0x0400343C RID: 13372
		[Token(Token = "0x400343C")]
		Vector3Int,
		// Token: 0x0400343D RID: 13373
		[Token(Token = "0x400343D")]
		RectInt,
		// Token: 0x0400343E RID: 13374
		[Token(Token = "0x400343E")]
		BoundsInt
	}
}
