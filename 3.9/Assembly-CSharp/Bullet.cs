using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Rendering;

// Token: 0x0200010B RID: 267
[Token(Token = "0x200010B")]
public class Bullet : MonoBehaviour, IDamageMaker
{
	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x06000511 RID: 1297 RVA: 0x0001A8A0 File Offset: 0x00018AA0
	// (set) Token: 0x06000512 RID: 1298 RVA: 0x0001A8B4 File Offset: 0x00018AB4
	[Token(Token = "0x170000A1")]
	public BulletMoveWay MoveWay
	{
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x5E2B60", Offset = "0x5E1160", VA = "0x1805E2B60")]
		get
		{
			return this._moveWay;
		}
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x5E2C40", Offset = "0x5E1240", VA = "0x1805E2C40")]
		set
		{
			if (this._moveWay != value)
			{
				this.OnMoveWayChanged(value);
				this._moveWay = value;
			}
		}
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x06000513 RID: 1299 RVA: 0x0001A8DC File Offset: 0x00018ADC
	[Token(Token = "0x170000A2")]
	public virtual ParticleType ParticleType
	{
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x5E2B70", Offset = "0x5E1170", VA = "0x1805E2B70", Slot = "7")]
		get;
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x06000514 RID: 1300 RVA: 0x0001A8F0 File Offset: 0x00018AF0
	// (set) Token: 0x06000515 RID: 1301 RVA: 0x0001A904 File Offset: 0x00018B04
	[Token(Token = "0x170000A3")]
	public int Damage
	{
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x5E2B50", Offset = "0x5E1150", VA = "0x1805E2B50")]
		get
		{
			return this._damage;
		}
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x5E2B90", Offset = "0x5E1190", VA = "0x1805E2B90")]
		set
		{
			if (this.<Team>k__BackingField != Team.Player)
			{
				this._damage = value;
				return;
			}
			Board board = this.board;
			int num = 0;
			if (board != 0)
			{
				float num2 = global::UnityEngine.Random.Range((float)num, 100f);
				Board board2 = this.board;
				if (board2.bulletStrikeP > num2)
				{
					this._damage = board2;
					return;
				}
			}
		}
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x06000516 RID: 1302 RVA: 0x0001A95C File Offset: 0x00018B5C
	// (set) Token: 0x06000517 RID: 1303 RVA: 0x0001A970 File Offset: 0x00018B70
	[Token(Token = "0x170000A4")]
	public Team Team
	{
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x5E2B80", Offset = "0x5E1180", VA = "0x1805E2B80", Slot = "4")]
		get;
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x5E2C70", Offset = "0x5E1270", VA = "0x1805E2C70", Slot = "5")]
		set;
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x06000518 RID: 1304 RVA: 0x0001A984 File Offset: 0x00018B84
	[Token(Token = "0x170000A5")]
	protected virtual bool Ignore
	{
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "8")]
		get
		{
			return true;
		}
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x0001A994 File Offset: 0x00018B94
	[Token(Token = "0x6000519")]
	[Address(RVA = "0x5E05B0", Offset = "0x5DEBB0", VA = "0x1805E05B0", Slot = "9")]
	public virtual void InitData()
	{
		int num = 0;
		this.attributeCount = num;
		this.shootingfloat = (float)num;
		this.shootingLevel = num;
		this.from = num;
		this.blocked = false;
		this.from_zombie = num;
		this.fromType = (PlantType)((ulong)4294967295L);
		this.shootByZombie = num != 0;
		this.rogueStatus = num;
		this.torchWood = num;
		this.targetPlant = num;
		this.targetZombie = num;
		this.blackHole = num;
		this.targetProjectiles = num;
		int num2 = 0;
		Rigidbody2D rigidbody2D = this.rb;
		int num3 = 0;
		this.trackSpeed = 5f;
		this.theExistTime = (float)num;
		this.theStatus = (BulletStatus)num;
		this.normalSpeed = 6f;
		this.height = 0.3f;
		this.hitCount = num;
		this.maxHitCount = (int)((ulong)1L);
		this.dying = num != 0;
		this.goldMagneted = num != 0;
		this.isLand = num != 0;
		this.umbrellaed = num != 0;
		rigidbody2D.velocity = num2;
		ulong num4;
		this.col.enabled = num4 != 0UL;
		this.angularVelocity = (float)num;
		Vector2 zeroVector = Vector2.zeroVector;
		this.velocity = zeroVector;
		this.velocity.y = (float)num3;
		Vector2 zeroVector2 = Vector2.zeroVector;
		this.acceleration = zeroVector2;
		this.acceleration.y = (float)num3;
		this.moveSpeed = 6f;
		if (this.<Team>k__BackingField != Team.AI)
		{
			GameObject gameObject = base.gameObject;
			int num5 = LayerMaskMgr.BulletLayer;
			gameObject.layer = num5;
			Board instance = Board.Instance;
			BulletType bulletType = this.theBulletType;
			if (bulletType != BulletType.Bullet_pea && bulletType != BulletType.Bullet_puff)
			{
				goto IL_01B7;
			}
			Rigidbody2D rigidbody2D2 = this.rb;
			LayerMask layerMask = LayerMask.GetMask(new string[] { "Plant" });
		}
		GameObject gameObject2 = base.gameObject;
		int num6 = LayerMaskMgr.ZombieBulletLayer;
		gameObject2.layer = num6;
		IL_01B7:
		BulletMoveWay moveWay = this._moveWay;
		if ((moveWay > BulletMoveWay.Free && moveWay == BulletMoveWay.SmoothTrack) || moveWay == (BulletMoveWay)(-3))
		{
			this.sortingGroup.sortingLayerName = "bullet11";
		}
		Transform transform = this.shadow;
		int num7 = 0;
		if (transform != num7)
		{
			this.bulletMovement.ShadowUpdate();
		}
		Board board = this.board;
		float num8 = this.trackSpeed;
		this.trackSpeed = num8;
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x0001ABC4 File Offset: 0x00018DC4
	[Token(Token = "0x600051A")]
	[Address(RVA = "0x5E0CA0", Offset = "0x5DF2A0", VA = "0x1805E0CA0")]
	public void OnMoveWayChanged(BulletMoveWay moveWay)
	{
		if (moveWay != BulletMoveWay.Track && moveWay != BulletMoveWay.SmoothTrack && moveWay != BulletMoveWay.Spin)
		{
			BulletHelper bulletHelper = this.hitHelper;
			int num = 0;
			if (!(bulletHelper != num))
			{
				goto IL_0068;
			}
			global::UnityEngine.Object.Destroy(this.hitHelper);
			this.hitHelper = (ulong)0L;
		}
		BulletHelper bulletHelper2 = this.hitHelper;
		int num2 = 0;
		if (bulletHelper2 == num2)
		{
			BulletHelper bulletHelper3 = this.AddComponent<BulletHelper>();
			this.hitHelper = bulletHelper3;
			this.hitHelper.bullet = this;
		}
		IL_0068:
		BulletMovement bulletMovement;
		this.bulletMovement = bulletMovement;
		this.bulletMovement.bullet = this;
		BulletMovement bulletMovement2 = this.bulletMovement;
		throw new NullReferenceException();
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x0001AC5C File Offset: 0x00018E5C
	[Token(Token = "0x600051B")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "10")]
	protected virtual void Awake()
	{
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x0001AC6C File Offset: 0x00018E6C
	[Token(Token = "0x600051C")]
	[Address(RVA = "0x5DECF0", Offset = "0x5DD2F0", VA = "0x1805DECF0")]
	public void Die()
	{
		if (!this.dying)
		{
			Board board = this.board;
			int num = this.maxHitCount;
			this.dying = true;
			this.hitCount = num;
			CreateBullet.Instance.RemoveFromList(this);
			this.OnDeath();
			GameObject gameObject = base.gameObject;
			int num2 = 0;
			gameObject.SetActive(num2 != 0);
			DelayAction delayAction = GameAPP.delayAction;
			Action action = new Action(this.DelayDie);
			int num3 = 0;
			delayAction.SetAction(action, (float)num3);
			if (this.cancellationTokenSource != (ulong)0L)
			{
				this.cancellationTokenSource.Cancel();
				this.cancellationTokenSource.Dispose();
			}
		}
	}

	// Token: 0x0600051D RID: 1309 RVA: 0x0001AD0C File Offset: 0x00018F0C
	[Token(Token = "0x600051D")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "11")]
	protected virtual void OnDeath()
	{
	}

	// Token: 0x0600051E RID: 1310 RVA: 0x0001AD1C File Offset: 0x00018F1C
	[Token(Token = "0x600051E")]
	[Address(RVA = "0x5DEC60", Offset = "0x5DD260", VA = "0x1805DEC60")]
	private void DelayDie()
	{
		BulletPoolManager instance = BulletPoolManager.Instance;
		BulletType bulletType = this.theBulletType;
		BulletType valueOrDefault = CollectionExtensions.GetValueOrDefault<BulletType, ObjectPool<Bullet>>(instance.pools, bulletType);
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x0001AD4C File Offset: 0x00018F4C
	[Token(Token = "0x600051F")]
	[Address(RVA = "0x5E29E0", Offset = "0x5E0FE0", VA = "0x1805E29E0", Slot = "12")]
	protected virtual void Update()
	{
		if (this._moveWay != BulletMoveWay.Stable)
		{
			float deltaTime = Time.deltaTime;
			this.theExistTime = deltaTime;
		}
		float num = this.theExistTime;
		if ((num > 0.75f && this._moveWay == BulletMoveWay.Puff) || num > 20f)
		{
			this.Die();
		}
		Transform transform = this.shadow;
		int num2 = 0;
		if (transform != num2)
		{
			BulletMovement bulletMovement = this.bulletMovement;
		}
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x0001ADBC File Offset: 0x00018FBC
	[Token(Token = "0x6000520")]
	[Address(RVA = "0x5E09E0", Offset = "0x5DEFE0", VA = "0x1805E09E0", Slot = "13")]
	public virtual void JumpLand()
	{
		Board board = this.board;
		Transform transform = base.transform;
		int num = this.theBulletRow;
		int num2;
		if (board.GetBoxType(num2, num) == BoxType.Water)
		{
			Transform transform2 = base.transform;
			Vector3 vector;
			float z = vector.z;
		}
	}

	// Token: 0x06000521 RID: 1313 RVA: 0x0001AE04 File Offset: 0x00019004
	[Token(Token = "0x6000521")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "14")]
	protected virtual bool CannonEffect()
	{
		return false;
	}

	// Token: 0x06000522 RID: 1314 RVA: 0x0001AE14 File Offset: 0x00019014
	[Token(Token = "0x6000522")]
	[Address(RVA = "0x5DF710", Offset = "0x5DDD10", VA = "0x1805DF710", Slot = "15")]
	protected virtual void FixedUpdate()
	{
		this.bulletMovement.PositionUpdate();
		Board board = this.board;
		float fixedDeltaTime = Time.fixedDeltaTime;
		int num = 0;
		float fixedDeltaTime2 = Time.fixedDeltaTime;
		Vector2 vector;
		this.velocity = vector;
		this.velocity.y = (float)0;
		this.rb.velocity = num;
		this.HitLandUpdate();
		Transform transform = base.transform;
		if (this._moveWay != BulletMoveWay.Split_left)
		{
			if (this._moveWay != BulletMoveWay.Cannon)
			{
			}
			return;
		}
		float num2 = this.minX;
		float num3 = this.minY;
		this.Die();
	}

	// Token: 0x06000523 RID: 1315 RVA: 0x0001AEE0 File Offset: 0x000190E0
	[Token(Token = "0x6000523")]
	[Address(RVA = "0x5E0C20", Offset = "0x5DF220", VA = "0x1805E0C20", Slot = "16")]
	protected virtual void MoveDieUpdate(Vector2 currentPosition)
	{
		float num = this.minX;
		if (this._moveWay != BulletMoveWay.Throw)
		{
			if (num <= currentPosition)
			{
				float num2 = this.maxX;
				if (currentPosition <= num2)
				{
					float num3 = this.minY;
					return;
				}
			}
		}
		else if (num <= currentPosition && currentPosition <= this.maxX)
		{
			return;
		}
		this.Die();
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x0001AF2C File Offset: 0x0001912C
	[Token(Token = "0x6000524")]
	[Address(RVA = "0x5DFDE0", Offset = "0x5DE3E0", VA = "0x1805DFDE0")]
	private void HitLandUpdate()
	{
		BulletMoveWay moveWay = this._moveWay;
		if (moveWay != BulletMoveWay.Throw)
		{
			if (moveWay == BulletMoveWay.Cannon)
			{
				Vector2 vector = this.rb.velocity;
				Transform transform = base.transform;
				int num = 0;
				Transform child = transform.GetChild(num);
				int num2 = 0;
				Transform child2 = child.GetChild(num2);
				float y = this.cannonPos.y;
			}
			Board instance = Board.Instance;
			Transform transform2 = base.transform;
			Rigidbody2D rigidbody2D = this.rb;
			float num3 = this.height;
			Vector2 vector2 = rigidbody2D.velocity;
			float fixedDeltaTime = Time.fixedDeltaTime;
			int num4 = 0;
			this.height = num3;
			if (num4 > (int)num3)
			{
				this.HitLand();
			}
			Board board = this.board;
			if (this._moveWay != BulletMoveWay.PeaNut)
			{
				Transform transform3 = base.transform;
				Vector3 vector3;
				float y2 = vector3.y;
				Mouse instance2 = Mouse.Instance;
				Transform transform4 = base.transform;
				float num5;
				if (num5 > y2)
				{
					this.HitLand();
				}
			}
		}
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x0001B018 File Offset: 0x00019218
	[Token(Token = "0x6000525")]
	[Address(RVA = "0x5E0050", Offset = "0x5DE650", VA = "0x1805E0050", Slot = "17")]
	public virtual void HitLand()
	{
		int num = this.maxHitCount;
		this.hitCount = num;
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		this.Die();
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x0001B050 File Offset: 0x00019250
	[Token(Token = "0x6000526")]
	[Address(RVA = "0x5DFDC0", Offset = "0x5DE3C0", VA = "0x1805DFDC0", Slot = "18")]
	public virtual void HitBlock()
	{
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x0001B060 File Offset: 0x00019260
	[Token(Token = "0x6000527")]
	[Address(RVA = "0x5E1290", Offset = "0x5DF890", VA = "0x1805E1290")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		int num2 = this.maxHitCount;
		if (this.hitCount < num2 && !this.blocked)
		{
			BulletHelper bulletHelper = this.hitHelper;
			int num3 = 0;
			if (!(bulletHelper != num3))
			{
				if (this.maxHitCount > 1 && this.Ignore)
				{
					Physics2D.IgnoreCollision(this.col, collision);
				}
				if (this.<Team>k__BackingField != Team.AI)
				{
					Board instance = Board.Instance;
				}
				if (!collision.TryGetComponent<Plant>(num))
				{
					if (!collision.TryGetComponent<Zombie>(num) || !this.bulletMovement.CanHit(num))
					{
						goto IL_00B7;
					}
					this.HitZombie(num);
					if (this._moveWay == BulletMoveWay.Throw && this.dying && this.<Team>k__BackingField == Team.Player)
					{
						this.OnThrowHit();
					}
				}
				this.CheckPlant(num);
				IL_00B7:
				int num4 = this.maxHitCount;
				this.Die();
			}
		}
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x0001B13C File Offset: 0x0001933C
	[Token(Token = "0x6000528")]
	[Address(RVA = "0x5E0B90", Offset = "0x5DF190", VA = "0x1805E0B90", Slot = "19")]
	public virtual void KeepHiting(Zombie zombie)
	{
		int damage = this._damage;
		PlantType plantType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)1), plantType, num != 0UL);
	}

	// Token: 0x06000529 RID: 1321 RVA: 0x0001B16C File Offset: 0x0001936C
	[Token(Token = "0x6000529")]
	[Address(RVA = "0x5DDDE0", Offset = "0x5DC3E0", VA = "0x1805DDDE0", Slot = "20")]
	protected virtual bool Blocked(Plant plant)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			BulletType bulletType = this.theBulletType;
			if (bulletType == BulletType.Bullet_snowBall || bulletType == BulletType.Bullet_iceSword)
			{
				break;
			}
			int thePlantColumn = plant.thePlantColumn;
			int thePlantRow = plant.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(thePlantColumn, thePlantRow);
			bool flag;
			bool flag2;
			if (!flag || !flag2 || num != 0)
			{
			}
		}
		while (num2 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x0001B1E4 File Offset: 0x000193E4
	[Token(Token = "0x600052A")]
	[Address(RVA = "0x5DE960", Offset = "0x5DCF60", VA = "0x1805DE960")]
	private void CheckPlant(Plant plant)
	{
		Board instance = Board.Instance;
		Team team = plant.<Team>k__BackingField;
		bool flag;
		if (this.<Team>k__BackingField == team && (this.theBulletType == BulletType.Bullet_pea || this.theBulletType == BulletType.Bullet_puff) && flag && !plant.isShort)
		{
			return;
		}
		Team team2 = plant.<Team>k__BackingField;
		if (this.<Team>k__BackingField != team2)
		{
			int num = this.theBulletRow;
			if ((plant.thePlantRow == num || this._moveWay == BulletMoveWay.Free) && plant.thePlantType != PlantType.EndoFlame)
			{
				if (this._moveWay != BulletMoveWay.Throw)
				{
					if (plant.isShort)
					{
						return;
					}
					Animator anim = plant.anim;
					float speed = anim.speed;
					if (anim != 0)
					{
						PlantType thePlantType = plant.thePlantType;
						if (thePlantType == PlantType.RedEmeraldUmbrella || thePlantType == PlantType.MelonUmbrella)
						{
							return;
						}
					}
					Plant pumpkin = plant.Pumpkin;
					int num2 = 0;
					if (pumpkin != num2 && !pumpkin.isShort)
					{
						this.HitPlant(pumpkin);
						return;
					}
				}
				return;
			}
		}
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x0001B2E4 File Offset: 0x000194E4
	[Token(Token = "0x600052B")]
	[Address(RVA = "0x5E17D0", Offset = "0x5DFDD0", VA = "0x1805E17D0")]
	private void Rebound(Plant plant)
	{
		if (this._moveWay != BulletMoveWay.MoveRight)
		{
			int num = 0;
			this.OnMoveWayChanged((BulletMoveWay)num);
			this._moveWay = (BulletMoveWay)((ulong)0L);
		}
		Team team = plant.<Team>k__BackingField;
		this.<Team>k__BackingField = team;
		GameObject gameObject = base.gameObject;
		LayerMask bulletLayer = LayerMaskMgr.BulletLayer;
		BulletType bulletType = this.theBulletType;
		this.hitCount = (int)((ulong)0L);
		if (bulletType > BulletType.Bullet_doom)
		{
			if (bulletType == BulletType.Bullet_snowBall)
			{
				goto IL_0075;
			}
			if (bulletType == BulletType.Bullet_doom_big)
			{
			}
			if (bulletType == BulletType.Bullet_doom_ulti)
			{
				goto IL_0067;
			}
		}
		if (bulletType != BulletType.Bullet_superCherry)
		{
			goto IL_006F;
		}
		IL_0067:
		uint num2;
		this.Damage = (int)num2;
		IL_006F:
		if (bulletType != BulletType.Bullet_doom)
		{
			goto IL_007B;
		}
		IL_0075:
		plant.FlashOnce();
		IL_007B:
		if (plant.PotType == PlantType.UmbrellaPot)
		{
			int num3 = this._damage;
			num3 += num3;
			this.Damage = num3;
		}
		plant.anim.SetTrigger("block2");
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x0001B3A8 File Offset: 0x000195A8
	[Token(Token = "0x600052C")]
	[Address(RVA = "0x5E00E0", Offset = "0x5DE6E0", VA = "0x1805E00E0")]
	private void HitPlantInDream(Shooter shooter)
	{
		Plant plant = this.from;
		if (shooter != plant)
		{
			if (shooter == 0)
			{
				float fixedDeltaTime = Time.fixedDeltaTime;
				shooter.dreamTime = fixedDeltaTime;
				Bullet bullet = shooter.AnimShoot();
				int num = 0;
				if (!(bullet == num))
				{
					bullet.from = shooter;
					Transform transform = bullet.transform;
					int num2 = 0;
					int num3 = 0;
					transform.Translate(0.2f, (float)num3, (float)num2);
					CreateBullet instance = CreateBullet.Instance;
					Transform transform2 = bullet.transform;
					Transform transform3 = bullet.transform;
					BulletType bulletType = bullet.theBulletType;
					Bullet bullet2;
					Transform transform4 = bullet2.transform;
					int num4 = 0;
					int num5 = 0;
					transform4.Translate(-0.5f, (float)num5, (float)num4);
					Transform transform5 = bullet2.transform;
					bullet2.from = shooter;
					CreateBullet instance2 = CreateBullet.Instance;
					Transform transform6 = bullet.transform;
					Transform transform7 = bullet.transform;
					BulletType bulletType2 = bullet.theBulletType;
					Bullet bullet3;
					Transform transform8 = bullet3.transform;
					int num6 = 0;
					int num7 = 0;
					transform8.Translate(-0.5f, (float)num7, (float)num6);
					Transform transform9 = bullet3.transform;
					bullet3.from = shooter;
				}
			}
			this.Die();
		}
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x0001B4CC File Offset: 0x000196CC
	[Token(Token = "0x600052D")]
	[Address(RVA = "0x5DEBC0", Offset = "0x5DD1C0", VA = "0x1805DEBC0")]
	protected bool CheckZombie(Zombie zombie)
	{
		if (this.bulletMovement.CanHit(zombie))
		{
			this.HitZombie(zombie);
			if (this._moveWay == BulletMoveWay.Throw && this.dying && this.<Team>k__BackingField == Team.Player)
			{
				this.OnThrowHit();
			}
			return true;
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x0001B51C File Offset: 0x0001971C
	[Token(Token = "0x600052E")]
	[Address(RVA = "0x5E0E20", Offset = "0x5DF420", VA = "0x1805E0E20")]
	private void OnThrowHit()
	{
		Func<Plant, bool> func = delegate(Plant p)
		{
			int num4 = this.theBulletRow;
			if (p.thePlantRow != num4)
			{
			}
			return p.theStatus == PlantStatus.Default;
		};
		List<Plant> list;
		IEnumerable<Plant> enumerable = Enumerable.Where<Plant>(list, func);
		Func<Plant, int> <>9__88_ = Bullet.<>c.<>9__88_1;
		if (<>9__88_ == 0)
		{
			Func<Plant, int> func2;
			Bullet.<>c.<>9__88_1 = func2;
		}
		Plant plant = Enumerable.FirstOrDefault<Plant>(Enumerable.OrderBy<Plant, int>(enumerable, <>9__88_));
		int num = 0;
		if (plant != num)
		{
			int thePlantColumn = plant.thePlantColumn;
			Mouse instance = Mouse.Instance;
			Transform transform = base.transform;
			int num2;
			if (thePlantColumn < num2)
			{
				CreateBullet instance2 = CreateBullet.Instance;
				Transform transform2 = base.transform;
				Transform transform3 = base.transform;
				BulletType bulletType = this.theBulletType;
				int damage = this._damage;
				Bullet bullet;
				bullet._damage = damage;
				int num3 = this.maxHitCount;
				bullet.hitCount = num3;
				bullet.targetPlant = plant;
				plant.anim.SetTrigger("shoot");
				plant.theStatus = (PlantStatus)((ulong)25L);
				Transform transform4 = bullet.transform;
				Vector3 vector;
				float z = vector.z;
				Transform shoot = plant.shoot;
			}
		}
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x0001B620 File Offset: 0x00019820
	[Token(Token = "0x600052F")]
	[Address(RVA = "0x5E1D00", Offset = "0x5E0300", VA = "0x1805E1D00")]
	public void SetSpeed(Vector2 projetilePosition, Vector2 targetVelocity, Vector2 targetCurrentPosition, float flightTime)
	{
		float[] array;
		float num = array[0];
		this.velocity = num;
		float num2 = array[1];
		this.velocity.y = num2;
		float num3 = array[1];
		this.acceleration.y = num3;
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x0001B670 File Offset: 0x00019870
	[Token(Token = "0x6000530")]
	[Address(RVA = "0x5E2430", Offset = "0x5E0A30", VA = "0x1805E2430")]
	public void ThrowTo(Zombie zombie, [Optional] Vector2? pos, [Optional] float? flightTimer)
	{
		Transform transform = base.transform;
		Vector2 colliderPosition = zombie.ColliderPosition;
		Vector2 vector = zombie.Velocity;
		Vector2 colliderPosition2 = zombie.ColliderPosition;
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x0001B6A4 File Offset: 0x000198A4
	[Token(Token = "0x6000531")]
	[Address(RVA = "0x5E2040", Offset = "0x5E0640", VA = "0x1805E2040")]
	public void ThrowToNull([Optional] Vector2? pos, [Optional] float? flightTimer)
	{
		Transform transform = base.transform;
		Board board = this.board;
		GridSystem gridSystem = board.gridSystem;
		int columnNum = board.columnNum;
		int num = this.theBulletRow;
		Vector2 position = gridSystem.GetGrid(columnNum, num).Position;
		if (flightTimer != 0)
		{
		}
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x0001B6F4 File Offset: 0x000198F4
	[Token(Token = "0x6000532")]
	[Address(RVA = "0x5E21E0", Offset = "0x5E07E0", VA = "0x1805E21E0")]
	public void ThrowTo(Plant plant, [Optional] Vector2? pos, [Optional] float? flightTimer)
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Transform axis = plant.axis;
		Vector3 vector2;
		float z2 = vector2.z;
		if (flightTimer != 0)
		{
		}
		this.targetPlant = plant;
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x0001B734 File Offset: 0x00019934
	[Token(Token = "0x6000533")]
	[Address(RVA = "0x5E2620", Offset = "0x5E0C20", VA = "0x1805E2620")]
	public void ThrowTo(Vector2 targetPosition, [Optional] Vector2? pos, [Optional] float? flightTimer)
	{
		Transform transform = base.transform;
		if (flightTimer != 0)
		{
		}
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x0001B754 File Offset: 0x00019954
	[Token(Token = "0x6000534")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "21")]
	protected virtual void HitPlant(Plant plant)
	{
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x0001B764 File Offset: 0x00019964
	[Token(Token = "0x6000535")]
	[Address(RVA = "0x5E0590", Offset = "0x5DEB90", VA = "0x1805E0590")]
	public void Hit(Zombie zombie)
	{
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x0001B774 File Offset: 0x00019974
	[Token(Token = "0x6000536")]
	[Address(RVA = "0x5E0510", Offset = "0x5DEB10", VA = "0x1805E0510", Slot = "22")]
	protected virtual void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		int num = 0;
		PlantType plantType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, plantType, num2 != 0UL);
		this.PlaySound(zombie);
		this.Die();
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x0001B7B0 File Offset: 0x000199B0
	[Token(Token = "0x6000537")]
	[Address(RVA = "0x5E14D0", Offset = "0x5DFAD0", VA = "0x1805E14D0")]
	protected void PlaySound(Zombie zombie)
	{
		while (zombie.theSecondArmorType == Zombie.SecondArmorType.Nothing || this._moveWay == BulletMoveWay.Throw || zombie.theSecondArmorType > Zombie.SecondArmorType.Protal)
		{
			if (zombie.theFirstArmorType == Zombie.FirstArmorType.Nothing)
			{
				ZombieType theZombieType = zombie.theZombieType;
				int num2;
				if (theZombieType > ZombieType.SuperBombThrower)
				{
					int num;
					if (theZombieType > ZombieType.UltimateJacksonDriver)
					{
						if (theZombieType > ZombieType.CherrySubmarine)
						{
							while (theZombieType == ZombieType.MachineLevatation)
							{
							}
							if (typeof(GameAPP).TypeHandle > (ulong)19L)
							{
								goto IL_0088;
							}
						}
						while (typeof(GameAPP).TypeHandle == (ulong)234L)
						{
						}
						while (typeof(GameAPP).TypeHandle <= (ulong)1L)
						{
						}
						IL_0088:
						num = 0;
					}
					while (num == 210)
					{
					}
					while (num == 219)
					{
					}
					while (18446744073709551395UL <= (ulong)1L)
					{
					}
					num2 = 0;
				}
				int num3;
				if (num2 > 46)
				{
					while (num2 == 53)
					{
					}
					while (18446744073709551416UL <= (ulong)1L)
					{
					}
					while (18446744073709551411UL <= (ulong)1L)
					{
					}
					num3 = 0;
				}
				while (-14 == 0)
				{
				}
				while (-14 == 0)
				{
				}
				while (-14 == 0)
				{
				}
				while (-14 == 0)
				{
				}
				while (18446744073709551602UL == (ulong)1L)
				{
				}
				while (num3 == 26)
				{
				}
				while (18446744073709551578UL > (ulong)8L)
				{
				}
			}
			if (zombie.theFirstArmorType <= Zombie.FirstArmorType.Balloon)
			{
				uint num4;
				GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num4), 0.5f, 1f);
				uint num6;
				uint num7;
				int num5 = global::UnityEngine.Random.Range((int)num6, (int)num7);
				throw new NullReferenceException();
			}
		}
		uint num8;
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num8), 0.5f, 1f);
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x0001B8E4 File Offset: 0x00019AE4
	[Token(Token = "0x6000538")]
	[Address(RVA = "0x5DF540", Offset = "0x5DDB40", VA = "0x1805DF540")]
	public void FireZombie(Zombie zombie, bool warm = true)
	{
		int num = 0;
		int damage = this._damage;
		PlantType plantType = this.fromType;
		zombie.TakeDamage(damage, this, (DamageType)num, plantType, num != 0);
		if (warm)
		{
			zombie.Warm();
			if (Lawnf.TravelAdvanced((AdvBuff)((uint)9)))
			{
				zombie.SetJalaed();
			}
		}
		if (!this.AllowSputter(zombie))
		{
			if (!warm)
			{
				goto IL_007F;
			}
			this.PlaySound(zombie);
		}
		if (warm)
		{
			GameAPP.PlaySound(global::UnityEngine.Random.Range(59, 61), 0.5f, 1f);
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
		}
		this.FireOtherZombie(zombie, warm);
		IL_007F:
		this.Die();
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x0001B980 File Offset: 0x00019B80
	[Token(Token = "0x6000539")]
	[Address(RVA = "0x5DEE80", Offset = "0x5DD480", VA = "0x1805DEE80")]
	private void FireOtherZombie(Zombie targetZombie, bool warm)
	{
		ulong num6;
		do
		{
			int num = 0;
			List<Zombie> list = new List();
			int damage = this._damage;
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			LayerMask layerMask = this.zombieLayer;
			int i = 0;
			int num2 = 0;
			Collider2D[] array;
			if (num2 < array.Length)
			{
				bool flag;
				bool flag2;
				if (flag && !flag2)
				{
					int num3 = this.theBulletRow;
					if (num3 != 1)
					{
						num3 += -3;
						if (num3 > 3 && num3 > 2 && num3 > 2)
						{
							ulong num4;
							if (num4 > (ulong)12L)
							{
								if (num4 == (ulong)20L || num3 <= 2 || num4 != (ulong)44L)
								{
									goto IL_00D4;
								}
								i++;
								if (i <= 4)
								{
									goto IL_00D4;
								}
								if (i <= 6)
								{
								}
								if (i <= 1 || i == 0)
								{
									goto IL_00D4;
								}
								while (i == 0)
								{
								}
								if (i == 0)
								{
									goto IL_00D4;
								}
								while (i == 0)
								{
								}
								if (i == 1)
								{
									goto IL_00D4;
								}
								while (i > 8)
								{
								}
							}
							if (i <= 8)
							{
							}
						}
					}
				}
				IL_00D4:
				i++;
			}
			if (list._size == 0)
			{
				break;
			}
			if (this.theBulletType == BulletType.Bullet_cherry || num * (int)0.33f <= (int)1f)
			{
			}
			bool flag3;
			if (flag3)
			{
				PlantType plantType = this.fromType;
				bool flag4;
				while (!flag4)
				{
				}
			}
			ulong num5;
			if (num5 != (ulong)0L)
			{
				goto IL_012F;
			}
			bool flag5;
			if (flag5)
			{
			}
		}
		while (num6 != (ulong)0L);
		return;
		IL_012F:
		throw new NullReferenceException();
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x0001BAC4 File Offset: 0x00019CC4
	[Token(Token = "0x600053A")]
	[Address(RVA = "0x5DDC20", Offset = "0x5DC220", VA = "0x1805DDC20")]
	private bool AllowSputter(Zombie zombie)
	{
		Zombie.SecondArmorType theSecondArmorType = zombie.theSecondArmorType;
		if (theSecondArmorType == Zombie.SecondArmorType.Door || theSecondArmorType <= Zombie.SecondArmorType.Ladder)
		{
			goto IL_0039;
		}
		ZombieType theZombieType = zombie.theZombieType;
		if (theZombieType <= ZombieType.JacksonDriver)
		{
			goto IL_0085;
		}
		if (theZombieType <= ZombieType.UltimateImpKing)
		{
			goto IL_006C;
		}
		if (theZombieType > ZombieType.Submarine_c2)
		{
			if (theSecondArmorType <= Zombie.SecondArmorType.Paper || theSecondArmorType <= Zombie.SecondArmorType.Paper)
			{
				goto IL_0039;
			}
			goto IL_0049;
		}
		IL_003B:
		while (zombie == (ulong)237L)
		{
		}
		int i;
		while (i <= 4)
		{
		}
		goto IL_0049;
		IL_006C:
		while (zombie == (ulong)210L)
		{
		}
		int j;
		if (j <= 6)
		{
		}
		while (zombie == (ulong)234L)
		{
		}
		goto IL_0085;
		IL_0039:
		i = 0;
		goto IL_003B;
		IL_0049:
		ZombieStatus zombieStatus = zombie.theStatus;
		if (zombieStatus <= ZombieStatus.Miner_digging)
		{
			goto IL_00C4;
		}
		while (zombieStatus == ZombieStatus.Polo_bigJump)
		{
		}
		while (i <= 2)
		{
		}
		if (zombieStatus == ZombieStatus.Bungi_awake)
		{
			j = 0;
			goto IL_006C;
		}
		goto IL_00C9;
		IL_0085:
		if (zombie > (ulong)46L)
		{
			while (zombie == (ulong)71L)
			{
			}
			while (zombie == (ulong)112L)
			{
			}
			while (j <= 1)
			{
			}
		}
		while (j == 0)
		{
		}
		while (j == 0)
		{
		}
		while (j == 0)
		{
		}
		while (j == 0)
		{
		}
		while (j == 1)
		{
		}
		while (zombie == (ulong)31L)
		{
		}
		while (j > 8)
		{
		}
		IL_00C4:
		if (j <= 8)
		{
		}
		IL_00C9:
		throw new NullReferenceException();
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x0001BBA4 File Offset: 0x00019DA4
	[Token(Token = "0x600053B")]
	[Address(RVA = "0x5E0AA0", Offset = "0x5DF0A0", VA = "0x1805E0AA0")]
	public void JumpUpdate()
	{
		Transform transform = base.transform;
		Transform transform2 = this.shadow;
		Vector3 vector;
		float y = vector.y;
		Vector3 vector2;
		float y2 = vector2.y;
		Transform transform3 = base.transform;
		Transform transform4 = this.shadow;
		Vector3 vector3;
		float z = vector3.z;
		this.velocity.y = 4f;
		this.JumpLand();
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x0001BC08 File Offset: 0x00019E08
	[Token(Token = "0x600053C")]
	[Address(RVA = "0x5E1AB0", Offset = "0x5E00B0", VA = "0x1805E1AB0")]
	public void RightUpdate()
	{
		float num = this.normalSpeed;
		this.velocity = num;
		this.velocity.y = 0f;
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x0001BC34 File Offset: 0x00019E34
	[Token(Token = "0x600053D")]
	[Address(RVA = "0x5E1AD0", Offset = "0x5E00D0", VA = "0x1805E1AD0")]
	public void RollingUpdate()
	{
		while (!this.isLand)
		{
			Vector2 gravity = Physics2D.gravity;
			this.acceleration.y = (float)0;
			float num = this.moveSpeed * 0.4f;
			this.velocity = num;
			Transform transform = base.transform;
			Transform transform2 = this.shadow;
			Vector3 vector;
			float y = vector.y;
			Vector3 vector2;
			if (vector2.y > y)
			{
				Transform transform3 = base.transform;
				Transform transform4 = base.transform;
				Transform transform5 = this.shadow;
				this.isLand = true;
				return;
			}
		}
		Board instance = Board.Instance;
		Vector2 zeroVector = Vector2.zeroVector;
		this.acceleration = zeroVector;
		this.velocity.y = 0f;
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x0001BCE8 File Offset: 0x00019EE8
	[Token(Token = "0x600053E")]
	[Address(RVA = "0x5DF9D0", Offset = "0x5DDFD0", VA = "0x1805DF9D0")]
	public void FreeUpdate()
	{
		BlackHole blackHole = this.blackHole;
		int num = 0;
		if (blackHole == num)
		{
			Transform transform = base.transform;
			float num2 = this.normalSpeed;
			this.velocity = num2;
			this.velocity.y = num2;
		}
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x0001BD34 File Offset: 0x00019F34
	[Token(Token = "0x600053F")]
	[Address(RVA = "0x5E0BF0", Offset = "0x5DF1F0", VA = "0x1805E0BF0")]
	public void LeftUpdate()
	{
		float num = this.normalSpeed;
		this.velocity = num;
		this.velocity.y = 0f;
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x0001BD60 File Offset: 0x00019F60
	[Token(Token = "0x6000540")]
	[Address(RVA = "0x5DE180", Offset = "0x5DC780", VA = "0x1805DE180")]
	public void CannonBulletUpdate()
	{
		int num = 0;
		Transform transform = base.transform;
		int num2 = 0;
		Transform child = transform.GetChild(num2);
		Transform transform2 = base.transform;
		Vector2 vector = this.cannonPos;
		Transform transform3 = base.transform;
		Board instance = Board.Instance;
		float num3 = vector * -3f;
		this.velocity.y = num3;
		this.velocity = num;
		if (!this.CannonEffect())
		{
			if (this.theStatus != (BulletStatus)num)
			{
				BulletStatus bulletStatus = this.theStatus;
				this.theStatus = (BulletStatus)num;
				if (bulletStatus != BulletStatus.Melon_cannon)
				{
					CreateBullet instance2 = CreateBullet.Instance;
					Transform transform4 = base.transform;
					Transform transform5 = base.transform;
					int num4 = 0;
					BulletMoveWay moveWay = this._moveWay;
					BulletType bulletType = this.theBulletType;
					float num5 = this.theExistTime;
					Bullet bullet;
					bullet.theExistTime = num5;
					Board instance3 = Board.Instance;
					int rowNum = instance3.rowNum;
					int columnNum = instance3.columnNum;
					int num6 = instance3.columnNum;
					num6 -= typeof(Board).TypeHandle;
					int num7 = this.theBulletRow;
					Vector2 randomGrid = Lawnf.GetRandomGrid(num6, num7, num4, columnNum, rowNum);
					bullet.cannonPos = num3;
					bullet.cannonPos.y = num3;
					Transform transform6 = bullet.transform;
					float num8 = global::UnityEngine.Random.Range(3f, 15f);
					int num9 = bullet.theBulletRow;
					bullet.theBulletRow = num9;
					int damage = this._damage;
					bullet._damage = damage;
					PlantType plantType = this.fromType;
					bullet.fromType = plantType;
					bullet.CannonBulletUpdate();
					num++;
					this.Die();
				}
				CreateBullet instance4 = CreateBullet.Instance;
				Transform transform7 = base.transform;
				Transform transform8 = base.transform;
				BulletMoveWay moveWay2 = this._moveWay;
				BulletType bulletType2 = this.theBulletType;
				float num10 = this.theExistTime;
				Bullet bullet2;
				bullet2.theExistTime = num10;
				Mouse instance5 = Mouse.Instance;
				Transform transform9 = bullet2.transform;
				int num11 = 0;
				int num12 = this.theBulletRow;
				int num13;
				uint num14;
				ulong num15;
				Vector2 randomGrid2 = Lawnf.GetRandomGrid(num13, num12, num11, (int)num14, (int)num15);
				bullet2.cannonPos = num3;
				bullet2.cannonPos.y = num3;
				Transform transform10 = bullet2.transform;
				float num16 = global::UnityEngine.Random.Range(3f, 15f);
				int num17 = bullet2.theBulletRow;
				bullet2.theBulletRow = num17;
				int damage2 = this._damage;
				bullet2._damage = damage2;
				bullet2.CannonBulletUpdate();
				PlantType plantType2 = this.fromType;
				num++;
				bullet2.fromType = plantType2;
			}
			ulong num18;
			this.shadow.gameObject.SetActive(num18 != 0UL);
			return;
		}
		this.Die();
		Transform transform11 = base.transform;
		int num19 = 0;
		Transform child2 = transform11.GetChild(num19);
		Board instance6 = Board.Instance;
		this.velocity = num;
		throw new NullReferenceException();
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x0001BFFC File Offset: 0x0001A1FC
	[Token(Token = "0x6000541")]
	[Address(RVA = "0x5E19F0", Offset = "0x5DFFF0", VA = "0x1805E19F0")]
	public void RightFreeUpdate()
	{
		float num = this.theExistTime;
		if (num <= 0.6f)
		{
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			float num2 = num * this.normalSpeed;
			this.velocity = num2;
			float num3 = num2 * 0.4f * this.normalSpeed;
			this.velocity.y = num3;
			return;
		}
		if (this._moveWay != BulletMoveWay.Free)
		{
			this.OnMoveWayChanged((BulletMoveWay)((uint)5));
			this._moveWay = (BulletMoveWay)((ulong)5L);
		}
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x0001C078 File Offset: 0x0001A278
	[Token(Token = "0x6000542")]
	[Address(RVA = "0x5E2780", Offset = "0x5E0D80", VA = "0x1805E2780", Slot = "23")]
	public virtual void TrackUpdate()
	{
		BulletMovement bulletMovement = this.bulletMovement;
		Zombie zombie = this.targetZombie;
		if (!bulletMovement.CanSearch(zombie))
		{
			Zombie nearestZombie = this.GetNearestZombie();
			this.targetZombie = nearestZombie;
		}
		Zombie zombie2 = this.targetZombie;
		int num = 0;
		if (!(zombie2 != num))
		{
			Transform transform = base.transform;
			float num2 = this.trackSpeed;
			this.velocity.y = num2;
			this.velocity = num2;
			return;
		}
		Vector2 centerPosition = this.targetZombie.CenterPosition;
		Vector2 position = this.rb.position;
		float num3 = this.trackSpeed;
		this.velocity.y = num3;
		this.velocity = num3;
		float num4;
		this.rb.rotation = num4;
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x0001C134 File Offset: 0x0001A334
	[Token(Token = "0x6000543")]
	[Address(RVA = "0x5E1DE0", Offset = "0x5E03E0", VA = "0x1805E1DE0")]
	public void SmoothTrackUpdate()
	{
		BulletMovement bulletMovement = this.bulletMovement;
		Zombie zombie = this.targetZombie;
		if (!bulletMovement.CanSearch(zombie))
		{
			Zombie nearestZombie = this.GetNearestZombie();
			this.targetZombie = nearestZombie;
		}
		Zombie zombie2 = this.targetZombie;
		int num = 0;
		if (zombie2 != num)
		{
			Vector2 centerPosition = this.targetZombie.CenterPosition;
			Vector2 position = this.rb.position;
			float num2 = this.rb.rotation;
			float fixedDeltaTime = Time.fixedDeltaTime;
			float num3;
			if (0 > (int)num3 || num3 > 360f)
			{
			}
			Rigidbody2D rigidbody2D = this.rb;
			float num4;
			num2 = num4;
			rigidbody2D.rotation = num4;
			num4 = num2;
			float num5 = num4 * 0.017453292f;
			this.velocity = num5;
			this.velocity.y = num5;
		}
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x0001C200 File Offset: 0x0001A400
	[Token(Token = "0x6000544")]
	[Address(RVA = "0x5DFAE0", Offset = "0x5DE0E0", VA = "0x1805DFAE0", Slot = "24")]
	protected virtual Zombie GetNearestZombie()
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
				if (!(num != num3) || !this.bulletMovement.CanSearch(num))
				{
					continue;
				}
				Transform transform = base.transform;
			}
		}
		while (num2 != 0);
		int num4 = 0;
		bool flag2 = num2 != num4;
		throw new NullReferenceException();
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x0001C27C File Offset: 0x0001A47C
	[Token(Token = "0x6000545")]
	[Address(RVA = "0x5DE0C0", Offset = "0x5DC6C0", VA = "0x1805DE0C0", Slot = "6")]
	public bool CanAttack(IDamageable target)
	{
		int num = 0;
		if (num < target)
		{
			num += num;
			num++;
		}
		return typeof(IDamageable).TypeHandle != this.<Team>k__BackingField;
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x0001C2B0 File Offset: 0x0001A4B0
	[Token(Token = "0x6000546")]
	[Address(RVA = "0x5E2AD0", Offset = "0x5E10D0", VA = "0x1805E2AD0")]
	public Bullet()
	{
		List<BulletHitFilter> list = new List();
		this.hitFilters = list;
		base..ctor();
	}

	// Token: 0x04000312 RID: 786
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000312")]
	public Board board;

	// Token: 0x04000313 RID: 787
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000313")]
	public SortingGroup sortingGroup;

	// Token: 0x04000314 RID: 788
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000314")]
	public Transform shadow;

	// Token: 0x04000315 RID: 789
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000315")]
	public Rigidbody2D rb;

	// Token: 0x04000316 RID: 790
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000316")]
	public Collider2D col;

	// Token: 0x04000317 RID: 791
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000317")]
	public BulletHelper hitHelper;

	// Token: 0x04000318 RID: 792
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000318")]
	public LayerMask zombieLayer;

	// Token: 0x04000319 RID: 793
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000319")]
	public BulletType theBulletType;

	// Token: 0x0400031A RID: 794
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400031A")]
	public float minX;

	// Token: 0x0400031B RID: 795
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400031B")]
	public float minY;

	// Token: 0x0400031C RID: 796
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400031C")]
	public float maxX;

	// Token: 0x0400031D RID: 797
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400031D")]
	public float maxY;

	// Token: 0x0400031E RID: 798
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400031E")]
	public BulletMovement bulletMovement;

	// Token: 0x0400031F RID: 799
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400031F")]
	public Zombie targetZombie;

	// Token: 0x04000320 RID: 800
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000320")]
	public Plant targetPlant;

	// Token: 0x04000321 RID: 801
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000321")]
	public List<AirProjectile> targetProjectiles;

	// Token: 0x04000322 RID: 802
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000322")]
	public Plant torchWood;

	// Token: 0x04000323 RID: 803
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000323")]
	public Plant from;

	// Token: 0x04000324 RID: 804
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000324")]
	public Zombie from_zombie;

	// Token: 0x04000325 RID: 805
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000325")]
	public PlantType fromType;

	// Token: 0x04000326 RID: 806
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000326")]
	public BlackHole blackHole;

	// Token: 0x04000327 RID: 807
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000327")]
	public BulletStatus theStatus;

	// Token: 0x04000328 RID: 808
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4000328")]
	public int rogueStatus;

	// Token: 0x04000329 RID: 809
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000329")]
	public Vector2 cannonPos;

	// Token: 0x0400032A RID: 810
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400032A")]
	public int theBulletRow;

	// Token: 0x0400032B RID: 811
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x400032B")]
	public bool shootByZombie;

	// Token: 0x0400032C RID: 812
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400032C")]
	[SerializeField]
	private BulletMoveWay _moveWay;

	// Token: 0x0400032D RID: 813
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400032D")]
	public List<BulletHitFilter> hitFilters;

	// Token: 0x0400032F RID: 815
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x400032F")]
	public int _damage;

	// Token: 0x04000331 RID: 817
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x4000331")]
	public int hitCount;

	// Token: 0x04000332 RID: 818
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000332")]
	public int maxHitCount;

	// Token: 0x04000333 RID: 819
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4000333")]
	public int attributeCount;

	// Token: 0x04000334 RID: 820
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000334")]
	public int indexInArray;

	// Token: 0x04000335 RID: 821
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x4000335")]
	public int shootingLevel;

	// Token: 0x04000336 RID: 822
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000336")]
	public bool isLand;

	// Token: 0x04000337 RID: 823
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xF9")]
	[Token(Token = "0x4000337")]
	public bool melonSputter;

	// Token: 0x04000338 RID: 824
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xFA")]
	[Token(Token = "0x4000338")]
	public bool umbrellaed;

	// Token: 0x04000339 RID: 825
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xFB")]
	[Token(Token = "0x4000339")]
	public bool goldMagneted;

	// Token: 0x0400033A RID: 826
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x400033A")]
	public bool accelerate;

	// Token: 0x0400033B RID: 827
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
	[Token(Token = "0x400033B")]
	public bool blocked;

	// Token: 0x0400033C RID: 828
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400033C")]
	public CancellationTokenSource cancellationTokenSource;

	// Token: 0x0400033D RID: 829
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400033D")]
	public float angularVelocity;

	// Token: 0x0400033E RID: 830
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x400033E")]
	public Vector2 velocity;

	// Token: 0x0400033F RID: 831
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Token(Token = "0x400033F")]
	public Vector2 acceleration;

	// Token: 0x04000340 RID: 832
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x4000340")]
	public float moveSpeed;

	// Token: 0x04000341 RID: 833
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000341")]
	public float trackSpeed;

	// Token: 0x04000342 RID: 834
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Token(Token = "0x4000342")]
	public float normalSpeed;

	// Token: 0x04000343 RID: 835
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000343")]
	public float magnetNutAngle;

	// Token: 0x04000344 RID: 836
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x4000344")]
	public float theExistTime;

	// Token: 0x04000345 RID: 837
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000345")]
	public float shootingfloat;

	// Token: 0x04000346 RID: 838
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Token(Token = "0x4000346")]
	private float height;

	// Token: 0x04000347 RID: 839
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000347")]
	private bool dying;
}
