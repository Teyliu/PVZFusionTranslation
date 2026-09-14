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
	// Token: 0x02000BE3 RID: 3043
	[Token(Token = "0x2000BE3")]
	public class RuntimeEventNodeEditor : MonoBehaviour
	{
		// Token: 0x06003F47 RID: 16199 RVA: 0x0014ED6C File Offset: 0x0014CF6C
		[Token(Token = "0x6003F47")]
		[Address(RVA = "0x80F740", Offset = "0x80DD40", VA = "0x18080F740")]
		private void Awake()
		{
			RuntimeEventNodeEditor.Instance = this;
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06003F48 RID: 16200 RVA: 0x0014ED80 File Offset: 0x0014CF80
		// (set) Token: 0x06003F49 RID: 16201 RVA: 0x0014ED98 File Offset: 0x0014CF98
		[Token(Token = "0x170004AB")]
		public Bounds WorldBounds
		{
			[Token(Token = "0x6003F48")]
			[Address(RVA = "0x8164F0", Offset = "0x814AF0", VA = "0x1808164F0")]
			[CompilerGenerated]
			get
			{
				return default(Bounds);
			}
			[Token(Token = "0x6003F49")]
			[Address(RVA = "0x816510", Offset = "0x814B10", VA = "0x180816510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003F4A RID: 16202 RVA: 0x0014EDA8 File Offset: 0x0014CFA8
		[Token(Token = "0x6003F4A")]
		[Address(RVA = "0x813B10", Offset = "0x812110", VA = "0x180813B10")]
		private void OnEnable()
		{
			if (base.transform != 0)
			{
			}
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x0014EDC0 File Offset: 0x0014CFC0
		[Token(Token = "0x6003F4B")]
		[Address(RVA = "0x815D80", Offset = "0x814380", VA = "0x180815D80")]
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

		// Token: 0x06003F4C RID: 16204 RVA: 0x0014EED4 File Offset: 0x0014D0D4
		[Token(Token = "0x6003F4C")]
		[Address(RVA = "0x8130F0", Offset = "0x8116F0", VA = "0x1808130F0")]
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

		// Token: 0x06003F4D RID: 16205 RVA: 0x0014EF80 File Offset: 0x0014D180
		[Token(Token = "0x6003F4D")]
		[Address(RVA = "0x815180", Offset = "0x813780", VA = "0x180815180")]
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

		// Token: 0x06003F4E RID: 16206 RVA: 0x0014EFF0 File Offset: 0x0014D1F0
		[Token(Token = "0x6003F4E")]
		[Address(RVA = "0x80F7A0", Offset = "0x80DDA0", VA = "0x18080F7A0")]
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

		// Token: 0x06003F4F RID: 16207 RVA: 0x0014F06C File Offset: 0x0014D26C
		[Token(Token = "0x6003F4F")]
		[Address(RVA = "0x8137B0", Offset = "0x811DB0", VA = "0x1808137B0")]
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

		// Token: 0x06003F50 RID: 16208 RVA: 0x0014F0D0 File Offset: 0x0014D2D0
		[Token(Token = "0x6003F50")]
		[Address(RVA = "0x810BF0", Offset = "0x80F1F0", VA = "0x180810BF0")]
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

		// Token: 0x06003F51 RID: 16209 RVA: 0x0014F174 File Offset: 0x0014D374
		[Token(Token = "0x6003F51")]
		[Address(RVA = "0x8115D0", Offset = "0x80FBD0", VA = "0x1808115D0")]
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

		// Token: 0x06003F52 RID: 16210 RVA: 0x0014F1D8 File Offset: 0x0014D3D8
		[Token(Token = "0x6003F52")]
		[Address(RVA = "0x810A20", Offset = "0x80F020", VA = "0x180810A20")]
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

		// Token: 0x06003F53 RID: 16211 RVA: 0x0014F274 File Offset: 0x0014D474
		[Token(Token = "0x6003F53")]
		[Address(RVA = "0x80F5D0", Offset = "0x80DBD0", VA = "0x18080F5D0")]
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

		// Token: 0x06003F54 RID: 16212 RVA: 0x0014F2DC File Offset: 0x0014D4DC
		[Token(Token = "0x6003F54")]
		[Address(RVA = "0x811F60", Offset = "0x810560", VA = "0x180811F60")]
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

		// Token: 0x06003F55 RID: 16213 RVA: 0x0014F3AC File Offset: 0x0014D5AC
		[Token(Token = "0x6003F55")]
		[Address(RVA = "0x811B50", Offset = "0x810150", VA = "0x180811B50")]
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

		// Token: 0x06003F56 RID: 16214 RVA: 0x0014F460 File Offset: 0x0014D660
		[Token(Token = "0x6003F56")]
		[Address(RVA = "0x815560", Offset = "0x813B60", VA = "0x180815560")]
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

		// Token: 0x06003F57 RID: 16215 RVA: 0x0014F4DC File Offset: 0x0014D6DC
		[Token(Token = "0x6003F57")]
		[Address(RVA = "0x811790", Offset = "0x80FD90", VA = "0x180811790")]
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

		// Token: 0x06003F58 RID: 16216 RVA: 0x0014F5F8 File Offset: 0x0014D7F8
		[Token(Token = "0x6003F58")]
		[Address(RVA = "0x812700", Offset = "0x810D00", VA = "0x180812700")]
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

		// Token: 0x06003F59 RID: 16217 RVA: 0x0014F638 File Offset: 0x0014D838
		[Token(Token = "0x6003F59")]
		[Address(RVA = "0x8127B0", Offset = "0x810DB0", VA = "0x1808127B0")]
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

		// Token: 0x06003F5A RID: 16218 RVA: 0x0014F7B0 File Offset: 0x0014D9B0
		[Token(Token = "0x6003F5A")]
		[Address(RVA = "0x815C00", Offset = "0x814200", VA = "0x180815C00")]
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

		// Token: 0x06003F5B RID: 16219 RVA: 0x0014F7DC File Offset: 0x0014D9DC
		[Token(Token = "0x6003F5B")]
		[Address(RVA = "0x8158D0", Offset = "0x813ED0", VA = "0x1808158D0")]
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

		// Token: 0x06003F5C RID: 16220 RVA: 0x0014F820 File Offset: 0x0014DA20
		[Token(Token = "0x6003F5C")]
		[Address(RVA = "0x815A50", Offset = "0x814050", VA = "0x180815A50")]
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

		// Token: 0x06003F5D RID: 16221 RVA: 0x0014F868 File Offset: 0x0014DA68
		[Token(Token = "0x6003F5D")]
		[Address(RVA = "0x811470", Offset = "0x80FA70", VA = "0x180811470")]
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

		// Token: 0x06003F5E RID: 16222 RVA: 0x0014F8D0 File Offset: 0x0014DAD0
		[Token(Token = "0x6003F5E")]
		[Address(RVA = "0x812F60", Offset = "0x811560", VA = "0x180812F60")]
		public RuntimeNodeUI GetNodeUI(string nodeId)
		{
			Dictionary<string, RuntimeNodeUI> dictionary = this.nodeUIs;
			int num = 0;
			bool flag = dictionary.TryGetValue(nodeId, num);
			throw new NullReferenceException();
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x0014F8F8 File Offset: 0x0014DAF8
		[Token(Token = "0x6003F5F")]
		[Address(RVA = "0x80F730", Offset = "0x80DD30", VA = "0x18080F730")]
		private bool ArePortTypesCompatible(PortType sourceType, PortType targetType)
		{
			return sourceType == targetType;
		}

		// Token: 0x06003F60 RID: 16224 RVA: 0x0014F90C File Offset: 0x0014DB0C
		[Token(Token = "0x6003F60")]
		[Address(RVA = "0x815320", Offset = "0x813920", VA = "0x180815320")]
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

		// Token: 0x06003F61 RID: 16225 RVA: 0x0014F978 File Offset: 0x0014DB78
		[Token(Token = "0x6003F61")]
		[Address(RVA = "0x80FC90", Offset = "0x80E290", VA = "0x18080FC90")]
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

		// Token: 0x06003F62 RID: 16226 RVA: 0x0014FAE0 File Offset: 0x0014DCE0
		[Token(Token = "0x6003F62")]
		[Address(RVA = "0x812E50", Offset = "0x811450", VA = "0x180812E50")]
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

		// Token: 0x06003F63 RID: 16227 RVA: 0x0014FB2C File Offset: 0x0014DD2C
		[Token(Token = "0x6003F63")]
		[Address(RVA = "0x814FB0", Offset = "0x8135B0", VA = "0x180814FB0")]
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

		// Token: 0x06003F64 RID: 16228 RVA: 0x0014FBBC File Offset: 0x0014DDBC
		[Token(Token = "0x6003F64")]
		[Address(RVA = "0x8156B0", Offset = "0x813CB0", VA = "0x1808156B0")]
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

		// Token: 0x06003F65 RID: 16229 RVA: 0x0014FC40 File Offset: 0x0014DE40
		[Token(Token = "0x6003F65")]
		[Address(RVA = "0x8124E0", Offset = "0x810AE0", VA = "0x1808124E0")]
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

		// Token: 0x06003F66 RID: 16230 RVA: 0x0014FC8C File Offset: 0x0014DE8C
		[Token(Token = "0x6003F66")]
		[Address(RVA = "0x812FE0", Offset = "0x8115E0", VA = "0x180812FE0")]
		public List<RuntimeNodeUI> GetSelectedNodes()
		{
			return new List(this.selectedNodes);
		}

		// Token: 0x06003F67 RID: 16231 RVA: 0x0014FCA4 File Offset: 0x0014DEA4
		[Token(Token = "0x6003F67")]
		[Address(RVA = "0x812DE0", Offset = "0x8113E0", VA = "0x180812DE0")]
		public RuntimeNodeUI GetFirstSelectedNode()
		{
			List<RuntimeNodeUI> list = this.selectedNodes;
			int num = 0;
			return list[num];
		}

		// Token: 0x06003F68 RID: 16232 RVA: 0x0014FCCC File Offset: 0x0014DECC
		[Token(Token = "0x6003F68")]
		[Address(RVA = "0x8130A0", Offset = "0x8116A0", VA = "0x1808130A0")]
		public bool HasSelectedNodes()
		{
			List<RuntimeNodeUI> list = this.selectedNodes;
			bool flag;
			return flag;
		}

		// Token: 0x06003F69 RID: 16233 RVA: 0x0014FCEC File Offset: 0x0014DEEC
		[Token(Token = "0x6003F69")]
		[Address(RVA = "0x813050", Offset = "0x811650", VA = "0x180813050")]
		public bool HasClipboardContent()
		{
			if (this.clipboardNodes == (ulong)0L)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x0014FD0C File Offset: 0x0014DF0C
		[Token(Token = "0x6003F6A")]
		[Address(RVA = "0x810380", Offset = "0x80E980", VA = "0x180810380")]
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

		// Token: 0x06003F6B RID: 16235 RVA: 0x0014FEA4 File Offset: 0x0014E0A4
		[Token(Token = "0x6003F6B")]
		[Address(RVA = "0x813C00", Offset = "0x812200", VA = "0x180813C00")]
		public void PasteNodes()
		{
			List<RuntimeNodeUI> list2;
			bool flag7;
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
					string text = JsonUtility.ToJson(num);
					Type type = num.GetType();
					if (JsonUtility.FromJson(text, type) != 0)
					{
						Guid guid = Guid.NewGuid();
						List<EventNodeBase> nodes = this.graph.nodes;
						Dictionary<string, RuntimeNodeUI> dictionary2 = this.nodeUIs;
						bool flag2;
						if (flag2)
						{
						}
						EventNodeDebug.Log(string.Concat(new string[] { "[RuntimeEventNodeEditor] 粘贴节点: ", "[RuntimeEventNodeEditor] 粘贴节点: ", " (原始ID: ", null, " -> 新ID: ", " -> 新ID: ", ")" }));
					}
					string name = num.GetType().Name;
					string text2 = "[RuntimeEventNodeEditor] 克隆节点失败: " + name;
					int num3 = 0;
					EventNodeDebug.LogError(text2);
					EventNodeDebug.LogError("[RuntimeEventNodeEditor] 粘贴节点失败: " + num3);
				}
				if (num2 != 0)
				{
					goto IL_02DD;
				}
				int num4 = 0;
				bool flag3;
				string text3;
				if (flag3)
				{
					bool flag4;
					bool flag5;
					if (flag4 && flag5)
					{
						EventNodeDebug.Log(string.Concat(new string[] { "[RuntimeEventNodeEditor] 重建连接: ", num2, ".", ".", " -> ", num2, ".", "." }));
					}
					text3 = string.Concat(new string[] { "[RuntimeEventNodeEditor] 无法重建连接: ", "[RuntimeEventNodeEditor] 无法重建连接: ", ".", ".", " -> ", " -> ", ".", ".", " (找不到映射)" });
					EventNodeDebug.LogWarning(text3);
				}
				if (num4 != 0)
				{
					goto IL_0367;
				}
				int num5 = 0;
				int stringLength = text3._stringLength;
				bool flag6;
				if (flag6)
				{
				}
				if (num5 == 0)
				{
					int num6 = 0;
					if (flag7)
					{
					}
					if (num6 == 0)
					{
						break;
					}
				}
			}
			int size = list2._size;
			EventNodeDebug.Log(string.Format("[RuntimeEventNodeEditor] 已粘贴 {0} 个节点和 {1} 条连接，并选中 {2} 个新节点", flag7, flag7, flag7));
			return;
			IL_02DD:
			throw new IndexOutOfRangeException();
			IL_0367:
			throw new NullReferenceException();
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x00150220 File Offset: 0x0014E420
		[Token(Token = "0x6003F6C")]
		[Address(RVA = "0x80FB00", Offset = "0x80E100", VA = "0x18080FB00")]
		private EventNodeBase CloneNode(EventNodeBase source)
		{
			string text = JsonUtility.ToJson(source);
			Type type = source.GetType();
			if (JsonUtility.FromJson(text, type) != 0)
			{
				Guid guid = Guid.NewGuid();
				string nodeType = source.nodeType;
				string nodeName = source.nodeName;
			}
			string name = source.GetType().Name;
			EventNodeDebug.LogError("[RuntimeEventNodeEditor] 克隆节点失败: " + name);
			throw new NullReferenceException();
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x00150288 File Offset: 0x0014E488
		[Token(Token = "0x6003F6D")]
		[Address(RVA = "0x810FB0", Offset = "0x80F5B0", VA = "0x180810FB0")]
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

		// Token: 0x06003F6E RID: 16238 RVA: 0x00150390 File Offset: 0x0014E590
		[Token(Token = "0x6003F6E")]
		[Address(RVA = "0x811A00", Offset = "0x810000", VA = "0x180811A00")]
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

		// Token: 0x06003F6F RID: 16239 RVA: 0x001503E0 File Offset: 0x0014E5E0
		[Token(Token = "0x6003F6F")]
		[Address(RVA = "0x80F440", Offset = "0x80DA40", VA = "0x18080F440")]
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

		// Token: 0x06003F70 RID: 16240 RVA: 0x00150484 File Offset: 0x0014E684
		[Token(Token = "0x6003F70")]
		[Address(RVA = "0x814B00", Offset = "0x813100", VA = "0x180814B00")]
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

		// Token: 0x06003F71 RID: 16241 RVA: 0x00150564 File Offset: 0x0014E764
		[Token(Token = "0x6003F71")]
		[Address(RVA = "0x815D10", Offset = "0x814310", VA = "0x180815D10")]
		public void UpdateGroupBounds(NodeGroupUI groupUI)
		{
			int num = 0;
			if (groupUI != num)
			{
				groupUI.UpdateBounds();
				return;
			}
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x0015058C File Offset: 0x0014E78C
		[Token(Token = "0x6003F72")]
		[Address(RVA = "0x812F40", Offset = "0x811540", VA = "0x180812F40")]
		public NodeGroupUI GetNodeGroup(RuntimeNodeUI nodeUI)
		{
			return nodeUI.group;
		}

		// Token: 0x06003F73 RID: 16243 RVA: 0x001505A8 File Offset: 0x0014E7A8
		[Token(Token = "0x6003F73")]
		[Address(RVA = "0x813330", Offset = "0x811930", VA = "0x180813330")]
		public void JumpToNodeById(string nodeId)
		{
			if (string.IsNullOrEmpty(nodeId))
			{
				InGameText instance = InGameText.Instance;
				int num = 0;
				instance.ShowText("节点ID为空，无法跳转", 3f, num != 0);
				return;
			}
			Dictionary<string, RuntimeNodeUI> dictionary = this.nodeUIs;
			bool flag;
			if (!flag)
			{
				InGameText instance2 = InGameText.Instance;
				string text = "未找到节点ID: " + nodeId;
				int num2 = 0;
				instance2.ShowText(text, 10f, num2 != 0);
				return;
			}
		}

		// Token: 0x06003F74 RID: 16244 RVA: 0x0015061C File Offset: 0x0014E81C
		[Token(Token = "0x6003F74")]
		[Address(RVA = "0x813460", Offset = "0x811A60", VA = "0x180813460")]
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
			int num5 = 0;
			instance.ShowText("节点UI为空，无法跳转", 3f, num5 != 0);
		}

		// Token: 0x06003F75 RID: 16245 RVA: 0x0015073C File Offset: 0x0014E93C
		[Token(Token = "0x6003F75")]
		[Address(RVA = "0x813BB0", Offset = "0x8121B0", VA = "0x180813BB0")]
		public void OnNodeIdSearchInput(string nodeId)
		{
			this.JumpToNodeById(nodeId);
		}

		// Token: 0x06003F76 RID: 16246 RVA: 0x00150754 File Offset: 0x0014E954
		[Token(Token = "0x6003F76")]
		[Address(RVA = "0x8162B0", Offset = "0x8148B0", VA = "0x1808162B0")]
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

		// Token: 0x04003037 RID: 12343
		[Token(Token = "0x4003037")]
		public static RuntimeEventNodeEditor Instance;

		// Token: 0x04003038 RID: 12344
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003038")]
		[Header("UI容器")]
		public RectTransform nodeContainer;

		// Token: 0x04003039 RID: 12345
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4003039")]
		public RectTransform connectionContainer;

		// Token: 0x0400303A RID: 12346
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400303A")]
		[Header("其他面板")]
		public NodeInfoPanel nodeInfoPanel;

		// Token: 0x0400303B RID: 12347
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400303B")]
		public AttributePanel attributePanel;

		// Token: 0x0400303C RID: 12348
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400303C")]
		public EventNodeCanvas canvas;

		// Token: 0x0400303D RID: 12349
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400303D")]
		[Header("节点搜索")]
		public TMP_InputField nodeIdSearchInput;

		// Token: 0x0400303E RID: 12350
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400303E")]
		[Header("预制体")]
		public GameObject nodePrefab;

		// Token: 0x0400303F RID: 12351
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400303F")]
		public GameObject portPrefab;

		// Token: 0x04003040 RID: 12352
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003040")]
		[Header("数据")]
		public EventNodeGraph graph;

		// Token: 0x04003041 RID: 12353
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4003041")]
		public Dictionary<string, RuntimeNodeUI> nodeUIs;

		// Token: 0x04003042 RID: 12354
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4003042")]
		public readonly List<ConnectionLine> connectionLines;

		// Token: 0x04003043 RID: 12355
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4003043")]
		private ConnectionLine tempConnectionLine;

		// Token: 0x04003044 RID: 12356
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4003044")]
		private RuntimeEventNodeEditor.PortData draggingPort;

		// Token: 0x04003045 RID: 12357
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4003045")]
		private Vector2 dragOffset;

		// Token: 0x04003046 RID: 12358
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4003046")]
		[Header("选中的线")]
		public ConnectionLine selectedLine;

		// Token: 0x04003047 RID: 12359
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4003047")]
		[Header("多选的节点")]
		public bool isDraggingMultiple;

		// Token: 0x04003048 RID: 12360
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4003048")]
		public List<RuntimeNodeUI> selectedNodes;

		// Token: 0x04003049 RID: 12361
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4003049")]
		public Dictionary<RuntimeNodeUI, Vector2> draggedNodesInitialPositions;

		// Token: 0x0400304A RID: 12362
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x400304A")]
		[Header("剪贴板")]
		private readonly List<EventNodeBase> clipboardNodes;

		// Token: 0x0400304B RID: 12363
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x400304B")]
		private readonly List<NodeConnection> clipboardConnections;

		// Token: 0x0400304C RID: 12364
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x400304C")]
		[Header("分组")]
		public GameObject groupPrefab;

		// Token: 0x0400304D RID: 12365
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x400304D")]
		public RectTransform groupContainer;

		// Token: 0x0400304E RID: 12366
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x400304E")]
		public Dictionary<string, NodeGroupUI> groupUIs;

		// Token: 0x02000BE4 RID: 3044
		[Token(Token = "0x2000BE4")]
		private class PortData
		{
			// Token: 0x06003F78 RID: 16248 RVA: 0x001507E8 File Offset: 0x0014E9E8
			[Token(Token = "0x6003F78")]
			[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
			public PortData()
			{
			}

			// Token: 0x04003050 RID: 12368
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4003050")]
			public string nodeId;

			// Token: 0x04003051 RID: 12369
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4003051")]
			public string portName;

			// Token: 0x04003052 RID: 12370
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4003052")]
			public PortType portType;

			// Token: 0x04003053 RID: 12371
			[FieldOffset(Offset = "0x24")]
			[Token(Token = "0x4003053")]
			public bool isInput;

			// Token: 0x04003054 RID: 12372
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4003054")]
			public RuntimeNodeUI nodeUI;
		}
	}
}
