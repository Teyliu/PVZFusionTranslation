using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200080C RID: 2060
[Token(Token = "0x200080C")]
public class AlmanacZombieMenu : AlmanacSecondMenu
{
	// Token: 0x170001EA RID: 490
	// (get) Token: 0x060029E7 RID: 10727 RVA: 0x000E2454 File Offset: 0x000E0654
	// (set) Token: 0x060029E8 RID: 10728 RVA: 0x000E2468 File Offset: 0x000E0668
	[Token(Token = "0x170001EA")]
	public List<ZombieType> Shows
	{
		[Token(Token = "0x60029E7")]
		[Address(RVA = "0x68D8F0", Offset = "0x68BEF0", VA = "0x18068D8F0")]
		get;
		[Token(Token = "0x60029E8")]
		[Address(RVA = "0x68D900", Offset = "0x68BF00", VA = "0x18068D900")]
		set;
	}

	// Token: 0x060029E9 RID: 10729 RVA: 0x000E247C File Offset: 0x000E067C
	[Token(Token = "0x60029E9")]
	[Address(RVA = "0x68D650", Offset = "0x68BC50", VA = "0x18068D650")]
	private void Start()
	{
		if (this.<Shows>k__BackingField == (ulong)0L)
		{
			List<ZombieType> list = new List(GameAPP.resourcesManager.allZombieTypes);
			int num = 0;
			ZombieType zombieType = list[num];
			num++;
		}
		List<ZombieType> list2 = this.<Shows>k__BackingField;
		int num2 = 0;
		ZombieType zombieType2 = list2[num2];
		RectTransform rectTransform = this.basicCardHead;
		num2++;
		RectTransform basicCardContent = this.basicCardContent;
		rectTransform += rectTransform;
		long num3 = rectTransform * (uint)145;
		List<AlmanacCardUI> cards = this.cards;
		bool flag = this.custom;
		this.custom = false;
		int num4 = 0;
		AlmanacCardUI almanacCardUI = cards[num4];
		this.SelectCard(almanacCardUI);
		this.custom = flag;
	}

	// Token: 0x060029EA RID: 10730 RVA: 0x000E2534 File Offset: 0x000E0734
	[Token(Token = "0x60029EA")]
	[Address(RVA = "0x68CD00", Offset = "0x68B300", VA = "0x18068CD00")]
	public void SelectCard(AlmanacCardUI card)
	{
		AlmanacZombieWindow almanacZombieWindow = this.window;
		ZombieType zombieType = card._zombieType;
		almanacZombieWindow.currentZombieType = zombieType;
		if (zombieType > ZombieType.DrownGargantuar)
		{
			if (zombieType != ZombieType.SuperSubmarine)
			{
			}
			Image background = almanacZombieWindow.background;
			Sprite poolBackground = almanacZombieWindow.poolBackground;
			background.sprite = poolBackground;
			if (this.custom)
			{
				List<ZombieType> spawnZombies = this.levelData.SpawnZombies;
				ZombieType zombieType2 = card._zombieType;
				bool flag = spawnZombies.Contains(zombieType2);
				List<ZombieType> spawnZombies2 = this.levelData.SpawnZombies;
				if (flag)
				{
					goto IL_009E;
				}
				Image background2 = card.background;
				Sprite selectedSprite = card.selectedSprite;
				background2.sprite = selectedSprite;
			}
			return;
		}
		while (zombieType == ZombieType.SubmarineZombie)
		{
		}
		while (zombieType == ZombieType.DrownGargantuar)
		{
		}
		Image background3 = almanacZombieWindow.background;
		IL_009E:
		ZombieType zombieType3 = card._zombieType;
		Image background4 = card.background;
		throw new NullReferenceException();
	}

	// Token: 0x060029EB RID: 10731 RVA: 0x000E25F8 File Offset: 0x000E07F8
	[Token(Token = "0x60029EB")]
	[Address(RVA = "0x68CC20", Offset = "0x68B220", VA = "0x18068CC20")]
	public void InitCards(List<ZombieType> zombieTypes)
	{
		int num = 0;
		ZombieType zombieType = zombieTypes[num];
		RectTransform rectTransform = this.basicCardHead;
		num++;
		RectTransform basicCardContent = this.basicCardContent;
		rectTransform += rectTransform;
		long num2 = rectTransform * (uint)145;
	}

	// Token: 0x060029EC RID: 10732 RVA: 0x000E2638 File Offset: 0x000E0838
	[Token(Token = "0x60029EC")]
	[Address(RVA = "0x68CA50", Offset = "0x68B050", VA = "0x18068CA50")]
	private void InitCards()
	{
		List<ZombieType> list = new List(GameAPP.resourcesManager.allZombieTypes);
		int num = 0;
		ZombieType zombieType = list[num];
		num++;
		RectTransform basicCardContent = this.basicCardContent;
		uint num2;
		num2 += num2;
		long num3 = (long)(num2 * (uint)145);
	}

	// Token: 0x060029ED RID: 10733 RVA: 0x000E268C File Offset: 0x000E088C
	[Token(Token = "0x60029ED")]
	[Address(RVA = "0x68D4B0", Offset = "0x68BAB0", VA = "0x18068D4B0")]
	private void ShowZombieCards(Func<ZombieType, bool> condition)
	{
		ulong num;
		do
		{
			List<AlmanacCardUI> cards = this.cards;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x060029EE RID: 10734 RVA: 0x000E26CC File Offset: 0x000E08CC
	[Token(Token = "0x60029EE")]
	[Address(RVA = "0x68CEB0", Offset = "0x68B4B0", VA = "0x18068CEB0")]
	private void SetCard(Transform parent, ZombieType theZombieType)
	{
		AlmanacCardUI component = global::UnityEngine.Object.Instantiate<GameObject>(this.cardPrefab, parent).GetComponent<AlmanacCardUI>();
		component.menu = this;
		if (this.custom)
		{
			List<ZombieType> spawnZombies = this.levelData.SpawnZombies;
			ZombieType zombieType = component._zombieType;
			bool flag = spawnZombies.Contains(zombieType);
			Image background = component.background;
			if (!flag)
			{
			}
			Sprite selectedSprite = component.selectedSprite;
			background.sprite = selectedSprite;
		}
		List<AlmanacCardUI> cards = this.cards;
		int size = cards._size;
	}

	// Token: 0x060029EF RID: 10735 RVA: 0x000E2754 File Offset: 0x000E0954
	[Token(Token = "0x60029EF")]
	[Address(RVA = "0x68D070", Offset = "0x68B670", VA = "0x18068D070")]
	public void ShowAll()
	{
		Func<ZombieType, bool> <>9__15_ = AlmanacZombieMenu.<>c.<>9__15_0;
		if (<>9__15_ == 0)
		{
			AlmanacZombieMenu.<>c.<>9__15_0 = (ZombieType p) => true;
		}
		this.ShowZombieCards(<>9__15_);
	}

	// Token: 0x060029F0 RID: 10736 RVA: 0x000E2790 File Offset: 0x000E0990
	[Token(Token = "0x60029F0")]
	[Address(RVA = "0x68D3A0", Offset = "0x68B9A0", VA = "0x18068D3A0")]
	public void ShowUlti()
	{
		Func<ZombieType, bool> <>9__16_ = AlmanacZombieMenu.<>c.<>9__16_0;
		if (<>9__16_ == 0)
		{
			AlmanacZombieMenu.<>c.<>9__16_0 = delegate(ZombieType p)
			{
				bool flag;
				return flag;
			};
		}
		this.ShowZombieCards(<>9__16_);
	}

	// Token: 0x060029F1 RID: 10737 RVA: 0x000E27CC File Offset: 0x000E09CC
	[Token(Token = "0x60029F1")]
	[Address(RVA = "0x68D180", Offset = "0x68B780", VA = "0x18068D180")]
	public void ShowBoss()
	{
		Func<ZombieType, bool> <>9__17_ = AlmanacZombieMenu.<>c.<>9__17_0;
		if (<>9__17_ == 0)
		{
			AlmanacZombieMenu.<>c.<>9__17_0 = delegate(ZombieType p)
			{
				bool flag;
				return flag;
			};
		}
		this.ShowZombieCards(<>9__17_);
	}

	// Token: 0x060029F2 RID: 10738 RVA: 0x000E2808 File Offset: 0x000E0A08
	[Token(Token = "0x60029F2")]
	[Address(RVA = "0x68D290", Offset = "0x68B890", VA = "0x18068D290")]
	public void ShowLevel()
	{
		Func<ZombieType, bool> <>9__18_ = AlmanacZombieMenu.<>c.<>9__18_0;
		if (<>9__18_ == 0)
		{
			AlmanacZombieMenu.<>c.<>9__18_0 = delegate(ZombieType p)
			{
				bool flag;
				return flag;
			};
		}
		this.ShowZombieCards(<>9__18_);
	}

	// Token: 0x060029F3 RID: 10739 RVA: 0x000E2844 File Offset: 0x000E0A44
	[Token(Token = "0x60029F3")]
	[Address(RVA = "0x68D8E0", Offset = "0x68BEE0", VA = "0x18068D8E0")]
	public AlmanacZombieMenu()
	{
	}

	// Token: 0x040017E6 RID: 6118
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40017E6")]
	[Header("图鉴展示项")]
	public AlmanacZombieWindow window;

	// Token: 0x040017E7 RID: 6119
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40017E7")]
	[Header("资源")]
	public GameObject cardPrefab;

	// Token: 0x040017E8 RID: 6120
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40017E8")]
	public bool custom;

	// Token: 0x040017E9 RID: 6121
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40017E9")]
	public SerializedLevelData levelData;

	// Token: 0x040017EA RID: 6122
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40017EA")]
	public UnityEvent<ZombieType> onClickZombieCard;
}
