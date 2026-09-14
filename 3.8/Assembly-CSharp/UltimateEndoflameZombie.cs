using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using UnityEngine;

// Token: 0x020006F1 RID: 1777
[Token(Token = "0x20006F1")]
public class UltimateEndoflameZombie : Zombie
{
	// Token: 0x06002329 RID: 9001 RVA: 0x000B807C File Offset: 0x000B627C
	[Token(Token = "0x6002329")]
	[Address(RVA = "0x5801E0", Offset = "0x57E7E0", VA = "0x1805801E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 2.5f;
	}

	// Token: 0x0600232A RID: 9002 RVA: 0x000B809C File Offset: 0x000B629C
	[Token(Token = "0x600232A")]
	[Address(RVA = "0x580010", Offset = "0x57E610", VA = "0x180580010", Slot = "23")]
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

	// Token: 0x0600232B RID: 9003 RVA: 0x000B810C File Offset: 0x000B630C
	[Token(Token = "0x600232B")]
	[Address(RVA = "0x580810", Offset = "0x57EE10", VA = "0x180580810", Slot = "15")]
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

	// Token: 0x0600232C RID: 9004 RVA: 0x000B818C File Offset: 0x000B638C
	[Token(Token = "0x600232C")]
	[Address(RVA = "0x533DF0", Offset = "0x5323F0", VA = "0x180533DF0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
	}

	// Token: 0x0600232D RID: 9005 RVA: 0x000B819C File Offset: 0x000B639C
	[Token(Token = "0x600232D")]
	[Address(RVA = "0x57FF60", Offset = "0x57E560", VA = "0x18057FF60")]
	private void AnimOpenFire()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x0600232E RID: 9006 RVA: 0x000B81BC File Offset: 0x000B63BC
	[Token(Token = "0x600232E")]
	[Address(RVA = "0x57FDC0", Offset = "0x57E3C0", VA = "0x18057FDC0")]
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

	// Token: 0x0600232F RID: 9007 RVA: 0x000B820C File Offset: 0x000B640C
	[Token(Token = "0x600232F")]
	[Address(RVA = "0x580D30", Offset = "0x57F330", VA = "0x180580D30", Slot = "18")]
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

	// Token: 0x06002330 RID: 9008 RVA: 0x000B8288 File Offset: 0x000B6488
	[Token(Token = "0x6002330")]
	[Address(RVA = "0x580C40", Offset = "0x57F240", VA = "0x180580C40")]
	private void 花苞形态()
	{
		float num = this.budTimer;
		float deltaTime = Time.deltaTime;
		this.budTimer = num;
	}

	// Token: 0x06002331 RID: 9009 RVA: 0x000B82B4 File Offset: 0x000B64B4
	[Token(Token = "0x6002331")]
	[Address(RVA = "0x580A50", Offset = "0x57F050", VA = "0x180580A50")]
	private void 僵尸形态()
	{
		float num = this.zombieTimer;
		float deltaTime = Time.deltaTime;
		this.zombieTimer = num;
	}

	// Token: 0x06002332 RID: 9010 RVA: 0x000B82E0 File Offset: 0x000B64E0
	[Token(Token = "0x6002332")]
	[Address(RVA = "0x5803F0", Offset = "0x57E9F0", VA = "0x1805803F0", Slot = "27")]
	public override void Die(int reason = 0)
	{
		base.Die(reason);
	}

	// Token: 0x06002333 RID: 9011 RVA: 0x000B82F4 File Offset: 0x000B64F4
	[Token(Token = "0x6002333")]
	[Address(RVA = "0x580200", Offset = "0x57E800", VA = "0x180580200", Slot = "28")]
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

	// Token: 0x06002334 RID: 9012 RVA: 0x000B8348 File Offset: 0x000B6548
	[Token(Token = "0x6002334")]
	[Address(RVA = "0x580D10", Offset = "0x57F310", VA = "0x180580D10", Slot = "46")]
	public override void UpdateColor(Zombie.ZombieColor zombieColor = Zombie.ZombieColor.Default)
	{
		base.UpdateColor(zombieColor);
	}

	// Token: 0x06002335 RID: 9013 RVA: 0x000B8360 File Offset: 0x000B6560
	[Token(Token = "0x6002335")]
	[Address(RVA = "0x580BB0", Offset = "0x57F1B0", VA = "0x180580BB0")]
	private UniTaskVoid 渐变到植物()
	{
		return default(UniTaskVoid);
	}

	// Token: 0x06002336 RID: 9014 RVA: 0x000B837C File Offset: 0x000B657C
	[Token(Token = "0x6002336")]
	[Address(RVA = "0x580B20", Offset = "0x57F120", VA = "0x180580B20")]
	private UniTaskVoid 渐变到僵尸()
	{
		return default(UniTaskVoid);
	}

	// Token: 0x06002337 RID: 9015 RVA: 0x000B8398 File Offset: 0x000B6598
	[Token(Token = "0x6002337")]
	[Address(RVA = "0x5804A0", Offset = "0x57EAA0", VA = "0x1805804A0", Slot = "39")]
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
			int num8 = this.theMaxHealth.Multiply(0.03f);
			int num9 = 0;
			base.ApplyDamage((DamageType)num9, num8);
			base.UpdateHealthText();
		}
	}

	// Token: 0x06002338 RID: 9016 RVA: 0x000B8470 File Offset: 0x000B6670
	[Token(Token = "0x6002338")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002339 RID: 9017 RVA: 0x000B8480 File Offset: 0x000B6680
	[Token(Token = "0x6002339")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x0600233A RID: 9018 RVA: 0x000B8490 File Offset: 0x000B6690
	[Token(Token = "0x600233A")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool fromFreeze = false)
	{
	}

	// Token: 0x0600233B RID: 9019 RVA: 0x000B84A0 File Offset: 0x000B66A0
	[Token(Token = "0x600233B")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x0600233C RID: 9020 RVA: 0x000B84B0 File Offset: 0x000B66B0
	[Token(Token = "0x600233C")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x0600233D RID: 9021 RVA: 0x000B84C0 File Offset: 0x000B66C0
	[Token(Token = "0x600233D")]
	[Address(RVA = "0x580410", Offset = "0x57EA10", VA = "0x180580410")]
	private float GetKnockBack(float damage)
	{
		while (0 <= (int)damage && damage <= 1f)
		{
		}
		return (float)(0 * (int)0.03f);
	}

	// Token: 0x0600233E RID: 9022 RVA: 0x000B84EC File Offset: 0x000B66EC
	[Token(Token = "0x600233E")]
	[Address(RVA = "0x580950", Offset = "0x57EF50", VA = "0x180580950", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		float num = (float)(0 * (int)0.03f * (int)0.02f);
		base.RealKnockBack(num);
	}

	// Token: 0x0600233F RID: 9023 RVA: 0x000B8514 File Offset: 0x000B6714
	[Token(Token = "0x600233F")]
	[Address(RVA = "0x546F50", Offset = "0x545550", VA = "0x180546F50", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		int num;
		if (num > 5000)
		{
		}
		return num;
	}

	// Token: 0x06002340 RID: 9024 RVA: 0x000B8530 File Offset: 0x000B6730
	[Token(Token = "0x6002340")]
	[Address(RVA = "0x546D50", Offset = "0x545350", VA = "0x180546D50", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06002341 RID: 9025 RVA: 0x000B8540 File Offset: 0x000B6740
	[Token(Token = "0x6002341")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06002342 RID: 9026 RVA: 0x000B8550 File Offset: 0x000B6750
	[Token(Token = "0x6002342")]
	[Address(RVA = "0x5810D0", Offset = "0x57F6D0", VA = "0x1805810D0")]
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

	// Token: 0x04001162 RID: 4450
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001162")]
	public GameObject zombieFertilize;

	// Token: 0x04001163 RID: 4451
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4001163")]
	public List<SpriteRenderer> z;

	// Token: 0x04001164 RID: 4452
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4001164")]
	public List<SpriteRenderer> p;

	// Token: 0x04001165 RID: 4453
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4001165")]
	public List<Transform> stems;

	// Token: 0x04001166 RID: 4454
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001166")]
	private float budTimer;

	// Token: 0x04001167 RID: 4455
	[FieldOffset(Offset = "0x27C")]
	[Token(Token = "0x4001167")]
	private float zombieTimer;

	// Token: 0x04001168 RID: 4456
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001168")]
	private int blockCount;

	// Token: 0x04001169 RID: 4457
	[FieldOffset(Offset = "0x284")]
	[Token(Token = "0x4001169")]
	private bool 渐变中;

	// Token: 0x0400116A RID: 4458
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x400116A")]
	private float x;
}
