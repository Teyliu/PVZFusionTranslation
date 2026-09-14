using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000681 RID: 1665
[Token(Token = "0x2000681")]
public class ImpZombie : Zombie
{
	// Token: 0x06001FFA RID: 8186 RVA: 0x000A9A6C File Offset: 0x000A7C6C
	[Token(Token = "0x6001FFA")]
	[Address(RVA = "0x5506C0", Offset = "0x54ECC0", VA = "0x1805506C0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform.Find("RealShadow");
		this.realShadow = transform;
		this.realShadow.AddComponent<SortingGroup>().sortAtRoot = true;
		this.Vx = -3f;
	}

	// Token: 0x06001FFB RID: 8187 RVA: 0x000A9ABC File Offset: 0x000A7CBC
	[Token(Token = "0x6001FFB")]
	[Address(RVA = "0x530300", Offset = "0x52E900", VA = "0x180530300", Slot = "69")]
	public override void BeSmall(float scale = 0.5f)
	{
	}

	// Token: 0x06001FFC RID: 8188 RVA: 0x000A9ACC File Offset: 0x000A7CCC
	[Token(Token = "0x6001FFC")]
	[Address(RVA = "0x550F20", Offset = "0x54F520", VA = "0x180550F20", Slot = "15")]
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

	// Token: 0x06001FFD RID: 8189 RVA: 0x000A9B74 File Offset: 0x000A7D74
	[Token(Token = "0x6001FFD")]
	[Address(RVA = "0x5508B0", Offset = "0x54EEB0", VA = "0x1805508B0")]
	private IEnumerator EnableSprites()
	{
		ImpZombie.<EnableSprites>d__8 <EnableSprites>d__;
		<EnableSprites>d__.System.IDisposable.Dispose();
		<EnableSprites>d__.<>1__state = (int)((ulong)0L);
		<EnableSprites>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001FFE RID: 8190 RVA: 0x000A9B98 File Offset: 0x000A7D98
	[Token(Token = "0x6001FFE")]
	[Address(RVA = "0x550790", Offset = "0x54ED90", VA = "0x180550790", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).GetComponent<SpriteRenderer>().enabled = true;
	}

	// Token: 0x06001FFF RID: 8191 RVA: 0x000A9BD8 File Offset: 0x000A7DD8
	[Token(Token = "0x6001FFF")]
	[Address(RVA = "0x550E40", Offset = "0x54F440", VA = "0x180550E40")]
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

	// Token: 0x06002000 RID: 8192 RVA: 0x000A9C24 File Offset: 0x000A7E24
	[Token(Token = "0x6002000")]
	[Address(RVA = "0x550920", Offset = "0x54EF20", VA = "0x180550920")]
	private IEnumerator IAdjustPosition()
	{
		ImpZombie.<IAdjustPosition>d__11 <IAdjustPosition>d__;
		<IAdjustPosition>d__.System.IDisposable.Dispose();
		<IAdjustPosition>d__.<>1__state = (int)((ulong)0L);
		<IAdjustPosition>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06002001 RID: 8193 RVA: 0x000A9C48 File Offset: 0x000A7E48
	[Token(Token = "0x6002001")]
	[Address(RVA = "0x550990", Offset = "0x54EF90", VA = "0x180550990", Slot = "74")]
	protected virtual void Land()
	{
		int num = 0;
		base.ChangeStatus((ZombieStatus)num);
		Rigidbody2D rb = this.rb;
	}

	// Token: 0x06002002 RID: 8194 RVA: 0x000A9C6C File Offset: 0x000A7E6C
	[Token(Token = "0x6002002")]
	[Address(RVA = "0x550840", Offset = "0x54EE40", VA = "0x180550840", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		base.DieEvent(reason);
		Rigidbody2D rb = this.rb;
	}

	// Token: 0x06002003 RID: 8195 RVA: 0x000A9C90 File Offset: 0x000A7E90
	[Token(Token = "0x6002003")]
	[Address(RVA = "0x550A00", Offset = "0x54F000", VA = "0x180550A00", Slot = "33")]
	protected override void LoseHeadEvent()
	{
		base.ZombieUpdate();
		Rigidbody2D rb = this.rb;
	}

	// Token: 0x06002004 RID: 8196 RVA: 0x000A9CB4 File Offset: 0x000A7EB4
	[Token(Token = "0x6002004")]
	[Address(RVA = "0x5511C0", Offset = "0x54F7C0", VA = "0x1805511C0")]
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

	// Token: 0x06002005 RID: 8197 RVA: 0x000A9D0C File Offset: 0x000A7F0C
	[Token(Token = "0x6002005")]
	[Address(RVA = "0x550A70", Offset = "0x54F070", VA = "0x180550A70", Slot = "21")]
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

	// Token: 0x06002006 RID: 8198 RVA: 0x000A9DE8 File Offset: 0x000A7FE8
	[Token(Token = "0x6002006")]
	[Address(RVA = "0x550DF0", Offset = "0x54F3F0", VA = "0x180550DF0", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetCold(time, num, true);
	}

	// Token: 0x06002007 RID: 8199 RVA: 0x000A9E0C File Offset: 0x000A800C
	[Token(Token = "0x6002007")]
	[Address(RVA = "0x550770", Offset = "0x54ED70", VA = "0x180550770", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = false)
	{
		base.Buttered(time, true);
	}

	// Token: 0x06002008 RID: 8200 RVA: 0x000A9E24 File Offset: 0x000A8024
	[Token(Token = "0x6002008")]
	[Address(RVA = "0x550660", Offset = "0x54EC60", VA = "0x180550660")]
	public ImpZombie()
	{
	}

	// Token: 0x040010B5 RID: 4277
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40010B5")]
	public int fromRow;

	// Token: 0x040010B6 RID: 4278
	[FieldOffset(Offset = "0x25C")]
	[Token(Token = "0x40010B6")]
	private float Vy = 1f;

	// Token: 0x040010B7 RID: 4279
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x40010B7")]
	private Transform realShadow;

	// Token: 0x040010B8 RID: 4280
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x40010B8")]
	private float Vx;

	// Token: 0x040010B9 RID: 4281
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x40010B9")]
	public Coroutine coroutine;
}
