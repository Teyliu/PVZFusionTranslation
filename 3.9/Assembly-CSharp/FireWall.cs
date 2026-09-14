using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002C8 RID: 712
[Token(Token = "0x20002C8")]
public class FireWall : MonoBehaviour
{
	// Token: 0x06000C8C RID: 3212 RVA: 0x0004797C File Offset: 0x00045B7C
	[Token(Token = "0x6000C8C")]
	[Address(RVA = "0x42F920", Offset = "0x42DF20", VA = "0x18042F920")]
	private void Awake()
	{
		bool flag;
		if (flag)
		{
			float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		}
		SpriteRenderer componentInChildren = base.transform.GetComponentInChildren<SpriteRenderer>();
		this.r = componentInChildren;
	}

	// Token: 0x06000C8D RID: 3213 RVA: 0x000479B8 File Offset: 0x00045BB8
	[Token(Token = "0x6000C8D")]
	[Address(RVA = "0x42FE20", Offset = "0x42E420", VA = "0x18042FE20")]
	public void Initialize(FirePoint start, FirePoint end, float tValue)
	{
		this.startPoint = start;
		this.endPoint = end;
		this.t = tValue;
		Mouse instance = Mouse.Instance;
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		SpriteRenderer spriteRenderer = this.r;
		int num;
		this.row = num;
		string text = string.Format("particle{0}", num);
		spriteRenderer.sortingLayerName = text;
	}

	// Token: 0x06000C8E RID: 3214 RVA: 0x00047A1C File Offset: 0x00045C1C
	[Token(Token = "0x6000C8E")]
	[Address(RVA = "0x4300A0", Offset = "0x42E6A0", VA = "0x1804300A0")]
	public void UpdateSorting()
	{
		Mouse instance = Mouse.Instance;
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		int num;
		this.row = num;
		SpriteRenderer spriteRenderer = this.r;
		string text = string.Format("particle{0}", num);
		spriteRenderer.sortingLayerName = text;
	}

	// Token: 0x06000C8F RID: 3215 RVA: 0x00047A6C File Offset: 0x00045C6C
	[Token(Token = "0x6000C8F")]
	[Address(RVA = "0x42FA00", Offset = "0x42E000", VA = "0x18042FA00")]
	private void FixedUpdate()
	{
		ulong num6;
		do
		{
			int num = 0;
			Plant plant = this.plant;
			int num2 = 0;
			if (plant == num2)
			{
				return;
			}
			float num3 = this.timer;
			Plant plant2 = this.plant;
			float fixedDeltaTime = Time.fixedDeltaTime;
			this.timer = num3;
			this.timer = 1f;
			HashSet<Zombie> hashSet = this.zombies;
			Predicate<Zombie> <>9__11_ = FireWall.<>c.<>9__11_0;
			if (<>9__11_ == 0)
			{
				Predicate<Zombie> predicate;
				FireWall.<>c.<>9__11_0 = predicate;
			}
			int num4 = hashSet.RemoveWhere(<>9__11_);
			List<Zombie> list = Enumerable.ToList<Zombie>(this.zombies);
			bool flag;
			if (flag)
			{
				int num5 = 0;
				if (!(num != num5))
				{
					continue;
				}
				Plant plant3 = this.plant;
			}
		}
		while (num6 != (ulong)0L);
		ulong num7;
		if (num7 != (ulong)0L)
		{
			ParticleManager instance = ParticleManager.Instance;
		}
	}

	// Token: 0x06000C90 RID: 3216 RVA: 0x00047B48 File Offset: 0x00045D48
	[Token(Token = "0x6000C90")]
	[Address(RVA = "0x42FF60", Offset = "0x42E560", VA = "0x18042FF60")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		ulong num;
		if (flag && num != (ulong)0L)
		{
			HashSet<Zombie> hashSet = this.zombies;
		}
	}

	// Token: 0x06000C91 RID: 3217 RVA: 0x00047B70 File Offset: 0x00045D70
	[Token(Token = "0x6000C91")]
	[Address(RVA = "0x430010", Offset = "0x42E610", VA = "0x180430010")]
	private void OnTriggerExit2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			HashSet<Zombie> hashSet = this.zombies;
		}
	}

	// Token: 0x06000C92 RID: 3218 RVA: 0x00047B90 File Offset: 0x00045D90
	[Token(Token = "0x6000C92")]
	[Address(RVA = "0x4301B0", Offset = "0x42E7B0", VA = "0x1804301B0")]
	public FireWall()
	{
		HashSet<Zombie> hashSet = new HashSet();
		this.zombies = hashSet;
		base..ctor();
	}

	// Token: 0x040008A9 RID: 2217
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008A9")]
	public Plant plant;

	// Token: 0x040008AA RID: 2218
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008AA")]
	[Header("贝塞尔曲线参数")]
	public float t;

	// Token: 0x040008AB RID: 2219
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008AB")]
	public FirePoint startPoint;

	// Token: 0x040008AC RID: 2220
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008AC")]
	public FirePoint endPoint;

	// Token: 0x040008AD RID: 2221
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008AD")]
	private float timer;

	// Token: 0x040008AE RID: 2222
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40008AE")]
	private readonly HashSet<Zombie> zombies;

	// Token: 0x040008AF RID: 2223
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008AF")]
	private SpriteRenderer r;

	// Token: 0x040008B0 RID: 2224
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40008B0")]
	private int row;
}
