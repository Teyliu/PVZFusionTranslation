using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C34 RID: 3124
	[Token(Token = "0x2000C34")]
	public class VariableItemDragHandler : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
	{
		// Token: 0x06004118 RID: 16664 RVA: 0x00157260 File Offset: 0x00155460
		[Token(Token = "0x6004118")]
		[Address(RVA = "0x515960", Offset = "0x513F60", VA = "0x180515960")]
		public void SetAsset(VariableAsset asset)
		{
			this.draggedAsset = asset;
		}

		// Token: 0x06004119 RID: 16665 RVA: 0x00157274 File Offset: 0x00155474
		[Token(Token = "0x6004119")]
		[Address(RVA = "0x515920", Offset = "0x513F20", VA = "0x180515920")]
		public VariableAsset GetDraggedAsset()
		{
			return this.draggedAsset;
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x00157288 File Offset: 0x00155488
		[Token(Token = "0x600411A")]
		[Address(RVA = "0x88F470", Offset = "0x88DA70", VA = "0x18088F470", Slot = "4")]
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

		// Token: 0x0600411B RID: 16667 RVA: 0x001572C8 File Offset: 0x001554C8
		[Token(Token = "0x600411B")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0600411C RID: 16668 RVA: 0x001572D8 File Offset: 0x001554D8
		[Token(Token = "0x600411C")]
		[Address(RVA = "0x88F520", Offset = "0x88DB20", VA = "0x18088F520", Slot = "6")]
		public void OnEndDrag(PointerEventData eventData)
		{
			EventNodeDebug.Log("[VariableItemDragHandler] 结束拖拽");
		}

		// Token: 0x0600411D RID: 16669 RVA: 0x001572F0 File Offset: 0x001554F0
		[Token(Token = "0x600411D")]
		[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
		public VariableItemDragHandler()
		{
		}

		// Token: 0x040031F2 RID: 12786
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40031F2")]
		private VariableAsset draggedAsset;
	}
}
