using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000562 RID: 1378
[Token(Token = "0x2000562")]
public class MagnetFume : FumeShroom
{
	// Token: 0x0600199F RID: 6559 RVA: 0x0008A918 File Offset: 0x00088B18
	[Token(Token = "0x600199F")]
	[Address(RVA = "0x536240", Offset = "0x534840", VA = "0x180536240", Slot = "73")]
	protected override void Attack(Zombie zombie)
	{
		bool flag = Lawnf.ZombieWithIron(zombie);
		int num = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
		if (flag)
		{
			num += num;
		}
	}

	// Token: 0x060019A0 RID: 6560 RVA: 0x0008A94C File Offset: 0x00088B4C
	[Token(Token = "0x60019A0")]
	[Address(RVA = "0x5362B0", Offset = "0x5348B0", VA = "0x1805362B0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject;
		Transform transform2 = gameObject.transform;
		GameAPP.PlaySound(58, 0.5f, 1f);
		base.AttackZombie();
		throw new NullReferenceException();
	}

	// Token: 0x060019A1 RID: 6561 RVA: 0x0008A9A4 File Offset: 0x00088BA4
	[Token(Token = "0x60019A1")]
	[Address(RVA = "0x50B0A0", Offset = "0x5096A0", VA = "0x18050B0A0")]
	public MagnetFume()
	{
	}
}
