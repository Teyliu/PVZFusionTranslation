using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D93 RID: 3475
	[Token(Token = "0x2000D93")]
	public class LanternUmbrella : BaseConfig
	{
		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06004859 RID: 18521 RVA: 0x00169EC8 File Offset: 0x001680C8
		[Token(Token = "0x170008C0")]
		public override string Role
		{
			[Token(Token = "0x6004859")]
			[Address(RVA = "0x8AEA10", Offset = "0x8AD010", VA = "0x1808AEA10", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x0600485A RID: 18522 RVA: 0x00169EDC File Offset: 0x001680DC
		[Token(Token = "0x170008C1")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600485A")]
			[Address(RVA = "0x7D2F30", Offset = "0x7D1530", VA = "0x1807D2F30", Slot = "4")]
			get
			{
				return PlantType.LanternUmbrella;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x0600485B RID: 18523 RVA: 0x00169EF0 File Offset: 0x001680F0
		[Token(Token = "0x170008C2")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600485B")]
			[Address(RVA = "0x8AE900", Offset = "0x8ACF00", VA = "0x1808AE900", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600485C RID: 18524 RVA: 0x00169F1C File Offset: 0x0016811C
		[Token(Token = "0x600485C")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x0600485D RID: 18525 RVA: 0x00169F2C File Offset: 0x0016812C
		[Token(Token = "0x600485D")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public LanternUmbrella()
		{
		}
	}
}
