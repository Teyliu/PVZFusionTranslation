using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200010A RID: 266
[Token(Token = "0x200010A")]
[Serializable]
public class BrainManager
{
	// Token: 0x0600050D RID: 1293 RVA: 0x0001A744 File Offset: 0x00018944
	[Token(Token = "0x600050D")]
	[Address(RVA = "0x5DCCC0", Offset = "0x5DB2C0", VA = "0x1805DCCC0")]
	public BrainManager(Board board)
	{
		List<Brain> list = new List();
		this.brains = list;
		this.winRoad = (int)((ulong)4294967295L);
		base..ctor();
		this.board = board;
		this.SetBrains();
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x0001A784 File Offset: 0x00018984
	[Token(Token = "0x600050E")]
	[Address(RVA = "0x5DC9F0", Offset = "0x5DAFF0", VA = "0x1805DC9F0")]
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

	// Token: 0x0600050F RID: 1295 RVA: 0x0001A7C0 File Offset: 0x000189C0
	[Token(Token = "0x600050F")]
	[Address(RVA = "0x5DC760", Offset = "0x5DAD60", VA = "0x1805DC760")]
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

	// Token: 0x06000510 RID: 1296 RVA: 0x0001A864 File Offset: 0x00018A64
	[Token(Token = "0x6000510")]
	[Address(RVA = "0x5DCBD0", Offset = "0x5DB1D0", VA = "0x1805DCBD0")]
	public void Win()
	{
		GameAPP.UIManager.PopAll();
		global::UnityEngine.Object.Destroy(this.board.gameObject);
		UIMgr.EVEAuto(this.winRoad);
	}

	// Token: 0x0400030F RID: 783
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400030F")]
	public List<Brain> brains;

	// Token: 0x04000310 RID: 784
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000310")]
	private readonly Board board;

	// Token: 0x04000311 RID: 785
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000311")]
	public int winRoad;
}
