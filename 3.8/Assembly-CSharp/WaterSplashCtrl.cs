using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002EF RID: 751
[Token(Token = "0x20002EF")]
public class WaterSplashCtrl : MonoBehaviour
{
	// Token: 0x06000D6D RID: 3437 RVA: 0x0004D5A4 File Offset: 0x0004B7A4
	[Token(Token = "0x6000D6D")]
	[Address(RVA = "0x4006B0", Offset = "0x3FECB0", VA = "0x1804006B0")]
	private void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000D6E RID: 3438 RVA: 0x0004D5BC File Offset: 0x0004B7BC
	[Token(Token = "0x6000D6E")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public WaterSplashCtrl()
	{
	}
}
