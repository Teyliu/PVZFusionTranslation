using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020008A1 RID: 2209
[Token(Token = "0x20008A1")]
public class UIZombieNum : MonoBehaviour
{
	// Token: 0x06002D01 RID: 11521 RVA: 0x000F8084 File Offset: 0x000F6284
	[Token(Token = "0x6002D01")]
	[Address(RVA = "0x695530", Offset = "0x693B30", VA = "0x180695530")]
	private void Start()
	{
		TextMeshProUGUI component = base.GetComponent<TextMeshProUGUI>();
		this.t = component;
		Board instance = Board.Instance;
		this.board = instance;
	}

	// Token: 0x06002D02 RID: 11522 RVA: 0x000F80AC File Offset: 0x000F62AC
	[Token(Token = "0x6002D02")]
	[Address(RVA = "0x6955B0", Offset = "0x693BB0", VA = "0x1806955B0")]
	private void Update()
	{
		int enermyCount = this.board.enermyCount;
		TextMeshProUGUI textMeshProUGUI = this.t;
		string text = string.Format("场上敌人数量：{0}", "场上敌人数量：{0}\t\t\t\t\t\t植物限制：{1}/{2}");
		textMeshProUGUI.text = text;
		Board board = this.board;
		TextMeshProUGUI textMeshProUGUI2 = this.t;
		string text2 = textMeshProUGUI2.text;
		Board board2 = this.board;
		string text3 = string.Format("\n当前分数：{0}", text2);
		string text4 = text2 + text3;
		textMeshProUGUI2.text = text4;
	}

	// Token: 0x06002D03 RID: 11523 RVA: 0x000F816C File Offset: 0x000F636C
	[Token(Token = "0x6002D03")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public UIZombieNum()
	{
	}

	// Token: 0x04001B20 RID: 6944
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001B20")]
	private TextMeshProUGUI t;

	// Token: 0x04001B21 RID: 6945
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001B21")]
	private Board board;
}
