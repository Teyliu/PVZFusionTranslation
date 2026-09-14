using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BC9 RID: 3017
	[Token(Token = "0x2000BC9")]
	[Serializable]
	public class GetPlantsInCellNode : EventNodeBase
	{
		// Token: 0x06003ECE RID: 16078 RVA: 0x0014C3D0 File Offset: 0x0014A5D0
		[Token(Token = "0x6003ECE")]
		[Address(RVA = "0x7F62A0", Offset = "0x7F48A0", VA = "0x1807F62A0", Slot = "4")]
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

		// Token: 0x06003ECF RID: 16079 RVA: 0x0014C42C File Offset: 0x0014A62C
		[Token(Token = "0x6003ECF")]
		[Address(RVA = "0x7F6410", Offset = "0x7F4A10", VA = "0x1807F6410", Slot = "5")]
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

		// Token: 0x06003ED0 RID: 16080 RVA: 0x0014C464 File Offset: 0x0014A664
		[Token(Token = "0x6003ED0")]
		[Address(RVA = "0x7F6500", Offset = "0x7F4B00", VA = "0x1807F6500", Slot = "7")]
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

		// Token: 0x06003ED1 RID: 16081 RVA: 0x0014C514 File Offset: 0x0014A714
		[Token(Token = "0x6003ED1")]
		[Address(RVA = "0x9B1AE0", Offset = "0x9B00E0", VA = "0x1809B1AE0", Slot = "9")]
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

		// Token: 0x06003ED2 RID: 16082 RVA: 0x0014C5C8 File Offset: 0x0014A7C8
		[Token(Token = "0x6003ED2")]
		[Address(RVA = "0x7F6650", Offset = "0x7F4C50", VA = "0x1807F6650")]
		public GetPlantsInCellNode()
		{
		}

		// Token: 0x04002FB4 RID: 12212
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FB4")]
		public string row_PortName = "行";

		// Token: 0x04002FB5 RID: 12213
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FB5")]
		public string column_PortName = "列";

		// Token: 0x04002FB6 RID: 12214
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002FB6")]
		public string plants_PortName = "植物列表";

		// Token: 0x04002FB7 RID: 12215
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002FB7")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002FB8 RID: 12216
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002FB8")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002FB9 RID: 12217
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002FB9")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002FBA RID: 12218
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002FBA")]
		[NonSerialized]
		private string columnSourcePort;
	}
}
