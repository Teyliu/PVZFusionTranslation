using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B79 RID: 2937
	[Token(Token = "0x2000B79")]
	public class EventNodeCanvas : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IScrollHandler, IPointerClickHandler, IDropHandler
	{
		// Token: 0x06003D1E RID: 15646 RVA: 0x0013E9A8 File Offset: 0x0013CBA8
		[Token(Token = "0x6003D1E")]
		[Address(RVA = "0x821AC0", Offset = "0x8200C0", VA = "0x180821AC0")]
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

		// Token: 0x06003D1F RID: 15647 RVA: 0x0013E9DC File Offset: 0x0013CBDC
		[Token(Token = "0x6003D1F")]
		[Address(RVA = "0x821780", Offset = "0x81FD80", VA = "0x180821780")]
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

		// Token: 0x06003D20 RID: 15648 RVA: 0x0013EAD0 File Offset: 0x0013CCD0
		[Token(Token = "0x6003D20")]
		[Address(RVA = "0x821640", Offset = "0x81FC40", VA = "0x180821640")]
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

		// Token: 0x06003D21 RID: 15649 RVA: 0x0013EB20 File Offset: 0x0013CD20
		[Token(Token = "0x6003D21")]
		[Address(RVA = "0x821B60", Offset = "0x820160", VA = "0x180821B60")]
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

		// Token: 0x06003D22 RID: 15650 RVA: 0x0013EB9C File Offset: 0x0013CD9C
		[Token(Token = "0x6003D22")]
		[Address(RVA = "0x821D90", Offset = "0x820390", VA = "0x180821D90")]
		internal void UpdateSelectionBox()
		{
			RectTransform rectTransform = this.selectionRect;
			RectTransform rectTransform2 = this.selectionRect;
			RectTransform rectTransform3 = this.selectionRect;
			RectTransform rectTransform4 = this.selectionRect;
		}

		// Token: 0x06003D23 RID: 15651 RVA: 0x0013EBCC File Offset: 0x0013CDCC
		[Token(Token = "0x6003D23")]
		[Address(RVA = "0x821A60", Offset = "0x820060", VA = "0x180821A60", Slot = "4")]
		public void OnBeginDrag(PointerEventData eventData)
		{
			EventNodeInputHandler.Canvas.OnBeginDrag(this, eventData);
		}

		// Token: 0x06003D24 RID: 15652 RVA: 0x0013EBE0 File Offset: 0x0013CDE0
		[Token(Token = "0x6003D24")]
		[Address(RVA = "0x821A70", Offset = "0x820070", VA = "0x180821A70", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
			EventNodeInputHandler.Canvas.OnDrag(this, eventData);
		}

		// Token: 0x06003D25 RID: 15653 RVA: 0x0013EBF4 File Offset: 0x0013CDF4
		[Token(Token = "0x6003D25")]
		[Address(RVA = "0x821A90", Offset = "0x820090", VA = "0x180821A90", Slot = "6")]
		public void OnEndDrag(PointerEventData eventData)
		{
			EventNodeInputHandler.Canvas.OnEndDrag(this, eventData);
		}

		// Token: 0x06003D26 RID: 15654 RVA: 0x0013EC08 File Offset: 0x0013CE08
		[Token(Token = "0x6003D26")]
		[Address(RVA = "0x821AA0", Offset = "0x8200A0", VA = "0x180821AA0", Slot = "8")]
		public void OnPointerClick(PointerEventData eventData)
		{
			EventNodeInputHandler.Canvas.OnPointerClick(this, eventData);
		}

		// Token: 0x06003D27 RID: 15655 RVA: 0x0013EC1C File Offset: 0x0013CE1C
		[Token(Token = "0x6003D27")]
		[Address(RVA = "0x821AB0", Offset = "0x8200B0", VA = "0x180821AB0", Slot = "7")]
		public void OnScroll(PointerEventData eventData)
		{
			EventNodeInputHandler.Canvas.HandleScrollZoom(this, eventData);
		}

		// Token: 0x06003D28 RID: 15656 RVA: 0x0013EC30 File Offset: 0x0013CE30
		[Token(Token = "0x6003D28")]
		[Address(RVA = "0x821A80", Offset = "0x820080", VA = "0x180821A80", Slot = "9")]
		public void OnDrop(PointerEventData eventData)
		{
			EventNodeInputHandler.Canvas.HandleDropVariableAsset(this, eventData);
		}

		// Token: 0x06003D29 RID: 15657 RVA: 0x0013EC44 File Offset: 0x0013CE44
		[Token(Token = "0x6003D29")]
		[Address(RVA = "0x821E90", Offset = "0x820490", VA = "0x180821E90")]
		public EventNodeCanvas()
		{
		}

		// Token: 0x04002DB0 RID: 11696
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002DB0")]
		[Header("变换目标")]
		public RectTransform targetTransform;

		// Token: 0x04002DB1 RID: 11697
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002DB1")]
		[Header("设置")]
		public float minZoom = 0.2f;

		// Token: 0x04002DB2 RID: 11698
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4002DB2")]
		public float maxZoom = 3f;

		// Token: 0x04002DB3 RID: 11699
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002DB3")]
		public float zoomSpeed = 0.1f;

		// Token: 0x04002DB4 RID: 11700
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002DB4")]
		[Header("右键菜单")]
		public EventNodeContextMenu contextMenu;

		// Token: 0x04002DB5 RID: 11701
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002DB5")]
		[Header("框选")]
		public RectTransform selectionRect;

		// Token: 0x04002DB6 RID: 11702
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002DB6")]
		public Image selectionRectImage;

		// Token: 0x04002DB7 RID: 11703
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002DB7")]
		public Color selectionColor;

		// Token: 0x04002DB8 RID: 11704
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002DB8")]
		public RuntimeEventNodeEditor editor;

		// Token: 0x04002DB9 RID: 11705
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002DB9")]
		internal float currentZoom = 1f;

		// Token: 0x04002DBA RID: 11706
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x4002DBA")]
		internal Vector2 panOffset;

		// Token: 0x04002DBB RID: 11707
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x4002DBB")]
		internal bool isDragging;

		// Token: 0x04002DBC RID: 11708
		[FieldOffset(Offset = "0x75")]
		[Token(Token = "0x4002DBC")]
		internal bool isBoxSelecting;

		// Token: 0x04002DBD RID: 11709
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002DBD")]
		internal Vector2 boxSelectionStart;

		// Token: 0x04002DBE RID: 11710
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002DBE")]
		internal Vector2 boxSelectionEnd;
	}
}
