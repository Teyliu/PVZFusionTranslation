using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000581 RID: 1409
[Token(Token = "0x2000581")]
public class ScaredyPotato : ScaredyShroom
{
	// Token: 0x06001A25 RID: 6693 RVA: 0x0008C878 File Offset: 0x0008AA78
	[Token(Token = "0x6001A25")]
	[Address(RVA = "0x53D070", Offset = "0x53B670", VA = "0x18053D070", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 20f;
		this.thePlantAttackCountDown = 0f;
	}

	// Token: 0x06001A26 RID: 6694 RVA: 0x0008C8A4 File Offset: 0x0008AAA4
	[Token(Token = "0x6001A26")]
	[Address(RVA = "0x53CC90", Offset = "0x53B290", VA = "0x18053CC90", Slot = "72")]
	protected override void GetNearZombies()
	{
		Transform axis = this.axis;
		int num = 0;
		Transform axis2 = this.axis;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (!flag || flag > true)
			{
				num++;
			}
			ulong num3;
			this.anim.SetBool("NearZombie", num3 != 0UL);
			base.ScaredEvent();
			return;
		}
		Animator anim = this.anim;
		int num4 = 0;
		anim.SetBool("NearZombie", num4 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x06001A27 RID: 6695 RVA: 0x0008C920 File Offset: 0x0008AB20
	[Token(Token = "0x6001A27")]
	[Address(RVA = "0x53CEA0", Offset = "0x53B4A0", VA = "0x18053CEA0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		GameAPP.PlaySound(57, 0.5f, 1f);
		float attributeCountdown = this.attributeCountdown;
		int num = 0;
		if (attributeCountdown <= (float)num)
		{
		}
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		base.FlashOnce();
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x06001A28 RID: 6696 RVA: 0x0008C9A0 File Offset: 0x0008ABA0
	[Token(Token = "0x6001A28")]
	[Address(RVA = "0x53CA60", Offset = "0x53B060", VA = "0x18053CA60", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		int num2 = 0;
		child.GetChild(num2).gameObject.SetActive(true);
		Transform transform2 = base.transform;
		int num3 = 0;
		GameObject gameObject = transform2.GetChild(num3).GetChild(1).gameObject;
		int num4 = 0;
		gameObject.SetActive(num4 != 0);
	}

	// Token: 0x06001A29 RID: 6697 RVA: 0x0008CA0C File Offset: 0x0008AC0C
	[Token(Token = "0x6001A29")]
	[Address(RVA = "0x53CB30", Offset = "0x53B130", VA = "0x18053CB30", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
		Transform axis2 = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num = 0;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)8), num, 11, num3 != 0UL, (float)num2);
		GameAPP.PlaySound(47, 0.5f, 1f);
	}

	// Token: 0x06001A2A RID: 6698 RVA: 0x0008CA78 File Offset: 0x0008AC78
	[Token(Token = "0x6001A2A")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public ScaredyPotato()
	{
	}
}
