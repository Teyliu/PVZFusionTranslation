using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B7A RID: 2938
	[Token(Token = "0x2000B7A")]
	[Serializable]
	public class UseMoneyNode : EventNodeBase
	{
		// Token: 0x06003D37 RID: 15671 RVA: 0x0014322C File Offset: 0x0014142C
		[Token(Token = "0x6003D37")]
		[Address(RVA = "0x7D6D00", Offset = "0x7D5300", VA = "0x1807D6D00", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.moneyAmount_PortName, (PortType)((uint)1), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003D38 RID: 15672 RVA: 0x0014328C File Offset: 0x0014148C
		[Token(Token = "0x6003D38")]
		[Address(RVA = "0x7D6E70", Offset = "0x7D5470", VA = "0x1807D6E70", Slot = "5")]
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

		// Token: 0x06003D39 RID: 15673 RVA: 0x001432E8 File Offset: 0x001414E8
		[Token(Token = "0x6003D39")]
		[Address(RVA = "0x7D6FE0", Offset = "0x7D55E0", VA = "0x1807D6FE0", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.moneyAmount_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.moneyAmountSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.moneyAmountSourcePort = sourcePortName;
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

		// Token: 0x06003D3A RID: 15674 RVA: 0x0014338C File Offset: 0x0014158C
		[Token(Token = "0x6003D3A")]
		[Address(RVA = "0x7D6910", Offset = "0x7D4F10", VA = "0x1807D6910", Slot = "6")]
		public override void Execute()
		{
			for (;;)
			{
				int num = 0;
				if (this.moneyAmountSourceNode != num)
				{
					num += 20;
					num += num;
				}
				uint num2;
				Board.Instance.UseMoney((int)num2);
				int theMoney = Board.Instance.theMoney;
				int num3;
				EventNodeDebug.Log(string.Format("[UseMoneyNode] 成功消耗 {0} 金币，剩余 {1}", num3, num3));
				List<EventNodeBase> list = this.onSuccessTargets;
				bool flag;
				if (flag)
				{
				}
				ulong num4;
				if (num4 == (ulong)0L)
				{
					int theMoney2 = Board.Instance.theMoney;
					int num5;
					string text = string.Format("[UseMoneyNode] 金币不足！需要 {0}，当前只有 {1}", num5, num5);
					EventNodeDebug.Log(text);
					bool flag2;
					if (flag2)
					{
					}
					ulong num6;
					if (num6 == (ulong)0L)
					{
						break;
					}
				}
			}
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x00143428 File Offset: 0x00141628
		[Token(Token = "0x6003D3B")]
		[Address(RVA = "0x7D7100", Offset = "0x7D5700", VA = "0x1807D7100")]
		public UseMoneyNode()
		{
			List<EventNodeBase> list = new List();
			this.onSuccessTargets = list;
			List<EventNodeBase> list2 = new List();
			this.onFailedTargets = list2;
			base..ctor();
		}

		// Token: 0x04002DCF RID: 11727
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002DCF")]
		public string trigger_PortName = "触发";

		// Token: 0x04002DD0 RID: 11728
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002DD0")]
		public string moneyAmount_PortName = "金币数量";

		// Token: 0x04002DD1 RID: 11729
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002DD1")]
		public string onSuccess_PortName = "消耗成功";

		// Token: 0x04002DD2 RID: 11730
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002DD2")]
		public string onFailed_PortName = "金币不足";

		// Token: 0x04002DD3 RID: 11731
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002DD3")]
		[NonSerialized]
		private EventNodeBase moneyAmountSourceNode;

		// Token: 0x04002DD4 RID: 11732
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002DD4")]
		[NonSerialized]
		private string moneyAmountSourcePort;

		// Token: 0x04002DD5 RID: 11733
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002DD5")]
		[NonSerialized]
		private List<EventNodeBase> onSuccessTargets;

		// Token: 0x04002DD6 RID: 11734
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002DD6")]
		[NonSerialized]
		private List<EventNodeBase> onFailedTargets;
	}
}
