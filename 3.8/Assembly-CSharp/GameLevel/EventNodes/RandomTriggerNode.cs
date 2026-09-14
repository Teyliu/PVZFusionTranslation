using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BB4 RID: 2996
	[Token(Token = "0x2000BB4")]
	[Serializable]
	public class RandomTriggerNode : EventNodeBase
	{
		// Token: 0x06003E60 RID: 15968 RVA: 0x001493EC File Offset: 0x001475EC
		[Token(Token = "0x6003E60")]
		[Address(RVA = "0x803180", Offset = "0x801780", VA = "0x180803180", Slot = "4")]
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

		// Token: 0x06003E61 RID: 15969 RVA: 0x0014946C File Offset: 0x0014766C
		[Token(Token = "0x6003E61")]
		[Address(RVA = "0x803360", Offset = "0x801960", VA = "0x180803360", Slot = "5")]
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

		// Token: 0x06003E62 RID: 15970 RVA: 0x001494A4 File Offset: 0x001476A4
		[Token(Token = "0x6003E62")]
		[Address(RVA = "0x803450", Offset = "0x801A50", VA = "0x180803450", Slot = "7")]
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

		// Token: 0x06003E63 RID: 15971 RVA: 0x00149578 File Offset: 0x00147778
		[Token(Token = "0x6003E63")]
		[Address(RVA = "0x802D30", Offset = "0x801330", VA = "0x180802D30", Slot = "6")]
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

		// Token: 0x06003E64 RID: 15972 RVA: 0x00149654 File Offset: 0x00147854
		[Token(Token = "0x6003E64")]
		[Address(RVA = "0x802820", Offset = "0x800E20", VA = "0x180802820")]
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

		// Token: 0x06003E65 RID: 15973 RVA: 0x001496C8 File Offset: 0x001478C8
		[Token(Token = "0x6003E65")]
		[Address(RVA = "0x8029D0", Offset = "0x800FD0", VA = "0x1808029D0")]
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

		// Token: 0x06003E66 RID: 15974 RVA: 0x001497E4 File Offset: 0x001479E4
		[Token(Token = "0x6003E66")]
		[Address(RVA = "0x8035C0", Offset = "0x801BC0", VA = "0x1808035C0")]
		public RandomTriggerNode()
		{
			List<EventNodeBase> list = new List();
			this.outputTargets = list;
			List<int> list2 = new List();
			this.availableIndices = list2;
			base..ctor();
		}

		// Token: 0x04002F0F RID: 12047
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F0F")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F10 RID: 12048
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F10")]
		public string count_PortName = "触发数量";

		// Token: 0x04002F11 RID: 12049
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F11")]
		public string allowRepeat_PortName = "重复触发";

		// Token: 0x04002F12 RID: 12050
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F12")]
		public string output_PortName = "触发";

		// Token: 0x04002F13 RID: 12051
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F13")]
		[NonSerialized]
		private EventNodeBase countSourceNode;

		// Token: 0x04002F14 RID: 12052
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F14")]
		[NonSerialized]
		private string countSourcePort;

		// Token: 0x04002F15 RID: 12053
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F15")]
		[NonSerialized]
		private EventNodeBase allowRepeatSourceNode;

		// Token: 0x04002F16 RID: 12054
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002F16")]
		[NonSerialized]
		private string allowRepeatSourcePort;

		// Token: 0x04002F17 RID: 12055
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002F17")]
		[NonSerialized]
		private List<EventNodeBase> outputTargets;

		// Token: 0x04002F18 RID: 12056
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002F18")]
		[NonSerialized]
		private List<int> availableIndices;
	}
}
