using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000679 RID: 1657
[Token(Token = "0x2000679")]
public class HorseBoss : Zombie
{
	// Token: 0x06001FB3 RID: 8115 RVA: 0x000A86B8 File Offset: 0x000A68B8
	[Token(Token = "0x6001FB3")]
	[Address(RVA = "0x54DAC0", Offset = "0x54C0C0", VA = "0x18054DAC0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)38L);
		this.attributeCountDown = 5f;
		Action action = new Action(this.DefaultStatus);
		this.defaultAction = action;
	}

	// Token: 0x06001FB4 RID: 8116 RVA: 0x000A86F4 File Offset: 0x000A68F4
	[Token(Token = "0x6001FB4")]
	[Address(RVA = "0x54E4C0", Offset = "0x54CAC0", VA = "0x18054E4C0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(this.board.columnNum);
		Mouse instance = Mouse.Instance;
		int theZombieRow = this.theZombieRow;
		float landY = instance.GetLandY(boxXFromColumn, theZombieRow);
		Board board = this.board;
		long num;
		this.theHealth = (int)num;
		long num2;
		this.theMaxHealth = (int)num2;
		base.UpdateHealthText();
	}

	// Token: 0x06001FB5 RID: 8117 RVA: 0x000A875C File Offset: 0x000A695C
	[Token(Token = "0x6001FB5")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "24")]
	public override void ChangeRow(int theTargetRow)
	{
	}

	// Token: 0x06001FB6 RID: 8118 RVA: 0x000A876C File Offset: 0x000A696C
	[Token(Token = "0x6001FB6")]
	[Address(RVA = "0x54E630", Offset = "0x54CC30", VA = "0x18054E630", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		Board board = this.board;
		Collider2D col = this.col;
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x06001FB7 RID: 8119 RVA: 0x000A8794 File Offset: 0x000A6994
	[Token(Token = "0x6001FB7")]
	[Address(RVA = "0x54DCD0", Offset = "0x54C2D0", VA = "0x18054DCD0")]
	private void DefaultStatus()
	{
	}

	// Token: 0x06001FB8 RID: 8120 RVA: 0x000A87A4 File Offset: 0x000A69A4
	[Token(Token = "0x6001FB8")]
	[Address(RVA = "0x54D9F0", Offset = "0x54BFF0", VA = "0x18054D9F0", Slot = "23")]
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
			int num2 = this.theMaxHealth;
			num2 -= "summon";
			this.attributeCountDown = 7f;
			return;
		}
		this.attributeCountDown = 5f;
		this.StartSkill();
		this.restSummonCount = (int)((ulong)4L);
	}

	// Token: 0x06001FB9 RID: 8121 RVA: 0x000A8838 File Offset: 0x000A6A38
	[Token(Token = "0x6001FB9")]
	[Address(RVA = "0x54E2A0", Offset = "0x54C8A0", VA = "0x18054E2A0")]
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

	// Token: 0x06001FBA RID: 8122 RVA: 0x000A88F8 File Offset: 0x000A6AF8
	[Token(Token = "0x6001FBA")]
	[Address(RVA = "0x54DF50", Offset = "0x54C550", VA = "0x18054DF50", Slot = "21")]
	protected override void PositionUpdate()
	{
		if (!this.jumping)
		{
			Queue<Vector2Int> queue = this.jumpTargetQueue;
			base.PositionUpdate();
			return;
		}
	}

	// Token: 0x06001FBB RID: 8123 RVA: 0x000A8924 File Offset: 0x000A6B24
	[Token(Token = "0x6001FBB")]
	[Address(RVA = "0x54CA40", Offset = "0x54B040", VA = "0x18054CA40")]
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

	// Token: 0x06001FBC RID: 8124 RVA: 0x000A89A4 File Offset: 0x000A6BA4
	[Token(Token = "0x6001FBC")]
	[Address(RVA = "0x54CBF0", Offset = "0x54B1F0", VA = "0x18054CBF0")]
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

	// Token: 0x06001FBD RID: 8125 RVA: 0x000A8A24 File Offset: 0x000A6C24
	[Token(Token = "0x6001FBD")]
	[Address(RVA = "0x54CEB0", Offset = "0x54B4B0", VA = "0x18054CEB0")]
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

	// Token: 0x06001FBE RID: 8126 RVA: 0x000A8AA8 File Offset: 0x000A6CA8
	[Token(Token = "0x6001FBE")]
	[Address(RVA = "0x54CDA0", Offset = "0x54B3A0", VA = "0x18054CDA0")]
	private void AnimChargeSound()
	{
		GameAPP.PlaySound(42, 0.5f, 0.8f);
	}

	// Token: 0x06001FBF RID: 8127 RVA: 0x000A8AC8 File Offset: 0x000A6CC8
	[Token(Token = "0x6001FBF")]
	[Address(RVA = "0x54C910", Offset = "0x54AF10", VA = "0x18054C910")]
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

	// Token: 0x06001FC0 RID: 8128 RVA: 0x000A8B14 File Offset: 0x000A6D14
	[Token(Token = "0x6001FC0")]
	[Address(RVA = "0x54D600", Offset = "0x54BC00", VA = "0x18054D600")]
	private void AnimJumpStart()
	{
		Transform axis = this.axis;
		this.jumping = true;
		Vector2 targetPosition = this.GetTargetPosition();
		HorseBoss.<SmoothMoveCoroutine>d__25 <SmoothMoveCoroutine>d__;
		<SmoothMoveCoroutine>d__.System.IDisposable.Dispose();
		<SmoothMoveCoroutine>d__.<>1__state = (int)((ulong)0L);
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

	// Token: 0x06001FC1 RID: 8129 RVA: 0x000A8B94 File Offset: 0x000A6D94
	[Token(Token = "0x6001FC1")]
	[Address(RVA = "0x54DFB0", Offset = "0x54C5B0", VA = "0x18054DFB0")]
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

	// Token: 0x06001FC2 RID: 8130 RVA: 0x000A8C54 File Offset: 0x000A6E54
	[Token(Token = "0x6001FC2")]
	[Address(RVA = "0x54DD70", Offset = "0x54C370", VA = "0x18054DD70")]
	private Vector2 GetTargetPosition()
	{
		Vector2Int vector2Int = this.jumpTargetQueue.Peek();
		Mouse instance = Mouse.Instance;
		int x = vector2Int.m_X;
		float boxXFromColumn = instance.GetBoxXFromColumn(x);
		throw new NullReferenceException();
	}

	// Token: 0x06001FC3 RID: 8131 RVA: 0x000A8C94 File Offset: 0x000A6E94
	[Token(Token = "0x6001FC3")]
	[Address(RVA = "0x54E1F0", Offset = "0x54C7F0", VA = "0x18054E1F0")]
	private IEnumerator SmoothMoveCoroutine(Vector2 startPos, Vector2 targetPos, float duration)
	{
		HorseBoss.<SmoothMoveCoroutine>d__25 <SmoothMoveCoroutine>d__;
		<SmoothMoveCoroutine>d__.System.IDisposable.Dispose();
		<SmoothMoveCoroutine>d__.<>1__state = (int)((ulong)0L);
		<SmoothMoveCoroutine>d__.<>4__this = this;
		<SmoothMoveCoroutine>d__.startPos = startPos;
		<SmoothMoveCoroutine>d__.startPos.y = (float)0;
		<SmoothMoveCoroutine>d__.duration = duration;
		<SmoothMoveCoroutine>d__.targetPos = targetPos;
		<SmoothMoveCoroutine>d__.targetPos.y = (float)0;
		return null;
	}

	// Token: 0x06001FC4 RID: 8132 RVA: 0x000A8CE8 File Offset: 0x000A6EE8
	[Token(Token = "0x6001FC4")]
	[Address(RVA = "0x54D2D0", Offset = "0x54B8D0", VA = "0x18054D2D0")]
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

	// Token: 0x06001FC5 RID: 8133 RVA: 0x000A8DCC File Offset: 0x000A6FCC
	[Token(Token = "0x6001FC5")]
	[Address(RVA = "0x54D110", Offset = "0x54B710", VA = "0x18054D110")]
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
				num++;
				uint num2;
				num2 += (uint)4;
			}
			num++;
		}
		if (this.onSpawn != 0)
		{
		}
	}

	// Token: 0x06001FC6 RID: 8134 RVA: 0x000A8E30 File Offset: 0x000A7030
	[Token(Token = "0x6001FC6")]
	[Address(RVA = "0x54DB60", Offset = "0x54C160", VA = "0x18054DB60", Slot = "29")]
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
				Lawnf.ChangeSprite((float)num2, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06001FC7 RID: 8135 RVA: 0x000A8E6C File Offset: 0x000A706C
	[Token(Token = "0x6001FC7")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06001FC8 RID: 8136 RVA: 0x000A8E7C File Offset: 0x000A707C
	[Token(Token = "0x6001FC8")]
	[Address(RVA = "0x54DE20", Offset = "0x54C420", VA = "0x18054DE20")]
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

	// Token: 0x06001FC9 RID: 8137 RVA: 0x000A8EB8 File Offset: 0x000A70B8
	[Token(Token = "0x6001FC9")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06001FCA RID: 8138 RVA: 0x000A8EC8 File Offset: 0x000A70C8
	[Token(Token = "0x6001FCA")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06001FCB RID: 8139 RVA: 0x000A8ED8 File Offset: 0x000A70D8
	[Token(Token = "0x6001FCB")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06001FCC RID: 8140 RVA: 0x000A8EE8 File Offset: 0x000A70E8
	[Token(Token = "0x6001FCC")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06001FCD RID: 8141 RVA: 0x000A8EF8 File Offset: 0x000A70F8
	[Token(Token = "0x6001FCD")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "59")]
	public override void Garliced(bool playSound = false, bool certainRow = false)
	{
	}

	// Token: 0x06001FCE RID: 8142 RVA: 0x000A8F08 File Offset: 0x000A7108
	[Token(Token = "0x6001FCE")]
	[Address(RVA = "0x546D50", Offset = "0x545350", VA = "0x180546D50", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06001FCF RID: 8143 RVA: 0x000A8F18 File Offset: 0x000A7118
	[Token(Token = "0x6001FCF")]
	[Address(RVA = "0x54CE00", Offset = "0x54B400", VA = "0x18054CE00")]
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

	// Token: 0x06001FD0 RID: 8144 RVA: 0x000A8F58 File Offset: 0x000A7158
	[Token(Token = "0x6001FD0")]
	[Address(RVA = "0x54DD10", Offset = "0x54C310", VA = "0x18054DD10", Slot = "27")]
	public override void Die(int reason = 0)
	{
		Animator anim = this.anim;
		this.theStatus = (ZombieStatus)((ulong)1L);
		anim.SetTrigger("GoDie");
	}

	// Token: 0x06001FD1 RID: 8145 RVA: 0x000A8F88 File Offset: 0x000A7188
	[Token(Token = "0x6001FD1")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "58")]
	public override void EatGarlic(Plant plant, float time = 1f, bool withSound = true)
	{
	}

	// Token: 0x06001FD2 RID: 8146 RVA: 0x000A8F98 File Offset: 0x000A7198
	[Token(Token = "0x6001FD2")]
	[Address(RVA = "0x54D700", Offset = "0x54BD00", VA = "0x18054D700")]
	private void AnimRevive()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform axis = this.axis;
		int num = 0;
		Transform child = axis.GetChild(num);
		Vector3 vector;
		float z = vector.z;
		ScreenShake.TriggerShake(0.15f);
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		Transform axis2 = this.axis;
		int num3 = 0;
		Transform child2 = axis2.GetChild(num3);
		uint num4;
		float boxXFromColumn = Lawnf.GetBoxXFromColumn((int)num4);
		uint num5;
		float boxXFromColumn2 = Lawnf.GetBoxXFromColumn((int)num5);
		CreateZombie instance2 = CreateZombie.Instance;
		int num6 = 0;
		Zombie zombie;
		if (zombie != num6)
		{
			Board board = this.board;
			int num7 = this.theMaxHealth;
			num7 -= num6;
			zombie.theHealth = num7;
			int num8 = this.theMaxHealth;
			num8 -= num6;
			zombie.theMaxHealth = num8;
			num6 += num6;
			zombie.theHealth = num6;
			num6 += num6;
			zombie.theMaxHealth = num6;
		}
		this.theStatus = (ZombieStatus)((ulong)0L);
		uint num9;
		base.Die((int)num9);
	}

	// Token: 0x06001FD3 RID: 8147 RVA: 0x000A9094 File Offset: 0x000A7294
	[Token(Token = "0x6001FD3")]
	[Address(RVA = "0x546F50", Offset = "0x545550", VA = "0x180546F50", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		int num;
		if (num > 5000)
		{
		}
		return num;
	}

	// Token: 0x06001FD4 RID: 8148 RVA: 0x000A90B0 File Offset: 0x000A72B0
	[Token(Token = "0x6001FD4")]
	[Address(RVA = "0x54E750", Offset = "0x54CD50", VA = "0x18054E750")]
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

	// Token: 0x0400109C RID: 4252
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400109C")]
	public GameObject Qi;

	// Token: 0x0400109D RID: 4253
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400109D")]
	[SerializeField]
	private int restSummonCount = (int)((ulong)3L);

	// Token: 0x0400109E RID: 4254
	[FieldOffset(Offset = "0x264")]
	[Token(Token = "0x400109E")]
	private Vector2 skillStartPosition;

	// Token: 0x0400109F RID: 4255
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x400109F")]
	private readonly Queue<Vector2Int> jumpTargetQueue;

	// Token: 0x040010A0 RID: 4256
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40010A0")]
	private bool jumping;

	// Token: 0x040010A1 RID: 4257
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40010A1")]
	public Action onSpawn;

	// Token: 0x040010A2 RID: 4258
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x40010A2")]
	private int currentSkillIndex;

	// Token: 0x040010A3 RID: 4259
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x40010A3")]
	private readonly List<HorseBoss.Skill> skillQueue;

	// Token: 0x040010A4 RID: 4260
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x40010A4")]
	private Coroutine move;

	// Token: 0x040010A5 RID: 4261
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x40010A5")]
	public List<ZombieType> spawns;

	// Token: 0x040010A6 RID: 4262
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x40010A6")]
	public int spawnCountPerRow;

	// Token: 0x0200067A RID: 1658
	[Token(Token = "0x200067A")]
	private enum Skill
	{
		// Token: 0x040010A8 RID: 4264
		[Token(Token = "0x40010A8")]
		Charge,
		// Token: 0x040010A9 RID: 4265
		[Token(Token = "0x40010A9")]
		Jump,
		// Token: 0x040010AA RID: 4266
		[Token(Token = "0x40010AA")]
		BigSummon,
		// Token: 0x040010AB RID: 4267
		[Token(Token = "0x40010AB")]
		FlagQi
	}
}
