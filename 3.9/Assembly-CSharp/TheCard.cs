using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000641 RID: 1601
[Token(Token = "0x2000641")]
public class TheCard : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IDragHandler, IDropHandler
{
	// Token: 0x06001E37 RID: 7735 RVA: 0x000A0D30 File Offset: 0x0009EF30
	[Token(Token = "0x6001E37")]
	[Address(RVA = "0x5783D0", Offset = "0x5769D0", VA = "0x1805783D0")]
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

	// Token: 0x06001E38 RID: 7736 RVA: 0x000A0D68 File Offset: 0x0009EF68
	[Token(Token = "0x6001E38")]
	[Address(RVA = "0x577EA0", Offset = "0x5764A0", VA = "0x180577EA0")]
	public void SetBg(CardBgType cardBgType)
	{
		Image component = base.GetComponent<Image>();
		Dictionary<CardBgType, Sprite> cardBgTypes = GameAPP.resourcesManager.CardBgTypes;
		Sprite sprite;
		component.sprite = sprite;
	}

	// Token: 0x06001E39 RID: 7737 RVA: 0x000A0D98 File Offset: 0x0009EF98
	[Token(Token = "0x6001E39")]
	[Address(RVA = "0x577DE0", Offset = "0x5763E0", VA = "0x180577DE0")]
	public void SetBg()
	{
		int num = (int)this.thePlantType;
		CardLevel cardLevel;
		if (cardLevel <= CardLevel.Red)
		{
		}
	}

	// Token: 0x06001E3A RID: 7738 RVA: 0x000A0DBC File Offset: 0x0009EFBC
	[Token(Token = "0x6001E3A")]
	[Address(RVA = "0x5781B0", Offset = "0x5767B0", VA = "0x1805781B0")]
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

	// Token: 0x06001E3B RID: 7739 RVA: 0x000A0E08 File Offset: 0x0009F008
	[Token(Token = "0x6001E3B")]
	[Address(RVA = "0x577F60", Offset = "0x576560", VA = "0x180577F60")]
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

	// Token: 0x06001E3C RID: 7740 RVA: 0x000A0E60 File Offset: 0x0009F060
	[Token(Token = "0x6001E3C")]
	[Address(RVA = "0x577CE0", Offset = "0x5762E0", VA = "0x180577CE0", Slot = "4")]
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

	// Token: 0x06001E3D RID: 7741 RVA: 0x000A0E9C File Offset: 0x0009F09C
	[Token(Token = "0x6001E3D")]
	[Address(RVA = "0x577D60", Offset = "0x576360", VA = "0x180577D60", Slot = "5")]
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

	// Token: 0x06001E3E RID: 7742 RVA: 0x000A0EDC File Offset: 0x0009F0DC
	[Token(Token = "0x6001E3E")]
	[Address(RVA = "0x577C50", Offset = "0x576250", VA = "0x180577C50", Slot = "9")]
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

	// Token: 0x06001E3F RID: 7743 RVA: 0x000A0F10 File Offset: 0x0009F110
	[Token(Token = "0x6001E3F")]
	[Address(RVA = "0x577BB0", Offset = "0x5761B0", VA = "0x180577BB0", Slot = "7")]
	public void OnDrag(PointerEventData eventData)
	{
		UnityEvent<TheCard> unityEvent = this.onDrag;
		if (unityEvent != 0)
		{
			unityEvent.Invoke(this);
			return;
		}
	}

	// Token: 0x06001E40 RID: 7744 RVA: 0x000A0F30 File Offset: 0x0009F130
	[Token(Token = "0x6001E40")]
	[Address(RVA = "0x577C00", Offset = "0x576200", VA = "0x180577C00", Slot = "8")]
	public void OnDrop(PointerEventData eventData)
	{
		UnityEvent<TheCard> unityEvent = this.onEndDrag;
		if (unityEvent != 0)
		{
			unityEvent.Invoke(this);
			return;
		}
	}

	// Token: 0x06001E41 RID: 7745 RVA: 0x000A0F50 File Offset: 0x0009F150
	[Token(Token = "0x6001E41")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public TheCard()
	{
	}

	// Token: 0x04001078 RID: 4216
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001078")]
	public UnityEvent<TheCard> clickEvent;

	// Token: 0x04001079 RID: 4217
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001079")]
	[NonSerialized]
	public UnityEvent<TheCard> onDrag;

	// Token: 0x0400107A RID: 4218
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400107A")]
	[NonSerialized]
	public UnityEvent<TheCard> onEndDrag;

	// Token: 0x0400107B RID: 4219
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400107B")]
	public Image icon;

	// Token: 0x0400107C RID: 4220
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400107C")]
	public GameObject highLight;

	// Token: 0x0400107D RID: 4221
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400107D")]
	public GameObject shadow;

	// Token: 0x0400107E RID: 4222
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400107E")]
	public TextMeshProUGUI costText;

	// Token: 0x0400107F RID: 4223
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400107F")]
	public PlantType thePlantType;

	// Token: 0x04001080 RID: 4224
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4001080")]
	public ZombieType theZombieType;

	// Token: 0x04001081 RID: 4225
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001081")]
	public bool isZombieCard;
}
