using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C6F RID: 3183
	[Token(Token = "0x2000C6F")]
	public class Shooting_步步紧逼 : BaseDebuff
	{
		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06004241 RID: 16961 RVA: 0x0015B98C File Offset: 0x00159B8C
		[Token(Token = "0x1700057A")]
		public override int Point
		{
			[Token(Token = "0x6004241")]
			[Address(RVA = "0x59DF10", Offset = "0x59C510", VA = "0x18059DF10", Slot = "21")]
			get
			{
				return 300;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06004242 RID: 16962 RVA: 0x0015B9A0 File Offset: 0x00159BA0
		[Token(Token = "0x1700057B")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x6004242")]
			[Address(RVA = "0x89FB30", Offset = "0x89E130", VA = "0x18089FB30", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_步步紧逼;
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06004243 RID: 16963 RVA: 0x0015B9B4 File Offset: 0x00159BB4
		[Token(Token = "0x1700057C")]
		public override string Description
		{
			[Token(Token = "0x6004243")]
			[Address(RVA = "0x89FB40", Offset = "0x89E140", VA = "0x18089FB40", Slot = "13")]
			get
			{
				return "步步紧逼：僵尸进化的波数降低至每4波一次";
			}
		}

		// Token: 0x06004244 RID: 16964 RVA: 0x0015B9C8 File Offset: 0x00159BC8
		[Token(Token = "0x6004244")]
		[Address(RVA = "0x89FA10", Offset = "0x89E010", VA = "0x18089FA10", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06004245 RID: 16965 RVA: 0x0015B9E8 File Offset: 0x00159BE8
		[Token(Token = "0x6004245")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_步步紧逼()
		{
		}
	}
}
