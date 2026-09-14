using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000737 RID: 1847
[Token(Token = "0x2000737")]
public class UltimateJackboxZombie : Zombie
{
	// Token: 0x060024C3 RID: 9411 RVA: 0x000BF24C File Offset: 0x000BD44C
	[Token(Token = "0x60024C3")]
	[Address(RVA = "0x588720", Offset = "0x586D20", VA = "0x180588720", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 3f;
	}

	// Token: 0x060024C4 RID: 9412 RVA: 0x000BF26C File Offset: 0x000BD46C
	[Token(Token = "0x60024C4")]
	[Address(RVA = "0x5FD9F0", Offset = "0x5FBFF0", VA = "0x1805FD9F0", Slot = "16")]
	protected override void Start()
	{
		int num = 0;
		base.Start();
		Board board = this.board;
		global::Lawnf.SetZombieHealth(this, (float)num);
	}

	// Token: 0x060024C5 RID: 9413 RVA: 0x000BF298 File Offset: 0x000BD498
	[Token(Token = "0x60024C5")]
	[Address(RVA = "0x601730", Offset = "0x5FFD30", VA = "0x180601730", Slot = "24")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("pop");
		int num = global::UnityEngine.Random.Range(0, 3);
		this.attributeCount = num;
		this.attributeCountDown = 8f;
	}

	// Token: 0x060024C6 RID: 9414 RVA: 0x000BF2D8 File Offset: 0x000BD4D8
	[Token(Token = "0x60024C6")]
	[Address(RVA = "0x601220", Offset = "0x5FF820", VA = "0x180601220")]
	private void AnimPop()
	{
		int attributeCount = this.attributeCount;
		if (attributeCount != 0)
		{
			if (attributeCount != 0)
			{
				if (attributeCount != 1)
				{
					return;
				}
				Board board = this.board;
				int num = 0;
				if (num >= board.rowNum)
				{
					return;
				}
				Transform axis = this.axis;
				Transform axis2 = this.axis;
				Mouse instance = Mouse.Instance;
				Board board2 = this.board;
				num++;
				while (board2 != 0)
				{
				}
			}
			int columnNum = this.board.columnNum;
			Board board3 = this.board;
			int num2 = 0;
			int num3 = columnNum - 1;
			if (num3 >= board3.columnNum)
			{
				return;
			}
			float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(num3);
			Board board4 = this.board;
			if (num2 < board4.rowNum)
			{
				float landY = Mouse.Instance.GetLandY(boxXFromColumn, num2);
				CreateZombie instance2 = CreateZombie.Instance;
				int num4 = 0;
				Zombie zombie;
				if (zombie != num4)
				{
					this.board.SetHealthInTravel(zombie);
				}
				num2++;
			}
			num3++;
			while (board4 != 0)
			{
			}
		}
		int columnNum2 = this.board.columnNum;
		Board board5 = this.board;
		int num5 = 0;
		int num6 = columnNum2 - 1;
		if (num6 < board5.columnNum)
		{
			float boxXFromColumn2 = Mouse.Instance.GetBoxXFromColumn(num6);
			Board board6 = this.board;
			if (num5 < board6.rowNum)
			{
				float landY2 = Mouse.Instance.GetLandY(boxXFromColumn2, num5);
				CreateZombie instance3 = CreateZombie.Instance;
				int num7 = 0;
				Zombie zombie2;
				if (zombie2 != num7)
				{
					this.board.SetHealthInTravel(zombie2);
				}
				num5++;
			}
			num6++;
		}
	}

	// Token: 0x060024C7 RID: 9415 RVA: 0x000BF46C File Offset: 0x000BD66C
	[Token(Token = "0x60024C7")]
	[Address(RVA = "0x6017A0", Offset = "0x5FFDA0", VA = "0x1806017A0", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num23;
		do
		{
			long num = this.theHealth;
			num -= (long)theDamage;
			this.theHealth = num;
			int num2 = 0;
			num -= (long)theDamage;
			int num3 = 0;
			if (global::Core.Lawnf.ValueBetween((float)0, (float)num3, (float)num2))
			{
				List<Transform> changeSprites = this.changeSprites;
				bool flag;
				if (flag)
				{
					int num4 = 0;
					SpriteRenderer spriteRenderer;
					spriteRenderer.enabled = num4 != 0;
					int num5 = 0;
					Transform transform;
					ulong num6;
					transform.GetChild(num5).gameObject.SetActive(num6 != 0UL);
					Transform transform2;
					uint num7;
					GameObject gameObject = transform2.GetChild((int)num7).gameObject;
					int num8 = 0;
					gameObject.SetActive(num8 != 0);
				}
				ulong num9;
				if (num9 != (ulong)0L)
				{
					goto IL_0166;
				}
			}
			int num10 = 0;
			float num11;
			if (num11 > (float)num10)
			{
				List<Transform> changeSprites2 = this.changeSprites;
				bool flag2;
				if (flag2)
				{
					int num12 = 0;
					SpriteRenderer spriteRenderer2;
					spriteRenderer2.enabled = num12 != 0;
					int num13 = 0;
					Transform transform3;
					GameObject gameObject2 = transform3.GetChild(num13).gameObject;
					int num14 = 0;
					gameObject2.SetActive(num14 != 0);
					Transform transform4;
					uint num15;
					ulong num16;
					transform4.GetChild((int)num15).gameObject.SetActive(num16 != 0UL);
				}
				ulong num17;
				if (num17 != (ulong)0L)
				{
					goto IL_0196;
				}
			}
			bool flag3;
			if (flag3)
			{
				SpriteRenderer spriteRenderer3;
				ulong num18;
				spriteRenderer3.enabled = num18 != 0UL;
				int num19 = 0;
				Transform transform5;
				GameObject gameObject3 = transform5.GetChild(num19).gameObject;
				int num20 = 0;
				gameObject3.SetActive(num20 != 0);
				Transform transform6;
				uint num21;
				GameObject gameObject4 = transform6.GetChild((int)num21).gameObject;
				int num22 = 0;
				gameObject4.SetActive(num22 != 0);
			}
		}
		while (num23 != (ulong)0L);
		return;
		IL_0166:
		throw new NullReferenceException();
		IL_0196:
		throw new NullReferenceException();
	}

	// Token: 0x060024C8 RID: 9416 RVA: 0x000BF640 File Offset: 0x000BD840
	[Token(Token = "0x60024C8")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060024C9 RID: 9417 RVA: 0x000BF650 File Offset: 0x000BD850
	[Token(Token = "0x60024C9")]
	[Address(RVA = "0x58EE50", Offset = "0x58D450", VA = "0x18058EE50")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x060024CA RID: 9418 RVA: 0x000BF670 File Offset: 0x000BD870
	[Token(Token = "0x60024CA")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x060024CB RID: 9419 RVA: 0x000BF680 File Offset: 0x000BD880
	[Token(Token = "0x60024CB")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x060024CC RID: 9420 RVA: 0x000BF690 File Offset: 0x000BD890
	[Token(Token = "0x60024CC")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x060024CD RID: 9421 RVA: 0x000BF6A0 File Offset: 0x000BD8A0
	[Token(Token = "0x60024CD")]
	[Address(RVA = "0x589F50", Offset = "0x588550", VA = "0x180589F50", Slot = "28")]
	public override void Die(int reason = 0)
	{
		bool flag = reason != 1;
		base.Die(flag ? 1 : 0);
	}

	// Token: 0x060024CE RID: 9422 RVA: 0x000BF6C0 File Offset: 0x000BD8C0
	[Token(Token = "0x60024CE")]
	[Address(RVA = "0x601DC0", Offset = "0x6003C0", VA = "0x180601DC0", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		this.SetMindControl(reason);
		Transform axis = this.axis;
	}

	// Token: 0x060024CF RID: 9423 RVA: 0x000BF6E4 File Offset: 0x000BD8E4
	[Token(Token = "0x60024CF")]
	[Address(RVA = "0x5A9160", Offset = "0x5A7760", VA = "0x1805A9160", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		long num;
		return num;
	}

	// Token: 0x060024D0 RID: 9424 RVA: 0x000BF6F8 File Offset: 0x000BD8F8
	[Token(Token = "0x60024D0")]
	[Address(RVA = "0x5A9020", Offset = "0x5A7620", VA = "0x1805A9020", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x060024D1 RID: 9425 RVA: 0x000BF708 File Offset: 0x000BD908
	[Token(Token = "0x60024D1")]
	[Address(RVA = "0x601E50", Offset = "0x600450", VA = "0x180601E50")]
	public UltimateJackboxZombie()
	{
	}
}
