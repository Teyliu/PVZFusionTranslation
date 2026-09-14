using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000544 RID: 1348
[Token(Token = "0x2000544")]
public class IFVIronPuff : IronPuff
{
	// Token: 0x06001912 RID: 6418 RVA: 0x000876FC File Offset: 0x000858FC
	[Token(Token = "0x6001912")]
	[Address(RVA = "0x5289D0", Offset = "0x526FD0", VA = "0x1805289D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		GameObject gameObject = this.heart.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
		Transform transform = this.heart.transform;
		this.heartTransform = transform;
		float num2 = global::UnityEngine.Random.Range(0.5f, 3f);
		this.sniperTimer = num2;
		float num3 = global::UnityEngine.Random.Range(0.5f, 3f);
		this.pultTimer = num3;
	}

	// Token: 0x06001913 RID: 6419 RVA: 0x00087770 File Offset: 0x00085970
	[Token(Token = "0x6001913")]
	[Address(RVA = "0x529B50", Offset = "0x528150", VA = "0x180529B50", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x06001914 RID: 6420 RVA: 0x000877B8 File Offset: 0x000859B8
	[Token(Token = "0x6001914")]
	[Address(RVA = "0x529C80", Offset = "0x528280", VA = "0x180529C80", Slot = "69")]
	protected override Bullet Shoot2()
	{
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		if (!(targetZombie == num))
		{
			Zombie targetZombie2 = this.targetZombie;
			if (!targetZombie2.isMindControlled && !targetZombie2.beforeDying && targetZombie2.theStatus != ZombieStatus.Dying)
			{
				goto IL_0043;
			}
		}
		Zombie zombie = this.SniperSearch();
		this.targetZombie = zombie;
		IL_0043:
		Zombie targetZombie3 = this.targetZombie;
		int num2 = 0;
		if (targetZombie3 != num2)
		{
			Collider2D col = this.targetZombie.col;
			Zombie targetZombie4 = this.targetZombie;
			int num3 = 0;
			int num4 = this.attributeCount;
			num4++;
			this.attributeCount = num4;
			if (num4 < 6)
			{
				int num5 = 0;
				if (!Lawnf.TravelAdvanced((AdvBuff)((uint)24)))
				{
					Zombie targetZombie5 = this.targetZombie;
					PlantType thePlantType = this.thePlantType;
					targetZombie5.TakeDamage(num5, this, (DamageType)((uint)4), thePlantType, num3 != 0);
					Transform transform = this.shoot_sniper;
				}
			}
			Zombie targetZombie6 = this.targetZombie;
			this.attributeCount = num3;
			PlantType thePlantType2 = this.thePlantType;
			targetZombie6.TakeDamage(1000000, this, (DamageType)((uint)14), thePlantType2, num3 != 0);
			Transform transform2 = this.shoot_sniper;
			GameAPP.PlaySound(40, 0.2f, 1f);
			if (Lawnf.TravelAdvanced((AdvBuff)((uint)24)) && global::UnityEngine.Random.Range(0, 3) == 0)
			{
				this.anim.SetTrigger("shoot2");
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001915 RID: 6421 RVA: 0x00087900 File Offset: 0x00085B00
	[Token(Token = "0x6001915")]
	[Address(RVA = "0x5291B0", Offset = "0x5277B0", VA = "0x1805291B0")]
	private void PierceZombie(Vector2 start, Vector2 target, int count, int damage, DamageType damageType)
	{
		int num = 0;
		if (count != 0)
		{
			int num2 = 0;
			bool flag;
			if (!flag)
			{
				this.FromTo(num2, target);
				LayerMask zombieLayer = this.zombieLayer;
				RaycastHit2D[] array;
				if (num < array.Length)
				{
					Collider2D collider2D;
					if (collider2D.TryGetComponent<Zombie>(num))
					{
						int num3 = 0;
						if (num != num3)
						{
							int num4 = 0;
							bool flag2;
							if (num != num4 && flag2)
							{
								if (num > 12)
								{
									if (num == 21 || 18446744073709551593UL <= (ulong)1L)
									{
										goto IL_0098;
									}
									if (num != 44)
									{
										goto IL_0088;
									}
									num++;
								}
								if (num == 1 || num == 12)
								{
									goto IL_0098;
								}
								IL_0088:
								PlantType thePlantType = this.thePlantType;
								if (ParticleManager.Instance == 0)
								{
									return;
								}
							}
						}
					}
					IL_0098:
					num++;
				}
			}
		}
	}

	// Token: 0x06001916 RID: 6422 RVA: 0x000879B0 File Offset: 0x00085BB0
	[Token(Token = "0x6001916")]
	[Address(RVA = "0x528F90", Offset = "0x527590", VA = "0x180528F90")]
	private UniTask PierceZombieRecursive(Vector2 start, Vector2 direction, float remainingDistance, int remainingPierce, DamageType damageType, int currentBounceCount, int maxPierceForBounce, int originalDamage, int hitCount = 0)
	{
		int num = 0;
		if (num < start)
		{
			num += num;
			num++;
			return default(UniTask);
		}
		return default(UniTask);
	}

	// Token: 0x06001917 RID: 6423 RVA: 0x000879E0 File Offset: 0x00085BE0
	[Token(Token = "0x6001917")]
	[Address(RVA = "0x528EA0", Offset = "0x5274A0", VA = "0x180528EA0")]
	private void FromTo(Vector2 from, Vector2 to)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001918 RID: 6424 RVA: 0x00087A04 File Offset: 0x00085C04
	[Token(Token = "0x6001918")]
	[Address(RVA = "0x528790", Offset = "0x526D90", VA = "0x180528790")]
	private void AnimShoot3()
	{
		Transform transform = this.shoot_pult;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		int size = bullet.hitFilters._size;
		bool flag = bullet.hitFilters.Remove(3);
		bullet.Damage = 3;
		float num = bullet.trackSpeed * 2.5f;
		bullet.trackSpeed = num;
		Transform transform2 = bullet.transform;
		Transform transform3 = this.shoot_pult;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
	}

	// Token: 0x06001919 RID: 6425 RVA: 0x00087AA0 File Offset: 0x00085CA0
	[Token(Token = "0x6001919")]
	[Address(RVA = "0x52A450", Offset = "0x528A50", VA = "0x18052A450", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Animator anim = this.anim;
		float speed = anim.speed;
		if (anim != 0)
		{
			this.ExtraShootUpdate();
			this.PultUpdate();
			Zombie targetZombie = this.targetZombie;
			bool flag = this.CheckZombie(targetZombie);
			Transform transform = this.heartTransform;
			if (!flag)
			{
				GameObject gameObject = transform.gameObject;
				int num = 0;
				gameObject.SetActive(num != 0);
				Zombie zombie = this.SniperSearch();
				return;
			}
			transform.gameObject.SetActive(true);
			Zombie targetZombie2 = this.targetZombie;
			Transform transform2 = this.heartTransform;
			Collider2D col = targetZombie2.col;
			Zombie targetZombie3 = this.targetZombie;
			SortingGroup sortingGroup = this.heart;
			int theZombieRow = targetZombie3.theZombieRow;
			string text = string.Format("bullet{0}", theZombieRow);
			sortingGroup.sortingLayerName = text;
			Zombie targetZombie4 = this.targetZombie;
			SortingGroup sortingGroup2 = this.heart;
			int num2 = targetZombie4.sortingGroup.sortingOrder + 1;
			sortingGroup2.sortingOrder = num2;
		}
	}

	// Token: 0x0600191A RID: 6426 RVA: 0x00087B94 File Offset: 0x00085D94
	[Token(Token = "0x600191A")]
	[Address(RVA = "0x529810", Offset = "0x527E10", VA = "0x180529810")]
	private void PultUpdate()
	{
		Zombie zombie = this.targetZombie2;
		int num = 0;
		if (!(zombie == num))
		{
			Zombie zombie2 = this.targetZombie2;
			if (this.CheckAir(zombie2))
			{
				goto IL_003B;
			}
			this.targetZombie2 = (ulong)0L;
		}
		Zombie zombie3 = this.TryGetFlyingZombie();
		this.targetZombie2 = zombie3;
		IL_003B:
		Zombie zombie4 = this.targetZombie2;
		int num2 = 0;
		if (zombie4 != num2)
		{
			Collider2D col = this.targetZombie2.col;
			Transform transform = this.pult.transform;
			Vector3 vector;
			float z = vector.z;
			Vector3 vector2;
			float z2 = vector2.z;
			Transform transform2 = this.pult.transform;
			Transform transform3 = this.pult.transform;
			int num3 = 0;
			float num4 = Time.deltaTime * 7f;
			if (num3 > (int)num4 || num4 > 1f)
			{
			}
		}
	}

	// Token: 0x0600191B RID: 6427 RVA: 0x00087C68 File Offset: 0x00085E68
	[Token(Token = "0x600191B")]
	[Address(RVA = "0x52A220", Offset = "0x528820", VA = "0x18052A220")]
	private Zombie TryGetFlyingZombie()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3) || !this.CheckAir(num))
				{
					continue;
				}
				Transform axis = this.axis;
			}
		}
		while (num2 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x0600191C RID: 6428 RVA: 0x00087CCC File Offset: 0x00085ECC
	[Token(Token = "0x600191C")]
	[Address(RVA = "0x528A80", Offset = "0x527080", VA = "0x180528A80")]
	private bool CheckAir(Zombie zombie)
	{
		Collider2D col = zombie.col;
		int num = 0;
		if (col != num && zombie.col.enabled && !zombie.isMindControlled)
		{
			int thePlantRow = this.thePlantRow;
			if (zombie.theZombieRow == thePlantRow && zombie.theStatus == ZombieStatus.Flying)
			{
				Transform axis = zombie.axis;
				Transform axis2 = this.axis;
				Transform axis3 = zombie.axis;
				float vision = this.vision;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600191D RID: 6429 RVA: 0x00087D48 File Offset: 0x00085F48
	[Token(Token = "0x600191D")]
	[Address(RVA = "0x528CC0", Offset = "0x5272C0", VA = "0x180528CC0")]
	private void ExtraShootUpdate()
	{
		float num = this.sniperTimer;
		float deltaTime = Time.deltaTime;
		int num2 = 0;
		this.sniperTimer = num;
		if (num2 > (int)num)
		{
			float thePlantAttackInterval = this.thePlantAttackInterval;
			float num3 = global::UnityEngine.Random.Range(0.95f, 1.05f);
			this.sniperTimer = num3;
			if (Lawnf.TravelAdvanced((AdvBuff)((uint)24)))
			{
				float num4 = this.sniperTimer * 2.5f;
				this.sniperTimer = num4;
			}
			Zombie targetZombie = this.targetZombie;
			int num5 = 0;
			if (targetZombie != num5)
			{
				this.anim.SetTrigger("shoot2");
			}
		}
		float num6 = this.pultTimer;
		float deltaTime2 = Time.deltaTime;
		this.pultTimer = num6;
		if (num2 > (int)num6)
		{
			float num7 = global::UnityEngine.Random.Range(0.95f, 1.05f);
			this.pultTimer = num7;
			if (this.PultSearch())
			{
				this.anim.SetTrigger("shoot3");
			}
		}
	}

	// Token: 0x0600191E RID: 6430 RVA: 0x00087E34 File Offset: 0x00086034
	[Token(Token = "0x600191E")]
	[Address(RVA = "0x529620", Offset = "0x527C20", VA = "0x180529620")]
	private bool PultSearch()
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
				goto Block_2;
			}
		}
		int thePlantRow = this.thePlantRow;
		Transform axis = this.axis;
		return true;
		Block_2:
		throw new NullReferenceException();
	}

	// Token: 0x0600191F RID: 6431 RVA: 0x00087E98 File Offset: 0x00086098
	[Token(Token = "0x600191F")]
	[Address(RVA = "0x529FE0", Offset = "0x5285E0", VA = "0x180529FE0")]
	private Zombie SniperSearch()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				if (!this.CheckZombie(num))
				{
					continue;
				}
				Transform axis = this.axis;
			}
		}
		while (num2 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x06001920 RID: 6432 RVA: 0x00087EEC File Offset: 0x000860EC
	[Token(Token = "0x6001920")]
	[Address(RVA = "0x528BC0", Offset = "0x5271C0", VA = "0x180528BC0")]
	private bool CheckZombie(Zombie zombie)
	{
		int num = 0;
		if (zombie != num && !zombie.isMindControlled)
		{
			Collider2D col = zombie.col;
			int num2 = 0;
			if (col != num2)
			{
				bool enabled = zombie.col.enabled;
				if (enabled && !zombie.beforeDying)
				{
					ZombieStatus theStatus = zombie.theStatus;
					if (theStatus > ZombieStatus.Miner_digging)
					{
						if (theStatus != ZombieStatus.Boss && enabled > true && theStatus != ZombieStatus.Bungi_awake)
						{
							return true;
						}
					}
					else if (theStatus != ZombieStatus.Dying)
					{
						return theStatus != ZombieStatus.Miner_digging;
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001921 RID: 6433 RVA: 0x00087F74 File Offset: 0x00086174
	[Token(Token = "0x6001921")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public IFVIronPuff()
	{
	}

	// Token: 0x04000EA7 RID: 3751
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000EA7")]
	private float sniperTimer;

	// Token: 0x04000EA8 RID: 3752
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000EA8")]
	private float pultTimer;

	// Token: 0x04000EA9 RID: 3753
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000EA9")]
	public Transform shoot_pult;

	// Token: 0x04000EAA RID: 3754
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000EAA")]
	public Transform shoot_sniper;

	// Token: 0x04000EAB RID: 3755
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000EAB")]
	public SortingGroup heart;

	// Token: 0x04000EAC RID: 3756
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000EAC")]
	private Transform heartTransform;

	// Token: 0x04000EAD RID: 3757
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000EAD")]
	public Transform pult;

	// Token: 0x04000EAE RID: 3758
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4000EAE")]
	private Zombie targetZombie2;
}
