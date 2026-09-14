using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A99 RID: 2713
	[Token(Token = "0x2000A99")]
	public class EndoFlameGirl : PlantData
	{
		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060037D4 RID: 14292 RVA: 0x0012884C File Offset: 0x00126A4C
		[Token(Token = "0x17000345")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60037D4")]
			[Address(RVA = "0x4ECDE0", Offset = "0x4EB3E0", VA = "0x1804ECDE0", Slot = "4")]
			get
			{
				return PlantType.EndoFlameGirl;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060037D5 RID: 14293 RVA: 0x00128860 File Offset: 0x00126A60
		[Token(Token = "0x17000346")]
		public override string Title
		{
			[Token(Token = "0x60037D5")]
			[Address(RVA = "0x76AB10", Offset = "0x769110", VA = "0x18076AB10", Slot = "5")]
			get
			{
				return "全域封禁";
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060037D6 RID: 14294 RVA: 0x00128874 File Offset: 0x00126A74
		[Token(Token = "0x17000347")]
		public override string Description
		{
			[Token(Token = "0x60037D6")]
			[Address(RVA = "0x76A9C0", Offset = "0x768FC0", VA = "0x18076A9C0", Slot = "6")]
			get
			{
				return "攻击造成范围伤害，并削减敌人的护甲";
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060037D7 RID: 14295 RVA: 0x00128888 File Offset: 0x00126A88
		[Token(Token = "0x17000348")]
		public override int Cost
		{
			[Token(Token = "0x60037D7")]
			[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060037D8 RID: 14296 RVA: 0x00128898 File Offset: 0x00126A98
		[Token(Token = "0x17000349")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60037D8")]
			[Address(RVA = "0x76A9F0", Offset = "0x768FF0", VA = "0x18076A9F0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x001288D4 File Offset: 0x00126AD4
		[Token(Token = "0x60037D9")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public EndoFlameGirl()
		{
		}
	}
}
