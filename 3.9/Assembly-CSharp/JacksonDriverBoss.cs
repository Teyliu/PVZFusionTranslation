using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006C5 RID: 1733
[Token(Token = "0x20006C5")]
public class JacksonDriverBoss : Zombie
{
	// Token: 0x0600216B RID: 8555 RVA: 0x000B051C File Offset: 0x000AE71C
	[Token(Token = "0x600216B")]
	[Address(RVA = "0x5B88F0", Offset = "0x5B6EF0", VA = "0x1805B88F0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 10f;
	}

	// Token: 0x0600216C RID: 8556 RVA: 0x000B053C File Offset: 0x000AE73C
	[Token(Token = "0x600216C")]
	[Address(RVA = "0x5B9060", Offset = "0x5B7660", VA = "0x1805B9060", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		GameAPP.PlaySound(69, 0.5f, 1f);
	}

	// Token: 0x0600216D RID: 8557 RVA: 0x000B0560 File Offset: 0x000AE760
	[Token(Token = "0x600216D")]
	[Address(RVA = "0x5B88B0", Offset = "0x5B6EB0", VA = "0x1805B88B0", Slot = "24")]
	protected override void AttributeEvent()
	{
		int num = 0;
		this.SetMindControl(num);
		this.attributeCountDown = 5f;
	}

	// Token: 0x0600216E RID: 8558 RVA: 0x000B0584 File Offset: 0x000AE784
	[Token(Token = "0x600216E")]
	[Address(RVA = "0x5B8CA0", Offset = "0x5B72A0", VA = "0x1805B8CA0", Slot = "23")]
	protected override void OnFixedUpdate()
	{
		base.OnFixedUpdate();
		if (base.Column > 5)
		{
			int column = base.Column;
			this.towards = (Towards)((ulong)0L);
			Transform transform = base.transform;
			return;
		}
		this.towards = (Towards)((ulong)1L);
		Transform transform2 = base.transform;
		throw new NullReferenceException();
	}

	// Token: 0x0600216F RID: 8559 RVA: 0x000B05D4 File Offset: 0x000AE7D4
	[Token(Token = "0x600216F")]
	[Address(RVA = "0x5B8D60", Offset = "0x5B7360", VA = "0x1805B8D60")]
	private void OnTriggerStay2D(Collider2D collision)
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
		return;
		Block_1:
		int theZombieRow2 = this.theZombieRow;
	}

	// Token: 0x06002170 RID: 8560 RVA: 0x000B0610 File Offset: 0x000AE810
	[Token(Token = "0x6002170")]
	[Address(RVA = "0x589F50", Offset = "0x588550", VA = "0x180589F50", Slot = "28")]
	public override void Die(int reason = 0)
	{
		bool flag = reason != 1;
		base.Die(flag ? 1 : 0);
	}

	// Token: 0x06002171 RID: 8561 RVA: 0x000B0630 File Offset: 0x000AE830
	[Token(Token = "0x6002171")]
	[Address(RVA = "0x5B8A80", Offset = "0x5B7080", VA = "0x1805B8A80", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		int num = 0;
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		Vector3 vector;
		float z = vector.z;
		int theZombieRow = this.theZombieRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)36), num, theZombieRow, num3 != 0UL, (float)num2);
	}

	// Token: 0x06002172 RID: 8562 RVA: 0x000B068C File Offset: 0x000AE88C
	[Token(Token = "0x6002172")]
	[Address(RVA = "0x5B90D0", Offset = "0x5B76D0", VA = "0x1805B90D0", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		bool flag;
		if (flag)
		{
		}
	}

	// Token: 0x06002173 RID: 8563 RVA: 0x000B06A0 File Offset: 0x000AE8A0
	[Token(Token = "0x6002173")]
	[Address(RVA = "0x5B8910", Offset = "0x5B6F10", VA = "0x1805B8910", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num2;
		do
		{
			List<Transform> changeSprites = this.changeSprites;
			bool flag;
			if (flag)
			{
				int num = 0;
				GameObject gameObject;
				global::Lawnf.ChangeSprite((float)0, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06002174 RID: 8564 RVA: 0x000B06D8 File Offset: 0x000AE8D8
	[Token(Token = "0x6002174")]
	[Address(RVA = "0x5A9160", Offset = "0x5A7760", VA = "0x1805A9160", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		long num;
		return num;
	}

	// Token: 0x06002175 RID: 8565 RVA: 0x000B06EC File Offset: 0x000AE8EC
	[Token(Token = "0x6002175")]
	[Address(RVA = "0x5A9020", Offset = "0x5A7620", VA = "0x1805A9020", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06002176 RID: 8566 RVA: 0x000B06FC File Offset: 0x000AE8FC
	[Token(Token = "0x6002176")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06002177 RID: 8567 RVA: 0x000B070C File Offset: 0x000AE90C
	[Token(Token = "0x6002177")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002178 RID: 8568 RVA: 0x000B071C File Offset: 0x000AE91C
	[Token(Token = "0x6002178")]
	[Address(RVA = "0x5B8C00", Offset = "0x5B7200", VA = "0x1805B8C00", Slot = "75")]
	public override void KillByCaltrop()
	{
		long num = this.theMaxHealth;
		num = num.MultiplyPercent(0.01f);
		int num2 = num.ToInt();
	}

	// Token: 0x06002179 RID: 8569 RVA: 0x000B0744 File Offset: 0x000AE944
	[Token(Token = "0x6002179")]
	[Address(RVA = "0x5B8FC0", Offset = "0x5B75C0", VA = "0x1805B8FC0", Slot = "54")]
	public override void SetPoison(float time = 10f)
	{
		long num = this.theHealth;
		num = num.MultiplyPercent(0.01f);
		int num2 = num.ToInt();
	}

	// Token: 0x0600217A RID: 8570 RVA: 0x000B076C File Offset: 0x000AE96C
	[Token(Token = "0x600217A")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "55")]
	public override void AddPoisonLevel()
	{
	}

	// Token: 0x0600217B RID: 8571 RVA: 0x000B077C File Offset: 0x000AE97C
	[Token(Token = "0x600217B")]
	[Address(RVA = "0x5B8E80", Offset = "0x5B7480", VA = "0x1805B8E80", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool fromFreeze = false)
	{
		long num = this.theHealth;
		num = num.MultiplyPercent(0.01f);
		int num2 = num.ToInt();
	}

	// Token: 0x0600217C RID: 8572 RVA: 0x000B07A4 File Offset: 0x000AE9A4
	[Token(Token = "0x600217C")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x0600217D RID: 8573 RVA: 0x000B07B4 File Offset: 0x000AE9B4
	[Token(Token = "0x600217D")]
	[Address(RVA = "0x5B8F20", Offset = "0x5B7520", VA = "0x1805B8F20", Slot = "51")]
	public override void SetJalaed()
	{
		long num = this.theHealth;
		num = num.MultiplyPercent(0.04f);
		int num2 = num.ToInt();
	}

	// Token: 0x0600217E RID: 8574 RVA: 0x000B07DC File Offset: 0x000AE9DC
	[Token(Token = "0x600217E")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x0600217F RID: 8575 RVA: 0x000B07EC File Offset: 0x000AE9EC
	[Token(Token = "0x600217F")]
	[Address(RVA = "0x5B9140", Offset = "0x5B7740", VA = "0x1805B9140")]
	public JacksonDriverBoss()
	{
	}
}
