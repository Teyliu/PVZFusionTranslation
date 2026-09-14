using System;
using System.Collections.Generic;
using System.IO;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000836 RID: 2102
[Token(Token = "0x2000836")]
public class ExploreMakeMenu : BaseMenu
{
	// Token: 0x06002AC6 RID: 10950 RVA: 0x000EA4BC File Offset: 0x000E86BC
	[Token(Token = "0x6002AC6")]
	[Address(RVA = "0x656210", Offset = "0x654810", VA = "0x180656210", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		ExploreMakeMenu.Instance = this;
		this.selectedPlantType = (PlantType)((ulong)4294967295L);
	}

	// Token: 0x06002AC7 RID: 10951 RVA: 0x000EA4E8 File Offset: 0x000E86E8
	[Token(Token = "0x6002AC7")]
	[Address(RVA = "0x656AD0", Offset = "0x6550D0", VA = "0x180656AD0")]
	public void InitMenu()
	{
		ulong num;
		do
		{
			string name = global::Lawnf.GetName(this.thePlantType);
			List<TextMeshProUGUI> list = this.titleName;
			bool flag;
			if (flag)
			{
				string text = "关卡制作中：" + name;
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06002AC8 RID: 10952 RVA: 0x000EA534 File Offset: 0x000E8734
	[Token(Token = "0x6002AC8")]
	[Address(RVA = "0x656790", Offset = "0x654D90", VA = "0x180656790")]
	private void InitCards()
	{
		ulong num;
		do
		{
			GameObject gameObject = Resources.Load<GameObject>("UI/Cards/Prefab/TheCard");
			Dictionary<PlantType, GameObject> plantPrefabs = GameAPP.resourcesManager.plantPrefabs;
			bool flag;
			if (flag)
			{
				Transform transform = this.plantViewContent.transform;
				global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).GetComponent<ExploreMakeCard>().menu = this;
			}
		}
		while (num != (ulong)0L);
		int num2 = GameAPP.resourcesManager.plantPrefabs.Count;
		num2++;
		long num3 = (long)(num2 * (int)((uint)140));
	}

	// Token: 0x06002AC9 RID: 10953 RVA: 0x000EA5C4 File Offset: 0x000E87C4
	[Token(Token = "0x6002AC9")]
	[Address(RVA = "0x656C60", Offset = "0x655260", VA = "0x180656C60")]
	private void InitZombieButtons()
	{
		GameObject gameObject;
		ulong num2;
		do
		{
			Transform transform = this.zombieViewContent.transform;
			int num = 0;
			gameObject = transform.GetChild(num).gameObject;
			Dictionary<ZombieType, GameObject> zombiePrefabs = GameAPP.resourcesManager.zombiePrefabs;
			bool flag;
			if (flag)
			{
				Transform transform2 = this.zombieViewContent.transform;
				ExploreMakeZombieButton component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform2).GetComponent<ExploreMakeZombieButton>();
			}
		}
		while (num2 != (ulong)0L);
		global::UnityEngine.Object.Destroy(gameObject);
		int num3 = GameAPP.resourcesManager.zombiePrefabs.Count;
		num3++;
	}

	// Token: 0x06002ACA RID: 10954 RVA: 0x000EA660 File Offset: 0x000E8860
	[Token(Token = "0x6002ACA")]
	[Address(RVA = "0x657F80", Offset = "0x656580", VA = "0x180657F80")]
	private void Start()
	{
		this.InitCards();
		this.InitZombieButtons();
		LevelData levelData = new LevelData();
		PlantType plantType = this.thePlantType;
		levelData.level = plantType;
		this.levelData = levelData;
		int num = (int)this.thePlantType;
		LevelData levelData2;
		this.originalData = levelData2;
		LevelData levelData3 = this.originalData;
		LevelData levelData4 = this.levelData;
		SceneType sceneType = levelData3.sceneType;
		levelData4.sceneType = sceneType;
	}

	// Token: 0x06002ACB RID: 10955 RVA: 0x000EA6CC File Offset: 0x000E88CC
	[Token(Token = "0x6002ACB")]
	[Address(RVA = "0x658160", Offset = "0x656760", VA = "0x180658160")]
	public void ViewPlant()
	{
		GameObject gameObject = this.currentView;
		int num = 0;
		gameObject.SetActive(num != 0);
		GameObject gameObject2 = this.plantView;
		this.currentView = gameObject2;
		this.currentView.SetActive(true);
	}

	// Token: 0x06002ACC RID: 10956 RVA: 0x000EA70C File Offset: 0x000E890C
	[Token(Token = "0x6002ACC")]
	[Address(RVA = "0x6581C0", Offset = "0x6567C0", VA = "0x1806581C0")]
	public void ViewScene()
	{
		GameObject gameObject = this.currentView;
		int num = 0;
		gameObject.SetActive(num != 0);
		GameObject gameObject2 = this.sceneView;
		this.currentView = gameObject2;
		this.currentView.SetActive(true);
	}

	// Token: 0x06002ACD RID: 10957 RVA: 0x000EA74C File Offset: 0x000E894C
	[Token(Token = "0x6002ACD")]
	[Address(RVA = "0x658100", Offset = "0x656700", VA = "0x180658100")]
	public void ViewLevel()
	{
		GameObject gameObject = this.currentView;
		int num = 0;
		gameObject.SetActive(num != 0);
		GameObject gameObject2 = this.levelView;
		this.currentView = gameObject2;
		this.currentView.SetActive(true);
	}

	// Token: 0x06002ACE RID: 10958 RVA: 0x000EA78C File Offset: 0x000E898C
	[Token(Token = "0x6002ACE")]
	[Address(RVA = "0x658220", Offset = "0x656820", VA = "0x180658220")]
	public void ViewZombie()
	{
		GameObject gameObject = this.currentView;
		int num = 0;
		gameObject.SetActive(num != 0);
		GameObject gameObject2 = this.zombieView;
		this.currentView = gameObject2;
		this.currentView.SetActive(true);
	}

	// Token: 0x06002ACF RID: 10959 RVA: 0x000EA7CC File Offset: 0x000E89CC
	[Token(Token = "0x6002ACF")]
	[Address(RVA = "0x656370", Offset = "0x654970", VA = "0x180656370")]
	public void DeleteLevel()
	{
		string dataPath = SaveInfo.GetDataPath();
		PlantType plantType = this.thePlantType;
		string text = string.Format("LevelData/Explore/{0}.json", dataPath);
		string text2 = Path.Combine(dataPath, text);
		if (File.Exists(text2))
		{
			File.Delete(text2);
			ExploreDataManager.LoadData();
			InGameText instance = InGameText.Instance;
			int num = 0;
			instance.ShowText("已删除制作的关卡", 3f, num != 0);
		}
	}

	// Token: 0x06002AD0 RID: 10960 RVA: 0x000EA83C File Offset: 0x000E8A3C
	[Token(Token = "0x6002AD0")]
	[Address(RVA = "0x656280", Offset = "0x654880", VA = "0x180656280")]
	public void ClearRecord()
	{
		InGameText instance = InGameText.Instance;
		int num = 0;
		instance.ShowText("已删除通关记录", 3f, num != 0);
		HashSet<int> exploreLevelCompleted = GameAPP.exploreLevelCompleted;
		SaveInfo.Instance.SavePlayerData();
	}

	// Token: 0x06002AD1 RID: 10961 RVA: 0x000EA87C File Offset: 0x000E8A7C
	[Token(Token = "0x6002AD1")]
	[Address(RVA = "0x658070", Offset = "0x656670", VA = "0x180658070")]
	public void TextLevel()
	{
		this.SaveData(true);
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002AD2 RID: 10962 RVA: 0x000EA898 File Offset: 0x000E8A98
	[Token(Token = "0x6002AD2")]
	[Address(RVA = "0x6564A0", Offset = "0x654AA0", VA = "0x1806564A0")]
	public void EnterAlmanacToSelectPlant()
	{
		UIMgr.EnterAlmanac();
	}

	// Token: 0x06002AD3 RID: 10963 RVA: 0x000EA8AC File Offset: 0x000E8AAC
	[Token(Token = "0x6002AD3")]
	[Address(RVA = "0x6576A0", Offset = "0x655CA0", VA = "0x1806576A0")]
	public void SaveData(bool test)
	{
		int num3;
		do
		{
			this.GetLevelSetting();
			List<PlantType> usePlant = this.levelData.usePlant;
			int num = 0;
			usePlant._size = num;
			List<RectTransform> list = this.selectPlantHeads;
			bool flag;
			if (flag)
			{
				int num2;
				while (num2 == 0)
				{
				}
				Transform transform;
				ExploreMakeCard component = transform.GetComponent<ExploreMakeCard>();
				List<PlantType> usePlant2 = this.levelData.usePlant;
			}
			if (num != 0)
			{
				goto IL_013F;
			}
			num3 = 0;
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num3 != 0);
		int num4 = 0;
		ExploreMakeZombieButton[] array;
		if (num4 < array.Length)
		{
			ExploreMakeZombieButton exploreMakeZombieButton = array[9];
			TextMeshProUGUI sceneText = array[20].sceneText;
			num4++;
			num4++;
		}
		string dataPath = SaveInfo.GetDataPath();
		PlantType plantType;
		string text = string.Format("LevelData/Explore/{0}.json", plantType);
		string text2 = Path.Combine(dataPath, text);
		string directoryName = Path.GetDirectoryName(text2);
		DirectoryInfo directoryInfo = Directory.CreateDirectory(directoryName);
		ulong num5;
		string text3 = JsonUtility.ToJson(directoryName, num5 != 0UL);
		File.WriteAllText(text2, text3);
		InGameText instance = InGameText.Instance;
		string text4 = "成功保存文件到:" + text2;
		int num6 = 0;
		instance.ShowText(text4, 6f, num6 != 0);
		ExploreDataManager.LoadData();
		return;
		IL_013F:
		throw new NullReferenceException();
	}

	// Token: 0x06002AD4 RID: 10964 RVA: 0x000EAA0C File Offset: 0x000E8C0C
	[Token(Token = "0x6002AD4")]
	[Address(RVA = "0x6564B0", Offset = "0x654AB0", VA = "0x1806564B0")]
	private void GetLevelSetting()
	{
		TMP_InputField tmp_InputField = this.setSun;
		LevelData levelData = this.levelData;
		string text = tmp_InputField.m_Text;
		bool flag;
		if (!flag)
		{
			this.levelData.theSun = (int)((ulong)500L);
		}
		TMP_InputField tmp_InputField2 = this.setWave;
		LevelData levelData2 = this.levelData;
		string text2 = tmp_InputField2.m_Text;
		bool flag2;
		if (!flag2)
		{
			this.levelData.maxWave = (int)((ulong)20L);
		}
		TMP_InputField tmp_InputField3 = this.setZombieHealth;
		LevelData levelData3 = this.levelData;
		string text3 = tmp_InputField3.m_Text;
		bool flag3;
		if (!flag3)
		{
			this.levelData.zombieHealthMultiplier = 1f;
		}
		TMP_InputField tmp_InputField4 = this.setZombieSpeed;
		LevelData levelData4 = this.levelData;
		string text4 = tmp_InputField4.m_Text;
		bool flag4;
		if (!flag4)
		{
			this.levelData.zombieSpeedAdder = 1f;
		}
		TMP_InputField tmp_InputField5 = this.setGloveCD;
		LevelData levelData5 = this.levelData;
		string text5 = tmp_InputField5.m_Text;
		bool flag5;
		if (!flag5)
		{
			this.levelData.gloveCD = 10f;
		}
		TMP_InputField tmp_InputField6 = this.setConveyTime;
		LevelData levelData6 = this.levelData;
		string text6 = tmp_InputField6.m_Text;
		bool flag6;
		if (!flag6)
		{
			this.levelData.convayTimer = 7.5f;
		}
		TMP_InputField tmp_InputField7 = this.setFirstWaveTime;
		LevelData levelData7 = this.levelData;
		string text7 = tmp_InputField7.m_Text;
		bool flag7;
		if (!flag7)
		{
			this.levelData.firstWaveCountdown = 15f;
		}
		TMP_InputField tmp_InputField8 = this.setWaveInterval;
		LevelData levelData8 = this.levelData;
		string text8 = tmp_InputField8.m_Text;
		bool flag8;
		if (!flag8)
		{
			this.levelData.nextWaveInterval = 30f;
		}
		TMP_InputField tmp_InputField9 = this.setTip;
		LevelData levelData9 = this.levelData;
		string text9 = tmp_InputField9.m_Text;
		levelData9.tips = text9;
		Toggle toggle = this.setConvey;
		LevelData levelData10 = this.levelData;
		bool isOn = toggle.m_IsOn;
		levelData10.convay = isOn;
		LevelData levelData11 = this.levelData;
		this.SetUIText(levelData11);
	}

	// Token: 0x06002AD5 RID: 10965 RVA: 0x000EABE0 File Offset: 0x000E8DE0
	[Token(Token = "0x6002AD5")]
	[Address(RVA = "0x657CA0", Offset = "0x6562A0", VA = "0x180657CA0")]
	private void SetUIText(LevelData data)
	{
		TMP_InputField tmp_InputField = this.setSun;
		int theSun = data.theSun;
		string text = string.Format("{0}", theSun);
		tmp_InputField.text = text;
		int maxWave = data.maxWave;
		TMP_InputField tmp_InputField2 = this.setWave;
		string text2 = string.Format("{0}", maxWave);
		tmp_InputField2.text = text2;
		float zombieHealthMultiplier = data.zombieHealthMultiplier;
		TMP_InputField tmp_InputField3 = this.setZombieHealth;
		string text3 = string.Format("{0}", text2);
		tmp_InputField3.text = text3;
		float zombieSpeedAdder = data.zombieSpeedAdder;
		TMP_InputField tmp_InputField4 = this.setZombieSpeed;
		string text4 = string.Format("{0}", text3);
		tmp_InputField4.text = text4;
		float gloveCD = data.gloveCD;
		TMP_InputField tmp_InputField5 = this.setGloveCD;
		string text5 = string.Format("{0}", text4);
		tmp_InputField5.text = text5;
		float convayTimer = data.convayTimer;
		TMP_InputField tmp_InputField6 = this.setConveyTime;
		string text6 = string.Format("{0}", text5);
		tmp_InputField6.text = text6;
		float firstWaveCountdown = data.firstWaveCountdown;
		TMP_InputField tmp_InputField7 = this.setFirstWaveTime;
		string text7 = string.Format("{0}", text6);
		tmp_InputField7.text = text7;
		float nextWaveInterval = data.nextWaveInterval;
		TMP_InputField tmp_InputField8 = this.setWaveInterval;
		string text8 = string.Format("{0}", text7);
		tmp_InputField8.text = text8;
		Toggle toggle = this.setConvey;
		bool convay = data.convay;
		toggle.isOn = convay;
		TMP_InputField tmp_InputField9 = this.setTip;
		string tips = data.tips;
		tmp_InputField9.text = tips;
	}

	// Token: 0x06002AD6 RID: 10966 RVA: 0x000EAD58 File Offset: 0x000E8F58
	[Token(Token = "0x6002AD6")]
	[Address(RVA = "0x656F90", Offset = "0x655590", VA = "0x180656F90")]
	private void OriginalSettings()
	{
		for (;;)
		{
			int num = 0;
			int num2 = (int)this.thePlantType;
			LevelData levelData;
			this.originalData = levelData;
			LevelData levelData2 = this.originalData;
			this.SetUIText(levelData2);
			List<PrePlantData> prePlant = this.originalData.prePlant;
			int num3 = 0;
			bool flag;
			if (flag)
			{
				List<ExploreGrid> list = this.exploreGrids;
				bool flag2;
				if (flag2)
				{
				}
				if (num3 != 0)
				{
					goto IL_0101;
				}
			}
			if (num3 == 0)
			{
				int num4 = 0;
				GameObject gameObject = Resources.Load<GameObject>("UI/Cards/Prefab/TheCard");
				RectTransform rectTransform;
				Transform transform = rectTransform.transform;
				ExploreMakeCard component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).GetComponent<ExploreMakeCard>();
				Transform transform2 = component.transform;
				PlantType plantType;
				component.thePlantType = plantType;
				component.menu = 0;
				component.selected = true;
				num4++;
				int num5 = 0;
				Transform transform3;
				Transform child = transform3.GetChild(num5);
				GameObject gameObject2 = child.gameObject;
				bool flag3;
				if (flag3)
				{
					Transform transform4;
					ExploreMakeZombieButton component2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject2, transform4).GetComponent<ExploreMakeZombieButton>();
					component2.theZombieType = (ZombieType)num;
					component2.selected = true;
				}
				if (num4 == 0)
				{
					break;
				}
			}
		}
		int num6;
		num6++;
		return;
		IL_0101:
		throw new NullReferenceException();
	}

	// Token: 0x06002AD7 RID: 10967 RVA: 0x000EAE6C File Offset: 0x000E906C
	[Token(Token = "0x6002AD7")]
	[Address(RVA = "0x6580B0", Offset = "0x6566B0", VA = "0x1806580B0")]
	public void UpdateContentSize()
	{
		RectTransform rectTransform = this.selectedZombieContent;
		int num = 0;
		int num2 = rectTransform.childCount;
		num2++;
		rectTransform.sizeDelta = num;
	}

	// Token: 0x06002AD8 RID: 10968 RVA: 0x000EAE9C File Offset: 0x000E909C
	[Token(Token = "0x6002AD8")]
	[Address(RVA = "0x658280", Offset = "0x656880", VA = "0x180658280")]
	public ExploreMakeMenu()
	{
		List<TextMeshProUGUI> list = new List();
		this.titleName = list;
		List<RectTransform> list2 = new List();
		this.selectPlantHeads = list2;
		List<ExploreGrid> list3 = new List();
		this.exploreGrids = list3;
		base..ctor();
	}

	// Token: 0x040018ED RID: 6381
	[Token(Token = "0x40018ED")]
	public static ExploreMakeMenu Instance;

	// Token: 0x040018EE RID: 6382
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40018EE")]
	public PlantType from1;

	// Token: 0x040018EF RID: 6383
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40018EF")]
	public PlantType from2;

	// Token: 0x040018F0 RID: 6384
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40018F0")]
	public PlantType thePlantType;

	// Token: 0x040018F1 RID: 6385
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40018F1")]
	public List<TextMeshProUGUI> titleName;

	// Token: 0x040018F2 RID: 6386
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40018F2")]
	public RectTransform plantViewContent;

	// Token: 0x040018F3 RID: 6387
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40018F3")]
	[Header("预选植物")]
	public GameObject plantView;

	// Token: 0x040018F4 RID: 6388
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40018F4")]
	public List<RectTransform> selectPlantHeads;

	// Token: 0x040018F5 RID: 6389
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40018F5")]
	[Header("场景设置")]
	public PlantType selectedPlantType;

	// Token: 0x040018F6 RID: 6390
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40018F6")]
	public GameObject sceneView;

	// Token: 0x040018F7 RID: 6391
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40018F7")]
	public List<ExploreGrid> exploreGrids;

	// Token: 0x040018F8 RID: 6392
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40018F8")]
	public ExploreMakeSceneButton currentSelectScene;

	// Token: 0x040018F9 RID: 6393
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40018F9")]
	[Header("关卡设置")]
	public GameObject levelView;

	// Token: 0x040018FA RID: 6394
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40018FA")]
	public TMP_InputField setSun;

	// Token: 0x040018FB RID: 6395
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40018FB")]
	public TMP_InputField setWave;

	// Token: 0x040018FC RID: 6396
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40018FC")]
	public TMP_InputField setZombieHealth;

	// Token: 0x040018FD RID: 6397
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40018FD")]
	public TMP_InputField setZombieSpeed;

	// Token: 0x040018FE RID: 6398
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40018FE")]
	public TMP_InputField setGloveCD;

	// Token: 0x040018FF RID: 6399
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40018FF")]
	public TMP_InputField setConveyTime;

	// Token: 0x04001900 RID: 6400
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4001900")]
	public TMP_InputField setFirstWaveTime;

	// Token: 0x04001901 RID: 6401
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4001901")]
	public TMP_InputField setWaveInterval;

	// Token: 0x04001902 RID: 6402
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4001902")]
	public TMP_InputField setTip;

	// Token: 0x04001903 RID: 6403
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4001903")]
	public Toggle setConvey;

	// Token: 0x04001904 RID: 6404
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4001904")]
	[Header("出怪设置")]
	public GameObject zombieView;

	// Token: 0x04001905 RID: 6405
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4001905")]
	public RectTransform zombieViewContent;

	// Token: 0x04001906 RID: 6406
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4001906")]
	public RectTransform selectedZombieContent;

	// Token: 0x04001907 RID: 6407
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4001907")]
	public LevelData levelData;

	// Token: 0x04001908 RID: 6408
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4001908")]
	public LevelData originalData;

	// Token: 0x04001909 RID: 6409
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4001909")]
	private GameObject currentView;
}
