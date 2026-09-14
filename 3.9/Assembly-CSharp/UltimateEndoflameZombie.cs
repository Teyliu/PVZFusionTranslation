using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using UnityEngine;

// Token: 0x02000729 RID: 1833
[Token(Token = "0x2000729")]
public class UltimateEndoflameZombie : Zombie
{
	// Token: 0x06002445 RID: 9285 RVA: 0x000BCEC0 File Offset: 0x000BB0C0
	[Token(Token = "0x6002445")]
	[Address(RVA = "0x5FBE90", Offset = "0x5FA490", VA = "0x1805FBE90", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 2.5f;
	}

	// Token: 0x06002446 RID: 9286 RVA: 0x000BCEE0 File Offset: 0x000BB0E0
	[Token(Token = "0x6002446")]
	[Address(RVA = "0x5FBCC0", Offset = "0x5FA2C0", VA = "0x1805FBCC0", Slot = "24")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("openFire");
		float boxXFromColumn = global::Lawnf.GetBoxXFromColumn(-1);
		float boxYFromRow = global::Lawnf.GetBoxYFromRow(-1, 5);
		GameObject gameObject = this.zombieFertilize;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameAPP.PlaySound((SoundType)((uint)66), 0.5f, 1f);
		this.attributeCountDown = 5f;
	}

	// Token: 0x06002447 RID: 9287 RVA: 0x000BCF50 File Offset: 0x000BB150
	[Token(Token = "0x6002447")]
	[Address(RVA = "0x5FC4B0", Offset = "0x5FAAB0", VA = "0x1805FC4B0", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("buded");
		Collider2D col = this.col;
		this.budTimer = 15f;
		this.zombieTimer = 30f;
		LayerMask layerMask = col.callbackLayers.m_Mask;
		LayerMask layerMask2 = LayerMask.GetMask(new string[] { "Bullet" });
		Transform axis = this.axis;
	}

	// Token: 0x06002448 RID: 9288 RVA: 0x000BCFD0 File Offset: 0x000BB1D0
	[Token(Token = "0x6002448")]
	[Address(RVA = "0x58AAD0", Offset = "0x5890D0", VA = "0x18058AAD0", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
	}

	// Token: 0x06002449 RID: 9289 RVA: 0x000BCFE0 File Offset: 0x000BB1E0
	[Token(Token = "0x6002449")]
	[Address(RVA = "0x5FBC10", Offset = "0x5FA210", VA = "0x1805FBC10")]
	private void AnimOpenFire()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x0600244A RID: 9290 RVA: 0x000BD000 File Offset: 0x000BB200
	[Token(Token = "0x600244A")]
	[Address(RVA = "0x5FBA70", Offset = "0x5FA070", VA = "0x1805FBA70")]
	private void AnimOpenFire2()
	{
		Transform shoot = this.shoot;
		ParticleManager instance = ParticleManager.Instance;
		int num = 0;
		Vector3 vector;
		float num2 = vector.z;
		int theZombieRow = this.theZombieRow;
		int num3 = 0;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)159), num, theZombieRow, num4 != 0UL, (float)num3);
	}

	// Token: 0x0600244B RID: 9291 RVA: 0x000BD050 File Offset: 0x000BB250
	[Token(Token = "0x600244B")]
	[Address(RVA = "0x5FC9D0", Offset = "0x5FAFD0", VA = "0x1805FC9D0", Slot = "19")]
	protected override void ZombieUpdate()
	{
		int num;
		do
		{
			List<Transform> list = this.stems;
			num = 0;
			int num2 = 0;
			bool flag;
			if (flag)
			{
				float num3 = this.x;
				Transform axis = this.axis;
				if (num2 > (int)num3 || num3 > 1f)
				{
				}
			}
		}
		while (num != 0);
		float deltaTime = Time.deltaTime;
		float deltaTime2 = Time.deltaTime;
	}

	// Token: 0x0600244C RID: 9292 RVA: 0x000BD0CC File Offset: 0x000BB2CC
	[Token(Token = "0x600244C")]
	[Address(RVA = "0x5FC8E0", Offset = "0x5FAEE0", VA = "0x1805FC8E0")]
	private void 花苞形态()
	{
		float num = this.budTimer;
		float deltaTime = Time.deltaTime;
		this.budTimer = num;
	}

	// Token: 0x0600244D RID: 9293 RVA: 0x000BD0F8 File Offset: 0x000BB2F8
	[Token(Token = "0x600244D")]
	[Address(RVA = "0x5FC6F0", Offset = "0x5FACF0", VA = "0x1805FC6F0")]
	private void 僵尸形态()
	{
		float num = this.zombieTimer;
		float deltaTime = Time.deltaTime;
		this.zombieTimer = num;
	}

	// Token: 0x0600244E RID: 9294 RVA: 0x000BD124 File Offset: 0x000BB324
	[Token(Token = "0x600244E")]
	[Address(RVA = "0x5FC0A0", Offset = "0x5FA6A0", VA = "0x1805FC0A0", Slot = "28")]
	public override void Die(int reason = 0)
	{
		base.Die(reason);
	}

	// Token: 0x0600244F RID: 9295 RVA: 0x000BD138 File Offset: 0x000BB338
	[Token(Token = "0x600244F")]
	[Address(RVA = "0x5FBEB0", Offset = "0x5FA4B0", VA = "0x1805FBEB0", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		ulong num3;
		do
		{
			int num = 0;
			IEnumerator enumerator = base.FadeDeath();
			Coroutine coroutine = base.StartCoroutine(enumerator);
			List<GridItem> list = Enumerable.ToList<GridItem>(this.board.griditemArray);
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				while (num == 0)
				{
				}
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06002450 RID: 9296 RVA: 0x000BD18C File Offset: 0x000BB38C
	[Token(Token = "0x6002450")]
	[Address(RVA = "0x5FC9B0", Offset = "0x5FAFB0", VA = "0x1805FC9B0", Slot = "48")]
	public override void UpdateColor(Zombie.ZombieColor zombieColor = Zombie.ZombieColor.Default)
	{
		base.UpdateColor(zombieColor);
	}

	// Token: 0x06002451 RID: 9297 RVA: 0x000BD1A4 File Offset: 0x000BB3A4
	[Token(Token = "0x6002451")]
	[Address(RVA = "0x5FC850", Offset = "0x5FAE50", VA = "0x1805FC850")]
	private UniTaskVoid 渐变到植物()
	{
		return default(UniTaskVoid);
	}

	// Token: 0x06002452 RID: 9298 RVA: 0x000BD1C0 File Offset: 0x000BB3C0
	[Token(Token = "0x6002452")]
	[Address(RVA = "0x5FC7C0", Offset = "0x5FADC0", VA = "0x1805FC7C0")]
	private UniTaskVoid 渐变到僵尸()
	{
		return default(UniTaskVoid);
	}

	// Token: 0x06002453 RID: 9299 RVA: 0x000BD1DC File Offset: 0x000BB3DC
	[Token(Token = "0x6002453")]
	[Address(RVA = "0x5FC150", Offset = "0x5FA750", VA = "0x1805FC150", Slot = "41")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		if ((this.渐变中 ? 1 : 0) == num && collision.TryGetComponent<Bullet>(num))
		{
			this.flashTime = 0.2f;
			uint num2;
			uint num3;
			GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num2, (int)num3), 0.5f, 1f);
			Vector3 vector;
			float num4 = vector.z;
			this.blockCount = num;
			base.RealKnockBack(0.33f);
			CreatePlant instance = CreatePlant.Instance;
			int column = base.Column;
			int columnNum = this.board.columnNum;
			if (column > columnNum)
			{
			}
			int num5 = 0;
			Plant plant;
			if (plant != num5)
			{
			}
			int num6 = 0;
			int num7 = 0;
			base.Garliced(num7 != 0, num6 != 0);
			long num8 = this.theMaxHealth;
			num8 = num8.Multiply(0.03f);
			int num9 = num8.ToInt();
			int num10 = 0;
			base.ApplyDamage((DamageType)num10, num9);
			base.UpdateHealthText();
		}
	}

	// Token: 0x06002454 RID: 9300 RVA: 0x000BD2C4 File Offset: 0x000BB4C4
	[Token(Token = "0x6002454")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002455 RID: 9301 RVA: 0x000BD2D4 File Offset: 0x000BB4D4
	[Token(Token = "0x6002455")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002456 RID: 9302 RVA: 0x000BD2E4 File Offset: 0x000BB4E4
	[Token(Token = "0x6002456")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool fromFreeze = false)
	{
	}

	// Token: 0x06002457 RID: 9303 RVA: 0x000BD2F4 File Offset: 0x000BB4F4
	[Token(Token = "0x6002457")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06002458 RID: 9304 RVA: 0x000BD304 File Offset: 0x000BB504
	[Token(Token = "0x6002458")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06002459 RID: 9305 RVA: 0x000BD314 File Offset: 0x000BB514
	[Token(Token = "0x6002459")]
	[Address(RVA = "0x5FC0C0", Offset = "0x5FA6C0", VA = "0x1805FC0C0")]
	private float GetKnockBack(float damage)
	{
		while (0 <= (int)damage && damage <= 1f)
		{
		}
		return (float)(0 * (int)0.03f);
	}

	// Token: 0x0600245A RID: 9306 RVA: 0x000BD340 File Offset: 0x000BB540
	[Token(Token = "0x600245A")]
	[Address(RVA = "0x5FC5F0", Offset = "0x5FABF0", VA = "0x1805FC5F0", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		float num = (float)(0 * (int)0.03f * (int)0.02f);
		base.RealKnockBack(num);
	}

	// Token: 0x0600245B RID: 9307 RVA: 0x000BD368 File Offset: 0x000BB568
	[Token(Token = "0x600245B")]
	[Address(RVA = "0x5A9160", Offset = "0x5A7760", VA = "0x1805A9160", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		long num;
		return num;
	}

	// Token: 0x0600245C RID: 9308 RVA: 0x000BD37C File Offset: 0x000BB57C
	[Token(Token = "0x600245C")]
	[Address(RVA = "0x5A9020", Offset = "0x5A7620", VA = "0x1805A9020", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x0600245D RID: 9309 RVA: 0x000BD38C File Offset: 0x000BB58C
	[Token(Token = "0x600245D")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x0600245E RID: 9310 RVA: 0x000BD39C File Offset: 0x000BB59C
	[Token(Token = "0x600245E")]
	[Address(RVA = "0x5FCD70", Offset = "0x5FB370", VA = "0x1805FCD70")]
	public UltimateEndoflameZombie()
	{
		List<SpriteRenderer> list = new List();
		this.z = list;
		List<SpriteRenderer> list2 = new List();
		this.p = list2;
		List<Transform> list3 = new List();
		this.stems = list3;
		base..ctor();
	}

	// Token: 0x0400122F RID: 4655
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x400122F")]
	public GameObject zombieFertilize;

	// Token: 0x04001230 RID: 4656
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001230")]
	public List<SpriteRenderer> z;

	// Token: 0x04001231 RID: 4657
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4001231")]
	public List<SpriteRenderer> p;

	// Token: 0x04001232 RID: 4658
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4001232")]
	public List<Transform> stems;

	// Token: 0x04001233 RID: 4659
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4001233")]
	private float budTimer;

	// Token: 0x04001234 RID: 4660
	[FieldOffset(Offset = "0x29C")]
	[Token(Token = "0x4001234")]
	private float zombieTimer;

	// Token: 0x04001235 RID: 4661
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4001235")]
	private int blockCount;

	// Token: 0x04001236 RID: 4662
	[FieldOffset(Offset = "0x2A4")]
	[Token(Token = "0x4001236")]
	private bool 渐变中;

	// Token: 0x04001237 RID: 4663
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x4001237")]
	private float x;
}
