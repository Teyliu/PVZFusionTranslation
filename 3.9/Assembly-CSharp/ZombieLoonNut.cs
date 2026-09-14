using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000768 RID: 1896
[Token(Token = "0x2000768")]
public class ZombieLoonNut : MachineNutZombie
{
	// Token: 0x06002692 RID: 9874 RVA: 0x000CA384 File Offset: 0x000C8584
	[Token(Token = "0x6002692")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "76")]
	protected override void InitType()
	{
	}

	// Token: 0x06002693 RID: 9875 RVA: 0x000CA394 File Offset: 0x000C8594
	[Token(Token = "0x6002693")]
	[Address(RVA = "0x635D60", Offset = "0x634360", VA = "0x180635D60", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		long num = this.theHealth;
		num -= (long)theDamage;
		this.theHealth = num;
		Transform transform = base.transform;
		int num2 = 0;
		Transform child = transform.GetChild(num2);
		int num3 = 0;
		GameObject gameObject = child.GetChild(num3).gameObject;
		int num4 = 0;
		Lawnf.ChangeSprite((float)0, (float)num4, gameObject);
	}

	// Token: 0x06002694 RID: 9876 RVA: 0x000CA3EC File Offset: 0x000C85EC
	[Token(Token = "0x6002694")]
	[Address(RVA = "0x635DF0", Offset = "0x6343F0", VA = "0x180635DF0", Slot = "29")]
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

	// Token: 0x06002695 RID: 9877 RVA: 0x000CA448 File Offset: 0x000C8648
	[Token(Token = "0x6002695")]
	[Address(RVA = "0x635F90", Offset = "0x634590", VA = "0x180635F90", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06002696 RID: 9878 RVA: 0x000CA458 File Offset: 0x000C8658
	[Token(Token = "0x6002696")]
	[Address(RVA = "0x635FB0", Offset = "0x6345B0", VA = "0x180635FB0")]
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

	// Token: 0x06002697 RID: 9879 RVA: 0x000CA4C4 File Offset: 0x000C86C4
	[Token(Token = "0x6002697")]
	[Address(RVA = "0x5F5B70", Offset = "0x5F4170", VA = "0x1805F5B70")]
	public ZombieLoonNut()
	{
	}
}
