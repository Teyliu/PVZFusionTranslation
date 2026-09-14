using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BC8 RID: 3016
	[Token(Token = "0x2000BC8")]
	[Serializable]
	public class CreateParticleNode : EventNodeBase
	{
		// Token: 0x06003EC5 RID: 16069 RVA: 0x00149CC4 File Offset: 0x00147EC4
		[Token(Token = "0x6003EC5")]
		[Address(RVA = "0x85A3A0", Offset = "0x8589A0", VA = "0x18085A3A0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[3];
			int num;
			int num2;
			PortDefinition portDefinition = new PortDefinition(this.trigger_PortName, (PortType)num, (PortDirection)num2);
			num2 = 0;
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num3;
			PortDefinition portDefinition2 = new PortDefinition(this.row_PortName, (PortType)((uint)1), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num4;
			PortDefinition portDefinition3 = new PortDefinition(this.column_PortName, (PortType)((uint)1), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06003EC6 RID: 16070 RVA: 0x00149D44 File Offset: 0x00147F44
		[Token(Token = "0x6003EC6")]
		[Address(RVA = "0x85A580", Offset = "0x858B80", VA = "0x18085A580", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003EC7 RID: 16071 RVA: 0x00149D54 File Offset: 0x00147F54
		[Token(Token = "0x6003EC7")]
		[Address(RVA = "0x85A5C0", Offset = "0x858BC0", VA = "0x18085A5C0", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.row_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.rowSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.rowSourcePort = sourcePortName;
			string text2 = this.column_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.columnSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.columnSourcePort = sourcePortName2;
		}

		// Token: 0x06003EC8 RID: 16072 RVA: 0x00149E04 File Offset: 0x00148004
		[Token(Token = "0x6003EC8")]
		[Address(RVA = "0x85A110", Offset = "0x858710", VA = "0x18085A110", Slot = "6")]
		public override void Execute()
		{
			if (this.rowSourceNode != (ulong)0L)
			{
			}
			int num = 0;
			if (this.columnSourceNode != (ulong)0L)
			{
			}
			int num2 = 0;
			ParticleManager instance = ParticleManager.Instance;
			int num3 = 0;
			if (!(instance == num3))
			{
				Vector2 position = Board.Instance.gridSystem.GetGrid(num2, num).Position;
				int num4;
				int num5;
				EventNodeDebug.Log(string.Format("[CreateParticleNode] 在 ({0}, {1}) 创建RandomCloud粒子特效", num4, num5));
				return;
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[CreateParticleNode] ParticleManager实例不存在，节点ID: " + nodeId);
		}

		// Token: 0x06003EC9 RID: 16073 RVA: 0x00149E8C File Offset: 0x0014808C
		[Token(Token = "0x6003EC9")]
		[Address(RVA = "0x85A710", Offset = "0x858D10", VA = "0x18085A710")]
		public CreateParticleNode()
		{
		}

		// Token: 0x04002F9A RID: 12186
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F9A")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F9B RID: 12187
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F9B")]
		public string row_PortName = "行";

		// Token: 0x04002F9C RID: 12188
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F9C")]
		public string column_PortName = "列";

		// Token: 0x04002F9D RID: 12189
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F9D")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002F9E RID: 12190
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F9E")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002F9F RID: 12191
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F9F")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002FA0 RID: 12192
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002FA0")]
		[NonSerialized]
		private string columnSourcePort;
	}
}
