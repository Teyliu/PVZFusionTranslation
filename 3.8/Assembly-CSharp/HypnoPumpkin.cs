using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003A5 RID: 933
[Token(Token = "0x20003A5")]
public class HypnoPumpkin : Pumpkin
{
	// Token: 0x06001122 RID: 4386 RVA: 0x000618C0 File Offset: 0x0005FAC0
	[Token(Token = "0x6001122")]
	[Address(RVA = "0x4013E0", Offset = "0x3FF9E0", VA = "0x1804013E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x06001123 RID: 4387 RVA: 0x000618E0 File Offset: 0x0005FAE0
	[Token(Token = "0x6001123")]
	[Address(RVA = "0x43C790", Offset = "0x43AD90", VA = "0x18043C790", Slot = "17")]
	protected override void FixedUpdate()
	{
		int num = 0;
		base.FixedUpdate();
		Zombie zombie = this.m_zombie;
		int num2 = 0;
		if (zombie != num2)
		{
			Zombie zombie2 = this.m_zombie;
			int thePlantRow = this.thePlantRow;
			if (zombie2.theZombieRow == thePlantRow)
			{
				Transform axis = zombie2.axis;
				Transform axis2 = this.axis;
				Animator anim = this.m_zombie.anim;
			}
		}
		this.m_zombie = num;
		Transform axis3 = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num3 = this.plantLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow2 = this.thePlantRow;
				Transform axis4 = this.axis;
				bool flag2;
				if (!flag2)
				{
					this.m_zombie = num;
				}
			}
			num++;
		}
	}

	// Token: 0x06001124 RID: 4388 RVA: 0x0006199C File Offset: 0x0005FB9C
	[Token(Token = "0x6001124")]
	[Address(RVA = "0x43CBE0", Offset = "0x43B1E0", VA = "0x18043CBE0", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		base.System.Collections.IEnumerator.Reset();
		this.m_zombie = (ulong)0L;
	}

	// Token: 0x06001125 RID: 4389 RVA: 0x000619B8 File Offset: 0x0005FBB8
	[Token(Token = "0x6001125")]
	[Address(RVA = "0x43D1F0", Offset = "0x43B7F0", VA = "0x18043D1F0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Zombie zombie = this.m_zombie;
		int num = 0;
		if (zombie != num)
		{
			Transform axis = this.axis;
			Transform axis2 = this.m_zombie.axis;
			Zombie zombie2 = this.m_zombie;
		}
	}

	// Token: 0x06001126 RID: 4390 RVA: 0x00061A04 File Offset: 0x0005FC04
	[Token(Token = "0x6001126")]
	[Address(RVA = "0x43D100", Offset = "0x43B700", VA = "0x18043D100", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		Zombie zombie = this.m_zombie;
		int num = 0;
		if (zombie != num)
		{
			Zombie zombie2 = this.m_zombie;
		}
	}

	// Token: 0x06001127 RID: 4391 RVA: 0x00061A34 File Offset: 0x0005FC34
	[Token(Token = "0x6001127")]
	[Address(RVA = "0x43CB10", Offset = "0x43B110", VA = "0x18043CB10", Slot = "33")]
	protected override bool Instead(int theDamage)
	{
		if (!base.Instead(theDamage))
		{
			Zombie zombie = this.m_zombie;
			int num = 0;
			bool flag = zombie != num;
			if (!flag)
			{
				return flag;
			}
			Zombie zombie2 = this.m_zombie;
		}
		return true;
	}

	// Token: 0x06001128 RID: 4392 RVA: 0x00061A74 File Offset: 0x0005FC74
	[Token(Token = "0x6001128")]
	[Address(RVA = "0x43CC20", Offset = "0x43B220", VA = "0x18043CC20", Slot = "29")]
	protected override void ReplaceSprite()
	{
		int num = this.thePlantMaxHealth;
		num += num;
		Transform transform = base.transform;
		int num2 = 0;
		ulong num3;
		transform.GetChild(num2).gameObject.SetActive(num3 != 0UL);
		uint num4;
		GameObject gameObject = base.transform.GetChild((int)num4).gameObject;
		int num5 = 0;
		gameObject.SetActive(num5 != 0);
		uint num6;
		GameObject gameObject2 = base.transform.GetChild((int)num6).gameObject;
		int num7 = 0;
		gameObject2.SetActive(num7 != 0);
		ulong num8;
		this.mushes[0].SetActive(num8 != 0UL);
		ulong num9;
		this.mushes[1].SetActive(num9 != 0UL);
		ulong num10;
		this.mushes[2].SetActive(num10 != 0UL);
		int num11 = this.thePlantMaxHealth;
		num11 += num11;
		Transform transform2 = base.transform;
		int num12 = 0;
		GameObject gameObject3 = transform2.GetChild(num12).gameObject;
		int num13 = 0;
		gameObject3.SetActive(num13 != 0);
		uint num14;
		ulong num15;
		base.transform.GetChild((int)num14).gameObject.SetActive(num15 != 0UL);
		uint num16;
		GameObject gameObject4 = base.transform.GetChild((int)num16).gameObject;
		int num17 = 0;
		gameObject4.SetActive(num17 != 0);
		GameObject gameObject5 = this.mushes[0];
		int num18 = 0;
		gameObject5.SetActive(num18 != 0);
		ulong num19;
		this.mushes[1].SetActive(num19 != 0UL);
		ulong num20;
		this.mushes[2].SetActive(num20 != 0UL);
		num20 += num20;
		Transform transform3 = base.transform;
		int num21 = 0;
		GameObject gameObject6 = transform3.GetChild(num21).gameObject;
		int num22 = 0;
		gameObject6.SetActive(num22 != 0);
		uint num23;
		GameObject gameObject7 = base.transform.GetChild((int)num23).gameObject;
		int num24 = 0;
		gameObject7.SetActive(num24 != 0);
		uint num25;
		ulong num26;
		base.transform.GetChild((int)num25).gameObject.SetActive(num26 != 0UL);
		GameObject gameObject8 = this.mushes[0];
		int num27 = 0;
		gameObject8.SetActive(num27 != 0);
		GameObject gameObject9 = this.mushes[1];
		int num28 = 0;
		gameObject9.SetActive(num28 != 0);
		ulong num29;
		this.mushes[2].SetActive(num29 != 0UL);
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x00061C88 File Offset: 0x0005FE88
	[Token(Token = "0x6001129")]
	[Address(RVA = "0x43D2E0", Offset = "0x43B8E0", VA = "0x18043D2E0")]
	public HypnoPumpkin()
	{
		GameObject[] array = new GameObject[3];
		this.mushes = array;
		base..ctor();
	}

	// Token: 0x04000BA9 RID: 2985
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BA9")]
	public GameObject[] mushes;

	// Token: 0x04000BAA RID: 2986
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000BAA")]
	[SerializeField]
	protected Zombie m_zombie;
}
