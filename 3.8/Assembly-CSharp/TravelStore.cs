using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x02000887 RID: 2183
[Token(Token = "0x2000887")]
public class TravelStore : BaseMenu
{
	// Token: 0x06002C88 RID: 11400 RVA: 0x000F5630 File Offset: 0x000F3830
	[Token(Token = "0x6002C88")]
	[Address(RVA = "0x689C30", Offset = "0x688230", VA = "0x180689C30", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		TravelStore.Instance = this;
	}

	// Token: 0x06002C89 RID: 11401 RVA: 0x000F564C File Offset: 0x000F384C
	[Token(Token = "0x6002C89")]
	[Address(RVA = "0x68B760", Offset = "0x689D60", VA = "0x18068B760")]
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

	// Token: 0x06002C8A RID: 11402 RVA: 0x000F56AC File Offset: 0x000F38AC
	[Token(Token = "0x6002C8A")]
	[Address(RVA = "0x68A0D0", Offset = "0x6886D0", VA = "0x18068A0D0")]
	private void InitBuffPool()
	{
		this.InitUnlockPool();
		this.InitBuffPoolForStore();
	}

	// Token: 0x06002C8B RID: 11403 RVA: 0x000F56C8 File Offset: 0x000F38C8
	[Token(Token = "0x6002C8B")]
	[Address(RVA = "0x68A0F0", Offset = "0x6886F0", VA = "0x18068A0F0")]
	private void InitUnlockPool()
	{
		List<TravelUnlocks> unlocksPool = TravelMgr.Instance.GetUnlocksPool();
		this.unlockPool = unlocksPool;
		throw new NullReferenceException();
	}

	// Token: 0x06002C8C RID: 11404 RVA: 0x000F56F0 File Offset: 0x000F38F0
	[Token(Token = "0x6002C8C")]
	[Address(RVA = "0x689FE0", Offset = "0x6885E0", VA = "0x180689FE0")]
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

	// Token: 0x06002C8D RID: 11405 RVA: 0x000F5760 File Offset: 0x000F3960
	[Token(Token = "0x6002C8D")]
	[Address(RVA = "0x68B960", Offset = "0x689F60", VA = "0x18068B960")]
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

	// Token: 0x06002C8E RID: 11406 RVA: 0x000F57A8 File Offset: 0x000F39A8
	[Token(Token = "0x6002C8E")]
	[Address(RVA = "0x68B830", Offset = "0x689E30", VA = "0x18068B830")]
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

	// Token: 0x06002C8F RID: 11407 RVA: 0x000F5810 File Offset: 0x000F3A10
	[Token(Token = "0x6002C8F")]
	[Address(RVA = "0x689C90", Offset = "0x688290", VA = "0x180689C90")]
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

	// Token: 0x06002C90 RID: 11408 RVA: 0x000F58B4 File Offset: 0x000F3AB4
	[Token(Token = "0x6002C90")]
	[Address(RVA = "0x68A900", Offset = "0x688F00", VA = "0x18068A900")]
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
				int num = 0;
				instance2.ShowText("积分不足", 3f, num != 0);
				return;
			}
			GameAPP.PlaySound(26, 0.5f, 1f);
			InGameText instance3 = InGameText.Instance;
		}
		GameAPP.PlaySound(26, 0.5f, 1f);
		InGameText instance4 = InGameText.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x06002C91 RID: 11409 RVA: 0x000F5A1C File Offset: 0x000F3C1C
	[Token(Token = "0x6002C91")]
	[Address(RVA = "0x68A410", Offset = "0x688A10", VA = "0x18068A410")]
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
		int num4 = 0;
		instance.ShowText("刷新次数已用完", 3f, num4 != 0);
		uint num5;
		GameAPP.PlaySound((int)num5, 0.5f, 1f);
	}

	// Token: 0x06002C92 RID: 11410 RVA: 0x000F5B88 File Offset: 0x000F3D88
	[Token(Token = "0x6002C92")]
	[Address(RVA = "0x68B000", Offset = "0x689600", VA = "0x18068B000")]
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

	// Token: 0x06002C93 RID: 11411 RVA: 0x000F5C38 File Offset: 0x000F3E38
	[Token(Token = "0x6002C93")]
	[Address(RVA = "0x68ADB0", Offset = "0x6893B0", VA = "0x18068ADB0")]
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

	// Token: 0x06002C94 RID: 11412 RVA: 0x000F5CE0 File Offset: 0x000F3EE0
	[Token(Token = "0x6002C94")]
	[Address(RVA = "0x68B280", Offset = "0x689880", VA = "0x18068B280")]
	private void SetCost(TravelStoreWindow window)
	{
		object buff = window.buff;
		if (buff != 0)
		{
			if (buff != 0)
			{
				window.cost = (int)((ulong)2000L);
			}
			else
			{
				window.cost = (int)((ulong)4294964296L);
				uint num;
				window.cost = (int)num;
				TravelData data = TravelMgr.Instance.data;
				bool invest = data.Invest;
				while (!invest)
				{
				}
				if (data.ultiBuffs_lv2 == invest)
				{
					window.cost = (int)((ulong)5000L);
					bool invest2 = TravelMgr.Instance.data.Invest;
					if (invest2)
					{
						window.cost = (int)((ulong)3000L);
					}
					if (invest2 <= true)
					{
					}
					bool flag;
					if (invest2 > true && invest2 > true)
					{
						TravelMgr instance = TravelMgr.Instance;
						while (!flag)
						{
						}
					}
					window.cost = (int)((ulong)15000L);
					while (flag > true)
					{
					}
					window.cost = (int)((ulong)16000L);
					window.cost = (int)((ulong)20000L);
					window.cost = (int)((ulong)10000L);
					window.cost = (int)((ulong)8000L);
					window.canBuy = false;
					return;
				}
				throw new InvalidCastException();
			}
		}
		if (global::Lawnf.TravelCurse() || TravelMgr.Instance.data.invest_challenge)
		{
		}
		if (TravelMgr.Instance.data.travelProcess == TravelProcess.Fast)
		{
			int num2 = window.cost;
			num2 += window;
			window.cost = num2;
		}
		bool flag2;
		if (flag2)
		{
			window.cost = (flag2 ? 1 : 0);
		}
		int cost = window.cost;
		string text = string.Format("{0}分", cost);
		window.canBuy = true;
	}

	// Token: 0x06002C95 RID: 11413 RVA: 0x000F5E70 File Offset: 0x000F4070
	[Token(Token = "0x6002C95")]
	[Address(RVA = "0x68A2C0", Offset = "0x6888C0", VA = "0x18068A2C0", Slot = "10")]
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

	// Token: 0x06002C96 RID: 11414 RVA: 0x000F5EA4 File Offset: 0x000F40A4
	[Token(Token = "0x6002C96")]
	[Address(RVA = "0x68A170", Offset = "0x688770", VA = "0x18068A170", Slot = "9")]
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

	// Token: 0x06002C97 RID: 11415 RVA: 0x000F5ED4 File Offset: 0x000F40D4
	[Token(Token = "0x6002C97")]
	[Address(RVA = "0x68BB10", Offset = "0x68A110", VA = "0x18068BB10")]
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

	// Token: 0x04001AAF RID: 6831
	[Token(Token = "0x4001AAF")]
	public static TravelStore Instance;

	// Token: 0x04001AB0 RID: 6832
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001AB0")]
	public List<TravelStoreWindow> buyPlantWindows;

	// Token: 0x04001AB1 RID: 6833
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001AB1")]
	public List<TravelStoreWindow> buyBuffWindows;

	// Token: 0x04001AB2 RID: 6834
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001AB2")]
	public List<TextMeshProUGUI> pointText;

	// Token: 0x04001AB3 RID: 6835
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001AB3")]
	public List<TextMeshProUGUI> refreshText;

	// Token: 0x04001AB4 RID: 6836
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001AB4")]
	public GameObject investTextContainer;

	// Token: 0x04001AB5 RID: 6837
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001AB5")]
	public TextMeshProUGUI investText;

	// Token: 0x04001AB6 RID: 6838
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001AB6")]
	public TextMeshProUGUI investTextshadow;

	// Token: 0x04001AB7 RID: 6839
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001AB7")]
	public RectTransform textContent;

	// Token: 0x04001AB8 RID: 6840
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001AB8")]
	[SerializeField]
	private int refreshCount;

	// Token: 0x04001AB9 RID: 6841
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4001AB9")]
	private bool buy;

	// Token: 0x04001ABA RID: 6842
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001ABA")]
	private List<TravelUnlocks> unlockPool;

	// Token: 0x04001ABB RID: 6843
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001ABB")]
	private List<object> pool;
}
