using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BE4 RID: 3044
	[Token(Token = "0x2000BE4")]
	[Serializable]
	public class IntVariableNode : VariableNode
	{
		// Token: 0x06003F51 RID: 16209 RVA: 0x0014C4B0 File Offset: 0x0014A6B0
		[Token(Token = "0x6003F51")]
		[Address(RVA = "0x860D20", Offset = "0x85F320", VA = "0x180860D20", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.variable_PortName, (PortType)((uint)2), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003F52 RID: 16210 RVA: 0x0014C4E8 File Offset: 0x0014A6E8
		[Token(Token = "0x6003F52")]
		[Address(RVA = "0x9EE1C0", Offset = "0x9EC7C0", VA = "0x1809EE1C0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06003F53 RID: 16211 RVA: 0x0014C518 File Offset: 0x0014A718
		// (set) Token: 0x06003F54 RID: 16212 RVA: 0x0014C578 File Offset: 0x0014A778
		[Token(Token = "0x170004F8")]
		public int Value
		{
			[Token(Token = "0x6003F53")]
			[Address(RVA = "0x860E60", Offset = "0x85F460", VA = "0x180860E60")]
			get
			{
				string nodeId = this.nodeId;
				EventNodeDebug.LogWarning("[IntVariableNode] 变量Asset未设置，返回0，节点ID: " + nodeId);
				return 0;
			}
			[Token(Token = "0x6003F54")]
			[Address(RVA = "0x860FC0", Offset = "0x85F5C0", VA = "0x180860FC0")]
			set
			{
				VariableAsset asset = this.asset;
			}
		}

		// Token: 0x06003F55 RID: 16213 RVA: 0x0014C5A4 File Offset: 0x0014A7A4
		[Token(Token = "0x6003F55")]
		[Address(RVA = "0x860E10", Offset = "0x85F410", VA = "0x180860E10")]
		public IntVariableNode()
		{
		}

		// Token: 0x0400301B RID: 12315
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400301B")]
		public string variable_PortName = "变量";
	}
}
