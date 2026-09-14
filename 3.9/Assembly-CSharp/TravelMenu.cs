using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020008BF RID: 2239
[Token(Token = "0x20008BF")]
public class TravelMenu : BaseMenu
{
	// Token: 0x17000208 RID: 520
	// (get) Token: 0x06002DB1 RID: 11697 RVA: 0x000F9F54 File Offset: 0x000F8154
	[Token(Token = "0x17000208")]
	public static TravelMenu.TravelConfig Config
	{
		[Token(Token = "0x6002DB1")]
		[Address(RVA = "0x701F60", Offset = "0x700560", VA = "0x180701F60")]
		get
		{
			TravelMenu._config = new TravelMenu.TravelConfig
			{
				routeBossType = (ZombieType)((ulong)212L)
			};
			return TravelMenu._config;
		}
	}

	// Token: 0x06002DB2 RID: 11698 RVA: 0x000F9F88 File Offset: 0x000F8188
	[Token(Token = "0x6002DB2")]
	[Address(RVA = "0x701950", Offset = "0x6FFF50", VA = "0x180701950", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		TravelMenu._config = new TravelMenu.TravelConfig
		{
			routeBossType = (ZombieType)((ulong)212L)
		};
		TravelMenu.TravelConfig travelConfig = TravelMenu._config;
		this.config = travelConfig;
		throw new NullReferenceException();
	}

	// Token: 0x06002DB3 RID: 11699 RVA: 0x000F9FC8 File Offset: 0x000F81C8
	[Token(Token = "0x6002DB3")]
	[Address(RVA = "0x701F20", Offset = "0x700520", VA = "0x180701F20")]
	private void Update()
	{
		if (this.curstomPage.activeSelf)
		{
			this.SetUp();
			return;
		}
	}

	// Token: 0x06002DB4 RID: 11700 RVA: 0x000F9FF0 File Offset: 0x000F81F0
	[Token(Token = "0x6002DB4")]
	[Address(RVA = "0x701C00", Offset = "0x700200", VA = "0x180701C00")]
	public void SetUp()
	{
		ToggleGroup toggleGroup = this.routeGroups;
		int num = 0;
		this.inputVaild = num != 0;
		string name = toggleGroup.GetFirstActiveToggle().transform.parent.name;
		string name2 = this.difficultyGroups.GetFirstActiveToggle().transform.parent.name;
		string name3 = this.processGroups.GetFirstActiveToggle().transform.parent.name;
		if (!Enum.TryParse<ZombieType>(name, (ZombieType)num))
		{
			this.inputVaild = true;
		}
		this.config.routeBossType = (ZombieType)num;
		if (!Enum.TryParse<TravelDifficulty>(name2, (TravelDifficulty)num))
		{
			this.inputVaild = true;
		}
		this.config.travelDifficulty = (TravelDifficulty)num;
		if (!Enum.TryParse<TravelProcess>(name3, (TravelProcess)num))
		{
			this.inputVaild = true;
			return;
		}
		this.config.travelProcess = (TravelProcess)num;
		throw new NullReferenceException();
	}

	// Token: 0x06002DB5 RID: 11701 RVA: 0x000FA0B8 File Offset: 0x000F82B8
	[Token(Token = "0x6002DB5")]
	[Address(RVA = "0x701A20", Offset = "0x700020", VA = "0x180701A20")]
	public void ChangePage()
	{
		GameObject gameObject = this.curstomPage;
		bool activeSelf = gameObject.activeSelf;
		gameObject.SetActive(activeSelf);
		GameObject gameObject2 = this.presetPage;
		bool activeSelf2 = gameObject2.activeSelf;
		gameObject2.SetActive(activeSelf2);
	}

	// Token: 0x06002DB6 RID: 11702 RVA: 0x000FA0F8 File Offset: 0x000F82F8
	[Token(Token = "0x6002DB6")]
	[Address(RVA = "0x701A90", Offset = "0x700090", VA = "0x180701A90")]
	public void EnterGame()
	{
		if (!this.inputVaild)
		{
			int num = 0;
			SaveMenu.InitSaveMenu((SurvivalLevel)((uint)40), num != 0);
			UnityEvent actionOnCreateNewLevel = SaveMenu.Instance.actionOnCreateNewLevel;
			UnityAction unityAction = delegate
			{
				TravelMgr instance2 = TravelMgr.Instance;
				TravelMenu.TravelConfig travelConfig = this.config;
				TravelData data = instance2.data;
				ZombieType routeBossType = travelConfig.routeBossType;
				data.routeBossType = routeBossType;
				TravelMgr instance3 = TravelMgr.Instance;
				TravelMenu.TravelConfig travelConfig2 = this.config;
				TravelData data2 = instance3.data;
				TravelDifficulty travelDifficulty = travelConfig2.travelDifficulty;
				data2.travelDifficulty = travelDifficulty;
				TravelMgr instance4 = TravelMgr.Instance;
				TravelMenu.TravelConfig travelConfig3 = this.config;
				TravelData data3 = instance4.data;
				TravelProcess travelProcess = travelConfig3.travelProcess;
				data3.travelProcess = travelProcess;
			};
			actionOnCreateNewLevel.AddListener(unityAction);
			return;
		}
		GameAPP.PlaySound(26, 0.5f, 1f);
		InGameText instance = InGameText.Instance;
	}

	// Token: 0x06002DB7 RID: 11703 RVA: 0x000FA15C File Offset: 0x000F835C
	[Token(Token = "0x6002DB7")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public TravelMenu()
	{
	}

	// Token: 0x04001B88 RID: 7048
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001B88")]
	public ToggleGroup routeGroups;

	// Token: 0x04001B89 RID: 7049
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001B89")]
	public ToggleGroup difficultyGroups;

	// Token: 0x04001B8A RID: 7050
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001B8A")]
	public ToggleGroup processGroups;

	// Token: 0x04001B8B RID: 7051
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001B8B")]
	public GameObject presetPage;

	// Token: 0x04001B8C RID: 7052
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001B8C")]
	public GameObject curstomPage;

	// Token: 0x04001B8D RID: 7053
	[Token(Token = "0x4001B8D")]
	private static TravelMenu.TravelConfig _config;

	// Token: 0x04001B8E RID: 7054
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001B8E")]
	[SerializeField]
	private TravelMenu.TravelConfig config;

	// Token: 0x04001B8F RID: 7055
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001B8F")]
	private bool inputVaild;

	// Token: 0x020008C0 RID: 2240
	[Token(Token = "0x20008C0")]
	[Serializable]
	public class TravelConfig
	{
		// Token: 0x06002DB9 RID: 11705 RVA: 0x000FA204 File Offset: 0x000F8404
		[Token(Token = "0x6002DB9")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public TravelConfig()
		{
		}

		// Token: 0x04001B90 RID: 7056
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001B90")]
		public ZombieType routeBossType;

		// Token: 0x04001B91 RID: 7057
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4001B91")]
		public TravelDifficulty travelDifficulty;

		// Token: 0x04001B92 RID: 7058
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001B92")]
		public TravelProcess travelProcess;
	}
}
