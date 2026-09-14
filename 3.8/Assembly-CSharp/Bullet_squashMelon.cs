using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020001AD RID: 429
[Token(Token = "0x20001AD")]
public class Bullet_squashMelon : Bullet
{
	// Token: 0x06000774 RID: 1908 RVA: 0x0002666C File Offset: 0x0002486C
	[Token(Token = "0x6000774")]
	[Address(RVA = "0x7E4460", Offset = "0x7E2A60", VA = "0x1807E4460", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		float num = this.Vx * 0.5f;
		this.hit = false;
		this.Vx = num;
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x00026694 File Offset: 0x00024894
	[Token(Token = "0x6000775")]
	[Address(RVA = "0x7E3FD0", Offset = "0x7E25D0", VA = "0x1807E3FD0", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		GridSystem gridSystem = this.board.gridSystem;
		Mouse instance = Mouse.Instance;
		Transform transform2 = base.transform;
		int theBulletRow = this.theBulletRow;
		int num;
		if (gridSystem.GetBoxType(num, theBulletRow) != BoxType.Water)
		{
			GameAPP.PlaySound(74, 0.2f, 1f);
			GameObject gameObject = base.gameObject;
			Transform shadow = this.shadow;
			Vector3 vector2;
			float z2 = vector2.z;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform3 = this.board.transform;
			GameObject gameObject2;
			global::UnityEngine.Object.Destroy(gameObject2.GetComponent<Bullet>());
			SortingGroup component = gameObject2.GetComponent<SortingGroup>();
			int theBulletRow2 = this.theBulletRow;
			string text = string.Format("bullet{0}", component);
			component.sortingLayerName = text;
			Transform transform4 = base.transform;
			Vector3 vector3;
			float z3 = vector3.z;
			Transform transform5 = gameObject2.transform;
			this.ExtraEffect(gameObject2);
		}
		Transform transform6 = base.transform;
		Vector2 oneVector = Vector2.oneVector;
		GameAPP.PlaySound(75, 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x000267A4 File Offset: 0x000249A4
	[Token(Token = "0x6000776")]
	[Address(RVA = "0x7E3E90", Offset = "0x7E2490", VA = "0x1807E3E90", Slot = "27")]
	protected virtual void ExtraEffect(GameObject obj)
	{
		int theBulletRow = this.theBulletRow;
		int row = theBulletRow;
		int damage = this._damage;
		int dmg = damage;
		bool melonSputter3 = this.melonSputter;
		bool melonSputter = melonSputter3;
		DelayAction delayAction = GameAPP.delayAction;
		Action action = delegate
		{
			Board board = this.board;
			int num = 0;
			if (board != num)
			{
				Bullet_squashMelon <>4__this = this;
				GameObject obj2 = obj;
				PlantType fromType = <>4__this.fromType;
				Transform transform = obj2.transform;
				CreateBullet instance = CreateBullet.Instance;
				int dmg2 = dmg;
				Bullet bullet;
				bullet.Damage = dmg2;
				bool melonSputter2 = melonSputter;
				bullet.melonSputter = melonSputter2;
				bullet.fromType = fromType;
				bullet.HitLand();
				global::UnityEngine.Object.Destroy(obj);
			}
		};
		delayAction.SetAction(action, 1f);
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x00026818 File Offset: 0x00024A18
	[Token(Token = "0x6000777")]
	[Address(RVA = "0x7E3D00", Offset = "0x7E2300", VA = "0x1807E3D00", Slot = "28")]
	protected virtual void AttackZombies(Vector2 center, int row, int maxRow)
	{
		LayerMask zombieLayer = this.zombieLayer;
		int num = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				num -= row;
				if (Lawnf.ThrowLandStatus((ZombieStatus)num))
				{
					PlantType fromType = this.fromType;
				}
			}
			num++;
		}
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x0002685C File Offset: 0x00024A5C
	[Token(Token = "0x6000778")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_squashMelon()
	{
	}
}
