using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000120 RID: 288
[Token(Token = "0x2000120")]
public class Bullet_cabbage_doom : Bullet_cabbage
{
	// Token: 0x06000585 RID: 1413 RVA: 0x0001D2E4 File Offset: 0x0001B4E4
	[Token(Token = "0x6000585")]
	[Address(RVA = "0x6E5370", Offset = "0x6E3970", VA = "0x1806E5370", Slot = "22")]
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

	// Token: 0x06000586 RID: 1414 RVA: 0x0001D37C File Offset: 0x0001B57C
	[Token(Token = "0x6000586")]
	[Address(RVA = "0x6E5270", Offset = "0x6E3870", VA = "0x1806E5270", Slot = "17")]
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

	// Token: 0x06000587 RID: 1415 RVA: 0x0001D3D4 File Offset: 0x0001B5D4
	[Token(Token = "0x6000587")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_cabbage_doom()
	{
	}
}
