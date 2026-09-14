using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000ADF RID: 2783
	[Token(Token = "0x2000ADF")]
	public class UltimateRandom4Level : RandomMix3Level
	{
		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x060039C8 RID: 14792 RVA: 0x00130F6C File Offset: 0x0012F16C
		[Token(Token = "0x170003E0")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x60039C8")]
			[Address(RVA = "0x79C7A0", Offset = "0x79ADA0", VA = "0x18079C7A0", Slot = "42")]
			get
			{
				return ChallengeLevel.UltimateRandom4;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x060039C9 RID: 14793 RVA: 0x00130F80 File Offset: 0x0012F180
		[Token(Token = "0x170003E1")]
		public override string Name
		{
			[Token(Token = "0x60039C9")]
			[Address(RVA = "0x79C7B0", Offset = "0x79ADB0", VA = "0x18079C7B0", Slot = "8")]
			get
			{
				return "炼狱随机：命运";
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x060039CA RID: 14794 RVA: 0x00130F94 File Offset: 0x0012F194
		[Token(Token = "0x170003E2")]
		public override SceneType SceneType
		{
			[Token(Token = "0x60039CA")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x00130FA4 File Offset: 0x0012F1A4
		[Token(Token = "0x60039CB")]
		[Address(RVA = "0x79C770", Offset = "0x79AD70", VA = "0x18079C770", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.boardTag.isUltimateSuperRandom = true;
			board.boardTag.disableMower = true;
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x060039CC RID: 14796 RVA: 0x00130FD8 File Offset: 0x0012F1D8
		[Token(Token = "0x170003E3")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x60039CC")]
			[Address(RVA = "0x79C7E0", Offset = "0x79ADE0", VA = "0x18079C7E0", Slot = "20")]
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

		// Token: 0x060039CD RID: 14797 RVA: 0x0013105C File Offset: 0x0012F25C
		[Token(Token = "0x60039CD")]
		[Address(RVA = "0x79C590", Offset = "0x79AB90", VA = "0x18079C590", Slot = "44")]
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

		// Token: 0x060039CE RID: 14798 RVA: 0x001310B8 File Offset: 0x0012F2B8
		[Token(Token = "0x60039CE")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public UltimateRandom4Level()
		{
		}
	}
}
