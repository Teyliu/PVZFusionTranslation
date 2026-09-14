using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000B3 RID: 179
[Token(Token = "0x20000B3")]
public class FruitBlade : MonoBehaviour
{
	// Token: 0x0600032A RID: 810 RVA: 0x0000D960 File Offset: 0x0000BB60
	[Token(Token = "0x600032A")]
	[Address(RVA = "0x40E300", Offset = "0x40C900", VA = "0x18040E300")]
	private void Awake()
	{
		Camera main = Camera.main;
		this.mainCamera = main;
		Collider2D component = base.GetComponent<Collider2D>();
		this.bladeCollider = component;
		TrailRenderer componentInChildren = base.GetComponentInChildren<TrailRenderer>();
		this.trail = componentInChildren;
	}

	// Token: 0x0600032B RID: 811 RVA: 0x0000D998 File Offset: 0x0000BB98
	[Token(Token = "0x600032B")]
	[Address(RVA = "0x40E600", Offset = "0x40CC00", VA = "0x18040E600")]
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

	// Token: 0x0600032C RID: 812 RVA: 0x0000DB6C File Offset: 0x0000BD6C
	[Token(Token = "0x600032C")]
	[Address(RVA = "0x40E4E0", Offset = "0x40CAE0", VA = "0x18040E4E0")]
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

	// Token: 0x0600032D RID: 813 RVA: 0x0000DBFC File Offset: 0x0000BDFC
	[Token(Token = "0x600032D")]
	[Address(RVA = "0x40E390", Offset = "0x40C990", VA = "0x18040E390")]
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

	// Token: 0x0600032E RID: 814 RVA: 0x0000DC4C File Offset: 0x0000BE4C
	[Token(Token = "0x600032E")]
	[Address(RVA = "0x40E970", Offset = "0x40CF70", VA = "0x18040E970")]
	public FruitBlade()
	{
	}

	// Token: 0x04000169 RID: 361
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000169")]
	private Camera mainCamera;

	// Token: 0x0400016A RID: 362
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400016A")]
	private Collider2D bladeCollider;

	// Token: 0x0400016B RID: 363
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400016B")]
	private TrailRenderer trail;

	// Token: 0x0400016C RID: 364
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400016C")]
	private Vector2 previousPosition;

	// Token: 0x0400016D RID: 365
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400016D")]
	private FruitNinjaManager manager;

	// Token: 0x0400016E RID: 366
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400016E")]
	public float minSliceVelocity = 0.01f;

	// Token: 0x0400016F RID: 367
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400016F")]
	public bool auto;

	// Token: 0x04000170 RID: 368
	[FieldOffset(Offset = "0x4D")]
	[Token(Token = "0x4000170")]
	private bool clicking;

	// Token: 0x04000171 RID: 369
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000171")]
	private readonly float speed = 20f;

	// Token: 0x04000172 RID: 370
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000172")]
	private Vector2 direction;

	// Token: 0x04000173 RID: 371
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000173")]
	private float minX;

	// Token: 0x04000174 RID: 372
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000174")]
	private float maxX;

	// Token: 0x04000175 RID: 373
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000175")]
	private float minY;

	// Token: 0x04000176 RID: 374
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000176")]
	private float maxY;
}
