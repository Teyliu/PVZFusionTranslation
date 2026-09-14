using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B57 RID: 2903
	[Token(Token = "0x2000B57")]
	[Serializable]
	public class NodeTypeInfo
	{
		// Token: 0x06003C79 RID: 15481 RVA: 0x0013DFD0 File Offset: 0x0013C1D0
		[Token(Token = "0x6003C79")]
		[Address(RVA = "0x7D0220", Offset = "0x7CE820", VA = "0x1807D0220")]
		public NodeTypeInfo(string type, string display, string cat, string desc, Color color)
		{
			int num = 0;
			base.FieldGetter(num, display, cat);
			this.typeName = type;
			this.displayName = display;
			this.category = cat;
			this.description = 0;
		}

		// Token: 0x04002CCF RID: 11471
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002CCF")]
		public string typeName;

		// Token: 0x04002CD0 RID: 11472
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002CD0")]
		public string displayName;

		// Token: 0x04002CD1 RID: 11473
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002CD1")]
		public string category;

		// Token: 0x04002CD2 RID: 11474
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002CD2")]
		public string description;

		// Token: 0x04002CD3 RID: 11475
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002CD3")]
		public Color nodeColor;
	}
}
