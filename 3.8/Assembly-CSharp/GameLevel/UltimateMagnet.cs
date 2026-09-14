using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B0D RID: 2829
	[Token(Token = "0x2000B0D")]
	public class UltimateMagnet : TravelAdvantureLevelData
	{
		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06003AF7 RID: 15095 RVA: 0x00135948 File Offset: 0x00133B48
		[Token(Token = "0x17000476")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003AF7")]
			[Address(RVA = "0x69AA70", Offset = "0x699070", VA = "0x18069AA70", Slot = "42")]
			get
			{
				return TravelAdvanture.UltimateMagnet;
			}
		}

		// Token: 0x06003AF8 RID: 15096 RVA: 0x00135958 File Offset: 0x00133B58
		[Token(Token = "0x6003AF8")]
		[Address(RVA = "0x7BC390", Offset = "0x7BA990", VA = "0x1807BC390", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "流光磁力菇 + 樱桃磁力菇\n使用向日葵、樱桃炸弹进行亚种切换\n提示：试试把僵尸掉落的机械碎片放置坚果上";
			throw new NullReferenceException();
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x00135984 File Offset: 0x00133B84
		[Token(Token = "0x6003AF9")]
		[Address(RVA = "0x7BC410", Offset = "0x7BAA10", VA = "0x1807BC410", Slot = "36")]
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

		// Token: 0x06003AFA RID: 15098 RVA: 0x001359D0 File Offset: 0x00133BD0
		[Token(Token = "0x6003AFA")]
		[Address(RVA = "0x7BC1D0", Offset = "0x7BA7D0", VA = "0x1807BC1D0", Slot = "40")]
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

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06003AFB RID: 15099 RVA: 0x00135A7C File Offset: 0x00133C7C
		[Token(Token = "0x17000477")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003AFB")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06003AFC RID: 15100 RVA: 0x00135A8C File Offset: 0x00133C8C
		[Token(Token = "0x17000478")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003AFC")]
			[Address(RVA = "0x7BC7B0", Offset = "0x7BADB0", VA = "0x1807BC7B0", Slot = "20")]
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

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06003AFD RID: 15101 RVA: 0x00135B0C File Offset: 0x00133D0C
		[Token(Token = "0x17000479")]
		public override int MaxWave
		{
			[Token(Token = "0x6003AFD")]
			[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "10")]
			get
			{
				return 30;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06003AFE RID: 15102 RVA: 0x00135B1C File Offset: 0x00133D1C
		[Token(Token = "0x1700047A")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003AFE")]
			[Address(RVA = "0x7BC5E0", Offset = "0x7BABE0", VA = "0x1807BC5E0", Slot = "22")]
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

		// Token: 0x06003AFF RID: 15103 RVA: 0x00135B68 File Offset: 0x00133D68
		[Token(Token = "0x6003AFF")]
		[Address(RVA = "0x6FAF20", Offset = "0x6F9520", VA = "0x1806FAF20")]
		public UltimateMagnet()
		{
		}
	}
}
