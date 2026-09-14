using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B5B RID: 2907
	[Token(Token = "0x2000B5B")]
	public class NodeGroupUI : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, IDropHandler
	{
		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06003C8A RID: 15498 RVA: 0x0013E304 File Offset: 0x0013C504
		[Token(Token = "0x170004A6")]
		public NodeGroup Group
		{
			[Token(Token = "0x6003C8A")]
			[Address(RVA = "0x74FED0", Offset = "0x74E4D0", VA = "0x18074FED0")]
			get
			{
				return this.group;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06003C8B RID: 15499 RVA: 0x0013E318 File Offset: 0x0013C518
		[Token(Token = "0x170004A7")]
		public RectTransform RectTransform
		{
			[Token(Token = "0x6003C8B")]
			[Address(RVA = "0x5B7FF0", Offset = "0x5B65F0", VA = "0x1805B7FF0")]
			get
			{
				return this.rectTransform;
			}
		}

		// Token: 0x06003C8C RID: 15500 RVA: 0x0013E32C File Offset: 0x0013C52C
		[Token(Token = "0x6003C8C")]
		[Address(RVA = "0x7CD3C0", Offset = "0x7CB9C0", VA = "0x1807CD3C0")]
		private void Awake()
		{
			RectTransform component = base.GetComponent<RectTransform>();
			this.rectTransform = component;
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x0013E348 File Offset: 0x0013C548
		[Token(Token = "0x6003C8D")]
		[Address(RVA = "0x7CD9C0", Offset = "0x7CBFC0", VA = "0x1807CD9C0")]
		private void Start()
		{
			EventNodeContextMenu <Instance>k__BackingField = EventNodeContextMenu.<Instance>k__BackingField;
			this.contextMenu = <Instance>k__BackingField;
		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x0013E364 File Offset: 0x0013C564
		[Token(Token = "0x6003C8E")]
		[Address(RVA = "0x7CD790", Offset = "0x7CBD90", VA = "0x1807CD790")]
		public void Initialize(NodeGroup group, RuntimeEventNodeEditor editor)
		{
			this.group = group;
			this.editor = editor;
			Image image = this.backgroundImage;
			int num = 0;
			if (image != num)
			{
				Image image2 = this.backgroundImage;
				Color backgroundColor = group.backgroundColor;
				image2.color = backgroundColor;
			}
			TextMeshProUGUI textMeshProUGUI = this.titleText;
			int num2 = 0;
			if (textMeshProUGUI != num2)
			{
				TextMeshProUGUI textMeshProUGUI2 = this.titleText;
				string title = group.title;
				textMeshProUGUI2.text = title;
			}
			TheButton theButton = this.foldButton;
			int num3 = 0;
			if (theButton != num3)
			{
				this.foldButton.theEvent_up.RemoveAllListeners();
				UnityEvent theEvent_up = this.foldButton.theEvent_up;
				UnityAction unityAction = new UnityAction(this.ToggleFold);
				theEvent_up.AddListener(unityAction);
				this.UpdateFoldButtonText();
			}
		}

		// Token: 0x06003C8F RID: 15503 RVA: 0x0013E430 File Offset: 0x0013C630
		[Token(Token = "0x6003C8F")]
		[Address(RVA = "0x7CE250", Offset = "0x7CC850", VA = "0x1807CE250")]
		public void UpdatePositionAndSize()
		{
			RectTransform rectTransform = this.rectTransform;
			int num = 0;
			if (rectTransform != num)
			{
				NodeGroup nodeGroup = this.group;
				this.rectTransform.anchoredPosition = num;
				NodeGroup nodeGroup2 = this.group;
				this.rectTransform.sizeDelta = num;
			}
		}

		// Token: 0x06003C90 RID: 15504 RVA: 0x0013E47C File Offset: 0x0013C67C
		[Token(Token = "0x6003C90")]
		[Address(RVA = "0x7CE310", Offset = "0x7CC910", VA = "0x1807CE310")]
		public void UpdateTitle(string newTitle)
		{
			TextMeshProUGUI textMeshProUGUI = this.titleText;
			int num = 0;
			if (textMeshProUGUI != num)
			{
				this.titleText.text = newTitle;
			}
		}

		// Token: 0x06003C91 RID: 15505 RVA: 0x0013E4B0 File Offset: 0x0013C6B0
		[Token(Token = "0x6003C91")]
		[Address(RVA = "0x7CDA10", Offset = "0x7CC010", VA = "0x1807CDA10")]
		public void ToggleFold()
		{
			NodeGroup nodeGroup = this.group;
			bool flag = !nodeGroup.isFolded;
			nodeGroup.isFolded = flag;
			this.UpdateFoldButtonText();
			this.UpdateNodesVisibility();
			NodeGroup nodeGroup2 = this.group;
			if (!nodeGroup2.isFolded)
			{
				this.UpdateBounds();
			}
			nodeGroup2.size = (ulong)1131413504L;
			nodeGroup2.size.y = 80f;
			this.UpdatePositionAndSize();
			NodeGroup nodeGroup3 = this.group;
			NodeGroup nodeGroup4 = this.group;
			string title = nodeGroup3.title;
			bool isFolded = nodeGroup4.isFolded;
			EventNodeDebug.Log(string.Format("[NodeGroupUI] 分组 {0} 折叠状态: {1}", title, nodeGroup4));
		}

		// Token: 0x06003C92 RID: 15506 RVA: 0x0013E554 File Offset: 0x0013C754
		[Token(Token = "0x6003C92")]
		[Address(RVA = "0x7CDF50", Offset = "0x7CC550", VA = "0x1807CDF50")]
		private void UpdateFoldButtonText()
		{
			TheButton theButton = this.foldButton;
			int num = 0;
			if (!(theButton == num))
			{
				TextMeshProUGUI componentInChildren = this.foldButton.GetComponentInChildren<TextMeshProUGUI>();
				int num2 = 0;
				if (componentInChildren != num2)
				{
					NodeGroup nodeGroup = this.group;
					string text = "折叠";
					if (nodeGroup.isFolded)
					{
						text = "展开";
					}
					componentInChildren.text = text;
				}
			}
		}

		// Token: 0x06003C93 RID: 15507 RVA: 0x0013E5BC File Offset: 0x0013C7BC
		[Token(Token = "0x6003C93")]
		[Address(RVA = "0x7CE0B0", Offset = "0x7CC6B0", VA = "0x1807CE0B0")]
		private void UpdateNodesVisibility()
		{
			int num2;
			do
			{
				int num = 0;
				num2 = 0;
				List<string> nodeIds = this.group.nodeIds;
				bool flag;
				if (flag)
				{
					if (!this.editor.nodeUIs.TryGetValue(num, num2))
					{
						continue;
					}
					bool flag2 = !this.group.isFolded;
					GameObject gameObject;
					gameObject.SetActive(flag2);
				}
			}
			while (num2 != 0);
		}

		// Token: 0x06003C94 RID: 15508 RVA: 0x0013E634 File Offset: 0x0013C834
		[Token(Token = "0x6003C94")]
		[Address(RVA = "0x7CE050", Offset = "0x7CC650", VA = "0x1807CE050")]
		private void UpdateGroupSize()
		{
			NodeGroup nodeGroup = this.group;
			if (!nodeGroup.isFolded)
			{
				this.UpdateBounds();
				this.UpdatePositionAndSize();
				return;
			}
			nodeGroup.size = (ulong)1131413504L;
			nodeGroup.size.y = 80f;
			this.UpdatePositionAndSize();
		}

		// Token: 0x06003C95 RID: 15509 RVA: 0x0013E688 File Offset: 0x0013C888
		[Token(Token = "0x6003C95")]
		[Address(RVA = "0x7CD960", Offset = "0x7CBF60", VA = "0x1807CD960")]
		private void OnEnable()
		{
			this.UpdateBounds();
			NodeGroup nodeGroup = this.group;
			if (!nodeGroup.isFolded)
			{
				this.UpdateBounds();
			}
			nodeGroup.size = (ulong)1131413504L;
			nodeGroup.size.y = 80f;
			this.UpdatePositionAndSize();
			this.UpdatePositionAndSize();
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x0013E6E0 File Offset: 0x0013C8E0
		[Token(Token = "0x6003C96")]
		[Address(RVA = "0x7CDB30", Offset = "0x7CC130", VA = "0x1807CDB30")]
		public void UpdateBounds()
		{
			int num;
			int num2;
			NodeGroup nodeGroup;
			bool flag;
			do
			{
				num = 0;
				num2 = 0;
				RuntimeEventNodeEditor runtimeEventNodeEditor = this.editor;
				int num3 = 0;
				if (runtimeEventNodeEditor == num3)
				{
					return;
				}
				nodeGroup = this.group;
				List<string> nodeIds = nodeGroup.nodeIds;
				if ((nodeGroup.isFolded ? 1 : 0) != num2)
				{
					goto IL_008F;
				}
				List<string> nodeIds2 = this.group.nodeIds;
			}
			while ((flag && !this.editor.nodeUIs.TryGetValue(num, num2)) || num2 != 0);
			Vector2 oneVector = Vector2.oneVector;
			if ((ulong)1L == 0UL)
			{
			}
			float num4 = Vector2.oneVector * 0.5f;
			float num5 = nodeGroup * 0.5f;
			Vector2.negativeInfinityVector = num4;
			IL_008F:
			this.UpdatePositionAndSize();
		}

		// Token: 0x06003C97 RID: 15511 RVA: 0x0013E79C File Offset: 0x0013C99C
		[Token(Token = "0x6003C97")]
		[Address(RVA = "0x7CD410", Offset = "0x7CBA10", VA = "0x1807CD410")]
		private void CalculateNodeChildrenBounds(RectTransform rect, Vector2 min, Vector2 max)
		{
			ulong num4;
			do
			{
				int num = 0;
				if (rect == num)
				{
					break;
				}
				RectTransform nodeContainer = this.editor.nodeContainer;
				int num2 = 0;
				if (nodeContainer == num2)
				{
					break;
				}
				List<GameObject> childs = global::Core.Lawnf.GetChilds(rect.transform);
				bool flag;
				if (flag)
				{
					int num3 = 0;
					RectTransform rectTransform;
					if (rectTransform == num3)
					{
						continue;
					}
					Vector3[] array = new Vector3[4];
					rectTransform.GetWorldCorners(array);
					int i = 0;
					while (i >= 4)
					{
					}
					RectTransform nodeContainer2 = this.editor.nodeContainer;
					min.y = (float)0;
					max.x = (float)0;
					max.y = (float)0;
					i++;
				}
			}
			while (num4 != (ulong)0L);
		}

		// Token: 0x06003C98 RID: 15512 RVA: 0x0013E868 File Offset: 0x0013CA68
		[Token(Token = "0x6003C98")]
		[Address(RVA = "0x7CA050", Offset = "0x7C8650", VA = "0x1807CA050", Slot = "4")]
		public void OnBeginDrag(PointerEventData eventData)
		{
			int num = 0;
			if (!(this == num))
			{
				NodeGroup nodeGroup = this.group;
				this.isDragging = true;
				string title = nodeGroup.title;
				EventNodeDebug.Log("[NodeGroupUIInputHandler] 开始拖拽分组: " + title);
				return;
			}
		}

		// Token: 0x06003C99 RID: 15513 RVA: 0x0013E8B0 File Offset: 0x0013CAB0
		[Token(Token = "0x6003C99")]
		[Address(RVA = "0x7CA110", Offset = "0x7C8710", VA = "0x1807CA110", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
			NodeGroupUIInputHandler.DragGroup(this, eventData);
		}

		// Token: 0x06003C9A RID: 15514 RVA: 0x0013E8C4 File Offset: 0x0013CAC4
		[Token(Token = "0x6003C9A")]
		[Address(RVA = "0x7CA130", Offset = "0x7C8730", VA = "0x1807CA130", Slot = "6")]
		public void OnEndDrag(PointerEventData eventData)
		{
			int num = 0;
			bool flag = this == num;
			if (!flag)
			{
				NodeGroup nodeGroup = this.group;
				this.isDragging = flag;
				string title = nodeGroup.title;
				EventNodeDebug.Log("[NodeGroupUIInputHandler] 结束拖拽分组: " + title);
				return;
			}
		}

		// Token: 0x06003C9B RID: 15515 RVA: 0x0013E90C File Offset: 0x0013CB0C
		[Token(Token = "0x6003C9B")]
		[Address(RVA = "0x7CA1F0", Offset = "0x7C87F0", VA = "0x1807CA1F0", Slot = "7")]
		public void OnPointerClick(PointerEventData eventData)
		{
			NodeGroupUIInputHandler.HandleGroupClick(this, eventData);
		}

		// Token: 0x06003C9C RID: 15516 RVA: 0x0013E920 File Offset: 0x0013CB20
		[Token(Token = "0x6003C9C")]
		[Address(RVA = "0x7CA120", Offset = "0x7C8720", VA = "0x1807CA120", Slot = "8")]
		public void OnDrop(PointerEventData eventData)
		{
			NodeGroupUIInputHandler.HandleDropNode(this, eventData);
		}

		// Token: 0x06003C9D RID: 15517 RVA: 0x0013E934 File Offset: 0x0013CB34
		[Token(Token = "0x6003C9D")]
		[Address(RVA = "0x7CE3A0", Offset = "0x7CC9A0", VA = "0x1807CE3A0")]
		public NodeGroupUI()
		{
		}

		// Token: 0x04002CE1 RID: 11489
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002CE1")]
		[Header("UI组件")]
		public Image backgroundImage;

		// Token: 0x04002CE2 RID: 11490
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002CE2")]
		public TextMeshProUGUI titleText;

		// Token: 0x04002CE3 RID: 11491
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002CE3")]
		public TheButton foldButton;

		// Token: 0x04002CE4 RID: 11492
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002CE4")]
		[Header("设置")]
		public float padding = 20f;

		// Token: 0x04002CE5 RID: 11493
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002CE5")]
		[SerializeField]
		private NodeGroup group;

		// Token: 0x04002CE6 RID: 11494
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002CE6")]
		internal RuntimeEventNodeEditor editor;

		// Token: 0x04002CE7 RID: 11495
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002CE7")]
		internal RectTransform rectTransform;

		// Token: 0x04002CE8 RID: 11496
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002CE8")]
		internal EventNodeContextMenu contextMenu;

		// Token: 0x04002CE9 RID: 11497
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002CE9")]
		internal bool isDragging;
	}
}
