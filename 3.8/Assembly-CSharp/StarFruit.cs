using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200056B RID: 1387
[Token(Token = "0x200056B")]
public class StarFruit : Shooter
{
	// Token: 0x060019BE RID: 6590 RVA: 0x0008AC18 File Offset: 0x00088E18
	[Token(Token = "0x60019BE")]
	[Address(RVA = "0x4E6960", Offset = "0x4E4F60", VA = "0x1804E6960", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot1");
		this.SetBullet(transform, (BulletMoveWay)((uint)2));
		Transform transform2 = base.transform.Find("Shoot2");
		this.SetBullet(transform2, (BulletMoveWay)((uint)2));
		Transform transform3 = base.transform.Find("Shoot3");
		this.SetBullet(transform3, (BulletMoveWay)((uint)9));
		Transform transform4 = base.transform.Find("Shoot4");
		this.SetBullet(transform4, (BulletMoveWay)((uint)2));
		Transform transform5 = base.transform.Find("Shoot5");
		this.SetBullet(transform5, (BulletMoveWay)((uint)2));
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x060019BF RID: 6591 RVA: 0x0008ACCC File Offset: 0x00088ECC
	[Token(Token = "0x60019BF")]
	[Address(RVA = "0x4E6830", Offset = "0x4E4E30", VA = "0x1804E6830", Slot = "73")]
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

	// Token: 0x060019C0 RID: 6592 RVA: 0x0008AD14 File Offset: 0x00088F14
	[Token(Token = "0x60019C0")]
	[Address(RVA = "0x4E6190", Offset = "0x4E4790", VA = "0x1804E6190", Slot = "44")]
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

	// Token: 0x060019C1 RID: 6593 RVA: 0x0008AE58 File Offset: 0x00089058
	[Token(Token = "0x60019C1")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public StarFruit()
	{
	}
}
