using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D0D RID: 3341
	[Token(Token = "0x2000D0D")]
	public class DoomChomper : BaseConfig
	{
		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06004560 RID: 17760 RVA: 0x00164860 File Offset: 0x00162A60
		[Token(Token = "0x170006EA")]
		public override string Role
		{
			[Token(Token = "0x6004560")]
			[Address(RVA = "0x8AB3A0", Offset = "0x8A99A0", VA = "0x1808AB3A0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06004561 RID: 17761 RVA: 0x00164874 File Offset: 0x00162A74
		[Token(Token = "0x170006EB")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004561")]
			[Address(RVA = "0x8AA260", Offset = "0x8A8860", VA = "0x1808AA260", Slot = "4")]
			get
			{
				return PlantType.DoomChomper;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06004562 RID: 17762 RVA: 0x00164888 File Offset: 0x00162A88
		[Token(Token = "0x170006EC")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004562")]
			[Address(RVA = "0x8AB0F0", Offset = "0x8A96F0", VA = "0x1808AB0F0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				DoomChomper.UniqueUpgrade uniqueUpgrade = new DoomChomper.UniqueUpgrade();
				int size3 = list._size;
				DoomChomper.ChompBuff chompBuff = new DoomChomper.ChompBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06004563 RID: 17763 RVA: 0x001648E0 File Offset: 0x00162AE0
		[Token(Token = "0x6004563")]
		[Address(RVA = "0x8AB030", Offset = "0x8A9630", VA = "0x1808AB030", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			bool flag = "{il2cpp field on {'Chomper' (constant value of type Mono.Cecil.TypeReference)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(Chomper).TypeHandle;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 1f, num2 != 0, num);
		}

		// Token: 0x06004564 RID: 17764 RVA: 0x00164918 File Offset: 0x00162B18
		[Token(Token = "0x6004564")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public DoomChomper()
		{
		}

		// Token: 0x02000D0E RID: 3342
		[Token(Token = "0x2000D0E")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x170006ED RID: 1773
			// (get) Token: 0x06004565 RID: 17765 RVA: 0x0016492C File Offset: 0x00162B2C
			[Token(Token = "0x170006ED")]
			public override string Title
			{
				[Token(Token = "0x6004565")]
				[Address(RVA = "0x8C6D20", Offset = "0x8C5320", VA = "0x1808C6D20", Slot = "5")]
				get
				{
					return "强化：爆炸";
				}
			}

			// Token: 0x170006EE RID: 1774
			// (get) Token: 0x06004566 RID: 17766 RVA: 0x00164940 File Offset: 0x00162B40
			[Token(Token = "0x170006EE")]
			public override string Description
			{
				[Token(Token = "0x6004566")]
				[Address(RVA = "0x8C6630", Offset = "0x8C4C30", VA = "0x1808C6630", Slot = "6")]
				get
				{
					return base.PlantName + "爆炸数+1";
				}
			}

			// Token: 0x170006EF RID: 1775
			// (get) Token: 0x06004567 RID: 17767 RVA: 0x00164960 File Offset: 0x00162B60
			[Token(Token = "0x170006EF")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004567")]
				[Address(RVA = "0x8AA260", Offset = "0x8A8860", VA = "0x1808AA260", Slot = "4")]
				get
				{
					return PlantType.DoomChomper;
				}
			}

			// Token: 0x170006F0 RID: 1776
			// (get) Token: 0x06004568 RID: 17768 RVA: 0x00164974 File Offset: 0x00162B74
			[Token(Token = "0x170006F0")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004568")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004569 RID: 17769 RVA: 0x00164988 File Offset: 0x00162B88
			[Token(Token = "0x6004569")]
			[Address(RVA = "0x8C5BD0", Offset = "0x8C41D0", VA = "0x1808C5BD0", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x170006F1 RID: 1777
			// (get) Token: 0x0600456A RID: 17770 RVA: 0x001649A8 File Offset: 0x00162BA8
			[Token(Token = "0x170006F1")]
			public override Quality Rarity
			{
				[Token(Token = "0x600456A")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x0600456B RID: 17771 RVA: 0x001649B8 File Offset: 0x00162BB8
			[Token(Token = "0x600456B")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000D0F RID: 3343
		[Token(Token = "0x2000D0F")]
		private class ChompBuff : BaseBuff
		{
			// Token: 0x170006F2 RID: 1778
			// (get) Token: 0x0600456C RID: 17772 RVA: 0x001649CC File Offset: 0x00162BCC
			[Token(Token = "0x170006F2")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600456C")]
				[Address(RVA = "0x8AA260", Offset = "0x8A8860", VA = "0x1808AA260", Slot = "4")]
				get
				{
					return PlantType.DoomChomper;
				}
			}

			// Token: 0x170006F3 RID: 1779
			// (get) Token: 0x0600456D RID: 17773 RVA: 0x001649E0 File Offset: 0x00162BE0
			[Token(Token = "0x170006F3")]
			public override string Title
			{
				[Token(Token = "0x600456D")]
				[Address(RVA = "0x8AA270", Offset = "0x8A8870", VA = "0x1808AA270", Slot = "5")]
				get
				{
					return "质变：毁灭";
				}
			}

			// Token: 0x170006F4 RID: 1780
			// (get) Token: 0x0600456E RID: 17774 RVA: 0x001649F4 File Offset: 0x00162BF4
			[Token(Token = "0x170006F4")]
			public override string Description
			{
				[Token(Token = "0x600456E")]
				[Address(RVA = "0x8AA210", Offset = "0x8A8810", VA = "0x1808AA210", Slot = "6")]
				get
				{
					return base.PlantName + "攻击时没有吞噬僵尸也将释放爆炸，吞下则释放两次";
				}
			}

			// Token: 0x170006F5 RID: 1781
			// (get) Token: 0x0600456F RID: 17775 RVA: 0x00164A14 File Offset: 0x00162C14
			[Token(Token = "0x170006F5")]
			public override Quality Rarity
			{
				[Token(Token = "0x600456F")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x170006F6 RID: 1782
			// (get) Token: 0x06004570 RID: 17776 RVA: 0x00164A24 File Offset: 0x00162C24
			[Token(Token = "0x170006F6")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004570")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170006F7 RID: 1783
			// (get) Token: 0x06004571 RID: 17777 RVA: 0x00164A38 File Offset: 0x00162C38
			[Token(Token = "0x170006F7")]
			public override int MaxCount
			{
				[Token(Token = "0x6004571")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x06004572 RID: 17778 RVA: 0x00164A48 File Offset: 0x00162C48
			[Token(Token = "0x6004572")]
			[Address(RVA = "0x8AA1B0", Offset = "0x8A87B0", VA = "0x1808AA1B0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12004));
			}

			// Token: 0x06004573 RID: 17779 RVA: 0x00164A70 File Offset: 0x00162C70
			[Token(Token = "0x6004573")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public ChompBuff()
			{
			}
		}
	}
}
