using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BE8 RID: 3048
	[Token(Token = "0x2000BE8")]
	[Serializable]
	public class BoolVariableNode : VariableNode
	{
		// Token: 0x06003F66 RID: 16230 RVA: 0x0014CB38 File Offset: 0x0014AD38
		[Token(Token = "0x6003F66")]
		[Address(RVA = "0x856DF0", Offset = "0x8553F0", VA = "0x180856DF0", Slot = "5")]
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

		// Token: 0x06003F67 RID: 16231 RVA: 0x0014CB70 File Offset: 0x0014AD70
		[Token(Token = "0x6003F67")]
		[Address(RVA = "0x9EE1C0", Offset = "0x9EC7C0", VA = "0x1809EE1C0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06003F68 RID: 16232 RVA: 0x0014CBA0 File Offset: 0x0014ADA0
		// (set) Token: 0x06003F69 RID: 16233 RVA: 0x0014CC00 File Offset: 0x0014AE00
		[Token(Token = "0x170004FA")]
		public bool Value
		{
			[Token(Token = "0x6003F68")]
			[Address(RVA = "0x856F30", Offset = "0x855530", VA = "0x180856F30")]
			get
			{
				string nodeId = this.nodeId;
				EventNodeDebug.LogWarning("[BoolVariableNode] 变量Asset未设置，返回false，节点ID: " + nodeId);
				string name = this.asset.GetType().Name;
				string nodeId2 = this.nodeId;
				EventNodeDebug.LogError("[BoolVariableNode] Asset类型错误：期望BoolVariableAsset，实际是" + name + "，返回false，节点ID: " + nodeId2);
				throw new NullReferenceException();
			}
			[Token(Token = "0x6003F69")]
			[Address(RVA = "0x857090", Offset = "0x855690", VA = "0x180857090")]
			set
			{
				VariableAsset asset = this.asset;
			}
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x0014CC2C File Offset: 0x0014AE2C
		[Token(Token = "0x6003F6A")]
		[Address(RVA = "0x856EE0", Offset = "0x8554E0", VA = "0x180856EE0")]
		public BoolVariableNode()
		{
		}

		// Token: 0x0400302A RID: 12330
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400302A")]
		public string variable_PortName = "变量";
	}
}
