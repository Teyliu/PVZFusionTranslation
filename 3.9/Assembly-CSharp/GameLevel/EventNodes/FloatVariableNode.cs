using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BE7 RID: 3047
	[Token(Token = "0x2000BE7")]
	[Serializable]
	public class FloatVariableNode : VariableNode
	{
		// Token: 0x06003F61 RID: 16225 RVA: 0x0014CA04 File Offset: 0x0014AC04
		[Token(Token = "0x6003F61")]
		[Address(RVA = "0x85C7B0", Offset = "0x85ADB0", VA = "0x18085C7B0", Slot = "5")]
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

		// Token: 0x06003F62 RID: 16226 RVA: 0x0014CA3C File Offset: 0x0014AC3C
		[Token(Token = "0x6003F62")]
		[Address(RVA = "0x9EE1C0", Offset = "0x9EC7C0", VA = "0x1809EE1C0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06003F63 RID: 16227 RVA: 0x0014CA6C File Offset: 0x0014AC6C
		// (set) Token: 0x06003F64 RID: 16228 RVA: 0x0014CAD8 File Offset: 0x0014ACD8
		[Token(Token = "0x170004F9")]
		public float Value
		{
			[Token(Token = "0x6003F63")]
			[Address(RVA = "0x85C8F0", Offset = "0x85AEF0", VA = "0x18085C8F0")]
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
			[Token(Token = "0x6003F64")]
			[Address(RVA = "0x85CA50", Offset = "0x85B050", VA = "0x18085CA50")]
			set
			{
				VariableAsset asset = this.asset;
			}
		}

		// Token: 0x06003F65 RID: 16229 RVA: 0x0014CB18 File Offset: 0x0014AD18
		[Token(Token = "0x6003F65")]
		[Address(RVA = "0x85C8A0", Offset = "0x85AEA0", VA = "0x18085C8A0")]
		public FloatVariableNode()
		{
		}

		// Token: 0x04003029 RID: 12329
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003029")]
		public string variable_PortName = "变量";
	}
}
