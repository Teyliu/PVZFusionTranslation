using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000957 RID: 2391
[Token(Token = "0x2000957")]
public class AoeDamage : MonoBehaviour
{
	// Token: 0x0600316E RID: 12654 RVA: 0x0010498C File Offset: 0x00102B8C
	[Token(Token = "0x600316E")]
	[Address(RVA = "0x6E34E0", Offset = "0x6E1AE0", VA = "0x1806E34E0")]
	private static bool Bomb(Vector3 position, float range, LayerMask layerMask, int theRow, int theDamage, int rangeRow, PlantType fromType)
	{
		int mask = layerMask.m_Mask;
		int num = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && AoeDamage.InLandAoeRange((ZombieStatus)num))
			{
				num -= theRow;
			}
			num++;
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600316F RID: 12655 RVA: 0x001049CC File Offset: 0x00102BCC
	[Token(Token = "0x600316F")]
	[Address(RVA = "0x6E3290", Offset = "0x6E1890", VA = "0x1806E3290")]
	private static void BombPotato(Vector3 position, float range, LayerMask layerMask, int theRow, int theDamage, int rangeRow, Action<Zombie> action, PlantType fromType)
	{
		int mask = layerMask.m_Mask;
		int num = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			bool flag2;
			if (flag && flag2 && !flag2 && !flag2)
			{
				num -= theRow;
			}
			num++;
		}
	}

	// Token: 0x06003170 RID: 12656 RVA: 0x00104A10 File Offset: 0x00102C10
	[Token(Token = "0x6003170")]
	[Address(RVA = "0x6E3810", Offset = "0x6E1E10", VA = "0x1806E3810")]
	public static void SmallBombPotato(Vector3 position, float range, LayerMask layerMask, int theRow, int theDamage, PlantType fromType, [Optional] Action<Zombie> action)
	{
		float z = position.z;
	}

	// Token: 0x06003171 RID: 12657 RVA: 0x00104A28 File Offset: 0x00102C28
	[Token(Token = "0x6003171")]
	[Address(RVA = "0x6E3750", Offset = "0x6E1D50", VA = "0x1806E3750")]
	public static void MidBombPotato(Vector3 position, float range, LayerMask layerMask, int theRow, int theDamage, PlantType fromType, [Optional] Action<Zombie> action)
	{
		float z = position.z;
	}

	// Token: 0x06003172 RID: 12658 RVA: 0x00104A40 File Offset: 0x00102C40
	[Token(Token = "0x6003172")]
	[Address(RVA = "0x6E3870", Offset = "0x6E1E70", VA = "0x1806E3870")]
	public static void SmallBomb(Vector3 position, float range, LayerMask layerMask, int theRow, int theDamage, PlantType fromType)
	{
		float z = position.z;
	}

	// Token: 0x06003173 RID: 12659 RVA: 0x00104A58 File Offset: 0x00102C58
	[Token(Token = "0x6003173")]
	[Address(RVA = "0x6E37B0", Offset = "0x6E1DB0", VA = "0x1806E37B0")]
	public static bool MidBomb(Vector3 position, float range, LayerMask layerMask, int theRow, int theDamage, PlantType fromType)
	{
		float z = position.z;
		bool flag;
		return flag;
	}

	// Token: 0x06003174 RID: 12660 RVA: 0x00104A70 File Offset: 0x00102C70
	[Token(Token = "0x6003174")]
	[Address(RVA = "0x6E3240", Offset = "0x6E1840", VA = "0x1806E3240")]
	public static void BigBomb(Vector3 position, float range, LayerMask layerMask, int theRow, int theDamage, PlantType fromType)
	{
		float z = position.z;
	}

	// Token: 0x06003175 RID: 12661 RVA: 0x00104A88 File Offset: 0x00102C88
	[Token(Token = "0x6003175")]
	[Address(RVA = "0x6E36D0", Offset = "0x6E1CD0", VA = "0x1806E36D0")]
	public static bool InLandAoeRange(ZombieStatus theZombieStatus)
	{
		if ((theZombieStatus <= ZombieStatus.Snokle_inWater || theZombieStatus != ZombieStatus.Bungi_awake) && theZombieStatus != ZombieStatus.Dying)
		{
			return theZombieStatus != ZombieStatus.Snokle_inWater;
		}
		int num = 0;
		num = (int)(num + theZombieStatus);
		return false;
	}

	// Token: 0x06003176 RID: 12662 RVA: 0x00104AB4 File Offset: 0x00102CB4
	[Token(Token = "0x6003176")]
	[Address(RVA = "0x6E3800", Offset = "0x6E1E00", VA = "0x1806E3800")]
	public static bool PotatoAoeRange(ZombieStatus theZombieStatus)
	{
		return theZombieStatus != ZombieStatus.Flying && theZombieStatus != ZombieStatus.Imp_fly;
	}

	// Token: 0x06003177 RID: 12663 RVA: 0x00104AD4 File Offset: 0x00102CD4
	[Token(Token = "0x6003177")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public AoeDamage()
	{
	}
}
