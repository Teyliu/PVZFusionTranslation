using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000556 RID: 1366
[Token(Token = "0x2000556")]
public class SeaFume : FumeShroom
{
	// Token: 0x06001962 RID: 6498 RVA: 0x000890AC File Offset: 0x000872AC
	[Token(Token = "0x6001962")]
	[Address(RVA = "0x4E01F0", Offset = "0x4DE7F0", VA = "0x1804E01F0", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.theStatus = (PlantStatus)((ulong)0L);
		this.range = 7f;
	}

	// Token: 0x06001963 RID: 6499 RVA: 0x000890D4 File Offset: 0x000872D4
	[Token(Token = "0x6001963")]
	[Address(RVA = "0x4E0180", Offset = "0x4DE780", VA = "0x1804E0180", Slot = "74")]
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

	// Token: 0x06001964 RID: 6500 RVA: 0x00089100 File Offset: 0x00087300
	[Token(Token = "0x6001964")]
	[Address(RVA = "0x4E0290", Offset = "0x4DE890", VA = "0x1804E0290", Slot = "69")]
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

	// Token: 0x06001965 RID: 6501 RVA: 0x00089170 File Offset: 0x00087370
	[Token(Token = "0x6001965")]
	[Address(RVA = "0x4E0220", Offset = "0x4DE820", VA = "0x1804E0220")]
	public void Eat()
	{
		this.range = 14f;
		base.AttributeCountdown = 10f;
		this.anim.SetTrigger("eat");
		this.theStatus = (PlantStatus)((ulong)25L);
	}

	// Token: 0x06001966 RID: 6502 RVA: 0x000891B4 File Offset: 0x000873B4
	[Token(Token = "0x6001966")]
	[Address(RVA = "0x49B750", Offset = "0x499D50", VA = "0x18049B750")]
	public SeaFume()
	{
	}
}
