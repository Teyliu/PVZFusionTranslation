using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000656 RID: 1622
[Token(Token = "0x2000656")]
public class Drownpult_c : Drownpult_b
{
	// Token: 0x06001EE3 RID: 7907 RVA: 0x000A4D18 File Offset: 0x000A2F18
	[Token(Token = "0x6001EE3")]
	[Address(RVA = "0x542A90", Offset = "0x541090", VA = "0x180542A90", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[54];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		int num = 0;
		GameObject gameObject2 = Resources.Load<GameObject>("Zombies/Zombie_drown/weapon");
		Transform axis2 = this.axis;
		Vector3 vector2;
		float z2 = vector2.z;
		Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
		Transform transform2 = this.board.transform;
		GameObject gameObject3;
		DrownProjectile drownProjectile = gameObject3.AddComponent<DrownProjectile>();
		int theZombieRow = this.theZombieRow;
		drownProjectile.theRow = theZombieRow;
		drownProjectile.free = true;
		float num2 = global::UnityEngine.Random.Range(-5f, 5f);
		float num3 = global::UnityEngine.Random.Range(3f, 5f);
		Rigidbody2D rb = drownProjectile.rb;
		drownProjectile.dy = -10f;
		num++;
	}

	// Token: 0x06001EE4 RID: 7908 RVA: 0x000A4E04 File Offset: 0x000A3004
	[Token(Token = "0x6001EE4")]
	[Address(RVA = "0x5427E0", Offset = "0x540DE0", VA = "0x1805427E0")]
	public Drownpult_c()
	{
	}
}
