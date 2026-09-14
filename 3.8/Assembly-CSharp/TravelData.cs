using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000740 RID: 1856
[Token(Token = "0x2000740")]
[Serializable]
public class TravelData
{
	// Token: 0x17000187 RID: 391
	// (get) Token: 0x060025C0 RID: 9664 RVA: 0x000C7044 File Offset: 0x000C5244
	[Token(Token = "0x17000187")]
	public bool Invest
	{
		[Token(Token = "0x60025C0")]
		[Address(RVA = "0x5CAE50", Offset = "0x5C9450", VA = "0x1805CAE50")]
		get
		{
			return this.travelDifficulty == TravelDifficulty.Invest;
		}
	}

	// Token: 0x060025C1 RID: 9665 RVA: 0x000C705C File Offset: 0x000C525C
	[Token(Token = "0x60025C1")]
	[Address(RVA = "0x5CAA20", Offset = "0x5C9020", VA = "0x1805CAA20")]
	public bool NeedShowInUI()
	{
		List<TravelUnlocks> list = this.unlockedPlants;
		List<AdvBuff> list2 = this.advBuffs;
		List<UltiBuff> list3 = this.ultiBuffs;
		List<TravelDebuff> list4 = this.travelDebuffs;
		List<InvestBuff> list5 = this.investBuffs;
		Board instance = Board.Instance;
		return true;
	}

	// Token: 0x060025C2 RID: 9666 RVA: 0x000C70A0 File Offset: 0x000C52A0
	[Token(Token = "0x60025C2")]
	[Address(RVA = "0x5CA890", Offset = "0x5C8E90", VA = "0x1805CA890")]
	public int GetBuffLevel(UltiBuff buff)
	{
		List<UltiBuff> list = this.ultiBuffs_lv2;
		bool flag;
		if (!flag)
		{
			List<UltiBuff> list2 = this.ultiBuffs;
		}
		return 2;
	}

	// Token: 0x060025C3 RID: 9667 RVA: 0x000C70C8 File Offset: 0x000C52C8
	[Token(Token = "0x60025C3")]
	[Address(RVA = "0x5CAB20", Offset = "0x5C9120", VA = "0x1805CAB20")]
	public void Refresh()
	{
	}

	// Token: 0x060025C4 RID: 9668 RVA: 0x000C70D8 File Offset: 0x000C52D8
	[Token(Token = "0x60025C4")]
	[Address(RVA = "0x5CA6B0", Offset = "0x5C8CB0", VA = "0x1805CA6B0")]
	public void AddDamage(PlantType thePlantType, float value)
	{
		Dictionary<PlantType, float> ida_plant = this.IDA_plant;
		Dictionary<PlantType, float> ida_plant2 = this.IDA_plant;
		bool flag;
		if (!flag)
		{
			return;
		}
	}

	// Token: 0x060025C5 RID: 9669 RVA: 0x000C7100 File Offset: 0x000C5300
	[Token(Token = "0x60025C5")]
	[Address(RVA = "0x5CAB30", Offset = "0x5C9130", VA = "0x1805CAB30")]
	public void SetDamage(PlantType thePlantType, float value)
	{
		Dictionary<PlantType, float> ida_plant = this.IDA_plant;
	}

	// Token: 0x060025C6 RID: 9670 RVA: 0x000C711C File Offset: 0x000C531C
	[Token(Token = "0x60025C6")]
	[Address(RVA = "0x5CA920", Offset = "0x5C8F20", VA = "0x1805CA920")]
	public float GetDamageMultiplier(PlantType plantType)
	{
		Dictionary<PlantType, float> ida_plant = this.IDA_plant;
		bool flag;
		if (!flag)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x060025C7 RID: 9671 RVA: 0x000C7144 File Offset: 0x000C5344
	[Token(Token = "0x60025C7")]
	[Address(RVA = "0x5CA7A0", Offset = "0x5C8DA0", VA = "0x1805CA7A0")]
	public void AddSpeed(PlantType thePlantType, float value)
	{
		Dictionary<PlantType, float> speed_plant = this.Speed_plant;
		Dictionary<PlantType, float> speed_plant2 = this.Speed_plant;
		bool flag;
		if (!flag)
		{
			return;
		}
	}

	// Token: 0x060025C8 RID: 9672 RVA: 0x000C716C File Offset: 0x000C536C
	[Token(Token = "0x60025C8")]
	[Address(RVA = "0x5CA9A0", Offset = "0x5C8FA0", VA = "0x1805CA9A0")]
	public float GetSpeed(PlantType plantType)
	{
		Dictionary<PlantType, float> speed_plant = this.Speed_plant;
		bool flag;
		if (!flag)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x060025C9 RID: 9673 RVA: 0x000C7194 File Offset: 0x000C5394
	[Token(Token = "0x60025C9")]
	[Address(RVA = "0x5CABA0", Offset = "0x5C91A0", VA = "0x1805CABA0")]
	public TravelData()
	{
		List<TravelUnlocks> list = new List();
		this.unlockedPlants = list;
		List<AdvBuff> list2 = new List();
		this.advBuffs = list2;
		List<TravelDebuff> list3 = new List();
		this.travelDebuffs = list3;
		List<PlantType> list4 = new List();
		this.unlockedWeaks = list4;
		List<InvestBuff> list5 = new List();
		this.investmentBuffs = list5;
		List<UltiBuff> list6 = new List();
		this.ultiBuffs = list6;
		List<UltiBuff> list7 = new List();
		this.ultiBuffs_lv2 = list7;
		Dictionary<PlantType, float> dictionary = new Dictionary();
		this.Speed_plant = dictionary;
		Dictionary<PlantType, float> dictionary2 = new Dictionary();
		this.IDA_plant = dictionary2;
		List<InvestBuff> list8 = new List();
		this.investBuffs = list8;
		base..ctor();
	}

	// Token: 0x04001312 RID: 4882
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001312")]
	public List<TravelUnlocks> unlockedPlants;

	// Token: 0x04001313 RID: 4883
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001313")]
	public List<AdvBuff> advBuffs;

	// Token: 0x04001314 RID: 4884
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001314")]
	public List<TravelDebuff> travelDebuffs;

	// Token: 0x04001315 RID: 4885
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001315")]
	public List<PlantType> unlockedWeaks;

	// Token: 0x04001316 RID: 4886
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001316")]
	public List<InvestBuff> investmentBuffs;

	// Token: 0x04001317 RID: 4887
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001317")]
	public List<UltiBuff> ultiBuffs;

	// Token: 0x04001318 RID: 4888
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001318")]
	public List<UltiBuff> ultiBuffs_lv2;

	// Token: 0x04001319 RID: 4889
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001319")]
	[Header("长期数据")]
	public int difficulty;

	// Token: 0x0400131A RID: 4890
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400131A")]
	public int shieldCount;

	// Token: 0x0400131B RID: 4891
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400131B")]
	public int extraRefreshCount;

	// Token: 0x0400131C RID: 4892
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400131C")]
	public float moreLuckyStrike;

	// Token: 0x0400131D RID: 4893
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400131D")]
	public float damageAmplification;

	// Token: 0x0400131E RID: 4894
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400131E")]
	public float pointsBonus;

	// Token: 0x0400131F RID: 4895
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400131F")]
	public bool usePoint;

	// Token: 0x04001320 RID: 4896
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x4001320")]
	public bool hideActive;

	// Token: 0x04001321 RID: 4897
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4001321")]
	public float ArmorPiercing;

	// Token: 0x04001322 RID: 4898
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001322")]
	public float jalaMore;

	// Token: 0x04001323 RID: 4899
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001323")]
	private readonly Dictionary<PlantType, float> Speed_plant;

	// Token: 0x04001324 RID: 4900
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001324")]
	private readonly Dictionary<PlantType, float> IDA_plant;

	// Token: 0x04001325 RID: 4901
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001325")]
	[Header("临时数据")]
	public List<InvestBuff> investBuffs;

	// Token: 0x04001326 RID: 4902
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001326")]
	[Header("关卡数据")]
	public ZombieType routeBossType;

	// Token: 0x04001327 RID: 4903
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4001327")]
	public TravelDifficulty travelDifficulty;

	// Token: 0x04001328 RID: 4904
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001328")]
	public TravelProcess travelProcess;

	// Token: 0x04001329 RID: 4905
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4001329")]
	public bool invest_challenge;

	// Token: 0x0400132A RID: 4906
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400132A")]
	[NonSerialized]
	public int temp_round;

	// Token: 0x0400132B RID: 4907
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x400132B")]
	[Header("旧版数据")]
	public bool curseMode;

	// Token: 0x0400132C RID: 4908
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400132C")]
	public int map;
}
