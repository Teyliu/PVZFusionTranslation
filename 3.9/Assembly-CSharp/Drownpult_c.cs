using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200068C RID: 1676
[Token(Token = "0x200068C")]
public class Drownpult_c : Drownpult_b
{
	// Token: 0x06001FE5 RID: 8165 RVA: 0x000A94BC File Offset: 0x000A76BC
	[Token(Token = "0x6001FE5")]
	[Address(RVA = "0x5A51F0", Offset = "0x5A37F0", VA = "0x1805A51F0", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		base.DieEvent(reason);
		Board board = this.board;
		int num = 0;
		GameObject gameObject = Resources.Load<GameObject>("Zombies/Zombie_drown/weapon");
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		DrownProjectile drownProjectile = gameObject2.AddComponent<DrownProjectile>();
		int theZombieRow = this.theZombieRow;
		drownProjectile.theRow = theZombieRow;
		drownProjectile.free = true;
		float num2 = global::UnityEngine.Random.Range(-5f, 5f);
		float num3 = global::UnityEngine.Random.Range(3f, 5f);
		Rigidbody2D rb = drownProjectile.rb;
		drownProjectile.dy = -10f;
		num++;
	}

	// Token: 0x06001FE6 RID: 8166 RVA: 0x000A9570 File Offset: 0x000A7770
	[Token(Token = "0x6001FE6")]
	[Address(RVA = "0x5A4F40", Offset = "0x5A3540", VA = "0x1805A4F40")]
	public Drownpult_c()
	{
	}
}
