using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D97 RID: 3479
	[Token(Token = "0x2000D97")]
	public class Bamboo : BaseConfig
	{
		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06004873 RID: 18547 RVA: 0x0016A168 File Offset: 0x00168368
		[Token(Token = "0x170008D2")]
		public override string Role
		{
			[Token(Token = "0x6004873")]
			[Address(RVA = "0x8A8530", Offset = "0x8A6B30", VA = "0x1808A8530", Slot = "7")]
			get
			{
				return "防御";
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06004874 RID: 18548 RVA: 0x0016A17C File Offset: 0x0016837C
		[Token(Token = "0x170008D3")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004874")]
			[Address(RVA = "0x716B30", Offset = "0x715130", VA = "0x180716B30", Slot = "4")]
			get
			{
				return PlantType.Bamboo;
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06004875 RID: 18549 RVA: 0x0016A18C File Offset: 0x0016838C
		[Token(Token = "0x170008D4")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004875")]
			[Address(RVA = "0x8A8420", Offset = "0x8A6A20", VA = "0x1808A8420", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004876 RID: 18550 RVA: 0x0016A1B8 File Offset: 0x001683B8
		[Token(Token = "0x6004876")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x06004877 RID: 18551 RVA: 0x0016A1C8 File Offset: 0x001683C8
		[Token(Token = "0x6004877")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public Bamboo()
		{
		}
	}
}
