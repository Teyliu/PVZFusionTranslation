using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BC7 RID: 3015
	[Token(Token = "0x2000BC7")]
	[Serializable]
	public class AddPlantCardNode : EventNodeBase
	{
		// Token: 0x06003EBD RID: 16061 RVA: 0x001496B8 File Offset: 0x001478B8
		[Token(Token = "0x6003EBD")]
		[Address(RVA = "0x855960", Offset = "0x853F60", VA = "0x180855960", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[5];
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
			PortDefinition portDefinition2 = new PortDefinition(this.plantType_PortName, (PortType)((uint)9), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num4;
			PortDefinition portDefinition3 = new PortDefinition(this.cooldown_PortName, (PortType)((uint)3), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			int num5;
			PortDefinition portDefinition4 = new PortDefinition(this.cost_PortName, (PortType)((uint)1), (PortDirection)num5);
			num5 = 0;
			if (portDefinition4 != 0)
			{
			}
			array[3] = portDefinition4;
			int num6;
			PortDefinition portDefinition5 = new PortDefinition(this.useDefaultData_PortName, (PortType)((uint)6), (PortDirection)num6);
			num6 = 0;
			if (portDefinition5 != 0)
			{
			}
			array[4] = portDefinition5;
			return array;
		}

		// Token: 0x06003EBE RID: 16062 RVA: 0x00149780 File Offset: 0x00147980
		[Token(Token = "0x6003EBE")]
		[Address(RVA = "0x855C30", Offset = "0x854230", VA = "0x180855C30", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[4];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.success_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.failed_PortName, (PortType)num2, (PortDirection)((uint)1));
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num3;
			PortDefinition portDefinition3 = new PortDefinition(this.onPlant_PortName, (PortType)num3, (PortDirection)((uint)1));
			num3 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			PortDefinition portDefinition4 = new PortDefinition(this.plantedPlant_PortName, (PortType)((uint)11), (PortDirection)((uint)1));
			if (portDefinition4 != 0)
			{
			}
			array[3] = portDefinition4;
			return array;
		}

		// Token: 0x06003EBF RID: 16063 RVA: 0x00149820 File Offset: 0x00147A20
		[Token(Token = "0x6003EBF")]
		[Address(RVA = "0x855E90", Offset = "0x854490", VA = "0x180855E90", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			this.cachedGraph = graph;
			string text = this.plantType_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.plantTypeSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.plantTypeSourcePort = sourcePortName;
			string text2 = this.cooldown_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.cooldownSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.cooldownSourcePort = sourcePortName2;
			string text3 = this.cost_PortName;
			string nodeId3 = this.nodeId;
			List<SourcePortInfo> sourceNodes3 = graph.GetSourceNodes(nodeId3, text3);
			int num5 = 0;
			EventNodeBase sourceNode3 = sourceNodes3[num5].sourceNode;
			this.costSourceNode = sourceNode3;
			int num6 = 0;
			string sourcePortName3 = sourceNodes3[num6].sourcePortName;
			this.costSourcePort = sourcePortName3;
			string text4 = this.useDefaultData_PortName;
			string nodeId4 = this.nodeId;
			List<SourcePortInfo> sourceNodes4 = graph.GetSourceNodes(nodeId4, text4);
			int num7 = 0;
			EventNodeBase sourceNode4 = sourceNodes4[num7].sourceNode;
			this.useDefaultDataSourceNode = sourceNode4;
			int num8 = 0;
			string sourcePortName4 = sourceNodes4[num8].sourcePortName;
			this.useDefaultDataSourcePort = sourcePortName4;
		}

		// Token: 0x06003EC0 RID: 16064 RVA: 0x0014997C File Offset: 0x00147B7C
		[Token(Token = "0x6003EC0")]
		[Address(RVA = "0x855200", Offset = "0x853800", VA = "0x180855200", Slot = "6")]
		public override void Execute()
		{
			if (this.plantTypeSourceNode != (ulong)0L)
			{
				PlantType plantType = this.plantType;
			}
			PlantType plantType2 = this.plantType;
			float num = this.cooldown;
			if (this.cooldownSourceNode != (ulong)0L)
			{
			}
			if (this.costSourceNode != (ulong)0L)
			{
			}
			int num2 = this.cost;
			if (this.useDefaultDataSourceNode != (ulong)0L)
			{
			}
			bool flag = this.useDefaultData;
			object[] array = new object[4];
			if (array != 0)
			{
			}
			array[0] = array;
			if (array != 0)
			{
			}
			array[1] = array;
			if (array != 0)
			{
			}
			array[2] = array;
			if (array != 0)
			{
			}
			array[3] = array;
			EventNodeDebug.Log(string.Format("[AddPlantCardNode] 添加植物卡牌: {0}, 冷却: {1}, 价格: {2}, 使用默认数据: {3}", array));
			int num3 = 0;
			CardUI cardUI;
			bool flag2 = cardUI == num3;
			Action<Plant> action;
			if (!flag2)
			{
				if (flag)
				{
					float fullCD = cardUI.fullCD;
					int theSeedCost = cardUI.theSeedCost;
				}
				cardUI.fullCD = num;
				cardUI.CD = num;
				cardUI.theSeedCost = num2;
				int theSeedCost2 = cardUI.theSeedCost;
				EventNodeDebug.Log(string.Format("[AddPlantCardNode] 自定义属性 - 冷却: {0}, 价格: {1}", flag2, flag2));
				ulong num4;
				bool flag3 = InGameUI.Instance.AddCardToBank(cardUI, num4 != 0UL);
				GameObject gameObject;
				if (!flag3)
				{
					string nodeId = this.nodeId;
					EventNodeDebug.LogWarning(string.Format("[AddPlantCardNode] 添加卡牌到卡槽失败（卡槽已满）: {0}，节点ID: {1}", flag3, nodeId));
					int num5 = 0;
					if (cardUI != num5)
					{
						gameObject = cardUI.gameObject;
						global::UnityEngine.Object.Destroy(gameObject);
					}
					string text = this.failed_PortName;
					this.TriggerPort(text);
					return;
				}
				EventNodeDebug.Log(string.Format("[AddPlantCardNode] 成功添加卡牌到卡槽: {0}", gameObject));
				cardUI.plantAction = action;
			}
			string nodeId2 = this.nodeId;
			EventNodeDebug.LogWarning(string.Format("[AddPlantCardNode] 创建卡牌失败: {0}，节点ID: {1}", action, nodeId2));
			throw new NullReferenceException();
		}

		// Token: 0x06003EC1 RID: 16065 RVA: 0x00149B30 File Offset: 0x00147D30
		[Token(Token = "0x6003EC1")]
		[Address(RVA = "0x856120", Offset = "0x854720", VA = "0x180856120")]
		private void OnPlant(Plant plant)
		{
			int num = 0;
			if (!(plant == num))
			{
				PlantType thePlantType = plant.thePlantType;
				EventNodeDebug.Log(string.Format("[AddPlantCardNode] 种植回调触发，植物: {0}", thePlantType));
				this.plantedPlant = plant;
				string text = this.onPlant_PortName;
				this.TriggerPort(text);
				return;
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[AddPlantCardNode] 种植回调：植物对象为空，节点ID: " + nodeId);
		}

		// Token: 0x06003EC2 RID: 16066 RVA: 0x00149B94 File Offset: 0x00147D94
		[Token(Token = "0x6003EC2")]
		[Address(RVA = "0x959260", Offset = "0x957860", VA = "0x180959260", Slot = "9")]
		public override T GetPortValue<T>(string portName, [Optional] T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			Plant plant = this.plantedPlant;
			int num = 0;
			if (plant != num)
			{
				Plant plant2 = this.plantedPlant;
			}
			T t;
			return t;
		}

		// Token: 0x06003EC3 RID: 16067 RVA: 0x00149BE4 File Offset: 0x00147DE4
		[Token(Token = "0x6003EC3")]
		[Address(RVA = "0x856280", Offset = "0x854880", VA = "0x180856280")]
		private void TriggerPort(string portName)
		{
			ulong num2;
			do
			{
				int num = 0;
				if (this.cachedGraph == num)
				{
					break;
				}
				string nodeId = this.nodeId;
				List<EventNodeBase> connectedNodes = this.cachedGraph.GetConnectedNodes(nodeId, portName);
				bool flag;
				if (flag)
				{
					string text;
					EventNodeDebug.Log(text);
				}
			}
			while (num2 != (ulong)0L);
		}

		// Token: 0x06003EC4 RID: 16068 RVA: 0x00149C30 File Offset: 0x00147E30
		[Token(Token = "0x6003EC4")]
		[Address(RVA = "0x856430", Offset = "0x854A30", VA = "0x180856430")]
		public AddPlantCardNode()
		{
		}

		// Token: 0x04002F83 RID: 12163
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F83")]
		public PlantType plantType;

		// Token: 0x04002F84 RID: 12164
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4002F84")]
		public float cooldown = 7.5f;

		// Token: 0x04002F85 RID: 12165
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F85")]
		public int cost = (int)((ulong)100L);

		// Token: 0x04002F86 RID: 12166
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4002F86")]
		public bool useDefaultData = true;

		// Token: 0x04002F87 RID: 12167
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F87")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F88 RID: 12168
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F88")]
		public string plantType_PortName = "植物类型";

		// Token: 0x04002F89 RID: 12169
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F89")]
		public string cooldown_PortName = "冷却时间";

		// Token: 0x04002F8A RID: 12170
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F8A")]
		public string cost_PortName = "价格";

		// Token: 0x04002F8B RID: 12171
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F8B")]
		public string useDefaultData_PortName = "使用默认数据";

		// Token: 0x04002F8C RID: 12172
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002F8C")]
		public string success_PortName = "添加成功";

		// Token: 0x04002F8D RID: 12173
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002F8D")]
		public string failed_PortName = "添加失败";

		// Token: 0x04002F8E RID: 12174
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002F8E")]
		public string onPlant_PortName = "种植时触发";

		// Token: 0x04002F8F RID: 12175
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002F8F")]
		public string plantedPlant_PortName = "种植的植物";

		// Token: 0x04002F90 RID: 12176
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002F90")]
		[NonSerialized]
		private EventNodeBase plantTypeSourceNode;

		// Token: 0x04002F91 RID: 12177
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002F91")]
		[NonSerialized]
		private string plantTypeSourcePort;

		// Token: 0x04002F92 RID: 12178
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002F92")]
		[NonSerialized]
		private EventNodeBase cooldownSourceNode;

		// Token: 0x04002F93 RID: 12179
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4002F93")]
		[NonSerialized]
		private string cooldownSourcePort;

		// Token: 0x04002F94 RID: 12180
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4002F94")]
		[NonSerialized]
		private EventNodeBase costSourceNode;

		// Token: 0x04002F95 RID: 12181
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4002F95")]
		[NonSerialized]
		private string costSourcePort;

		// Token: 0x04002F96 RID: 12182
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4002F96")]
		[NonSerialized]
		private EventNodeBase useDefaultDataSourceNode;

		// Token: 0x04002F97 RID: 12183
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4002F97")]
		[NonSerialized]
		private string useDefaultDataSourcePort;

		// Token: 0x04002F98 RID: 12184
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4002F98")]
		[NonSerialized]
		private EventNodeGraph cachedGraph;

		// Token: 0x04002F99 RID: 12185
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x4002F99")]
		[NonSerialized]
		private Plant plantedPlant;
	}
}
