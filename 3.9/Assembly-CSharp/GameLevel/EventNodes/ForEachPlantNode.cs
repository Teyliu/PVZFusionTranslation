using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BB0 RID: 2992
	[Token(Token = "0x2000BB0")]
	[Serializable]
	public class ForEachPlantNode : EventNodeBase
	{
		// Token: 0x06003E49 RID: 15945 RVA: 0x001469FC File Offset: 0x00144BFC
		[Token(Token = "0x6003E49")]
		[Address(RVA = "0x843040", Offset = "0x841640", VA = "0x180843040", Slot = "4")]
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

		// Token: 0x06003E4A RID: 15946 RVA: 0x00146A5C File Offset: 0x00144C5C
		[Token(Token = "0x6003E4A")]
		[Address(RVA = "0x8431B0", Offset = "0x8417B0", VA = "0x1808431B0", Slot = "5")]
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

		// Token: 0x06003E4B RID: 15947 RVA: 0x00146AF8 File Offset: 0x00144CF8
		[Token(Token = "0x6003E4B")]
		[Address(RVA = "0x843410", Offset = "0x841A10", VA = "0x180843410", Slot = "7")]
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

		// Token: 0x06003E4C RID: 15948 RVA: 0x00146B9C File Offset: 0x00144D9C
		[Token(Token = "0x6003E4C")]
		[Address(RVA = "0xA52F00", Offset = "0xA51500", VA = "0x180A52F00", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003E4D RID: 15949 RVA: 0x00146BDC File Offset: 0x00144DDC
		[Token(Token = "0x6003E4D")]
		[Address(RVA = "0x842AF0", Offset = "0x8410F0", VA = "0x180842AF0", Slot = "6")]
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

		// Token: 0x06003E4E RID: 15950 RVA: 0x00146CC0 File Offset: 0x00144EC0
		[Token(Token = "0x6003E4E")]
		[Address(RVA = "0x843530", Offset = "0x841B30", VA = "0x180843530")]
		public ForEachPlantNode()
		{
			List<EventNodeBase> list = new List();
			this.loopBodyTargets = list;
			List<EventNodeBase> list2 = new List();
			this.onCompletedTargets = list2;
			base..ctor();
		}

		// Token: 0x04002EDD RID: 11997
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002EDD")]
		public string trigger_PortName = "触发";

		// Token: 0x04002EDE RID: 11998
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002EDE")]
		public string plantList_PortName = "植物列表";

		// Token: 0x04002EDF RID: 11999
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002EDF")]
		public string loopBody_PortName = "循环体";

		// Token: 0x04002EE0 RID: 12000
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002EE0")]
		public string currentPlant_PortName = "当前植物";

		// Token: 0x04002EE1 RID: 12001
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002EE1")]
		public string currentIndex_PortName = "当前索引";

		// Token: 0x04002EE2 RID: 12002
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002EE2")]
		public string onCompleted_PortName = "循环完成";

		// Token: 0x04002EE3 RID: 12003
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002EE3")]
		[NonSerialized]
		private EventNodeBase plantListSourceNode;

		// Token: 0x04002EE4 RID: 12004
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002EE4")]
		[NonSerialized]
		private string plantListSourcePort;

		// Token: 0x04002EE5 RID: 12005
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002EE5")]
		[NonSerialized]
		private List<EventNodeBase> loopBodyTargets;

		// Token: 0x04002EE6 RID: 12006
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002EE6")]
		[NonSerialized]
		private List<EventNodeBase> onCompletedTargets;

		// Token: 0x04002EE7 RID: 12007
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002EE7")]
		[NonSerialized]
		private Plant currentPlant;

		// Token: 0x04002EE8 RID: 12008
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002EE8")]
		[NonSerialized]
		private int currentIndex;
	}
}
