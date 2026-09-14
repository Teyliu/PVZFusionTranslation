using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BCA RID: 3018
	[Token(Token = "0x2000BCA")]
	[Serializable]
	public class GetSunAmountNode : EventNodeBase
	{
		// Token: 0x06003ED3 RID: 16083 RVA: 0x0014C5FC File Offset: 0x0014A7FC
		[Token(Token = "0x6003ED3")]
		[Address(RVA = "0x7F6A10", Offset = "0x7F5010", VA = "0x1807F6A10", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x0014C60C File Offset: 0x0014A80C
		[Token(Token = "0x6003ED4")]
		[Address(RVA = "0x7F6A50", Offset = "0x7F5050", VA = "0x1807F6A50", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.sunAmount_PortName, (PortType)((uint)1), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x0014C644 File Offset: 0x0014A844
		[Token(Token = "0x6003ED5")]
		[Address(RVA = "0x9B3D40", Offset = "0x9B2340", VA = "0x1809B3D40", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x0014C6A0 File Offset: 0x0014A8A0
		[Token(Token = "0x6003ED6")]
		[Address(RVA = "0x7F6B40", Offset = "0x7F5140", VA = "0x1807F6B40")]
		public GetSunAmountNode()
		{
		}

		// Token: 0x04002FBB RID: 12219
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FBB")]
		public string sunAmount_PortName = "阳光数量";
	}
}
