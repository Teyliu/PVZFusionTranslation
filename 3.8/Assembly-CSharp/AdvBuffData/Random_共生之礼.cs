using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000D15 RID: 3349
	[Token(Token = "0x2000D15")]
	public class Random_共生之礼 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060045F3 RID: 17907 RVA: 0x00161DF4 File Offset: 0x0015FFF4
		[Token(Token = "0x170007DD")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60045F3")]
			[Address(RVA = "0x84A490", Offset = "0x848A90", VA = "0x18084A490", Slot = "12")]
			get
			{
				return AdvBuff.Random_共生之礼;
			}
		}

		// Token: 0x060045F4 RID: 17908 RVA: 0x00161E08 File Offset: 0x00160008
		[Token(Token = "0x60045F4")]
		[Address(RVA = "0x84A2E0", Offset = "0x8488E0", VA = "0x18084A2E0", Slot = "13")]
		public override string GetDescription()
		{
			return "共生之礼：当你首次获得两个一样的植物时，额外获得一个该植物卡牌";
		}

		// Token: 0x060045F5 RID: 17909 RVA: 0x00161E1C File Offset: 0x0016001C
		[Token(Token = "0x60045F5")]
		[Address(RVA = "0x84A310", Offset = "0x848910", VA = "0x18084A310", Slot = "17")]
		public override void OnSelect(Board board)
		{
			HashSet<PlantType> hashSet = Enumerable.ToHashSet<PlantType>(GameAPP.resourcesManager.allPlants);
			HashSet<PlantType> plantTypes = hashSet;
			int num = 0;
			Action<object> action;
			EventManager.AddListener_obj((GameEvent)((uint)8), action, num != 0);
		}

		// Token: 0x060045F6 RID: 17910 RVA: 0x00161E58 File Offset: 0x00160058
		[Token(Token = "0x60045F6")]
		[Address(RVA = "0x84A450", Offset = "0x848A50", VA = "0x18084A450")]
		public Random_共生之礼()
		{
		}
	}
}
