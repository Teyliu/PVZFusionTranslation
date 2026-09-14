using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UI;

namespace GameLevel.Abyss
{
	// Token: 0x02000CD4 RID: 3284
	[Token(Token = "0x2000CD4")]
	[Serializable]
	public class AbyssData
	{
		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060044C5 RID: 17605 RVA: 0x0015D4A4 File Offset: 0x0015B6A4
		[Token(Token = "0x17000783")]
		public int StorageSize
		{
			[Token(Token = "0x60044C5")]
			[Address(RVA = "0x826490", Offset = "0x824A90", VA = "0x180826490")]
			get
			{
				AbyssData abyssData = GameAPP.config.abyssData;
				ulong num;
				num += num;
				throw new NullReferenceException();
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060044C6 RID: 17606 RVA: 0x0015D4C8 File Offset: 0x0015B6C8
		[Token(Token = "0x17000784")]
		public int RemainingCapacity
		{
			[Token(Token = "0x60044C6")]
			[Address(RVA = "0x8263E0", Offset = "0x8249E0", VA = "0x1808263E0")]
			get
			{
				AbyssData abyssData = GameAPP.config.abyssData;
				List<PlantType> list = this.currentPlants;
				ulong num;
				num += num;
				throw new NullReferenceException();
			}
		}

		// Token: 0x060044C7 RID: 17607 RVA: 0x0015D4F4 File Offset: 0x0015B6F4
		[Token(Token = "0x60044C7")]
		[Address(RVA = "0x8260F0", Offset = "0x8246F0", VA = "0x1808260F0")]
		public AbyssData()
		{
			List<PlantType> list = new List();
			this.currentPlants = list;
			List<ZombieType> list2 = new List();
			this.zombies = list2;
			List<PlantType> list3 = new List();
			this.meetPlants = list3;
			List<ZombieBuff> list4 = new List();
			this.zombieBuffs = list4;
			List<ReinforceData> list5 = new List();
			this.reinforceDatas = list5;
			base..ctor();
			List<PlantType> list6 = new List();
			int num = 0;
			int size = list6._size;
			list6._size = list6;
			int size2 = list6._size;
			list6._size = list6;
			int size3 = list6._size;
			list6._size = list6;
			num++;
			this.AddPlants(list6);
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x0015D5AC File Offset: 0x0015B7AC
		[Token(Token = "0x60044C8")]
		[Address(RVA = "0x8260A0", Offset = "0x8246A0", VA = "0x1808260A0")]
		public bool UseTicket(Quality quality, int count)
		{
			return ((quality != Quality.Default && quality != Quality.Default && quality != Quality.Default && quality != Quality.silver) || this.woodenTicket < count) && false;
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x0015D5D8 File Offset: 0x0015B7D8
		[Token(Token = "0x60044C9")]
		[Address(RVA = "0x826050", Offset = "0x824650", VA = "0x180826050")]
		public void GetTicket(Quality quality, int count)
		{
			if (quality != Quality.Default)
			{
				if (quality == Quality.Default)
				{
					int num = this.silverTicket;
					num += count;
					this.silverTicket = num;
					return;
				}
				if (quality == Quality.Default)
				{
					int num2 = this.goldTicket;
					num2 += count;
					this.goldTicket = num2;
					return;
				}
				if (quality == Quality.silver)
				{
					int num3 = this.diamondTicket;
					num3 += count;
					this.diamondTicket = num3;
					return;
				}
			}
			else
			{
				int num4 = this.woodenTicket;
				num4 += count;
				this.woodenTicket = num4;
			}
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x0015D640 File Offset: 0x0015B840
		[Token(Token = "0x60044CA")]
		[Address(RVA = "0x825B50", Offset = "0x824150", VA = "0x180825B50")]
		public void AddPlant(PlantType plantType)
		{
			List<PlantType> list = this.currentPlants;
			int size = list._size;
			int num = (int)(plantType + 1);
			list._size = num;
			List<PlantType> list2 = this.meetPlants;
			List<PlantType> list3 = this.currentPlants;
			Func<PlantType, PlantType> <>9__18_ = AbyssData.<>c.<>9__18_0;
			if (<>9__18_ == 0)
			{
				Func<PlantType, PlantType> func;
				AbyssData.<>c.<>9__18_0 = func;
			}
			List<PlantType> list4 = Enumerable.ToList<PlantType>(Enumerable.OrderBy<PlantType, PlantType>(list3, <>9__18_));
			this.currentPlants = list4;
			throw new NullReferenceException();
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x0015D6B0 File Offset: 0x0015B8B0
		[Token(Token = "0x60044CB")]
		[Address(RVA = "0x825D50", Offset = "0x824350", VA = "0x180825D50")]
		public void AddPlants(List<PlantType> plants)
		{
			ulong num2;
			do
			{
				int num = 0;
				bool flag;
				if (flag)
				{
					List<PlantType> list = this.currentPlants;
					int size = list._size;
					list._size = 1;
					bool flag2 = ListExtensions.TryAddUnique<PlantType>(this.meetPlants, (PlantType)num);
				}
			}
			while (num2 != (ulong)0L);
			if (AbyssData.<>c.<>9__19_0 == 0)
			{
				Func<PlantType, PlantType> func;
				AbyssData.<>c.<>9__19_0 = func;
			}
			IOrderedEnumerable<PlantType> orderedEnumerable;
			List<PlantType> list2 = Enumerable.ToList<PlantType>(orderedEnumerable);
		}

		// Token: 0x04003150 RID: 12624
		[Token(Token = "0x4003150")]
		private const int CountPerRow = 16;

		// Token: 0x04003151 RID: 12625
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003151")]
		public int arrivedLevel = (int)((ulong)1L);

		// Token: 0x04003152 RID: 12626
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4003152")]
		public int woodenTicket;

		// Token: 0x04003153 RID: 12627
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003153")]
		public int silverTicket;

		// Token: 0x04003154 RID: 12628
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4003154")]
		public int goldTicket;

		// Token: 0x04003155 RID: 12629
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003155")]
		public int diamondTicket;

		// Token: 0x04003156 RID: 12630
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4003156")]
		public List<PlantType> currentPlants;

		// Token: 0x04003157 RID: 12631
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003157")]
		public List<ZombieType> zombies;

		// Token: 0x04003158 RID: 12632
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003158")]
		public List<PlantType> meetPlants;

		// Token: 0x04003159 RID: 12633
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003159")]
		public List<ZombieBuff> zombieBuffs;

		// Token: 0x0400315A RID: 12634
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400315A")]
		public List<ReinforceData> reinforceDatas;
	}
}
