using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BB1 RID: 2993
	[Token(Token = "0x2000BB1")]
	[Serializable]
	public class ForEachPlantTypeNode : EventNodeBase
	{
		// Token: 0x06003E4F RID: 15951 RVA: 0x00146D30 File Offset: 0x00144F30
		[Token(Token = "0x6003E4F")]
		[Address(RVA = "0x843C20", Offset = "0x842220", VA = "0x180843C20", Slot = "4")]
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

		// Token: 0x06003E50 RID: 15952 RVA: 0x00146D90 File Offset: 0x00144F90
		[Token(Token = "0x6003E50")]
		[Address(RVA = "0x843D90", Offset = "0x842390", VA = "0x180843D90", Slot = "5")]
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

		// Token: 0x06003E51 RID: 15953 RVA: 0x00146E2C File Offset: 0x0014502C
		[Token(Token = "0x6003E51")]
		[Address(RVA = "0x843FF0", Offset = "0x8425F0", VA = "0x180843FF0", Slot = "7")]
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

		// Token: 0x06003E52 RID: 15954 RVA: 0x00146ED0 File Offset: 0x001450D0
		[Token(Token = "0x6003E52")]
		[Address(RVA = "0xA538D0", Offset = "0xA51ED0", VA = "0x180A538D0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x00146F0C File Offset: 0x0014510C
		[Token(Token = "0x6003E53")]
		[Address(RVA = "0x8436C0", Offset = "0x841CC0", VA = "0x1808436C0", Slot = "6")]
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

		// Token: 0x06003E54 RID: 15956 RVA: 0x00147000 File Offset: 0x00145200
		[Token(Token = "0x6003E54")]
		[Address(RVA = "0x844110", Offset = "0x842710", VA = "0x180844110")]
		public ForEachPlantTypeNode()
		{
			List<EventNodeBase> list = new List();
			this.loopBodyTargets = list;
			List<EventNodeBase> list2 = new List();
			this.onCompletedTargets = list2;
			base..ctor();
		}

		// Token: 0x04002EE9 RID: 12009
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002EE9")]
		public string trigger_PortName = "触发";

		// Token: 0x04002EEA RID: 12010
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002EEA")]
		public string plantTypeList_PortName = "植物类型列表";

		// Token: 0x04002EEB RID: 12011
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002EEB")]
		public string loopBody_PortName = "循环体";

		// Token: 0x04002EEC RID: 12012
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002EEC")]
		public string currentPlantType_PortName = "当前类型";

		// Token: 0x04002EED RID: 12013
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002EED")]
		public string currentIndex_PortName = "当前索引";

		// Token: 0x04002EEE RID: 12014
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002EEE")]
		public string onCompleted_PortName = "循环完成";

		// Token: 0x04002EEF RID: 12015
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002EEF")]
		[NonSerialized]
		private EventNodeBase plantTypeListSourceNode;

		// Token: 0x04002EF0 RID: 12016
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002EF0")]
		[NonSerialized]
		private string plantTypeListSourcePort;

		// Token: 0x04002EF1 RID: 12017
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002EF1")]
		[NonSerialized]
		private List<EventNodeBase> loopBodyTargets;

		// Token: 0x04002EF2 RID: 12018
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002EF2")]
		[NonSerialized]
		private List<EventNodeBase> onCompletedTargets;

		// Token: 0x04002EF3 RID: 12019
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002EF3")]
		[NonSerialized]
		private PlantType currentPlantType;

		// Token: 0x04002EF4 RID: 12020
		[FieldOffset(Offset = "0x84")]
		[Token(Token = "0x4002EF4")]
		[NonSerialized]
		private int currentIndex;
	}
}
