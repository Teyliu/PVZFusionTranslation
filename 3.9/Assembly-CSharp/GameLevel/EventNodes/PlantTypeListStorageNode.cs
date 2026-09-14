using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C23 RID: 3107
	[Token(Token = "0x2000C23")]
	[Serializable]
	public class PlantTypeListStorageNode : EventNodeBase
	{
		// Token: 0x0600408A RID: 16522 RVA: 0x00153A2C File Offset: 0x00151C2C
		[Token(Token = "0x600408A")]
		[Address(RVA = "0x8675C0", Offset = "0x865BC0", VA = "0x1808675C0", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.plantType_PortName, (PortType)((uint)9), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num4;
			PortDefinition portDefinition3 = new PortDefinition(this.list_PortName, (PortType)((uint)16), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x0600408B RID: 16523 RVA: 0x00153AB0 File Offset: 0x00151CB0
		[Token(Token = "0x600408B")]
		[Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[3];
			PortDefinition portDefinition = new PortDefinition(this.currentList_PortName, (PortType)((uint)16), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.count_PortName, (PortType)((uint)1), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num;
			PortDefinition portDefinition3 = new PortDefinition(this.onComplete_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x0600408C RID: 16524 RVA: 0x00153B28 File Offset: 0x00151D28
		[Token(Token = "0x600408C")]
		[Address(RVA = "0x867980", Offset = "0x865F80", VA = "0x180867980", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.list_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.listSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.listSourcePort = sourcePortName;
			string text2 = this.plantType_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.plantTypeSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.plantTypeSourcePort = sourcePortName2;
			string text3 = this.onComplete_PortName;
			string nodeId3 = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId3, text3);
			this.onCompleteTargets = connectedNodes;
			throw new NullReferenceException();
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x00153BFC File Offset: 0x00151DFC
		[Token(Token = "0x600408D")]
		[Address(RVA = "0x867B00", Offset = "0x866100", VA = "0x180867B00", Slot = "8")]
		public override void OnBoardStart(Board board)
		{
			if (!this.initialized && this.initializeEmpty)
			{
				List<PlantType> list = new List();
				this.storedList = list;
				this.initialized = true;
				EventNodeDebug.Log("[PlantTypeListStorageNode] 初始化为空列表");
				return;
			}
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x00153C3C File Offset: 0x00151E3C
		[Token(Token = "0x600408E")]
		[Address(RVA = "0x8672B0", Offset = "0x8658B0", VA = "0x1808672B0", Slot = "6")]
		public override void Execute()
		{
			ulong num2;
			do
			{
				int num = 0;
				if ((this.initialized ? 1 : 0) == num)
				{
					List<PlantType> list = new List();
					this.storedList = list;
					this.initialized = true;
				}
				ListStorageOperation listStorageOperation = this.operation;
				if (listStorageOperation != ListStorageOperation.Set)
				{
					if (listStorageOperation != ListStorageOperation.Set)
					{
						if (listStorageOperation == ListStorageOperation.Add)
						{
							this.RemovePlantType();
						}
						List<EventNodeBase> list2 = this.onCompleteTargets;
						bool flag;
						if (!flag)
						{
							goto IL_0086;
						}
					}
					this.AddPlantType();
				}
				while (this.listSourceNode == (ulong)0L)
				{
				}
				while ("[PlantTypeListStorageNode] 设置列表，大小: {0}" == 0)
				{
				}
				List<PlantType> list3;
				this.storedList = list3;
				int size = this.storedList._size;
				EventNodeDebug.Log(string.Format("[PlantTypeListStorageNode] 设置列表，大小: {0}", size));
				IL_0086:;
			}
			while (num2 != (ulong)0L);
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x00153CE8 File Offset: 0x00151EE8
		[Token(Token = "0x600408F")]
		[Address(RVA = "0x867E80", Offset = "0x866480", VA = "0x180867E80")]
		private void SetList()
		{
			if (this.listSourceNode != (ulong)0L && "[PlantTypeListStorageNode] 设置列表，大小: {0}" != 0)
			{
				List<PlantType> list;
				this.storedList = list;
				int size = this.storedList._size;
				EventNodeDebug.Log(string.Format("[PlantTypeListStorageNode] 设置列表，大小: {0}", size));
			}
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x00153D34 File Offset: 0x00151F34
		[Token(Token = "0x6004090")]
		[Address(RVA = "0x867080", Offset = "0x865680", VA = "0x180867080")]
		private void AddPlantType()
		{
			if (this.plantTypeSourceNode != (ulong)0L)
			{
				EventNodeBase eventNodeBase = this.listSourceNode;
				uint num;
				num += (uint)20;
				num += num;
				if ("[PlantTypeListStorageNode] 添加植物类型: {0}，当前大小: {1}" != (ulong)(-1L) && "[PlantTypeListStorageNode] 添加植物类型: {0}，当前大小: {1}" != 0)
				{
					int size = this.storedList._size;
					EventNodeDebug.Log(string.Format("[PlantTypeListStorageNode] 添加植物类型: {0}，当前大小: {1}", "[PlantTypeListStorageNode] 添加植物类型: {0}，当前大小: {1}", "[PlantTypeListStorageNode] 添加植物类型: {0}，当前大小: {1}"));
					List<PlantType> list;
					this.storedList = list;
				}
			}
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x00153DA4 File Offset: 0x00151FA4
		[Token(Token = "0x6004091")]
		[Address(RVA = "0x867BD0", Offset = "0x8661D0", VA = "0x180867BD0")]
		private void RemovePlantType()
		{
			if (this.plantTypeSourceNode != (ulong)0L)
			{
				PlantTypeListStorageNode.<>c__DisplayClass22_0 CS$<>8__locals1 = new PlantTypeListStorageNode.<>c__DisplayClass22_0();
				EventNodeBase eventNodeBase = this.plantTypeSourceNode;
				CS$<>8__locals1.plantType = CS$<>8__locals1;
				EventNodeBase eventNodeBase2 = this.listSourceNode;
				CS$<>8__locals1 += CS$<>8__locals1;
				if (CS$<>8__locals1 != 0)
				{
					Predicate<PlantType> predicate = (PlantType type) => type == CS$<>8__locals1.plantType;
					PlantType plantType = CS$<>8__locals1.plantType;
					int num;
					EventNodeDebug.Log(string.Format("[PlantTypeListStorageNode] 删除植物类型: {0}，删除数量: {1}，当前大小: {2}", num, num, num));
					List<PlantType> list;
					this.storedList = list;
				}
			}
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x00153E18 File Offset: 0x00152018
		[Token(Token = "0x6004092")]
		[Address(RVA = "0xAACB70", Offset = "0xAAB170", VA = "0x180AACB70", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x00153E7C File Offset: 0x0015207C
		[Token(Token = "0x6004093")]
		[Address(RVA = "0x867FF0", Offset = "0x8665F0", VA = "0x180867FF0", Slot = "10")]
		public override int ShowEditorUI(RuntimeNodeUI ui)
		{
			RectTransform valueEditContainer = ui.valueEditContainer;
			GameObject dropdownPrefab = ui.dropdownPrefab;
			int num = 0;
			if (!(dropdownPrefab != num))
			{
				return 0;
			}
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(ui.dropdownPrefab, valueEditContainer);
			bool flag;
			if (flag)
			{
				List<TMP_Dropdown.OptionData> list;
				int size = list._size;
				list._size = (int)((ulong)0L);
				if (size > 0)
				{
				}
				TMP_Dropdown.OptionData optionData = new TMP_Dropdown.OptionData("设置列表");
				TMP_Dropdown.OptionData optionData2 = new TMP_Dropdown.OptionData("添加元素");
				TMP_Dropdown.OptionData optionData3 = new TMP_Dropdown.OptionData("删除元素");
			}
			throw new NullReferenceException();
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x00153F00 File Offset: 0x00152100
		[Token(Token = "0x6004094")]
		[Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
		public PlantTypeListStorageNode()
		{
			List<EventNodeBase> list = new List();
			this.onCompleteTargets = list;
			base..ctor();
		}

		// Token: 0x0400319A RID: 12698
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400319A")]
		public string trigger_PortName = "触发";

		// Token: 0x0400319B RID: 12699
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400319B")]
		public string list_PortName = "列表";

		// Token: 0x0400319C RID: 12700
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400319C")]
		public string plantType_PortName = "植物类型";

		// Token: 0x0400319D RID: 12701
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400319D")]
		public string currentList_PortName = "当前列表";

		// Token: 0x0400319E RID: 12702
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400319E")]
		public string count_PortName = "列表长度";

		// Token: 0x0400319F RID: 12703
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400319F")]
		public string onComplete_PortName = "完成";

		// Token: 0x040031A0 RID: 12704
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40031A0")]
		public ListStorageOperation operation;

		// Token: 0x040031A1 RID: 12705
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x40031A1")]
		public bool initializeEmpty = true;

		// Token: 0x040031A2 RID: 12706
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40031A2")]
		[NonSerialized]
		private List<PlantType> storedList;

		// Token: 0x040031A3 RID: 12707
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40031A3")]
		[NonSerialized]
		private EventNodeBase listSourceNode;

		// Token: 0x040031A4 RID: 12708
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40031A4")]
		[NonSerialized]
		private string listSourcePort;

		// Token: 0x040031A5 RID: 12709
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40031A5")]
		[NonSerialized]
		private EventNodeBase plantTypeSourceNode;

		// Token: 0x040031A6 RID: 12710
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40031A6")]
		[NonSerialized]
		private string plantTypeSourcePort;

		// Token: 0x040031A7 RID: 12711
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x40031A7")]
		[NonSerialized]
		private List<EventNodeBase> onCompleteTargets;

		// Token: 0x040031A8 RID: 12712
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40031A8")]
		[NonSerialized]
		private bool initialized;
	}
}
