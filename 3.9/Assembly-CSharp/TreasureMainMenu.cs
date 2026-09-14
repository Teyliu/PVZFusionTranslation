using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020008CD RID: 2253
[Token(Token = "0x20008CD")]
public class TreasureMainMenu : BaseMenu
{
	// Token: 0x06002DE7 RID: 11751 RVA: 0x000FB818 File Offset: 0x000F9A18
	[Token(Token = "0x6002DE7")]
	[Address(RVA = "0x7078F0", Offset = "0x705EF0", VA = "0x1807078F0", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		TreasureMainMenu.Instance = this;
	}

	// Token: 0x06002DE8 RID: 11752 RVA: 0x000FB834 File Offset: 0x000F9A34
	[Token(Token = "0x6002DE8")]
	[Address(RVA = "0x7085F0", Offset = "0x706BF0", VA = "0x1807085F0")]
	private void Update()
	{
		SceneType levelSceneType = TreasureData.levelSceneType;
		int num = (int)levelSceneType;
		if (levelSceneType != SceneType.Day)
		{
			if (levelSceneType != SceneType.Day)
			{
				if (levelSceneType != SceneType.Day)
				{
					if (levelSceneType != SceneType.Day)
					{
						if (num != 1)
						{
							if (levelSceneType == SceneType.Snow)
							{
								TextMeshProUGUI textMeshProUGUI = this.mapText;
							}
							return;
						}
						TextMeshProUGUI textMeshProUGUI2 = this.mapText;
					}
					TextMeshProUGUI textMeshProUGUI3 = this.mapText;
				}
				TextMeshProUGUI textMeshProUGUI4 = this.mapText;
			}
			TextMeshProUGUI textMeshProUGUI5 = this.mapText;
		}
		TextMeshProUGUI textMeshProUGUI6 = this.mapText;
		throw new NullReferenceException();
	}

	// Token: 0x06002DE9 RID: 11753 RVA: 0x000FB898 File Offset: 0x000F9A98
	[Token(Token = "0x6002DE9")]
	[Address(RVA = "0x707B20", Offset = "0x706120", VA = "0x180707B20")]
	public void EnterGarden()
	{
		GameAPP.Instance.PlayMusic((MusicType)((uint)16));
		GameAPP.UIManager.PopAll();
		Garden component = global::UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("Garden/BigGarden/GardenPrefab")).GetComponent<Garden>();
		CursorChange.SetDefaultCursor();
		UIResourcesLoader uimanager = GameAPP.UIManager;
		int num = 0;
		Transform canvasUp = GameAPP.canvasUp;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)52), canvasUp, num != 0);
		component.ui = baseMenu;
		throw new NullReferenceException();
	}

	// Token: 0x06002DEA RID: 11754 RVA: 0x000FB904 File Offset: 0x000F9B04
	[Token(Token = "0x6002DEA")]
	[Address(RVA = "0x7083E0", Offset = "0x7069E0", VA = "0x1807083E0")]
	public void SetSceneType(string name)
	{
		ulong num;
		if (Enum.TryParse(typeof(SceneType), name, num))
		{
			TreasureData.levelSceneType = (SceneType)num;
		}
	}

	// Token: 0x06002DEB RID: 11755 RVA: 0x000FB934 File Offset: 0x000F9B34
	[Token(Token = "0x6002DEB")]
	[Address(RVA = "0x708360", Offset = "0x706960", VA = "0x180708360")]
	public void EnterWareHouse()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)45), canvasUp, num != 0);
	}

	// Token: 0x06002DEC RID: 11756 RVA: 0x000FB964 File Offset: 0x000F9B64
	[Token(Token = "0x6002DEC")]
	[Address(RVA = "0x708110", Offset = "0x706710", VA = "0x180708110")]
	public void EnterStore()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)46), canvasUp, num != 0);
	}

	// Token: 0x06002DED RID: 11757 RVA: 0x000FB994 File Offset: 0x000F9B94
	[Token(Token = "0x6002DED")]
	[Address(RVA = "0x707950", Offset = "0x705F50", VA = "0x180707950")]
	public void EnterEquipment()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)49), canvasUp, num != 0);
	}

	// Token: 0x06002DEE RID: 11758 RVA: 0x000FB9C4 File Offset: 0x000F9BC4
	[Token(Token = "0x6002DEE")]
	[Address(RVA = "0x7082E0", Offset = "0x7068E0", VA = "0x1807082E0")]
	public void EnterUpgrade()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)50), canvasUp, num != 0);
	}

	// Token: 0x06002DEF RID: 11759 RVA: 0x000FB9F4 File Offset: 0x000F9BF4
	[Token(Token = "0x6002DEF")]
	[Address(RVA = "0x68ECA0", Offset = "0x68D2A0", VA = "0x18068ECA0")]
	public void Back()
	{
		UIMgr.EnterMainMenu();
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002DF0 RID: 11760 RVA: 0x000FBA10 File Offset: 0x000F9C10
	[Token(Token = "0x6002DF0")]
	[Address(RVA = "0x707FC0", Offset = "0x7065C0", VA = "0x180707FC0")]
	public void EnterNormalLevel()
	{
		GameAPP.config.difficulty = (int)((ulong)3L);
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)47), canvasUp, num != 0);
	}

	// Token: 0x06002DF1 RID: 11761 RVA: 0x000FBA4C File Offset: 0x000F9C4C
	[Token(Token = "0x6002DF1")]
	[Address(RVA = "0x707D20", Offset = "0x706320", VA = "0x180707D20")]
	public void EnterHardLevel()
	{
		GameAPP.config.difficulty = (int)((ulong)4L);
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)47), canvasUp, num != 0);
	}

	// Token: 0x06002DF2 RID: 11762 RVA: 0x000FBA8C File Offset: 0x000F9C8C
	[Token(Token = "0x6002DF2")]
	[Address(RVA = "0x707E70", Offset = "0x706470", VA = "0x180707E70")]
	public void EnterHellLevel()
	{
		GameAPP.config.difficulty = (int)((ulong)5L);
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)47), canvasUp, num != 0);
	}

	// Token: 0x06002DF3 RID: 11763 RVA: 0x000FBACC File Offset: 0x000F9CCC
	[Token(Token = "0x6002DF3")]
	[Address(RVA = "0x708190", Offset = "0x706790", VA = "0x180708190")]
	public void EnterUpgradeLevel()
	{
		GameAPP.config.difficulty = (int)((ulong)5L);
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)47), canvasUp, num != 0);
	}

	// Token: 0x06002DF4 RID: 11764 RVA: 0x000FBB0C File Offset: 0x000F9D0C
	[Token(Token = "0x6002DF4")]
	[Address(RVA = "0x7079D0", Offset = "0x705FD0", VA = "0x1807079D0")]
	public void EnterFateLevel()
	{
		GameAPP.config.difficulty = (int)((ulong)5L);
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)47), canvasUp, num != 0);
	}

	// Token: 0x06002DF5 RID: 11765 RVA: 0x000FBB4C File Offset: 0x000F9D4C
	[Token(Token = "0x6002DF5")]
	[Address(RVA = "0x708510", Offset = "0x706B10", VA = "0x180708510")]
	public void TryReset()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)47), canvasUp, num != 0);
	}

	// Token: 0x06002DF6 RID: 11766 RVA: 0x000FBB80 File Offset: 0x000F9D80
	[Token(Token = "0x6002DF6")]
	[Address(RVA = "0x707830", Offset = "0x705E30", VA = "0x180707830")]
	public void AutoCollect()
	{
		TreasureData.autoCollect = "{il2cpp field on {'constant10' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x30}" == (ulong)0L;
		TextMeshProUGUI textMeshProUGUI = this.autoCollectText;
		throw new NullReferenceException();
	}

	// Token: 0x06002DF7 RID: 11767 RVA: 0x000FBBAC File Offset: 0x000F9DAC
	[Token(Token = "0x6002DF7")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public TreasureMainMenu()
	{
	}

	// Token: 0x04001BD9 RID: 7129
	[Token(Token = "0x4001BD9")]
	public static TreasureMainMenu Instance;

	// Token: 0x04001BDA RID: 7130
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001BDA")]
	public TextMeshProUGUI mapText;

	// Token: 0x04001BDB RID: 7131
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001BDB")]
	public TextMeshProUGUI autoCollectText;
}
