using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

namespace VarietyFX
{
	// Token: 0x02000DED RID: 3565
	[Token(Token = "0x2000DED")]
	public class VarietyLoop : MonoBehaviour
	{
		// Token: 0x060049CE RID: 18894 RVA: 0x0016CB40 File Offset: 0x0016AD40
		[Token(Token = "0x60049CE")]
		[Address(RVA = "0x8DC910", Offset = "0x8DAF10", VA = "0x1808DC910")]
		private void Start()
		{
			Coroutine coroutine = base.StartCoroutine("EffectLoop");
		}

		// Token: 0x060049CF RID: 18895 RVA: 0x0016CB5C File Offset: 0x0016AD5C
		[Token(Token = "0x60049CF")]
		[Address(RVA = "0x8DC910", Offset = "0x8DAF10", VA = "0x1808DC910")]
		public void PlayEffect()
		{
			Coroutine coroutine = base.StartCoroutine("EffectLoop");
		}

		// Token: 0x060049D0 RID: 18896 RVA: 0x0016CB78 File Offset: 0x0016AD78
		[Token(Token = "0x60049D0")]
		[Address(RVA = "0x8DC8A0", Offset = "0x8DAEA0", VA = "0x1808DC8A0")]
		private IEnumerator EffectLoop()
		{
			VarietyLoop.<EffectLoop>d__4 <EffectLoop>d__;
			<EffectLoop>d__.System.IDisposable.Dispose();
			<EffectLoop>d__.<>1__state = (int)((ulong)0L);
			<EffectLoop>d__.<>4__this = this;
			return null;
		}

		// Token: 0x060049D1 RID: 18897 RVA: 0x0016CB9C File Offset: 0x0016AD9C
		[Token(Token = "0x60049D1")]
		[Address(RVA = "0x8DC950", Offset = "0x8DAF50", VA = "0x1808DC950")]
		public VarietyLoop()
		{
		}

		// Token: 0x0400341D RID: 13341
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400341D")]
		public GameObject chosenEffect;

		// Token: 0x0400341E RID: 13342
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400341E")]
		public float loopTimeLimit = 2f;
	}
}
