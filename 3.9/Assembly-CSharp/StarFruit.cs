using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200059B RID: 1435
[Token(Token = "0x200059B")]
public class StarFruit : Shooter
{
	// Token: 0x06001A9E RID: 6814 RVA: 0x0008ECCC File Offset: 0x0008CECC
	[Token(Token = "0x6001A9E")]
	[Address(RVA = "0x544DD0", Offset = "0x5433D0", VA = "0x180544DD0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot1");
		this.SetBullet(transform, (BulletMoveWay)((uint)5));
		Transform transform2 = base.transform.Find("Shoot2");
		this.SetBullet(transform2, (BulletMoveWay)((uint)5));
		Transform transform3 = base.transform.Find("Shoot3");
		this.SetBullet(transform3, (BulletMoveWay)((uint)6));
		Transform transform4 = base.transform.Find("Shoot4");
		this.SetBullet(transform4, (BulletMoveWay)((uint)5));
		Transform transform5 = base.transform.Find("Shoot5");
		this.SetBullet(transform5, (BulletMoveWay)((uint)5));
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x06001A9F RID: 6815 RVA: 0x0008ED80 File Offset: 0x0008CF80
	[Token(Token = "0x6001A9F")]
	[Address(RVA = "0x544CA0", Offset = "0x5432A0", VA = "0x180544CA0", Slot = "72")]
	protected virtual void SetBullet(Transform _transform, BulletMoveWay theMovingWay)
	{
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		Transform transform = bullet.transform;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001AA0 RID: 6816 RVA: 0x0008EDC8 File Offset: 0x0008CFC8
	[Token(Token = "0x6001AA0")]
	[Address(RVA = "0x544600", Offset = "0x542C00", VA = "0x180544600", Slot = "43")]
	protected override GameObject SearchZombie()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.zombieLayer;
		RaycastHit2D[] array;
		if (num < array.Length)
		{
			int num3 = 0;
			Collider2D collider2D;
			if (!collider2D.gameObject.TryGetComponent<Zombie>(num3) || !base.SearchUniqueZombie(num3))
			{
				num++;
			}
			GameObject gameObject;
			return gameObject;
		}
		LayerMask zombieLayer = this.zombieLayer;
		RaycastHit2D[] array2;
		if (num < array2.Length)
		{
			int num4 = 0;
			Collider2D collider2D2;
			bool flag = collider2D2.gameObject.TryGetComponent<Zombie>(num4);
			if (!flag || !base.SearchUniqueZombie(num4))
			{
				num++;
			}
		}
		LayerMask zombieLayer2 = this.zombieLayer;
		RaycastHit2D[] array3;
		if (num < array3.Length)
		{
			int num5 = 0;
			Collider2D collider2D3;
			bool flag2 = collider2D3.gameObject.TryGetComponent<Zombie>(num5);
			if (!flag2 || !base.SearchUniqueZombie(num5))
			{
				num++;
			}
		}
		LayerMask zombieLayer3 = this.zombieLayer;
		RaycastHit2D[] array4;
		if (num < array4.Length)
		{
			Collider2D collider2D4;
			bool flag3 = collider2D4.gameObject.TryGetComponent<Zombie>(num);
			if (!flag3 || !base.SearchUniqueZombie(num))
			{
				num++;
			}
		}
		LayerMask zombieLayer4 = this.zombieLayer;
		RaycastHit2D[] array5;
		if (num < array5.Length)
		{
			Collider2D collider2D5;
			if (collider2D5.gameObject.TryGetComponent<Zombie>(num))
			{
				int thePlantRow = this.thePlantRow;
				if (base.SearchUniqueZombie(num))
				{
					goto IL_0130;
				}
			}
			num++;
		}
		IL_0130:
		throw new NullReferenceException();
	}

	// Token: 0x06001AA1 RID: 6817 RVA: 0x0008EF0C File Offset: 0x0008D10C
	[Token(Token = "0x6001AA1")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public StarFruit()
	{
	}
}
