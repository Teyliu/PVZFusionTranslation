using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BF6 RID: 3062
	[Token(Token = "0x2000BF6")]
	[Serializable]
	public class RandomTriggerNode : EventNodeBase
	{
		// Token: 0x06003FB1 RID: 16305 RVA: 0x0014E65C File Offset: 0x0014C85C
		[Token(Token = "0x6003FB1")]
		[Address(RVA = "0x86AB30", Offset = "0x869130", VA = "0x18086AB30", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.count_PortName, (PortType)((uint)1), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num4;
			PortDefinition portDefinition3 = new PortDefinition(this.allowRepeat_PortName, (PortType)((uint)6), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06003FB2 RID: 16306 RVA: 0x0014E6DC File Offset: 0x0014C8DC
		[Token(Token = "0x6003FB2")]
		[Address(RVA = "0x86AD10", Offset = "0x869310", VA = "0x18086AD10", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.output_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003FB3 RID: 16307 RVA: 0x0014E714 File Offset: 0x0014C914
		[Token(Token = "0x6003FB3")]
		[Address(RVA = "0x86AE00", Offset = "0x869400", VA = "0x18086AE00", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.count_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.countSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.countSourcePort = sourcePortName;
			string text2 = this.allowRepeat_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.allowRepeatSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.allowRepeatSourcePort = sourcePortName2;
			string text3 = this.output_PortName;
			string nodeId3 = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId3, text3);
			this.outputTargets = connectedNodes;
			throw new NullReferenceException();
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x0014E7E8 File Offset: 0x0014C9E8
		[Token(Token = "0x6003FB4")]
		[Address(RVA = "0x86A6E0", Offset = "0x868CE0", VA = "0x18086A6E0", Slot = "6")]
		public override void Execute()
		{
			if (this.countSourceNode != (ulong)0L)
			{
			}
			int num = 0;
			if (this.allowRepeatSourceNode != num)
			{
			}
			List<EventNodeBase> list = this.outputTargets;
			uint num2;
			if (num2 > (uint)0)
			{
				int size = list._size;
				int num3;
				EventNodeDebug.Log(string.Format("[RandomTriggerNode] 开始随机触发，总节点数: {0}, 触发数量: {1}, 允许重复: {2}", list, num3, num3));
				if (num == 0)
				{
					List<EventNodeBase> list2 = this.outputTargets;
					int num4;
					this.ExecuteWithoutRepeat(num4);
				}
				Random random = new Random();
				List<EventNodeBase> list3 = this.outputTargets;
				int num5 = 0;
				int size2 = list3._size;
				int num6 = random.Next(num5, size2);
				EventNodeBase eventNodeBase = this.outputTargets[num6];
				string nodeName = eventNodeBase.nodeName;
				int num7;
				EventNodeDebug.Log(string.Format("[RandomTriggerNode] 第 {0} 次触发，选择索引: {1}, 节点: {2}", num7, num7, nodeName));
				eventNodeBase.Execute();
				num++;
				EventNodeDebug.Log("[RandomTriggerNode] 随机触发完成");
			}
			string text;
			EventNodeDebug.LogWarning(text);
		}

		// Token: 0x06003FB5 RID: 16309 RVA: 0x0014E8C4 File Offset: 0x0014CAC4
		[Token(Token = "0x6003FB5")]
		[Address(RVA = "0x86A1D0", Offset = "0x8687D0", VA = "0x18086A1D0")]
		private void ExecuteWithRepeat(int count)
		{
			Random random = new Random();
			int num = 0;
			if (count > 0)
			{
				List<EventNodeBase> list = this.outputTargets;
				int num2 = 0;
				int size = list._size;
				int num3 = random.Next(num2, size);
				EventNodeBase eventNodeBase = this.outputTargets[num3];
				string nodeName = eventNodeBase.nodeName;
				int num4;
				EventNodeDebug.Log(string.Format("[RandomTriggerNode] 第 {0} 次触发，选择索引: {1}, 节点: {2}", num4, num4, nodeName));
				eventNodeBase.Execute();
				num++;
			}
		}

		// Token: 0x06003FB6 RID: 16310 RVA: 0x0014E938 File Offset: 0x0014CB38
		[Token(Token = "0x6003FB6")]
		[Address(RVA = "0x86A380", Offset = "0x868980", VA = "0x18086A380")]
		private void ExecuteWithoutRepeat(int count)
		{
			List<int> list = this.availableIndices;
			int num = 0;
			list._size = num;
			List<EventNodeBase> list2 = this.outputTargets;
			List<int> list3 = this.availableIndices;
			int size = list3._size;
			list3._size = 1;
			List<EventNodeBase> list4 = this.outputTargets;
			num++;
			Random random = new Random();
			int num2 = this.availableIndices._size;
			if (num2 > 0)
			{
				int num3 = num2 + 1;
				int num4 = 0;
				int num5 = random.Next(num4, num3);
				int num6 = this.availableIndices[num2];
				List<int> list5 = this.availableIndices;
				num2 = num5;
				int num7 = list5[num2];
				list5[num2] = num7;
				List<int> list6 = this.availableIndices;
				num7 = num6;
				num2 = num5;
				list6[num2] = num7;
			}
			if (count > 0)
			{
				int num8 = this.availableIndices[num];
				List<EventNodeBase> list7 = this.outputTargets;
				EventNodeBase eventNodeBase = list7[num8];
				string nodeName = eventNodeBase.nodeName;
				int num9;
				EventNodeDebug.Log(string.Format("[RandomTriggerNode] 第 {0} 次触发，选择索引: {1}, 节点: {2}", num9, num9, nodeName));
				eventNodeBase.Execute();
				num++;
			}
		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x0014EA54 File Offset: 0x0014CC54
		[Token(Token = "0x6003FB7")]
		[Address(RVA = "0x86AF70", Offset = "0x869570", VA = "0x18086AF70")]
		public RandomTriggerNode()
		{
			List<EventNodeBase> list = new List();
			this.outputTargets = list;
			List<int> list2 = new List();
			this.availableIndices = list2;
			base..ctor();
		}

		// Token: 0x04003083 RID: 12419
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003083")]
		public string trigger_PortName = "触发";

		// Token: 0x04003084 RID: 12420
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003084")]
		public string count_PortName = "触发数量";

		// Token: 0x04003085 RID: 12421
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003085")]
		public string allowRepeat_PortName = "重复触发";

		// Token: 0x04003086 RID: 12422
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003086")]
		public string output_PortName = "触发";

		// Token: 0x04003087 RID: 12423
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003087")]
		[NonSerialized]
		private EventNodeBase countSourceNode;

		// Token: 0x04003088 RID: 12424
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003088")]
		[NonSerialized]
		private string countSourcePort;

		// Token: 0x04003089 RID: 12425
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003089")]
		[NonSerialized]
		private EventNodeBase allowRepeatSourceNode;

		// Token: 0x0400308A RID: 12426
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400308A")]
		[NonSerialized]
		private string allowRepeatSourcePort;

		// Token: 0x0400308B RID: 12427
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400308B")]
		[NonSerialized]
		private List<EventNodeBase> outputTargets;

		// Token: 0x0400308C RID: 12428
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400308C")]
		[NonSerialized]
		private List<int> availableIndices;
	}
}
