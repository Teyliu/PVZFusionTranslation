using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C06 RID: 3078
	[Token(Token = "0x2000C06")]
	[Serializable]
	public class ModifyPlantAttackNode : EventNodeBase
	{
		// Token: 0x06004003 RID: 16387 RVA: 0x001508F0 File Offset: 0x0014EAF0
		[Token(Token = "0x6004003")]
		[Address(RVA = "0x861E20", Offset = "0x860420", VA = "0x180861E20", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.plant_PortName, (PortType)((uint)11), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num4;
			PortDefinition portDefinition3 = new PortDefinition(this.multiplier_PortName, (PortType)((uint)3), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06004004 RID: 16388 RVA: 0x00150970 File Offset: 0x0014EB70
		[Token(Token = "0x6004004")]
		[Address(RVA = "0x862000", Offset = "0x860600", VA = "0x180862000", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.onModified_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.plantOut_PortName, (PortType)((uint)11), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06004005 RID: 16389 RVA: 0x001509C8 File Offset: 0x0014EBC8
		[Token(Token = "0x6004005")]
		[Address(RVA = "0x862170", Offset = "0x860770", VA = "0x180862170", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.plant_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.plantSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.plantSourcePort = sourcePortName;
			string text2 = this.multiplier_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.multiplierSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.multiplierSourcePort = sourcePortName2;
			string text3 = this.onModified_PortName;
			string nodeId3 = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId3, text3);
			this.onModifiedTargets = connectedNodes;
			throw new NullReferenceException();
		}

		// Token: 0x06004006 RID: 16390 RVA: 0x00150A9C File Offset: 0x0014EC9C
		[Token(Token = "0x6004006")]
		[Address(RVA = "0xA98F30", Offset = "0xA97530", VA = "0x180A98F30", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06004007 RID: 16391 RVA: 0x00150AE4 File Offset: 0x0014ECE4
		[Token(Token = "0x6004007")]
		[Address(RVA = "0x861AA0", Offset = "0x8600A0", VA = "0x180861AA0", Slot = "6")]
		public override void Execute()
		{
			int num;
			do
			{
				num = 0;
				int num2 = 0;
				if (this.plantSourceNode != 0)
				{
					num2 += 20;
					num2 += num2;
				}
				this.targetPlant = num2;
				if (this.multiplierSourceNode != 0)
				{
					string text = this.multiplierSourcePort;
					num2 += 20;
					num2 += num2;
				}
				Plant plant = this.targetPlant;
				int num3 = 0;
				if (!(plant != num3))
				{
					break;
				}
				Plant plant2 = this.targetPlant;
				EventNodeDebug.Log(string.Format("[ModifyPlantAttackNode] 修改植物攻击力加成{0}%", num));
				List<EventNodeBase> list = this.onModifiedTargets;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != 0);
			string text2;
			EventNodeDebug.LogWarning(text2);
		}

		// Token: 0x06004008 RID: 16392 RVA: 0x00150B80 File Offset: 0x0014ED80
		[Token(Token = "0x6004008")]
		[Address(RVA = "0x8622E0", Offset = "0x8608E0", VA = "0x1808622E0")]
		public ModifyPlantAttackNode()
		{
			List<EventNodeBase> list = new List();
			this.onModifiedTargets = list;
			base..ctor();
		}

		// Token: 0x040030F8 RID: 12536
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40030F8")]
		public string trigger_PortName = "触发";

		// Token: 0x040030F9 RID: 12537
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40030F9")]
		public string plant_PortName = "植物";

		// Token: 0x040030FA RID: 12538
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40030FA")]
		public string multiplier_PortName = "攻击力加成x100%";

		// Token: 0x040030FB RID: 12539
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40030FB")]
		public string onModified_PortName = "修改成功";

		// Token: 0x040030FC RID: 12540
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40030FC")]
		public string plantOut_PortName = "植物";

		// Token: 0x040030FD RID: 12541
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40030FD")]
		[NonSerialized]
		private EventNodeBase plantSourceNode;

		// Token: 0x040030FE RID: 12542
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40030FE")]
		[NonSerialized]
		private string plantSourcePort;

		// Token: 0x040030FF RID: 12543
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40030FF")]
		[NonSerialized]
		private EventNodeBase multiplierSourceNode;

		// Token: 0x04003100 RID: 12544
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4003100")]
		[NonSerialized]
		private string multiplierSourcePort;

		// Token: 0x04003101 RID: 12545
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4003101")]
		[NonSerialized]
		private List<EventNodeBase> onModifiedTargets;

		// Token: 0x04003102 RID: 12546
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4003102")]
		private Plant targetPlant;
	}
}
