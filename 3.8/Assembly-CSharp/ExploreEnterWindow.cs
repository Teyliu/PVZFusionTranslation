using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000834 RID: 2100
[Token(Token = "0x2000834")]
public class ExploreEnterWindow : UIButton
{
	// Token: 0x06002AB8 RID: 10936 RVA: 0x000E9E80 File Offset: 0x000E8080
	[Token(Token = "0x6002AB8")]
	[Address(RVA = "0x6546E0", Offset = "0x652CE0", VA = "0x1806546E0")]
	private void Awake()
	{
		this.basicPlant = true;
	}

	// Token: 0x06002AB9 RID: 10937 RVA: 0x000E9E94 File Offset: 0x000E8094
	[Token(Token = "0x6002AB9")]
	[Address(RVA = "0x654D00", Offset = "0x653300", VA = "0x180654D00", Slot = "4")]
	protected override void Start()
	{
		base.Start();
	}

	// Token: 0x06002ABA RID: 10938 RVA: 0x000E9EA8 File Offset: 0x000E80A8
	[Token(Token = "0x6002ABA")]
	[Address(RVA = "0x654770", Offset = "0x652D70", VA = "0x180654770")]
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

	// Token: 0x06002ABB RID: 10939 RVA: 0x000E9F14 File Offset: 0x000E8114
	[Token(Token = "0x6002ABB")]
	[Address(RVA = "0x654C00", Offset = "0x653200", VA = "0x180654C00")]
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

	// Token: 0x06002ABC RID: 10940 RVA: 0x000E9F60 File Offset: 0x000E8160
	[Token(Token = "0x6002ABC")]
	[Address(RVA = "0x654900", Offset = "0x652F00", VA = "0x180654900")]
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

	// Token: 0x06002ABD RID: 10941 RVA: 0x000EA00C File Offset: 0x000E820C
	[Token(Token = "0x6002ABD")]
	[Address(RVA = "0x6546F0", Offset = "0x652CF0", VA = "0x1806546F0")]
	private SceneType GetPlantScene(PlantType thePlantType)
	{
		bool flag;
		if (!flag)
		{
		}
		return SceneType.Roof;
	}

	// Token: 0x06002ABE RID: 10942 RVA: 0x000EA02C File Offset: 0x000E822C
	[Token(Token = "0x6002ABE")]
	[Address(RVA = "0x51C260", Offset = "0x51A860", VA = "0x18051C260")]
	public ExploreEnterWindow()
	{
	}

	// Token: 0x040018DF RID: 6367
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40018DF")]
	[Header("属性")]
	public bool basicPlant;

	// Token: 0x040018E0 RID: 6368
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40018E0")]
	public int selfType;

	// Token: 0x040018E1 RID: 6369
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40018E1")]
	public PlantType targetType;

	// Token: 0x040018E2 RID: 6370
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40018E2")]
	public bool disabled;

	// Token: 0x040018E3 RID: 6371
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40018E3")]
	public PlantType mix1;

	// Token: 0x040018E4 RID: 6372
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x40018E4")]
	public PlantType mix2;

	// Token: 0x040018E5 RID: 6373
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40018E5")]
	[Header("引用")]
	public Transform sceneHead;

	// Token: 0x040018E6 RID: 6374
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40018E6")]
	public Image plantIcon;

	// Token: 0x040018E7 RID: 6375
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40018E7")]
	public GameObject trophy;

	// Token: 0x040018E8 RID: 6376
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40018E8")]
	public TextMeshProUGUI nameText;
}
