using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000760 RID: 1888
[Token(Token = "0x2000760")]
public class ZombieBoss : Zombie
{
	// Token: 0x06002647 RID: 9799 RVA: 0x000C8368 File Offset: 0x000C6568
	[Token(Token = "0x6002647")]
	[Address(RVA = "0x633CB0", Offset = "0x6322B0", VA = "0x180633CB0", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		Board board = this.board;
		this.revived = true;
		this.theHealth = this;
		this.theMaxHealth = this;
	}

	// Token: 0x06002648 RID: 9800 RVA: 0x000C83A0 File Offset: 0x000C65A0
	[Token(Token = "0x6002648")]
	[Address(RVA = "0x631620", Offset = "0x62FC20", VA = "0x180631620", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		long num = this.theHealth;
		num -= (long)theDamage;
		this.theHealth = num;
		int num2 = 0;
		int num3 = 0;
		if (!global::Core.Lawnf.ValueBetween((float)0, (float)num3, (float)num2))
		{
			SpriteRenderer component = this.head.GetComponent<SpriteRenderer>();
			int num4 = 0;
			component.enabled = num4 != 0;
			Transform transform = this.head.transform;
			int num5 = 0;
			GameObject gameObject = transform.GetChild(num5).gameObject;
			int num6 = 0;
			gameObject.SetActive(num6 != 0);
			uint num7;
			ulong num8;
			this.head.transform.GetChild((int)num7).gameObject.SetActive(num8 != 0UL);
			SpriteRenderer component2 = this.thumb.GetComponent<SpriteRenderer>();
			int num9 = 0;
			component2.enabled = num9 != 0;
			Transform transform2 = this.thumb.transform;
			int num10 = 0;
			GameObject gameObject2 = transform2.GetChild(num10).gameObject;
			int num11 = 0;
			gameObject2.SetActive(num11 != 0);
			uint num12;
			ulong num13;
			this.thumb.transform.GetChild((int)num12).gameObject.SetActive(num13 != 0UL);
			SpriteRenderer component3 = this.jaw.GetComponent<SpriteRenderer>();
			int num14 = 0;
			component3.enabled = num14 != 0;
			Transform transform3 = this.jaw.transform;
			int num15 = 0;
			GameObject gameObject3 = transform3.GetChild(num15).gameObject;
			int num16 = 0;
			gameObject3.SetActive(num16 != 0);
			uint num17;
			ulong num18;
			this.jaw.transform.GetChild((int)num17).gameObject.SetActive(num18 != 0UL);
			SpriteRenderer component4 = this.hand.GetComponent<SpriteRenderer>();
			int num19 = 0;
			component4.enabled = num19 != 0;
			Transform transform4 = this.hand.transform;
			int num20 = 0;
			GameObject gameObject4 = transform4.GetChild(num20).gameObject;
			int num21 = 0;
			gameObject4.SetActive(num21 != 0);
			uint num22;
			ulong num23;
			this.hand.transform.GetChild((int)num22).gameObject.SetActive(num23 != 0UL);
			SpriteRenderer component5 = this.foot_outter.GetComponent<SpriteRenderer>();
			int num24 = 0;
			component5.enabled = num24 != 0;
			Transform transform5 = this.foot_outter.transform;
			int num25 = 0;
			ulong num26;
			transform5.GetChild(num25).gameObject.SetActive(num26 != 0UL);
			uint num27;
			ulong num28;
			this.head.transform.GetChild((int)num27).gameObject.SetActive(num28 != 0UL);
			uint num29;
			ulong num30;
			this.head.transform.GetChild((int)num29).gameObject.SetActive(num30 != 0UL);
			return;
		}
		SpriteRenderer component6 = this.head.GetComponent<SpriteRenderer>();
		int num31 = 0;
		component6.enabled = num31 != 0;
		Transform transform6 = this.head.transform;
		int num32 = 0;
		ulong num33;
		transform6.GetChild(num32).gameObject.SetActive(num33 != 0UL);
		uint num34;
		GameObject gameObject5 = this.head.transform.GetChild((int)num34).gameObject;
		int num35 = 0;
		gameObject5.SetActive(num35 != 0);
		SpriteRenderer component7 = this.thumb.GetComponent<SpriteRenderer>();
		int num36 = 0;
		component7.enabled = num36 != 0;
		Transform transform7 = this.thumb.transform;
		int num37 = 0;
		ulong num38;
		transform7.GetChild(num37).gameObject.SetActive(num38 != 0UL);
		uint num39;
		GameObject gameObject6 = this.thumb.transform.GetChild((int)num39).gameObject;
		int num40 = 0;
		gameObject6.SetActive(num40 != 0);
		SpriteRenderer component8 = this.jaw.GetComponent<SpriteRenderer>();
		int num41 = 0;
		component8.enabled = num41 != 0;
		Transform transform8 = this.jaw.transform;
		int num42 = 0;
		ulong num43;
		transform8.GetChild(num42).gameObject.SetActive(num43 != 0UL);
		uint num44;
		GameObject gameObject7 = this.jaw.transform.GetChild((int)num44).gameObject;
		int num45 = 0;
		gameObject7.SetActive(num45 != 0);
		SpriteRenderer component9 = this.hand.GetComponent<SpriteRenderer>();
		int num46 = 0;
		component9.enabled = num46 != 0;
		Transform transform9 = this.hand.transform;
		int num47 = 0;
		ulong num48;
		transform9.GetChild(num47).gameObject.SetActive(num48 != 0UL);
		uint num49;
		GameObject gameObject8 = this.hand.transform.GetChild((int)num49).gameObject;
		int num50 = 0;
		gameObject8.SetActive(num50 != 0);
		SpriteRenderer component10 = this.foot_inner.GetComponent<SpriteRenderer>();
		int num51 = 0;
		component10.enabled = num51 != 0;
		Transform transform10 = this.foot_inner.transform;
		throw new NullReferenceException();
	}

	// Token: 0x06002649 RID: 9801 RVA: 0x000C8790 File Offset: 0x000C6990
	[Token(Token = "0x6002649")]
	[Address(RVA = "0x6315D0", Offset = "0x62FBD0", VA = "0x1806315D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Collider2D col = this.col;
		this.theStatus = (ZombieStatus)((ulong)21L);
		this.bossStatus = (ZombieBoss.BossStatus)((ulong)0L);
		int num = 0;
		col.enabled = num != 0;
	}

	// Token: 0x0600264A RID: 9802 RVA: 0x000C87CC File Offset: 0x000C69CC
	[Token(Token = "0x600264A")]
	[Address(RVA = "0x633D70", Offset = "0x632370", VA = "0x180633D70", Slot = "17")]
	protected override void Update()
	{
		base.Update();
		if (this.bossStatus == ZombieBoss.BossStatus.idle)
		{
			this.anim.SetTrigger("head_enter");
			this.ball = false;
			this.bossStatus = (ZombieBoss.BossStatus)((ulong)5L);
			GameAPP.PlaySound(149, 0.5f, 1f);
			this.SpawnUpdate();
		}
		if (this.bossStatus == ZombieBoss.BossStatus.head_idle)
		{
			float freezeSpeed = this.freezeSpeed;
			int num = 0;
			if (freezeSpeed > (float)num && !this.ball)
			{
				this.HeadUpdate();
			}
		}
	}

	// Token: 0x0600264B RID: 9803 RVA: 0x000C8850 File Offset: 0x000C6A50
	[Token(Token = "0x600264B")]
	[Address(RVA = "0x631FC0", Offset = "0x6305C0", VA = "0x180631FC0")]
	private void BossUpdate()
	{
		if (this.bossStatus == ZombieBoss.BossStatus.idle)
		{
			this.anim.SetTrigger("head_enter");
			this.ball = false;
			this.bossStatus = (ZombieBoss.BossStatus)((ulong)5L);
			GameAPP.PlaySound(149, 0.5f, 1f);
			this.SpawnUpdate();
		}
		if (this.bossStatus == ZombieBoss.BossStatus.head_idle)
		{
			float freezeSpeed = this.freezeSpeed;
			int num = 0;
			if (freezeSpeed > (float)num && !this.ball)
			{
				this.HeadUpdate();
				return;
			}
		}
	}

	// Token: 0x0600264C RID: 9804 RVA: 0x000C88CC File Offset: 0x000C6ACC
	[Token(Token = "0x600264C")]
	[Address(RVA = "0x6339A0", Offset = "0x631FA0", VA = "0x1806339A0")]
	private void SpawnUpdate()
	{
		ulong num4;
		do
		{
			int num = 0;
			float num2 = this.summonTime;
			float deltaTime = Time.deltaTime;
			this.summonTime = num2;
			if (0 <= (int)num2)
			{
				return;
			}
			this.summonTime = 4f;
			if (global::UnityEngine.Random.Range(0, 4) != 0)
			{
				break;
			}
			List<Plant> plantArray = this.board.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				this.FootCrash(num3);
			}
		}
		while (num4 != (ulong)0L);
		int num5 = global::UnityEngine.Random.Range(0, 5);
		this.targetRow = num5;
		Animator anim = this.anim;
		num5++;
		string text = string.Format("spawn{0}", num5);
		anim.SetTrigger(text);
		this.bossStatus = (ZombieBoss.BossStatus)((ulong)2L);
		GameAPP.PlaySound(150, 0.5f, 1f);
	}

	// Token: 0x0600264D RID: 9805 RVA: 0x000C89A4 File Offset: 0x000C6BA4
	[Token(Token = "0x600264D")]
	[Address(RVA = "0x632FA0", Offset = "0x6315A0", VA = "0x180632FA0")]
	private void HeadUpdate()
	{
		int num4;
		int num5;
		int num7;
		do
		{
			int num = 0;
			float num2 = this.ballCountDown;
			float deltaTime = Time.deltaTime;
			this.ballCountDown = num2;
			if (0 <= (int)num2)
			{
				return;
			}
			int num3 = global::UnityEngine.Random.Range(0, 5);
			this.targetRow = num3;
			Animator anim = this.anim;
			num3++;
			string text = string.Format("attack{0}", num3);
			anim.SetTrigger(text);
			this.animDriver.SetTrigger("drive");
			this.ball = true;
			GameAPP.PlaySound(149, 0.5f, 1f);
			this.ballCountDown = 10f;
			num4 = 0;
			num5 = 0;
			ConveyManager instance = ConveyManager.Instance;
			int num6 = 0;
			if (!(instance != num6))
			{
				goto IL_00E1;
			}
			List<CardUI> cardsOnBelt = ConveyManager.Instance.cardsOnBelt;
			num7 = 0;
			bool flag;
			if (flag)
			{
				int num8 = 0;
				if (!(num != num8))
				{
					continue;
				}
			}
		}
		while (num7 != 0);
		if (num4 == 0 || num5 == 0)
		{
		}
		IL_00E1:
		int num9;
		if (num5 == 0)
		{
			num9 = global::UnityEngine.Random.Range(num5, 2);
		}
		this.ballType = num9;
		SpriteRenderer spriteRenderer = this.eye;
		int num10 = 0;
		if (this.ballType == num10)
		{
			throw new NullReferenceException();
		}
		spriteRenderer.transform.GetChild(1).gameObject.SetActive(true);
	}

	// Token: 0x0600264E RID: 9806 RVA: 0x000C8AE4 File Offset: 0x000C6CE4
	[Token(Token = "0x600264E")]
	[Address(RVA = "0x633750", Offset = "0x631D50", VA = "0x180633750")]
	public void Skill()
	{
		long theMaxHealth = this.theMaxHealth;
		this.anim.SetTrigger("rv");
		this.bossStatus = (ZombieBoss.BossStatus)((ulong)4L);
		uint num2;
		int num = global::UnityEngine.Random.Range(0, (int)num2);
		this.targetRow = num;
		uint num4;
		int num3 = global::UnityEngine.Random.Range(0, (int)num4);
		this.targetColumn = num3;
		float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(num3);
		float boxYFromRow = Mouse.Instance.GetBoxYFromRow(num3);
		Transform transform = this.animRV.gameObject.transform.Find("Shadow");
		Vector3 vector;
		float z = vector.z;
		Transform transform2 = this.animRV.transform;
		Vector3 vector2;
		float z2 = vector2.z;
	}

	// Token: 0x0600264F RID: 9807 RVA: 0x000C8B90 File Offset: 0x000C6D90
	[Token(Token = "0x600264F")]
	[Address(RVA = "0x633660", Offset = "0x631C60", VA = "0x180633660", Slot = "76")]
	protected virtual void SetBungi(int theColumn)
	{
		CreateZombie instance = CreateZombie.Instance;
		int num = 0;
		ulong num2;
		BungiZombie component = instance.SetZombie(num, (ZombieType)((uint)45), 9.9f, num2 != 0UL).GetComponent<BungiZombie>();
		component.targetColumn = theColumn;
		component.boss = this;
		throw new NullReferenceException();
	}

	// Token: 0x06002650 RID: 9808 RVA: 0x000C8BD4 File Offset: 0x000C6DD4
	[Token(Token = "0x6002650")]
	[Address(RVA = "0x630A60", Offset = "0x62F060", VA = "0x180630A60")]
	private void AnimBungi()
	{
		this.SetBungi(1);
		this.SetBungi(2);
	}

	// Token: 0x06002651 RID: 9809 RVA: 0x000C8BF0 File Offset: 0x000C6DF0
	[Token(Token = "0x6002651")]
	[Address(RVA = "0x6334C0", Offset = "0x631AC0", VA = "0x1806334C0")]
	private void RvPositionUpdate(int theColumn, int theRow)
	{
		float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(theColumn);
		float boxYFromRow = Mouse.Instance.GetBoxYFromRow(theColumn);
		Transform transform = this.animRV.gameObject.transform.Find("Shadow");
		Vector3 vector;
		float z = vector.z;
		Transform transform2 = this.animRV.transform;
		Vector3 vector2;
		float z2 = vector2.z;
	}

	// Token: 0x06002652 RID: 9810 RVA: 0x000C8C58 File Offset: 0x000C6E58
	[Token(Token = "0x6002652")]
	[Address(RVA = "0x632810", Offset = "0x630E10", VA = "0x180632810")]
	private void FootCrash(int row)
	{
		Animator anim = this.anim;
		if (row == 0 || row == 0 || row != 0)
		{
		}
		anim.SetTrigger("stomp1");
		this.targetRow = row;
		this.bossStatus = (ZombieBoss.BossStatus)((ulong)3L);
	}

	// Token: 0x06002653 RID: 9811 RVA: 0x000C8C9C File Offset: 0x000C6E9C
	[Token(Token = "0x6002653")]
	[Address(RVA = "0x633460", Offset = "0x631A60", VA = "0x180633460")]
	private void RemoveDeBuff()
	{
		int num = 0;
		bool flag = base.RemoveBuff((EffectType)num);
		bool flag2 = base.RemoveBuff((EffectType)((uint)2));
		bool flag3 = base.RemoveBuff((EffectType)((uint)1));
		bool flag4 = base.RemoveBuff((EffectType)((uint)3));
		bool flag5 = base.RemoveBuff((EffectType)((uint)10));
	}

	// Token: 0x06002654 RID: 9812 RVA: 0x000C8CDC File Offset: 0x000C6EDC
	[Token(Token = "0x6002654")]
	[Address(RVA = "0x6320F0", Offset = "0x6306F0", VA = "0x1806320F0")]
	public IEnumerator ColoredEye(Color color)
	{
		ZombieBoss.<ColoredEye>d__35 <ColoredEye>d__;
		<ColoredEye>d__.System.IDisposable.Dispose();
		<ColoredEye>d__.<>1__state = (int)((ulong)0L);
		<ColoredEye>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06002655 RID: 9813 RVA: 0x000C8D00 File Offset: 0x000C6F00
	[Token(Token = "0x6002655")]
	[Address(RVA = "0x6333D0", Offset = "0x6319D0", VA = "0x1806333D0")]
	private void MachineSound2()
	{
		GameAPP.PlaySound(149, 0.5f, 1f);
	}

	// Token: 0x06002656 RID: 9814 RVA: 0x000C8D24 File Offset: 0x000C6F24
	[Token(Token = "0x6002656")]
	[Address(RVA = "0x6314B0", Offset = "0x62FAB0", VA = "0x1806314B0")]
	private void AnimSpawn()
	{
		Board board = this.board;
		CreateZombie instance = CreateZombie.Instance;
		ZombieType zombieType = this.GetZombieType();
		Transform transform = this.spawnPosition;
	}

	// Token: 0x06002657 RID: 9815 RVA: 0x000C8D60 File Offset: 0x000C6F60
	[Token(Token = "0x6002657")]
	[Address(RVA = "0x630E00", Offset = "0x62F400", VA = "0x180630E00")]
	private void AnimPutBall()
	{
		GameAPP.PlaySound(151, 0.5f, 1f);
		Transform transform = this.ballPosition;
		Vector3 vector;
		float z = vector.z;
		Mouse instance = Mouse.Instance;
		Transform transform2 = this.ballPosition;
		if (this.ballType != 1)
		{
			Vector3 vector2;
			float z2 = vector2.z;
		}
		Vector3 vector3;
		float z3 = vector3.z;
		GameObject[] itemPrefab = GameAPP.itemPrefab;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform3 = this.board.transform;
		GameObject gameObject;
		ZombieBall component = gameObject.GetComponent<ZombieBall>();
		int num = this.targetRow;
		component.theBallRow = num;
		component.boss = true;
		ZombieBall.<Bigger>d__16 <Bigger>d__;
		<Bigger>d__.System.IDisposable.Dispose();
		<Bigger>d__.<>1__state = (int)((ulong)0L);
		<Bigger>d__.<>4__this = component;
		Coroutine coroutine = component.StartCoroutine(<Bigger>d__);
		SortingGroup component2 = gameObject.GetComponent<SortingGroup>();
		int num2 = this.sortingGroup.sortingOrder + 1;
		component2.sortingOrder = num2;
		SortingGroup component3 = gameObject.GetComponent<SortingGroup>();
		int sortingLayerID = this.sortingGroup.sortingLayerID;
		component3.sortingLayerID = sortingLayerID;
	}

	// Token: 0x06002658 RID: 9816 RVA: 0x000C8E64 File Offset: 0x000C7064
	[Token(Token = "0x6002658")]
	[Address(RVA = "0x631290", Offset = "0x62F890", VA = "0x180631290", Slot = "77")]
	protected virtual void AnimRv()
	{
		int size = this.board.boardEntity.plantArray._size;
		int num = 0;
		int num2 = size - 1;
		if (size > 0)
		{
			Plant plant = this.board.boardEntity.plantArray[num2];
			int num3 = 0;
			if (plant != num3)
			{
				int num4 = this.targetRow;
				num4++;
				int num5 = this.targetColumn;
				num5 += 2;
				int num6 = 0;
				int num7 = 0;
				int num8 = 0;
				plant.Crashed(num8, num7, num6);
			}
			if (num != 0)
			{
				uint num9;
				uint num10;
				GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num9, (int)num10), 0.5f, 1f);
			}
		}
		uint num11;
		GameAPP.PlaySound((int)num11, 0.5f, 1f);
	}

	// Token: 0x06002659 RID: 9817 RVA: 0x000C8F1C File Offset: 0x000C711C
	[Token(Token = "0x6002659")]
	[Address(RVA = "0x630AC0", Offset = "0x62F0C0", VA = "0x180630AC0")]
	private void AnimCrash()
	{
		int size = this.board.boardEntity.plantArray._size;
		int num = 0;
		int num2 = size - 1;
		if (size > 0)
		{
			Plant plant = this.board.boardEntity.plantArray[num2];
			int num3 = 0;
			if (!(plant != num3) || plant.thePlantColumn <= 5 || plant.plantTag == (ulong)0L)
			{
			}
			if (num != 0)
			{
				uint num4;
				uint num5;
				GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num4, (int)num5), 0.5f, 1f);
			}
		}
		ScreenShake.TriggerShake(0.15f);
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x0600265A RID: 9818 RVA: 0x000C8FC4 File Offset: 0x000C71C4
	[Token(Token = "0x600265A")]
	[Address(RVA = "0x6328E0", Offset = "0x630EE0", VA = "0x1806328E0")]
	private ZombieType GetZombieType()
	{
		int num = this.summonCount;
		if (num <= 4)
		{
		}
		num += -5;
		if (num <= 2)
		{
		}
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		int size7 = list._size;
		int size8 = list._size;
		int size9 = list._size;
		int size10 = list._size;
		int size11 = list._size;
		int size12 = list._size;
		int size13 = list._size;
		int size14 = list._size;
		int size15 = list._size;
		int size16 = list._size;
		int size17 = list._size;
		int size18 = list._size;
		int num2 = list._size;
		num2 = global::UnityEngine.Random.Range(0, num2);
		return list[num2];
	}

	// Token: 0x0600265B RID: 9819 RVA: 0x000C90AC File Offset: 0x000C72AC
	[Token(Token = "0x600265B")]
	[Address(RVA = "0x5A9160", Offset = "0x5A7760", VA = "0x1805A9160", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		long num;
		return num;
	}

	// Token: 0x0600265C RID: 9820 RVA: 0x000C90C0 File Offset: 0x000C72C0
	[Token(Token = "0x600265C")]
	[Address(RVA = "0x5A9020", Offset = "0x5A7620", VA = "0x1805A9020", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x0600265D RID: 9821 RVA: 0x000C90D0 File Offset: 0x000C72D0
	[Token(Token = "0x600265D")]
	[Address(RVA = "0x633D30", Offset = "0x632330", VA = "0x180633D30", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x0600265E RID: 9822 RVA: 0x000C90E0 File Offset: 0x000C72E0
	[Token(Token = "0x600265E")]
	[Address(RVA = "0x630D70", Offset = "0x62F370", VA = "0x180630D70")]
	private void AnimFootSound()
	{
		ScreenShake.TriggerShake(0.02f);
		GameAPP.PlaySound(74, 0.5f, 1f);
	}

	// Token: 0x0600265F RID: 9823 RVA: 0x000C9108 File Offset: 0x000C7308
	[Token(Token = "0x600265F")]
	[Address(RVA = "0x632660", Offset = "0x630C60", VA = "0x180632660")]
	private void DieExplode()
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		float num = global::UnityEngine.Random.Range(4f, 9f);
		float num2 = global::UnityEngine.Random.Range(-1f, 5f);
		ScreenShake.TriggerShake(0.05f);
	}

	// Token: 0x06002660 RID: 9824 RVA: 0x000C9154 File Offset: 0x000C7354
	[Token(Token = "0x6002660")]
	[Address(RVA = "0x632220", Offset = "0x630820", VA = "0x180632220", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Obstacle> zombieBalls = this.board.zombieBalls;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
		GameAPP.PlaySound(112, 0.5f, 1f);
		bool flag3;
		bool flag2 = flag3 - true;
		if (flag3 > false)
		{
			int num4 = 0;
			Zombie zombie;
			if (zombie != num4 && zombie.theZombieType != ZombieType.ZombieBoss && zombie.theZombieType != ZombieType.ZombieBoss2)
			{
				zombie.Die(1);
			}
		}
		bool flag4 = flag2 - true;
		if (flag2 > false)
		{
			int num5 = 0;
			Zombie zombie2;
			if (zombie2 != num5 && zombie2.theZombieType != ZombieType.ZombieBoss && zombie2.theZombieType != ZombieType.ZombieBoss2)
			{
				zombie2.Die(1);
			}
		}
		ZombieBoss.<ColoredEye>d__35 <ColoredEye>d__;
		<ColoredEye>d__.<>1__state = (int)((ulong)0L);
		<ColoredEye>d__.<>4__this = 0;
	}

	// Token: 0x06002661 RID: 9825 RVA: 0x000C9230 File Offset: 0x000C7430
	[Token(Token = "0x6002661")]
	[Address(RVA = "0x6327C0", Offset = "0x630DC0", VA = "0x1806327C0")]
	private void DriverDie()
	{
		this.animDriver.SetTrigger("Die");
	}

	// Token: 0x06002662 RID: 9826 RVA: 0x000C9254 File Offset: 0x000C7454
	[Token(Token = "0x6002662")]
	[Address(RVA = "0x632170", Offset = "0x630770", VA = "0x180632170")]
	private void DieAnimOver()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002663 RID: 9827 RVA: 0x000C9274 File Offset: 0x000C7474
	[Token(Token = "0x6002663")]
	[Address(RVA = "0x632760", Offset = "0x630D60", VA = "0x180632760", Slot = "28")]
	public override void Die(int reason = 0)
	{
		Animator anim = this.anim;
		this.theStatus = (ZombieStatus)((ulong)1L);
		anim.SetTrigger("GoDie");
	}

	// Token: 0x06002664 RID: 9828 RVA: 0x000C92A4 File Offset: 0x000C74A4
	[Token(Token = "0x6002664")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06002665 RID: 9829 RVA: 0x000C92B4 File Offset: 0x000C74B4
	[Token(Token = "0x6002665")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06002666 RID: 9830 RVA: 0x000C92C4 File Offset: 0x000C74C4
	[Token(Token = "0x6002666")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "54")]
	public override void SetPoison(float time = 10f)
	{
	}

	// Token: 0x06002667 RID: 9831 RVA: 0x000C92D4 File Offset: 0x000C74D4
	[Token(Token = "0x6002667")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "55")]
	public override void AddPoisonLevel()
	{
	}

	// Token: 0x06002668 RID: 9832 RVA: 0x000C92E4 File Offset: 0x000C74E4
	[Token(Token = "0x6002668")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "60")]
	public override void EatGarlic(Plant plant, float time = 1f, bool withSound = true)
	{
	}

	// Token: 0x06002669 RID: 9833 RVA: 0x000C92F4 File Offset: 0x000C74F4
	[Token(Token = "0x6002669")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "61")]
	public override void Garliced(bool playSound = false, bool certainRow = false)
	{
	}

	// Token: 0x0600266A RID: 9834 RVA: 0x000C9304 File Offset: 0x000C7504
	[Token(Token = "0x600266A")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x0600266B RID: 9835 RVA: 0x000C9314 File Offset: 0x000C7514
	[Token(Token = "0x600266B")]
	[Address(RVA = "0x633730", Offset = "0x631D30", VA = "0x180633730", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		base.SetCold(time, coldLevel, freeze);
	}

	// Token: 0x0600266C RID: 9836 RVA: 0x000C932C File Offset: 0x000C752C
	[Token(Token = "0x600266C")]
	[Address(RVA = "0x603480", Offset = "0x601A80", VA = "0x180603480", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x0600266D RID: 9837 RVA: 0x000C9348 File Offset: 0x000C7548
	[Token(Token = "0x600266D")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "72")]
	public override void RealKnockBack(float x)
	{
	}

	// Token: 0x0600266E RID: 9838 RVA: 0x000C9358 File Offset: 0x000C7558
	[Token(Token = "0x600266E")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "25")]
	public override void ChangeRow(int theTargetRow)
	{
	}

	// Token: 0x0600266F RID: 9839 RVA: 0x000C9368 File Offset: 0x000C7568
	[Token(Token = "0x600266F")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002670 RID: 9840 RVA: 0x000C9378 File Offset: 0x000C7578
	[Token(Token = "0x6002670")]
	[Address(RVA = "0x6309F0", Offset = "0x62EFF0", VA = "0x1806309F0")]
	public ZombieBoss()
	{
	}

	// Token: 0x04001373 RID: 4979
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001373")]
	public int targetRow;

	// Token: 0x04001374 RID: 4980
	[FieldOffset(Offset = "0x27C")]
	[Token(Token = "0x4001374")]
	public int targetColumn;

	// Token: 0x04001375 RID: 4981
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001375")]
	public int ballType;

	// Token: 0x04001376 RID: 4982
	[FieldOffset(Offset = "0x284")]
	[Token(Token = "0x4001376")]
	public int summonCount;

	// Token: 0x04001377 RID: 4983
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4001377")]
	public int spawnCount = (int)((ulong)8L);

	// Token: 0x04001378 RID: 4984
	[FieldOffset(Offset = "0x28C")]
	[Token(Token = "0x4001378")]
	public int summonBallCount;

	// Token: 0x04001379 RID: 4985
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4001379")]
	public float summonTime = 5f;

	// Token: 0x0400137A RID: 4986
	[FieldOffset(Offset = "0x294")]
	[Token(Token = "0x400137A")]
	public float ballCountDown = 3f;

	// Token: 0x0400137B RID: 4987
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x400137B")]
	public bool ball;

	// Token: 0x0400137C RID: 4988
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x400137C")]
	public Animator animDriver;

	// Token: 0x0400137D RID: 4989
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x400137D")]
	public Animator animRV;

	// Token: 0x0400137E RID: 4990
	[FieldOffset(Offset = "0x2B0")]
	[Token(Token = "0x400137E")]
	public Transform ballPosition;

	// Token: 0x0400137F RID: 4991
	[FieldOffset(Offset = "0x2B8")]
	[Token(Token = "0x400137F")]
	public Transform spawnPosition;

	// Token: 0x04001380 RID: 4992
	[FieldOffset(Offset = "0x2C0")]
	[Token(Token = "0x4001380")]
	public SpriteRenderer eye;

	// Token: 0x04001381 RID: 4993
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x4001381")]
	public ZombieBoss.BossStatus bossStatus;

	// Token: 0x04001382 RID: 4994
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x4001382")]
	public GameObject head;

	// Token: 0x04001383 RID: 4995
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x4001383")]
	public GameObject thumb;

	// Token: 0x04001384 RID: 4996
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x4001384")]
	public GameObject jaw;

	// Token: 0x04001385 RID: 4997
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x4001385")]
	public GameObject hand;

	// Token: 0x04001386 RID: 4998
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x4001386")]
	public GameObject foot_inner;

	// Token: 0x04001387 RID: 4999
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x4001387")]
	public GameObject foot_outter;

	// Token: 0x04001388 RID: 5000
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x4001388")]
	public GameObject eyes;

	// Token: 0x02000761 RID: 1889
	[Token(Token = "0x2000761")]
	public enum BossStatus
	{
		// Token: 0x0400138A RID: 5002
		[Token(Token = "0x400138A")]
		enter,
		// Token: 0x0400138B RID: 5003
		[Token(Token = "0x400138B")]
		idle,
		// Token: 0x0400138C RID: 5004
		[Token(Token = "0x400138C")]
		spawn,
		// Token: 0x0400138D RID: 5005
		[Token(Token = "0x400138D")]
		foot,
		// Token: 0x0400138E RID: 5006
		[Token(Token = "0x400138E")]
		rv,
		// Token: 0x0400138F RID: 5007
		[Token(Token = "0x400138F")]
		head_enter,
		// Token: 0x04001390 RID: 5008
		[Token(Token = "0x4001390")]
		head_idle,
		// Token: 0x04001391 RID: 5009
		[Token(Token = "0x4001391")]
		head_leave,
		// Token: 0x04001392 RID: 5010
		[Token(Token = "0x4001392")]
		bungi
	}
}
