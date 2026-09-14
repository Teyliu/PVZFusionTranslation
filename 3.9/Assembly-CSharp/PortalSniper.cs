using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000576 RID: 1398
[Token(Token = "0x2000576")]
public class PortalSniper : SniperPea
{
	// Token: 0x060019F2 RID: 6642 RVA: 0x0008B974 File Offset: 0x00089B74
	[Token(Token = "0x60019F2")]
	[Address(RVA = "0x539940", Offset = "0x537F40", VA = "0x180539940", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)6), action, num != 0);
	}

	// Token: 0x060019F3 RID: 6643 RVA: 0x0008B994 File Offset: 0x00089B94
	[Token(Token = "0x60019F3")]
	[Address(RVA = "0x539490", Offset = "0x537A90", VA = "0x180539490", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)6), action);
	}

	// Token: 0x060019F4 RID: 6644 RVA: 0x0008B9AC File Offset: 0x00089BAC
	[Token(Token = "0x60019F4")]
	[Address(RVA = "0x539530", Offset = "0x537B30", VA = "0x180539530")]
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

	// Token: 0x060019F5 RID: 6645 RVA: 0x0008BA08 File Offset: 0x00089C08
	[Token(Token = "0x60019F5")]
	[Address(RVA = "0x539640", Offset = "0x537C40", VA = "0x180539640", Slot = "68")]
	protected override Bullet Shoot1()
	{
		return base.Shoot1();
	}

	// Token: 0x060019F6 RID: 6646 RVA: 0x0008BAF4 File Offset: 0x00089CF4
	[Token(Token = "0x60019F6")]
	[Address(RVA = "0x539350", Offset = "0x537950", VA = "0x180539350", Slot = "72")]
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

	// Token: 0x060019F7 RID: 6647 RVA: 0x0008BB44 File Offset: 0x00089D44
	[Token(Token = "0x60019F7")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public PortalSniper()
	{
	}
}
