using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D4C RID: 3404
	[Token(Token = "0x2000D4C")]
	public class UltimateBigGatling : BaseConfig
	{
		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060046CC RID: 18124 RVA: 0x00166EAC File Offset: 0x001650AC
		[Token(Token = "0x170007D2")]
		public override string Role
		{
			[Token(Token = "0x60046CC")]
			[Address(RVA = "0x8C04C0", Offset = "0x8BEAC0", VA = "0x1808C04C0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060046CD RID: 18125 RVA: 0x00166EC0 File Offset: 0x001650C0
		[Token(Token = "0x170007D3")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60046CD")]
			[Address(RVA = "0x7E7CD0", Offset = "0x7E62D0", VA = "0x1807E7CD0", Slot = "4")]
			get
			{
				return PlantType.UltimateBigGatling;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060046CE RID: 18126 RVA: 0x00166ED4 File Offset: 0x001650D4
		[Token(Token = "0x170007D4")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60046CE")]
			[Address(RVA = "0x8C0220", Offset = "0x8BE820", VA = "0x1808C0220", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				UltimateBigGatling.HealthUpgrade healthUpgrade = new UltimateBigGatling.HealthUpgrade();
				int size2 = list._size;
				UltimateBigGatling.SuperBuff superBuff = new UltimateBigGatling.SuperBuff();
				int size3 = list._size;
				UltimateBigGatling.PierceBuff pierceBuff = new UltimateBigGatling.PierceBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x060046CF RID: 18127 RVA: 0x00166F30 File Offset: 0x00165130
		[Token(Token = "0x60046CF")]
		[Address(RVA = "0x8C0100", Offset = "0x8BE700", VA = "0x1808C0100", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			plant.AddSpeed(1f);
			Action<object> action;
			EventManager.RemoveListener((GameEvent)((uint)5), action);
			int num = 0;
			Action<object> action2;
			EventManager.AddListener_obj((GameEvent)((uint)5), action2, num != 0);
		}

		// Token: 0x060046D0 RID: 18128 RVA: 0x00166F64 File Offset: 0x00165164
		[Token(Token = "0x60046D0")]
		[Address(RVA = "0x8BFF80", Offset = "0x8BE580", VA = "0x1808BFF80")]
		private void OnZombieTakeDamage(object obj)
		{
			if (obj != 0 && obj != 0)
			{
				PlantType plantType = this.PlantType;
				if (this == plantType)
				{
					Plant plant = base.Plant;
					int num = 0;
					if (plant != num)
					{
						Plant plant2 = base.Plant;
						float attributeFloat = base.Plant.attributeFloat;
						float num2 = attributeFloat * 0.5f;
						int num3 = 0;
						ulong num4;
						plant2.Recover(num2, (DamageType)num3, true, num4 != 0UL);
					}
				}
			}
		}

		// Token: 0x060046D1 RID: 18129 RVA: 0x00166FD0 File Offset: 0x001651D0
		[Token(Token = "0x60046D1")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateBigGatling()
		{
		}

		// Token: 0x02000D4D RID: 3405
		[Token(Token = "0x2000D4D")]
		private class PierceBuff : BaseBuff
		{
			// Token: 0x170007D5 RID: 2005
			// (get) Token: 0x060046D2 RID: 18130 RVA: 0x00166FE4 File Offset: 0x001651E4
			[Token(Token = "0x170007D5")]
			public override string Title
			{
				[Token(Token = "0x60046D2")]
				[Address(RVA = "0x8B11C0", Offset = "0x8AF7C0", VA = "0x1808B11C0", Slot = "5")]
				get
				{
					return "强化：弹射";
				}
			}

			// Token: 0x170007D6 RID: 2006
			// (get) Token: 0x060046D3 RID: 18131 RVA: 0x00166FF8 File Offset: 0x001651F8
			[Token(Token = "0x170007D6")]
			public override string Description
			{
				[Token(Token = "0x60046D3")]
				[Address(RVA = "0x8B1130", Offset = "0x8AF730", VA = "0x1808B1130", Slot = "6")]
				get
				{
					string plantName = base.PlantName;
					return "子弹弹射数量+1\n" + plantName + "的子弹命中僵尸时额外造成多次伤害，每次伤害对小范围内的敌方随机单体造成相当于子弹伤害100%的伤害";
				}
			}

			// Token: 0x170007D7 RID: 2007
			// (get) Token: 0x060046D4 RID: 18132 RVA: 0x0016701C File Offset: 0x0016521C
			[Token(Token = "0x170007D7")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60046D4")]
				[Address(RVA = "0x7E7CD0", Offset = "0x7E62D0", VA = "0x1807E7CD0", Slot = "4")]
				get
				{
					return PlantType.UltimateBigGatling;
				}
			}

			// Token: 0x170007D8 RID: 2008
			// (get) Token: 0x060046D5 RID: 18133 RVA: 0x00167030 File Offset: 0x00165230
			[Token(Token = "0x170007D8")]
			public override float AppearWeight
			{
				[Token(Token = "0x60046D5")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170007D9 RID: 2009
			// (get) Token: 0x060046D6 RID: 18134 RVA: 0x00167044 File Offset: 0x00165244
			[Token(Token = "0x170007D9")]
			public override int MaxCount
			{
				[Token(Token = "0x60046D6")]
				[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "8")]
				get
				{
					return 10;
				}
			}

			// Token: 0x060046D7 RID: 18135 RVA: 0x00167054 File Offset: 0x00165254
			[Token(Token = "0x60046D7")]
			[Address(RVA = "0x8B0F90", Offset = "0x8AF590", VA = "0x1808B0F90", Slot = "7")]
			public override void OnGet()
			{
				Plant plant = base.Plant;
				int num = 0;
				if (plant != num)
				{
					Plant plant2 = base.Plant;
				}
			}

			// Token: 0x170007DA RID: 2010
			// (get) Token: 0x060046D8 RID: 18136 RVA: 0x00167084 File Offset: 0x00165284
			[Token(Token = "0x170007DA")]
			public override Quality Rarity
			{
				[Token(Token = "0x60046D8")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060046D9 RID: 18137 RVA: 0x00167094 File Offset: 0x00165294
			[Token(Token = "0x60046D9")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public PierceBuff()
			{
			}
		}

		// Token: 0x02000D4E RID: 3406
		[Token(Token = "0x2000D4E")]
		private class HealthUpgrade : BaseBuff
		{
			// Token: 0x170007DB RID: 2011
			// (get) Token: 0x060046DA RID: 18138 RVA: 0x001670A8 File Offset: 0x001652A8
			[Token(Token = "0x170007DB")]
			public override string Title
			{
				[Token(Token = "0x60046DA")]
				[Address(RVA = "0x8AD360", Offset = "0x8AB960", VA = "0x1808AD360", Slot = "5")]
				get
				{
					return "强化：再生";
				}
			}

			// Token: 0x170007DC RID: 2012
			// (get) Token: 0x060046DB RID: 18139 RVA: 0x001670BC File Offset: 0x001652BC
			[Token(Token = "0x170007DC")]
			public override string Description
			{
				[Token(Token = "0x60046DB")]
				[Address(RVA = "0x8AD310", Offset = "0x8AB910", VA = "0x1808AD310", Slot = "6")]
				get
				{
					return base.PlantName + "生命偷取+50%";
				}
			}

			// Token: 0x170007DD RID: 2013
			// (get) Token: 0x060046DC RID: 18140 RVA: 0x001670DC File Offset: 0x001652DC
			[Token(Token = "0x170007DD")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60046DC")]
				[Address(RVA = "0x7E7CD0", Offset = "0x7E62D0", VA = "0x1807E7CD0", Slot = "4")]
				get
				{
					return PlantType.UltimateBigGatling;
				}
			}

			// Token: 0x170007DE RID: 2014
			// (get) Token: 0x060046DD RID: 18141 RVA: 0x001670F0 File Offset: 0x001652F0
			[Token(Token = "0x170007DE")]
			public override float AppearWeight
			{
				[Token(Token = "0x60046DD")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170007DF RID: 2015
			// (get) Token: 0x060046DE RID: 18142 RVA: 0x00167104 File Offset: 0x00165304
			[Token(Token = "0x170007DF")]
			public override int MaxCount
			{
				[Token(Token = "0x60046DE")]
				[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "8")]
				get
				{
					return 10;
				}
			}

			// Token: 0x060046DF RID: 18143 RVA: 0x00167114 File Offset: 0x00165314
			[Token(Token = "0x60046DF")]
			[Address(RVA = "0x8AD280", Offset = "0x8AB880", VA = "0x1808AD280", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x170007E0 RID: 2016
			// (get) Token: 0x060046E0 RID: 18144 RVA: 0x00167134 File Offset: 0x00165334
			[Token(Token = "0x170007E0")]
			public override Quality Rarity
			{
				[Token(Token = "0x60046E0")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060046E1 RID: 18145 RVA: 0x00167144 File Offset: 0x00165344
			[Token(Token = "0x60046E1")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public HealthUpgrade()
			{
			}
		}

		// Token: 0x02000D4F RID: 3407
		[Token(Token = "0x2000D4F")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x170007E1 RID: 2017
			// (get) Token: 0x060046E2 RID: 18146 RVA: 0x00167158 File Offset: 0x00165358
			[Token(Token = "0x170007E1")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60046E2")]
				[Address(RVA = "0x7E7CD0", Offset = "0x7E62D0", VA = "0x1807E7CD0", Slot = "4")]
				get
				{
					return PlantType.UltimateBigGatling;
				}
			}

			// Token: 0x170007E2 RID: 2018
			// (get) Token: 0x060046E3 RID: 18147 RVA: 0x0016716C File Offset: 0x0016536C
			[Token(Token = "0x170007E2")]
			public override string Title
			{
				[Token(Token = "0x60046E3")]
				[Address(RVA = "0x8B7330", Offset = "0x8B5930", VA = "0x1808B7330", Slot = "5")]
				get
				{
					return "质变：迸发";
				}
			}

			// Token: 0x170007E3 RID: 2019
			// (get) Token: 0x060046E4 RID: 18148 RVA: 0x00167180 File Offset: 0x00165380
			[Token(Token = "0x170007E3")]
			public override string Description
			{
				[Token(Token = "0x60046E4")]
				[Address(RVA = "0x8B6D90", Offset = "0x8B5390", VA = "0x1808B6D90", Slot = "6")]
				get
				{
					return "炮台在释放大招过程中额外释放4次火爆辣椒效果，每次造成50段伤害，每次伤害对敌方随机单体造成等同于炮台10000%攻击力的伤害";
				}
			}

			// Token: 0x170007E4 RID: 2020
			// (get) Token: 0x060046E5 RID: 18149 RVA: 0x00167194 File Offset: 0x00165394
			[Token(Token = "0x170007E4")]
			public override Quality Rarity
			{
				[Token(Token = "0x60046E5")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x170007E5 RID: 2021
			// (get) Token: 0x060046E6 RID: 18150 RVA: 0x001671A4 File Offset: 0x001653A4
			[Token(Token = "0x170007E5")]
			public override int MaxCount
			{
				[Token(Token = "0x60046E6")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x170007E6 RID: 2022
			// (get) Token: 0x060046E7 RID: 18151 RVA: 0x001671B4 File Offset: 0x001653B4
			[Token(Token = "0x170007E6")]
			public override float AppearWeight
			{
				[Token(Token = "0x60046E7")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060046E8 RID: 18152 RVA: 0x001671C8 File Offset: 0x001653C8
			[Token(Token = "0x60046E8")]
			[Address(RVA = "0x8B62C0", Offset = "0x8B48C0", VA = "0x1808B62C0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12001));
			}

			// Token: 0x060046E9 RID: 18153 RVA: 0x001671F0 File Offset: 0x001653F0
			[Token(Token = "0x60046E9")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperBuff()
			{
			}
		}
	}
}
