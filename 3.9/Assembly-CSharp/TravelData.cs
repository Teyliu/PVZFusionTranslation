using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000779 RID: 1913
[Token(Token = "0x2000779")]
[Serializable]
public class TravelData
{
	// Token: 0x170001CE RID: 462
	// (get) Token: 0x060026E5 RID: 9957 RVA: 0x000CBF34 File Offset: 0x000CA134
	[Token(Token = "0x170001CE")]
	public bool Invest
	{
		[Token(Token = "0x60026E5")]
		[Address(RVA = "0x62C210", Offset = "0x62A810", VA = "0x18062C210")]
		get
		{
			return this.travelDifficulty == TravelDifficulty.Invest;
		}
	}

	// Token: 0x060026E6 RID: 9958 RVA: 0x000CBF4C File Offset: 0x000CA14C
	[Token(Token = "0x60026E6")]
	[Address(RVA = "0x62BDE0", Offset = "0x62A3E0", VA = "0x18062BDE0")]
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

	// Token: 0x060026E7 RID: 9959 RVA: 0x000CBF90 File Offset: 0x000CA190
	[Token(Token = "0x60026E7")]
	[Address(RVA = "0x62BC50", Offset = "0x62A250", VA = "0x18062BC50")]
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

	// Token: 0x060026E8 RID: 9960 RVA: 0x000CBFB8 File Offset: 0x000CA1B8
	[Token(Token = "0x60026E8")]
	[Address(RVA = "0x62BEE0", Offset = "0x62A4E0", VA = "0x18062BEE0")]
	public void Refresh()
	{
	}

	// Token: 0x060026E9 RID: 9961 RVA: 0x000CBFC8 File Offset: 0x000CA1C8
	[Token(Token = "0x60026E9")]
	[Address(RVA = "0x62BA70", Offset = "0x62A070", VA = "0x18062BA70")]
	public void AddDamage(PlantType thePlantType, float value)
	{
		Dictionary<PlantType, float> damage_plant = this.Damage_plant;
		Dictionary<PlantType, float> damage_plant2 = this.Damage_plant;
		bool flag;
		if (!flag)
		{
			return;
		}
	}

	// Token: 0x060026EA RID: 9962 RVA: 0x000CBFF0 File Offset: 0x000CA1F0
	[Token(Token = "0x60026EA")]
	[Address(RVA = "0x62BEF0", Offset = "0x62A4F0", VA = "0x18062BEF0")]
	public void SetDamage(PlantType thePlantType, float value)
	{
		Dictionary<PlantType, float> damage_plant = this.Damage_plant;
	}

	// Token: 0x060026EB RID: 9963 RVA: 0x000CC00C File Offset: 0x000CA20C
	[Token(Token = "0x60026EB")]
	[Address(RVA = "0x62BCE0", Offset = "0x62A2E0", VA = "0x18062BCE0")]
	public float GetDamageMultiplier(PlantType plantType)
	{
		Dictionary<PlantType, float> damage_plant = this.Damage_plant;
		bool flag;
		if (!flag)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x060026EC RID: 9964 RVA: 0x000CC034 File Offset: 0x000CA234
	[Token(Token = "0x60026EC")]
	[Address(RVA = "0x62BB60", Offset = "0x62A160", VA = "0x18062BB60")]
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

	// Token: 0x060026ED RID: 9965 RVA: 0x000CC05C File Offset: 0x000CA25C
	[Token(Token = "0x60026ED")]
	[Address(RVA = "0x62BD60", Offset = "0x62A360", VA = "0x18062BD60")]
	public float GetSpeed(PlantType plantType)
	{
		Dictionary<PlantType, float> speed_plant = this.Speed_plant;
		bool flag;
		if (!flag)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x060026EE RID: 9966 RVA: 0x000CC084 File Offset: 0x000CA284
	[Token(Token = "0x60026EE")]
	[Address(RVA = "0x62BF60", Offset = "0x62A560", VA = "0x18062BF60")]
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
		this.Damage_plant = dictionary2;
		List<InvestBuff> list8 = new List();
		this.investBuffs = list8;
		base..ctor();
	}

	// Token: 0x040013E8 RID: 5096
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40013E8")]
	public List<TravelUnlocks> unlockedPlants;

	// Token: 0x040013E9 RID: 5097
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40013E9")]
	public List<AdvBuff> advBuffs;

	// Token: 0x040013EA RID: 5098
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013EA")]
	public List<TravelDebuff> travelDebuffs;

	// Token: 0x040013EB RID: 5099
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013EB")]
	public List<PlantType> unlockedWeaks;

	// Token: 0x040013EC RID: 5100
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40013EC")]
	public List<InvestBuff> investmentBuffs;

	// Token: 0x040013ED RID: 5101
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40013ED")]
	public List<UltiBuff> ultiBuffs;

	// Token: 0x040013EE RID: 5102
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40013EE")]
	public List<UltiBuff> ultiBuffs_lv2;

	// Token: 0x040013EF RID: 5103
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40013EF")]
	[Header("长期数据")]
	public int difficulty;

	// Token: 0x040013F0 RID: 5104
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40013F0")]
	public int shieldCount;

	// Token: 0x040013F1 RID: 5105
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40013F1")]
	public int extraRefreshCount;

	// Token: 0x040013F2 RID: 5106
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40013F2")]
	public float moreLuckyStrike;

	// Token: 0x040013F3 RID: 5107
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40013F3")]
	public float damageAmplification;

	// Token: 0x040013F4 RID: 5108
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40013F4")]
	public float pointsBonus;

	// Token: 0x040013F5 RID: 5109
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40013F5")]
	public bool usePoint;

	// Token: 0x040013F6 RID: 5110
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x40013F6")]
	public bool hideActive;

	// Token: 0x040013F7 RID: 5111
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40013F7")]
	public float ArmorPiercing;

	// Token: 0x040013F8 RID: 5112
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40013F8")]
	public float jalaMore;

	// Token: 0x040013F9 RID: 5113
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40013F9")]
	public readonly Dictionary<PlantType, float> Speed_plant;

	// Token: 0x040013FA RID: 5114
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40013FA")]
	public readonly Dictionary<PlantType, float> Damage_plant;

	// Token: 0x040013FB RID: 5115
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40013FB")]
	[Header("临时数据")]
	public List<InvestBuff> investBuffs;

	// Token: 0x040013FC RID: 5116
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40013FC")]
	[Header("关卡数据")]
	public ZombieType routeBossType;

	// Token: 0x040013FD RID: 5117
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x40013FD")]
	public TravelDifficulty travelDifficulty;

	// Token: 0x040013FE RID: 5118
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40013FE")]
	public TravelProcess travelProcess;

	// Token: 0x040013FF RID: 5119
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x40013FF")]
	public bool invest_challenge;

	// Token: 0x04001400 RID: 5120
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001400")]
	[NonSerialized]
	public int temp_round;

	// Token: 0x04001401 RID: 5121
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4001401")]
	[Header("旧版数据")]
	public bool curseMode;

	// Token: 0x04001402 RID: 5122
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001402")]
	public int map;
}
