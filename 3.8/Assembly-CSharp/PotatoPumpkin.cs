using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000402 RID: 1026
[Token(Token = "0x2000402")]
public class PotatoPumpkin : Pumpkin
{
	// Token: 0x060012F0 RID: 4848 RVA: 0x0006AACC File Offset: 0x00068CCC
	[Token(Token = "0x60012F0")]
	[Address(RVA = "0x45D9E0", Offset = "0x45BFE0", VA = "0x18045D9E0", Slot = "29")]
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
		this.attributeCount = (int)((ulong)1L);
		uint num15;
		this.Explode((int)num15);
		num15 += num15;
		Transform transform3 = base.transform;
		int num16 = 0;
		GameObject gameObject5 = transform3.GetChild(num16).gameObject;
		int num17 = 0;
		gameObject5.SetActive(num17 != 0);
		uint num18;
		GameObject gameObject6 = base.transform.GetChild((int)num18).gameObject;
		int num19 = 0;
		gameObject6.SetActive(num19 != 0);
		uint num20;
		ulong num21;
		base.transform.GetChild((int)num20).gameObject.SetActive(num21 != 0UL);
		this.attributeCount = (int)((ulong)2L);
		uint num22;
		this.Explode((int)num22);
	}

	// Token: 0x060012F1 RID: 4849 RVA: 0x0006AC40 File Offset: 0x00068E40
	[Token(Token = "0x60012F1")]
	[Address(RVA = "0x45D880", Offset = "0x45BE80", VA = "0x18045D880")]
	private void Explode(int damage)
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		PlantType thePlantType = this.thePlantType;
		Transform axis2 = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num = 0;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)8), num, 11, num3 != 0UL, (float)num2);
		GameAPP.PlaySound(47, 0.5f, 1f);
	}

	// Token: 0x060012F2 RID: 4850 RVA: 0x0006ACA4 File Offset: 0x00068EA4
	[Token(Token = "0x60012F2")]
	[Address(RVA = "0x45D870", Offset = "0x45BE70", VA = "0x18045D870", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		this.Explode(1800);
	}

	// Token: 0x060012F3 RID: 4851 RVA: 0x0006ACBC File Offset: 0x00068EBC
	[Token(Token = "0x60012F3")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public PotatoPumpkin()
	{
	}
}
