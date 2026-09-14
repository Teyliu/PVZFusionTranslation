using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000105 RID: 261
[Token(Token = "0x2000105")]
[Serializable]
public class BrainManager
{
	// Token: 0x060004F2 RID: 1266 RVA: 0x0001A340 File Offset: 0x00018540
	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x5A52D0", Offset = "0x5A38D0", VA = "0x1805A52D0")]
	public BrainManager(Board board)
	{
		List<Brain> list = new List();
		this.brains = list;
		this.winRoad = (int)((ulong)4294967295L);
		base..ctor();
		this.board = board;
		this.SetBrains();
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x0001A380 File Offset: 0x00018580
	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x5A5000", Offset = "0x5A3600", VA = "0x1805A5000")]
	public void SetBrains()
	{
		int num;
		do
		{
			List<Brain> list = this.brains;
			num = 0;
			bool flag;
			if (flag)
			{
				GameObject gameObject;
				global::UnityEngine.Object.Destroy(gameObject);
			}
		}
		while (num != 0);
		int num2 = 0;
		num2++;
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x0001A3BC File Offset: 0x000185BC
	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x5A4D70", Offset = "0x5A3370", VA = "0x1805A4D70")]
	public void SetBrain(int row)
	{
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(0);
		float landY = Mouse.Instance.GetLandY(boxXFromColumn, row);
		GameObject gameObject = Resources.Load<GameObject>("GridItem/Brain");
		Board board = this.board;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = board.transform;
		GameObject gameObject2;
		Brain component = gameObject2.GetComponent<Brain>();
		Board board2 = this.board;
		component.board = board2;
		component.theRow = row;
		component.brainManager = this;
		component.theHealth = (int)((ulong)300L);
		List<Brain> list = this.brains;
		int size = list._size;
	}

	// Token: 0x060004F5 RID: 1269 RVA: 0x0001A460 File Offset: 0x00018660
	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x5A51E0", Offset = "0x5A37E0", VA = "0x1805A51E0")]
	public void Win()
	{
		GameAPP.UIManager.PopAll();
		global::UnityEngine.Object.Destroy(this.board.gameObject);
		UIMgr.EVEAuto(this.winRoad);
	}

	// Token: 0x04000301 RID: 769
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000301")]
	public List<Brain> brains;

	// Token: 0x04000302 RID: 770
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000302")]
	private readonly Board board;

	// Token: 0x04000303 RID: 771
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000303")]
	public int winRoad;
}
