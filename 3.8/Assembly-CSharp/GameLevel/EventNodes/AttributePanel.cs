using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B34 RID: 2868
	[Token(Token = "0x2000B34")]
	public class AttributePanel : MonoBehaviour
	{
		// Token: 0x06003BA9 RID: 15273 RVA: 0x00138BD4 File Offset: 0x00136DD4
		[Token(Token = "0x6003BA9")]
		[Address(RVA = "0x79F430", Offset = "0x79DA30", VA = "0x18079F430")]
		private void Start()
		{
			if (this.currentGraph != (ulong)0L)
			{
				Button button = this.buttonPrefab;
				Transform transform = this.createButtonContainer;
				Button button2 = global::UnityEngine.Object.Instantiate<Button>(button, transform);
				Button.ButtonClickedEvent onClick = button2.m_OnClick;
				UnityAction unityAction = new UnityAction(this.CreateIntVariable);
				onClick.AddListener(unityAction);
				button2.GetComponentInChildren<TextMeshProUGUI>().text = "创建整数变量";
				Transform transform2 = this.createButtonContainer;
				Button button3 = global::UnityEngine.Object.Instantiate<Button>(this.buttonPrefab, transform2);
				Button.ButtonClickedEvent onClick2 = button3.m_OnClick;
				UnityAction unityAction2 = new UnityAction(this.CreateFloatVariable);
				onClick2.AddListener(unityAction2);
				button3.GetComponentInChildren<TextMeshProUGUI>().text = "创建浮点变量";
				Transform transform3 = this.createButtonContainer;
				Button button4 = global::UnityEngine.Object.Instantiate<Button>(this.buttonPrefab, transform3);
				Button.ButtonClickedEvent onClick3 = button4.m_OnClick;
				UnityAction unityAction3 = new UnityAction(this.CreateBoolVariable);
				onClick3.AddListener(unityAction3);
				TextMeshProUGUI componentInChildren = button4.GetComponentInChildren<TextMeshProUGUI>();
			}
			EventNodeDebug.LogWarning("[AttributePanel] 当前没有节点图");
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x00138CCC File Offset: 0x00136ECC
		[Token(Token = "0x6003BAA")]
		[Address(RVA = "0x79F400", Offset = "0x79DA00", VA = "0x18079F400")]
		public void SetGraph(EventNodeGraph graph)
		{
			this.currentGraph = graph;
			this.RefreshVariableList();
		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x00138CE8 File Offset: 0x00136EE8
		[Token(Token = "0x6003BAB")]
		[Address(RVA = "0x79F720", Offset = "0x79DD20", VA = "0x18079F720")]
		public void UpdateVariableItem(VariableAsset variableAsset)
		{
			Dictionary<VariableAsset, GameObject> dictionary = this.variableItemUIs;
			bool flag;
			if (flag)
			{
				string name = variableAsset.name;
				TextMeshProUGUI textMeshProUGUI;
				textMeshProUGUI.text = name;
			}
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x00138D18 File Offset: 0x00136F18
		[Token(Token = "0x6003BAC")]
		[Address(RVA = "0x79F010", Offset = "0x79D610", VA = "0x18079F010")]
		public void RefreshVariableList()
		{
			ulong num2;
			do
			{
				int num = 0;
				if (this.currentGraph == num)
				{
					break;
				}
				this.ClearVariableList();
				List<VariableAsset> variables = this.currentGraph.variables;
				bool flag;
				if (flag)
				{
					this.CreateVariableItem(num);
				}
			}
			while (num2 != (ulong)0L);
		}

		// Token: 0x06003BAD RID: 15277 RVA: 0x00138D58 File Offset: 0x00136F58
		[Token(Token = "0x6003BAD")]
		[Address(RVA = "0x79E6F0", Offset = "0x79CCF0", VA = "0x18079E6F0")]
		private void ClearVariableList()
		{
			ulong num3;
			do
			{
				int num = 0;
				Dictionary<VariableAsset, GameObject>.ValueCollection values = this.variableItemUIs.Values;
				bool flag;
				if (flag)
				{
					int num2 = 0;
					if (!(num != num2))
					{
						continue;
					}
					global::UnityEngine.Object.Destroy(num);
				}
			}
			while (num3 != (ulong)0L);
		}

		// Token: 0x06003BAE RID: 15278 RVA: 0x00138D9C File Offset: 0x00136F9C
		[Token(Token = "0x6003BAE")]
		[Address(RVA = "0x79EAD0", Offset = "0x79D0D0", VA = "0x18079EAD0")]
		public void CreateIntVariable()
		{
			IntVariableAsset intVariableAsset = new IntVariableAsset();
			List<VariableAsset> variables = this.currentGraph.variables;
			int size = variables._size;
			variables._size = intVariableAsset;
			intVariableAsset.name = "整数";
			this.CreateVariableItem(intVariableAsset);
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x00138DE4 File Offset: 0x00136FE4
		[Token(Token = "0x6003BAF")]
		[Address(RVA = "0x79E9C0", Offset = "0x79CFC0", VA = "0x18079E9C0")]
		public void CreateFloatVariable()
		{
			FloatVariableAsset floatVariableAsset = new FloatVariableAsset();
			List<VariableAsset> variables = this.currentGraph.variables;
			int size = variables._size;
			variables._size = floatVariableAsset;
			floatVariableAsset.name = "浮点数";
			this.CreateVariableItem(floatVariableAsset);
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x00138E2C File Offset: 0x0013702C
		[Token(Token = "0x6003BB0")]
		[Address(RVA = "0x79E8B0", Offset = "0x79CEB0", VA = "0x18079E8B0")]
		public void CreateBoolVariable()
		{
			BoolVariableAsset boolVariableAsset = new BoolVariableAsset();
			List<VariableAsset> variables = this.currentGraph.variables;
			int size = variables._size;
			variables._size = boolVariableAsset;
			boolVariableAsset.name = "布尔值";
			this.CreateVariableItem(boolVariableAsset);
		}

		// Token: 0x06003BB1 RID: 15281 RVA: 0x00138E74 File Offset: 0x00137074
		[Token(Token = "0x6003BB1")]
		[Address(RVA = "0x79EBE0", Offset = "0x79D1E0", VA = "0x18079EBE0")]
		private void CreateVariableItem(VariableAsset asset)
		{
			int num = 0;
			Button button = this.variableItemPrefab;
			int num2 = 0;
			if (!(button == num2))
			{
				Transform transform = this.variableListContainer;
				int num3 = 0;
				if (!(transform == num3))
				{
					Button button2 = this.variableItemPrefab;
					Transform transform2 = this.variableListContainer;
					Button button3 = global::UnityEngine.Object.Instantiate<Button>(button2, transform2);
					TextMeshProUGUI componentInChildren = button3.GetComponentInChildren<TextMeshProUGUI>();
					int num4 = 0;
					if (componentInChildren != num4)
					{
						VariableAsset asset2 = asset;
						string text;
						componentInChildren.text = text;
					}
					Button button4;
					if (!button3.TryGetComponent<Button>(num))
					{
						button4 = button3.AddComponent<Button>();
					}
					button4.m_OnClick.RemoveAllListeners();
					Button.ButtonClickedEvent onClick = button4.m_OnClick;
					UnityAction unityAction = delegate
					{
						VariableAsset asset5 = asset;
						RuntimeEventNodeEditor.Instance.nodeInfoPanel.ShowVariableAssetEditor(asset5);
						string name = asset5.name;
						EventNodeDebug.Log("[AttributePanel] 选中了变量：" + name);
					};
					onClick.AddListener(unityAction);
					VariableItemDragHandler variableItemDragHandler;
					if (!button3.TryGetComponent<VariableItemDragHandler>(num))
					{
						variableItemDragHandler = button3.AddComponent<VariableItemDragHandler>();
					}
					VariableAsset asset3 = asset;
					variableItemDragHandler.draggedAsset = asset3;
					Dictionary<VariableAsset, GameObject> dictionary = this.variableItemUIs;
					VariableAsset asset4 = asset;
					GameObject gameObject = button3.gameObject;
					dictionary[asset4] = gameObject;
					return;
				}
			}
			EventNodeDebug.LogWarning("[AttributePanel] 变量项预制体或容器未设置");
			throw new NullReferenceException();
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x00138FA8 File Offset: 0x001371A8
		[Token(Token = "0x6003BB2")]
		[Address(RVA = "0x79EF60", Offset = "0x79D560", VA = "0x18079EF60")]
		public void OnVariableSelected(VariableAsset asset)
		{
			RuntimeEventNodeEditor.Instance.nodeInfoPanel.ShowVariableAssetEditor(asset);
			string name = asset.name;
			EventNodeDebug.Log("[AttributePanel] 选中了变量：" + name);
		}

		// Token: 0x06003BB3 RID: 15283 RVA: 0x00138FE4 File Offset: 0x001371E4
		[Token(Token = "0x6003BB3")]
		[Address(RVA = "0x79F140", Offset = "0x79D740", VA = "0x18079F140")]
		public void RemoveVariable(VariableAsset asset)
		{
			ulong num2;
			do
			{
				int num = 0;
				Dictionary<VariableAsset, GameObject> dictionary = this.variableItemUIs;
				bool flag;
				if (flag)
				{
					bool flag2;
					if (flag2)
					{
					}
					bool flag3 = this.variableItemUIs.Remove(asset);
				}
				List<string> list = Enumerable.ToList<string>(asset.referencedNodeIds);
				bool flag4;
				if (flag4)
				{
					RuntimeEventNodeEditor.Instance.DeleteNode(num);
				}
			}
			while (num2 != (ulong)0L);
			string text;
			EventNodeDebug.Log(text);
		}

		// Token: 0x06003BB4 RID: 15284 RVA: 0x0013904C File Offset: 0x0013724C
		[Token(Token = "0x6003BB4")]
		[Address(RVA = "0x79EF40", Offset = "0x79D540", VA = "0x18079EF40")]
		public EventNodeBase GetVariableById(string nodeId)
		{
			if (this.currentGraph == (ulong)0L)
			{
			}
			return this.currentGraph.GetNodeById(nodeId);
		}

		// Token: 0x06003BB5 RID: 15285 RVA: 0x00139074 File Offset: 0x00137274
		[Token(Token = "0x6003BB5")]
		[Address(RVA = "0x79F7D0", Offset = "0x79DDD0", VA = "0x18079F7D0")]
		public AttributePanel()
		{
			Dictionary<VariableAsset, GameObject> dictionary = new Dictionary();
			this.variableItemUIs = dictionary;
			base..ctor();
		}

		// Token: 0x04002C24 RID: 11300
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002C24")]
		[SerializeField]
		[Header("UI组件")]
		private GameObject panel;

		// Token: 0x04002C25 RID: 11301
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002C25")]
		[SerializeField]
		private Transform variableListContainer;

		// Token: 0x04002C26 RID: 11302
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002C26")]
		[SerializeField]
		private Transform createButtonContainer;

		// Token: 0x04002C27 RID: 11303
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002C27")]
		[SerializeField]
		private Button buttonPrefab;

		// Token: 0x04002C28 RID: 11304
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002C28")]
		[SerializeField]
		private Button variableItemPrefab;

		// Token: 0x04002C29 RID: 11305
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002C29")]
		[SerializeField]
		private GameObject createPanel;

		// Token: 0x04002C2A RID: 11306
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002C2A")]
		[SerializeField]
		[Header("当前节点图")]
		private EventNodeGraph currentGraph;

		// Token: 0x04002C2B RID: 11307
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002C2B")]
		private readonly Dictionary<VariableAsset, GameObject> variableItemUIs;
	}
}
