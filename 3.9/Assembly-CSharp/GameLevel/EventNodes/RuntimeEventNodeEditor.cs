using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C25 RID: 3109
	[Token(Token = "0x2000C25")]
	public class RuntimeEventNodeEditor : MonoBehaviour
	{
		// Token: 0x06004098 RID: 16536 RVA: 0x00153FC0 File Offset: 0x001521C0
		[Token(Token = "0x6004098")]
		[Address(RVA = "0x880D30", Offset = "0x87F330", VA = "0x180880D30")]
		private void Awake()
		{
			RuntimeEventNodeEditor.Instance = this;
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06004099 RID: 16537 RVA: 0x00153FD4 File Offset: 0x001521D4
		// (set) Token: 0x0600409A RID: 16538 RVA: 0x00153FEC File Offset: 0x001521EC
		[Token(Token = "0x170004FB")]
		public Bounds WorldBounds
		{
			[Token(Token = "0x6004099")]
			[Address(RVA = "0x887A70", Offset = "0x886070", VA = "0x180887A70")]
			[CompilerGenerated]
			get
			{
				return default(Bounds);
			}
			[Token(Token = "0x600409A")]
			[Address(RVA = "0x887A90", Offset = "0x886090", VA = "0x180887A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600409B RID: 16539 RVA: 0x00153FFC File Offset: 0x001521FC
		[Token(Token = "0x600409B")]
		[Address(RVA = "0x885210", Offset = "0x883810", VA = "0x180885210")]
		private void OnEnable()
		{
			if (base.transform != 0)
			{
			}
		}

		// Token: 0x0600409C RID: 16540 RVA: 0x00154014 File Offset: 0x00152214
		[Token(Token = "0x600409C")]
		[Address(RVA = "0x887300", Offset = "0x885900", VA = "0x180887300")]
		private void Update()
		{
			ulong num5;
			do
			{
				if (Input.GetKeyDownInt((KeyCode)((uint)127)))
				{
					List<RuntimeNodeUI> list = Enumerable.ToList<RuntimeNodeUI>(this.selectedNodes);
					bool flag;
					if (flag)
					{
					}
					ulong num;
					if (num != (ulong)0L)
					{
						goto IL_00DD;
					}
				}
				if (Input.GetKeyInt((KeyCode)((uint)306)) || Input.GetKeyInt((KeyCode)((uint)305)))
				{
					if (!Input.GetKeyDownInt((KeyCode)((uint)99)))
					{
						if (!Input.GetKeyDownInt((KeyCode)((uint)118)))
						{
							goto IL_006A;
						}
						this.PasteNodes();
					}
					this.CopySelectedNodes();
				}
				IL_006A:
				ConnectionLine connectionLine = this.tempConnectionLine;
				int num2 = 0;
				if (connectionLine != num2 && this.draggingPort.nodeId != (ulong)0L)
				{
					this.tempConnectionLine.OnUpdate();
				}
				List<ConnectionLine> list2 = this.connectionLines;
				bool flag2;
				if (flag2)
				{
				}
				ulong num3;
				if (num3 != (ulong)0L)
				{
					goto IL_00E3;
				}
				bool flag3;
				bool flag4;
				if (flag3 && flag4)
				{
					int num4 = 0;
					GameObject gameObject;
					gameObject.SetActive(num4 != 0);
				}
			}
			while (num5 != (ulong)0L);
			return;
			IL_00DD:
			throw new NullReferenceException();
			IL_00E3:
			throw new NullReferenceException();
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x00154128 File Offset: 0x00152328
		[Token(Token = "0x600409D")]
		[Address(RVA = "0x8847C0", Offset = "0x882DC0", VA = "0x1808847C0")]
		public void Initialize(EventNodeGraph nodeGraph)
		{
			this.graph = nodeGraph;
			AttributePanel attributePanel = this.attributePanel;
			EventNodeGraph eventNodeGraph = this.graph;
			attributePanel.SetGraph(eventNodeGraph);
			this.canvas.editor = this;
			TMP_InputField tmp_InputField = this.nodeIdSearchInput;
			int num = 0;
			if (!(tmp_InputField != num))
			{
				EventNodeDebug.LogWarning("[RuntimeEventNodeEditor] 节点搜索输入框未设置");
			}
			this.nodeIdSearchInput.m_OnValueChanged.RemoveAllListeners();
			this.nodeIdSearchInput.m_OnEndEdit.RemoveAllListeners();
			UnityAction<string> unityAction;
			this.nodeIdSearchInput.m_OnEndEdit.AddListener(unityAction);
			EventNodeDebug.Log("[RuntimeEventNodeEditor] 节点搜索输入框已设置");
			this.ClearEditor();
			this.LoadGraph();
			EventNodeDebug.Log("[RuntimeEventNodeEditor] 加载现有节点图");
		}

		// Token: 0x0600409E RID: 16542 RVA: 0x001541D4 File Offset: 0x001523D4
		[Token(Token = "0x600409E")]
		[Address(RVA = "0x886700", Offset = "0x884D00", VA = "0x180886700")]
		private void SetupNodeIdSearchInput()
		{
			TMP_InputField tmp_InputField = this.nodeIdSearchInput;
			int num = 0;
			if (!(tmp_InputField != num))
			{
				EventNodeDebug.LogWarning("[RuntimeEventNodeEditor] 节点搜索输入框未设置");
				return;
			}
			this.nodeIdSearchInput.m_OnValueChanged.RemoveAllListeners();
			this.nodeIdSearchInput.m_OnEndEdit.RemoveAllListeners();
			UnityAction<string> unityAction;
			this.nodeIdSearchInput.m_OnEndEdit.AddListener(unityAction);
			EventNodeDebug.Log("[RuntimeEventNodeEditor] 节点搜索输入框已设置");
		}

		// Token: 0x0600409F RID: 16543 RVA: 0x00154244 File Offset: 0x00152444
		[Token(Token = "0x600409F")]
		[Address(RVA = "0x880D90", Offset = "0x87F390", VA = "0x180880D90")]
		private void ClearEditor()
		{
			int num4;
			ulong num6;
			do
			{
				int num = 0;
				Dictionary<string, RuntimeNodeUI>.ValueCollection values = this.nodeUIs.Values;
				bool flag;
				if (flag)
				{
					int num2 = 0;
					if (!(num != num2))
					{
						continue;
					}
					GameObject gameObject;
					global::UnityEngine.Object.Destroy(gameObject);
				}
				ulong num3;
				if (num3 != (ulong)0L)
				{
					goto IL_0069;
				}
				bool flag2;
				if (flag2)
				{
					num4 = 0;
					int num5 = 0;
					if (!(num != num5))
					{
						continue;
					}
					GameObject gameObject2;
					global::UnityEngine.Object.Destroy(gameObject2);
				}
			}
			while (num6 != (ulong)0L);
			if (num4 > 0)
			{
			}
			return;
			IL_0069:
			throw new NullReferenceException();
		}

		// Token: 0x060040A0 RID: 16544 RVA: 0x001542C0 File Offset: 0x001524C0
		[Token(Token = "0x60040A0")]
		[Address(RVA = "0x884EB0", Offset = "0x8834B0", VA = "0x180884EB0")]
		private void LoadGraph()
		{
			for (;;)
			{
				int num = 0;
				if (this.graph == num)
				{
					break;
				}
				List<EventNodeBase> nodes = this.graph.nodes;
				bool flag;
				if (flag)
				{
					RuntimeNodeUI runtimeNodeUI = this.CreateNodeUI(num);
				}
				ulong num2;
				if (num2 == (ulong)0L)
				{
					bool flag2;
					if (flag2)
					{
						bool flag3;
						if (flag3)
						{
						}
						ulong num3;
						if (num3 != (ulong)0L)
						{
							continue;
						}
					}
					NodeGroupUI nodeGroupUI;
					CancellationTokenSource cancellationTokenSource = nodeGroupUI.m_CancellationTokenSource;
					bool flag4;
					if (flag4)
					{
					}
					ulong num4;
					if (num4 == (ulong)0L)
					{
						break;
					}
				}
			}
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x00154324 File Offset: 0x00152524
		[Token(Token = "0x60040A1")]
		[Address(RVA = "0x8822C0", Offset = "0x8808C0", VA = "0x1808822C0")]
		private NodeGroupUI CreateGroupUI(NodeGroup group)
		{
			ulong num3;
			do
			{
				int num = 0;
				GameObject gameObject = this.groupPrefab;
				int num2 = 0;
				if (gameObject == num2)
				{
					goto IL_007D;
				}
				GameObject gameObject2 = this.groupPrefab;
				RectTransform rectTransform = this.groupContainer;
				GameObject gameObject3 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject2, rectTransform);
				bool flag;
				if (!flag)
				{
					NodeGroupUI nodeGroupUI = gameObject3.AddComponent<NodeGroupUI>();
				}
				Dictionary<string, NodeGroupUI> dictionary = this.groupUIs;
				List<string> nodeIds = group.nodeIds;
				bool flag2;
				if (flag2)
				{
					if (!this.nodeUIs.TryGetValue(num, num))
					{
						continue;
					}
					num += 160;
				}
			}
			while (num3 != (ulong)0L);
			string text;
			EventNodeDebug.Log(text);
			IL_007D:
			EventNodeDebug.LogError("[RuntimeEventNodeEditor] 分组预制体未设置");
			throw new NullReferenceException();
		}

		// Token: 0x060040A2 RID: 16546 RVA: 0x001543C8 File Offset: 0x001525C8
		[Token(Token = "0x60040A2")]
		[Address(RVA = "0x882CA0", Offset = "0x8812A0", VA = "0x180882CA0")]
		private RuntimeNodeUI CreateNodeUI(EventNodeBase node)
		{
			GameObject gameObject = this.nodePrefab;
			int num = 0;
			if (!(gameObject == num))
			{
				GameObject gameObject2 = this.nodePrefab;
				RectTransform rectTransform = this.nodeContainer;
				GameObject gameObject3 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject2, rectTransform);
				bool flag;
				if (!flag)
				{
					RuntimeNodeUI runtimeNodeUI = gameObject3.AddComponent<RuntimeNodeUI>();
				}
				Dictionary<string, RuntimeNodeUI> dictionary = this.nodeUIs;
			}
			EventNodeDebug.LogError("节点预制体未设置！");
			throw new NullReferenceException();
		}

		// Token: 0x060040A3 RID: 16547 RVA: 0x0015442C File Offset: 0x0015262C
		[Token(Token = "0x60040A3")]
		[Address(RVA = "0x8820F0", Offset = "0x8806F0", VA = "0x1808820F0")]
		private void CreateConnectionUI(NodeConnection connection)
		{
			string targetNodeId = connection.targetNodeId;
			string sourceNodeId = connection.sourceNodeId;
			GameObject gameObject = new GameObject("Connection_" + sourceNodeId + "_" + targetNodeId);
			Transform transform = gameObject.transform;
			RectTransform rectTransform = this.connectionContainer;
			int num = 0;
			transform.SetParent(rectTransform, num != 0);
			CanvasRenderer canvasRenderer = gameObject.AddComponent<CanvasRenderer>();
			RectTransform rectTransform2 = gameObject.AddComponent<RectTransform>();
			ConnectionLine connectionLine = gameObject.AddComponent<ConnectionLine>();
			connectionLine.Initialize(connection, this);
			List<ConnectionLine> list = this.connectionLines;
			int size = list._size;
			bool maskable = connectionLine.m_Maskable;
		}

		// Token: 0x060040A4 RID: 16548 RVA: 0x001544C8 File Offset: 0x001526C8
		[Token(Token = "0x60040A4")]
		[Address(RVA = "0x880BC0", Offset = "0x87F1C0", VA = "0x180880BC0")]
		public RuntimeNodeUI AddNode(string nodeType, Vector2 position)
		{
			EventNodeBase eventNodeBase = NodeTypeRegistry.CreateNode(nodeType);
			if (eventNodeBase != 0)
			{
				EventNodeDebug.Log("创建了节点：" + nodeType);
				eventNodeBase.position = position;
				eventNodeBase.position.y = (float)0;
				List<EventNodeBase> nodes = this.graph.nodes;
				return this.CreateNodeUI(eventNodeBase);
			}
			EventNodeDebug.LogError("无法创建节点类型: " + nodeType);
			throw new NullReferenceException();
		}

		// Token: 0x060040A5 RID: 16549 RVA: 0x00154530 File Offset: 0x00152730
		[Token(Token = "0x60040A5")]
		[Address(RVA = "0x883630", Offset = "0x881C30", VA = "0x180883630")]
		public void DeleteNode(string nodeId)
		{
			int num;
			RuntimeEventNodeEditor.<>c__DisplayClass39_0 CS$<>8__locals1;
			do
			{
				num = 0;
				CS$<>8__locals1.nodeId = nodeId;
				List<string> list = new List();
				List<NodeConnection> connections = this.graph.connections;
				bool flag;
				if (flag && !flag)
				{
					while (!flag)
					{
					}
				}
			}
			while (num != 0);
			string nodeId2 = CS$<>8__locals1.nodeId;
			bool flag2;
			if (flag2)
			{
			}
			string nodeId3 = CS$<>8__locals1.nodeId;
			string nodeId4 = CS$<>8__locals1.nodeId;
			int num2 = 0;
			if (num != num2)
			{
				if (num2 != 0)
				{
					string nodeId5 = CS$<>8__locals1.nodeId;
				}
				GameObject gameObject;
				global::UnityEngine.Object.Destroy(gameObject);
				string nodeId6 = CS$<>8__locals1.nodeId;
			}
			int num3 = 0;
			if (num != num3)
			{
				int num4 = 0;
				int num5;
				if (num5 == 0)
				{
					EventNodeDebug.Log("[RuntimeEventNodeEditor] 分组 " + num4 + " 已清空，自动删除");
				}
			}
		}

		// Token: 0x060040A6 RID: 16550 RVA: 0x00154600 File Offset: 0x00152800
		[Token(Token = "0x60040A6")]
		[Address(RVA = "0x883220", Offset = "0x881820", VA = "0x180883220")]
		public void DeleteNodeConnections(string nodeId)
		{
			List<NodeConnection> list;
			ulong num3;
			do
			{
				int num = 0;
				list = new List();
				List<NodeConnection> connections = this.graph.connections;
				bool flag;
				if (flag && !flag)
				{
					while (!flag)
					{
					}
				}
				ulong num2;
				if (num2 != (ulong)0L)
				{
					goto IL_008F;
				}
				bool flag2;
				if (flag2)
				{
					RuntimeEventNodeEditor.<>c__DisplayClass40_0 CS$<>8__locals1;
					CS$<>8__locals1.conn = num;
					NodeConnection conn = CS$<>8__locals1.conn;
					string sourceNodeId = conn.sourceNodeId;
					string sourcePortName = conn.sourcePortName;
					string targetNodeId = conn.targetNodeId;
					string targetPortName = conn.targetPortName;
				}
			}
			while (num3 != (ulong)0L);
			int size = list._size;
			string text;
			EventNodeDebug.Log(text);
			return;
			IL_008F:
			throw new NullReferenceException();
		}

		// Token: 0x060040A7 RID: 16551 RVA: 0x001546B4 File Offset: 0x001528B4
		[Token(Token = "0x60040A7")]
		[Address(RVA = "0x886AE0", Offset = "0x8850E0", VA = "0x180886AE0")]
		public void StartPortDrag(RuntimeNodeUI nodeUI, PortDefinition port, bool isInput)
		{
			RuntimeEventNodeEditor.PortData portData = new RuntimeEventNodeEditor.PortData();
			string nodeId = nodeUI.<Node>k__BackingField.nodeId;
			portData.nodeId = nodeId;
			string portName = port.portName;
			portData.portName = portName;
			PortType portType = port.portType;
			portData.portType = portType;
			portData.isInput = isInput;
			portData.nodeUI = nodeUI;
			this.draggingPort = portData;
			this.CreateTempConnectionLine();
			string portName2 = port.portName;
			EventNodeDebug.Log("开始拖拽端口: " + portName2);
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x00154730 File Offset: 0x00152930
		[Token(Token = "0x60040A8")]
		[Address(RVA = "0x882E60", Offset = "0x881460", VA = "0x180882E60")]
		private void CreateTempConnectionLine()
		{
			ConnectionLine connectionLine = this.tempConnectionLine;
			int num = 0;
			if (connectionLine != num)
			{
				global::UnityEngine.Object.Destroy(this.tempConnectionLine.gameObject);
			}
			GameObject gameObject = new GameObject("TempConnectionLine");
			Transform transform = gameObject.transform;
			RectTransform rectTransform = this.connectionContainer;
			int num2 = 0;
			transform.SetParent(rectTransform, num2 != 0);
			CanvasRenderer canvasRenderer = gameObject.AddComponent<CanvasRenderer>();
			RectTransform rectTransform2 = gameObject.AddComponent<RectTransform>();
			ConnectionLine connectionLine2 = gameObject.AddComponent<ConnectionLine>();
			this.tempConnectionLine = connectionLine2;
			this.tempConnectionLine.<Editor>k__BackingField = this;
			this.tempConnectionLine.<IsTempLine>k__BackingField = true;
			ConnectionLine connectionLine3 = this.tempConnectionLine;
			int num3 = 0;
			connectionLine3.raycastTarget = num3 != 0;
			RuntimeEventNodeEditor.PortData portData = this.draggingPort;
			Dictionary<string, RuntimeNodeUI> dictionary = this.nodeUIs;
			string nodeId = portData.nodeId;
			RuntimeNodeUI runtimeNodeUI = dictionary[nodeId];
			int num4 = 0;
			if (runtimeNodeUI != num4)
			{
				RuntimeEventNodeEditor.PortData portData2 = this.draggingPort;
				bool isInput = portData2.isInput;
				string portName = portData2.portName;
				RuntimePortUI portUI = runtimeNodeUI.GetPortUI(portName, isInput);
				this.tempConnectionLine.sourcePortUI = portUI;
			}
			this.tempConnectionLine.OnUpdate();
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x0015484C File Offset: 0x00152A4C
		[Token(Token = "0x60040A9")]
		[Address(RVA = "0x883DD0", Offset = "0x8823D0", VA = "0x180883DD0")]
		public void DestroyTempConnectionLine()
		{
			ConnectionLine connectionLine = this.tempConnectionLine;
			int num = 0;
			if (connectionLine != num)
			{
				global::UnityEngine.Object.Destroy(this.tempConnectionLine.gameObject);
				this.tempConnectionLine = (ulong)0L;
			}
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x0015488C File Offset: 0x00152A8C
		[Token(Token = "0x60040AA")]
		[Address(RVA = "0x883E80", Offset = "0x882480", VA = "0x180883E80")]
		public void EndPortDrop(RuntimeNodeUI targetNodeUI, PortDefinition targetPort, bool isInput)
		{
			RuntimeEventNodeEditor.PortData portData;
			int num3;
			do
			{
				int num = 0;
				this.DestroyTempConnectionLine();
				portData = this.draggingPort;
				if (portData.nodeId == (ulong)0L)
				{
					return;
				}
				if (portData.portType != targetPort.portType)
				{
					goto IL_0128;
				}
				if (portData.isInput == isInput)
				{
					break;
				}
				if (portData.isInput)
				{
					string nodeId = targetNodeUI.<Node>k__BackingField.nodeId;
					string portName = targetPort.portName;
					RuntimeEventNodeEditor.PortData portData2 = this.draggingPort;
				}
				string nodeId2 = portData.nodeId;
				string portName2 = portData.portName;
				string nodeId3 = targetNodeUI.<Node>k__BackingField.nodeId;
				if (this.draggingPort.isInput)
				{
					RuntimeEventNodeEditor.PortData portData3 = this.draggingPort;
				}
				string portName3 = targetPort.portName;
				List<NodeConnection> list = new List();
				List<NodeConnection> connections = this.graph.connections;
				int num2 = 0;
				bool flag;
				if (flag)
				{
					while (!flag)
					{
					}
					while (!flag)
					{
					}
				}
				if (num2 != 0)
				{
					goto IL_0150;
				}
				num3 = 0;
				bool flag2;
				if (flag2)
				{
					RuntimeEventNodeEditor.<>c__DisplayClass44_0 CS$<>8__locals1;
					CS$<>8__locals1.oldConn = num;
					NodeConnection oldConn = CS$<>8__locals1.oldConn;
					string sourceNodeId = oldConn.sourceNodeId;
					string sourcePortName = oldConn.sourcePortName;
					string targetNodeId = oldConn.targetNodeId;
					string targetPortName = oldConn.targetPortName;
					Predicate<ConnectionLine> predicate;
					int num4 = list.RemoveAll(predicate);
				}
			}
			while (num3 != 0);
			EventNodeDebug.LogError("不能连接相同方向的端口！");
			return;
			IL_0128:
			PortType portType = targetPort.portType;
			string text = string.Format("端口类型不兼容！{0} → {1}", portData, portData);
			throw new NullReferenceException();
			IL_0150:
			throw new NullReferenceException();
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x00154A04 File Offset: 0x00152C04
		[Token(Token = "0x60040AB")]
		[Address(RVA = "0x887180", Offset = "0x885780", VA = "0x180887180")]
		public void UpdateConnectionPositions()
		{
			ulong num;
			do
			{
				List<ConnectionLine> list = this.connectionLines;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x00154A30 File Offset: 0x00152C30
		[Token(Token = "0x60040AC")]
		[Address(RVA = "0x886E50", Offset = "0x885450", VA = "0x180886E50")]
		public void UpdateConnectionPositionsForNode(string nodeId)
		{
			ulong num;
			do
			{
				List<ConnectionLine> list = this.connectionLines;
				bool flag;
				if (flag && !flag)
				{
					while (!flag)
					{
					}
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x00154A74 File Offset: 0x00152C74
		[Token(Token = "0x60040AD")]
		[Address(RVA = "0x886FD0", Offset = "0x8855D0", VA = "0x180886FD0")]
		public void UpdateConnectionPositionsForNodes(HashSet<string> nodeIds)
		{
			ulong num;
			do
			{
				List<ConnectionLine> list = this.connectionLines;
				bool flag;
				bool flag2;
				if (flag && !flag2)
				{
					bool flag3;
					while (!flag3)
					{
					}
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x00154ABC File Offset: 0x00152CBC
		[Token(Token = "0x60040AE")]
		[Address(RVA = "0x882B40", Offset = "0x881140", VA = "0x180882B40")]
		public void CreateNodeByType(string nodeTypeName, Vector2 position)
		{
			EventNodeBase eventNodeBase = NodeTypeRegistry.CreateNode(nodeTypeName);
			if (eventNodeBase != 0)
			{
				EventNodeDebug.Log("创建了节点：" + nodeTypeName);
				eventNodeBase.position = position;
				eventNodeBase.position.y = (float)0;
				List<EventNodeBase> nodes = this.graph.nodes;
				RuntimeNodeUI runtimeNodeUI = this.CreateNodeUI(eventNodeBase);
				return;
			}
			EventNodeDebug.LogError("无法创建节点类型: " + nodeTypeName);
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x00154B24 File Offset: 0x00152D24
		[Token(Token = "0x60040AF")]
		[Address(RVA = "0x884630", Offset = "0x882C30", VA = "0x180884630")]
		public RuntimeNodeUI GetNodeUI(string nodeId)
		{
			Dictionary<string, RuntimeNodeUI> dictionary = this.nodeUIs;
			int num = 0;
			bool flag = dictionary.TryGetValue(nodeId, num);
			throw new NullReferenceException();
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x00154B4C File Offset: 0x00152D4C
		[Token(Token = "0x60040B0")]
		[Address(RVA = "0x880D20", Offset = "0x87F320", VA = "0x180880D20")]
		private bool ArePortTypesCompatible(PortType sourceType, PortType targetType)
		{
			return sourceType == targetType;
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x00154B60 File Offset: 0x00152D60
		[Token(Token = "0x60040B1")]
		[Address(RVA = "0x8868A0", Offset = "0x884EA0", VA = "0x1808868A0")]
		public void ShowContextMenuForPort(RuntimeNodeUI sourceNodeUI, PortDefinition sourcePort, bool isInput, Vector2 dragEndScreenPosition)
		{
			EventNodeContextMenu <Instance>k__BackingField = EventNodeContextMenu.<Instance>k__BackingField;
			int num = 0;
			if (!(<Instance>k__BackingField == num))
			{
				RectTransform menuPanel = EventNodeContextMenu.<Instance>k__BackingField.menuPanel;
				int num2 = 0;
				if (menuPanel != num2)
				{
					Transform parent = EventNodeContextMenu.<Instance>k__BackingField.menuPanel.parent;
					if (parent != 0 && parent != 0)
					{
						Camera main = Camera.main;
						bool flag;
						if (flag)
						{
						}
					}
				}
			}
		}

		// Token: 0x060040B2 RID: 16562 RVA: 0x00154BCC File Offset: 0x00152DCC
		[Token(Token = "0x60040B2")]
		[Address(RVA = "0x881360", Offset = "0x87F960", VA = "0x180881360")]
		public void ConnectNodes(RuntimeNodeUI sourceNodeUI, PortDefinition sourcePort, RuntimeNodeUI targetNodeUI, PortDefinition targetPort)
		{
			ulong num4;
			do
			{
				int num = 0;
				PortType portType = sourcePort.portType;
				List<NodeConnection> list = new List();
				List<NodeConnection> connections = this.graph.connections;
				bool flag;
				if (flag)
				{
					EventNodeBase <Node>k__BackingField = targetNodeUI.<Node>k__BackingField;
					while (!flag)
					{
					}
					while (!flag)
					{
					}
				}
				ulong num2;
				if (num2 != (ulong)0L)
				{
					goto IL_0142;
				}
				bool flag2;
				if (flag2)
				{
					RuntimeEventNodeEditor.<>c__DisplayClass53_0 CS$<>8__locals1;
					CS$<>8__locals1.oldConn = num;
					NodeConnection oldConn = CS$<>8__locals1.oldConn;
					string sourceNodeId = oldConn.sourceNodeId;
					string sourcePortName = oldConn.sourcePortName;
					string targetNodeId = oldConn.targetNodeId;
					string targetPortName = oldConn.targetPortName;
					Predicate<ConnectionLine> predicate;
					int num3 = list.RemoveAll(predicate);
				}
			}
			while (num4 != (ulong)0L);
			string text = string.Concat(new string[] { "连接节点: ", "连接节点: ", ".", ".", " → ", " → ", ".", "." });
			EventNodeDebug.Log(text);
			return;
			IL_0142:
			throw new NullReferenceException();
		}

		// Token: 0x060040B3 RID: 16563 RVA: 0x00154D34 File Offset: 0x00152F34
		[Token(Token = "0x60040B3")]
		[Address(RVA = "0x884520", Offset = "0x882B20", VA = "0x180884520")]
		public RuntimeNodeUI GetLatestNodeUI()
		{
			List<EventNodeBase> nodes = this.graph.nodes;
			int size = nodes._size;
			string nodeId = nodes[size].nodeId;
			Dictionary<string, RuntimeNodeUI> dictionary = this.nodeUIs;
			int num = 0;
			bool flag = dictionary.TryGetValue(nodeId, num);
			throw new NullReferenceException();
		}

		// Token: 0x060040B4 RID: 16564 RVA: 0x00154D80 File Offset: 0x00152F80
		[Token(Token = "0x60040B4")]
		[Address(RVA = "0x886530", Offset = "0x884B30", VA = "0x180886530")]
		public void SelectNode(RuntimeNodeUI nodeUI, bool addToSelection = false)
		{
			int num = 0;
			if (!(nodeUI == num))
			{
				if (!addToSelection)
				{
					this.DeselectAllNodes();
				}
				if (!nodeUI.isSelected)
				{
					nodeUI.IsSelected = true;
					List<RuntimeNodeUI> list = this.selectedNodes;
					string nodeName = nodeUI.<Node>k__BackingField.nodeName;
					int size = this.selectedNodes._size;
					EventNodeDebug.Log(string.Format("[RuntimeEventNodeEditor] 选中节点: {0}，当前选中数量: {1}", nodeName, size));
				}
				if (!addToSelection)
				{
					this.nodeInfoPanel.ShowNodeInfo(num);
					throw new NullReferenceException();
				}
				List<RuntimeNodeUI> list2 = this.selectedNodes;
				this.nodeInfoPanel.HidePanel();
			}
		}

		// Token: 0x060040B5 RID: 16565 RVA: 0x00154E10 File Offset: 0x00153010
		[Token(Token = "0x60040B5")]
		[Address(RVA = "0x886C30", Offset = "0x885230", VA = "0x180886C30")]
		public void ToggleNodeSelection(RuntimeNodeUI nodeUI)
		{
			int num = 0;
			if (!(nodeUI == num))
			{
				int num2 = 0;
				if ((nodeUI.isSelected ? 1 : 0) != num2)
				{
					int num3 = 0;
					nodeUI.IsSelected = num3 != 0;
					List<RuntimeNodeUI> list = this.selectedNodes;
					int size = this.selectedNodes._size;
					throw new NullReferenceException();
				}
				nodeUI.IsSelected = true;
				List<RuntimeNodeUI> list2 = this.selectedNodes;
				string nodeName = nodeUI.<Node>k__BackingField.nodeName;
				int size2 = this.selectedNodes._size;
				EventNodeDebug.Log(string.Format("[RuntimeEventNodeEditor] 选中节点: {0}，当前选中数量: {1}", nodeName, size2));
			}
		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x00154E94 File Offset: 0x00153094
		[Token(Token = "0x60040B6")]
		[Address(RVA = "0x883BB0", Offset = "0x8821B0", VA = "0x180883BB0")]
		public void DeselectAllNodes()
		{
			ulong num3;
			do
			{
				int num = 0;
				List<RuntimeNodeUI> list = this.selectedNodes;
				bool flag;
				if (flag)
				{
					int num2 = 0;
					if (!(num != num2))
					{
						continue;
					}
				}
			}
			while (num3 != (ulong)0L);
			EventNodeDebug.Log("[RuntimeEventNodeEditor] 清除所有选中节点");
		}

		// Token: 0x060040B7 RID: 16567 RVA: 0x00154EE0 File Offset: 0x001530E0
		[Token(Token = "0x60040B7")]
		[Address(RVA = "0x8846B0", Offset = "0x882CB0", VA = "0x1808846B0")]
		public List<RuntimeNodeUI> GetSelectedNodes()
		{
			return new List(this.selectedNodes);
		}

		// Token: 0x060040B8 RID: 16568 RVA: 0x00154EF8 File Offset: 0x001530F8
		[Token(Token = "0x60040B8")]
		[Address(RVA = "0x8844B0", Offset = "0x882AB0", VA = "0x1808844B0")]
		public RuntimeNodeUI GetFirstSelectedNode()
		{
			List<RuntimeNodeUI> list = this.selectedNodes;
			int num = 0;
			return list[num];
		}

		// Token: 0x060040B9 RID: 16569 RVA: 0x00154F20 File Offset: 0x00153120
		[Token(Token = "0x60040B9")]
		[Address(RVA = "0x884770", Offset = "0x882D70", VA = "0x180884770")]
		public bool HasSelectedNodes()
		{
			List<RuntimeNodeUI> list = this.selectedNodes;
			bool flag;
			return flag;
		}

		// Token: 0x060040BA RID: 16570 RVA: 0x00154F40 File Offset: 0x00153140
		[Token(Token = "0x60040BA")]
		[Address(RVA = "0x884720", Offset = "0x882D20", VA = "0x180884720")]
		public bool HasClipboardContent()
		{
			if (this.clipboardNodes == (ulong)0L)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060040BB RID: 16571 RVA: 0x00154F60 File Offset: 0x00153160
		[Token(Token = "0x60040BB")]
		[Address(RVA = "0x881A50", Offset = "0x880050", VA = "0x180881A50")]
		public void CopySelectedNodes()
		{
			int num2;
			string text;
			do
			{
				List<RuntimeNodeUI> list = this.selectedNodes;
				List<EventNodeBase> list2 = this.clipboardNodes;
				int size = list2._size;
				int num = 0;
				list2._size = num;
				if (size > 0)
				{
				}
				List<NodeConnection> list3 = this.clipboardConnections;
				int size2 = list3._size;
				list3._size = num;
				if (size2 > 0)
				{
				}
				HashSet<string> hashSet = new HashSet();
				List<RuntimeNodeUI> list4 = this.selectedNodes;
				bool flag;
				if (flag)
				{
					List<EventNodeBase> list5 = this.clipboardNodes;
				}
				if (num != 0)
				{
					goto IL_0141;
				}
				num2 = 0;
				bool flag2;
				if (flag2)
				{
					bool flag3;
					while (!flag3)
					{
					}
					bool flag4;
					while (!flag4)
					{
					}
					text = string.Concat(new string[] { "[RuntimeEventNodeEditor] 复制连接: ", "[RuntimeEventNodeEditor] 复制连接: ", ".", ".", " -> ", " -> ", ".", "." });
					EventNodeDebug.Log(text);
				}
			}
			while (num2 != 0);
			EventNodeDebug.Log(string.Format("[RuntimeEventNodeEditor] 已复制 {0} 个节点和 {1} 条连接到剪贴板", text, text));
			return;
			IL_0141:
			throw new IndexOutOfRangeException();
		}

		// Token: 0x060040BC RID: 16572 RVA: 0x001550F8 File Offset: 0x001532F8
		[Token(Token = "0x60040BC")]
		[Address(RVA = "0x885300", Offset = "0x883900", VA = "0x180885300")]
		public void PasteNodes()
		{
			List<RuntimeNodeUI> list2;
			bool flag6;
			for (;;)
			{
				int num = 0;
				int num2 = 0;
				List<EventNodeBase> list = this.clipboardNodes;
				this.DeselectAllNodes();
				Dictionary<string, string> dictionary = new Dictionary();
				list2 = new List();
				List<EventNodeBase> list3 = this.clipboardNodes;
				bool flag;
				if (flag)
				{
					EventNodeBase eventNodeBase = this.CloneNode(num);
					if (eventNodeBase != 0)
					{
						List<EventNodeBase> nodes = this.graph.nodes;
						RuntimeNodeUI runtimeNodeUI = this.CreateNodeUI(eventNodeBase);
						Dictionary<string, RuntimeNodeUI> dictionary2 = this.nodeUIs;
						string nodeId = eventNodeBase.nodeId;
						if (dictionary2.TryGetValue(nodeId, num2))
						{
						}
						string nodeId2 = eventNodeBase.nodeId;
						dictionary[nodeId] = nodeId2;
						string[] array = new string[7];
						array[0] = "[RuntimeEventNodeEditor] 粘贴节点: ";
						string nodeName = eventNodeBase.nodeName;
						array[1] = nodeName;
						array[2] = " (原始ID: ";
						array[4] = " -> 新ID: ";
						string nodeId3 = eventNodeBase.nodeId;
						array[5] = nodeId3;
						array[6] = ")";
						EventNodeDebug.Log(string.Concat(array));
					}
					EventNodeDebug.LogError("[RuntimeEventNodeEditor] 粘贴节点失败: " + num);
				}
				if (num2 != 0)
				{
					goto IL_02D4;
				}
				int num3 = 0;
				bool flag2;
				string text;
				if (flag2)
				{
					bool flag3;
					bool flag4;
					if (flag3 && flag4)
					{
						EventNodeDebug.Log(string.Concat(new string[] { "[RuntimeEventNodeEditor] 重建连接: ", num2, ".", ".", " -> ", num2, ".", "." }));
					}
					text = string.Concat(new string[] { "[RuntimeEventNodeEditor] 无法重建连接: ", "[RuntimeEventNodeEditor] 无法重建连接: ", ".", ".", " -> ", " -> ", ".", ".", " (找不到映射)" });
					EventNodeDebug.LogWarning(text);
				}
				if (num3 != 0)
				{
					goto IL_035E;
				}
				int num4 = 0;
				int stringLength = text._stringLength;
				bool flag5;
				if (flag5)
				{
				}
				if (num4 == 0)
				{
					int num5 = 0;
					if (flag6)
					{
					}
					if (num5 == 0)
					{
						break;
					}
				}
			}
			int size = list2._size;
			EventNodeDebug.Log(string.Format("[RuntimeEventNodeEditor] 已粘贴 {0} 个节点和 {1} 条连接，并选中 {2} 个新节点", flag6, flag6, flag6));
			return;
			IL_02D4:
			throw new IndexOutOfRangeException();
			IL_035E:
			throw new NullReferenceException();
		}

		// Token: 0x060040BD RID: 16573 RVA: 0x0015546C File Offset: 0x0015366C
		[Token(Token = "0x60040BD")]
		[Address(RVA = "0x8810F0", Offset = "0x87F6F0", VA = "0x1808810F0")]
		private EventNodeBase CloneNode(EventNodeBase source)
		{
			if (source != 0)
			{
				int num = 0;
				string text = JsonUtility.ToJson(source);
				Type type = source.GetType();
				if (JsonUtility.FromJson(text, type) != 0)
				{
					Guid guid = Guid.NewGuid();
					string nodeType = source.nodeType;
					string nodeName = source.nodeName;
					if (num != 0 && num != 0)
					{
						EventNodeDebug.Log("[RuntimeEventNodeEditor] 变量节点克隆完成，保持Asset引用: " + num);
					}
				}
				string name = source.GetType().Name;
				EventNodeDebug.LogError("[RuntimeEventNodeEditor] 克隆节点失败: " + name);
			}
			throw new NullReferenceException();
		}

		// Token: 0x060040BE RID: 16574 RVA: 0x001554F0 File Offset: 0x001536F0
		[Token(Token = "0x60040BE")]
		[Address(RVA = "0x882680", Offset = "0x880C80", VA = "0x180882680")]
		public NodeGroupUI CreateGroup(List<RuntimeNodeUI> nodes, string title = "新分组")
		{
			NodeGroup nodeGroup;
			ulong num3;
			do
			{
				int num = 0;
				if (nodes == 0)
				{
					goto IL_00E7;
				}
				Func<RuntimeNodeUI, string> <>9__65_ = RuntimeEventNodeEditor.<>c.<>9__65_0;
				if (<>9__65_ == 0)
				{
					Func<RuntimeNodeUI, string> func;
					RuntimeEventNodeEditor.<>c.<>9__65_0 = func;
				}
				List<string> list = Enumerable.ToList<string>(Enumerable.Select<RuntimeNodeUI, string>(nodes, <>9__65_));
				nodeGroup = this.graph.CreateGroup(list, title);
				GameObject gameObject = this.groupPrefab;
				int num2 = 0;
				if (gameObject == num2)
				{
					goto IL_00DD;
				}
				GameObject gameObject2 = this.groupPrefab;
				RectTransform rectTransform = this.groupContainer;
				GameObject gameObject3 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject2, rectTransform);
				bool flag;
				NodeGroupUI nodeGroupUI;
				if (!flag)
				{
					nodeGroupUI = gameObject3.AddComponent<NodeGroupUI>();
				}
				nodeGroupUI.Initialize(nodeGroup, this);
				nodeGroupUI.UpdateBounds();
				Dictionary<string, NodeGroupUI> dictionary = this.groupUIs;
				string groupId = nodeGroup.groupId;
				dictionary[groupId] = nodeGroupUI;
				bool flag2;
				if (flag2)
				{
					num += 160;
				}
			}
			while (num3 != (ulong)0L);
			string title2 = nodeGroup.title;
			EventNodeDebug.Log(string.Format("[RuntimeEventNodeEditor] 创建分组UI: {0}, 包含 {1} 个节点", title2, nodeGroup));
			IL_00DD:
			EventNodeDebug.LogError("[RuntimeEventNodeEditor] 分组预制体未设置");
			IL_00E7:
			EventNodeDebug.LogWarning("[RuntimeEventNodeEditor] 创建分组失败：节点列表为空");
			throw new NullReferenceException();
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x001555F8 File Offset: 0x001537F8
		[Token(Token = "0x60040BF")]
		[Address(RVA = "0x8830D0", Offset = "0x8816D0", VA = "0x1808830D0")]
		public void DeleteGroup(string groupId)
		{
			Dictionary<string, NodeGroupUI> dictionary = this.groupUIs;
			bool flag;
			if (flag)
			{
				GameObject gameObject;
				global::UnityEngine.Object.Destroy(gameObject);
				bool flag2 = this.groupUIs.Remove(groupId);
				this.graph.RemoveGroup(groupId);
				EventNodeDebug.Log("[RuntimeEventNodeEditor] 删除分组: " + groupId);
			}
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x00155648 File Offset: 0x00153848
		[Token(Token = "0x60040C0")]
		[Address(RVA = "0x880A30", Offset = "0x87F030", VA = "0x180880A30")]
		public void AddNodeToGroup(RuntimeNodeUI nodeUI, NodeGroupUI groupUI)
		{
			int num = 0;
			if (!(nodeUI == num))
			{
				int num2 = 0;
				if (!(groupUI == num2))
				{
					this.RemoveNodeFromGroup(nodeUI);
					EventNodeBase <Node>k__BackingField = nodeUI.<Node>k__BackingField;
					NodeGroup group = groupUI.group;
					EventNodeGraph eventNodeGraph = this.graph;
					string groupId = group.groupId;
					string nodeId = <Node>k__BackingField.nodeId;
					eventNodeGraph.AddNodeToGroup(nodeId, groupId);
					groupUI.UpdateBounds();
					EventNodeBase <Node>k__BackingField2 = nodeUI.<Node>k__BackingField;
					string title = groupUI.group.title;
					string nodeName = <Node>k__BackingField2.nodeName;
					EventNodeDebug.Log("[RuntimeEventNodeEditor] 节点 " + nodeName + " 添加到分组 " + title);
				}
			}
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x001556EC File Offset: 0x001538EC
		[Token(Token = "0x60040C1")]
		[Address(RVA = "0x886080", Offset = "0x884680", VA = "0x180886080")]
		public void RemoveNodeFromGroup(RuntimeNodeUI nodeUI)
		{
			for (;;)
			{
				int num = 0;
				int num2 = 0;
				if (nodeUI == num2)
				{
					return;
				}
				EventNodeGraph eventNodeGraph = this.graph;
				string nodeId = nodeUI.<Node>k__BackingField.nodeId;
				eventNodeGraph.RemoveNodeFromGroup(nodeId);
				nodeUI.group = (ulong)0L;
				string nodeName = nodeUI.<Node>k__BackingField.nodeName;
				EventNodeDebug.Log("[RuntimeEventNodeEditor] 清除节点 " + nodeName + " 的分组引用");
				List<string> list = new List();
				Dictionary<string, NodeGroupUI>.ValueCollection values = this.groupUIs.Values;
				bool flag;
				if (flag)
				{
					int num3;
					while (num3 != 0)
					{
					}
				}
				ulong num4;
				if (num4 == (ulong)0L)
				{
					bool flag2;
					if (flag2)
					{
						EventNodeDebug.Log("[RuntimeEventNodeEditor] 分组 " + num + " 已清空，自动删除");
					}
					ulong num5;
					if (num5 == (ulong)0L)
					{
						break;
					}
				}
			}
			string text;
			EventNodeDebug.Log(text);
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x001557CC File Offset: 0x001539CC
		[Token(Token = "0x60040C2")]
		[Address(RVA = "0x887290", Offset = "0x885890", VA = "0x180887290")]
		public void UpdateGroupBounds(NodeGroupUI groupUI)
		{
			int num = 0;
			if (groupUI != num)
			{
				groupUI.UpdateBounds();
				return;
			}
		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x001557F4 File Offset: 0x001539F4
		[Token(Token = "0x60040C3")]
		[Address(RVA = "0x884610", Offset = "0x882C10", VA = "0x180884610")]
		public NodeGroupUI GetNodeGroup(RuntimeNodeUI nodeUI)
		{
			return nodeUI.group;
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x00155810 File Offset: 0x00153A10
		[Token(Token = "0x60040C4")]
		[Address(RVA = "0x884A00", Offset = "0x883000", VA = "0x180884A00")]
		public void JumpToNodeById(string nodeId)
		{
			if (string.IsNullOrEmpty(nodeId))
			{
				InGameText instance = InGameText.Instance;
				return;
			}
			Dictionary<string, RuntimeNodeUI> dictionary = this.nodeUIs;
			bool flag;
			if (!flag)
			{
				InGameText instance2 = InGameText.Instance;
				string text = "未找到节点ID: " + nodeId;
				return;
			}
		}

		// Token: 0x060040C5 RID: 16581 RVA: 0x0015585C File Offset: 0x00153A5C
		[Token(Token = "0x60040C5")]
		[Address(RVA = "0x884B50", Offset = "0x883150", VA = "0x180884B50")]
		public void JumpToNode(RuntimeNodeUI nodeUI)
		{
			int num = 0;
			if (!(nodeUI == num))
			{
				EventNodeCanvas eventNodeCanvas = this.canvas;
				int num2 = 0;
				if (!(eventNodeCanvas == num2))
				{
					RectTransform targetTransform = this.canvas.targetTransform;
					int num3 = 0;
					if (!(targetTransform == num3))
					{
						Vector2 anchoredPosition = nodeUI.rectTransform.anchoredPosition;
						RectTransform targetTransform2 = this.canvas.targetTransform;
						RectTransform targetTransform3 = this.canvas.targetTransform;
						int num4 = 0;
						this.SelectNode(nodeUI, num4 != 0);
						string[] array = new string[5];
						array[0] = "[RuntimeEventNodeEditor] 跳转到节点: ";
						string nodeName = nodeUI.<Node>k__BackingField.nodeName;
						array[1] = nodeName;
						array[2] = " (ID: ";
						string nodeId = nodeUI.<Node>k__BackingField.nodeId;
						array[3] = nodeId;
						array[4] = ")";
						EventNodeDebug.Log(string.Concat(array));
						return;
					}
				}
				EventNodeDebug.LogWarning("[RuntimeEventNodeEditor] 画布或目标Transform未设置，无法跳转");
				return;
			}
			InGameText instance = InGameText.Instance;
		}

		// Token: 0x060040C6 RID: 16582 RVA: 0x00155964 File Offset: 0x00153B64
		[Token(Token = "0x60040C6")]
		[Address(RVA = "0x8852B0", Offset = "0x8838B0", VA = "0x1808852B0")]
		public void OnNodeIdSearchInput(string nodeId)
		{
			this.JumpToNodeById(nodeId);
		}

		// Token: 0x060040C7 RID: 16583 RVA: 0x0015597C File Offset: 0x00153B7C
		[Token(Token = "0x60040C7")]
		[Address(RVA = "0x887830", Offset = "0x885E30", VA = "0x180887830")]
		public RuntimeEventNodeEditor()
		{
			Dictionary<string, RuntimeNodeUI> dictionary = new Dictionary();
			this.nodeUIs = dictionary;
			List<ConnectionLine> list = new List();
			this.connectionLines = list;
			List<RuntimeNodeUI> list2 = new List();
			this.selectedNodes = list2;
			Dictionary<RuntimeNodeUI, Vector2> dictionary2 = new Dictionary();
			this.draggedNodesInitialPositions = dictionary2;
			List<EventNodeBase> list3 = new List();
			this.clipboardNodes = list3;
			List<NodeConnection> list4 = new List();
			this.clipboardConnections = list4;
			Dictionary<string, NodeGroupUI> dictionary3 = new Dictionary();
			this.groupUIs = dictionary3;
			base..ctor();
		}

		// Token: 0x040031AA RID: 12714
		[Token(Token = "0x40031AA")]
		public static RuntimeEventNodeEditor Instance;

		// Token: 0x040031AB RID: 12715
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40031AB")]
		[Header("UI容器")]
		public RectTransform nodeContainer;

		// Token: 0x040031AC RID: 12716
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40031AC")]
		public RectTransform connectionContainer;

		// Token: 0x040031AD RID: 12717
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40031AD")]
		[Header("其他面板")]
		public NodeInfoPanel nodeInfoPanel;

		// Token: 0x040031AE RID: 12718
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40031AE")]
		public AttributePanel attributePanel;

		// Token: 0x040031AF RID: 12719
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40031AF")]
		public EventNodeCanvas canvas;

		// Token: 0x040031B0 RID: 12720
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40031B0")]
		[Header("节点搜索")]
		public TMP_InputField nodeIdSearchInput;

		// Token: 0x040031B1 RID: 12721
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40031B1")]
		[Header("预制体")]
		public GameObject nodePrefab;

		// Token: 0x040031B2 RID: 12722
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40031B2")]
		public GameObject portPrefab;

		// Token: 0x040031B3 RID: 12723
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40031B3")]
		[Header("数据")]
		public EventNodeGraph graph;

		// Token: 0x040031B4 RID: 12724
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40031B4")]
		public Dictionary<string, RuntimeNodeUI> nodeUIs;

		// Token: 0x040031B5 RID: 12725
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40031B5")]
		public readonly List<ConnectionLine> connectionLines;

		// Token: 0x040031B6 RID: 12726
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40031B6")]
		private ConnectionLine tempConnectionLine;

		// Token: 0x040031B7 RID: 12727
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40031B7")]
		private RuntimeEventNodeEditor.PortData draggingPort;

		// Token: 0x040031B8 RID: 12728
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40031B8")]
		private Vector2 dragOffset;

		// Token: 0x040031B9 RID: 12729
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x40031B9")]
		[Header("选中的线")]
		public ConnectionLine selectedLine;

		// Token: 0x040031BA RID: 12730
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40031BA")]
		[Header("多选的节点")]
		public bool isDraggingMultiple;

		// Token: 0x040031BB RID: 12731
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40031BB")]
		public List<RuntimeNodeUI> selectedNodes;

		// Token: 0x040031BC RID: 12732
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40031BC")]
		public Dictionary<RuntimeNodeUI, Vector2> draggedNodesInitialPositions;

		// Token: 0x040031BD RID: 12733
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x40031BD")]
		[Header("剪贴板")]
		private readonly List<EventNodeBase> clipboardNodes;

		// Token: 0x040031BE RID: 12734
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x40031BE")]
		private readonly List<NodeConnection> clipboardConnections;

		// Token: 0x040031BF RID: 12735
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x40031BF")]
		[Header("分组")]
		public GameObject groupPrefab;

		// Token: 0x040031C0 RID: 12736
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x40031C0")]
		public RectTransform groupContainer;

		// Token: 0x040031C1 RID: 12737
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x40031C1")]
		public Dictionary<string, NodeGroupUI> groupUIs;

		// Token: 0x02000C26 RID: 3110
		[Token(Token = "0x2000C26")]
		private class PortData
		{
			// Token: 0x060040C9 RID: 16585 RVA: 0x00155A10 File Offset: 0x00153C10
			[Token(Token = "0x60040C9")]
			[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
			public PortData()
			{
			}

			// Token: 0x040031C3 RID: 12739
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40031C3")]
			public string nodeId;

			// Token: 0x040031C4 RID: 12740
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40031C4")]
			public string portName;

			// Token: 0x040031C5 RID: 12741
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40031C5")]
			public PortType portType;

			// Token: 0x040031C6 RID: 12742
			[FieldOffset(Offset = "0x24")]
			[Token(Token = "0x40031C6")]
			public bool isInput;

			// Token: 0x040031C7 RID: 12743
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x40031C7")]
			public RuntimeNodeUI nodeUI;
		}
	}
}
