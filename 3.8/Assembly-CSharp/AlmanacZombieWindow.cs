using System;
using System.Collections.Generic;
using AlmanacData;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

// Token: 0x020007D5 RID: 2005
[Token(Token = "0x20007D5")]
public class AlmanacZombieWindow : MonoBehaviour
{
	// Token: 0x060028CB RID: 10443 RVA: 0x000DD8E0 File Offset: 0x000DBAE0
	[Token(Token = "0x60028CB")]
	[Address(RVA = "0x62A020", Offset = "0x628620", VA = "0x18062A020")]
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

	// Token: 0x060028CC RID: 10444 RVA: 0x000DD948 File Offset: 0x000DBB48
	[Token(Token = "0x60028CC")]
	[Address(RVA = "0x62A690", Offset = "0x628C90", VA = "0x18062A690")]
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

	// Token: 0x060028CD RID: 10445 RVA: 0x000DDB00 File Offset: 0x000DBD00
	[Token(Token = "0x60028CD")]
	[Address(RVA = "0x62A260", Offset = "0x628860", VA = "0x18062A260")]
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

	// Token: 0x060028CE RID: 10446 RVA: 0x000DDB58 File Offset: 0x000DBD58
	[Token(Token = "0x60028CE")]
	[Address(RVA = "0x62A2D0", Offset = "0x6288D0", VA = "0x18062A2D0")]
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

	// Token: 0x060028CF RID: 10447 RVA: 0x000DDC00 File Offset: 0x000DBE00
	[Token(Token = "0x60028CF")]
	[Address(RVA = "0x62A0C0", Offset = "0x6286C0", VA = "0x18062A0C0")]
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

	// Token: 0x060028D0 RID: 10448 RVA: 0x000DDC70 File Offset: 0x000DBE70
	[Token(Token = "0x60028D0")]
	[Address(RVA = "0x62A500", Offset = "0x628B00", VA = "0x18062A500")]
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

	// Token: 0x060028D1 RID: 10449 RVA: 0x000DDCE0 File Offset: 0x000DBEE0
	[Token(Token = "0x60028D1")]
	[Address(RVA = "0x62ACD0", Offset = "0x6292D0", VA = "0x18062ACD0")]
	public AlmanacZombieWindow()
	{
		List<TextMeshProUGUI> list = new List();
		this.showedZombieName = list;
		base..ctor();
	}

	// Token: 0x04001715 RID: 5909
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001715")]
	public AlmanacPlantMenu menu;

	// Token: 0x04001716 RID: 5910
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001716")]
	public ZombieType currentZombieType;

	// Token: 0x04001717 RID: 5911
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001717")]
	public GameObject showedZombie;

	// Token: 0x04001718 RID: 5912
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001718")]
	public Scrollbar zombieTextScrollbar;

	// Token: 0x04001719 RID: 5913
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001719")]
	public Transform showedZombieAxis;

	// Token: 0x0400171A RID: 5914
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400171A")]
	public RectTransform zombieTextContent;

	// Token: 0x0400171B RID: 5915
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400171B")]
	public TextMeshProUGUI showedZombieIntroduce;

	// Token: 0x0400171C RID: 5916
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400171C")]
	public List<TextMeshProUGUI> showedZombieName;

	// Token: 0x0400171D RID: 5917
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400171D")]
	[Header("背景设置")]
	public Image background;

	// Token: 0x0400171E RID: 5918
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400171E")]
	public Sprite landBackground;

	// Token: 0x0400171F RID: 5919
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400171F")]
	public Sprite poolBackground;

	// Token: 0x04001720 RID: 5920
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001720")]
	[Header("PVP砸罐子设置")]
	public GameObject pvpButton;

	// Token: 0x04001721 RID: 5921
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001721")]
	public TextMeshProUGUI buttonText;
}
