using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BA6 RID: 2982
	[Token(Token = "0x2000BA6")]
	[Serializable]
	public class BoolVariableNode : VariableNode
	{
		// Token: 0x06003E15 RID: 15893 RVA: 0x001478C8 File Offset: 0x00145AC8
		[Token(Token = "0x6003E15")]
		[Address(RVA = "0x7EF320", Offset = "0x7ED920", VA = "0x1807EF320", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.variable_PortName, (PortType)((uint)7), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003E16 RID: 15894 RVA: 0x00147900 File Offset: 0x00145B00
		[Token(Token = "0x6003E16")]
		[Address(RVA = "0x932810", Offset = "0x930E10", VA = "0x180932810", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06003E17 RID: 15895 RVA: 0x00147930 File Offset: 0x00145B30
		// (set) Token: 0x06003E18 RID: 15896 RVA: 0x00147990 File Offset: 0x00145B90
		[Token(Token = "0x170004AA")]
		public bool Value
		{
			[Token(Token = "0x6003E17")]
			[Address(RVA = "0x7EF460", Offset = "0x7EDA60", VA = "0x1807EF460")]
			get
			{
				string nodeId = this.nodeId;
				EventNodeDebug.LogWarning("[BoolVariableNode] 变量Asset未设置，返回false，节点ID: " + nodeId);
				string name = this.asset.GetType().Name;
				string nodeId2 = this.nodeId;
				EventNodeDebug.LogError("[BoolVariableNode] Asset类型错误：期望BoolVariableAsset，实际是" + name + "，返回false，节点ID: " + nodeId2);
				throw new NullReferenceException();
			}
			[Token(Token = "0x6003E18")]
			[Address(RVA = "0x7EF5C0", Offset = "0x7EDBC0", VA = "0x1807EF5C0")]
			set
			{
				VariableAsset asset = this.asset;
			}
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x001479BC File Offset: 0x00145BBC
		[Token(Token = "0x6003E19")]
		[Address(RVA = "0x7EF410", Offset = "0x7EDA10", VA = "0x1807EF410")]
		public BoolVariableNode()
		{
		}

		// Token: 0x04002EB6 RID: 11958
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002EB6")]
		public string variable_PortName = "变量";
	}
}
