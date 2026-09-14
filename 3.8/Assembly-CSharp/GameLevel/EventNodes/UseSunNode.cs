using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B72 RID: 2930
	[Token(Token = "0x2000B72")]
	[Serializable]
	public class UseSunNode : EventNodeBase
	{
		// Token: 0x06003D0F RID: 15631 RVA: 0x0014226C File Offset: 0x0014046C
		[Token(Token = "0x6003D0F")]
		[Address(RVA = "0x7D7650", Offset = "0x7D5C50", VA = "0x1807D7650", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.sunAmount_PortName, (PortType)((uint)1), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003D10 RID: 15632 RVA: 0x001422CC File Offset: 0x001404CC
		[Token(Token = "0x6003D10")]
		[Address(RVA = "0x7D77C0", Offset = "0x7D5DC0", VA = "0x1807D77C0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.onSuccess_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.onFailed_PortName, (PortType)num2, (PortDirection)((uint)1));
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003D11 RID: 15633 RVA: 0x00142328 File Offset: 0x00140528
		[Token(Token = "0x6003D11")]
		[Address(RVA = "0x7D7930", Offset = "0x7D5F30", VA = "0x1807D7930", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.sunAmount_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.sunAmountSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.sunAmountSourcePort = sourcePortName;
			string text2 = this.onSuccess_PortName;
			string nodeId2 = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId2, text2);
			this.onSuccessTargets = connectedNodes;
			string text3 = this.onFailed_PortName;
			string nodeId3 = this.nodeId;
			List<EventNodeBase> connectedNodes2 = graph.GetConnectedNodes(nodeId3, text3);
			this.onFailedTargets = connectedNodes2;
			throw new NullReferenceException();
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x001423CC File Offset: 0x001405CC
		[Token(Token = "0x6003D12")]
		[Address(RVA = "0x7D7250", Offset = "0x7D5850", VA = "0x1807D7250", Slot = "6")]
		public override void Execute()
		{
			for (;;)
			{
				int num = 0;
				if (this.sunAmountSourceNode != num)
				{
					num += 20;
					num += num;
				}
				Board instance = Board.Instance;
				int theSun = Board.Instance.theSun;
				int num2;
				EventNodeDebug.Log(string.Format("[UseSunNode] 成功消耗 {0} 阳光，剩余 {1}", num2, num2));
				List<EventNodeBase> list = this.onSuccessTargets;
				bool flag;
				if (flag)
				{
				}
				ulong num3;
				if (num3 == (ulong)0L)
				{
					int theSun2 = Board.Instance.theSun;
					int num4;
					string text = string.Format("[UseSunNode] 阳光不足！需要 {0}，当前只有 {1}", num4, num4);
					EventNodeDebug.Log(text);
					bool flag2;
					if (flag2)
					{
					}
					ulong num5;
					if (num5 == (ulong)0L)
					{
						break;
					}
				}
			}
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x00142464 File Offset: 0x00140664
		[Token(Token = "0x6003D13")]
		[Address(RVA = "0x7D7A50", Offset = "0x7D6050", VA = "0x1807D7A50")]
		public UseSunNode()
		{
			List<EventNodeBase> list = new List();
			this.onSuccessTargets = list;
			List<EventNodeBase> list2 = new List();
			this.onFailedTargets = list2;
			base..ctor();
		}

		// Token: 0x04002D93 RID: 11667
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002D93")]
		public string trigger_PortName = "触发";

		// Token: 0x04002D94 RID: 11668
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002D94")]
		public string sunAmount_PortName = "阳光数量";

		// Token: 0x04002D95 RID: 11669
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002D95")]
		public string onSuccess_PortName = "消耗成功";

		// Token: 0x04002D96 RID: 11670
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002D96")]
		public string onFailed_PortName = "阳光不足";

		// Token: 0x04002D97 RID: 11671
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002D97")]
		[NonSerialized]
		private EventNodeBase sunAmountSourceNode;

		// Token: 0x04002D98 RID: 11672
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002D98")]
		[NonSerialized]
		private string sunAmountSourcePort;

		// Token: 0x04002D99 RID: 11673
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002D99")]
		[NonSerialized]
		private List<EventNodeBase> onSuccessTargets;

		// Token: 0x04002D9A RID: 11674
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002D9A")]
		[NonSerialized]
		private List<EventNodeBase> onFailedTargets;
	}
}
