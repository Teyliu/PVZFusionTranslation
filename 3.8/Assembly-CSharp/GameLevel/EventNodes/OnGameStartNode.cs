using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B95 RID: 2965
	[Token(Token = "0x2000B95")]
	[Serializable]
	public class OnGameStartNode : EventNodeBase
	{
		// Token: 0x06003DC4 RID: 15812 RVA: 0x0014658C File Offset: 0x0014478C
		[Token(Token = "0x6003DC4")]
		[Address(RVA = "0x7FCC30", Offset = "0x7FB230", VA = "0x1807FCC30", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x0014659C File Offset: 0x0014479C
		[Token(Token = "0x6003DC5")]
		[Address(RVA = "0x7FCC70", Offset = "0x7FB270", VA = "0x1807FCC70", Slot = "5")]
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

		// Token: 0x06003DC6 RID: 15814 RVA: 0x001465D4 File Offset: 0x001447D4
		[Token(Token = "0x6003DC6")]
		[Address(RVA = "0x7FCB20", Offset = "0x7FB120", VA = "0x1807FCB20", Slot = "6")]
		public override void Execute()
		{
			Board instance = Board.Instance;
			int num = 0;
			if (!(instance == num))
			{
				EventNodeDebug.Log("[OnGameStartNode] 触发关卡开始事件");
				string text = this.trigger_PortName;
				base.TriggerConnectedNodes(text);
				return;
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[OnGameStartNode] Board.Instance 为 null，无法触发关卡开始事件，节点ID: " + nodeId);
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x00146624 File Offset: 0x00144824
		[Token(Token = "0x6003DC7")]
		[Address(RVA = "0x7FCD60", Offset = "0x7FB360", VA = "0x1807FCD60")]
		public OnGameStartNode()
		{
		}

		// Token: 0x04002E80 RID: 11904
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E80")]
		public string trigger_PortName = "触发";
	}
}
