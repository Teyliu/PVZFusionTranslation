using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020007FD RID: 2045
[Token(Token = "0x20007FD")]
public class AdvantureLevelText : MonoBehaviour
{
	// Token: 0x06002969 RID: 10601 RVA: 0x000DF9E0 File Offset: 0x000DDBE0
	[Token(Token = "0x6002969")]
	[Address(RVA = "0x6803D0", Offset = "0x67E9D0", VA = "0x1806803D0")]
	private void Start()
	{
		TextMeshProUGUI component = base.GetComponent<TextMeshProUGUI>();
		this.textMesh = component;
		TextMeshProUGUI textMeshProUGUI = this.textMesh;
		if (!this.big)
		{
			int num = GameAPP.advantureLevel;
			ulong num2;
			num2 += num2;
			num = (int)((ulong)num - num2);
			num++;
		}
		ulong num3;
		num3 += (ulong)1L;
		num3 += num3;
		string text;
		textMeshProUGUI.text = text;
	}

	// Token: 0x0600296A RID: 10602 RVA: 0x000DFA40 File Offset: 0x000DDC40
	[Token(Token = "0x600296A")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public AdvantureLevelText()
	{
	}

	// Token: 0x04001773 RID: 6003
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001773")]
	public bool big;

	// Token: 0x04001774 RID: 6004
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001774")]
	private TextMeshProUGUI textMesh;
}
