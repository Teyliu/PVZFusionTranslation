using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020007C4 RID: 1988
[Token(Token = "0x20007C4")]
public class AdvantureLevelText : MonoBehaviour
{
	// Token: 0x0600283A RID: 10298 RVA: 0x000DAA24 File Offset: 0x000D8C24
	[Token(Token = "0x600283A")]
	[Address(RVA = "0x61CB10", Offset = "0x61B110", VA = "0x18061CB10")]
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

	// Token: 0x0600283B RID: 10299 RVA: 0x000DAA84 File Offset: 0x000D8C84
	[Token(Token = "0x600283B")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public AdvantureLevelText()
	{
	}

	// Token: 0x04001697 RID: 5783
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001697")]
	public bool big;

	// Token: 0x04001698 RID: 5784
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001698")]
	private TextMeshProUGUI textMesh;
}
