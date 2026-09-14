using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B37 RID: 2871
	[Token(Token = "0x2000B37")]
	public class EventNodeCanvas : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IScrollHandler, IPointerClickHandler, IDropHandler
	{
		// Token: 0x06003BCD RID: 15309 RVA: 0x00139700 File Offset: 0x00137900
		[Token(Token = "0x6003BCD")]
		[Address(RVA = "0x7A65A0", Offset = "0x7A4BA0", VA = "0x1807A65A0")]
		private void Start()
		{
			RectTransform rectTransform = this.targetTransform;
			int num = 0;
			if (rectTransform == num)
			{
				RectTransform component = base.GetComponent<RectTransform>();
				this.targetTransform = component;
			}
			this.InitializeSelectionRect();
		}

		// Token: 0x06003BCE RID: 15310 RVA: 0x00139734 File Offset: 0x00137934
		[Token(Token = "0x6003BCE")]
		[Address(RVA = "0x7A6260", Offset = "0x7A4860", VA = "0x1807A6260")]
		private void InitializeSelectionRect()
		{
			RectTransform rectTransform = this.selectionRect;
			int num = 0;
			if (rectTransform != num)
			{
				global::UnityEngine.Object.Destroy(this.selectionRect.gameObject);
			}
			GameObject gameObject = new GameObject("BoxSelectionRect");
			Transform transform = gameObject.transform;
			Transform transform2 = base.transform;
			int num2 = 0;
			transform.SetParent(transform2, num2 != 0);
			RectTransform rectTransform2 = gameObject.AddComponent<RectTransform>();
			this.selectionRect = rectTransform2;
			RectTransform rectTransform3 = this.selectionRect;
			RectTransform rectTransform4 = this.selectionRect;
			RectTransform rectTransform5 = this.selectionRect;
			GameObject gameObject2 = this.selectionRect.gameObject;
			int num3 = 0;
			gameObject2.SetActive(num3 != 0);
			Image image = gameObject.AddComponent<Image>();
			this.selectionRectImage = image;
			Image image2 = this.selectionRectImage;
			Color color = this.selectionColor;
			image2.color = color;
			Canvas componentInParent = gameObject.GetComponentInParent<Canvas>();
			int num4 = 0;
			if (componentInParent != num4)
			{
				gameObject.transform.SetAsLastSibling();
			}
			EventNodeDebug.Log("[EventNodeCanvas] 框选矩形初始化完成");
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x00139828 File Offset: 0x00137A28
		[Token(Token = "0x6003BCF")]
		[Address(RVA = "0x7A6120", Offset = "0x7A4720", VA = "0x1807A6120")]
		public Vector2 GetPositionOnCanvas(PointerEventData eventData)
		{
			int num = 0;
			Transform transform = base.transform;
			int num2 = 0;
			Camera pressEventCamera = eventData.pressEventCamera;
			int num3 = 0;
			if (transform != 0)
			{
			}
			if (!RectTransformUtility.ScreenPointToLocalPointInRectangle(num3, num2, pressEventCamera, num))
			{
				return typeof(Vector2).TypeHandle;
			}
			return typeof(Vector2).TypeHandle;
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x00139878 File Offset: 0x00137A78
		[Token(Token = "0x6003BD0")]
		[Address(RVA = "0x7A6640", Offset = "0x7A4C40", VA = "0x1807A6640")]
		internal void UpdatePan()
		{
			ulong num3;
			do
			{
				RectTransform rectTransform = this.targetTransform;
				int num = 0;
				if (!(rectTransform != num))
				{
					break;
				}
				RectTransform rectTransform2 = this.targetTransform;
				int num2 = 0;
				Vector2 anchoredPosition = rectTransform2.anchoredPosition;
				rectTransform2.anchoredPosition = num2;
				Vector2 zeroVector = Vector2.zeroVector;
				this.panOffset = zeroVector;
				this.panOffset.y = (float)0;
				Dictionary<string, RuntimeNodeUI> nodeUIs = RuntimeEventNodeEditor.Instance.nodeUIs;
				bool flag;
				if (flag)
				{
				}
			}
			while (num3 != (ulong)0L);
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x001398F4 File Offset: 0x00137AF4
		[Token(Token = "0x6003BD1")]
		[Address(RVA = "0x7A6870", Offset = "0x7A4E70", VA = "0x1807A6870")]
		internal void UpdateSelectionBox()
		{
			RectTransform rectTransform = this.selectionRect;
			RectTransform rectTransform2 = this.selectionRect;
			RectTransform rectTransform3 = this.selectionRect;
			RectTransform rectTransform4 = this.selectionRect;
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x00139924 File Offset: 0x00137B24
		[Token(Token = "0x6003BD2")]
		[Address(RVA = "0x7A6540", Offset = "0x7A4B40", VA = "0x1807A6540", Slot = "4")]
		public void OnBeginDrag(PointerEventData eventData)
		{
			EventNodeInputHandler.Canvas.OnBeginDrag(this, eventData);
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x00139938 File Offset: 0x00137B38
		[Token(Token = "0x6003BD3")]
		[Address(RVA = "0x7A6550", Offset = "0x7A4B50", VA = "0x1807A6550", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
			EventNodeInputHandler.Canvas.OnDrag(this, eventData);
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x0013994C File Offset: 0x00137B4C
		[Token(Token = "0x6003BD4")]
		[Address(RVA = "0x7A6570", Offset = "0x7A4B70", VA = "0x1807A6570", Slot = "6")]
		public void OnEndDrag(PointerEventData eventData)
		{
			EventNodeInputHandler.Canvas.OnEndDrag(this, eventData);
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x00139960 File Offset: 0x00137B60
		[Token(Token = "0x6003BD5")]
		[Address(RVA = "0x7A6580", Offset = "0x7A4B80", VA = "0x1807A6580", Slot = "8")]
		public void OnPointerClick(PointerEventData eventData)
		{
			EventNodeInputHandler.Canvas.OnPointerClick(this, eventData);
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x00139974 File Offset: 0x00137B74
		[Token(Token = "0x6003BD6")]
		[Address(RVA = "0x7A6590", Offset = "0x7A4B90", VA = "0x1807A6590", Slot = "7")]
		public void OnScroll(PointerEventData eventData)
		{
			EventNodeInputHandler.Canvas.HandleScrollZoom(this, eventData);
		}

		// Token: 0x06003BD7 RID: 15319 RVA: 0x00139988 File Offset: 0x00137B88
		[Token(Token = "0x6003BD7")]
		[Address(RVA = "0x7A6560", Offset = "0x7A4B60", VA = "0x1807A6560", Slot = "9")]
		public void OnDrop(PointerEventData eventData)
		{
			EventNodeInputHandler.Canvas.HandleDropVariableAsset(this, eventData);
		}

		// Token: 0x06003BD8 RID: 15320 RVA: 0x0013999C File Offset: 0x00137B9C
		[Token(Token = "0x6003BD8")]
		[Address(RVA = "0x7A6970", Offset = "0x7A4F70", VA = "0x1807A6970")]
		public EventNodeCanvas()
		{
		}

		// Token: 0x04002C3C RID: 11324
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002C3C")]
		[Header("变换目标")]
		public RectTransform targetTransform;

		// Token: 0x04002C3D RID: 11325
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002C3D")]
		[Header("设置")]
		public float minZoom = 0.2f;

		// Token: 0x04002C3E RID: 11326
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4002C3E")]
		public float maxZoom = 3f;

		// Token: 0x04002C3F RID: 11327
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002C3F")]
		public float zoomSpeed = 0.1f;

		// Token: 0x04002C40 RID: 11328
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002C40")]
		[Header("右键菜单")]
		public EventNodeContextMenu contextMenu;

		// Token: 0x04002C41 RID: 11329
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002C41")]
		[Header("框选")]
		public RectTransform selectionRect;

		// Token: 0x04002C42 RID: 11330
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002C42")]
		public Image selectionRectImage;

		// Token: 0x04002C43 RID: 11331
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002C43")]
		public Color selectionColor;

		// Token: 0x04002C44 RID: 11332
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002C44")]
		public RuntimeEventNodeEditor editor;

		// Token: 0x04002C45 RID: 11333
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002C45")]
		internal float currentZoom = 1f;

		// Token: 0x04002C46 RID: 11334
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x4002C46")]
		internal Vector2 panOffset;

		// Token: 0x04002C47 RID: 11335
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x4002C47")]
		internal bool isDragging;

		// Token: 0x04002C48 RID: 11336
		[FieldOffset(Offset = "0x75")]
		[Token(Token = "0x4002C48")]
		internal bool isBoxSelecting;

		// Token: 0x04002C49 RID: 11337
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002C49")]
		internal Vector2 boxSelectionStart;

		// Token: 0x04002C4A RID: 11338
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002C4A")]
		internal Vector2 boxSelectionEnd;
	}
}
