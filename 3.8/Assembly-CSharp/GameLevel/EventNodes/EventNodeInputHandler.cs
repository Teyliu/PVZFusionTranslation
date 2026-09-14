using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B4F RID: 2895
	[Token(Token = "0x2000B4F")]
	public static class EventNodeInputHandler
	{
		// Token: 0x02000B50 RID: 2896
		[Token(Token = "0x2000B50")]
		public static class Canvas
		{
			// Token: 0x06003C52 RID: 15442 RVA: 0x0013D200 File Offset: 0x0013B400
			[Token(Token = "0x6003C52")]
			[Address(RVA = "0x7BCE20", Offset = "0x7BB420", VA = "0x1807BCE20")]
			public static void OnBeginDrag(EventNodeCanvas canvas, PointerEventData eventData)
			{
				int num = 0;
				if (!(canvas == num))
				{
					if (eventData.<button>k__BackingField == PointerEventData.InputButton.Left)
					{
						bool flag;
						while (flag)
						{
						}
						Vector2 vector;
						EventNodeCanvasInputHandler.BeginBoxSelection(canvas, vector);
						return;
					}
					if (eventData.<button>k__BackingField == PointerEventData.InputButton.Middle)
					{
						EventNodeCanvasInputHandler.BeginPan(canvas);
					}
				}
			}

			// Token: 0x06003C53 RID: 15443 RVA: 0x0013D244 File Offset: 0x0013B444
			[Token(Token = "0x6003C53")]
			[Address(RVA = "0x7BCEF0", Offset = "0x7BB4F0", VA = "0x1807BCEF0")]
			public static void OnDrag(EventNodeCanvas canvas, PointerEventData eventData)
			{
				int num = 0;
				bool flag = canvas == num;
				if (!flag)
				{
					if (eventData.<button>k__BackingField != PointerEventData.InputButton.Left || canvas.isBoxSelecting == flag)
					{
						EventNodeCanvasInputHandler.UpdatePan(canvas, num);
						return;
					}
					Vector2 positionOnCanvas = canvas.GetPositionOnCanvas(eventData);
					EventNodeCanvasInputHandler.UpdateBoxSelection(canvas, positionOnCanvas);
				}
			}

			// Token: 0x06003C54 RID: 15444 RVA: 0x0013D290 File Offset: 0x0013B490
			[Token(Token = "0x6003C54")]
			[Address(RVA = "0x7BCFC0", Offset = "0x7BB5C0", VA = "0x1807BCFC0")]
			public static void OnEndDrag(EventNodeCanvas canvas, PointerEventData eventData)
			{
				int num = 0;
				bool flag = canvas == num;
				if (!flag)
				{
					if (eventData.<button>k__BackingField != PointerEventData.InputButton.Left || canvas.isBoxSelecting == flag)
					{
						return;
					}
					EventNodeCanvasInputHandler.EndBoxSelection(canvas);
				}
			}

			// Token: 0x06003C55 RID: 15445 RVA: 0x0013D2CC File Offset: 0x0013B4CC
			[Token(Token = "0x6003C55")]
			[Address(RVA = "0x7BD060", Offset = "0x7BB660", VA = "0x1807BD060")]
			public static void OnPointerClick(EventNodeCanvas canvas, PointerEventData eventData)
			{
				int num = 0;
				bool flag = canvas == num;
				if (!flag)
				{
					if (eventData.<button>k__BackingField == PointerEventData.InputButton.Right && canvas.isDragging == flag)
					{
						EventNodeCanvasInputHandler.HandleRightClick(canvas, eventData);
						canvas.isDragging = false;
						return;
					}
					if (eventData.<button>k__BackingField == PointerEventData.InputButton.Left && !canvas.isDragging)
					{
						EventNodeCanvasInputHandler.HandleLeftClick(canvas, eventData);
					}
					canvas.isDragging = false;
				}
			}

			// Token: 0x06003C56 RID: 15446 RVA: 0x0013D330 File Offset: 0x0013B530
			[Token(Token = "0x6003C56")]
			[Address(RVA = "0x7BCE10", Offset = "0x7BB410", VA = "0x1807BCE10")]
			public static void HandleScrollZoom(EventNodeCanvas canvas, PointerEventData eventData)
			{
				EventNodeCanvasInputHandler.HandleScrollZoom(canvas, eventData);
			}

			// Token: 0x06003C57 RID: 15447 RVA: 0x0013D344 File Offset: 0x0013B544
			[Token(Token = "0x6003C57")]
			[Address(RVA = "0x7BCE00", Offset = "0x7BB400", VA = "0x1807BCE00")]
			public static void HandleDropVariableAsset(EventNodeCanvas canvas, PointerEventData eventData)
			{
				EventNodeCanvasInputHandler.HandleDropVariableAsset(canvas, eventData);
			}
		}

		// Token: 0x02000B51 RID: 2897
		[Token(Token = "0x2000B51")]
		public static class Node
		{
			// Token: 0x06003C58 RID: 15448 RVA: 0x0013D358 File Offset: 0x0013B558
			[Token(Token = "0x6003C58")]
			[Address(RVA = "0x7D2CA0", Offset = "0x7D12A0", VA = "0x1807D2CA0")]
			public static void OnPointerClick(RuntimeNodeUI nodeUI, PointerEventData eventData)
			{
				RuntimeNodeUIInputHandler.HandleNodeClick(nodeUI, eventData);
			}

			// Token: 0x06003C59 RID: 15449 RVA: 0x0013D36C File Offset: 0x0013B56C
			[Token(Token = "0x6003C59")]
			[Address(RVA = "0x7D2C80", Offset = "0x7D1280", VA = "0x1807D2C80")]
			public static void OnDrag(RuntimeNodeUI nodeUI, PointerEventData eventData)
			{
				RuntimeNodeUIInputHandler.DragNode(nodeUI, eventData);
			}

			// Token: 0x06003C5A RID: 15450 RVA: 0x0013D380 File Offset: 0x0013B580
			[Token(Token = "0x6003C5A")]
			[Address(RVA = "0x7D2C70", Offset = "0x7D1270", VA = "0x1807D2C70")]
			public static void OnBeginDrag(RuntimeNodeUI nodeUI, PointerEventData eventData)
			{
				RuntimeNodeUIInputHandler.BeginDragNode(nodeUI, eventData);
			}

			// Token: 0x06003C5B RID: 15451 RVA: 0x0013D394 File Offset: 0x0013B594
			[Token(Token = "0x6003C5B")]
			[Address(RVA = "0x7D2C90", Offset = "0x7D1290", VA = "0x1807D2C90")]
			public static void OnEndDrag(RuntimeNodeUI nodeUI, PointerEventData eventData)
			{
				RuntimeNodeUIInputHandler.EndDragNode(nodeUI);
			}
		}

		// Token: 0x02000B52 RID: 2898
		[Token(Token = "0x2000B52")]
		public static class Port
		{
			// Token: 0x06003C5C RID: 15452 RVA: 0x0013D3A8 File Offset: 0x0013B5A8
			[Token(Token = "0x6003C5C")]
			[Address(RVA = "0x7D2CB0", Offset = "0x7D12B0", VA = "0x1807D2CB0")]
			public static void OnBeginDrag(RuntimePortUI portUI, PointerEventData eventData)
			{
				RuntimePortUIInputHandler.BeginDragPort(portUI, eventData);
			}

			// Token: 0x06003C5D RID: 15453 RVA: 0x0013D3BC File Offset: 0x0013B5BC
			[Token(Token = "0x6003C5D")]
			[Address(RVA = "0x7D2CC0", Offset = "0x7D12C0", VA = "0x1807D2CC0")]
			public static void OnDrag(RuntimePortUI portUI, PointerEventData eventData)
			{
				portUI.Dispose();
			}

			// Token: 0x06003C5E RID: 15454 RVA: 0x0013D3D0 File Offset: 0x0013B5D0
			[Token(Token = "0x6003C5E")]
			[Address(RVA = "0x7D2CD0", Offset = "0x7D12D0", VA = "0x1807D2CD0")]
			public static void OnEndDrag(RuntimePortUI portUI, PointerEventData eventData)
			{
				RuntimePortUIInputHandler.EndDragPort(portUI, eventData);
			}
		}

		// Token: 0x02000B53 RID: 2899
		[Token(Token = "0x2000B53")]
		public static class Group
		{
			// Token: 0x06003C5F RID: 15455 RVA: 0x0013D3E4 File Offset: 0x0013B5E4
			[Token(Token = "0x6003C5F")]
			[Address(RVA = "0x7CA050", Offset = "0x7C8650", VA = "0x1807CA050")]
			public static void OnBeginDrag(NodeGroupUI groupUI, PointerEventData eventData)
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

			// Token: 0x06003C60 RID: 15456 RVA: 0x0013D42C File Offset: 0x0013B62C
			[Token(Token = "0x6003C60")]
			[Address(RVA = "0x7CA110", Offset = "0x7C8710", VA = "0x1807CA110")]
			public static void OnDrag(NodeGroupUI groupUI, PointerEventData eventData)
			{
				NodeGroupUIInputHandler.DragGroup(groupUI, eventData);
			}

			// Token: 0x06003C61 RID: 15457 RVA: 0x0013D440 File Offset: 0x0013B640
			[Token(Token = "0x6003C61")]
			[Address(RVA = "0x7CA130", Offset = "0x7C8730", VA = "0x1807CA130")]
			public static void OnEndDrag(NodeGroupUI groupUI, PointerEventData eventData)
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

			// Token: 0x06003C62 RID: 15458 RVA: 0x0013D488 File Offset: 0x0013B688
			[Token(Token = "0x6003C62")]
			[Address(RVA = "0x7CA1F0", Offset = "0x7C87F0", VA = "0x1807CA1F0")]
			public static void OnPointerClick(NodeGroupUI groupUI, PointerEventData eventData)
			{
				NodeGroupUIInputHandler.HandleGroupClick(groupUI, eventData);
			}

			// Token: 0x06003C63 RID: 15459 RVA: 0x0013D49C File Offset: 0x0013B69C
			[Token(Token = "0x6003C63")]
			[Address(RVA = "0x7CA120", Offset = "0x7C8720", VA = "0x1807CA120")]
			public static void OnDrop(NodeGroupUI groupUI, PointerEventData eventData)
			{
				NodeGroupUIInputHandler.HandleDropNode(groupUI, eventData);
			}
		}
	}
}
