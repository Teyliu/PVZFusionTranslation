using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006F3 RID: 1779
[Token(Token = "0x20006F3")]
public class QingZombie : Zombie
{
	// Token: 0x060022ED RID: 8941 RVA: 0x000B69E0 File Offset: 0x000B4BE0
	[Token(Token = "0x60022ED")]
	[Address(RVA = "0x5CDC50", Offset = "0x5CC250", VA = "0x1805CDC50", Slot = "10")]
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

	// Token: 0x060022EE RID: 8942 RVA: 0x000B6A5C File Offset: 0x000B4C5C
	[Token(Token = "0x60022EE")]
	[Address(RVA = "0x5CE2F0", Offset = "0x5CC8F0", VA = "0x1805CE2F0", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)14)))
		{
			this.theAttackDamage = num;
		}
	}

	// Token: 0x060022EF RID: 8943 RVA: 0x000B6A84 File Offset: 0x000B4C84
	[Token(Token = "0x60022EF")]
	[Address(RVA = "0x5CDBB0", Offset = "0x5CC1B0", VA = "0x1805CDBB0", Slot = "24")]
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

	// Token: 0x060022F0 RID: 8944 RVA: 0x000B6AE0 File Offset: 0x000B4CE0
	[Token(Token = "0x60022F0")]
	[Address(RVA = "0x5CDF00", Offset = "0x5CC500", VA = "0x1805CDF00", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		base.DieEvent(reason);
		this.anim.SetTrigger("shake");
	}

	// Token: 0x060022F1 RID: 8945 RVA: 0x000B6B0C File Offset: 0x000B4D0C
	[Token(Token = "0x60022F1")]
	[Address(RVA = "0x5CDD30", Offset = "0x5CC330", VA = "0x1805CDD30", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x060022F2 RID: 8946 RVA: 0x000B6B4C File Offset: 0x000B4D4C
	[Token(Token = "0x60022F2")]
	[Address(RVA = "0x5CD8E0", Offset = "0x5CBEE0", VA = "0x1805CD8E0", Slot = "69")]
	protected override void AttackPlant(Plant plant)
	{
	}

	// Token: 0x060022F3 RID: 8947 RVA: 0x000B6B60 File Offset: 0x000B4D60
	[Token(Token = "0x60022F3")]
	[Address(RVA = "0x5CDFB0", Offset = "0x5CC5B0", VA = "0x1805CDFB0", Slot = "42")]
	protected override void OnTriggerExit2D(Collider2D collision)
	{
		base.OnTriggerExit2D(collision);
		if (this.quickmove)
		{
			this.QuickDamage(collision);
		}
	}

	// Token: 0x060022F4 RID: 8948 RVA: 0x000B6B88 File Offset: 0x000B4D88
	[Token(Token = "0x60022F4")]
	[Address(RVA = "0x5CDF60", Offset = "0x5CC560", VA = "0x1805CDF60", Slot = "41")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		base.OnTriggerEnter2D(collision);
		if (this.quickmove)
		{
			this.QuickDamage(collision);
		}
	}

	// Token: 0x060022F5 RID: 8949 RVA: 0x000B6BB0 File Offset: 0x000B4DB0
	[Token(Token = "0x60022F5")]
	[Address(RVA = "0x5CE000", Offset = "0x5CC600", VA = "0x1805CE000")]
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

	// Token: 0x060022F6 RID: 8950 RVA: 0x000B6C00 File Offset: 0x000B4E00
	[Token(Token = "0x60022F6")]
	[Address(RVA = "0x5CE250", Offset = "0x5CC850", VA = "0x1805CE250")]
	private void StartQuickMove()
	{
		GameAPP.PlaySound(42, 0.3f, 1.6f);
		ParticleSystem particleSystem = this.particle;
		this.quickmove = true;
		ParticleSystem.MainModule main = particleSystem.main;
	}

	// Token: 0x060022F7 RID: 8951 RVA: 0x000B6C3C File Offset: 0x000B4E3C
	[Token(Token = "0x60022F7")]
	[Address(RVA = "0x5A7380", Offset = "0x5A5980", VA = "0x1805A7380")]
	private void QuickMoveOver()
	{
		this.quickmove = false;
		ParticleSystem.MainModule main = this.particle.main;
	}

	// Token: 0x060022F8 RID: 8952 RVA: 0x000B6C64 File Offset: 0x000B4E64
	[Token(Token = "0x60022F8")]
	[Address(RVA = "0x5CDDD0", Offset = "0x5CC3D0", VA = "0x1805CDDD0", Slot = "47")]
	public override void DestoryZombie()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameAPP.PlaySound(40, 0.5f, 1f);
		global::UnityEngine.Object.Destroy(base.gameObject);
		this.AttackPlants();
	}

	// Token: 0x060022F9 RID: 8953 RVA: 0x000B6CAC File Offset: 0x000B4EAC
	[Token(Token = "0x60022F9")]
	[Address(RVA = "0x5CD930", Offset = "0x5CBF30", VA = "0x1805CD930")]
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

	// Token: 0x060022FA RID: 8954 RVA: 0x000B6D0C File Offset: 0x000B4F0C
	[Token(Token = "0x60022FA")]
	[Address(RVA = "0x5CE330", Offset = "0x5CC930", VA = "0x1805CE330")]
	public QingZombie()
	{
	}

	// Token: 0x040011ED RID: 4589
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40011ED")]
	public bool quickmove;

	// Token: 0x040011EE RID: 4590
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40011EE")]
	private ParticleSystem particle;
}
