using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006BB RID: 1723
[Token(Token = "0x20006BB")]
public class QingZombie : Zombie
{
	// Token: 0x060021D3 RID: 8659 RVA: 0x000B1CD8 File Offset: 0x000AFED8
	[Token(Token = "0x60021D3")]
	[Address(RVA = "0x56A370", Offset = "0x568970", VA = "0x18056A370", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(4.4f, 7.54f);
		this.attributeCountDown = num;
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)15)))
		{
			float num2 = this.attributeCountDown * 0.25f;
			this.attributeCountDown = num2;
		}
		Transform transform = base.transform;
		int num3 = 0;
		Transform child = transform.GetChild(num3);
		int num4 = 0;
		ParticleSystem component = child.GetChild(num4).GetComponent<ParticleSystem>();
		this.particle = component;
		throw new NullReferenceException();
	}

	// Token: 0x060021D4 RID: 8660 RVA: 0x000B1D54 File Offset: 0x000AFF54
	[Token(Token = "0x60021D4")]
	[Address(RVA = "0x56AA10", Offset = "0x569010", VA = "0x18056AA10", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)14)))
		{
			this.theAttackDamage = num;
		}
	}

	// Token: 0x060021D5 RID: 8661 RVA: 0x000B1D7C File Offset: 0x000AFF7C
	[Token(Token = "0x60021D5")]
	[Address(RVA = "0x56A2D0", Offset = "0x5688D0", VA = "0x18056A2D0", Slot = "23")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("quickMove");
		float num = global::UnityEngine.Random.Range(8.8f, 15.8f);
		this.attributeCountDown = num;
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)15)))
		{
			float num2 = this.attributeCountDown * 0.25f;
			this.attributeCountDown = num2;
		}
	}

	// Token: 0x060021D6 RID: 8662 RVA: 0x000B1DD8 File Offset: 0x000AFFD8
	[Token(Token = "0x60021D6")]
	[Address(RVA = "0x56A620", Offset = "0x568C20", VA = "0x18056A620", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		base.DieEvent(reason);
		this.anim.SetTrigger("shake");
	}

	// Token: 0x060021D7 RID: 8663 RVA: 0x000B1E04 File Offset: 0x000B0004
	[Token(Token = "0x60021D7")]
	[Address(RVA = "0x56A450", Offset = "0x568A50", VA = "0x18056A450", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x060021D8 RID: 8664 RVA: 0x000B1E44 File Offset: 0x000B0044
	[Token(Token = "0x60021D8")]
	[Address(RVA = "0x56A000", Offset = "0x568600", VA = "0x18056A000", Slot = "67")]
	protected override void AttackPlant(Plant plant)
	{
	}

	// Token: 0x060021D9 RID: 8665 RVA: 0x000B1E58 File Offset: 0x000B0058
	[Token(Token = "0x60021D9")]
	[Address(RVA = "0x56A6D0", Offset = "0x568CD0", VA = "0x18056A6D0", Slot = "40")]
	protected override void OnTriggerExit2D(Collider2D collision)
	{
		base.OnTriggerExit2D(collision);
		if (this.quickmove)
		{
			this.QuickDamage(collision);
		}
	}

	// Token: 0x060021DA RID: 8666 RVA: 0x000B1E80 File Offset: 0x000B0080
	[Token(Token = "0x60021DA")]
	[Address(RVA = "0x56A680", Offset = "0x568C80", VA = "0x18056A680", Slot = "39")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		base.OnTriggerEnter2D(collision);
		if (this.quickmove)
		{
			this.QuickDamage(collision);
		}
	}

	// Token: 0x060021DB RID: 8667 RVA: 0x000B1EA8 File Offset: 0x000B00A8
	[Token(Token = "0x60021DB")]
	[Address(RVA = "0x56A720", Offset = "0x568D20", VA = "0x18056A720")]
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
				goto Block_1;
			}
		}
		int theZombieRow = this.theZombieRow;
		int num2 = 0;
		Plant plant;
		if (!(plant == num2))
		{
		}
		return;
		Block_1:
		bool isMindControlled = this.isMindControlled;
		if (this.theZombieRow <= 17)
		{
		}
	}

	// Token: 0x060021DC RID: 8668 RVA: 0x000B1EF8 File Offset: 0x000B00F8
	[Token(Token = "0x60021DC")]
	[Address(RVA = "0x56A970", Offset = "0x568F70", VA = "0x18056A970")]
	private void StartQuickMove()
	{
		GameAPP.PlaySound(42, 0.3f, 1.6f);
		ParticleSystem particleSystem = this.particle;
		this.quickmove = true;
		ParticleSystem.MainModule main = particleSystem.main;
	}

	// Token: 0x060021DD RID: 8669 RVA: 0x000B1F34 File Offset: 0x000B0134
	[Token(Token = "0x60021DD")]
	[Address(RVA = "0x544D60", Offset = "0x543360", VA = "0x180544D60")]
	private void QuickMoveOver()
	{
		this.quickmove = false;
		ParticleSystem.MainModule main = this.particle.main;
	}

	// Token: 0x060021DE RID: 8670 RVA: 0x000B1F5C File Offset: 0x000B015C
	[Token(Token = "0x60021DE")]
	[Address(RVA = "0x56A4F0", Offset = "0x568AF0", VA = "0x18056A4F0", Slot = "45")]
	public override void DestoryZombie()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameAPP.PlaySound(40, 0.5f, 1f);
		global::UnityEngine.Object.Destroy(base.gameObject);
		this.AttackPlants();
	}

	// Token: 0x060021DF RID: 8671 RVA: 0x000B1FA4 File Offset: 0x000B01A4
	[Token(Token = "0x60021DF")]
	[Address(RVA = "0x56A050", Offset = "0x568650", VA = "0x18056A050")]
	private void AttackPlants()
	{
		int num = 0;
		Transform axis = this.axis;
		int num2 = this.plantLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			LayerMask layerMask;
			int mask = layerMask.m_Mask;
			bool flag;
			if (layerMask != 0 && flag)
			{
				int num3 = 0;
				Plant plant;
				if (!(plant == num3))
				{
				}
			}
			num++;
		}
	}

	// Token: 0x060021E0 RID: 8672 RVA: 0x000B2004 File Offset: 0x000B0204
	[Token(Token = "0x60021E0")]
	[Address(RVA = "0x56AA50", Offset = "0x569050", VA = "0x18056AA50")]
	public QingZombie()
	{
	}

	// Token: 0x04001120 RID: 4384
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001120")]
	public bool quickmove;

	// Token: 0x04001121 RID: 4385
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4001121")]
	private ParticleSystem particle;
}
