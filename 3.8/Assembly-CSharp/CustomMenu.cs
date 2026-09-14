using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;
using TMPro;
using UnityEngine;

// Token: 0x020007E3 RID: 2019
[Token(Token = "0x20007E3")]
public class CustomMenu : BaseMenu
{
	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x06002924 RID: 10532 RVA: 0x000DFEFC File Offset: 0x000DE0FC
	[Token(Token = "0x170001A2")]
	public SerializedLevelData LevelData
	{
		[Token(Token = "0x6002924")]
		[Address(RVA = "0x62F2A0", Offset = "0x62D8A0", VA = "0x18062F2A0")]
		get
		{
			return CustomMenu._levelData;
		}
	}

	// Token: 0x06002925 RID: 10533 RVA: 0x000DFF10 File Offset: 0x000DE110
	[Token(Token = "0x6002925")]
	[Address(RVA = "0x62E930", Offset = "0x62CF30", VA = "0x18062E930")]
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

	// Token: 0x06002926 RID: 10534 RVA: 0x000DFFA0 File Offset: 0x000DE1A0
	[Token(Token = "0x6002926")]
	[Address(RVA = "0x62E120", Offset = "0x62C720", VA = "0x18062E120")]
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

	// Token: 0x06002927 RID: 10535 RVA: 0x000DFFFC File Offset: 0x000DE1FC
	[Token(Token = "0x6002927")]
	[Address(RVA = "0x62EFC0", Offset = "0x62D5C0", VA = "0x18062EFC0")]
	public void SetSpawnZombie()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)57), canvasUp, num != 0);
		SerializedLevelData serializedLevelData = CustomMenu._levelData;
		throw new NullReferenceException();
	}

	// Token: 0x06002928 RID: 10536 RVA: 0x000E0034 File Offset: 0x000DE234
	[Token(Token = "0x6002928")]
	[Address(RVA = "0x62F150", Offset = "0x62D750", VA = "0x18062F150")]
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

	// Token: 0x06002929 RID: 10537 RVA: 0x000E0084 File Offset: 0x000DE284
	[Token(Token = "0x6002929")]
	[Address(RVA = "0x62F0D0", Offset = "0x62D6D0", VA = "0x18062F0D0")]
	public void SetSun()
	{
		ulong num;
		if (int.TryParse(this.sunInput.m_Text, (int)num))
		{
			CustomMenu._levelData.startSun = (int)num;
		}
	}

	// Token: 0x0600292A RID: 10538 RVA: 0x000E00B8 File Offset: 0x000DE2B8
	[Token(Token = "0x600292A")]
	[Address(RVA = "0x62EBD0", Offset = "0x62D1D0", VA = "0x18062EBD0")]
	public void SetName()
	{
		SerializedLevelData serializedLevelData = CustomMenu._levelData;
		string text = this.nameInput.m_Text;
		serializedLevelData.name = text;
		throw new NullReferenceException();
	}

	// Token: 0x0600292B RID: 10539 RVA: 0x000E00E4 File Offset: 0x000DE2E4
	[Token(Token = "0x600292B")]
	[Address(RVA = "0x62EC40", Offset = "0x62D240", VA = "0x18062EC40")]
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

	// Token: 0x0600292C RID: 10540 RVA: 0x000E0134 File Offset: 0x000DE334
	[Token(Token = "0x600292C")]
	[Address(RVA = "0x62ED40", Offset = "0x62D340", VA = "0x18062ED40")]
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

	// Token: 0x0600292D RID: 10541 RVA: 0x000E01C4 File Offset: 0x000DE3C4
	[Token(Token = "0x600292D")]
	[Address(RVA = "0x62E640", Offset = "0x62CC40", VA = "0x18062E640")]
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

	// Token: 0x0600292E RID: 10542 RVA: 0x000E025C File Offset: 0x000DE45C
	[Token(Token = "0x600292E")]
	[Address(RVA = "0x62DDE0", Offset = "0x62C3E0", VA = "0x18062DDE0", Slot = "6")]
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

	// Token: 0x0600292F RID: 10543 RVA: 0x000E02E0 File Offset: 0x000DE4E0
	[Token(Token = "0x600292F")]
	[Address(RVA = "0x62E2D0", Offset = "0x62C8D0", VA = "0x18062E2D0")]
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

	// Token: 0x06002930 RID: 10544 RVA: 0x000E0360 File Offset: 0x000DE560
	[Token(Token = "0x6002930")]
	[Address(RVA = "0x62E4D0", Offset = "0x62CAD0", VA = "0x18062E4D0")]
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

	// Token: 0x06002931 RID: 10545 RVA: 0x000E0424 File Offset: 0x000DE624
	[Token(Token = "0x6002931")]
	[Address(RVA = "0x62E070", Offset = "0x62C670", VA = "0x18062E070")]
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

	// Token: 0x06002932 RID: 10546 RVA: 0x000E049C File Offset: 0x000DE69C
	[Token(Token = "0x6002932")]
	[Address(RVA = "0x62F220", Offset = "0x62D820", VA = "0x18062F220")]
	public CustomMenu()
	{
		List<CustomMenu_page> list = new List();
		this.pages = list;
		base..ctor();
	}

	// Token: 0x04001761 RID: 5985
	[Token(Token = "0x4001761")]
	public static CustomMenu Instance;

	// Token: 0x04001762 RID: 5986
	[Token(Token = "0x4001762")]
	public static SerializedLevelData _levelData;

	// Token: 0x04001763 RID: 5987
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001763")]
	public SerializedLevelData levelData;

	// Token: 0x04001764 RID: 5988
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001764")]
	[Header("场景设置")]
	public RectTransform ScenesContent;

	// Token: 0x04001765 RID: 5989
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001765")]
	public RectTransform CurrentSceneContainer;

	// Token: 0x04001766 RID: 5990
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001766")]
	public CustomButton_scene FirstSceneButton;

	// Token: 0x04001767 RID: 5991
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001767")]
	[Header("波数设置")]
	public TMP_InputField waveInput;

	// Token: 0x04001768 RID: 5992
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001768")]
	[Header("阳光设置")]
	public TMP_InputField sunInput;

	// Token: 0x04001769 RID: 5993
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001769")]
	[Header("关卡名、编号等设置")]
	public TMP_InputField nameInput;

	// Token: 0x0400176A RID: 5994
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400176A")]
	public TMP_InputField levelNumberInput;

	// Token: 0x0400176B RID: 5995
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400176B")]
	[Header("设置页面")]
	public List<CustomMenu_page> pages;

	// Token: 0x0400176C RID: 5996
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400176C")]
	public Page page;

	// Token: 0x0400176D RID: 5997
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400176D")]
	public GameObject lastPage;

	// Token: 0x0400176E RID: 5998
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400176E")]
	public GameObject nextPage;

	// Token: 0x0400176F RID: 5999
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400176F")]
	public GameObject openPageButton;

	// Token: 0x04001770 RID: 6000
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001770")]
	public GameObject closePageButton;

	// Token: 0x04001771 RID: 6001
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001771")]
	public GameObject closeMenuButton;
}
