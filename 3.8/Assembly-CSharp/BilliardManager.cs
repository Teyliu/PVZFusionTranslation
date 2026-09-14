using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000091 RID: 145
[Token(Token = "0x2000091")]
public class BilliardManager : MonoBehaviour
{
	// Token: 0x06000267 RID: 615 RVA: 0x00009BFC File Offset: 0x00007DFC
	[Token(Token = "0x6000267")]
	[Address(RVA = "0x3B5B60", Offset = "0x3B4160", VA = "0x1803B5B60")]
	private void Awake()
	{
		BilliardManager.Instance = this;
	}

	// Token: 0x06000268 RID: 616 RVA: 0x00009C10 File Offset: 0x00007E10
	[Token(Token = "0x6000268")]
	[Address(RVA = "0x3B6020", Offset = "0x3B4620", VA = "0x1803B6020")]
	private void Start()
	{
		GameObject gameObject = this.billiardRod.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
		if (GameAPP.theBoardLevel == 1)
		{
		}
	}

	// Token: 0x06000269 RID: 617 RVA: 0x00009C4C File Offset: 0x00007E4C
	[Token(Token = "0x6000269")]
	[Address(RVA = "0x3B5DF0", Offset = "0x3B43F0", VA = "0x1803B5DF0")]
	public BilliardBall SetBall(int theColumn, int theRow, BilliardBall.BilliardBallType theBallType)
	{
		GameObject gameObject = this.prefabs[theColumn];
		Transform transform = base.transform;
		GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform);
		float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(theColumn);
		float landY = Mouse.Instance.GetLandY(boxXFromColumn, theRow);
		Transform transform2 = gameObject2.transform;
		BilliardBall component = gameObject2.GetComponent<BilliardBall>();
		component.theBallType = theBallType;
		int size = this.billiardBalls._size;
		component.rb = component;
		return component;
	}

	// Token: 0x0600026A RID: 618 RVA: 0x00009CD8 File Offset: 0x00007ED8
	[Token(Token = "0x600026A")]
	[Address(RVA = "0x3B62D0", Offset = "0x3B48D0", VA = "0x1803B62D0")]
	private void Update()
	{
		this.RodUpdate();
		this.billiardRod.OnUpdate();
	}

	// Token: 0x0600026B RID: 619 RVA: 0x00009D00 File Offset: 0x00007F00
	[Token(Token = "0x600026B")]
	[Address(RVA = "0x3B5BC0", Offset = "0x3B41C0", VA = "0x1803B5BC0")]
	private void RodUpdate()
	{
		bool flag;
		ulong num;
		do
		{
			List<BilliardBall> list = this.billiardBalls;
		}
		while ((flag && 0 != 0) || num != (ulong)0L);
		ulong num2;
		bool flag2;
		if (num2 == (ulong)0L || !flag2)
		{
		}
	}

	// Token: 0x0600026C RID: 620 RVA: 0x00009D4C File Offset: 0x00007F4C
	[Token(Token = "0x600026C")]
	[Address(RVA = "0x3B6350", Offset = "0x3B4950", VA = "0x1803B6350")]
	public BilliardManager()
	{
		List<GameObject> list = new List();
		this.prefabs = list;
		List<BilliardBall> list2 = new List();
		this.billiardBalls = list2;
		base..ctor();
	}

	// Token: 0x040000C3 RID: 195
	[Token(Token = "0x40000C3")]
	public static BilliardManager Instance;

	// Token: 0x040000C4 RID: 196
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000C4")]
	public List<GameObject> prefabs;

	// Token: 0x040000C5 RID: 197
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000C5")]
	public BilliardBall whiteBall;

	// Token: 0x040000C6 RID: 198
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000C6")]
	public BilliardRod billiardRod;

	// Token: 0x040000C7 RID: 199
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000C7")]
	public List<BilliardBall> billiardBalls;
}
