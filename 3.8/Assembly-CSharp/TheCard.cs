using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x0200060C RID: 1548
[Token(Token = "0x200060C")]
public class TheCard : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IDragHandler, IDropHandler
{
	// Token: 0x06001D38 RID: 7480 RVA: 0x0009C25C File Offset: 0x0009A45C
	[Token(Token = "0x6001D38")]
	[Address(RVA = "0x51D0D0", Offset = "0x51B6D0", VA = "0x18051D0D0")]
	private void Start()
	{
		int num = 0;
		if ((this.isZombieCard ? 1 : 0) == num)
		{
			PlantType plantType = this.thePlantType;
			this.SetIcon(plantType);
			return;
		}
		ZombieType zombieType = this.theZombieType;
		this.SetIcon(zombieType);
	}

	// Token: 0x06001D39 RID: 7481 RVA: 0x0009C294 File Offset: 0x0009A494
	[Token(Token = "0x6001D39")]
	[Address(RVA = "0x51CBA0", Offset = "0x51B1A0", VA = "0x18051CBA0")]
	public void SetBg(CardBgType cardBgType)
	{
		Image component = base.GetComponent<Image>();
		Dictionary<CardBgType, Sprite> cardBgTypes = GameAPP.resourcesManager.CardBgTypes;
		Sprite sprite;
		component.sprite = sprite;
	}

	// Token: 0x06001D3A RID: 7482 RVA: 0x0009C2C4 File Offset: 0x0009A4C4
	[Token(Token = "0x6001D3A")]
	[Address(RVA = "0x51CAE0", Offset = "0x51B0E0", VA = "0x18051CAE0")]
	public void SetBg()
	{
		int num = (int)this.thePlantType;
		CardLevel cardLevel;
		if (cardLevel <= CardLevel.Red)
		{
		}
	}

	// Token: 0x06001D3B RID: 7483 RVA: 0x0009C2E4 File Offset: 0x0009A4E4
	[Token(Token = "0x6001D3B")]
	[Address(RVA = "0x51CEB0", Offset = "0x51B4B0", VA = "0x18051CEB0")]
	public void SetIcon(ZombieType theZombieType)
	{
		int num = 0;
		Dictionary<ZombieType, Sprite> zombieSprites = GameAPP.resourcesManager.zombieSprites;
		bool flag;
		if (flag)
		{
			this.icon.sprite = num;
			this.icon.SetNativeSize();
			Transform transform = this.icon.transform;
		}
	}

	// Token: 0x06001D3C RID: 7484 RVA: 0x0009C330 File Offset: 0x0009A530
	[Token(Token = "0x6001D3C")]
	[Address(RVA = "0x51CC60", Offset = "0x51B260", VA = "0x18051CC60")]
	public void SetIcon(PlantType thePlantType)
	{
		Dictionary<PlantType, GameObject> plantPreviews = GameAPP.resourcesManager.plantPreviews;
		bool flag;
		if (flag)
		{
			Image image = this.icon;
			SpriteRenderer spriteRenderer;
			Sprite sprite = spriteRenderer.sprite;
			image.sprite = sprite;
			this.icon.SetNativeSize();
			Transform transform = this.icon.transform;
		}
	}

	// Token: 0x06001D3D RID: 7485 RVA: 0x0009C388 File Offset: 0x0009A588
	[Token(Token = "0x6001D3D")]
	[Address(RVA = "0x51C9E0", Offset = "0x51AFE0", VA = "0x18051C9E0", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
		GameObject gameObject = this.highLight;
		int num = 0;
		if (gameObject != num)
		{
			this.highLight.SetActive(true);
		}
		CursorChange.SetClickCursor();
	}

	// Token: 0x06001D3E RID: 7486 RVA: 0x0009C3C4 File Offset: 0x0009A5C4
	[Token(Token = "0x6001D3E")]
	[Address(RVA = "0x51CA60", Offset = "0x51B060", VA = "0x18051CA60", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
		GameObject gameObject = this.highLight;
		int num = 0;
		if (gameObject != num)
		{
			GameObject gameObject2 = this.highLight;
			int num2 = 0;
			gameObject2.SetActive(num2 != 0);
		}
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06001D3F RID: 7487 RVA: 0x0009C404 File Offset: 0x0009A604
	[Token(Token = "0x6001D3F")]
	[Address(RVA = "0x51C950", Offset = "0x51AF50", VA = "0x18051C950", Slot = "9")]
	public virtual void OnPointerDown(PointerEventData eventData)
	{
		GameAPP.PlaySound(19, 0.5f, 1f);
		UnityEvent<TheCard> unityEvent = this.clickEvent;
		if (unityEvent != 0)
		{
			unityEvent.Invoke(this);
			return;
		}
	}

	// Token: 0x06001D40 RID: 7488 RVA: 0x0009C438 File Offset: 0x0009A638
	[Token(Token = "0x6001D40")]
	[Address(RVA = "0x51C8B0", Offset = "0x51AEB0", VA = "0x18051C8B0", Slot = "7")]
	public void OnDrag(PointerEventData eventData)
	{
		UnityEvent<TheCard> unityEvent = this.onDrag;
		if (unityEvent != 0)
		{
			unityEvent.Invoke(this);
			return;
		}
	}

	// Token: 0x06001D41 RID: 7489 RVA: 0x0009C458 File Offset: 0x0009A658
	[Token(Token = "0x6001D41")]
	[Address(RVA = "0x51C900", Offset = "0x51AF00", VA = "0x18051C900", Slot = "8")]
	public void OnDrop(PointerEventData eventData)
	{
		UnityEvent<TheCard> unityEvent = this.onEndDrag;
		if (unityEvent != 0)
		{
			unityEvent.Invoke(this);
			return;
		}
	}

	// Token: 0x06001D42 RID: 7490 RVA: 0x0009C478 File Offset: 0x0009A678
	[Token(Token = "0x6001D42")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public TheCard()
	{
	}

	// Token: 0x04000FB0 RID: 4016
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FB0")]
	public UnityEvent<TheCard> clickEvent;

	// Token: 0x04000FB1 RID: 4017
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000FB1")]
	[NonSerialized]
	public UnityEvent<TheCard> onDrag;

	// Token: 0x04000FB2 RID: 4018
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000FB2")]
	[NonSerialized]
	public UnityEvent<TheCard> onEndDrag;

	// Token: 0x04000FB3 RID: 4019
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000FB3")]
	public Image icon;

	// Token: 0x04000FB4 RID: 4020
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000FB4")]
	public GameObject highLight;

	// Token: 0x04000FB5 RID: 4021
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000FB5")]
	public GameObject shadow;

	// Token: 0x04000FB6 RID: 4022
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000FB6")]
	public TextMeshProUGUI costText;

	// Token: 0x04000FB7 RID: 4023
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000FB7")]
	public PlantType thePlantType;

	// Token: 0x04000FB8 RID: 4024
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000FB8")]
	public ZombieType theZombieType;

	// Token: 0x04000FB9 RID: 4025
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000FB9")]
	public bool isZombieCard;
}
