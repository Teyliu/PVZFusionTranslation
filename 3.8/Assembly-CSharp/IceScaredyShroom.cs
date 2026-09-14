using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000516 RID: 1302
[Token(Token = "0x2000516")]
public class IceScaredyShroom : ScaredyShroom
{
	// Token: 0x06001840 RID: 6208 RVA: 0x00083A3C File Offset: 0x00081C3C
	[Token(Token = "0x6001840")]
	[Address(RVA = "0x4CFA20", Offset = "0x4CE020", VA = "0x1804CFA20", Slot = "69")]
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

	// Token: 0x06001841 RID: 6209 RVA: 0x00083AA4 File Offset: 0x00081CA4
	[Token(Token = "0x6001841")]
	[Address(RVA = "0x4CF5C0", Offset = "0x4CDBC0", VA = "0x1804CF5C0")]
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

	// Token: 0x06001842 RID: 6210 RVA: 0x00083B58 File Offset: 0x00081D58
	[Token(Token = "0x6001842")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public IceScaredyShroom()
	{
	}
}
