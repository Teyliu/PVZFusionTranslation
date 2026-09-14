using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting.CurseBuffs
{
	// Token: 0x02000DBA RID: 3514
	[Token(Token = "0x2000DBA")]
	public abstract class BaseCurse : BaseBuff<AdvBuff>
	{
		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06004916 RID: 18710 RVA: 0x0016B154 File Offset: 0x00169354
		[Token(Token = "0x17000923")]
		public virtual bool CanAppear
		{
			[Token(Token = "0x6004916")]
			[Address(RVA = "0x8A85A0", Offset = "0x8A6BA0", VA = "0x1808A85A0", Slot = "20")]
			get
			{
				int buffType = base.BuffType;
				bool flag;
				return flag;
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06004917 RID: 18711 RVA: 0x0016B16C File Offset: 0x0016936C
		[Token(Token = "0x17000924")]
		protected ShootingManager manager
		{
			[Token(Token = "0x6004917")]
			[Address(RVA = "0x8A8610", Offset = "0x8A6C10", VA = "0x1808A8610")]
			get
			{
				return ShootingManager.Instance;
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06004918 RID: 18712 RVA: 0x0016B180 File Offset: 0x00169380
		[Token(Token = "0x17000925")]
		protected Board board
		{
			[Token(Token = "0x6004918")]
			[Address(RVA = "0x8A85D0", Offset = "0x8A6BD0", VA = "0x1808A85D0")]
			get
			{
				return Board.Instance;
			}
		}

		// Token: 0x06004919 RID: 18713 RVA: 0x0016B194 File Offset: 0x00169394
		[Token(Token = "0x6004919")]
		[Address(RVA = "0x8A8560", Offset = "0x8A6B60", VA = "0x1808A8560")]
		protected BaseCurse()
		{
		}
	}
}
