using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C07 RID: 3079
	[Token(Token = "0x2000C07")]
	[Serializable]
	public class ModifyPlantHealthNode : EventNodeBase
	{
		// Token: 0x06004009 RID: 16393 RVA: 0x00150BD8 File Offset: 0x0014EDD8
		[Token(Token = "0x6004009")]
		[Address(RVA = "0x8627C0", Offset = "0x860DC0", VA = "0x1808627C0", Slot = "4")]
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

		// Token: 0x0600400A RID: 16394 RVA: 0x00150C58 File Offset: 0x0014EE58
		[Token(Token = "0x600400A")]
		[Address(RVA = "0x8629A0", Offset = "0x860FA0", VA = "0x1808629A0", Slot = "5")]
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

		// Token: 0x0600400B RID: 16395 RVA: 0x00150CB0 File Offset: 0x0014EEB0
		[Token(Token = "0x600400B")]
		[Address(RVA = "0x862B10", Offset = "0x861110", VA = "0x180862B10", Slot = "7")]
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

		// Token: 0x0600400C RID: 16396 RVA: 0x00150D84 File Offset: 0x0014EF84
		[Token(Token = "0x600400C")]
		[Address(RVA = "0xA98F30", Offset = "0xA97530", VA = "0x180A98F30", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x0600400D RID: 16397 RVA: 0x00150DCC File Offset: 0x0014EFCC
		[Token(Token = "0x600400D")]
		[Address(RVA = "0x862410", Offset = "0x860A10", VA = "0x180862410", Slot = "6")]
		public override void Execute()
		{
			ulong num4;
			do
			{
				int num = 0;
				if (this.plantSourceNode != 0)
				{
					num += 20;
					num += num;
				}
				this.targetPlant = num;
				if (this.multiplierSourceNode != 0)
				{
					string text = this.multiplierSourcePort;
					num += 20;
					num += num;
				}
				int num2 = 0;
				Plant plant = this.targetPlant;
				int num3 = 0;
				if (!(plant != num3))
				{
					break;
				}
				Plant plant2 = this.targetPlant;
				this.targetPlant.UpdateText();
				EventNodeDebug.Log(string.Format("[ModifyPlantHealthNode] 修改植物血量加成{0}%", num2));
				List<EventNodeBase> list = this.onModifiedTargets;
				bool flag;
				if (flag)
				{
				}
			}
			while (num4 != (ulong)0L);
			string text2;
			EventNodeDebug.LogWarning(text2);
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x00150E78 File Offset: 0x0014F078
		[Token(Token = "0x600400E")]
		[Address(RVA = "0x862C80", Offset = "0x861280", VA = "0x180862C80")]
		public ModifyPlantHealthNode()
		{
			List<EventNodeBase> list = new List();
			this.onModifiedTargets = list;
			base..ctor();
		}

		// Token: 0x04003103 RID: 12547
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003103")]
		public string trigger_PortName = "触发";

		// Token: 0x04003104 RID: 12548
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003104")]
		public string plant_PortName = "植物";

		// Token: 0x04003105 RID: 12549
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003105")]
		public string multiplier_PortName = "血量加成x100%";

		// Token: 0x04003106 RID: 12550
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003106")]
		public string onModified_PortName = "修改成功";

		// Token: 0x04003107 RID: 12551
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003107")]
		public string plantOut_PortName = "植物";

		// Token: 0x04003108 RID: 12552
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003108")]
		[NonSerialized]
		private EventNodeBase plantSourceNode;

		// Token: 0x04003109 RID: 12553
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003109")]
		[NonSerialized]
		private string plantSourcePort;

		// Token: 0x0400310A RID: 12554
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400310A")]
		[NonSerialized]
		private EventNodeBase multiplierSourceNode;

		// Token: 0x0400310B RID: 12555
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400310B")]
		[NonSerialized]
		private string multiplierSourcePort;

		// Token: 0x0400310C RID: 12556
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400310C")]
		[NonSerialized]
		private List<EventNodeBase> onModifiedTargets;

		// Token: 0x0400310D RID: 12557
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400310D")]
		private Plant targetPlant;
	}
}
