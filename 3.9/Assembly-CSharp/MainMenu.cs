using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x0200089A RID: 2202
[Token(Token = "0x200089A")]
public class MainMenu : BaseMenu
{
	// Token: 0x06002CF0 RID: 11504 RVA: 0x000F4F78 File Offset: 0x000F3178
	[Token(Token = "0x6002CF0")]
	[Address(RVA = "0x6D1E80", Offset = "0x6D0480", VA = "0x1806D1E80")]
	private void Start()
	{
		GameObject gameObject = this.hotLevelEnter;
		int num = 0;
		if (gameObject != num)
		{
			GameObject gameObject2 = this.hotLevelEnter;
			bool[] advLevelCompleted = GameAPP.advLevelCompleted;
			bool flag = "{il2cpp array field local6->}" != (ulong)0L;
			gameObject2.SetActive(flag);
		}
		GameObject travelEnter = this.TravelEnter;
		int num2 = 0;
		if (travelEnter != num2)
		{
			GameObject travelEnter2 = this.TravelEnter;
			bool[] advLevelCompleted2 = GameAPP.advLevelCompleted;
			bool flag2 = "{il2cpp array field local14->}" != (ulong)0L;
			travelEnter2.SetActive(flag2);
		}
		GameObject mystriousEnter = this.MystriousEnter;
		int num3 = 0;
		if (mystriousEnter != num3)
		{
			GameObject mystriousEnter2 = this.MystriousEnter;
			bool[] advLevelCompleted3 = GameAPP.advLevelCompleted;
			bool flag3 = "{il2cpp array field local22->}" != (ulong)0L;
			mystriousEnter2.SetActive(flag3);
		}
		GameObject recipeEnter = this.RecipeEnter;
		int num4 = 0;
		if (recipeEnter != num4)
		{
			GameObject recipeEnter2 = this.RecipeEnter;
			bool[] advLevelCompleted4 = GameAPP.advLevelCompleted;
			bool flag4 = "{il2cpp array field local30->}" != (ulong)0L;
			recipeEnter2.SetActive(flag4);
		}
		GameObject gardenEnter = this.GardenEnter;
		int num5 = 0;
		if (gardenEnter != num5)
		{
			GameObject gardenEnter2 = this.GardenEnter;
			bool[] advLevelCompleted5 = GameAPP.advLevelCompleted;
			bool flag5 = "{il2cpp array field local38->}" != (ulong)0L;
			gardenEnter2.SetActive(flag5);
		}
		UIButton_mainMenu uibutton_mainMenu = this.challengeLevel;
		int num6 = 0;
		if (uibutton_mainMenu != num6)
		{
			bool[] advLevelCompleted6 = GameAPP.advLevelCompleted;
			if ("{il2cpp array field local45->}" == (ulong)0L)
			{
				this.challengeLevel.State = (MainMenu.ButtonState)((uint)2);
			}
		}
		UIButton_mainMenu uibutton_mainMenu2 = this.izLevel;
		int num7 = 0;
		if (uibutton_mainMenu2 != num7)
		{
			bool[] advLevelCompleted7 = GameAPP.advLevelCompleted;
			if ("{il2cpp array field local52->}" == (ulong)0L)
			{
				this.izLevel.State = (MainMenu.ButtonState)((uint)2);
			}
		}
		UIButton_mainMenu uibutton_mainMenu3 = this.survivalLevel;
		int num8 = 0;
		if (uibutton_mainMenu3 != num8)
		{
			bool[] advLevelCompleted8 = GameAPP.advLevelCompleted;
			if ("{il2cpp array field local59->}" == (ulong)0L)
			{
				this.survivalLevel.State = (MainMenu.ButtonState)((uint)2);
			}
		}
		float timeScale = Time.timeScale;
		Time.timeScale = 1f;
	}

	// Token: 0x06002CF1 RID: 11505 RVA: 0x000F5170 File Offset: 0x000F3370
	[Token(Token = "0x6002CF1")]
	[Address(RVA = "0x6D1B80", Offset = "0x6D0180", VA = "0x1806D1B80")]
	public void EnterNormalMenu(string name)
	{
		ulong num;
		if (Enum.TryParse(typeof(UIType), name, num))
		{
			GameAPP.UIManager.PopAll();
			UIResourcesLoader uimanager = GameAPP.UIManager;
			UIMgr.MenuNormalSettings();
		}
	}

	// Token: 0x06002CF2 RID: 11506 RVA: 0x000F51B0 File Offset: 0x000F33B0
	[Token(Token = "0x6002CF2")]
	[Address(RVA = "0x6D1A10", Offset = "0x6D0010", VA = "0x1806D1A10")]
	public void EnterClassicAdvanture()
	{
		int num = 0;
		int num2 = 0;
		int advantureLevel = GameAPP.advantureLevel;
		UIMgr.EnterGame((LevelType)num2, advantureLevel, -1, num);
	}

	// Token: 0x06002CF3 RID: 11507 RVA: 0x000F51D0 File Offset: 0x000F33D0
	[Token(Token = "0x6002CF3")]
	[Address(RVA = "0x6D1A00", Offset = "0x6D0000", VA = "0x1806D1A00")]
	public void EnterChallengeMenu()
	{
		UIMgr.EnterChallengeMenu();
	}

	// Token: 0x06002CF4 RID: 11508 RVA: 0x000F51E4 File Offset: 0x000F33E4
	[Token(Token = "0x6002CF4")]
	[Address(RVA = "0x6D1B70", Offset = "0x6D0170", VA = "0x1806D1B70")]
	public void EnterIZMenu()
	{
		UIMgr.EnterIZMenu();
	}

	// Token: 0x06002CF5 RID: 11509 RVA: 0x000F51F8 File Offset: 0x000F33F8
	[Token(Token = "0x6002CF5")]
	[Address(RVA = "0x6D1CF0", Offset = "0x6D02F0", VA = "0x1806D1CF0")]
	public void EnterSurvivalMenu()
	{
		UIMgr.EnterSurvivalEMenu();
	}

	// Token: 0x06002CF6 RID: 11510 RVA: 0x000F520C File Offset: 0x000F340C
	[Token(Token = "0x6002CF6")]
	[Address(RVA = "0x6D1A90", Offset = "0x6D0090", VA = "0x1806D1A90")]
	public void EnterExploreMenu()
	{
		UIMgr.EnterExploreMenu();
	}

	// Token: 0x06002CF7 RID: 11511 RVA: 0x000F5220 File Offset: 0x000F3420
	[Token(Token = "0x6002CF7")]
	[Address(RVA = "0x6D1D00", Offset = "0x6D0300", VA = "0x1806D1D00")]
	public void EnterTowerMenu()
	{
		UIMgr.EnterTowerMenu();
	}

	// Token: 0x06002CF8 RID: 11512 RVA: 0x000F5234 File Offset: 0x000F3434
	[Token(Token = "0x6002CF8")]
	[Address(RVA = "0x6D1DB0", Offset = "0x6D03B0", VA = "0x1806D1DB0")]
	public void ExitGame()
	{
		Application.Quit();
	}

	// Token: 0x06002CF9 RID: 11513 RVA: 0x000F5248 File Offset: 0x000F3448
	[Token(Token = "0x6002CF9")]
	[Address(RVA = "0x6D1B00", Offset = "0x6D0100", VA = "0x1806D1B00")]
	public void EnterHelpMenu()
	{
		GameAPP.UIManager.PopAll();
		UIMgr.EnterHelpMenu();
	}

	// Token: 0x06002CFA RID: 11514 RVA: 0x000F526C File Offset: 0x000F346C
	[Token(Token = "0x6002CFA")]
	[Address(RVA = "0x6D2320", Offset = "0x6D0920", VA = "0x1806D2320")]
	public void SwitchTravelMode()
	{
		GameAPP.TravelMenu = "{il2cpp field on {'constant8' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0xF9}" == (ulong)0L;
		UIMgr.EnterMainMenu();
	}

	// Token: 0x06002CFB RID: 11515 RVA: 0x000F5290 File Offset: 0x000F3490
	[Token(Token = "0x6002CFB")]
	[Address(RVA = "0x6D1D40", Offset = "0x6D0340", VA = "0x1806D1D40")]
	public void EnterTreasureMenu()
	{
		UIMgr.EnterTreasureMenu();
	}

	// Token: 0x06002CFC RID: 11516 RVA: 0x000F52A4 File Offset: 0x000F34A4
	[Token(Token = "0x6002CFC")]
	[Address(RVA = "0x6D1AA0", Offset = "0x6D00A0", VA = "0x1806D1AA0")]
	public void EnterGarden()
	{
		UIMgr.EnterGarden();
	}

	// Token: 0x06002CFD RID: 11517 RVA: 0x000F52BC File Offset: 0x000F34BC
	[Token(Token = "0x6002CFD")]
	[Address(RVA = "0x6D1A80", Offset = "0x6D0080", VA = "0x1806D1A80")]
	public void EnterClassicTravel()
	{
		UIMgr.EnterClassicTravel();
	}

	// Token: 0x06002CFE RID: 11518 RVA: 0x000F52D0 File Offset: 0x000F34D0
	[Token(Token = "0x6002CFE")]
	[Address(RVA = "0x6D1D10", Offset = "0x6D0310", VA = "0x1806D1D10")]
	public void EnterTravelAdvanture()
	{
		UIMgr.EnterTravelAdv();
	}

	// Token: 0x06002CFF RID: 11519 RVA: 0x000F52E4 File Offset: 0x000F34E4
	[Token(Token = "0x6002CFF")]
	[Address(RVA = "0x6D1D30", Offset = "0x6D0330", VA = "0x1806D1D30")]
	public void EnterTravelGame()
	{
		UIMgr.EnterTravelGame();
	}

	// Token: 0x06002D00 RID: 11520 RVA: 0x000F52F8 File Offset: 0x000F34F8
	[Token(Token = "0x6002D00")]
	[Address(RVA = "0x6D1D20", Offset = "0x6D0320", VA = "0x1806D1D20")]
	public void EnterTravelChallenge()
	{
		UIMgr.EnterTravelChallenge();
	}

	// Token: 0x17000205 RID: 517
	// (get) Token: 0x06002D01 RID: 11521 RVA: 0x000F530C File Offset: 0x000F350C
	[Token(Token = "0x17000205")]
	private static string CurrentVersion
	{
		[Token(Token = "0x6002D01")]
		[Address(RVA = "0x6D2500", Offset = "0x6D0B00", VA = "0x1806D2500")]
		get
		{
			return GameAPP.version;
		}
	}

	// Token: 0x06002D02 RID: 11522 RVA: 0x000F5320 File Offset: 0x000F3520
	[Token(Token = "0x6002D02")]
	[Address(RVA = "0x6D1D50", Offset = "0x6D0350", VA = "0x1806D1D50")]
	public void EnterUpdateUrl()
	{
		Application.OpenURL("https://wiki.biligame.com/pvzrh");
	}

	// Token: 0x06002D03 RID: 11523 RVA: 0x000F5338 File Offset: 0x000F3538
	[Token(Token = "0x6002D03")]
	[Address(RVA = "0x6D1DF0", Offset = "0x6D03F0", VA = "0x1806D1DF0")]
	public static void GetLatestVersion()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002D04 RID: 11524 RVA: 0x000F5358 File Offset: 0x000F3558
	[Token(Token = "0x6002D04")]
	[Address(RVA = "0x6D1990", Offset = "0x6CFF90", VA = "0x1806D1990")]
	private void AnimOver()
	{
		global::UnityEngine.Object.Destroy(base.GetComponent<Animator>());
	}

	// Token: 0x06002D05 RID: 11525 RVA: 0x000F5370 File Offset: 0x000F3570
	[Token(Token = "0x6002D05")]
	[Address(RVA = "0x6D2390", Offset = "0x6D0990", VA = "0x1806D2390")]
	private void Update()
	{
		TextMeshProUGUI textMeshProUGUI = this.nameMesh;
		string playerName = GameAPP.playerName;
		textMeshProUGUI.text = playerName;
		GameObject gameObject = this.updateItem;
		int num = 0;
		if (gameObject != num)
		{
			GameObject gameObject2 = this.updateItem;
			string latestVersion = MainMenu.LatestVersion;
			string version = GameAPP.version;
			if (!(latestVersion != version))
			{
			}
			bool flag = MainMenu.connected;
			gameObject2.SetActive(flag);
		}
	}

	// Token: 0x06002D06 RID: 11526 RVA: 0x000F53E4 File Offset: 0x000F35E4
	[Token(Token = "0x6002D06")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public MainMenu()
	{
	}

	// Token: 0x04001ADC RID: 6876
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001ADC")]
	public TextMeshProUGUI nameMesh;

	// Token: 0x04001ADD RID: 6877
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001ADD")]
	public GameObject TravelEnter;

	// Token: 0x04001ADE RID: 6878
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001ADE")]
	public GameObject MystriousEnter;

	// Token: 0x04001ADF RID: 6879
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001ADF")]
	public GameObject RecipeEnter;

	// Token: 0x04001AE0 RID: 6880
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001AE0")]
	public GameObject GardenEnter;

	// Token: 0x04001AE1 RID: 6881
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001AE1")]
	public GameObject hotLevelEnter;

	// Token: 0x04001AE2 RID: 6882
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001AE2")]
	public UIButton_mainMenu challengeLevel;

	// Token: 0x04001AE3 RID: 6883
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001AE3")]
	public UIButton_mainMenu izLevel;

	// Token: 0x04001AE4 RID: 6884
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001AE4")]
	public UIButton_mainMenu survivalLevel;

	// Token: 0x04001AE5 RID: 6885
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001AE5")]
	public GameObject updateItem;

	// Token: 0x04001AE6 RID: 6886
	[Token(Token = "0x4001AE6")]
	protected static bool connected;

	// Token: 0x04001AE7 RID: 6887
	[Token(Token = "0x4001AE7")]
	public static string LatestVersion;

	// Token: 0x0200089B RID: 2203
	[Token(Token = "0x200089B")]
	public enum ButtonState
	{
		// Token: 0x04001AE9 RID: 6889
		[Token(Token = "0x4001AE9")]
		Default,
		// Token: 0x04001AEA RID: 6890
		[Token(Token = "0x4001AEA")]
		Hide,
		// Token: 0x04001AEB RID: 6891
		[Token(Token = "0x4001AEB")]
		NonInteractive
	}
}
