using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C65 RID: 3173
	[Token(Token = "0x2000C65")]
	public class Shooting_榜样激励 : BaseDebuff
	{
		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x0600421E RID: 16926 RVA: 0x0015B4C0 File Offset: 0x001596C0
		[Token(Token = "0x17000568")]
		public override int Point
		{
			[Token(Token = "0x600421E")]
			[Address(RVA = "0x88CB90", Offset = "0x88B190", VA = "0x18088CB90", Slot = "21")]
			get
			{
				return 150;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x0600421F RID: 16927 RVA: 0x0015B4D4 File Offset: 0x001596D4
		[Token(Token = "0x17000569")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x600421F")]
			[Address(RVA = "0x88CBA0", Offset = "0x88B1A0", VA = "0x18088CBA0", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_榜样激励;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06004220 RID: 16928 RVA: 0x0015B4E8 File Offset: 0x001596E8
		[Token(Token = "0x1700056A")]
		public override string Description
		{
			[Token(Token = "0x6004220")]
			[Address(RVA = "0x88CBB0", Offset = "0x88B1B0", VA = "0x18088CBB0", Slot = "13")]
			get
			{
				return "榜样激励：伤害统计面板排名第一的植物造成85%的原伤害，其他植物造成105%原伤害";
			}
		}

		// Token: 0x06004221 RID: 16929 RVA: 0x0015B4FC File Offset: 0x001596FC
		[Token(Token = "0x6004221")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_榜样激励()
		{
		}
	}
}
