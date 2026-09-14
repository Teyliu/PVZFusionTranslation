using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B94 RID: 2964
	[Token(Token = "0x2000B94")]
	[Serializable]
	public class OnBoardStartNode : EventNodeBase
	{
		// Token: 0x06003DC0 RID: 15808 RVA: 0x001464D4 File Offset: 0x001446D4
		[Token(Token = "0x6003DC0")]
		[Address(RVA = "0x7FC9A0", Offset = "0x7FAFA0", VA = "0x1807FC9A0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003DC1 RID: 15809 RVA: 0x001464E4 File Offset: 0x001446E4
		[Token(Token = "0x6003DC1")]
		[Address(RVA = "0x7FC9E0", Offset = "0x7FAFE0", VA = "0x1807FC9E0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.trigger_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x0014651C File Offset: 0x0014471C
		[Token(Token = "0x6003DC2")]
		[Address(RVA = "0x7FC890", Offset = "0x7FAE90", VA = "0x1807FC890", Slot = "6")]
		public override void Execute()
		{
			Board instance = Board.Instance;
			int num = 0;
			if (!(instance == num))
			{
				EventNodeDebug.Log("[OnBoardStartNode] 触发关卡开始事件");
				string text = this.trigger_PortName;
				base.TriggerConnectedNodes(text);
				return;
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[OnBoardStartNode] Board.Instance 为 null，无法触发关卡开始事件，节点ID: " + nodeId);
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x0014656C File Offset: 0x0014476C
		[Token(Token = "0x6003DC3")]
		[Address(RVA = "0x7FCAD0", Offset = "0x7FB0D0", VA = "0x1807FCAD0")]
		public OnBoardStartNode()
		{
		}

		// Token: 0x04002E7F RID: 11903
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E7F")]
		public string trigger_PortName = "触发";
	}
}
