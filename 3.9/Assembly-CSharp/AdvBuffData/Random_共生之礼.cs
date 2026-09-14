using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DDD RID: 3549
	[Token(Token = "0x2000DDD")]
	public class Random_共生之礼 : BaseBuff<AdvBuff>
	{
		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06004994 RID: 18836 RVA: 0x0016C248 File Offset: 0x0016A448
		[Token(Token = "0x17000951")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004994")]
			[Address(RVA = "0x8A0840", Offset = "0x89EE40", VA = "0x1808A0840", Slot = "12")]
			get
			{
				return AdvBuff.Random_共生之礼;
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06004995 RID: 18837 RVA: 0x0016C25C File Offset: 0x0016A45C
		[Token(Token = "0x17000952")]
		public override string Description
		{
			[Token(Token = "0x6004995")]
			[Address(RVA = "0x8CF7C0", Offset = "0x8CDDC0", VA = "0x1808CF7C0", Slot = "13")]
			get
			{
				return "共生之礼：当你首次获得两个一样的植物时，额外获得一个该植物卡牌";
			}
		}

		// Token: 0x06004996 RID: 18838 RVA: 0x0016C270 File Offset: 0x0016A470
		[Token(Token = "0x6004996")]
		[Address(RVA = "0x8CF640", Offset = "0x8CDC40", VA = "0x1808CF640", Slot = "17")]
		public override void OnSelect(Board board)
		{
			HashSet<PlantType> hashSet = Enumerable.ToHashSet<PlantType>(GameAPP.resourcesManager.allPlants);
			HashSet<PlantType> plantTypes = hashSet;
			int num = 0;
			Action<object> action;
			EventManager.AddListener_obj((GameEvent)((uint)8), action, num != 0);
		}

		// Token: 0x06004997 RID: 18839 RVA: 0x0016C2AC File Offset: 0x0016A4AC
		[Token(Token = "0x6004997")]
		[Address(RVA = "0x8CF780", Offset = "0x8CDD80", VA = "0x1808CF780")]
		public Random_共生之礼()
		{
		}
	}
}
