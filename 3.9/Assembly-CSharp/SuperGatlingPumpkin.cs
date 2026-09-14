using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000463 RID: 1123
[Token(Token = "0x2000463")]
public class SuperGatlingPumpkin : SuperGatling
{
	// Token: 0x060014AC RID: 5292 RVA: 0x00072954 File Offset: 0x00070B54
	[Token(Token = "0x60014AC")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x060014AD RID: 5293 RVA: 0x0007296C File Offset: 0x00070B6C
	[Token(Token = "0x60014AD")]
	[Address(RVA = "0x4C9E20", Offset = "0x4C8420", VA = "0x1804C9E20", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x060014AE RID: 5294 RVA: 0x0007297C File Offset: 0x00070B7C
	[Token(Token = "0x60014AE")]
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

	// Token: 0x060014AF RID: 5295 RVA: 0x00072AD0 File Offset: 0x00070CD0
	[Token(Token = "0x60014AF")]
	[Address(RVA = "0x4C9AC0", Offset = "0x4C80C0", VA = "0x1804C9AC0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		float theOriginSpeed = this.theOriginSpeed;
		this.thePlantSpeed = theOriginSpeed;
	}

	// Token: 0x060014B0 RID: 5296 RVA: 0x00072AF4 File Offset: 0x00070CF4
	[Token(Token = "0x60014B0")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public SuperGatlingPumpkin()
	{
	}
}
