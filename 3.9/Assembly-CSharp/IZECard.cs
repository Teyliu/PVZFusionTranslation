using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

// Token: 0x020001FB RID: 507
[Token(Token = "0x20001FB")]
public class IZECard : CardUI
{
	// Token: 0x060008A0 RID: 2208 RVA: 0x0002C280 File Offset: 0x0002A480
	[Token(Token = "0x60008A0")]
	[Address(RVA = "0x8F89D0", Offset = "0x8F6FD0", VA = "0x1808F89D0", Slot = "4")]
	protected override void Awake()
	{
		Board instance = Board.Instance;
		this.board = instance;
		int theSeedType = this.theSeedType;
		this.theZombieType = (ZombieType)theSeedType;
		int num = 0;
		this.CD = (float)num;
	}

	// Token: 0x060008A1 RID: 2209 RVA: 0x0002C2B4 File Offset: 0x0002A4B4
	[Token(Token = "0x60008A1")]
	[Address(RVA = "0x8F8C30", Offset = "0x8F7230", VA = "0x1808F8C30")]
	public void UpdateSprite()
	{
		Transform transform = base.transform;
		int num = 0;
		Image component = transform.GetChild(num).GetComponent<Image>();
		Transform transform2 = base.transform;
		int num2 = 0;
		RectTransform component2 = transform2.GetChild(num2).GetComponent<RectTransform>();
		Dictionary<ZombieType, Sprite> zombieSprites = GameAPP.resourcesManager.zombieSprites;
		bool flag;
		if (flag)
		{
		}
		component.SetNativeSize();
		Vector2 sizeDelta = component2.sizeDelta;
		int num3 = 0;
		Vector2 sizeDelta2 = component2.sizeDelta;
		component2.sizeDelta = num3;
		ZombieCardPackage zombieCardPackage = this.zombieCardPackage;
		int num4 = 0;
		if (zombieCardPackage != num4)
		{
			ZombieCardPackage zombieCardPackage2 = this.zombieCardPackage;
			Image backgroundIcon = zombieCardPackage2.backgroundIcon;
			RectTransform component3 = backgroundIcon.GetComponent<RectTransform>();
			Image backgroundIcon2 = zombieCardPackage2.backgroundIcon;
			backgroundIcon.SetNativeSize();
			Vector2 sizeDelta3 = component3.sizeDelta;
			int num5 = 0;
			Vector2 sizeDelta4 = component3.sizeDelta;
			component3.sizeDelta = num5;
		}
	}

	// Token: 0x060008A2 RID: 2210 RVA: 0x0002C390 File Offset: 0x0002A590
	[Token(Token = "0x60008A2")]
	[Address(RVA = "0x8F8A30", Offset = "0x8F7030", VA = "0x1808F8A30", Slot = "5")]
	protected override void Start()
	{
		InGameUI_IZ instance = InGameUI_IZ.Instance;
		int num = 0;
		if (instance != num)
		{
			List<IZECard> zombieCards = InGameUI_IZ.Instance.zombieCards;
			int size = zombieCards._size;
			zombieCards._size = typeof(InGameUI_IZ).TypeHandle;
		}
		uint num2;
		Slider component = base.transform.GetChild((int)num2).gameObject.GetComponent<Slider>();
		this.slider = component;
		uint num3;
		string text;
		base.transform.GetChild((int)num3).GetComponent<TextMeshProUGUI>().text = text;
		this.UpdateSprite();
	}

	// Token: 0x060008A3 RID: 2211 RVA: 0x0002C414 File Offset: 0x0002A614
	[Token(Token = "0x60008A3")]
	[Address(RVA = "0x8F9060", Offset = "0x8F7660", VA = "0x1808F9060", Slot = "6")]
	protected override void Update()
	{
		Board instance = Board.Instance;
		int num = 0;
		if (instance != num)
		{
			Board instance2 = Board.Instance;
			int theSeedCost = this.theSeedCost;
			GameObject gameObject = base.transform.GetChild(3).gameObject;
		}
		base.transform.GetChild(3).gameObject.SetActive(true);
		SortingGroup sortingGroup = this.z_sortingGroup;
		int num2 = 0;
		if (sortingGroup != num2)
		{
			SortingGroup sortingGroup2 = this.z_sortingGroup;
			string sortingLayerName = InGameUI.Instance.transform.parent.GetComponent<Canvas>().sortingLayerName;
			sortingGroup2.sortingLayerName = sortingLayerName;
			SortingGroup sortingGroup3 = this.z_sortingGroup;
			int num3 = InGameUI.Instance.transform.parent.GetComponent<Canvas>().sortingOrder + 1;
			sortingGroup3.sortingOrder = num3;
		}
		base.CDUpdate();
	}

	// Token: 0x060008A4 RID: 2212 RVA: 0x0002C4E8 File Offset: 0x0002A6E8
	[Token(Token = "0x60008A4")]
	[Address(RVA = "0x8F9330", Offset = "0x8F7930", VA = "0x1808F9330")]
	public IZECard()
	{
	}

	// Token: 0x0400041F RID: 1055
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400041F")]
	public ZombieCardPackage zombieCardPackage;

	// Token: 0x04000420 RID: 1056
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000420")]
	private SortingGroup z_sortingGroup;

	// Token: 0x04000421 RID: 1057
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000421")]
	public Action<Zombie> onSetZombie;
}
