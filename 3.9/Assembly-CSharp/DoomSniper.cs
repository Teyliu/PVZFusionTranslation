using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200050D RID: 1293
[Token(Token = "0x200050D")]
public class DoomSniper : Shooter
{
	// Token: 0x06001845 RID: 6213 RVA: 0x00083EDC File Offset: 0x000820DC
	[Token(Token = "0x6001845")]
	[Address(RVA = "0x521B90", Offset = "0x520190", VA = "0x180521B90", Slot = "43")]
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
				if (num != num2)
				{
					float vision = this.vision;
					Transform shoot = this.shoot;
					if (base.SearchUniqueZombie(num))
					{
						break;
					}
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

	// Token: 0x06001846 RID: 6214 RVA: 0x00083F50 File Offset: 0x00082150
	[Token(Token = "0x6001846")]
	[Address(RVA = "0x5223E0", Offset = "0x5209E0", VA = "0x1805223E0", Slot = "45")]
	protected override void UpdateAttackCountDown()
	{
		float num = this.crazeTimer;
		int num2 = 0;
		if (num > (float)num2)
		{
			float deltaTime = Time.deltaTime;
			this.crazeTimer = num;
			float thePlantAttackCountDown = this.thePlantAttackCountDown;
			float deltaTime2 = Time.deltaTime;
			this.thePlantAttackCountDown = thePlantAttackCountDown;
			this.crazeTimer = 0f;
		}
		base.UpdateAttackCountDown();
	}

	// Token: 0x06001847 RID: 6215 RVA: 0x00083FA4 File Offset: 0x000821A4
	[Token(Token = "0x6001847")]
	[Address(RVA = "0x521DD0", Offset = "0x5203D0", VA = "0x180521DD0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		int num = 0;
		float num2 = global::UnityEngine.Random.Range(0.9f, 1.1f);
		uint num3;
		GameAPP.PlaySound((int)num3, 0.5f, num2);
		Transform shoot = this.shoot;
		Board board = this.board;
		Vector3 vector;
		float z = vector.z;
		Func<Zombie, bool> func = new Func(this.CheckZombie);
		ParticleManager instance = ParticleManager.Instance;
		Transform shoot2 = this.shoot;
		Vector3 vector2;
		float z2 = vector2.z;
		int num4 = 0;
		Zombie zombie;
		if (zombie != num4)
		{
			Collider2D col = zombie.col;
			Transform shoot3 = this.shoot;
			Vector3 vector3;
			float z3 = vector3.z;
			Transform shoot4 = this.shoot;
			Vector3 vector4;
			float z4 = vector4.z;
			LayerMask zombieLayer = this.zombieLayer;
			Particle particle;
			Transform transform = particle.transform;
			int num5 = this.attackDamage;
			Quaternion quaternion;
			bool flag;
			if (quaternion == (ulong)5L || flag)
			{
				num5 += num5;
			}
			RaycastHit2D[] array;
			if (num < array.Length)
			{
				int num6 = 0;
				Collider2D collider2D;
				if (collider2D.TryGetComponent<Zombie>(num6) && Lawnf.InLandStatus(zombie.theStatus))
				{
					int num7 = 0;
					bool flag2;
					if (!flag2)
					{
					}
					num7 += num7;
					PlantType thePlantType = this.thePlantType;
					if (!flag2)
					{
					}
				}
				num++;
			}
			this.attributeCount = num;
			BoardAction boardAction = this.board.boardAction;
			int column = zombie.Column;
			PlantType thePlantType2 = this.thePlantType;
			this.crazeTimer = 8f;
			this.craze = num;
		}
		throw new IndexOutOfRangeException();
	}

	// Token: 0x06001848 RID: 6216 RVA: 0x00084108 File Offset: 0x00082308
	[Token(Token = "0x6001848")]
	[Address(RVA = "0x521A90", Offset = "0x520090", VA = "0x180521A90")]
	private bool CheckZombie(Zombie zombie)
	{
		if (!zombie.isMindControlled)
		{
			Collider2D col = zombie.col;
			int num = 0;
			if (col != num && zombie.col.enabled)
			{
				Transform axis = zombie.axis;
				Transform shoot = this.shoot;
				return Lawnf.InLandStatus(zombie.theStatus);
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001849 RID: 6217 RVA: 0x00084164 File Offset: 0x00082364
	[Token(Token = "0x6001849")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public DoomSniper()
	{
	}

	// Token: 0x04000E67 RID: 3687
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E67")]
	private int craze;

	// Token: 0x04000E68 RID: 3688
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000E68")]
	private float crazeTimer;
}
