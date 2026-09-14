using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003A0 RID: 928
[Token(Token = "0x20003A0")]
public class FumePumpkin : Pumpkin
{
	// Token: 0x06001110 RID: 4368 RVA: 0x00060F04 File Offset: 0x0005F104
	[Token(Token = "0x6001110")]
	[Address(RVA = "0x489B60", Offset = "0x488160", VA = "0x180489B60")]
	private void AnimPreShoot()
	{
		GameAPP.PlaySound(58, 0.5f, 1f);
		Transform shoot = this.shoot;
		ParticleManager instance = ParticleManager.Instance;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		int num2 = 0;
		ulong num3;
		Transform transform = instance.SetParticle((ParticleType)((uint)130), num, 11, num3 != 0UL, (float)num2).transform;
		Transform shoot2 = this.shoot;
		ParticleManager instance2 = ParticleManager.Instance;
		int num4 = 0;
		Vector3 vector2;
		float z2 = vector2.z;
		ulong num5;
		Transform transform2 = instance2.SetParticle((ParticleType)((uint)130), num4, 11, num5 != 0UL, (float)num2).transform;
	}

	// Token: 0x06001111 RID: 4369 RVA: 0x00060F94 File Offset: 0x0005F194
	[Token(Token = "0x6001111")]
	[Address(RVA = "0x489DB0", Offset = "0x4883B0", VA = "0x180489DB0")]
	private void AnimShoot()
	{
		Board board = this.board;
		int num = 0;
		int size = board.zombieArray._size;
		int num2 = size - 1;
		if (size > 0)
		{
			Zombie zombie = this.board.zombieArray[num2];
			int num3 = 0;
			if (zombie != num3)
			{
				int column = zombie.Column;
				if (base.SearchUniqueZombie(zombie))
				{
					PlantType thePlantType = this.thePlantType;
				}
			}
			if (num != 0)
			{
				uint num4;
				GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num4), 0.5f, 1f);
			}
		}
	}

	// Token: 0x06001112 RID: 4370 RVA: 0x00061020 File Offset: 0x0005F220
	[Token(Token = "0x6001112")]
	[Address(RVA = "0x48A160", Offset = "0x488760", VA = "0x18048A160", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
		}
	}

	// Token: 0x06001113 RID: 4371 RVA: 0x0006103C File Offset: 0x0005F23C
	[Token(Token = "0x6001113")]
	[Address(RVA = "0x489F80", Offset = "0x488580", VA = "0x180489F80", Slot = "43")]
	protected override GameObject SearchZombie()
	{
		for (;;)
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			ulong num3;
			if (flag)
			{
				int num2 = 0;
				if (num != num2 && base.SearchUniqueZombie(num))
				{
					break;
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_3;
			}
		}
		GameObject gameObject;
		return gameObject;
		Block_3:
		throw new NullReferenceException();
	}

	// Token: 0x06001114 RID: 4372 RVA: 0x00061090 File Offset: 0x0005F290
	[Token(Token = "0x6001114")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public FumePumpkin()
	{
	}
}
