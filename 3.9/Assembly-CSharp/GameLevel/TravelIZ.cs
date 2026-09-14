using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B3D RID: 2877
	[Token(Token = "0x2000B3D")]
	public class TravelIZ : SuperIZLevelData
	{
		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06003BBF RID: 15295 RVA: 0x00139464 File Offset: 0x00137664
		[Token(Token = "0x17000474")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003BBF")]
			[Address(RVA = "0x7FBDF0", Offset = "0x7FA3F0", VA = "0x1807FBDF0", Slot = "42")]
			get
			{
				return ChallengeLevel.SuperIZ;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06003BC0 RID: 15296 RVA: 0x00139478 File Offset: 0x00137678
		[Token(Token = "0x17000475")]
		public override string Name
		{
			[Token(Token = "0x6003BC0")]
			[Address(RVA = "0x7FBE00", Offset = "0x7FA400", VA = "0x1807FBE00", Slot = "8")]
			get
			{
				return "超级僵尸大战";
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06003BC1 RID: 15297 RVA: 0x0013948C File Offset: 0x0013768C
		[Token(Token = "0x17000476")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003BC1")]
			[Address(RVA = "0x3FA3D0", Offset = "0x3F89D0", VA = "0x1803FA3D0", Slot = "12")]
			get
			{
				return SceneType.Night_6;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06003BC2 RID: 15298 RVA: 0x0013949C File Offset: 0x0013769C
		[Token(Token = "0x17000477")]
		public override List<ZombieType> PreselectCards_zombie
		{
			[Token(Token = "0x6003BC2")]
			[Address(RVA = "0x7FBE30", Offset = "0x7FA430", VA = "0x1807FBE30", Slot = "24")]
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

		// Token: 0x06003BC3 RID: 15299 RVA: 0x00139518 File Offset: 0x00137718
		[Token(Token = "0x6003BC3")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public TravelIZ()
		{
		}
	}
}
