using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B91 RID: 2961
	[Token(Token = "0x2000B91")]
	public static class EventNodeInputHandler
	{
		// Token: 0x02000B92 RID: 2962
		[Token(Token = "0x2000B92")]
		public static class Canvas
		{
			// Token: 0x06003DA3 RID: 15779 RVA: 0x001424B4 File Offset: 0x001406B4
			[Token(Token = "0x6003DA3")]
			[Address(RVA = "0x839170", Offset = "0x837770", VA = "0x180839170")]
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

			// Token: 0x06003DA4 RID: 15780 RVA: 0x001424F8 File Offset: 0x001406F8
			[Token(Token = "0x6003DA4")]
			[Address(RVA = "0x839240", Offset = "0x837840", VA = "0x180839240")]
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

			// Token: 0x06003DA5 RID: 15781 RVA: 0x00142544 File Offset: 0x00140744
			[Token(Token = "0x6003DA5")]
			[Address(RVA = "0x839310", Offset = "0x837910", VA = "0x180839310")]
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

			// Token: 0x06003DA6 RID: 15782 RVA: 0x00142580 File Offset: 0x00140780
			[Token(Token = "0x6003DA6")]
			[Address(RVA = "0x8393B0", Offset = "0x8379B0", VA = "0x1808393B0")]
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

			// Token: 0x06003DA7 RID: 15783 RVA: 0x001425E4 File Offset: 0x001407E4
			[Token(Token = "0x6003DA7")]
			[Address(RVA = "0x839160", Offset = "0x837760", VA = "0x180839160")]
			public static void HandleScrollZoom(EventNodeCanvas canvas, PointerEventData eventData)
			{
				EventNodeCanvasInputHandler.HandleScrollZoom(canvas, eventData);
			}

			// Token: 0x06003DA8 RID: 15784 RVA: 0x001425F8 File Offset: 0x001407F8
			[Token(Token = "0x6003DA8")]
			[Address(RVA = "0x839150", Offset = "0x837750", VA = "0x180839150")]
			public static void HandleDropVariableAsset(EventNodeCanvas canvas, PointerEventData eventData)
			{
				EventNodeCanvasInputHandler.HandleDropVariableAsset(canvas, eventData);
			}
		}

		// Token: 0x02000B93 RID: 2963
		[Token(Token = "0x2000B93")]
		public static class Node
		{
			// Token: 0x06003DA9 RID: 15785 RVA: 0x0014260C File Offset: 0x0014080C
			[Token(Token = "0x6003DA9")]
			[Address(RVA = "0x84F000", Offset = "0x84D600", VA = "0x18084F000")]
			public static void OnPointerClick(RuntimeNodeUI nodeUI, PointerEventData eventData)
			{
				RuntimeNodeUIInputHandler.HandleNodeClick(nodeUI, eventData);
			}

			// Token: 0x06003DAA RID: 15786 RVA: 0x00142620 File Offset: 0x00140820
			[Token(Token = "0x6003DAA")]
			[Address(RVA = "0x84EFE0", Offset = "0x84D5E0", VA = "0x18084EFE0")]
			public static void OnDrag(RuntimeNodeUI nodeUI, PointerEventData eventData)
			{
				RuntimeNodeUIInputHandler.DragNode(nodeUI, eventData);
			}

			// Token: 0x06003DAB RID: 15787 RVA: 0x00142634 File Offset: 0x00140834
			[Token(Token = "0x6003DAB")]
			[Address(RVA = "0x84EFD0", Offset = "0x84D5D0", VA = "0x18084EFD0")]
			public static void OnBeginDrag(RuntimeNodeUI nodeUI, PointerEventData eventData)
			{
				RuntimeNodeUIInputHandler.BeginDragNode(nodeUI, eventData);
			}

			// Token: 0x06003DAC RID: 15788 RVA: 0x00142648 File Offset: 0x00140848
			[Token(Token = "0x6003DAC")]
			[Address(RVA = "0x84EFF0", Offset = "0x84D5F0", VA = "0x18084EFF0")]
			public static void OnEndDrag(RuntimeNodeUI nodeUI, PointerEventData eventData)
			{
				RuntimeNodeUIInputHandler.EndDragNode(nodeUI);
			}
		}

		// Token: 0x02000B94 RID: 2964
		[Token(Token = "0x2000B94")]
		public static class Port
		{
			// Token: 0x06003DAD RID: 15789 RVA: 0x0014265C File Offset: 0x0014085C
			[Token(Token = "0x6003DAD")]
			[Address(RVA = "0x84F010", Offset = "0x84D610", VA = "0x18084F010")]
			public static void OnBeginDrag(RuntimePortUI portUI, PointerEventData eventData)
			{
				RuntimePortUIInputHandler.BeginDragPort(portUI, eventData);
			}

			// Token: 0x06003DAE RID: 15790 RVA: 0x00142670 File Offset: 0x00140870
			[Token(Token = "0x6003DAE")]
			[Address(RVA = "0x84F020", Offset = "0x84D620", VA = "0x18084F020")]
			public static void OnDrag(RuntimePortUI portUI, PointerEventData eventData)
			{
			}

			// Token: 0x06003DAF RID: 15791 RVA: 0x00142680 File Offset: 0x00140880
			[Token(Token = "0x6003DAF")]
			[Address(RVA = "0x84F030", Offset = "0x84D630", VA = "0x18084F030")]
			public static void OnEndDrag(RuntimePortUI portUI, PointerEventData eventData)
			{
				RuntimePortUIInputHandler.EndDragPort(portUI, eventData);
			}
		}

		// Token: 0x02000B95 RID: 2965
		[Token(Token = "0x2000B95")]
		public static class Group
		{
			// Token: 0x06003DB0 RID: 15792 RVA: 0x00142694 File Offset: 0x00140894
			[Token(Token = "0x6003DB0")]
			[Address(RVA = "0x8463B0", Offset = "0x8449B0", VA = "0x1808463B0")]
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

			// Token: 0x06003DB1 RID: 15793 RVA: 0x001426DC File Offset: 0x001408DC
			[Token(Token = "0x6003DB1")]
			[Address(RVA = "0x846470", Offset = "0x844A70", VA = "0x180846470")]
			public static void OnDrag(NodeGroupUI groupUI, PointerEventData eventData)
			{
				NodeGroupUIInputHandler.DragGroup(groupUI, eventData);
			}

			// Token: 0x06003DB2 RID: 15794 RVA: 0x001426F0 File Offset: 0x001408F0
			[Token(Token = "0x6003DB2")]
			[Address(RVA = "0x846490", Offset = "0x844A90", VA = "0x180846490")]
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

			// Token: 0x06003DB3 RID: 15795 RVA: 0x00142738 File Offset: 0x00140938
			[Token(Token = "0x6003DB3")]
			[Address(RVA = "0x846550", Offset = "0x844B50", VA = "0x180846550")]
			public static void OnPointerClick(NodeGroupUI groupUI, PointerEventData eventData)
			{
				NodeGroupUIInputHandler.HandleGroupClick(groupUI, eventData);
			}

			// Token: 0x06003DB4 RID: 15796 RVA: 0x0014274C File Offset: 0x0014094C
			[Token(Token = "0x6003DB4")]
			[Address(RVA = "0x846480", Offset = "0x844A80", VA = "0x180846480")]
			public static void OnDrop(NodeGroupUI groupUI, PointerEventData eventData)
			{
				NodeGroupUIInputHandler.HandleDropNode(groupUI, eventData);
			}
		}
	}
}
