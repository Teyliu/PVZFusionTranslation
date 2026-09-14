using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel.EventNodes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GameLevel
{
	// Token: 0x02000B58 RID: 2904
	[Token(Token = "0x2000B58")]
	public class CustomMenuPage_event : CustomMenu_page
	{
		// Token: 0x06003C93 RID: 15507 RVA: 0x0013BED0 File Offset: 0x0013A0D0
		[Token(Token = "0x6003C93")]
		[Address(RVA = "0x81DD80", Offset = "0x81C380", VA = "0x18081DD80", Slot = "4")]
		public override void LoadOriginalSettings()
		{
			this.InitializeNodeEditor();
			Toggle.ToggleEvent onValueChanged = this.nodeInfoToggle.onValueChanged;
			UnityAction<bool> unityAction = delegate(bool value)
			{
				this.nodeInfoPanel.gameObject.SetActive(value);
			};
			onValueChanged.AddListener(unityAction);
			Toggle.ToggleEvent onValueChanged2 = this.attributeToggle.onValueChanged;
			UnityAction<bool> unityAction2 = delegate(bool value)
			{
				this.attributePanel.gameObject.SetActive(value);
			};
			onValueChanged2.AddListener(unityAction2);
		}

		// Token: 0x06003C94 RID: 15508 RVA: 0x0013BF2C File Offset: 0x0013A12C
		[Token(Token = "0x6003C94")]
		[Address(RVA = "0x81D9D0", Offset = "0x81BFD0", VA = "0x18081D9D0")]
		private void InitializeNodeEditor()
		{
			do
			{
				GameObject gameObject = this.contextMenuPrefab;
				int num = 0;
				if (gameObject != num)
				{
					RuntimeEventNodeEditor runtimeEventNodeEditor = this.nodeEditor;
					GameObject gameObject2 = this.contextMenuPrefab;
					Transform transform = runtimeEventNodeEditor.transform;
					GameObject gameObject3 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject2, transform);
					bool flag;
					if (!flag)
					{
						EventNodeContextMenu eventNodeContextMenu = gameObject3.AddComponent<EventNodeContextMenu>();
					}
					RuntimeEventNodeEditor runtimeEventNodeEditor2 = this.nodeEditor;
					EventNodeDebug.Log("[EventNodeContextMenu] 菜单结构初始化完成");
					ulong num2;
					this.eventNodeCanvas.contextMenu = num2;
				}
			}
			while (CustomMenu._levelData.eventNodeGraph == (ulong)0L);
			ulong num3;
			if (num3 == (ulong)0L)
			{
			}
			List<EventNodeBase> nodes = CustomMenu._levelData.eventNodeGraph.nodes;
			RuntimeEventNodeEditor runtimeEventNodeEditor3 = this.nodeEditor;
			ulong num4;
			if (num4 == (ulong)0L)
			{
			}
			Dictionary<string, EventNodeBase> nodeCache = CustomMenu._levelData.eventNodeGraph.nodeCache;
			EventNodeGraph eventNodeGraph = new EventNodeGraph();
			Debug.Log("[CustomMenuPage_event] 节点编辑器初始化完成");
		}

		// Token: 0x06003C95 RID: 15509 RVA: 0x0013C004 File Offset: 0x0013A204
		[Token(Token = "0x6003C95")]
		[Address(RVA = "0x81DE90", Offset = "0x81C490", VA = "0x18081DE90", Slot = "6")]
		public override void OnExport()
		{
			RuntimeEventNodeEditor runtimeEventNodeEditor = this.nodeEditor;
			int num = 0;
			if (runtimeEventNodeEditor != num && this.nodeEditor.graph != (ulong)0L)
			{
				RuntimeEventNodeEditor runtimeEventNodeEditor2 = this.nodeEditor;
				SerializedLevelData levelData = CustomMenu._levelData;
				EventNodeGraph graph = runtimeEventNodeEditor2.graph;
				levelData.eventNodeGraph = graph;
				int size = this.nodeEditor.graph.nodes._size;
				int size2 = this.nodeEditor.graph.connections._size;
				Debug.Log(string.Format("[CustomMenuPage_event] 已保存节点图: {0} 个节点, {1} 条连接", size, size2));
			}
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x0013C098 File Offset: 0x0013A298
		[Token(Token = "0x6003C96")]
		[Address(RVA = "0x5EDFC0", Offset = "0x5EC5C0", VA = "0x1805EDFC0")]
		public CustomMenuPage_event()
		{
		}

		// Token: 0x04002D0A RID: 11530
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002D0A")]
		[Header("节点编辑器")]
		public GameObject contextMenuPrefab;

		// Token: 0x04002D0B RID: 11531
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002D0B")]
		public Toggle nodeInfoToggle;

		// Token: 0x04002D0C RID: 11532
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002D0C")]
		public Toggle attributeToggle;

		// Token: 0x04002D0D RID: 11533
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002D0D")]
		public RuntimeEventNodeEditor nodeEditor;

		// Token: 0x04002D0E RID: 11534
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002D0E")]
		public NodeInfoPanel nodeInfoPanel;

		// Token: 0x04002D0F RID: 11535
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002D0F")]
		public AttributePanel attributePanel;

		// Token: 0x04002D10 RID: 11536
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002D10")]
		public EventNodeCanvas eventNodeCanvas;
	}
}
