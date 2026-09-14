using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000517 RID: 1303
[Token(Token = "0x2000517")]
public class IFVIronPuff : IronPuff
{
	// Token: 0x06001843 RID: 6211 RVA: 0x00083B6C File Offset: 0x00081D6C
	[Token(Token = "0x6001843")]
	[Address(RVA = "0x4CC610", Offset = "0x4CAC10", VA = "0x1804CC610", Slot = "10")]
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

	// Token: 0x06001844 RID: 6212 RVA: 0x00083BE0 File Offset: 0x00081DE0
	[Token(Token = "0x6001844")]
	[Address(RVA = "0x4CD790", Offset = "0x4CBD90", VA = "0x1804CD790", Slot = "69")]
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

	// Token: 0x06001845 RID: 6213 RVA: 0x00083C28 File Offset: 0x00081E28
	[Token(Token = "0x6001845")]
	[Address(RVA = "0x4CD8C0", Offset = "0x4CBEC0", VA = "0x1804CD8C0", Slot = "70")]
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

	// Token: 0x06001846 RID: 6214 RVA: 0x00083D70 File Offset: 0x00081F70
	[Token(Token = "0x6001846")]
	[Address(RVA = "0x4CCDF0", Offset = "0x4CB3F0", VA = "0x1804CCDF0")]
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

	// Token: 0x06001847 RID: 6215 RVA: 0x00083E20 File Offset: 0x00082020
	[Token(Token = "0x6001847")]
	[Address(RVA = "0x4CCBD0", Offset = "0x4CB1D0", VA = "0x1804CCBD0")]
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

	// Token: 0x06001848 RID: 6216 RVA: 0x00083E50 File Offset: 0x00082050
	[Token(Token = "0x6001848")]
	[Address(RVA = "0x4CCAE0", Offset = "0x4CB0E0", VA = "0x1804CCAE0")]
	private void FromTo(Vector2 from, Vector2 to)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001849 RID: 6217 RVA: 0x00083E74 File Offset: 0x00082074
	[Token(Token = "0x6001849")]
	[Address(RVA = "0x4CC470", Offset = "0x4CAA70", VA = "0x1804CC470")]
	private void AnimShoot3()
	{
		Transform transform = this.shoot_pult;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		float num = bullet.trackSpeed * 2.5f;
		bullet.trackSpeed = num;
		Transform transform2 = bullet.transform;
		Transform transform3 = this.shoot_pult;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
	}

	// Token: 0x0600184A RID: 6218 RVA: 0x00083EE0 File Offset: 0x000820E0
	[Token(Token = "0x600184A")]
	[Address(RVA = "0x4CE090", Offset = "0x4CC690", VA = "0x1804CE090", Slot = "16")]
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

	// Token: 0x0600184B RID: 6219 RVA: 0x00083FD4 File Offset: 0x000821D4
	[Token(Token = "0x600184B")]
	[Address(RVA = "0x4CD450", Offset = "0x4CBA50", VA = "0x1804CD450")]
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

	// Token: 0x0600184C RID: 6220 RVA: 0x000840A8 File Offset: 0x000822A8
	[Token(Token = "0x600184C")]
	[Address(RVA = "0x4CDE60", Offset = "0x4CC460", VA = "0x1804CDE60")]
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

	// Token: 0x0600184D RID: 6221 RVA: 0x0008410C File Offset: 0x0008230C
	[Token(Token = "0x600184D")]
	[Address(RVA = "0x4CC6C0", Offset = "0x4CACC0", VA = "0x1804CC6C0")]
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

	// Token: 0x0600184E RID: 6222 RVA: 0x00084188 File Offset: 0x00082388
	[Token(Token = "0x600184E")]
	[Address(RVA = "0x4CC900", Offset = "0x4CAF00", VA = "0x1804CC900")]
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

	// Token: 0x0600184F RID: 6223 RVA: 0x00084274 File Offset: 0x00082474
	[Token(Token = "0x600184F")]
	[Address(RVA = "0x4CD260", Offset = "0x4CB860", VA = "0x1804CD260")]
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

	// Token: 0x06001850 RID: 6224 RVA: 0x000842D8 File Offset: 0x000824D8
	[Token(Token = "0x6001850")]
	[Address(RVA = "0x4CDC20", Offset = "0x4CC220", VA = "0x1804CDC20")]
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

	// Token: 0x06001851 RID: 6225 RVA: 0x0008432C File Offset: 0x0008252C
	[Token(Token = "0x6001851")]
	[Address(RVA = "0x4CC800", Offset = "0x4CAE00", VA = "0x1804CC800")]
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

	// Token: 0x06001852 RID: 6226 RVA: 0x000843B4 File Offset: 0x000825B4
	[Token(Token = "0x6001852")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public IFVIronPuff()
	{
	}

	// Token: 0x04000DEE RID: 3566
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000DEE")]
	private float sniperTimer;

	// Token: 0x04000DEF RID: 3567
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000DEF")]
	private float pultTimer;

	// Token: 0x04000DF0 RID: 3568
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000DF0")]
	public Transform shoot_pult;

	// Token: 0x04000DF1 RID: 3569
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000DF1")]
	public Transform shoot_sniper;

	// Token: 0x04000DF2 RID: 3570
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000DF2")]
	public SortingGroup heart;

	// Token: 0x04000DF3 RID: 3571
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000DF3")]
	private Transform heartTransform;

	// Token: 0x04000DF4 RID: 3572
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000DF4")]
	public Transform pult;

	// Token: 0x04000DF5 RID: 3573
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4000DF5")]
	private Zombie targetZombie2;
}
