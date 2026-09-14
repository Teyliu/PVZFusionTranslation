using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x0200089E RID: 2206
[Token(Token = "0x200089E")]
public class UIDifficulty : MonoBehaviour
{
	// Token: 0x06002CF6 RID: 11510 RVA: 0x000F7E14 File Offset: 0x000F6014
	[Token(Token = "0x6002CF6")]
	[Address(RVA = "0x694B60", Offset = "0x693160", VA = "0x180694B60")]
	private void Start()
	{
		TextMeshProUGUI component = base.GetComponent<TextMeshProUGUI>();
		this.t = component;
	}

	// Token: 0x06002CF7 RID: 11511 RVA: 0x000F7E30 File Offset: 0x000F6030
	[Token(Token = "0x6002CF7")]
	[Address(RVA = "0x694BB0", Offset = "0x6931B0", VA = "0x180694BB0")]
	private void Update()
	{
		TextMeshProUGUI textMeshProUGUI = this.t;
		int difficulty = GameAPP.config.difficulty;
		string text = string.Format("难度：{0}", difficulty);
		textMeshProUGUI.text = text;
	}

	// Token: 0x06002CF8 RID: 11512 RVA: 0x000F7E70 File Offset: 0x000F6070
	[Token(Token = "0x6002CF8")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public UIDifficulty()
	{
	}

	// Token: 0x04001B18 RID: 6936
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001B18")]
	private TextMeshProUGUI t;
}
