using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;

// Token: 0x020008BB RID: 2235
[Token(Token = "0x20008BB")]
[Serializable]
public class AdvantureData
{
	// Token: 0x06002D50 RID: 11600 RVA: 0x000F96CC File Offset: 0x000F78CC
	[Token(Token = "0x6002D50")]
	[Address(RVA = "0x680750", Offset = "0x67ED50", VA = "0x180680750")]
	public void GetTalent(TalentType talentType)
	{
		List<TalentType> list = this.talents;
		int size = list._size;
		int num = (int)(talentType + 1);
		list._size = num;
		HashSet<TalentType> hashSet = LinqUtility.ToHashSet<TalentType>(this.talents);
		this._talents = hashSet;
		throw new NullReferenceException();
	}

	// Token: 0x06002D51 RID: 11601 RVA: 0x000F9714 File Offset: 0x000F7914
	[Token(Token = "0x6002D51")]
	[Address(RVA = "0x680E60", Offset = "0x67F460", VA = "0x180680E60")]
	public void RemoveTalent(TalentType talentType)
	{
		List<TalentType> list = this.talents;
		HashSet<TalentType> hashSet = LinqUtility.ToHashSet<TalentType>(this.talents);
		this._talents = hashSet;
		throw new NullReferenceException();
	}

	// Token: 0x06002D52 RID: 11602 RVA: 0x000F9744 File Offset: 0x000F7944
	[Token(Token = "0x6002D52")]
	[Address(RVA = "0x680E10", Offset = "0x67F410", VA = "0x180680E10")]
	public void OnInit()
	{
		HashSet<TalentType> hashSet = LinqUtility.ToHashSet<TalentType>(this.talents);
		this._talents = hashSet;
	}

	// Token: 0x170001C6 RID: 454
	// (get) Token: 0x06002D53 RID: 11603 RVA: 0x000F9764 File Offset: 0x000F7964
	[Token(Token = "0x170001C6")]
	public int RestStar
	{
		[Token(Token = "0x6002D53")]
		[Address(RVA = "0x681570", Offset = "0x67FB70", VA = "0x180681570")]
		get
		{
			int stars = this.GetStars();
			int usedStars = this.GetUsedStars();
			return stars - usedStars;
		}
	}

	// Token: 0x06002D54 RID: 11604 RVA: 0x000F9788 File Offset: 0x000F7988
	[Token(Token = "0x6002D54")]
	[Address(RVA = "0x67FF50", Offset = "0x67E550", VA = "0x18067FF50")]
	public bool CheckTalent(TalentType talentType)
	{
		bool flag;
		return flag;
	}

	// Token: 0x06002D55 RID: 11605 RVA: 0x000F97A4 File Offset: 0x000F79A4
	[Token(Token = "0x6002D55")]
	[Address(RVA = "0x680090", Offset = "0x67E690", VA = "0x180680090")]
	public bool GetResult(AdvantureLevel missionLevel, MissionResult matchResult)
	{
		for (;;)
		{
			List<MissionData> list = this.missionDatas;
			bool flag;
			if (flag)
			{
				break;
			}
			ulong num;
			if (num == (ulong)0L)
			{
				goto Block_1;
			}
		}
		return true;
		Block_1:
		throw new NullReferenceException();
	}

	// Token: 0x06002D56 RID: 11606 RVA: 0x000F97DC File Offset: 0x000F79DC
	[Token(Token = "0x6002D56")]
	[Address(RVA = "0x680AF0", Offset = "0x67F0F0", VA = "0x180680AF0")]
	public void MissonComplete(AdvantureLevel missionLevel, MissionResult matchResult)
	{
		ulong num;
		do
		{
			List<MissionData> list = this.missionDatas;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
		MissionData missionData = new MissionData();
		missionData.level = AdvantureLevel.Default;
		missionData.result = MissionResult.Nothing;
		List<MissionResult> list2 = new List();
		int size = list2._size;
		missionData.unlockedResult = list2;
	}

	// Token: 0x06002D57 RID: 11607 RVA: 0x000F9848 File Offset: 0x000F7A48
	[Token(Token = "0x6002D57")]
	[Address(RVA = "0x680590", Offset = "0x67EB90", VA = "0x180680590")]
	public int GetStars()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<AdvantureLevel> list = this.levelCompleted;
			bool flag;
			if (flag)
			{
				bool flag2 = AdvantureData._levelStarMap.TryGetValue(num, num2);
				num2 += num2;
			}
		}
		while (num2 != 0);
		return num2;
	}

	// Token: 0x06002D58 RID: 11608 RVA: 0x000F988C File Offset: 0x000F7A8C
	[Token(Token = "0x6002D58")]
	[Address(RVA = "0x680810", Offset = "0x67EE10", VA = "0x180680810")]
	private int GetUsedStars()
	{
		int num;
		do
		{
			num = 0;
			List<TalentType> list = this.talents;
			bool flag;
			if (flag)
			{
				List<TalentData> talentDatas = AdvantureStarMenu.talentDatas;
				bool flag2;
				if (flag2)
				{
				}
				if (num != 0)
				{
					goto IL_0037;
				}
			}
		}
		while (num != 0);
		return num;
		IL_0037:
		throw new NullReferenceException();
	}

	// Token: 0x06002D59 RID: 11609 RVA: 0x000F98D8 File Offset: 0x000F7AD8
	[Token(Token = "0x6002D59")]
	[Address(RVA = "0x67FFF0", Offset = "0x67E5F0", VA = "0x18067FFF0")]
	private int GetLevelStar(AdvantureLevel level)
	{
		int num = 0;
		Dictionary<AdvantureLevel, int> levelStarMap = AdvantureData._levelStarMap;
		return num;
	}

	// Token: 0x06002D5A RID: 11610 RVA: 0x000F98F8 File Offset: 0x000F7AF8
	[Token(Token = "0x6002D5A")]
	[Address(RVA = "0x680220", Offset = "0x67E820", VA = "0x180680220")]
	public int GetSceneStars(SceneType sceneType)
	{
		int num3;
		do
		{
			int num = 0;
			Dictionary<SceneType, string> dictionary = new Dictionary();
			int num2 = 0;
			dictionary.Add(num2, "Day_sub");
			bool flag;
			if (!flag)
			{
				goto IL_0050;
			}
			num3 = 0;
			List<AdvantureLevel> list = this.levelCompleted;
			bool flag2;
			if (flag2)
			{
				bool flag3;
				while (!flag3)
				{
				}
				bool flag4 = AdvantureData._levelStarMap.TryGetValue(num, num);
				num3 += num;
			}
		}
		while (num3 != 0);
		return num3;
		IL_0050:
		throw new NullReferenceException();
	}

	// Token: 0x06002D5B RID: 11611 RVA: 0x000F9968 File Offset: 0x000F7B68
	[Token(Token = "0x6002D5B")]
	[Address(RVA = "0x680A70", Offset = "0x67F070", VA = "0x180680A70")]
	public static bool IsEndless(AdvantureLevel level)
	{
		HashSet<AdvantureLevel> endlessLevel = AdvantureData.EndlessLevel;
		bool flag;
		return flag;
	}

	// Token: 0x06002D5C RID: 11612 RVA: 0x000F9984 File Offset: 0x000F7B84
	[Token(Token = "0x6002D5C")]
	[Address(RVA = "0x6813C0", Offset = "0x67F9C0", VA = "0x1806813C0")]
	public AdvantureData()
	{
		List<AdvantureLevel> list = new List();
		this.levelCompletedHard = list;
		List<AdvantureLevel> list2 = new List();
		this.levelCompleted = list2;
		List<MissionData> list3 = new List();
		this.missionDatas = list3;
		List<TalentType> list4 = new List();
		this.talents = list4;
		HashSet<TalentType> hashSet = new HashSet();
		this._talents = hashSet;
		PlantDevelopData plantDevelopData = new PlantDevelopData();
		this.plantDevelopData = plantDevelopData;
		base..ctor();
	}

	// Token: 0x06002D5D RID: 11613 RVA: 0x000F99EC File Offset: 0x000F7BEC
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6002D5D")]
	[Address(RVA = "0x680EE0", Offset = "0x67F4E0", VA = "0x180680EE0")]
	static AdvantureData()
	{
		throw new NullReferenceException();
	}

	// Token: 0x04001BD8 RID: 7128
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001BD8")]
	public List<AdvantureLevel> levelCompletedHard;

	// Token: 0x04001BD9 RID: 7129
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001BD9")]
	public List<AdvantureLevel> levelCompleted;

	// Token: 0x04001BDA RID: 7130
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001BDA")]
	public List<MissionData> missionDatas;

	// Token: 0x04001BDB RID: 7131
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001BDB")]
	public List<TalentType> talents;

	// Token: 0x04001BDC RID: 7132
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001BDC")]
	public HashSet<TalentType> _talents;

	// Token: 0x04001BDD RID: 7133
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001BDD")]
	public bool hardMode;

	// Token: 0x04001BDE RID: 7134
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001BDE")]
	public int gameDifficulty;

	// Token: 0x04001BDF RID: 7135
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001BDF")]
	public PlantDevelopData plantDevelopData;

	// Token: 0x04001BE0 RID: 7136
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001BE0")]
	public int enpowerStarCount;

	// Token: 0x04001BE1 RID: 7137
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4001BE1")]
	public int enpowerStarCount_hard;

	// Token: 0x04001BE2 RID: 7138
	[Token(Token = "0x4001BE2")]
	private static readonly HashSet<AdvantureLevel> EndlessLevel = new HashSet();

	// Token: 0x04001BE3 RID: 7139
	[Token(Token = "0x4001BE3")]
	private static readonly Dictionary<AdvantureLevel, int> _levelStarMap = new Dictionary();
}
