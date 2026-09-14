using System;
using Cpp2IlInjected;

namespace RhythmGame
{
	// Token: 0x02000A4A RID: 2634
	[Token(Token = "0x2000A4A")]
	[Serializable]
	public class ComboManager
	{
		// Token: 0x06003614 RID: 13844 RVA: 0x001237E4 File Offset: 0x001219E4
		[Token(Token = "0x6003614")]
		[Address(RVA = "0x74CCE0", Offset = "0x74B2E0", VA = "0x18074CCE0")]
		public void AddCombo(NoteJudgeSystem.JudgeResult result)
		{
			if (result != NoteJudgeSystem.JudgeResult.Miss)
			{
				int num = this.currentCombo;
				num++;
				this.currentCombo = num;
				if (result == NoteJudgeSystem.JudgeResult.Perfect || result == NoteJudgeSystem.JudgeResult.Perfect || result == NoteJudgeSystem.JudgeResult.Great)
				{
				}
				if (num > this.maxCombo)
				{
					this.maxCombo = num;
					return;
				}
			}
			else
			{
				this.currentCombo = (int)((ulong)0L);
			}
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x00123830 File Offset: 0x00121A30
		[Token(Token = "0x6003615")]
		[Address(RVA = "0x74CD50", Offset = "0x74B350", VA = "0x18074CD50")]
		public void ResetCombo()
		{
			this.currentCombo = (int)((ulong)0L);
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x00123848 File Offset: 0x00121A48
		[Token(Token = "0x6003616")]
		[Address(RVA = "0x74CD30", Offset = "0x74B330", VA = "0x18074CD30")]
		public int GetExtraBulletCount()
		{
			return 0;
		}

		// Token: 0x06003617 RID: 13847 RVA: 0x00123858 File Offset: 0x00121A58
		[Token(Token = "0x6003617")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public ComboManager()
		{
		}

		// Token: 0x0400296C RID: 10604
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400296C")]
		public int currentCombo;

		// Token: 0x0400296D RID: 10605
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400296D")]
		public int maxCombo;

		// Token: 0x0400296E RID: 10606
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400296E")]
		public int perfectCount;

		// Token: 0x0400296F RID: 10607
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400296F")]
		public int greatCount;

		// Token: 0x04002970 RID: 10608
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002970")]
		public int goodCount;

		// Token: 0x04002971 RID: 10609
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4002971")]
		public int missCount;

		// Token: 0x04002972 RID: 10610
		[Token(Token = "0x4002972")]
		private const int COMBO_BONUS_THRESHOLD = 10;
	}
}
