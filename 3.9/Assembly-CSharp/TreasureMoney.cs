using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000650 RID: 1616
[Token(Token = "0x2000650")]
public class TreasureMoney : MonoBehaviour
{
	// Token: 0x06001E82 RID: 7810 RVA: 0x000A2570 File Offset: 0x000A0770
	[Token(Token = "0x6001E82")]
	[Address(RVA = "0x595740", Offset = "0x593D40", VA = "0x180595740")]
	private void Awake()
	{
		TextMeshProUGUI component = base.GetComponent<TextMeshProUGUI>();
		this.text = component;
	}

	// Token: 0x06001E83 RID: 7811 RVA: 0x000A258C File Offset: 0x000A078C
	[Token(Token = "0x6001E83")]
	[Address(RVA = "0x595790", Offset = "0x593D90", VA = "0x180595790")]
	private void Update()
	{
		TextMeshProUGUI textMeshProUGUI = this.text;
		int treasureMoney = TreasureData.treasureMoney;
		string text;
		textMeshProUGUI.text = text;
	}

	// Token: 0x06001E84 RID: 7812 RVA: 0x000A25B4 File Offset: 0x000A07B4
	[Token(Token = "0x6001E84")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public TreasureMoney()
	{
	}

	// Token: 0x040010E9 RID: 4329
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010E9")]
	private TextMeshProUGUI text;
}
