using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200054A RID: 1354
[Token(Token = "0x200054A")]
public class PotatoPuff : SmallPuff
{
	// Token: 0x06001929 RID: 6441 RVA: 0x00087F14 File Offset: 0x00086114
	[Token(Token = "0x6001929")]
	[Address(RVA = "0x4DC7C0", Offset = "0x4DADC0", VA = "0x1804DC7C0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f) * 20f;
		base.AttributeCountdown = num;
	}

	// Token: 0x0600192A RID: 6442 RVA: 0x00087F44 File Offset: 0x00086144
	[Token(Token = "0x600192A")]
	[Address(RVA = "0x4DC640", Offset = "0x4DAC40", VA = "0x1804DC640", Slot = "40")]
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

	// Token: 0x0600192B RID: 6443 RVA: 0x00087FD4 File Offset: 0x000861D4
	[Token(Token = "0x600192B")]
	[Address(RVA = "0x4DC970", Offset = "0x4DAF70", VA = "0x1804DC970", Slot = "69")]
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

	// Token: 0x0600192C RID: 6444 RVA: 0x0008803C File Offset: 0x0008623C
	[Token(Token = "0x600192C")]
	[Address(RVA = "0x4DC810", Offset = "0x4DAE10", VA = "0x1804DC810", Slot = "52")]
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

	// Token: 0x0600192D RID: 6445 RVA: 0x000880A0 File Offset: 0x000862A0
	[Token(Token = "0x600192D")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public PotatoPuff()
	{
	}
}
