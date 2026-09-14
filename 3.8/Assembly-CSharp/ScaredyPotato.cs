using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000552 RID: 1362
[Token(Token = "0x2000552")]
public class ScaredyPotato : ScaredyShroom
{
	// Token: 0x06001949 RID: 6473 RVA: 0x0008890C File Offset: 0x00086B0C
	[Token(Token = "0x6001949")]
	[Address(RVA = "0x4DEF70", Offset = "0x4DD570", VA = "0x1804DEF70", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 20f;
		this.thePlantAttackCountDown = 0f;
	}

	// Token: 0x0600194A RID: 6474 RVA: 0x00088938 File Offset: 0x00086B38
	[Token(Token = "0x600194A")]
	[Address(RVA = "0x4DEB90", Offset = "0x4DD190", VA = "0x1804DEB90", Slot = "73")]
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

	// Token: 0x0600194B RID: 6475 RVA: 0x000889B4 File Offset: 0x00086BB4
	[Token(Token = "0x600194B")]
	[Address(RVA = "0x4DEDA0", Offset = "0x4DD3A0", VA = "0x1804DEDA0", Slot = "69")]
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

	// Token: 0x0600194C RID: 6476 RVA: 0x00088A34 File Offset: 0x00086C34
	[Token(Token = "0x600194C")]
	[Address(RVA = "0x4DE960", Offset = "0x4DCF60", VA = "0x1804DE960", Slot = "40")]
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

	// Token: 0x0600194D RID: 6477 RVA: 0x00088AA0 File Offset: 0x00086CA0
	[Token(Token = "0x600194D")]
	[Address(RVA = "0x4DEA30", Offset = "0x4DD030", VA = "0x1804DEA30", Slot = "52")]
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

	// Token: 0x0600194E RID: 6478 RVA: 0x00088B0C File Offset: 0x00086D0C
	[Token(Token = "0x600194E")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public ScaredyPotato()
	{
	}
}
