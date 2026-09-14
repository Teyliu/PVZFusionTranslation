using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UIElements;

// Token: 0x0200044B RID: 1099
[Token(Token = "0x200044B")]
public class SquashNut : WallNut
{
	// Token: 0x06001442 RID: 5186 RVA: 0x00070B74 File Offset: 0x0006ED74
	[Token(Token = "0x6001442")]
	[Address(RVA = "0x4C03C0", Offset = "0x4BE9C0", VA = "0x1804C03C0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		List<Collider2D> list = Enumerable.ToList<Collider2D>(base.GetComponents<Collider2D>());
		this.collider2Ds = list;
	}

	// Token: 0x06001443 RID: 5187 RVA: 0x00070B9C File Offset: 0x0006ED9C
	[Token(Token = "0x6001443")]
	[Address(RVA = "0x4C0440", Offset = "0x4BEA40", VA = "0x1804C0440", Slot = "17")]
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

	// Token: 0x06001444 RID: 5188 RVA: 0x00070C18 File Offset: 0x0006EE18
	[Token(Token = "0x6001444")]
	[Address(RVA = "0x4C0600", Offset = "0x4BEC00", VA = "0x1804C0600")]
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

	// Token: 0x06001445 RID: 5189 RVA: 0x00070C78 File Offset: 0x0006EE78
	[Token(Token = "0x6001445")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "68")]
	protected override void OnTriggerStay2D(Collider2D collision)
	{
	}

	// Token: 0x06001446 RID: 5190 RVA: 0x00070C88 File Offset: 0x0006EE88
	[Token(Token = "0x6001446")]
	[Address(RVA = "0x4C0790", Offset = "0x4BED90", VA = "0x1804C0790")]
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

	// Token: 0x06001447 RID: 5191 RVA: 0x00070CB8 File Offset: 0x0006EEB8
	[Token(Token = "0x6001447")]
	[Address(RVA = "0x4C00C0", Offset = "0x4BE6C0", VA = "0x1804C00C0")]
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

	// Token: 0x06001448 RID: 5192 RVA: 0x00070D28 File Offset: 0x0006EF28
	[Token(Token = "0x6001448")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public SquashNut()
	{
	}

	// Token: 0x04000D13 RID: 3347
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D13")]
	private List<Collider2D> collider2Ds;
}
