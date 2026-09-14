using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B5C RID: 2908
	[Token(Token = "0x2000B5C")]
	public static class NodeGroupUIInputHandler
	{
		// Token: 0x06003C9E RID: 15518 RVA: 0x0013E954 File Offset: 0x0013CB54
		[Token(Token = "0x6003C9E")]
		[Address(RVA = "0x7CA050", Offset = "0x7C8650", VA = "0x1807CA050")]
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

		// Token: 0x06003C9F RID: 15519 RVA: 0x0013E99C File Offset: 0x0013CB9C
		[Token(Token = "0x6003C9F")]
		[Address(RVA = "0x7CC760", Offset = "0x7CAD60", VA = "0x1807CC760")]
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

		// Token: 0x06003CA0 RID: 15520 RVA: 0x0013EA90 File Offset: 0x0013CC90
		[Token(Token = "0x6003CA0")]
		[Address(RVA = "0x7CA130", Offset = "0x7C8730", VA = "0x1807CA130")]
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

		// Token: 0x06003CA1 RID: 15521 RVA: 0x0013EAD8 File Offset: 0x0013CCD8
		[Token(Token = "0x6003CA1")]
		[Address(RVA = "0x7CC5D0", Offset = "0x7CABD0", VA = "0x1807CC5D0")]
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

		// Token: 0x06003CA2 RID: 15522 RVA: 0x0013EB30 File Offset: 0x0013CD30
		[Token(Token = "0x6003CA2")]
		[Address(RVA = "0x7CD110", Offset = "0x7CB710", VA = "0x1807CD110")]
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

		// Token: 0x06003CA3 RID: 15523 RVA: 0x0013EBBC File Offset: 0x0013CDBC
		[Token(Token = "0x6003CA3")]
		[Address(RVA = "0x7CCCB0", Offset = "0x7CB2B0", VA = "0x1807CCCB0")]
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

		// Token: 0x06003CA4 RID: 15524 RVA: 0x0013EC40 File Offset: 0x0013CE40
		[Token(Token = "0x6003CA4")]
		[Address(RVA = "0x7CD050", Offset = "0x7CB650", VA = "0x1807CD050")]
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

		// Token: 0x06003CA5 RID: 15525 RVA: 0x0013EC9C File Offset: 0x0013CE9C
		[Token(Token = "0x6003CA5")]
		[Address(RVA = "0x7CCE70", Offset = "0x7CB470", VA = "0x1807CCE70")]
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

		// Token: 0x06003CA6 RID: 15526 RVA: 0x0013ED18 File Offset: 0x0013CF18
		[Token(Token = "0x6003CA6")]
		[Address(RVA = "0x7CCA30", Offset = "0x7CB030", VA = "0x1807CCA30")]
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
