using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x020005F8 RID: 1528
[Token(Token = "0x20005F8")]
public class TravelBuffMenu : BaseMenu
{
	// Token: 0x06001CD1 RID: 7377 RVA: 0x00099D38 File Offset: 0x00097F38
	[Token(Token = "0x6001CD1")]
	[Address(RVA = "0x51D0F0", Offset = "0x51B6F0", VA = "0x18051D0F0", Slot = "6")]
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

	// Token: 0x06001CD2 RID: 7378 RVA: 0x00099D7C File Offset: 0x00097F7C
	[Token(Token = "0x6001CD2")]
	[Address(RVA = "0x51D520", Offset = "0x51BB20", VA = "0x18051D520")]
	private void InitBuffPool()
	{
		TravelMgr instance = TravelMgr.Instance;
		this.manager = instance;
		this.InitDebuffPool();
		this.InitPlantBuffPool();
	}

	// Token: 0x06001CD3 RID: 7379 RVA: 0x00099DA4 File Offset: 0x00097FA4
	[Token(Token = "0x6001CD3")]
	[Address(RVA = "0x51D590", Offset = "0x51BB90", VA = "0x18051D590")]
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
		if (Board.Instance.theCurrentSurvivalRound > 3)
		{
			List<TravelDebuff> list7 = this.debuffPool;
		}
		List<TravelDebuff> list8 = this.debuffPool;
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
		int num4 = list8.RemoveAll(predicate2);
	}

	// Token: 0x06001CD4 RID: 7380 RVA: 0x00099F14 File Offset: 0x00098114
	[Token(Token = "0x6001CD4")]
	[Address(RVA = "0x51DB10", Offset = "0x51C110", VA = "0x18051DB10")]
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

	// Token: 0x06001CD5 RID: 7381 RVA: 0x0009A084 File Offset: 0x00098284
	[Token(Token = "0x6001CD5")]
	[Address(RVA = "0x51F400", Offset = "0x51DA00", VA = "0x18051F400")]
	private void Start()
	{
		TravelMgr instance = TravelMgr.Instance;
		this.manager = instance;
		this.InitDebuffPool();
		this.InitPlantBuffPool();
		int num = 0;
		this.RefeshOptions(num != 0);
	}

	// Token: 0x06001CD6 RID: 7382 RVA: 0x0009A0B8 File Offset: 0x000982B8
	[Token(Token = "0x6001CD6")]
	[Address(RVA = "0x51D190", Offset = "0x51B790", VA = "0x18051D190")]
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

	// Token: 0x06001CD7 RID: 7383 RVA: 0x0009A11C File Offset: 0x0009831C
	[Token(Token = "0x6001CD7")]
	[Address(RVA = "0x51E300", Offset = "0x51C900", VA = "0x18051E300", Slot = "10")]
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

	// Token: 0x06001CD8 RID: 7384 RVA: 0x0009A158 File Offset: 0x00098358
	[Token(Token = "0x6001CD8")]
	[Address(RVA = "0x51E190", Offset = "0x51C790", VA = "0x18051E190", Slot = "9")]
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

	// Token: 0x06001CD9 RID: 7385 RVA: 0x0009A190 File Offset: 0x00098390
	[Token(Token = "0x6001CD9")]
	[Address(RVA = "0x51E830", Offset = "0x51CE30", VA = "0x18051E830")]
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

	// Token: 0x06001CDA RID: 7386 RVA: 0x0009A248 File Offset: 0x00098448
	[Token(Token = "0x6001CDA")]
	[Address(RVA = "0x51EF20", Offset = "0x51D520", VA = "0x18051EF20")]
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

	// Token: 0x06001CDB RID: 7387 RVA: 0x0009A2DC File Offset: 0x000984DC
	[Token(Token = "0x6001CDB")]
	[Address(RVA = "0x51F160", Offset = "0x51D760", VA = "0x18051F160")]
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

	// Token: 0x06001CDC RID: 7388 RVA: 0x0009A32C File Offset: 0x0009852C
	[Token(Token = "0x6001CDC")]
	[Address(RVA = "0x51ECE0", Offset = "0x51D2E0", VA = "0x18051ECE0")]
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
					goto IL_0084;
				}
				if (buff2 != 0)
				{
					goto IL_007E;
				}
				if (buff2 != 0)
				{
					int num = 0;
					InGameText instance2 = InGameText.Instance;
					int num2 = 0;
					instance2.ShowText(text, (float)num, num2 != 0);
				}
			}
		}
		int num3 = this.debuffNeedCount;
		if (this.isDebuff)
		{
			int num4 = num3 - 1;
			this.debuffNeedCount = num4;
		}
		IL_007E:
		IL_0084:
		int num5 = this.selectBuffCount;
		num5++;
		this.selectBuffCount = num5;
		if (instance.data.travelDifficulty != TravelDifficulty.Curse || num5 != 1)
		{
			if (!this.withDebuff || this.debuffNeedCount <= 0)
			{
				throw new NullReferenceException();
			}
			this.isDebuff = true;
		}
		this.RefeshOptions(true);
	}

	// Token: 0x06001CDD RID: 7389 RVA: 0x0009A410 File Offset: 0x00098610
	[Token(Token = "0x6001CDD")]
	[Address(RVA = "0x51D410", Offset = "0x51BA10", VA = "0x18051D410")]
	public void GiveUpBuff()
	{
		if (this.isDebuff)
		{
			GameAPP.PlaySound(26, 0.5f, 1f);
			InGameText instance = InGameText.Instance;
			int num = 0;
			instance.ShowText("无法放弃僵尸词条", 3f, num != 0);
			return;
		}
		if (this.withDebuff && this.debuffNeedCount > 0)
		{
			this.isDebuff = true;
			this.RefeshOptions(true);
			return;
		}
		Board instance2 = Board.Instance;
		int num2 = 0;
		instance2.GetPoint(1000f, num2 != 0);
		this.Quit();
	}

	// Token: 0x06001CDE RID: 7390 RVA: 0x0009A498 File Offset: 0x00098698
	[Token(Token = "0x6001CDE")]
	[Address(RVA = "0x51E470", Offset = "0x51CA70", VA = "0x18051E470")]
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

	// Token: 0x06001CDF RID: 7391 RVA: 0x0009A5C8 File Offset: 0x000987C8
	[Token(Token = "0x6001CDF")]
	[Address(RVA = "0x51F480", Offset = "0x51DA80", VA = "0x18051F480")]
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

	// Token: 0x04000F6A RID: 3946
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F6A")]
	private readonly List<TravelBuffOptionButton> options;

	// Token: 0x04000F6B RID: 3947
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000F6B")]
	public GameObject cancelButton;

	// Token: 0x04000F6C RID: 3948
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000F6C")]
	public bool leader;

	// Token: 0x04000F6D RID: 3949
	[FieldOffset(Offset = "0x51")]
	[Token(Token = "0x4000F6D")]
	public bool withDebuff;

	// Token: 0x04000F6E RID: 3950
	[FieldOffset(Offset = "0x52")]
	[Token(Token = "0x4000F6E")]
	public bool isDebuff;

	// Token: 0x04000F6F RID: 3951
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000F6F")]
	private int selectBuffCount;

	// Token: 0x04000F70 RID: 3952
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000F70")]
	public int debuffNeedCount;

	// Token: 0x04000F71 RID: 3953
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000F71")]
	public bool temp;

	// Token: 0x04000F72 RID: 3954
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000F72")]
	private List<object> pool;

	// Token: 0x04000F73 RID: 3955
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000F73")]
	private List<TravelDebuff> debuffPool;

	// Token: 0x04000F74 RID: 3956
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000F74")]
	private TravelMgr manager;
}
