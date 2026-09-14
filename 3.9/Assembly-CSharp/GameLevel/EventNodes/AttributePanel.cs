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
	// Token: 0x02000B76 RID: 2934
	[Token(Token = "0x2000B76")]
	public class AttributePanel : MonoBehaviour
	{
		// Token: 0x06003CFA RID: 15610 RVA: 0x0013DE7C File Offset: 0x0013C07C
		[Token(Token = "0x6003CFA")]
		[Address(RVA = "0x81A4A0", Offset = "0x818AA0", VA = "0x18081A4A0")]
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

		// Token: 0x06003CFB RID: 15611 RVA: 0x0013DF74 File Offset: 0x0013C174
		[Token(Token = "0x6003CFB")]
		[Address(RVA = "0x81A470", Offset = "0x818A70", VA = "0x18081A470")]
		public void SetGraph(EventNodeGraph graph)
		{
			this.currentGraph = graph;
			this.RefreshVariableList();
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x0013DF90 File Offset: 0x0013C190
		[Token(Token = "0x6003CFC")]
		[Address(RVA = "0x81A790", Offset = "0x818D90", VA = "0x18081A790")]
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

		// Token: 0x06003CFD RID: 15613 RVA: 0x0013DFC0 File Offset: 0x0013C1C0
		[Token(Token = "0x6003CFD")]
		[Address(RVA = "0x81A080", Offset = "0x818680", VA = "0x18081A080")]
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

		// Token: 0x06003CFE RID: 15614 RVA: 0x0013E000 File Offset: 0x0013C200
		[Token(Token = "0x6003CFE")]
		[Address(RVA = "0x819760", Offset = "0x817D60", VA = "0x180819760")]
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

		// Token: 0x06003CFF RID: 15615 RVA: 0x0013E044 File Offset: 0x0013C244
		[Token(Token = "0x6003CFF")]
		[Address(RVA = "0x819B40", Offset = "0x818140", VA = "0x180819B40")]
		public void CreateIntVariable()
		{
			IntVariableAsset intVariableAsset = new IntVariableAsset();
			List<VariableAsset> variables = this.currentGraph.variables;
			int size = variables._size;
			variables._size = intVariableAsset;
			intVariableAsset.name = "整数";
			this.CreateVariableItem(intVariableAsset);
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x0013E08C File Offset: 0x0013C28C
		[Token(Token = "0x6003D00")]
		[Address(RVA = "0x819A30", Offset = "0x818030", VA = "0x180819A30")]
		public void CreateFloatVariable()
		{
			FloatVariableAsset floatVariableAsset = new FloatVariableAsset();
			List<VariableAsset> variables = this.currentGraph.variables;
			int size = variables._size;
			variables._size = floatVariableAsset;
			floatVariableAsset.name = "浮点数";
			this.CreateVariableItem(floatVariableAsset);
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x0013E0D4 File Offset: 0x0013C2D4
		[Token(Token = "0x6003D01")]
		[Address(RVA = "0x819920", Offset = "0x817F20", VA = "0x180819920")]
		public void CreateBoolVariable()
		{
			BoolVariableAsset boolVariableAsset = new BoolVariableAsset();
			List<VariableAsset> variables = this.currentGraph.variables;
			int size = variables._size;
			variables._size = boolVariableAsset;
			boolVariableAsset.name = "布尔值";
			this.CreateVariableItem(boolVariableAsset);
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x0013E11C File Offset: 0x0013C31C
		[Token(Token = "0x6003D02")]
		[Address(RVA = "0x819C50", Offset = "0x818250", VA = "0x180819C50")]
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

		// Token: 0x06003D03 RID: 15619 RVA: 0x0013E250 File Offset: 0x0013C450
		[Token(Token = "0x6003D03")]
		[Address(RVA = "0x819FD0", Offset = "0x8185D0", VA = "0x180819FD0")]
		public void OnVariableSelected(VariableAsset asset)
		{
			RuntimeEventNodeEditor.Instance.nodeInfoPanel.ShowVariableAssetEditor(asset);
			string name = asset.name;
			EventNodeDebug.Log("[AttributePanel] 选中了变量：" + name);
		}

		// Token: 0x06003D04 RID: 15620 RVA: 0x0013E28C File Offset: 0x0013C48C
		[Token(Token = "0x6003D04")]
		[Address(RVA = "0x81A1B0", Offset = "0x8187B0", VA = "0x18081A1B0")]
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

		// Token: 0x06003D05 RID: 15621 RVA: 0x0013E2F4 File Offset: 0x0013C4F4
		[Token(Token = "0x6003D05")]
		[Address(RVA = "0x819FB0", Offset = "0x8185B0", VA = "0x180819FB0")]
		public EventNodeBase GetVariableById(string nodeId)
		{
			if (this.currentGraph == (ulong)0L)
			{
			}
			return this.currentGraph.GetNodeById(nodeId);
		}

		// Token: 0x06003D06 RID: 15622 RVA: 0x0013E31C File Offset: 0x0013C51C
		[Token(Token = "0x6003D06")]
		[Address(RVA = "0x81A840", Offset = "0x818E40", VA = "0x18081A840")]
		public AttributePanel()
		{
			Dictionary<VariableAsset, GameObject> dictionary = new Dictionary();
			this.variableItemUIs = dictionary;
			base..ctor();
		}

		// Token: 0x04002D98 RID: 11672
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002D98")]
		[SerializeField]
		[Header("UI组件")]
		private GameObject panel;

		// Token: 0x04002D99 RID: 11673
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002D99")]
		[SerializeField]
		private Transform variableListContainer;

		// Token: 0x04002D9A RID: 11674
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002D9A")]
		[SerializeField]
		private Transform createButtonContainer;

		// Token: 0x04002D9B RID: 11675
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002D9B")]
		[SerializeField]
		private Button buttonPrefab;

		// Token: 0x04002D9C RID: 11676
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002D9C")]
		[SerializeField]
		private Button variableItemPrefab;

		// Token: 0x04002D9D RID: 11677
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002D9D")]
		[SerializeField]
		private GameObject createPanel;

		// Token: 0x04002D9E RID: 11678
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002D9E")]
		[SerializeField]
		[Header("当前节点图")]
		private EventNodeGraph currentGraph;

		// Token: 0x04002D9F RID: 11679
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002D9F")]
		private readonly Dictionary<VariableAsset, GameObject> variableItemUIs;
	}
}
