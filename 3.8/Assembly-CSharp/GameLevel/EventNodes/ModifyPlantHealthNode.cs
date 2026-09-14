using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BC5 RID: 3013
	[Token(Token = "0x2000BC5")]
	[Serializable]
	public class ModifyPlantHealthNode : EventNodeBase
	{
		// Token: 0x06003EB8 RID: 16056 RVA: 0x0014B96C File Offset: 0x00149B6C
		[Token(Token = "0x6003EB8")]
		[Address(RVA = "0x7FAE10", Offset = "0x7F9410", VA = "0x1807FAE10", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.plant_PortName, (PortType)((uint)11), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num4;
			PortDefinition portDefinition3 = new PortDefinition(this.multiplier_PortName, (PortType)((uint)3), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06003EB9 RID: 16057 RVA: 0x0014B9EC File Offset: 0x00149BEC
		[Token(Token = "0x6003EB9")]
		[Address(RVA = "0x7FAFF0", Offset = "0x7F95F0", VA = "0x1807FAFF0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.onModified_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.plantOut_PortName, (PortType)((uint)11), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003EBA RID: 16058 RVA: 0x0014BA44 File Offset: 0x00149C44
		[Token(Token = "0x6003EBA")]
		[Address(RVA = "0x7FB160", Offset = "0x7F9760", VA = "0x1807FB160", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.plant_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.plantSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.plantSourcePort = sourcePortName;
			string text2 = this.multiplier_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.multiplierSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.multiplierSourcePort = sourcePortName2;
			string text3 = this.onModified_PortName;
			string nodeId3 = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId3, text3);
			this.onModifiedTargets = connectedNodes;
			throw new NullReferenceException();
		}

		// Token: 0x06003EBB RID: 16059 RVA: 0x0014BB18 File Offset: 0x00149D18
		[Token(Token = "0x6003EBB")]
		[Address(RVA = "0x9E7780", Offset = "0x9E5D80", VA = "0x1809E7780", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x0014BB60 File Offset: 0x00149D60
		[Token(Token = "0x6003EBC")]
		[Address(RVA = "0x7FAA60", Offset = "0x7F9060", VA = "0x1807FAA60", Slot = "6")]
		public override void Execute()
		{
			ulong num4;
			do
			{
				int num = 0;
				if (this.plantSourceNode != 0)
				{
					num += 20;
					num += num;
				}
				this.targetPlant = num;
				if (this.multiplierSourceNode != 0)
				{
					string text = this.multiplierSourcePort;
					num += 20;
					num += num;
				}
				int num2 = 0;
				Plant plant = this.targetPlant;
				int num3 = 0;
				if (!(plant != num3))
				{
					break;
				}
				Plant plant2 = this.targetPlant;
				this.targetPlant.UpdateText();
				EventNodeDebug.Log(string.Format("[ModifyPlantHealthNode] 修改植物血量加成{0}%", num2));
				List<EventNodeBase> list = this.onModifiedTargets;
				bool flag;
				if (flag)
				{
				}
			}
			while (num4 != (ulong)0L);
			string text2;
			EventNodeDebug.LogWarning(text2);
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x0014BC0C File Offset: 0x00149E0C
		[Token(Token = "0x6003EBD")]
		[Address(RVA = "0x7FB2D0", Offset = "0x7F98D0", VA = "0x1807FB2D0")]
		public ModifyPlantHealthNode()
		{
			List<EventNodeBase> list = new List();
			this.onModifiedTargets = list;
			base..ctor();
		}

		// Token: 0x04002F8F RID: 12175
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F8F")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F90 RID: 12176
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F90")]
		public string plant_PortName = "植物";

		// Token: 0x04002F91 RID: 12177
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F91")]
		public string multiplier_PortName = "血量加成x100%";

		// Token: 0x04002F92 RID: 12178
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F92")]
		public string onModified_PortName = "修改成功";

		// Token: 0x04002F93 RID: 12179
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F93")]
		public string plantOut_PortName = "植物";

		// Token: 0x04002F94 RID: 12180
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F94")]
		[NonSerialized]
		private EventNodeBase plantSourceNode;

		// Token: 0x04002F95 RID: 12181
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F95")]
		[NonSerialized]
		private string plantSourcePort;

		// Token: 0x04002F96 RID: 12182
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002F96")]
		[NonSerialized]
		private EventNodeBase multiplierSourceNode;

		// Token: 0x04002F97 RID: 12183
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002F97")]
		[NonSerialized]
		private string multiplierSourcePort;

		// Token: 0x04002F98 RID: 12184
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002F98")]
		[NonSerialized]
		private List<EventNodeBase> onModifiedTargets;

		// Token: 0x04002F99 RID: 12185
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002F99")]
		private Plant targetPlant;
	}
}
