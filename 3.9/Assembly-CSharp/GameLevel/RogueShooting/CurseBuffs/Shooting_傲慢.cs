using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting.CurseBuffs
{
	// Token: 0x02000DBD RID: 3517
	[Token(Token = "0x2000DBD")]
	public class Shooting_傲慢 : BaseCurse
	{
		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06004924 RID: 18724 RVA: 0x0016B4C0 File Offset: 0x001696C0
		[Token(Token = "0x1700092B")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004924")]
			[Address(RVA = "0x8B4B20", Offset = "0x8B3120", VA = "0x1808B4B20", Slot = "12")]
			get
			{
				return AdvBuff.Shooting_傲慢之罚;
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06004925 RID: 18725 RVA: 0x0016B4D4 File Offset: 0x001696D4
		[Token(Token = "0x1700092C")]
		public override string Description
		{
			[Token(Token = "0x6004925")]
			[Address(RVA = "0x8B4B30", Offset = "0x8B3130", VA = "0x1808B4B30", Slot = "13")]
			get
			{
				return "傲慢：当你的植物在僵尸上方时，额外造成30%伤害，当你的植物在僵尸下方时，少造成30%伤害，方位以屏幕上下判定";
			}
		}

		// Token: 0x06004926 RID: 18726 RVA: 0x0016B4E8 File Offset: 0x001696E8
		[Token(Token = "0x6004926")]
		[Address(RVA = "0x8B4700", Offset = "0x8B2D00", VA = "0x1808B4700", Slot = "17")]
		public override void OnSelect(Board board)
		{
			int num = 0;
			Action<object> action;
			EventManager.AddListener_obj((GameEvent)((uint)5), action, num != 0);
		}

		// Token: 0x06004927 RID: 18727 RVA: 0x0016B504 File Offset: 0x00169704
		[Token(Token = "0x6004927")]
		[Address(RVA = "0x8B47A0", Offset = "0x8B2DA0", VA = "0x1808B47A0")]
		private void OnZombieTakeDamage(object obj)
		{
			if (obj != 0 && obj != 0)
			{
				Func<Plant, int> <>9__5_ = Shooting_傲慢.<>c.<>9__5_0;
				if (<>9__5_ == 0)
				{
					Func<Plant, int> func;
					Shooting_傲慢.<>c.<>9__5_0 = func;
				}
				List<Plant> list;
				double num = Enumerable.Average<Plant>(list, <>9__5_);
				long num3;
				int num2 = num3.ToInt();
			}
		}

		// Token: 0x06004928 RID: 18728 RVA: 0x0016B554 File Offset: 0x00169754
		[Token(Token = "0x6004928")]
		[Address(RVA = "0x8A8560", Offset = "0x8A6B60", VA = "0x1808A8560")]
		public Shooting_傲慢()
		{
		}
	}
}
