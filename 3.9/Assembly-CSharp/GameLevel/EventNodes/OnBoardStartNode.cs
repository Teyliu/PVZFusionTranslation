using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BD6 RID: 3030
	[Token(Token = "0x2000BD6")]
	[Serializable]
	public class OnBoardStartNode : EventNodeBase
	{
		// Token: 0x06003F11 RID: 16145 RVA: 0x0014B744 File Offset: 0x00149944
		[Token(Token = "0x6003F11")]
		[Address(RVA = "0x864350", Offset = "0x862950", VA = "0x180864350", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003F12 RID: 16146 RVA: 0x0014B754 File Offset: 0x00149954
		[Token(Token = "0x6003F12")]
		[Address(RVA = "0x864390", Offset = "0x862990", VA = "0x180864390", Slot = "5")]
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

		// Token: 0x06003F13 RID: 16147 RVA: 0x0014B78C File Offset: 0x0014998C
		[Token(Token = "0x6003F13")]
		[Address(RVA = "0x864240", Offset = "0x862840", VA = "0x180864240", Slot = "6")]
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

		// Token: 0x06003F14 RID: 16148 RVA: 0x0014B7DC File Offset: 0x001499DC
		[Token(Token = "0x6003F14")]
		[Address(RVA = "0x864480", Offset = "0x862A80", VA = "0x180864480")]
		public OnBoardStartNode()
		{
		}

		// Token: 0x04002FF3 RID: 12275
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FF3")]
		public string trigger_PortName = "触发";
	}
}
