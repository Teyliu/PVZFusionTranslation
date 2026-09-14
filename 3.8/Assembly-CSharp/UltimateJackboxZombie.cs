using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006FF RID: 1791
[Token(Token = "0x20006FF")]
public class UltimateJackboxZombie : Zombie
{
	// Token: 0x060023A8 RID: 9128 RVA: 0x000BA658 File Offset: 0x000B8858
	[Token(Token = "0x60023A8")]
	[Address(RVA = "0x531BD0", Offset = "0x5301D0", VA = "0x180531BD0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 3f;
	}

	// Token: 0x060023A9 RID: 9129 RVA: 0x000BA678 File Offset: 0x000B8878
	[Token(Token = "0x60023A9")]
	[Address(RVA = "0x5824D0", Offset = "0x580AD0", VA = "0x1805824D0", Slot = "15")]
	protected override void Start()
	{
		int num = 0;
		base.Start();
		Board board = this.board;
		Lawnf.SetZombieHealth(this, (float)num);
	}

	// Token: 0x060023AA RID: 9130 RVA: 0x000BA6A4 File Offset: 0x000B88A4
	[Token(Token = "0x60023AA")]
	[Address(RVA = "0x588960", Offset = "0x586F60", VA = "0x180588960", Slot = "23")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("pop");
		int num = global::UnityEngine.Random.Range(0, 3);
		this.attributeCount = num;
		this.attributeCountDown = 8f;
	}

	// Token: 0x060023AB RID: 9131 RVA: 0x000BA6E4 File Offset: 0x000B88E4
	[Token(Token = "0x60023AB")]
	[Address(RVA = "0x588450", Offset = "0x586A50", VA = "0x180588450")]
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

	// Token: 0x060023AC RID: 9132 RVA: 0x000BA878 File Offset: 0x000B8A78
	[Token(Token = "0x60023AC")]
	[Address(RVA = "0x5889D0", Offset = "0x586FD0", VA = "0x1805889D0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num19;
		do
		{
			int num = this.theHealth;
			num -= theDamage;
			this.theHealth = num;
			num -= theDamage;
			bool flag;
			if (flag)
			{
				List<Transform> changeSprites = this.changeSprites;
				bool flag2;
				if (flag2)
				{
					int num2 = 0;
					SpriteRenderer spriteRenderer;
					spriteRenderer.enabled = num2 != 0;
					int num3 = 0;
					Transform transform;
					ulong num4;
					transform.GetChild(num3).gameObject.SetActive(num4 != 0UL);
					Transform transform2;
					uint num5;
					GameObject gameObject = transform2.GetChild((int)num5).gameObject;
					int num6 = 0;
					gameObject.SetActive(num6 != 0);
				}
				ulong num7;
				if (num7 != (ulong)0L)
				{
					goto IL_0150;
				}
			}
			List<Transform> changeSprites2 = this.changeSprites;
			bool flag3;
			if (flag3)
			{
				int num8 = 0;
				SpriteRenderer spriteRenderer2;
				spriteRenderer2.enabled = num8 != 0;
				int num9 = 0;
				Transform transform3;
				GameObject gameObject2 = transform3.GetChild(num9).gameObject;
				int num10 = 0;
				gameObject2.SetActive(num10 != 0);
				Transform transform4;
				uint num11;
				ulong num12;
				transform4.GetChild((int)num11).gameObject.SetActive(num12 != 0UL);
			}
			ulong num13;
			if (num13 != (ulong)0L)
			{
				goto IL_0180;
			}
			bool flag4;
			if (flag4)
			{
				SpriteRenderer spriteRenderer3;
				ulong num14;
				spriteRenderer3.enabled = num14 != 0UL;
				int num15 = 0;
				Transform transform5;
				GameObject gameObject3 = transform5.GetChild(num15).gameObject;
				int num16 = 0;
				gameObject3.SetActive(num16 != 0);
				Transform transform6;
				uint num17;
				GameObject gameObject4 = transform6.GetChild((int)num17).gameObject;
				int num18 = 0;
				gameObject4.SetActive(num18 != 0);
			}
		}
		while (num19 != (ulong)0L);
		return;
		IL_0150:
		throw new NullReferenceException();
		IL_0180:
		throw new NullReferenceException();
	}

	// Token: 0x060023AD RID: 9133 RVA: 0x000BAA38 File Offset: 0x000B8C38
	[Token(Token = "0x60023AD")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060023AE RID: 9134 RVA: 0x000BAA48 File Offset: 0x000B8C48
	[Token(Token = "0x60023AE")]
	[Address(RVA = "0x538170", Offset = "0x536770", VA = "0x180538170")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x060023AF RID: 9135 RVA: 0x000BAA68 File Offset: 0x000B8C68
	[Token(Token = "0x60023AF")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x060023B0 RID: 9136 RVA: 0x000BAA78 File Offset: 0x000B8C78
	[Token(Token = "0x60023B0")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x060023B1 RID: 9137 RVA: 0x000BAA88 File Offset: 0x000B8C88
	[Token(Token = "0x60023B1")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x060023B2 RID: 9138 RVA: 0x000BAA98 File Offset: 0x000B8C98
	[Token(Token = "0x60023B2")]
	[Address(RVA = "0x533270", Offset = "0x531870", VA = "0x180533270", Slot = "27")]
	public override void Die(int reason = 0)
	{
		bool flag = reason != 1;
		base.Die(flag ? 1 : 0);
	}

	// Token: 0x060023B3 RID: 9139 RVA: 0x000BAAB8 File Offset: 0x000B8CB8
	[Token(Token = "0x60023B3")]
	[Address(RVA = "0x588FD0", Offset = "0x5875D0", VA = "0x180588FD0", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		Transform axis = this.axis;
	}

	// Token: 0x060023B4 RID: 9140 RVA: 0x000BAAD8 File Offset: 0x000B8CD8
	[Token(Token = "0x60023B4")]
	[Address(RVA = "0x546F50", Offset = "0x545550", VA = "0x180546F50", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		int num;
		if (num > 5000)
		{
		}
		return num;
	}

	// Token: 0x060023B5 RID: 9141 RVA: 0x000BAAF4 File Offset: 0x000B8CF4
	[Token(Token = "0x60023B5")]
	[Address(RVA = "0x546D50", Offset = "0x545350", VA = "0x180546D50", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x060023B6 RID: 9142 RVA: 0x000BAB04 File Offset: 0x000B8D04
	[Token(Token = "0x60023B6")]
	[Address(RVA = "0x589060", Offset = "0x587660", VA = "0x180589060")]
	public UltimateJackboxZombie()
	{
	}
}
