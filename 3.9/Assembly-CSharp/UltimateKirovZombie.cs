using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000739 RID: 1849
[Token(Token = "0x2000739")]
public class UltimateKirovZombie : Zombie
{
	// Token: 0x060024E0 RID: 9440 RVA: 0x000BFAC8 File Offset: 0x000BDCC8
	[Token(Token = "0x60024E0")]
	[Address(RVA = "0x588720", Offset = "0x586D20", VA = "0x180588720", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 3f;
	}

	// Token: 0x060024E1 RID: 9441 RVA: 0x000BFAE8 File Offset: 0x000BDCE8
	[Token(Token = "0x60024E1")]
	[Address(RVA = "0x5FD9F0", Offset = "0x5FBFF0", VA = "0x1805FD9F0", Slot = "16")]
	protected override void Start()
	{
		int num = 0;
		base.Start();
		Board board = this.board;
		global::Lawnf.SetZombieHealth(this, (float)num);
	}

	// Token: 0x060024E2 RID: 9442 RVA: 0x000BFB14 File Offset: 0x000BDD14
	[Token(Token = "0x60024E2")]
	[Address(RVA = "0x602C40", Offset = "0x601240", VA = "0x180602C40", Slot = "24")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("shoot");
		Board board = this.board;
		int num = 0;
		if (num < board.rowNum)
		{
			Zombie zombie = CreateZombie.Instance.SetZombie(num, (ZombieType)((uint)205), 9.9f, num != 0);
			Board board2 = this.board;
			num++;
		}
		this.attributeCountDown = 3f;
	}

	// Token: 0x060024E3 RID: 9443 RVA: 0x000BFB78 File Offset: 0x000BDD78
	[Token(Token = "0x60024E3")]
	[Address(RVA = "0x6029A0", Offset = "0x600FA0", VA = "0x1806029A0")]
	private void AnimShoot()
	{
		Transform shoot = this.shoot;
		GameObject gameObject = this.weaponPrefab;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		SpiderWeapon component = gameObject2.GetComponent<SpiderWeapon>();
		int theZombieRow = this.theZombieRow;
		component.theRow = theZombieRow;
		bool isMindControlled = this.isMindControlled;
		component.isMindControl = isMindControlled;
		Board board = this.board;
		component.board = board;
		SpriteRenderer component2 = component.GetComponent<SpriteRenderer>();
		int theZombieRow2 = this.theZombieRow;
		string text = string.Format("bullet{0}", component2);
		component2.sortingLayerName = text;
		Rigidbody2D rb = component.rb;
	}

	// Token: 0x060024E4 RID: 9444 RVA: 0x000BFC24 File Offset: 0x000BDE24
	[Token(Token = "0x60024E4")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060024E5 RID: 9445 RVA: 0x000BFC34 File Offset: 0x000BDE34
	[Token(Token = "0x60024E5")]
	[Address(RVA = "0x603440", Offset = "0x601A40", VA = "0x180603440")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x060024E6 RID: 9446 RVA: 0x000BFC54 File Offset: 0x000BDE54
	[Token(Token = "0x60024E6")]
	[Address(RVA = "0x6033F0", Offset = "0x6019F0", VA = "0x1806033F0", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix = false, PlantType fromType = PlantType.Nothing)
	{
		return 0L;
	}

	// Token: 0x060024E7 RID: 9447 RVA: 0x000BFC68 File Offset: 0x000BDE68
	[Token(Token = "0x60024E7")]
	[Address(RVA = "0x5A9020", Offset = "0x5A7620", VA = "0x1805A9020", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x060024E8 RID: 9448 RVA: 0x000BFC78 File Offset: 0x000BDE78
	[Token(Token = "0x60024E8")]
	[Address(RVA = "0x602D50", Offset = "0x601350", VA = "0x180602D50", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num13;
		do
		{
			long num = this.theHealth;
			num -= (long)theDamage;
			this.theHealth = num;
			long num2 = this.theMaxHealth;
			num2 += num2;
			num -= (long)theDamage;
			this.anim.SetTrigger("fly");
			long num3 = this.theMaxHealth;
			num3 += num3;
			int num4 = 0;
			int num5 = 0;
			if (global::Core.Lawnf.ValueBetween((float)0, (float)num5, (float)num4))
			{
				List<Transform> changeSprites = this.changeSprites;
				bool flag;
				if (flag)
				{
					int num6 = 0;
					SpriteRenderer spriteRenderer;
					spriteRenderer.enabled = num6 != 0;
					Transform transform;
					ulong num7;
					transform.GetComponent<SpriteRenderer>().enabled = num7 != 0UL;
					Transform transform2;
					SpriteRenderer component = transform2.GetComponent<SpriteRenderer>();
					int num8 = 0;
					component.enabled = num8 != 0;
				}
				ulong num9;
				if (num9 != (ulong)0L)
				{
					goto IL_0103;
				}
			}
			bool flag2;
			if (flag2)
			{
				int num10 = 0;
				SpriteRenderer spriteRenderer2;
				spriteRenderer2.enabled = num10 != 0;
				Transform transform3;
				SpriteRenderer component2 = transform3.GetComponent<SpriteRenderer>();
				int num11 = 0;
				component2.enabled = num11 != 0;
				Transform transform4;
				ulong num12;
				transform4.GetComponent<SpriteRenderer>().enabled = num12 != 0UL;
			}
		}
		while (num13 != (ulong)0L);
		return;
		IL_0103:
		throw new NullReferenceException();
	}

	// Token: 0x060024E9 RID: 9449 RVA: 0x000BFDAC File Offset: 0x000BDFAC
	[Token(Token = "0x60024E9")]
	[Address(RVA = "0x589F50", Offset = "0x588550", VA = "0x180589F50", Slot = "28")]
	public override void Die(int reason = 0)
	{
		bool flag = reason != 1;
		base.Die(flag ? 1 : 0);
	}

	// Token: 0x060024EA RID: 9450 RVA: 0x000BFDCC File Offset: 0x000BDFCC
	[Token(Token = "0x60024EA")]
	[Address(RVA = "0x603210", Offset = "0x601810", VA = "0x180603210", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		GameObject[] particlePrefab = GameAPP.particlePrefab;
		Transform axis = this.axis;
		GameObject gameObject = particlePrefab[34];
		Transform axis2 = this.axis;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
	}

	// Token: 0x060024EB RID: 9451 RVA: 0x000BFE28 File Offset: 0x000BE028
	[Token(Token = "0x60024EB")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x060024EC RID: 9452 RVA: 0x000BFE38 File Offset: 0x000BE038
	[Token(Token = "0x60024EC")]
	[Address(RVA = "0x603480", Offset = "0x601A80", VA = "0x180603480", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x060024ED RID: 9453 RVA: 0x000BFE54 File Offset: 0x000BE054
	[Token(Token = "0x60024ED")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x060024EE RID: 9454 RVA: 0x000BFE64 File Offset: 0x000BE064
	[Token(Token = "0x60024EE")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x060024EF RID: 9455 RVA: 0x000BFE74 File Offset: 0x000BE074
	[Token(Token = "0x60024EF")]
	[Address(RVA = "0x6034A0", Offset = "0x601AA0", VA = "0x1806034A0")]
	public UltimateKirovZombie()
	{
	}

	// Token: 0x04001264 RID: 4708
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001264")]
	public GameObject weaponPrefab;
}
