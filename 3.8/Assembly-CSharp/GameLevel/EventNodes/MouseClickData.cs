using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B59 RID: 2905
	[Token(Token = "0x2000B59")]
	[Serializable]
	public class MouseClickData
	{
		// Token: 0x06003C83 RID: 15491 RVA: 0x0013E1BC File Offset: 0x0013C3BC
		[Token(Token = "0x6003C83")]
		[Address(RVA = "0x7CA8C0", Offset = "0x7C8EC0", VA = "0x1807CA8C0")]
		public MouseClickData(int row, int column, GameObject item, bool isLeft)
		{
			this.row = row;
			this.column = column;
			this.itemOnMouse = item;
			this.isLeftButton = false;
		}

		// Token: 0x04002CD6 RID: 11478
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002CD6")]
		public int row;

		// Token: 0x04002CD7 RID: 11479
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4002CD7")]
		public int column;

		// Token: 0x04002CD8 RID: 11480
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002CD8")]
		public GameObject itemOnMouse;

		// Token: 0x04002CD9 RID: 11481
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002CD9")]
		public bool isLeftButton;
	}
}
