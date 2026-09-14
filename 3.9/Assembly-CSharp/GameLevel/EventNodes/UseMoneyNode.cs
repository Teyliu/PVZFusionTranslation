using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BBC RID: 3004
	[Token(Token = "0x2000BBC")]
	[Serializable]
	public class UseMoneyNode : EventNodeBase
	{
		// Token: 0x06003E88 RID: 16008 RVA: 0x001484C0 File Offset: 0x001466C0
		[Token(Token = "0x6003E88")]
		[Address(RVA = "0x853060", Offset = "0x851660", VA = "0x180853060", Slot = "4")]
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

		// Token: 0x06003E89 RID: 16009 RVA: 0x00148520 File Offset: 0x00146720
		[Token(Token = "0x6003E89")]
		[Address(RVA = "0x8531D0", Offset = "0x8517D0", VA = "0x1808531D0", Slot = "5")]
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

		// Token: 0x06003E8A RID: 16010 RVA: 0x0014857C File Offset: 0x0014677C
		[Token(Token = "0x6003E8A")]
		[Address(RVA = "0x853340", Offset = "0x851940", VA = "0x180853340", Slot = "7")]
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

		// Token: 0x06003E8B RID: 16011 RVA: 0x00148620 File Offset: 0x00146820
		[Token(Token = "0x6003E8B")]
		[Address(RVA = "0x852C70", Offset = "0x851270", VA = "0x180852C70", Slot = "6")]
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

		// Token: 0x06003E8C RID: 16012 RVA: 0x001486BC File Offset: 0x001468BC
		[Token(Token = "0x6003E8C")]
		[Address(RVA = "0x853460", Offset = "0x851A60", VA = "0x180853460")]
		public UseMoneyNode()
		{
			List<EventNodeBase> list = new List();
			this.onSuccessTargets = list;
			List<EventNodeBase> list2 = new List();
			this.onFailedTargets = list2;
			base..ctor();
		}

		// Token: 0x04002F43 RID: 12099
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F43")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F44 RID: 12100
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F44")]
		public string moneyAmount_PortName = "金币数量";

		// Token: 0x04002F45 RID: 12101
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F45")]
		public string onSuccess_PortName = "消耗成功";

		// Token: 0x04002F46 RID: 12102
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F46")]
		public string onFailed_PortName = "金币不足";

		// Token: 0x04002F47 RID: 12103
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F47")]
		[NonSerialized]
		private EventNodeBase moneyAmountSourceNode;

		// Token: 0x04002F48 RID: 12104
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F48")]
		[NonSerialized]
		private string moneyAmountSourcePort;

		// Token: 0x04002F49 RID: 12105
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F49")]
		[NonSerialized]
		private List<EventNodeBase> onSuccessTargets;

		// Token: 0x04002F4A RID: 12106
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002F4A")]
		[NonSerialized]
		private List<EventNodeBase> onFailedTargets;
	}
}
