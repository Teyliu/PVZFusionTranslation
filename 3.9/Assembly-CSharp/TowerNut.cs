using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000601 RID: 1537
[Token(Token = "0x2000601")]
public class TowerNut : TowerPlant
{
	// Token: 0x06001CBE RID: 7358 RVA: 0x00099398 File Offset: 0x00097598
	[Token(Token = "0x6001CBE")]
	[Address(RVA = "0x466C80", Offset = "0x465280", VA = "0x180466C80", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06001CBF RID: 7359 RVA: 0x000993A8 File Offset: 0x000975A8
	[Token(Token = "0x6001CBF")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "46")]
	protected override bool Shootable()
	{
		return false;
	}

	// Token: 0x06001CC0 RID: 7360 RVA: 0x000993B8 File Offset: 0x000975B8
	[Token(Token = "0x6001CC0")]
	[Address(RVA = "0x4C9AF0", Offset = "0x4C80F0", VA = "0x1804C9AF0", Slot = "28")]
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
		int num8 = this.thePlantMaxHealth;
		num8 += num8;
		Transform transform2 = base.transform;
		int num9 = 0;
		GameObject gameObject3 = transform2.GetChild(num9).gameObject;
		int num10 = 0;
		gameObject3.SetActive(num10 != 0);
		uint num11;
		ulong num12;
		base.transform.GetChild((int)num11).gameObject.SetActive(num12 != 0UL);
		uint num13;
		GameObject gameObject4 = base.transform.GetChild((int)num13).gameObject;
		int num14 = 0;
		gameObject4.SetActive(num14 != 0);
		num14 += num14;
		Transform transform3 = base.transform;
		int num15 = 0;
		GameObject gameObject5 = transform3.GetChild(num15).gameObject;
		int num16 = 0;
		gameObject5.SetActive(num16 != 0);
		uint num17;
		GameObject gameObject6 = base.transform.GetChild((int)num17).gameObject;
		int num18 = 0;
		gameObject6.SetActive(num18 != 0);
		uint num19;
		ulong num20;
		base.transform.GetChild((int)num19).gameObject.SetActive(num20 != 0UL);
	}

	// Token: 0x06001CC1 RID: 7361 RVA: 0x0009950C File Offset: 0x0009770C
	[Token(Token = "0x6001CC1")]
	[Address(RVA = "0x55D7F0", Offset = "0x55BDF0", VA = "0x18055D7F0", Slot = "75")]
	protected virtual void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			this.thePlantSpeed = 0f;
		}
	}

	// Token: 0x06001CC2 RID: 7362 RVA: 0x00099538 File Offset: 0x00097738
	[Token(Token = "0x6001CC2")]
	[Address(RVA = "0x46AC00", Offset = "0x469200", VA = "0x18046AC00", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		float theOriginSpeed = this.theOriginSpeed;
		this.thePlantSpeed = theOriginSpeed;
	}

	// Token: 0x06001CC3 RID: 7363 RVA: 0x0009955C File Offset: 0x0009775C
	[Token(Token = "0x6001CC3")]
	[Address(RVA = "0x55D890", Offset = "0x55BE90", VA = "0x18055D890")]
	public TowerNut()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}
}
