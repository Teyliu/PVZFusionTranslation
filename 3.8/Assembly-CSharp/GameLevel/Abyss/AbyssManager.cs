using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UI;
using UnityEngine;

namespace GameLevel.Abyss
{
	// Token: 0x02000CE8 RID: 3304
	[Token(Token = "0x2000CE8")]
	public class AbyssManager : Singleton<AbyssManager>
	{
		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06004529 RID: 17705 RVA: 0x0015E258 File Offset: 0x0015C458
		[Token(Token = "0x170007C9")]
		public static AbyssData Data
		{
			[Token(Token = "0x6004529")]
			[Address(RVA = "0x82DC10", Offset = "0x82C210", VA = "0x18082DC10")]
			get
			{
				return GameAPP.config.abyssData;
			}
		}

		// Token: 0x0600452A RID: 17706 RVA: 0x0015E278 File Offset: 0x0015C478
		[Token(Token = "0x600452A")]
		[Address(RVA = "0x82D5C0", Offset = "0x82BBC0", VA = "0x18082D5C0")]
		public void StartNewAdventure()
		{
			GameConfig config = GameAPP.config;
			AbyssData abyssData = new AbyssData();
			config.abyssData = abyssData;
			this.UpdateZombieBuff();
			SaveInfo.Instance.SavePlayerData();
		}

		// Token: 0x0600452B RID: 17707 RVA: 0x0015E2B0 File Offset: 0x0015C4B0
		[Token(Token = "0x600452B")]
		[Address(RVA = "0x82CB30", Offset = "0x82B130", VA = "0x18082CB30")]
		public void OnBoardStart(Board board)
		{
			SeedLibrary.Instance.DeleteCards("NormalCards");
			SeedLibrary.Instance.DeleteCards("ColorCards");
			SeedLibrary instance = SeedLibrary.Instance;
			AbyssData abyssData = GameAPP.config.abyssData;
			SeedLibrary.Instance.ShowCards("abyssCards");
			board.theSun = (int)((ulong)50L);
			board.theMoney = (int)((ulong)0L);
			this.ApplyBuffEffect(board);
			int difficulty = GameAPP.config.difficulty;
			board.lockedDifficulty = difficulty;
		}

		// Token: 0x0600452C RID: 17708 RVA: 0x0015E330 File Offset: 0x0015C530
		[Token(Token = "0x600452C")]
		[Address(RVA = "0x82D140", Offset = "0x82B740", VA = "0x18082D140")]
		private void OnCardCreate(CardUI card)
		{
			CardUI card2 = card;
			CardUI card3 = card;
			PlantDataManager.PlantData plantData;
			float cd = plantData.cd;
			card3.fullCD = cd;
			int cost = plantData.cost;
			card3.theSeedCost = cost;
			CardUI card4 = card;
			float fullCD = card4.fullCD;
			card4.CD = fullCD;
			Func<ReinforceData, bool> func;
			if (Enumerable.FirstOrDefault<ReinforceData>(GameAPP.config.abyssData.reinforceDatas, func) != 0)
			{
				CardUI card5 = card;
				uint num2;
				int num = card5.theSeedCost.MultiplyPercent((float)num2);
				card5.theSeedCost = num;
			}
			Action<Plant> action;
			card.plantAction = action;
			throw new NullReferenceException();
		}

		// Token: 0x0600452D RID: 17709 RVA: 0x0015E3E8 File Offset: 0x0015C5E8
		[Token(Token = "0x600452D")]
		[Address(RVA = "0x82CDC0", Offset = "0x82B3C0", VA = "0x18082CDC0")]
		public void OnBoardWin(Board board)
		{
			int num;
			do
			{
				BoardStatistics boardStatistics = board.boardStatistics;
				List<ZombieBuff> zombieBuffs = AbyssManager.Data.zombieBuffs;
				num = 0;
				bool flag;
				if (flag)
				{
					Dictionary<ZombieBuff, ValueTuple<string, int>> zombieBuffDescription = this.ZombieBuffDescription;
				}
			}
			while (num != 0);
			int num2 = 0;
			uint num3;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0050;
					}
					num3 += (uint)5;
				}
				num3 += (uint)3;
			}
			num3 += (uint)1;
			IL_0050:
			if (num3 > (uint)0)
			{
				while (num3 != (uint)0)
				{
				}
			}
			int arrivedLevel = GameAPP.config.abyssData.arrivedLevel;
			AbyssData abyssData = GameAPP.config.abyssData;
			uint num5;
			int num4 = Mathf.Max((int)num3, (int)num5);
			if (num2 < num4)
			{
				num2++;
			}
			SaveInfo.Instance.SavePlayerData();
		}

		// Token: 0x0600452E RID: 17710 RVA: 0x0015E49C File Offset: 0x0015C69C
		[Token(Token = "0x600452E")]
		[Address(RVA = "0x82D3B0", Offset = "0x82B9B0", VA = "0x18082D3B0")]
		public void ReinforcePlant(Plant plant)
		{
			Func<ReinforceData, bool> func;
			if (Enumerable.FirstOrDefault<ReinforceData>(GameAPP.config.abyssData.reinforceDatas, func) != 0)
			{
				TravelMgr instance = TravelMgr.Instance;
				Plant plant2 = plant;
				PlantType plantType;
				float num;
				instance.data.SetDamage(plantType, num);
				float num2;
				plant.AddSpeed(num2);
				Plant plant3 = plant;
				int num3 = 0;
				float num4 = num * 0.15f;
				plant3.ModifyHealth((PlantHealthAdder)((uint)13), num4, num3 != 0);
			}
		}

		// Token: 0x0600452F RID: 17711 RVA: 0x0015E524 File Offset: 0x0015C724
		[Token(Token = "0x600452F")]
		[Address(RVA = "0x82C540", Offset = "0x82AB40", VA = "0x18082C540")]
		private void CreateItem()
		{
			int i = GameAPP.theBoardLevel;
			Dictionary<Quality, int> dictionary = new Dictionary();
			int num = 0;
			uint num2;
			dictionary[num] = num2;
			Dictionary<Quality, int> dictionary2 = new Dictionary();
			int num3 = 0;
			uint num4;
			dictionary2[num3] = num4;
			Dictionary<Quality, int> dictionary3 = new Dictionary();
			int num5 = 0;
			uint num6;
			dictionary3[num5] = num6;
			Quality randomKeyByWeight = DictionaryExtensions.GetRandomKeyByWeight<Quality>(dictionary3);
			Quality quality = randomKeyByWeight;
			if (randomKeyByWeight != Quality.Default && randomKeyByWeight != Quality.Default && randomKeyByWeight != Quality.Default && randomKeyByWeight == Quality.silver)
			{
				while (i >= 20)
				{
				}
				if (i < 15)
				{
					if (i < 10)
					{
						Dictionary<Quality, int> dictionary4 = new Dictionary();
						int num7 = 0;
						uint num8;
						dictionary4[num7] = num8;
					}
					Dictionary<Quality, int> dictionary5 = new Dictionary();
					int num9 = 0;
					uint num10;
					dictionary5[num9] = num10;
				}
				Dictionary<Quality, int> dictionary6 = new Dictionary();
				int num11 = 0;
				uint num12;
				dictionary6[num11] = num12;
			}
			DroppedItem droppedItem = Resources.Load<DroppedItem>("UI/Abyss/SilverTicket");
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Board instance = Board.Instance;
			DroppedItem droppedItem2;
			Action<DroppedItem> onClick = droppedItem2.onClick;
			droppedItem2.landY = -1f;
			Action<DroppedItem> action;
			Delegate @delegate = Delegate.Combine(onClick, action);
			if (@delegate == 0)
			{
				droppedItem2.onClick = @delegate;
			}
			if (@delegate != 0)
			{
				droppedItem2.onClick = @delegate;
				if (@delegate != 0)
				{
					throw new NullReferenceException();
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06004530 RID: 17712 RVA: 0x0015E654 File Offset: 0x0015C854
		[Token(Token = "0x6004530")]
		[Address(RVA = "0x82D6A0", Offset = "0x82BCA0", VA = "0x18082D6A0")]
		private void UpdateZombieBuff()
		{
			AbyssData abyssData = GameAPP.config.abyssData;
			ulong num;
			num += num;
			if (num > (ulong)0L)
			{
				List<ZombieBuff> list = Enumerable.ToList<ZombieBuff>(global::Core.Lawnf.GetEnumValues<ZombieBuff>());
				int num2 = 0;
				bool flag = list.Remove(num2);
				ListExtensions.Shuffle<ZombieBuff>(list);
				AbyssData data = AbyssManager.Data;
				List<ZombieBuff> list2 = Enumerable.ToList<ZombieBuff>(Enumerable.Take<ZombieBuff>(list, (int)num));
				data.zombieBuffs = list2;
			}
		}

		// Token: 0x06004531 RID: 17713 RVA: 0x0015E6BC File Offset: 0x0015C8BC
		[Token(Token = "0x6004531")]
		[Address(RVA = "0x82C150", Offset = "0x82A750", VA = "0x18082C150")]
		private void ApplyBuffEffect(Board board)
		{
			ulong num;
			do
			{
				List<ZombieBuff> zombieBuffs = GameAPP.config.abyssData.zombieBuffs;
				bool flag;
				if (flag)
				{
					while (18446744073709551615UL > (ulong)8L)
					{
					}
					BoardConfig config = board.config;
					float zombieHealthMultiplier = config.zombieHealthMultiplier;
					config.zombieHealthMultiplier = zombieHealthMultiplier;
					BoardConfig config2 = board.config;
					float zombieHealthMultiplier2 = config2.zombieHealthMultiplier;
					config2.zombieHealthMultiplier = zombieHealthMultiplier2;
					BoardConfig config3 = board.config;
					float zombieHealthMultiplier3 = config3.zombieHealthMultiplier;
					config3.zombieHealthMultiplier = zombieHealthMultiplier3;
					BoardConfig config4 = board.config;
					float zombieDamageMultiplier = config4.zombieDamageMultiplier;
					config4.zombieDamageMultiplier = zombieDamageMultiplier;
					BoardConfig config5 = board.config;
					float zombieDamageMultiplier2 = config5.zombieDamageMultiplier;
					config5.zombieDamageMultiplier = zombieDamageMultiplier2;
					BoardConfig config6 = board.config;
					float zombieDamageMultiplier3 = config6.zombieDamageMultiplier;
					config6.zombieDamageMultiplier = zombieDamageMultiplier3;
					BoardConfig config7 = board.config;
					float zombieSpeedMultiplier = config7.zombieSpeedMultiplier;
					config7.zombieSpeedMultiplier = zombieSpeedMultiplier;
					BoardConfig config8 = board.config;
					float zombieSpeedMultiplier2 = config8.zombieSpeedMultiplier;
					config8.zombieSpeedMultiplier = zombieSpeedMultiplier2;
					BoardConfig config9 = board.config;
					float zombieSpeedMultiplier3 = config9.zombieSpeedMultiplier;
					config9.zombieSpeedMultiplier = zombieSpeedMultiplier3;
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x06004532 RID: 17714 RVA: 0x0015E84C File Offset: 0x0015CA4C
		[Token(Token = "0x6004532")]
		[Address(RVA = "0x82D860", Offset = "0x82BE60", VA = "0x18082D860")]
		public AbyssManager()
		{
			Dictionary<ZombieBuff, ValueTuple<string, int>> dictionary = new Dictionary();
			this.ZombieBuffDescription = dictionary;
			base..ctor();
		}

		// Token: 0x04003178 RID: 12664
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003178")]
		[TupleElementNames(new string[] { "desciption", "points" })]
		public readonly Dictionary<ZombieBuff, ValueTuple<string, int>> ZombieBuffDescription;
	}
}
