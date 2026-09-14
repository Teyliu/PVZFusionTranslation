using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005BA RID: 1466
[Token(Token = "0x20005BA")]
public class SwordStarfruit : StarFruit
{
	// Token: 0x06001B13 RID: 6931 RVA: 0x00091134 File Offset: 0x0008F334
	[Token(Token = "0x6001B13")]
	[Address(RVA = "0x54C560", Offset = "0x54AB60", VA = "0x18054C560", Slot = "72")]
	protected override void SetBullet(Transform _transform, BulletMoveWay theMovingWay)
	{
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		Transform transform = bullet.transform;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		if (theMovingWay == BulletMoveWay.Left)
		{
			Transform transform2 = bullet.transform;
			int num = 0;
			int num2 = 0;
			transform2.Rotate((float)num2, (float)num, 180f);
		}
	}

	// Token: 0x06001B14 RID: 6932 RVA: 0x000911A0 File Offset: 0x0008F3A0
	[Token(Token = "0x6001B14")]
	[Address(RVA = "0x54C2E0", Offset = "0x54A8E0", VA = "0x18054C2E0")]
	private void AnimAttack()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		ulong num;
		num += num;
		PlantType thePlantType = this.thePlantType;
		bool flag;
		if (flag)
		{
			uint num2;
			GameAPP.PlaySound((int)num2, 0.5f, 1f);
			return;
		}
	}

	// Token: 0x06001B15 RID: 6933 RVA: 0x000911E8 File Offset: 0x0008F3E8
	[Token(Token = "0x6001B15")]
	[Address(RVA = "0x54C3F0", Offset = "0x54A9F0", VA = "0x18054C3F0", Slot = "43")]
	protected override GameObject SearchZombie()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (!flag || !base.SearchUniqueZombie(num))
			{
				num++;
			}
			GameObject gameObject;
			return gameObject;
		}
		GameObject gameObject2 = base.SearchZombie();
		throw new NullReferenceException();
	}

	// Token: 0x06001B16 RID: 6934 RVA: 0x0009123C File Offset: 0x0008F43C
	[Token(Token = "0x6001B16")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public SwordStarfruit()
	{
	}
}
