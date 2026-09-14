using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C0C RID: 3084
	[Token(Token = "0x2000C0C")]
	[Serializable]
	public class GetSunAmountNode : EventNodeBase
	{
		// Token: 0x06004024 RID: 16420 RVA: 0x00151868 File Offset: 0x0014FA68
		[Token(Token = "0x6004024")]
		[Address(RVA = "0x85E5C0", Offset = "0x85CBC0", VA = "0x18085E5C0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06004025 RID: 16421 RVA: 0x00151878 File Offset: 0x0014FA78
		[Token(Token = "0x6004025")]
		[Address(RVA = "0x85E600", Offset = "0x85CC00", VA = "0x18085E600", Slot = "5")]
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

		// Token: 0x06004026 RID: 16422 RVA: 0x001518B0 File Offset: 0x0014FAB0
		[Token(Token = "0x6004026")]
		[Address(RVA = "0xA5D6A0", Offset = "0xA5BCA0", VA = "0x180A5D6A0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06004027 RID: 16423 RVA: 0x0015190C File Offset: 0x0014FB0C
		[Token(Token = "0x6004027")]
		[Address(RVA = "0x85E6F0", Offset = "0x85CCF0", VA = "0x18085E6F0")]
		public GetSunAmountNode()
		{
		}

		// Token: 0x0400312F RID: 12591
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400312F")]
		public string sunAmount_PortName = "阳光数量";
	}
}
