using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;
using TMPro;
using UnityEngine;

// Token: 0x0200081C RID: 2076
[Token(Token = "0x200081C")]
public class CustomMenu : BaseMenu
{
	// Token: 0x170001EC RID: 492
	// (get) Token: 0x06002A53 RID: 10835 RVA: 0x000E4E50 File Offset: 0x000E3050
	[Token(Token = "0x170001EC")]
	public SerializedLevelData LevelData
	{
		[Token(Token = "0x6002A53")]
		[Address(RVA = "0x692BB0", Offset = "0x6911B0", VA = "0x180692BB0")]
		get
		{
			return CustomMenu._levelData;
		}
	}

	// Token: 0x06002A54 RID: 10836 RVA: 0x000E4E64 File Offset: 0x000E3064
	[Token(Token = "0x6002A54")]
	[Address(RVA = "0x692240", Offset = "0x690840", VA = "0x180692240")]
	public void LoadOriginalSettings()
	{
		ulong num;
		do
		{
			TMP_InputField tmp_InputField = this.waveInput;
			SerializedLevelData serializedLevelData = CustomMenu._levelData;
			string text;
			tmp_InputField.text = text;
			TMP_InputField tmp_InputField2 = this.sunInput;
			SerializedLevelData serializedLevelData2 = CustomMenu._levelData;
			string text2;
			tmp_InputField2.text = text2;
			TMP_InputField tmp_InputField3 = this.nameInput;
			string name = CustomMenu._levelData.name;
			tmp_InputField3.text = name;
			TMP_InputField tmp_InputField4 = this.levelNumberInput;
			SerializedLevelData serializedLevelData3 = CustomMenu._levelData;
			string text3;
			tmp_InputField4.text = text3;
			List<CustomMenu_page> list = this.pages;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06002A55 RID: 10837 RVA: 0x000E4EF4 File Offset: 0x000E30F4
	[Token(Token = "0x6002A55")]
	[Address(RVA = "0x691A30", Offset = "0x690030", VA = "0x180691A30")]
	public void EnterSettingLevel()
	{
		CustomLevelData customLevelData = CustomMenu._levelData.BuildLevel();
		ulong num;
		if (num == (ulong)0L)
		{
		}
		SceneType sceneType = customLevelData.SceneType;
		Action<Board> <CustomOnBoardStart>k__BackingField = customLevelData.<CustomOnBoardStart>k__BackingField;
		Action<Board> <CustomOnBoardAwake>k__BackingField = customLevelData.<CustomOnBoardAwake>k__BackingField;
		int num2 = 0;
		int num3 = 0;
		UIMgr.EnterGame((LevelType)((uint)11), num3, -1, num2);
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002A56 RID: 10838 RVA: 0x000E4F50 File Offset: 0x000E3150
	[Token(Token = "0x6002A56")]
	[Address(RVA = "0x6928D0", Offset = "0x690ED0", VA = "0x1806928D0")]
	public void SetSpawnZombie()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)57), canvasUp, num != 0);
		SerializedLevelData serializedLevelData = CustomMenu._levelData;
		throw new NullReferenceException();
	}

	// Token: 0x06002A57 RID: 10839 RVA: 0x000E4F88 File Offset: 0x000E3188
	[Token(Token = "0x6002A57")]
	[Address(RVA = "0x692A60", Offset = "0x691060", VA = "0x180692A60")]
	public void SetWave()
	{
		ulong num;
		if (int.TryParse(this.waveInput.m_Text, (int)num))
		{
			if (num < (ulong)10L)
			{
			}
			if (num > (ulong)100L)
			{
			}
			string text;
			this.waveInput.text = text;
			ulong num2;
			CustomMenu._levelData.maxWave = (int)num2;
		}
	}

	// Token: 0x06002A58 RID: 10840 RVA: 0x000E4FD8 File Offset: 0x000E31D8
	[Token(Token = "0x6002A58")]
	[Address(RVA = "0x6929E0", Offset = "0x690FE0", VA = "0x1806929E0")]
	public void SetSun()
	{
		ulong num;
		if (int.TryParse(this.sunInput.m_Text, (int)num))
		{
			CustomMenu._levelData.startSun = (int)num;
		}
	}

	// Token: 0x06002A59 RID: 10841 RVA: 0x000E500C File Offset: 0x000E320C
	[Token(Token = "0x6002A59")]
	[Address(RVA = "0x6924E0", Offset = "0x690AE0", VA = "0x1806924E0")]
	public void SetName()
	{
		SerializedLevelData serializedLevelData = CustomMenu._levelData;
		string text = this.nameInput.m_Text;
		serializedLevelData.name = text;
		throw new NullReferenceException();
	}

	// Token: 0x06002A5A RID: 10842 RVA: 0x000E5038 File Offset: 0x000E3238
	[Token(Token = "0x6002A5A")]
	[Address(RVA = "0x692550", Offset = "0x690B50", VA = "0x180692550")]
	public void SetNumber()
	{
		ulong num;
		if (!int.TryParse(this.levelNumberInput.m_Text, (int)num))
		{
			CustomMenu._levelData.levelNumber = (int)((ulong)1L);
			return;
		}
		uint num2;
		CustomMenu._levelData.levelNumber = (int)num2;
		string text;
		this.levelNumberInput.text = text;
	}

	// Token: 0x06002A5B RID: 10843 RVA: 0x000E5088 File Offset: 0x000E3288
	[Token(Token = "0x6002A5B")]
	[Address(RVA = "0x692650", Offset = "0x690C50", VA = "0x180692650")]
	public void SetScene(CustomButton_scene customButton_Scene)
	{
		SerializedLevelData serializedLevelData = CustomMenu._levelData;
		SceneType sceneType = customButton_Scene.sceneType;
		serializedLevelData.sceneType = sceneType;
		if (this.CurrentSceneContainer.childCount > 0)
		{
			RectTransform currentSceneContainer = this.CurrentSceneContainer;
			int num = 0;
			global::UnityEngine.Object.Destroy(currentSceneContainer.GetChild(num).gameObject);
		}
		Transform transform = this.CurrentSceneContainer.transform;
		CustomButton_scene customButton_scene = global::UnityEngine.Object.Instantiate<CustomButton_scene>(customButton_Scene, transform, true);
		Transform transform2 = customButton_scene.transform;
		Transform transform3 = customButton_scene.transform;
		Transform transform4 = customButton_scene.transform;
		global::UnityEngine.Object.Destroy(customButton_scene);
	}

	// Token: 0x06002A5C RID: 10844 RVA: 0x000E5118 File Offset: 0x000E3318
	[Token(Token = "0x6002A5C")]
	[Address(RVA = "0x691F50", Offset = "0x690550", VA = "0x180691F50")]
	private void InitScene()
	{
		uint num;
		ulong num2;
		do
		{
			Dictionary<SceneType, string> sceneName = MapData_cs.SceneName;
			bool flag;
			if (flag)
			{
				while (!flag)
				{
				}
				CustomButton_scene firstSceneButton = this.FirstSceneButton;
				Transform parent = firstSceneButton.transform.parent;
				CustomButton_scene customButton_scene = global::UnityEngine.Object.Instantiate<CustomButton_scene>(firstSceneButton, parent);
				customButton_scene.sceneType = firstSceneButton;
				TextMeshProUGUI sceneText = customButton_scene.sceneText;
				this.SetScene(customButton_scene);
				num += (uint)1;
			}
		}
		while (num2 != (ulong)0L);
		long num3 = (long)(num * (uint)200);
	}

	// Token: 0x06002A5D RID: 10845 RVA: 0x000E51B0 File Offset: 0x000E33B0
	[Token(Token = "0x6002A5D")]
	[Address(RVA = "0x6916F0", Offset = "0x68FCF0", VA = "0x1806916F0", Slot = "6")]
	protected override void Awake()
	{
		ulong num2;
		do
		{
			int num = 0;
			CustomMenu.Instance = this;
			base.GetCol();
			Animator component = base.GetComponent<Animator>();
			this.anim = component;
			CustomMenu._levelData = new SerializedLevelData
			{
				levelNumber = (int)((ulong)1L)
			};
			SerializedLevelData serializedLevelData = CustomMenu._levelData;
			this.levelData = serializedLevelData;
			this.InitScene();
			List<CustomMenu_page> list = this.pages;
			bool flag;
			if (flag)
			{
				TypeCode typeCode = num.GetTypeCode();
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06002A5E RID: 10846 RVA: 0x000E5234 File Offset: 0x000E3434
	[Token(Token = "0x6002A5E")]
	[Address(RVA = "0x691BE0", Offset = "0x6901E0", VA = "0x180691BE0")]
	public void ExportLevel()
	{
		ulong num;
		do
		{
			List<CustomMenu_page> list = this.pages;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
		SerializedLevelData serializedLevelData = CustomMenu._levelData.Copy();
		if (string.IsNullOrEmpty(serializedLevelData.name))
		{
			serializedLevelData.name = "未命名关卡";
		}
		if (serializedLevelData.levelNumber == 0)
		{
			serializedLevelData.levelNumber = (int)((ulong)1L);
		}
		serializedLevelData.levelType = (LevelType)((ulong)11L);
		LevelManager.SaveLevelData(serializedLevelData);
	}

	// Token: 0x06002A5F RID: 10847 RVA: 0x000E52B4 File Offset: 0x000E34B4
	[Token(Token = "0x6002A5F")]
	[Address(RVA = "0x691DE0", Offset = "0x6903E0", VA = "0x180691DE0")]
	public void GotoPage(int page)
	{
		Page page2 = this.page;
		int num = 0;
		int childCount = page2.transform.childCount;
		Page page3 = this.page;
		if (num < childCount)
		{
			GameObject gameObject = page3.transform.GetChild(num).gameObject;
			bool flag = num == page;
			gameObject.SetActive(flag);
			Page page4 = this.page;
			num++;
		}
		page3.gameObject.SetActive(true);
		this.nextPage.SetActive(true);
		this.lastPage.SetActive(true);
		this.closePageButton.SetActive(true);
		GameObject gameObject2 = this.openPageButton;
		int num2 = 0;
		gameObject2.SetActive(num2 != 0);
		GameObject gameObject3 = this.closeMenuButton;
		int num3 = 0;
		gameObject3.SetActive(num3 != 0);
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002A60 RID: 10848 RVA: 0x000E5378 File Offset: 0x000E3578
	[Token(Token = "0x6002A60")]
	[Address(RVA = "0x691980", Offset = "0x68FF80", VA = "0x180691980")]
	public void ClosePage()
	{
		GameObject gameObject = this.page.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
		GameObject gameObject2 = this.nextPage;
		int num2 = 0;
		gameObject2.SetActive(num2 != 0);
		GameObject gameObject3 = this.lastPage;
		int num3 = 0;
		gameObject3.SetActive(num3 != 0);
		GameObject gameObject4 = this.closePageButton;
		int num4 = 0;
		gameObject4.SetActive(num4 != 0);
		this.openPageButton.SetActive(true);
		this.closeMenuButton.SetActive(true);
	}

	// Token: 0x06002A61 RID: 10849 RVA: 0x000E53F0 File Offset: 0x000E35F0
	[Token(Token = "0x6002A61")]
	[Address(RVA = "0x692B30", Offset = "0x691130", VA = "0x180692B30")]
	public CustomMenu()
	{
		List<CustomMenu_page> list = new List();
		this.pages = list;
		base..ctor();
	}

	// Token: 0x0400183D RID: 6205
	[Token(Token = "0x400183D")]
	public static CustomMenu Instance;

	// Token: 0x0400183E RID: 6206
	[Token(Token = "0x400183E")]
	public static SerializedLevelData _levelData;

	// Token: 0x0400183F RID: 6207
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400183F")]
	public SerializedLevelData levelData;

	// Token: 0x04001840 RID: 6208
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001840")]
	[Header("场景设置")]
	public RectTransform ScenesContent;

	// Token: 0x04001841 RID: 6209
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001841")]
	public RectTransform CurrentSceneContainer;

	// Token: 0x04001842 RID: 6210
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001842")]
	public CustomButton_scene FirstSceneButton;

	// Token: 0x04001843 RID: 6211
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001843")]
	[Header("波数设置")]
	public TMP_InputField waveInput;

	// Token: 0x04001844 RID: 6212
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001844")]
	[Header("阳光设置")]
	public TMP_InputField sunInput;

	// Token: 0x04001845 RID: 6213
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001845")]
	[Header("关卡名、编号等设置")]
	public TMP_InputField nameInput;

	// Token: 0x04001846 RID: 6214
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001846")]
	public TMP_InputField levelNumberInput;

	// Token: 0x04001847 RID: 6215
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001847")]
	[Header("设置页面")]
	public List<CustomMenu_page> pages;

	// Token: 0x04001848 RID: 6216
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001848")]
	public Page page;

	// Token: 0x04001849 RID: 6217
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001849")]
	public GameObject lastPage;

	// Token: 0x0400184A RID: 6218
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400184A")]
	public GameObject nextPage;

	// Token: 0x0400184B RID: 6219
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400184B")]
	public GameObject openPageButton;

	// Token: 0x0400184C RID: 6220
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400184C")]
	public GameObject closePageButton;

	// Token: 0x0400184D RID: 6221
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400184D")]
	public GameObject closeMenuButton;
}
