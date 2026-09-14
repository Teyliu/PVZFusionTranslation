using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000C49 RID: 3145
	[Token(Token = "0x2000C49")]
	public class Round1_4 : AbyssLevelData
	{
		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600417F RID: 16767 RVA: 0x00157FB8 File Offset: 0x001561B8
		[Token(Token = "0x17000543")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x600417F")]
			[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_4;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06004180 RID: 16768 RVA: 0x00157FC8 File Offset: 0x001561C8
		[Token(Token = "0x17000544")]
		public override int MaxWave
		{
			[Token(Token = "0x6004180")]
			[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "10")]
			get
			{
				return 10;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06004181 RID: 16769 RVA: 0x00157FD8 File Offset: 0x001561D8
		[Token(Token = "0x17000545")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6004181")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "12")]
			get
			{
				return SceneType.Night;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06004182 RID: 16770 RVA: 0x00157FE8 File Offset: 0x001561E8
		[Token(Token = "0x17000546")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6004182")]
			[Address(RVA = "0x87FC80", Offset = "0x87E280", VA = "0x18087FC80", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06004183 RID: 16771 RVA: 0x00158030 File Offset: 0x00156230
		[Token(Token = "0x6004183")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public Round1_4()
		{
		}
	}
}
