using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BC4 RID: 3012
	[Token(Token = "0x2000BC4")]
	[Serializable]
	public class ModifyPlantAttackNode : EventNodeBase
	{
		// Token: 0x06003EB2 RID: 16050 RVA: 0x0014B684 File Offset: 0x00149884
		[Token(Token = "0x6003EB2")]
		[Address(RVA = "0x7FA470", Offset = "0x7F8A70", VA = "0x1807FA470", Slot = "4")]
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

		// Token: 0x06003EB3 RID: 16051 RVA: 0x0014B704 File Offset: 0x00149904
		[Token(Token = "0x6003EB3")]
		[Address(RVA = "0x7FA650", Offset = "0x7F8C50", VA = "0x1807FA650", Slot = "5")]
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

		// Token: 0x06003EB4 RID: 16052 RVA: 0x0014B75C File Offset: 0x0014995C
		[Token(Token = "0x6003EB4")]
		[Address(RVA = "0x7FA7C0", Offset = "0x7F8DC0", VA = "0x1807FA7C0", Slot = "7")]
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

		// Token: 0x06003EB5 RID: 16053 RVA: 0x0014B830 File Offset: 0x00149A30
		[Token(Token = "0x6003EB5")]
		[Address(RVA = "0x9E7780", Offset = "0x9E5D80", VA = "0x1809E7780", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x0014B878 File Offset: 0x00149A78
		[Token(Token = "0x6003EB6")]
		[Address(RVA = "0x7FA0F0", Offset = "0x7F86F0", VA = "0x1807FA0F0", Slot = "6")]
		public override void Execute()
		{
			int num;
			do
			{
				num = 0;
				int num2 = 0;
				if (this.plantSourceNode != 0)
				{
					num2 += 20;
					num2 += num2;
				}
				this.targetPlant = num2;
				if (this.multiplierSourceNode != 0)
				{
					string text = this.multiplierSourcePort;
					num2 += 20;
					num2 += num2;
				}
				Plant plant = this.targetPlant;
				int num3 = 0;
				if (!(plant != num3))
				{
					break;
				}
				Plant plant2 = this.targetPlant;
				EventNodeDebug.Log(string.Format("[ModifyPlantAttackNode] 修改植物攻击力加成{0}%", num));
				List<EventNodeBase> list = this.onModifiedTargets;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != 0);
			string text2;
			EventNodeDebug.LogWarning(text2);
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x0014B914 File Offset: 0x00149B14
		[Token(Token = "0x6003EB7")]
		[Address(RVA = "0x7FA930", Offset = "0x7F8F30", VA = "0x1807FA930")]
		public ModifyPlantAttackNode()
		{
			List<EventNodeBase> list = new List();
			this.onModifiedTargets = list;
			base..ctor();
		}

		// Token: 0x04002F84 RID: 12164
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F84")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F85 RID: 12165
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F85")]
		public string plant_PortName = "植物";

		// Token: 0x04002F86 RID: 12166
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F86")]
		public string multiplier_PortName = "攻击力加成x100%";

		// Token: 0x04002F87 RID: 12167
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F87")]
		public string onModified_PortName = "修改成功";

		// Token: 0x04002F88 RID: 12168
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F88")]
		public string plantOut_PortName = "植物";

		// Token: 0x04002F89 RID: 12169
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F89")]
		[NonSerialized]
		private EventNodeBase plantSourceNode;

		// Token: 0x04002F8A RID: 12170
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F8A")]
		[NonSerialized]
		private string plantSourcePort;

		// Token: 0x04002F8B RID: 12171
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002F8B")]
		[NonSerialized]
		private EventNodeBase multiplierSourceNode;

		// Token: 0x04002F8C RID: 12172
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002F8C")]
		[NonSerialized]
		private string multiplierSourcePort;

		// Token: 0x04002F8D RID: 12173
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002F8D")]
		[NonSerialized]
		private List<EventNodeBase> onModifiedTargets;

		// Token: 0x04002F8E RID: 12174
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002F8E")]
		private Plant targetPlant;
	}
}
