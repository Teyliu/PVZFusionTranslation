using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B5A RID: 2906
	[Token(Token = "0x2000B5A")]
	[Serializable]
	public class NodeGroup
	{
		// Token: 0x06003C84 RID: 15492 RVA: 0x0013E1EC File Offset: 0x0013C3EC
		[Token(Token = "0x6003C84")]
		[Address(RVA = "0x7CE570", Offset = "0x7CCB70", VA = "0x1807CE570")]
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

		// Token: 0x06003C85 RID: 15493 RVA: 0x0013E248 File Offset: 0x0013C448
		[Token(Token = "0x6003C85")]
		[Address(RVA = "0x7CE4A0", Offset = "0x7CCAA0", VA = "0x1807CE4A0")]
		public bool ContainsNode(string nodeId)
		{
			return this.nodeIds.Contains(nodeId);
		}

		// Token: 0x06003C86 RID: 15494 RVA: 0x0013E268 File Offset: 0x0013C468
		[Token(Token = "0x6003C86")]
		[Address(RVA = "0x7CE3B0", Offset = "0x7CC9B0", VA = "0x1807CE3B0")]
		public void AddNode(string nodeId)
		{
			if (!string.IsNullOrEmpty(nodeId) && !this.nodeIds.Contains(nodeId))
			{
				int num = this.nodeIds._size;
			}
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x0013E2A4 File Offset: 0x0013C4A4
		[Token(Token = "0x6003C87")]
		[Address(RVA = "0x7CE500", Offset = "0x7CCB00", VA = "0x1807CE500")]
		public bool RemoveNode(string nodeId)
		{
			return this.nodeIds.Remove(nodeId);
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x0013E2C4 File Offset: 0x0013C4C4
		[Token(Token = "0x6003C88")]
		[Address(RVA = "0x7CE560", Offset = "0x7CCB60", VA = "0x1807CE560")]
		public void ToggleFold()
		{
			bool flag = !this.isFolded;
			this.isFolded = flag;
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06003C89 RID: 15497 RVA: 0x0013E2E4 File Offset: 0x0013C4E4
		[Token(Token = "0x170004A5")]
		public int NodeCount
		{
			[Token(Token = "0x6003C89")]
			[Address(RVA = "0x7CE6D0", Offset = "0x7CCCD0", VA = "0x1807CE6D0")]
			get
			{
				return this.nodeIds._size;
			}
		}

		// Token: 0x04002CDA RID: 11482
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002CDA")]
		public string groupId;

		// Token: 0x04002CDB RID: 11483
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002CDB")]
		public string title;

		// Token: 0x04002CDC RID: 11484
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002CDC")]
		[NonSerialized]
		public Color backgroundColor;

		// Token: 0x04002CDD RID: 11485
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002CDD")]
		public List<string> nodeIds;

		// Token: 0x04002CDE RID: 11486
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002CDE")]
		public Vector2 position;

		// Token: 0x04002CDF RID: 11487
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002CDF")]
		[NonSerialized]
		public Vector2 size;

		// Token: 0x04002CE0 RID: 11488
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002CE0")]
		public bool isFolded;
	}
}
