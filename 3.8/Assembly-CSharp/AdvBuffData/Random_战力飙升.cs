using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000D04 RID: 3332
	[Token(Token = "0x2000D04")]
	public class Random_战力飙升 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060045BD RID: 17853 RVA: 0x001617B8 File Offset: 0x0015F9B8
		[Token(Token = "0x170007D4")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60045BD")]
			[Address(RVA = "0x84B0B0", Offset = "0x8496B0", VA = "0x18084B0B0", Slot = "12")]
			get
			{
				return AdvBuff.Random_战力飙升;
			}
		}

		// Token: 0x060045BE RID: 17854 RVA: 0x001617CC File Offset: 0x0015F9CC
		[Token(Token = "0x60045BE")]
		[Address(RVA = "0x84AD50", Offset = "0x849350", VA = "0x18084AD50", Slot = "13")]
		public override string GetDescription()
		{
			return "战力飙升：获得一个随机的究极植物，每一波僵尸出现时，该植物获得25%伤害加成，25%血量加成，10%速度加成";
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x001617E0 File Offset: 0x0015F9E0
		[Token(Token = "0x60045BF")]
		[Address(RVA = "0x84AD80", Offset = "0x849380", VA = "0x18084AD80", Slot = "17")]
		public override void OnSelect(Board board)
		{
			List<KeyValuePair<PlantType, ValueTuple<PlantType?, object, object, bool>>> list = Enumerable.ToList<KeyValuePair<PlantType, ValueTuple<PlantType?, object, object, bool>>>(TravelDictionary.PlantInfo);
			Func<KeyValuePair<PlantType, ValueTuple<PlantType?, object, object, bool>>, bool> <>9__3_ = Random_战力飙升.<>c.<>9__3_0;
			if (<>9__3_ == 0)
			{
				Func<KeyValuePair<PlantType, ValueTuple<PlantType?, object, object, bool>>, bool> func;
				Random_战力飙升.<>c.<>9__3_0 = func;
			}
			List<KeyValuePair<PlantType, ValueTuple<PlantType?, object, object, bool>>> list2 = Enumerable.ToList<KeyValuePair<PlantType, ValueTuple<PlantType?, object, object, bool>>>(Enumerable.Where<KeyValuePair<PlantType, ValueTuple<PlantType?, object, object, bool>>>(list, <>9__3_));
			Action<Plant> action;
			if (Random_战力飙升.<>c.<>9__3_1 == 0)
			{
				Random_战力飙升.<>c.<>9__3_1 = action;
			}
			DroppedCard droppedCard;
			droppedCard.plantAction = action;
			throw new NullReferenceException();
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x00161834 File Offset: 0x0015FA34
		[Token(Token = "0x60045C0")]
		[Address(RVA = "0x84B070", Offset = "0x849670", VA = "0x18084B070")]
		public Random_战力飙升()
		{
		}
	}
}
