using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel.EventNodes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GameLevel
{
	// Token: 0x02000B16 RID: 2838
	[Token(Token = "0x2000B16")]
	public class CustomMenuPage_event : CustomMenu_page
	{
		// Token: 0x06003B42 RID: 15170 RVA: 0x00136B94 File Offset: 0x00134D94
		[Token(Token = "0x6003B42")]
		[Address(RVA = "0x7A2860", Offset = "0x7A0E60", VA = "0x1807A2860", Slot = "4")]
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

		// Token: 0x06003B43 RID: 15171 RVA: 0x00136BF0 File Offset: 0x00134DF0
		[Token(Token = "0x6003B43")]
		[Address(RVA = "0x7A24B0", Offset = "0x7A0AB0", VA = "0x1807A24B0")]
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

		// Token: 0x06003B44 RID: 15172 RVA: 0x00136CC8 File Offset: 0x00134EC8
		[Token(Token = "0x6003B44")]
		[Address(RVA = "0x7A2970", Offset = "0x7A0F70", VA = "0x1807A2970", Slot = "6")]
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

		// Token: 0x06003B45 RID: 15173 RVA: 0x00136D5C File Offset: 0x00134F5C
		[Token(Token = "0x6003B45")]
		[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
		public CustomMenuPage_event()
		{
		}

		// Token: 0x04002B96 RID: 11158
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002B96")]
		[Header("节点编辑器")]
		public GameObject contextMenuPrefab;

		// Token: 0x04002B97 RID: 11159
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002B97")]
		public Toggle nodeInfoToggle;

		// Token: 0x04002B98 RID: 11160
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002B98")]
		public Toggle attributeToggle;

		// Token: 0x04002B99 RID: 11161
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002B99")]
		public RuntimeEventNodeEditor nodeEditor;

		// Token: 0x04002B9A RID: 11162
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002B9A")]
		public NodeInfoPanel nodeInfoPanel;

		// Token: 0x04002B9B RID: 11163
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002B9B")]
		public AttributePanel attributePanel;

		// Token: 0x04002B9C RID: 11164
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002B9C")]
		public EventNodeCanvas eventNodeCanvas;
	}
}
