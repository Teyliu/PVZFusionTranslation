using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B9F RID: 2975
	[Token(Token = "0x2000B9F")]
	public class NodeInfoPanel : MonoBehaviour
	{
		// Token: 0x06003DF8 RID: 15864 RVA: 0x001440C8 File Offset: 0x001422C8
		[Token(Token = "0x6003DF8")]
		[Address(RVA = "0x84C1A0", Offset = "0x84A7A0", VA = "0x18084C1A0")]
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

		// Token: 0x06003DF9 RID: 15865 RVA: 0x00144104 File Offset: 0x00142304
		[Token(Token = "0x6003DF9")]
		[Address(RVA = "0x84C080", Offset = "0x84A680", VA = "0x18084C080")]
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

		// Token: 0x06003DFA RID: 15866 RVA: 0x00144168 File Offset: 0x00142368
		[Token(Token = "0x6003DFA")]
		[Address(RVA = "0x84BB40", Offset = "0x84A140", VA = "0x18084BB40")]
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

		// Token: 0x06003DFB RID: 15867 RVA: 0x001442E8 File Offset: 0x001424E8
		[Token(Token = "0x6003DFB")]
		[Address(RVA = "0x84B240", Offset = "0x849840", VA = "0x18084B240")]
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

		// Token: 0x06003DFC RID: 15868 RVA: 0x001443A0 File Offset: 0x001425A0
		[Token(Token = "0x6003DFC")]
		[Address(RVA = "0x84B430", Offset = "0x849A30", VA = "0x18084B430")]
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

		// Token: 0x06003DFD RID: 15869 RVA: 0x001444A0 File Offset: 0x001426A0
		[Token(Token = "0x6003DFD")]
		[Address(RVA = "0x84AC40", Offset = "0x849240", VA = "0x18084AC40")]
		public void HidePanel()
		{
			this.titleText.text = "无标题";
			this.descriptionText.text = "无描述";
			this.HideVariableEditor();
		}

		// Token: 0x06003DFE RID: 15870 RVA: 0x001444DC File Offset: 0x001426DC
		[Token(Token = "0x6003DFE")]
		[Address(RVA = "0x84ACD0", Offset = "0x8492D0", VA = "0x18084ACD0")]
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

		// Token: 0x06003DFF RID: 15871 RVA: 0x00144514 File Offset: 0x00142714
		[Token(Token = "0x6003DFF")]
		[Address(RVA = "0x84C370", Offset = "0x84A970", VA = "0x18084C370")]
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

		// Token: 0x06003E00 RID: 15872 RVA: 0x00144580 File Offset: 0x00142780
		[Token(Token = "0x6003E00")]
		[Address(RVA = "0x84B8B0", Offset = "0x849EB0", VA = "0x18084B8B0")]
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

		// Token: 0x06003E01 RID: 15873 RVA: 0x0014465C File Offset: 0x0014285C
		[Token(Token = "0x6003E01")]
		[Address(RVA = "0x84B6E0", Offset = "0x849CE0", VA = "0x18084B6E0")]
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

		// Token: 0x06003E02 RID: 15874 RVA: 0x001446EC File Offset: 0x001428EC
		[Token(Token = "0x6003E02")]
		[Address(RVA = "0x84B050", Offset = "0x849650", VA = "0x18084B050")]
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

		// Token: 0x06003E03 RID: 15875 RVA: 0x0014477C File Offset: 0x0014297C
		[Token(Token = "0x6003E03")]
		[Address(RVA = "0x84AD50", Offset = "0x849350", VA = "0x18084AD50")]
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

		// Token: 0x06003E04 RID: 15876 RVA: 0x00144818 File Offset: 0x00142A18
		[Token(Token = "0x6003E04")]
		[Address(RVA = "0x84AA70", Offset = "0x849070", VA = "0x18084AA70")]
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

		// Token: 0x06003E05 RID: 15877 RVA: 0x00144914 File Offset: 0x00142B14
		[Token(Token = "0x6003E05")]
		[Address(RVA = "0x84C230", Offset = "0x84A830", VA = "0x18084C230")]
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

		// Token: 0x06003E06 RID: 15878 RVA: 0x00144994 File Offset: 0x00142B94
		[Token(Token = "0x6003E06")]
		[Address(RVA = "0x84AF00", Offset = "0x849500", VA = "0x18084AF00")]
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

		// Token: 0x06003E07 RID: 15879 RVA: 0x00144A18 File Offset: 0x00142C18
		[Token(Token = "0x6003E07")]
		[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
		public NodeInfoPanel()
		{
		}

		// Token: 0x04002E5E RID: 11870
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002E5E")]
		[SerializeField]
		[Header("UI组件")]
		private GameObject panel;

		// Token: 0x04002E5F RID: 11871
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002E5F")]
		[SerializeField]
		private TextMeshProUGUI titleText;

		// Token: 0x04002E60 RID: 11872
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E60")]
		[SerializeField]
		private TextMeshProUGUI descriptionText;

		// Token: 0x04002E61 RID: 11873
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E61")]
		[Header("变量编辑组件")]
		[SerializeField]
		private GameObject variableEditPanel;

		// Token: 0x04002E62 RID: 11874
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E62")]
		[SerializeField]
		private TextMeshProUGUI variableNameText;

		// Token: 0x04002E63 RID: 11875
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E63")]
		[SerializeField]
		private TMP_InputField nameEditContainer;

		// Token: 0x04002E64 RID: 11876
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002E64")]
		[SerializeField]
		private TMP_InputField intEditContainer;

		// Token: 0x04002E65 RID: 11877
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002E65")]
		[SerializeField]
		private TMP_InputField floatEditContainer;

		// Token: 0x04002E66 RID: 11878
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002E66")]
		[SerializeField]
		private Toggle boolEditContainer;

		// Token: 0x04002E67 RID: 11879
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002E67")]
		[SerializeField]
		private TheButton actionButton;
	}
}
