using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000084 RID: 132
[Token(Token = "0x2000084")]
public class AirProjectile : MonoBehaviour, IDamageMaker
{
	// Token: 0x17000036 RID: 54
	// (get) Token: 0x0600020F RID: 527 RVA: 0x000070E4 File Offset: 0x000052E4
	// (set) Token: 0x06000210 RID: 528 RVA: 0x000070F4 File Offset: 0x000052F4
	[Token(Token = "0x17000036")]
	public Team Team
	{
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "4")]
		get
		{
			return Team.AI;
		}
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x39CE50", Offset = "0x39B450", VA = "0x18039CE50", Slot = "5")]
		set
		{
			NotImplementedException ex = new NotImplementedException();
		}
	}

	// Token: 0x06000211 RID: 529 RVA: 0x00007108 File Offset: 0x00005308
	[Token(Token = "0x6000211")]
	[Address(RVA = "0x39C8A0", Offset = "0x39AEA0", VA = "0x18039C8A0", Slot = "7")]
	protected virtual void Awake()
	{
		Collider2D component = base.GetComponent<Collider2D>();
		this.col = component;
		Rigidbody2D component2 = base.GetComponent<Rigidbody2D>();
		this.rb = component2;
		this.rb.interpolation = (RigidbodyInterpolation2D)((uint)1);
	}

	// Token: 0x06000212 RID: 530 RVA: 0x00007144 File Offset: 0x00005344
	[Token(Token = "0x6000212")]
	[Address(RVA = "0x39CD30", Offset = "0x39B330", VA = "0x18039CD30")]
	public int TakeDamage(int damage)
	{
		int num = this.theHealth;
		num -= damage;
		this.flashTimer = 0.2f;
		this.theHealth = num;
		global::UnityEngine.Object.Destroy(base.gameObject);
		return damage;
	}

	// Token: 0x06000213 RID: 531 RVA: 0x0000717C File Offset: 0x0000537C
	[Token(Token = "0x6000213")]
	[Address(RVA = "0x39C970", Offset = "0x39AF70", VA = "0x18039C970")]
	protected void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000214 RID: 532 RVA: 0x00007194 File Offset: 0x00005394
	[Token(Token = "0x6000214")]
	[Address(RVA = "0x39CB80", Offset = "0x39B180", VA = "0x18039CB80")]
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

	// Token: 0x06000215 RID: 533 RVA: 0x000071D8 File Offset: 0x000053D8
	[Token(Token = "0x6000215")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "8")]
	protected virtual void OnFixedUpdate()
	{
	}

	// Token: 0x06000216 RID: 534 RVA: 0x000071E8 File Offset: 0x000053E8
	[Token(Token = "0x6000216")]
	[Address(RVA = "0x39C9D0", Offset = "0x39AFD0", VA = "0x18039C9D0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000217 RID: 535 RVA: 0x000071F8 File Offset: 0x000053F8
	[Token(Token = "0x6000217")]
	[Address(RVA = "0x39CA50", Offset = "0x39B050", VA = "0x18039CA50")]
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

	// Token: 0x06000218 RID: 536 RVA: 0x0000725C File Offset: 0x0000545C
	[Token(Token = "0x6000218")]
	[Address(RVA = "0x39CB20", Offset = "0x39B120", VA = "0x18039CB20", Slot = "9")]
	public virtual void SetLumen(float b)
	{
		GameMaterial.SetBrightness(this.spriteRenderers, b);
	}

	// Token: 0x06000219 RID: 537 RVA: 0x00007278 File Offset: 0x00005478
	[Token(Token = "0x6000219")]
	[Address(RVA = "0x39C930", Offset = "0x39AF30", VA = "0x18039C930", Slot = "6")]
	public bool CanAttack(IDamageable target)
	{
		NotImplementedException ex = new NotImplementedException();
		return false;
	}

	// Token: 0x0600021A RID: 538 RVA: 0x0000728C File Offset: 0x0000548C
	[Token(Token = "0x600021A")]
	[Address(RVA = "0x39CDC0", Offset = "0x39B3C0", VA = "0x18039CDC0")]
	public AirProjectile()
	{
		List<SpriteRenderer> list = new List();
		this.spriteRenderers = list;
		this.dy = -10f;
		base..ctor();
	}

	// Token: 0x04000075 RID: 117
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000075")]
	public int theRow;

	// Token: 0x04000076 RID: 118
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000076")]
	public int damage;

	// Token: 0x04000077 RID: 119
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000077")]
	public int theHealth;

	// Token: 0x04000078 RID: 120
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000078")]
	public Collider2D col;

	// Token: 0x04000079 RID: 121
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000079")]
	public Rigidbody2D rb;

	// Token: 0x0400007A RID: 122
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400007A")]
	private readonly List<SpriteRenderer> spriteRenderers;

	// Token: 0x0400007B RID: 123
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400007B")]
	protected float flashTimer;

	// Token: 0x0400007C RID: 124
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400007C")]
	public float dy;
}
