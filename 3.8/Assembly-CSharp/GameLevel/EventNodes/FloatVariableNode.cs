using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BA5 RID: 2981
	[Token(Token = "0x2000BA5")]
	[Serializable]
	public class FloatVariableNode : VariableNode
	{
		// Token: 0x06003E10 RID: 15888 RVA: 0x00147794 File Offset: 0x00145994
		[Token(Token = "0x6003E10")]
		[Address(RVA = "0x7F4C00", Offset = "0x7F3200", VA = "0x1807F4C00", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.variable_PortName, (PortType)((uint)4), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003E11 RID: 15889 RVA: 0x001477CC File Offset: 0x001459CC
		[Token(Token = "0x6003E11")]
		[Address(RVA = "0x932810", Offset = "0x930E10", VA = "0x180932810", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06003E12 RID: 15890 RVA: 0x001477FC File Offset: 0x001459FC
		// (set) Token: 0x06003E13 RID: 15891 RVA: 0x00147868 File Offset: 0x00145A68
		[Token(Token = "0x170004A9")]
		public float Value
		{
			[Token(Token = "0x6003E12")]
			[Address(RVA = "0x7F4D40", Offset = "0x7F3340", VA = "0x1807F4D40")]
			get
			{
				string nodeId = this.nodeId;
				EventNodeDebug.LogWarning("[FloatVariableNode] 变量Asset未设置，返回0，节点ID: " + nodeId);
				VariableAsset asset = this.asset;
				string name = this.asset.GetType().Name;
				string nodeId2 = this.nodeId;
				EventNodeDebug.LogError("[FloatVariableNode] Asset类型错误：期望FloatVariableAsset，实际是" + name + "，返回0，节点ID: " + nodeId2);
				throw new NullReferenceException();
			}
			[Token(Token = "0x6003E13")]
			[Address(RVA = "0x7F4EA0", Offset = "0x7F34A0", VA = "0x1807F4EA0")]
			set
			{
				VariableAsset asset = this.asset;
			}
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x001478A8 File Offset: 0x00145AA8
		[Token(Token = "0x6003E14")]
		[Address(RVA = "0x7F4CF0", Offset = "0x7F32F0", VA = "0x1807F4CF0")]
		public FloatVariableNode()
		{
		}

		// Token: 0x04002EB5 RID: 11957
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002EB5")]
		public string variable_PortName = "变量";
	}
}
