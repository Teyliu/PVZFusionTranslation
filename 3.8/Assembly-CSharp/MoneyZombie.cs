using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006A3 RID: 1699
[Token(Token = "0x20006A3")]
public class MoneyZombie : Zombie
{
	// Token: 0x0600210B RID: 8459 RVA: 0x000AECD4 File Offset: 0x000ACED4
	[Token(Token = "0x600210B")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x0600210C RID: 8460 RVA: 0x000AECE4 File Offset: 0x000ACEE4
	[Token(Token = "0x600210C")]
	[Address(RVA = "0x561500", Offset = "0x55FB00", VA = "0x180561500", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		this.flashTime = 0.3f;
	}

	// Token: 0x0600210D RID: 8461 RVA: 0x000AECFC File Offset: 0x000ACEFC
	[Token(Token = "0x600210D")]
	[Address(RVA = "0x561530", Offset = "0x55FB30", VA = "0x180561530", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (this.existTime > 15f)
		{
			this.beforeDying = true;
		}
	}

	// Token: 0x0600210E RID: 8462 RVA: 0x000AED24 File Offset: 0x000ACF24
	[Token(Token = "0x600210E")]
	[Address(RVA = "0x561440", Offset = "0x55FA40", VA = "0x180561440", Slot = "27")]
	public override void Die(int reason = 0)
	{
		base.Die(2);
	}

	// Token: 0x0600210F RID: 8463 RVA: 0x000AED38 File Offset: 0x000ACF38
	[Token(Token = "0x600210F")]
	[Address(RVA = "0x561450", Offset = "0x55FA50", VA = "0x180561450", Slot = "21")]
	protected override void PositionUpdate()
	{
		base.PositionUpdate();
		Transform axis = this.axis;
		float plantMaxVisionX = this.board.plantMaxVisionX;
		Transform axis2 = this.axis;
	}

	// Token: 0x06002110 RID: 8464 RVA: 0x000AED70 File Offset: 0x000ACF70
	[Token(Token = "0x6002110")]
	[Address(RVA = "0x561150", Offset = "0x55F750", VA = "0x180561150", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		Transform axis = this.axis;
		int num = 0;
		Transform axis2 = this.axis;
		CreateItem instance = CreateItem.Instance;
		int num2 = 0;
		int num3 = 0;
		Vector3 vector;
		GameObject gameObject = instance.SetCoin(num3, num2, 36, num, vector, num != 0);
		Transform axis3 = this.axis;
		CreateItem instance2 = CreateItem.Instance;
		int num4 = 0;
		int num5 = 0;
		Vector3 vector2;
		GameObject gameObject2 = instance2.SetCoin(num5, num4, 36, num, vector2, num != 0);
		Transform axis4 = this.axis;
		CreateItem instance3 = CreateItem.Instance;
		int num6 = 0;
		int num7 = 0;
		Vector3 vector3;
		GameObject gameObject3 = instance3.SetCoin(num7, num6, 36, num, vector3, num != 0);
		GameAPP.PlaySound(117, 0.5f, 1f);
	}

	// Token: 0x06002111 RID: 8465 RVA: 0x000AEE18 File Offset: 0x000AD018
	[Token(Token = "0x6002111")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002112 RID: 8466 RVA: 0x000AEE28 File Offset: 0x000AD028
	[Token(Token = "0x6002112")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "59")]
	public override void Garliced(bool playSound = false, bool certainRow = false)
	{
	}

	// Token: 0x06002113 RID: 8467 RVA: 0x000AEE38 File Offset: 0x000AD038
	[Token(Token = "0x6002113")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "52")]
	public override void SetPoison(float time = 10f)
	{
	}

	// Token: 0x06002114 RID: 8468 RVA: 0x000AEE48 File Offset: 0x000AD048
	[Token(Token = "0x6002114")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "58")]
	public override void EatGarlic(Plant plant, float time = 1f, bool withSound = true)
	{
	}

	// Token: 0x06002115 RID: 8469 RVA: 0x000AEE58 File Offset: 0x000AD058
	[Token(Token = "0x6002115")]
	[Address(RVA = "0x5615B0", Offset = "0x55FBB0", VA = "0x1805615B0")]
	public MoneyZombie()
	{
	}
}
