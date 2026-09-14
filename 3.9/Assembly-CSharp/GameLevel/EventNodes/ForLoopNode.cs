using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BEF RID: 3055
	[Token(Token = "0x2000BEF")]
	[Serializable]
	public class ForLoopNode : EventNodeBase
	{
		// Token: 0x06003F8B RID: 16267 RVA: 0x0014D8B0 File Offset: 0x0014BAB0
		[Token(Token = "0x6003F8B")]
		[Address(RVA = "0x85CE70", Offset = "0x85B470", VA = "0x18085CE70", Slot = "4")]
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

		// Token: 0x06003F8C RID: 16268 RVA: 0x0014D910 File Offset: 0x0014BB10
		[Token(Token = "0x6003F8C")]
		[Address(RVA = "0x85CFE0", Offset = "0x85B5E0", VA = "0x18085CFE0", Slot = "5")]
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

		// Token: 0x06003F8D RID: 16269 RVA: 0x0014D968 File Offset: 0x0014BB68
		[Token(Token = "0x6003F8D")]
		[Address(RVA = "0x85D150", Offset = "0x85B750", VA = "0x18085D150", Slot = "7")]
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

		// Token: 0x06003F8E RID: 16270 RVA: 0x0014D9E8 File Offset: 0x0014BBE8
		[Token(Token = "0x6003F8E")]
		[Address(RVA = "0x85CB70", Offset = "0x85B170", VA = "0x18085CB70", Slot = "6")]
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

		// Token: 0x06003F8F RID: 16271 RVA: 0x0014DA70 File Offset: 0x0014BC70
		[Token(Token = "0x6003F8F")]
		[Address(RVA = "0xA541C0", Offset = "0xA527C0", VA = "0x180A541C0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003F90 RID: 16272 RVA: 0x0014DAAC File Offset: 0x0014BCAC
		[Token(Token = "0x6003F90")]
		[Address(RVA = "0x85D250", Offset = "0x85B850", VA = "0x18085D250")]
		public ForLoopNode()
		{
			List<EventNodeBase> list = new List();
			this.outputTargets = list;
			base..ctor();
		}

		// Token: 0x04003053 RID: 12371
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003053")]
		public string trigger_PortName = "触发";

		// Token: 0x04003054 RID: 12372
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003054")]
		public string count_PortName = "循环次数";

		// Token: 0x04003055 RID: 12373
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003055")]
		public string output_PortName = "循环体";

		// Token: 0x04003056 RID: 12374
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003056")]
		public string index_PortName = "当前索引";

		// Token: 0x04003057 RID: 12375
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003057")]
		[NonSerialized]
		private EventNodeBase countSourceNode;

		// Token: 0x04003058 RID: 12376
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003058")]
		[NonSerialized]
		private string countSourcePort;

		// Token: 0x04003059 RID: 12377
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003059")]
		[NonSerialized]
		private List<EventNodeBase> outputTargets;

		// Token: 0x0400305A RID: 12378
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400305A")]
		private int currentIndex;
	}
}
