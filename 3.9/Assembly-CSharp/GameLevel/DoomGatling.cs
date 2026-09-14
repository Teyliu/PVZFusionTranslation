using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B42 RID: 2882
	[Token(Token = "0x2000B42")]
	public class DoomGatling : TravelAdvantureLevelData
	{
		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06003BE0 RID: 15328 RVA: 0x00139BB0 File Offset: 0x00137DB0
		[Token(Token = "0x17000485")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003BE0")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "42")]
			get
			{
				return TravelAdvanture.DoomGatling;
			}
		}

		// Token: 0x06003BE1 RID: 15329 RVA: 0x00139BC0 File Offset: 0x00137DC0
		[Token(Token = "0x6003BE1")]
		[Address(RVA = "0x7EE6F0", Offset = "0x7ECCF0", VA = "0x1807EE6F0", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "机枪射手 + 毁灭菇\n使用胆小菇、豌豆射手进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x00139BEC File Offset: 0x00137DEC
		[Token(Token = "0x6003BE2")]
		[Address(RVA = "0x7EE770", Offset = "0x7ECD70", VA = "0x1807EE770", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int theSun = board.theSun;
			board.theSun = this;
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06003BE3 RID: 15331 RVA: 0x00139C14 File Offset: 0x00137E14
		[Token(Token = "0x17000486")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003BE3")]
			[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "12")]
			get
			{
				return SceneType.Day;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06003BE4 RID: 15332 RVA: 0x00139C2C File Offset: 0x00137E2C
		[Token(Token = "0x17000487")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003BE4")]
			[Address(RVA = "0x7EE980", Offset = "0x7ECF80", VA = "0x1807EE980", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06003BE5 RID: 15333 RVA: 0x00139C74 File Offset: 0x00137E74
		[Token(Token = "0x17000488")]
		public override int MaxWave
		{
			[Token(Token = "0x6003BE5")]
			[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "10")]
			get
			{
				return 10;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06003BE6 RID: 15334 RVA: 0x00139C84 File Offset: 0x00137E84
		[Token(Token = "0x17000489")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003BE6")]
			[Address(RVA = "0x7EE7B0", Offset = "0x7ECDB0", VA = "0x1807EE7B0", Slot = "22")]
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

		// Token: 0x06003BE7 RID: 15335 RVA: 0x00139CD4 File Offset: 0x00137ED4
		[Token(Token = "0x6003BE7")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public DoomGatling()
		{
		}
	}
}
