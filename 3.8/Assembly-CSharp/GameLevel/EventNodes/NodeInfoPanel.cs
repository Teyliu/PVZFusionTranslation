using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B5D RID: 2909
	[Token(Token = "0x2000B5D")]
	public class NodeInfoPanel : MonoBehaviour
	{
		// Token: 0x06003CA7 RID: 15527 RVA: 0x0013EE18 File Offset: 0x0013D018
		[Token(Token = "0x6003CA7")]
		[Address(RVA = "0x7CFE40", Offset = "0x7CE440", VA = "0x1807CFE40")]
		private void Start()
		{
			this.HidePanel();
			GameObject gameObject = this.variableEditPanel;
			int num = 0;
			if (gameObject != num)
			{
				GameObject gameObject2 = this.variableEditPanel;
				int num2 = 0;
				gameObject2.SetActive(num2 != 0);
			}
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x0013EE54 File Offset: 0x0013D054
		[Token(Token = "0x6003CA8")]
		[Address(RVA = "0x7CFD20", Offset = "0x7CE320", VA = "0x1807CFD20")]
		public void ShowVariableAssetEditor(VariableAsset asset)
		{
			GameObject gameObject = this.panel;
			int num = 0;
			if (!(gameObject == num))
			{
				GameObject gameObject2 = this.variableEditPanel;
				int num2 = 0;
				if (!(gameObject2 == num2))
				{
					this.panel.SetActive(true);
					this.variableEditPanel.SetActive(true);
					this.UpdateVariableAssetEditor(asset);
					return;
				}
			}
			EventNodeDebug.LogWarning("[NodeInfoPanel] 面板或变量编辑面板未设置");
		}

		// Token: 0x06003CA9 RID: 15529 RVA: 0x0013EEB8 File Offset: 0x0013D0B8
		[Token(Token = "0x6003CA9")]
		[Address(RVA = "0x7CF7E0", Offset = "0x7CDDE0", VA = "0x1807CF7E0")]
		public void ShowNodeInfo(EventNodeBase node)
		{
			if (node != 0)
			{
				GameObject gameObject = this.panel;
				int num = 0;
				if (!(gameObject == num))
				{
					GameObject gameObject2 = this.variableEditPanel;
					int num2 = 0;
					if (!(gameObject2 == num2))
					{
						this.panel.SetActive(true);
						this.variableEditPanel.SetActive(true);
					}
				}
			}
			GameObject gameObject3 = this.panel;
			int num3 = 0;
			if (!(gameObject3 == num3))
			{
				if (node != 0)
				{
					this.HideVariableEditor();
					Dictionary<string, NodeTypeInfo> nodeTypes = NodeTypeRegistry.nodeTypes;
					bool flag;
					ulong num4;
					if (flag && num4 != (ulong)0L)
					{
						TextMeshProUGUI textMeshProUGUI = this.titleText;
						int num5 = 0;
						if (textMeshProUGUI != num5)
						{
							this.titleText.text = num5;
						}
						TextMeshProUGUI textMeshProUGUI2 = this.descriptionText;
						int num6 = 0;
						if (!(textMeshProUGUI2 != num6))
						{
							return;
						}
						string nodeId = node.nodeId;
						string text;
						this.descriptionText.text = text;
					}
					string nodeType = node.nodeType;
					EventNodeDebug.LogWarning("[NodeInfoPanel] 未找到节点类型信息: " + nodeType);
					TextMeshProUGUI textMeshProUGUI3 = this.titleText;
					int num7 = 0;
					if (textMeshProUGUI3 != num7)
					{
						string nodeName = node.nodeName;
						if (nodeName == 0)
						{
							string nodeType2 = node.nodeType;
						}
						this.titleText.text = nodeName;
					}
					TextMeshProUGUI textMeshProUGUI4 = this.descriptionText;
					int num8 = 0;
					if (!(textMeshProUGUI4 != num8))
					{
						return;
					}
					string nodeId2 = node.nodeId;
					TextMeshProUGUI textMeshProUGUI5 = this.descriptionText;
					string text2 = "暂无描述信息\n\n<b>节点ID:</b> " + nodeId2;
				}
				EventNodeDebug.LogWarning("[NodeInfoPanel] 节点为空");
			}
			EventNodeDebug.LogWarning("[NodeInfoPanel] 面板对象未设置");
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x0013F038 File Offset: 0x0013D238
		[Token(Token = "0x6003CAA")]
		[Address(RVA = "0x7CEEE0", Offset = "0x7CD4E0", VA = "0x1807CEEE0")]
		public void ShowGroupInfo(NodeGroup group)
		{
			GameObject gameObject = this.panel;
			int num = 0;
			if (gameObject == num)
			{
				EventNodeDebug.LogWarning("[NodeInfoPanel] 面板对象未设置");
				return;
			}
			if (group != 0)
			{
				this.panel.SetActive(true);
				this.HideVariableEditor();
				TextMeshProUGUI textMeshProUGUI = this.titleText;
				int num2 = 0;
				if (textMeshProUGUI != num2)
				{
					TextMeshProUGUI textMeshProUGUI2 = this.titleText;
					string title = group.title;
					textMeshProUGUI2.text = title;
				}
				TextMeshProUGUI textMeshProUGUI3 = this.descriptionText;
				int num3 = 0;
				if (textMeshProUGUI3 != num3)
				{
					this.descriptionText.text = "";
				}
				this.ShowGroupTitleEditor(group);
				return;
			}
			EventNodeDebug.LogWarning("[NodeInfoPanel] 分组为空");
			this.HidePanel();
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x0013F0F0 File Offset: 0x0013D2F0
		[Token(Token = "0x6003CAB")]
		[Address(RVA = "0x7CF0D0", Offset = "0x7CD6D0", VA = "0x1807CF0D0")]
		private void ShowGroupTitleEditor(NodeGroup group)
		{
			GameObject gameObject = this.variableEditPanel;
			int num = 0;
			if (!(gameObject == num))
			{
				TMP_InputField tmp_InputField = this.nameEditContainer;
				int num2 = 0;
				if (!(tmp_InputField == num2))
				{
					this.variableEditPanel.SetActive(true);
					this.HideAllEditors();
					this.nameEditContainer.gameObject.SetActive(true);
					this.nameEditContainer.m_OnValueChanged.RemoveAllListeners();
					NodeGroup group2 = group;
					string text;
					this.nameEditContainer.text = text;
					TMP_InputField tmp_InputField2 = this.nameEditContainer;
					int num3 = 0;
					tmp_InputField2.contentType = (TMP_InputField.ContentType)num3;
					UnityAction<string> unityAction;
					this.nameEditContainer.m_OnValueChanged.AddListener(unityAction);
					TheButton theButton = this.actionButton;
					int num4 = 0;
					if (theButton != num4)
					{
						GameObject gameObject2 = this.actionButton.gameObject;
						int num5 = 0;
						gameObject2.SetActive(num5 != 0);
					}
					return;
				}
			}
			EventNodeDebug.LogWarning("[NodeInfoPanel] 变量编辑面板或名称编辑器未设置");
			throw new NullReferenceException();
		}

		// Token: 0x06003CAC RID: 15532 RVA: 0x0013F1F0 File Offset: 0x0013D3F0
		[Token(Token = "0x6003CAC")]
		[Address(RVA = "0x7CE8E0", Offset = "0x7CCEE0", VA = "0x1807CE8E0")]
		public void HidePanel()
		{
			this.titleText.text = "无标题";
			this.descriptionText.text = "无描述";
			this.HideVariableEditor();
		}

		// Token: 0x06003CAD RID: 15533 RVA: 0x0013F22C File Offset: 0x0013D42C
		[Token(Token = "0x6003CAD")]
		[Address(RVA = "0x7CE970", Offset = "0x7CCF70", VA = "0x1807CE970")]
		private void HideVariableEditor()
		{
			GameObject gameObject = this.variableEditPanel;
			int num = 0;
			if (gameObject != num)
			{
				GameObject gameObject2 = this.variableEditPanel;
				int num2 = 0;
				gameObject2.SetActive(num2 != 0);
			}
		}

		// Token: 0x06003CAE RID: 15534 RVA: 0x0013F264 File Offset: 0x0013D464
		[Token(Token = "0x6003CAE")]
		[Address(RVA = "0x7D0010", Offset = "0x7CE610", VA = "0x1807D0010")]
		private void UpdateVariableAssetEditor(VariableAsset asset)
		{
			TextMeshProUGUI textMeshProUGUI = this.variableNameText;
			int num = 0;
			if (textMeshProUGUI != num)
			{
				TextMeshProUGUI textMeshProUGUI2 = this.variableNameText;
				string name = asset.name;
				textMeshProUGUI2.text = name;
				this.descriptionText.text = "";
			}
			if (asset != 0)
			{
				this.ShowNameEditor(asset);
				return;
			}
			this.HideAllEditors();
		}

		// Token: 0x06003CAF RID: 15535 RVA: 0x0013F2D0 File Offset: 0x0013D4D0
		[Token(Token = "0x6003CAF")]
		[Address(RVA = "0x7CF550", Offset = "0x7CDB50", VA = "0x1807CF550")]
		private void ShowNameEditor(VariableAsset asset)
		{
			this.nameEditContainer.gameObject.SetActive(true);
			this.nameEditContainer.m_OnValueChanged.RemoveAllListeners();
			VariableAsset asset2 = asset;
			string text;
			this.nameEditContainer.text = text;
			TMP_InputField tmp_InputField = this.nameEditContainer;
			int num = 0;
			tmp_InputField.contentType = (TMP_InputField.ContentType)num;
			UnityAction<string> unityAction;
			this.nameEditContainer.m_OnValueChanged.AddListener(unityAction);
			this.actionButton.gameObject.SetActive(true);
			this.actionButton.theEvent_up.RemoveAllListeners();
			this.actionButton.GetComponentInChildren<TextMeshProUGUI>().text = "删除变量";
			UnityEvent theEvent_up = this.actionButton.theEvent_up;
			UnityAction unityAction2 = delegate
			{
				AttributePanel attributePanel = RuntimeEventNodeEditor.Instance.attributePanel;
				VariableAsset asset3 = asset;
				attributePanel.RemoveVariable(asset3);
				this.HidePanel();
				CursorChange.SetDefaultCursor();
			};
			theEvent_up.AddListener(unityAction2);
		}

		// Token: 0x06003CB0 RID: 15536 RVA: 0x0013F3AC File Offset: 0x0013D5AC
		[Token(Token = "0x6003CB0")]
		[Address(RVA = "0x7CF380", Offset = "0x7CD980", VA = "0x1807CF380")]
		private void ShowIntAssetEditor(IntVariableAsset intVar)
		{
			this.HideAllEditors();
			TMP_InputField tmp_InputField = this.intEditContainer;
			int num = 0;
			if (tmp_InputField != num)
			{
				ulong num2;
				this.intEditContainer.gameObject.SetActive(num2 != 0UL);
				TMP_InputField tmp_InputField2 = this.intEditContainer;
				int num3 = 0;
				if (tmp_InputField2 != num3)
				{
					tmp_InputField2.m_OnValueChanged.RemoveAllListeners();
					IntVariableAsset intVar2 = intVar;
					string text;
					tmp_InputField2.text = text;
					UnityAction<string> unityAction;
					tmp_InputField2.m_OnValueChanged.AddListener(unityAction);
				}
			}
		}

		// Token: 0x06003CB1 RID: 15537 RVA: 0x0013F43C File Offset: 0x0013D63C
		[Token(Token = "0x6003CB1")]
		[Address(RVA = "0x7CECF0", Offset = "0x7CD2F0", VA = "0x1807CECF0")]
		private void ShowFloatAssetEditor(FloatVariableAsset floatVar)
		{
			this.HideAllEditors();
			TMP_InputField tmp_InputField = this.floatEditContainer;
			int num = 0;
			if (tmp_InputField != num)
			{
				ulong num2;
				this.floatEditContainer.gameObject.SetActive(num2 != 0UL);
				TMP_InputField tmp_InputField2 = this.floatEditContainer;
				int num3 = 0;
				if (tmp_InputField2 != num3)
				{
					tmp_InputField2.m_OnValueChanged.RemoveAllListeners();
					FloatVariableAsset floatVar2 = floatVar;
					string text;
					tmp_InputField2.text = text;
					UnityAction<string> unityAction;
					tmp_InputField2.m_OnValueChanged.AddListener(unityAction);
				}
			}
		}

		// Token: 0x06003CB2 RID: 15538 RVA: 0x0013F4CC File Offset: 0x0013D6CC
		[Token(Token = "0x6003CB2")]
		[Address(RVA = "0x7CE9F0", Offset = "0x7CCFF0", VA = "0x1807CE9F0")]
		private void ShowBoolAssetEditor(BoolVariableAsset boolVar)
		{
			this.HideAllEditors();
			Toggle toggle = this.boolEditContainer;
			int num = 0;
			if (toggle != num)
			{
				this.boolEditContainer.gameObject.SetActive(true);
				Toggle toggle2 = this.boolEditContainer;
				int num2 = 0;
				if (toggle2 != num2)
				{
					toggle2.onValueChanged.RemoveAllListeners();
					BoolVariableAsset boolVar2 = boolVar;
					bool flag;
					toggle2.isOn = flag;
					Toggle.ToggleEvent onValueChanged = toggle2.onValueChanged;
					UnityAction<bool> unityAction = delegate(bool value)
					{
						boolVar.value = value;
					};
					onValueChanged.AddListener(unityAction);
				}
			}
		}

		// Token: 0x06003CB3 RID: 15539 RVA: 0x0013F568 File Offset: 0x0013D768
		[Token(Token = "0x6003CB3")]
		[Address(RVA = "0x7CE710", Offset = "0x7CCD10", VA = "0x1807CE710")]
		private void HideAllEditors()
		{
			TMP_InputField tmp_InputField = this.intEditContainer;
			int num = 0;
			if (tmp_InputField != num)
			{
				GameObject gameObject = this.intEditContainer.gameObject;
				int num2 = 0;
				gameObject.SetActive(num2 != 0);
			}
			TMP_InputField tmp_InputField2 = this.floatEditContainer;
			int num3 = 0;
			if (tmp_InputField2 != num3)
			{
				GameObject gameObject2 = this.floatEditContainer.gameObject;
				int num4 = 0;
				gameObject2.SetActive(num4 != 0);
			}
			Toggle toggle = this.boolEditContainer;
			int num5 = 0;
			if (toggle != num5)
			{
				GameObject gameObject3 = this.boolEditContainer.gameObject;
				int num6 = 0;
				gameObject3.SetActive(num6 != 0);
			}
			TMP_InputField tmp_InputField3 = this.nameEditContainer;
			int num7 = 0;
			if (tmp_InputField3 != num7)
			{
				GameObject gameObject4 = this.nameEditContainer.gameObject;
				int num8 = 0;
				gameObject4.SetActive(num8 != 0);
			}
			TheButton theButton = this.actionButton;
			int num9 = 0;
			if (theButton != num9)
			{
				GameObject gameObject5 = this.actionButton.gameObject;
				int num10 = 0;
				gameObject5.SetActive(num10 != 0);
			}
		}

		// Token: 0x06003CB4 RID: 15540 RVA: 0x0013F664 File Offset: 0x0013D864
		[Token(Token = "0x6003CB4")]
		[Address(RVA = "0x7CFED0", Offset = "0x7CE4D0", VA = "0x1807CFED0")]
		private void UpdatePanelContent(NodeTypeInfo nodeInfo, EventNodeBase node)
		{
			TextMeshProUGUI textMeshProUGUI = this.titleText;
			int num = 0;
			if (textMeshProUGUI != num)
			{
				TextMeshProUGUI textMeshProUGUI2 = this.titleText;
				string displayName = nodeInfo.displayName;
				textMeshProUGUI2.text = displayName;
			}
			TextMeshProUGUI textMeshProUGUI3 = this.descriptionText;
			int num2 = 0;
			if (textMeshProUGUI3 != num2)
			{
				string nodeId = node.nodeId;
				TextMeshProUGUI textMeshProUGUI4 = this.descriptionText;
				string text = nodeInfo.description + "\n\n<b>节点ID:</b> " + nodeId;
				textMeshProUGUI4.text = text;
			}
		}

		// Token: 0x06003CB5 RID: 15541 RVA: 0x0013F6E4 File Offset: 0x0013D8E4
		[Token(Token = "0x6003CB5")]
		[Address(RVA = "0x7CEBA0", Offset = "0x7CD1A0", VA = "0x1807CEBA0")]
		private void ShowDefaultInfo(EventNodeBase node)
		{
			TextMeshProUGUI textMeshProUGUI = this.titleText;
			int num = 0;
			if (textMeshProUGUI != num)
			{
				string nodeName = node.nodeName;
				if (nodeName == 0)
				{
					string nodeType = node.nodeType;
				}
				this.titleText.text = nodeName;
			}
			TextMeshProUGUI textMeshProUGUI2 = this.descriptionText;
			int num2 = 0;
			if (textMeshProUGUI2 != num2)
			{
				string nodeId = node.nodeId;
				TextMeshProUGUI textMeshProUGUI3 = this.descriptionText;
				string text = "暂无描述信息\n\n<b>节点ID:</b> " + nodeId;
				textMeshProUGUI3.text = text;
			}
		}

		// Token: 0x06003CB6 RID: 15542 RVA: 0x0013F768 File Offset: 0x0013D968
		[Token(Token = "0x6003CB6")]
		[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
		public NodeInfoPanel()
		{
		}

		// Token: 0x04002CEA RID: 11498
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002CEA")]
		[Header("UI组件")]
		[SerializeField]
		private GameObject panel;

		// Token: 0x04002CEB RID: 11499
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002CEB")]
		[SerializeField]
		private TextMeshProUGUI titleText;

		// Token: 0x04002CEC RID: 11500
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002CEC")]
		[SerializeField]
		private TextMeshProUGUI descriptionText;

		// Token: 0x04002CED RID: 11501
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002CED")]
		[SerializeField]
		[Header("变量编辑组件")]
		private GameObject variableEditPanel;

		// Token: 0x04002CEE RID: 11502
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002CEE")]
		[SerializeField]
		private TextMeshProUGUI variableNameText;

		// Token: 0x04002CEF RID: 11503
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002CEF")]
		[SerializeField]
		private TMP_InputField nameEditContainer;

		// Token: 0x04002CF0 RID: 11504
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002CF0")]
		[SerializeField]
		private TMP_InputField intEditContainer;

		// Token: 0x04002CF1 RID: 11505
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002CF1")]
		[SerializeField]
		private TMP_InputField floatEditContainer;

		// Token: 0x04002CF2 RID: 11506
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002CF2")]
		[SerializeField]
		private Toggle boolEditContainer;

		// Token: 0x04002CF3 RID: 11507
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002CF3")]
		[SerializeField]
		private TheButton actionButton;
	}
}
