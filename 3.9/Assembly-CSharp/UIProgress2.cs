using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020008DC RID: 2268
[Token(Token = "0x20008DC")]
public class UIProgress2 : MonoBehaviour
{
	// Token: 0x06002E30 RID: 11824 RVA: 0x000FCAF4 File Offset: 0x000FACF4
	[Token(Token = "0x6002E30")]
	[Address(RVA = "0x70F230", Offset = "0x70D830", VA = "0x18070F230")]
	private void Start()
	{
		Board instance = Board.Instance;
		this.Board = instance;
		TextMeshProUGUI component = base.GetComponent<TextMeshProUGUI>();
		this.t = component;
	}

	// Token: 0x06002E31 RID: 11825 RVA: 0x000FCB1C File Offset: 0x000FAD1C
	[Token(Token = "0x6002E31")]
	[Address(RVA = "0x70F2B0", Offset = "0x70D8B0", VA = "0x18070F2B0")]
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

	// Token: 0x06002E32 RID: 11826 RVA: 0x000FCBE0 File Offset: 0x000FADE0
	[Token(Token = "0x6002E32")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public UIProgress2()
	{
	}

	// Token: 0x04001C0B RID: 7179
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001C0B")]
	private TextMeshProUGUI t;

	// Token: 0x04001C0C RID: 7180
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001C0C")]
	private Board Board;

	// Token: 0x04001C0D RID: 7181
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001C0D")]
	private float timer;
}
