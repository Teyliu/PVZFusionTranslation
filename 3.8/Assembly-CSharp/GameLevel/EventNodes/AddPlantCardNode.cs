using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B85 RID: 2949
	[Token(Token = "0x2000B85")]
	[Serializable]
	public class AddPlantCardNode : EventNodeBase
	{
		// Token: 0x06003D6C RID: 15724 RVA: 0x00144428 File Offset: 0x00142628
		[Token(Token = "0x6003D6C")]
		[Address(RVA = "0x7EDE90", Offset = "0x7EC490", VA = "0x1807EDE90", Slot = "4")]
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

		// Token: 0x06003D6D RID: 15725 RVA: 0x001444F0 File Offset: 0x001426F0
		[Token(Token = "0x6003D6D")]
		[Address(RVA = "0x7EE160", Offset = "0x7EC760", VA = "0x1807EE160", Slot = "5")]
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

		// Token: 0x06003D6E RID: 15726 RVA: 0x00144590 File Offset: 0x00142790
		[Token(Token = "0x6003D6E")]
		[Address(RVA = "0x7EE3C0", Offset = "0x7EC9C0", VA = "0x1807EE3C0", Slot = "7")]
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

		// Token: 0x06003D6F RID: 15727 RVA: 0x001446EC File Offset: 0x001428EC
		[Token(Token = "0x6003D6F")]
		[Address(RVA = "0x7ED730", Offset = "0x7EBD30", VA = "0x1807ED730", Slot = "6")]
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

		// Token: 0x06003D70 RID: 15728 RVA: 0x001448A0 File Offset: 0x00142AA0
		[Token(Token = "0x6003D70")]
		[Address(RVA = "0x7EE650", Offset = "0x7ECC50", VA = "0x1807EE650")]
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

		// Token: 0x06003D71 RID: 15729 RVA: 0x00144904 File Offset: 0x00142B04
		[Token(Token = "0x6003D71")]
		[Address(RVA = "0x8B9270", Offset = "0x8B7870", VA = "0x1808B9270", Slot = "9")]
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

		// Token: 0x06003D72 RID: 15730 RVA: 0x00144954 File Offset: 0x00142B54
		[Token(Token = "0x6003D72")]
		[Address(RVA = "0x7EE7B0", Offset = "0x7ECDB0", VA = "0x1807EE7B0")]
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

		// Token: 0x06003D73 RID: 15731 RVA: 0x001449A0 File Offset: 0x00142BA0
		[Token(Token = "0x6003D73")]
		[Address(RVA = "0x7EE960", Offset = "0x7ECF60", VA = "0x1807EE960")]
		public AddPlantCardNode()
		{
		}

		// Token: 0x04002E0F RID: 11791
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E0F")]
		public PlantType plantType;

		// Token: 0x04002E10 RID: 11792
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4002E10")]
		public float cooldown = 7.5f;

		// Token: 0x04002E11 RID: 11793
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E11")]
		public int cost = (int)((ulong)100L);

		// Token: 0x04002E12 RID: 11794
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4002E12")]
		public bool useDefaultData = true;

		// Token: 0x04002E13 RID: 11795
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E13")]
		public string trigger_PortName = "触发";

		// Token: 0x04002E14 RID: 11796
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E14")]
		public string plantType_PortName = "植物类型";

		// Token: 0x04002E15 RID: 11797
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002E15")]
		public string cooldown_PortName = "冷却时间";

		// Token: 0x04002E16 RID: 11798
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002E16")]
		public string cost_PortName = "价格";

		// Token: 0x04002E17 RID: 11799
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002E17")]
		public string useDefaultData_PortName = "使用默认数据";

		// Token: 0x04002E18 RID: 11800
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002E18")]
		public string success_PortName = "添加成功";

		// Token: 0x04002E19 RID: 11801
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002E19")]
		public string failed_PortName = "添加失败";

		// Token: 0x04002E1A RID: 11802
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002E1A")]
		public string onPlant_PortName = "种植时触发";

		// Token: 0x04002E1B RID: 11803
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002E1B")]
		public string plantedPlant_PortName = "种植的植物";

		// Token: 0x04002E1C RID: 11804
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002E1C")]
		[NonSerialized]
		private EventNodeBase plantTypeSourceNode;

		// Token: 0x04002E1D RID: 11805
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002E1D")]
		[NonSerialized]
		private string plantTypeSourcePort;

		// Token: 0x04002E1E RID: 11806
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002E1E")]
		[NonSerialized]
		private EventNodeBase cooldownSourceNode;

		// Token: 0x04002E1F RID: 11807
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4002E1F")]
		[NonSerialized]
		private string cooldownSourcePort;

		// Token: 0x04002E20 RID: 11808
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4002E20")]
		[NonSerialized]
		private EventNodeBase costSourceNode;

		// Token: 0x04002E21 RID: 11809
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4002E21")]
		[NonSerialized]
		private string costSourcePort;

		// Token: 0x04002E22 RID: 11810
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4002E22")]
		[NonSerialized]
		private EventNodeBase useDefaultDataSourceNode;

		// Token: 0x04002E23 RID: 11811
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4002E23")]
		[NonSerialized]
		private string useDefaultDataSourcePort;

		// Token: 0x04002E24 RID: 11812
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4002E24")]
		[NonSerialized]
		private EventNodeGraph cachedGraph;

		// Token: 0x04002E25 RID: 11813
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x4002E25")]
		[NonSerialized]
		private Plant plantedPlant;
	}
}
