using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BD8 RID: 3032
	[Token(Token = "0x2000BD8")]
	[Serializable]
	public class WaveEventNode : EventNodeBase
	{
		// Token: 0x06003F19 RID: 16153 RVA: 0x0014B8B4 File Offset: 0x00149AB4
		[Token(Token = "0x6003F19")]
		[Address(RVA = "0x872740", Offset = "0x870D40", VA = "0x180872740", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003F1A RID: 16154 RVA: 0x0014B8C4 File Offset: 0x00149AC4
		[Token(Token = "0x6003F1A")]
		[Address(RVA = "0x872780", Offset = "0x870D80", VA = "0x180872780", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.trigger_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.wave_PortName, (PortType)((uint)1), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x0014B91C File Offset: 0x00149B1C
		[Token(Token = "0x6003F1B")]
		[Address(RVA = "0xB23AC0", Offset = "0xB220C0", VA = "0x180B23AC0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003F1C RID: 16156 RVA: 0x0014B958 File Offset: 0x00149B58
		[Token(Token = "0x6003F1C")]
		[Address(RVA = "0x8725E0", Offset = "0x870BE0", VA = "0x1808725E0", Slot = "6")]
		public override void Execute()
		{
			Board instance = Board.Instance;
			int num = 0;
			if (!(instance == num))
			{
				int theWave = instance.theWave;
				this.waveValue = theWave;
				EventNodeDebug.Log(string.Format("[WaveEventNode] 触发波次事件，当前波次: {0}", theWave));
				string text = this.trigger_PortName;
				base.TriggerConnectedNodes(text);
				return;
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[WaveEventNode] Board.Instance 为 null，无法触发波次事件，节点ID: " + nodeId);
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x0014B9C4 File Offset: 0x00149BC4
		[Token(Token = "0x6003F1D")]
		[Address(RVA = "0x8728F0", Offset = "0x870EF0", VA = "0x1808728F0")]
		public WaveEventNode()
		{
		}

		// Token: 0x04002FF5 RID: 12277
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FF5")]
		public int waveValue;

		// Token: 0x04002FF6 RID: 12278
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FF6")]
		public string trigger_PortName = "触发";

		// Token: 0x04002FF7 RID: 12279
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002FF7")]
		public string wave_PortName = "波次";
	}
}
