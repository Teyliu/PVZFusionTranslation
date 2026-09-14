using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000B1F RID: 2847
	[Token(Token = "0x2000B1F")]
	public class UltimateRandom4Level : RandomMix3Level
	{
		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06003B0C RID: 15116 RVA: 0x0013604C File Offset: 0x0013424C
		[Token(Token = "0x17000428")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003B0C")]
			[Address(RVA = "0x803160", Offset = "0x801760", VA = "0x180803160", Slot = "42")]
			get
			{
				return ChallengeLevel.UltimateRandom4;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06003B0D RID: 15117 RVA: 0x00136060 File Offset: 0x00134260
		[Token(Token = "0x17000429")]
		public override string Name
		{
			[Token(Token = "0x6003B0D")]
			[Address(RVA = "0x803170", Offset = "0x801770", VA = "0x180803170", Slot = "8")]
			get
			{
				return "炼狱随机：命运";
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06003B0E RID: 15118 RVA: 0x00136074 File Offset: 0x00134274
		[Token(Token = "0x1700042A")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003B0E")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x06003B0F RID: 15119 RVA: 0x00136084 File Offset: 0x00134284
		[Token(Token = "0x6003B0F")]
		[Address(RVA = "0x803130", Offset = "0x801730", VA = "0x180803130", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.boardTag.isUltimateSuperRandom = true;
			board.boardTag.disableMower = true;
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06003B10 RID: 15120 RVA: 0x001360B8 File Offset: 0x001342B8
		[Token(Token = "0x1700042B")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003B10")]
			[Address(RVA = "0x8031A0", Offset = "0x8017A0", VA = "0x1808031A0", Slot = "20")]
			get
			{
				List<ZombieType> list;
				ulong num;
				do
				{
					list = new List();
					int size = list._size;
					list._size = list;
					int size2 = list._size;
					list._size = list;
					int size3 = list._size;
					list._size = list;
					HashSet<ZombieType> leaderZombies = TypeMgr.LeaderZombies;
					bool flag;
					if (flag)
					{
						int size4 = list._size;
						list._size = (flag ? 1 : 0);
					}
				}
				while (num != (ulong)0L);
				return list;
			}
		}

		// Token: 0x06003B11 RID: 15121 RVA: 0x0013613C File Offset: 0x0013433C
		[Token(Token = "0x6003B11")]
		[Address(RVA = "0x802F50", Offset = "0x801550", VA = "0x180802F50", Slot = "44")]
		protected override void GetBuffs(Board board)
		{
			Dictionary<int, int> dictionary;
			board.boardData.zombieLevelDic = dictionary;
			int num = board.theWave;
			ulong num2;
			num2 += num2;
			long num3 = (long)(num2 * (ulong)((uint)15));
			num = (int)((long)num - num3);
			if (num != 2)
			{
				base.GetBuffs(board);
				return;
			}
			Time.timeScale = (float)0;
			UIResourcesLoader uimanager = GameAPP.UIManager;
			BaseMenu baseMenu;
			uint num4;
			baseMenu.GetComponentInChildren<TravelRefresh>().ModifyRefrashTimes((int)num4);
		}

		// Token: 0x06003B12 RID: 15122 RVA: 0x00136198 File Offset: 0x00134398
		[Token(Token = "0x6003B12")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public UltimateRandom4Level()
		{
		}
	}
}
