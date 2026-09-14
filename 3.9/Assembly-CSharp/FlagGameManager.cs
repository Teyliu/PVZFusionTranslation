using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000B2 RID: 178
[Token(Token = "0x20000B2")]
public class FlagGameManager : MonoBehaviour
{
	// Token: 0x06000327 RID: 807 RVA: 0x0000D850 File Offset: 0x0000BA50
	[Token(Token = "0x6000327")]
	[Address(RVA = "0x40DDF0", Offset = "0x40C3F0", VA = "0x18040DDF0")]
	private void Start()
	{
		Board board = this.board;
		int num = 0;
		if (num < board.rowNum)
		{
			int columnNum = this.board.columnNum;
			ContestedFlag contestedFlag = ContestedFlag.SetFlag(this.board, columnNum, num);
			int size = this.flags._size;
			Board board2 = this.board;
			num++;
		}
	}

	// Token: 0x06000328 RID: 808 RVA: 0x0000D8AC File Offset: 0x0000BAAC
	[Token(Token = "0x6000328")]
	[Address(RVA = "0x40DF00", Offset = "0x40C500", VA = "0x18040DF00")]
	private void Update()
	{
		ulong num4;
		do
		{
			List<ContestedFlag> list = this.flags;
			bool flag;
			if (flag)
			{
			}
			ulong num;
			if (num != (ulong)0L)
			{
				goto IL_0067;
			}
			float deltaTime = Time.deltaTime;
			bool flag2;
			if (flag2)
			{
				Board board = this.board;
				int num2 = 0;
				board.GetPoint(-1f, num2 != 0);
				int num3 = 0;
				board.GetPoint(1f, num3 != 0);
			}
		}
		while (num4 != (ulong)0L);
		return;
		IL_0067:
		throw new NullReferenceException();
	}

	// Token: 0x06000329 RID: 809 RVA: 0x0000D934 File Offset: 0x0000BB34
	[Token(Token = "0x6000329")]
	[Address(RVA = "0x40E280", Offset = "0x40C880", VA = "0x18040E280")]
	public FlagGameManager()
	{
		List<ContestedFlag> list = new List();
		this.flags = list;
		this.timer = 1f;
		base..ctor();
	}

	// Token: 0x04000166 RID: 358
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000166")]
	public Board board;

	// Token: 0x04000167 RID: 359
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000167")]
	private readonly List<ContestedFlag> flags;

	// Token: 0x04000168 RID: 360
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000168")]
	private float timer;
}
