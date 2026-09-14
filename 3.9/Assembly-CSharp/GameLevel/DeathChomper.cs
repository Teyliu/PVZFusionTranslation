using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B53 RID: 2899
	[Token(Token = "0x2000B53")]
	public class DeathChomper : TravelAdvantureLevelData
	{
		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06003C69 RID: 15465 RVA: 0x0013B328 File Offset: 0x00139528
		[Token(Token = "0x170004DA")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003C69")]
			[Address(RVA = "0x715C90", Offset = "0x714290", VA = "0x180715C90", Slot = "42")]
			get
			{
				return TravelAdvanture.DeathChomper;
			}
		}

		// Token: 0x06003C6A RID: 15466 RVA: 0x0013B338 File Offset: 0x00139538
		[Token(Token = "0x6003C6A")]
		[Address(RVA = "0x81E0F0", Offset = "0x81C6F0", VA = "0x18081E0F0", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "毁灭辣椒 + 毁灭大嘴花\n使用土豆雷、大嘴花进行亚种切换\n提示：使用死神大嘴花来触发植物亡语效果";
			throw new NullReferenceException();
		}

		// Token: 0x06003C6B RID: 15467 RVA: 0x0013B364 File Offset: 0x00139564
		[Token(Token = "0x6003C6B")]
		[Address(RVA = "0x81E170", Offset = "0x81C770", VA = "0x18081E170", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			int num2 = 0;
			board.theSun = num;
			if (num2 < board.rowNum)
			{
				CreatePlant instance = CreatePlant.Instance;
				num2++;
			}
			num2++;
			TravelMgr instance2 = TravelMgr.Instance;
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06003C6C RID: 15468 RVA: 0x0013B3BC File Offset: 0x001395BC
		[Token(Token = "0x170004DB")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003C6C")]
			[Address(RVA = "0x7185D0", Offset = "0x716BD0", VA = "0x1807185D0", Slot = "12")]
			get
			{
				return SceneType.Roof_Pool;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06003C6D RID: 15469 RVA: 0x0013B3CC File Offset: 0x001395CC
		[Token(Token = "0x170004DC")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003C6D")]
			[Address(RVA = "0x81E480", Offset = "0x81CA80", VA = "0x18081E480", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				int size6 = list._size;
				int size7 = list._size;
				int size8 = list._size;
				return list;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06003C6E RID: 15470 RVA: 0x0013B43C File Offset: 0x0013963C
		[Token(Token = "0x170004DD")]
		public override int MaxWave
		{
			[Token(Token = "0x6003C6E")]
			[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "10")]
			get
			{
				return 30;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06003C6F RID: 15471 RVA: 0x0013B44C File Offset: 0x0013964C
		[Token(Token = "0x170004DE")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003C6F")]
			[Address(RVA = "0x81E2B0", Offset = "0x81C8B0", VA = "0x18081E2B0", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06003C70 RID: 15472 RVA: 0x0013B498 File Offset: 0x00139698
		[Token(Token = "0x6003C70")]
		[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
		public DeathChomper()
		{
		}
	}
}
