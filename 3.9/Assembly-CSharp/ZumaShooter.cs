using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000103 RID: 259
[Token(Token = "0x2000103")]
public class ZumaShooter : MonoBehaviour
{
	// Token: 0x060004EE RID: 1262 RVA: 0x00019D04 File Offset: 0x00017F04
	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x5EE790", Offset = "0x5ECD90", VA = "0x1805EE790")]
	private void Awake()
	{
		ZumaShooter.Instance = this;
		Transform transform = base.transform.Find("Shoot");
		this.cannonPos = transform;
		Transform transform2 = base.transform.Find("Wait");
		this.cannonPos2 = transform2;
		throw new NullReferenceException();
	}

	// Token: 0x060004EF RID: 1263 RVA: 0x00019D4C File Offset: 0x00017F4C
	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x5EED10", Offset = "0x5ED310", VA = "0x1805EED10")]
	private void Start()
	{
		Zuma instance = Zuma.Instance;
		Transform transform = this.cannonPos;
		Vector3 vector;
		float z = vector.z;
		Transform transform2 = base.transform;
		if (global::UnityEngine.Random.Range(0, 10) != 0)
		{
			int num = global::UnityEngine.Random.Range(0, 5);
		}
		ZumaBall zumaBall;
		this.currentBall = zumaBall;
		Transform transform3 = this.currentBall.transform;
		Transform transform4 = base.transform;
		transform3.parentInternal = transform4;
		this.currentBall.theBallStatus = (ZumaBall.BallStatus)((ulong)1L);
		this.currentBall.GetComponent<SortingGroup>().sortingOrder = 4;
		SortingGroup component = this.currentBall.GetComponent<SortingGroup>();
		int num2 = 0;
		component.sortingLayerID = num2;
		Transform transform5 = this.cannonPos2;
		Zuma instance2 = Zuma.Instance;
		Vector3 vector2;
		float z2 = vector2.z;
		Transform transform6 = base.transform;
		Quaternion quaternion;
		if (quaternion != 0)
		{
		}
		ZumaBall zumaBall2;
		this.nextball = zumaBall2;
		Transform transform7 = this.nextball.transform;
		Transform transform8 = base.transform;
		transform7.parentInternal = transform8;
		this.nextball.theBallStatus = (ZumaBall.BallStatus)((ulong)1L);
		this.nextball.GetComponent<SortingGroup>().sortingOrder = 6;
		SortingGroup component2 = this.nextball.GetComponent<SortingGroup>();
		int num3 = 0;
		component2.sortingLayerID = num3;
	}

	// Token: 0x060004F0 RID: 1264 RVA: 0x00019E78 File Offset: 0x00018078
	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x5EF080", Offset = "0x5ED680", VA = "0x1805EF080")]
	private void Update()
	{
		if (!Zuma.Instance.gameOver)
		{
			Camera main = Camera.main;
			float z = Input.mousePosition.z;
			Vector3 vector;
			float z2 = vector.z;
			Transform transform = base.transform;
			Vector3 vector2;
			float z3 = vector2.z;
			Transform transform2 = base.transform;
			float num2;
			float num = num2 * 0.017453292f;
			if (Input.GetMouseButtonDown(0) && this.freeMouse)
			{
				Vector2 vector3;
				this.Shoot(vector3, 10f);
			}
		}
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x00019EF8 File Offset: 0x000180F8
	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x5EE870", Offset = "0x5ECE70", VA = "0x1805EE870")]
	private void Shoot(Vector2 direction, float speed)
	{
		this.currentBall.rb.velocity = direction;
		Transform transform = this.currentBall.transform;
		Transform transform2 = Zuma.Instance.transform;
		transform.parentInternal = transform2;
		this.currentBall.theBallStatus = (ZumaBall.BallStatus)((ulong)0L);
		this.currentBall.GetComponent<SortingGroup>().sortingLayerName = "plant0";
		ZumaBall zumaBall = this.currentBall;
		List<ZumaBall> list = this.shootBallList;
		int num = 0;
		ZumaBall zumaBall2 = this.shootBallList[num];
		int num2 = 0;
		bool flag = zumaBall2 == num2;
		List<ZumaBall> list2 = this.shootBallList;
		if (!flag)
		{
			num++;
		}
		list2[num] = zumaBall;
		ZumaBall zumaBall3 = this.nextball;
		this.currentBall = zumaBall3;
		Transform transform3 = this.currentBall.transform;
		Transform transform4 = this.cannonPos;
		Vector3 vector;
		float z = vector.z;
		Transform transform5 = this.cannonPos2;
		Zuma instance = Zuma.Instance;
		Transform transform6 = base.transform;
		Quaternion quaternion;
		if (quaternion != 0)
		{
		}
		ZumaBall zumaBall4;
		this.nextball = zumaBall4;
		Transform transform7 = this.nextball.transform;
		Transform transform8 = base.transform;
		transform7.parentInternal = transform8;
		this.nextball.theBallStatus = (ZumaBall.BallStatus)((ulong)1L);
		this.currentBall.GetComponent<SortingGroup>().sortingOrder = 6;
		SortingGroup component = this.nextball.GetComponent<SortingGroup>();
		int num3 = 0;
		component.sortingLayerID = num3;
		GameAPP.PlaySound(53, 0.5f, 1f);
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x0001A06C File Offset: 0x0001826C
	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x5EE670", Offset = "0x5ECC70", VA = "0x1805EE670")]
	private void AddToList(ZumaBall ball)
	{
		List<ZumaBall> list = this.shootBallList;
		int num = 0;
		ZumaBall zumaBall = this.shootBallList[num];
		int num2 = 0;
		bool flag = zumaBall == num2;
		List<ZumaBall> list2 = this.shootBallList;
		if (!flag)
		{
			num++;
		}
		list2[num] = ball;
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x0001A0BC File Offset: 0x000182BC
	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x5EF2B0", Offset = "0x5ED8B0", VA = "0x1805EF2B0")]
	public ZumaShooter()
	{
		List<ZumaBall> list = new List();
		this.shootBallList = list;
		this.freeMouse = true;
		base..ctor();
	}

	// Token: 0x040002FD RID: 765
	[Token(Token = "0x40002FD")]
	public static ZumaShooter Instance;

	// Token: 0x040002FE RID: 766
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002FE")]
	public List<ZumaBall> shootBallList;

	// Token: 0x040002FF RID: 767
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002FF")]
	private ZumaBall currentBall;

	// Token: 0x04000300 RID: 768
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000300")]
	private ZumaBall nextball;

	// Token: 0x04000301 RID: 769
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000301")]
	public Transform cannonPos;

	// Token: 0x04000302 RID: 770
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000302")]
	private Transform cannonPos2;

	// Token: 0x04000303 RID: 771
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000303")]
	public bool freeMouse;
}
