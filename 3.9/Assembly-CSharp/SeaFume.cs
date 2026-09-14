using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000585 RID: 1413
[Token(Token = "0x2000585")]
public class SeaFume : FumeShroom
{
	// Token: 0x06001A3E RID: 6718 RVA: 0x0008D01C File Offset: 0x0008B21C
	[Token(Token = "0x6001A3E")]
	[Address(RVA = "0x53E300", Offset = "0x53C900", VA = "0x18053E300", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.theStatus = (PlantStatus)((ulong)0L);
		this.range = 7f;
	}

	// Token: 0x06001A3F RID: 6719 RVA: 0x0008D044 File Offset: 0x0008B244
	[Token(Token = "0x6001A3F")]
	[Address(RVA = "0x53E290", Offset = "0x53C890", VA = "0x18053E290", Slot = "73")]
	protected override void Attack(Zombie zombie)
	{
		base.Attack(zombie);
		int num = 0;
		float timer = zombie.GetTimer((ZombieTimer)num);
		int num2 = 0;
		if (timer > (float)num2)
		{
		}
	}

	// Token: 0x06001A40 RID: 6720 RVA: 0x0008D070 File Offset: 0x0008B270
	[Token(Token = "0x6001A40")]
	[Address(RVA = "0x53E3A0", Offset = "0x53C9A0", VA = "0x18053E3A0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		int num = 0;
		ParticleManager instance = ParticleManager.Instance;
		int thePlantRow = this.thePlantRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)115), num, thePlantRow, num3 != 0UL, (float)num2);
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject;
		Transform transform = gameObject.transform;
		GameAPP.PlaySound(58, 0.5f, 1f);
		base.AttackZombie();
		throw new NullReferenceException();
	}

	// Token: 0x06001A41 RID: 6721 RVA: 0x0008D0E0 File Offset: 0x0008B2E0
	[Token(Token = "0x6001A41")]
	[Address(RVA = "0x53E330", Offset = "0x53C930", VA = "0x18053E330")]
	public void Eat()
	{
		this.range = 14f;
		base.AttributeCountdown = 10f;
		this.anim.SetTrigger("eat");
		this.theStatus = (PlantStatus)((ulong)25L);
	}

	// Token: 0x06001A42 RID: 6722 RVA: 0x0008D124 File Offset: 0x0008B324
	[Token(Token = "0x6001A42")]
	[Address(RVA = "0x50B0A0", Offset = "0x5096A0", VA = "0x18050B0A0")]
	public SeaFume()
	{
	}
}
