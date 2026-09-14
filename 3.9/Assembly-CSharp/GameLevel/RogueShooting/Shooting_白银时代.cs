using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CA3 RID: 3235
	[Token(Token = "0x2000CA3")]
	public class Shooting_白银时代 : BaseDebuff
	{
		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06004306 RID: 17158 RVA: 0x0015D228 File Offset: 0x0015B428
		[Token(Token = "0x170005CE")]
		public override int Point
		{
			[Token(Token = "0x6004306")]
			[Address(RVA = "0x88C900", Offset = "0x88AF00", VA = "0x18088C900", Slot = "21")]
			get
			{
				return 400;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06004307 RID: 17159 RVA: 0x0015D23C File Offset: 0x0015B43C
		[Token(Token = "0x170005CF")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x6004307")]
			[Address(RVA = "0x89FF10", Offset = "0x89E510", VA = "0x18089FF10", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_白银时代;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06004308 RID: 17160 RVA: 0x0015D250 File Offset: 0x0015B450
		[Token(Token = "0x170005D0")]
		public override string Description
		{
			[Token(Token = "0x6004308")]
			[Address(RVA = "0x89FF20", Offset = "0x89E520", VA = "0x18089FF20", Slot = "13")]
			get
			{
				return "白银时代：非保底时，具有不同品质的词条只会出现白银品质，若拥有点钻成金，则将金、钻降级为木头";
			}
		}

		// Token: 0x06004309 RID: 17161 RVA: 0x0015D264 File Offset: 0x0015B464
		[Token(Token = "0x6004309")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_白银时代()
		{
		}
	}
}
