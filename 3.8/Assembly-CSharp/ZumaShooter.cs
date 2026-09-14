using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020000FE RID: 254
[Token(Token = "0x20000FE")]
public class ZumaShooter : MonoBehaviour
{
	// Token: 0x060004D3 RID: 1235 RVA: 0x00019900 File Offset: 0x00017B00
	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x5B8CC0", Offset = "0x5B72C0", VA = "0x1805B8CC0")]
	private void Awake()
	{
		ZumaShooter.Instance = this;
		Transform transform = base.transform.Find("Shoot");
		this.cannonPos = transform;
		Transform transform2 = base.transform.Find("Wait");
		this.cannonPos2 = transform2;
		throw new NullReferenceException();
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x00019948 File Offset: 0x00017B48
	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x5B9240", Offset = "0x5B7840", VA = "0x1805B9240")]
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

	// Token: 0x060004D5 RID: 1237 RVA: 0x00019A74 File Offset: 0x00017C74
	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x5B95B0", Offset = "0x5B7BB0", VA = "0x1805B95B0")]
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

	// Token: 0x060004D6 RID: 1238 RVA: 0x00019AF4 File Offset: 0x00017CF4
	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x5B8DA0", Offset = "0x5B73A0", VA = "0x1805B8DA0")]
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

	// Token: 0x060004D7 RID: 1239 RVA: 0x00019C68 File Offset: 0x00017E68
	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x5B8BA0", Offset = "0x5B71A0", VA = "0x1805B8BA0")]
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

	// Token: 0x060004D8 RID: 1240 RVA: 0x00019CB8 File Offset: 0x00017EB8
	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x5B97E0", Offset = "0x5B7DE0", VA = "0x1805B97E0")]
	public ZumaShooter()
	{
		List<ZumaBall> list = new List();
		this.shootBallList = list;
		this.freeMouse = true;
		base..ctor();
	}

	// Token: 0x040002EF RID: 751
	[Token(Token = "0x40002EF")]
	public static ZumaShooter Instance;

	// Token: 0x040002F0 RID: 752
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002F0")]
	public List<ZumaBall> shootBallList;

	// Token: 0x040002F1 RID: 753
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002F1")]
	private ZumaBall currentBall;

	// Token: 0x040002F2 RID: 754
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002F2")]
	private ZumaBall nextball;

	// Token: 0x040002F3 RID: 755
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002F3")]
	public Transform cannonPos;

	// Token: 0x040002F4 RID: 756
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002F4")]
	private Transform cannonPos2;

	// Token: 0x040002F5 RID: 757
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002F5")]
	public bool freeMouse;
}
