using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Token: 0x0200063D RID: 1597
[Token(Token = "0x200063D")]
public class ExploreMakeCard : TheCard
{
	// Token: 0x06001E24 RID: 7716 RVA: 0x000A0810 File Offset: 0x0009EA10
	[Token(Token = "0x6001E24")]
	[Address(RVA = "0x56FE20", Offset = "0x56E420", VA = "0x18056FE20", Slot = "9")]
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

	// Token: 0x06001E25 RID: 7717 RVA: 0x000A0978 File Offset: 0x0009EB78
	[Token(Token = "0x6001E25")]
	[Address(RVA = "0x56FD90", Offset = "0x56E390", VA = "0x18056FD90")]
	private IEnumerator Moving(RectTransform rectTransform)
	{
		ExploreMakeCard.<Moving>d__4 <Moving>d__;
		<Moving>d__.System.IDisposable.Dispose();
		<Moving>d__.<>1__state = (int)((ulong)0L);
		<Moving>d__.<>4__this = this;
		<Moving>d__.rectTransform = rectTransform;
		return null;
	}

	// Token: 0x06001E26 RID: 7718 RVA: 0x000A09A4 File Offset: 0x0009EBA4
	[Token(Token = "0x6001E26")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public ExploreMakeCard()
	{
	}

	// Token: 0x04001069 RID: 4201
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001069")]
	public ExploreMakeMenu menu;

	// Token: 0x0400106A RID: 4202
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400106A")]
	public bool selected;

	// Token: 0x0400106B RID: 4203
	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x400106B")]
	private bool dying;
}
