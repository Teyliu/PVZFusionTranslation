using System;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000098 RID: 152
[Token(Token = "0x2000098")]
public class BallLauncher : MonoBehaviour
{
	// Token: 0x0600028F RID: 655 RVA: 0x0000A4A8 File Offset: 0x000086A8
	[Token(Token = "0x600028F")]
	[Address(RVA = "0x401880", Offset = "0x3FFE80", VA = "0x180401880")]
	private void Start()
	{
		this.CreateNewBall((PlantType)((uint)3));
		if (Board.Instance.sceneType == SceneType.MidMap)
		{
			float num = this.launchSpeed * 1.5f;
			this.launchSpeed = num;
		}
	}

	// Token: 0x06000290 RID: 656 RVA: 0x0000A4E8 File Offset: 0x000086E8
	[Token(Token = "0x6000290")]
	[Address(RVA = "0x401910", Offset = "0x3FFF10", VA = "0x180401910")]
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

	// Token: 0x06000291 RID: 657 RVA: 0x0000A544 File Offset: 0x00008744
	[Token(Token = "0x6000291")]
	[Address(RVA = "0x401900", Offset = "0x3FFF00", VA = "0x180401900")]
	private void Supply()
	{
		this.CreateNewBall((PlantType)((uint)3));
	}

	// Token: 0x06000292 RID: 658 RVA: 0x0000A55C File Offset: 0x0000875C
	[Token(Token = "0x6000292")]
	[Address(RVA = "0x401270", Offset = "0x3FF870", VA = "0x180401270")]
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

	// Token: 0x06000293 RID: 659 RVA: 0x0000A600 File Offset: 0x00008800
	[Token(Token = "0x6000293")]
	[Address(RVA = "0x4015C0", Offset = "0x3FFBC0", VA = "0x1804015C0")]
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

	// Token: 0x06000294 RID: 660 RVA: 0x0000A654 File Offset: 0x00008854
	[Token(Token = "0x6000294")]
	[Address(RVA = "0x401670", Offset = "0x3FFC70", VA = "0x180401670")]
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

	// Token: 0x06000295 RID: 661 RVA: 0x0000A6CC File Offset: 0x000088CC
	[Token(Token = "0x6000295")]
	[Address(RVA = "0x401AC0", Offset = "0x4000C0", VA = "0x180401AC0")]
	public BallLauncher()
	{
		List<BrickBall> list = new List();
		this.balls = list;
		this.launchSpeed = 10f;
		base..ctor();
	}

	// Token: 0x040000DD RID: 221
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000DD")]
	public GameObject ballPrefab;

	// Token: 0x040000DE RID: 222
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000DE")]
	public Transform topPoint;

	// Token: 0x040000DF RID: 223
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000DF")]
	public Transform bottomPoint;

	// Token: 0x040000E0 RID: 224
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000E0")]
	public readonly List<BrickBall> balls;

	// Token: 0x040000E1 RID: 225
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000E1")]
	public float launchSpeed;

	// Token: 0x040000E2 RID: 226
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40000E2")]
	private bool waiting;
}
