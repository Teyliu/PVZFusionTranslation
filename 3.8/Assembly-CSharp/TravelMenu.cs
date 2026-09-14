using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000883 RID: 2179
[Token(Token = "0x2000883")]
public class TravelMenu : BaseMenu
{
	// Token: 0x170001C0 RID: 448
	// (get) Token: 0x06002C7F RID: 11391 RVA: 0x000F5358 File Offset: 0x000F3558
	[Token(Token = "0x170001C0")]
	public static TravelMenu.TravelConfig Config
	{
		[Token(Token = "0x6002C7F")]
		[Address(RVA = "0x688940", Offset = "0x686F40", VA = "0x180688940")]
		get
		{
			TravelMenu._config = new TravelMenu.TravelConfig
			{
				routeBossType = (ZombieType)((ulong)212L)
			};
			return TravelMenu._config;
		}
	}

	// Token: 0x06002C80 RID: 11392 RVA: 0x000F538C File Offset: 0x000F358C
	[Token(Token = "0x6002C80")]
	[Address(RVA = "0x688340", Offset = "0x686940", VA = "0x180688340", Slot = "6")]
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

	// Token: 0x06002C81 RID: 11393 RVA: 0x000F53CC File Offset: 0x000F35CC
	[Token(Token = "0x6002C81")]
	[Address(RVA = "0x688900", Offset = "0x686F00", VA = "0x180688900")]
	private void Update()
	{
		if (this.curstomPage.activeSelf)
		{
			this.SetUp();
			return;
		}
	}

	// Token: 0x06002C82 RID: 11394 RVA: 0x000F53F4 File Offset: 0x000F35F4
	[Token(Token = "0x6002C82")]
	[Address(RVA = "0x6885E0", Offset = "0x686BE0", VA = "0x1806885E0")]
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

	// Token: 0x06002C83 RID: 11395 RVA: 0x000F54BC File Offset: 0x000F36BC
	[Token(Token = "0x6002C83")]
	[Address(RVA = "0x688410", Offset = "0x686A10", VA = "0x180688410")]
	public void ChangePage()
	{
		GameObject gameObject = this.curstomPage;
		bool activeSelf = gameObject.activeSelf;
		gameObject.SetActive(activeSelf);
		GameObject gameObject2 = this.presetPage;
		bool activeSelf2 = gameObject2.activeSelf;
		gameObject2.SetActive(activeSelf2);
	}

	// Token: 0x06002C84 RID: 11396 RVA: 0x000F54FC File Offset: 0x000F36FC
	[Token(Token = "0x6002C84")]
	[Address(RVA = "0x688480", Offset = "0x686A80", VA = "0x180688480")]
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
		int num2 = 0;
		instance.ShowText("输入不合法", 3f, num2 != 0);
	}

	// Token: 0x06002C85 RID: 11397 RVA: 0x000F5574 File Offset: 0x000F3774
	[Token(Token = "0x6002C85")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public TravelMenu()
	{
	}

	// Token: 0x04001A9A RID: 6810
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001A9A")]
	public ToggleGroup routeGroups;

	// Token: 0x04001A9B RID: 6811
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001A9B")]
	public ToggleGroup difficultyGroups;

	// Token: 0x04001A9C RID: 6812
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001A9C")]
	public ToggleGroup processGroups;

	// Token: 0x04001A9D RID: 6813
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001A9D")]
	public GameObject presetPage;

	// Token: 0x04001A9E RID: 6814
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001A9E")]
	public GameObject curstomPage;

	// Token: 0x04001A9F RID: 6815
	[Token(Token = "0x4001A9F")]
	private static TravelMenu.TravelConfig _config;

	// Token: 0x04001AA0 RID: 6816
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001AA0")]
	[SerializeField]
	private TravelMenu.TravelConfig config;

	// Token: 0x04001AA1 RID: 6817
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001AA1")]
	private bool inputVaild;

	// Token: 0x02000884 RID: 2180
	[Token(Token = "0x2000884")]
	[Serializable]
	public class TravelConfig
	{
		// Token: 0x06002C87 RID: 11399 RVA: 0x000F561C File Offset: 0x000F381C
		[Token(Token = "0x6002C87")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public TravelConfig()
		{
		}

		// Token: 0x04001AA2 RID: 6818
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001AA2")]
		public ZombieType routeBossType;

		// Token: 0x04001AA3 RID: 6819
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4001AA3")]
		public TravelDifficulty travelDifficulty;

		// Token: 0x04001AA4 RID: 6820
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001AA4")]
		public TravelProcess travelProcess;
	}
}
