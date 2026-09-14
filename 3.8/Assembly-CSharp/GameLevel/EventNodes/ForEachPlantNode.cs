using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B6E RID: 2926
	[Token(Token = "0x2000B6E")]
	[Serializable]
	public class ForEachPlantNode : EventNodeBase
	{
		// Token: 0x06003CF8 RID: 15608 RVA: 0x00141764 File Offset: 0x0013F964
		[Token(Token = "0x6003CF8")]
		[Address(RVA = "0x7C6CE0", Offset = "0x7C52E0", VA = "0x1807C6CE0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
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
			PortDefinition portDefinition2 = new PortDefinition(this.plantList_PortName, (PortType)((uint)14), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x001417C4 File Offset: 0x0013F9C4
		[Token(Token = "0x6003CF9")]
		[Address(RVA = "0x7C6E50", Offset = "0x7C5450", VA = "0x1807C6E50", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[4];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.loopBody_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.currentPlant_PortName, (PortType)((uint)11), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			PortDefinition portDefinition3 = new PortDefinition(this.currentIndex_PortName, (PortType)((uint)1), (PortDirection)((uint)1));
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			int num2;
			PortDefinition portDefinition4 = new PortDefinition(this.onCompleted_PortName, (PortType)num2, (PortDirection)((uint)1));
			num2 = 0;
			if (portDefinition4 != 0)
			{
			}
			array[3] = portDefinition4;
			return array;
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x00141864 File Offset: 0x0013FA64
		[Token(Token = "0x6003CFA")]
		[Address(RVA = "0x7C70B0", Offset = "0x7C56B0", VA = "0x1807C70B0", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.plantList_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.plantListSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.plantListSourcePort = sourcePortName;
			string text2 = this.loopBody_PortName;
			string nodeId2 = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId2, text2);
			this.loopBodyTargets = connectedNodes;
			string text3 = this.onCompleted_PortName;
			string nodeId3 = this.nodeId;
			List<EventNodeBase> connectedNodes2 = graph.GetConnectedNodes(nodeId3, text3);
			this.onCompletedTargets = connectedNodes2;
			throw new NullReferenceException();
		}

		// Token: 0x06003CFB RID: 15611 RVA: 0x00141908 File Offset: 0x0013FB08
		[Token(Token = "0x6003CFB")]
		[Address(RVA = "0x9A9940", Offset = "0x9A7F40", VA = "0x1809A9940", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x00141948 File Offset: 0x0013FB48
		[Token(Token = "0x6003CFC")]
		[Address(RVA = "0x7C6790", Offset = "0x7C4D90", VA = "0x1807C6790", Slot = "6")]
		public override void Execute()
		{
			int num4;
			do
			{
				int num = 0;
				if (this.plantListSourceNode != 0)
				{
					num += 20;
					num += num;
					if (num != 0)
					{
						string text = string.Format("[ForEachPlantNode] 开始遍历 {0} 个植物", num);
						EventNodeDebug.Log(text);
						int num2 = 0;
						Plant plant;
						this.currentPlant = plant;
						this.currentIndex = num2;
						Plant plant2 = this.currentPlant;
						int num3;
						EventNodeDebug.Log(string.Format("[ForEachPlantNode] 处理第 {0} 个植物: {1}", num3, plant2));
						List<EventNodeBase> list = this.loopBodyTargets;
						bool flag;
						if (flag)
						{
						}
						if (num2 != 0)
						{
							continue;
						}
						num2++;
						this.currentPlant = num2;
						EventNodeDebug.Log(string.Format("[ForEachPlantNode] 遍历完成，共处理 {0} 个植物", text));
						List<EventNodeBase> list2 = this.onCompletedTargets;
						bool flag2;
						if (flag2)
						{
						}
						if (num2 != 0)
						{
							continue;
						}
					}
				}
				string nodeId = this.nodeId;
				EventNodeDebug.LogWarning("[ForEachPlantNode] 植物列表为空或null，节点ID: " + nodeId);
				List<EventNodeBase> list3 = this.onCompletedTargets;
				num4 = 0;
				bool flag3;
				if (flag3)
				{
				}
			}
			while (num4 != 0);
		}

		// Token: 0x06003CFD RID: 15613 RVA: 0x00141A2C File Offset: 0x0013FC2C
		[Token(Token = "0x6003CFD")]
		[Address(RVA = "0x7C71D0", Offset = "0x7C57D0", VA = "0x1807C71D0")]
		public ForEachPlantNode()
		{
			List<EventNodeBase> list = new List();
			this.loopBodyTargets = list;
			List<EventNodeBase> list2 = new List();
			this.onCompletedTargets = list2;
			base..ctor();
		}

		// Token: 0x04002D69 RID: 11625
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002D69")]
		public string trigger_PortName = "触发";

		// Token: 0x04002D6A RID: 11626
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002D6A")]
		public string plantList_PortName = "植物列表";

		// Token: 0x04002D6B RID: 11627
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002D6B")]
		public string loopBody_PortName = "循环体";

		// Token: 0x04002D6C RID: 11628
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002D6C")]
		public string currentPlant_PortName = "当前植物";

		// Token: 0x04002D6D RID: 11629
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002D6D")]
		public string currentIndex_PortName = "当前索引";

		// Token: 0x04002D6E RID: 11630
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002D6E")]
		public string onCompleted_PortName = "循环完成";

		// Token: 0x04002D6F RID: 11631
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002D6F")]
		[NonSerialized]
		private EventNodeBase plantListSourceNode;

		// Token: 0x04002D70 RID: 11632
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002D70")]
		[NonSerialized]
		private string plantListSourcePort;

		// Token: 0x04002D71 RID: 11633
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002D71")]
		[NonSerialized]
		private List<EventNodeBase> loopBodyTargets;

		// Token: 0x04002D72 RID: 11634
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002D72")]
		[NonSerialized]
		private List<EventNodeBase> onCompletedTargets;

		// Token: 0x04002D73 RID: 11635
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002D73")]
		[NonSerialized]
		private Plant currentPlant;

		// Token: 0x04002D74 RID: 11636
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002D74")]
		[NonSerialized]
		private int currentIndex;
	}
}
