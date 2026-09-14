using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D3A RID: 3386
	[Token(Token = "0x2000D3A")]
	public class UltimateDoomScared : BaseConfig
	{
		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06004662 RID: 18018 RVA: 0x00166388 File Offset: 0x00164588
		[Token(Token = "0x1700078E")]
		public override string Role
		{
			[Token(Token = "0x6004662")]
			[Address(RVA = "0x8C19B0", Offset = "0x8BFFB0", VA = "0x1808C19B0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06004663 RID: 18019 RVA: 0x0016639C File Offset: 0x0016459C
		[Token(Token = "0x1700078F")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004663")]
			[Address(RVA = "0x8B7140", Offset = "0x8B5740", VA = "0x1808B7140", Slot = "4")]
			get
			{
				return PlantType.UltimateDoomScaredy;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06004664 RID: 18020 RVA: 0x001663B0 File Offset: 0x001645B0
		[Token(Token = "0x17000790")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004664")]
			[Address(RVA = "0x8C1790", Offset = "0x8BFD90", VA = "0x1808C1790", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				UltimateDoomScared.SuperBuff superBuff = new UltimateDoomScared.SuperBuff();
				int size2 = list._size;
				UltimateDoomScared.UniqueBuff uniqueBuff = new UltimateDoomScared.UniqueBuff();
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06004665 RID: 18021 RVA: 0x001663FC File Offset: 0x001645FC
		[Token(Token = "0x6004665")]
		[Address(RVA = "0x8C16F0", Offset = "0x8BFCF0", VA = "0x1808C16F0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 2.5f, num2 != 0, num);
			plant.AddSpeed(1f);
			TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)2));
		}

		// Token: 0x06004666 RID: 18022 RVA: 0x0016643C File Offset: 0x0016463C
		[Token(Token = "0x6004666")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateDoomScared()
		{
		}

		// Token: 0x02000D3B RID: 3387
		[Token(Token = "0x2000D3B")]
		private class UniqueBuff : BaseBuff
		{
			// Token: 0x17000791 RID: 1937
			// (get) Token: 0x06004667 RID: 18023 RVA: 0x00166450 File Offset: 0x00164650
			[Token(Token = "0x17000791")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004667")]
				[Address(RVA = "0x8B7140", Offset = "0x8B5740", VA = "0x1808B7140", Slot = "4")]
				get
				{
					return PlantType.UltimateDoomScaredy;
				}
			}

			// Token: 0x17000792 RID: 1938
			// (get) Token: 0x06004668 RID: 18024 RVA: 0x00166464 File Offset: 0x00164664
			[Token(Token = "0x17000792")]
			public override string Title
			{
				[Token(Token = "0x6004668")]
				[Address(RVA = "0x8C5520", Offset = "0x8C3B20", VA = "0x1808C5520", Slot = "5")]
				get
				{
					return "强化：超级宇宙无敌雷霆大子弹";
				}
			}

			// Token: 0x17000793 RID: 1939
			// (get) Token: 0x06004669 RID: 18025 RVA: 0x00166478 File Offset: 0x00164678
			[Token(Token = "0x17000793")]
			public override string Description
			{
				[Token(Token = "0x6004669")]
				[Address(RVA = "0x8C52C0", Offset = "0x8C38C0", VA = "0x1808C52C0", Slot = "6")]
				get
				{
					return "大子弹所需射击数-4";
				}
			}

			// Token: 0x17000794 RID: 1940
			// (get) Token: 0x0600466A RID: 18026 RVA: 0x0016648C File Offset: 0x0016468C
			[Token(Token = "0x17000794")]
			public override Quality Rarity
			{
				[Token(Token = "0x600466A")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x17000795 RID: 1941
			// (get) Token: 0x0600466B RID: 18027 RVA: 0x0016649C File Offset: 0x0016469C
			[Token(Token = "0x17000795")]
			public override int MaxCount
			{
				[Token(Token = "0x600466B")]
				[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "8")]
				get
				{
					return 4;
				}
			}

			// Token: 0x17000796 RID: 1942
			// (get) Token: 0x0600466C RID: 18028 RVA: 0x001664AC File Offset: 0x001646AC
			[Token(Token = "0x17000796")]
			public override float AppearWeight
			{
				[Token(Token = "0x600466C")]
				[Address(RVA = "0x8C52B0", Offset = "0x8C38B0", VA = "0x1808C52B0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600466D RID: 18029 RVA: 0x001664C0 File Offset: 0x001646C0
			[Token(Token = "0x600466D")]
			[Address(RVA = "0x8C4EE0", Offset = "0x8C34E0", VA = "0x1808C4EE0", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__12_ = UltimateDoomScared.UniqueBuff.<>c.<>9__12_0;
				if (<>9__12_ == 0)
				{
					Action<Plant> action;
					UltimateDoomScared.UniqueBuff.<>c.<>9__12_0 = action;
				}
				base.SafeModify(<>9__12_);
			}

			// Token: 0x0600466E RID: 18030 RVA: 0x001664EC File Offset: 0x001646EC
			[Token(Token = "0x600466E")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueBuff()
			{
			}
		}

		// Token: 0x02000D3D RID: 3389
		[Token(Token = "0x2000D3D")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x17000797 RID: 1943
			// (get) Token: 0x06004672 RID: 18034 RVA: 0x00166500 File Offset: 0x00164700
			[Token(Token = "0x17000797")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004672")]
				[Address(RVA = "0x8B7140", Offset = "0x8B5740", VA = "0x1808B7140", Slot = "4")]
				get
				{
					return PlantType.UltimateDoomScaredy;
				}
			}

			// Token: 0x17000798 RID: 1944
			// (get) Token: 0x06004673 RID: 18035 RVA: 0x00166514 File Offset: 0x00164714
			[Token(Token = "0x17000798")]
			public override string Title
			{
				[Token(Token = "0x6004673")]
				[Address(RVA = "0x8B74E0", Offset = "0x8B5AE0", VA = "0x1808B74E0", Slot = "5")]
				get
				{
					return "质变：真毁";
				}
			}

			// Token: 0x17000799 RID: 1945
			// (get) Token: 0x06004674 RID: 18036 RVA: 0x00166528 File Offset: 0x00164728
			[Token(Token = "0x17000799")]
			public override string Description
			{
				[Token(Token = "0x6004674")]
				[Address(RVA = "0x8B6E70", Offset = "0x8B5470", VA = "0x1808B6E70", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)2000];
				}
			}

			// Token: 0x1700079A RID: 1946
			// (get) Token: 0x06004675 RID: 18037 RVA: 0x0016654C File Offset: 0x0016474C
			[Token(Token = "0x1700079A")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004675")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x1700079B RID: 1947
			// (get) Token: 0x06004676 RID: 18038 RVA: 0x0016655C File Offset: 0x0016475C
			[Token(Token = "0x1700079B")]
			public override int MaxCount
			{
				[Token(Token = "0x6004676")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x1700079C RID: 1948
			// (get) Token: 0x06004677 RID: 18039 RVA: 0x0016656C File Offset: 0x0016476C
			[Token(Token = "0x1700079C")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004677")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004678 RID: 18040 RVA: 0x00166580 File Offset: 0x00164780
			[Token(Token = "0x6004678")]
			[Address(RVA = "0x8B61B0", Offset = "0x8B47B0", VA = "0x1808B61B0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)2000));
			}

			// Token: 0x06004679 RID: 18041 RVA: 0x001665A8 File Offset: 0x001647A8
			[Token(Token = "0x6004679")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperBuff()
			{
			}
		}
	}
}
