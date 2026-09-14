using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A9A RID: 2714
	[Token(Token = "0x2000A9A")]
	public class UltimateCorn : PlantData
	{
		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060037DA RID: 14298 RVA: 0x001288E8 File Offset: 0x00126AE8
		[Token(Token = "0x1700034A")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60037DA")]
			[Address(RVA = "0x781460", Offset = "0x77FA60", VA = "0x180781460", Slot = "4")]
			get
			{
				return PlantType.UltimateCorn;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060037DB RID: 14299 RVA: 0x001288FC File Offset: 0x00126AFC
		[Token(Token = "0x1700034B")]
		public override string Title
		{
			[Token(Token = "0x60037DB")]
			[Address(RVA = "0x781590", Offset = "0x77FB90", VA = "0x180781590", Slot = "5")]
			get
			{
				return "黑洞领域";
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060037DC RID: 14300 RVA: 0x00128910 File Offset: 0x00126B10
		[Token(Token = "0x1700034C")]
		public override string Description
		{
			[Token(Token = "0x60037DC")]
			[Address(RVA = "0x781430", Offset = "0x77FA30", VA = "0x180781430", Slot = "6")]
			get
			{
				return "黑洞爆炸会延后战斗结束倒计时";
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060037DD RID: 14301 RVA: 0x00128924 File Offset: 0x00126B24
		[Token(Token = "0x1700034D")]
		public override int Cost
		{
			[Token(Token = "0x60037DD")]
			[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "8")]
			get
			{
				return 5;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060037DE RID: 14302 RVA: 0x00128934 File Offset: 0x00126B34
		[Token(Token = "0x1700034E")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60037DE")]
			[Address(RVA = "0x781470", Offset = "0x77FA70", VA = "0x180781470", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060037DF RID: 14303 RVA: 0x00128970 File Offset: 0x00126B70
		[Token(Token = "0x60037DF")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public UltimateCorn()
		{
		}
	}
}
