using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BAD RID: 2989
	[Token(Token = "0x2000BAD")]
	[Serializable]
	public class ForLoopNode : EventNodeBase
	{
		// Token: 0x06003E3A RID: 15930 RVA: 0x00148640 File Offset: 0x00146840
		[Token(Token = "0x6003E3A")]
		[Address(RVA = "0x7F52C0", Offset = "0x7F38C0", VA = "0x1807F52C0", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.count_PortName, (PortType)((uint)1), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003E3B RID: 15931 RVA: 0x001486A0 File Offset: 0x001468A0
		[Token(Token = "0x6003E3B")]
		[Address(RVA = "0x7F5430", Offset = "0x7F3A30", VA = "0x1807F5430", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.output_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.index_PortName, (PortType)((uint)1), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x001486F8 File Offset: 0x001468F8
		[Token(Token = "0x6003E3C")]
		[Address(RVA = "0x7F55A0", Offset = "0x7F3BA0", VA = "0x1807F55A0", Slot = "7")]
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
			string text2 = this.output_PortName;
			string nodeId2 = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId2, text2);
			this.outputTargets = connectedNodes;
			throw new NullReferenceException();
		}

		// Token: 0x06003E3D RID: 15933 RVA: 0x00148778 File Offset: 0x00146978
		[Token(Token = "0x6003E3D")]
		[Address(RVA = "0x7F4FC0", Offset = "0x7F35C0", VA = "0x1807F4FC0", Slot = "6")]
		public override void Execute()
		{
			int num3;
			ulong num6;
			do
			{
				int num = 0;
				if (this.countSourceNode != num)
				{
					num += 20;
					num += num;
				}
				int num2;
				EventNodeDebug.Log(string.Format("[ForLoopNode] 开始循环，次数: {0}", num2));
				num3 = 0;
				uint num4;
				if (num3 >= (int)num4)
				{
					goto IL_0061;
				}
				this.currentIndex = num3;
				int num5;
				EventNodeDebug.Log(string.Format("[ForLoopNode] 循环第 {0} 次", num5));
				List<EventNodeBase> list = this.outputTargets;
				bool flag;
				if (flag)
				{
				}
			}
			while (num6 != (ulong)0L);
			num3++;
			IL_0061:
			int num7;
			EventNodeDebug.Log(string.Format("[ForLoopNode] 循环结束，共执行 {0} 次", num7));
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x00148800 File Offset: 0x00146A00
		[Token(Token = "0x6003E3E")]
		[Address(RVA = "0x9AAC00", Offset = "0x9A9200", VA = "0x1809AAC00", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x0014883C File Offset: 0x00146A3C
		[Token(Token = "0x6003E3F")]
		[Address(RVA = "0x7F56A0", Offset = "0x7F3CA0", VA = "0x1807F56A0")]
		public ForLoopNode()
		{
			List<EventNodeBase> list = new List();
			this.outputTargets = list;
			base..ctor();
		}

		// Token: 0x04002EDF RID: 11999
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002EDF")]
		public string trigger_PortName = "触发";

		// Token: 0x04002EE0 RID: 12000
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002EE0")]
		public string count_PortName = "循环次数";

		// Token: 0x04002EE1 RID: 12001
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002EE1")]
		public string output_PortName = "循环体";

		// Token: 0x04002EE2 RID: 12002
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002EE2")]
		public string index_PortName = "当前索引";

		// Token: 0x04002EE3 RID: 12003
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002EE3")]
		[NonSerialized]
		private EventNodeBase countSourceNode;

		// Token: 0x04002EE4 RID: 12004
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002EE4")]
		[NonSerialized]
		private string countSourcePort;

		// Token: 0x04002EE5 RID: 12005
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002EE5")]
		[NonSerialized]
		private List<EventNodeBase> outputTargets;

		// Token: 0x04002EE6 RID: 12006
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002EE6")]
		private int currentIndex;
	}
}
