using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel.RogueShooting;
using UnityEngine;

// Token: 0x020006AF RID: 1711
[Token(Token = "0x20006AF")]
public class HorseBoss : Zombie
{
	// Token: 0x060020B5 RID: 8373 RVA: 0x000ACF7C File Offset: 0x000AB17C
	[Token(Token = "0x60020B5")]
	[Address(RVA = "0x5B0340", Offset = "0x5AE940", VA = "0x1805B0340", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)38L);
		this.attributeCountDown = 5f;
		Action action = new Action(this.DefaultStatus);
		this.defaultAction = action;
	}

	// Token: 0x060020B6 RID: 8374 RVA: 0x000ACFB8 File Offset: 0x000AB1B8
	[Token(Token = "0x60020B6")]
	[Address(RVA = "0x5B0D50", Offset = "0x5AF350", VA = "0x1805B0D50", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(this.board.columnNum);
		Mouse instance = Mouse.Instance;
		int theZombieRow = this.theZombieRow;
		float landY = instance.GetLandY(boxXFromColumn, theZombieRow);
		Board board = this.board;
		long num;
		this.theHealth = num;
		long num2;
		this.theMaxHealth = num2;
		base.UpdateHealthText();
	}

	// Token: 0x060020B7 RID: 8375 RVA: 0x000AD020 File Offset: 0x000AB220
	[Token(Token = "0x60020B7")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "25")]
	public override void ChangeRow(int theTargetRow)
	{
	}

	// Token: 0x060020B8 RID: 8376 RVA: 0x000AD030 File Offset: 0x000AB230
	[Token(Token = "0x60020B8")]
	[Address(RVA = "0x5B0EC0", Offset = "0x5AF4C0", VA = "0x1805B0EC0", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		Board board = this.board;
		Collider2D col = this.col;
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x060020B9 RID: 8377 RVA: 0x000AD058 File Offset: 0x000AB258
	[Token(Token = "0x60020B9")]
	[Address(RVA = "0x5B0550", Offset = "0x5AEB50", VA = "0x1805B0550")]
	private void DefaultStatus()
	{
	}

	// Token: 0x060020BA RID: 8378 RVA: 0x000AD068 File Offset: 0x000AB268
	[Token(Token = "0x60020BA")]
	[Address(RVA = "0x5B0260", Offset = "0x5AE860", VA = "0x1805B0260", Slot = "24")]
	protected override void AttributeEvent()
	{
		ZombieStatus theStatus = this.theStatus;
		if (theStatus != ZombieStatus.Default)
		{
			if (theStatus <= ZombieStatus.Paper_lookPaper)
			{
				this.attributeCountDown = 1f;
			}
			return;
		}
		int num = this.restSummonCount;
		this.restSummonCount = num;
		if (num > 0)
		{
			this.anim.SetTrigger("summon");
			long num2 = this.theMaxHealth;
			num2 -= "summon";
			this.attributeCountDown = 7f;
			return;
		}
		this.attributeCountDown = 5f;
		this.StartSkill();
		this.restSummonCount = (int)((ulong)4L);
	}

	// Token: 0x060020BB RID: 8379 RVA: 0x000AD0FC File Offset: 0x000AB2FC
	[Token(Token = "0x60020BB")]
	[Address(RVA = "0x5B0B30", Offset = "0x5AF130", VA = "0x1805B0B30")]
	private void StartSkill()
	{
		List<HorseBoss.Skill> list = this.skillQueue;
		int num = this.currentSkillIndex;
		HorseBoss.Skill skill = list[num];
		List<HorseBoss.Skill> list2 = this.skillQueue;
		int num2 = (int)skill;
		int num3 = this.currentSkillIndex;
		num3++;
		this.currentSkillIndex = num;
		Transform axis = this.axis;
		if (num2 == 0)
		{
			this.anim.SetTrigger("charge");
			uint num4;
			GameAPP.PlaySound((int)num4, 1f, 1f);
			return;
		}
		if (num2 == 0)
		{
			this.SetJumpTargets();
			this.anim.SetTrigger("jump");
			return;
		}
		if (num2 != 0)
		{
			if (num2 == 1)
			{
				this.anim.SetTrigger("flag3");
			}
			return;
		}
		this.anim.SetTrigger("bigSummon");
	}

	// Token: 0x060020BC RID: 8380 RVA: 0x000AD1BC File Offset: 0x000AB3BC
	[Token(Token = "0x60020BC")]
	[Address(RVA = "0x5B07D0", Offset = "0x5AEDD0", VA = "0x1805B07D0", Slot = "22")]
	protected override void PositionUpdate()
	{
		if (!this.jumping)
		{
			Queue<Vector2Int> queue = this.jumpTargetQueue;
			base.PositionUpdate();
			return;
		}
	}

	// Token: 0x060020BD RID: 8381 RVA: 0x000AD1E8 File Offset: 0x000AB3E8
	[Token(Token = "0x60020BD")]
	[Address(RVA = "0x5AF180", Offset = "0x5AD780", VA = "0x1805AF180")]
	private void AnimCharge1()
	{
		Transform shoot = this.shoot;
		GameObject qi = this.Qi;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		Transform transform = this.board.transform;
		GameObject gameObject;
		SwordQi component = gameObject.GetComponent<SwordQi>();
		component.v.z = (float)num;
		component.timer = 3f;
		int theAttackDamage = this.theAttackDamage;
		component.dmg = theAttackDamage;
		int theZombieRow = this.theZombieRow;
		component.theRow = theZombieRow;
	}

	// Token: 0x060020BE RID: 8382 RVA: 0x000AD268 File Offset: 0x000AB468
	[Token(Token = "0x60020BE")]
	[Address(RVA = "0x5AF330", Offset = "0x5AD930", VA = "0x1805AF330")]
	private void AnimCharge2()
	{
		Transform shoot = this.shoot;
		GameObject qi = this.Qi;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		Transform transform = this.board.transform;
		GameObject gameObject;
		SwordQi component = gameObject.GetComponent<SwordQi>();
		component.v.z = (float)num;
		component.timer = 3f;
		int theAttackDamage = this.theAttackDamage;
		component.dmg = theAttackDamage;
		int theZombieRow = this.theZombieRow;
		component.theRow = theZombieRow;
	}

	// Token: 0x060020BF RID: 8383 RVA: 0x000AD2E8 File Offset: 0x000AB4E8
	[Token(Token = "0x60020BF")]
	[Address(RVA = "0x5AF5F0", Offset = "0x5ADBF0", VA = "0x1805AF5F0")]
	private void AnimFlag3()
	{
		int num = 0;
		Transform shoot = this.shoot;
		GameObject qi = this.Qi;
		Vector3 vector;
		float z = vector.z;
		Transform transform = this.board.transform;
		GameObject gameObject;
		SwordQi component = gameObject.GetComponent<SwordQi>();
		component.timer = 3f;
		uint num2;
		num2 += (uint)15;
		component.v.z = (float)num;
		int theAttackDamage = this.theAttackDamage;
		component.dmg = theAttackDamage;
		component.free = true;
		uint num3;
		while (num3 >= (uint)75)
		{
		}
	}

	// Token: 0x060020C0 RID: 8384 RVA: 0x000AD36C File Offset: 0x000AB56C
	[Token(Token = "0x60020C0")]
	[Address(RVA = "0x5AF4E0", Offset = "0x5ADAE0", VA = "0x1805AF4E0")]
	private void AnimChargeSound()
	{
		GameAPP.PlaySound(42, 0.5f, 0.8f);
	}

	// Token: 0x060020C1 RID: 8385 RVA: 0x000AD38C File Offset: 0x000AB58C
	[Token(Token = "0x60020C1")]
	[Address(RVA = "0x5AF050", Offset = "0x5AD650", VA = "0x1805AF050")]
	private void AnimBigSummon()
	{
		Board board = this.board;
		int num = 0;
		if (num < board.rowNum)
		{
			BoxType[] roadType = this.board.roadType;
			CreateZombie instance = CreateZombie.Instance;
			Board board2 = this.board;
			num++;
			uint num2;
			num2 += (uint)4;
		}
	}

	// Token: 0x060020C2 RID: 8386 RVA: 0x000AD3D8 File Offset: 0x000AB5D8
	[Token(Token = "0x60020C2")]
	[Address(RVA = "0x5AFDB0", Offset = "0x5AE3B0", VA = "0x1805AFDB0")]
	private void AnimJumpStart()
	{
		Transform axis = this.axis;
		this.jumping = true;
		Vector2 targetPosition = this.GetTargetPosition();
		int num;
		HorseBoss.<SmoothMoveCoroutine>d__25 <SmoothMoveCoroutine>d__ = new HorseBoss.<SmoothMoveCoroutine>d__25(num);
		num = 0;
		<SmoothMoveCoroutine>d__.<>4__this = this;
		<SmoothMoveCoroutine>d__.startPos = 0;
		<SmoothMoveCoroutine>d__.startPos.y = (float)0;
		<SmoothMoveCoroutine>d__.targetPos = targetPosition;
		<SmoothMoveCoroutine>d__.targetPos.y = (float)0;
		<SmoothMoveCoroutine>d__.duration = 0.6666667f;
		Coroutine coroutine = base.StartCoroutine(<SmoothMoveCoroutine>d__);
		this.move = coroutine;
		throw new NullReferenceException();
	}

	// Token: 0x060020C3 RID: 8387 RVA: 0x000AD454 File Offset: 0x000AB654
	[Token(Token = "0x60020C3")]
	[Address(RVA = "0x5B0830", Offset = "0x5AEE30", VA = "0x1805B0830")]
	private void SetJumpTargets()
	{
		Vector2Int s_Zero = Vector2Int.s_Zero;
		ulong num;
		if (num == (ulong)0L)
		{
		}
		Vector2Int s_Zero2 = Vector2Int.s_Zero;
		uint num3;
		int num2 = global::UnityEngine.Random.Range(0, (int)num3);
		if (num2 != 0)
		{
			if (num2 != 0)
			{
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						goto IL_0063;
					}
					Board board = this.board;
				}
				Board board2 = this.board;
			}
			uint num5;
			int num4 = global::UnityEngine.Random.Range(0, (int)num5);
			Board board3 = this.board;
		}
		uint num7;
		int num6 = global::UnityEngine.Random.Range(0, (int)num7);
		Board board4 = this.board;
		IL_0063:
		Queue<Vector2Int> queue = this.jumpTargetQueue;
		Queue<Vector2Int> queue2 = this.jumpTargetQueue;
		Board board5 = this.board;
		Queue<Vector2Int> queue3 = this.jumpTargetQueue;
		Board board6 = this.board;
		int columnNum = board5.columnNum;
		int num8 = 0;
		int rowNum = board6.rowNum;
		int num9 = global::UnityEngine.Random.Range(num8, rowNum);
	}

	// Token: 0x060020C4 RID: 8388 RVA: 0x000AD514 File Offset: 0x000AB714
	[Token(Token = "0x60020C4")]
	[Address(RVA = "0x5B05F0", Offset = "0x5AEBF0", VA = "0x1805B05F0")]
	private Vector2 GetTargetPosition()
	{
		Vector2Int vector2Int = this.jumpTargetQueue.Peek();
		Mouse instance = Mouse.Instance;
		int x = vector2Int.m_X;
		float boxXFromColumn = instance.GetBoxXFromColumn(x);
		throw new NullReferenceException();
	}

	// Token: 0x060020C5 RID: 8389 RVA: 0x000AD554 File Offset: 0x000AB754
	[Token(Token = "0x60020C5")]
	[Address(RVA = "0x5B0A70", Offset = "0x5AF070", VA = "0x1805B0A70")]
	private IEnumerator SmoothMoveCoroutine(Vector2 startPos, Vector2 targetPos, float duration)
	{
		int num;
		HorseBoss.<SmoothMoveCoroutine>d__25 <SmoothMoveCoroutine>d__ = new HorseBoss.<SmoothMoveCoroutine>d__25(num);
		num = 0;
		<SmoothMoveCoroutine>d__.<>4__this = this;
		<SmoothMoveCoroutine>d__.startPos = startPos;
		<SmoothMoveCoroutine>d__.startPos.y = (float)0;
		<SmoothMoveCoroutine>d__.duration = duration;
		<SmoothMoveCoroutine>d__.targetPos = targetPos;
		<SmoothMoveCoroutine>d__.targetPos.y = (float)0;
		throw new NullReferenceException();
	}

	// Token: 0x060020C6 RID: 8390 RVA: 0x000AD5A8 File Offset: 0x000AB7A8
	[Token(Token = "0x60020C6")]
	[Address(RVA = "0x5AFA80", Offset = "0x5AE080", VA = "0x1805AFA80")]
	private void AnimJumpEnd()
	{
		GameAPP.PlaySound(74, 0.5f, 1f);
		ScreenShake.TriggerShake(0.05f);
		Coroutine coroutine = this.move;
		base.StopCoroutine(coroutine);
		Vector2 targetPosition = this.GetTargetPosition();
		Queue<Vector2Int> queue = this.jumpTargetQueue;
		this.jumping = false;
		Transform transform = base.transform;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		transform.rotation = identityQuaternion;
		int num = 0;
		base.ChangeStatus((ZombieStatus)num);
		this.anim.SetTrigger("jumpend");
	}

	// Token: 0x060020C7 RID: 8391 RVA: 0x000AD68C File Offset: 0x000AB88C
	[Token(Token = "0x60020C7")]
	[Address(RVA = "0x5AF850", Offset = "0x5ADE50", VA = "0x1805AF850")]
	private void AnimFlagUp()
	{
		int num = 0;
		if (this.spawnCountPerRow > num)
		{
			Board board = this.board;
			if (num < board.rowNum)
			{
				BoxType[] roadType = board.roadType;
				List<ZombieType> list = this.spawns;
				CreateZombie instance = CreateZombie.Instance;
				ZombieType random = ListExtensions.GetRandom<ZombieType>(list);
				int num2 = 0;
				Zombie zombie;
				bool flag;
				if (zombie != num2 && flag)
				{
					Lawnf.SetZombieHealth(zombie, 1.6f);
				}
				num++;
				uint num3;
				num3 += (uint)4;
			}
			num++;
		}
		if (this.onSpawn != 0)
		{
		}
	}

	// Token: 0x060020C8 RID: 8392 RVA: 0x000AD710 File Offset: 0x000AB910
	[Token(Token = "0x60020C8")]
	[Address(RVA = "0x5B03E0", Offset = "0x5AE9E0", VA = "0x1805B03E0", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num2;
		do
		{
			List<Transform> changeSprites = this.changeSprites;
			bool flag;
			if (flag)
			{
				int num = 0;
				GameObject gameObject;
				Lawnf.ChangeSprite((float)0, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060020C9 RID: 8393 RVA: 0x000AD748 File Offset: 0x000AB948
	[Token(Token = "0x60020C9")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060020CA RID: 8394 RVA: 0x000AD758 File Offset: 0x000AB958
	[Token(Token = "0x60020CA")]
	[Address(RVA = "0x5B06A0", Offset = "0x5AECA0", VA = "0x1805B06A0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		for (;;)
		{
			int num = 0;
			if ((this.jumping ? 1 : 0) != num)
			{
				return;
			}
			if (collision.TryGetComponent<Plant>(num))
			{
				break;
			}
			if (collision.TryGetComponent<Zombie>(num))
			{
				return;
			}
		}
		int theZombieRow = this.theZombieRow;
	}

	// Token: 0x060020CB RID: 8395 RVA: 0x000AD794 File Offset: 0x000AB994
	[Token(Token = "0x60020CB")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x060020CC RID: 8396 RVA: 0x000AD7A4 File Offset: 0x000AB9A4
	[Token(Token = "0x60020CC")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x060020CD RID: 8397 RVA: 0x000AD7B4 File Offset: 0x000AB9B4
	[Token(Token = "0x60020CD")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x060020CE RID: 8398 RVA: 0x000AD7C4 File Offset: 0x000AB9C4
	[Token(Token = "0x60020CE")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x060020CF RID: 8399 RVA: 0x000AD7D4 File Offset: 0x000AB9D4
	[Token(Token = "0x60020CF")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "61")]
	public override void Garliced(bool playSound = false, bool certainRow = false)
	{
	}

	// Token: 0x060020D0 RID: 8400 RVA: 0x000AD7E4 File Offset: 0x000AB9E4
	[Token(Token = "0x60020D0")]
	[Address(RVA = "0x5A9020", Offset = "0x5A7620", VA = "0x1805A9020", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x060020D1 RID: 8401 RVA: 0x000AD7F4 File Offset: 0x000AB9F4
	[Token(Token = "0x60020D1")]
	[Address(RVA = "0x5AF540", Offset = "0x5ADB40", VA = "0x1805AF540")]
	private void AnimDestoryHorse()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform axis = this.axis;
		int num = 0;
		int num2 = 0;
		int theZombieRow = this.theZombieRow;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)11), num, theZombieRow, num3 != 0UL, (float)num2);
	}

	// Token: 0x060020D2 RID: 8402 RVA: 0x000AD834 File Offset: 0x000ABA34
	[Token(Token = "0x60020D2")]
	[Address(RVA = "0x5B0590", Offset = "0x5AEB90", VA = "0x1805B0590", Slot = "28")]
	public override void Die(int reason = 0)
	{
		Animator anim = this.anim;
		this.theStatus = (ZombieStatus)((ulong)1L);
		anim.SetTrigger("GoDie");
	}

	// Token: 0x060020D3 RID: 8403 RVA: 0x000AD864 File Offset: 0x000ABA64
	[Token(Token = "0x60020D3")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "60")]
	public override void EatGarlic(Plant plant, float time = 1f, bool withSound = true)
	{
	}

	// Token: 0x060020D4 RID: 8404 RVA: 0x000AD874 File Offset: 0x000ABA74
	[Token(Token = "0x60020D4")]
	[Address(RVA = "0x5AFEB0", Offset = "0x5AE4B0", VA = "0x1805AFEB0")]
	private void AnimRevive()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform axis = this.axis;
		int num = 0;
		Transform child = axis.GetChild(num);
		Vector3 vector;
		float z = vector.z;
		int num2 = 0;
		ScreenShake.TriggerShake(0.15f);
		uint num3;
		GameAPP.PlaySound((int)num3, 0.5f, 1f);
		Transform axis2 = this.axis;
		int num4 = 0;
		Transform child2 = axis2.GetChild(num4);
		uint num5;
		float boxXFromColumn = Lawnf.GetBoxXFromColumn((int)num5);
		uint num6;
		float boxXFromColumn2 = Lawnf.GetBoxXFromColumn((int)num6);
		CreateZombie instance2 = CreateZombie.Instance;
		int num7 = 0;
		Zombie zombie;
		if (zombie != num7)
		{
			Board board = this.board;
			long num8 = this.theMaxHealth;
			num8 -= (long)num7;
			zombie.theHealth = num8;
			long num9 = this.theMaxHealth;
			num9 -= (long)num7;
			zombie.theMaxHealth = num9;
			num7 += num7;
			zombie.theHealth = (long)num7;
			num7 += num7;
			zombie.theMaxHealth = (long)num7;
		}
		ShootingManager instance3 = ShootingManager.Instance;
		int num10 = 0;
		if (instance3 != num10)
		{
			ShootingManager.Instance.AsBoss(zombie);
			Action<Zombie> onDeath = this.onDeath;
			zombie.onDeath = onDeath;
			this.onDeath = num2;
		}
		this.theStatus = (ZombieStatus)num2;
		uint num11;
		base.Die((int)num11);
	}

	// Token: 0x060020D5 RID: 8405 RVA: 0x000AD9AC File Offset: 0x000ABBAC
	[Token(Token = "0x60020D5")]
	[Address(RVA = "0x5A9160", Offset = "0x5A7760", VA = "0x1805A9160", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		long num;
		return num;
	}

	// Token: 0x060020D6 RID: 8406 RVA: 0x000AD9C0 File Offset: 0x000ABBC0
	[Token(Token = "0x60020D6")]
	[Address(RVA = "0x5B0FE0", Offset = "0x5AF5E0", VA = "0x1805B0FE0")]
	public HorseBoss()
	{
		Queue<Vector2Int> queue = new Queue();
		this.jumpTargetQueue = queue;
		List<HorseBoss.Skill> list = new List();
		int size = list._size;
		list._size = 1;
		list._syncRoot = (ulong)0L;
		int size2 = list._size;
		list._size = 1;
		int size3 = list._size;
		list._size = 1;
		int size4 = list._size;
		list._size = 1;
		int size5 = list._size;
		list._size = 1;
		int size6 = list._size;
		list._size = 1;
		this.skillQueue = list;
		List<ZombieType> list2 = new List();
		int size7 = list2._size;
		int size8 = list2._size;
		int size9 = list2._size;
		int size10 = list2._size;
		int size11 = list2._size;
		int size12 = list2._size;
		int size13 = list2._size;
		int size14 = list2._size;
		int size15 = list2._size;
		int size16 = list2._size;
		int size17 = list2._size;
		int size18 = list2._size;
		int size19 = list2._size;
		this.spawns = list2;
		this.spawnCountPerRow = (int)((ulong)1L);
		base..ctor();
	}

	// Token: 0x04001169 RID: 4457
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001169")]
	public GameObject Qi;

	// Token: 0x0400116A RID: 4458
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x400116A")]
	[SerializeField]
	private int restSummonCount = (int)((ulong)3L);

	// Token: 0x0400116B RID: 4459
	[FieldOffset(Offset = "0x284")]
	[Token(Token = "0x400116B")]
	private Vector2 skillStartPosition;

	// Token: 0x0400116C RID: 4460
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x400116C")]
	private readonly Queue<Vector2Int> jumpTargetQueue;

	// Token: 0x0400116D RID: 4461
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x400116D")]
	private bool jumping;

	// Token: 0x0400116E RID: 4462
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x400116E")]
	public Action onSpawn;

	// Token: 0x0400116F RID: 4463
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x400116F")]
	private int currentSkillIndex;

	// Token: 0x04001170 RID: 4464
	[FieldOffset(Offset = "0x2B0")]
	[Token(Token = "0x4001170")]
	private readonly List<HorseBoss.Skill> skillQueue;

	// Token: 0x04001171 RID: 4465
	[FieldOffset(Offset = "0x2B8")]
	[Token(Token = "0x4001171")]
	private Coroutine move;

	// Token: 0x04001172 RID: 4466
	[FieldOffset(Offset = "0x2C0")]
	[Token(Token = "0x4001172")]
	public List<ZombieType> spawns;

	// Token: 0x04001173 RID: 4467
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x4001173")]
	public int spawnCountPerRow;

	// Token: 0x020006B0 RID: 1712
	[Token(Token = "0x20006B0")]
	private enum Skill
	{
		// Token: 0x04001175 RID: 4469
		[Token(Token = "0x4001175")]
		Charge,
		// Token: 0x04001176 RID: 4470
		[Token(Token = "0x4001176")]
		Jump,
		// Token: 0x04001177 RID: 4471
		[Token(Token = "0x4001177")]
		BigSummon,
		// Token: 0x04001178 RID: 4472
		[Token(Token = "0x4001178")]
		FlagQi
	}
}
