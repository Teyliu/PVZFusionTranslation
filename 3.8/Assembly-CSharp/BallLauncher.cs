using System;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000093 RID: 147
[Token(Token = "0x2000093")]
public class BallLauncher : MonoBehaviour
{
	// Token: 0x06000274 RID: 628 RVA: 0x0000A148 File Offset: 0x00008348
	[Token(Token = "0x6000274")]
	[Address(RVA = "0x3B4AF0", Offset = "0x3B30F0", VA = "0x1803B4AF0")]
	private void Start()
	{
		this.CreateNewBall((PlantType)((uint)3));
		if (Board.Instance.sceneType == SceneType.MidMap)
		{
			float num = this.launchSpeed * 1.5f;
			this.launchSpeed = num;
		}
	}

	// Token: 0x06000275 RID: 629 RVA: 0x0000A188 File Offset: 0x00008388
	[Token(Token = "0x6000275")]
	[Address(RVA = "0x3B4B80", Offset = "0x3B3180", VA = "0x1803B4B80")]
	private void Update()
	{
		ulong num2;
		do
		{
			int num = 0;
			List<BrickBall> list = this.balls;
			if (!this.waiting)
			{
				this.waiting = true;
				base.Invoke("Supply", 3f);
			}
			List<BrickBall> list2 = this.balls;
			bool flag;
			if (flag)
			{
				this.LaunchBall(num);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06000276 RID: 630 RVA: 0x0000A1E4 File Offset: 0x000083E4
	[Token(Token = "0x6000276")]
	[Address(RVA = "0x3B4B70", Offset = "0x3B3170", VA = "0x1803B4B70")]
	private void Supply()
	{
		this.CreateNewBall((PlantType)((uint)3));
	}

	// Token: 0x06000277 RID: 631 RVA: 0x0000A1FC File Offset: 0x000083FC
	[Token(Token = "0x6000277")]
	[Address(RVA = "0x3B44E0", Offset = "0x3B2AE0", VA = "0x1803B44E0")]
	[ProButton]
	public void CreateNewBall(PlantType plantType = PlantType.WallNut)
	{
		if (this.waiting)
		{
			this.waiting = false;
		}
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Dictionary<PlantType, GameObject> plantPreviews = GameAPP.resourcesManager.plantPreviews;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform2 = Board.Instance.transform;
		GameObject gameObject;
		BrickBall brickBall = gameObject.AddComponent<BrickBall>();
		Transform transform3 = brickBall.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		Transform transform4 = base.transform;
		brickBall.paddle = transform4;
		brickBall.thePlantType = plantType;
		List<BrickBall> list = this.balls;
		int size = list._size;
	}

	// Token: 0x06000278 RID: 632 RVA: 0x0000A2A0 File Offset: 0x000084A0
	[Token(Token = "0x6000278")]
	[Address(RVA = "0x3B4830", Offset = "0x3B2E30", VA = "0x1803B4830")]
	private void LaunchBall(BrickBall ball)
	{
		Rigidbody2D rb = ball.rb;
		int num = 0;
		rb.isKinematic = num != 0;
		Rigidbody2D rb2 = ball.rb;
		int num2 = 0;
		float num3 = this.launchSpeed;
		rb2.velocity = num2;
		ball.isLaunched = true;
		float num4 = this.launchSpeed;
		ball.speed = num4;
	}

	// Token: 0x06000279 RID: 633 RVA: 0x0000A2F4 File Offset: 0x000084F4
	[Token(Token = "0x6000279")]
	[Address(RVA = "0x3B48E0", Offset = "0x3B2EE0", VA = "0x1803B48E0")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
		GameObject gameObject = collision.gameObject;
		bool flag;
		if (flag)
		{
			ContactPoint2D[] contacts = collision.contacts;
			ContactPoint2D contactPoint2D = contacts[0];
			ContactPoint2D contactPoint2D2 = contacts[2];
			ContactPoint2D contactPoint2D3 = contacts[4];
			Transform transform = this.bottomPoint;
			if (this.topPoint == 0)
			{
				int num = 0;
				int num2 = 0;
				if (num <= num2)
				{
				}
			}
			float num3 = this.launchSpeed;
		}
	}

	// Token: 0x0600027A RID: 634 RVA: 0x0000A36C File Offset: 0x0000856C
	[Token(Token = "0x600027A")]
	[Address(RVA = "0x3B4D30", Offset = "0x3B3330", VA = "0x1803B4D30")]
	public BallLauncher()
	{
		List<BrickBall> list = new List();
		this.balls = list;
		this.launchSpeed = 10f;
		base..ctor();
	}

	// Token: 0x040000D0 RID: 208
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D0")]
	public GameObject ballPrefab;

	// Token: 0x040000D1 RID: 209
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000D1")]
	public Transform topPoint;

	// Token: 0x040000D2 RID: 210
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000D2")]
	public Transform bottomPoint;

	// Token: 0x040000D3 RID: 211
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000D3")]
	public readonly List<BrickBall> balls;

	// Token: 0x040000D4 RID: 212
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000D4")]
	public float launchSpeed;

	// Token: 0x040000D5 RID: 213
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40000D5")]
	private bool waiting;
}
