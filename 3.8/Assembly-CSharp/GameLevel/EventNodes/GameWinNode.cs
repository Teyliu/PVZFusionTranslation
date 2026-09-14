using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B7F RID: 2943
	[Token(Token = "0x2000B7F")]
	[Serializable]
	public class GameWinNode : EventNodeBase
	{
		// Token: 0x06003D4E RID: 15694 RVA: 0x00143974 File Offset: 0x00141B74
		[Token(Token = "0x6003D4E")]
		[Address(RVA = "0x7C83B0", Offset = "0x7C69B0", VA = "0x1807C83B0", Slot = "4")]
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

		// Token: 0x06003D4F RID: 15695 RVA: 0x001439B0 File Offset: 0x00141BB0
		[Token(Token = "0x6003D4F")]
		[Address(RVA = "0x7C8490", Offset = "0x7C6A90", VA = "0x1807C8490", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003D50 RID: 15696 RVA: 0x001439C0 File Offset: 0x00141BC0
		[Token(Token = "0x6003D50")]
		[Address(RVA = "0x7C8320", Offset = "0x7C6920", VA = "0x1807C8320", Slot = "6")]
		public override void Execute()
		{
			EventNodeDebug.Log("[GameWinNode] 游戏胜利");
			Board.Instance.boardVicotry.Win();
		}

		// Token: 0x06003D51 RID: 15697 RVA: 0x001439EC File Offset: 0x00141BEC
		[Token(Token = "0x6003D51")]
		[Address(RVA = "0x7C84D0", Offset = "0x7C6AD0", VA = "0x1807C84D0")]
		public GameWinNode()
		{
		}

		// Token: 0x04002DE8 RID: 11752
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002DE8")]
		public string trigger_PortName = "触发";
	}
}
