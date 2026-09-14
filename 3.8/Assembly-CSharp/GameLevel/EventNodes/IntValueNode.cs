using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BD0 RID: 3024
	[Token(Token = "0x2000BD0")]
	[Serializable]
	public class IntValueNode : EventNodeBase
	{
		// Token: 0x06003EF6 RID: 16118 RVA: 0x0014D6C8 File Offset: 0x0014B8C8
		[Token(Token = "0x6003EF6")]
		[Address(RVA = "0x7F8D80", Offset = "0x7F7380", VA = "0x1807F8D80", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x0014D6D8 File Offset: 0x0014B8D8
		[Token(Token = "0x6003EF7")]
		[Address(RVA = "0x7F8DC0", Offset = "0x7F73C0", VA = "0x1807F8DC0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.value_PortName, (PortType)((uint)1), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x0014D710 File Offset: 0x0014B910
		[Token(Token = "0x6003EF8")]
		[Address(RVA = "0x9C7940", Offset = "0x9C5F40", VA = "0x1809C7940", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003EF9 RID: 16121 RVA: 0x0014D74C File Offset: 0x0014B94C
		[Token(Token = "0x6003EF9")]
		[Address(RVA = "0x7F8EB0", Offset = "0x7F74B0", VA = "0x1807F8EB0", Slot = "10")]
		public override int ShowEditorUI(RuntimeNodeUI ui)
		{
			GameObject inputFieldPrefab = ui.inputFieldPrefab;
			RectTransform valueEditContainer = ui.valueEditContainer;
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(inputFieldPrefab, valueEditContainer);
			bool flag;
			if (flag)
			{
			}
			return 1;
		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x0014D780 File Offset: 0x0014B980
		[Token(Token = "0x6003EFA")]
		[Address(RVA = "0x7F90F0", Offset = "0x7F76F0", VA = "0x1807F90F0")]
		public IntValueNode()
		{
		}

		// Token: 0x04002FF9 RID: 12281
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FF9")]
		public int value = (int)((ulong)1L);

		// Token: 0x04002FFA RID: 12282
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FFA")]
		public string value_PortName = "值";
	}
}
