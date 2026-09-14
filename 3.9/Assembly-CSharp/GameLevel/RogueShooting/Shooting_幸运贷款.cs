using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C82 RID: 3202
	[Token(Token = "0x2000C82")]
	public class Shooting_幸运贷款 : BaseDebuff
	{
		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x0600428A RID: 17034 RVA: 0x0015C42C File Offset: 0x0015A62C
		[Token(Token = "0x17000598")]
		public override int Point
		{
			[Token(Token = "0x600428A")]
			[Address(RVA = "0x720BB0", Offset = "0x71F1B0", VA = "0x180720BB0", Slot = "21")]
			get
			{
				return 50;
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x0600428B RID: 17035 RVA: 0x0015C43C File Offset: 0x0015A63C
		[Token(Token = "0x17000599")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x600428B")]
			[Address(RVA = "0x89F180", Offset = "0x89D780", VA = "0x18089F180", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_幸运贷款;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x0600428C RID: 17036 RVA: 0x0015C450 File Offset: 0x0015A650
		[Token(Token = "0x1700059A")]
		public override string Description
		{
			[Token(Token = "0x600428C")]
			[Address(RVA = "0x89F190", Offset = "0x89D790", VA = "0x18089F190", Slot = "13")]
			get
			{
				return "幸运贷款：获得75幸运，但从第50波开始后每一波开始时，丢失1点幸运";
			}
		}

		// Token: 0x0600428D RID: 17037 RVA: 0x0015C464 File Offset: 0x0015A664
		[Token(Token = "0x600428D")]
		[Address(RVA = "0x89F060", Offset = "0x89D660", VA = "0x18089F060", Slot = "17")]
		public override void OnSelect(Board board)
		{
			ShootingManager instance = ShootingManager.Instance;
			float lucky = instance._lucky;
			instance.Lucky = lucky;
			Action action = delegate
			{
				ShootingManager instance2 = ShootingManager.Instance;
				Board board2 = board;
				ShootingManager instance3 = ShootingManager.Instance;
				float lucky2 = instance3._lucky;
				instance3.Lucky = lucky2;
			};
			int num = 0;
			EventManager.AddListener(GameEvent.BoardWaveAdd, action, num != 0);
		}

		// Token: 0x0600428E RID: 17038 RVA: 0x0015C4B4 File Offset: 0x0015A6B4
		[Token(Token = "0x600428E")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_幸运贷款()
		{
		}
	}
}
