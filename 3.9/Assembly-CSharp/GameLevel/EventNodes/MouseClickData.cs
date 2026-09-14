using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B9B RID: 2971
	[Token(Token = "0x2000B9B")]
	[Serializable]
	public class MouseClickData
	{
		// Token: 0x06003DD4 RID: 15828 RVA: 0x0014346C File Offset: 0x0014166C
		[Token(Token = "0x6003DD4")]
		[Address(RVA = "0x846C20", Offset = "0x845220", VA = "0x180846C20")]
		public MouseClickData(int row, int column, GameObject item, bool isLeft)
		{
			this.row = row;
			this.column = column;
			this.itemOnMouse = item;
			this.isLeftButton = false;
		}

		// Token: 0x04002E4A RID: 11850
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002E4A")]
		public int row;

		// Token: 0x04002E4B RID: 11851
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4002E4B")]
		public int column;

		// Token: 0x04002E4C RID: 11852
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002E4C")]
		public GameObject itemOnMouse;

		// Token: 0x04002E4D RID: 11853
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002E4D")]
		public bool isLeftButton;
	}
}
