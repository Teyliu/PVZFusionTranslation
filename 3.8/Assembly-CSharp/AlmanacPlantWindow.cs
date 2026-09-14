using System;
using System.Collections.Generic;
using AlmanacData;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

// Token: 0x020007D1 RID: 2001
[Token(Token = "0x20007D1")]
public class AlmanacPlantWindow : MonoBehaviour
{
	// Token: 0x060028AD RID: 10413 RVA: 0x000DCE9C File Offset: 0x000DB09C
	[Token(Token = "0x60028AD")]
	[Address(RVA = "0x627CB0", Offset = "0x6262B0", VA = "0x180627CB0")]
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

	// Token: 0x060028AE RID: 10414 RVA: 0x000DCEDC File Offset: 0x000DB0DC
	[Token(Token = "0x60028AE")]
	[Address(RVA = "0x628900", Offset = "0x626F00", VA = "0x180628900")]
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

	// Token: 0x060028AF RID: 10415 RVA: 0x000DD0B4 File Offset: 0x000DB2B4
	[Token(Token = "0x60028AF")]
	[Address(RVA = "0x628220", Offset = "0x626820", VA = "0x180628220")]
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

	// Token: 0x060028B0 RID: 10416 RVA: 0x000DD0F4 File Offset: 0x000DB2F4
	[Token(Token = "0x60028B0")]
	[Address(RVA = "0x628510", Offset = "0x626B10", VA = "0x180628510")]
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

	// Token: 0x060028B1 RID: 10417 RVA: 0x000DD180 File Offset: 0x000DB380
	[Token(Token = "0x60028B1")]
	[Address(RVA = "0x6282B0", Offset = "0x6268B0", VA = "0x1806282B0")]
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

	// Token: 0x060028B2 RID: 10418 RVA: 0x000DD230 File Offset: 0x000DB430
	[Token(Token = "0x60028B2")]
	[Address(RVA = "0x627D50", Offset = "0x626350", VA = "0x180627D50")]
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

	// Token: 0x060028B3 RID: 10419 RVA: 0x000DD2A8 File Offset: 0x000DB4A8
	[Token(Token = "0x60028B3")]
	[Address(RVA = "0x628050", Offset = "0x626650", VA = "0x180628050")]
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

	// Token: 0x060028B4 RID: 10420 RVA: 0x000DD344 File Offset: 0x000DB544
	[Token(Token = "0x60028B4")]
	[Address(RVA = "0x627EA0", Offset = "0x6264A0", VA = "0x180627EA0")]
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

	// Token: 0x060028B5 RID: 10421 RVA: 0x000DD3B4 File Offset: 0x000DB5B4
	[Token(Token = "0x60028B5")]
	[Address(RVA = "0x628770", Offset = "0x626D70", VA = "0x180628770")]
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

	// Token: 0x060028B6 RID: 10422 RVA: 0x000DD424 File Offset: 0x000DB624
	[Token(Token = "0x60028B6")]
	[Address(RVA = "0x629050", Offset = "0x627650", VA = "0x180629050")]
	public AlmanacPlantWindow()
	{
		List<TextMeshProUGUI> list = new List();
		this.showedPlantName = list;
		base..ctor();
	}

	// Token: 0x040016F7 RID: 5879
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40016F7")]
	public AlmanacPlantMenu menu;

	// Token: 0x040016F8 RID: 5880
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40016F8")]
	public PlantType currentPlantType;

	// Token: 0x040016F9 RID: 5881
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40016F9")]
	public GameObject skinButton;

	// Token: 0x040016FA RID: 5882
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40016FA")]
	public GameObject showedPlant;

	// Token: 0x040016FB RID: 5883
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40016FB")]
	public Scrollbar plantTextScrollbar;

	// Token: 0x040016FC RID: 5884
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40016FC")]
	public Transform showedPlantAxis;

	// Token: 0x040016FD RID: 5885
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40016FD")]
	public Transform showedPlantAxis2;

	// Token: 0x040016FE RID: 5886
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40016FE")]
	public RectTransform plantTextContent;

	// Token: 0x040016FF RID: 5887
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40016FF")]
	public TextMeshProUGUI showedPlantIntroduce;

	// Token: 0x04001700 RID: 5888
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001700")]
	public List<TextMeshProUGUI> showedPlantName;

	// Token: 0x04001701 RID: 5889
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001701")]
	[Header("背景设置")]
	public Image background;

	// Token: 0x04001702 RID: 5890
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001702")]
	public Sprite landBackground;

	// Token: 0x04001703 RID: 5891
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001703")]
	public Sprite poolBackground;

	// Token: 0x04001704 RID: 5892
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001704")]
	[Header("PVP砸罐子设置")]
	public GameObject pvpButton;

	// Token: 0x04001705 RID: 5893
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001705")]
	public TextMeshProUGUI buttonText;
}
