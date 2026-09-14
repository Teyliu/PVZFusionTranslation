using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000850 RID: 2128
[Token(Token = "0x2000850")]
public class CheckAdv2 : MonoBehaviour
{
	// Token: 0x06002B49 RID: 11081 RVA: 0x000EB054 File Offset: 0x000E9254
	[Token(Token = "0x6002B49")]
	[Address(RVA = "0x6996D0", Offset = "0x697CD0", VA = "0x1806996D0")]
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

	// Token: 0x06002B4A RID: 11082 RVA: 0x000EB09C File Offset: 0x000E929C
	[Token(Token = "0x6002B4A")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public CheckAdv2()
	{
	}
}
