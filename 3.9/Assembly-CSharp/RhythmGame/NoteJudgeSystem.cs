using System;
using Cpp2IlInjected;
using UnityEngine;

namespace RhythmGame
{
	// Token: 0x02000A8E RID: 2702
	[Token(Token = "0x2000A8E")]
	public class NoteJudgeSystem
	{
		// Token: 0x06003773 RID: 14195 RVA: 0x001295E0 File Offset: 0x001277E0
		[Token(Token = "0x6003773")]
		[Address(RVA = "0x7D38A0", Offset = "0x7D1EA0", VA = "0x1807D38A0")]
		public NoteJudgeSystem.JudgeResult Judge(float clickTime, float noteTargetTime)
		{
			int num = 0;
			num += 2;
			return NoteJudgeSystem.JudgeResult.Perfect;
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x00129600 File Offset: 0x00127800
		[Token(Token = "0x6003774")]
		[Address(RVA = "0x7D3710", Offset = "0x7D1D10", VA = "0x1807D3710")]
		public int GetScore(NoteJudgeSystem.JudgeResult result)
		{
			if (result == NoteJudgeSystem.JudgeResult.Perfect)
			{
				return 0;
			}
			if (result == NoteJudgeSystem.JudgeResult.Perfect)
			{
				return 0;
			}
			if (result != NoteJudgeSystem.JudgeResult.Perfect)
			{
				return 0;
			}
			return 0;
		}

		// Token: 0x06003775 RID: 14197 RVA: 0x00129624 File Offset: 0x00127824
		[Token(Token = "0x6003775")]
		[Address(RVA = "0x7D3710", Offset = "0x7D1D10", VA = "0x1807D3710")]
		public int GetDamage(NoteJudgeSystem.JudgeResult result)
		{
			if (result == NoteJudgeSystem.JudgeResult.Perfect)
			{
				return 0;
			}
			if (result == NoteJudgeSystem.JudgeResult.Perfect)
			{
				return 0;
			}
			if (result != NoteJudgeSystem.JudgeResult.Perfect)
			{
				return 0;
			}
			return 0;
		}

		// Token: 0x06003776 RID: 14198 RVA: 0x00129648 File Offset: 0x00127848
		[Token(Token = "0x6003776")]
		[Address(RVA = "0x7D3740", Offset = "0x7D1D40", VA = "0x1807D3740")]
		public Color GetResultColor(NoteJudgeSystem.JudgeResult result)
		{
			return default(Color);
		}

		// Token: 0x06003777 RID: 14199 RVA: 0x00129660 File Offset: 0x00127860
		[Token(Token = "0x6003777")]
		[Address(RVA = "0x7D37E0", Offset = "0x7D1DE0", VA = "0x1807D37E0")]
		public string GetResultText(NoteJudgeSystem.JudgeResult result)
		{
			if (result == NoteJudgeSystem.JudgeResult.Perfect)
			{
				return "PERFECT!";
			}
			if (result == NoteJudgeSystem.JudgeResult.Perfect)
			{
				return "GREAT!";
			}
			if (result == NoteJudgeSystem.JudgeResult.Perfect)
			{
				return "GOOD";
			}
			if (result != NoteJudgeSystem.JudgeResult.Great)
			{
				return "";
			}
			return "MISS";
		}

		// Token: 0x06003778 RID: 14200 RVA: 0x0012969C File Offset: 0x0012789C
		[Token(Token = "0x6003778")]
		[Address(RVA = "0x7D38A0", Offset = "0x7D1EA0", VA = "0x1807D38A0")]
		public NoteJudgeSystem.JudgeResult JudgeHoldStart(float clickTime, float noteTargetTime)
		{
			int num = 0;
			num += 2;
			return NoteJudgeSystem.JudgeResult.Perfect;
		}

		// Token: 0x06003779 RID: 14201 RVA: 0x001296BC File Offset: 0x001278BC
		[Token(Token = "0x6003779")]
		[Address(RVA = "0x7D3890", Offset = "0x7D1E90", VA = "0x1807D3890")]
		public bool JudgeHoldReleasedEarly(float releaseTime, float noteEndTime)
		{
			return false;
		}

		// Token: 0x0600377A RID: 14202 RVA: 0x001296CC File Offset: 0x001278CC
		[Token(Token = "0x600377A")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public NoteJudgeSystem()
		{
		}

		// Token: 0x04002AFF RID: 11007
		[Token(Token = "0x4002AFF")]
		private const float PERFECT_WINDOW = 0.07f;

		// Token: 0x04002B00 RID: 11008
		[Token(Token = "0x4002B00")]
		private const float GREAT_WINDOW = 0.12f;

		// Token: 0x04002B01 RID: 11009
		[Token(Token = "0x4002B01")]
		private const float GOOD_WINDOW = 0.15f;

		// Token: 0x02000A8F RID: 2703
		[Token(Token = "0x2000A8F")]
		public enum JudgeResult
		{
			// Token: 0x04002B03 RID: 11011
			[Token(Token = "0x4002B03")]
			Perfect,
			// Token: 0x04002B04 RID: 11012
			[Token(Token = "0x4002B04")]
			Great,
			// Token: 0x04002B05 RID: 11013
			[Token(Token = "0x4002B05")]
			Good,
			// Token: 0x04002B06 RID: 11014
			[Token(Token = "0x4002B06")]
			Miss
		}
	}
}
