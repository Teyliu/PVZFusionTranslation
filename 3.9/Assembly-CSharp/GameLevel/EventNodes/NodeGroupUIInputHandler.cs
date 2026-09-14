using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B9E RID: 2974
	[Token(Token = "0x2000B9E")]
	public static class NodeGroupUIInputHandler
	{
		// Token: 0x06003DEF RID: 15855 RVA: 0x00143C04 File Offset: 0x00141E04
		[Token(Token = "0x6003DEF")]
		[Address(RVA = "0x8463B0", Offset = "0x8449B0", VA = "0x1808463B0")]
		public static void BeginDragGroup(NodeGroupUI groupUI, PointerEventData eventData)
		{
			int num = 0;
			if (!(groupUI == num))
			{
				NodeGroup group = groupUI.group;
				groupUI.isDragging = true;
				string title = group.title;
				EventNodeDebug.Log("[NodeGroupUIInputHandler] 开始拖拽分组: " + title);
				return;
			}
		}

		// Token: 0x06003DF0 RID: 15856 RVA: 0x00143C4C File Offset: 0x00141E4C
		[Token(Token = "0x6003DF0")]
		[Address(RVA = "0x848AC0", Offset = "0x8470C0", VA = "0x180848AC0")]
		public static void DragGroup(NodeGroupUI groupUI, PointerEventData eventData)
		{
			int num = 0;
			bool flag = groupUI == num;
			if (!flag && groupUI.isDragging != flag)
			{
				RectTransform rectTransform = groupUI.rectTransform;
				int num2 = 0;
				Transform parent = rectTransform.parent;
				int num3 = 0;
				Camera pressEventCamera = eventData.pressEventCamera;
				int num4 = 0;
				if (parent != 0)
				{
				}
				bool flag2 = RectTransformUtility.ScreenPointToLocalPointInRectangle(num4, num3, pressEventCamera, num2);
				Transform parent2 = rectTransform.parent;
				Camera pressEventCamera2 = eventData.pressEventCamera;
				if (parent2 != 0)
				{
				}
				RectTransform rectTransform2 = groupUI.rectTransform;
				int num5 = 0;
				Vector2 anchoredPosition = rectTransform2.anchoredPosition;
				rectTransform2.anchoredPosition = num5;
				RectTransform rectTransform3 = groupUI.rectTransform;
				NodeGroup group = groupUI.group;
				int num6 = 0;
				Vector2 anchoredPosition2 = rectTransform3.anchoredPosition;
				group.position = anchoredPosition2;
				group.position.y = (float)0;
				NodeGroupUIInputHandler.SyncMoveGroupNodes(groupUI, num6);
				RuntimeEventNodeEditor editor = groupUI.editor;
				int num7 = 0;
				if (editor != num7)
				{
					groupUI.editor.UpdateConnectionPositions();
				}
			}
		}

		// Token: 0x06003DF1 RID: 15857 RVA: 0x00143D40 File Offset: 0x00141F40
		[Token(Token = "0x6003DF1")]
		[Address(RVA = "0x846490", Offset = "0x844A90", VA = "0x180846490")]
		public static void EndDragGroup(NodeGroupUI groupUI, PointerEventData eventData)
		{
			int num = 0;
			bool flag = groupUI == num;
			if (!flag)
			{
				NodeGroup group = groupUI.group;
				groupUI.isDragging = flag;
				string title = group.title;
				EventNodeDebug.Log("[NodeGroupUIInputHandler] 结束拖拽分组: " + title);
				return;
			}
		}

		// Token: 0x06003DF2 RID: 15858 RVA: 0x00143D88 File Offset: 0x00141F88
		[Token(Token = "0x6003DF2")]
		[Address(RVA = "0x848930", Offset = "0x846F30", VA = "0x180848930")]
		private static Vector2 CalculateLocalDelta(RectTransform rectTransform, PointerEventData eventData)
		{
			int num = 0;
			Transform parent = rectTransform.parent;
			int num2 = 0;
			Camera pressEventCamera = eventData.pressEventCamera;
			int num3 = 0;
			if (parent != 0)
			{
			}
			bool flag = RectTransformUtility.ScreenPointToLocalPointInRectangle(num3, num2, pressEventCamera, num);
			Transform parent2 = rectTransform.parent;
			Camera pressEventCamera2 = eventData.pressEventCamera;
			if (parent2 != 0)
			{
			}
			throw new NullReferenceException();
		}

		// Token: 0x06003DF3 RID: 15859 RVA: 0x00143DE0 File Offset: 0x00141FE0
		[Token(Token = "0x6003DF3")]
		[Address(RVA = "0x849470", Offset = "0x847A70", VA = "0x180849470")]
		private static void SyncMoveGroupNodes(NodeGroupUI groupUI, Vector2 localDelta)
		{
			int num;
			int num2;
			bool flag;
			do
			{
				num = 0;
				num2 = 0;
				if (groupUI.group == num)
				{
					break;
				}
				RuntimeEventNodeEditor editor = groupUI.editor;
				int num3 = 0;
				if (editor == num3)
				{
					break;
				}
				List<string> nodeIds = groupUI.group.nodeIds;
			}
			while ((flag && !groupUI.editor.nodeUIs.TryGetValue(num, num2)) || num2 != 0);
		}

		// Token: 0x06003DF4 RID: 15860 RVA: 0x00143E6C File Offset: 0x0014206C
		[Token(Token = "0x6003DF4")]
		[Address(RVA = "0x849010", Offset = "0x847610", VA = "0x180849010")]
		public static void HandleGroupClick(NodeGroupUI groupUI, PointerEventData eventData)
		{
			int num = 0;
			bool flag = groupUI == num;
			if (!flag && groupUI.isDragging == flag)
			{
				EventNodeContextMenu contextMenu = groupUI.contextMenu;
				int num2 = 0;
				if (contextMenu != num2)
				{
					EventNodeContextMenu contextMenu2 = groupUI.contextMenu;
					if (contextMenu2.isVisible)
					{
						contextMenu2.Hide();
					}
				}
				if (eventData.<button>k__BackingField == PointerEventData.InputButton.Left)
				{
					bool flag2;
					while (!flag2)
					{
					}
					bool flag3;
					while (!flag3)
					{
					}
					return;
				}
				if (eventData.<button>k__BackingField == PointerEventData.InputButton.Right)
				{
					NodeGroupUIInputHandler.ShowGroupContextMenu(groupUI, eventData);
					eventData.Use();
				}
			}
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x00143EF0 File Offset: 0x001420F0
		[Token(Token = "0x6003DF5")]
		[Address(RVA = "0x8493B0", Offset = "0x8479B0", VA = "0x1808493B0")]
		private static void ShowGroupInfo(NodeGroupUI groupUI)
		{
			RuntimeEventNodeEditor editor = groupUI.editor;
			int num = 0;
			if (editor != num)
			{
				NodeInfoPanel nodeInfoPanel = groupUI.editor.nodeInfoPanel;
				int num2 = 0;
				if (nodeInfoPanel != num2)
				{
					NodeInfoPanel nodeInfoPanel2 = groupUI.editor.nodeInfoPanel;
					NodeGroup group = groupUI.group;
					nodeInfoPanel2.ShowGroupInfo(group);
				}
			}
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x00143F4C File Offset: 0x0014214C
		[Token(Token = "0x6003DF6")]
		[Address(RVA = "0x8491D0", Offset = "0x8477D0", VA = "0x1808491D0")]
		private static void ShowGroupContextMenu(NodeGroupUI groupUI, PointerEventData eventData)
		{
			int num = 0;
			EventNodeContextMenu <Instance>k__BackingField = EventNodeContextMenu.<Instance>k__BackingField;
			int num2 = 0;
			if (!(<Instance>k__BackingField == num2))
			{
				Transform parent = EventNodeContextMenu.<Instance>k__BackingField.menuPanel.parent;
				int num3 = 0;
				Camera pressEventCamera = eventData.pressEventCamera;
				int num4 = 0;
				if (parent != 0)
				{
				}
				if (RectTransformUtility.ScreenPointToLocalPointInRectangle(num4, num3, pressEventCamera, num))
				{
					NodeGroup group = groupUI.group;
					EventNodeContextMenu <Instance>k__BackingField2 = EventNodeContextMenu.<Instance>k__BackingField;
					string groupId = group.groupId;
					<Instance>k__BackingField2.ShowGroupContextMenu(num, groupId);
				}
			}
		}

		// Token: 0x06003DF7 RID: 15863 RVA: 0x00143FC8 File Offset: 0x001421C8
		[Token(Token = "0x6003DF7")]
		[Address(RVA = "0x848D90", Offset = "0x847390", VA = "0x180848D90")]
		public static void HandleDropNode(NodeGroupUI groupUI, PointerEventData eventData)
		{
			int num = 0;
			if (!(groupUI == num))
			{
				RuntimeEventNodeEditor editor = groupUI.editor;
				int num2 = 0;
				if (!(editor == num2))
				{
					GameObject <pointerDrag>k__BackingField = eventData.<pointerDrag>k__BackingField;
					int num3 = 0;
					if (!(<pointerDrag>k__BackingField == num3))
					{
						RuntimeNodeUI component = eventData.<pointerDrag>k__BackingField.GetComponent<RuntimeNodeUI>();
						int num4 = 0;
						if (!(component == num4))
						{
							EventNodeBase <Node>k__BackingField = component.<Node>k__BackingField;
							NodeGroup group = groupUI.group;
							string nodeId = <Node>k__BackingField.nodeId;
							if (!group.nodeIds.Contains(nodeId))
							{
								groupUI.editor.AddNodeToGroup(component, groupUI);
								EventNodeBase <Node>k__BackingField2 = component.<Node>k__BackingField;
								string title = groupUI.group.title;
								string nodeName = <Node>k__BackingField2.nodeName;
								string text = "[NodeGroupUIInputHandler] 节点 " + nodeName + " 添加到分组 " + title;
							}
							string nodeName2 = component.<Node>k__BackingField.nodeName;
							EventNodeDebug.Log("[NodeGroupUIInputHandler] 节点 " + nodeName2 + " 已在分组中");
						}
					}
				}
			}
		}
	}
}
