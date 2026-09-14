using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000851 RID: 2129
[Token(Token = "0x2000851")]
public class CheckNewAdv : MonoBehaviour
{
	// Token: 0x06002B4B RID: 11083 RVA: 0x000EB0B0 File Offset: 0x000E92B0
	[Token(Token = "0x6002B4B")]
	[Address(RVA = "0x6997D0", Offset = "0x697DD0", VA = "0x1806997D0")]
	private void Start()
	{
		int buttonNumber = base.transform.GetChild(1).GetComponent<Advanture_Btn>().buttonNumber;
		GameObject gameObject = base.gameObject;
		bool flag = "{il2cpp field on {'constant15' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x88}" >= buttonNumber;
		gameObject.SetActive(flag);
	}

	// Token: 0x06002B4C RID: 11084 RVA: 0x000EB0F4 File Offset: 0x000E92F4
	[Token(Token = "0x6002B4C")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public CheckNewAdv()
	{
	}
}
