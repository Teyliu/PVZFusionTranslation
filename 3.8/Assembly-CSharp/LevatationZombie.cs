using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200069D RID: 1693
[Token(Token = "0x200069D")]
public class LevatationZombie : Zombie
{
	// Token: 0x060020DC RID: 8412 RVA: 0x000ADDD8 File Offset: 0x000ABFD8
	[Token(Token = "0x60020DC")]
	[Address(RVA = "0x55E2A0", Offset = "0x55C8A0", VA = "0x18055E2A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)10L);
		this.uniqueSpeed = 2f;
	}

	// Token: 0x060020DD RID: 8413 RVA: 0x000ADE00 File Offset: 0x000AC000
	[Token(Token = "0x60020DD")]
	[Address(RVA = "0x55EBA0", Offset = "0x55D1A0", VA = "0x18055EBA0", Slot = "21")]
	protected override void PositionUpdate()
	{
		base.PositionUpdate();
		float uniqueSpeed = this.uniqueSpeed;
		float deltaTime = Time.deltaTime;
		this.uniqueSpeed = uniqueSpeed;
		this.uniqueSpeed = -1f;
	}

	// Token: 0x060020DE RID: 8414 RVA: 0x000ADE38 File Offset: 0x000AC038
	[Token(Token = "0x60020DE")]
	[Address(RVA = "0x55E2D0", Offset = "0x55C8D0", VA = "0x18055E2D0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num20;
		do
		{
			int num = this.theHealth;
			num -= theDamage;
			this.theHealth = num;
			int num2 = this.theMaxHealth;
			num2 += num2;
			num -= theDamage;
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
				goto IL_015C;
			}
			bool flag2;
			if (flag2)
			{
				List<Transform> changeSprites2 = this.changeSprites;
				bool flag3;
				if (flag3)
				{
					int num9 = 0;
					SpriteRenderer spriteRenderer2;
					spriteRenderer2.enabled = num9 != 0;
					int num10 = 0;
					Transform transform3;
					ulong num11;
					transform3.GetChild(num10).gameObject.SetActive(num11 != 0UL);
					Transform transform4;
					uint num12;
					GameObject gameObject3 = transform4.GetChild((int)num12).gameObject;
					int num13 = 0;
					gameObject3.SetActive(num13 != 0);
				}
				ulong num14;
				if (num14 != (ulong)0L)
				{
					goto IL_018C;
				}
			}
			bool flag4;
			if (flag4)
			{
				int num15 = 0;
				SpriteRenderer spriteRenderer3;
				spriteRenderer3.enabled = num15 != 0;
				int num16 = 0;
				Transform transform5;
				GameObject gameObject4 = transform5.GetChild(num16).gameObject;
				int num17 = 0;
				gameObject4.SetActive(num17 != 0);
				Transform transform6;
				uint num18;
				ulong num19;
				transform6.GetChild((int)num18).gameObject.SetActive(num19 != 0UL);
			}
		}
		while (num20 != (ulong)0L);
		return;
		IL_015C:
		throw new NullReferenceException();
		IL_018C:
		throw new NullReferenceException();
	}

	// Token: 0x060020DF RID: 8415 RVA: 0x000AE004 File Offset: 0x000AC204
	[Token(Token = "0x60020DF")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x060020E0 RID: 8416 RVA: 0x000AE014 File Offset: 0x000AC214
	[Token(Token = "0x60020E0")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060020E1 RID: 8417 RVA: 0x000AE024 File Offset: 0x000AC224
	[Token(Token = "0x60020E1")]
	[Address(RVA = "0x55E910", Offset = "0x55CF10", VA = "0x18055E910", Slot = "45")]
	public override void DestoryZombie()
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x060020E2 RID: 8418 RVA: 0x000AE064 File Offset: 0x000AC264
	[Token(Token = "0x60020E2")]
	[Address(RVA = "0x55EA20", Offset = "0x55D020", VA = "0x18055EA20", Slot = "19")]
	protected override void OverRangeDie()
	{
		Transform axis = this.axis;
		Transform axis2 = this.axis;
		float deadLeft = this.deadLeft;
	}

	// Token: 0x060020E3 RID: 8419 RVA: 0x000AE0FC File Offset: 0x000AC2FC
	[Token(Token = "0x60020E3")]
	[Address(RVA = "0x55EC00", Offset = "0x55D200", VA = "0x18055EC00")]
	public LevatationZombie()
	{
	}
}
