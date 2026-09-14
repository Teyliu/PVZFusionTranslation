using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020007D3 RID: 2003
[Token(Token = "0x20007D3")]
public class AlmanacZombieMenu : AlmanacSecondMenu
{
	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x060028B8 RID: 10424 RVA: 0x000DD464 File Offset: 0x000DB664
	// (set) Token: 0x060028B9 RID: 10425 RVA: 0x000DD478 File Offset: 0x000DB678
	[Token(Token = "0x170001A0")]
	public List<ZombieType> Shows
	{
		[Token(Token = "0x60028B8")]
		[Address(RVA = "0x629FF0", Offset = "0x6285F0", VA = "0x180629FF0")]
		get;
		[Token(Token = "0x60028B9")]
		[Address(RVA = "0x62A000", Offset = "0x628600", VA = "0x18062A000")]
		set;
	}

	// Token: 0x060028BA RID: 10426 RVA: 0x000DD48C File Offset: 0x000DB68C
	[Token(Token = "0x60028BA")]
	[Address(RVA = "0x629D50", Offset = "0x628350", VA = "0x180629D50")]
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

	// Token: 0x060028BB RID: 10427 RVA: 0x000DD544 File Offset: 0x000DB744
	[Token(Token = "0x60028BB")]
	[Address(RVA = "0x629400", Offset = "0x627A00", VA = "0x180629400")]
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

	// Token: 0x060028BC RID: 10428 RVA: 0x000DD608 File Offset: 0x000DB808
	[Token(Token = "0x60028BC")]
	[Address(RVA = "0x629320", Offset = "0x627920", VA = "0x180629320")]
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

	// Token: 0x060028BD RID: 10429 RVA: 0x000DD648 File Offset: 0x000DB848
	[Token(Token = "0x60028BD")]
	[Address(RVA = "0x629150", Offset = "0x627750", VA = "0x180629150")]
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

	// Token: 0x060028BE RID: 10430 RVA: 0x000DD69C File Offset: 0x000DB89C
	[Token(Token = "0x60028BE")]
	[Address(RVA = "0x629BB0", Offset = "0x6281B0", VA = "0x180629BB0")]
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

	// Token: 0x060028BF RID: 10431 RVA: 0x000DD6DC File Offset: 0x000DB8DC
	[Token(Token = "0x60028BF")]
	[Address(RVA = "0x6295B0", Offset = "0x627BB0", VA = "0x1806295B0")]
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

	// Token: 0x060028C0 RID: 10432 RVA: 0x000DD764 File Offset: 0x000DB964
	[Token(Token = "0x60028C0")]
	[Address(RVA = "0x629770", Offset = "0x627D70", VA = "0x180629770")]
	public void ShowAll()
	{
		Func<ZombieType, bool> <>9__15_ = AlmanacZombieMenu.<>c.<>9__15_0;
		if (<>9__15_ == 0)
		{
			AlmanacZombieMenu.<>c.<>9__15_0 = (ZombieType p) => true;
		}
		this.ShowZombieCards(<>9__15_);
	}

	// Token: 0x060028C1 RID: 10433 RVA: 0x000DD7A0 File Offset: 0x000DB9A0
	[Token(Token = "0x60028C1")]
	[Address(RVA = "0x629AA0", Offset = "0x6280A0", VA = "0x180629AA0")]
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

	// Token: 0x060028C2 RID: 10434 RVA: 0x000DD7DC File Offset: 0x000DB9DC
	[Token(Token = "0x60028C2")]
	[Address(RVA = "0x629880", Offset = "0x627E80", VA = "0x180629880")]
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

	// Token: 0x060028C3 RID: 10435 RVA: 0x000DD818 File Offset: 0x000DBA18
	[Token(Token = "0x60028C3")]
	[Address(RVA = "0x629990", Offset = "0x627F90", VA = "0x180629990")]
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

	// Token: 0x060028C4 RID: 10436 RVA: 0x000DD854 File Offset: 0x000DBA54
	[Token(Token = "0x60028C4")]
	[Address(RVA = "0x629FE0", Offset = "0x6285E0", VA = "0x180629FE0")]
	public AlmanacZombieMenu()
	{
	}

	// Token: 0x0400170A RID: 5898
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400170A")]
	[Header("图鉴展示项")]
	public AlmanacZombieWindow window;

	// Token: 0x0400170B RID: 5899
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400170B")]
	[Header("资源")]
	public GameObject cardPrefab;

	// Token: 0x0400170C RID: 5900
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400170C")]
	public bool custom;

	// Token: 0x0400170D RID: 5901
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400170D")]
	public SerializedLevelData levelData;

	// Token: 0x0400170E RID: 5902
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400170E")]
	public UnityEvent<ZombieType> onClickZombieCard;
}
