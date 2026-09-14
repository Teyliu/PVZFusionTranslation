using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D92 RID: 3474
	[Token(Token = "0x2000D92")]
	public class Umbrellaleaf : BaseConfig
	{
		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06004854 RID: 18516 RVA: 0x00169E54 File Offset: 0x00168054
		[Token(Token = "0x170008BD")]
		public override string Role
		{
			[Token(Token = "0x6004854")]
			[Address(RVA = "0x8C4B80", Offset = "0x8C3180", VA = "0x1808C4B80", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06004855 RID: 18517 RVA: 0x00169E68 File Offset: 0x00168068
		[Token(Token = "0x170008BE")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004855")]
			[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "4")]
			get
			{
				return PlantType.Umbrellaleaf;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06004856 RID: 18518 RVA: 0x00169E78 File Offset: 0x00168078
		[Token(Token = "0x170008BF")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004856")]
			[Address(RVA = "0x8C4A70", Offset = "0x8C3070", VA = "0x1808C4A70", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004857 RID: 18519 RVA: 0x00169EA4 File Offset: 0x001680A4
		[Token(Token = "0x6004857")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x06004858 RID: 18520 RVA: 0x00169EB4 File Offset: 0x001680B4
		[Token(Token = "0x6004858")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public Umbrellaleaf()
		{
		}
	}
}
