using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008BC RID: 2236
[Token(Token = "0x20008BC")]
public class AdvantureManager : MonoBehaviour
{
	// Token: 0x06002D5E RID: 11614 RVA: 0x000F9A14 File Offset: 0x000F7C14
	[Token(Token = "0x6002D5E")]
	[Address(RVA = "0x6815A0", Offset = "0x67FBA0", VA = "0x1806815A0")]
	private void Awake()
	{
		AdvantureManager.Instance = this;
		AdvantureAward advantureAward = new AdvantureAward();
		this.award = advantureAward;
		int theBoardLevel = GameAPP.theBoardLevel;
		this.level = (AdvantureLevel)theBoardLevel;
	}

	// Token: 0x06002D5F RID: 11615 RVA: 0x000F9A44 File Offset: 0x000F7C44
	[Token(Token = "0x6002D5F")]
	[Address(RVA = "0x682D40", Offset = "0x681340", VA = "0x180682D40")]
	private void Update()
	{
		AdvantureMission advantureMission = this.mission;
		if (advantureMission != 0)
		{
			advantureMission.OnUpdate();
			return;
		}
	}

	// Token: 0x06002D60 RID: 11616 RVA: 0x000F9A64 File Offset: 0x000F7C64
	[Token(Token = "0x6002D60")]
	[Address(RVA = "0x682470", Offset = "0x680A70", VA = "0x180682470")]
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

	// Token: 0x06002D61 RID: 11617 RVA: 0x000F9C50 File Offset: 0x000F7E50
	[Token(Token = "0x6002D61")]
	[Address(RVA = "0x681670", Offset = "0x67FC70", VA = "0x180681670")]
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

	// Token: 0x06002D62 RID: 11618 RVA: 0x000F9CDC File Offset: 0x000F7EDC
	[Token(Token = "0x6002D62")]
	[Address(RVA = "0x681860", Offset = "0x67FE60", VA = "0x180681860")]
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

	// Token: 0x06002D63 RID: 11619 RVA: 0x000F9E60 File Offset: 0x000F8060
	[Token(Token = "0x6002D63")]
	[Address(RVA = "0x681FF0", Offset = "0x6805F0", VA = "0x180681FF0")]
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

	// Token: 0x06002D64 RID: 11620 RVA: 0x000F9FE0 File Offset: 0x000F81E0
	[Token(Token = "0x6002D64")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public AdvantureManager()
	{
	}

	// Token: 0x04001BE4 RID: 7140
	[Token(Token = "0x4001BE4")]
	public static AdvantureManager Instance;

	// Token: 0x04001BE5 RID: 7141
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001BE5")]
	public AdvantureAward award;

	// Token: 0x04001BE6 RID: 7142
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001BE6")]
	public Board board;

	// Token: 0x04001BE7 RID: 7143
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001BE7")]
	public AdvantureMission mission;

	// Token: 0x04001BE8 RID: 7144
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001BE8")]
	public AdvantureLevel level;

	// Token: 0x04001BE9 RID: 7145
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001BE9")]
	public bool hardMode;
}
