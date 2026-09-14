using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000993 RID: 2451
[Token(Token = "0x2000993")]
public class AoeDamage : MonoBehaviour
{
	// Token: 0x060032A1 RID: 12961 RVA: 0x001096EC File Offset: 0x001078EC
	[Token(Token = "0x60032A1")]
	[Address(RVA = "0x7487F0", Offset = "0x746DF0", VA = "0x1807487F0")]
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

	// Token: 0x060032A2 RID: 12962 RVA: 0x0010972C File Offset: 0x0010792C
	[Token(Token = "0x60032A2")]
	[Address(RVA = "0x7485A0", Offset = "0x746BA0", VA = "0x1807485A0")]
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

	// Token: 0x060032A3 RID: 12963 RVA: 0x00109770 File Offset: 0x00107970
	[Token(Token = "0x60032A3")]
	[Address(RVA = "0x748B20", Offset = "0x747120", VA = "0x180748B20")]
	public static void SmallBombPotato(Vector3 position, float range, LayerMask layerMask, int theRow, int theDamage, PlantType fromType, [Optional] Action<Zombie> action)
	{
		float z = position.z;
	}

	// Token: 0x060032A4 RID: 12964 RVA: 0x00109788 File Offset: 0x00107988
	[Token(Token = "0x60032A4")]
	[Address(RVA = "0x748A60", Offset = "0x747060", VA = "0x180748A60")]
	public static void MidBombPotato(Vector3 position, float range, LayerMask layerMask, int theRow, int theDamage, PlantType fromType, [Optional] Action<Zombie> action)
	{
		float z = position.z;
	}

	// Token: 0x060032A5 RID: 12965 RVA: 0x001097A0 File Offset: 0x001079A0
	[Token(Token = "0x60032A5")]
	[Address(RVA = "0x748B80", Offset = "0x747180", VA = "0x180748B80")]
	public static void SmallBomb(Vector3 position, float range, LayerMask layerMask, int theRow, int theDamage, PlantType fromType)
	{
		float z = position.z;
	}

	// Token: 0x060032A6 RID: 12966 RVA: 0x001097B8 File Offset: 0x001079B8
	[Token(Token = "0x60032A6")]
	[Address(RVA = "0x748AC0", Offset = "0x7470C0", VA = "0x180748AC0")]
	public static bool MidBomb(Vector3 position, float range, LayerMask layerMask, int theRow, int theDamage, PlantType fromType)
	{
		float z = position.z;
		bool flag;
		return flag;
	}

	// Token: 0x060032A7 RID: 12967 RVA: 0x001097D0 File Offset: 0x001079D0
	[Token(Token = "0x60032A7")]
	[Address(RVA = "0x748550", Offset = "0x746B50", VA = "0x180748550")]
	public static void BigBomb(Vector3 position, float range, LayerMask layerMask, int theRow, int theDamage, PlantType fromType)
	{
		float z = position.z;
	}

	// Token: 0x060032A8 RID: 12968 RVA: 0x001097E8 File Offset: 0x001079E8
	[Token(Token = "0x60032A8")]
	[Address(RVA = "0x7489E0", Offset = "0x746FE0", VA = "0x1807489E0")]
	public static bool InLandAoeRange(ZombieStatus theZombieStatus)
	{
		while ((theZombieStatus > ZombieStatus.Snokle_inWater && theZombieStatus == ZombieStatus.Bungi_awake) || theZombieStatus == ZombieStatus.Dying)
		{
			if (theZombieStatus != ZombieStatus.Snokle_inWater)
			{
			}
			if (theZombieStatus != ZombieStatus.Snokle_inWater)
			{
			}
			if (theZombieStatus != ZombieStatus.Snokle_inWater)
			{
			}
			if (theZombieStatus != ZombieStatus.Snokle_inWater)
			{
			}
			if (theZombieStatus != ZombieStatus.Snokle_inWater)
			{
			}
			if (theZombieStatus != ZombieStatus.Snokle_inWater)
			{
			}
			if (theZombieStatus != ZombieStatus.Snokle_inWater)
			{
			}
			if (theZombieStatus != ZombieStatus.Snokle_inWater)
			{
			}
			if (theZombieStatus != ZombieStatus.Snokle_inWater)
			{
				return false;
			}
		}
		return theZombieStatus != ZombieStatus.Snokle_inWater;
	}

	// Token: 0x060032A9 RID: 12969 RVA: 0x00109834 File Offset: 0x00107A34
	[Token(Token = "0x60032A9")]
	[Address(RVA = "0x748B10", Offset = "0x747110", VA = "0x180748B10")]
	public static bool PotatoAoeRange(ZombieStatus theZombieStatus)
	{
		return theZombieStatus != ZombieStatus.Flying && theZombieStatus != ZombieStatus.Imp_fly;
	}

	// Token: 0x060032AA RID: 12970 RVA: 0x00109854 File Offset: 0x00107A54
	[Token(Token = "0x60032AA")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public AoeDamage()
	{
	}
}
