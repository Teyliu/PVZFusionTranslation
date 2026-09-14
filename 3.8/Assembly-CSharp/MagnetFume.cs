using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000535 RID: 1333
[Token(Token = "0x2000535")]
public class MagnetFume : FumeShroom
{
	// Token: 0x060018CF RID: 6351 RVA: 0x00086C54 File Offset: 0x00084E54
	[Token(Token = "0x60018CF")]
	[Address(RVA = "0x4D5930", Offset = "0x4D3F30", VA = "0x1804D5930", Slot = "74")]
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

	// Token: 0x060018D0 RID: 6352 RVA: 0x00086C88 File Offset: 0x00084E88
	[Token(Token = "0x60018D0")]
	[Address(RVA = "0x4D59A0", Offset = "0x4D3FA0", VA = "0x1804D59A0", Slot = "69")]
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

	// Token: 0x060018D1 RID: 6353 RVA: 0x00086CE0 File Offset: 0x00084EE0
	[Token(Token = "0x60018D1")]
	[Address(RVA = "0x4C7F30", Offset = "0x4C6530", VA = "0x1804C7F30")]
	public MagnetFume()
	{
		this.range = 7f;
		base..ctor();
	}
}
