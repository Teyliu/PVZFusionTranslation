using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000813 RID: 2067
[Token(Token = "0x2000813")]
public class CheckNewAdv : MonoBehaviour
{
	// Token: 0x06002A0D RID: 10765 RVA: 0x000E5D70 File Offset: 0x000E3F70
	[Token(Token = "0x6002A0D")]
	[Address(RVA = "0x635260", Offset = "0x633860", VA = "0x180635260")]
	private void Start()
	{
		int buttonNumber = base.transform.GetChild(1).GetComponent<Advanture_Btn>().buttonNumber;
		GameObject gameObject = base.gameObject;
		bool flag = "{il2cpp field on {'constant15' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x88}" >= buttonNumber;
		gameObject.SetActive(flag);
	}

	// Token: 0x06002A0E RID: 10766 RVA: 0x000E5DB4 File Offset: 0x000E3FB4
	[Token(Token = "0x6002A0E")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public CheckNewAdv()
	{
	}
}
