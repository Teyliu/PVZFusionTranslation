using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BF2 RID: 3058
	[Token(Token = "0x2000BF2")]
	public class VariableItemDragHandler : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
	{
		// Token: 0x06003FC7 RID: 16327 RVA: 0x00152030 File Offset: 0x00150230
		[Token(Token = "0x6003FC7")]
		[Address(RVA = "0x4A9D30", Offset = "0x4A8330", VA = "0x1804A9D30")]
		public void SetAsset(VariableAsset asset)
		{
			this.draggedAsset = asset;
		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x00152044 File Offset: 0x00150244
		[Token(Token = "0x6003FC8")]
		[Address(RVA = "0x4A9CF0", Offset = "0x4A82F0", VA = "0x1804A9CF0")]
		public VariableAsset GetDraggedAsset()
		{
			return this.draggedAsset;
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x00152058 File Offset: 0x00150258
		[Token(Token = "0x6003FC9")]
		[Address(RVA = "0x825A40", Offset = "0x824040", VA = "0x180825A40", Slot = "4")]
		public void OnBeginDrag(PointerEventData eventData)
		{
			if (this.draggedAsset != (ulong)0L)
			{
				string name = this.draggedAsset.name;
				EventNodeDebug.Log("[VariableItemDragHandler] 开始拖拽变量: " + name);
				return;
			}
			EventNodeDebug.LogWarning("[VariableItemDragHandler] 没有可拖拽的Asset");
		}

		// Token: 0x06003FCA RID: 16330 RVA: 0x00152098 File Offset: 0x00150298
		[Token(Token = "0x6003FCA")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x001520A8 File Offset: 0x001502A8
		[Token(Token = "0x6003FCB")]
		[Address(RVA = "0x825AF0", Offset = "0x8240F0", VA = "0x180825AF0", Slot = "6")]
		public void OnEndDrag(PointerEventData eventData)
		{
			EventNodeDebug.Log("[VariableItemDragHandler] 结束拖拽");
		}

		// Token: 0x06003FCC RID: 16332 RVA: 0x001520C0 File Offset: 0x001502C0
		[Token(Token = "0x6003FCC")]
		[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
		public VariableItemDragHandler()
		{
		}

		// Token: 0x0400307F RID: 12415
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400307F")]
		private VariableAsset draggedAsset;
	}
}
