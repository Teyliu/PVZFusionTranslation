using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B4F RID: 2895
	[Token(Token = "0x2000B4F")]
	public class UltimateMagnet : TravelAdvantureLevelData
	{
		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06003C48 RID: 15432 RVA: 0x0013AC98 File Offset: 0x00138E98
		[Token(Token = "0x170004C6")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003C48")]
			[Address(RVA = "0x714BD0", Offset = "0x7131D0", VA = "0x180714BD0", Slot = "42")]
			get
			{
				return TravelAdvanture.UltimateMagnet;
			}
		}

		// Token: 0x06003C49 RID: 15433 RVA: 0x0013ACA8 File Offset: 0x00138EA8
		[Token(Token = "0x6003C49")]
		[Address(RVA = "0x8386E0", Offset = "0x836CE0", VA = "0x1808386E0", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "流光磁力菇 + 樱桃磁力菇\n使用向日葵、樱桃炸弹进行亚种切换\n提示：试试把僵尸掉落的机械碎片放置坚果上";
			throw new NullReferenceException();
		}

		// Token: 0x06003C4A RID: 15434 RVA: 0x0013ACD4 File Offset: 0x00138ED4
		[Token(Token = "0x6003C4A")]
		[Address(RVA = "0x838760", Offset = "0x836D60", VA = "0x180838760", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
			CreatePlant instance = CreatePlant.Instance;
			CreatePlant instance2 = CreatePlant.Instance;
			CreatePlant instance3 = CreatePlant.Instance;
			CreatePlant instance4 = CreatePlant.Instance;
		}

		// Token: 0x06003C4B RID: 15435 RVA: 0x0013AD20 File Offset: 0x00138F20
		[Token(Token = "0x6003C4B")]
		[Address(RVA = "0x838520", Offset = "0x836B20", VA = "0x180838520", Slot = "40")]
		public override void OnAnimUIOver(Board board)
		{
			base.OnAnimUIOver(board);
			CreatePlant instance = CreatePlant.Instance;
			int num = 0;
			CreateZombie instance2 = CreateZombie.Instance;
			int num2 = 0;
			Zombie zombie = instance2.SetZombie(num2, (ZombieType)((uint)210), 9.9f, num != 0);
			CreateZombie instance3 = CreateZombie.Instance;
			int num3 = 0;
			Zombie zombie2 = instance3.SetZombie(num3, (ZombieType)((uint)210), 9.9f, num != 0);
			CreateZombie instance4 = CreateZombie.Instance;
			int num4 = 0;
			Zombie zombie3 = instance4.SetZombie(num4, (ZombieType)((uint)210), 9.9f, num != 0);
			CreateZombie instance5 = CreateZombie.Instance;
			int num5 = 0;
			Zombie zombie4 = instance5.SetZombie(num5, (ZombieType)((uint)210), 9.9f, num != 0);
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06003C4C RID: 15436 RVA: 0x0013ADCC File Offset: 0x00138FCC
		[Token(Token = "0x170004C7")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003C4C")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06003C4D RID: 15437 RVA: 0x0013ADDC File Offset: 0x00138FDC
		[Token(Token = "0x170004C8")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003C4D")]
			[Address(RVA = "0x838B00", Offset = "0x837100", VA = "0x180838B00", Slot = "20")]
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
				int size9 = list._size;
				int size10 = list._size;
				return list;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06003C4E RID: 15438 RVA: 0x0013AE5C File Offset: 0x0013905C
		[Token(Token = "0x170004C9")]
		public override int MaxWave
		{
			[Token(Token = "0x6003C4E")]
			[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "10")]
			get
			{
				return 30;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06003C4F RID: 15439 RVA: 0x0013AE6C File Offset: 0x0013906C
		[Token(Token = "0x170004CA")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003C4F")]
			[Address(RVA = "0x838930", Offset = "0x836F30", VA = "0x180838930", Slot = "22")]
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

		// Token: 0x06003C50 RID: 15440 RVA: 0x0013AEB8 File Offset: 0x001390B8
		[Token(Token = "0x6003C50")]
		[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
		public UltimateMagnet()
		{
		}
	}
}
