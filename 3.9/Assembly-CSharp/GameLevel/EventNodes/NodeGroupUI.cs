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
	// Token: 0x02000B9D RID: 2973
	[Token(Token = "0x2000B9D")]
	public class NodeGroupUI : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, IDropHandler
	{
		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06003DDB RID: 15835 RVA: 0x001435B4 File Offset: 0x001417B4
		[Token(Token = "0x170004F6")]
		public NodeGroup Group
		{
			[Token(Token = "0x6003DDB")]
			[Address(RVA = "0x7B6890", Offset = "0x7B4E90", VA = "0x1807B6890")]
			get
			{
				return this.group;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06003DDC RID: 15836 RVA: 0x001435C8 File Offset: 0x001417C8
		[Token(Token = "0x170004F7")]
		public RectTransform RectTransform
		{
			[Token(Token = "0x6003DDC")]
			[Address(RVA = "0x5EDAC0", Offset = "0x5EC0C0", VA = "0x1805EDAC0")]
			get
			{
				return this.rectTransform;
			}
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x001435DC File Offset: 0x001417DC
		[Token(Token = "0x6003DDD")]
		[Address(RVA = "0x849720", Offset = "0x847D20", VA = "0x180849720")]
		private void Awake()
		{
			RectTransform component = base.GetComponent<RectTransform>();
			this.rectTransform = component;
		}

		// Token: 0x06003DDE RID: 15838 RVA: 0x001435F8 File Offset: 0x001417F8
		[Token(Token = "0x6003DDE")]
		[Address(RVA = "0x849D20", Offset = "0x848320", VA = "0x180849D20")]
		private void Start()
		{
			EventNodeContextMenu <Instance>k__BackingField = EventNodeContextMenu.<Instance>k__BackingField;
			this.contextMenu = <Instance>k__BackingField;
		}

		// Token: 0x06003DDF RID: 15839 RVA: 0x00143614 File Offset: 0x00141814
		[Token(Token = "0x6003DDF")]
		[Address(RVA = "0x849AF0", Offset = "0x8480F0", VA = "0x180849AF0")]
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

		// Token: 0x06003DE0 RID: 15840 RVA: 0x001436E0 File Offset: 0x001418E0
		[Token(Token = "0x6003DE0")]
		[Address(RVA = "0x84A5B0", Offset = "0x848BB0", VA = "0x18084A5B0")]
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

		// Token: 0x06003DE1 RID: 15841 RVA: 0x0014372C File Offset: 0x0014192C
		[Token(Token = "0x6003DE1")]
		[Address(RVA = "0x84A670", Offset = "0x848C70", VA = "0x18084A670")]
		public void UpdateTitle(string newTitle)
		{
			TextMeshProUGUI textMeshProUGUI = this.titleText;
			int num = 0;
			if (textMeshProUGUI != num)
			{
				this.titleText.text = newTitle;
			}
		}

		// Token: 0x06003DE2 RID: 15842 RVA: 0x00143760 File Offset: 0x00141960
		[Token(Token = "0x6003DE2")]
		[Address(RVA = "0x849D70", Offset = "0x848370", VA = "0x180849D70")]
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

		// Token: 0x06003DE3 RID: 15843 RVA: 0x00143804 File Offset: 0x00141A04
		[Token(Token = "0x6003DE3")]
		[Address(RVA = "0x84A2B0", Offset = "0x8488B0", VA = "0x18084A2B0")]
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

		// Token: 0x06003DE4 RID: 15844 RVA: 0x0014386C File Offset: 0x00141A6C
		[Token(Token = "0x6003DE4")]
		[Address(RVA = "0x84A410", Offset = "0x848A10", VA = "0x18084A410")]
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

		// Token: 0x06003DE5 RID: 15845 RVA: 0x001438E4 File Offset: 0x00141AE4
		[Token(Token = "0x6003DE5")]
		[Address(RVA = "0x84A3B0", Offset = "0x8489B0", VA = "0x18084A3B0")]
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

		// Token: 0x06003DE6 RID: 15846 RVA: 0x00143938 File Offset: 0x00141B38
		[Token(Token = "0x6003DE6")]
		[Address(RVA = "0x849CC0", Offset = "0x8482C0", VA = "0x180849CC0")]
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

		// Token: 0x06003DE7 RID: 15847 RVA: 0x00143990 File Offset: 0x00141B90
		[Token(Token = "0x6003DE7")]
		[Address(RVA = "0x849E90", Offset = "0x848490", VA = "0x180849E90")]
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

		// Token: 0x06003DE8 RID: 15848 RVA: 0x00143A4C File Offset: 0x00141C4C
		[Token(Token = "0x6003DE8")]
		[Address(RVA = "0x849770", Offset = "0x847D70", VA = "0x180849770")]
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

		// Token: 0x06003DE9 RID: 15849 RVA: 0x00143B18 File Offset: 0x00141D18
		[Token(Token = "0x6003DE9")]
		[Address(RVA = "0x8463B0", Offset = "0x8449B0", VA = "0x1808463B0", Slot = "4")]
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

		// Token: 0x06003DEA RID: 15850 RVA: 0x00143B60 File Offset: 0x00141D60
		[Token(Token = "0x6003DEA")]
		[Address(RVA = "0x846470", Offset = "0x844A70", VA = "0x180846470", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
			NodeGroupUIInputHandler.DragGroup(this, eventData);
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x00143B74 File Offset: 0x00141D74
		[Token(Token = "0x6003DEB")]
		[Address(RVA = "0x846490", Offset = "0x844A90", VA = "0x180846490", Slot = "6")]
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

		// Token: 0x06003DEC RID: 15852 RVA: 0x00143BBC File Offset: 0x00141DBC
		[Token(Token = "0x6003DEC")]
		[Address(RVA = "0x846550", Offset = "0x844B50", VA = "0x180846550", Slot = "7")]
		public void OnPointerClick(PointerEventData eventData)
		{
			NodeGroupUIInputHandler.HandleGroupClick(this, eventData);
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x00143BD0 File Offset: 0x00141DD0
		[Token(Token = "0x6003DED")]
		[Address(RVA = "0x846480", Offset = "0x844A80", VA = "0x180846480", Slot = "8")]
		public void OnDrop(PointerEventData eventData)
		{
			NodeGroupUIInputHandler.HandleDropNode(this, eventData);
		}

		// Token: 0x06003DEE RID: 15854 RVA: 0x00143BE4 File Offset: 0x00141DE4
		[Token(Token = "0x6003DEE")]
		[Address(RVA = "0x84A700", Offset = "0x848D00", VA = "0x18084A700")]
		public NodeGroupUI()
		{
		}

		// Token: 0x04002E55 RID: 11861
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002E55")]
		[Header("UI组件")]
		public Image backgroundImage;

		// Token: 0x04002E56 RID: 11862
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002E56")]
		public TextMeshProUGUI titleText;

		// Token: 0x04002E57 RID: 11863
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E57")]
		public TheButton foldButton;

		// Token: 0x04002E58 RID: 11864
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E58")]
		[Header("设置")]
		public float padding = 20f;

		// Token: 0x04002E59 RID: 11865
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E59")]
		[SerializeField]
		private NodeGroup group;

		// Token: 0x04002E5A RID: 11866
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E5A")]
		internal RuntimeEventNodeEditor editor;

		// Token: 0x04002E5B RID: 11867
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002E5B")]
		internal RectTransform rectTransform;

		// Token: 0x04002E5C RID: 11868
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002E5C")]
		internal EventNodeContextMenu contextMenu;

		// Token: 0x04002E5D RID: 11869
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002E5D")]
		internal bool isDragging;
	}
}
