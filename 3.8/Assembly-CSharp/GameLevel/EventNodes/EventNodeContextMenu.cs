using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B46 RID: 2886
	[Token(Token = "0x2000B46")]
	public class EventNodeContextMenu : MonoBehaviour
	{
		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06003C14 RID: 15380 RVA: 0x0013AEA0 File Offset: 0x001390A0
		// (set) Token: 0x06003C15 RID: 15381 RVA: 0x0013AEB4 File Offset: 0x001390B4
		[Token(Token = "0x170004A3")]
		public static EventNodeContextMenu Instance
		{
			[Token(Token = "0x6003C14")]
			[Address(RVA = "0x7AD810", Offset = "0x7ABE10", VA = "0x1807AD810")]
			get;
			[Token(Token = "0x6003C15")]
			[Address(RVA = "0x7AD850", Offset = "0x7ABE50", VA = "0x1807AD850")]
			private set;
		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x0013AEC8 File Offset: 0x001390C8
		[Token(Token = "0x6003C16")]
		[Address(RVA = "0x7A69A0", Offset = "0x7A4FA0", VA = "0x1807A69A0")]
		private void Awake()
		{
			EventNodeContextMenu.<Instance>k__BackingField = this;
		}

		// Token: 0x06003C17 RID: 15383 RVA: 0x0013AEDC File Offset: 0x001390DC
		[Token(Token = "0x6003C17")]
		[Address(RVA = "0x7AD030", Offset = "0x7AB630", VA = "0x1807AD030")]
		private void Start()
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003C18 RID: 15384 RVA: 0x0013AEFC File Offset: 0x001390FC
		[Token(Token = "0x6003C18")]
		[Address(RVA = "0x7A70F0", Offset = "0x7A56F0", VA = "0x1807A70F0")]
		private void CreateFunctionButtons()
		{
			GameObject gameObject = this.categoryItemPrefab;
			RectTransform rectTransform = this.menuPanel;
			GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, rectTransform);
			Button component = gameObject2.GetComponent<Button>();
			this.copyNodeButton = component;
			Image component2 = gameObject2.GetComponent<Image>();
			this.copyNodeButtonImage = component2;
			TextMeshProUGUI componentInChildren = gameObject2.GetComponentInChildren<TextMeshProUGUI>();
			int num = 0;
			if (componentInChildren != num)
			{
				componentInChildren.text = "复制节点";
			}
			Button button = this.copyNodeButton;
			int num2 = 0;
			if (button != num2)
			{
				Button.ButtonClickedEvent onClick = this.copyNodeButton.m_OnClick;
				UnityAction unityAction = new UnityAction(this.OnCopyNodeClicked);
				onClick.AddListener(unityAction);
			}
			GameObject gameObject3 = this.categoryItemPrefab;
			RectTransform rectTransform2 = this.menuPanel;
			GameObject gameObject4 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject3, rectTransform2);
			Button component3 = gameObject4.GetComponent<Button>();
			this.pasteNodeButton = component3;
			Image component4 = gameObject4.GetComponent<Image>();
			this.pasteNodeButtonImage = component4;
			TextMeshProUGUI componentInChildren2 = gameObject4.GetComponentInChildren<TextMeshProUGUI>();
			int num3 = 0;
			if (componentInChildren2 != num3)
			{
				componentInChildren2.text = "粘贴节点";
			}
			Button button2 = this.pasteNodeButton;
			int num4 = 0;
			if (button2 != num4)
			{
				Button.ButtonClickedEvent onClick2 = this.pasteNodeButton.m_OnClick;
				UnityAction unityAction2 = new UnityAction(this.OnPasteNodeClicked);
				onClick2.AddListener(unityAction2);
			}
			GameObject gameObject5 = this.categoryItemPrefab;
			RectTransform rectTransform3 = this.menuPanel;
			GameObject gameObject6 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject5, rectTransform3);
			Button component5 = gameObject6.GetComponent<Button>();
			this.deleteNodeButton = component5;
			Image component6 = gameObject6.GetComponent<Image>();
			this.deleteNodeButtonImage = component6;
			TextMeshProUGUI componentInChildren3 = gameObject6.GetComponentInChildren<TextMeshProUGUI>();
			int num5 = 0;
			if (componentInChildren3 != num5)
			{
				componentInChildren3.text = "删除节点";
			}
			Button button3 = this.deleteNodeButton;
			int num6 = 0;
			if (button3 != num6)
			{
				Button.ButtonClickedEvent onClick3 = this.deleteNodeButton.m_OnClick;
				UnityAction unityAction3 = new UnityAction(this.OnDeleteNodeClicked);
				onClick3.AddListener(unityAction3);
			}
			GameObject gameObject7 = this.categoryItemPrefab;
			RectTransform rectTransform4 = this.menuPanel;
			GameObject gameObject8 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject7, rectTransform4);
			Button component7 = gameObject8.GetComponent<Button>();
			this.createGroupButton = component7;
			TextMeshProUGUI componentInChildren4 = gameObject8.GetComponentInChildren<TextMeshProUGUI>();
			int num7 = 0;
			if (componentInChildren4 != num7)
			{
				componentInChildren4.text = "创建分组";
			}
			Button button4 = this.createGroupButton;
			int num8 = 0;
			if (button4 != num8)
			{
				Button.ButtonClickedEvent onClick4 = this.createGroupButton.m_OnClick;
				UnityAction unityAction4 = new UnityAction(this.OnCreateGroupClicked);
				onClick4.AddListener(unityAction4);
			}
			GameObject gameObject9 = this.categoryItemPrefab;
			RectTransform rectTransform5 = this.menuPanel;
			GameObject gameObject10 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject9, rectTransform5);
			Button component8 = gameObject10.GetComponent<Button>();
			this.disbandGroupButton = component8;
			TextMeshProUGUI componentInChildren5 = gameObject10.GetComponentInChildren<TextMeshProUGUI>();
			int num9 = 0;
			if (componentInChildren5 != num9)
			{
				componentInChildren5.text = "解散分组";
			}
			Button button5 = this.disbandGroupButton;
			int num10 = 0;
			if (button5 != num10)
			{
				Button.ButtonClickedEvent onClick5 = this.disbandGroupButton.m_OnClick;
				UnityAction unityAction5 = new UnityAction(this.OnDisbandGroupClicked);
				onClick5.AddListener(unityAction5);
			}
			GameObject gameObject11 = this.categoryItemPrefab;
			RectTransform rectTransform6 = this.menuPanel;
			GameObject gameObject12 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject11, rectTransform6);
			Button component9 = gameObject12.GetComponent<Button>();
			this.removeFromGroupButton = component9;
			TextMeshProUGUI componentInChildren6 = gameObject12.GetComponentInChildren<TextMeshProUGUI>();
			int num11 = 0;
			if (componentInChildren6 != num11)
			{
				componentInChildren6.text = "移出分组";
			}
			Button button6 = this.removeFromGroupButton;
			int num12 = 0;
			if (button6 != num12)
			{
				Button.ButtonClickedEvent onClick6 = this.removeFromGroupButton.m_OnClick;
				UnityAction unityAction6 = new UnityAction(this.OnRemoveFromGroupClicked);
				onClick6.AddListener(unityAction6);
			}
			EventNodeDebug.Log("[EventNodeContextMenu] 功能按钮已实例化：创建节点、复制、粘贴、删除、分组");
		}

		// Token: 0x06003C19 RID: 15385 RVA: 0x0013B284 File Offset: 0x00139484
		[Token(Token = "0x6003C19")]
		[Address(RVA = "0x7A9F60", Offset = "0x7A8560", VA = "0x1807A9F60")]
		public void InitializeMenuStructure()
		{
			if (!this.menuStructureCreated)
			{
				Dictionary<int, GameObject> dictionary = this.currentshows;
				int num = 0;
				int num2 = 0;
				dictionary[num2] = num;
				Dictionary<int, GameObject> dictionary2 = this.currentshows;
				int num3 = 0;
				dictionary2[1] = num3;
				this.CreateMenuStructure();
				this.menuStructureCreated = true;
				this.CreateFunctionButtons();
				EventNodeDebug.Log("[EventNodeContextMenu] 菜单结构初始化完成");
				return;
			}
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x0013B2E4 File Offset: 0x001394E4
		[Token(Token = "0x6003C1A")]
		[Address(RVA = "0x7ABF00", Offset = "0x7AA500", VA = "0x1807ABF00")]
		public void SetEditor(RuntimeEventNodeEditor editor)
		{
			this.editor = editor;
			if (!this.menuStructureCreated)
			{
				Dictionary<int, GameObject> dictionary = this.currentshows;
				int num = 0;
				int num2 = 0;
				dictionary[num2] = num;
				Dictionary<int, GameObject> dictionary2 = this.currentshows;
				int num3 = 0;
				uint num4;
				dictionary2[num4] = num3;
				this.CreateMenuStructure();
				this.menuStructureCreated = true;
				this.CreateFunctionButtons();
				EventNodeDebug.Log("[EventNodeContextMenu] 菜单结构初始化完成");
				return;
			}
		}

		// Token: 0x06003C1B RID: 15387 RVA: 0x0013B34C File Offset: 0x0013954C
		[Token(Token = "0x6003C1B")]
		[Address(RVA = "0x7AC9D0", Offset = "0x7AAFD0", VA = "0x1807AC9D0")]
		public void Show(Vector2 localPosition)
		{
			RectTransform rectTransform = this.menuPanel;
			int num = 0;
			bool flag = rectTransform == num;
			if (!flag)
			{
				this.isPortConnectionMode = flag;
				this.RestoreAllMenuItems();
				this.CollapseAllCategories();
				EventNodeDebug.Log("[EventNodeContextMenu] 刷新菜单显示状态");
				int[] array = new int[5];
				array[1] = (int)((ulong)1L);
				this.positions = array;
				RectTransform rectTransform2 = this.menuPanel;
				RectTransform rectTransform3 = this.menuPanel;
				Transform transform = this.editor.transform;
				int num2 = 0;
				if (transform != 0)
				{
				}
				this.menuPanel.pivot = num2;
				this.menuPanel.anchoredPosition = num2;
				this.menuPanel.gameObject.SetActive(true);
				this.isVisible = true;
				Button button = this.copyNodeButton;
				int num3 = 0;
				if (!(button == num3))
				{
					RuntimeEventNodeEditor runtimeEventNodeEditor = this.editor;
					int num4 = 0;
					if (!(runtimeEventNodeEditor == num4))
					{
						bool flag2 = this.editor.HasSelectedNodes();
						this.copyNodeButton.interactable = flag2;
						Image image = this.copyNodeButtonImage;
						int num5 = 0;
						if (image != num5)
						{
							if (flag2)
							{
							}
							Color color = this.disabledColor;
							this.copyNodeButtonImage.color = color;
						}
					}
				}
				Button button2 = this.pasteNodeButton;
				int num6 = 0;
				if (!(button2 == num6))
				{
					RuntimeEventNodeEditor runtimeEventNodeEditor2 = this.editor;
					int num7 = 0;
					if (!(runtimeEventNodeEditor2 == num7))
					{
						bool flag3 = this.editor.HasClipboardContent();
						this.pasteNodeButton.interactable = flag3;
						Image image2 = this.pasteNodeButtonImage;
						int num8 = 0;
						if (image2 != num8)
						{
							if (flag3)
							{
							}
							Color color2 = this.disabledColor;
							this.pasteNodeButtonImage.color = color2;
						}
					}
				}
				Button button3 = this.deleteNodeButton;
				int num9 = 0;
				if (!(button3 == num9))
				{
					RuntimeEventNodeEditor runtimeEventNodeEditor3 = this.editor;
					int num10 = 0;
					if (!(runtimeEventNodeEditor3 == num10))
					{
						bool flag4 = this.editor.HasSelectedNodes();
						this.deleteNodeButton.interactable = flag4;
						Image image3 = this.deleteNodeButtonImage;
						int num11 = 0;
						if (image3 != num11)
						{
							if (flag4)
							{
							}
							Color color3 = this.disabledColor;
							this.deleteNodeButtonImage.color = color3;
						}
					}
				}
				this.UpdateGroupButtonState();
			}
		}

		// Token: 0x06003C1C RID: 15388 RVA: 0x0013B578 File Offset: 0x00139778
		[Token(Token = "0x6003C1C")]
		[Address(RVA = "0x7ABFF0", Offset = "0x7AA5F0", VA = "0x1807ABFF0")]
		public void ShowFilteredMenu(Vector2 localPosition, PortType portType, bool isInput, RuntimeNodeUI sourceNodeUI, PortDefinition sourcePort, Vector2 dragEndScreenPos)
		{
			RectTransform rectTransform = this.menuPanel;
			int num = 0;
			if (!(rectTransform == num))
			{
				this.isPortConnectionMode = true;
				this.connectionPortType = portType;
				this.connectionIsInput = isInput;
				this.connectionSourceNodeUI = 0;
				this.connectionSourcePort = 0;
				this.CollapseAllCategories();
				EventNodeDebug.Log("[EventNodeContextMenu] 刷新菜单显示状态");
				int[] array = new int[5];
				array[1] = (int)((ulong)1L);
				this.positions = array;
				RectTransform rectTransform2 = this.menuPanel;
				RectTransform rectTransform3 = this.menuPanel;
				Transform transform = this.editor.transform;
				int num2 = 0;
				if (transform != 0)
				{
				}
				this.menuPanel.pivot = num2;
				this.menuPanel.anchoredPosition = num2;
				this.menuPanel.gameObject.SetActive(true);
				this.isVisible = true;
				this.HideFunctionButtons();
			}
		}

		// Token: 0x06003C1D RID: 15389 RVA: 0x0013B64C File Offset: 0x0013984C
		[Token(Token = "0x6003C1D")]
		[Address(RVA = "0x7AD220", Offset = "0x7AB820", VA = "0x1807AD220")]
		private void UpdateDeleteButtonState()
		{
			Button button = this.deleteNodeButton;
			int num = 0;
			if (!(button == num))
			{
				RuntimeEventNodeEditor runtimeEventNodeEditor = this.editor;
				int num2 = 0;
				if (!(runtimeEventNodeEditor == num2))
				{
					bool flag = this.editor.HasSelectedNodes();
					this.deleteNodeButton.interactable = flag;
					Image image = this.deleteNodeButtonImage;
					int num3 = 0;
					if (image != num3)
					{
						if (flag)
						{
						}
						Color color = this.disabledColor;
						this.deleteNodeButtonImage.color = color;
					}
				}
			}
		}

		// Token: 0x06003C1E RID: 15390 RVA: 0x0013B6D0 File Offset: 0x001398D0
		[Token(Token = "0x6003C1E")]
		[Address(RVA = "0x7AD0E0", Offset = "0x7AB6E0", VA = "0x1807AD0E0")]
		private void UpdateCopyButtonState()
		{
			Button button = this.copyNodeButton;
			int num = 0;
			if (!(button == num))
			{
				RuntimeEventNodeEditor runtimeEventNodeEditor = this.editor;
				int num2 = 0;
				if (!(runtimeEventNodeEditor == num2))
				{
					bool flag = this.editor.HasSelectedNodes();
					this.copyNodeButton.interactable = flag;
					Image image = this.copyNodeButtonImage;
					int num3 = 0;
					if (image != num3)
					{
						if (flag)
						{
						}
						Color color = this.disabledColor;
						this.copyNodeButtonImage.color = color;
					}
				}
			}
		}

		// Token: 0x06003C1F RID: 15391 RVA: 0x0013B754 File Offset: 0x00139954
		[Token(Token = "0x6003C1F")]
		[Address(RVA = "0x7AD5C0", Offset = "0x7ABBC0", VA = "0x1807AD5C0")]
		private void UpdatePasteButtonState()
		{
			Button button = this.pasteNodeButton;
			int num = 0;
			if (!(button == num))
			{
				RuntimeEventNodeEditor runtimeEventNodeEditor = this.editor;
				int num2 = 0;
				if (!(runtimeEventNodeEditor == num2))
				{
					bool flag = this.editor.HasClipboardContent();
					this.pasteNodeButton.interactable = flag;
					Image image = this.pasteNodeButtonImage;
					int num3 = 0;
					if (image != num3)
					{
						if (flag)
						{
						}
						Color color = this.disabledColor;
						this.pasteNodeButtonImage.color = color;
					}
				}
			}
		}

		// Token: 0x06003C20 RID: 15392 RVA: 0x0013B7D8 File Offset: 0x001399D8
		[Token(Token = "0x6003C20")]
		[Address(RVA = "0x7A9E80", Offset = "0x7A8480", VA = "0x1807A9E80")]
		public void Hide()
		{
			RectTransform rectTransform = this.menuPanel;
			int num = 0;
			if (rectTransform != num)
			{
				GameObject gameObject = this.menuPanel.gameObject;
				int num2 = 0;
				gameObject.SetActive(num2 != 0);
			}
			this.isVisible = false;
			int[] array = new int[5];
			this.positions = array;
			this.CollapseAllCategories();
			this.ShowFunctionButtons();
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x0013B838 File Offset: 0x00139A38
		[Token(Token = "0x6003C21")]
		[Address(RVA = "0x7A7950", Offset = "0x7A5F50", VA = "0x1807A7950")]
		private void CreateMenuStructure()
		{
			for (;;)
			{
				int num = 0;
				GameObject gameObject = this.categoryItemPrefab;
				RectTransform rectTransform = this.menuPanel;
				GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, rectTransform);
				gameObject2.GetComponentInChildren<TextMeshProUGUI>().text = "创建节点";
				Transform transform = gameObject2.transform.Find("childs");
				RectTransform parentRect;
				if (transform == 0)
				{
					parentRect = num;
				}
				parentRect = transform;
				if (gameObject2.TryGetComponent<Button>(num))
				{
					UnityAction unityAction = delegate
					{
						Dictionary<int, GameObject> dictionary2 = this.currentshows;
						int num4 = 0;
						GameObject gameObject4 = dictionary2[num4];
						int num5 = 0;
						if (gameObject4 != num5)
						{
							Dictionary<int, GameObject> dictionary3 = this.currentshows;
							int num6 = 0;
							GameObject gameObject5 = dictionary3[num6];
							int num7 = 0;
							gameObject5.SetActive(num7 != 0);
						}
						EventNodeContextMenu <>4__this = this;
						RectTransform parentRect3 = parentRect;
						Dictionary<int, GameObject> dictionary4 = <>4__this.currentshows;
						GameObject gameObject6 = parentRect3.gameObject;
						int num8 = 0;
						dictionary4[num8] = gameObject6;
						parentRect.gameObject.SetActive(true);
						EventNodeContextMenu <>4__this2 = this;
						RectTransform parentRect2 = parentRect;
						<>4__this2.PositionCategoryContainer(parentRect2, 2);
					};
				}
				Dictionary<string, List<NodeTypeInfo>> dictionary = new Dictionary();
				if (NodeTypeRegistry.GetAllNodeTypes() != 0)
				{
					if (num >= typeof(IEnumerator).TypeHandle)
					{
						goto IL_00A9;
					}
					num += num;
					if (num != typeof(IEnumerator).TypeHandle)
					{
						num++;
						goto IL_00A9;
					}
					IL_00BB:
					List<NodeTypeInfo> list;
					list += list;
					goto IL_00C2;
					IL_00A9:
					if (!dictionary.ContainsKey(num))
					{
						List<NodeTypeInfo> list2 = new List();
						goto IL_00BB;
					}
					goto IL_00BB;
				}
				IL_00C2:
				if ("{il2cpp array field local22->}" != (ulong)0L)
				{
				}
				if (num == 0)
				{
					int num2 = 0;
					bool flag;
					if (flag)
					{
					}
					if (num2 == 0)
					{
						break;
					}
				}
			}
			GameObject gameObject3 = CS$<>8__locals1.parentRect.gameObject;
			int num3 = 0;
			gameObject3.SetActive(num3 != 0);
		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x0013B968 File Offset: 0x00139B68
		[Token(Token = "0x6003C22")]
		[Address(RVA = "0x7A6BF0", Offset = "0x7A51F0", VA = "0x1807A6BF0")]
		private void CreateCategoryMenuItem(string categoryName, List<NodeTypeInfo> nodes, Transform parent)
		{
			int num;
			GameObject gameObject;
			do
			{
				num = 0;
				int num2 = 0;
				gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.categoryItemPrefab, parent);
				gameObject.SetActive(true);
				TextMeshProUGUI componentInChildren = gameObject.GetComponentInChildren<TextMeshProUGUI>();
				int num3 = 0;
				if (componentInChildren != num3)
				{
					componentInChildren.text = categoryName;
					Color color = this.categoryTextColor;
					componentInChildren.color = color;
				}
				if (gameObject.TryGetComponent<Image>(num))
				{
					Color color2 = this.categoryColor;
				}
				Transform transform = gameObject.transform.Find("childs");
				RectTransform nodeContainer;
				if (transform == 0)
				{
					nodeContainer = num;
				}
				nodeContainer = transform;
				global::UnityEngine.Object.DestroyImmediate(nodeContainer.GetComponent<VerticalLayoutGroup>());
				GridLayoutGroup gridLayoutGroup = nodeContainer.AddComponent<GridLayoutGroup>();
				gridLayoutGroup.constraint = (GridLayoutGroup.Constraint)((uint)1);
				gridLayoutGroup.constraintCount = 2;
				bool flag;
				if (flag)
				{
					RectTransform nodeContainer3 = nodeContainer;
					this.CreateNodeMenuItem(num2, nodeContainer3);
				}
			}
			while (num != 0);
			RectTransform nodeContainer2 = CS$<>8__locals1.nodeContainer;
			int num4 = 0;
			if (nodeContainer2 != num4)
			{
				GameObject gameObject2 = CS$<>8__locals1.nodeContainer.gameObject;
				int num5 = 0;
				gameObject2.SetActive(num5 != 0);
			}
			if (gameObject.TryGetComponent<Button>(num))
			{
				Transform transform2 = gameObject.transform;
				UnityAction unityAction = delegate
				{
					GameObject gameObject3 = CS$<>8__locals1.<>4__this.currentshows[1];
					int num6 = 0;
					if (gameObject3 != num6)
					{
						GameObject gameObject4 = CS$<>8__locals1.<>4__this.currentshows[1];
						int num7 = 0;
						gameObject4.SetActive(num7 != 0);
					}
					EventNodeContextMenu <>4__this = CS$<>8__locals1.<>4__this;
					RectTransform nodeContainer4 = CS$<>8__locals1.nodeContainer;
					Dictionary<int, GameObject> dictionary = <>4__this.currentshows;
					GameObject gameObject5 = nodeContainer4.gameObject;
					dictionary[1] = gameObject5;
					CS$<>8__locals1.nodeContainer.gameObject.SetActive(true);
					EventNodeContextMenu <>4__this2 = CS$<>8__locals1.<>4__this;
					RectTransform nodeContainer5 = CS$<>8__locals1.nodeContainer;
					<>4__this2.PositionCategoryContainer(nodeContainer5, 3);
				};
			}
		}

		// Token: 0x06003C23 RID: 15395 RVA: 0x0013BAB0 File Offset: 0x00139CB0
		[Token(Token = "0x6003C23")]
		[Address(RVA = "0x7A6A00", Offset = "0x7A5000", VA = "0x1807A6A00")]
		private void CollapseAllCategories()
		{
			ulong num;
			do
			{
				List<KeyValuePair<int, GameObject>> list = Enumerable.ToList<KeyValuePair<int, GameObject>>(this.currentshows);
				bool flag;
				if (flag)
				{
					bool flag2;
					while (!flag2)
					{
					}
					Dictionary<int, GameObject> dictionary = this.currentshows;
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x06003C24 RID: 15396 RVA: 0x0013BAF4 File Offset: 0x00139CF4
		[Token(Token = "0x6003C24")]
		[Address(RVA = "0x7AB390", Offset = "0x7A9990", VA = "0x1807AB390")]
		private void RefreshMenuDisplay()
		{
			this.CollapseAllCategories();
			EventNodeDebug.Log("[EventNodeContextMenu] 刷新菜单显示状态");
		}

		// Token: 0x06003C25 RID: 15397 RVA: 0x0013BB14 File Offset: 0x00139D14
		[Token(Token = "0x6003C25")]
		[Address(RVA = "0x7A9CD0", Offset = "0x7A82D0", VA = "0x1807A9CD0")]
		private void HideFunctionButtons()
		{
			Button button = this.copyNodeButton;
			int num = 0;
			if (button != num && this.copyNodeButton.gameObject.activeSelf)
			{
				GameObject gameObject = this.copyNodeButton.gameObject;
				int num2 = 0;
				gameObject.SetActive(num2 != 0);
			}
			Button button2 = this.pasteNodeButton;
			int num3 = 0;
			if (button2 != num3 && this.pasteNodeButton.gameObject.activeSelf)
			{
				GameObject gameObject2 = this.pasteNodeButton.gameObject;
				int num4 = 0;
				gameObject2.SetActive(num4 != 0);
			}
			Button button3 = this.deleteNodeButton;
			int num5 = 0;
			if (button3 != num5 && this.deleteNodeButton.gameObject.activeSelf)
			{
				GameObject gameObject3 = this.deleteNodeButton.gameObject;
				int num6 = 0;
				gameObject3.SetActive(num6 != 0);
			}
		}

		// Token: 0x06003C26 RID: 15398 RVA: 0x0013BBE8 File Offset: 0x00139DE8
		[Token(Token = "0x6003C26")]
		[Address(RVA = "0x7AC3A0", Offset = "0x7AA9A0", VA = "0x1807AC3A0")]
		private void ShowFunctionButtons()
		{
			Button button = this.copyNodeButton;
			int num = 0;
			if (button != num && !this.copyNodeButton.gameObject.activeSelf)
			{
				this.copyNodeButton.gameObject.SetActive(true);
			}
			Button button2 = this.pasteNodeButton;
			int num2 = 0;
			if (button2 != num2 && !this.pasteNodeButton.gameObject.activeSelf)
			{
				this.pasteNodeButton.gameObject.SetActive(true);
			}
			Button button3 = this.deleteNodeButton;
			int num3 = 0;
			if (button3 != num3 && !this.deleteNodeButton.gameObject.activeSelf)
			{
				this.deleteNodeButton.gameObject.SetActive(true);
			}
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x0013BCA4 File Offset: 0x00139EA4
		[Token(Token = "0x6003C27")]
		[Address(RVA = "0x7A8A60", Offset = "0x7A7060", VA = "0x1807A8A60")]
		private void FilterExistingMenuStructure(PortType portType, bool isInput, RuntimeNodeUI sourceNodeUI, PortDefinition sourcePort)
		{
			for (;;)
			{
				int num = 0;
				IEnumerator enumerator = this.menuPanel.GetEnumerator();
				int num2 = 0;
				if (num2 < typeof(IEnumerator).TypeHandle)
				{
					num2 += num2;
					num2++;
				}
				enumerator += enumerator;
				string text;
				if (!text.Contains("Button"))
				{
					TextMeshProUGUI textMeshProUGUI;
					if (textMeshProUGUI != 0)
					{
						string text2 = textMeshProUGUI.text;
					}
					int num3 = 0;
					while (num3 != 0)
					{
					}
					TextMeshProUGUI textMeshProUGUI2;
					if (textMeshProUGUI2 != 0)
					{
						string text3 = textMeshProUGUI2.text;
					}
					while (num3 != 0)
					{
					}
					TextMeshProUGUI textMeshProUGUI3;
					if (textMeshProUGUI3 != 0)
					{
						string text4 = textMeshProUGUI3.text;
					}
					while (num3 != 0)
					{
					}
					int num4 = 0;
					TextMeshProUGUI textMeshProUGUI4;
					if (textMeshProUGUI4 != num4 && textMeshProUGUI4.text != 0)
					{
						Transform transform2;
						Transform transform = transform2.Find("childs");
						int num5 = 0;
						if (transform != num5 && num == 0)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x0013BD94 File Offset: 0x00139F94
		[Token(Token = "0x6003C28")]
		[Address(RVA = "0x7A8480", Offset = "0x7A6A80", VA = "0x1807A8480")]
		private void FilterCategoryMenu(Transform categoryContainer, PortType portType, bool isInput, RuntimeNodeUI sourceNodeUI, PortDefinition sourcePort)
		{
			int num2;
			for (;;)
			{
				int num = 0;
				num2 = 0;
				IEnumerator enumerator = categoryContainer.GetEnumerator();
				int num3 = 0;
				if (num3 < typeof(IEnumerator).TypeHandle)
				{
					num3 += num3;
					num3++;
				}
				enumerator += enumerator;
				int num4 = 0;
				Button button;
				if (!(button == num4))
				{
					int num5 = 0;
					TextMeshProUGUI textMeshProUGUI;
					if (!(textMeshProUGUI == num5))
					{
						int num6 = 0;
						Transform transform;
						if (!(transform == num6))
						{
							bool flag;
							if (flag)
							{
								ulong num7;
								button.interactable = num7 != 0UL;
								int num8 = 0;
								Image image;
								if (image != num8)
								{
									Color color = this.categoryColor;
									Image image2;
									image2.color = color;
								}
								int num9 = 0;
								if (!(textMeshProUGUI != num9))
								{
									continue;
								}
								Color color2 = this.categoryTextColor;
							}
							int num10 = 0;
							Image image3;
							if (image3 != num10)
							{
								Color color3 = this.disabledColor;
								Image image4;
								image4.color = color3;
							}
							int num11 = 0;
							if (textMeshProUGUI != num11)
							{
								float g = this.disabledColor.g;
								if (num == 0)
								{
									break;
								}
							}
						}
					}
				}
			}
			if (num2 == 0)
			{
				EventNodeDebug.Log("[EventNodeContextMenu] 没有可连接的节点");
			}
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x0013BED4 File Offset: 0x0013A0D4
		[Token(Token = "0x6003C29")]
		[Address(RVA = "0x7A8F00", Offset = "0x7A7500", VA = "0x1807A8F00")]
		private bool FilterNodeMenu(Transform nodeContainer, PortType portType, bool isInput, RuntimeNodeUI sourceNodeUI, PortDefinition sourcePort)
		{
			for (;;)
			{
				IEnumerator enumerator = nodeContainer.GetEnumerator();
				int num = 0;
				Button button;
				if (!(button == num))
				{
					int num2 = 0;
					TextMeshProUGUI textMeshProUGUI;
					if (!(textMeshProUGUI == num2))
					{
						string nodeTypeNameFromButton = this.GetNodeTypeNameFromButton(button);
						string nodeTypeName = nodeTypeNameFromButton;
						if (!string.IsNullOrEmpty(nodeTypeName))
						{
							IEnumerable<NodeTypeInfo> allNodeTypes = NodeTypeRegistry.GetAllNodeTypes();
							if (allNodeTypes != 0)
							{
								while (allNodeTypes == 0)
								{
								}
							}
							if ("{il2cpp array field local36->}" != (ulong)0L)
							{
							}
							ulong num3;
							if (num3 != (ulong)0L)
							{
								goto IL_0181;
							}
							bool flag;
							if (!flag)
							{
								int num4 = 0;
								button.interactable = num4 != 0;
								int num5 = 0;
								Image image;
								if (image != num5)
								{
								}
								int num6 = 0;
								if (!(textMeshProUGUI != num6))
								{
									continue;
								}
								float g = this.disabledColor.g;
							}
							button.interactable = true;
							int num7 = 0;
							Image image2;
							if (image2 != num7)
							{
							}
							int num8 = 0;
							if (textMeshProUGUI != num8)
							{
							}
							Button.ButtonClickedEvent buttonClickedEvent = new Button.ButtonClickedEvent();
							button.m_OnClick = buttonClickedEvent;
							string nodeTypeName3 = this.nodeTypeName;
							string nodeName = nodeTypeName3;
							Button.ButtonClickedEvent onClick = button.m_OnClick;
							UnityAction unityAction = delegate
							{
								EventNodeContextMenu <>4__this = this.<>4__this;
								string nodeName4 = nodeName;
								<>4__this.CreateNode(nodeName4);
							};
							onClick.AddListener(unityAction);
							Button.ButtonClickedEvent onClick2 = button.m_OnClick;
							UnityAction unityAction2 = delegate
							{
								Vector2 spawnPosition = unityAction.<>4__this.GetSpawnPosition();
								RuntimeEventNodeEditor runtimeEventNodeEditor = unityAction.<>4__this.editor;
								string nodeTypeName2 = unityAction.nodeTypeName;
								runtimeEventNodeEditor.CreateNodeByType(nodeTypeName2, spawnPosition);
								RuntimeNodeUI latestNodeUI = unityAction.<>4__this.editor.GetLatestNodeUI();
								int num10 = 0;
								if (latestNodeUI != num10)
								{
									EventNodeContextMenu <>4__this2 = unityAction.<>4__this;
									PortType portType2 = <>4__this2.connectionPortType;
									EventNodeBase <Node>k__BackingField = latestNodeUI.<Node>k__BackingField;
									bool flag2 = !<>4__this2.connectionIsInput;
									if (<>4__this2.FindAvailablePort(<Node>k__BackingField, portType2, flag2) != 0)
									{
										RuntimeEventNodeEditor runtimeEventNodeEditor2 = unityAction.<>4__this.editor;
										string[] array = new string[8];
										array[0] = "[EventNodeContextMenu] 自动连接成功: ";
										string nodeName2 = unityAction.<>4__this.connectionSourceNodeUI.<Node>k__BackingField.nodeName;
										array[1] = nodeName2;
										array[2] = ".";
										string portName = unityAction.<>4__this.connectionSourcePort.portName;
										array[3] = portName;
										array[4] = " → ";
										array[5] = " → ";
										array[6] = ".";
										array[7] = ".";
										EventNodeDebug.Log(string.Concat(array));
										throw new NullReferenceException();
									}
									string nodeName3 = latestNodeUI.<Node>k__BackingField.nodeName;
									PortType portType3 = unityAction.<>4__this.connectionPortType;
									EventNodeDebug.LogWarning(string.Format("[EventNodeContextMenu] 节点 {0} 没有可用的 {1} 端口", nodeName3, portType3));
								}
								unityAction.<>4__this.Hide();
								unityAction.<>4__this.ShowFunctionButtons();
							};
							onClick2.AddListener(unityAction2);
							ulong num9;
							if (num9 == (ulong)0L)
							{
								break;
							}
						}
					}
				}
			}
			throw new NullReferenceException();
			IL_0181:
			throw new NullReferenceException();
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x0013C0C4 File Offset: 0x0013A2C4
		[Token(Token = "0x6003C2A")]
		[Address(RVA = "0x7A98C0", Offset = "0x7A7EC0", VA = "0x1807A98C0")]
		private string GetNodeTypeNameFromButton(Button button)
		{
			int num = 0;
			if (!(button == num))
			{
				GameObject gameObject = button.gameObject;
				int num2 = 0;
				if (!(gameObject == num2) && button.gameObject.name.StartsWith("NodeItem_"))
				{
					string text;
					return text;
				}
			}
			throw new NullReferenceException();
		}

		// Token: 0x06003C2B RID: 15403 RVA: 0x0013C114 File Offset: 0x0013A314
		[Token(Token = "0x6003C2B")]
		[Address(RVA = "0x7AB400", Offset = "0x7A9A00", VA = "0x1807AB400")]
		private void RestoreAllMenuItems()
		{
			int num;
			do
			{
				num = 0;
				IEnumerator enumerator = this.menuPanel.GetEnumerator();
				if (enumerator != 0)
				{
					if (num < typeof(IEnumerator).TypeHandle)
					{
						num += num;
						num++;
					}
					Transform transform2;
					Transform transform = transform2.Find("childs");
					int num2 = 0;
					if (!(transform != num2))
					{
						continue;
					}
					this.RestoreCategoryMenu(transform);
				}
				if (enumerator != 0)
				{
				}
			}
			while (num != 0);
		}

		// Token: 0x06003C2C RID: 15404 RVA: 0x0013C18C File Offset: 0x0013A38C
		[Token(Token = "0x6003C2C")]
		[Address(RVA = "0x7AB670", Offset = "0x7A9C70", VA = "0x1807AB670")]
		private void RestoreCategoryMenu(Transform categoryContainer)
		{
			int num;
			do
			{
				num = 0;
				IEnumerator enumerator = categoryContainer.GetEnumerator();
				if (enumerator != 0)
				{
					if (num < typeof(IEnumerator).TypeHandle)
					{
						num += num;
						num++;
					}
					enumerator += enumerator;
					int num2 = 0;
					Button button;
					if (button != num2)
					{
						ulong num3;
						button.interactable = num3 != 0UL;
					}
					int num4 = 0;
					Image image;
					if (image != num4)
					{
						Color color = this.categoryColor;
						Image image2;
						image2.color = color;
					}
					int num5 = 0;
					TextMeshProUGUI textMeshProUGUI;
					if (textMeshProUGUI != num5)
					{
						Color color2 = this.categoryTextColor;
						textMeshProUGUI.color = color2;
					}
					int num6 = 0;
					Transform transform;
					if (!(transform != num6))
					{
						continue;
					}
					this.RestoreNodeMenu(transform);
				}
				if (enumerator != 0)
				{
				}
			}
			while (num != 0);
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x0013C264 File Offset: 0x0013A464
		[Token(Token = "0x6003C2D")]
		[Address(RVA = "0x7ABA60", Offset = "0x7AA060", VA = "0x1807ABA60")]
		private void RestoreNodeMenu(Transform nodeContainer)
		{
			int num;
			do
			{
				num = 0;
				IEnumerator enumerator = nodeContainer.GetEnumerator();
				if (enumerator != 0)
				{
					if (num < typeof(IEnumerator).TypeHandle)
					{
						num += num;
						num++;
					}
					enumerator += enumerator;
					int num2 = 0;
					Button button;
					if (button != num2)
					{
						ulong num3;
						button.interactable = num3 != 0UL;
						string nodeTypeNameFromButton = this.GetNodeTypeNameFromButton(button);
						string nodeTypeName = nodeTypeNameFromButton;
						if (!string.IsNullOrEmpty(nodeTypeName))
						{
							Button.ButtonClickedEvent buttonClickedEvent = new Button.ButtonClickedEvent();
							button.m_OnClick = buttonClickedEvent;
							Button.ButtonClickedEvent onClick = button.m_OnClick;
							UnityAction unityAction = delegate
							{
								EventNodeContextMenu <>4__this = this;
								string nodeTypeName2 = nodeTypeName;
								<>4__this.CreateNode(nodeTypeName2);
							};
							onClick.AddListener(unityAction);
						}
					}
					int num4 = 0;
					Image image;
					if (image != num4)
					{
					}
					int num5 = 0;
					TextMeshProUGUI textMeshProUGUI;
					if (!(textMeshProUGUI != num5))
					{
						continue;
					}
				}
				if (enumerator != 0)
				{
				}
			}
			while (num != 0);
		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x0013C370 File Offset: 0x0013A570
		[Token(Token = "0x6003C2E")]
		[Address(RVA = "0x7A9BA0", Offset = "0x7A81A0", VA = "0x1807A9BA0")]
		private bool HasAvailablePort(NodeTypeInfo nodeType, PortType targetPortType, bool targetIsInput)
		{
			EventNodeBase eventNodeBase = NodeTypeRegistry.CreateNode(nodeType.typeName);
			if (eventNodeBase != 0)
			{
				if (targetIsInput)
				{
					PortDefinition[] outputPorts = eventNodeBase.GetOutputPorts();
				}
				PortDefinition[] inputPorts = eventNodeBase.GetInputPorts();
				int num = 0;
				bool flag;
				if (num < inputPorts.Length && flag)
				{
					num++;
				}
			}
			throw new NullReferenceException();
		}

		// Token: 0x06003C2F RID: 15407 RVA: 0x0013C3C0 File Offset: 0x0013A5C0
		[Token(Token = "0x6003C2F")]
		[Address(RVA = "0x7A97D0", Offset = "0x7A7DD0", VA = "0x1807A97D0")]
		private PortDefinition FindAvailablePort(EventNodeBase node, PortType targetType, bool isInput)
		{
			if (isInput)
			{
			}
			PortDefinition[] outputPorts = node.GetOutputPorts();
			int num = 0;
			int num2 = 0;
			bool flag;
			if (num2 < outputPorts.Length && flag)
			{
				num++;
			}
			throw new NullReferenceException();
		}

		// Token: 0x06003C30 RID: 15408 RVA: 0x0013C3FC File Offset: 0x0013A5FC
		[Token(Token = "0x6003C30")]
		[Address(RVA = "0x7AA040", Offset = "0x7A8640", VA = "0x1807AA040")]
		private bool IsPortInUse(EventNodeBase node, PortDefinition port, bool isInput)
		{
			ulong num2;
			do
			{
				RuntimeEventNodeEditor runtimeEventNodeEditor = this.editor;
				int num = 0;
				if (runtimeEventNodeEditor == num)
				{
					break;
				}
				RuntimeEventNodeEditor runtimeEventNodeEditor2 = this.editor;
				if (runtimeEventNodeEditor2.graph == (ulong)0L)
				{
					break;
				}
				List<NodeConnection> connections = runtimeEventNodeEditor2.graph.connections;
				bool flag;
				if (flag)
				{
					if (!isInput)
					{
						while (!flag)
						{
						}
						while (!flag)
						{
						}
					}
					while (!flag)
					{
					}
					while (!flag)
					{
					}
				}
			}
			while (num2 != (ulong)0L);
			throw new NullReferenceException();
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x0013C490 File Offset: 0x0013A690
		[Token(Token = "0x6003C31")]
		[Address(RVA = "0x7AAB60", Offset = "0x7A9160", VA = "0x1807AAB60")]
		private void PositionCategoryContainer(RectTransform container, int level)
		{
			int num = 0;
			LayoutRebuilder.ForceRebuildLayoutImmediate(container);
			int[] array = this.positions;
			if (num < array.Length)
			{
				int[] array2 = this.positions;
				uint num2;
				num2.m_value = (uint)num;
				int num3;
				int num4;
				EventNodeDebug.Log(string.Format("[PositionCategoryContainer] 清除索引{0}中的level={1}菜单", num3, num4));
				int[] array3 = this.positions;
				num++;
				num2 += (uint)4;
			}
			if (this.editor.transform != 0)
			{
			}
			int num5 = level - 1;
			int[] array4 = this.positions;
			int[] array5 = this.positions;
			int length;
			int num6 = length + 1;
			num5 = num6;
			num5 += 8;
			num6++;
			num5 += 4;
			length = array5.Length;
			array5[0] = num;
			EventNodeDebug.LogWarning("右侧没有空位，清空并使用最右边的位置");
			if (level != 3)
			{
			}
			Vector2 vector;
			container.pivot = vector;
			container.anchoredPosition = vector;
			if (level == 3)
			{
			}
			this.positions[0] = num;
			EventNodeDebug.LogWarning("左侧没有空位，清空并使用最左边的位置");
			this.positions[0] = level;
			if (level == 2 || level == 3)
			{
				int num7 = 0;
				Vector2 anchoredPosition = container.anchoredPosition;
				container.anchoredPosition = num7;
				float num8;
				EventNodeDebug.Log(string.Format("[PositionCategoryContainer] 空间不足，向下移动 {0}", num8));
				if (level == 3)
				{
					Vector2 pivot = container.pivot;
					Vector2 pivot2 = container.pivot;
					Vector2 vector2;
					container.pivot = vector2;
				}
			}
		}

		// Token: 0x06003C32 RID: 15410 RVA: 0x0013C5F8 File Offset: 0x0013A7F8
		[Token(Token = "0x6003C32")]
		[Address(RVA = "0x7A7FC0", Offset = "0x7A65C0", VA = "0x1807A7FC0")]
		private void CreateNodeMenuItem(NodeTypeInfo nodeType, Transform parent)
		{
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.categoryItemPrefab, parent);
			string typeName = nodeType.typeName;
			string text = "NodeItem_" + typeName;
			gameObject.name = text;
			TextMeshProUGUI componentInChildren = gameObject.GetComponentInChildren<TextMeshProUGUI>();
			int num = 0;
			if (componentInChildren != num)
			{
				string displayName = nodeType.displayName;
				componentInChildren.text = displayName;
			}
			bool flag;
			if (flag)
			{
				string typeName2 = nodeType.typeName;
				string nodeTypeName = typeName2;
				UnityAction unityAction = delegate
				{
					EventNodeContextMenu <>4__this = this;
					string nodeTypeName2 = nodeTypeName;
					<>4__this.CreateNode(nodeTypeName2);
				};
			}
			gameObject.SetActive(true);
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x0013C694 File Offset: 0x0013A894
		[Token(Token = "0x6003C33")]
		[Address(RVA = "0x7A81E0", Offset = "0x7A67E0", VA = "0x1807A81E0")]
		private void CreateNode(string nodeTypeName)
		{
			RuntimeEventNodeEditor runtimeEventNodeEditor = this.editor;
			int num = 0;
			if (runtimeEventNodeEditor != num)
			{
				int num2 = 0;
				if ((this.isPortConnectionMode ? 1 : 0) != num2)
				{
					RectTransform nodeContainer = RuntimeEventNodeEditor.Instance.nodeContainer;
					Camera main = Camera.main;
					if (RectTransformUtility.ScreenPointToLocalPointInRectangle(nodeContainer, num, main, num2))
					{
					}
				}
				RectTransform nodeContainer2 = RuntimeEventNodeEditor.Instance.nodeContainer;
				int num3 = 0;
				Vector3 mousePosition = Input.mousePosition;
				Camera main2 = Camera.main;
				if (!RectTransformUtility.ScreenPointToLocalPointInRectangle(nodeContainer2, num3, main2, num2))
				{
					Vector2 anchoredPosition = this.menuPanel.anchoredPosition;
				}
				RuntimeEventNodeEditor runtimeEventNodeEditor2 = this.editor;
				EventNodeDebug.Log("[EventNodeContextMenu] 创建节点: " + nodeTypeName);
			}
			this.Hide();
		}

		// Token: 0x06003C34 RID: 15412 RVA: 0x0013C748 File Offset: 0x0013A948
		[Token(Token = "0x6003C34")]
		[Address(RVA = "0x7A99D0", Offset = "0x7A7FD0", VA = "0x1807A99D0")]
		private Vector2 GetSpawnPosition()
		{
			int num = 0;
			if ((this.isPortConnectionMode ? 1 : 0) != num)
			{
				RectTransform nodeContainer = RuntimeEventNodeEditor.Instance.nodeContainer;
				Camera main = Camera.main;
				bool flag;
				if (flag)
				{
				}
			}
			RectTransform nodeContainer2 = RuntimeEventNodeEditor.Instance.nodeContainer;
			int num2 = 0;
			Vector3 mousePosition = Input.mousePosition;
			Camera main2 = Camera.main;
			if (!RectTransformUtility.ScreenPointToLocalPointInRectangle(nodeContainer2, num2, main2, num))
			{
				Vector2 anchoredPosition = this.menuPanel.anchoredPosition;
			}
			throw new NullReferenceException();
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x0013C7C4 File Offset: 0x0013A9C4
		[Token(Token = "0x6003C35")]
		[Address(RVA = "0x7AA2B0", Offset = "0x7A88B0", VA = "0x1807AA2B0")]
		private void OnCopyNodeClicked()
		{
			RuntimeEventNodeEditor runtimeEventNodeEditor = this.editor;
			int num = 0;
			if (!(runtimeEventNodeEditor == num))
			{
				this.editor.CopySelectedNodes();
				this.Hide();
			}
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x0013C7FC File Offset: 0x0013A9FC
		[Token(Token = "0x6003C36")]
		[Address(RVA = "0x7AAA10", Offset = "0x7A9010", VA = "0x1807AAA10")]
		private void OnPasteNodeClicked()
		{
			RuntimeEventNodeEditor runtimeEventNodeEditor = this.editor;
			int num = 0;
			if (!(runtimeEventNodeEditor == num))
			{
				this.editor.PasteNodes();
				this.Hide();
			}
		}

		// Token: 0x06003C37 RID: 15415 RVA: 0x0013C834 File Offset: 0x0013AA34
		[Token(Token = "0x6003C37")]
		[Address(RVA = "0x7AA590", Offset = "0x7A8B90", VA = "0x1807AA590")]
		private void OnDeleteNodeClicked()
		{
			ulong num5;
			do
			{
				int num = 0;
				RuntimeEventNodeEditor runtimeEventNodeEditor = this.editor;
				int num2 = 0;
				if (runtimeEventNodeEditor == num2)
				{
					break;
				}
				List<RuntimeNodeUI> selectedNodes = this.editor.GetSelectedNodes();
				List<string> list = new List();
				bool flag;
				if (flag)
				{
					int num3 = 0;
					if (!(num != num3))
					{
						continue;
					}
				}
				ulong num4;
				if (num4 != (ulong)0L)
				{
					goto IL_0088;
				}
				bool flag2;
				if (flag2)
				{
					EventNodeDebug.Log("[EventNodeContextMenu] 删除节点: " + num);
				}
			}
			while (num5 != (ulong)0L);
			return;
			IL_0088:
			throw new NullReferenceException();
		}

		// Token: 0x06003C38 RID: 15416 RVA: 0x0013C8D0 File Offset: 0x0013AAD0
		[Token(Token = "0x6003C38")]
		[Address(RVA = "0x7AD360", Offset = "0x7AB960", VA = "0x1807AD360")]
		public void UpdateGroupButtonState()
		{
			GameObject gameObject = this.disbandGroupButton.gameObject;
			int num = 0;
			gameObject.SetActive(num != 0);
			if (!this.editor.HasSelectedNodes())
			{
				GameObject gameObject2 = this.createGroupButton.gameObject;
				int num2 = 0;
				gameObject2.SetActive(num2 != 0);
				GameObject gameObject3 = this.removeFromGroupButton.gameObject;
				int num3 = 0;
				gameObject3.SetActive(num3 != 0);
				return;
			}
			List<RuntimeNodeUI> selectedNodes = this.editor.GetSelectedNodes();
			Button button = this.createGroupButton;
			GameObject gameObject4 = button.gameObject;
			ulong num4;
			button.gameObject.SetActive(num4 != 0UL);
			Func<RuntimeNodeUI, bool> func;
			if (EventNodeContextMenu.<>c.<>9__66_0 == 0)
			{
				EventNodeContextMenu.<>c.<>9__66_0 = func;
			}
			bool flag = Enumerable.Any<RuntimeNodeUI>(selectedNodes, func);
			Button button2 = this.removeFromGroupButton;
			while (!flag)
			{
			}
			ulong num5;
			button2.gameObject.SetActive(num5 != 0UL);
		}

		// Token: 0x06003C39 RID: 15417 RVA: 0x0013C998 File Offset: 0x0013AB98
		[Token(Token = "0x6003C39")]
		[Address(RVA = "0x7AC550", Offset = "0x7AAB50", VA = "0x1807AC550")]
		public void ShowGroupContextMenu(Vector2 localPosition, string groupId)
		{
			this.currentContextGroupId = groupId;
			this.currentContextNodeUI = (ulong)0L;
			int num = 0;
			this.Show(num);
			Button button = this.disbandGroupButton;
			int num2 = 0;
			if (button != num2)
			{
				this.disbandGroupButton.gameObject.SetActive(true);
			}
			Button button2 = this.createGroupButton;
			int num3 = 0;
			if (button2 != num3)
			{
				GameObject gameObject = this.createGroupButton.gameObject;
				int num4 = 0;
				gameObject.SetActive(num4 != 0);
			}
			Button button3 = this.removeFromGroupButton;
			int num5 = 0;
			if (button3 != num5)
			{
				GameObject gameObject2 = this.removeFromGroupButton.gameObject;
				int num6 = 0;
				gameObject2.SetActive(num6 != 0);
			}
		}

		// Token: 0x06003C3A RID: 15418 RVA: 0x0013CA48 File Offset: 0x0013AC48
		[Token(Token = "0x6003C3A")]
		[Address(RVA = "0x7AC850", Offset = "0x7AAE50", VA = "0x1807AC850")]
		public void ShowNodeInGroupContextMenu(Vector2 localPosition, RuntimeNodeUI nodeUI)
		{
			this.currentContextGroupId = (ulong)0L;
			this.currentContextNodeUI = nodeUI;
			Button button = this.removeFromGroupButton;
			int num = 0;
			if (button != num)
			{
				this.removeFromGroupButton.gameObject.SetActive(true);
			}
			Button button2 = this.disbandGroupButton;
			int num2 = 0;
			if (button2 != num2)
			{
				GameObject gameObject = this.disbandGroupButton.gameObject;
				int num3 = 0;
				gameObject.SetActive(num3 != 0);
			}
			Button button3 = this.createGroupButton;
			int num4 = 0;
			if (button3 != num4)
			{
				GameObject gameObject2 = this.createGroupButton.gameObject;
				int num5 = 0;
				gameObject2.SetActive(num5 != 0);
			}
		}

		// Token: 0x06003C3B RID: 15419 RVA: 0x0013CAEC File Offset: 0x0013ACEC
		[Token(Token = "0x6003C3B")]
		[Address(RVA = "0x7AC6D0", Offset = "0x7AACD0", VA = "0x1807AC6D0")]
		public void ShowMultiSelectContextMenu(Vector2 localPosition)
		{
			int num = 0;
			this.currentContextGroupId = num;
			this.currentContextNodeUI = num;
			int num2 = 0;
			this.Show(num2);
			Button button = this.createGroupButton;
			int num3 = 0;
			if (button != num3)
			{
				this.createGroupButton.gameObject.SetActive(true);
			}
			Button button2 = this.disbandGroupButton;
			int num4 = 0;
			if (button2 != num4)
			{
				GameObject gameObject = this.disbandGroupButton.gameObject;
				int num5 = 0;
				gameObject.SetActive(num5 != 0);
			}
			Button button3 = this.removeFromGroupButton;
			int num6 = 0;
			if (button3 != num6)
			{
				GameObject gameObject2 = this.removeFromGroupButton.gameObject;
				int num7 = 0;
				gameObject2.SetActive(num7 != 0);
			}
		}

		// Token: 0x06003C3C RID: 15420 RVA: 0x0013CB9C File Offset: 0x0013AD9C
		[Token(Token = "0x6003C3C")]
		[Address(RVA = "0x7AA340", Offset = "0x7A8940", VA = "0x1807AA340")]
		private void OnCreateGroupClicked()
		{
			RuntimeEventNodeEditor runtimeEventNodeEditor = this.editor;
			int num = 0;
			if (!(runtimeEventNodeEditor == num))
			{
				List<RuntimeNodeUI> selectedNodes = this.editor.GetSelectedNodes();
				Func<RuntimeNodeUI, bool> <>9__70_ = EventNodeContextMenu.<>c.<>9__70_0;
				if (<>9__70_ == 0)
				{
					Func<RuntimeNodeUI, bool> func;
					EventNodeContextMenu.<>c.<>9__70_0 = func;
				}
				if (!Enumerable.Any<RuntimeNodeUI>(selectedNodes, <>9__70_))
				{
					NodeGroupUI nodeGroupUI = this.editor.CreateGroup(selectedNodes, "新分组");
					this.Hide();
					return;
				}
				InGameText instance = InGameText.Instance;
				int num2 = 0;
				instance.ShowText("有节点存在于其他分组中", 5f, num2 != 0);
			}
		}

		// Token: 0x06003C3D RID: 15421 RVA: 0x0013CC30 File Offset: 0x0013AE30
		[Token(Token = "0x6003C3D")]
		[Address(RVA = "0x7AA970", Offset = "0x7A8F70", VA = "0x1807AA970")]
		private void OnDisbandGroupClicked()
		{
			RuntimeEventNodeEditor runtimeEventNodeEditor = this.editor;
			int num = 0;
			if (!(runtimeEventNodeEditor == num) && !string.IsNullOrEmpty(this.currentContextGroupId))
			{
				RuntimeEventNodeEditor runtimeEventNodeEditor2 = this.editor;
				string text = this.currentContextGroupId;
				runtimeEventNodeEditor2.DeleteGroup(text);
				this.Hide();
			}
		}

		// Token: 0x06003C3E RID: 15422 RVA: 0x0013CC80 File Offset: 0x0013AE80
		[Token(Token = "0x6003C3E")]
		[Address(RVA = "0x7AAAA0", Offset = "0x7A90A0", VA = "0x1807AAAA0")]
		private void OnRemoveFromGroupClicked()
		{
			RuntimeEventNodeEditor runtimeEventNodeEditor = this.editor;
			int num = 0;
			if (!(runtimeEventNodeEditor == num))
			{
				RuntimeNodeUI runtimeNodeUI = this.currentContextNodeUI;
				int num2 = 0;
				if (!(runtimeNodeUI == num2))
				{
					RuntimeEventNodeEditor runtimeEventNodeEditor2 = this.editor;
					RuntimeNodeUI runtimeNodeUI2 = this.currentContextNodeUI;
					runtimeEventNodeEditor2.RemoveNodeFromGroup(runtimeNodeUI2);
					this.Hide();
				}
			}
		}

		// Token: 0x06003C3F RID: 15423 RVA: 0x0013CCD8 File Offset: 0x0013AED8
		[Token(Token = "0x6003C3F")]
		[Address(RVA = "0x7AD700", Offset = "0x7ABD00", VA = "0x1807AD700")]
		public EventNodeContextMenu()
		{
			Dictionary<int, GameObject> dictionary = new Dictionary();
			this.currentshows = dictionary;
			int[] array = new int[5];
			array[1] = (int)((ulong)1L);
			this.positions = array;
			base..ctor();
		}

		// Token: 0x04002C81 RID: 11393
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002C81")]
		[Header("UI组件")]
		public RectTransform menuPanel;

		// Token: 0x04002C82 RID: 11394
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002C82")]
		public GameObject categoryItemPrefab;

		// Token: 0x04002C83 RID: 11395
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002C83")]
		[Header("功能按钮")]
		public Button copyNodeButton;

		// Token: 0x04002C84 RID: 11396
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002C84")]
		public Button pasteNodeButton;

		// Token: 0x04002C85 RID: 11397
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002C85")]
		public Button deleteNodeButton;

		// Token: 0x04002C86 RID: 11398
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002C86")]
		public Button createGroupButton;

		// Token: 0x04002C87 RID: 11399
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002C87")]
		public Button disbandGroupButton;

		// Token: 0x04002C88 RID: 11400
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002C88")]
		public Button removeFromGroupButton;

		// Token: 0x04002C89 RID: 11401
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002C89")]
		public Image copyNodeButtonImage;

		// Token: 0x04002C8A RID: 11402
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002C8A")]
		public Image pasteNodeButtonImage;

		// Token: 0x04002C8B RID: 11403
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002C8B")]
		public Image deleteNodeButtonImage;

		// Token: 0x04002C8C RID: 11404
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002C8C")]
		public Color disabledColor;

		// Token: 0x04002C8D RID: 11405
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002C8D")]
		public Color normalColor;

		// Token: 0x04002C8E RID: 11406
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002C8E")]
		[Header("设置")]
		public Color categoryColor;

		// Token: 0x04002C8F RID: 11407
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4002C8F")]
		public Color categoryTextColor;

		// Token: 0x04002C90 RID: 11408
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4002C90")]
		private bool isPortConnectionMode;

		// Token: 0x04002C91 RID: 11409
		[FieldOffset(Offset = "0xBC")]
		[Token(Token = "0x4002C91")]
		private PortType connectionPortType;

		// Token: 0x04002C92 RID: 11410
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4002C92")]
		private bool connectionIsInput;

		// Token: 0x04002C93 RID: 11411
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4002C93")]
		private RuntimeNodeUI connectionSourceNodeUI;

		// Token: 0x04002C94 RID: 11412
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x4002C94")]
		private PortDefinition connectionSourcePort;

		// Token: 0x04002C95 RID: 11413
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x4002C95")]
		private Vector2 portDragEndScreenPosition;

		// Token: 0x04002C96 RID: 11414
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x4002C96")]
		private string currentContextGroupId;

		// Token: 0x04002C97 RID: 11415
		[FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x4002C97")]
		private RuntimeNodeUI currentContextNodeUI;

		// Token: 0x04002C98 RID: 11416
		[FieldOffset(Offset = "0xF0")]
		[Token(Token = "0x4002C98")]
		private RuntimeEventNodeEditor editor;

		// Token: 0x04002C99 RID: 11417
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x4002C99")]
		public bool isVisible;

		// Token: 0x04002C9A RID: 11418
		[FieldOffset(Offset = "0xF9")]
		[Token(Token = "0x4002C9A")]
		private bool menuStructureCreated;

		// Token: 0x04002C9B RID: 11419
		[FieldOffset(Offset = "0x100")]
		[Token(Token = "0x4002C9B")]
		private readonly Dictionary<int, GameObject> currentshows;

		// Token: 0x04002C9C RID: 11420
		[FieldOffset(Offset = "0x108")]
		[Token(Token = "0x4002C9C")]
		[SerializeField]
		private int[] positions;
	}
}
