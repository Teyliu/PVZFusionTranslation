using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BBE RID: 3006
	[Token(Token = "0x2000BBE")]
	[Serializable]
	public class GetNearestZombieNode : EventNodeBase
	{
		// Token: 0x06003E92 RID: 16018 RVA: 0x00148868 File Offset: 0x00146A68
		[Token(Token = "0x6003E92")]
		[Address(RVA = "0x844CA0", Offset = "0x8432A0", VA = "0x180844CA0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.row_PortName, (PortType)((uint)1), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.column_PortName, (PortType)((uint)1), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003E93 RID: 16019 RVA: 0x001488C4 File Offset: 0x00146AC4
		[Token(Token = "0x6003E93")]
		[Address(RVA = "0x844E10", Offset = "0x843410", VA = "0x180844E10", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.zombie_PortName, (PortType)((uint)12), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x001488FC File Offset: 0x00146AFC
		[Token(Token = "0x6003E94")]
		[Address(RVA = "0x844F00", Offset = "0x843500", VA = "0x180844F00", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.row_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.rowSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.rowSourcePort = sourcePortName;
			string text2 = this.column_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.columnSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.columnSourcePort = sourcePortName2;
		}

		// Token: 0x06003E95 RID: 16021 RVA: 0x001489AC File Offset: 0x00146BAC
		[Token(Token = "0x6003E95")]
		[Address(RVA = "0xA59710", Offset = "0xA57D10", VA = "0x180A59710", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			int num;
			if (this.rowSourceNode != (ulong)0L)
			{
				num += 20;
				num += num;
			}
			int num2 = 0;
			EventNodeBase eventNodeBase;
			if (this.columnSourceNode != (ulong)0L)
			{
				eventNodeBase = this.columnSourceNode;
				num += 20;
				num += num;
			}
			int num3 = 0;
			float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(num3);
			float landY = Mouse.Instance.GetLandY(boxXFromColumn, num2);
			Board instance = Board.Instance;
			if (eventNodeBase == 0)
			{
				Func<Zombie, bool> func = new Func(Board.Instance, (IntPtr)num2);
			}
			int num4 = 0;
			Zombie zombie;
			if (!(zombie != num4))
			{
				int num5;
				int num6;
				EventNodeDebug.Log(string.Format("[GetNearestZombieNode] 未找到僵尸: 行{0}, 列{1}", num5, num6));
				return defaultValue;
			}
			string text;
			EventNodeDebug.Log(text);
			throw new NullReferenceException();
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x00148A70 File Offset: 0x00146C70
		[Token(Token = "0x6003E96")]
		[Address(RVA = "0x845050", Offset = "0x843650", VA = "0x180845050")]
		public GetNearestZombieNode()
		{
		}

		// Token: 0x04002F4F RID: 12111
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F4F")]
		public string row_PortName = "行";

		// Token: 0x04002F50 RID: 12112
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F50")]
		public string column_PortName = "列";

		// Token: 0x04002F51 RID: 12113
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F51")]
		public string zombie_PortName = "僵尸";

		// Token: 0x04002F52 RID: 12114
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F52")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002F53 RID: 12115
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F53")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002F54 RID: 12116
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F54")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002F55 RID: 12117
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F55")]
		[NonSerialized]
		private string columnSourcePort;
	}
}
