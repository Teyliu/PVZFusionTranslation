using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Rendering;

// Token: 0x02000106 RID: 262
[Token(Token = "0x2000106")]
public class Bullet : MonoBehaviour, IDamageMaker
{
	// Token: 0x17000064 RID: 100
	// (get) Token: 0x060004F6 RID: 1270 RVA: 0x0001A49C File Offset: 0x0001869C
	// (set) Token: 0x060004F7 RID: 1271 RVA: 0x0001A4B0 File Offset: 0x000186B0
	[Token(Token = "0x17000064")]
	public BulletMoveWay MoveWay
	{
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x5ACF70", Offset = "0x5AB570", VA = "0x1805ACF70")]
		get
		{
			return this._moveWay;
		}
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x5AD050", Offset = "0x5AB650", VA = "0x1805AD050")]
		set
		{
			while (this._moveWay != value)
			{
				if (value > BulletMoveWay.Convolute)
				{
					if (value == BulletMoveWay.Track_air_singleRow || value == BulletMoveWay.Pirouette)
					{
						BulletHelper bulletHelper = this.hitHelper;
						int num = 0;
						if (bulletHelper == num)
						{
							BulletHelper bulletHelper2 = this.AddComponent<BulletHelper>();
							this.hitHelper = bulletHelper2;
							this.hitHelper.bullet = this;
						}
						BulletMovement bulletMovement;
						this.bulletMovement = bulletMovement;
						this.bulletMovement.bullet = this;
						this._moveWay = value;
						break;
					}
				}
				else
				{
					while (value == BulletMoveWay.Track)
					{
					}
					while (value == BulletMoveWay.Convolute)
					{
					}
				}
				BulletHelper bulletHelper3 = this.hitHelper;
				int num2 = 0;
				if (bulletHelper3 != num2)
				{
					global::UnityEngine.Object.Destroy(this.hitHelper);
					this.hitHelper = (ulong)0L;
					throw new NullReferenceException();
				}
			}
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x060004F8 RID: 1272 RVA: 0x0001A560 File Offset: 0x00018760
	[Token(Token = "0x17000065")]
	public virtual ParticleType ParticleType
	{
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x5ACF80", Offset = "0x5AB580", VA = "0x1805ACF80", Slot = "7")]
		get;
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x060004F9 RID: 1273 RVA: 0x0001A574 File Offset: 0x00018774
	// (set) Token: 0x060004FA RID: 1274 RVA: 0x0001A588 File Offset: 0x00018788
	[Token(Token = "0x17000066")]
	public int Damage
	{
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x5ACF60", Offset = "0x5AB560", VA = "0x1805ACF60")]
		get
		{
			return this._damage;
		}
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x5ACFA0", Offset = "0x5AB5A0", VA = "0x1805ACFA0")]
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

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x060004FB RID: 1275 RVA: 0x0001A5E0 File Offset: 0x000187E0
	// (set) Token: 0x060004FC RID: 1276 RVA: 0x0001A5F4 File Offset: 0x000187F4
	[Token(Token = "0x17000067")]
	public Team Team
	{
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x5ACF90", Offset = "0x5AB590", VA = "0x1805ACF90", Slot = "4")]
		get;
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x5AD1E0", Offset = "0x5AB7E0", VA = "0x1805AD1E0", Slot = "5")]
		set;
	}

	// Token: 0x060004FD RID: 1277 RVA: 0x0001A608 File Offset: 0x00018808
	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x5A9EF0", Offset = "0x5A84F0", VA = "0x1805A9EF0", Slot = "8")]
	public virtual void InitData()
	{
		int num = 0;
		this.attributeCount = num;
		this.shootingfloat = (float)num;
		this.shootingLevel = num;
		this.from = num;
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
		this.trackSpeed = 5f;
		this.theExistTime = (float)num;
		this.hitTimes = num;
		this.theStatus = (BulletStatus)num;
		this.normalSpeed = 6f;
		this.height = 0.3f;
		this.dying = num != 0;
		this.goldThreeTorch = num != 0;
		this.hit = num != 0;
		this.goldMagneted = num != 0;
		rigidbody2D.velocity = num2;
		this.col.enabled = true;
		this.Vx = (float)num;
		this.detaVx = (float)num;
		if (this.<Team>k__BackingField != Team.AI)
		{
			GameObject gameObject = base.gameObject;
			int num3 = LayerMaskMgr.BulletLayer;
			gameObject.layer = num3;
			Board instance = Board.Instance;
			BulletType bulletType = this.theBulletType;
			if (bulletType != BulletType.Bullet_pea && bulletType != BulletType.Bullet_puff)
			{
				goto IL_0168;
			}
			Rigidbody2D rigidbody2D2 = this.rb;
			LayerMask layerMask = LayerMask.GetMask(new string[] { "Plant" });
		}
		GameObject gameObject2 = base.gameObject;
		int num4 = LayerMaskMgr.ZombieBulletLayer;
		gameObject2.layer = num4;
		IL_0168:
		if ((this._moveWay > BulletMoveWay.Track && num4 <= 1) || num4 == -5)
		{
			this.sortingGroup.sortingLayerName = "bullet11";
		}
		Transform transform = this.shadow;
		int num5 = 0;
		if (transform != num5)
		{
			BulletMovement bulletMovement = this.bulletMovement;
			if (bulletMovement != 0)
			{
				bulletMovement.ShadowUpdate();
			}
		}
		Board board = this.board;
		float num6 = this.trackSpeed;
		this.trackSpeed = num6;
	}

	// Token: 0x060004FE RID: 1278 RVA: 0x0001A7EC File Offset: 0x000189EC
	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x5AA660", Offset = "0x5A8C60", VA = "0x1805AA660")]
	public void OnMoveWayChanged(BulletMoveWay moveWay)
	{
		BulletHelper bulletHelper3;
		int num2;
		do
		{
			if (moveWay > BulletMoveWay.Convolute)
			{
				if (moveWay != BulletMoveWay.Track_air_singleRow && moveWay != BulletMoveWay.Pirouette)
				{
					goto IL_005B;
				}
				BulletHelper bulletHelper = this.hitHelper;
				int num = 0;
				if (bulletHelper == num)
				{
					BulletHelper bulletHelper2 = this.AddComponent<BulletHelper>();
					this.hitHelper = bulletHelper2;
					this.hitHelper.bullet = this;
				}
				BulletMovement bulletMovement;
				this.bulletMovement = bulletMovement;
				this.bulletMovement.bullet = this;
			}
			while (moveWay == BulletMoveWay.Track)
			{
			}
			while (moveWay == BulletMoveWay.Convolute)
			{
			}
			IL_005B:
			bulletHelper3 = this.hitHelper;
			num2 = 0;
		}
		while (!(bulletHelper3 != num2));
		global::UnityEngine.Object.Destroy(this.hitHelper);
		this.hitHelper = (ulong)0L;
		throw new NullReferenceException();
	}

	// Token: 0x060004FF RID: 1279 RVA: 0x0001A888 File Offset: 0x00018A88
	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "9")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x0001A898 File Offset: 0x00018A98
	[Token(Token = "0x6000500")]
	[Address(RVA = "0x5A7D20", Offset = "0x5A6320", VA = "0x1805A7D20")]
	public void Die()
	{
		if (!this.dying)
		{
			Board board = this.board;
			this.dying = true;
			this.hit = true;
			CreateBullet.Instance.RemoveFromList(this);
			this.OnDeath();
			GameObject gameObject = base.gameObject;
			int num = 0;
			gameObject.SetActive(num != 0);
			DelayAction delayAction = GameAPP.delayAction;
			Action action = new Action(this.DelayDie);
			int num2 = 0;
			delayAction.SetAction(action, (float)num2);
		}
	}

	// Token: 0x06000501 RID: 1281 RVA: 0x0001A90C File Offset: 0x00018B0C
	[Token(Token = "0x6000501")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "10")]
	protected virtual void OnDeath()
	{
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x0001A91C File Offset: 0x00018B1C
	[Token(Token = "0x6000502")]
	[Address(RVA = "0x5A7C90", Offset = "0x5A6290", VA = "0x1805A7C90")]
	private void DelayDie()
	{
		BulletPoolManager instance = BulletPoolManager.Instance;
		BulletType bulletType = this.theBulletType;
		BulletType valueOrDefault = CollectionExtensions.GetValueOrDefault<BulletType, ObjectPool<Bullet>>(instance.pools, bulletType);
	}

	// Token: 0x06000503 RID: 1283 RVA: 0x0001A94C File Offset: 0x00018B4C
	[Token(Token = "0x6000503")]
	[Address(RVA = "0x5ACE30", Offset = "0x5AB430", VA = "0x1805ACE30", Slot = "11")]
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
			if (bulletMovement != 0)
			{
				bulletMovement.ShadowUpdate();
			}
		}
		if (this.theExistTime > 1f)
		{
			Zombie zombie = this.targetZombie;
			int num3 = 0;
			if (zombie == num3 && this._moveWay == BulletMoveWay.Track_air_singleRow)
			{
				this.HitLand();
			}
		}
	}

	// Token: 0x06000504 RID: 1284 RVA: 0x0001A9F8 File Offset: 0x00018BF8
	[Token(Token = "0x6000504")]
	[Address(RVA = "0x5ACC00", Offset = "0x5AB200", VA = "0x1805ACC00")]
	public void TrackZombieSingleRow(Zombie zombie)
	{
		Zombie zombie2 = this.targetZombie;
		if (zombie == zombie2 && !zombie.isMindControlled && zombie.theHealth > 0)
		{
			int num = this.theBulletRow;
			if (zombie.theZombieRow == num)
			{
				ZombieStatus zombieStatus = zombie.theStatus;
				if (zombieStatus > ZombieStatus.Miner_digging)
				{
					if (zombieStatus == ZombieStatus.Imp_fly || num <= 3 || zombieStatus == ZombieStatus.Bungi_awake)
					{
						return;
					}
				}
				else if (zombieStatus <= ZombieStatus.Bungi_awake)
				{
				}
				this.hit = true;
				this.HitZombie(zombie);
				this.Die();
				return;
			}
		}
	}

	// Token: 0x06000505 RID: 1285 RVA: 0x0001AA74 File Offset: 0x00018C74
	[Token(Token = "0x6000505")]
	[Address(RVA = "0x5AA290", Offset = "0x5A8890", VA = "0x1805AA290", Slot = "12")]
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

	// Token: 0x06000506 RID: 1286 RVA: 0x0001AABC File Offset: 0x00018CBC
	[Token(Token = "0x6000506")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	protected virtual bool CannonEffect()
	{
		return false;
	}

	// Token: 0x06000507 RID: 1287 RVA: 0x0001AACC File Offset: 0x00018CCC
	[Token(Token = "0x6000507")]
	[Address(RVA = "0x5A92B0", Offset = "0x5A78B0", VA = "0x1805A92B0")]
	protected Zombie GetSingleRowFlyingZombie()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Zombie> zombieArray = Board.Instance.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				int num4 = this.theBulletRow;
				bool flag2;
				while (!flag2)
				{
				}
				bool flag3;
				while (!flag3)
				{
				}
				Transform transform = base.transform;
				Vector3 vector;
				float z = vector.z;
			}
		}
		while (num2 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x06000508 RID: 1288 RVA: 0x0001AB48 File Offset: 0x00018D48
	[Token(Token = "0x6000508")]
	[Address(RVA = "0x5AC5A0", Offset = "0x5AABA0", VA = "0x1805AC5A0")]
	public void TrackSingleRowUpdate()
	{
		Zombie zombie = this.targetZombie;
		int num = 0;
		if (!(zombie == num))
		{
			Zombie zombie2 = this.targetZombie;
			if (zombie2.theStatus == ZombieStatus.Flying && zombie2.theHealth > 0 && !zombie2.isMindControlled)
			{
				Collider2D collider2D = zombie2.col;
				int num2 = 0;
				if (collider2D != num2 && this.targetZombie.col.enabled)
				{
					Collider2D collider2D2 = this.targetZombie.col;
					Transform transform = base.transform;
					Rigidbody2D rigidbody2D = this.rb;
					int num3 = 0;
					float num4 = this.trackSpeed;
					rigidbody2D.velocity = num3;
					float num5;
					this.rb.rotation = num5;
					return;
				}
			}
			Zombie singleRowFlyingZombie = this.GetSingleRowFlyingZombie();
			this.targetZombie = singleRowFlyingZombie;
		}
		Zombie singleRowFlyingZombie2 = this.GetSingleRowFlyingZombie();
		this.targetZombie = singleRowFlyingZombie2;
		Transform transform2 = base.transform;
		Rigidbody2D rigidbody2D2 = this.rb;
		Vector3 vector;
		float z = vector.z;
		throw new NullReferenceException();
	}

	// Token: 0x06000509 RID: 1289 RVA: 0x0001AC38 File Offset: 0x00018E38
	[Token(Token = "0x6000509")]
	[Address(RVA = "0x5A8C50", Offset = "0x5A7250", VA = "0x1805A8C50")]
	private Zombie GetNearestLandZombie()
	{
		int size = Board.Instance.zombieArray._size;
		int num = size - 1;
		if (size > 0)
		{
			Zombie zombie = Board.Instance.zombieArray[num];
			int num2 = 0;
			if (zombie != num2 && this.NearestZombieCondition(zombie))
			{
				Collider2D collider2D = zombie.col;
				int num3 = 0;
				if (collider2D != num3 && zombie.col.enabled)
				{
					Collider2D collider2D2 = zombie.col;
					Transform transform = base.transform;
					Vector3 vector;
					float z = vector.z;
					Collider2D collider2D3 = zombie.col;
					Transform transform2 = base.transform;
					Vector3 vector2;
					float z2 = vector2.z;
				}
			}
			if (num > 0)
			{
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600050A RID: 1290 RVA: 0x0001ACF0 File Offset: 0x00018EF0
	[Token(Token = "0x600050A")]
	[Address(RVA = "0x5A8F60", Offset = "0x5A7560", VA = "0x1805A8F60", Slot = "14")]
	protected virtual Zombie GetNearestZombie()
	{
		Zombie nearestFlyingZombie = this.GetNearestFlyingZombie();
		int num = 0;
		if (!(nearestFlyingZombie != num))
		{
			int size = Board.Instance.zombieArray._size;
			int num2 = size - 1;
			if (size > 0)
			{
				Zombie zombie = Board.Instance.zombieArray[num2];
				int num3 = 0;
				if (zombie != num3 && this.NearestZombieCondition(zombie))
				{
					Collider2D collider2D = zombie.col;
					int num4 = 0;
					if (collider2D != num4 && zombie.col.enabled)
					{
						Collider2D collider2D2 = zombie.col;
						Transform transform = base.transform;
						Vector3 vector;
						float z = vector.z;
						Collider2D collider2D3 = zombie.col;
						Transform transform2 = base.transform;
						Vector3 vector2;
						float z2 = vector2.z;
					}
				}
				if (num2 > 0)
				{
				}
			}
			return nearestFlyingZombie;
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600050B RID: 1291 RVA: 0x0001ADC4 File Offset: 0x00018FC4
	[Token(Token = "0x600050B")]
	[Address(RVA = "0x5AA5C0", Offset = "0x5A8BC0", VA = "0x1805AA5C0", Slot = "15")]
	protected virtual bool NearestZombieCondition(Zombie zombie)
	{
		if (zombie.theStatus > ZombieStatus.Pol_jump)
		{
		}
		while (zombie.isMindControlled)
		{
		}
		return zombie.theHealth > 0;
	}

	// Token: 0x0600050C RID: 1292 RVA: 0x0001ADF8 File Offset: 0x00018FF8
	[Token(Token = "0x600050C")]
	[Address(RVA = "0x5A8930", Offset = "0x5A6F30", VA = "0x1805A8930")]
	protected Zombie GetNearestFlyingZombie()
	{
		int size = Board.Instance.zombieArray._size;
		int num = size - 1;
		if (size > 0)
		{
			Zombie zombie = Board.Instance.zombieArray[num];
			int num2 = 0;
			if (zombie != num2 && zombie.theStatus == ZombieStatus.Flying && zombie.theHealth > 0 && !zombie.isMindControlled)
			{
				Collider2D collider2D = zombie.col;
				int num3 = 0;
				if (collider2D != num3 && zombie.col.enabled)
				{
					Collider2D collider2D2 = zombie.col;
					Transform transform = base.transform;
					Vector3 vector;
					float z = vector.z;
					Collider2D collider2D3 = zombie.col;
					Transform transform2 = base.transform;
					Vector3 vector2;
					float z2 = vector2.z;
				}
			}
			if (num > 0)
			{
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600050D RID: 1293 RVA: 0x0001AEC4 File Offset: 0x000190C4
	[Token(Token = "0x600050D")]
	[Address(RVA = "0x5A8710", Offset = "0x5A6D10", VA = "0x1805A8710", Slot = "16")]
	protected virtual void FixedUpdate()
	{
		BulletMovement bulletMovement = this.bulletMovement;
		if (bulletMovement != 0)
		{
			bulletMovement.PositionUpdate();
		}
		this.HitLandUpdate();
		Transform transform = base.transform;
		if (this._moveWay != BulletMoveWay.Split_left)
		{
			if (this._moveWay != BulletMoveWay.Cannon)
			{
			}
			return;
		}
		float num = this.minX;
		float num2 = this.minY;
		this.Die();
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x0001AF44 File Offset: 0x00019144
	[Token(Token = "0x600050E")]
	[Address(RVA = "0x5AA530", Offset = "0x5A8B30", VA = "0x1805AA530", Slot = "17")]
	protected virtual void MoveDieUpdate(Vector2 currentPosition)
	{
		if (this._moveWay != BulletMoveWay.Throw && this._moveWay != BulletMoveWay.Quick_throw)
		{
			if (this.minX <= currentPosition)
			{
				float num = this.maxX;
				if (currentPosition <= num)
				{
					float num2 = this.minY;
					return;
				}
			}
		}
		else if (this.minX <= currentPosition && currentPosition <= this.maxX)
		{
			return;
		}
		this.Die();
	}

	// Token: 0x0600050F RID: 1295 RVA: 0x0001AF9C File Offset: 0x0001919C
	[Token(Token = "0x600050F")]
	[Address(RVA = "0x5A95A0", Offset = "0x5A7BA0", VA = "0x1805A95A0")]
	private void HitLandUpdate()
	{
		while (this._moveWay == BulletMoveWay.Roll)
		{
			Mouse instance = Mouse.Instance;
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			float num;
			Vector3 vector;
			while (num <= vector.y)
			{
			}
			if (0 > (int)this.Vy)
			{
				this.HitLand();
				return;
			}
		}
		Board instance2 = Board.Instance;
		Board board = this.board;
		BulletMoveWay moveWay = this._moveWay;
		if (moveWay != BulletMoveWay.Throw && moveWay != BulletMoveWay.Quick_throw)
		{
			Transform transform3 = base.transform;
			Rigidbody2D rigidbody2D = this.rb;
			float num2 = this.height;
			Vector2 velocity = rigidbody2D.velocity;
			float fixedDeltaTime = Time.fixedDeltaTime;
			int num3 = 0;
			this.height = num2;
			if (num3 > (int)num2)
			{
				this.HitLand();
			}
		}
		Board board2 = this.board;
		if (this._moveWay != BulletMoveWay.Roll)
		{
			Rigidbody2D rigidbody2D2 = this.rb;
			int num4 = 0;
			Vector2 velocity2 = rigidbody2D2.velocity;
			rigidbody2D2.velocity = num4;
			Mouse instance3 = Mouse.Instance;
			Transform transform4 = base.transform;
			float num5;
			float num2 = num5;
			Transform transform5 = base.transform;
			Vector3 vector2;
			if (num2 > vector2.y)
			{
				this.HitLand();
			}
		}
	}

	// Token: 0x06000510 RID: 1296 RVA: 0x0001B0F8 File Offset: 0x000192F8
	[Token(Token = "0x6000510")]
	[Address(RVA = "0x5A9980", Offset = "0x5A7F80", VA = "0x1805A9980", Slot = "18")]
	public virtual void HitLand()
	{
		this.hit = true;
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		this.Die();
	}

	// Token: 0x06000511 RID: 1297 RVA: 0x0001B128 File Offset: 0x00019328
	[Token(Token = "0x6000511")]
	[Address(RVA = "0x3D9DA0", Offset = "0x3D83A0", VA = "0x1803D9DA0", Slot = "19")]
	public virtual void HitBlock()
	{
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x0001B138 File Offset: 0x00019338
	[Token(Token = "0x6000512")]
	[Address(RVA = "0x5AACD0", Offset = "0x5A92D0", VA = "0x1805AACD0", Slot = "20")]
	protected virtual void OnTriggerEnter2D(Collider2D collision)
	{
		int num;
		for (;;)
		{
			num = 0;
			if ((this.hit ? 1 : 0) != num)
			{
				break;
			}
			BulletMoveWay moveWay = this._moveWay;
			if (moveWay > BulletMoveWay.Convolute)
			{
				if (moveWay == BulletMoveWay.Track_air_singleRow || moveWay == BulletMoveWay.Pirouette)
				{
					break;
				}
			}
			else
			{
				while (num == 6)
				{
				}
				while (num == 16)
				{
				}
			}
			if (this.<Team>k__BackingField != Team.AI)
			{
				Board instance = Board.Instance;
			}
			if (collision.TryGetComponent<Plant>(num))
			{
				return;
			}
			if (collision.TryGetComponent<Zombie>(num))
			{
				goto Block_5;
			}
		}
		return;
		Block_5:
		this.CheckZombie(num);
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x0001B1A4 File Offset: 0x000193A4
	[Token(Token = "0x6000513")]
	[Address(RVA = "0x5AA490", Offset = "0x5A8A90", VA = "0x1805AA490", Slot = "21")]
	public virtual void KeepHiting(Zombie zombie)
	{
		int damage = this._damage;
		PlantType plantType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)1), plantType, num != 0UL);
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x0001B1D4 File Offset: 0x000193D4
	[Token(Token = "0x6000514")]
	[Address(RVA = "0x5ACD00", Offset = "0x5AB300", VA = "0x1805ACD00", Slot = "22")]
	public virtual void TrackZombie(Zombie zombie)
	{
		Zombie zombie2 = this.targetZombie;
		bool flag = zombie == zombie2;
		if (flag && !zombie.isMindControlled && zombie.theHealth > 0)
		{
			ZombieStatus zombieStatus = zombie.theStatus;
			if (zombieStatus > ZombieStatus.Miner_digging)
			{
				if (zombieStatus == ZombieStatus.Imp_fly || flag <= true || zombieStatus == ZombieStatus.Bungi_awake)
				{
					return;
				}
			}
			else if (zombieStatus <= ZombieStatus.Bungi_awake)
			{
			}
			this.hit = true;
			this.HitZombie(zombie);
			this.Die();
			return;
		}
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x0001B240 File Offset: 0x00019440
	[Token(Token = "0x6000515")]
	[Address(RVA = "0x5A6C90", Offset = "0x5A5290", VA = "0x1805A6C90")]
	private void CheckPlant(Plant plant)
	{
		Plant pumpkin;
		for (;;)
		{
			int num = 0;
			int num2 = 0;
			Board instance = Board.Instance;
			Team team = this.<Team>k__BackingField;
			if ((this.theBulletType == (BulletType)num || this.theBulletType == BulletType.Bullet_puff) && plant.TryGetComponent<Shooter>(num) && (plant.isShort ? 1 : 0) == num)
			{
				Plant plant2 = this.from;
				if (!(num != plant2))
				{
					return;
				}
				if (num == 0)
				{
					float fixedDeltaTime = Time.fixedDeltaTime;
					int num3 = 0;
					Bullet bullet;
					if (!(bullet == num3))
					{
						bullet.from = num;
						Transform transform = bullet.transform;
						int num4 = 0;
						int num5 = 0;
						transform.Translate(0.2f, (float)num5, (float)num4);
						if (transform == (ulong)1030L || transform != (ulong)1032L)
						{
						}
						CreateBullet instance2 = CreateBullet.Instance;
						Transform transform2 = bullet.transform;
						Transform transform3 = bullet.transform;
						BulletType bulletType = bullet.theBulletType;
						Bullet bullet2;
						Transform transform4 = bullet2.transform;
						int num6 = 0;
						int num7 = 0;
						transform4.Translate(-0.5f, (float)num7, (float)num6);
						GameObject gameObject = bullet2.gameObject;
						this.Rotate(gameObject, 90);
						bullet2.from = num;
						CreateBullet instance3 = CreateBullet.Instance;
						Transform transform5 = bullet.transform;
						Transform transform6 = bullet.transform;
						BulletType bulletType2 = bullet.theBulletType;
						Bullet bullet3;
						Transform transform7 = bullet3.transform;
						int num8 = 0;
						int num9 = 0;
						transform7.Translate(-0.5f, (float)num9, (float)num8);
						GameObject gameObject2 = bullet3.gameObject;
						this.Rotate(gameObject2, -90);
						bullet3.from = num;
					}
				}
				this.Die();
			}
			Team team2 = this.<Team>k__BackingField;
			int num10 = this.theBulletRow;
			if ((plant.thePlantRow != num10 && this._moveWay != BulletMoveWay.Free) || plant.thePlantType == PlantType.EndoFlame)
			{
				return;
			}
			if (this._moveWay != BulletMoveWay.Throw)
			{
				if ((plant.isShort ? 1 : 0) != num && this._moveWay != BulletMoveWay.Quick_throw)
				{
					return;
				}
				this.hit = true;
				Animator anim = plant.anim;
				float speed = anim.speed;
				if (anim != 0)
				{
					PlantType thePlantType = plant.thePlantType;
					if (thePlantType == PlantType.RedEmeraldUmbrella || thePlantType == PlantType.MelonUmbrella)
					{
						this.Rebound(plant);
					}
				}
				pumpkin = plant.Pumpkin;
				int num11 = 0;
				if (pumpkin != num11 && (pumpkin.isShort ? 1 : 0) == num)
				{
					break;
				}
			}
			int thePlantColumn = plant.thePlantColumn;
			int thePlantRow = plant.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(thePlantColumn, thePlantRow);
			bool flag;
			bool flag2;
			if (!flag || !flag2 || num2 != 0)
			{
			}
			if (num == 0)
			{
				goto Block_17;
			}
		}
		this.HitPlant(pumpkin);
		return;
		Block_17:
		throw new NullReferenceException();
	}

	// Token: 0x06000516 RID: 1302 RVA: 0x0001B4D8 File Offset: 0x000196D8
	[Token(Token = "0x6000516")]
	[Address(RVA = "0x5AB100", Offset = "0x5A9700", VA = "0x1805AB100")]
	private void Rebound(Plant plant)
	{
		if (this._moveWay == BulletMoveWay.Left || this._moveWay != BulletMoveWay.Quick_throw)
		{
		}
		int num = 0;
		this.MoveWay = (BulletMoveWay)num;
		Team team = plant.<Team>k__BackingField;
		this.<Team>k__BackingField = team;
		GameObject gameObject = base.gameObject;
		int num2 = LayerMaskMgr.BulletLayer;
		gameObject.layer = num2;
		BulletType bulletType = this.theBulletType;
		this.hit = false;
		if (bulletType > BulletType.Bullet_doom)
		{
			if (bulletType == BulletType.Bullet_snowBall)
			{
				goto IL_0081;
			}
			if (bulletType == BulletType.Bullet_doom_big)
			{
			}
			if (bulletType == BulletType.Bullet_doom_ulti)
			{
				goto IL_0073;
			}
		}
		if (bulletType != BulletType.Bullet_superCherry)
		{
			goto IL_007B;
		}
		IL_0073:
		uint num3;
		this.Damage = (int)num3;
		IL_007B:
		if (bulletType != BulletType.Bullet_doom)
		{
			goto IL_0087;
		}
		IL_0081:
		plant.FlashOnce();
		IL_0087:
		if (plant.PotType == PlantType.UmbrellaPot)
		{
			int num4 = this._damage;
			num4 += num4;
			this.Damage = num4;
		}
		RedEmeraldUmbrella component;
		if (plant.thePlantType == PlantType.RedEmeraldUmbrella)
		{
			component = plant.GetComponent<RedEmeraldUmbrella>();
			component.anim.SetTrigger("block2");
			component.blocking = true;
			return;
		}
		while (component != (ulong)1131L)
		{
		}
		MelonUmbrella component2 = plant.GetComponent<MelonUmbrella>();
		component2.anim.SetTrigger("block2");
		component2.blocking = true;
		int storgedDamage = component2.storgedDamage;
		component2.storgedDamage = storgedDamage;
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x0001B604 File Offset: 0x00019804
	[Token(Token = "0x6000517")]
	[Address(RVA = "0x5A9A10", Offset = "0x5A8010", VA = "0x1805A9A10")]
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
					PlantType thePlantType = shooter.thePlantType;
					if (thePlantType == PlantType.DoubleShooter || thePlantType == PlantType.GatlingPea)
					{
						CreateBullet instance = CreateBullet.Instance;
						Transform transform2 = bullet.transform;
						Transform transform3 = bullet.transform;
						BulletType bulletType = bullet.theBulletType;
						Bullet bullet2;
						Transform transform4 = bullet2.transform;
						int num4 = 0;
						int num5 = 0;
						transform4.Translate(-0.5f, (float)num5, (float)num4);
						GameObject gameObject = bullet2.gameObject;
						this.Rotate(gameObject, 90);
						bullet2.from = shooter;
					}
					CreateBullet instance2 = CreateBullet.Instance;
					Transform transform5 = bullet.transform;
					Transform transform6 = bullet.transform;
					BulletType bulletType2 = bullet.theBulletType;
					Bullet bullet3;
					Transform transform7 = bullet3.transform;
					int num6 = 0;
					int num7 = 0;
					transform7.Translate(-0.5f, (float)num7, (float)num6);
					GameObject gameObject2 = bullet3.gameObject;
					this.Rotate(gameObject2, -90);
					bullet3.from = shooter;
				}
			}
			this.Die();
		}
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x0001B754 File Offset: 0x00019954
	[Token(Token = "0x6000518")]
	[Address(RVA = "0x5A6400", Offset = "0x5A4A00", VA = "0x1805A6400")]
	private bool AllowUp(PlantType type)
	{
		return type == PlantType.DoubleShooter || type == PlantType.GatlingPea;
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x0001B774 File Offset: 0x00019974
	[Token(Token = "0x6000519")]
	[Address(RVA = "0x5A6230", Offset = "0x5A4830", VA = "0x1805A6230")]
	private bool AllowDown(PlantType type)
	{
		return type == PlantType.GatlingPea;
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x0001B78C File Offset: 0x0001998C
	[Token(Token = "0x600051A")]
	[Address(RVA = "0x5AB670", Offset = "0x5A9C70", VA = "0x1805AB670")]
	private void Rotate(GameObject obj, int angle)
	{
		int num2;
		do
		{
			int num = 0;
			IEnumerator enumerator = obj.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				enumerator += enumerator;
				string text;
				while (text == 0)
				{
				}
				Vector3 vector;
				float z = vector.z;
			}
			if (enumerator != 0)
			{
			}
			if (num != 0)
			{
				goto IL_00B5;
			}
			num2 = 0;
			int num3 = 0;
			Transform transform;
			IEnumerator enumerator2 = transform.GetEnumerator();
			if (num2 < num3)
			{
				num2 += num2;
				num2++;
			}
			if (num2 < num2)
			{
				num2 += num2;
				num2++;
			}
			enumerator2 += enumerator2;
			enumerator2 += enumerator2;
			string text2;
			while (text2 == 0)
			{
			}
			Transform transform2;
			if (transform2 != 0)
			{
			}
		}
		while (num2 != 0);
		return;
		IL_00B5:
		throw new NullReferenceException();
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x0001B86C File Offset: 0x00019A6C
	[Token(Token = "0x600051B")]
	[Address(RVA = "0x5A74C0", Offset = "0x5A5AC0", VA = "0x1805A74C0", Slot = "23")]
	protected virtual void CheckZombie(Zombie zombie)
	{
		if (this.<Team>k__BackingField != Team.AI)
		{
			if ((zombie.theZombieType != ZombieType.ZombieBoss2 && zombie.theZombieType != ZombieType.ZombieBoss) || zombie.theStatus == ZombieStatus.Boss)
			{
				if (zombie.isMindControlled || zombie.theHealth <= 0)
				{
					return;
				}
				ZombieStatus zombieStatus = zombie.theStatus;
				if (zombieStatus > ZombieStatus.Dolphinrider_jump)
				{
					if (typeof(global::UnityEngine.Object).TypeHandle <= (ulong)1L || zombieStatus == ZombieStatus.Imp_fly)
					{
						return;
					}
					if (typeof(global::UnityEngine.Object).TypeHandle > (ulong)1L)
					{
						goto IL_007F;
					}
				}
				if (zombieStatus == ZombieStatus.Pol_jump || zombieStatus == ZombieStatus.Dolphinrider_jump)
				{
					return;
				}
				IL_007F:
				if (this._moveWay <= (BulletMoveWay)25 && zombieStatus == ZombieStatus.Flying && zombieStatus == ZombieStatus.Snokle_inWater && zombieStatus != ZombieStatus.Flying && (zombieStatus == ZombieStatus.Snokle_inWater || zombieStatus == ZombieStatus.Flying))
				{
					return;
				}
				BulletMoveWay moveWay = this._moveWay;
				if (moveWay > BulletMoveWay.Throw)
				{
					if (moveWay == BulletMoveWay.Right_free)
					{
						goto IL_00C4;
					}
					if (moveWay != BulletMoveWay.Sin)
					{
						goto IL_0104;
					}
					if (moveWay <= BulletMoveWay.Roll)
					{
						goto IL_0116;
					}
				}
				if (moveWay != BulletMoveWay.Free)
				{
					goto IL_00DB;
				}
				IL_00C4:
				BlackHole blackHole = this.blackHole;
				int num = 0;
				bool flag = blackHole != num;
				if (!flag)
				{
					goto IL_0116;
				}
				IL_00DB:
				if (flag)
				{
					Corner targetCorner = zombie.targetCorner;
					int num2 = 0;
					if (targetCorner == num2)
					{
					}
					Corner targetCorner2 = zombie.targetCorner;
					bool flag2;
					if (flag2)
					{
						goto IL_0116;
					}
				}
				IL_0104:
				int num3 = this.theBulletRow;
				if (zombie.theZombieRow != num3)
				{
					return;
				}
				IL_0116:
				this.hit = true;
				this.HitZombie(zombie);
				if (this._moveWay != BulletMoveWay.Throw || !this.dying)
				{
					return;
				}
				this.OnThrowHit();
			}
			this.hit = true;
			this.HitZombie(zombie);
			return;
		}
		while (!zombie.isMindControlled)
		{
		}
		int i = this.theBulletRow;
		while (zombie.theZombieRow != i)
		{
		}
		ZombieStatus zombieStatus2 = zombie.theStatus;
		if (zombieStatus2 > ZombieStatus.Flying)
		{
			while (zombieStatus2 == ZombieStatus.Miner_digging)
			{
			}
			while (i <= 4)
			{
			}
			while (zombieStatus2 != ZombieStatus.Bungi_awake)
			{
			}
		}
		while (zombieStatus2 == ZombieStatus.Snokle_inWater)
		{
		}
		while (zombieStatus2 == ZombieStatus.Flying)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x0001BA10 File Offset: 0x00019C10
	[Token(Token = "0x600051C")]
	[Address(RVA = "0x5AA7E0", Offset = "0x5A8DE0", VA = "0x1805AA7E0")]
	private void OnThrowHit()
	{
		List<Plant> list;
		Func<Plant, bool> func;
		IEnumerable<Plant> enumerable = Enumerable.Where<Plant>(list, func);
		Func<Plant, int> <>9__95_ = Bullet.<>c.<>9__95_1;
		if (<>9__95_ == 0)
		{
			Func<Plant, int> func2;
			Bullet.<>c.<>9__95_1 = func2;
		}
		Plant plant = Enumerable.FirstOrDefault<Plant>(Enumerable.OrderBy<Plant, int>(enumerable, <>9__95_));
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
				bullet.hit = true;
				bullet.targetPlant = plant;
				plant.anim.SetTrigger("shoot");
				plant.theStatus = (PlantStatus)((ulong)25L);
				Transform transform4 = bullet.transform;
				Vector3 vector;
				float z = vector.z;
				Transform shoot = plant.shoot;
				float[] array;
				float num3 = array[0];
				bullet.Vx = num3;
				float num4 = array[1];
				bullet.Vy = num4;
				float num5 = array[1];
				bullet.detaVy = num5;
			}
		}
	}

	// Token: 0x0600051D RID: 1309 RVA: 0x0001BB38 File Offset: 0x00019D38
	[Token(Token = "0x600051D")]
	[Address(RVA = "0x5ABC30", Offset = "0x5AA230", VA = "0x1805ABC30")]
	public void SetSpeed(Vector2 projetilePosition, Vector2 targetVelocity, Vector2 targetCurrentPosition, float flightTime)
	{
		float[] array;
		float num = array[0];
		this.Vx = num;
		float num2 = array[1];
		this.Vy = num2;
		float num3 = array[1];
		this.detaVy = num3;
	}

	// Token: 0x0600051E RID: 1310 RVA: 0x0001BB7C File Offset: 0x00019D7C
	[Token(Token = "0x600051E")]
	[Address(RVA = "0x5AC3B0", Offset = "0x5AA9B0", VA = "0x1805AC3B0")]
	public void ThrowTo(Zombie zombie, [Optional] Vector2? pos, [Optional] float? flightTimer)
	{
		Transform transform = base.transform;
		Vector2 colliderPosition = zombie.ColliderPosition;
		Vector2 velocity = zombie.Velocity;
		Vector2 colliderPosition2 = zombie.ColliderPosition;
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x0001BBB0 File Offset: 0x00019DB0
	[Token(Token = "0x600051F")]
	[Address(RVA = "0x5ABFC0", Offset = "0x5AA5C0", VA = "0x1805ABFC0")]
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

	// Token: 0x06000520 RID: 1312 RVA: 0x0001BC00 File Offset: 0x00019E00
	[Token(Token = "0x6000520")]
	[Address(RVA = "0x5AC160", Offset = "0x5AA760", VA = "0x1805AC160")]
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

	// Token: 0x06000521 RID: 1313 RVA: 0x0001BC40 File Offset: 0x00019E40
	[Token(Token = "0x6000521")]
	[Address(RVA = "0x5A9DC0", Offset = "0x5A83C0", VA = "0x1805A9DC0")]
	protected bool HitZombieCondition(ZombieStatus theZombieStatus)
	{
		if (theZombieStatus > ZombieStatus.Dolphinrider_jump)
		{
			if (theZombieStatus != ZombieStatus.Imp_fly)
			{
			}
		}
		while (theZombieStatus == ZombieStatus.Pol_jump)
		{
		}
		while (theZombieStatus == ZombieStatus.Dolphinrider_jump)
		{
		}
		if (this._moveWay <= (BulletMoveWay)25)
		{
			while (theZombieStatus == ZombieStatus.Flying)
			{
			}
		}
		while (theZombieStatus != ZombieStatus.Flying)
		{
		}
		while (theZombieStatus == ZombieStatus.Snokle_inWater)
		{
		}
		return theZombieStatus != ZombieStatus.Flying;
	}

	// Token: 0x06000522 RID: 1314 RVA: 0x0001BC84 File Offset: 0x00019E84
	[Token(Token = "0x6000522")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "24")]
	protected virtual void HitPlant(Plant plant)
	{
	}

	// Token: 0x06000523 RID: 1315 RVA: 0x0001BC94 File Offset: 0x00019E94
	[Token(Token = "0x6000523")]
	[Address(RVA = "0x5A9E70", Offset = "0x5A8470", VA = "0x1805A9E70", Slot = "25")]
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

	// Token: 0x06000524 RID: 1316 RVA: 0x0001BCD0 File Offset: 0x00019ED0
	[Token(Token = "0x6000524")]
	[Address(RVA = "0x5AAE00", Offset = "0x5A9400", VA = "0x1805AAE00")]
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
								goto IL_0089;
							}
						}
						while (typeof(GameAPP).TypeHandle == (ulong)234L)
						{
						}
						while (typeof(GameAPP).TypeHandle <= (ulong)1L)
						{
						}
						IL_0089:
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

	// Token: 0x06000525 RID: 1317 RVA: 0x0001BE08 File Offset: 0x0001A008
	[Token(Token = "0x6000525")]
	[Address(RVA = "0x5A8540", Offset = "0x5A6B40", VA = "0x1805A8540")]
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

	// Token: 0x06000526 RID: 1318 RVA: 0x0001BEA4 File Offset: 0x0001A0A4
	[Token(Token = "0x6000526")]
	[Address(RVA = "0x5A7E80", Offset = "0x5A6480", VA = "0x1805A7E80")]
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

	// Token: 0x06000527 RID: 1319 RVA: 0x0001BFE8 File Offset: 0x0001A1E8
	[Token(Token = "0x6000527")]
	[Address(RVA = "0x5A6240", Offset = "0x5A4840", VA = "0x1805A6240")]
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

	// Token: 0x06000528 RID: 1320 RVA: 0x0001C0C8 File Offset: 0x0001A2C8
	[Token(Token = "0x6000528")]
	[Address(RVA = "0x5AA350", Offset = "0x5A8950", VA = "0x1805AA350")]
	public void JumpUpdate()
	{
		float vy = this.Vy;
		float fixedDeltaTime = Time.fixedDeltaTime;
		Rigidbody2D rigidbody2D = this.rb;
		this.Vy = vy;
		Transform transform = base.transform;
		Transform transform2 = this.shadow;
		Vector3 vector;
		float y = vector.y;
		Vector3 vector2;
		float y2 = vector2.y;
		if (0 > (int)this.Vy)
		{
			Transform transform3 = base.transform;
			Transform transform4 = this.shadow;
			Vector3 vector3;
			float z = vector3.z;
			this.Vy = 4f;
			this.JumpLand();
		}
	}

	// Token: 0x06000529 RID: 1321 RVA: 0x0001C150 File Offset: 0x0001A350
	[Token(Token = "0x6000529")]
	[Address(RVA = "0x5AB420", Offset = "0x5A9A20", VA = "0x1805AB420")]
	public void RightUpdate()
	{
		Rigidbody2D rigidbody2D = this.rb;
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x0001C16C File Offset: 0x0001A36C
	[Token(Token = "0x600052A")]
	[Address(RVA = "0x5AB460", Offset = "0x5A9A60", VA = "0x1805AB460")]
	public void RollingUpdate()
	{
		for (;;)
		{
			Rigidbody2D rigidbody2D = this.rb;
			if (this.isLand)
			{
				break;
			}
			float fixedDeltaTime = Time.fixedDeltaTime;
			Rigidbody2D rigidbody2D2 = this.rb;
			float num = fixedDeltaTime * 9.8f;
			this.Vy = num;
			Transform transform = base.transform;
			Transform transform2 = this.shadow;
			Vector3 vector;
			float y = vector.y;
			Vector3 vector2;
			if (vector2.y > y)
			{
				goto Block_1;
			}
		}
		Board instance = Board.Instance;
		this.HitLand();
		return;
		Block_1:
		Transform transform3 = base.transform;
		Transform transform4 = base.transform;
		Transform transform5 = this.shadow;
		this.isLand = true;
		throw new NullReferenceException();
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x0001C204 File Offset: 0x0001A404
	[Token(Token = "0x600052B")]
	[Address(RVA = "0x5A8840", Offset = "0x5A6E40", VA = "0x1805A8840")]
	public void FreeUpdate()
	{
		BlackHole blackHole = this.blackHole;
		int num = 0;
		if (blackHole == num)
		{
			Transform transform = base.transform;
			Rigidbody2D rigidbody2D = this.rb;
			Vector3 vector;
			float num2 = vector.z * 0.017453292f;
		}
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x0001C248 File Offset: 0x0001A448
	[Token(Token = "0x600052C")]
	[Address(RVA = "0x5ABDD0", Offset = "0x5AA3D0", VA = "0x1805ABDD0")]
	public void ThreeUpUpdate()
	{
		Rigidbody2D rigidbody2D = this.rb;
		if (this.goldThreeTorch)
		{
			this.MoveWay = (BulletMoveWay)((uint)5);
			this.theExistTime = 0f;
			this.goldThreeTorch = false;
			int rowNum = Board.Instance.rowNum;
			int num = this.theBulletRow;
			num++;
			if (num >= rowNum)
			{
				num = rowNum;
			}
			this.theBulletRow = num;
		}
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x0001C2B4 File Offset: 0x0001A4B4
	[Token(Token = "0x600052D")]
	[Address(RVA = "0x5ABD10", Offset = "0x5AA310", VA = "0x1805ABD10")]
	public void ThreeDownUpdate()
	{
		Rigidbody2D rigidbody2D = this.rb;
		if (this.goldThreeTorch)
		{
			this.MoveWay = (BulletMoveWay)((uint)4);
			int num = this.theBulletRow;
			int num2 = 0;
			this.theExistTime = (float)num2;
			this.goldThreeTorch = num2 != 0;
			this.theBulletRow = num2;
		}
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x0001C308 File Offset: 0x0001A508
	[Token(Token = "0x600052E")]
	[Address(RVA = "0x5AC870", Offset = "0x5AAE70", VA = "0x1805AC870", Slot = "26")]
	public virtual void TrackUpdate()
	{
		Rigidbody2D rigidbody2D = this.rb;
		Zombie zombie = this.targetZombie;
		int num = 0;
		if (!(zombie == num))
		{
			ZombieStatus zombieStatus = this.targetZombie.theStatus;
			if (zombieStatus > ZombieStatus.Miner_digging)
			{
				if (zombieStatus > ZombieStatus.Bungi_up)
				{
					if (zombieStatus == ZombieStatus.Legion_fall || zombieStatus == ZombieStatus.Bungi_awake)
					{
						goto IL_00E6;
					}
					Zombie zombie2 = this.targetZombie;
					if (zombie2.theHealth <= 0 || zombie2.isMindControlled)
					{
						goto IL_00E6;
					}
					Collider2D collider2D = zombie2.col;
					int num2 = 0;
					if (collider2D != num2 && this.targetZombie.col.enabled)
					{
						Collider2D collider2D2 = this.targetZombie.col;
						Transform transform = base.transform;
						Rigidbody2D rigidbody2D2 = this.rb;
						int num3 = 0;
						float num4 = this.trackSpeed;
						rigidbody2D2.velocity = num3;
						float num5;
						this.rb.rotation = num5;
						return;
					}
					goto IL_00E6;
				}
				else if (zombieStatus == ZombieStatus.Imp_fly || zombieStatus <= ZombieStatus.Pol_jump)
				{
					goto IL_00E6;
				}
			}
			while (zombieStatus > ZombieStatus.Pol_jump)
			{
			}
			while (zombieStatus >= ZombieStatus.Pol_jump)
			{
			}
			IL_00E6:
			Zombie nearestZombie = this.GetNearestZombie();
			this.targetZombie = nearestZombie;
		}
		Zombie nearestZombie2 = this.GetNearestZombie();
		this.targetZombie = nearestZombie2;
		Transform transform2 = base.transform;
		Rigidbody2D rigidbody2D3 = this.rb;
		Vector3 vector;
		float z = vector.z;
		throw new NullReferenceException();
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x0001C43C File Offset: 0x0001A63C
	[Token(Token = "0x600052F")]
	[Address(RVA = "0x5AA4F0", Offset = "0x5A8AF0", VA = "0x1805AA4F0")]
	public void LeftUpdate()
	{
		Rigidbody2D rigidbody2D = this.rb;
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x0001C458 File Offset: 0x0001A658
	[Token(Token = "0x6000530")]
	[Address(RVA = "0x5ABEE0", Offset = "0x5AA4E0", VA = "0x1805ABEE0")]
	public void ThrowBulletUpdate()
	{
		float vx = this.Vx;
		float fixedDeltaTime = Time.fixedDeltaTime;
		this.Vx = vx;
		float vy = this.Vy;
		float fixedDeltaTime2 = Time.fixedDeltaTime;
		Board board = this.board;
		this.Vy = vy;
		float fixedDeltaTime3 = Time.fixedDeltaTime;
		this.Vy = vy;
		Rigidbody2D rigidbody2D = this.rb;
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x0001C4C0 File Offset: 0x0001A6C0
	[Token(Token = "0x6000531")]
	[Address(RVA = "0x5A64E0", Offset = "0x5A4AE0", VA = "0x1805A64E0")]
	public void CannonBulletUpdate()
	{
		int num = 0;
		Transform transform = base.transform;
		int num2 = 0;
		Transform child = transform.GetChild(num2);
		Transform transform2 = base.transform;
		Transform transform3 = base.transform;
		Vector3 vector;
		float y = vector.y;
		Rigidbody2D rigidbody2D = this.rb;
		Board instance = Board.Instance;
		int num3 = 0;
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
					bullet.cannonPos.y = (float)num3;
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
				bullet2.cannonPos.y = (float)num3;
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
		Rigidbody2D rigidbody2D2 = this.rb;
		Board instance6 = Board.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x0001C74C File Offset: 0x0001A94C
	[Token(Token = "0x6000532")]
	[Address(RVA = "0x5AB350", Offset = "0x5A9950", VA = "0x1805AB350")]
	public void RightFreeUpdate()
	{
		float num = this.theExistTime;
		if (num <= 0.6f)
		{
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			float num2 = num * 0.4f;
			Rigidbody2D rigidbody2D = this.rb;
			return;
		}
		this.MoveWay = (BulletMoveWay)((uint)2);
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x0001C798 File Offset: 0x0001A998
	[Token(Token = "0x6000533")]
	[Address(RVA = "0x5A7810", Offset = "0x5A5E10", VA = "0x1805A7810")]
	public void ConvoluteUpdate()
	{
		Zombie zombie = this.targetZombie;
		int num = 0;
		if (!(zombie == num))
		{
			ZombieStatus zombieStatus = this.targetZombie.theStatus;
			if (zombieStatus > ZombieStatus.Miner_digging)
			{
				if (zombieStatus > ZombieStatus.Bungi_up)
				{
					if (zombieStatus == ZombieStatus.Legion_fall || zombieStatus == ZombieStatus.Bungi_awake)
					{
						goto IL_00EF;
					}
					Zombie zombie2 = this.targetZombie;
					if (zombie2.theHealth <= 0 || zombie2.isMindControlled)
					{
						goto IL_0103;
					}
					Collider2D collider2D = zombie2.col;
					int num2 = 0;
					if (!(collider2D != num2) || !this.targetZombie.col.enabled)
					{
						goto IL_0103;
					}
					Collider2D collider2D2 = this.targetZombie.col;
					Vector2 position = this.rb.position;
					Vector2 velocity = this.rb.velocity;
					float fixedDeltaTime = Time.fixedDeltaTime;
					int num3 = 0;
					float num4 = fixedDeltaTime * 20f;
					if (num3 > (int)num4 || num4 <= 1f)
					{
						goto IL_0103;
					}
				}
				if (zombieStatus == ZombieStatus.Imp_fly || zombieStatus <= ZombieStatus.Pol_jump)
				{
					goto IL_00EF;
				}
			}
			while (zombieStatus > ZombieStatus.Pol_jump)
			{
			}
			while (zombieStatus >= ZombieStatus.Pol_jump)
			{
			}
			IL_00EF:
			Zombie nearestLandZombie = this.GetNearestLandZombie();
			this.targetZombie = nearestLandZombie;
			return;
		}
		IL_0103:
		Zombie nearestLandZombie2 = this.GetNearestLandZombie();
		this.targetZombie = nearestLandZombie2;
		Transform transform = base.transform;
		Vector3 vector;
		float num5 = vector.z * 0.017453292f;
		Rigidbody2D rigidbody2D = this.rb;
		Vector2 velocity2 = rigidbody2D.velocity;
		float fixedDeltaTime2 = Time.fixedDeltaTime;
		if (0 > (int)fixedDeltaTime2 || fixedDeltaTime2 > 1f)
		{
		}
		int num6 = 0;
		rigidbody2D.velocity = num6;
		throw new NullReferenceException();
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x0001C90C File Offset: 0x0001AB0C
	[Token(Token = "0x6000534")]
	[Address(RVA = "0x5A6420", Offset = "0x5A4A20", VA = "0x1805A6420", Slot = "6")]
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

	// Token: 0x06000535 RID: 1333 RVA: 0x0001C940 File Offset: 0x0001AB40
	[Token(Token = "0x6000535")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public Bullet()
	{
	}

	// Token: 0x04000304 RID: 772
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000304")]
	public Board board;

	// Token: 0x04000305 RID: 773
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000305")]
	public SortingGroup sortingGroup;

	// Token: 0x04000306 RID: 774
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000306")]
	public Transform shadow;

	// Token: 0x04000307 RID: 775
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000307")]
	public Rigidbody2D rb;

	// Token: 0x04000308 RID: 776
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000308")]
	public Collider2D col;

	// Token: 0x04000309 RID: 777
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000309")]
	public BulletHelper hitHelper;

	// Token: 0x0400030A RID: 778
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400030A")]
	public LayerMask zombieLayer;

	// Token: 0x0400030B RID: 779
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400030B")]
	public BulletType theBulletType;

	// Token: 0x0400030C RID: 780
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400030C")]
	public float minX;

	// Token: 0x0400030D RID: 781
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400030D")]
	public float minY;

	// Token: 0x0400030E RID: 782
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400030E")]
	public float maxX;

	// Token: 0x0400030F RID: 783
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400030F")]
	public float maxY;

	// Token: 0x04000310 RID: 784
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000310")]
	public BulletMovement bulletMovement;

	// Token: 0x04000311 RID: 785
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000311")]
	public Zombie targetZombie;

	// Token: 0x04000312 RID: 786
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000312")]
	public Plant targetPlant;

	// Token: 0x04000313 RID: 787
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000313")]
	public List<AirProjectile> targetProjectiles;

	// Token: 0x04000314 RID: 788
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000314")]
	public Plant torchWood;

	// Token: 0x04000315 RID: 789
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000315")]
	public Plant from;

	// Token: 0x04000316 RID: 790
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000316")]
	public Zombie from_zombie;

	// Token: 0x04000317 RID: 791
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000317")]
	public PlantType fromType;

	// Token: 0x04000318 RID: 792
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000318")]
	public BlackHole blackHole;

	// Token: 0x04000319 RID: 793
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000319")]
	public BulletStatus theStatus;

	// Token: 0x0400031A RID: 794
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x400031A")]
	public int rogueStatus;

	// Token: 0x0400031B RID: 795
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400031B")]
	public Vector2 cannonPos;

	// Token: 0x0400031C RID: 796
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400031C")]
	public int theBulletRow;

	// Token: 0x0400031D RID: 797
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x400031D")]
	public bool shootByZombie;

	// Token: 0x0400031E RID: 798
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400031E")]
	[SerializeField]
	private BulletMoveWay _moveWay;

	// Token: 0x04000320 RID: 800
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000320")]
	public int _damage;

	// Token: 0x04000322 RID: 802
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000322")]
	public int hitTimes;

	// Token: 0x04000323 RID: 803
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x4000323")]
	public int penetrationTimes;

	// Token: 0x04000324 RID: 804
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000324")]
	public int attributeCount;

	// Token: 0x04000325 RID: 805
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x4000325")]
	public int indexInArray;

	// Token: 0x04000326 RID: 806
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000326")]
	public int shootingLevel;

	// Token: 0x04000327 RID: 807
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4000327")]
	public bool hit;

	// Token: 0x04000328 RID: 808
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Token(Token = "0x4000328")]
	public bool isLand;

	// Token: 0x04000329 RID: 809
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Token(Token = "0x4000329")]
	public bool melonSputter;

	// Token: 0x0400032A RID: 810
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Token(Token = "0x400032A")]
	public bool umbrellaed;

	// Token: 0x0400032B RID: 811
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400032B")]
	public bool goldMagneted;

	// Token: 0x0400032C RID: 812
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xF1")]
	[Token(Token = "0x400032C")]
	public bool goldThreeTorch;

	// Token: 0x0400032D RID: 813
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xF2")]
	[Token(Token = "0x400032D")]
	public bool accelerate;

	// Token: 0x0400032E RID: 814
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x400032E")]
	public float Vx;

	// Token: 0x0400032F RID: 815
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400032F")]
	public float Vy;

	// Token: 0x04000330 RID: 816
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x4000330")]
	public float detaVx;

	// Token: 0x04000331 RID: 817
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000331")]
	public float detaVy;

	// Token: 0x04000332 RID: 818
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Token(Token = "0x4000332")]
	public float trackSpeed;

	// Token: 0x04000333 RID: 819
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000333")]
	public float normalSpeed;

	// Token: 0x04000334 RID: 820
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x4000334")]
	public float magnetNutAngle;

	// Token: 0x04000335 RID: 821
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000335")]
	public float theExistTime;

	// Token: 0x04000336 RID: 822
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Token(Token = "0x4000336")]
	public float shootingfloat;

	// Token: 0x04000337 RID: 823
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000337")]
	private float height;

	// Token: 0x04000338 RID: 824
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x4000338")]
	private bool dying;
}
