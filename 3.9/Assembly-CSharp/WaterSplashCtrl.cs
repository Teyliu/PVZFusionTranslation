using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002FD RID: 765
[Token(Token = "0x20002FD")]
public class WaterSplashCtrl : MonoBehaviour
{
	// Token: 0x06000DB0 RID: 3504 RVA: 0x0004E218 File Offset: 0x0004C418
	[Token(Token = "0x6000DB0")]
	[Address(RVA = "0x458A70", Offset = "0x457070", VA = "0x180458A70")]
	private void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000DB1 RID: 3505 RVA: 0x0004E230 File Offset: 0x0004C430
	[Token(Token = "0x6000DB1")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public WaterSplashCtrl()
	{
	}
}
