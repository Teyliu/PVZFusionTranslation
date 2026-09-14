using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

namespace VarietyFX
{
	// Token: 0x02000D21 RID: 3361
	[Token(Token = "0x2000D21")]
	public class VarietyLoop : MonoBehaviour
	{
		// Token: 0x0600461F RID: 17951 RVA: 0x00162428 File Offset: 0x00160628
		[Token(Token = "0x600461F")]
		[Address(RVA = "0x850DE0", Offset = "0x84F3E0", VA = "0x180850DE0")]
		private void Start()
		{
			Coroutine coroutine = base.StartCoroutine("EffectLoop");
		}

		// Token: 0x06004620 RID: 17952 RVA: 0x00162444 File Offset: 0x00160644
		[Token(Token = "0x6004620")]
		[Address(RVA = "0x850DE0", Offset = "0x84F3E0", VA = "0x180850DE0")]
		public void PlayEffect()
		{
			Coroutine coroutine = base.StartCoroutine("EffectLoop");
		}

		// Token: 0x06004621 RID: 17953 RVA: 0x00162460 File Offset: 0x00160660
		[Token(Token = "0x6004621")]
		[Address(RVA = "0x850D70", Offset = "0x84F370", VA = "0x180850D70")]
		private IEnumerator EffectLoop()
		{
			VarietyLoop.<EffectLoop>d__4 <EffectLoop>d__;
			<EffectLoop>d__.System.IDisposable.Dispose();
			<EffectLoop>d__.<>1__state = (int)((ulong)0L);
			<EffectLoop>d__.<>4__this = this;
			return null;
		}

		// Token: 0x06004622 RID: 17954 RVA: 0x00162484 File Offset: 0x00160684
		[Token(Token = "0x6004622")]
		[Address(RVA = "0x850E20", Offset = "0x84F420", VA = "0x180850E20")]
		public VarietyLoop()
		{
		}

		// Token: 0x040031FE RID: 12798
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40031FE")]
		public GameObject chosenEffect;

		// Token: 0x040031FF RID: 12799
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40031FF")]
		public float loopTimeLimit = 2f;
	}
}
