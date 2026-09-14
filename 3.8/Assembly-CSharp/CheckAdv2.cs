using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000812 RID: 2066
[Token(Token = "0x2000812")]
public class CheckAdv2 : MonoBehaviour
{
	// Token: 0x06002A0B RID: 10763 RVA: 0x000E5D14 File Offset: 0x000E3F14
	[Token(Token = "0x6002A0B")]
	[Address(RVA = "0x635160", Offset = "0x633760", VA = "0x180635160")]
	private void Start()
	{
		if (base.transform.GetChild(1).GetComponent<Advanture_Btn>().buttonNumber != 1)
		{
			GameObject gameObject = base.gameObject;
			List<AdvantureLevel> levelCompleted = AdvantureConfig.data.levelCompleted;
			bool flag;
			gameObject.SetActive(flag);
		}
	}

	// Token: 0x06002A0C RID: 10764 RVA: 0x000E5D5C File Offset: 0x000E3F5C
	[Token(Token = "0x6002A0C")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public CheckAdv2()
	{
	}
}
