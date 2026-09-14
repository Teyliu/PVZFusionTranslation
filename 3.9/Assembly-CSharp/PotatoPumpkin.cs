using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200041D RID: 1053
[Token(Token = "0x200041D")]
public class PotatoPumpkin : Pumpkin
{
	// Token: 0x06001366 RID: 4966 RVA: 0x0006C900 File Offset: 0x0006AB00
	[Token(Token = "0x6001366")]
	[Address(RVA = "0x4B3ED0", Offset = "0x4B24D0", VA = "0x1804B3ED0", Slot = "28")]
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

	// Token: 0x06001367 RID: 4967 RVA: 0x0006CA74 File Offset: 0x0006AC74
	[Token(Token = "0x6001367")]
	[Address(RVA = "0x4B3D70", Offset = "0x4B2370", VA = "0x1804B3D70")]
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

	// Token: 0x06001368 RID: 4968 RVA: 0x0006CAD8 File Offset: 0x0006ACD8
	[Token(Token = "0x6001368")]
	[Address(RVA = "0x4B3D60", Offset = "0x4B2360", VA = "0x1804B3D60", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		this.Explode(1800);
	}

	// Token: 0x06001369 RID: 4969 RVA: 0x0006CAF0 File Offset: 0x0006ACF0
	[Token(Token = "0x6001369")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public PotatoPumpkin()
	{
	}
}
