using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UI;

namespace GameLevel.Abyss
{
	// Token: 0x02000C39 RID: 3129
	[Token(Token = "0x2000C39")]
	[Serializable]
	public class AbyssData
	{
		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x0600412F RID: 16687 RVA: 0x00157444 File Offset: 0x00155644
		[Token(Token = "0x1700050D")]
		public int StorageSize
		{
			[Token(Token = "0x600412F")]
			[Address(RVA = "0x873AD0", Offset = "0x8720D0", VA = "0x180873AD0")]
			get
			{
				AbyssData abyssData = GameAPP.config.abyssData;
				ulong num;
				num += num;
				throw new NullReferenceException();
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06004130 RID: 16688 RVA: 0x00157468 File Offset: 0x00155668
		[Token(Token = "0x1700050E")]
		public int RemainingCapacity
		{
			[Token(Token = "0x6004130")]
			[Address(RVA = "0x873A80", Offset = "0x872080", VA = "0x180873A80")]
			get
			{
				int storageSize = this.StorageSize;
				List<PlantType> list = this.currentPlants;
				return storageSize;
			}
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x0015748C File Offset: 0x0015568C
		[Token(Token = "0x6004131")]
		[Address(RVA = "0x873790", Offset = "0x871D90", VA = "0x180873790")]
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

		// Token: 0x06004132 RID: 16690 RVA: 0x00157544 File Offset: 0x00155744
		[Token(Token = "0x6004132")]
		[Address(RVA = "0x873740", Offset = "0x871D40", VA = "0x180873740")]
		public bool UseTicket(Quality quality, int count)
		{
			return ((quality != Quality.Default && quality != Quality.Default && quality != Quality.Default && quality != Quality.silver) || this.woodenTicket < count) && false;
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x00157570 File Offset: 0x00155770
		[Token(Token = "0x6004133")]
		[Address(RVA = "0x8736F0", Offset = "0x871CF0", VA = "0x1808736F0")]
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

		// Token: 0x06004134 RID: 16692 RVA: 0x001575D8 File Offset: 0x001557D8
		[Token(Token = "0x6004134")]
		[Address(RVA = "0x8731F0", Offset = "0x8717F0", VA = "0x1808731F0")]
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

		// Token: 0x06004135 RID: 16693 RVA: 0x00157648 File Offset: 0x00155848
		[Token(Token = "0x6004135")]
		[Address(RVA = "0x8733F0", Offset = "0x8719F0", VA = "0x1808733F0")]
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

		// Token: 0x040031F5 RID: 12789
		[Token(Token = "0x40031F5")]
		private const int CountPerRow = 16;

		// Token: 0x040031F6 RID: 12790
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40031F6")]
		public int arrivedLevel = (int)((ulong)1L);

		// Token: 0x040031F7 RID: 12791
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40031F7")]
		public int woodenTicket;

		// Token: 0x040031F8 RID: 12792
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40031F8")]
		public int silverTicket;

		// Token: 0x040031F9 RID: 12793
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40031F9")]
		public int goldTicket;

		// Token: 0x040031FA RID: 12794
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40031FA")]
		public int diamondTicket;

		// Token: 0x040031FB RID: 12795
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40031FB")]
		public List<PlantType> currentPlants;

		// Token: 0x040031FC RID: 12796
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40031FC")]
		public List<ZombieType> zombies;

		// Token: 0x040031FD RID: 12797
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40031FD")]
		public List<PlantType> meetPlants;

		// Token: 0x040031FE RID: 12798
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40031FE")]
		public List<ZombieBuff> zombieBuffs;

		// Token: 0x040031FF RID: 12799
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40031FF")]
		public List<ReinforceData> reinforceDatas;
	}
}
