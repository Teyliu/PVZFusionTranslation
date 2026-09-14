using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000642 RID: 1602
[Token(Token = "0x2000642")]
public class TreasureCard : MonoBehaviour
{
	// Token: 0x17000193 RID: 403
	// (get) Token: 0x06001E42 RID: 7746 RVA: 0x000A0F64 File Offset: 0x0009F164
	// (set) Token: 0x06001E43 RID: 7747 RVA: 0x000A0F78 File Offset: 0x0009F178
	[Token(Token = "0x17000193")]
	public PlantType PlantType
	{
		[Token(Token = "0x6001E42")]
		[Address(RVA = "0x41DF70", Offset = "0x41C570", VA = "0x18041DF70")]
		get
		{
			return this._plantType;
		}
		[Token(Token = "0x6001E43")]
		[Address(RVA = "0x590CC0", Offset = "0x58F2C0", VA = "0x180590CC0")]
		set
		{
			this._plantType = value;
			this.SetIcon();
		}
	}

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x06001E44 RID: 7748 RVA: 0x000A0F94 File Offset: 0x0009F194
	// (set) Token: 0x06001E45 RID: 7749 RVA: 0x000A0FA8 File Offset: 0x0009F1A8
	[Token(Token = "0x17000194")]
	public int Durability
	{
		[Token(Token = "0x6001E44")]
		[Address(RVA = "0x590AF0", Offset = "0x58F0F0", VA = "0x180590AF0")]
		get
		{
			return this._durability;
		}
		[Token(Token = "0x6001E45")]
		[Address(RVA = "0x590B40", Offset = "0x58F140", VA = "0x180590B40")]
		set
		{
			TextMeshProUGUI textMeshProUGUI = this.durText;
			this._durability = value;
			int maxDurability = this._maxDurability;
			string text = string.Format("{0}/{1}", "{0}/{1}", "{0}/{1}");
			textMeshProUGUI.text = text;
		}
	}

	// Token: 0x17000195 RID: 405
	// (get) Token: 0x06001E46 RID: 7750 RVA: 0x000A0FEC File Offset: 0x0009F1EC
	// (set) Token: 0x06001E47 RID: 7751 RVA: 0x000A1000 File Offset: 0x0009F200
	[Token(Token = "0x17000195")]
	public int MaxDurability
	{
		[Token(Token = "0x6001E46")]
		[Address(RVA = "0x590B00", Offset = "0x58F100", VA = "0x180590B00")]
		get
		{
			return this._maxDurability;
		}
		[Token(Token = "0x6001E47")]
		[Address(RVA = "0x590C00", Offset = "0x58F200", VA = "0x180590C00")]
		set
		{
			int durability = this._durability;
			TextMeshProUGUI textMeshProUGUI = this.durText;
			this._maxDurability = value;
			int maxDurability = this._maxDurability;
			string text = string.Format("{0}/{1}", value, durability);
			textMeshProUGUI.text = text;
		}
	}

	// Token: 0x17000196 RID: 406
	// (get) Token: 0x06001E48 RID: 7752 RVA: 0x000A1044 File Offset: 0x0009F244
	[Token(Token = "0x17000196")]
	public int RealCost
	{
		[Token(Token = "0x6001E48")]
		[Address(RVA = "0x590B10", Offset = "0x58F110", VA = "0x180590B10")]
		get
		{
			if (this._maxDurability > 1)
			{
				return this.cost;
			}
			return 0;
		}
	}

	// Token: 0x06001E49 RID: 7753 RVA: 0x000A1064 File Offset: 0x0009F264
	[Token(Token = "0x6001E49")]
	[Address(RVA = "0x58FE40", Offset = "0x58E440", VA = "0x18058FE40")]
	private void Awake()
	{
		Image component = base.transform.GetComponent<Image>();
		this.back = component;
		Transform transform = base.transform;
		int num = 0;
		Image component2 = transform.GetChild(num).GetComponent<Image>();
		this.cardIcon = component2;
		TextMeshProUGUI component3 = base.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
		this.durText = component3;
		throw new NullReferenceException();
	}

	// Token: 0x06001E4A RID: 7754 RVA: 0x000A10C4 File Offset: 0x0009F2C4
	[Token(Token = "0x6001E4A")]
	[Address(RVA = "0x58FF40", Offset = "0x58E540", VA = "0x18058FF40")]
	public void Init()
	{
		PlantType plantType = this._plantType;
		PlantDataManager.PlantData plantData;
		int num = plantData.cost;
		CardLevel cardLevel;
		uint num2;
		if (cardLevel <= CardLevel.Red)
		{
			num2 += num2;
		}
		PlantType plantType2 = this._plantType;
		this.cost = (int)num2;
		CardLevel cardLevel2 = TreasureData.GetCardLevel(plantType2);
		this.level = cardLevel2;
		if (cardLevel2 <= CardLevel.Red)
		{
			List<Sprite> list = this.sprites;
			Image image = this.back;
			int num3 = 0;
			Sprite sprite = list[num3];
			image.sprite = sprite;
		}
	}

	// Token: 0x06001E4B RID: 7755 RVA: 0x000A1144 File Offset: 0x0009F344
	[Token(Token = "0x6001E4B")]
	[Address(RVA = "0x590A60", Offset = "0x58F060", VA = "0x180590A60")]
	private void Start()
	{
		this.Init();
	}

	// Token: 0x06001E4C RID: 7756 RVA: 0x000A1158 File Offset: 0x0009F358
	[Token(Token = "0x6001E4C")]
	[Address(RVA = "0x5906B0", Offset = "0x58ECB0", VA = "0x1805906B0")]
	private void OnMouseEnter()
	{
		CursorChange.SetClickCursor();
	}

	// Token: 0x06001E4D RID: 7757 RVA: 0x000A116C File Offset: 0x0009F36C
	[Token(Token = "0x6001E4D")]
	[Address(RVA = "0x575490", Offset = "0x573A90", VA = "0x180575490")]
	private void OnMouseExit()
	{
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06001E4E RID: 7758 RVA: 0x000A1180 File Offset: 0x0009F380
	[Token(Token = "0x6001E4E")]
	[Address(RVA = "0x590180", Offset = "0x58E780", VA = "0x180590180")]
	private void OnMouseDown()
	{
		TreasureWarehouseMenu instance;
		int num2;
		do
		{
			uint num;
			GameAPP.PlaySound((int)num, 0.5f, 1f);
			TreasureCard.Status status = this.theStatus;
			if (status != TreasureCard.Status.WareHouse)
			{
				if (status != TreasureCard.Status.WareHouse)
				{
					if (status != TreasureCard.Status.WareHouse)
					{
						if (status != TreasureCard.Status.Store)
						{
							return;
						}
						if (!this.data.equiped)
						{
							goto Block_4;
						}
						TreasureCardData treasureCardData = this.data;
						bool flag = !treasureCardData.equiped;
						treasureCardData.equiped = flag;
						TreasureEquipmentMenu.Instance.UpdateCards();
					}
					UIResourcesLoader uimanager = GameAPP.UIManager;
				}
				UIResourcesLoader uimanager2 = GameAPP.UIManager;
			}
			UIResourcesLoader uimanager3 = GameAPP.UIManager;
			instance = TreasureWarehouseMenu.Instance;
			num2 = 0;
		}
		while (!(instance != num2));
		while (!instance.quickSell)
		{
		}
		throw new NullReferenceException();
		Block_4:
		List<TreasureCardData> treasureCards = TreasureData.treasureCards;
		Predicate<TreasureCardData> <>9__27_ = TreasureCard.<>c.<>9__27_0;
		if (<>9__27_ == 0)
		{
			Predicate<TreasureCardData> predicate;
			TreasureCard.<>c.<>9__27_0 = predicate;
		}
		List<TreasureCardData> list = treasureCards.FindAll(<>9__27_);
		uint num3;
		GameAPP.PlaySound((int)num3, 0.5f, 1f);
		InGameText instance2 = InGameText.Instance;
	}

	// Token: 0x06001E4F RID: 7759 RVA: 0x000A1278 File Offset: 0x0009F478
	[Token(Token = "0x6001E4F")]
	[Address(RVA = "0x590810", Offset = "0x58EE10", VA = "0x180590810")]
	private void SetIcon()
	{
		int num = 0;
		Dictionary<PlantType, GameObject> plantPreviews = GameAPP.resourcesManager.plantPreviews;
		PlantType plantType = this._plantType;
		if (plantPreviews.TryGetValue(plantType, num))
		{
			Image image = this.cardIcon;
			SpriteRenderer spriteRenderer;
			Sprite sprite = spriteRenderer.sprite;
			image.sprite = sprite;
			this.cardIcon.SetNativeSize();
			Transform transform = this.cardIcon.transform;
		}
	}

	// Token: 0x06001E50 RID: 7760 RVA: 0x000A12E0 File Offset: 0x0009F4E0
	[Token(Token = "0x6001E50")]
	[Address(RVA = "0x5906C0", Offset = "0x58ECC0", VA = "0x1805906C0")]
	public void Sell()
	{
		int num = TreasureData.treasureMoney;
		if (this._maxDurability > 1)
		{
		}
		int num2 = 0;
		num -= num2;
		TreasureData.treasureMoney = num;
		List<TreasureCardData> treasureCards = TreasureData.treasureCards;
		TreasureCardData treasureCardData = this.data;
		bool flag = treasureCards.Remove(treasureCardData);
		global::UnityEngine.Object.Destroy(base.gameObject);
		uint num3;
		GameAPP.PlaySound((int)num3, 0.5f, 1f);
	}

	// Token: 0x06001E51 RID: 7761 RVA: 0x000A1344 File Offset: 0x0009F544
	[Token(Token = "0x6001E51")]
	[Address(RVA = "0x590A70", Offset = "0x58F070", VA = "0x180590A70")]
	public TreasureCard()
	{
		List<Sprite> list = new List();
		this.sprites = list;
		base..ctor();
	}

	// Token: 0x04001082 RID: 4226
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001082")]
	[SerializeField]
	private PlantType _plantType;

	// Token: 0x04001083 RID: 4227
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001083")]
	[SerializeField]
	private int _durability;

	// Token: 0x04001084 RID: 4228
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001084")]
	[SerializeField]
	private int _maxDurability;

	// Token: 0x04001085 RID: 4229
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001085")]
	[Header("引用")]
	public TreasureCardData data;

	// Token: 0x04001086 RID: 4230
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001086")]
	public List<Sprite> sprites;

	// Token: 0x04001087 RID: 4231
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001087")]
	private Image cardIcon;

	// Token: 0x04001088 RID: 4232
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001088")]
	private Image back;

	// Token: 0x04001089 RID: 4233
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001089")]
	private TextMeshProUGUI durText;

	// Token: 0x0400108A RID: 4234
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400108A")]
	[Header("属性")]
	public int cost;

	// Token: 0x0400108B RID: 4235
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400108B")]
	public CardLevel level;

	// Token: 0x0400108C RID: 4236
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400108C")]
	public TreasureCard.Status theStatus;

	// Token: 0x02000643 RID: 1603
	[Token(Token = "0x2000643")]
	public enum Status
	{
		// Token: 0x0400108E RID: 4238
		[Token(Token = "0x400108E")]
		WareHouse,
		// Token: 0x0400108F RID: 4239
		[Token(Token = "0x400108F")]
		Store,
		// Token: 0x04001090 RID: 4240
		[Token(Token = "0x4001090")]
		Game,
		// Token: 0x04001091 RID: 4241
		[Token(Token = "0x4001091")]
		Equipment,
		// Token: 0x04001092 RID: 4242
		[Token(Token = "0x4001092")]
		Upgrade
	}
}
