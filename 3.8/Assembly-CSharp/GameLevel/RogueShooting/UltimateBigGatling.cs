using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C78 RID: 3192
	[Token(Token = "0x2000C78")]
	public class UltimateBigGatling : BaseConfig
	{
		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060042DC RID: 17116 RVA: 0x00159A5C File Offset: 0x00157C5C
		[Token(Token = "0x17000669")]
		public override string Role
		{
			[Token(Token = "0x60042DC")]
			[Address(RVA = "0x8408A0", Offset = "0x83EEA0", VA = "0x1808408A0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060042DD RID: 17117 RVA: 0x00159A70 File Offset: 0x00157C70
		[Token(Token = "0x1700066A")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60042DD")]
			[Address(RVA = "0x780E20", Offset = "0x77F420", VA = "0x180780E20", Slot = "4")]
			get
			{
				return PlantType.UltimateBigGatling;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060042DE RID: 17118 RVA: 0x00159A84 File Offset: 0x00157C84
		[Token(Token = "0x1700066B")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60042DE")]
			[Address(RVA = "0x840600", Offset = "0x83EC00", VA = "0x180840600", Slot = "5")]
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

		// Token: 0x060042DF RID: 17119 RVA: 0x00159AE0 File Offset: 0x00157CE0
		[Token(Token = "0x60042DF")]
		[Address(RVA = "0x8404E0", Offset = "0x83EAE0", VA = "0x1808404E0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			plant.AddSpeed(1f);
			Action<object> action;
			EventManager.RemoveListener((GameEvent)((uint)5), action);
			int num = 0;
			Action<object> action2;
			EventManager.AddListener_obj((GameEvent)((uint)5), action2, num != 0);
		}

		// Token: 0x060042E0 RID: 17120 RVA: 0x00159B14 File Offset: 0x00157D14
		[Token(Token = "0x60042E0")]
		[Address(RVA = "0x840370", Offset = "0x83E970", VA = "0x180840370")]
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
						int num2 = 0;
						float num3 = attributeFloat * 0.5f;
						ulong num4;
						plant2.Recover(num3, (DamageType)num2, true, num4 != 0UL);
					}
				}
			}
		}

		// Token: 0x060042E1 RID: 17121 RVA: 0x00159B80 File Offset: 0x00157D80
		[Token(Token = "0x60042E1")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateBigGatling()
		{
		}

		// Token: 0x02000C79 RID: 3193
		[Token(Token = "0x2000C79")]
		private class PierceBuff : BaseBuff
		{
			// Token: 0x1700066C RID: 1644
			// (get) Token: 0x060042E2 RID: 17122 RVA: 0x00159B94 File Offset: 0x00157D94
			[Token(Token = "0x1700066C")]
			public override string Title
			{
				[Token(Token = "0x60042E2")]
				[Address(RVA = "0x835770", Offset = "0x833D70", VA = "0x180835770", Slot = "5")]
				get
				{
					return "强化：弹射";
				}
			}

			// Token: 0x1700066D RID: 1645
			// (get) Token: 0x060042E3 RID: 17123 RVA: 0x00159BA8 File Offset: 0x00157DA8
			[Token(Token = "0x1700066D")]
			public override string Description
			{
				[Token(Token = "0x60042E3")]
				[Address(RVA = "0x8356E0", Offset = "0x833CE0", VA = "0x1808356E0", Slot = "6")]
				get
				{
					string plantName = base.PlantName;
					return "子弹弹射数量+1\n" + plantName + "的子弹命中僵尸时额外造成多次伤害，每次伤害对小范围内的敌方随机单体造成相当于子弹伤害100%的伤害";
				}
			}

			// Token: 0x1700066E RID: 1646
			// (get) Token: 0x060042E4 RID: 17124 RVA: 0x00159BCC File Offset: 0x00157DCC
			[Token(Token = "0x1700066E")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60042E4")]
				[Address(RVA = "0x780E20", Offset = "0x77F420", VA = "0x180780E20", Slot = "4")]
				get
				{
					return PlantType.UltimateBigGatling;
				}
			}

			// Token: 0x1700066F RID: 1647
			// (get) Token: 0x060042E5 RID: 17125 RVA: 0x00159BE0 File Offset: 0x00157DE0
			[Token(Token = "0x1700066F")]
			public override float AppearWeight
			{
				[Token(Token = "0x60042E5")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000670 RID: 1648
			// (get) Token: 0x060042E6 RID: 17126 RVA: 0x00159BF4 File Offset: 0x00157DF4
			[Token(Token = "0x17000670")]
			public override int MaxCount
			{
				[Token(Token = "0x60042E6")]
				[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "8")]
				get
				{
					return 10;
				}
			}

			// Token: 0x060042E7 RID: 17127 RVA: 0x00159C04 File Offset: 0x00157E04
			[Token(Token = "0x60042E7")]
			[Address(RVA = "0x835540", Offset = "0x833B40", VA = "0x180835540", Slot = "7")]
			public override void OnGet()
			{
				Plant plant = base.Plant;
				int num = 0;
				if (plant != num)
				{
					Plant plant2 = base.Plant;
				}
			}

			// Token: 0x17000671 RID: 1649
			// (get) Token: 0x060042E8 RID: 17128 RVA: 0x00159C34 File Offset: 0x00157E34
			[Token(Token = "0x17000671")]
			public override Quality Rarity
			{
				[Token(Token = "0x60042E8")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060042E9 RID: 17129 RVA: 0x00159C44 File Offset: 0x00157E44
			[Token(Token = "0x60042E9")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public PierceBuff()
			{
			}
		}

		// Token: 0x02000C7A RID: 3194
		[Token(Token = "0x2000C7A")]
		private class HealthUpgrade : BaseBuff
		{
			// Token: 0x17000672 RID: 1650
			// (get) Token: 0x060042EA RID: 17130 RVA: 0x00159C58 File Offset: 0x00157E58
			[Token(Token = "0x17000672")]
			public override string Title
			{
				[Token(Token = "0x60042EA")]
				[Address(RVA = "0x831D60", Offset = "0x830360", VA = "0x180831D60", Slot = "5")]
				get
				{
					return "强化：再生";
				}
			}

			// Token: 0x17000673 RID: 1651
			// (get) Token: 0x060042EB RID: 17131 RVA: 0x00159C6C File Offset: 0x00157E6C
			[Token(Token = "0x17000673")]
			public override string Description
			{
				[Token(Token = "0x60042EB")]
				[Address(RVA = "0x831D10", Offset = "0x830310", VA = "0x180831D10", Slot = "6")]
				get
				{
					return base.PlantName + "生命偷取+50%";
				}
			}

			// Token: 0x17000674 RID: 1652
			// (get) Token: 0x060042EC RID: 17132 RVA: 0x00159C8C File Offset: 0x00157E8C
			[Token(Token = "0x17000674")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60042EC")]
				[Address(RVA = "0x780E20", Offset = "0x77F420", VA = "0x180780E20", Slot = "4")]
				get
				{
					return PlantType.UltimateBigGatling;
				}
			}

			// Token: 0x17000675 RID: 1653
			// (get) Token: 0x060042ED RID: 17133 RVA: 0x00159CA0 File Offset: 0x00157EA0
			[Token(Token = "0x17000675")]
			public override float AppearWeight
			{
				[Token(Token = "0x60042ED")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000676 RID: 1654
			// (get) Token: 0x060042EE RID: 17134 RVA: 0x00159CB4 File Offset: 0x00157EB4
			[Token(Token = "0x17000676")]
			public override int MaxCount
			{
				[Token(Token = "0x60042EE")]
				[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "8")]
				get
				{
					return 10;
				}
			}

			// Token: 0x060042EF RID: 17135 RVA: 0x00159CC4 File Offset: 0x00157EC4
			[Token(Token = "0x60042EF")]
			[Address(RVA = "0x831C80", Offset = "0x830280", VA = "0x180831C80", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x17000677 RID: 1655
			// (get) Token: 0x060042F0 RID: 17136 RVA: 0x00159CE4 File Offset: 0x00157EE4
			[Token(Token = "0x17000677")]
			public override Quality Rarity
			{
				[Token(Token = "0x60042F0")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060042F1 RID: 17137 RVA: 0x00159CF4 File Offset: 0x00157EF4
			[Token(Token = "0x60042F1")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public HealthUpgrade()
			{
			}
		}

		// Token: 0x02000C7B RID: 3195
		[Token(Token = "0x2000C7B")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x17000678 RID: 1656
			// (get) Token: 0x060042F2 RID: 17138 RVA: 0x00159D08 File Offset: 0x00157F08
			[Token(Token = "0x17000678")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60042F2")]
				[Address(RVA = "0x780E20", Offset = "0x77F420", VA = "0x180780E20", Slot = "4")]
				get
				{
					return PlantType.UltimateBigGatling;
				}
			}

			// Token: 0x17000679 RID: 1657
			// (get) Token: 0x060042F3 RID: 17139 RVA: 0x00159D1C File Offset: 0x00157F1C
			[Token(Token = "0x17000679")]
			public override string Title
			{
				[Token(Token = "0x60042F3")]
				[Address(RVA = "0x83A580", Offset = "0x838B80", VA = "0x18083A580", Slot = "5")]
				get
				{
					return "质变：迸发";
				}
			}

			// Token: 0x1700067A RID: 1658
			// (get) Token: 0x060042F4 RID: 17140 RVA: 0x00159D30 File Offset: 0x00157F30
			[Token(Token = "0x1700067A")]
			public override string Description
			{
				[Token(Token = "0x60042F4")]
				[Address(RVA = "0x83A140", Offset = "0x838740", VA = "0x18083A140", Slot = "6")]
				get
				{
					return "炮台在释放大招过程中额外释放4次火爆辣椒效果，每次造成50段伤害，每次伤害对敌方随机单体造成等同于炮台10000%攻击力的伤害";
				}
			}

			// Token: 0x1700067B RID: 1659
			// (get) Token: 0x060042F5 RID: 17141 RVA: 0x00159D44 File Offset: 0x00157F44
			[Token(Token = "0x1700067B")]
			public override Quality Rarity
			{
				[Token(Token = "0x60042F5")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x1700067C RID: 1660
			// (get) Token: 0x060042F6 RID: 17142 RVA: 0x00159D54 File Offset: 0x00157F54
			[Token(Token = "0x1700067C")]
			public override int MaxCount
			{
				[Token(Token = "0x60042F6")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x1700067D RID: 1661
			// (get) Token: 0x060042F7 RID: 17143 RVA: 0x00159D64 File Offset: 0x00157F64
			[Token(Token = "0x1700067D")]
			public override float AppearWeight
			{
				[Token(Token = "0x60042F7")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060042F8 RID: 17144 RVA: 0x00159D78 File Offset: 0x00157F78
			[Token(Token = "0x60042F8")]
			[Address(RVA = "0x839970", Offset = "0x837F70", VA = "0x180839970", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12001));
			}

			// Token: 0x060042F9 RID: 17145 RVA: 0x00159DA0 File Offset: 0x00157FA0
			[Token(Token = "0x60042F9")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public SuperBuff()
			{
			}
		}
	}
}
