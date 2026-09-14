using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

// Token: 0x020001F4 RID: 500
[Token(Token = "0x20001F4")]
public class IZECard : CardUI
{
	// Token: 0x06000886 RID: 2182 RVA: 0x0002C2A4 File Offset: 0x0002A4A4
	[Token(Token = "0x6000886")]
	[Address(RVA = "0x869C80", Offset = "0x868280", VA = "0x180869C80", Slot = "4")]
	protected override void Awake()
	{
		Board instance = Board.Instance;
		this.board = instance;
		int theSeedType = this.theSeedType;
		this.theZombieType = (ZombieType)theSeedType;
		int num = 0;
		this.CD = (float)num;
	}

	// Token: 0x06000887 RID: 2183 RVA: 0x0002C2D8 File Offset: 0x0002A4D8
	[Token(Token = "0x6000887")]
	[Address(RVA = "0x869EE0", Offset = "0x8684E0", VA = "0x180869EE0")]
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

	// Token: 0x06000888 RID: 2184 RVA: 0x0002C3B4 File Offset: 0x0002A5B4
	[Token(Token = "0x6000888")]
	[Address(RVA = "0x869CE0", Offset = "0x8682E0", VA = "0x180869CE0", Slot = "5")]
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

	// Token: 0x06000889 RID: 2185 RVA: 0x0002C438 File Offset: 0x0002A638
	[Token(Token = "0x6000889")]
	[Address(RVA = "0x86A310", Offset = "0x868910", VA = "0x18086A310", Slot = "6")]
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

	// Token: 0x0600088A RID: 2186 RVA: 0x0002C50C File Offset: 0x0002A70C
	[Token(Token = "0x600088A")]
	[Address(RVA = "0x86A5E0", Offset = "0x868BE0", VA = "0x18086A5E0")]
	public IZECard()
	{
	}

	// Token: 0x04000415 RID: 1045
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000415")]
	public ZombieCardPackage zombieCardPackage;

	// Token: 0x04000416 RID: 1046
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000416")]
	private SortingGroup z_sortingGroup;

	// Token: 0x04000417 RID: 1047
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000417")]
	public Action<Zombie> onSetZombie;
}
