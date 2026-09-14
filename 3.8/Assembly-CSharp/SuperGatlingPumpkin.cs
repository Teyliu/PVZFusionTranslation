using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000443 RID: 1091
[Token(Token = "0x2000443")]
public class SuperGatlingPumpkin : SuperGatling
{
	// Token: 0x0600141C RID: 5148 RVA: 0x00070668 File Offset: 0x0006E868
	[Token(Token = "0x600141C")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x0600141D RID: 5149 RVA: 0x00070680 File Offset: 0x0006E880
	[Token(Token = "0x600141D")]
	[Address(RVA = "0x472570", Offset = "0x470B70", VA = "0x180472570", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x0600141E RID: 5150 RVA: 0x00070690 File Offset: 0x0006E890
	[Token(Token = "0x600141E")]
	[Address(RVA = "0x472240", Offset = "0x470840", VA = "0x180472240", Slot = "29")]
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

	// Token: 0x0600141F RID: 5151 RVA: 0x000707E4 File Offset: 0x0006E9E4
	[Token(Token = "0x600141F")]
	[Address(RVA = "0x472210", Offset = "0x470810", VA = "0x180472210", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		float theOriginSpeed = this.theOriginSpeed;
		this.thePlantSpeed = theOriginSpeed;
	}

	// Token: 0x06001420 RID: 5152 RVA: 0x00070808 File Offset: 0x0006EA08
	[Token(Token = "0x6001420")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public SuperGatlingPumpkin()
	{
	}
}
