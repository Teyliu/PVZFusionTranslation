using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BD7 RID: 3031
	[Token(Token = "0x2000BD7")]
	[Serializable]
	public class OnGameStartNode : EventNodeBase
	{
		// Token: 0x06003F15 RID: 16149 RVA: 0x0014B7FC File Offset: 0x001499FC
		[Token(Token = "0x6003F15")]
		[Address(RVA = "0x8645E0", Offset = "0x862BE0", VA = "0x1808645E0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003F16 RID: 16150 RVA: 0x0014B80C File Offset: 0x00149A0C
		[Token(Token = "0x6003F16")]
		[Address(RVA = "0x864620", Offset = "0x862C20", VA = "0x180864620", Slot = "5")]
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

		// Token: 0x06003F17 RID: 16151 RVA: 0x0014B844 File Offset: 0x00149A44
		[Token(Token = "0x6003F17")]
		[Address(RVA = "0x8644D0", Offset = "0x862AD0", VA = "0x1808644D0", Slot = "6")]
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

		// Token: 0x06003F18 RID: 16152 RVA: 0x0014B894 File Offset: 0x00149A94
		[Token(Token = "0x6003F18")]
		[Address(RVA = "0x864710", Offset = "0x862D10", VA = "0x180864710")]
		public OnGameStartNode()
		{
		}

		// Token: 0x04002FF4 RID: 12276
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FF4")]
		public string trigger_PortName = "触发";
	}
}
