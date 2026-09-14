using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000589 RID: 1417
[Token(Token = "0x2000589")]
public class SwordStarfruit : StarFruit
{
	// Token: 0x06001A2D RID: 6701 RVA: 0x0008CDAC File Offset: 0x0008AFAC
	[Token(Token = "0x6001A2D")]
	[Address(RVA = "0x4EC6F0", Offset = "0x4EACF0", VA = "0x1804EC6F0", Slot = "73")]
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

	// Token: 0x06001A2E RID: 6702 RVA: 0x0008CE18 File Offset: 0x0008B018
	[Token(Token = "0x6001A2E")]
	[Address(RVA = "0x4EC470", Offset = "0x4EAA70", VA = "0x1804EC470")]
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

	// Token: 0x06001A2F RID: 6703 RVA: 0x0008CE60 File Offset: 0x0008B060
	[Token(Token = "0x6001A2F")]
	[Address(RVA = "0x4EC580", Offset = "0x4EAB80", VA = "0x1804EC580", Slot = "44")]
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

	// Token: 0x06001A30 RID: 6704 RVA: 0x0008CEB4 File Offset: 0x0008B0B4
	[Token(Token = "0x6001A30")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SwordStarfruit()
	{
	}
}
