using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B6F RID: 2927
	[Token(Token = "0x2000B6F")]
	[Serializable]
	public class ForEachPlantTypeNode : EventNodeBase
	{
		// Token: 0x06003CFE RID: 15614 RVA: 0x00141A9C File Offset: 0x0013FC9C
		[Token(Token = "0x6003CFE")]
		[Address(RVA = "0x7C78C0", Offset = "0x7C5EC0", VA = "0x1807C78C0", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.plantTypeList_PortName, (PortType)((uint)16), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x00141AFC File Offset: 0x0013FCFC
		[Token(Token = "0x6003CFF")]
		[Address(RVA = "0x7C7A30", Offset = "0x7C6030", VA = "0x1807C7A30", Slot = "5")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.currentPlantType_PortName, (PortType)((uint)9), (PortDirection)((uint)1));
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

		// Token: 0x06003D00 RID: 15616 RVA: 0x00141B98 File Offset: 0x0013FD98
		[Token(Token = "0x6003D00")]
		[Address(RVA = "0x7C7C90", Offset = "0x7C6290", VA = "0x1807C7C90", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.plantTypeList_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.plantTypeListSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.plantTypeListSourcePort = sourcePortName;
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

		// Token: 0x06003D01 RID: 15617 RVA: 0x00141C3C File Offset: 0x0013FE3C
		[Token(Token = "0x6003D01")]
		[Address(RVA = "0x9AA310", Offset = "0x9A8910", VA = "0x1809AA310", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x00141C78 File Offset: 0x0013FE78
		[Token(Token = "0x6003D02")]
		[Address(RVA = "0x7C7360", Offset = "0x7C5960", VA = "0x1807C7360", Slot = "6")]
		public override void Execute()
		{
			int num4;
			do
			{
				int num = 0;
				if (this.plantTypeListSourceNode != num)
				{
					EventNodeBase eventNodeBase = this.plantTypeListSourceNode;
					num += 20;
					num += num;
					if (num != 0)
					{
						string text = string.Format("[ForEachPlantTypeNode] 开始遍历 {0} 个植物类型", num);
						EventNodeDebug.Log(text);
						int num2 = 0;
						PlantType plantType;
						this.currentPlantType = plantType;
						this.currentIndex = num2;
						PlantType plantType2 = this.currentPlantType;
						int num3;
						EventNodeDebug.Log(string.Format("[ForEachPlantTypeNode] 处理第 {0} 个植物类型: {1}", num3, num3));
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
						this.currentPlantType = (PlantType)num2;
						EventNodeDebug.Log(string.Format("[ForEachPlantTypeNode] 遍历完成，共处理 {0} 个植物类型", text));
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
				EventNodeDebug.LogWarning("[ForEachPlantTypeNode] 植物类型列表为空或null，节点ID: " + nodeId);
				List<EventNodeBase> list3 = this.onCompletedTargets;
				num4 = 0;
				bool flag3;
				if (flag3)
				{
				}
			}
			while (num4 != 0);
		}

		// Token: 0x06003D03 RID: 15619 RVA: 0x00141D6C File Offset: 0x0013FF6C
		[Token(Token = "0x6003D03")]
		[Address(RVA = "0x7C7DB0", Offset = "0x7C63B0", VA = "0x1807C7DB0")]
		public ForEachPlantTypeNode()
		{
			List<EventNodeBase> list = new List();
			this.loopBodyTargets = list;
			List<EventNodeBase> list2 = new List();
			this.onCompletedTargets = list2;
			base..ctor();
		}

		// Token: 0x04002D75 RID: 11637
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002D75")]
		public string trigger_PortName = "触发";

		// Token: 0x04002D76 RID: 11638
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002D76")]
		public string plantTypeList_PortName = "植物类型列表";

		// Token: 0x04002D77 RID: 11639
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002D77")]
		public string loopBody_PortName = "循环体";

		// Token: 0x04002D78 RID: 11640
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002D78")]
		public string currentPlantType_PortName = "当前类型";

		// Token: 0x04002D79 RID: 11641
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002D79")]
		public string currentIndex_PortName = "当前索引";

		// Token: 0x04002D7A RID: 11642
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002D7A")]
		public string onCompleted_PortName = "循环完成";

		// Token: 0x04002D7B RID: 11643
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002D7B")]
		[NonSerialized]
		private EventNodeBase plantTypeListSourceNode;

		// Token: 0x04002D7C RID: 11644
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002D7C")]
		[NonSerialized]
		private string plantTypeListSourcePort;

		// Token: 0x04002D7D RID: 11645
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002D7D")]
		[NonSerialized]
		private List<EventNodeBase> loopBodyTargets;

		// Token: 0x04002D7E RID: 11646
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002D7E")]
		[NonSerialized]
		private List<EventNodeBase> onCompletedTargets;

		// Token: 0x04002D7F RID: 11647
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002D7F")]
		[NonSerialized]
		private PlantType currentPlantType;

		// Token: 0x04002D80 RID: 11648
		[FieldOffset(Offset = "0x84")]
		[Token(Token = "0x4002D80")]
		[NonSerialized]
		private int currentIndex;
	}
}
