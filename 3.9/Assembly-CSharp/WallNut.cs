using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004BC RID: 1212
[Token(Token = "0x20004BC")]
public class WallNut : Plant
{
	// Token: 0x060016B1 RID: 5809 RVA: 0x0007D18C File Offset: 0x0007B38C
	[Token(Token = "0x60016B1")]
	[Address(RVA = "0x466C80", Offset = "0x465280", VA = "0x180466C80", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x060016B2 RID: 5810 RVA: 0x0007D19C File Offset: 0x0007B39C
	[Token(Token = "0x60016B2")]
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

	// Token: 0x060016B3 RID: 5811 RVA: 0x0007D2F0 File Offset: 0x0007B4F0
	[Token(Token = "0x60016B3")]
	[Address(RVA = "0x51BC20", Offset = "0x51A220", VA = "0x18051BC20", Slot = "68")]
	protected virtual void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			this.thePlantSpeed = 0f;
		}
	}

	// Token: 0x060016B4 RID: 5812 RVA: 0x0007D31C File Offset: 0x0007B51C
	[Token(Token = "0x60016B4")]
	[Address(RVA = "0x46AC00", Offset = "0x469200", VA = "0x18046AC00", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		float theOriginSpeed = this.theOriginSpeed;
		this.thePlantSpeed = theOriginSpeed;
	}

	// Token: 0x060016B5 RID: 5813 RVA: 0x0007D340 File Offset: 0x0007B540
	[Token(Token = "0x60016B5")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public WallNut()
	{
	}
}
