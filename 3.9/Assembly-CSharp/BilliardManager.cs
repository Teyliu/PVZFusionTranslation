using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000096 RID: 150
[Token(Token = "0x2000096")]
public class BilliardManager : MonoBehaviour
{
	// Token: 0x06000282 RID: 642 RVA: 0x00009F74 File Offset: 0x00008174
	[Token(Token = "0x6000282")]
	[Address(RVA = "0x4028F0", Offset = "0x400EF0", VA = "0x1804028F0")]
	private void Awake()
	{
		BilliardManager.Instance = this;
	}

	// Token: 0x06000283 RID: 643 RVA: 0x00009F88 File Offset: 0x00008188
	[Token(Token = "0x6000283")]
	[Address(RVA = "0x402DB0", Offset = "0x4013B0", VA = "0x180402DB0")]
	private void Start()
	{
		GameObject gameObject = this.billiardRod.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
		if (GameAPP.theBoardLevel == 1)
		{
		}
	}

	// Token: 0x06000284 RID: 644 RVA: 0x00009FC4 File Offset: 0x000081C4
	[Token(Token = "0x6000284")]
	[Address(RVA = "0x402B80", Offset = "0x401180", VA = "0x180402B80")]
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

	// Token: 0x06000285 RID: 645 RVA: 0x0000A050 File Offset: 0x00008250
	[Token(Token = "0x6000285")]
	[Address(RVA = "0x403060", Offset = "0x401660", VA = "0x180403060")]
	private void Update()
	{
		this.RodUpdate();
		this.billiardRod.OnUpdate();
	}

	// Token: 0x06000286 RID: 646 RVA: 0x0000A078 File Offset: 0x00008278
	[Token(Token = "0x6000286")]
	[Address(RVA = "0x402950", Offset = "0x400F50", VA = "0x180402950")]
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

	// Token: 0x06000287 RID: 647 RVA: 0x0000A0C4 File Offset: 0x000082C4
	[Token(Token = "0x6000287")]
	[Address(RVA = "0x4030E0", Offset = "0x4016E0", VA = "0x1804030E0")]
	public BilliardManager()
	{
		List<GameObject> list = new List();
		this.prefabs = list;
		List<BilliardBall> list2 = new List();
		this.billiardBalls = list2;
		base..ctor();
	}

	// Token: 0x040000D0 RID: 208
	[Token(Token = "0x40000D0")]
	public static BilliardManager Instance;

	// Token: 0x040000D1 RID: 209
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D1")]
	public List<GameObject> prefabs;

	// Token: 0x040000D2 RID: 210
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000D2")]
	public BilliardBall whiteBall;

	// Token: 0x040000D3 RID: 211
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000D3")]
	public BilliardRod billiardRod;

	// Token: 0x040000D4 RID: 212
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000D4")]
	public List<BilliardBall> billiardBalls;
}
