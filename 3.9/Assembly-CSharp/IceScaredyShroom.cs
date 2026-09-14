using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000541 RID: 1345
[Token(Token = "0x2000541")]
public class IceScaredyShroom : ScaredyShroom
{
	// Token: 0x06001909 RID: 6409 RVA: 0x0008728C File Offset: 0x0008548C
	[Token(Token = "0x6001909")]
	[Address(RVA = "0x52BDE0", Offset = "0x52A3E0", VA = "0x18052BDE0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		GameAPP.PlaySound(68, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x0600190A RID: 6410 RVA: 0x000872F4 File Offset: 0x000854F4
	[Token(Token = "0x600190A")]
	[Address(RVA = "0x52B980", Offset = "0x529F80", VA = "0x18052B980")]
	private void AnimFreeze()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = 0;
		Vector3 vector;
		float z = vector.z;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			bool flag2;
			if (flag && flag2)
			{
				PlantType thePlantType = this.thePlantType;
			}
			num++;
		}
		if (num2 != 0)
		{
			uint num3;
			GameAPP.PlaySound((int)num3, 0.5f, 1f);
		}
		GameObject[] particlePrefab = GameAPP.particlePrefab;
		Transform axis2 = this.axis;
		GameObject gameObject = particlePrefab[24];
		Vector3 vector2;
		float z2 = vector2.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		Transform transform2 = gameObject2.transform;
		Vector3 vector3;
		float z3 = vector3.z;
		Transform transform3 = gameObject2.transform;
	}

	// Token: 0x0600190B RID: 6411 RVA: 0x000873A8 File Offset: 0x000855A8
	[Token(Token = "0x600190B")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public IceScaredyShroom()
	{
	}
}
