using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000089 RID: 137
[Token(Token = "0x2000089")]
public class AirProjectile : MonoBehaviour, IDamageMaker
{
	// Token: 0x17000073 RID: 115
	// (get) Token: 0x0600022A RID: 554 RVA: 0x000074B8 File Offset: 0x000056B8
	// (set) Token: 0x0600022B RID: 555 RVA: 0x000074C8 File Offset: 0x000056C8
	[Token(Token = "0x17000073")]
	public Team Team
	{
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "4")]
		get
		{
			return Team.AI;
		}
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x3E8E60", Offset = "0x3E7460", VA = "0x1803E8E60", Slot = "5")]
		set
		{
			NotImplementedException ex = new NotImplementedException();
		}
	}

	// Token: 0x0600022C RID: 556 RVA: 0x000074DC File Offset: 0x000056DC
	[Token(Token = "0x600022C")]
	[Address(RVA = "0x3E88B0", Offset = "0x3E6EB0", VA = "0x1803E88B0", Slot = "7")]
	protected virtual void Awake()
	{
		Collider2D component = base.GetComponent<Collider2D>();
		this.col = component;
		Rigidbody2D component2 = base.GetComponent<Rigidbody2D>();
		this.rb = component2;
		this.rb.interpolation = (RigidbodyInterpolation2D)((uint)1);
	}

	// Token: 0x0600022D RID: 557 RVA: 0x00007518 File Offset: 0x00005718
	[Token(Token = "0x600022D")]
	[Address(RVA = "0x3E8D40", Offset = "0x3E7340", VA = "0x1803E8D40")]
	public int TakeDamage(int damage)
	{
		int num = this.theHealth;
		num -= damage;
		this.flashTimer = 0.2f;
		this.theHealth = num;
		global::UnityEngine.Object.Destroy(base.gameObject);
		return damage;
	}

	// Token: 0x0600022E RID: 558 RVA: 0x00007550 File Offset: 0x00005750
	[Token(Token = "0x600022E")]
	[Address(RVA = "0x3E8980", Offset = "0x3E6F80", VA = "0x1803E8980")]
	protected void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600022F RID: 559 RVA: 0x00007568 File Offset: 0x00005768
	[Token(Token = "0x600022F")]
	[Address(RVA = "0x3E8B90", Offset = "0x3E7190", VA = "0x1803E8B90")]
	private void Start()
	{
		ulong num;
		do
		{
			List<GameObject> childs = global::Core.Lawnf.GetChilds(base.transform);
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
				List<SpriteRenderer> list = this.spriteRenderers;
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06000230 RID: 560 RVA: 0x000075AC File Offset: 0x000057AC
	[Token(Token = "0x6000230")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "8")]
	protected virtual void OnFixedUpdate()
	{
	}

	// Token: 0x06000231 RID: 561 RVA: 0x000075BC File Offset: 0x000057BC
	[Token(Token = "0x6000231")]
	[Address(RVA = "0x3E89E0", Offset = "0x3E6FE0", VA = "0x1803E89E0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000232 RID: 562 RVA: 0x000075CC File Offset: 0x000057CC
	[Token(Token = "0x6000232")]
	[Address(RVA = "0x3E8A60", Offset = "0x3E7060", VA = "0x1803E8A60")]
	private void FlashUpdate()
	{
		float num = this.flashTimer;
		int num2 = 0;
		if (num > (float)num2)
		{
			if (num > 0.2f || num > (float)num2)
			{
				float num3 = num * -30f;
				this.SetLumen(num3);
			}
			float num4 = this.flashTimer;
			float fixedDeltaTime = Time.fixedDeltaTime;
			this.flashTimer = num4;
			this.SetLumen(1f);
			this.flashTimer = 0f;
		}
	}

	// Token: 0x06000233 RID: 563 RVA: 0x00007630 File Offset: 0x00005830
	[Token(Token = "0x6000233")]
	[Address(RVA = "0x3E8B30", Offset = "0x3E7130", VA = "0x1803E8B30", Slot = "9")]
	public virtual void SetLumen(float b)
	{
		GameMaterial.SetBrightness(this.spriteRenderers, b);
	}

	// Token: 0x06000234 RID: 564 RVA: 0x0000764C File Offset: 0x0000584C
	[Token(Token = "0x6000234")]
	[Address(RVA = "0x3E8940", Offset = "0x3E6F40", VA = "0x1803E8940", Slot = "6")]
	public bool CanAttack(IDamageable target)
	{
		NotImplementedException ex = new NotImplementedException();
		return false;
	}

	// Token: 0x06000235 RID: 565 RVA: 0x00007660 File Offset: 0x00005860
	[Token(Token = "0x6000235")]
	[Address(RVA = "0x3E8DD0", Offset = "0x3E73D0", VA = "0x1803E8DD0")]
	public AirProjectile()
	{
		List<SpriteRenderer> list = new List();
		this.spriteRenderers = list;
		this.dy = -10f;
		base..ctor();
	}

	// Token: 0x04000082 RID: 130
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000082")]
	public int theRow;

	// Token: 0x04000083 RID: 131
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000083")]
	public int damage;

	// Token: 0x04000084 RID: 132
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000084")]
	public int theHealth;

	// Token: 0x04000085 RID: 133
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000085")]
	public Collider2D col;

	// Token: 0x04000086 RID: 134
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000086")]
	public Rigidbody2D rb;

	// Token: 0x04000087 RID: 135
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000087")]
	private readonly List<SpriteRenderer> spriteRenderers;

	// Token: 0x04000088 RID: 136
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000088")]
	protected float flashTimer;

	// Token: 0x04000089 RID: 137
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000089")]
	public float dy;
}
