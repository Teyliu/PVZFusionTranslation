using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000870 RID: 2160
[Token(Token = "0x2000870")]
public class ExploreEnterWindow : UIButton
{
	// Token: 0x06002BEA RID: 11242 RVA: 0x000EEC28 File Offset: 0x000ECE28
	[Token(Token = "0x6002BEA")]
	[Address(RVA = "0x6B8500", Offset = "0x6B6B00", VA = "0x1806B8500")]
	private void Awake()
	{
		this.basicPlant = true;
	}

	// Token: 0x06002BEB RID: 11243 RVA: 0x000EEC3C File Offset: 0x000ECE3C
	[Token(Token = "0x6002BEB")]
	[Address(RVA = "0x6B8B20", Offset = "0x6B7120", VA = "0x1806B8B20", Slot = "4")]
	protected override void Start()
	{
		base.Start();
	}

	// Token: 0x06002BEC RID: 11244 RVA: 0x000EEC50 File Offset: 0x000ECE50
	[Token(Token = "0x6002BEC")]
	[Address(RVA = "0x6B8590", Offset = "0x6B6B90", VA = "0x1806B8590")]
	public void SetDisable(bool disabled)
	{
		this.disabled = disabled;
		if (disabled)
		{
			this.trophy.SetActive(true);
			Image image = this.plantIcon;
			Sprite sprite = Resources.Load<Sprite>("UI/Spirte/lock");
			image.sprite = sprite;
			this.plantIcon.SetNativeSize();
			Transform transform = this.plantIcon.transform;
			this.nameText.text = "敬请期待";
		}
	}

	// Token: 0x06002BED RID: 11245 RVA: 0x000EECBC File Offset: 0x000ECEBC
	[Token(Token = "0x6002BED")]
	[Address(RVA = "0x6B8A20", Offset = "0x6B7020", VA = "0x1806B8A20")]
	public void SetInfo(PlantType thePlantType)
	{
		GameObject gameObject = this.trophy;
		if (!this.basicPlant)
		{
			bool flag = GameAPP.exploreLevelCompleted.Contains(thePlantType);
		}
		UnlockType unlockType;
		bool flag2 = unlockType != UnlockType.NotUnlocked;
		gameObject.SetActive(flag2);
		TextMeshProUGUI textMeshProUGUI = this.nameText;
		throw new NullReferenceException();
	}

	// Token: 0x06002BEE RID: 11246 RVA: 0x000EED08 File Offset: 0x000ECF08
	[Token(Token = "0x6002BEE")]
	[Address(RVA = "0x6B8720", Offset = "0x6B6D20", VA = "0x1806B8720")]
	private void SetIcon(PlantType thePlantType)
	{
		Image image = this.plantIcon;
		int num = 0;
		Transform transform = image.transform;
		Dictionary<PlantType, GameObject> plantPreviews = GameAPP.resourcesManager.plantPreviews;
		bool flag;
		if (flag || transform != 0)
		{
			if (transform != 0)
			{
			}
			Image image2 = this.plantIcon;
			SpriteRenderer spriteRenderer;
			Sprite sprite = spriteRenderer.sprite;
			image2.sprite = sprite;
		}
		this.plantIcon.SetNativeSize();
		bool flag2;
		if (!flag2)
		{
		}
		int childCount = this.sceneHead.childCount;
		if (num < childCount)
		{
			GameObject gameObject = this.sceneHead.GetChild(num).gameObject;
			bool flag3 = num == 4;
			gameObject.SetActive(flag3);
			Transform transform2 = this.sceneHead;
			num++;
		}
	}

	// Token: 0x06002BEF RID: 11247 RVA: 0x000EEDB4 File Offset: 0x000ECFB4
	[Token(Token = "0x6002BEF")]
	[Address(RVA = "0x6B8510", Offset = "0x6B6B10", VA = "0x1806B8510")]
	private SceneType GetPlantScene(PlantType thePlantType)
	{
		bool flag;
		if (!flag)
		{
		}
		return SceneType.Roof;
	}

	// Token: 0x06002BF0 RID: 11248 RVA: 0x000EEDD4 File Offset: 0x000ECFD4
	[Token(Token = "0x6002BF0")]
	[Address(RVA = "0x5763F0", Offset = "0x5749F0", VA = "0x1805763F0")]
	public ExploreEnterWindow()
	{
	}

	// Token: 0x040019CD RID: 6605
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40019CD")]
	[Header("属性")]
	public bool basicPlant;

	// Token: 0x040019CE RID: 6606
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40019CE")]
	public int selfType;

	// Token: 0x040019CF RID: 6607
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40019CF")]
	public PlantType targetType;

	// Token: 0x040019D0 RID: 6608
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40019D0")]
	public bool disabled;

	// Token: 0x040019D1 RID: 6609
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40019D1")]
	public PlantType mix1;

	// Token: 0x040019D2 RID: 6610
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x40019D2")]
	public PlantType mix2;

	// Token: 0x040019D3 RID: 6611
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40019D3")]
	[Header("引用")]
	public Transform sceneHead;

	// Token: 0x040019D4 RID: 6612
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40019D4")]
	public Image plantIcon;

	// Token: 0x040019D5 RID: 6613
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40019D5")]
	public GameObject trophy;

	// Token: 0x040019D6 RID: 6614
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40019D6")]
	public TextMeshProUGUI nameText;
}
