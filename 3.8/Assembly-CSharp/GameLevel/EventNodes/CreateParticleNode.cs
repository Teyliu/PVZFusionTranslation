using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B86 RID: 2950
	[Token(Token = "0x2000B86")]
	[Serializable]
	public class CreateParticleNode : EventNodeBase
	{
		// Token: 0x06003D74 RID: 15732 RVA: 0x00144A34 File Offset: 0x00142C34
		[Token(Token = "0x6003D74")]
		[Address(RVA = "0x7F28D0", Offset = "0x7F0ED0", VA = "0x1807F28D0", Slot = "4")]
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

		// Token: 0x06003D75 RID: 15733 RVA: 0x00144AB4 File Offset: 0x00142CB4
		[Token(Token = "0x6003D75")]
		[Address(RVA = "0x7F2AB0", Offset = "0x7F10B0", VA = "0x1807F2AB0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003D76 RID: 15734 RVA: 0x00144AC4 File Offset: 0x00142CC4
		[Token(Token = "0x6003D76")]
		[Address(RVA = "0x7F2AF0", Offset = "0x7F10F0", VA = "0x1807F2AF0", Slot = "7")]
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

		// Token: 0x06003D77 RID: 15735 RVA: 0x00144B74 File Offset: 0x00142D74
		[Token(Token = "0x6003D77")]
		[Address(RVA = "0x7F2640", Offset = "0x7F0C40", VA = "0x1807F2640", Slot = "6")]
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

		// Token: 0x06003D78 RID: 15736 RVA: 0x00144BFC File Offset: 0x00142DFC
		[Token(Token = "0x6003D78")]
		[Address(RVA = "0x7F2C40", Offset = "0x7F1240", VA = "0x1807F2C40")]
		public CreateParticleNode()
		{
		}

		// Token: 0x04002E26 RID: 11814
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E26")]
		public string trigger_PortName = "触发";

		// Token: 0x04002E27 RID: 11815
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E27")]
		public string row_PortName = "行";

		// Token: 0x04002E28 RID: 11816
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E28")]
		public string column_PortName = "列";

		// Token: 0x04002E29 RID: 11817
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E29")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002E2A RID: 11818
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002E2A")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002E2B RID: 11819
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002E2B")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002E2C RID: 11820
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002E2C")]
		[NonSerialized]
		private string columnSourcePort;
	}
}
