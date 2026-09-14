using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A94 RID: 2708
	[Token(Token = "0x2000A94")]
	public class UltimateBigGatling : PlantData
	{
		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060037B6 RID: 14262 RVA: 0x00128540 File Offset: 0x00126740
		[Token(Token = "0x1700032C")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60037B6")]
			[Address(RVA = "0x780E20", Offset = "0x77F420", VA = "0x180780E20", Slot = "4")]
			get
			{
				return PlantType.UltimateBigGatling;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060037B7 RID: 14263 RVA: 0x00128554 File Offset: 0x00126754
		[Token(Token = "0x1700032D")]
		public override string Title
		{
			[Token(Token = "0x60037B7")]
			[Address(RVA = "0x780F50", Offset = "0x77F550", VA = "0x180780F50", Slot = "5")]
			get
			{
				return "荒芜流淌";
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060037B8 RID: 14264 RVA: 0x00128568 File Offset: 0x00126768
		[Token(Token = "0x1700032E")]
		public override string Description
		{
			[Token(Token = "0x60037B8")]
			[Address(RVA = "0x780DF0", Offset = "0x77F3F0", VA = "0x180780DF0", Slot = "6")]
			get
			{
				return "大招回复的生命值提高，普通攻击获得更多能量，造成更高的伤害";
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060037B9 RID: 14265 RVA: 0x0012857C File Offset: 0x0012677C
		[Token(Token = "0x1700032F")]
		public override int Cost
		{
			[Token(Token = "0x60037B9")]
			[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060037BA RID: 14266 RVA: 0x0012858C File Offset: 0x0012678C
		[Token(Token = "0x17000330")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60037BA")]
			[Address(RVA = "0x780E30", Offset = "0x77F430", VA = "0x180780E30", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x001285C8 File Offset: 0x001267C8
		[Token(Token = "0x60037BB")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public UltimateBigGatling()
		{
		}
	}
}
