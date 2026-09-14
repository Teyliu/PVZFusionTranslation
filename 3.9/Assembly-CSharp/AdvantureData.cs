using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;

// Token: 0x020008F7 RID: 2295
[Token(Token = "0x20008F7")]
[Serializable]
public class AdvantureData
{
	// Token: 0x06002E83 RID: 11907 RVA: 0x000FE260 File Offset: 0x000FC460
	[Token(Token = "0x6002E83")]
	[Address(RVA = "0x6F9D10", Offset = "0x6F8310", VA = "0x1806F9D10")]
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

	// Token: 0x06002E84 RID: 11908 RVA: 0x000FE2A8 File Offset: 0x000FC4A8
	[Token(Token = "0x6002E84")]
	[Address(RVA = "0x6FA420", Offset = "0x6F8A20", VA = "0x1806FA420")]
	public void RemoveTalent(TalentType talentType)
	{
		List<TalentType> list = this.talents;
		HashSet<TalentType> hashSet = LinqUtility.ToHashSet<TalentType>(this.talents);
		this._talents = hashSet;
		throw new NullReferenceException();
	}

	// Token: 0x06002E85 RID: 11909 RVA: 0x000FE2D8 File Offset: 0x000FC4D8
	[Token(Token = "0x6002E85")]
	[Address(RVA = "0x6FA3D0", Offset = "0x6F89D0", VA = "0x1806FA3D0")]
	public void OnInit()
	{
		HashSet<TalentType> hashSet = LinqUtility.ToHashSet<TalentType>(this.talents);
		this._talents = hashSet;
	}

	// Token: 0x1700020E RID: 526
	// (get) Token: 0x06002E86 RID: 11910 RVA: 0x000FE2F8 File Offset: 0x000FC4F8
	[Token(Token = "0x1700020E")]
	public int RestStar
	{
		[Token(Token = "0x6002E86")]
		[Address(RVA = "0x6FAB30", Offset = "0x6F9130", VA = "0x1806FAB30")]
		get
		{
			int stars = this.GetStars();
			int usedStars = this.GetUsedStars();
			return stars - usedStars;
		}
	}

	// Token: 0x06002E87 RID: 11911 RVA: 0x000FE31C File Offset: 0x000FC51C
	[Token(Token = "0x6002E87")]
	[Address(RVA = "0x6F9510", Offset = "0x6F7B10", VA = "0x1806F9510")]
	public bool CheckTalent(TalentType talentType)
	{
		bool flag;
		return flag;
	}

	// Token: 0x06002E88 RID: 11912 RVA: 0x000FE338 File Offset: 0x000FC538
	[Token(Token = "0x6002E88")]
	[Address(RVA = "0x6F9650", Offset = "0x6F7C50", VA = "0x1806F9650")]
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

	// Token: 0x06002E89 RID: 11913 RVA: 0x000FE370 File Offset: 0x000FC570
	[Token(Token = "0x6002E89")]
	[Address(RVA = "0x6FA0B0", Offset = "0x6F86B0", VA = "0x1806FA0B0")]
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

	// Token: 0x06002E8A RID: 11914 RVA: 0x000FE3DC File Offset: 0x000FC5DC
	[Token(Token = "0x6002E8A")]
	[Address(RVA = "0x6F9B50", Offset = "0x6F8150", VA = "0x1806F9B50")]
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

	// Token: 0x06002E8B RID: 11915 RVA: 0x000FE420 File Offset: 0x000FC620
	[Token(Token = "0x6002E8B")]
	[Address(RVA = "0x6F9DD0", Offset = "0x6F83D0", VA = "0x1806F9DD0")]
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

	// Token: 0x06002E8C RID: 11916 RVA: 0x000FE46C File Offset: 0x000FC66C
	[Token(Token = "0x6002E8C")]
	[Address(RVA = "0x6F95B0", Offset = "0x6F7BB0", VA = "0x1806F95B0")]
	private int GetLevelStar(AdvantureLevel level)
	{
		int num = 0;
		Dictionary<AdvantureLevel, int> levelStarMap = AdvantureData._levelStarMap;
		return num;
	}

	// Token: 0x06002E8D RID: 11917 RVA: 0x000FE48C File Offset: 0x000FC68C
	[Token(Token = "0x6002E8D")]
	[Address(RVA = "0x6F97E0", Offset = "0x6F7DE0", VA = "0x1806F97E0")]
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

	// Token: 0x06002E8E RID: 11918 RVA: 0x000FE4FC File Offset: 0x000FC6FC
	[Token(Token = "0x6002E8E")]
	[Address(RVA = "0x6FA030", Offset = "0x6F8630", VA = "0x1806FA030")]
	public static bool IsEndless(AdvantureLevel level)
	{
		HashSet<AdvantureLevel> endlessLevel = AdvantureData.EndlessLevel;
		bool flag;
		return flag;
	}

	// Token: 0x06002E8F RID: 11919 RVA: 0x000FE518 File Offset: 0x000FC718
	[Token(Token = "0x6002E8F")]
	[Address(RVA = "0x6FA980", Offset = "0x6F8F80", VA = "0x1806FA980")]
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

	// Token: 0x06002E90 RID: 11920 RVA: 0x000FE580 File Offset: 0x000FC780
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6002E90")]
	[Address(RVA = "0x6FA4A0", Offset = "0x6F8AA0", VA = "0x1806FA4A0")]
	static AdvantureData()
	{
		throw new NullReferenceException();
	}

	// Token: 0x04001CC8 RID: 7368
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001CC8")]
	public List<AdvantureLevel> levelCompletedHard;

	// Token: 0x04001CC9 RID: 7369
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001CC9")]
	public List<AdvantureLevel> levelCompleted;

	// Token: 0x04001CCA RID: 7370
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001CCA")]
	public List<MissionData> missionDatas;

	// Token: 0x04001CCB RID: 7371
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001CCB")]
	public List<TalentType> talents;

	// Token: 0x04001CCC RID: 7372
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001CCC")]
	public HashSet<TalentType> _talents;

	// Token: 0x04001CCD RID: 7373
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001CCD")]
	public bool hardMode;

	// Token: 0x04001CCE RID: 7374
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001CCE")]
	public int gameDifficulty;

	// Token: 0x04001CCF RID: 7375
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001CCF")]
	public PlantDevelopData plantDevelopData;

	// Token: 0x04001CD0 RID: 7376
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001CD0")]
	public int enpowerStarCount;

	// Token: 0x04001CD1 RID: 7377
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4001CD1")]
	public int enpowerStarCount_hard;

	// Token: 0x04001CD2 RID: 7378
	[Token(Token = "0x4001CD2")]
	private static readonly HashSet<AdvantureLevel> EndlessLevel = new HashSet();

	// Token: 0x04001CD3 RID: 7379
	[Token(Token = "0x4001CD3")]
	private static readonly Dictionary<AdvantureLevel, int> _levelStarMap = new Dictionary();
}
