using System;
using System.Collections.Generic;
using AlmanacData;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

// Token: 0x0200080E RID: 2062
[Token(Token = "0x200080E")]
public class AlmanacZombieWindow : MonoBehaviour
{
	// Token: 0x060029FA RID: 10746 RVA: 0x000E28D0 File Offset: 0x000E0AD0
	[Token(Token = "0x60029FA")]
	[Address(RVA = "0x68D920", Offset = "0x68BF20", VA = "0x18068D920")]
	public void InitWindow(ZombieType theZombieType)
	{
		this.currentZombieType = theZombieType;
		this.SetZombie(theZombieType);
		if (theZombieType > ZombieType.DrownGargantuar)
		{
			if (theZombieType != ZombieType.SuperSubmarine)
			{
			}
			Image image = this.background;
			Sprite sprite = this.poolBackground;
			image.sprite = sprite;
			return;
		}
		while (theZombieType == ZombieType.SubmarineZombie)
		{
		}
		while (theZombieType == ZombieType.DrownGargantuar)
		{
		}
		Image image2 = this.background;
		Sprite sprite2 = this.landBackground;
		image2.sprite = sprite2;
	}

	// Token: 0x060029FB RID: 10747 RVA: 0x000E2938 File Offset: 0x000E0B38
	[Token(Token = "0x60029FB")]
	[Address(RVA = "0x68DF90", Offset = "0x68C590", VA = "0x18068DF90")]
	private void UpdateText(ZombieType theZombieType)
	{
		ulong num2;
		do
		{
			ZombieInfo zombieInfo;
			if (zombieInfo != 0)
			{
				TextMeshProUGUI textMeshProUGUI = this.showedZombieIntroduce;
				string info = zombieInfo.info;
				textMeshProUGUI.text = info;
				TextMeshProUGUI textMeshProUGUI2 = this.showedZombieIntroduce;
				string text = textMeshProUGUI2.text + "\n\n";
				textMeshProUGUI2.text = text;
				TextMeshProUGUI textMeshProUGUI3 = this.showedZombieIntroduce;
				string text2 = textMeshProUGUI3.text;
				Dictionary<ZombieType, ZombieDataManager.ZombieData> zombieDataDic = ZombieDataManager.zombieDataDic;
				ZombieDataManager.ZombieData zombieData;
				int summonLevel = zombieData.summonLevel;
				string text3 = string.Format("<color=#3D1400>出怪等级：</color><color=red>{0}</color>\n", summonLevel);
				string text4 = text2 + text3;
				textMeshProUGUI3.text = text4;
				TextMeshProUGUI textMeshProUGUI4 = this.showedZombieIntroduce;
				string text5 = textMeshProUGUI4.text;
				Dictionary<ZombieType, ZombieDataManager.ZombieData> zombieDataDic2 = ZombieDataManager.zombieDataDic;
				ZombieDataManager.ZombieData zombieData2;
				int summonWeight = zombieData2.summonWeight;
				string text6 = string.Format("<color=#3D1400>出怪权重：</color><color=red>{0}</color>", summonWeight);
				string text7 = text5 + text6;
				textMeshProUGUI4.text = text7;
				TextMeshProUGUI textMeshProUGUI5 = this.showedZombieIntroduce;
				string text8 = textMeshProUGUI5.text + "\n\n";
				textMeshProUGUI5.text = text8;
				TextMeshProUGUI textMeshProUGUI6 = this.showedZombieIntroduce;
				string text9 = textMeshProUGUI6.text;
				string introduce = zombieInfo.introduce;
				string text10 = text9 + introduce;
				textMeshProUGUI6.text = text10;
				List<TextMeshProUGUI> list = this.showedZombieName;
				bool flag;
				if (flag)
				{
					string name = zombieInfo.name;
					ZombieType zombieType = this.currentZombieType;
					string text11 = string.Format("({0})", zombieType);
					string text12 = name + text11;
				}
				ulong num;
				if (num != (ulong)0L)
				{
					continue;
				}
			}
			this.showedZombieIntroduce.text = "";
			List<TextMeshProUGUI> list2 = this.showedZombieName;
			bool flag2;
			if (flag2)
			{
				ZombieType zombieType2 = this.currentZombieType;
				string text13 = string.Format("({0})", zombieType2);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060029FC RID: 10748 RVA: 0x000E2AF0 File Offset: 0x000E0CF0
	[Token(Token = "0x60029FC")]
	[Address(RVA = "0x68DB60", Offset = "0x68C160", VA = "0x18068DB60")]
	private void SetBackground(ZombieType theZombieType)
	{
		if (theZombieType > ZombieType.DrownGargantuar)
		{
			if (theZombieType != ZombieType.SuperSubmarine)
			{
			}
			Image image = this.background;
			Sprite sprite = this.poolBackground;
			image.sprite = sprite;
			return;
		}
		while (theZombieType == ZombieType.SubmarineZombie)
		{
		}
		while (theZombieType == ZombieType.DrownGargantuar)
		{
		}
		Image image2 = this.background;
		Sprite sprite2 = this.landBackground;
		image2.sprite = sprite2;
	}

	// Token: 0x060029FD RID: 10749 RVA: 0x000E2B48 File Offset: 0x000E0D48
	[Token(Token = "0x60029FD")]
	[Address(RVA = "0x68DBD0", Offset = "0x68C1D0", VA = "0x18068DBD0")]
	private void SetZombie(ZombieType theZombieType)
	{
		global::UnityEngine.Object.Destroy(this.showedZombie);
		Transform transform = this.showedZombieAxis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = new GameObject("zombie");
		Transform transform2 = gameObject.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		GameObject gameObject2;
		Transform transform3 = gameObject2.transform;
		Transform transform4 = gameObject.transform;
		transform3.parentInternal = transform4;
		gameObject.transform.parentInternal = transform;
		this.showedZombie = gameObject;
		SortingGroup sortingGroup = this.showedZombie.AddComponent<SortingGroup>();
		sortingGroup.sortingLayerName = "up1";
		sortingGroup.sortingOrder = 20001;
		this.PvPSetting();
	}

	// Token: 0x060029FE RID: 10750 RVA: 0x000E2BF0 File Offset: 0x000E0DF0
	[Token(Token = "0x60029FE")]
	[Address(RVA = "0x68D9C0", Offset = "0x68BFC0", VA = "0x18068D9C0")]
	private void PvPSetting()
	{
		GameObject gameObject = this.pvpButton;
		int num = 0;
		gameObject.SetActive(num != 0);
		Board instance = Board.Instance;
		int num2 = 0;
		if (instance != num2)
		{
			Board instance2 = Board.Instance;
			this.pvpButton.SetActive(true);
			List<ZombieType> bannedInPVPScaryPot_zombie = GameAPP.bannedInPVPScaryPot_zombie;
			ZombieType zombieType = this.currentZombieType;
			bool flag = bannedInPVPScaryPot_zombie.Contains(zombieType);
			TextMeshProUGUI textMeshProUGUI = this.buttonText;
			if (!flag)
			{
				throw new NullReferenceException();
			}
		}
	}

	// Token: 0x060029FF RID: 10751 RVA: 0x000E2C60 File Offset: 0x000E0E60
	[Token(Token = "0x60029FF")]
	[Address(RVA = "0x68DE00", Offset = "0x68C400", VA = "0x18068DE00")]
	public void UpdatePvPSetting()
	{
		List<ZombieType> bannedInPVPScaryPot_zombie = GameAPP.bannedInPVPScaryPot_zombie;
		ZombieType zombieType = this.currentZombieType;
		if (!bannedInPVPScaryPot_zombie.Contains(zombieType))
		{
			int size = GameAPP.bannedInPVPScaryPot_zombie._size;
			string playerName = GameAPP.playerName;
			this.PvPSetting();
			return;
		}
		List<ZombieType> bannedInPVPScaryPot_zombie2 = GameAPP.bannedInPVPScaryPot_zombie;
		ZombieType zombieType2 = this.currentZombieType;
		bool flag = bannedInPVPScaryPot_zombie2.Remove(zombieType2);
		this.PvPSetting();
	}

	// Token: 0x06002A00 RID: 10752 RVA: 0x000E2CD0 File Offset: 0x000E0ED0
	[Token(Token = "0x6002A00")]
	[Address(RVA = "0x68E5D0", Offset = "0x68CBD0", VA = "0x18068E5D0")]
	public AlmanacZombieWindow()
	{
		List<TextMeshProUGUI> list = new List();
		this.showedZombieName = list;
		base..ctor();
	}

	// Token: 0x040017F1 RID: 6129
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40017F1")]
	public AlmanacPlantMenu menu;

	// Token: 0x040017F2 RID: 6130
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40017F2")]
	public ZombieType currentZombieType;

	// Token: 0x040017F3 RID: 6131
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40017F3")]
	public GameObject showedZombie;

	// Token: 0x040017F4 RID: 6132
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40017F4")]
	public Scrollbar zombieTextScrollbar;

	// Token: 0x040017F5 RID: 6133
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40017F5")]
	public Transform showedZombieAxis;

	// Token: 0x040017F6 RID: 6134
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40017F6")]
	public RectTransform zombieTextContent;

	// Token: 0x040017F7 RID: 6135
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40017F7")]
	public TextMeshProUGUI showedZombieIntroduce;

	// Token: 0x040017F8 RID: 6136
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40017F8")]
	public List<TextMeshProUGUI> showedZombieName;

	// Token: 0x040017F9 RID: 6137
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40017F9")]
	[Header("背景设置")]
	public Image background;

	// Token: 0x040017FA RID: 6138
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40017FA")]
	public Sprite landBackground;

	// Token: 0x040017FB RID: 6139
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40017FB")]
	public Sprite poolBackground;

	// Token: 0x040017FC RID: 6140
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40017FC")]
	[Header("PVP砸罐子设置")]
	public GameObject pvpButton;

	// Token: 0x040017FD RID: 6141
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40017FD")]
	public TextMeshProUGUI buttonText;
}
