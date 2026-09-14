using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x0200085E RID: 2142
[Token(Token = "0x200085E")]
public class MainMenu : BaseMenu
{
	// Token: 0x06002BBE RID: 11198 RVA: 0x000F02FC File Offset: 0x000EE4FC
	[Token(Token = "0x6002BBE")]
	[Address(RVA = "0x66D360", Offset = "0x66B960", VA = "0x18066D360")]
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
	}

	// Token: 0x06002BBF RID: 11199 RVA: 0x000F04E0 File Offset: 0x000EE6E0
	[Token(Token = "0x6002BBF")]
	[Address(RVA = "0x66D060", Offset = "0x66B660", VA = "0x18066D060")]
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

	// Token: 0x06002BC0 RID: 11200 RVA: 0x000F0520 File Offset: 0x000EE720
	[Token(Token = "0x6002BC0")]
	[Address(RVA = "0x66CEF0", Offset = "0x66B4F0", VA = "0x18066CEF0")]
	public void EnterClassicAdvanture()
	{
		int num = 0;
		int num2 = 0;
		int advantureLevel = GameAPP.advantureLevel;
		UIMgr.EnterGame((LevelType)num2, advantureLevel, -1, num);
	}

	// Token: 0x06002BC1 RID: 11201 RVA: 0x000F0540 File Offset: 0x000EE740
	[Token(Token = "0x6002BC1")]
	[Address(RVA = "0x66CEE0", Offset = "0x66B4E0", VA = "0x18066CEE0")]
	public void EnterChallengeMenu()
	{
		UIMgr.EnterChallengeMenu();
	}

	// Token: 0x06002BC2 RID: 11202 RVA: 0x000F0554 File Offset: 0x000EE754
	[Token(Token = "0x6002BC2")]
	[Address(RVA = "0x66D050", Offset = "0x66B650", VA = "0x18066D050")]
	public void EnterIZMenu()
	{
		UIMgr.EnterIZMenu();
	}

	// Token: 0x06002BC3 RID: 11203 RVA: 0x000F0568 File Offset: 0x000EE768
	[Token(Token = "0x6002BC3")]
	[Address(RVA = "0x66D1D0", Offset = "0x66B7D0", VA = "0x18066D1D0")]
	public void EnterSurvivalMenu()
	{
		UIMgr.EnterSurvivalEMenu();
	}

	// Token: 0x06002BC4 RID: 11204 RVA: 0x000F057C File Offset: 0x000EE77C
	[Token(Token = "0x6002BC4")]
	[Address(RVA = "0x66CF70", Offset = "0x66B570", VA = "0x18066CF70")]
	public void EnterExploreMenu()
	{
		UIMgr.EnterExploreMenu();
	}

	// Token: 0x06002BC5 RID: 11205 RVA: 0x000F0590 File Offset: 0x000EE790
	[Token(Token = "0x6002BC5")]
	[Address(RVA = "0x66D1E0", Offset = "0x66B7E0", VA = "0x18066D1E0")]
	public void EnterTowerMenu()
	{
		UIMgr.EnterTowerMenu();
	}

	// Token: 0x06002BC6 RID: 11206 RVA: 0x000F05A4 File Offset: 0x000EE7A4
	[Token(Token = "0x6002BC6")]
	[Address(RVA = "0x66D290", Offset = "0x66B890", VA = "0x18066D290")]
	public void ExitGame()
	{
		Application.Quit();
	}

	// Token: 0x06002BC7 RID: 11207 RVA: 0x000F05B8 File Offset: 0x000EE7B8
	[Token(Token = "0x6002BC7")]
	[Address(RVA = "0x66CFE0", Offset = "0x66B5E0", VA = "0x18066CFE0")]
	public void EnterHelpMenu()
	{
		GameAPP.UIManager.PopAll();
		UIMgr.EnterHelpMenu();
	}

	// Token: 0x06002BC8 RID: 11208 RVA: 0x000F05DC File Offset: 0x000EE7DC
	[Token(Token = "0x6002BC8")]
	[Address(RVA = "0x66D7E0", Offset = "0x66BDE0", VA = "0x18066D7E0")]
	public void SwitchTravelMode()
	{
		GameAPP.TravelMenu = "{il2cpp field on {'constant8' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0xF9}" == (ulong)0L;
		UIMgr.EnterMainMenu();
	}

	// Token: 0x06002BC9 RID: 11209 RVA: 0x000F0600 File Offset: 0x000EE800
	[Token(Token = "0x6002BC9")]
	[Address(RVA = "0x66D220", Offset = "0x66B820", VA = "0x18066D220")]
	public void EnterTreasureMenu()
	{
		UIMgr.EnterTreasureMenu();
	}

	// Token: 0x06002BCA RID: 11210 RVA: 0x000F0614 File Offset: 0x000EE814
	[Token(Token = "0x6002BCA")]
	[Address(RVA = "0x66CF80", Offset = "0x66B580", VA = "0x18066CF80")]
	public void EnterGarden()
	{
		UIMgr.EnterGarden();
	}

	// Token: 0x06002BCB RID: 11211 RVA: 0x000F062C File Offset: 0x000EE82C
	[Token(Token = "0x6002BCB")]
	[Address(RVA = "0x66CF60", Offset = "0x66B560", VA = "0x18066CF60")]
	public void EnterClassicTravel()
	{
		UIMgr.EnterClassicTravel();
	}

	// Token: 0x06002BCC RID: 11212 RVA: 0x000F0640 File Offset: 0x000EE840
	[Token(Token = "0x6002BCC")]
	[Address(RVA = "0x66D1F0", Offset = "0x66B7F0", VA = "0x18066D1F0")]
	public void EnterTravelAdvanture()
	{
		UIMgr.EnterTravelAdv();
	}

	// Token: 0x06002BCD RID: 11213 RVA: 0x000F0654 File Offset: 0x000EE854
	[Token(Token = "0x6002BCD")]
	[Address(RVA = "0x66D210", Offset = "0x66B810", VA = "0x18066D210")]
	public void EnterTravelGame()
	{
		UIMgr.EnterTravelGame();
	}

	// Token: 0x06002BCE RID: 11214 RVA: 0x000F0668 File Offset: 0x000EE868
	[Token(Token = "0x6002BCE")]
	[Address(RVA = "0x66D200", Offset = "0x66B800", VA = "0x18066D200")]
	public void EnterTravelChallenge()
	{
		UIMgr.EnterTravelChallenge();
	}

	// Token: 0x170001BD RID: 445
	// (get) Token: 0x06002BCF RID: 11215 RVA: 0x000F067C File Offset: 0x000EE87C
	[Token(Token = "0x170001BD")]
	private static string CurrentVersion
	{
		[Token(Token = "0x6002BCF")]
		[Address(RVA = "0x66D9C0", Offset = "0x66BFC0", VA = "0x18066D9C0")]
		get
		{
			return GameAPP.version;
		}
	}

	// Token: 0x06002BD0 RID: 11216 RVA: 0x000F0690 File Offset: 0x000EE890
	[Token(Token = "0x6002BD0")]
	[Address(RVA = "0x66D230", Offset = "0x66B830", VA = "0x18066D230")]
	public void EnterUpdateUrl()
	{
		Application.OpenURL("https://wiki.biligame.com/pvzrh");
	}

	// Token: 0x06002BD1 RID: 11217 RVA: 0x000F06A8 File Offset: 0x000EE8A8
	[Token(Token = "0x6002BD1")]
	[Address(RVA = "0x66D2D0", Offset = "0x66B8D0", VA = "0x18066D2D0")]
	public static void GetLatestVersion()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002BD2 RID: 11218 RVA: 0x000F06C8 File Offset: 0x000EE8C8
	[Token(Token = "0x6002BD2")]
	[Address(RVA = "0x66CE70", Offset = "0x66B470", VA = "0x18066CE70")]
	private void AnimOver()
	{
		global::UnityEngine.Object.Destroy(base.GetComponent<Animator>());
	}

	// Token: 0x06002BD3 RID: 11219 RVA: 0x000F06E0 File Offset: 0x000EE8E0
	[Token(Token = "0x6002BD3")]
	[Address(RVA = "0x66D850", Offset = "0x66BE50", VA = "0x18066D850")]
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

	// Token: 0x06002BD4 RID: 11220 RVA: 0x000F0754 File Offset: 0x000EE954
	[Token(Token = "0x6002BD4")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public MainMenu()
	{
	}

	// Token: 0x040019EE RID: 6638
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40019EE")]
	public TextMeshProUGUI nameMesh;

	// Token: 0x040019EF RID: 6639
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40019EF")]
	public GameObject TravelEnter;

	// Token: 0x040019F0 RID: 6640
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40019F0")]
	public GameObject MystriousEnter;

	// Token: 0x040019F1 RID: 6641
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40019F1")]
	public GameObject RecipeEnter;

	// Token: 0x040019F2 RID: 6642
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40019F2")]
	public GameObject GardenEnter;

	// Token: 0x040019F3 RID: 6643
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40019F3")]
	public GameObject hotLevelEnter;

	// Token: 0x040019F4 RID: 6644
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40019F4")]
	public UIButton_mainMenu challengeLevel;

	// Token: 0x040019F5 RID: 6645
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40019F5")]
	public UIButton_mainMenu izLevel;

	// Token: 0x040019F6 RID: 6646
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40019F6")]
	public UIButton_mainMenu survivalLevel;

	// Token: 0x040019F7 RID: 6647
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40019F7")]
	public GameObject updateItem;

	// Token: 0x040019F8 RID: 6648
	[Token(Token = "0x40019F8")]
	protected static bool connected;

	// Token: 0x040019F9 RID: 6649
	[Token(Token = "0x40019F9")]
	public static string LatestVersion;

	// Token: 0x0200085F RID: 2143
	[Token(Token = "0x200085F")]
	public enum ButtonState
	{
		// Token: 0x040019FB RID: 6651
		[Token(Token = "0x40019FB")]
		Default,
		// Token: 0x040019FC RID: 6652
		[Token(Token = "0x40019FC")]
		Hide,
		// Token: 0x040019FD RID: 6653
		[Token(Token = "0x40019FD")]
		NonInteractive
	}
}
