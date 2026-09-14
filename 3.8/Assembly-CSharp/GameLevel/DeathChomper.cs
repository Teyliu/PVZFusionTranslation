using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B11 RID: 2833
	[Token(Token = "0x2000B11")]
	public class DeathChomper : TravelAdvantureLevelData
	{
		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06003B18 RID: 15128 RVA: 0x00135FD8 File Offset: 0x001341D8
		[Token(Token = "0x1700048A")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003B18")]
			[Address(RVA = "0x69BB30", Offset = "0x69A130", VA = "0x18069BB30", Slot = "42")]
			get
			{
				return TravelAdvanture.DeathChomper;
			}
		}

		// Token: 0x06003B19 RID: 15129 RVA: 0x00135FE8 File Offset: 0x001341E8
		[Token(Token = "0x6003B19")]
		[Address(RVA = "0x7A2BD0", Offset = "0x7A11D0", VA = "0x1807A2BD0", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "毁灭辣椒 + 毁灭大嘴花\n使用土豆雷、大嘴花进行亚种切换\n提示：使用死神大嘴花来触发植物亡语效果";
			throw new NullReferenceException();
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x00136014 File Offset: 0x00134214
		[Token(Token = "0x6003B1A")]
		[Address(RVA = "0x7A2C50", Offset = "0x7A1250", VA = "0x1807A2C50", Slot = "36")]
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

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06003B1B RID: 15131 RVA: 0x0013606C File Offset: 0x0013426C
		[Token(Token = "0x1700048B")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003B1B")]
			[Address(RVA = "0x69E470", Offset = "0x69CA70", VA = "0x18069E470", Slot = "12")]
			get
			{
				return SceneType.Roof_Pool;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06003B1C RID: 15132 RVA: 0x0013607C File Offset: 0x0013427C
		[Token(Token = "0x1700048C")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003B1C")]
			[Address(RVA = "0x7A2F60", Offset = "0x7A1560", VA = "0x1807A2F60", Slot = "20")]
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

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06003B1D RID: 15133 RVA: 0x001360EC File Offset: 0x001342EC
		[Token(Token = "0x1700048D")]
		public override int MaxWave
		{
			[Token(Token = "0x6003B1D")]
			[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "10")]
			get
			{
				return 30;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06003B1E RID: 15134 RVA: 0x001360FC File Offset: 0x001342FC
		[Token(Token = "0x1700048E")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003B1E")]
			[Address(RVA = "0x7A2D90", Offset = "0x7A1390", VA = "0x1807A2D90", Slot = "22")]
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

		// Token: 0x06003B1F RID: 15135 RVA: 0x00136148 File Offset: 0x00134348
		[Token(Token = "0x6003B1F")]
		[Address(RVA = "0x6FAF20", Offset = "0x6F9520", VA = "0x1806FAF20")]
		public DeathChomper()
		{
		}
	}
}
