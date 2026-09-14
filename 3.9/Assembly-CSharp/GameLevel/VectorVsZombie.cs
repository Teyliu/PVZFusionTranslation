using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000B29 RID: 2857
	[Token(Token = "0x2000B29")]
	public class VectorVsZombie : ChallengeLevelData
	{
		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06003B4B RID: 15179 RVA: 0x001375E0 File Offset: 0x001357E0
		[Token(Token = "0x17000441")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003B4B")]
			[Address(RVA = "0x5444C0", Offset = "0x542AC0", VA = "0x1805444C0", Slot = "42")]
			get
			{
				return ChallengeLevel.VectorVsZombie;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06003B4C RID: 15180 RVA: 0x001375F4 File Offset: 0x001357F4
		[Token(Token = "0x17000442")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003B4C")]
			[Address(RVA = "0x71BFF0", Offset = "0x71A5F0", VA = "0x18071BFF0", Slot = "12")]
			get
			{
				return SceneType.MidMap;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06003B4D RID: 15181 RVA: 0x00137604 File Offset: 0x00135804
		[Token(Token = "0x17000443")]
		public override string Name
		{
			[Token(Token = "0x6003B4D")]
			[Address(RVA = "0x803C80", Offset = "0x802280", VA = "0x180803C80", Slot = "8")]
			get
			{
				return "僵尸分拣大挑战";
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06003B4E RID: 15182 RVA: 0x00137618 File Offset: 0x00135818
		[Token(Token = "0x17000444")]
		public override int MaxWave
		{
			[Token(Token = "0x6003B4E")]
			[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "10")]
			get
			{
				return 10;
			}
		}

		// Token: 0x06003B4F RID: 15183 RVA: 0x00137628 File Offset: 0x00135828
		[Token(Token = "0x6003B4F")]
		[Address(RVA = "0x803740", Offset = "0x801D40", VA = "0x180803740", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			if (base.CardCount != 0)
			{
				int cardCount = base.CardCount;
				board.cardCountLimit = cardCount;
			}
			BoardConfig boardConfig = base.Config.Copy();
			board.config = boardConfig;
			float firstWaveArrivedTimer = base.Config.firstWaveArrivedTimer;
			board.timeUntilNextWave = firstWaveArrivedTimer;
			board.boardTag.disableSelectCard = true;
			board.fallSun = false;
		}

		// Token: 0x06003B50 RID: 15184 RVA: 0x0013768C File Offset: 0x0013588C
		[Token(Token = "0x6003B50")]
		[Address(RVA = "0x803810", Offset = "0x801E10", VA = "0x180803810", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			board.theSun = (int)((ulong)3L);
			int num = 0;
			Action<object> action;
			EventManager.AddListener_obj((GameEvent)((uint)2), action, num != 0);
		}

		// Token: 0x06003B51 RID: 15185 RVA: 0x001376CC File Offset: 0x001358CC
		[Token(Token = "0x6003B51")]
		[Address(RVA = "0x8034B0", Offset = "0x801AB0", VA = "0x1808034B0")]
		private void FixZombieBack(object obj)
		{
			CreateZombie instance = CreateZombie.Instance;
		}

		// Token: 0x06003B52 RID: 15186 RVA: 0x001376E8 File Offset: 0x001358E8
		[Token(Token = "0x6003B52")]
		[Address(RVA = "0x803670", Offset = "0x801C70", VA = "0x180803670", Slot = "40")]
		public override void OnAnimUIOver(Board board)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003B53 RID: 15187 RVA: 0x0013770C File Offset: 0x0013590C
		[Token(Token = "0x6003B53")]
		[Address(RVA = "0x803970", Offset = "0x801F70", VA = "0x180803970", Slot = "34")]
		public override void ReinforcePlant(Plant plant)
		{
			BoardConfig config = plant.board.config;
			if (config.applyRandomData)
			{
				float num = config.plantModifyMin;
				float plantModifyMax = config.plantModifyMax;
				float num2 = global::Core.Lawnf.GetRandomLogSymmetric(num, plantModifyMax);
				int num3 = 0;
				num = num2;
				plant.ModifyHealth((PlantHealthAdder)((uint)5), num2, num3 != 0);
				int num4 = 0;
				int num5 = 0;
				num2 = num;
				plant.ModifyDamage((PlantDamageAdder)((uint)44), num2, num5 != 0, num4);
				float plantSpeedAvg = config.plantSpeedAvg;
				float num6 = config.plantSpeedMax;
				float randomWithMean = global::Core.Lawnf.GetRandomWithMean(config.plantSpeedMin, num6, plantSpeedAvg);
				num6 = randomWithMean;
				plant.attributeSpeed = randomWithMean;
				plant.attackSpeedAdder = num6;
				num6 = randomWithMean;
				float num7 = num6 * plant.thePlantSpeed;
				plant.thePlantSpeed = num7;
				float num8;
				plant.thePlantProduceInterval = num8;
			}
			if (plant.thePlantType == PlantType.VectorPlant)
			{
				plant.theStatus = (PlantStatus)((ulong)25L);
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06003B54 RID: 15188 RVA: 0x001377E0 File Offset: 0x001359E0
		[Token(Token = "0x17000445")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003B54")]
			[Address(RVA = "0x803CB0", Offset = "0x8022B0", VA = "0x180803CB0", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				int size6 = list._size;
				int size7 = list._size;
				int size8 = list._size;
				int size9 = list._size;
				int size10 = list._size;
				int size11 = list._size;
				int size12 = list._size;
				int size13 = list._size;
				int size14 = list._size;
				return list;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06003B55 RID: 15189 RVA: 0x0013787C File Offset: 0x00135A7C
		[Token(Token = "0x17000446")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003B55")]
			[Address(RVA = "0x8041D0", Offset = "0x8027D0", VA = "0x1808041D0", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				return list;
			}
		}

		// Token: 0x06003B56 RID: 15190 RVA: 0x001378D4 File Offset: 0x00135AD4
		[Token(Token = "0x6003B56")]
		[Address(RVA = "0x8035A0", Offset = "0x801BA0", VA = "0x1808035A0")]
		public void GameLogic(Board board)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003B57 RID: 15191 RVA: 0x001378F8 File Offset: 0x00135AF8
		[Token(Token = "0x6003B57")]
		[Address(RVA = "0x803AF0", Offset = "0x8020F0", VA = "0x180803AF0")]
		public VectorVsZombie()
		{
			Dictionary<Vector2Int, ZombieType> dictionary = new Dictionary();
			this.recyclc = dictionary;
			base..ctor();
		}

		// Token: 0x04002CBB RID: 11451
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002CBB")]
		private readonly Dictionary<Vector2Int, ZombieType> recyclc;
	}
}
