using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BE1 RID: 3041
	[Token(Token = "0x2000BE1")]
	[Serializable]
	public class PlantTypeListStorageNode : EventNodeBase
	{
		// Token: 0x06003F39 RID: 16185 RVA: 0x0014E7D8 File Offset: 0x0014C9D8
		[Token(Token = "0x6003F39")]
		[Address(RVA = "0x7FFC10", Offset = "0x7FE210", VA = "0x1807FFC10", Slot = "4")]
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

		// Token: 0x06003F3A RID: 16186 RVA: 0x0014E85C File Offset: 0x0014CA5C
		[Token(Token = "0x6003F3A")]
		[Address(RVA = "0x7FFDF0", Offset = "0x7FE3F0", VA = "0x1807FFDF0", Slot = "5")]
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

		// Token: 0x06003F3B RID: 16187 RVA: 0x0014E8D4 File Offset: 0x0014CAD4
		[Token(Token = "0x6003F3B")]
		[Address(RVA = "0x7FFFD0", Offset = "0x7FE5D0", VA = "0x1807FFFD0", Slot = "7")]
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

		// Token: 0x06003F3C RID: 16188 RVA: 0x0014E9A8 File Offset: 0x0014CBA8
		[Token(Token = "0x6003F3C")]
		[Address(RVA = "0x800150", Offset = "0x7FE750", VA = "0x180800150", Slot = "8")]
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

		// Token: 0x06003F3D RID: 16189 RVA: 0x0014E9E8 File Offset: 0x0014CBE8
		[Token(Token = "0x6003F3D")]
		[Address(RVA = "0x7FF900", Offset = "0x7FDF00", VA = "0x1807FF900", Slot = "6")]
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

		// Token: 0x06003F3E RID: 16190 RVA: 0x0014EA94 File Offset: 0x0014CC94
		[Token(Token = "0x6003F3E")]
		[Address(RVA = "0x8004D0", Offset = "0x7FEAD0", VA = "0x1808004D0")]
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

		// Token: 0x06003F3F RID: 16191 RVA: 0x0014EAE0 File Offset: 0x0014CCE0
		[Token(Token = "0x6003F3F")]
		[Address(RVA = "0x7FF6D0", Offset = "0x7FDCD0", VA = "0x1807FF6D0")]
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

		// Token: 0x06003F40 RID: 16192 RVA: 0x0014EB50 File Offset: 0x0014CD50
		[Token(Token = "0x6003F40")]
		[Address(RVA = "0x800220", Offset = "0x7FE820", VA = "0x180800220")]
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

		// Token: 0x06003F41 RID: 16193 RVA: 0x0014EBC4 File Offset: 0x0014CDC4
		[Token(Token = "0x6003F41")]
		[Address(RVA = "0x9FB330", Offset = "0x9F9930", VA = "0x1809FB330", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003F42 RID: 16194 RVA: 0x0014EC28 File Offset: 0x0014CE28
		[Token(Token = "0x6003F42")]
		[Address(RVA = "0x800640", Offset = "0x7FEC40", VA = "0x180800640", Slot = "10")]
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

		// Token: 0x06003F43 RID: 16195 RVA: 0x0014ECAC File Offset: 0x0014CEAC
		[Token(Token = "0x6003F43")]
		[Address(RVA = "0x8009F0", Offset = "0x7FEFF0", VA = "0x1808009F0")]
		public PlantTypeListStorageNode()
		{
			List<EventNodeBase> list = new List();
			this.onCompleteTargets = list;
			base..ctor();
		}

		// Token: 0x04003027 RID: 12327
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003027")]
		public string trigger_PortName = "触发";

		// Token: 0x04003028 RID: 12328
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003028")]
		public string list_PortName = "列表";

		// Token: 0x04003029 RID: 12329
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003029")]
		public string plantType_PortName = "植物类型";

		// Token: 0x0400302A RID: 12330
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400302A")]
		public string currentList_PortName = "当前列表";

		// Token: 0x0400302B RID: 12331
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400302B")]
		public string count_PortName = "列表长度";

		// Token: 0x0400302C RID: 12332
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400302C")]
		public string onComplete_PortName = "完成";

		// Token: 0x0400302D RID: 12333
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400302D")]
		public ListStorageOperation operation;

		// Token: 0x0400302E RID: 12334
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x400302E")]
		public bool initializeEmpty = true;

		// Token: 0x0400302F RID: 12335
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400302F")]
		[NonSerialized]
		private List<PlantType> storedList;

		// Token: 0x04003030 RID: 12336
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4003030")]
		[NonSerialized]
		private EventNodeBase listSourceNode;

		// Token: 0x04003031 RID: 12337
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4003031")]
		[NonSerialized]
		private string listSourcePort;

		// Token: 0x04003032 RID: 12338
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4003032")]
		[NonSerialized]
		private EventNodeBase plantTypeSourceNode;

		// Token: 0x04003033 RID: 12339
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4003033")]
		[NonSerialized]
		private string plantTypeSourcePort;

		// Token: 0x04003034 RID: 12340
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4003034")]
		[NonSerialized]
		private List<EventNodeBase> onCompleteTargets;

		// Token: 0x04003035 RID: 12341
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4003035")]
		[NonSerialized]
		private bool initialized;
	}
}
