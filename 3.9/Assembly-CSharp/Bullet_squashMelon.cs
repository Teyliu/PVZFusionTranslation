using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001B4 RID: 436
[Token(Token = "0x20001B4")]
public class Bullet_squashMelon : Bullet
{
	// Token: 0x06000781 RID: 1921 RVA: 0x00025F90 File Offset: 0x00024190
	[Token(Token = "0x6000781")]
	[Address(RVA = "0x811B10", Offset = "0x810110", VA = "0x180811B10", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		float num = this.velocity * 0.5f;
		this.velocity = num;
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x00025FB4 File Offset: 0x000241B4
	[Token(Token = "0x6000782")]
	[Address(RVA = "0x811680", Offset = "0x80FC80", VA = "0x180811680", Slot = "17")]
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
			Transform transform3 = base.transform;
			int num2 = 0;
			GameObject gameObject = transform3.GetChild(num2).gameObject;
			Transform shadow = this.shadow;
			Vector3 vector2;
			float z2 = vector2.z;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform4 = this.board.transform;
			GameObject gameObject2;
			SpriteRenderer component = gameObject2.GetComponent<SpriteRenderer>();
			int theBulletRow2 = this.theBulletRow;
			string text = string.Format("bullet{0}", component);
			component.sortingLayerName = text;
			Transform transform5 = base.transform;
			Vector3 vector3;
			float z3 = vector3.z;
			Transform transform6 = gameObject2.transform;
			this.ExtraEffect(gameObject2);
		}
		Transform transform7 = base.transform;
		Vector2 oneVector = Vector2.oneVector;
		GameAPP.PlaySound(75, 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x000260CC File Offset: 0x000242CC
	[Token(Token = "0x6000783")]
	[Address(RVA = "0x811540", Offset = "0x80FB40", VA = "0x180811540", Slot = "25")]
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

	// Token: 0x06000784 RID: 1924 RVA: 0x00026140 File Offset: 0x00024340
	[Token(Token = "0x6000784")]
	[Address(RVA = "0x8113B0", Offset = "0x80F9B0", VA = "0x1808113B0", Slot = "26")]
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

	// Token: 0x06000785 RID: 1925 RVA: 0x00026184 File Offset: 0x00024384
	[Token(Token = "0x6000785")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_squashMelon()
	{
	}
}
