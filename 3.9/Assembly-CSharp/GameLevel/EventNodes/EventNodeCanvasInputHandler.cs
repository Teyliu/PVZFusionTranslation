using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B7A RID: 2938
	[Token(Token = "0x2000B7A")]
	public static class EventNodeCanvasInputHandler
	{
		// Token: 0x06003D2A RID: 15658 RVA: 0x0013EC84 File Offset: 0x0013CE84
		[Token(Token = "0x6003D2A")]
		[Address(RVA = "0x81F380", Offset = "0x81D980", VA = "0x18081F380")]
		public static void BeginBoxSelection(EventNodeCanvas canvas, Vector2 startPosition)
		{
			int num = 0;
			if (!(canvas == num))
			{
				canvas.boxSelectionStart = startPosition;
				canvas.boxSelectionStart.y = (float)0;
				canvas.boxSelectionEnd = startPosition;
				canvas.boxSelectionEnd.y = (float)0;
				canvas.isBoxSelecting = true;
				RectTransform selectionRect = canvas.selectionRect;
				int num2 = 0;
				if (selectionRect != num2)
				{
					canvas.selectionRect.gameObject.SetActive(true);
					canvas.UpdateSelectionBox();
					canvas.selectionRect.transform.SetAsLastSibling();
				}
				EventNodeDebug.Log("[EventNodeCanvasInputHandler] 开始框选");
				return;
			}
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x0013ED18 File Offset: 0x0013CF18
		[Token(Token = "0x6003D2B")]
		[Address(RVA = "0x821500", Offset = "0x81FB00", VA = "0x180821500")]
		public static void UpdateBoxSelection(EventNodeCanvas canvas, Vector2 endPosition)
		{
			int num = 0;
			bool flag = canvas == num;
			if (!flag && canvas.isBoxSelecting != flag)
			{
				canvas.boxSelectionEnd = endPosition;
				canvas.boxSelectionEnd.y = (float)0;
				canvas.UpdateSelectionBox();
				return;
			}
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x0013ED5C File Offset: 0x0013CF5C
		[Token(Token = "0x6003D2C")]
		[Address(RVA = "0x81F610", Offset = "0x81DC10", VA = "0x18081F610")]
		public static void EndBoxSelection(EventNodeCanvas canvas)
		{
			int num = 0;
			bool flag = canvas == num;
			if (!flag && canvas.isBoxSelecting != flag)
			{
				RectTransform selectionRect = canvas.selectionRect;
				canvas.isBoxSelecting = flag;
				int num2 = 0;
				if (selectionRect != num2)
				{
					GameObject gameObject = canvas.selectionRect.gameObject;
					int num3 = 0;
					gameObject.SetActive(num3 != 0);
				}
				EventNodeCanvasInputHandler.SelectNodesInBox(canvas);
				EventNodeDebug.Log("[EventNodeCanvasInputHandler] 结束框选");
				return;
			}
		}

		// Token: 0x06003D2D RID: 15661 RVA: 0x0013EDCC File Offset: 0x0013CFCC
		[Token(Token = "0x6003D2D")]
		[Address(RVA = "0x820F90", Offset = "0x81F590", VA = "0x180820F90")]
		private static void SelectNodesInBox(EventNodeCanvas canvas)
		{
			RuntimeEventNodeEditor instance;
			ulong num6;
			do
			{
				instance = RuntimeEventNodeEditor.Instance;
				int num = 0;
				if (instance == num)
				{
					return;
				}
				RectTransform selectionRect = canvas.selectionRect;
				int num2 = 0;
				if (selectionRect == num2)
				{
					return;
				}
				RectTransform targetTransform = canvas.targetTransform;
				int num3 = 0;
				if (targetTransform == num3)
				{
					return;
				}
				if (!Input.GetKeyInt((KeyCode)((uint)304)) && !Input.GetKeyInt((KeyCode)((uint)303)))
				{
					instance.DeselectAllNodes();
				}
				Vector2 boxSelectionStart = canvas.boxSelectionStart;
				float num4 = canvas.boxSelectionStart.y;
				Vector2 boxSelectionEnd = canvas.boxSelectionEnd;
				float y = canvas.boxSelectionEnd.y;
				if (boxSelectionEnd <= boxSelectionStart)
				{
				}
				if (y <= num4)
				{
					num4 = y;
				}
				Vector2 boxSelectionStart2 = canvas.boxSelectionStart;
				float num5 = canvas.boxSelectionStart.y;
				if (boxSelectionStart2 <= boxSelectionEnd)
				{
				}
				if (num5 <= y)
				{
					num5 = y;
				}
				Vector2 anchoredPosition = canvas.targetTransform.anchoredPosition;
				RectTransform targetTransform2 = canvas.targetTransform;
				Vector3 vector;
				float z = vector.z;
				if (boxSelectionEnd > boxSelectionEnd)
				{
				}
				if (num5 > num4)
				{
				}
				Dictionary<string, RuntimeNodeUI> nodeUIs = RuntimeEventNodeEditor.Instance.nodeUIs;
				bool flag;
				if (flag)
				{
					bool flag2;
					while (flag2)
					{
					}
					bool flag3;
					if (flag3)
					{
					}
					Vector2 vector2;
					if (boxSelectionEnd > vector2)
					{
					}
					if (0 == 0)
					{
						continue;
					}
				}
			}
			while (num6 != (ulong)0L);
			int size = instance.GetSelectedNodes()._size;
			EventNodeDebug.Log(string.Format("[EventNodeCanvasInputHandler] 框选完成，选中了 {0} 个节点", size));
		}

		// Token: 0x06003D2E RID: 15662 RVA: 0x0013EF4C File Offset: 0x0013D14C
		[Token(Token = "0x6003D2E")]
		[Address(RVA = "0x81F4E0", Offset = "0x81DAE0", VA = "0x18081F4E0")]
		public static void BeginPan(EventNodeCanvas canvas)
		{
			int num = 0;
			if (!(canvas == num))
			{
				canvas.isDragging = true;
				Vector2 zeroVector = Vector2.zeroVector;
				EventNodeContextMenu contextMenu = canvas.contextMenu;
				canvas.panOffset = zeroVector;
				int num2 = 0;
				if (contextMenu != num2)
				{
					canvas.contextMenu.Hide();
				}
				EventNodeDebug.Log("[EventNodeCanvasInputHandler] 开始平移");
				return;
			}
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x0013EFAC File Offset: 0x0013D1AC
		[Token(Token = "0x6003D2F")]
		[Address(RVA = "0x8215A0", Offset = "0x81FBA0", VA = "0x1808215A0")]
		public static void UpdatePan(EventNodeCanvas canvas, Vector2 delta)
		{
			int num = 0;
			bool flag = canvas == num;
			if (!flag && canvas.isDragging != flag)
			{
				canvas.panOffset = delta;
				canvas.panOffset.y = (float)0;
				canvas.UpdatePan();
				return;
			}
		}

		// Token: 0x06003D30 RID: 15664 RVA: 0x0013EFF0 File Offset: 0x0013D1F0
		[Token(Token = "0x6003D30")]
		[Address(RVA = "0x81F720", Offset = "0x81DD20", VA = "0x18081F720")]
		public static void EndPan(EventNodeCanvas canvas)
		{
			int num = 0;
			bool flag = canvas == num;
			if (!flag)
			{
				canvas.isDragging = flag;
				EventNodeDebug.Log("[EventNodeCanvasInputHandler] 结束平移");
				return;
			}
		}

		// Token: 0x06003D31 RID: 15665 RVA: 0x0013F024 File Offset: 0x0013D224
		[Token(Token = "0x6003D31")]
		[Address(RVA = "0x820580", Offset = "0x81EB80", VA = "0x180820580")]
		public static void HandleScrollZoom(EventNodeCanvas canvas, PointerEventData eventData)
		{
			bool flag;
			ulong num7;
			do
			{
				int num = 0;
				int num2 = 0;
				if (canvas == num2)
				{
					return;
				}
				RectTransform targetTransform = canvas.targetTransform;
				int num3 = 0;
				if (targetTransform == num3)
				{
					return;
				}
				Transform transform = RuntimeEventNodeEditor.Instance.transform;
				int num4 = 0;
				Camera pressEventCamera = eventData.pressEventCamera;
				int num5 = 0;
				if (transform != 0)
				{
				}
				if (!RectTransformUtility.ScreenPointToLocalPointInRectangle(num5, num4, pressEventCamera, num))
				{
					return;
				}
				float currentZoom = canvas.currentZoom;
				float minZoom = canvas.minZoom;
				float maxZoom = canvas.maxZoom;
				float num6 = eventData.<scrollDelta>k__BackingField.y * canvas.zoomSpeed;
				if (minZoom > num6 || num6 > maxZoom)
				{
					num6 = minZoom;
				}
				canvas.currentZoom = num6;
				Vector2 anchoredPosition = canvas.targetTransform.anchoredPosition;
				RectTransform targetTransform2 = canvas.targetTransform;
				canvas.targetTransform.anchoredPosition = anchoredPosition;
				Dictionary<string, RuntimeNodeUI> nodeUIs = RuntimeEventNodeEditor.Instance.nodeUIs;
				if (flag)
				{
				}
			}
			while (num7 != (ulong)0L);
			EventNodeDebug.Log(string.Format("[EventNodeCanvasInputHandler] 缩放: {0:F2} -> {1:F2}", flag, flag));
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x0013F138 File Offset: 0x0013D338
		[Token(Token = "0x6003D32")]
		[Address(RVA = "0x820AE0", Offset = "0x81F0E0", VA = "0x180820AE0")]
		public static bool IsPointerOverUI(EventNodeCanvas canvas, PointerEventData eventData)
		{
			int num = 0;
			if (!(canvas == num))
			{
				EventNodeContextMenu contextMenu = canvas.contextMenu;
				int num2 = 0;
				if (contextMenu != num2)
				{
					EventNodeContextMenu contextMenu2 = canvas.contextMenu;
					if (contextMenu2.isVisible)
					{
						RectTransform menuPanel = contextMenu2.menuPanel;
						int num3 = 0;
						if (menuPanel != num3 && RectTransformUtility.RectangleContainsScreenPoint(menuPanel, num3))
						{
							goto IL_0088;
						}
					}
				}
				RuntimeNodeUI[] array = global::UnityEngine.Object.FindObjectsOfType<RuntimeNodeUI>();
				int num4 = 0;
				if (num4 < array.Length)
				{
					int num5 = 0;
					bool flag;
					bool flag2;
					if (!(canvas != num5) || !flag || !flag2)
					{
						num4++;
					}
				}
			}
			IL_0088:
			throw new IndexOutOfRangeException();
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x0013F1D8 File Offset: 0x0013D3D8
		[Token(Token = "0x6003D33")]
		[Address(RVA = "0x820120", Offset = "0x81E720", VA = "0x180820120")]
		public static void HandleLeftClick(EventNodeCanvas canvas, PointerEventData eventData)
		{
			int num = 0;
			if (!(canvas == num))
			{
				EventNodeContextMenu contextMenu = canvas.contextMenu;
				int num2 = 0;
				if (contextMenu != num2)
				{
					EventNodeContextMenu contextMenu2 = canvas.contextMenu;
					if (contextMenu2.isVisible && RectTransformUtility.RectangleContainsScreenPoint(contextMenu2.menuPanel, num2))
					{
						return;
					}
				}
				EventNodeContextMenu contextMenu3 = canvas.contextMenu;
				int num3 = 0;
				if (contextMenu3 != num3)
				{
					EventNodeContextMenu contextMenu4 = canvas.contextMenu;
					if (contextMenu4.isVisible)
					{
						contextMenu4.Hide();
					}
				}
				RuntimeEventNodeEditor instance = RuntimeEventNodeEditor.Instance;
				int num4 = 0;
				if (instance != num4 && instance.HasSelectedNodes())
				{
					instance.DeselectAllNodes();
					EventNodeDebug.Log("[EventNodeCanvasInputHandler] 点击空白区域，取消所有节点选中");
				}
			}
		}

		// Token: 0x06003D34 RID: 15668 RVA: 0x0013F290 File Offset: 0x0013D490
		[Token(Token = "0x6003D34")]
		[Address(RVA = "0x820330", Offset = "0x81E930", VA = "0x180820330")]
		public static void HandleRightClick(EventNodeCanvas canvas, PointerEventData eventData)
		{
			int num = 0;
			int num2 = 0;
			if (!(canvas == num2))
			{
				EventNodeContextMenu contextMenu = canvas.contextMenu;
				int num3 = 0;
				if (contextMenu != num3)
				{
					EventNodeContextMenu contextMenu2 = canvas.contextMenu;
					if (contextMenu2.isVisible && RectTransformUtility.RectangleContainsScreenPoint(contextMenu2.menuPanel, num3))
					{
						return;
					}
				}
				EventNodeContextMenu contextMenu3 = canvas.contextMenu;
				int num4 = 0;
				if (contextMenu3 != num4)
				{
					RectTransform menuPanel = canvas.contextMenu.menuPanel;
					int num5 = 0;
					if (menuPanel != num5)
					{
						Transform parent = canvas.contextMenu.menuPanel.parent;
						Camera pressEventCamera = eventData.pressEventCamera;
						if (parent != 0)
						{
						}
						bool flag;
						if (flag)
						{
							canvas.contextMenu.Show(num);
						}
					}
				}
			}
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x0013F350 File Offset: 0x0013D550
		[Token(Token = "0x6003D35")]
		[Address(RVA = "0x81FA50", Offset = "0x81E050", VA = "0x18081FA50")]
		public static void HandleDropVariableAsset(EventNodeCanvas canvas, PointerEventData eventData)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (!(canvas == num3))
			{
				if (eventData.<pointerDrag>k__BackingField.TryGetComponent<VariableItemDragHandler>(num))
				{
					if (num != 0)
					{
						Transform transform = canvas.transform;
						int num4 = 0;
						Camera pressEventCamera = eventData.pressEventCamera;
						if (transform != 0)
						{
						}
						if (RectTransformUtility.ScreenPointToLocalPointInRectangle(num, num4, pressEventCamera, num2))
						{
							RectTransform targetTransform = canvas.targetTransform;
							int num5 = 0;
							if (targetTransform != num5)
							{
								Vector2 anchoredPosition = canvas.targetTransform.anchoredPosition;
								RectTransform targetTransform2 = canvas.targetTransform;
							}
							if ("BoolVariableNode" != 0)
							{
								RuntimeEventNodeEditor instance = RuntimeEventNodeEditor.Instance;
								int num6 = 0;
								int num7 = 0;
								if (!(instance == num7))
								{
									RuntimeNodeUI runtimeNodeUI = instance.AddNode("BoolVariableNode", num6);
									int num8 = 0;
									if (runtimeNodeUI != num8)
									{
										if (runtimeNodeUI.<Node>k__BackingField == 0)
										{
										}
										string nodeId = runtimeNodeUI.<Node>k__BackingField.nodeId;
										runtimeNodeUI.titleText.text = nodeId;
										string text;
										EventNodeDebug.Log(text);
										return;
									}
									string name;
									if (canvas != 0 && num3 != 0)
									{
										name = num3.GetType().Name;
									}
									string text2 = "[EventNodeCanvasInputHandler] 创建的节点不是VariableNode类型: " + name;
								}
								EventNodeDebug.LogWarning("[EventNodeCanvasInputHandler] 节点编辑器未初始化");
							}
							Type type;
							string name2 = type.Name;
							EventNodeDebug.LogWarning("[EventNodeCanvasInputHandler] 未知的Asset类型: " + name2);
						}
						EventNodeDebug.LogWarning("[EventNodeCanvasInputHandler] 坐标转换失败");
					}
					EventNodeDebug.LogWarning("[EventNodeCanvasInputHandler] 拖拽的Asset为空");
				}
				throw new NullReferenceException();
			}
		}

		// Token: 0x06003D36 RID: 15670 RVA: 0x0013F4B0 File Offset: 0x0013D6B0
		[Token(Token = "0x6003D36")]
		[Address(RVA = "0x81F7C0", Offset = "0x81DDC0", VA = "0x18081F7C0")]
		private static string GetNodeTypeFromAsset(VariableAsset asset)
		{
			if (asset != 0)
			{
				return "IntVariableNode";
			}
			return null;
		}

		// Token: 0x06003D37 RID: 15671 RVA: 0x0013F4D8 File Offset: 0x0013D6D8
		[Token(Token = "0x6003D37")]
		[Address(RVA = "0x81F8E0", Offset = "0x81DEE0", VA = "0x18081F8E0")]
		public static Vector2 GetPositionOnCanvas(EventNodeCanvas canvas, PointerEventData eventData)
		{
			int num = 0;
			int num2 = 0;
			if (!(canvas == num2))
			{
				Transform transform = canvas.transform;
				int num3 = 0;
				Camera pressEventCamera = eventData.pressEventCamera;
				int num4 = 0;
				if (transform != 0)
				{
				}
				if (RectTransformUtility.ScreenPointToLocalPointInRectangle(num4, num3, pressEventCamera, num))
				{
				}
			}
			return typeof(Vector2).TypeHandle;
		}

		// Token: 0x06003D38 RID: 15672 RVA: 0x0013F530 File Offset: 0x0013D730
		[Token(Token = "0x6003D38")]
		[Address(RVA = "0x820D70", Offset = "0x81F370", VA = "0x180820D70")]
		public static Vector2 ScreenToTargetSpace(EventNodeCanvas canvas, Vector2 screenPosition, Camera eventCamera)
		{
			int num = 0;
			int num2 = 0;
			if (!(canvas == num2))
			{
				int num3 = 0;
				Transform transform = canvas.transform;
				int num4 = 0;
				if (transform != 0)
				{
				}
				if (RectTransformUtility.ScreenPointToLocalPointInRectangle(num4, num3, eventCamera, num))
				{
					RectTransform targetTransform = canvas.targetTransform;
					int num5 = 0;
					if (!(targetTransform != num5))
					{
					}
					Vector2 anchoredPosition = canvas.targetTransform.anchoredPosition;
					RectTransform targetTransform2 = canvas.targetTransform;
				}
			}
			return typeof(Vector2).TypeHandle;
		}

		// Token: 0x06003D39 RID: 15673 RVA: 0x0013F5AC File Offset: 0x0013D7AC
		[Token(Token = "0x6003D39")]
		[Address(RVA = "0x820A60", Offset = "0x81F060", VA = "0x180820A60")]
		public static bool IsDraggingOrBoxSelecting(EventNodeCanvas canvas)
		{
			int num = 0;
			bool flag = canvas == num;
			if (!flag)
			{
				return canvas.isDragging != flag || canvas.isBoxSelecting;
			}
			throw new NullReferenceException();
		}
	}
}
