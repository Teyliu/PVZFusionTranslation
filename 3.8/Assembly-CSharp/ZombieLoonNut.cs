using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200072F RID: 1839
[Token(Token = "0x200072F")]
public class ZombieLoonNut : MachineNutZombie
{
	// Token: 0x0600256D RID: 9581 RVA: 0x000C5464 File Offset: 0x000C3664
	[Token(Token = "0x600256D")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "74")]
	protected override void InitType()
	{
	}

	// Token: 0x0600256E RID: 9582 RVA: 0x000C5474 File Offset: 0x000C3674
	[Token(Token = "0x600256E")]
	[Address(RVA = "0x5D4900", Offset = "0x5D2F00", VA = "0x1805D4900", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		int num = this.theHealth;
		num -= theDamage;
		this.theHealth = num;
		Transform transform = base.transform;
		int num2 = 0;
		Transform child = transform.GetChild(num2);
		int num3 = 0;
		GameObject gameObject = child.GetChild(num3).gameObject;
	}

	// Token: 0x0600256F RID: 9583 RVA: 0x000C54C0 File Offset: 0x000C36C0
	[Token(Token = "0x600256F")]
	[Address(RVA = "0x5D4990", Offset = "0x5D2F90", VA = "0x1805D4990", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		int num = 0;
		GameAPP.PlaySound(10, 0.5f, 1f);
		Transform axis = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		Vector3 vector;
		float z = vector.z;
		int theZombieRow = this.theZombieRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)157), num, theZombieRow, num3 != 0UL, (float)num2);
	}

	// Token: 0x06002570 RID: 9584 RVA: 0x000C551C File Offset: 0x000C371C
	[Token(Token = "0x6002570")]
	[Address(RVA = "0x5D4B30", Offset = "0x5D3130", VA = "0x1805D4B30", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06002571 RID: 9585 RVA: 0x000C552C File Offset: 0x000C372C
	[Token(Token = "0x6002571")]
	[Address(RVA = "0x5D4B50", Offset = "0x5D3150", VA = "0x1805D4B50")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		float attributeCountDown = this.attributeCountDown;
		int num = 0;
		bool flag;
		if (attributeCountDown <= (float)num && flag)
		{
			int theZombieRow = this.theZombieRow;
			bool flag2;
			if (!flag2)
			{
				int num2 = this.theZombieRow;
				int avaliableRow = base.GetAvaliableRow(num2);
				num2 = avaliableRow;
				base.ChangeRow(num2);
				this.attributeCountDown = 1f;
				GameAPP.PlaySound(avaliableRow, 0.5f, 1f);
			}
		}
	}

	// Token: 0x06002572 RID: 9586 RVA: 0x000C5598 File Offset: 0x000C3798
	[Token(Token = "0x6002572")]
	[Address(RVA = "0x57B590", Offset = "0x579B90", VA = "0x18057B590")]
	public ZombieLoonNut()
	{
	}
}
