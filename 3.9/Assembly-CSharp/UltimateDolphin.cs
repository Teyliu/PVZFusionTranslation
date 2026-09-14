using System;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000728 RID: 1832
[Token(Token = "0x2000728")]
public class UltimateDolphin : Zombie
{
	// Token: 0x06002436 RID: 9270 RVA: 0x000BCB5C File Offset: 0x000BAD5C
	[Token(Token = "0x6002436")]
	[Address(RVA = "0x5FB490", Offset = "0x5F9A90", VA = "0x1805FB490", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 0.5f;
		this.nextStageTimer = 10f;
	}

	// Token: 0x06002437 RID: 9271 RVA: 0x000BCB88 File Offset: 0x000BAD88
	[Token(Token = "0x6002437")]
	[Address(RVA = "0x5FB700", Offset = "0x5F9D00", VA = "0x1805FB700", Slot = "23")]
	protected override void OnFixedUpdate()
	{
		base.OnFixedUpdate();
		float num = this.nextStageTimer;
		float fixedDeltaTime = Time.fixedDeltaTime;
		this.nextStageTimer = num;
		this.nextStageTimer = 10f;
		this.Peace();
	}

	// Token: 0x06002438 RID: 9272 RVA: 0x000BCBD0 File Offset: 0x000BADD0
	[Token(Token = "0x6002438")]
	[Address(RVA = "0x5FB310", Offset = "0x5F9910", VA = "0x1805FB310", Slot = "24")]
	protected override void AttributeEvent()
	{
		Board board = this.board;
		this.attributeCountDown = 0.5f;
		int rowNum = board.rowNum;
		int num = global::UnityEngine.Random.Range(0, rowNum);
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(11);
		float landY = Mouse.Instance.GetLandY(boxXFromColumn, num);
		CreateBullet instance = CreateBullet.Instance;
		int theAttackDamage = this.theAttackDamage;
		Bullet bullet;
		bullet.Damage = theAttackDamage;
		bullet.shootByZombie = true;
		int num2 = this.attributeCount;
		num2++;
		this.attributeCount = num2;
		if (num2 != 2)
		{
		}
		Animator anim = this.anim;
		this.attributeCount = (int)((ulong)0L);
		anim.SetTrigger("shoot");
	}

	// Token: 0x06002439 RID: 9273 RVA: 0x000BCC74 File Offset: 0x000BAE74
	[Token(Token = "0x6002439")]
	[Address(RVA = "0x5FB1D0", Offset = "0x5F97D0", VA = "0x1805FB1D0")]
	private void AnimShoot()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot2 = this.shoot;
		Bullet bullet;
		bullet.velocity.y = -3f;
		bullet.velocity = (ulong)3233808384L;
		int theAttackDamage = this.theAttackDamage;
		bullet.Damage = theAttackDamage;
		bullet.shootByZombie = true;
	}

	// Token: 0x0600243A RID: 9274 RVA: 0x000BCCD8 File Offset: 0x000BAED8
	[Token(Token = "0x600243A")]
	[Address(RVA = "0x5FB4C0", Offset = "0x5F9AC0", VA = "0x1805FB4C0")]
	private BulletType GetBulletType()
	{
		return BulletType.Bullet_superCherry;
	}

	// Token: 0x0600243B RID: 9275 RVA: 0x000BCCE8 File Offset: 0x000BAEE8
	[Token(Token = "0x600243B")]
	[Address(RVA = "0x5FB4E0", Offset = "0x5F9AE0", VA = "0x1805FB4E0")]
	private void Landing()
	{
		int num = 0;
		this.jumping = num != 0;
		Transform axis = this.axis;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			LayerMask layerMask;
			int mask = layerMask.m_Mask;
			bool flag;
			if (layerMask != 0 && flag)
			{
				int theZombieRow = this.theZombieRow;
			}
			num++;
		}
	}

	// Token: 0x0600243C RID: 9276 RVA: 0x000BCD48 File Offset: 0x000BAF48
	[Token(Token = "0x600243C")]
	[Address(RVA = "0x5FB2F0", Offset = "0x5F98F0", VA = "0x1805FB2F0", Slot = "40")]
	protected override void AttackUpdate()
	{
		if (!this.jumping)
		{
			base.AttackUpdate();
			return;
		}
	}

	// Token: 0x0600243D RID: 9277 RVA: 0x000BCD68 File Offset: 0x000BAF68
	[Token(Token = "0x600243D")]
	[Address(RVA = "0x5FAF70", Offset = "0x5F9570", VA = "0x1805FAF70")]
	[ProButton]
	public void Angry()
	{
		ulong num3;
		do
		{
			this.uniqueSpeed = 2f;
			this.anim.SetTrigger("jump");
			this.jumping = true;
			Animator anim = this.anim;
			int num = 0;
			anim.SetBool("isAttacking", num != 0);
			List<SpriteRenderer> list = this.angrySprites;
			bool flag;
			if (flag)
			{
			}
			ulong num2;
			if (num2 != (ulong)0L)
			{
				goto IL_006B;
			}
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num3 != (ulong)0L);
		return;
		IL_006B:
		throw new NullReferenceException();
	}

	// Token: 0x0600243E RID: 9278 RVA: 0x000BCDE8 File Offset: 0x000BAFE8
	[Token(Token = "0x600243E")]
	[Address(RVA = "0x5FB780", Offset = "0x5F9D80", VA = "0x1805FB780")]
	[ProButton]
	public void Peace()
	{
		ulong num2;
		do
		{
			this.uniqueSpeed = 1f;
			List<SpriteRenderer> list = this.angrySprites;
			bool flag;
			if (flag)
			{
			}
			ulong num;
			if (num != (ulong)0L)
			{
				goto IL_0041;
			}
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num2 != (ulong)0L);
		return;
		IL_0041:
		throw new NullReferenceException();
	}

	// Token: 0x0600243F RID: 9279 RVA: 0x000BCE3C File Offset: 0x000BB03C
	[Token(Token = "0x600243F")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002440 RID: 9280 RVA: 0x000BCE4C File Offset: 0x000BB04C
	[Token(Token = "0x6002440")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06002441 RID: 9281 RVA: 0x000BCE5C File Offset: 0x000BB05C
	[Token(Token = "0x6002441")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06002442 RID: 9282 RVA: 0x000BCE6C File Offset: 0x000BB06C
	[Token(Token = "0x6002442")]
	[Address(RVA = "0x5A9160", Offset = "0x5A7760", VA = "0x1805A9160", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		long num;
		return num;
	}

	// Token: 0x06002443 RID: 9283 RVA: 0x000BCE80 File Offset: 0x000BB080
	[Token(Token = "0x6002443")]
	[Address(RVA = "0x5A9020", Offset = "0x5A7620", VA = "0x1805A9020", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06002444 RID: 9284 RVA: 0x000BCE90 File Offset: 0x000BB090
	[Token(Token = "0x6002444")]
	[Address(RVA = "0x5FB990", Offset = "0x5F9F90", VA = "0x1805FB990")]
	public UltimateDolphin()
	{
		List<SpriteRenderer> list = new List();
		this.angrySprites = list;
		List<SpriteRenderer> list2 = new List();
		this.normalSprites = list2;
		base..ctor();
	}

	// Token: 0x0400122B RID: 4651
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x400122B")]
	public List<SpriteRenderer> angrySprites;

	// Token: 0x0400122C RID: 4652
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x400122C")]
	public List<SpriteRenderer> normalSprites;

	// Token: 0x0400122D RID: 4653
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x400122D")]
	private float nextStageTimer;

	// Token: 0x0400122E RID: 4654
	[FieldOffset(Offset = "0x28C")]
	[Token(Token = "0x400122E")]
	private bool jumping;
}
