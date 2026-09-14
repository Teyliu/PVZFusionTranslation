using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020005C1 RID: 1473
[Token(Token = "0x20005C1")]
public class UltimateStar : StarFruit
{
	// Token: 0x06001B6F RID: 7023 RVA: 0x00092D04 File Offset: 0x00090F04
	[Token(Token = "0x6001B6F")]
	[Address(RVA = "0x503880", Offset = "0x501E80", VA = "0x180503880", Slot = "57")]
	protected override bool OnStarUp()
	{
		this.anim.SetTrigger("starup");
		return true;
	}

	// Token: 0x06001B70 RID: 7024 RVA: 0x00092D28 File Offset: 0x00090F28
	[Token(Token = "0x6001B70")]
	[Address(RVA = "0x503440", Offset = "0x501A40", VA = "0x180503440")]
	private void AnimStarUpShoot()
	{
		Transform transform = this.star3;
		GameObject gameObject = this.star3Prefab;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform2 = this.board.transform;
		GameObject gameObject2;
		BigStar component = gameObject2.GetComponent<BigStar>();
		SortingGroup sortingGroup = component.gameObject.AddComponent<SortingGroup>();
		int thePlantRow = this.thePlantRow;
		string text = string.Format("bullet{0}", sortingGroup);
		sortingGroup.sortingLayerName = text;
		int skinType = this.skinType;
		component.skinType = skinType;
		long num;
		component.baseDamage = (int)num;
		int attackDamage = this.attackDamage;
		ulong num2;
		component.bulletDamage = num2;
		PlantType thePlantType = this.thePlantType;
		component.fromType = thePlantType;
	}

	// Token: 0x06001B71 RID: 7025 RVA: 0x00092DD8 File Offset: 0x00090FD8
	[Token(Token = "0x6001B71")]
	[Address(RVA = "0x503E80", Offset = "0x502480", VA = "0x180503E80")]
	private void SetIFVStars(int damage, Vector2 center, float distance = 0f)
	{
		List<int> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int num = 0;
		int num2 = 0;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		Transform transform = bullet.transform;
		int num3 = list[num];
		bullet.transform.Translate(distance, (float)num2, (float)num2);
		bullet.Damage = damage;
		PlantType thePlantType = this.thePlantType;
		num++;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001B72 RID: 7026 RVA: 0x00092E68 File Offset: 0x00091068
	[Token(Token = "0x6001B72")]
	[Address(RVA = "0x5042A0", Offset = "0x5028A0", VA = "0x1805042A0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		List<Plant> plants = MagnetSystem.GetPlants(this);
		Func<Plant, bool> <>9__5_ = UltimateStar.<>c.<>9__5_0;
		if (<>9__5_ == 0)
		{
			Func<Plant, bool> func;
			UltimateStar.<>c.<>9__5_0 = func;
		}
		Plant plant = Enumerable.FirstOrDefault<Plant>(plants, <>9__5_);
		int num = 0;
		bool flag = plant != num;
		int num2 = 0;
		if (flag)
		{
			Transform shoot = this.shoot;
			int attackDamage = plant.attackDamage;
			int num3 = 0;
			int num4 = 0;
			this.SetIFVStars(attackDamage, num3, (float)num4);
		}
		int bulletDamage = this.GetBulletDamage();
		Transform shoot2 = this.shoot;
		num2++;
		return base.Shoot1();
	}

	// Token: 0x06001B73 RID: 7027 RVA: 0x00092EF4 File Offset: 0x000910F4
	[Token(Token = "0x6001B73")]
	[Address(RVA = "0x504500", Offset = "0x502B00", VA = "0x180504500", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (!Lawnf.TravelUltimate((UltiBuff)((uint)8)))
		{
			return;
		}
	}

	// Token: 0x06001B74 RID: 7028 RVA: 0x00092F14 File Offset: 0x00091114
	[Token(Token = "0x6001B74")]
	[Address(RVA = "0x503860", Offset = "0x501E60", VA = "0x180503860", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_ultimateStar_magic;
	}

	// Token: 0x06001B75 RID: 7029 RVA: 0x00092F28 File Offset: 0x00091128
	[Token(Token = "0x6001B75")]
	[Address(RVA = "0x5036D0", Offset = "0x501CD0", VA = "0x1805036D0")]
	private int GetBulletDamage()
	{
		Board board = this.board;
		int magnetCount = this.magnetCount;
		int num;
		int attackDamage;
		float num2;
		float num4;
		if (num != 0)
		{
			float num3;
			if (num != 0)
			{
				if (num != 1)
				{
					return attackDamage;
				}
				num2 = num3 * 3f;
			}
			num4 = num3 * 0.05f;
			num2 = num4;
			if (num2 <= num4)
			{
				return attackDamage;
			}
		}
		attackDamage = this.attackDamage;
		uint num5;
		num5 += num5;
		float num6 = num4 * 0.05f;
		if (num2 > num6)
		{
			num5 += num5;
		}
		return attackDamage;
	}

	// Token: 0x06001B76 RID: 7030 RVA: 0x00092F98 File Offset: 0x00091198
	[Token(Token = "0x6001B76")]
	[Address(RVA = "0x503CA0", Offset = "0x5022A0", VA = "0x180503CA0", Slot = "73")]
	protected override void SetBullet(Transform _transform, BulletMoveWay theMovingWay)
	{
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		Bullet bullet;
		Transform transform = bullet.transform;
		Transform axis = this.axis;
		List<AirProjectile> list;
		bullet.targetProjectiles = list;
		if (list != 0)
		{
			float trackSpeed = bullet.trackSpeed;
			bullet.trackSpeed = trackSpeed;
		}
		int bulletDamage = this.GetBulletDamage();
		bullet.Damage = bulletDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001B77 RID: 7031 RVA: 0x00093010 File Offset: 0x00091210
	[Token(Token = "0x6001B77")]
	[Address(RVA = "0x5039E0", Offset = "0x501FE0", VA = "0x1805039E0", Slot = "44")]
	protected override GameObject SearchZombie()
	{
		for (;;)
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			ulong num3;
			if (flag)
			{
				int num2 = 0;
				if (num != num2)
				{
					break;
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_3;
			}
		}
		float vision = this.vision;
		Vector3 vector;
		while (vector <= (ulong)4L)
		{
		}
		GameObject gameObject;
		return gameObject;
		Block_3:
		int num4 = 0;
		AirProjectile airProjectile;
		if (!(airProjectile != num4))
		{
		}
		return airProjectile.gameObject;
	}

	// Token: 0x06001B78 RID: 7032 RVA: 0x00093088 File Offset: 0x00091288
	[Token(Token = "0x6001B78")]
	[Address(RVA = "0x5038D0", Offset = "0x501ED0", VA = "0x1805038D0", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float thePlantAttackInterval = this.thePlantAttackInterval;
		this.thePlantAttackCountDown = thePlantAttackInterval;
		GameObject gameObject = this.SearchZombie();
		int num = 0;
		if (!(gameObject != num))
		{
			Zombie zombie = base.SearchBoss();
			int num2 = 0;
			if (!(zombie != num2))
			{
				return;
			}
		}
		this.anim.SetTrigger("shoot");
	}

	// Token: 0x06001B79 RID: 7033 RVA: 0x000930EC File Offset: 0x000912EC
	[Token(Token = "0x6001B79")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public UltimateStar()
	{
	}

	// Token: 0x04000EDC RID: 3804
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000EDC")]
	public Transform star3;

	// Token: 0x04000EDD RID: 3805
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000EDD")]
	public GameObject star3Prefab;
}
