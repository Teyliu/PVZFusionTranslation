using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000548 RID: 1352
[Token(Token = "0x2000548")]
public class PortalSniper : SniperPea
{
	// Token: 0x0600191D RID: 6429 RVA: 0x00087BCC File Offset: 0x00085DCC
	[Token(Token = "0x600191D")]
	[Address(RVA = "0x4DC1C0", Offset = "0x4DA7C0", VA = "0x1804DC1C0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)6), action, num != 0);
	}

	// Token: 0x0600191E RID: 6430 RVA: 0x00087BEC File Offset: 0x00085DEC
	[Token(Token = "0x600191E")]
	[Address(RVA = "0x4DBD10", Offset = "0x4DA310", VA = "0x1804DBD10", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)6), action);
	}

	// Token: 0x0600191F RID: 6431 RVA: 0x00087C04 File Offset: 0x00085E04
	[Token(Token = "0x600191F")]
	[Address(RVA = "0x4DBDB0", Offset = "0x4DA3B0", VA = "0x1804DBDB0")]
	private void OnPlantShoot(object obj)
	{
		if (obj != 0)
		{
			PlantType thePlantType = this.thePlantType;
			int num = this.attributeCount;
			num++;
			this.attributeCount = num;
			if (num == 8)
			{
				Animator anim = this.anim;
				this.attributeCount = (int)((ulong)0L);
				anim.SetTrigger("shoot");
				this.theStatus = (PlantStatus)((ulong)25L);
			}
		}
	}

	// Token: 0x06001920 RID: 6432 RVA: 0x00087C60 File Offset: 0x00085E60
	[Token(Token = "0x6001920")]
	[Address(RVA = "0x4DBEC0", Offset = "0x4DA4C0", VA = "0x1804DBEC0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		return base.Shoot1();
	}

	// Token: 0x06001921 RID: 6433 RVA: 0x00087D4C File Offset: 0x00085F4C
	[Token(Token = "0x6001921")]
	[Address(RVA = "0x4DBBD0", Offset = "0x4DA1D0", VA = "0x1804DBBD0", Slot = "73")]
	protected override void AttackZombie(Zombie zombie, int damage, DamageType theDamageType = DamageType.Shieldless)
	{
		PlantType thePlantType = this.thePlantType;
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = this.ac.transform;
		int num = 0;
		int theZombieRow = zombie.theZombieRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)97), num, theZombieRow, num3 != 0UL, (float)num2);
		throw new NullReferenceException();
	}

	// Token: 0x06001922 RID: 6434 RVA: 0x00087D9C File Offset: 0x00085F9C
	[Token(Token = "0x6001922")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public PortalSniper()
	{
	}
}
