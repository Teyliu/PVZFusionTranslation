using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000610 RID: 1552
[Token(Token = "0x2000610")]
public class Tower_squashNut : TowerNut
{
	// Token: 0x06001D24 RID: 7460 RVA: 0x0009B090 File Offset: 0x00099290
	[Token(Token = "0x6001D24")]
	[Address(RVA = "0x57A2B0", Offset = "0x5788B0", VA = "0x18057A2B0", Slot = "73")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float basicDamage = this.basicDamage;
		this.basicDamage = basicDamage;
		base.UpdateText();
	}

	// Token: 0x06001D25 RID: 7461 RVA: 0x0009B0B4 File Offset: 0x000992B4
	[Token(Token = "0x6001D25")]
	[Address(RVA = "0x579DC0", Offset = "0x5783C0", VA = "0x180579DC0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		List<Collider2D> list = Enumerable.ToList<Collider2D>(base.GetComponents<Collider2D>());
		this.collider2Ds = list;
	}

	// Token: 0x06001D26 RID: 7462 RVA: 0x0009B0DC File Offset: 0x000992DC
	[Token(Token = "0x6001D26")]
	[Address(RVA = "0x579E40", Offset = "0x578440", VA = "0x180579E40", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.Active)
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
					int thePlantRow = this.thePlantRow;
					if (Lawnf.InLandStatus((ZombieStatus)num))
					{
						goto IL_0048;
					}
				}
				num++;
				IL_0048:
				Animator anim = this.anim;
				this.theStatus = (PlantStatus)((ulong)32L);
				anim.SetTrigger("jump");
			}
		}
	}

	// Token: 0x06001D27 RID: 7463 RVA: 0x0009B158 File Offset: 0x00099358
	[Token(Token = "0x6001D27")]
	[Address(RVA = "0x57A000", Offset = "0x578600", VA = "0x18057A000")]
	private void SearchZombieUpdate()
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
				int thePlantRow = this.thePlantRow;
				if (Lawnf.InLandStatus((ZombieStatus)num))
				{
					goto IL_0039;
				}
			}
			num++;
			IL_0039:
			this.anim.SetTrigger("jump");
		}
	}

	// Token: 0x06001D28 RID: 7464 RVA: 0x0009B1B8 File Offset: 0x000993B8
	[Token(Token = "0x6001D28")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "75")]
	protected override void OnTriggerStay2D(Collider2D collision)
	{
	}

	// Token: 0x06001D29 RID: 7465 RVA: 0x0009B1C8 File Offset: 0x000993C8
	[Token(Token = "0x6001D29")]
	[Address(RVA = "0x57A190", Offset = "0x578790", VA = "0x18057A190")]
	private void StartJump()
	{
		ulong num;
		do
		{
			List<Collider2D> list = this.collider2Ds;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06001D2A RID: 7466 RVA: 0x0009B1F8 File Offset: 0x000993F8
	[Token(Token = "0x6001D2A")]
	[Address(RVA = "0x5796C0", Offset = "0x577CC0", VA = "0x1805796C0")]
	private void AnimCrash()
	{
		ulong num9;
		do
		{
			int num = 0;
			List<Collider2D> list = this.collider2Ds;
			bool flag;
			if (flag)
			{
			}
			ulong num2;
			if (num2 != (ulong)0L)
			{
				goto IL_00AA;
			}
			List<Zombie> list2 = new List();
			LayerMask layerMask = (int)num2;
			int num3 = 0;
			int num4 = 0;
			Collider2D[] array;
			bool flag2;
			if (num4 < array.Length)
			{
				if (!flag2 || Lawnf.InLandStatus((ZombieStatus)num))
				{
				}
				num3++;
			}
			if (flag2)
			{
				bool flag3;
				if (flag3)
				{
				}
				ulong num5;
				if (num5 != (ulong)0L)
				{
					goto IL_00AA;
				}
				int num6 = 0;
				int num7;
				num7 -= num6;
			}
			bool flag4;
			if (flag4)
			{
			}
			ulong num8;
			if (num8 != (ulong)0L)
			{
				goto IL_00B0;
			}
			bool flag5;
			if (flag5)
			{
			}
		}
		while (num9 != (ulong)0L);
		uint num10;
		GameAPP.PlaySound((int)num10, 0.3f, 1f);
		return;
		IL_00AA:
		throw new NullReferenceException();
		IL_00B0:
		throw new NullReferenceException();
	}

	// Token: 0x06001D2B RID: 7467 RVA: 0x0009B2BC File Offset: 0x000994BC
	[Token(Token = "0x6001D2B")]
	[Address(RVA = "0x578AF0", Offset = "0x5770F0", VA = "0x180578AF0")]
	public Tower_squashNut()
	{
	}

	// Token: 0x04000FCF RID: 4047
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000FCF")]
	private List<Collider2D> collider2Ds;
}
