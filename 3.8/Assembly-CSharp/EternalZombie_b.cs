using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000664 RID: 1636
[Token(Token = "0x2000664")]
public class EternalZombie_b : EternalZombie_a
{
	// Token: 0x06001F1F RID: 7967 RVA: 0x000A5B1C File Offset: 0x000A3D1C
	[Token(Token = "0x6001F1F")]
	[Address(RVA = "0x544A00", Offset = "0x543000", VA = "0x180544A00", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(4.4f, 7.54f);
		this.attributeCountDown = num;
		Transform transform = base.transform;
		int num2 = 0;
		Transform child = transform.GetChild(num2);
		int num3 = 0;
		ParticleSystem component = child.GetChild(num3).GetComponent<ParticleSystem>();
		this.particle = component;
		throw new NullReferenceException();
	}

	// Token: 0x06001F20 RID: 7968 RVA: 0x000A5B78 File Offset: 0x000A3D78
	[Token(Token = "0x6001F20")]
	[Address(RVA = "0x544980", Offset = "0x542F80", VA = "0x180544980", Slot = "23")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("quickMove");
		float num = global::UnityEngine.Random.Range(4.4f, 7.54f);
		this.attributeCountDown = num;
	}

	// Token: 0x06001F21 RID: 7969 RVA: 0x000A5BB4 File Offset: 0x000A3DB4
	[Token(Token = "0x6001F21")]
	[Address(RVA = "0x544B10", Offset = "0x543110", VA = "0x180544B10", Slot = "40")]
	protected override void OnTriggerExit2D(Collider2D collision)
	{
		base.OnTriggerExit2D(collision);
		if (this.quickmove)
		{
			this.QuickDamage(collision);
		}
	}

	// Token: 0x06001F22 RID: 7970 RVA: 0x000A5BDC File Offset: 0x000A3DDC
	[Token(Token = "0x6001F22")]
	[Address(RVA = "0x544AC0", Offset = "0x5430C0", VA = "0x180544AC0", Slot = "39")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		base.OnTriggerEnter2D(collision);
		if (this.quickmove)
		{
			this.QuickDamage(collision);
		}
	}

	// Token: 0x06001F23 RID: 7971 RVA: 0x000A5C04 File Offset: 0x000A3E04
	[Token(Token = "0x6001F23")]
	[Address(RVA = "0x544DB0", Offset = "0x5433B0", VA = "0x180544DB0")]
	private void StartQuickMove()
	{
		GameAPP.PlaySound(42, 0.3f, 1.6f);
		ParticleSystem particleSystem = this.particle;
		this.quickmove = true;
		ParticleSystem.MainModule main = particleSystem.main;
	}

	// Token: 0x06001F24 RID: 7972 RVA: 0x000A5C40 File Offset: 0x000A3E40
	[Token(Token = "0x6001F24")]
	[Address(RVA = "0x544D60", Offset = "0x543360", VA = "0x180544D60")]
	private void QuickMoveOver()
	{
		this.quickmove = false;
		ParticleSystem.MainModule main = this.particle.main;
	}

	// Token: 0x06001F25 RID: 7973 RVA: 0x000A5C68 File Offset: 0x000A3E68
	[Token(Token = "0x6001F25")]
	[Address(RVA = "0x544B60", Offset = "0x543160", VA = "0x180544B60")]
	private void QuickDamage(Collider2D collision)
	{
		for (;;)
		{
			int num = 0;
			if (collision.TryGetComponent<Plant>(num))
			{
				break;
			}
			if (collision.TryGetComponent<Zombie>(num))
			{
				bool isMindControlled = this.isMindControlled;
				int theZombieRow = this.theZombieRow;
				if (Lawnf.InLandStatus((ZombieStatus)num))
				{
					return;
				}
			}
		}
		int theZombieRow2 = this.theZombieRow;
		int num2 = 0;
		Plant plant;
		if (!(plant == num2))
		{
		}
	}

	// Token: 0x06001F26 RID: 7974 RVA: 0x000A5CC0 File Offset: 0x000A3EC0
	[Token(Token = "0x6001F26")]
	[Address(RVA = "0x544930", Offset = "0x542F30", VA = "0x180544930")]
	public EternalZombie_b()
	{
	}

	// Token: 0x0400106B RID: 4203
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400106B")]
	public bool quickmove;

	// Token: 0x0400106C RID: 4204
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400106C")]
	private ParticleSystem particle;
}
