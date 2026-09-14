using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006D4 RID: 1748
[Token(Token = "0x20006D4")]
public class LevatationZombie : Zombie
{
	// Token: 0x060021F3 RID: 8691 RVA: 0x000B2A58 File Offset: 0x000B0C58
	[Token(Token = "0x60021F3")]
	[Address(RVA = "0x5C1000", Offset = "0x5BF600", VA = "0x1805C1000", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)10L);
		this.uniqueSpeed = 2f;
	}

	// Token: 0x060021F4 RID: 8692 RVA: 0x000B2A80 File Offset: 0x000B0C80
	[Token(Token = "0x60021F4")]
	[Address(RVA = "0x5C1920", Offset = "0x5BFF20", VA = "0x1805C1920", Slot = "22")]
	protected override void PositionUpdate()
	{
		base.PositionUpdate();
		float uniqueSpeed = this.uniqueSpeed;
		float deltaTime = Time.deltaTime;
		this.uniqueSpeed = uniqueSpeed;
		this.uniqueSpeed = -1f;
	}

	// Token: 0x060021F5 RID: 8693 RVA: 0x000B2AB8 File Offset: 0x000B0CB8
	[Token(Token = "0x60021F5")]
	[Address(RVA = "0x5C1030", Offset = "0x5BF630", VA = "0x1805C1030", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num24;
		do
		{
			long num = this.theHealth;
			num -= (long)theDamage;
			this.theHealth = num;
			num -= (long)theDamage;
			long num2 = this.theMaxHealth;
			num2 += num2;
			List<Transform> changeSprites = this.changeSprites;
			bool flag;
			if (flag)
			{
				SpriteRenderer spriteRenderer;
				ulong num3;
				spriteRenderer.enabled = num3 != 0UL;
				int num4 = 0;
				Transform transform;
				GameObject gameObject = transform.GetChild(num4).gameObject;
				int num5 = 0;
				gameObject.SetActive(num5 != 0);
				Transform transform2;
				uint num6;
				GameObject gameObject2 = transform2.GetChild((int)num6).gameObject;
				int num7 = 0;
				gameObject2.SetActive(num7 != 0);
			}
			ulong num8;
			if (num8 != (ulong)0L)
			{
				goto IL_0173;
			}
			int num9 = 0;
			int num10 = 0;
			if (global::Core.Lawnf.ValueBetween((float)0, (float)num10, (float)num9))
			{
				List<Transform> changeSprites2 = this.changeSprites;
				bool flag2;
				if (flag2)
				{
					int num11 = 0;
					SpriteRenderer spriteRenderer2;
					spriteRenderer2.enabled = num11 != 0;
					int num12 = 0;
					Transform transform3;
					ulong num13;
					transform3.GetChild(num12).gameObject.SetActive(num13 != 0UL);
					Transform transform4;
					uint num14;
					GameObject gameObject3 = transform4.GetChild((int)num14).gameObject;
					int num15 = 0;
					gameObject3.SetActive(num15 != 0);
				}
				ulong num16;
				if (num16 != (ulong)0L)
				{
					goto IL_01A3;
				}
			}
			int num17 = 0;
			float num18;
			if (num18 <= (float)num17)
			{
				break;
			}
			bool flag3;
			if (flag3)
			{
				int num19 = 0;
				SpriteRenderer spriteRenderer3;
				spriteRenderer3.enabled = num19 != 0;
				int num20 = 0;
				Transform transform5;
				GameObject gameObject4 = transform5.GetChild(num20).gameObject;
				int num21 = 0;
				gameObject4.SetActive(num21 != 0);
				Transform transform6;
				uint num22;
				ulong num23;
				transform6.GetChild((int)num22).gameObject.SetActive(num23 != 0UL);
			}
		}
		while (num24 != (ulong)0L);
		return;
		IL_0173:
		throw new NullReferenceException();
		IL_01A3:
		throw new NullReferenceException();
	}

	// Token: 0x060021F6 RID: 8694 RVA: 0x000B2C98 File Offset: 0x000B0E98
	[Token(Token = "0x60021F6")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x060021F7 RID: 8695 RVA: 0x000B2CA8 File Offset: 0x000B0EA8
	[Token(Token = "0x60021F7")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060021F8 RID: 8696 RVA: 0x000B2CB8 File Offset: 0x000B0EB8
	[Token(Token = "0x60021F8")]
	[Address(RVA = "0x5C1690", Offset = "0x5BFC90", VA = "0x1805C1690", Slot = "47")]
	public override void DestoryZombie()
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x060021F9 RID: 8697 RVA: 0x000B2CF8 File Offset: 0x000B0EF8
	[Token(Token = "0x60021F9")]
	[Address(RVA = "0x5C17A0", Offset = "0x5BFDA0", VA = "0x1805C17A0", Slot = "20")]
	protected override void OverRangeDie()
	{
		Transform axis = this.axis;
		Transform axis2 = this.axis;
		float deadLeft = this.deadLeft;
	}

	// Token: 0x060021FA RID: 8698 RVA: 0x000B2D90 File Offset: 0x000B0F90
	[Token(Token = "0x60021FA")]
	[Address(RVA = "0x5C1980", Offset = "0x5BFF80", VA = "0x1805C1980")]
	public LevatationZombie()
	{
	}
}
