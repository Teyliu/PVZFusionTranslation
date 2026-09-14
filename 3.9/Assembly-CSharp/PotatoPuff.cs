using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000578 RID: 1400
[Token(Token = "0x2000578")]
public class PotatoPuff : SmallPuff
{
	// Token: 0x060019FE RID: 6654 RVA: 0x0008BCBC File Offset: 0x00089EBC
	[Token(Token = "0x60019FE")]
	[Address(RVA = "0x539F40", Offset = "0x538540", VA = "0x180539F40", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f) * 20f;
		base.AttributeCountdown = num;
	}

	// Token: 0x060019FF RID: 6655 RVA: 0x0008BCEC File Offset: 0x00089EEC
	[Token(Token = "0x60019FF")]
	[Address(RVA = "0x539DC0", Offset = "0x5383C0", VA = "0x180539DC0", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		CreatePlant instance = CreatePlant.Instance;
		int num = 0;
		Plant plant;
		if (!(plant != num))
		{
			float num2 = global::UnityEngine.Random.Range(0.95f, 1.05f) * 20f;
			base.AttributeCountdown = num2;
			return;
		}
		int num3 = 0;
		base.AttributeCountdown = (float)num3;
		Transform transform = base.transform;
		int num4 = 0;
		Transform child = transform.GetChild(num4);
		int num5 = 0;
		GameObject gameObject = child.GetChild(num5).gameObject;
		int num6 = 0;
		gameObject.SetActive(num6 != 0);
	}

	// Token: 0x06001A00 RID: 6656 RVA: 0x0008BD7C File Offset: 0x00089F7C
	[Token(Token = "0x6001A00")]
	[Address(RVA = "0x53A0F0", Offset = "0x5386F0", VA = "0x18053A0F0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound(57, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001A01 RID: 6657 RVA: 0x0008BDE4 File Offset: 0x00089FE4
	[Token(Token = "0x6001A01")]
	[Address(RVA = "0x539F90", Offset = "0x538590", VA = "0x180539F90", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
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

	// Token: 0x06001A02 RID: 6658 RVA: 0x0008BE48 File Offset: 0x0008A048
	[Token(Token = "0x6001A02")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public PotatoPuff()
	{
	}
}
