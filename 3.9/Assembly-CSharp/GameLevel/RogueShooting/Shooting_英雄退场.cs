using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C79 RID: 3193
	[Token(Token = "0x2000C79")]
	public class Shooting_英雄退场 : BaseDebuff
	{
		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06004266 RID: 16998 RVA: 0x0015BE80 File Offset: 0x0015A080
		[Token(Token = "0x17000589")]
		public override int Point
		{
			[Token(Token = "0x6004266")]
			[Address(RVA = "0x88CB90", Offset = "0x88B190", VA = "0x18088CB90", Slot = "21")]
			get
			{
				return 150;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06004267 RID: 16999 RVA: 0x0015BE94 File Offset: 0x0015A094
		[Token(Token = "0x1700058A")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x6004267")]
			[Address(RVA = "0x8A0840", Offset = "0x89EE40", VA = "0x1808A0840", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_英雄退场;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06004268 RID: 17000 RVA: 0x0015BEA8 File Offset: 0x0015A0A8
		[Token(Token = "0x1700058B")]
		public override string Description
		{
			[Token(Token = "0x6004268")]
			[Address(RVA = "0x8A0850", Offset = "0x89EE50", VA = "0x1808A0850", Slot = "13")]
			get
			{
				return "英雄退场：每一波僵尸刷新时，词条数拿的最多的植物降低1%独立伤害增幅，最低为0";
			}
		}

		// Token: 0x06004269 RID: 17001 RVA: 0x0015BEBC File Offset: 0x0015A0BC
		[Token(Token = "0x6004269")]
		[Address(RVA = "0x8A0700", Offset = "0x89ED00", VA = "0x1808A0700", Slot = "17")]
		public override void OnSelect(Board board)
		{
			base.OnSelect(board);
			Action <>9__6_ = Shooting_英雄退场.<>c.<>9__6_0;
			if (<>9__6_ == 0)
			{
				Shooting_英雄退场.<>c.<>9__6_0 = delegate
				{
					Dictionary<PlantType, Dictionary<string, int>>.KeyCollection keys = ShootingManager.Instance.plantBuffRecords.Keys;
					Func<PlantType, int> <>9__6_2 = Shooting_英雄退场.<>c.<>9__6_1;
					if (<>9__6_2 == 0)
					{
						Func<PlantType, int> func;
						Shooting_英雄退场.<>c.<>9__6_1 = func;
					}
					if (Enumerable.FirstOrDefault<PlantType>(Enumerable.OrderByDescending<PlantType, int>(keys, <>9__6_2)) != PlantType.Peashooter)
					{
						TravelData data = TravelMgr.Instance.data;
						TravelData data2 = TravelMgr.Instance.data;
						TravelData data3 = TravelMgr.Instance.data;
					}
				};
			}
			int num = 0;
			EventManager.AddListener(GameEvent.BoardWaveAdd, <>9__6_, num != 0);
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x0015BEFC File Offset: 0x0015A0FC
		[Token(Token = "0x600426A")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_英雄退场()
		{
		}
	}
}
