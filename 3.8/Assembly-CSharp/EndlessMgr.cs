using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000825 RID: 2085
[Token(Token = "0x2000825")]
public class EndlessMgr : MonoBehaviour
{
	// Token: 0x06002A5A RID: 10842 RVA: 0x000E7D28 File Offset: 0x000E5F28
	[Token(Token = "0x6002A5A")]
	[Address(RVA = "0x64D140", Offset = "0x64B740", VA = "0x18064D140")]
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

	// Token: 0x06002A5B RID: 10843 RVA: 0x000E7D90 File Offset: 0x000E5F90
	[Token(Token = "0x6002A5B")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public EndlessMgr()
	{
	}

	// Token: 0x040018B2 RID: 6322
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40018B2")]
	public int theLevel;
}
