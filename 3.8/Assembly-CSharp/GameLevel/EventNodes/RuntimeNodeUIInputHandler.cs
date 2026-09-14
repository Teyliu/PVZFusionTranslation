using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BEB RID: 3051
	[Token(Token = "0x2000BEB")]
	public static class RuntimeNodeUIInputHandler
	{
		// Token: 0x06003F9C RID: 16284 RVA: 0x00151264 File Offset: 0x0014F464
		[Token(Token = "0x6003F9C")]
		[Address(RVA = "0x817360", Offset = "0x815960", VA = "0x180817360")]
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

		// Token: 0x06003F9D RID: 16285 RVA: 0x00151384 File Offset: 0x0014F584
		[Token(Token = "0x6003F9D")]
		[Address(RVA = "0x817230", Offset = "0x815830", VA = "0x180817230")]
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

		// Token: 0x06003F9E RID: 16286 RVA: 0x001513FC File Offset: 0x0014F5FC
		[Token(Token = "0x6003F9E")]
		[Address(RVA = "0x8171A0", Offset = "0x8157A0", VA = "0x1808171A0")]
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

		// Token: 0x06003F9F RID: 16287 RVA: 0x0015143C File Offset: 0x0014F63C
		[Token(Token = "0x6003F9F")]
		[Address(RVA = "0x8176C0", Offset = "0x815CC0", VA = "0x1808176C0")]
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

		// Token: 0x06003FA0 RID: 16288 RVA: 0x00151488 File Offset: 0x0014F688
		[Token(Token = "0x6003FA0")]
		[Address(RVA = "0x817760", Offset = "0x815D60", VA = "0x180817760")]
		private static bool IsModifierKeyPressed()
		{
			if (Input.GetKeyInt((KeyCode)((uint)306)))
			{
			}
			bool keyInt = Input.GetKeyInt((KeyCode)((uint)305));
			return Input.GetKeyInt((KeyCode)((uint)304)) || Input.GetKeyInt((KeyCode)((uint)303));
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x001514CC File Offset: 0x0014F6CC
		[Token(Token = "0x6003FA1")]
		[Address(RVA = "0x816530", Offset = "0x814B30", VA = "0x180816530")]
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

		// Token: 0x06003FA2 RID: 16290 RVA: 0x00151610 File Offset: 0x0014F810
		[Token(Token = "0x6003FA2")]
		[Address(RVA = "0x816D60", Offset = "0x815360", VA = "0x180816D60")]
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

		// Token: 0x06003FA3 RID: 16291 RVA: 0x00151730 File Offset: 0x0014F930
		[Token(Token = "0x6003FA3")]
		[Address(RVA = "0x8170E0", Offset = "0x8156E0", VA = "0x1808170E0")]
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

		// Token: 0x06003FA4 RID: 16292 RVA: 0x00151780 File Offset: 0x0014F980
		[Token(Token = "0x6003FA4")]
		[Address(RVA = "0x816970", Offset = "0x814F70", VA = "0x180816970")]
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

		// Token: 0x06003FA5 RID: 16293 RVA: 0x001517D8 File Offset: 0x0014F9D8
		[Token(Token = "0x6003FA5")]
		[Address(RVA = "0x816B00", Offset = "0x815100", VA = "0x180816B00")]
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

		// Token: 0x06003FA6 RID: 16294 RVA: 0x00151828 File Offset: 0x0014FA28
		[Token(Token = "0x6003FA6")]
		[Address(RVA = "0x818010", Offset = "0x816610", VA = "0x180818010")]
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

		// Token: 0x06003FA7 RID: 16295 RVA: 0x001518A8 File Offset: 0x0014FAA8
		[Token(Token = "0x6003FA7")]
		[Address(RVA = "0x8182B0", Offset = "0x8168B0", VA = "0x1808182B0")]
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

		// Token: 0x06003FA8 RID: 16296 RVA: 0x001518E8 File Offset: 0x0014FAE8
		[Token(Token = "0x6003FA8")]
		[Address(RVA = "0x817DA0", Offset = "0x8163A0", VA = "0x180817DA0")]
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

		// Token: 0x06003FA9 RID: 16297 RVA: 0x00151974 File Offset: 0x0014FB74
		[Token(Token = "0x6003FA9")]
		[Address(RVA = "0x8177C0", Offset = "0x815DC0", VA = "0x1808177C0")]
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

		// Token: 0x06003FAA RID: 16298 RVA: 0x001519B8 File Offset: 0x0014FBB8
		[Token(Token = "0x6003FAA")]
		[Address(RVA = "0x817900", Offset = "0x815F00", VA = "0x180817900")]
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

		// Token: 0x06003FAB RID: 16299 RVA: 0x00151A14 File Offset: 0x0014FC14
		[Token(Token = "0x6003FAB")]
		[Address(RVA = "0x817B00", Offset = "0x816100", VA = "0x180817B00")]
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
