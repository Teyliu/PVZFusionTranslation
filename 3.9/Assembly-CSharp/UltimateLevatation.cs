using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200073A RID: 1850
[Token(Token = "0x200073A")]
public class UltimateLevatation : Zombie
{
	// Token: 0x060024F0 RID: 9456 RVA: 0x000BFE88 File Offset: 0x000BE088
	[Token(Token = "0x60024F0")]
	[Address(RVA = "0x6036B0", Offset = "0x601CB0", VA = "0x1806036B0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)10L);
		this.attributeCountDown = 1f;
	}

	// Token: 0x060024F1 RID: 9457 RVA: 0x000BFEB0 File Offset: 0x000BE0B0
	[Token(Token = "0x60024F1")]
	[Address(RVA = "0x6034F0", Offset = "0x601AF0", VA = "0x1806034F0", Slot = "24")]
	protected override void AttributeEvent()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int theZombieRow = this.theZombieRow;
				Team <Team>k__BackingField = this.<Team>k__BackingField;
				if (Lawnf.ThrowLandStatus((ZombieStatus)num))
				{
				}
			}
			num++;
		}
		this.attributeCountDown = 1f;
	}

	// Token: 0x060024F2 RID: 9458 RVA: 0x000BFF14 File Offset: 0x000BE114
	[Token(Token = "0x60024F2")]
	[Address(RVA = "0x6036E0", Offset = "0x601CE0", VA = "0x1806036E0", Slot = "30")]
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
				Lawnf.ChangeSprite((float)0, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060024F3 RID: 9459 RVA: 0x000BFF4C File Offset: 0x000BE14C
	[Token(Token = "0x60024F3")]
	[Address(RVA = "0x603890", Offset = "0x601E90", VA = "0x180603890", Slot = "47")]
	public override void DestoryZombie()
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x060024F4 RID: 9460 RVA: 0x000BFF8C File Offset: 0x000BE18C
	[Token(Token = "0x60024F4")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060024F5 RID: 9461 RVA: 0x000BFF9C File Offset: 0x000BE19C
	[Token(Token = "0x60024F5")]
	[Address(RVA = "0x6039A0", Offset = "0x601FA0", VA = "0x1806039A0", Slot = "18")]
	protected override void FixedUpdate()
	{
		int num = 0;
		base.FixedUpdate();
		Transform axis = this.axis;
		int num2 = this.plantLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int theZombieRow = this.theZombieRow;
			}
			num++;
		}
	}

	// Token: 0x060024F6 RID: 9462 RVA: 0x000BFFE8 File Offset: 0x000BE1E8
	[Token(Token = "0x60024F6")]
	[Address(RVA = "0x603850", Offset = "0x601E50", VA = "0x180603850")]
	private bool CheckPlant(Plant plant)
	{
		int theZombieRow = this.theZombieRow;
		if (plant.thePlantRow != theZombieRow)
		{
		}
		bool flag;
		return flag;
	}

	// Token: 0x060024F7 RID: 9463 RVA: 0x000C0010 File Offset: 0x000BE210
	[Token(Token = "0x60024F7")]
	[Address(RVA = "0x603B10", Offset = "0x602110", VA = "0x180603B10")]
	public UltimateLevatation()
	{
	}
}
