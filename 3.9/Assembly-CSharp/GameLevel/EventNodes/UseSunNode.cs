using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BB4 RID: 2996
	[Token(Token = "0x2000BB4")]
	[Serializable]
	public class UseSunNode : EventNodeBase
	{
		// Token: 0x06003E60 RID: 15968 RVA: 0x00147500 File Offset: 0x00145700
		[Token(Token = "0x6003E60")]
		[Address(RVA = "0x8539B0", Offset = "0x851FB0", VA = "0x1808539B0", Slot = "4")]
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

		// Token: 0x06003E61 RID: 15969 RVA: 0x00147560 File Offset: 0x00145760
		[Token(Token = "0x6003E61")]
		[Address(RVA = "0x853B20", Offset = "0x852120", VA = "0x180853B20", Slot = "5")]
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

		// Token: 0x06003E62 RID: 15970 RVA: 0x001475BC File Offset: 0x001457BC
		[Token(Token = "0x6003E62")]
		[Address(RVA = "0x853C90", Offset = "0x852290", VA = "0x180853C90", Slot = "7")]
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

		// Token: 0x06003E63 RID: 15971 RVA: 0x00147660 File Offset: 0x00145860
		[Token(Token = "0x6003E63")]
		[Address(RVA = "0x8535B0", Offset = "0x851BB0", VA = "0x1808535B0", Slot = "6")]
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

		// Token: 0x06003E64 RID: 15972 RVA: 0x001476F8 File Offset: 0x001458F8
		[Token(Token = "0x6003E64")]
		[Address(RVA = "0x853DB0", Offset = "0x8523B0", VA = "0x180853DB0")]
		public UseSunNode()
		{
			List<EventNodeBase> list = new List();
			this.onSuccessTargets = list;
			List<EventNodeBase> list2 = new List();
			this.onFailedTargets = list2;
			base..ctor();
		}

		// Token: 0x04002F07 RID: 12039
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F07")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F08 RID: 12040
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F08")]
		public string sunAmount_PortName = "阳光数量";

		// Token: 0x04002F09 RID: 12041
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F09")]
		public string onSuccess_PortName = "消耗成功";

		// Token: 0x04002F0A RID: 12042
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F0A")]
		public string onFailed_PortName = "阳光不足";

		// Token: 0x04002F0B RID: 12043
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F0B")]
		[NonSerialized]
		private EventNodeBase sunAmountSourceNode;

		// Token: 0x04002F0C RID: 12044
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F0C")]
		[NonSerialized]
		private string sunAmountSourcePort;

		// Token: 0x04002F0D RID: 12045
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F0D")]
		[NonSerialized]
		private List<EventNodeBase> onSuccessTargets;

		// Token: 0x04002F0E RID: 12046
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002F0E")]
		[NonSerialized]
		private List<EventNodeBase> onFailedTargets;
	}
}
