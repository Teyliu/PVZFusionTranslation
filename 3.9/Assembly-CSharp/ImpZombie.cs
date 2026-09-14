using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020006B7 RID: 1719
[Token(Token = "0x20006B7")]
public class ImpZombie : Zombie
{
	// Token: 0x060020FC RID: 8444 RVA: 0x000AE370 File Offset: 0x000AC570
	[Token(Token = "0x60020FC")]
	[Address(RVA = "0x5B4250", Offset = "0x5B2850", VA = "0x1805B4250", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform.Find("RealShadow");
		this.realShadow = transform;
		this.realShadow.AddComponent<SortingGroup>().sortAtRoot = true;
		this.Vx = -3f;
	}

	// Token: 0x060020FD RID: 8445 RVA: 0x000AE3C0 File Offset: 0x000AC5C0
	[Token(Token = "0x60020FD")]
	[Address(RVA = "0x586E80", Offset = "0x585480", VA = "0x180586E80", Slot = "71")]
	public override void BeSmall(float scale = 0.5f)
	{
	}

	// Token: 0x060020FE RID: 8446 RVA: 0x000AE3D0 File Offset: 0x000AC5D0
	[Token(Token = "0x60020FE")]
	[Address(RVA = "0x5B4AB0", Offset = "0x5B30B0", VA = "0x1805B4AB0", Slot = "16")]
	protected override void Start()
	{
		ulong num;
		do
		{
			base.Start();
			Mouse instance = Mouse.Instance;
			Transform axis = this.axis;
			this.Vx = -2f;
			List<SpriteRenderer> spriteRenderers = this.spriteRenderers;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
		ImpZombie.<EnableSprites>d__8 <EnableSprites>d__;
		<EnableSprites>d__.<>1__state = (int)((ulong)0L);
		<EnableSprites>d__.<>4__this = 0;
		int theZombieRow = this.theZombieRow;
		if (this.fromRow != theZombieRow)
		{
			int num2 = this.fromRow;
			float vy = this.Vy;
			int num3 = this.theZombieRow;
			num3 -= num2;
			this.Vy = vy;
			return;
		}
	}

	// Token: 0x060020FF RID: 8447 RVA: 0x000AE478 File Offset: 0x000AC678
	[Token(Token = "0x60020FF")]
	[Address(RVA = "0x5B4440", Offset = "0x5B2A40", VA = "0x1805B4440")]
	private IEnumerator EnableSprites()
	{
		ImpZombie.<EnableSprites>d__8 <EnableSprites>d__;
		<EnableSprites>d__.System.IDisposable.Dispose();
		<EnableSprites>d__.<>1__state = (int)((ulong)0L);
		<EnableSprites>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06002100 RID: 8448 RVA: 0x000AE49C File Offset: 0x000AC69C
	[Token(Token = "0x6002100")]
	[Address(RVA = "0x5B4320", Offset = "0x5B2920", VA = "0x1805B4320", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).GetComponent<SpriteRenderer>().enabled = true;
	}

	// Token: 0x06002101 RID: 8449 RVA: 0x000AE4DC File Offset: 0x000AC6DC
	[Token(Token = "0x6002101")]
	[Address(RVA = "0x5B49D0", Offset = "0x5B2FD0", VA = "0x1805B49D0")]
	private void StartLand()
	{
		base.ChangeStatus((ZombieStatus)((uint)17));
		ImpZombie.<IAdjustPosition>d__11 <IAdjustPosition>d__;
		<IAdjustPosition>d__.System.IDisposable.Dispose();
		<IAdjustPosition>d__.<>1__state = (int)((ulong)0L);
		<IAdjustPosition>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<IAdjustPosition>d__);
		this.coroutine = coroutine;
		Rigidbody2D rb = this.rb;
	}

	// Token: 0x06002102 RID: 8450 RVA: 0x000AE528 File Offset: 0x000AC728
	[Token(Token = "0x6002102")]
	[Address(RVA = "0x5B44B0", Offset = "0x5B2AB0", VA = "0x1805B44B0")]
	private IEnumerator IAdjustPosition()
	{
		ImpZombie.<IAdjustPosition>d__11 <IAdjustPosition>d__;
		<IAdjustPosition>d__.System.IDisposable.Dispose();
		<IAdjustPosition>d__.<>1__state = (int)((ulong)0L);
		<IAdjustPosition>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06002103 RID: 8451 RVA: 0x000AE54C File Offset: 0x000AC74C
	[Token(Token = "0x6002103")]
	[Address(RVA = "0x5B4520", Offset = "0x5B2B20", VA = "0x1805B4520", Slot = "76")]
	protected virtual void Land()
	{
		int num = 0;
		base.ChangeStatus((ZombieStatus)num);
		Rigidbody2D rb = this.rb;
	}

	// Token: 0x06002104 RID: 8452 RVA: 0x000AE570 File Offset: 0x000AC770
	[Token(Token = "0x6002104")]
	[Address(RVA = "0x5B43D0", Offset = "0x5B29D0", VA = "0x1805B43D0", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		base.DieEvent(reason);
		Rigidbody2D rb = this.rb;
	}

	// Token: 0x06002105 RID: 8453 RVA: 0x000AE594 File Offset: 0x000AC794
	[Token(Token = "0x6002105")]
	[Address(RVA = "0x5B4590", Offset = "0x5B2B90", VA = "0x1805B4590", Slot = "34")]
	protected override void LoseHeadEvent()
	{
		base.ZombieUpdate();
		Rigidbody2D rb = this.rb;
	}

	// Token: 0x06002106 RID: 8454 RVA: 0x000AE5B8 File Offset: 0x000AC7B8
	[Token(Token = "0x6002106")]
	[Address(RVA = "0x5B4D50", Offset = "0x5B3350", VA = "0x1805B4D50")]
	public void Thrown()
	{
		Transform transform = base.transform;
		int num = 0;
		int num2 = 0;
		transform.Translate((float)num2, 1.5f, (float)num);
		this.anim.Play("thrown");
		int theZombieRow = this.theZombieRow;
		this.fromRow = theZombieRow;
		this.theStatus = (ZombieStatus)((ulong)16L);
	}

	// Token: 0x06002107 RID: 8455 RVA: 0x000AE610 File Offset: 0x000AC810
	[Token(Token = "0x6002107")]
	[Address(RVA = "0x5B4600", Offset = "0x5B2C00", VA = "0x1805B4600", Slot = "22")]
	protected override void PositionUpdate()
	{
		base.PositionUpdate();
		Rigidbody2D rb = this.rb;
		Transform axis = this.axis;
		Mouse instance = Mouse.Instance;
		Board board = this.board;
		Transform axis2 = this.axis;
		Vector3 vector;
		float num;
		if (vector.y <= num)
		{
			Vector2 velocity = this.rb.velocity;
			this.anim.SetTrigger("landing");
		}
		float vy = this.Vy;
		int theZombieRow = this.theZombieRow;
		if (this.fromRow != theZombieRow)
		{
			float deltaTime = Time.deltaTime;
		}
		float deltaTime2 = Time.deltaTime;
		this.Vy = vy;
		Rigidbody2D rb2 = this.rb;
		Board board2 = this.board;
		Transform transform = this.realShadow;
		Transform axis3 = this.axis;
		Transform axis4 = this.axis;
		Mouse instance2 = Mouse.Instance;
	}

	// Token: 0x06002108 RID: 8456 RVA: 0x000AE6EC File Offset: 0x000AC8EC
	[Token(Token = "0x6002108")]
	[Address(RVA = "0x5B4980", Offset = "0x5B2F80", VA = "0x1805B4980", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetCold(time, num, true);
	}

	// Token: 0x06002109 RID: 8457 RVA: 0x000AE710 File Offset: 0x000AC910
	[Token(Token = "0x6002109")]
	[Address(RVA = "0x5B4300", Offset = "0x5B2900", VA = "0x1805B4300", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = false)
	{
		base.Buttered(time, true);
	}

	// Token: 0x0600210A RID: 8458 RVA: 0x000AE728 File Offset: 0x000AC928
	[Token(Token = "0x600210A")]
	[Address(RVA = "0x5B41F0", Offset = "0x5B27F0", VA = "0x1805B41F0")]
	public ImpZombie()
	{
	}

	// Token: 0x04001182 RID: 4482
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001182")]
	public int fromRow;

	// Token: 0x04001183 RID: 4483
	[FieldOffset(Offset = "0x27C")]
	[Token(Token = "0x4001183")]
	private float Vy = 1f;

	// Token: 0x04001184 RID: 4484
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001184")]
	private Transform realShadow;

	// Token: 0x04001185 RID: 4485
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4001185")]
	private float Vx;

	// Token: 0x04001186 RID: 4486
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4001186")]
	public Coroutine coroutine;
}
