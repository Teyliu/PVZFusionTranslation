using System;
using Cpp2IlInjected;
using UnityEngine;

namespace UI
{
	// Token: 0x02000A57 RID: 2647
	[Token(Token = "0x2000A57")]
	[Serializable]
	public class UIConfig
	{
		// Token: 0x06003689 RID: 13961 RVA: 0x001236C4 File Offset: 0x001218C4
		[Token(Token = "0x6003689")]
		[Address(RVA = "0x7C9120", Offset = "0x7C7720", VA = "0x1807C9120")]
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

		// Token: 0x040029EC RID: 10732
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40029EC")]
		public Vector2 leftButtonOffset;

		// Token: 0x040029ED RID: 10733
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40029ED")]
		public float leftButtonScale;

		// Token: 0x040029EE RID: 10734
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40029EE")]
		public Vector2 seedBankOffset;

		// Token: 0x040029EF RID: 10735
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40029EF")]
		public Vector2 conveyOffset;

		// Token: 0x040029F0 RID: 10736
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40029F0")]
		public Vector2 bottomOffset;

		// Token: 0x040029F1 RID: 10737
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40029F1")]
		public Vector2 bottomOffsetInGame;

		// Token: 0x040029F2 RID: 10738
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40029F2")]
		public Vector2 toolOffset;
	}
}
