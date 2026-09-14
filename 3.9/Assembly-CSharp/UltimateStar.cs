using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020005F3 RID: 1523
[Token(Token = "0x20005F3")]
public class UltimateStar : StarFruit
{
	// Token: 0x06001C62 RID: 7266 RVA: 0x000974BC File Offset: 0x000956BC
	[Token(Token = "0x6001C62")]
	[Address(RVA = "0x56C1A0", Offset = "0x56A7A0", VA = "0x18056C1A0", Slot = "56")]
	protected override bool OnStarUp()
	{
		this.anim.SetTrigger("starup");
		return true;
	}

	// Token: 0x06001C63 RID: 7267 RVA: 0x000974E0 File Offset: 0x000956E0
	[Token(Token = "0x6001C63")]
	[Address(RVA = "0x56BD50", Offset = "0x56A350", VA = "0x18056BD50")]
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
		float attributeSpeed = this.attributeSpeed;
		component.speedMutiplier = attributeSpeed;
	}

	// Token: 0x06001C64 RID: 7268 RVA: 0x000975A0 File Offset: 0x000957A0
	[Token(Token = "0x6001C64")]
	[Address(RVA = "0x56C820", Offset = "0x56AE20", VA = "0x18056C820")]
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

	// Token: 0x06001C65 RID: 7269 RVA: 0x00097630 File Offset: 0x00095830
	[Token(Token = "0x6001C65")]
	[Address(RVA = "0x56CC40", Offset = "0x56B240", VA = "0x18056CC40", Slot = "68")]
	protected override Bullet Shoot1()
	{
		List<Plant> plants = MagnetSystem.GetPlants(this);
		Func<Plant, bool> <>9__5_ = UltimateStar.<>c.<>9__5_0;
		if (<>9__5_ == 0)
		{
			UltimateStar.<>c.<>9__5_0 = (Plant p) => p.thePlantType == PlantType.IFVStar;
		}
		Plant plant = Enumerable.FirstOrDefault<Plant>(plants, <>9__5_);
		int num = 0;
		bool flag = plant != num;
		int num2 = 0;
		int num3;
		int num5;
		if (flag)
		{
			Transform shoot = this.shoot;
			num3 = plant.attackDamage;
			int num4 = 0;
			num5 = 0;
			this.SetIFVStars(num3, num4, (float)num5);
		}
		num3 = this.GetBulletDamage();
		num3 += num3;
		int shootingLevel = this.shootingLevel;
		bool flag2;
		if (!flag2)
		{
			if (shootingLevel <= 0)
			{
				goto IL_00B3;
			}
			Transform shoot2 = this.shoot;
			int num6 = 0;
			this.SetIFVStars(num3, num6, (float)num5);
			num2++;
		}
		if (this > 0)
		{
			Transform shoot3 = this.shoot;
			num2++;
		}
		IL_00B3:
		Bullet bullet = base.Shoot1();
		bool flag3;
		if (flag3)
		{
			int num7 = this.shootingCurse;
			num7 += 5;
			this.shootingCurse = num7;
			TravelMgr instance = TravelMgr.Instance;
			List<AdvBuff> advBuffs = TravelMgr.Instance.data.advBuffs;
			InGameText instance2 = InGameText.Instance;
			string text = global::Lawnf.GetName(this.thePlantType) + "的诅咒效果已反转";
			float thePlantAttackCountDown = this.thePlantAttackCountDown;
			this.thePlantAttackCountDown = thePlantAttackCountDown;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001C66 RID: 7270 RVA: 0x0009776C File Offset: 0x0009596C
	[Token(Token = "0x6001C66")]
	[Address(RVA = "0x56D060", Offset = "0x56B660", VA = "0x18056D060", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (!global::Lawnf.TravelUltimate((UltiBuff)((uint)8)))
		{
			return;
		}
	}

	// Token: 0x06001C67 RID: 7271 RVA: 0x0009778C File Offset: 0x0009598C
	[Token(Token = "0x6001C67")]
	[Address(RVA = "0x56C180", Offset = "0x56A780", VA = "0x18056C180", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_ultimateStar_magic;
	}

	// Token: 0x06001C68 RID: 7272 RVA: 0x000977A0 File Offset: 0x000959A0
	[Token(Token = "0x6001C68")]
	[Address(RVA = "0x56BFF0", Offset = "0x56A5F0", VA = "0x18056BFF0")]
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

	// Token: 0x06001C69 RID: 7273 RVA: 0x00097810 File Offset: 0x00095A10
	[Token(Token = "0x6001C69")]
	[Address(RVA = "0x56C5C0", Offset = "0x56ABC0", VA = "0x18056C5C0", Slot = "72")]
	protected override void SetBullet(Transform _transform, BulletMoveWay theMovingWay)
	{
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		Bullet bullet;
		Transform transform = bullet.transform;
		List<BulletHitFilter> hitFilters = bullet.hitFilters;
		int size = hitFilters._size;
		Quaternion quaternion;
		hitFilters._size = quaternion;
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

	// Token: 0x06001C6A RID: 7274 RVA: 0x000978A4 File Offset: 0x00095AA4
	[Token(Token = "0x6001C6A")]
	[Address(RVA = "0x56C300", Offset = "0x56A900", VA = "0x18056C300", Slot = "43")]
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

	// Token: 0x06001C6B RID: 7275 RVA: 0x0009791C File Offset: 0x00095B1C
	[Token(Token = "0x6001C6B")]
	[Address(RVA = "0x56C1F0", Offset = "0x56A7F0", VA = "0x18056C1F0", Slot = "44")]
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

	// Token: 0x06001C6C RID: 7276 RVA: 0x00097980 File Offset: 0x00095B80
	[Token(Token = "0x6001C6C")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public UltimateStar()
	{
	}

	// Token: 0x04000F9B RID: 3995
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000F9B")]
	public Transform star3;

	// Token: 0x04000F9C RID: 3996
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000F9C")]
	public GameObject star3Prefab;
}
