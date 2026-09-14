using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200060D RID: 1549
[Token(Token = "0x200060D")]
public class TreasureCard : MonoBehaviour
{
	// Token: 0x1700014D RID: 333
	// (get) Token: 0x06001D43 RID: 7491 RVA: 0x0009C48C File Offset: 0x0009A68C
	// (set) Token: 0x06001D44 RID: 7492 RVA: 0x0009C4A0 File Offset: 0x0009A6A0
	[Token(Token = "0x1700014D")]
	public PlantType PlantType
	{
		[Token(Token = "0x6001D43")]
		[Address(RVA = "0x3D1110", Offset = "0x3CF710", VA = "0x1803D1110")]
		get
		{
			return this._plantType;
		}
		[Token(Token = "0x6001D44")]
		[Address(RVA = "0x525B30", Offset = "0x524130", VA = "0x180525B30")]
		set
		{
			this._plantType = value;
			this.SetIcon();
		}
	}

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x06001D45 RID: 7493 RVA: 0x0009C4BC File Offset: 0x0009A6BC
	// (set) Token: 0x06001D46 RID: 7494 RVA: 0x0009C4D0 File Offset: 0x0009A6D0
	[Token(Token = "0x1700014E")]
	public int Durability
	{
		[Token(Token = "0x6001D45")]
		[Address(RVA = "0x525960", Offset = "0x523F60", VA = "0x180525960")]
		get
		{
			return this._durability;
		}
		[Token(Token = "0x6001D46")]
		[Address(RVA = "0x5259B0", Offset = "0x523FB0", VA = "0x1805259B0")]
		set
		{
			TextMeshProUGUI textMeshProUGUI = this.durText;
			this._durability = value;
			int maxDurability = this._maxDurability;
			string text = string.Format("{0}/{1}", "{0}/{1}", "{0}/{1}");
			textMeshProUGUI.text = text;
		}
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06001D47 RID: 7495 RVA: 0x0009C514 File Offset: 0x0009A714
	// (set) Token: 0x06001D48 RID: 7496 RVA: 0x0009C528 File Offset: 0x0009A728
	[Token(Token = "0x1700014F")]
	public int MaxDurability
	{
		[Token(Token = "0x6001D47")]
		[Address(RVA = "0x525970", Offset = "0x523F70", VA = "0x180525970")]
		get
		{
			return this._maxDurability;
		}
		[Token(Token = "0x6001D48")]
		[Address(RVA = "0x525A70", Offset = "0x524070", VA = "0x180525A70")]
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

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06001D49 RID: 7497 RVA: 0x0009C56C File Offset: 0x0009A76C
	[Token(Token = "0x17000150")]
	public int RealCost
	{
		[Token(Token = "0x6001D49")]
		[Address(RVA = "0x525980", Offset = "0x523F80", VA = "0x180525980")]
		get
		{
			if (this._maxDurability > 1)
			{
				return this.cost;
			}
			return 0;
		}
	}

	// Token: 0x06001D4A RID: 7498 RVA: 0x0009C58C File Offset: 0x0009A78C
	[Token(Token = "0x6001D4A")]
	[Address(RVA = "0x524CC0", Offset = "0x5232C0", VA = "0x180524CC0")]
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

	// Token: 0x06001D4B RID: 7499 RVA: 0x0009C5EC File Offset: 0x0009A7EC
	[Token(Token = "0x6001D4B")]
	[Address(RVA = "0x524DC0", Offset = "0x5233C0", VA = "0x180524DC0")]
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

	// Token: 0x06001D4C RID: 7500 RVA: 0x0009C66C File Offset: 0x0009A86C
	[Token(Token = "0x6001D4C")]
	[Address(RVA = "0x5258D0", Offset = "0x523ED0", VA = "0x1805258D0")]
	private void Start()
	{
		this.Init();
	}

	// Token: 0x06001D4D RID: 7501 RVA: 0x0009C680 File Offset: 0x0009A880
	[Token(Token = "0x6001D4D")]
	[Address(RVA = "0x525520", Offset = "0x523B20", VA = "0x180525520")]
	private void OnMouseEnter()
	{
		CursorChange.SetClickCursor();
	}

	// Token: 0x06001D4E RID: 7502 RVA: 0x0009C694 File Offset: 0x0009A894
	[Token(Token = "0x6001D4E")]
	[Address(RVA = "0x51B300", Offset = "0x519900", VA = "0x18051B300")]
	private void OnMouseExit()
	{
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06001D4F RID: 7503 RVA: 0x0009C6A8 File Offset: 0x0009A8A8
	[Token(Token = "0x6001D4F")]
	[Address(RVA = "0x525000", Offset = "0x523600", VA = "0x180525000")]
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
		int num4 = 0;
		instance2.ShowText("出战已满", 3f, num4 != 0);
	}

	// Token: 0x06001D50 RID: 7504 RVA: 0x0009C7B8 File Offset: 0x0009A9B8
	[Token(Token = "0x6001D50")]
	[Address(RVA = "0x525680", Offset = "0x523C80", VA = "0x180525680")]
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

	// Token: 0x06001D51 RID: 7505 RVA: 0x0009C820 File Offset: 0x0009AA20
	[Token(Token = "0x6001D51")]
	[Address(RVA = "0x525530", Offset = "0x523B30", VA = "0x180525530")]
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

	// Token: 0x06001D52 RID: 7506 RVA: 0x0009C884 File Offset: 0x0009AA84
	[Token(Token = "0x6001D52")]
	[Address(RVA = "0x5258E0", Offset = "0x523EE0", VA = "0x1805258E0")]
	public TreasureCard()
	{
		List<Sprite> list = new List();
		this.sprites = list;
		base..ctor();
	}

	// Token: 0x04000FBA RID: 4026
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FBA")]
	[SerializeField]
	private PlantType _plantType;

	// Token: 0x04000FBB RID: 4027
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000FBB")]
	[SerializeField]
	private int _durability;

	// Token: 0x04000FBC RID: 4028
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000FBC")]
	[SerializeField]
	private int _maxDurability;

	// Token: 0x04000FBD RID: 4029
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000FBD")]
	[Header("引用")]
	public TreasureCardData data;

	// Token: 0x04000FBE RID: 4030
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000FBE")]
	public List<Sprite> sprites;

	// Token: 0x04000FBF RID: 4031
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000FBF")]
	private Image cardIcon;

	// Token: 0x04000FC0 RID: 4032
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000FC0")]
	private Image back;

	// Token: 0x04000FC1 RID: 4033
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000FC1")]
	private TextMeshProUGUI durText;

	// Token: 0x04000FC2 RID: 4034
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000FC2")]
	[Header("属性")]
	public int cost;

	// Token: 0x04000FC3 RID: 4035
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000FC3")]
	public CardLevel level;

	// Token: 0x04000FC4 RID: 4036
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000FC4")]
	public TreasureCard.Status theStatus;

	// Token: 0x0200060E RID: 1550
	[Token(Token = "0x200060E")]
	public enum Status
	{
		// Token: 0x04000FC6 RID: 4038
		[Token(Token = "0x4000FC6")]
		WareHouse,
		// Token: 0x04000FC7 RID: 4039
		[Token(Token = "0x4000FC7")]
		Store,
		// Token: 0x04000FC8 RID: 4040
		[Token(Token = "0x4000FC8")]
		Game,
		// Token: 0x04000FC9 RID: 4041
		[Token(Token = "0x4000FC9")]
		Equipment,
		// Token: 0x04000FCA RID: 4042
		[Token(Token = "0x4000FCA")]
		Upgrade
	}
}
