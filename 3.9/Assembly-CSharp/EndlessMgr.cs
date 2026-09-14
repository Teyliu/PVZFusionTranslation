using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000861 RID: 2145
[Token(Token = "0x2000861")]
public class EndlessMgr : MonoBehaviour
{
	// Token: 0x06002B8C RID: 11148 RVA: 0x000ECB64 File Offset: 0x000EAD64
	[Token(Token = "0x6002B8C")]
	[Address(RVA = "0x6B0EE0", Offset = "0x6AF4E0", VA = "0x1806B0EE0")]
	private void Awake()
	{
		SaveInfo instance = SaveInfo.Instance;
		int num = this.theLevel;
		if (instance.GetMaxRound(num, -1) > 0)
		{
			base.transform.GetChild(2).gameObject.SetActive(true);
			TextMeshProUGUI component = base.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
			string text = string.Format("{0}轮", component);
			component.text = text;
		}
	}

	// Token: 0x06002B8D RID: 11149 RVA: 0x000ECBCC File Offset: 0x000EADCC
	[Token(Token = "0x6002B8D")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public EndlessMgr()
	{
	}

	// Token: 0x040019A0 RID: 6560
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40019A0")]
	public int theLevel;
}
