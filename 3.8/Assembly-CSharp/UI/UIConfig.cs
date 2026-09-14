using System;
using Cpp2IlInjected;
using UnityEngine;

namespace UI
{
	// Token: 0x02000A18 RID: 2584
	[Token(Token = "0x2000A18")]
	[Serializable]
	public class UIConfig
	{
		// Token: 0x06003548 RID: 13640 RVA: 0x0011E5A8 File Offset: 0x0011C7A8
		[Token(Token = "0x6003548")]
		[Address(RVA = "0x7622E0", Offset = "0x7608E0", VA = "0x1807622E0")]
		public UIConfig()
		{
			Vector2 zeroVector = Vector2.zeroVector;
			this.leftButtonOffset = zeroVector;
			this.leftButtonScale = 1f;
			Vector2 zeroVector2 = Vector2.zeroVector;
			this.seedBankOffset = zeroVector2;
			Vector2 zeroVector3 = Vector2.zeroVector;
			this.conveyOffset = zeroVector3;
			Vector2 zeroVector4 = Vector2.zeroVector;
			this.bottomOffset = zeroVector4;
			Vector2 zeroVector5 = Vector2.zeroVector;
			this.bottomOffsetInGame = zeroVector5;
			Vector2 zeroVector6 = Vector2.zeroVector;
			this.toolOffset = zeroVector6;
			base..ctor();
		}

		// Token: 0x0400287B RID: 10363
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400287B")]
		public Vector2 leftButtonOffset;

		// Token: 0x0400287C RID: 10364
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400287C")]
		public float leftButtonScale;

		// Token: 0x0400287D RID: 10365
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400287D")]
		public Vector2 seedBankOffset;

		// Token: 0x0400287E RID: 10366
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400287E")]
		public Vector2 conveyOffset;

		// Token: 0x0400287F RID: 10367
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x400287F")]
		public Vector2 bottomOffset;

		// Token: 0x04002880 RID: 10368
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4002880")]
		public Vector2 bottomOffsetInGame;

		// Token: 0x04002881 RID: 10369
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4002881")]
		public Vector2 toolOffset;
	}
}
