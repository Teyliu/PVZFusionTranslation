using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200069A RID: 1690
[Token(Token = "0x200069A")]
public class EternalZombie_b : EternalZombie_a
{
	// Token: 0x06002021 RID: 8225 RVA: 0x000AA294 File Offset: 0x000A8494
	[Token(Token = "0x6002021")]
	[Address(RVA = "0x5A7020", Offset = "0x5A5620", VA = "0x1805A7020", Slot = "10")]
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

	// Token: 0x06002022 RID: 8226 RVA: 0x000AA2F0 File Offset: 0x000A84F0
	[Token(Token = "0x6002022")]
	[Address(RVA = "0x5A6FA0", Offset = "0x5A55A0", VA = "0x1805A6FA0", Slot = "24")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("quickMove");
		float num = global::UnityEngine.Random.Range(4.4f, 7.54f);
		this.attributeCountDown = num;
	}

	// Token: 0x06002023 RID: 8227 RVA: 0x000AA32C File Offset: 0x000A852C
	[Token(Token = "0x6002023")]
	[Address(RVA = "0x5A7130", Offset = "0x5A5730", VA = "0x1805A7130", Slot = "42")]
	protected override void OnTriggerExit2D(Collider2D collision)
	{
		base.OnTriggerExit2D(collision);
		if (this.quickmove)
		{
			this.QuickDamage(collision);
		}
	}

	// Token: 0x06002024 RID: 8228 RVA: 0x000AA354 File Offset: 0x000A8554
	[Token(Token = "0x6002024")]
	[Address(RVA = "0x5A70E0", Offset = "0x5A56E0", VA = "0x1805A70E0", Slot = "41")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		base.OnTriggerEnter2D(collision);
		if (this.quickmove)
		{
			this.QuickDamage(collision);
		}
	}

	// Token: 0x06002025 RID: 8229 RVA: 0x000AA37C File Offset: 0x000A857C
	[Token(Token = "0x6002025")]
	[Address(RVA = "0x5A73D0", Offset = "0x5A59D0", VA = "0x1805A73D0")]
	private void StartQuickMove()
	{
		GameAPP.PlaySound(42, 0.3f, 1.6f);
		ParticleSystem particleSystem = this.particle;
		this.quickmove = true;
		ParticleSystem.MainModule main = particleSystem.main;
	}

	// Token: 0x06002026 RID: 8230 RVA: 0x000AA3B8 File Offset: 0x000A85B8
	[Token(Token = "0x6002026")]
	[Address(RVA = "0x5A7380", Offset = "0x5A5980", VA = "0x1805A7380")]
	private void QuickMoveOver()
	{
		this.quickmove = false;
		ParticleSystem.MainModule main = this.particle.main;
	}

	// Token: 0x06002027 RID: 8231 RVA: 0x000AA3E0 File Offset: 0x000A85E0
	[Token(Token = "0x6002027")]
	[Address(RVA = "0x5A7180", Offset = "0x5A5780", VA = "0x1805A7180")]
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

	// Token: 0x06002028 RID: 8232 RVA: 0x000AA438 File Offset: 0x000A8638
	[Token(Token = "0x6002028")]
	[Address(RVA = "0x5A6F50", Offset = "0x5A5550", VA = "0x1805A6F50")]
	public EternalZombie_b()
	{
	}

	// Token: 0x04001137 RID: 4407
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001137")]
	public bool quickmove;

	// Token: 0x04001138 RID: 4408
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001138")]
	private ParticleSystem particle;
}
