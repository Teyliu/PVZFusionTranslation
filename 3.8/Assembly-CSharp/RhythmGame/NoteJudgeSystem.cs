using System;
using Cpp2IlInjected;
using UnityEngine;

namespace RhythmGame
{
	// Token: 0x02000A4E RID: 2638
	[Token(Token = "0x2000A4E")]
	public class NoteJudgeSystem
	{
		// Token: 0x0600362F RID: 13871 RVA: 0x00124364 File Offset: 0x00122564
		[Token(Token = "0x600362F")]
		[Address(RVA = "0x76CA60", Offset = "0x76B060", VA = "0x18076CA60")]
		public NoteJudgeSystem.JudgeResult Judge(float clickTime, float noteTargetTime)
		{
			int num = 0;
			num += 2;
			return NoteJudgeSystem.JudgeResult.Perfect;
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x00124384 File Offset: 0x00122584
		[Token(Token = "0x6003630")]
		[Address(RVA = "0x76C8D0", Offset = "0x76AED0", VA = "0x18076C8D0")]
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

		// Token: 0x06003631 RID: 13873 RVA: 0x001243A8 File Offset: 0x001225A8
		[Token(Token = "0x6003631")]
		[Address(RVA = "0x76C8D0", Offset = "0x76AED0", VA = "0x18076C8D0")]
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

		// Token: 0x06003632 RID: 13874 RVA: 0x001243CC File Offset: 0x001225CC
		[Token(Token = "0x6003632")]
		[Address(RVA = "0x76C900", Offset = "0x76AF00", VA = "0x18076C900")]
		public Color GetResultColor(NoteJudgeSystem.JudgeResult result)
		{
			return default(Color);
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x001243E4 File Offset: 0x001225E4
		[Token(Token = "0x6003633")]
		[Address(RVA = "0x76C9A0", Offset = "0x76AFA0", VA = "0x18076C9A0")]
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

		// Token: 0x06003634 RID: 13876 RVA: 0x00124420 File Offset: 0x00122620
		[Token(Token = "0x6003634")]
		[Address(RVA = "0x76CA60", Offset = "0x76B060", VA = "0x18076CA60")]
		public NoteJudgeSystem.JudgeResult JudgeHoldStart(float clickTime, float noteTargetTime)
		{
			int num = 0;
			num += 2;
			return NoteJudgeSystem.JudgeResult.Perfect;
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x00124440 File Offset: 0x00122640
		[Token(Token = "0x6003635")]
		[Address(RVA = "0x76CA50", Offset = "0x76B050", VA = "0x18076CA50")]
		public bool JudgeHoldReleasedEarly(float releaseTime, float noteEndTime)
		{
			return false;
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x00124450 File Offset: 0x00122650
		[Token(Token = "0x6003636")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public NoteJudgeSystem()
		{
		}

		// Token: 0x0400298C RID: 10636
		[Token(Token = "0x400298C")]
		private const float PERFECT_WINDOW = 0.07f;

		// Token: 0x0400298D RID: 10637
		[Token(Token = "0x400298D")]
		private const float GREAT_WINDOW = 0.12f;

		// Token: 0x0400298E RID: 10638
		[Token(Token = "0x400298E")]
		private const float GOOD_WINDOW = 0.15f;

		// Token: 0x02000A4F RID: 2639
		[Token(Token = "0x2000A4F")]
		public enum JudgeResult
		{
			// Token: 0x04002990 RID: 10640
			[Token(Token = "0x4002990")]
			Perfect,
			// Token: 0x04002991 RID: 10641
			[Token(Token = "0x4002991")]
			Great,
			// Token: 0x04002992 RID: 10642
			[Token(Token = "0x4002992")]
			Good,
			// Token: 0x04002993 RID: 10643
			[Token(Token = "0x4002993")]
			Miss
		}
	}
}
