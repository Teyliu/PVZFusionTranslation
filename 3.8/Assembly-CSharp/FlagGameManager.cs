using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000AD RID: 173
[Token(Token = "0x20000AD")]
public class FlagGameManager : MonoBehaviour
{
	// Token: 0x0600030C RID: 780 RVA: 0x0000D4B0 File Offset: 0x0000B6B0
	[Token(Token = "0x600030C")]
	[Address(RVA = "0x3C1040", Offset = "0x3BF640", VA = "0x1803C1040")]
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

	// Token: 0x0600030D RID: 781 RVA: 0x0000D50C File Offset: 0x0000B70C
	[Token(Token = "0x600030D")]
	[Address(RVA = "0x3C1150", Offset = "0x3BF750", VA = "0x1803C1150")]
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

	// Token: 0x0600030E RID: 782 RVA: 0x0000D594 File Offset: 0x0000B794
	[Token(Token = "0x600030E")]
	[Address(RVA = "0x3C14D0", Offset = "0x3BFAD0", VA = "0x1803C14D0")]
	public FlagGameManager()
	{
		List<ContestedFlag> list = new List();
		this.flags = list;
		this.timer = 1f;
		base..ctor();
	}

	// Token: 0x04000159 RID: 345
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000159")]
	public Board board;

	// Token: 0x0400015A RID: 346
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400015A")]
	private readonly List<ContestedFlag> flags;

	// Token: 0x0400015B RID: 347
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400015B")]
	private float timer;
}
