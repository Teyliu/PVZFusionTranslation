using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UIElements;

// Token: 0x0200042C RID: 1068
[Token(Token = "0x200042C")]
public class SquashNut : WallNut
{
	// Token: 0x060013B8 RID: 5048 RVA: 0x0006E8E4 File Offset: 0x0006CAE4
	[Token(Token = "0x60013B8")]
	[Address(RVA = "0x4693D0", Offset = "0x4679D0", VA = "0x1804693D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		List<Collider2D> list = Enumerable.ToList<Collider2D>(base.GetComponents<Collider2D>());
		this.collider2Ds = list;
	}

	// Token: 0x060013B9 RID: 5049 RVA: 0x0006E90C File Offset: 0x0006CB0C
	[Token(Token = "0x60013B9")]
	[Address(RVA = "0x469450", Offset = "0x467A50", VA = "0x180469450", Slot = "17")]
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

	// Token: 0x060013BA RID: 5050 RVA: 0x0006E988 File Offset: 0x0006CB88
	[Token(Token = "0x60013BA")]
	[Address(RVA = "0x469610", Offset = "0x467C10", VA = "0x180469610")]
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

	// Token: 0x060013BB RID: 5051 RVA: 0x0006E9E8 File Offset: 0x0006CBE8
	[Token(Token = "0x60013BB")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "69")]
	protected override void OnTriggerStay2D(Collider2D collision)
	{
	}

	// Token: 0x060013BC RID: 5052 RVA: 0x0006E9F8 File Offset: 0x0006CBF8
	[Token(Token = "0x60013BC")]
	[Address(RVA = "0x4697A0", Offset = "0x467DA0", VA = "0x1804697A0")]
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

	// Token: 0x060013BD RID: 5053 RVA: 0x0006EA28 File Offset: 0x0006CC28
	[Token(Token = "0x60013BD")]
	[Address(RVA = "0x4690D0", Offset = "0x4676D0", VA = "0x1804690D0")]
	private void AnimCrash()
	{
		int num;
		do
		{
			num = 0;
			List<Collider2D> list = this.collider2Ds;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != 0);
		int num2 = 0;
		EasingMode mode = ((EasingMode)num).m_Mode;
		Collider2D[] array;
		if (num2 < array.Length)
		{
			bool flag2;
			if (!flag2 || Lawnf.InLandStatus((ZombieStatus)num))
			{
			}
			num2++;
		}
		uint num3;
		GameAPP.PlaySound((int)num3, 0.3f, 1f);
	}

	// Token: 0x060013BE RID: 5054 RVA: 0x0006EA98 File Offset: 0x0006CC98
	[Token(Token = "0x60013BE")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public SquashNut()
	{
	}

	// Token: 0x04000C89 RID: 3209
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C89")]
	private List<Collider2D> collider2Ds;
}
