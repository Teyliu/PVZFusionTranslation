using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AA7 RID: 2727
	[Token(Token = "0x2000AA7")]
	public class WallNut : PlantData
	{
		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060037EC RID: 14316 RVA: 0x0012BBC0 File Offset: 0x00129DC0
		[Token(Token = "0x17000293")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60037EC")]
			[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "4")]
			get
			{
				return PlantType.WallNut;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060037ED RID: 14317 RVA: 0x0012BBD0 File Offset: 0x00129DD0
		[Token(Token = "0x17000294")]
		public override string Title
		{
			[Token(Token = "0x60037ED")]
			[Address(RVA = "0x7E9290", Offset = "0x7E7890", VA = "0x1807E9290", Slot = "5")]
			get
			{
				return "本坚果保护你！";
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060037EE RID: 14318 RVA: 0x0012BBE4 File Offset: 0x00129DE4
		[Token(Token = "0x17000295")]
		public override string Description
		{
			[Token(Token = "0x60037EE")]
			[Address(RVA = "0x7E9140", Offset = "0x7E7740", VA = "0x1807E9140", Slot = "6")]
			get
			{
				return "持续为周围3x3低血量植物提供护盾";
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060037EF RID: 14319 RVA: 0x0012BBF8 File Offset: 0x00129DF8
		[Token(Token = "0x17000296")]
		public override int Cost
		{
			[Token(Token = "0x60037EF")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060037F0 RID: 14320 RVA: 0x0012BC08 File Offset: 0x00129E08
		[Token(Token = "0x17000297")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60037F0")]
			[Address(RVA = "0x7E9170", Offset = "0x7E7770", VA = "0x1807E9170", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060037F1 RID: 14321 RVA: 0x0012BC44 File Offset: 0x00129E44
		[Token(Token = "0x60037F1")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public WallNut()
		{
		}
	}
}
