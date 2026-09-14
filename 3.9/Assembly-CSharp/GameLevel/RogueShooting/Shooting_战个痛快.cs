using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C93 RID: 3219
	[Token(Token = "0x2000C93")]
	public class Shooting_战个痛快 : BaseDebuff
	{
		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060042CA RID: 17098 RVA: 0x0015CC7C File Offset: 0x0015AE7C
		[Token(Token = "0x170005B0")]
		public override int Point
		{
			[Token(Token = "0x60042CA")]
			[Address(RVA = "0x3F6A80", Offset = "0x3F5080", VA = "0x1803F6A80", Slot = "21")]
			get
			{
				return 100;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060042CB RID: 17099 RVA: 0x0015CC8C File Offset: 0x0015AE8C
		[Token(Token = "0x170005B1")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x60042CB")]
			[Address(RVA = "0x89F350", Offset = "0x89D950", VA = "0x18089F350", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_战个痛快;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060042CC RID: 17100 RVA: 0x0015CCA0 File Offset: 0x0015AEA0
		[Token(Token = "0x170005B2")]
		public override string Description
		{
			[Token(Token = "0x60042CC")]
			[Address(RVA = "0x89F360", Offset = "0x89D960", VA = "0x18089F360", Slot = "13")]
			get
			{
				return "战个痛快：刷新间隔缩短，每次刷新僵尸时，有概率立即刷新下一波";
			}
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x0015CCB4 File Offset: 0x0015AEB4
		[Token(Token = "0x60042CD")]
		[Address(RVA = "0x89F240", Offset = "0x89D840", VA = "0x18089F240", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Board board2 = board;
			BoardConfig boardConfig;
			boardConfig.holdTimer = 0f;
			board.config.holdTimer2 = 0.5f;
			Action action = delegate
			{
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			};
			int num = 0;
			EventManager.AddListener((GameEvent)((uint)3), action, num != 0);
		}

		// Token: 0x060042CE RID: 17102 RVA: 0x0015CD18 File Offset: 0x0015AF18
		[Token(Token = "0x60042CE")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_战个痛快()
		{
		}
	}
}
