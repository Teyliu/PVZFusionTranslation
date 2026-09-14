using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006F9 RID: 1785
[Token(Token = "0x20006F9")]
public class SandJackson : ZombieJackson
{
	// Token: 0x06002317 RID: 8983 RVA: 0x000B7880 File Offset: 0x000B5A80
	[Token(Token = "0x6002317")]
	[Address(RVA = "0x5D0BD0", Offset = "0x5CF1D0", VA = "0x1805D0BD0", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06002318 RID: 8984 RVA: 0x000B78C0 File Offset: 0x000B5AC0
	[Token(Token = "0x6002318")]
	[Address(RVA = "0x5D0C70", Offset = "0x5CF270", VA = "0x1805D0C70", Slot = "76")]
	protected override ZombieType GetZombieType()
	{
		return ListExtensions.GetRandom<ZombieType>(this.zombies);
	}

	// Token: 0x06002319 RID: 8985 RVA: 0x000B78D8 File Offset: 0x000B5AD8
	[Token(Token = "0x6002319")]
	[Address(RVA = "0x5D0CE0", Offset = "0x5CF2E0", VA = "0x1805D0CE0", Slot = "77")]
	protected override GameObject SetZombie(float x, int row)
	{
		CreateZombie instance = CreateZombie.Instance;
		ZombieType zombieType = this.GetZombieType();
		CreateZombie instance2 = CreateZombie.Instance;
		ZombieType zombieType2 = this.GetZombieType();
		Action<Zombie> onDeath = this.onDeath;
		Zombie zombie;
		zombie.onDeath = onDeath;
		long num = this.theHealth;
		num -= onDeath;
		zombie.theHealth = num;
		long num2 = this.theMaxHealth;
		num2 -= onDeath;
		Transform axis = zombie.axis;
		zombie.theMaxHealth = num2;
		ParticleManager instance3 = ParticleManager.Instance;
		Vector3 vector;
		float z = vector.z;
		return zombie.gameObject;
	}

	// Token: 0x0600231A RID: 8986 RVA: 0x000B7970 File Offset: 0x000B5B70
	[Token(Token = "0x600231A")]
	[Address(RVA = "0x5D0F50", Offset = "0x5CF550", VA = "0x1805D0F50")]
	public SandJackson()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		this.zombies = list;
		base..ctor();
	}

	// Token: 0x040011F6 RID: 4598
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x40011F6")]
	public List<ZombieType> zombies;
}
