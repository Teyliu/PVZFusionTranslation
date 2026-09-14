using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020008A0 RID: 2208
[Token(Token = "0x20008A0")]
public class UIProgress2 : MonoBehaviour
{
	// Token: 0x06002CFE RID: 11518 RVA: 0x000F7F84 File Offset: 0x000F6184
	[Token(Token = "0x6002CFE")]
	[Address(RVA = "0x695270", Offset = "0x693870", VA = "0x180695270")]
	private void Start()
	{
		Board instance = Board.Instance;
		this.Board = instance;
		TextMeshProUGUI component = base.GetComponent<TextMeshProUGUI>();
		this.t = component;
	}

	// Token: 0x06002CFF RID: 11519 RVA: 0x000F7FAC File Offset: 0x000F61AC
	[Token(Token = "0x6002CFF")]
	[Address(RVA = "0x6952F0", Offset = "0x6938F0", VA = "0x1806952F0")]
	private void Update()
	{
		Board board = this.Board;
		float num = this.timer;
		float deltaTime = Time.deltaTime;
		int num2 = 0;
		this.timer = num;
		if (num2 > (int)num)
		{
			this.timer = 1f;
			TreasureManager instance = TreasureManager.Instance;
			Board board2 = this.Board;
			BoardStatistics boardStatistics = board2.boardStatistics;
			TextMeshProUGUI textMeshProUGUI = this.t;
			ulong num3;
			num3 += num3;
			ulong num4;
			num4 += num4;
			long num5 = (long)(num4 * (ulong)((uint)60));
			board2 -= num5;
			string text;
			textMeshProUGUI.text = text;
		}
	}

	// Token: 0x06002D00 RID: 11520 RVA: 0x000F8070 File Offset: 0x000F6270
	[Token(Token = "0x6002D00")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public UIProgress2()
	{
	}

	// Token: 0x04001B1D RID: 6941
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001B1D")]
	private TextMeshProUGUI t;

	// Token: 0x04001B1E RID: 6942
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001B1E")]
	private Board Board;

	// Token: 0x04001B1F RID: 6943
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001B1F")]
	private float timer;
}
