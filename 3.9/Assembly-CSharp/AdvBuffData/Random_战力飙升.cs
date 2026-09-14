using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DCC RID: 3532
	[Token(Token = "0x2000DCC")]
	public class Random_战力飙升 : BaseBuff<AdvBuff>
	{
		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x0600495E RID: 18782 RVA: 0x0016BC2C File Offset: 0x00169E2C
		[Token(Token = "0x1700093F")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x600495E")]
			[Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0", Slot = "12")]
			get
			{
				return AdvBuff.Random_战力飙升;
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x0600495F RID: 18783 RVA: 0x0016BC40 File Offset: 0x00169E40
		[Token(Token = "0x17000940")]
		public override string Description
		{
			[Token(Token = "0x600495F")]
			[Address(RVA = "0x8B1C80", Offset = "0x8B0280", VA = "0x1808B1C80", Slot = "13")]
			get
			{
				return "战力飙升：获得一个随机的究极植物，每一波僵尸出现时，该植物获得25%伤害加成，25%血量加成，10%速度加成";
			}
		}

		// Token: 0x06004960 RID: 18784 RVA: 0x0016BC54 File Offset: 0x00169E54
		[Token(Token = "0x6004960")]
		[Address(RVA = "0x8B1950", Offset = "0x8AFF50", VA = "0x1808B1950", Slot = "17")]
		public override void OnSelect(Board board)
		{
			List<KeyValuePair<PlantType, ValueTuple<PlantType?, object, object, bool>>> list = Enumerable.ToList<KeyValuePair<PlantType, ValueTuple<PlantType?, object, object, bool>>>(TravelDictionary.PlantInfo);
			Func<KeyValuePair<PlantType, ValueTuple<PlantType?, object, object, bool>>, bool> <>9__4_ = Random_战力飙升.<>c.<>9__4_0;
			if (<>9__4_ == 0)
			{
				Func<KeyValuePair<PlantType, ValueTuple<PlantType?, object, object, bool>>, bool> func;
				Random_战力飙升.<>c.<>9__4_0 = func;
			}
			List<KeyValuePair<PlantType, ValueTuple<PlantType?, object, object, bool>>> list2 = Enumerable.ToList<KeyValuePair<PlantType, ValueTuple<PlantType?, object, object, bool>>>(Enumerable.Where<KeyValuePair<PlantType, ValueTuple<PlantType?, object, object, bool>>>(list, <>9__4_));
			Action<Plant> action;
			if (Random_战力飙升.<>c.<>9__4_1 == 0)
			{
				Random_战力飙升.<>c.<>9__4_1 = action;
			}
			DroppedCard droppedCard;
			droppedCard.plantAction = action;
			throw new NullReferenceException();
		}

		// Token: 0x06004961 RID: 18785 RVA: 0x0016BCA8 File Offset: 0x00169EA8
		[Token(Token = "0x6004961")]
		[Address(RVA = "0x8B1C40", Offset = "0x8B0240", VA = "0x1808B1C40")]
		public Random_战力飙升()
		{
		}
	}
}
