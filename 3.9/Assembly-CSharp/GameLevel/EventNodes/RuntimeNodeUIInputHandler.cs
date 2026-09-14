using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C2D RID: 3117
	[Token(Token = "0x2000C2D")]
	public static class RuntimeNodeUIInputHandler
	{
		// Token: 0x060040ED RID: 16621 RVA: 0x00156490 File Offset: 0x00154690
		[Token(Token = "0x60040ED")]
		[Address(RVA = "0x8888E0", Offset = "0x886EE0", VA = "0x1808888E0")]
		public static void HandleNodeClick(RuntimeNodeUI nodeUI, PointerEventData eventData)
		{
			int num = 0;
			if (!(nodeUI == num))
			{
				RuntimeEventNodeEditor <Editor>k__BackingField = nodeUI.<Editor>k__BackingField;
				int num2 = 0;
				if (!(<Editor>k__BackingField == num2) && !nodeUI.<Editor>k__BackingField.isDraggingMultiple)
				{
					if (Input.GetKeyInt((KeyCode)((uint)306)))
					{
					}
					bool keyInt = Input.GetKeyInt((KeyCode)((uint)305));
					if (!Input.GetKeyInt((KeyCode)((uint)304)))
					{
						bool keyInt2 = Input.GetKeyInt((KeyCode)((uint)303));
					}
					if (eventData.<button>k__BackingField == PointerEventData.InputButton.Right)
					{
						bool flag;
						while (flag)
						{
						}
						bool flag2;
						while (flag2)
						{
						}
						throw new NullReferenceException();
					}
					if (eventData.<button>k__BackingField == PointerEventData.InputButton.Left)
					{
						bool flag3;
						while (flag3)
						{
						}
						bool flag4;
						while (flag4)
						{
						}
						return;
					}
					if (eventData.<button>k__BackingField == PointerEventData.InputButton.Middle)
					{
						int num3 = 0;
						if (!(nodeUI == num3))
						{
							RuntimeEventNodeEditor <Editor>k__BackingField2 = nodeUI.<Editor>k__BackingField;
							int num4 = 0;
							if (!(<Editor>k__BackingField2 == num4))
							{
								EventNodeBase <Node>k__BackingField = nodeUI.<Node>k__BackingField;
								RuntimeEventNodeEditor <Editor>k__BackingField3 = nodeUI.<Editor>k__BackingField;
								string nodeId = <Node>k__BackingField.nodeId;
								<Editor>k__BackingField3.DeleteNodeConnections(nodeId);
								string nodeName = nodeUI.<Node>k__BackingField.nodeName;
								EventNodeDebug.Log("[RuntimeNodeUIInputHandler] 中键点击节点 " + nodeName + "，删除了该节点上的所有连线");
							}
						}
					}
				}
			}
		}

		// Token: 0x060040EE RID: 16622 RVA: 0x001565B0 File Offset: 0x001547B0
		[Token(Token = "0x60040EE")]
		[Address(RVA = "0x8887B0", Offset = "0x886DB0", VA = "0x1808887B0")]
		private static void HandleMiddleClick(RuntimeNodeUI nodeUI)
		{
			int num = 0;
			if (!(nodeUI == num))
			{
				RuntimeEventNodeEditor <Editor>k__BackingField = nodeUI.<Editor>k__BackingField;
				int num2 = 0;
				if (!(<Editor>k__BackingField == num2))
				{
					EventNodeBase <Node>k__BackingField = nodeUI.<Node>k__BackingField;
					RuntimeEventNodeEditor <Editor>k__BackingField2 = nodeUI.<Editor>k__BackingField;
					string nodeId = <Node>k__BackingField.nodeId;
					<Editor>k__BackingField2.DeleteNodeConnections(nodeId);
					string nodeName = nodeUI.<Node>k__BackingField.nodeName;
					EventNodeDebug.Log("[RuntimeNodeUIInputHandler] 中键点击节点 " + nodeName + "，删除了该节点上的所有连线");
					return;
				}
			}
		}

		// Token: 0x060040EF RID: 16623 RVA: 0x00156628 File Offset: 0x00154828
		[Token(Token = "0x60040EF")]
		[Address(RVA = "0x888720", Offset = "0x886D20", VA = "0x180888720")]
		private static void HandleLeftClick(RuntimeNodeUI nodeUI, PointerEventData eventData, bool isMultiSelect)
		{
			if (!RuntimeNodeUIInputHandler.IsPointerOverInputField(nodeUI, eventData) && !RuntimeNodeUIInputHandler.IsPointerOverPort(nodeUI, eventData))
			{
				RuntimeEventNodeEditor <Editor>k__BackingField = nodeUI.<Editor>k__BackingField;
				if (isMultiSelect)
				{
					return;
				}
				int num = 0;
				<Editor>k__BackingField.SelectNode(nodeUI, num != 0);
			}
		}

		// Token: 0x060040F0 RID: 16624 RVA: 0x00156668 File Offset: 0x00154868
		[Token(Token = "0x60040F0")]
		[Address(RVA = "0x888C40", Offset = "0x887240", VA = "0x180888C40")]
		private static void HandleRightClick(RuntimeNodeUI nodeUI, PointerEventData eventData, bool isMultiSelect)
		{
			if (!RuntimeNodeUIInputHandler.IsPointerOverInputField(nodeUI, eventData))
			{
				bool flag = RuntimeNodeUIInputHandler.IsPointerOverPort(nodeUI, eventData);
				if (!flag)
				{
					if (nodeUI.isSelected == flag)
					{
						nodeUI.<Editor>k__BackingField.SelectNode(nodeUI, isMultiSelect);
					}
					RuntimeNodeUIInputHandler.ShowContextMenuAtPosition(nodeUI, eventData);
					eventData.Use();
				}
			}
		}

		// Token: 0x060040F1 RID: 16625 RVA: 0x001566B4 File Offset: 0x001548B4
		[Token(Token = "0x60040F1")]
		[Address(RVA = "0x888CE0", Offset = "0x8872E0", VA = "0x180888CE0")]
		private static bool IsModifierKeyPressed()
		{
			if (Input.GetKeyInt((KeyCode)((uint)306)))
			{
			}
			bool keyInt = Input.GetKeyInt((KeyCode)((uint)305));
			return Input.GetKeyInt((KeyCode)((uint)304)) || Input.GetKeyInt((KeyCode)((uint)303));
		}

		// Token: 0x060040F2 RID: 16626 RVA: 0x001566F8 File Offset: 0x001548F8
		[Token(Token = "0x60040F2")]
		[Address(RVA = "0x887AB0", Offset = "0x8860B0", VA = "0x180887AB0")]
		public static void BeginDragNode(RuntimeNodeUI nodeUI, PointerEventData eventData)
		{
			int num = 0;
			if (!(nodeUI == num))
			{
				RuntimeEventNodeEditor <Editor>k__BackingField = nodeUI.<Editor>k__BackingField;
				int num2 = 0;
				if (!(<Editor>k__BackingField == num2) && !RuntimeNodeUIInputHandler.IsPointerOverInputField(nodeUI, eventData))
				{
					bool flag = RuntimeNodeUIInputHandler.IsPointerOverPort(nodeUI, eventData);
					if (!flag && eventData.<button>k__BackingField == PointerEventData.InputButton.Left)
					{
						nodeUI.isDragging = true;
						if (nodeUI.isSelected != flag)
						{
							RuntimeEventNodeEditor <Editor>k__BackingField2 = nodeUI.<Editor>k__BackingField;
							int num3 = 0;
							if (<Editor>k__BackingField2 != num3)
							{
								List<RuntimeNodeUI> selectedNodes = nodeUI.<Editor>k__BackingField.GetSelectedNodes();
								nodeUI.<Editor>k__BackingField.isDraggingMultiple = false;
							}
						}
					}
				}
			}
		}

		// Token: 0x060040F3 RID: 16627 RVA: 0x0015683C File Offset: 0x00154A3C
		[Token(Token = "0x60040F3")]
		[Address(RVA = "0x8882E0", Offset = "0x8868E0", VA = "0x1808882E0")]
		public static void DragNode(RuntimeNodeUI nodeUI, PointerEventData eventData)
		{
			int num = 0;
			bool flag = nodeUI == num;
			if (!flag && nodeUI.isDragging != flag)
			{
				RectTransform rectTransform = nodeUI.rectTransform;
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
				RectTransform rectTransform2 = nodeUI.rectTransform;
				int num5 = 0;
				Vector2 anchoredPosition = rectTransform2.anchoredPosition;
				rectTransform2.anchoredPosition = num5;
				RectTransform rectTransform3 = nodeUI.rectTransform;
				EventNodeBase <Node>k__BackingField = nodeUI.<Node>k__BackingField;
				Vector2 anchoredPosition2 = rectTransform3.anchoredPosition;
				<Node>k__BackingField.position = anchoredPosition2;
				<Node>k__BackingField.position.y = (float)0;
				RuntimeEventNodeEditor <Editor>k__BackingField = nodeUI.<Editor>k__BackingField;
				if (!<Editor>k__BackingField.isDraggingMultiple || <Editor>k__BackingField.draggedNodesInitialPositions.Count > 0)
				{
				}
				RuntimeNodeUIInputHandler.UpdateConnectionLines(nodeUI);
				RuntimeEventNodeEditor <Editor>k__BackingField2 = nodeUI.<Editor>k__BackingField;
				int num6 = 0;
				if (!(<Editor>k__BackingField2 == num6))
				{
					NodeGroupUI group = nodeUI.group;
					int num7 = 0;
					if (group != num7)
					{
						group.UpdateBounds();
					}
				}
			}
		}

		// Token: 0x060040F4 RID: 16628 RVA: 0x0015695C File Offset: 0x00154B5C
		[Token(Token = "0x60040F4")]
		[Address(RVA = "0x888660", Offset = "0x886C60", VA = "0x180888660")]
		public static void EndDragNode(RuntimeNodeUI nodeUI)
		{
			int num = 0;
			bool flag = nodeUI == num;
			if (!flag)
			{
				nodeUI.isDragging = flag;
				RuntimeEventNodeEditor <Editor>k__BackingField = nodeUI.<Editor>k__BackingField;
				int num2 = 0;
				if (<Editor>k__BackingField != num2)
				{
					nodeUI.<Editor>k__BackingField.isDraggingMultiple = false;
				}
				RuntimeNodeUIInputHandler.UpdateAllSelectedNodesGroupBounds(nodeUI);
				return;
			}
		}

		// Token: 0x060040F5 RID: 16629 RVA: 0x001569AC File Offset: 0x00154BAC
		[Token(Token = "0x60040F5")]
		[Address(RVA = "0x887EF0", Offset = "0x8864F0", VA = "0x180887EF0")]
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

		// Token: 0x060040F6 RID: 16630 RVA: 0x00156A04 File Offset: 0x00154C04
		[Token(Token = "0x60040F6")]
		[Address(RVA = "0x888080", Offset = "0x886680", VA = "0x180888080")]
		private static void DragMultipleNodes(RuntimeNodeUI nodeUI, Vector2 localDelta)
		{
			ulong num;
			do
			{
				Vector2 anchoredPosition = nodeUI.rectTransform.anchoredPosition;
				Dictionary<RuntimeNodeUI, Vector2> draggedNodesInitialPositions = nodeUI.<Editor>k__BackingField.draggedNodesInitialPositions;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x060040F7 RID: 16631 RVA: 0x00156A54 File Offset: 0x00154C54
		[Token(Token = "0x60040F7")]
		[Address(RVA = "0x889590", Offset = "0x887B90", VA = "0x180889590")]
		private static void UpdateConnectionLines(RuntimeNodeUI nodeUI)
		{
			ulong num2;
			do
			{
				RuntimeEventNodeEditor <Editor>k__BackingField = nodeUI.<Editor>k__BackingField;
				int num = 0;
				if (<Editor>k__BackingField == num)
				{
					break;
				}
				RuntimeEventNodeEditor <Editor>k__BackingField2 = nodeUI.<Editor>k__BackingField;
				if (!<Editor>k__BackingField2.isDraggingMultiple)
				{
					goto IL_0053;
				}
				List<RuntimeNodeUI> selectedNodes = <Editor>k__BackingField2.selectedNodes;
				HashSet<string> hashSet = new HashSet();
				List<RuntimeNodeUI> selectedNodes2 = nodeUI.<Editor>k__BackingField.selectedNodes;
				bool flag;
				if (flag)
				{
				}
			}
			while (num2 != (ulong)0L);
			return;
			IL_0053:
			string nodeId = nodeUI.<Node>k__BackingField.nodeId;
		}

		// Token: 0x060040F8 RID: 16632 RVA: 0x00156AD4 File Offset: 0x00154CD4
		[Token(Token = "0x60040F8")]
		[Address(RVA = "0x889830", Offset = "0x887E30", VA = "0x180889830")]
		private static void UpdateNodeGroupBounds(RuntimeNodeUI nodeUI)
		{
			RuntimeEventNodeEditor <Editor>k__BackingField = nodeUI.<Editor>k__BackingField;
			int num = 0;
			if (!(<Editor>k__BackingField == num))
			{
				NodeGroupUI group = nodeUI.group;
				int num2 = 0;
				if (group != num2)
				{
					group.UpdateBounds();
					return;
				}
			}
		}

		// Token: 0x060040F9 RID: 16633 RVA: 0x00156B14 File Offset: 0x00154D14
		[Token(Token = "0x60040F9")]
		[Address(RVA = "0x889320", Offset = "0x887920", VA = "0x180889320")]
		private static void UpdateAllSelectedNodesGroupBounds(RuntimeNodeUI nodeUI)
		{
			ulong num6;
			do
			{
				int num = 0;
				RuntimeEventNodeEditor <Editor>k__BackingField = nodeUI.<Editor>k__BackingField;
				int num2 = 0;
				if (<Editor>k__BackingField == num2)
				{
					break;
				}
				NodeGroupUI group = nodeUI.group;
				int num3 = 0;
				if (group != num3)
				{
					group.UpdateBounds();
				}
				List<RuntimeNodeUI> selectedNodes = nodeUI.<Editor>k__BackingField.selectedNodes;
				bool flag;
				if (flag)
				{
					int num4 = 0;
					if (!(num != num4))
					{
						continue;
					}
					int num5 = 0;
					if (!(num != num5))
					{
						continue;
					}
				}
			}
			while (num6 != (ulong)0L);
		}

		// Token: 0x060040FA RID: 16634 RVA: 0x00156BA0 File Offset: 0x00154DA0
		[Token(Token = "0x60040FA")]
		[Address(RVA = "0x888D40", Offset = "0x887340", VA = "0x180888D40")]
		public static bool IsPointerOverInputField(RuntimeNodeUI nodeUI, PointerEventData eventData)
		{
			TMP_InputField valueInputField = nodeUI.valueInputField;
			int num = 0;
			if (!(valueInputField == num))
			{
				TMP_InputField valueInputField2 = nodeUI.valueInputField;
				bool flag;
				if (flag)
				{
					Camera pressEventCamera = eventData.pressEventCamera;
					bool flag2;
					return flag2;
				}
			}
			throw new NullReferenceException();
		}

		// Token: 0x060040FB RID: 16635 RVA: 0x00156BE4 File Offset: 0x00154DE4
		[Token(Token = "0x60040FB")]
		[Address(RVA = "0x888E80", Offset = "0x887480", VA = "0x180888E80")]
		public static bool IsPointerOverPort(RuntimeNodeUI nodeUI, PointerEventData eventData)
		{
			for (;;)
			{
				List<RuntimePortUI> ports = nodeUI.ports;
				bool flag;
				ulong num3;
				if (flag)
				{
					int num = 0;
					Camera pressEventCamera = eventData.pressEventCamera;
					int num2 = 0;
					Transform transform;
					if (transform != 0)
					{
					}
					if (RectTransformUtility.RectangleContainsScreenPoint(num2, num, pressEventCamera))
					{
						break;
					}
				}
				else if (num3 == (ulong)0L)
				{
					goto Block_2;
				}
			}
			return true;
			Block_2:
			throw new NullReferenceException();
		}

		// Token: 0x060040FC RID: 16636 RVA: 0x00156C40 File Offset: 0x00154E40
		[Token(Token = "0x60040FC")]
		[Address(RVA = "0x889080", Offset = "0x887680", VA = "0x180889080")]
		private static void ShowContextMenuAtPosition(RuntimeNodeUI nodeUI, PointerEventData eventData)
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
					RuntimeEventNodeEditor <Editor>k__BackingField = nodeUI.<Editor>k__BackingField;
					NodeGroupUI group = nodeUI.group;
					List<RuntimeNodeUI> selectedNodes = <Editor>k__BackingField.GetSelectedNodes();
					int num5 = 0;
					if (group != num5)
					{
						EventNodeContextMenu <Instance>k__BackingField2 = EventNodeContextMenu.<Instance>k__BackingField;
						return;
					}
				}
			}
		}
	}
}
