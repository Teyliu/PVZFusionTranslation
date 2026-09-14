using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200011A RID: 282
[Token(Token = "0x200011A")]
public class Bullet_cabbage_doom : Bullet_cabbage
{
	// Token: 0x06000574 RID: 1396 RVA: 0x0001D958 File Offset: 0x0001BB58
	[Token(Token = "0x6000574")]
	[Address(RVA = "0x6BA480", Offset = "0x6B8A80", VA = "0x1806BA480", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int i = 0;
		uint num;
		GameAPP.PlaySound((int)num, 0.5f, 1f);
		PlantType fromType = this.fromType;
		bool flag;
		if (!flag)
		{
			ParticleManager instance = ParticleManager.Instance;
			Transform transform = base.transform;
			base.Die();
			return;
		}
		Transform transform2 = base.transform;
		GameObject gameObject;
		Transform transform3 = gameObject.transform;
		Transform transform4 = base.transform;
		LayerMask zombieLayer = this.zombieLayer;
		Collider2D[] array;
		while (i >= array.Length)
		{
		}
		bool flag2;
		bool flag3;
		if (flag2 && Lawnf.InLandStatus((ZombieStatus)i) && flag3)
		{
			PlantType fromType2 = this.fromType;
		}
		i++;
		throw new NullReferenceException();
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x0001D9F0 File Offset: 0x0001BBF0
	[Token(Token = "0x6000575")]
	[Address(RVA = "0x6BA380", Offset = "0x6B8980", VA = "0x1806BA380", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(70, 0.5f, 1f);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)27), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x0001DA48 File Offset: 0x0001BC48
	[Token(Token = "0x6000576")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_cabbage_doom()
	{
	}
}
