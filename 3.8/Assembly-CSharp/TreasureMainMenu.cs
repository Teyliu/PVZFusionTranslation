using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000891 RID: 2193
[Token(Token = "0x2000891")]
public class TreasureMainMenu : BaseMenu
{
	// Token: 0x06002CB5 RID: 11445 RVA: 0x000F6C90 File Offset: 0x000F4E90
	[Token(Token = "0x6002CB5")]
	[Address(RVA = "0x68E240", Offset = "0x68C840", VA = "0x18068E240", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		TreasureMainMenu.Instance = this;
	}

	// Token: 0x06002CB6 RID: 11446 RVA: 0x000F6CAC File Offset: 0x000F4EAC
	[Token(Token = "0x6002CB6")]
	[Address(RVA = "0x68EF40", Offset = "0x68D540", VA = "0x18068EF40")]
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

	// Token: 0x06002CB7 RID: 11447 RVA: 0x000F6D10 File Offset: 0x000F4F10
	[Token(Token = "0x6002CB7")]
	[Address(RVA = "0x68E470", Offset = "0x68CA70", VA = "0x18068E470")]
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

	// Token: 0x06002CB8 RID: 11448 RVA: 0x000F6D7C File Offset: 0x000F4F7C
	[Token(Token = "0x6002CB8")]
	[Address(RVA = "0x68ED30", Offset = "0x68D330", VA = "0x18068ED30")]
	public void SetSceneType(string name)
	{
		ulong num;
		if (Enum.TryParse(typeof(SceneType), name, num))
		{
			TreasureData.levelSceneType = (SceneType)num;
		}
	}

	// Token: 0x06002CB9 RID: 11449 RVA: 0x000F6DAC File Offset: 0x000F4FAC
	[Token(Token = "0x6002CB9")]
	[Address(RVA = "0x68ECB0", Offset = "0x68D2B0", VA = "0x18068ECB0")]
	public void EnterWareHouse()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)45), canvasUp, num != 0);
	}

	// Token: 0x06002CBA RID: 11450 RVA: 0x000F6DDC File Offset: 0x000F4FDC
	[Token(Token = "0x6002CBA")]
	[Address(RVA = "0x68EA60", Offset = "0x68D060", VA = "0x18068EA60")]
	public void EnterStore()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)46), canvasUp, num != 0);
	}

	// Token: 0x06002CBB RID: 11451 RVA: 0x000F6E0C File Offset: 0x000F500C
	[Token(Token = "0x6002CBB")]
	[Address(RVA = "0x68E2A0", Offset = "0x68C8A0", VA = "0x18068E2A0")]
	public void EnterEquipment()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)49), canvasUp, num != 0);
	}

	// Token: 0x06002CBC RID: 11452 RVA: 0x000F6E3C File Offset: 0x000F503C
	[Token(Token = "0x6002CBC")]
	[Address(RVA = "0x68EC30", Offset = "0x68D230", VA = "0x18068EC30")]
	public void EnterUpgrade()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)50), canvasUp, num != 0);
	}

	// Token: 0x06002CBD RID: 11453 RVA: 0x000F6E6C File Offset: 0x000F506C
	[Token(Token = "0x6002CBD")]
	[Address(RVA = "0x62B3A0", Offset = "0x6299A0", VA = "0x18062B3A0")]
	public void Back()
	{
		UIMgr.EnterMainMenu();
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002CBE RID: 11454 RVA: 0x000F6E88 File Offset: 0x000F5088
	[Token(Token = "0x6002CBE")]
	[Address(RVA = "0x68E910", Offset = "0x68CF10", VA = "0x18068E910")]
	public void EnterNormalLevel()
	{
		GameAPP.config.difficulty = (int)((ulong)3L);
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)47), canvasUp, num != 0);
	}

	// Token: 0x06002CBF RID: 11455 RVA: 0x000F6EC4 File Offset: 0x000F50C4
	[Token(Token = "0x6002CBF")]
	[Address(RVA = "0x68E670", Offset = "0x68CC70", VA = "0x18068E670")]
	public void EnterHardLevel()
	{
		GameAPP.config.difficulty = (int)((ulong)4L);
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)47), canvasUp, num != 0);
	}

	// Token: 0x06002CC0 RID: 11456 RVA: 0x000F6F04 File Offset: 0x000F5104
	[Token(Token = "0x6002CC0")]
	[Address(RVA = "0x68E7C0", Offset = "0x68CDC0", VA = "0x18068E7C0")]
	public void EnterHellLevel()
	{
		GameAPP.config.difficulty = (int)((ulong)5L);
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)47), canvasUp, num != 0);
	}

	// Token: 0x06002CC1 RID: 11457 RVA: 0x000F6F44 File Offset: 0x000F5144
	[Token(Token = "0x6002CC1")]
	[Address(RVA = "0x68EAE0", Offset = "0x68D0E0", VA = "0x18068EAE0")]
	public void EnterUpgradeLevel()
	{
		GameAPP.config.difficulty = (int)((ulong)5L);
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)47), canvasUp, num != 0);
	}

	// Token: 0x06002CC2 RID: 11458 RVA: 0x000F6F84 File Offset: 0x000F5184
	[Token(Token = "0x6002CC2")]
	[Address(RVA = "0x68E320", Offset = "0x68C920", VA = "0x18068E320")]
	public void EnterFateLevel()
	{
		GameAPP.config.difficulty = (int)((ulong)5L);
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)47), canvasUp, num != 0);
	}

	// Token: 0x06002CC3 RID: 11459 RVA: 0x000F6FC4 File Offset: 0x000F51C4
	[Token(Token = "0x6002CC3")]
	[Address(RVA = "0x68EE60", Offset = "0x68D460", VA = "0x18068EE60")]
	public void TryReset()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)47), canvasUp, num != 0);
	}

	// Token: 0x06002CC4 RID: 11460 RVA: 0x000F6FF8 File Offset: 0x000F51F8
	[Token(Token = "0x6002CC4")]
	[Address(RVA = "0x68E180", Offset = "0x68C780", VA = "0x18068E180")]
	public void AutoCollect()
	{
		TreasureData.autoCollect = "{il2cpp field on {'constant10' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x30}" == (ulong)0L;
		TextMeshProUGUI textMeshProUGUI = this.autoCollectText;
		throw new NullReferenceException();
	}

	// Token: 0x06002CC5 RID: 11461 RVA: 0x000F7024 File Offset: 0x000F5224
	[Token(Token = "0x6002CC5")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public TreasureMainMenu()
	{
	}

	// Token: 0x04001AEB RID: 6891
	[Token(Token = "0x4001AEB")]
	public static TreasureMainMenu Instance;

	// Token: 0x04001AEC RID: 6892
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001AEC")]
	public TextMeshProUGUI mapText;

	// Token: 0x04001AED RID: 6893
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001AED")]
	public TextMeshProUGUI autoCollectText;
}
