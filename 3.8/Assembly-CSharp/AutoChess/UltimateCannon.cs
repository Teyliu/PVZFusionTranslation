using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AA1 RID: 2721
	[Token(Token = "0x2000AA1")]
	public class UltimateCannon : PlantData
	{
		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06003804 RID: 14340 RVA: 0x00128D2C File Offset: 0x00126F2C
		[Token(Token = "0x1700036D")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003804")]
			[Address(RVA = "0x781140", Offset = "0x77F740", VA = "0x180781140", Slot = "4")]
			get
			{
				return PlantType.UltimateCannon;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06003805 RID: 14341 RVA: 0x00128D40 File Offset: 0x00126F40
		[Token(Token = "0x1700036E")]
		public override string Title
		{
			[Token(Token = "0x6003805")]
			[Address(RVA = "0x781270", Offset = "0x77F870", VA = "0x180781270", Slot = "5")]
			get
			{
				return "爱与黄金";
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06003806 RID: 14342 RVA: 0x00128D54 File Offset: 0x00126F54
		[Token(Token = "0x1700036F")]
		public override string Description
		{
			[Token(Token = "0x6003806")]
			[Address(RVA = "0x781110", Offset = "0x77F710", VA = "0x180781110", Slot = "6")]
			get
			{
				return "进入战斗时获得追忆，并强化所有投手植物的角色赋能效果，获得词条绝对力量";
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06003807 RID: 14343 RVA: 0x00128D68 File Offset: 0x00126F68
		[Token(Token = "0x17000370")]
		public override int Cost
		{
			[Token(Token = "0x6003807")]
			[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "8")]
			get
			{
				return 5;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06003808 RID: 14344 RVA: 0x00128D78 File Offset: 0x00126F78
		[Token(Token = "0x17000371")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003808")]
			[Address(RVA = "0x781150", Offset = "0x77F750", VA = "0x180781150", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x00128DB4 File Offset: 0x00126FB4
		[Token(Token = "0x6003809")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public UltimateCannon()
		{
		}
	}
}
