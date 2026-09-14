using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B96 RID: 2966
	[Token(Token = "0x2000B96")]
	[Serializable]
	public class WaveEventNode : EventNodeBase
	{
		// Token: 0x06003DC8 RID: 15816 RVA: 0x00146644 File Offset: 0x00144844
		[Token(Token = "0x6003DC8")]
		[Address(RVA = "0x80AD50", Offset = "0x809350", VA = "0x18080AD50", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003DC9 RID: 15817 RVA: 0x00146654 File Offset: 0x00144854
		[Token(Token = "0x6003DC9")]
		[Address(RVA = "0x80AD90", Offset = "0x809390", VA = "0x18080AD90", Slot = "5")]
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

		// Token: 0x06003DCA RID: 15818 RVA: 0x001466AC File Offset: 0x001448AC
		[Token(Token = "0x6003DCA")]
		[Address(RVA = "0xA4F890", Offset = "0xA4DE90", VA = "0x180A4F890", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x001466E8 File Offset: 0x001448E8
		[Token(Token = "0x6003DCB")]
		[Address(RVA = "0x80ABF0", Offset = "0x8091F0", VA = "0x18080ABF0", Slot = "6")]
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

		// Token: 0x06003DCC RID: 15820 RVA: 0x00146754 File Offset: 0x00144954
		[Token(Token = "0x6003DCC")]
		[Address(RVA = "0x80AF00", Offset = "0x809500", VA = "0x18080AF00")]
		public WaveEventNode()
		{
		}

		// Token: 0x04002E81 RID: 11905
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E81")]
		public int waveValue;

		// Token: 0x04002E82 RID: 11906
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E82")]
		public string trigger_PortName = "触发";

		// Token: 0x04002E83 RID: 11907
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E83")]
		public string wave_PortName = "波次";
	}
}
