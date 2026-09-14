using System;
using System.Collections.Generic;
using System.IO;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000872 RID: 2162
[Token(Token = "0x2000872")]
public class ExploreMakeMenu : BaseMenu
{
	// Token: 0x06002BF8 RID: 11256 RVA: 0x000EF264 File Offset: 0x000ED464
	[Token(Token = "0x6002BF8")]
	[Address(RVA = "0x6BA030", Offset = "0x6B8630", VA = "0x1806BA030", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		ExploreMakeMenu.Instance = this;
		this.selectedPlantType = (PlantType)((ulong)4294967295L);
	}

	// Token: 0x06002BF9 RID: 11257 RVA: 0x000EF290 File Offset: 0x000ED490
	[Token(Token = "0x6002BF9")]
	[Address(RVA = "0x6BA900", Offset = "0x6B8F00", VA = "0x1806BA900")]
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

	// Token: 0x06002BFA RID: 11258 RVA: 0x000EF2DC File Offset: 0x000ED4DC
	[Token(Token = "0x6002BFA")]
	[Address(RVA = "0x6BA5C0", Offset = "0x6B8BC0", VA = "0x1806BA5C0")]
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

	// Token: 0x06002BFB RID: 11259 RVA: 0x000EF36C File Offset: 0x000ED56C
	[Token(Token = "0x6002BFB")]
	[Address(RVA = "0x6BAA90", Offset = "0x6B9090", VA = "0x1806BAA90")]
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

	// Token: 0x06002BFC RID: 11260 RVA: 0x000EF408 File Offset: 0x000ED608
	[Token(Token = "0x6002BFC")]
	[Address(RVA = "0x6BBDC0", Offset = "0x6BA3C0", VA = "0x1806BBDC0")]
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

	// Token: 0x06002BFD RID: 11261 RVA: 0x000EF474 File Offset: 0x000ED674
	[Token(Token = "0x6002BFD")]
	[Address(RVA = "0x6BBFA0", Offset = "0x6BA5A0", VA = "0x1806BBFA0")]
	public void ViewPlant()
	{
		GameObject gameObject = this.currentView;
		int num = 0;
		gameObject.SetActive(num != 0);
		GameObject gameObject2 = this.plantView;
		this.currentView = gameObject2;
		this.currentView.SetActive(true);
	}

	// Token: 0x06002BFE RID: 11262 RVA: 0x000EF4B4 File Offset: 0x000ED6B4
	[Token(Token = "0x6002BFE")]
	[Address(RVA = "0x6BC000", Offset = "0x6BA600", VA = "0x1806BC000")]
	public void ViewScene()
	{
		GameObject gameObject = this.currentView;
		int num = 0;
		gameObject.SetActive(num != 0);
		GameObject gameObject2 = this.sceneView;
		this.currentView = gameObject2;
		this.currentView.SetActive(true);
	}

	// Token: 0x06002BFF RID: 11263 RVA: 0x000EF4F4 File Offset: 0x000ED6F4
	[Token(Token = "0x6002BFF")]
	[Address(RVA = "0x6BBF40", Offset = "0x6BA540", VA = "0x1806BBF40")]
	public void ViewLevel()
	{
		GameObject gameObject = this.currentView;
		int num = 0;
		gameObject.SetActive(num != 0);
		GameObject gameObject2 = this.levelView;
		this.currentView = gameObject2;
		this.currentView.SetActive(true);
	}

	// Token: 0x06002C00 RID: 11264 RVA: 0x000EF534 File Offset: 0x000ED734
	[Token(Token = "0x6002C00")]
	[Address(RVA = "0x6BC060", Offset = "0x6BA660", VA = "0x1806BC060")]
	public void ViewZombie()
	{
		GameObject gameObject = this.currentView;
		int num = 0;
		gameObject.SetActive(num != 0);
		GameObject gameObject2 = this.zombieView;
		this.currentView = gameObject2;
		this.currentView.SetActive(true);
	}

	// Token: 0x06002C01 RID: 11265 RVA: 0x000EF574 File Offset: 0x000ED774
	[Token(Token = "0x6002C01")]
	[Address(RVA = "0x6BA190", Offset = "0x6B8790", VA = "0x1806BA190")]
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
		}
	}

	// Token: 0x06002C02 RID: 11266 RVA: 0x000EF5D0 File Offset: 0x000ED7D0
	[Token(Token = "0x6002C02")]
	[Address(RVA = "0x6BA0A0", Offset = "0x6B86A0", VA = "0x1806BA0A0")]
	public void ClearRecord()
	{
		InGameText instance = InGameText.Instance;
		HashSet<int> exploreLevelCompleted = GameAPP.exploreLevelCompleted;
		SaveInfo.Instance.SavePlayerData();
	}

	// Token: 0x06002C03 RID: 11267 RVA: 0x000EF5FC File Offset: 0x000ED7FC
	[Token(Token = "0x6002C03")]
	[Address(RVA = "0x6BBEB0", Offset = "0x6BA4B0", VA = "0x1806BBEB0")]
	public void TextLevel()
	{
		this.SaveData(true);
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002C04 RID: 11268 RVA: 0x000EF618 File Offset: 0x000ED818
	[Token(Token = "0x6002C04")]
	[Address(RVA = "0x6BA2D0", Offset = "0x6B88D0", VA = "0x1806BA2D0")]
	public void EnterAlmanacToSelectPlant()
	{
		UIMgr.EnterAlmanac();
	}

	// Token: 0x06002C05 RID: 11269 RVA: 0x000EF62C File Offset: 0x000ED82C
	[Token(Token = "0x6002C05")]
	[Address(RVA = "0x6BB4D0", Offset = "0x6B9AD0", VA = "0x1806BB4D0")]
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
				goto IL_012C;
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
		ExploreDataManager.LoadData();
		return;
		IL_012C:
		throw new NullReferenceException();
	}

	// Token: 0x06002C06 RID: 11270 RVA: 0x000EF778 File Offset: 0x000ED978
	[Token(Token = "0x6002C06")]
	[Address(RVA = "0x6BA2E0", Offset = "0x6B88E0", VA = "0x1806BA2E0")]
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

	// Token: 0x06002C07 RID: 11271 RVA: 0x000EF94C File Offset: 0x000EDB4C
	[Token(Token = "0x6002C07")]
	[Address(RVA = "0x6BBAE0", Offset = "0x6BA0E0", VA = "0x1806BBAE0")]
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

	// Token: 0x06002C08 RID: 11272 RVA: 0x000EFAC4 File Offset: 0x000EDCC4
	[Token(Token = "0x6002C08")]
	[Address(RVA = "0x6BADC0", Offset = "0x6B93C0", VA = "0x1806BADC0")]
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

	// Token: 0x06002C09 RID: 11273 RVA: 0x000EFBD8 File Offset: 0x000EDDD8
	[Token(Token = "0x6002C09")]
	[Address(RVA = "0x6BBEF0", Offset = "0x6BA4F0", VA = "0x1806BBEF0")]
	public void UpdateContentSize()
	{
		RectTransform rectTransform = this.selectedZombieContent;
		int num = 0;
		int num2 = rectTransform.childCount;
		num2++;
		rectTransform.sizeDelta = num;
	}

	// Token: 0x06002C0A RID: 11274 RVA: 0x000EFC08 File Offset: 0x000EDE08
	[Token(Token = "0x6002C0A")]
	[Address(RVA = "0x6BC0C0", Offset = "0x6BA6C0", VA = "0x1806BC0C0")]
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

	// Token: 0x040019DB RID: 6619
	[Token(Token = "0x40019DB")]
	public static ExploreMakeMenu Instance;

	// Token: 0x040019DC RID: 6620
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40019DC")]
	public PlantType from1;

	// Token: 0x040019DD RID: 6621
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40019DD")]
	public PlantType from2;

	// Token: 0x040019DE RID: 6622
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40019DE")]
	public PlantType thePlantType;

	// Token: 0x040019DF RID: 6623
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40019DF")]
	public List<TextMeshProUGUI> titleName;

	// Token: 0x040019E0 RID: 6624
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40019E0")]
	public RectTransform plantViewContent;

	// Token: 0x040019E1 RID: 6625
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40019E1")]
	[Header("预选植物")]
	public GameObject plantView;

	// Token: 0x040019E2 RID: 6626
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40019E2")]
	public List<RectTransform> selectPlantHeads;

	// Token: 0x040019E3 RID: 6627
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40019E3")]
	[Header("场景设置")]
	public PlantType selectedPlantType;

	// Token: 0x040019E4 RID: 6628
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40019E4")]
	public GameObject sceneView;

	// Token: 0x040019E5 RID: 6629
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40019E5")]
	public List<ExploreGrid> exploreGrids;

	// Token: 0x040019E6 RID: 6630
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40019E6")]
	public ExploreMakeSceneButton currentSelectScene;

	// Token: 0x040019E7 RID: 6631
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40019E7")]
	[Header("关卡设置")]
	public GameObject levelView;

	// Token: 0x040019E8 RID: 6632
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40019E8")]
	public TMP_InputField setSun;

	// Token: 0x040019E9 RID: 6633
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40019E9")]
	public TMP_InputField setWave;

	// Token: 0x040019EA RID: 6634
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40019EA")]
	public TMP_InputField setZombieHealth;

	// Token: 0x040019EB RID: 6635
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40019EB")]
	public TMP_InputField setZombieSpeed;

	// Token: 0x040019EC RID: 6636
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40019EC")]
	public TMP_InputField setGloveCD;

	// Token: 0x040019ED RID: 6637
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40019ED")]
	public TMP_InputField setConveyTime;

	// Token: 0x040019EE RID: 6638
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40019EE")]
	public TMP_InputField setFirstWaveTime;

	// Token: 0x040019EF RID: 6639
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40019EF")]
	public TMP_InputField setWaveInterval;

	// Token: 0x040019F0 RID: 6640
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40019F0")]
	public TMP_InputField setTip;

	// Token: 0x040019F1 RID: 6641
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40019F1")]
	public Toggle setConvey;

	// Token: 0x040019F2 RID: 6642
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40019F2")]
	[Header("出怪设置")]
	public GameObject zombieView;

	// Token: 0x040019F3 RID: 6643
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40019F3")]
	public RectTransform zombieViewContent;

	// Token: 0x040019F4 RID: 6644
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40019F4")]
	public RectTransform selectedZombieContent;

	// Token: 0x040019F5 RID: 6645
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40019F5")]
	public LevelData levelData;

	// Token: 0x040019F6 RID: 6646
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40019F6")]
	public LevelData originalData;

	// Token: 0x040019F7 RID: 6647
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40019F7")]
	private GameObject currentView;
}
