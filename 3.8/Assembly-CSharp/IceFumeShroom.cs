using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000512 RID: 1298
[Token(Token = "0x2000512")]
public class IceFumeShroom : FumeShroom
{
	// Token: 0x06001835 RID: 6197 RVA: 0x00083710 File Offset: 0x00081910
	[Token(Token = "0x6001835")]
	[Address(RVA = "0x4CEBA0", Offset = "0x4CD1A0", VA = "0x1804CEBA0", Slot = "74")]
	protected override void Attack(Zombie zombie)
	{
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(attackDamage, this, (DamageType)((uint)3), thePlantType, num != 0UL);
		int num2 = 0;
		zombie.AddfreezeLevel(5, num2);
	}

	// Token: 0x06001836 RID: 6198 RVA: 0x00083748 File Offset: 0x00081948
	[Token(Token = "0x6001836")]
	[Address(RVA = "0x4CEC10", Offset = "0x4CD210", VA = "0x1804CEC10", Slot = "69")]
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

	// Token: 0x06001837 RID: 6199 RVA: 0x000837E0 File Offset: 0x000819E0
	[Token(Token = "0x6001837")]
	[Address(RVA = "0x4C7F30", Offset = "0x4C6530", VA = "0x1804C7F30")]
	public IceFumeShroom()
	{
		this.range = 7f;
		base..ctor();
	}
}
