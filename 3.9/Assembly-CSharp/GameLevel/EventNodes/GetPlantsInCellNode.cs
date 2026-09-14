using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C0B RID: 3083
	[Token(Token = "0x2000C0B")]
	[Serializable]
	public class GetPlantsInCellNode : EventNodeBase
	{
		// Token: 0x0600401F RID: 16415 RVA: 0x0015163C File Offset: 0x0014F83C
		[Token(Token = "0x600401F")]
		[Address(RVA = "0x85DE50", Offset = "0x85C450", VA = "0x18085DE50", Slot = "4")]
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

		// Token: 0x06004020 RID: 16416 RVA: 0x00151698 File Offset: 0x0014F898
		[Token(Token = "0x6004020")]
		[Address(RVA = "0x85DFC0", Offset = "0x85C5C0", VA = "0x18085DFC0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.plants_PortName, (PortType)((uint)14), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06004021 RID: 16417 RVA: 0x001516D0 File Offset: 0x0014F8D0
		[Token(Token = "0x6004021")]
		[Address(RVA = "0x85E0B0", Offset = "0x85C6B0", VA = "0x18085E0B0", Slot = "7")]
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

		// Token: 0x06004022 RID: 16418 RVA: 0x00151780 File Offset: 0x0014F980
		[Token(Token = "0x6004022")]
		[Address(RVA = "0xA5B440", Offset = "0xA59A40", VA = "0x180A5B440", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			Type typeFromHandle = typeof(List<Plant>);
			Type type;
			if (type.Equals(typeFromHandle))
			{
				if (this.rowSourceNode != 0)
				{
				}
				int num = 0;
				if (this.columnSourceNode != 0)
				{
				}
				int num2 = 0;
				Board instance = Board.Instance;
				int num3 = 0;
				if (!(instance == num3))
				{
					int size = Enumerable.ToList<Plant>(instance.gridSystem.GetGrid(num2, num).plants)._size;
					int num4;
					int num5;
					EventNodeDebug.Log(string.Format("[GetPlantsInCellNode] 获取格子({0}, {1})内的植物，共{2}个", num4, num5, num5));
				}
				string text;
				EventNodeDebug.LogWarning(text);
				List<Plant> list = new List();
			}
			throw new InvalidCastException();
		}

		// Token: 0x06004023 RID: 16419 RVA: 0x00151834 File Offset: 0x0014FA34
		[Token(Token = "0x6004023")]
		[Address(RVA = "0x85E200", Offset = "0x85C800", VA = "0x18085E200")]
		public GetPlantsInCellNode()
		{
		}

		// Token: 0x04003128 RID: 12584
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003128")]
		public string row_PortName = "行";

		// Token: 0x04003129 RID: 12585
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003129")]
		public string column_PortName = "列";

		// Token: 0x0400312A RID: 12586
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400312A")]
		public string plants_PortName = "植物列表";

		// Token: 0x0400312B RID: 12587
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400312B")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x0400312C RID: 12588
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400312C")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x0400312D RID: 12589
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400312D")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x0400312E RID: 12590
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400312E")]
		[NonSerialized]
		private string columnSourcePort;
	}
}
