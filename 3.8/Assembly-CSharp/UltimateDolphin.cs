using System;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006F0 RID: 1776
[Token(Token = "0x20006F0")]
public class UltimateDolphin : Zombie
{
	// Token: 0x0600231A RID: 8986 RVA: 0x000B7D18 File Offset: 0x000B5F18
	[Token(Token = "0x600231A")]
	[Address(RVA = "0x57F7E0", Offset = "0x57DDE0", VA = "0x18057F7E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 0.5f;
		this.nextStageTimer = 10f;
	}

	// Token: 0x0600231B RID: 8987 RVA: 0x000B7D44 File Offset: 0x000B5F44
	[Token(Token = "0x600231B")]
	[Address(RVA = "0x57FA50", Offset = "0x57E050", VA = "0x18057FA50", Slot = "22")]
	protected override void OnFixedUpdate()
	{
		base.OnFixedUpdate();
		float num = this.nextStageTimer;
		float fixedDeltaTime = Time.fixedDeltaTime;
		this.nextStageTimer = num;
		this.nextStageTimer = 10f;
		this.Peace();
	}

	// Token: 0x0600231C RID: 8988 RVA: 0x000B7D8C File Offset: 0x000B5F8C
	[Token(Token = "0x600231C")]
	[Address(RVA = "0x57F660", Offset = "0x57DC60", VA = "0x18057F660", Slot = "23")]
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

	// Token: 0x0600231D RID: 8989 RVA: 0x000B7E30 File Offset: 0x000B6030
	[Token(Token = "0x600231D")]
	[Address(RVA = "0x57F520", Offset = "0x57DB20", VA = "0x18057F520")]
	private void AnimShoot()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot2 = this.shoot;
		Bullet bullet;
		bullet.Vy = -3f;
		bullet.Vx = -6f;
		int theAttackDamage = this.theAttackDamage;
		bullet.Damage = theAttackDamage;
		bullet.shootByZombie = true;
	}

	// Token: 0x0600231E RID: 8990 RVA: 0x000B7E8C File Offset: 0x000B608C
	[Token(Token = "0x600231E")]
	[Address(RVA = "0x57F810", Offset = "0x57DE10", VA = "0x18057F810")]
	private BulletType GetBulletType()
	{
		return BulletType.Bullet_superCherry;
	}

	// Token: 0x0600231F RID: 8991 RVA: 0x000B7E9C File Offset: 0x000B609C
	[Token(Token = "0x600231F")]
	[Address(RVA = "0x57F830", Offset = "0x57DE30", VA = "0x18057F830")]
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

	// Token: 0x06002320 RID: 8992 RVA: 0x000B7EFC File Offset: 0x000B60FC
	[Token(Token = "0x6002320")]
	[Address(RVA = "0x57F640", Offset = "0x57DC40", VA = "0x18057F640", Slot = "38")]
	protected override void AttackUpdate()
	{
		if (!this.jumping)
		{
			base.AttackUpdate();
			return;
		}
	}

	// Token: 0x06002321 RID: 8993 RVA: 0x000B7F1C File Offset: 0x000B611C
	[Token(Token = "0x6002321")]
	[Address(RVA = "0x57F2C0", Offset = "0x57D8C0", VA = "0x18057F2C0")]
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

	// Token: 0x06002322 RID: 8994 RVA: 0x000B7F9C File Offset: 0x000B619C
	[Token(Token = "0x6002322")]
	[Address(RVA = "0x57FAD0", Offset = "0x57E0D0", VA = "0x18057FAD0")]
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

	// Token: 0x06002323 RID: 8995 RVA: 0x000B7FF0 File Offset: 0x000B61F0
	[Token(Token = "0x6002323")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002324 RID: 8996 RVA: 0x000B8000 File Offset: 0x000B6200
	[Token(Token = "0x6002324")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06002325 RID: 8997 RVA: 0x000B8010 File Offset: 0x000B6210
	[Token(Token = "0x6002325")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06002326 RID: 8998 RVA: 0x000B8020 File Offset: 0x000B6220
	[Token(Token = "0x6002326")]
	[Address(RVA = "0x546F50", Offset = "0x545550", VA = "0x180546F50", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		int num;
		if (num > 5000)
		{
		}
		return num;
	}

	// Token: 0x06002327 RID: 8999 RVA: 0x000B803C File Offset: 0x000B623C
	[Token(Token = "0x6002327")]
	[Address(RVA = "0x546D50", Offset = "0x545350", VA = "0x180546D50", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06002328 RID: 9000 RVA: 0x000B804C File Offset: 0x000B624C
	[Token(Token = "0x6002328")]
	[Address(RVA = "0x57FCE0", Offset = "0x57E2E0", VA = "0x18057FCE0")]
	public UltimateDolphin()
	{
		List<SpriteRenderer> list = new List();
		this.angrySprites = list;
		List<SpriteRenderer> list2 = new List();
		this.normalSprites = list2;
		base..ctor();
	}

	// Token: 0x0400115E RID: 4446
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400115E")]
	public List<SpriteRenderer> angrySprites;

	// Token: 0x0400115F RID: 4447
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400115F")]
	public List<SpriteRenderer> normalSprites;

	// Token: 0x04001160 RID: 4448
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4001160")]
	private float nextStageTimer;

	// Token: 0x04001161 RID: 4449
	[FieldOffset(Offset = "0x26C")]
	[Token(Token = "0x4001161")]
	private bool jumping;
}
