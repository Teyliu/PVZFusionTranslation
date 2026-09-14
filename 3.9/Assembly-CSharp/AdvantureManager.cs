using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008F8 RID: 2296
[Token(Token = "0x20008F8")]
public class AdvantureManager : MonoBehaviour
{
	// Token: 0x06002E91 RID: 11921 RVA: 0x000FE5A8 File Offset: 0x000FC7A8
	[Token(Token = "0x6002E91")]
	[Address(RVA = "0x6FAB60", Offset = "0x6F9160", VA = "0x1806FAB60")]
	private void Awake()
	{
		AdvantureManager.Instance = this;
		AdvantureAward advantureAward = new AdvantureAward();
		this.award = advantureAward;
		int theBoardLevel = GameAPP.theBoardLevel;
		this.level = (AdvantureLevel)theBoardLevel;
	}

	// Token: 0x06002E92 RID: 11922 RVA: 0x000FE5D8 File Offset: 0x000FC7D8
	[Token(Token = "0x6002E92")]
	[Address(RVA = "0x6FC300", Offset = "0x6FA900", VA = "0x1806FC300")]
	private void Update()
	{
		AdvantureMission advantureMission = this.mission;
		if (advantureMission != 0)
		{
			advantureMission.OnUpdate();
			return;
		}
	}

	// Token: 0x06002E93 RID: 11923 RVA: 0x000FE5F8 File Offset: 0x000FC7F8
	[Token(Token = "0x6002E93")]
	[Address(RVA = "0x6FBA30", Offset = "0x6FA030", VA = "0x1806FBA30")]
	public void ReinforcePlant(Plant plant)
	{
		ulong num3;
		do
		{
			int num = 0;
			AdvantureData data = AdvantureConfig.data;
			bool flag;
			if (flag)
			{
			}
			if (plant.attributeCountdown > 0.5f)
			{
				AdvantureData data2 = AdvantureConfig.data;
				bool flag2;
				if (flag2)
				{
					plant.AttributeCountdown = 0.5f;
				}
			}
			if (plant.isShort)
			{
				AdvantureData data3 = AdvantureConfig.data;
				bool flag3;
				if (flag3)
				{
					CreateItem instance = CreateItem.Instance;
				}
			}
			Board board = this.board;
			AdvantureData data4 = AdvantureConfig.data;
			bool flag4;
			if (flag4)
			{
			}
			if (plant.plantTag != (ulong)0L)
			{
				AdvantureData data5 = AdvantureConfig.data;
				bool flag5;
				if (flag5)
				{
				}
				if (plant.plantTag != (ulong)0L)
				{
					AdvantureData data6 = AdvantureConfig.data;
					bool flag6;
					if (flag6)
					{
					}
				}
			}
			AdvantureData data7 = AdvantureConfig.data;
			bool flag7;
			if (flag7)
			{
				float num2 = plant.defence * 0.7f;
				plant.defence = num2;
			}
			int thePlantType = (int)plant.thePlantType;
			bool flag8;
			if (flag8)
			{
				AdvantureData data8 = AdvantureConfig.data;
				bool flag9;
				if (flag9)
				{
				}
			}
			AdvantureData data9 = AdvantureConfig.data;
			bool flag10;
			if (flag10 && plant.thePlantType != PlantType.StarFruit)
			{
				PlantType thePlantType2 = plant.thePlantType;
				List<PlantType> list;
				if (list.Contains(thePlantType2))
				{
				}
			}
			List<TalentType> talents = AdvantureConfig.data.talents;
			bool flag11;
			if (flag11)
			{
				if (num > 23)
				{
					if (-29 != 0)
					{
						if (-29 != 0)
						{
							if (18446744073709551587UL != (ulong)1L)
							{
								if (num == 41)
								{
								}
								while (num != 42)
								{
								}
							}
							if (!Lawnf.IsBasicPlant(plant.thePlantType))
							{
								continue;
							}
						}
						if (!Lawnf.IsBasicPlant(plant.thePlantType))
						{
							continue;
						}
					}
					if (!Lawnf.IsBasicPlant(plant.thePlantType))
					{
						continue;
					}
					float attackSpeedAdder = plant.attackSpeedAdder;
					plant.attackSpeedAdder = attackSpeedAdder;
					float thePlantSpeed = plant.thePlantSpeed;
					plant.thePlantSpeed = thePlantSpeed;
				}
				if (-6 != 0 && -6 != 0 && -6 != 0)
				{
					if (18446744073709551610UL != (ulong)1L)
					{
						if (-19 == 0)
						{
							goto IL_01C9;
						}
						while (-19 == 0)
						{
						}
						if (-19 == 0)
						{
							goto IL_01C9;
						}
						while (-19 == 0)
						{
						}
						while (18446744073709551597UL != (ulong)1L)
						{
						}
					}
					float defence = plant.defence;
					plant.defence = defence;
				}
			}
			IL_01C9:;
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06002E94 RID: 11924 RVA: 0x000FE7E4 File Offset: 0x000FC9E4
	[Token(Token = "0x6002E94")]
	[Address(RVA = "0x6FAC30", Offset = "0x6F9230", VA = "0x1806FAC30")]
	public void LevelComplete(AdvantureLevel level)
	{
		AdvantureData data = AdvantureConfig.data;
		List<AdvantureLevel> levelCompleted = data.levelCompleted;
		if (this.hardMode)
		{
			List<AdvantureLevel> levelCompletedHard = data.levelCompletedHard;
		}
		if (level == AdvantureLevel.RandomChallenge)
		{
			Dictionary<AdvantureLevel, ILevelStrategy> levelStrategies = AdvantureConfig._levelStrategies;
			int num = data.gameDifficulty;
			num++;
			data.enpowerStarCount = num;
			if (data.hardMode)
			{
				num += 2;
				data.enpowerStarCount = num;
			}
		}
		if (this.mission == (ulong)0L || this.mission.complete)
		{
		}
	}

	// Token: 0x06002E95 RID: 11925 RVA: 0x000FE870 File Offset: 0x000FCA70
	[Token(Token = "0x6002E95")]
	[Address(RVA = "0x6FAE20", Offset = "0x6F9420", VA = "0x1806FAE20")]
	public void OnBoardStart(AdvantureLevel level)
	{
		int num;
		do
		{
			num = 0;
			int num2 = 0;
			bool flag;
			if (!flag)
			{
				AdvantureData data = AdvantureConfig.data;
				bool flag2;
				if (flag2)
				{
					CreatePlant instance = CreatePlant.Instance;
				}
				AdvantureData data2 = AdvantureConfig.data;
				bool flag3;
				if (flag3)
				{
					CreatePlant instance2 = CreatePlant.Instance;
					Dictionary<AdvantureLevel, ILevelStrategy> levelStrategies = AdvantureConfig._levelStrategies;
					bool flag4;
					if (!flag4)
					{
					}
				}
				AdvantureData data3 = AdvantureConfig.data;
				bool flag5;
				if (flag5)
				{
					Board board = this.board;
					if (num < board.rowNum)
					{
						CreatePlant instance3 = CreatePlant.Instance;
						num++;
						Board board2 = this.board;
					}
				}
			}
			AdvantureData data4 = AdvantureConfig.data;
			bool flag6;
			if (flag6)
			{
				ulong num3;
				this.board.GetSun(75f, num3 != 0UL);
			}
			Dictionary<AdvantureLevel, ILevelStrategy> levelStrategies2 = AdvantureConfig._levelStrategies;
			bool flag7;
			if (flag7)
			{
			}
			List<TalentType> talents = AdvantureConfig.data.talents;
			bool flag8;
			if (flag8)
			{
				if (num2 <= 13)
				{
					goto IL_00E0;
				}
				if (num2 != 17)
				{
					while (num2 != 18)
					{
					}
					Board board3 = this.board;
					float bulletStrikeMultiplier = board3.bulletStrikeMultiplier;
					board3.bulletStrikeMultiplier = bulletStrikeMultiplier;
					goto IL_00E0;
				}
				goto IL_010D;
				IL_0153:
				ulong num4;
				this.board.GetSun(25f, num4 != 0UL);
				goto IL_0165;
				IL_0141:
				ulong num5;
				this.board.GetSun(50f, num5 != 0UL);
				goto IL_0153;
				IL_00E0:
				if (-1 == 0)
				{
					goto IL_0153;
				}
				if (-1 == 0)
				{
					goto IL_0141;
				}
				while (-1 == 0)
				{
				}
				if (-1 != 0)
				{
					if (18446744073709551615UL != (ulong)1L)
					{
						while (num2 != 13)
						{
						}
						ulong num6;
						this.board.GetSun(75f, num6 != 0UL);
						goto IL_010D;
					}
					goto IL_010D;
				}
				IL_0127:
				Board board4 = this.board;
				float bulletStrikeP = board4.bulletStrikeP;
				board4.bulletStrikeP = bulletStrikeP;
				goto IL_0141;
				IL_010D:
				Board board5 = this.board;
				float bulletStrikeP2 = board5.bulletStrikeP;
				board5.bulletStrikeP = bulletStrikeP2;
				goto IL_0127;
			}
			IL_0165:;
		}
		while (num != 0);
		if (num != 0)
		{
		}
	}

	// Token: 0x06002E96 RID: 11926 RVA: 0x000FE9F4 File Offset: 0x000FCBF4
	[Token(Token = "0x6002E96")]
	[Address(RVA = "0x6FB5B0", Offset = "0x6F9BB0", VA = "0x1806FB5B0")]
	public void OnGameStart()
	{
		if (this.mission != (ulong)0L && this.mission.target != (ulong)0L)
		{
			ulong num;
			InGameUI.Instance.lookMission.SetActive(num != 0UL);
			ulong num2;
			InGameUI.Instance.submitMission.SetActive(num2 != 0UL);
			if (this.mission.onLook == (ulong)0L)
			{
				ulong num3;
				InGameUI.Instance.missionProgress.SetActive(num3 != 0UL);
			}
		}
		AdvantureData data = AdvantureConfig.data;
		int num4 = 0;
		bool flag;
		if (flag)
		{
			List<CardUI> cards = InGameUI.Instance.Cards;
			if (num4 < 6)
			{
				if (InGameUI.Instance.Cards[num4].theSeedCost > 5)
				{
					CardUI cardUI = InGameUI.Instance.Cards[num4];
				}
				num4++;
				InGameUI instance = InGameUI.Instance;
			}
		}
		AdvantureData data2 = AdvantureConfig.data;
		bool flag2;
		if (flag2)
		{
			Board board = this.board;
			if (num4 < board.rowNum)
			{
				BoxType[] roadType = this.board.roadType;
				if ("{il2cpp array field local41->}" != (ulong)1L)
				{
					int num5 = 0;
					CreateZombie instance2 = CreateZombie.Instance;
					float boxXFromColumn = Lawnf.GetBoxXFromColumn(num5);
				}
				int num6 = 0;
				CreateZombie instance3 = CreateZombie.Instance;
				float boxXFromColumn2 = Lawnf.GetBoxXFromColumn(num6);
				Board board2 = this.board;
				num4++;
				uint num7;
				num7 += (uint)4;
				while (board2 != 0)
				{
				}
			}
		}
		AdvantureData data3 = AdvantureConfig.data;
		bool flag3;
		if (flag3)
		{
			Board board3 = this.board;
			if (board3.theSun > 100)
			{
				board3.theSun = (int)((ulong)100L);
				Board board4 = this.board;
				long num8 = board3 * (uint)50;
				board4.GetMoney((float)num8);
			}
		}
	}

	// Token: 0x06002E97 RID: 11927 RVA: 0x000FEB74 File Offset: 0x000FCD74
	[Token(Token = "0x6002E97")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public AdvantureManager()
	{
	}

	// Token: 0x04001CD4 RID: 7380
	[Token(Token = "0x4001CD4")]
	public static AdvantureManager Instance;

	// Token: 0x04001CD5 RID: 7381
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001CD5")]
	public AdvantureAward award;

	// Token: 0x04001CD6 RID: 7382
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001CD6")]
	public Board board;

	// Token: 0x04001CD7 RID: 7383
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001CD7")]
	public AdvantureMission mission;

	// Token: 0x04001CD8 RID: 7384
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001CD8")]
	public AdvantureLevel level;

	// Token: 0x04001CD9 RID: 7385
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001CD9")]
	public bool hardMode;
}
