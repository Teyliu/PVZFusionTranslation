using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000AE RID: 174
[Token(Token = "0x20000AE")]
public class FruitBlade : MonoBehaviour
{
	// Token: 0x0600030F RID: 783 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
	[Token(Token = "0x600030F")]
	[Address(RVA = "0x3C1550", Offset = "0x3BFB50", VA = "0x1803C1550")]
	private void Awake()
	{
		Camera main = Camera.main;
		this.mainCamera = main;
		Collider2D component = base.GetComponent<Collider2D>();
		this.bladeCollider = component;
		TrailRenderer componentInChildren = base.GetComponentInChildren<TrailRenderer>();
		this.trail = componentInChildren;
	}

	// Token: 0x06000310 RID: 784 RVA: 0x0000D5F8 File Offset: 0x0000B7F8
	[Token(Token = "0x6000310")]
	[Address(RVA = "0x3C1850", Offset = "0x3BFE50", VA = "0x1803C1850")]
	private void Update()
	{
		if (!this.auto)
		{
			Camera camera = this.mainCamera;
			Vector3 mousePosition = Input.mousePosition;
			int num = 0;
			base.transform.position = num;
			if (Input.GetMouseButtonDown(1))
			{
				bool flag = !this.clicking;
				this.clicking = flag;
			}
			bool mouseButton = Input.GetMouseButton(0);
			if (!mouseButton && this.clicking == mouseButton)
			{
				this.manager.combo = false;
				this.manager.comboCount = (int)((ulong)0L);
				Collider2D collider2D = this.bladeCollider;
				int num2 = 0;
				collider2D.enabled = num2 != 0;
				TrailRenderer trailRenderer = this.trail;
			}
			this.manager.combo = true;
			int num3 = 0;
			float deltaTime = Time.deltaTime;
			this.bladeCollider.enabled = num3 != 0;
			Collider2D collider2D2 = this.bladeCollider;
			TrailRenderer trailRenderer2 = this.trail;
			bool enabled = collider2D2.enabled;
			trailRenderer2.emitting = enabled;
			return;
		}
		float num4 = this.speed * this.direction.y;
		float deltaTime2 = Time.deltaTime;
		int num5 = 0;
		Transform transform = base.transform;
		int num6 = 0;
		transform.Translate(num5, (Space)num6);
		Transform transform2 = base.transform;
		if (this.minX < num4)
		{
		}
		Vector2 vector = this.direction;
		this.direction = vector;
		if (this.minY < deltaTime2 && deltaTime2 < this.maxY)
		{
			while ((ulong)1L == 0UL)
			{
			}
		}
		float y = this.direction.y;
		this.direction.y = y;
		float num7 = this.minX;
		if (num7 <= num4)
		{
			float num8 = this.maxX;
			if (num4 > num8)
			{
			}
		}
		float num9 = this.minY;
		if (num9 <= deltaTime2)
		{
			float num10 = this.maxY;
			if (deltaTime2 > num10)
			{
			}
		}
		Transform transform3 = base.transform;
		Transform transform4 = base.transform;
		throw new NullReferenceException();
	}

	// Token: 0x06000311 RID: 785 RVA: 0x0000D7CC File Offset: 0x0000B9CC
	[Token(Token = "0x6000311")]
	[Address(RVA = "0x3C1730", Offset = "0x3BFD30", VA = "0x1803C1730")]
	private void Start()
	{
		FruitNinjaManager instance = FruitNinjaManager.Instance;
		this.manager = instance;
		this.minX = -6f;
		this.maxX = 8f;
		this.minY = -4f;
		this.maxY = 4f;
		float num = global::UnityEngine.Random.Range(-6f, 8f);
		float num2 = this.maxY;
		float num3 = global::UnityEngine.Random.Range(this.minY, num2);
		Transform transform = base.transform;
		Vector2 vector;
		this.direction = vector;
		this.direction.y = (float)0;
	}

	// Token: 0x06000312 RID: 786 RVA: 0x0000D85C File Offset: 0x0000BA5C
	[Token(Token = "0x6000312")]
	[Address(RVA = "0x3C15E0", Offset = "0x3BFBE0", VA = "0x1803C15E0")]
	private void CheckBoundaries()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		float num = this.minX;
		Vector2 vector2 = this.direction;
		this.direction = vector2;
		float num2 = this.minY;
		if ((ulong)1L == 0UL)
		{
			return;
		}
		Vector3 vector3;
		float z2 = vector3.z;
		throw new NullReferenceException();
	}

	// Token: 0x06000313 RID: 787 RVA: 0x0000D8AC File Offset: 0x0000BAAC
	[Token(Token = "0x6000313")]
	[Address(RVA = "0x3C1BC0", Offset = "0x3C01C0", VA = "0x1803C1BC0")]
	public FruitBlade()
	{
	}

	// Token: 0x0400015C RID: 348
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400015C")]
	private Camera mainCamera;

	// Token: 0x0400015D RID: 349
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400015D")]
	private Collider2D bladeCollider;

	// Token: 0x0400015E RID: 350
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400015E")]
	private TrailRenderer trail;

	// Token: 0x0400015F RID: 351
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400015F")]
	private Vector2 previousPosition;

	// Token: 0x04000160 RID: 352
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000160")]
	private FruitNinjaManager manager;

	// Token: 0x04000161 RID: 353
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000161")]
	public float minSliceVelocity = 0.01f;

	// Token: 0x04000162 RID: 354
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000162")]
	public bool auto;

	// Token: 0x04000163 RID: 355
	[FieldOffset(Offset = "0x4D")]
	[Token(Token = "0x4000163")]
	private bool clicking;

	// Token: 0x04000164 RID: 356
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000164")]
	private readonly float speed = 20f;

	// Token: 0x04000165 RID: 357
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000165")]
	private Vector2 direction;

	// Token: 0x04000166 RID: 358
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000166")]
	private float minX;

	// Token: 0x04000167 RID: 359
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000167")]
	private float maxX;

	// Token: 0x04000168 RID: 360
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000168")]
	private float minY;

	// Token: 0x04000169 RID: 361
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000169")]
	private float maxY;
}
