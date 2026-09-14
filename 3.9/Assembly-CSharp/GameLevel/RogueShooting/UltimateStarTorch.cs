using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000DB0 RID: 3504
	[Token(Token = "0x2000DB0")]
	public class UltimateStarTorch : BaseConfig
	{
		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x060048F5 RID: 18677 RVA: 0x0016AC7C File Offset: 0x00168E7C
		[Token(Token = "0x1700091C")]
		public override string Role
		{
			[Token(Token = "0x60048F5")]
			[Address(RVA = "0x8C4230", Offset = "0x8C2830", VA = "0x1808C4230", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x060048F6 RID: 18678 RVA: 0x0016AC90 File Offset: 0x00168E90
		[Token(Token = "0x1700091D")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60048F6")]
			[Address(RVA = "0x8C4220", Offset = "0x8C2820", VA = "0x1808C4220", Slot = "4")]
			get
			{
				return PlantType.UltimateStarTorch;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x060048F7 RID: 18679 RVA: 0x0016ACA4 File Offset: 0x00168EA4
		[Token(Token = "0x1700091E")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60048F7")]
			[Address(RVA = "0x8C4110", Offset = "0x8C2710", VA = "0x1808C4110", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UltimateStarTorch.UniqueBuff uniqueBuff = new UltimateStarTorch.UniqueBuff();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060048F8 RID: 18680 RVA: 0x0016ACD8 File Offset: 0x00168ED8
		[Token(Token = "0x60048F8")]
		[Address(RVA = "0x8C40B0", Offset = "0x8C26B0", VA = "0x1808C40B0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			TravelMgr instance = TravelMgr.Instance;
			int num = 0;
			instance.GetUltiBuff((UltiBuff)((uint)7), num != 0);
		}

		// Token: 0x060048F9 RID: 18681 RVA: 0x0016AD00 File Offset: 0x00168F00
		[Token(Token = "0x60048F9")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateStarTorch()
		{
		}

		// Token: 0x02000DB1 RID: 3505
		[Token(Token = "0x2000DB1")]
		private class UniqueBuff : BaseBuff
		{
			// Token: 0x1700091F RID: 2335
			// (get) Token: 0x060048FA RID: 18682 RVA: 0x0016AD14 File Offset: 0x00168F14
			[Token(Token = "0x1700091F")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60048FA")]
				[Address(RVA = "0x8C4220", Offset = "0x8C2820", VA = "0x1808C4220", Slot = "4")]
				get
				{
					return PlantType.UltimateStarTorch;
				}
			}

			// Token: 0x17000920 RID: 2336
			// (get) Token: 0x060048FB RID: 18683 RVA: 0x0016AD28 File Offset: 0x00168F28
			[Token(Token = "0x17000920")]
			public override string Title
			{
				[Token(Token = "0x60048FB")]
				[Address(RVA = "0x8C54C0", Offset = "0x8C3AC0", VA = "0x1808C54C0", Slot = "5")]
				get
				{
					return "强化：数量";
				}
			}

			// Token: 0x17000921 RID: 2337
			// (get) Token: 0x060048FC RID: 18684 RVA: 0x0016AD3C File Offset: 0x00168F3C
			[Token(Token = "0x17000921")]
			public override string Description
			{
				[Token(Token = "0x60048FC")]
				[Address(RVA = "0x8C5370", Offset = "0x8C3970", VA = "0x1808C5370", Slot = "6")]
				get
				{
					return "生成杨桃所需子弹数-10";
				}
			}

			// Token: 0x17000922 RID: 2338
			// (get) Token: 0x060048FD RID: 18685 RVA: 0x0016AD50 File Offset: 0x00168F50
			[Token(Token = "0x17000922")]
			public override Quality Rarity
			{
				[Token(Token = "0x60048FD")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060048FE RID: 18686 RVA: 0x0016AD60 File Offset: 0x00168F60
			[Token(Token = "0x60048FE")]
			[Address(RVA = "0x8C4FF0", Offset = "0x8C35F0", VA = "0x1808C4FF0", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__8_ = UltimateStarTorch.UniqueBuff.<>c.<>9__8_0;
				if (<>9__8_ == 0)
				{
					Action<Plant> action;
					UltimateStarTorch.UniqueBuff.<>c.<>9__8_0 = action;
				}
				base.SafeModify(<>9__8_);
			}

			// Token: 0x060048FF RID: 18687 RVA: 0x0016AD8C File Offset: 0x00168F8C
			[Token(Token = "0x60048FF")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueBuff()
			{
			}
		}
	}
}
