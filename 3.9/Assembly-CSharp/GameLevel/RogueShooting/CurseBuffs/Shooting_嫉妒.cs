using System;
using Core;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting.CurseBuffs
{
	// Token: 0x02000DBF RID: 3519
	[Token(Token = "0x2000DBF")]
	public class Shooting_嫉妒 : BaseCurse
	{
		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x0600492C RID: 18732 RVA: 0x0016B5B0 File Offset: 0x001697B0
		[Token(Token = "0x1700092D")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x600492C")]
			[Address(RVA = "0x8B4DF0", Offset = "0x8B33F0", VA = "0x1808B4DF0", Slot = "12")]
			get
			{
				return AdvBuff.Shooting_嫉妒之惩;
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x0600492D RID: 18733 RVA: 0x0016B5C4 File Offset: 0x001697C4
		[Token(Token = "0x1700092E")]
		public override string Description
		{
			[Token(Token = "0x600492D")]
			[Address(RVA = "0x8B4E00", Offset = "0x8B3400", VA = "0x1808B4E00", Slot = "13")]
			get
			{
				return "嫉妒：当僵尸血量高于50%时，额外造成30%伤害，当僵尸血量低于50%时，少造成30%伤害";
			}
		}

		// Token: 0x0600492E RID: 18734 RVA: 0x0016B5D8 File Offset: 0x001697D8
		[Token(Token = "0x600492E")]
		[Address(RVA = "0x8B4B60", Offset = "0x8B3160", VA = "0x1808B4B60", Slot = "17")]
		public override void OnSelect(Board board)
		{
			int num = 0;
			Action<object> action;
			EventManager.AddListener_obj((GameEvent)((uint)5), action, num != 0);
		}

		// Token: 0x0600492F RID: 18735 RVA: 0x0016B5F4 File Offset: 0x001697F4
		[Token(Token = "0x600492F")]
		[Address(RVA = "0x8B4C00", Offset = "0x8B3200", VA = "0x1808B4C00")]
		private void OnZombieTakeDamage(object obj)
		{
			if (obj != 0 && obj != 0)
			{
				long num2;
				int num = num2.ToInt();
				int num3 = 0;
				long num4;
				num4 -= (long)num3;
				long num5;
				if (num5 >= num4)
				{
					DamageReporter damageReporter = Board.Instance.damageReporter;
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x06004930 RID: 18736 RVA: 0x0016B638 File Offset: 0x00169838
		[Token(Token = "0x6004930")]
		[Address(RVA = "0x8A8560", Offset = "0x8A6B60", VA = "0x1808A8560")]
		public Shooting_嫉妒()
		{
		}
	}
}
