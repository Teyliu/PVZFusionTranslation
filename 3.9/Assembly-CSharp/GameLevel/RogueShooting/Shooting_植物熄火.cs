using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C63 RID: 3171
	[Token(Token = "0x2000C63")]
	public class Shooting_植物熄火 : BaseDebuff
	{
		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06004216 RID: 16918 RVA: 0x0015B3F0 File Offset: 0x001595F0
		[Token(Token = "0x17000565")]
		public override int Point
		{
			[Token(Token = "0x6004216")]
			[Address(RVA = "0x88CB90", Offset = "0x88B190", VA = "0x18088CB90", Slot = "21")]
			get
			{
				return 150;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06004217 RID: 16919 RVA: 0x0015B404 File Offset: 0x00159604
		[Token(Token = "0x17000566")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x6004217")]
			[Address(RVA = "0x88CB50", Offset = "0x88B150", VA = "0x18088CB50", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_植物熄火;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06004218 RID: 16920 RVA: 0x0015B418 File Offset: 0x00159618
		[Token(Token = "0x17000567")]
		public override string Description
		{
			[Token(Token = "0x6004218")]
			[Address(RVA = "0x88CB60", Offset = "0x88B160", VA = "0x18088CB60", Slot = "13")]
			get
			{
				return "植物熄火：每一波开始后的前2秒内植物方造成的伤害降低至1点";
			}
		}

		// Token: 0x06004219 RID: 16921 RVA: 0x0015B42C File Offset: 0x0015962C
		[Token(Token = "0x6004219")]
		[Address(RVA = "0x88CA30", Offset = "0x88B030", VA = "0x18088CA30", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Action <>9__7_ = Shooting_植物熄火.<>c.<>9__7_0;
			if (<>9__7_ == 0)
			{
				Shooting_植物熄火.<>c.<>9__7_0 = delegate
				{
					Shooting_植物熄火.timer = Time.time;
				};
			}
			int num = 0;
			EventManager.AddListener(GameEvent.BoardWaveAdd, <>9__7_, num != 0);
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x0015B464 File Offset: 0x00159664
		[Token(Token = "0x600421A")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_植物熄火()
		{
		}

		// Token: 0x04003278 RID: 12920
		[Token(Token = "0x4003278")]
		public static float timer;
	}
}
