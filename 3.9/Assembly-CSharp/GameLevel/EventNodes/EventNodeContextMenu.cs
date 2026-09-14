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
	// Token: 0x02000B88 RID: 2952
	[Token(Token = "0x2000B88")]
	public class EventNodeContextMenu : MonoBehaviour
	{
		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06003D65 RID: 15717 RVA: 0x00140148 File Offset: 0x0013E348
		// (set) Token: 0x06003D66 RID: 15718 RVA: 0x0014015C File Offset: 0x0013E35C
		[Token(Token = "0x170004F3")]
		public static EventNodeContextMenu Instance
		{
			[Token(Token = "0x6003D65")]
			[Address(RVA = "0x828D50", Offset = "0x827350", VA = "0x180828D50")]
			get;
			[Token(Token = "0x6003D66")]
			[Address(RVA = "0x828D90", Offset = "0x827390", VA = "0x180828D90")]
			private set;
		}

		// Token: 0x06003D67 RID: 15719 RVA: 0x00140170 File Offset: 0x0013E370
		[Token(Token = "0x6003D67")]
		[Address(RVA = "0x821EC0", Offset = "0x8204C0", VA = "0x180821EC0")]
		private void Awake()
		{
			EventNodeContextMenu.<Instance>k__BackingField = this;
		}

		// Token: 0x06003D68 RID: 15720 RVA: 0x00140184 File Offset: 0x0013E384
		[Token(Token = "0x6003D68")]
		[Address(RVA = "0x828570", Offset = "0x826B70", VA = "0x180828570")]
		private void Start()
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003D69 RID: 15721 RVA: 0x001401A4 File Offset: 0x0013E3A4
		[Token(Token = "0x6003D69")]
		[Address(RVA = "0x822610", Offset = "0x820C10", VA = "0x180822610")]
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

		// Token: 0x06003D6A RID: 15722 RVA: 0x0014052C File Offset: 0x0013E72C
		[Token(Token = "0x6003D6A")]
		[Address(RVA = "0x825480", Offset = "0x823A80", VA = "0x180825480")]
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

		// Token: 0x06003D6B RID: 15723 RVA: 0x0014058C File Offset: 0x0013E78C
		[Token(Token = "0x6003D6B")]
		[Address(RVA = "0x827440", Offset = "0x825A40", VA = "0x180827440")]
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

		// Token: 0x06003D6C RID: 15724 RVA: 0x001405F4 File Offset: 0x0013E7F4
		[Token(Token = "0x6003D6C")]
		[Address(RVA = "0x827F10", Offset = "0x826510", VA = "0x180827F10")]
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

		// Token: 0x06003D6D RID: 15725 RVA: 0x00140820 File Offset: 0x0013EA20
		[Token(Token = "0x6003D6D")]
		[Address(RVA = "0x827530", Offset = "0x825B30", VA = "0x180827530")]
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

		// Token: 0x06003D6E RID: 15726 RVA: 0x001408F4 File Offset: 0x0013EAF4
		[Token(Token = "0x6003D6E")]
		[Address(RVA = "0x828760", Offset = "0x826D60", VA = "0x180828760")]
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

		// Token: 0x06003D6F RID: 15727 RVA: 0x00140978 File Offset: 0x0013EB78
		[Token(Token = "0x6003D6F")]
		[Address(RVA = "0x828620", Offset = "0x826C20", VA = "0x180828620")]
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

		// Token: 0x06003D70 RID: 15728 RVA: 0x001409FC File Offset: 0x0013EBFC
		[Token(Token = "0x6003D70")]
		[Address(RVA = "0x828B00", Offset = "0x827100", VA = "0x180828B00")]
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

		// Token: 0x06003D71 RID: 15729 RVA: 0x00140A80 File Offset: 0x0013EC80
		[Token(Token = "0x6003D71")]
		[Address(RVA = "0x8253A0", Offset = "0x8239A0", VA = "0x1808253A0")]
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

		// Token: 0x06003D72 RID: 15730 RVA: 0x00140AE0 File Offset: 0x0013ECE0
		[Token(Token = "0x6003D72")]
		[Address(RVA = "0x822E70", Offset = "0x821470", VA = "0x180822E70")]
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

		// Token: 0x06003D73 RID: 15731 RVA: 0x00140C10 File Offset: 0x0013EE10
		[Token(Token = "0x6003D73")]
		[Address(RVA = "0x822110", Offset = "0x820710", VA = "0x180822110")]
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

		// Token: 0x06003D74 RID: 15732 RVA: 0x00140D58 File Offset: 0x0013EF58
		[Token(Token = "0x6003D74")]
		[Address(RVA = "0x821F20", Offset = "0x820520", VA = "0x180821F20")]
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

		// Token: 0x06003D75 RID: 15733 RVA: 0x00140D9C File Offset: 0x0013EF9C
		[Token(Token = "0x6003D75")]
		[Address(RVA = "0x8268D0", Offset = "0x824ED0", VA = "0x1808268D0")]
		private void RefreshMenuDisplay()
		{
			this.CollapseAllCategories();
			EventNodeDebug.Log("[EventNodeContextMenu] 刷新菜单显示状态");
		}

		// Token: 0x06003D76 RID: 15734 RVA: 0x00140DBC File Offset: 0x0013EFBC
		[Token(Token = "0x6003D76")]
		[Address(RVA = "0x8251F0", Offset = "0x8237F0", VA = "0x1808251F0")]
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

		// Token: 0x06003D77 RID: 15735 RVA: 0x00140E90 File Offset: 0x0013F090
		[Token(Token = "0x6003D77")]
		[Address(RVA = "0x8278E0", Offset = "0x825EE0", VA = "0x1808278E0")]
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

		// Token: 0x06003D78 RID: 15736 RVA: 0x00140F4C File Offset: 0x0013F14C
		[Token(Token = "0x6003D78")]
		[Address(RVA = "0x823F80", Offset = "0x822580", VA = "0x180823F80")]
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

		// Token: 0x06003D79 RID: 15737 RVA: 0x0014103C File Offset: 0x0013F23C
		[Token(Token = "0x6003D79")]
		[Address(RVA = "0x8239A0", Offset = "0x821FA0", VA = "0x1808239A0")]
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

		// Token: 0x06003D7A RID: 15738 RVA: 0x0014117C File Offset: 0x0013F37C
		[Token(Token = "0x6003D7A")]
		[Address(RVA = "0x824420", Offset = "0x822A20", VA = "0x180824420")]
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

		// Token: 0x06003D7B RID: 15739 RVA: 0x0014136C File Offset: 0x0013F56C
		[Token(Token = "0x6003D7B")]
		[Address(RVA = "0x824DE0", Offset = "0x8233E0", VA = "0x180824DE0")]
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

		// Token: 0x06003D7C RID: 15740 RVA: 0x001413BC File Offset: 0x0013F5BC
		[Token(Token = "0x6003D7C")]
		[Address(RVA = "0x826940", Offset = "0x824F40", VA = "0x180826940")]
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

		// Token: 0x06003D7D RID: 15741 RVA: 0x00141434 File Offset: 0x0013F634
		[Token(Token = "0x6003D7D")]
		[Address(RVA = "0x826BB0", Offset = "0x8251B0", VA = "0x180826BB0")]
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

		// Token: 0x06003D7E RID: 15742 RVA: 0x0014150C File Offset: 0x0013F70C
		[Token(Token = "0x6003D7E")]
		[Address(RVA = "0x826FA0", Offset = "0x8255A0", VA = "0x180826FA0")]
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

		// Token: 0x06003D7F RID: 15743 RVA: 0x00141618 File Offset: 0x0013F818
		[Token(Token = "0x6003D7F")]
		[Address(RVA = "0x8250C0", Offset = "0x8236C0", VA = "0x1808250C0")]
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

		// Token: 0x06003D80 RID: 15744 RVA: 0x00141668 File Offset: 0x0013F868
		[Token(Token = "0x6003D80")]
		[Address(RVA = "0x824CF0", Offset = "0x8232F0", VA = "0x180824CF0")]
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

		// Token: 0x06003D81 RID: 15745 RVA: 0x001416A4 File Offset: 0x0013F8A4
		[Token(Token = "0x6003D81")]
		[Address(RVA = "0x825560", Offset = "0x823B60", VA = "0x180825560")]
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

		// Token: 0x06003D82 RID: 15746 RVA: 0x00141738 File Offset: 0x0013F938
		[Token(Token = "0x6003D82")]
		[Address(RVA = "0x8260A0", Offset = "0x8246A0", VA = "0x1808260A0")]
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

		// Token: 0x06003D83 RID: 15747 RVA: 0x001418A0 File Offset: 0x0013FAA0
		[Token(Token = "0x6003D83")]
		[Address(RVA = "0x8234E0", Offset = "0x821AE0", VA = "0x1808234E0")]
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

		// Token: 0x06003D84 RID: 15748 RVA: 0x0014193C File Offset: 0x0013FB3C
		[Token(Token = "0x6003D84")]
		[Address(RVA = "0x823700", Offset = "0x821D00", VA = "0x180823700")]
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

		// Token: 0x06003D85 RID: 15749 RVA: 0x001419F0 File Offset: 0x0013FBF0
		[Token(Token = "0x6003D85")]
		[Address(RVA = "0x824EF0", Offset = "0x8234F0", VA = "0x180824EF0")]
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

		// Token: 0x06003D86 RID: 15750 RVA: 0x00141A6C File Offset: 0x0013FC6C
		[Token(Token = "0x6003D86")]
		[Address(RVA = "0x8257D0", Offset = "0x823DD0", VA = "0x1808257D0")]
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

		// Token: 0x06003D87 RID: 15751 RVA: 0x00141AA4 File Offset: 0x0013FCA4
		[Token(Token = "0x6003D87")]
		[Address(RVA = "0x825F50", Offset = "0x824550", VA = "0x180825F50")]
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

		// Token: 0x06003D88 RID: 15752 RVA: 0x00141ADC File Offset: 0x0013FCDC
		[Token(Token = "0x6003D88")]
		[Address(RVA = "0x825AD0", Offset = "0x8240D0", VA = "0x180825AD0")]
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

		// Token: 0x06003D89 RID: 15753 RVA: 0x00141B78 File Offset: 0x0013FD78
		[Token(Token = "0x6003D89")]
		[Address(RVA = "0x8288A0", Offset = "0x826EA0", VA = "0x1808288A0")]
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
				func = delegate(RuntimeNodeUI node)
				{
					NodeGroupUI group = node.group;
					int num6 = 0;
					return group != num6;
				};
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

		// Token: 0x06003D8A RID: 15754 RVA: 0x00141C54 File Offset: 0x0013FE54
		[Token(Token = "0x6003D8A")]
		[Address(RVA = "0x827A90", Offset = "0x826090", VA = "0x180827A90")]
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

		// Token: 0x06003D8B RID: 15755 RVA: 0x00141D04 File Offset: 0x0013FF04
		[Token(Token = "0x6003D8B")]
		[Address(RVA = "0x827D90", Offset = "0x826390", VA = "0x180827D90")]
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

		// Token: 0x06003D8C RID: 15756 RVA: 0x00141DA8 File Offset: 0x0013FFA8
		[Token(Token = "0x6003D8C")]
		[Address(RVA = "0x827C10", Offset = "0x826210", VA = "0x180827C10")]
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

		// Token: 0x06003D8D RID: 15757 RVA: 0x00141E58 File Offset: 0x00140058
		[Token(Token = "0x6003D8D")]
		[Address(RVA = "0x825860", Offset = "0x823E60", VA = "0x180825860")]
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
					EventNodeContextMenu.<>c.<>9__70_0 = delegate(RuntimeNodeUI a)
					{
						NodeGroupUI group = a.group;
						int num2 = 0;
						return group != num2;
					};
				}
				if (!Enumerable.Any<RuntimeNodeUI>(selectedNodes, <>9__70_))
				{
					NodeGroupUI nodeGroupUI = this.editor.CreateGroup(selectedNodes, "新分组");
					this.Hide();
					return;
				}
				InGameText instance = InGameText.Instance;
			}
		}

		// Token: 0x06003D8E RID: 15758 RVA: 0x00141EE4 File Offset: 0x001400E4
		[Token(Token = "0x6003D8E")]
		[Address(RVA = "0x825EB0", Offset = "0x8244B0", VA = "0x180825EB0")]
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

		// Token: 0x06003D8F RID: 15759 RVA: 0x00141F34 File Offset: 0x00140134
		[Token(Token = "0x6003D8F")]
		[Address(RVA = "0x825FE0", Offset = "0x8245E0", VA = "0x180825FE0")]
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

		// Token: 0x06003D90 RID: 15760 RVA: 0x00141F8C File Offset: 0x0014018C
		[Token(Token = "0x6003D90")]
		[Address(RVA = "0x828C40", Offset = "0x827240", VA = "0x180828C40")]
		public EventNodeContextMenu()
		{
			Dictionary<int, GameObject> dictionary = new Dictionary();
			this.currentshows = dictionary;
			int[] array = new int[5];
			array[1] = (int)((ulong)1L);
			this.positions = array;
			base..ctor();
		}

		// Token: 0x04002DF5 RID: 11765
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002DF5")]
		[Header("UI组件")]
		public RectTransform menuPanel;

		// Token: 0x04002DF6 RID: 11766
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002DF6")]
		public GameObject categoryItemPrefab;

		// Token: 0x04002DF7 RID: 11767
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002DF7")]
		[Header("功能按钮")]
		public Button copyNodeButton;

		// Token: 0x04002DF8 RID: 11768
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002DF8")]
		public Button pasteNodeButton;

		// Token: 0x04002DF9 RID: 11769
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002DF9")]
		public Button deleteNodeButton;

		// Token: 0x04002DFA RID: 11770
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002DFA")]
		public Button createGroupButton;

		// Token: 0x04002DFB RID: 11771
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002DFB")]
		public Button disbandGroupButton;

		// Token: 0x04002DFC RID: 11772
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002DFC")]
		public Button removeFromGroupButton;

		// Token: 0x04002DFD RID: 11773
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002DFD")]
		public Image copyNodeButtonImage;

		// Token: 0x04002DFE RID: 11774
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002DFE")]
		public Image pasteNodeButtonImage;

		// Token: 0x04002DFF RID: 11775
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002DFF")]
		public Image deleteNodeButtonImage;

		// Token: 0x04002E00 RID: 11776
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002E00")]
		public Color disabledColor;

		// Token: 0x04002E01 RID: 11777
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002E01")]
		public Color normalColor;

		// Token: 0x04002E02 RID: 11778
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002E02")]
		[Header("设置")]
		public Color categoryColor;

		// Token: 0x04002E03 RID: 11779
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4002E03")]
		public Color categoryTextColor;

		// Token: 0x04002E04 RID: 11780
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4002E04")]
		private bool isPortConnectionMode;

		// Token: 0x04002E05 RID: 11781
		[FieldOffset(Offset = "0xBC")]
		[Token(Token = "0x4002E05")]
		private PortType connectionPortType;

		// Token: 0x04002E06 RID: 11782
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4002E06")]
		private bool connectionIsInput;

		// Token: 0x04002E07 RID: 11783
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4002E07")]
		private RuntimeNodeUI connectionSourceNodeUI;

		// Token: 0x04002E08 RID: 11784
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x4002E08")]
		private PortDefinition connectionSourcePort;

		// Token: 0x04002E09 RID: 11785
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x4002E09")]
		private Vector2 portDragEndScreenPosition;

		// Token: 0x04002E0A RID: 11786
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x4002E0A")]
		private string currentContextGroupId;

		// Token: 0x04002E0B RID: 11787
		[FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x4002E0B")]
		private RuntimeNodeUI currentContextNodeUI;

		// Token: 0x04002E0C RID: 11788
		[FieldOffset(Offset = "0xF0")]
		[Token(Token = "0x4002E0C")]
		private RuntimeEventNodeEditor editor;

		// Token: 0x04002E0D RID: 11789
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x4002E0D")]
		public bool isVisible;

		// Token: 0x04002E0E RID: 11790
		[FieldOffset(Offset = "0xF9")]
		[Token(Token = "0x4002E0E")]
		private bool menuStructureCreated;

		// Token: 0x04002E0F RID: 11791
		[FieldOffset(Offset = "0x100")]
		[Token(Token = "0x4002E0F")]
		private readonly Dictionary<int, GameObject> currentshows;

		// Token: 0x04002E10 RID: 11792
		[FieldOffset(Offset = "0x108")]
		[Token(Token = "0x4002E10")]
		[SerializeField]
		private int[] positions;
	}
}
