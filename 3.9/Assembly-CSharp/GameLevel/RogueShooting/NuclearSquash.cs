using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D44 RID: 3396
	[Token(Token = "0x2000D44")]
	public class NuclearSquash : BaseConfig
	{
		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x0600469C RID: 18076 RVA: 0x00166984 File Offset: 0x00164B84
		[Token(Token = "0x170007B3")]
		public override string Role
		{
			[Token(Token = "0x600469C")]
			[Address(RVA = "0x8B0050", Offset = "0x8AE650", VA = "0x1808B0050", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x0600469D RID: 18077 RVA: 0x00166998 File Offset: 0x00164B98
		[Token(Token = "0x170007B4")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600469D")]
			[Address(RVA = "0x8AB7C0", Offset = "0x8A9DC0", VA = "0x1808AB7C0", Slot = "4")]
			get
			{
				return PlantType.NuclearSquash;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x0600469E RID: 18078 RVA: 0x001669AC File Offset: 0x00164BAC
		[Token(Token = "0x170007B5")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600469E")]
			[Address(RVA = "0x8AFEB0", Offset = "0x8AE4B0", VA = "0x1808AFEB0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				NuclearSquash.DuringBuff duringBuff = new NuclearSquash.DuringBuff();
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600469F RID: 18079 RVA: 0x001669EC File Offset: 0x00164BEC
		[Token(Token = "0x600469F")]
		[Address(RVA = "0x8AFE60", Offset = "0x8AE460", VA = "0x1808AFE60", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), -0.5f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x060046A0 RID: 18080 RVA: 0x00166A20 File Offset: 0x00164C20
		[Token(Token = "0x60046A0")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public NuclearSquash()
		{
		}

		// Token: 0x02000D45 RID: 3397
		[Token(Token = "0x2000D45")]
		private class DuringBuff : BaseBuff
		{
			// Token: 0x170007B6 RID: 1974
			// (get) Token: 0x060046A1 RID: 18081 RVA: 0x00166A34 File Offset: 0x00164C34
			[Token(Token = "0x170007B6")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60046A1")]
				[Address(RVA = "0x8AB7C0", Offset = "0x8A9DC0", VA = "0x1808AB7C0", Slot = "4")]
				get
				{
					return PlantType.NuclearSquash;
				}
			}

			// Token: 0x170007B7 RID: 1975
			// (get) Token: 0x060046A2 RID: 18082 RVA: 0x00166A48 File Offset: 0x00164C48
			[Token(Token = "0x170007B7")]
			public override string Title
			{
				[Token(Token = "0x60046A2")]
				[Address(RVA = "0x8AB7D0", Offset = "0x8A9DD0", VA = "0x1808AB7D0", Slot = "5")]
				get
				{
					return "强化：王从天降";
				}
			}

			// Token: 0x170007B8 RID: 1976
			// (get) Token: 0x060046A3 RID: 18083 RVA: 0x00166A5C File Offset: 0x00164C5C
			[Token(Token = "0x170007B8")]
			public override string Description
			{
				[Token(Token = "0x60046A3")]
				[Address(RVA = "0x8AB790", Offset = "0x8A9D90", VA = "0x1808AB790", Slot = "6")]
				get
				{
					return "辐射持续时间+1秒";
				}
			}

			// Token: 0x170007B9 RID: 1977
			// (get) Token: 0x060046A4 RID: 18084 RVA: 0x00166A70 File Offset: 0x00164C70
			[Token(Token = "0x170007B9")]
			public override Quality Rarity
			{
				[Token(Token = "0x60046A4")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x170007BA RID: 1978
			// (get) Token: 0x060046A5 RID: 18085 RVA: 0x00166A80 File Offset: 0x00164C80
			[Token(Token = "0x170007BA")]
			public override float AppearWeight
			{
				[Token(Token = "0x60046A5")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060046A6 RID: 18086 RVA: 0x00166A94 File Offset: 0x00164C94
			[Token(Token = "0x60046A6")]
			[Address(RVA = "0x8AB700", Offset = "0x8A9D00", VA = "0x1808AB700", Slot = "7")]
			public override void OnGet()
			{
				Plant plant = base.Plant;
				int num = 0;
				if (plant != num)
				{
					Plant plant2 = base.Plant;
				}
			}

			// Token: 0x060046A7 RID: 18087 RVA: 0x00166AC4 File Offset: 0x00164CC4
			[Token(Token = "0x60046A7")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public DuringBuff()
			{
			}
		}
	}
}
