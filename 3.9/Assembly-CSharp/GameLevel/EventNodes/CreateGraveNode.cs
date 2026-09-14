using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BAC RID: 2988
	[Token(Token = "0x2000BAC")]
	[Serializable]
	public class CreateGraveNode : EventNodeBase
	{
		// Token: 0x06003E33 RID: 15923 RVA: 0x00145F58 File Offset: 0x00144158
		[Token(Token = "0x6003E33")]
		[Address(RVA = "0x83AE80", Offset = "0x839480", VA = "0x18083AE80", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[3];
			int num;
			int num2;
			PortDefinition portDefinition = new PortDefinition(this.trigger_PortName, (PortType)num, (PortDirection)num2);
			num2 = 0;
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num3;
			PortDefinition portDefinition2 = new PortDefinition(this.row_PortName, (PortType)((uint)1), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num4;
			PortDefinition portDefinition3 = new PortDefinition(this.column_PortName, (PortType)((uint)1), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x00145FD8 File Offset: 0x001441D8
		[Token(Token = "0x6003E34")]
		[Address(RVA = "0x83B060", Offset = "0x839660", VA = "0x18083B060", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003E35 RID: 15925 RVA: 0x00145FE8 File Offset: 0x001441E8
		[Token(Token = "0x6003E35")]
		[Address(RVA = "0x83B0A0", Offset = "0x8396A0", VA = "0x18083B0A0", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.column_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.columnSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.columnSourcePort = sourcePortName;
			string text2 = this.row_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.rowSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.rowSourcePort = sourcePortName2;
		}

		// Token: 0x06003E36 RID: 15926 RVA: 0x00146098 File Offset: 0x00144298
		[Token(Token = "0x6003E36")]
		[Address(RVA = "0x83AD10", Offset = "0x839310", VA = "0x18083AD10", Slot = "6")]
		public override void Execute()
		{
			if (this.columnSourceNode != (ulong)0L)
			{
			}
			if (this.rowSourceNode != (ulong)0L)
			{
			}
			int num;
			int num2;
			EventNodeDebug.Log(string.Format("[CreateGraveNode] 在 ({0}, {1}) 创建了墓碑", num, num2));
		}

		// Token: 0x06003E37 RID: 15927 RVA: 0x001460D4 File Offset: 0x001442D4
		[Token(Token = "0x6003E37")]
		[Address(RVA = "0x83B1F0", Offset = "0x8397F0", VA = "0x18083B1F0")]
		public CreateGraveNode()
		{
		}

		// Token: 0x04002EB2 RID: 11954
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002EB2")]
		public string trigger_PortName = "触发";

		// Token: 0x04002EB3 RID: 11955
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002EB3")]
		public string column_PortName = "列";

		// Token: 0x04002EB4 RID: 11956
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002EB4")]
		public string row_PortName = "行";

		// Token: 0x04002EB5 RID: 11957
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002EB5")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002EB6 RID: 11958
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002EB6")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002EB7 RID: 11959
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002EB7")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002EB8 RID: 11960
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002EB8")]
		[NonSerialized]
		private string rowSourcePort;
	}
}
