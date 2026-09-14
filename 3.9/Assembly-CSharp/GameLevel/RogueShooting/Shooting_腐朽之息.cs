using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C88 RID: 3208
	[Token(Token = "0x2000C88")]
	public class Shooting_腐朽之息 : BaseDebuff
	{
		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060042A1 RID: 17057 RVA: 0x0015C720 File Offset: 0x0015A920
		[Token(Token = "0x170005A1")]
		public override int Point
		{
			[Token(Token = "0x60042A1")]
			[Address(RVA = "0x88C900", Offset = "0x88AF00", VA = "0x18088C900", Slot = "21")]
			get
			{
				return 400;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060042A2 RID: 17058 RVA: 0x0015C734 File Offset: 0x0015A934
		[Token(Token = "0x170005A2")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x60042A2")]
			[Address(RVA = "0x8A0420", Offset = "0x89EA20", VA = "0x1808A0420", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_腐朽之息;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060042A3 RID: 17059 RVA: 0x0015C748 File Offset: 0x0015A948
		[Token(Token = "0x170005A3")]
		public override string Description
		{
			[Token(Token = "0x60042A3")]
			[Address(RVA = "0x8A0430", Offset = "0x89EA30", VA = "0x1808A0430", Slot = "13")]
			get
			{
				return "腐朽之息：每3秒为全场植物施加5%最大生命值的诅咒";
			}
		}

		// Token: 0x060042A4 RID: 17060 RVA: 0x0015C75C File Offset: 0x0015A95C
		[Token(Token = "0x60042A4")]
		[Address(RVA = "0x8A0370", Offset = "0x89E970", VA = "0x1808A0370", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x060042A5 RID: 17061 RVA: 0x0015C77C File Offset: 0x0015A97C
		[Token(Token = "0x60042A5")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_腐朽之息()
		{
		}
	}
}
