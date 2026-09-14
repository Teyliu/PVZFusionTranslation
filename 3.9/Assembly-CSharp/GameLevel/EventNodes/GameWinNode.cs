using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BC1 RID: 3009
	[Token(Token = "0x2000BC1")]
	[Serializable]
	public class GameWinNode : EventNodeBase
	{
		// Token: 0x06003E9F RID: 16031 RVA: 0x00148C14 File Offset: 0x00146E14
		[Token(Token = "0x6003E9F")]
		[Address(RVA = "0x844710", Offset = "0x842D10", VA = "0x180844710", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			int num2;
			PortDefinition portDefinition = new PortDefinition(this.trigger_PortName, (PortType)num, (PortDirection)num2);
			num2 = 0;
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003EA0 RID: 16032 RVA: 0x00148C50 File Offset: 0x00146E50
		[Token(Token = "0x6003EA0")]
		[Address(RVA = "0x8447F0", Offset = "0x842DF0", VA = "0x1808447F0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003EA1 RID: 16033 RVA: 0x00148C60 File Offset: 0x00146E60
		[Token(Token = "0x6003EA1")]
		[Address(RVA = "0x844680", Offset = "0x842C80", VA = "0x180844680", Slot = "6")]
		public override void Execute()
		{
			EventNodeDebug.Log("[GameWinNode] 游戏胜利");
			Board.Instance.boardVicotry.Win();
		}

		// Token: 0x06003EA2 RID: 16034 RVA: 0x00148C8C File Offset: 0x00146E8C
		[Token(Token = "0x6003EA2")]
		[Address(RVA = "0x844830", Offset = "0x842E30", VA = "0x180844830")]
		public GameWinNode()
		{
		}

		// Token: 0x04002F5C RID: 12124
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F5C")]
		public string trigger_PortName = "触发";
	}
}
