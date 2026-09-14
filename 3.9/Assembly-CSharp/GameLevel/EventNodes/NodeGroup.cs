using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B9C RID: 2972
	[Token(Token = "0x2000B9C")]
	[Serializable]
	public class NodeGroup
	{
		// Token: 0x06003DD5 RID: 15829 RVA: 0x0014349C File Offset: 0x0014169C
		[Token(Token = "0x6003DD5")]
		[Address(RVA = "0x84A8D0", Offset = "0x848ED0", VA = "0x18084A8D0")]
		public NodeGroup()
		{
			Guid guid = Guid.NewGuid();
			string text;
			this.groupId = text;
			this.title = "新分组";
			List<string> list = new List();
			this.nodeIds = list;
			Vector2 zeroVector = Vector2.zeroVector;
			this.position = zeroVector;
			Vector2 zeroVector2 = Vector2.zeroVector;
			this.size = zeroVector2;
		}

		// Token: 0x06003DD6 RID: 15830 RVA: 0x001434F8 File Offset: 0x001416F8
		[Token(Token = "0x6003DD6")]
		[Address(RVA = "0x84A800", Offset = "0x848E00", VA = "0x18084A800")]
		public bool ContainsNode(string nodeId)
		{
			return this.nodeIds.Contains(nodeId);
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x00143518 File Offset: 0x00141718
		[Token(Token = "0x6003DD7")]
		[Address(RVA = "0x84A710", Offset = "0x848D10", VA = "0x18084A710")]
		public void AddNode(string nodeId)
		{
			if (!string.IsNullOrEmpty(nodeId) && !this.nodeIds.Contains(nodeId))
			{
				int num = this.nodeIds._size;
			}
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x00143554 File Offset: 0x00141754
		[Token(Token = "0x6003DD8")]
		[Address(RVA = "0x84A860", Offset = "0x848E60", VA = "0x18084A860")]
		public bool RemoveNode(string nodeId)
		{
			return this.nodeIds.Remove(nodeId);
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x00143574 File Offset: 0x00141774
		[Token(Token = "0x6003DD9")]
		[Address(RVA = "0x84A8C0", Offset = "0x848EC0", VA = "0x18084A8C0")]
		public void ToggleFold()
		{
			bool flag = !this.isFolded;
			this.isFolded = flag;
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06003DDA RID: 15834 RVA: 0x00143594 File Offset: 0x00141794
		[Token(Token = "0x170004F5")]
		public int NodeCount
		{
			[Token(Token = "0x6003DDA")]
			[Address(RVA = "0x84AA30", Offset = "0x849030", VA = "0x18084AA30")]
			get
			{
				return this.nodeIds._size;
			}
		}

		// Token: 0x04002E4E RID: 11854
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002E4E")]
		public string groupId;

		// Token: 0x04002E4F RID: 11855
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002E4F")]
		public string title;

		// Token: 0x04002E50 RID: 11856
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002E50")]
		[NonSerialized]
		public Color backgroundColor;

		// Token: 0x04002E51 RID: 11857
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E51")]
		public List<string> nodeIds;

		// Token: 0x04002E52 RID: 11858
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E52")]
		public Vector2 position;

		// Token: 0x04002E53 RID: 11859
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E53")]
		[NonSerialized]
		public Vector2 size;

		// Token: 0x04002E54 RID: 11860
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E54")]
		public bool isFolded;
	}
}
