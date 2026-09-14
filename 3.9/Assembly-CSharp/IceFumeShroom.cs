using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200053D RID: 1341
[Token(Token = "0x200053D")]
public class IceFumeShroom : FumeShroom
{
	// Token: 0x060018FE RID: 6398 RVA: 0x00086F60 File Offset: 0x00085160
	[Token(Token = "0x60018FE")]
	[Address(RVA = "0x52AF60", Offset = "0x529560", VA = "0x18052AF60", Slot = "73")]
	protected override void Attack(Zombie zombie)
	{
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(attackDamage, this, (DamageType)((uint)3), thePlantType, num != 0UL);
		int num2 = 0;
		zombie.AddfreezeLevel(5, num2);
	}

	// Token: 0x060018FF RID: 6399 RVA: 0x00086F98 File Offset: 0x00085198
	[Token(Token = "0x60018FF")]
	[Address(RVA = "0x52AFD0", Offset = "0x5295D0", VA = "0x18052AFD0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[30];
		Transform transform2 = this.board.transform;
		GameObject gameObject2;
		Renderer component = gameObject2.GetComponent<ParticleSystem>().GetComponent<Renderer>();
		int thePlantRow = this.thePlantRow;
		string text = string.Format("particle{0}", component);
		component.sortingLayerName = text;
		GameAPP.PlaySound(58, 0.5f, 1f);
		base.AttackZombie();
		throw new NullReferenceException();
	}

	// Token: 0x06001900 RID: 6400 RVA: 0x00087030 File Offset: 0x00085230
	[Token(Token = "0x6001900")]
	[Address(RVA = "0x523270", Offset = "0x521870", VA = "0x180523270")]
	public IceFumeShroom()
	{
		this.range = 7f;
		base..ctor();
	}
}
