using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200063B RID: 1595
[Token(Token = "0x200063B")]
public class Charred : MonoBehaviour
{
	// Token: 0x06001E55 RID: 7765 RVA: 0x000A23B8 File Offset: 0x000A05B8
	[Token(Token = "0x6001E55")]
	[Address(RVA = "0x538600", Offset = "0x536C00", VA = "0x180538600")]
	public void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject, 0.2f);
	}

	// Token: 0x06001E56 RID: 7766 RVA: 0x000A23D8 File Offset: 0x000A05D8
	[Token(Token = "0x6001E56")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public Charred()
	{
	}
}
