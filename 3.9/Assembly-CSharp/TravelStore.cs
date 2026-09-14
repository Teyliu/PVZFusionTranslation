using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x020008C3 RID: 2243
[Token(Token = "0x20008C3")]
public class TravelStore : BaseMenu
{
	// Token: 0x06002DBA RID: 11706 RVA: 0x000FA218 File Offset: 0x000F8418
	[Token(Token = "0x6002DBA")]
	[Address(RVA = "0x703250", Offset = "0x701850", VA = "0x180703250", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		TravelStore.Instance = this;
	}

	// Token: 0x06002DBB RID: 11707 RVA: 0x000FA234 File Offset: 0x000F8434
	[Token(Token = "0x6002DBB")]
	[Address(RVA = "0x704DE0", Offset = "0x7033E0", VA = "0x180704DE0")]
	private void Start()
	{
		this.InitUnlockPool();
		this.InitBuffPoolForStore();
		this.RefreshBuff();
		TravelMgr.Instance.data.usePoint = false;
		GameObject gameObject = this.investTextContainer;
		bool invest = TravelMgr.Instance.data.Invest;
		gameObject.SetActive(invest);
		this.UpdateInvestText();
	}

	// Token: 0x06002DBC RID: 11708 RVA: 0x000FA294 File Offset: 0x000F8494
	[Token(Token = "0x6002DBC")]
	[Address(RVA = "0x7036F0", Offset = "0x701CF0", VA = "0x1807036F0")]
	private void InitBuffPool()
	{
		this.InitUnlockPool();
		this.InitBuffPoolForStore();
	}

	// Token: 0x06002DBD RID: 11709 RVA: 0x000FA2B0 File Offset: 0x000F84B0
	[Token(Token = "0x6002DBD")]
	[Address(RVA = "0x703710", Offset = "0x701D10", VA = "0x180703710")]
	private void InitUnlockPool()
	{
		List<TravelUnlocks> unlocksPool = TravelMgr.Instance.GetUnlocksPool();
		this.unlockPool = unlocksPool;
		throw new NullReferenceException();
	}

	// Token: 0x06002DBE RID: 11710 RVA: 0x000FA2D8 File Offset: 0x000F84D8
	[Token(Token = "0x6002DBE")]
	[Address(RVA = "0x703600", Offset = "0x701C00", VA = "0x180703600")]
	private void InitBuffPoolForStore()
	{
		List<object> list = this.pool;
		int size = list._size;
		list._size = (int)((ulong)0L);
		if (size > 0)
		{
		}
		List<object> list2 = this.pool;
		List<AdvBuff> advancedBuffPool = TravelMgr.Instance.GetAdvancedBuffPool(true);
		list2.AddRange(advancedBuffPool);
		List<object> list3 = this.pool;
		List<UltiBuff> ultiBuffPool = TravelMgr.Instance.GetUltiBuffPool();
		list3.AddRange(ultiBuffPool);
	}

	// Token: 0x06002DBF RID: 11711 RVA: 0x000FA348 File Offset: 0x000F8548
	[Token(Token = "0x6002DBF")]
	[Address(RVA = "0x704FE0", Offset = "0x7035E0", VA = "0x180704FE0")]
	private void Update()
	{
		ulong num;
		do
		{
			List<TextMeshProUGUI> list = this.pointText;
			bool flag;
			if (flag)
			{
				Board instance = Board.Instance;
				string text = string.Format("剩余积分：{0}点", instance);
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06002DC0 RID: 11712 RVA: 0x000FA390 File Offset: 0x000F8590
	[Token(Token = "0x6002DC0")]
	[Address(RVA = "0x704EB0", Offset = "0x7034B0", VA = "0x180704EB0")]
	public void UpdateInvestText()
	{
		TravelMgr.Instance.UpdateSynergies();
		string text = SynergyDisplay.GetText("black");
		this.investText.text = text;
		TextMeshProUGUI textMeshProUGUI = this.investTextshadow;
		string text2 = InGameText.RemoveRichTextTags(text);
		textMeshProUGUI.text = text2;
		TextMeshProUGUI textMeshProUGUI2 = this.investText;
		RectTransform rectTransform = this.textContent;
		float preferredHeight = textMeshProUGUI2.preferredHeight;
	}

	// Token: 0x06002DC1 RID: 11713 RVA: 0x000FA3F8 File Offset: 0x000F85F8
	[Token(Token = "0x6002DC1")]
	[Address(RVA = "0x7032B0", Offset = "0x7018B0", VA = "0x1807032B0")]
	public void Exit()
	{
		for (;;)
		{
			base.PopMenu();
			bool flag;
			if (flag && !this.buy)
			{
				TravelData data = TravelMgr.Instance.data;
			}
			if (!global::Lawnf.TravelHell())
			{
				break;
			}
			if (!TravelMgr.Instance.data.Invest)
			{
				goto Block_3;
			}
			UIResourcesLoader uimanager = GameAPP.UIManager;
			if (TravelMgr.Instance.data.invest_challenge)
			{
			}
			uint num;
			if (Board.Instance.theCurrentSurvivalRound < (int)num)
			{
				return;
			}
		}
		Time.timeScale = GameAPP.config.gameSpeed;
		Board.Instance.TravelNextRound();
		return;
		Block_3:
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
	}

	// Token: 0x06002DC2 RID: 11714 RVA: 0x000FA49C File Offset: 0x000F869C
	[Token(Token = "0x6002DC2")]
	[Address(RVA = "0x703F40", Offset = "0x702540", VA = "0x180703F40")]
	public void SelectBuff(TravelStoreWindow window)
	{
		if (window.canBuy)
		{
			if (!window.sold)
			{
				Board instance = Board.Instance;
				float thePoints = instance.thePoints;
				GameAPP.PlaySound(26, 0.5f, 1f);
				InGameText instance2 = InGameText.Instance;
				return;
			}
			GameAPP.PlaySound(26, 0.5f, 1f);
			InGameText instance3 = InGameText.Instance;
		}
		GameAPP.PlaySound(26, 0.5f, 1f);
		InGameText instance4 = InGameText.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x06002DC3 RID: 11715 RVA: 0x000FA5D8 File Offset: 0x000F87D8
	[Token(Token = "0x6002DC3")]
	[Address(RVA = "0x703A30", Offset = "0x702030", VA = "0x180703A30")]
	public void RefreshBuff()
	{
		if (TravelMgr.Instance.data.travelProcess == TravelProcess.Fast)
		{
		}
		bool flag = global::Lawnf.TravelCurse();
		int num = this.refreshCount;
		int num2 = num + 1;
		this.refreshCount = num2;
		int num3 = num - 1;
		this.refreshCount = num3;
		TravelData data = TravelMgr.Instance.data;
		InGameText instance = InGameText.Instance;
		uint num4;
		GameAPP.PlaySound((int)num4, 0.5f, 1f);
	}

	// Token: 0x06002DC4 RID: 11716 RVA: 0x000FA730 File Offset: 0x000F8930
	[Token(Token = "0x6002DC4")]
	[Address(RVA = "0x704680", Offset = "0x702C80", VA = "0x180704680")]
	private void SetBuyPlant()
	{
		ulong num5;
		do
		{
			int num = 0;
			int size = this.unlockPool._size;
			List<TravelStoreWindow> list = this.buyPlantWindows;
			this.InitUnlockPool();
			List<TravelStoreWindow> list2 = this.buyPlantWindows;
			bool flag;
			if (flag)
			{
				int num2 = this.unlockPool._size;
				int num3 = global::UnityEngine.Random.Range(0, num2);
				List<TravelUnlocks> list3 = this.unlockPool;
				num2 = num3;
				int num4 = list3[num2];
				List<TravelUnlocks> list4 = this.unlockPool;
				num2 = num3;
				list4.RemoveAt(num2);
				this.SetCost(num);
			}
		}
		while (num5 != (ulong)0L);
	}

	// Token: 0x06002DC5 RID: 11717 RVA: 0x000FA7E0 File Offset: 0x000F89E0
	[Token(Token = "0x6002DC5")]
	[Address(RVA = "0x704430", Offset = "0x702A30", VA = "0x180704430")]
	private void SetBuyBuff()
	{
		ulong num4;
		do
		{
			int num = 0;
			int size = this.pool._size;
			List<TravelStoreWindow> list = this.buyBuffWindows;
			this.InitBuffPoolForStore();
			List<TravelStoreWindow> list2 = this.buyBuffWindows;
			bool flag;
			if (flag)
			{
				int num2 = this.pool._size;
				int num3 = global::UnityEngine.Random.Range(0, num2);
				List<object> list3 = this.pool;
				num2 = num3;
				object obj = list3[num2];
				this.pool.RemoveAt(num3);
				this.SetCost(num);
			}
		}
		while (num4 != (ulong)0L);
	}

	// Token: 0x06002DC6 RID: 11718 RVA: 0x000FA888 File Offset: 0x000F8A88
	[Token(Token = "0x6002DC6")]
	[Address(RVA = "0x704900", Offset = "0x702F00", VA = "0x180704900")]
	private void SetCost(TravelStoreWindow window)
	{
		TravelData data;
		for (;;)
		{
			object buff = window.buff;
			if (buff == 0)
			{
				goto IL_0029;
			}
			if (buff != 0)
			{
				break;
			}
			window.cost = (int)((ulong)4294964296L);
			window.cost = (int)((ulong)5000L);
			data = TravelMgr.Instance.data;
			if (data.Invest)
			{
				goto Block_4;
			}
		}
		TravelData data2 = TravelMgr.Instance.data;
		uint num;
		window.cost = (int)num;
		IL_0029:
		if (global::Lawnf.TravelCurse() || TravelMgr.Instance.data.invest_challenge)
		{
		}
		if (TravelMgr.Instance.data.travelProcess == TravelProcess.Fast)
		{
			int num2 = window.cost;
			num2 += window;
			window.cost = num2;
		}
		int cost = window.cost;
		string text = string.Format("{0}分", cost);
		window.canBuy = true;
		return;
		Block_4:
		List<UltiBuff> ultiBuffs_lv = data.ultiBuffs_lv2;
		window.cost = (int)((ulong)5000L);
		bool invest = TravelMgr.Instance.data.Invest;
		if (invest)
		{
			window.cost = (int)((ulong)3000L);
		}
		if (invest <= true)
		{
		}
		if (invest && invest)
		{
			if (invest)
			{
				if (invest && invest)
				{
					goto IL_0160;
				}
				window.cost = (int)((ulong)10000L);
				if (invest <= true)
				{
					window.cost = (int)((ulong)16000L);
					window.cost = (int)((ulong)20000L);
				}
			}
			TravelMgr instance = TravelMgr.Instance;
			bool flag;
			while (!flag)
			{
			}
		}
		IL_0160:
		window.cost = (int)((ulong)15000L);
		window.cost = (int)((ulong)8000L);
		window.canBuy = false;
	}

	// Token: 0x06002DC7 RID: 11719 RVA: 0x000FAA24 File Offset: 0x000F8C24
	[Token(Token = "0x6002DC7")]
	[Address(RVA = "0x7038E0", Offset = "0x701EE0", VA = "0x1807038E0", Slot = "10")]
	public override void OnHide()
	{
		ulong num;
		do
		{
			List<SpriteRenderer> sprites = global::Core.Lawnf.GetSprites(base.gameObject);
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06002DC8 RID: 11720 RVA: 0x000FAA58 File Offset: 0x000F8C58
	[Token(Token = "0x6002DC8")]
	[Address(RVA = "0x703790", Offset = "0x701D90", VA = "0x180703790", Slot = "9")]
	public override void OnBackEnter()
	{
		ulong num;
		do
		{
			List<SpriteRenderer> sprites = global::Core.Lawnf.GetSprites(base.gameObject);
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06002DC9 RID: 11721 RVA: 0x000FAA88 File Offset: 0x000F8C88
	[Token(Token = "0x6002DC9")]
	[Address(RVA = "0x705190", Offset = "0x703790", VA = "0x180705190")]
	public TravelStore()
	{
		List<TravelStoreWindow> list = new List();
		this.buyPlantWindows = list;
		List<TravelStoreWindow> list2 = new List();
		this.buyBuffWindows = list2;
		List<TextMeshProUGUI> list3 = new List();
		this.pointText = list3;
		List<TextMeshProUGUI> list4 = new List();
		this.refreshText = list4;
		List<TravelUnlocks> list5 = new List();
		this.unlockPool = list5;
		List<object> list6 = new List();
		this.pool = list6;
		base..ctor();
	}

	// Token: 0x04001B9D RID: 7069
	[Token(Token = "0x4001B9D")]
	public static TravelStore Instance;

	// Token: 0x04001B9E RID: 7070
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001B9E")]
	public List<TravelStoreWindow> buyPlantWindows;

	// Token: 0x04001B9F RID: 7071
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001B9F")]
	public List<TravelStoreWindow> buyBuffWindows;

	// Token: 0x04001BA0 RID: 7072
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001BA0")]
	public List<TextMeshProUGUI> pointText;

	// Token: 0x04001BA1 RID: 7073
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001BA1")]
	public List<TextMeshProUGUI> refreshText;

	// Token: 0x04001BA2 RID: 7074
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001BA2")]
	public GameObject investTextContainer;

	// Token: 0x04001BA3 RID: 7075
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001BA3")]
	public TextMeshProUGUI investText;

	// Token: 0x04001BA4 RID: 7076
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001BA4")]
	public TextMeshProUGUI investTextshadow;

	// Token: 0x04001BA5 RID: 7077
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001BA5")]
	public RectTransform textContent;

	// Token: 0x04001BA6 RID: 7078
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001BA6")]
	[SerializeField]
	private int refreshCount;

	// Token: 0x04001BA7 RID: 7079
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4001BA7")]
	private bool buy;

	// Token: 0x04001BA8 RID: 7080
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001BA8")]
	private List<TravelUnlocks> unlockPool;

	// Token: 0x04001BA9 RID: 7081
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001BA9")]
	private List<object> pool;
}
