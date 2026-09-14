using System;
using System.Collections.Generic;
using AlmanacData;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

// Token: 0x0200080A RID: 2058
[Token(Token = "0x200080A")]
public class AlmanacPlantWindow : MonoBehaviour
{
	// Token: 0x060029DC RID: 10716 RVA: 0x000E1E8C File Offset: 0x000E008C
	[Token(Token = "0x60029DC")]
	[Address(RVA = "0x68B5B0", Offset = "0x689BB0", VA = "0x18068B5B0")]
	public void InitWindow(PlantType thePlantType)
	{
		this.currentPlantType = thePlantType;
		this.SetPlant(thePlantType);
		Image image = this.background;
		bool flag;
		if (!flag)
		{
		}
		Sprite sprite = this.poolBackground;
		image.sprite = sprite;
	}

	// Token: 0x060029DD RID: 10717 RVA: 0x000E1ECC File Offset: 0x000E00CC
	[Token(Token = "0x60029DD")]
	[Address(RVA = "0x68C200", Offset = "0x68A800", VA = "0x18068C200")]
	private void UpdateText(PlantType thePlantType)
	{
		ulong num3;
		do
		{
			PlantInfo plantInfo;
			if (plantInfo != 0)
			{
				TextMeshProUGUI textMeshProUGUI = this.showedPlantIntroduce;
				string info = plantInfo.info;
				string text = "<color=#0E276C>" + info + "</color>";
				textMeshProUGUI.text = text;
				TextMeshProUGUI textMeshProUGUI2 = this.showedPlantIntroduce;
				string text2 = textMeshProUGUI2.text + "\n\n";
				textMeshProUGUI2.text = text2;
				TextMeshProUGUI textMeshProUGUI3 = this.showedPlantIntroduce;
				string text3 = textMeshProUGUI3.text;
				string introduce = plantInfo.introduce;
				string text4 = text3 + introduce;
				textMeshProUGUI3.text = text4;
				TextMeshProUGUI textMeshProUGUI4 = this.showedPlantIntroduce;
				string text5 = textMeshProUGUI4.text;
				string cost = plantInfo.cost;
				string text6 = text5 + "\n\n" + cost;
				textMeshProUGUI4.text = text6;
				SynergyManager instance = SynergyManager.Instance;
				TextMeshProUGUI textMeshProUGUI5 = this.showedPlantIntroduce;
				string text7 = textMeshProUGUI5.text + "<color=red>旅行羁绊：";
				textMeshProUGUI5.text = text7;
				bool flag;
				if (flag)
				{
					TextMeshProUGUI textMeshProUGUI6 = this.showedPlantIntroduce;
					string text8 = textMeshProUGUI6.text;
					SynergyType synergyType;
					string text9 = string.Format("{0} ", synergyType);
					string text10 = text8 + text9;
					textMeshProUGUI6.text = text10;
				}
				ulong num;
				if (num != (ulong)0L)
				{
					goto IL_01BD;
				}
				List<TextMeshProUGUI> list = this.showedPlantName;
				bool flag2;
				if (flag2)
				{
					string name = plantInfo.name;
					PlantType plantType = this.currentPlantType;
					string text11 = string.Format("({0})", plantType);
					string text12 = name + text11;
				}
				ulong num2;
				if (num2 != (ulong)0L)
				{
					goto IL_01C3;
				}
			}
			this.showedPlantIntroduce.text = "";
			List<TextMeshProUGUI> list2 = this.showedPlantName;
			bool flag3;
			if (flag3)
			{
				PlantType plantType2 = this.currentPlantType;
				string text13 = string.Format("({0})", plantType2);
			}
		}
		while (num3 != (ulong)0L);
		return;
		IL_01BD:
		throw new NullReferenceException();
		IL_01C3:
		throw new NullReferenceException();
	}

	// Token: 0x060029DE RID: 10718 RVA: 0x000E20A4 File Offset: 0x000E02A4
	[Token(Token = "0x60029DE")]
	[Address(RVA = "0x68BB20", Offset = "0x68A120", VA = "0x18068BB20")]
	private void SetBackground(PlantType thePlantType)
	{
		Image image = this.background;
		bool flag;
		if (!flag)
		{
			Sprite sprite = this.landBackground;
			image.sprite = sprite;
			return;
		}
		Sprite sprite2 = this.poolBackground;
		image.sprite = sprite2;
	}

	// Token: 0x060029DF RID: 10719 RVA: 0x000E20E4 File Offset: 0x000E02E4
	[Token(Token = "0x60029DF")]
	[Address(RVA = "0x68BE10", Offset = "0x68A410", VA = "0x18068BE10")]
	private void SkinSetting(PlantType thePlantType)
	{
		int num = 0;
		Dictionary<PlantType, List<GameObject>> plantPrefabs = GameAPP.resourcesManager._plantPrefabs;
		bool flag;
		if (flag)
		{
			this.skinButton.SetActive(true);
			Type typeFromHandle = typeof(PlantType);
			string name = Enum.GetName(typeFromHandle, typeFromHandle);
			if (Enum.TryParse(typeof(SkinLevel), name, num))
			{
				HashSet<int> skinLevelCompleted = GameAPP.skinLevelCompleted;
				int num2 = num;
				if (!skinLevelCompleted.Contains(num2))
				{
					GameObject gameObject = this.skinButton;
					int num3 = 0;
					gameObject.SetActive(num3 != 0);
				}
			}
		}
	}

	// Token: 0x060029E0 RID: 10720 RVA: 0x000E2170 File Offset: 0x000E0370
	[Token(Token = "0x60029E0")]
	[Address(RVA = "0x68BBB0", Offset = "0x68A1B0", VA = "0x18068BBB0")]
	private void SetPlant(PlantType thePlantType)
	{
		global::UnityEngine.Object.Destroy(this.showedPlant);
		Transform transform = this.showedPlantAxis;
		bool flag;
		if (flag)
		{
		}
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = new GameObject("plant");
		Transform transform2 = gameObject.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		GameObject gameObject2;
		Transform transform3 = gameObject2.transform;
		Transform transform4 = gameObject.transform;
		transform3.parentInternal = transform4;
		gameObject.transform.parentInternal = transform;
		this.showedPlant = gameObject;
		SortingGroup sortingGroup = this.showedPlant.AddComponent<SortingGroup>();
		sortingGroup.sortingLayerName = "up1";
		sortingGroup.sortingOrder = 20001;
		this.PvPSetting();
	}

	// Token: 0x060029E1 RID: 10721 RVA: 0x000E2220 File Offset: 0x000E0420
	[Token(Token = "0x60029E1")]
	[Address(RVA = "0x68B650", Offset = "0x689C50", VA = "0x18068B650")]
	public void LeftSkin()
	{
		Dictionary<PlantType, int> plantSkinDic = GameAPP.resourcesManager.plantSkinDic;
		PlantType plantType = this.currentPlantType;
		ulong num;
		if (plantSkinDic.TryGetValue(plantType, num))
		{
			Dictionary<PlantType, int> plantSkinDic2 = GameAPP.resourcesManager.plantSkinDic;
			PlantType plantType2 = this.currentPlantType;
			plantSkinDic2[plantType2] = num;
			ResourcesManager resourcesManager = GameAPP.resourcesManager;
			PlantType plantType3 = this.currentPlantType;
			resourcesManager.SetSkin(plantType3, (int)num);
			PlantType plantType4 = this.currentPlantType;
			this.SetPlant(plantType4);
		}
	}

	// Token: 0x060029E2 RID: 10722 RVA: 0x000E2298 File Offset: 0x000E0498
	[Token(Token = "0x60029E2")]
	[Address(RVA = "0x68B950", Offset = "0x689F50", VA = "0x18068B950")]
	public void RightSkin()
	{
		Dictionary<PlantType, int> plantSkinDic = GameAPP.resourcesManager.plantSkinDic;
		PlantType plantType = this.currentPlantType;
		ulong num;
		if (plantSkinDic.TryGetValue(plantType, num))
		{
			num += (ulong)1L;
			Dictionary<PlantType, List<GameObject>> plantPrefabs = GameAPP.resourcesManager._plantPrefabs;
			PlantType plantType2 = this.currentPlantType;
			List<GameObject> list = plantPrefabs[plantType2];
			Dictionary<PlantType, int> plantSkinDic2 = GameAPP.resourcesManager.plantSkinDic;
			PlantType plantType3 = this.currentPlantType;
			plantSkinDic2[plantType3] = num;
			ResourcesManager resourcesManager = GameAPP.resourcesManager;
			PlantType plantType4 = this.currentPlantType;
			resourcesManager.SetSkin(plantType4, (int)num);
			PlantType plantType5 = this.currentPlantType;
			this.SetPlant(plantType5);
		}
	}

	// Token: 0x060029E3 RID: 10723 RVA: 0x000E2334 File Offset: 0x000E0534
	[Token(Token = "0x60029E3")]
	[Address(RVA = "0x68B7A0", Offset = "0x689DA0", VA = "0x18068B7A0")]
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
			List<PlantType> bannedInPVPScaryPot = GameAPP.bannedInPVPScaryPot;
			PlantType plantType = this.currentPlantType;
			bool flag = bannedInPVPScaryPot.Contains(plantType);
			TextMeshProUGUI textMeshProUGUI = this.buttonText;
			if (!flag)
			{
				throw new NullReferenceException();
			}
		}
	}

	// Token: 0x060029E4 RID: 10724 RVA: 0x000E23A4 File Offset: 0x000E05A4
	[Token(Token = "0x60029E4")]
	[Address(RVA = "0x68C070", Offset = "0x68A670", VA = "0x18068C070")]
	public void UpdatePvPSetting()
	{
		List<PlantType> bannedInPVPScaryPot = GameAPP.bannedInPVPScaryPot;
		PlantType plantType = this.currentPlantType;
		if (!bannedInPVPScaryPot.Contains(plantType))
		{
			int size = GameAPP.bannedInPVPScaryPot._size;
			string playerName = GameAPP.playerName;
			this.PvPSetting();
			return;
		}
		List<PlantType> bannedInPVPScaryPot2 = GameAPP.bannedInPVPScaryPot;
		PlantType plantType2 = this.currentPlantType;
		bool flag = bannedInPVPScaryPot2.Remove(plantType2);
		this.PvPSetting();
	}

	// Token: 0x060029E5 RID: 10725 RVA: 0x000E2414 File Offset: 0x000E0614
	[Token(Token = "0x60029E5")]
	[Address(RVA = "0x68C950", Offset = "0x68AF50", VA = "0x18068C950")]
	public AlmanacPlantWindow()
	{
		List<TextMeshProUGUI> list = new List();
		this.showedPlantName = list;
		base..ctor();
	}

	// Token: 0x040017D3 RID: 6099
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40017D3")]
	public AlmanacPlantMenu menu;

	// Token: 0x040017D4 RID: 6100
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40017D4")]
	public PlantType currentPlantType;

	// Token: 0x040017D5 RID: 6101
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40017D5")]
	public GameObject skinButton;

	// Token: 0x040017D6 RID: 6102
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40017D6")]
	public GameObject showedPlant;

	// Token: 0x040017D7 RID: 6103
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40017D7")]
	public Scrollbar plantTextScrollbar;

	// Token: 0x040017D8 RID: 6104
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40017D8")]
	public Transform showedPlantAxis;

	// Token: 0x040017D9 RID: 6105
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40017D9")]
	public Transform showedPlantAxis2;

	// Token: 0x040017DA RID: 6106
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40017DA")]
	public RectTransform plantTextContent;

	// Token: 0x040017DB RID: 6107
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40017DB")]
	public TextMeshProUGUI showedPlantIntroduce;

	// Token: 0x040017DC RID: 6108
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40017DC")]
	public List<TextMeshProUGUI> showedPlantName;

	// Token: 0x040017DD RID: 6109
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40017DD")]
	[Header("背景设置")]
	public Image background;

	// Token: 0x040017DE RID: 6110
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40017DE")]
	public Sprite landBackground;

	// Token: 0x040017DF RID: 6111
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40017DF")]
	public Sprite poolBackground;

	// Token: 0x040017E0 RID: 6112
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40017E0")]
	[Header("PVP砸罐子设置")]
	public GameObject pvpButton;

	// Token: 0x040017E1 RID: 6113
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40017E1")]
	public TextMeshProUGUI buttonText;
}
