using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Token: 0x02000608 RID: 1544
[Token(Token = "0x2000608")]
public class ExploreMakeCard : TheCard
{
	// Token: 0x06001D25 RID: 7461 RVA: 0x0009BD34 File Offset: 0x00099F34
	[Token(Token = "0x6001D25")]
	[Address(RVA = "0x51AA50", Offset = "0x519050", VA = "0x18051AA50", Slot = "9")]
	public override void OnPointerDown(PointerEventData eventData)
	{
		if (!this.dying)
		{
			GameAPP.PlaySound(19, 0.5f, 1f);
			UnityEvent<TheCard> clickEvent = this.clickEvent;
			if (clickEvent != 0)
			{
				clickEvent.Invoke(this);
			}
			if (this.selected)
			{
				this.dying = true;
				Transform transform = base.transform;
				Transform transform2 = this.menu.transform;
				transform.parentInternal = transform2;
				CanvasGroup canvasGroup = this.AddComponent<CanvasGroup>();
				int num = 0;
				canvasGroup.blocksRaycasts = num != 0;
				Rigidbody2D rigidbody2D = this.AddComponent<Rigidbody2D>();
				rigidbody2D.interpolation = (RigidbodyInterpolation2D)((uint)1);
				float num2 = global::UnityEngine.Random.Range(-3f, 3f);
				float num3 = global::UnityEngine.Random.Range(4f, 7f);
				rigidbody2D.gravityScale = 3f;
				global::UnityEngine.Object.Destroy(base.gameObject, 1.5f);
				global::UnityEngine.Object.Destroy(this);
				CursorChange.SetDefaultCursor();
				throw new NullReferenceException();
			}
			ExploreMakeMenu exploreMakeMenu = this.menu;
			int num4 = 0;
			List<RectTransform> selectPlantHeads = exploreMakeMenu.selectPlantHeads;
			if (this.menu.selectPlantHeads[num4].childCount != 0)
			{
				ExploreMakeMenu exploreMakeMenu2 = this.menu;
				num4++;
			}
			Transform transform3 = base.transform;
			Vector3 vector;
			float z = vector.z;
			ExploreMakeMenu exploreMakeMenu3 = this.menu;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			RectTransform rectTransform = exploreMakeMenu3.selectPlantHeads[num4];
			ExploreMakeCard exploreMakeCard;
			exploreMakeCard.selected = true;
			if (exploreMakeCard.transform != 0)
			{
			}
			IEnumerator enumerator;
			Coroutine coroutine = base.StartCoroutine(enumerator);
		}
	}

	// Token: 0x06001D26 RID: 7462 RVA: 0x0009BE9C File Offset: 0x0009A09C
	[Token(Token = "0x6001D26")]
	[Address(RVA = "0x51A9C0", Offset = "0x518FC0", VA = "0x18051A9C0")]
	private IEnumerator Moving(RectTransform rectTransform)
	{
		ExploreMakeCard.<Moving>d__4 <Moving>d__;
		<Moving>d__.System.IDisposable.Dispose();
		<Moving>d__.<>1__state = (int)((ulong)0L);
		<Moving>d__.<>4__this = this;
		<Moving>d__.rectTransform = rectTransform;
		return null;
	}

	// Token: 0x06001D27 RID: 7463 RVA: 0x0009BEC8 File Offset: 0x0009A0C8
	[Token(Token = "0x6001D27")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public ExploreMakeCard()
	{
	}

	// Token: 0x04000FA1 RID: 4001
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000FA1")]
	public ExploreMakeMenu menu;

	// Token: 0x04000FA2 RID: 4002
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000FA2")]
	public bool selected;

	// Token: 0x04000FA3 RID: 4003
	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x4000FA3")]
	private bool dying;
}
