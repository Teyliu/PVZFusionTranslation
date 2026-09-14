using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B38 RID: 2872
	[Token(Token = "0x2000B38")]
	public static class EventNodeCanvasInputHandler
	{
		// Token: 0x06003BD9 RID: 15321 RVA: 0x001399DC File Offset: 0x00137BDC
		[Token(Token = "0x6003BD9")]
		[Address(RVA = "0x7A3E60", Offset = "0x7A2460", VA = "0x1807A3E60")]
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

		// Token: 0x06003BDA RID: 15322 RVA: 0x00139A70 File Offset: 0x00137C70
		[Token(Token = "0x6003BDA")]
		[Address(RVA = "0x7A5FE0", Offset = "0x7A45E0", VA = "0x1807A5FE0")]
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

		// Token: 0x06003BDB RID: 15323 RVA: 0x00139AB4 File Offset: 0x00137CB4
		[Token(Token = "0x6003BDB")]
		[Address(RVA = "0x7A40F0", Offset = "0x7A26F0", VA = "0x1807A40F0")]
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

		// Token: 0x06003BDC RID: 15324 RVA: 0x00139B24 File Offset: 0x00137D24
		[Token(Token = "0x6003BDC")]
		[Address(RVA = "0x7A5A70", Offset = "0x7A4070", VA = "0x1807A5A70")]
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

		// Token: 0x06003BDD RID: 15325 RVA: 0x00139CA4 File Offset: 0x00137EA4
		[Token(Token = "0x6003BDD")]
		[Address(RVA = "0x7A3FC0", Offset = "0x7A25C0", VA = "0x1807A3FC0")]
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

		// Token: 0x06003BDE RID: 15326 RVA: 0x00139D04 File Offset: 0x00137F04
		[Token(Token = "0x6003BDE")]
		[Address(RVA = "0x7A6080", Offset = "0x7A4680", VA = "0x1807A6080")]
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

		// Token: 0x06003BDF RID: 15327 RVA: 0x00139D48 File Offset: 0x00137F48
		[Token(Token = "0x6003BDF")]
		[Address(RVA = "0x7A4200", Offset = "0x7A2800", VA = "0x1807A4200")]
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

		// Token: 0x06003BE0 RID: 15328 RVA: 0x00139D7C File Offset: 0x00137F7C
		[Token(Token = "0x6003BE0")]
		[Address(RVA = "0x7A5060", Offset = "0x7A3660", VA = "0x1807A5060")]
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

		// Token: 0x06003BE1 RID: 15329 RVA: 0x00139E90 File Offset: 0x00138090
		[Token(Token = "0x6003BE1")]
		[Address(RVA = "0x7A55C0", Offset = "0x7A3BC0", VA = "0x1807A55C0")]
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

		// Token: 0x06003BE2 RID: 15330 RVA: 0x00139F30 File Offset: 0x00138130
		[Token(Token = "0x6003BE2")]
		[Address(RVA = "0x7A4C00", Offset = "0x7A3200", VA = "0x1807A4C00")]
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

		// Token: 0x06003BE3 RID: 15331 RVA: 0x00139FE8 File Offset: 0x001381E8
		[Token(Token = "0x6003BE3")]
		[Address(RVA = "0x7A4E10", Offset = "0x7A3410", VA = "0x1807A4E10")]
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

		// Token: 0x06003BE4 RID: 15332 RVA: 0x0013A0A8 File Offset: 0x001382A8
		[Token(Token = "0x6003BE4")]
		[Address(RVA = "0x7A4530", Offset = "0x7A2B30", VA = "0x1807A4530")]
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

		// Token: 0x06003BE5 RID: 15333 RVA: 0x0013A208 File Offset: 0x00138408
		[Token(Token = "0x6003BE5")]
		[Address(RVA = "0x7A42A0", Offset = "0x7A28A0", VA = "0x1807A42A0")]
		private static string GetNodeTypeFromAsset(VariableAsset asset)
		{
			if (asset != 0)
			{
				return "IntVariableNode";
			}
			return null;
		}

		// Token: 0x06003BE6 RID: 15334 RVA: 0x0013A230 File Offset: 0x00138430
		[Token(Token = "0x6003BE6")]
		[Address(RVA = "0x7A43C0", Offset = "0x7A29C0", VA = "0x1807A43C0")]
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

		// Token: 0x06003BE7 RID: 15335 RVA: 0x0013A288 File Offset: 0x00138488
		[Token(Token = "0x6003BE7")]
		[Address(RVA = "0x7A5850", Offset = "0x7A3E50", VA = "0x1807A5850")]
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

		// Token: 0x06003BE8 RID: 15336 RVA: 0x0013A304 File Offset: 0x00138504
		[Token(Token = "0x6003BE8")]
		[Address(RVA = "0x7A5540", Offset = "0x7A3B40", VA = "0x1807A5540")]
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
