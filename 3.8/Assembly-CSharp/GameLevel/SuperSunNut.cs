using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B03 RID: 2819
	[Token(Token = "0x2000B03")]
	public class SuperSunNut : TravelAdvantureLevelData
	{
		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06003AA7 RID: 15015 RVA: 0x00134C30 File Offset: 0x00132E30
		[Token(Token = "0x17000444")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003AA7")]
			[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "42")]
			get
			{
				return TravelAdvanture.SuperSunNut;
			}
		}

		// Token: 0x06003AA8 RID: 15016 RVA: 0x00134C40 File Offset: 0x00132E40
		[Token(Token = "0x6003AA8")]
		[Address(RVA = "0x7938D0", Offset = "0x791ED0", VA = "0x1807938D0", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "阳光坚果 + 坚果墙\n使用火爆辣椒、向日葵进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x00134C6C File Offset: 0x00132E6C
		[Token(Token = "0x6003AA9")]
		[Address(RVA = "0x783650", Offset = "0x781C50", VA = "0x180783650", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06003AAA RID: 15018 RVA: 0x00134C98 File Offset: 0x00132E98
		[Token(Token = "0x17000445")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003AAA")]
			[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "12")]
			get
			{
				return SceneType.Day;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06003AAB RID: 15019 RVA: 0x00134CB0 File Offset: 0x00132EB0
		[Token(Token = "0x17000446")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003AAB")]
			[Address(RVA = "0x793B20", Offset = "0x792120", VA = "0x180793B20", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				int size6 = list._size;
				return list;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06003AAC RID: 15020 RVA: 0x00134D10 File Offset: 0x00132F10
		[Token(Token = "0x17000447")]
		public override int MaxWave
		{
			[Token(Token = "0x6003AAC")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06003AAD RID: 15021 RVA: 0x00134D20 File Offset: 0x00132F20
		[Token(Token = "0x17000448")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003AAD")]
			[Address(RVA = "0x793950", Offset = "0x791F50", VA = "0x180793950", Slot = "22")]
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

		// Token: 0x06003AAE RID: 15022 RVA: 0x00134D6C File Offset: 0x00132F6C
		[Token(Token = "0x6003AAE")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public SuperSunNut()
		{
		}
	}
}
