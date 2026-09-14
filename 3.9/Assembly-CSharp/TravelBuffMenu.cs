using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x0200062D RID: 1581
[Token(Token = "0x200062D")]
public class TravelBuffMenu : BaseMenu
{
	// Token: 0x06001DD0 RID: 7632 RVA: 0x0009E890 File Offset: 0x0009CA90
	[Token(Token = "0x6001DD0")]
	[Address(RVA = "0x57D190", Offset = "0x57B790", VA = "0x18057D190", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		this.GetOptions();
		if (TravelMgr.Instance.data.Invest)
		{
			GameObject gameObject = this.cancelButton;
			int num = 0;
			gameObject.SetActive(num != 0);
			return;
		}
	}

	// Token: 0x06001DD1 RID: 7633 RVA: 0x0009E8D4 File Offset: 0x0009CAD4
	[Token(Token = "0x6001DD1")]
	[Address(RVA = "0x57D5D0", Offset = "0x57BBD0", VA = "0x18057D5D0")]
	private void InitBuffPool()
	{
		TravelMgr instance = TravelMgr.Instance;
		this.manager = instance;
		this.InitDebuffPool();
		this.InitPlantBuffPool();
	}

	// Token: 0x06001DD2 RID: 7634 RVA: 0x0009E8FC File Offset: 0x0009CAFC
	[Token(Token = "0x6001DD2")]
	[Address(RVA = "0x57D640", Offset = "0x57BC40", VA = "0x18057D640")]
	private void InitDebuffPool()
	{
		ulong num2;
		do
		{
			int num = 0;
			if ((this.leader ? 1 : 0) == num)
			{
				break;
			}
			List<TravelDebuff> list = Enumerable.ToList<TravelDebuff>(TravelHelper.LeaderAppear);
			this.debuffPool = list;
			TravelMgr travelMgr = this.manager;
			if (travelMgr.TravelPackage == (ulong)0L)
			{
				goto IL_00F9;
			}
			if (travelMgr.TravelPackage.LandRoute)
			{
				List<TravelDebuff> list2 = this.debuffPool;
			}
			List<TravelDebuff> list3 = Enumerable.ToList<TravelDebuff>(this.debuffPool);
			bool flag;
			if (flag)
			{
				Dictionary<TravelDebuff, ValueTuple<string, ZombieType>> debuffData = TravelDictionary.debuffData;
				ZombieType routeBossType = this.manager.TravelPackage.RouteBossType;
				bool flag2 = this.debuffPool.Remove(num);
			}
		}
		while (num2 != (ulong)0L);
		TravelMgr travelMgr2 = this.manager;
		TravelMgr travelMgr3 = this.manager;
		if (travelMgr2.TravelPackage == (ulong)0L)
		{
			List<TravelDebuff> list4 = travelMgr3.GetDebuffPool();
			this.debuffPool = list4;
			List<TravelDebuff> list5 = this.debuffPool;
			Predicate<TravelDebuff> predicate;
			if (TravelBuffMenu.<>c.<>9__13_0 == 0)
			{
				predicate = (TravelDebuff a) => a >= TravelDebuff.究极黑巨;
				TravelBuffMenu.<>c.<>9__13_0 = predicate;
			}
			int num3 = list5.RemoveAll(predicate);
		}
		List<TravelDebuff> list6;
		this.debuffPool = list6;
		IL_00F9:
		List<TravelDebuff> list7 = this.debuffPool;
		Predicate<TravelDebuff> predicate2;
		if (TravelBuffMenu.<>c.<>9__13_1 == 0)
		{
			predicate2 = delegate(TravelDebuff a)
			{
				bool flag3;
				return flag3;
			};
			TravelBuffMenu.<>c.<>9__13_1 = predicate2;
		}
		int num4 = list7.RemoveAll(predicate2);
	}

	// Token: 0x06001DD3 RID: 7635 RVA: 0x0009EA58 File Offset: 0x0009CC58
	[Token(Token = "0x6001DD3")]
	[Address(RVA = "0x57DB80", Offset = "0x57C180", VA = "0x18057DB80")]
	private void InitPlantBuffPool()
	{
		ulong num5;
		do
		{
			List<object> list = this.pool;
			int size = list._size;
			list._size = (int)((ulong)0L);
			if (size > 0)
			{
			}
			List<object> list2 = this.pool;
			List<UltiBuff> ultiBuffPool = this.manager.GetUltiBuffPool();
			list2.AddRange(ultiBuffPool);
			List<object> list3 = this.pool;
			TravelMgr travelMgr = this.manager;
			int num = 0;
			List<AdvBuff> advancedBuffPool = travelMgr.GetAdvancedBuffPool(num != 0);
			list3.AddRange(advancedBuffPool);
			Board instance = Board.Instance;
			Dictionary<PlantType, ValueTuple<PlantType?, object, object, bool>> plantInfo = TravelDictionary.PlantInfo;
			bool flag;
			if (flag)
			{
				List<PlantType> unlockedWeaks = TravelMgr.Instance.data.unlockedWeaks;
				bool flag2;
				while (flag2)
				{
				}
				List<object> list4;
				if (unlockedWeaks != 0 && unlockedWeaks != 0)
				{
					list4 = this.pool;
					List<PlantType> list5 = unlockedWeaks;
					bool flag3 = list4.Remove(list5);
				}
				while (list4 == 0)
				{
				}
				while (list4 == 0)
				{
				}
				List<object> list6 = this.pool;
				List<object> list7 = list4;
				bool flag4 = list6.Remove(list7);
			}
			ulong num2;
			if (num2 != (ulong)0L)
			{
				goto IL_0143;
			}
			Dictionary<PlantType, ValueTuple<PlantType?, object, object, bool>> plantInfo2 = TravelDictionary.PlantInfo;
			bool flag5;
			if (flag5)
			{
				Board instance2 = Board.Instance;
				bool flag6;
				if (flag6)
				{
					int num3 = 0;
					num3++;
				}
				bool flag7;
				while (!flag7)
				{
				}
				int num4 = 0;
				num4++;
			}
		}
		while (num5 != (ulong)0L);
		return;
		IL_0143:
		throw new NullReferenceException();
	}

	// Token: 0x06001DD4 RID: 7636 RVA: 0x0009EBC8 File Offset: 0x0009CDC8
	[Token(Token = "0x6001DD4")]
	[Address(RVA = "0x57F480", Offset = "0x57DA80", VA = "0x18057F480")]
	private void Start()
	{
		TravelMgr instance = TravelMgr.Instance;
		this.manager = instance;
		this.InitDebuffPool();
		this.InitPlantBuffPool();
		int num = 0;
		this.RefeshOptions(num != 0);
	}

	// Token: 0x06001DD5 RID: 7637 RVA: 0x0009EBFC File Offset: 0x0009CDFC
	[Token(Token = "0x6001DD5")]
	[Address(RVA = "0x57D230", Offset = "0x57B830", VA = "0x18057D230")]
	private void GetOptions()
	{
		int num;
		do
		{
			num = 0;
			IEnumerator enumerator = base.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				bool flag;
				while (!flag)
				{
				}
				List<TravelBuffOptionButton> list = this.options;
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06001DD6 RID: 7638 RVA: 0x0009EC60 File Offset: 0x0009CE60
	[Token(Token = "0x6001DD6")]
	[Address(RVA = "0x57E370", Offset = "0x57C970", VA = "0x18057E370", Slot = "10")]
	public override void OnHide()
	{
		ulong num;
		do
		{
			List<TravelBuffOptionButton> list = this.options;
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06001DD7 RID: 7639 RVA: 0x0009EC9C File Offset: 0x0009CE9C
	[Token(Token = "0x6001DD7")]
	[Address(RVA = "0x57E200", Offset = "0x57C800", VA = "0x18057E200", Slot = "9")]
	public override void OnBackEnter()
	{
		ulong num;
		do
		{
			List<TravelBuffOptionButton> list = this.options;
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06001DD8 RID: 7640 RVA: 0x0009ECD4 File Offset: 0x0009CED4
	[Token(Token = "0x6001DD8")]
	[Address(RVA = "0x57E8A0", Offset = "0x57CEA0", VA = "0x18057E8A0")]
	public void RefeshOptions(bool refresh = false)
	{
		ulong num5;
		do
		{
			TravelMgr instance = TravelMgr.Instance;
			if (global::Lawnf.TravelInvest((InvestBuff)((uint)2011)))
			{
				Board instance2 = Board.Instance;
				int num = 0;
				instance2.GetPoint(500f, num != 0);
			}
			List<TravelBuffOptionButton> list = this.options;
			bool flag;
			bool flag2;
			if (!flag || flag2)
			{
			}
			ulong num2;
			if (num2 != (ulong)0L)
			{
				goto IL_0086;
			}
			bool flag3;
			if (flag3)
			{
				int num3 = 0;
				int num4 = global::UnityEngine.Random.Range(0, num3);
				TravelBuffMenu.<>c__DisplayClass19_0 CS$<>8__locals1;
				object obj;
				CS$<>8__locals1.buffType = obj;
			}
		}
		while (num5 != (ulong)0L);
		return;
		IL_0086:
		throw new NullReferenceException();
	}

	// Token: 0x06001DD9 RID: 7641 RVA: 0x0009ED8C File Offset: 0x0009CF8C
	[Token(Token = "0x6001DD9")]
	[Address(RVA = "0x57EFA0", Offset = "0x57D5A0", VA = "0x18057EFA0")]
	private void SetDebuff(bool refresh)
	{
		ulong num3;
		do
		{
			int size = this.debuffPool._size;
			List<TravelBuffOptionButton> list = this.options;
			this.InitDebuffPool();
			List<TravelBuffOptionButton> list2 = this.options;
			bool flag;
			if (flag)
			{
				int num = this.debuffPool._size;
				int num2 = global::UnityEngine.Random.Range(0, num);
				List<TravelDebuff> list3 = this.debuffPool;
				num = num2;
				TravelDebuff travelDebuff = list3[num];
				this.debuffPool.RemoveAt(num2);
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06001DDA RID: 7642 RVA: 0x0009EE20 File Offset: 0x0009D020
	[Token(Token = "0x6001DDA")]
	[Address(RVA = "0x57F1E0", Offset = "0x57D7E0", VA = "0x18057F1E0")]
	private void SetProbability(List<object> advancedPool)
	{
		if (global::UnityEngine.Random.Range(0, 4) != 0)
		{
		}
		if (global::UnityEngine.Random.Range(0, 4) != 0)
		{
		}
		if (global::UnityEngine.Random.Range(0, 4) != 0)
		{
		}
		if (global::UnityEngine.Random.Range(0, 3) != 0)
		{
		}
		if (global::UnityEngine.Random.Range(0, 2) != 0)
		{
		}
		if (global::UnityEngine.Random.Range(0, 2) != 0)
		{
		}
	}

	// Token: 0x06001DDB RID: 7643 RVA: 0x0009EE70 File Offset: 0x0009D070
	[Token(Token = "0x6001DDB")]
	[Address(RVA = "0x57ED50", Offset = "0x57D350", VA = "0x18057ED50")]
	public void SelectBuff(TravelBuffOptionButton option)
	{
		TravelMgr instance = TravelMgr.Instance;
		object buff = option.buff;
		string text = instance.GetText(buff);
		if (option.set)
		{
			object buff2 = option.buff;
			if (buff2 != 0)
			{
				if (buff2 != 0)
				{
					goto IL_0071;
				}
				if (buff2 != 0)
				{
					goto IL_006B;
				}
				if (buff2 != 0)
				{
					InGameText instance2 = InGameText.Instance;
				}
			}
		}
		int num = this.debuffNeedCount;
		if (this.isDebuff)
		{
			int num2 = num - 1;
			this.debuffNeedCount = num2;
		}
		IL_006B:
		IL_0071:
		int num3 = this.selectBuffCount;
		num3++;
		this.selectBuffCount = num3;
		if (instance.data.travelDifficulty != TravelDifficulty.Curse || num3 != 1)
		{
			if (!this.withDebuff || this.debuffNeedCount <= 0)
			{
				throw new NullReferenceException();
			}
			this.isDebuff = true;
		}
		this.RefeshOptions(true);
	}

	// Token: 0x06001DDC RID: 7644 RVA: 0x0009EF40 File Offset: 0x0009D140
	[Token(Token = "0x6001DDC")]
	[Address(RVA = "0x57D4B0", Offset = "0x57BAB0", VA = "0x18057D4B0")]
	public void GiveUpBuff()
	{
		if (this.isDebuff)
		{
			GameAPP.PlaySound(26, 0.5f, 1f);
			InGameText instance = InGameText.Instance;
			return;
		}
		if (this.withDebuff && this.debuffNeedCount > 0)
		{
			this.isDebuff = true;
			this.RefeshOptions(true);
			return;
		}
		Board instance2 = Board.Instance;
		int num = 0;
		instance2.GetPoint(1000f, num != 0);
		this.Quit();
	}

	// Token: 0x06001DDD RID: 7645 RVA: 0x0009EFB4 File Offset: 0x0009D1B4
	[Token(Token = "0x6001DDD")]
	[Address(RVA = "0x57E4E0", Offset = "0x57CAE0", VA = "0x18057E4E0")]
	public void Quit()
	{
		GameAPP.UIManager.Pop();
		CursorChange.SetDefaultCursor();
		if (this.temp)
		{
			Time.timeScale = GameAPP.config.gameSpeed;
			return;
		}
		Board instance = Board.Instance;
		if (TravelMgr.Instance.data.travelProcess == TravelProcess.Fast && !this.leader && !this.isDebuff)
		{
			UIResourcesLoader uimanager = GameAPP.UIManager;
			Transform canvasUp = GameAPP.canvasUp;
			int num = 0;
			BaseMenu baseMenu = uimanager.Push((UIType)((uint)25), canvasUp, num != 0);
			return;
		}
		int theCurrentSurvivalRound = instance.theCurrentSurvivalRound;
		JigsawManager instance3;
		if (theCurrentSurvivalRound - 1 > 7)
		{
			if (theCurrentSurvivalRound != 12 && theCurrentSurvivalRound != 16)
			{
				goto IL_00B7;
			}
			JigsawManager instance2 = JigsawManager.Instance;
			int num2 = 0;
			if (instance2 == num2)
			{
				JigsawManager.Instance.GetRandomShape();
				return;
			}
			instance3 = JigsawManager.Instance;
			instance3.enabled = true;
		}
		while (instance3 == (ulong)3L)
		{
		}
		while (instance3 == (ulong)8L)
		{
		}
		IL_00B7:
		if (RogueManager.Instance.leaderType == LeaderType.Present)
		{
			Time.timeScale = GameAPP.config.gameSpeed;
			instance.TravelNextRound();
			return;
		}
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
		Transform canvasUp2 = GameAPP.canvasUp;
		int num3 = 0;
		BaseMenu baseMenu2 = uimanager2.Push((UIType)((uint)36), canvasUp2, num3 != 0);
	}

	// Token: 0x06001DDE RID: 7646 RVA: 0x0009F0E4 File Offset: 0x0009D2E4
	[Token(Token = "0x6001DDE")]
	[Address(RVA = "0x57F500", Offset = "0x57DB00", VA = "0x18057F500")]
	public TravelBuffMenu()
	{
		List<TravelBuffOptionButton> list = new List();
		this.options = list;
		List<object> list2 = new List();
		this.pool = list2;
		List<TravelDebuff> list3 = new List();
		this.debuffPool = list3;
		base..ctor();
	}

	// Token: 0x04001032 RID: 4146
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001032")]
	private readonly List<TravelBuffOptionButton> options;

	// Token: 0x04001033 RID: 4147
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001033")]
	public GameObject cancelButton;

	// Token: 0x04001034 RID: 4148
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001034")]
	public bool leader;

	// Token: 0x04001035 RID: 4149
	[FieldOffset(Offset = "0x51")]
	[Token(Token = "0x4001035")]
	public bool withDebuff;

	// Token: 0x04001036 RID: 4150
	[FieldOffset(Offset = "0x52")]
	[Token(Token = "0x4001036")]
	public bool isDebuff;

	// Token: 0x04001037 RID: 4151
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4001037")]
	private int selectBuffCount;

	// Token: 0x04001038 RID: 4152
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001038")]
	public int debuffNeedCount;

	// Token: 0x04001039 RID: 4153
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4001039")]
	public bool temp;

	// Token: 0x0400103A RID: 4154
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400103A")]
	private List<object> pool;

	// Token: 0x0400103B RID: 4155
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400103B")]
	private List<TravelDebuff> debuffPool;

	// Token: 0x0400103C RID: 4156
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400103C")]
	private TravelMgr manager;
}
