using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B99 RID: 2969
	[Token(Token = "0x2000B99")]
	[Serializable]
	public class NodeTypeInfo
	{
		// Token: 0x06003DCA RID: 15818 RVA: 0x00143280 File Offset: 0x00141480
		[Token(Token = "0x6003DCA")]
		[Address(RVA = "0x84C580", Offset = "0x84AB80", VA = "0x18084C580")]
		public NodeTypeInfo(string type, string display, string cat, string desc, Color color)
		{
			int num = 0;
			base.FieldGetter(num, display, cat);
			this.typeName = type;
			this.displayName = display;
			this.category = cat;
			this.description = 0;
		}

		// Token: 0x04002E43 RID: 11843
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002E43")]
		public string typeName;

		// Token: 0x04002E44 RID: 11844
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002E44")]
		public string displayName;

		// Token: 0x04002E45 RID: 11845
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002E45")]
		public string category;

		// Token: 0x04002E46 RID: 11846
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002E46")]
		public string description;

		// Token: 0x04002E47 RID: 11847
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E47")]
		public Color nodeColor;
	}
}
