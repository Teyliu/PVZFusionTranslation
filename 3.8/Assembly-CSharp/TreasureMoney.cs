using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x0200061B RID: 1563
[Token(Token = "0x200061B")]
public class TreasureMoney : MonoBehaviour
{
	// Token: 0x06001D83 RID: 7555 RVA: 0x0009DB18 File Offset: 0x0009BD18
	[Token(Token = "0x6001D83")]
	[Address(RVA = "0x52A560", Offset = "0x528B60", VA = "0x18052A560")]
	private void Awake()
	{
		TextMeshProUGUI component = base.GetComponent<TextMeshProUGUI>();
		this.text = component;
	}

	// Token: 0x06001D84 RID: 7556 RVA: 0x0009DB34 File Offset: 0x0009BD34
	[Token(Token = "0x6001D84")]
	[Address(RVA = "0x52A5B0", Offset = "0x528BB0", VA = "0x18052A5B0")]
	private void Update()
	{
		TextMeshProUGUI textMeshProUGUI = this.text;
		int treasureMoney = TreasureData.treasureMoney;
		string text;
		textMeshProUGUI.text = text;
	}

	// Token: 0x06001D85 RID: 7557 RVA: 0x0009DB5C File Offset: 0x0009BD5C
	[Token(Token = "0x6001D85")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public TreasureMoney()
	{
	}

	// Token: 0x04001021 RID: 4129
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001021")]
	private TextMeshProUGUI text;
}
