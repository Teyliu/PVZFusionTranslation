using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005DB RID: 1499
[Token(Token = "0x20005DB")]
public class Tower_squashNut : TowerNut
{
	// Token: 0x06001C25 RID: 7205 RVA: 0x00096490 File Offset: 0x00094690
	[Token(Token = "0x6001C25")]
	[Address(RVA = "0x512960", Offset = "0x510F60", VA = "0x180512960", Slot = "74")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float basicDamage = this.basicDamage;
		this.basicDamage = basicDamage;
		base.UpdateText();
	}

	// Token: 0x06001C26 RID: 7206 RVA: 0x000964B4 File Offset: 0x000946B4
	[Token(Token = "0x6001C26")]
	[Address(RVA = "0x512460", Offset = "0x510A60", VA = "0x180512460", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.SetSpeed(1f);
		List<Collider2D> list = Enumerable.ToList<Collider2D>(base.GetComponents<Collider2D>());
		this.collider2Ds = list;
	}

	// Token: 0x06001C27 RID: 7207 RVA: 0x000964E8 File Offset: 0x000946E8
	[Token(Token = "0x6001C27")]
	[Address(RVA = "0x5124F0", Offset = "0x510AF0", VA = "0x1805124F0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		float theOriginSpeed = this.theOriginSpeed;
		this.thePlantSpeed = theOriginSpeed;
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
						goto IL_0057;
					}
				}
				num++;
				IL_0057:
				Animator anim = this.anim;
				this.theStatus = (PlantStatus)((ulong)32L);
				anim.SetTrigger("jump");
			}
		}
	}

	// Token: 0x06001C28 RID: 7208 RVA: 0x00096574 File Offset: 0x00094774
	[Token(Token = "0x6001C28")]
	[Address(RVA = "0x5126B0", Offset = "0x510CB0", VA = "0x1805126B0")]
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

	// Token: 0x06001C29 RID: 7209 RVA: 0x000965D4 File Offset: 0x000947D4
	[Token(Token = "0x6001C29")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "76")]
	protected override void OnTriggerStay2D(Collider2D collision)
	{
	}

	// Token: 0x06001C2A RID: 7210 RVA: 0x000965E4 File Offset: 0x000947E4
	[Token(Token = "0x6001C2A")]
	[Address(RVA = "0x512840", Offset = "0x510E40", VA = "0x180512840")]
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

	// Token: 0x06001C2B RID: 7211 RVA: 0x00096614 File Offset: 0x00094814
	[Token(Token = "0x6001C2B")]
	[Address(RVA = "0x511D30", Offset = "0x510330", VA = "0x180511D30")]
	private void AnimCrash()
	{
		ulong num7;
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
				goto IL_00A0;
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
					goto IL_00A0;
				}
			}
			bool flag4;
			if (flag4)
			{
			}
			ulong num6;
			if (num6 != (ulong)0L)
			{
				goto IL_00A6;
			}
			bool flag5;
			if (flag5)
			{
			}
		}
		while (num7 != (ulong)0L);
		uint num8;
		GameAPP.PlaySound((int)num8, 0.3f, 1f);
		return;
		IL_00A0:
		throw new NullReferenceException();
		IL_00A6:
		throw new NullReferenceException();
	}

	// Token: 0x06001C2C RID: 7212 RVA: 0x000966D0 File Offset: 0x000948D0
	[Token(Token = "0x6001C2C")]
	[Address(RVA = "0x50C640", Offset = "0x50AC40", VA = "0x18050C640")]
	public Tower_squashNut()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}

	// Token: 0x04000F07 RID: 3847
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000F07")]
	private List<Collider2D> collider2Ds;
}
