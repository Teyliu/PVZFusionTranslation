using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003B9 RID: 953
[Token(Token = "0x20003B9")]
public class HypnoPumpkin : Pumpkin
{
	// Token: 0x0600117E RID: 4478 RVA: 0x00062F1C File Offset: 0x0006111C
	[Token(Token = "0x600117E")]
	[Address(RVA = "0x4454A0", Offset = "0x443AA0", VA = "0x1804454A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x0600117F RID: 4479 RVA: 0x00062F3C File Offset: 0x0006113C
	[Token(Token = "0x600117F")]
	[Address(RVA = "0x48FFF0", Offset = "0x48E5F0", VA = "0x18048FFF0", Slot = "17")]
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

	// Token: 0x06001180 RID: 4480 RVA: 0x00062FF8 File Offset: 0x000611F8
	[Token(Token = "0x6001180")]
	[Address(RVA = "0x490440", Offset = "0x48EA40", VA = "0x180490440", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		base..ctor();
		this.m_zombie = (ulong)0L;
	}

	// Token: 0x06001181 RID: 4481 RVA: 0x00063014 File Offset: 0x00061214
	[Token(Token = "0x6001181")]
	[Address(RVA = "0x490A50", Offset = "0x48F050", VA = "0x180490A50", Slot = "16")]
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

	// Token: 0x06001182 RID: 4482 RVA: 0x00063060 File Offset: 0x00061260
	[Token(Token = "0x6001182")]
	[Address(RVA = "0x490960", Offset = "0x48EF60", VA = "0x180490960", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		Zombie zombie = this.m_zombie;
		int num = 0;
		if (zombie != num)
		{
			Zombie zombie2 = this.m_zombie;
		}
	}

	// Token: 0x06001183 RID: 4483 RVA: 0x00063090 File Offset: 0x00061290
	[Token(Token = "0x6001183")]
	[Address(RVA = "0x490370", Offset = "0x48E970", VA = "0x180490370", Slot = "32")]
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

	// Token: 0x06001184 RID: 4484 RVA: 0x000630D0 File Offset: 0x000612D0
	[Token(Token = "0x6001184")]
	[Address(RVA = "0x490480", Offset = "0x48EA80", VA = "0x180490480", Slot = "28")]
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

	// Token: 0x06001185 RID: 4485 RVA: 0x000632E4 File Offset: 0x000614E4
	[Token(Token = "0x6001185")]
	[Address(RVA = "0x490B40", Offset = "0x48F140", VA = "0x180490B40")]
	public HypnoPumpkin()
	{
		GameObject[] array = new GameObject[3];
		this.mushes = array;
		base..ctor();
	}

	// Token: 0x04000C0F RID: 3087
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C0F")]
	public GameObject[] mushes;

	// Token: 0x04000C10 RID: 3088
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C10")]
	[SerializeField]
	protected Zombie m_zombie;
}
