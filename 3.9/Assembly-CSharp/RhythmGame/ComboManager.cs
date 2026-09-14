using System;
using Cpp2IlInjected;

namespace RhythmGame
{
	// Token: 0x02000A8A RID: 2698
	[Token(Token = "0x2000A8A")]
	[Serializable]
	public class ComboManager
	{
		// Token: 0x06003758 RID: 14168 RVA: 0x00128A60 File Offset: 0x00126C60
		[Token(Token = "0x6003758")]
		[Address(RVA = "0x7B36A0", Offset = "0x7B1CA0", VA = "0x1807B36A0")]
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

		// Token: 0x06003759 RID: 14169 RVA: 0x00128AAC File Offset: 0x00126CAC
		[Token(Token = "0x6003759")]
		[Address(RVA = "0x7B3710", Offset = "0x7B1D10", VA = "0x1807B3710")]
		public void ResetCombo()
		{
			this.currentCombo = (int)((ulong)0L);
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x00128AC4 File Offset: 0x00126CC4
		[Token(Token = "0x600375A")]
		[Address(RVA = "0x7B36F0", Offset = "0x7B1CF0", VA = "0x1807B36F0")]
		public int GetExtraBulletCount()
		{
			return 0;
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x00128AD4 File Offset: 0x00126CD4
		[Token(Token = "0x600375B")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public ComboManager()
		{
		}

		// Token: 0x04002ADF RID: 10975
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002ADF")]
		public int currentCombo;

		// Token: 0x04002AE0 RID: 10976
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4002AE0")]
		public int maxCombo;

		// Token: 0x04002AE1 RID: 10977
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002AE1")]
		public int perfectCount;

		// Token: 0x04002AE2 RID: 10978
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4002AE2")]
		public int greatCount;

		// Token: 0x04002AE3 RID: 10979
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002AE3")]
		public int goodCount;

		// Token: 0x04002AE4 RID: 10980
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4002AE4")]
		public int missCount;

		// Token: 0x04002AE5 RID: 10981
		[Token(Token = "0x4002AE5")]
		private const int COMBO_BONUS_THRESHOLD = 10;
	}
}
