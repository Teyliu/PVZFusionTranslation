using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C71 RID: 3185
	[Token(Token = "0x2000C71")]
	public class Shooting_抢你小车 : BaseDebuff
	{
		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06004249 RID: 16969 RVA: 0x0015BA64 File Offset: 0x00159C64
		[Token(Token = "0x1700057D")]
		public override int Point
		{
			[Token(Token = "0x6004249")]
			[Address(RVA = "0x720BB0", Offset = "0x71F1B0", VA = "0x180720BB0", Slot = "21")]
			get
			{
				return 50;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x0600424A RID: 16970 RVA: 0x0015BA74 File Offset: 0x00159C74
		[Token(Token = "0x1700057E")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x600424A")]
			[Address(RVA = "0x89F520", Offset = "0x89DB20", VA = "0x18089F520", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_抢你小车;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x0600424B RID: 16971 RVA: 0x0015BA88 File Offset: 0x00159C88
		[Token(Token = "0x1700057F")]
		public override string Description
		{
			[Token(Token = "0x600424B")]
			[Address(RVA = "0x89F530", Offset = "0x89DB30", VA = "0x18089F530", Slot = "13")]
			get
			{
				return "抢你小车：禁用小推车";
			}
		}

		// Token: 0x0600424C RID: 16972 RVA: 0x0015BA9C File Offset: 0x00159C9C
		[Token(Token = "0x600424C")]
		[Address(RVA = "0x89F390", Offset = "0x89D990", VA = "0x18089F390", Slot = "17")]
		public override void OnSelect(Board board)
		{
			base.OnSelect(board);
			List<Mower> list = Enumerable.ToList<Mower>(board.mowerArray);
			Action<Mower> <>9__6_ = Shooting_抢你小车.<>c.<>9__6_0;
			if (<>9__6_ == 0)
			{
				Action<Mower> action;
				Shooting_抢你小车.<>c.<>9__6_0 = action;
			}
			global::Core.Lawnf.Foreach<Mower>(list, <>9__6_);
		}

		// Token: 0x0600424D RID: 16973 RVA: 0x0015BADC File Offset: 0x00159CDC
		[Token(Token = "0x600424D")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_抢你小车()
		{
		}
	}
}
