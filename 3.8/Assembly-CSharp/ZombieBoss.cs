using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000727 RID: 1831
[Token(Token = "0x2000727")]
public class ZombieBoss : Zombie
{
	// Token: 0x06002524 RID: 9508 RVA: 0x000C3474 File Offset: 0x000C1674
	[Token(Token = "0x6002524")]
	[Address(RVA = "0x5D28A0", Offset = "0x5D0EA0", VA = "0x1805D28A0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		Board board = this.board;
		this.revived = true;
		this.theHealth = this;
		this.theMaxHealth = this;
	}

	// Token: 0x06002525 RID: 9509 RVA: 0x000C34AC File Offset: 0x000C16AC
	[Token(Token = "0x6002525")]
	[Address(RVA = "0x5D0280", Offset = "0x5CE880", VA = "0x1805D0280", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		int num = this.theHealth;
		num -= theDamage;
		this.theHealth = num;
		bool flag;
		if (!flag)
		{
			SpriteRenderer component = this.head.GetComponent<SpriteRenderer>();
			int num2 = 0;
			component.enabled = num2 != 0;
			Transform transform = this.head.transform;
			int num3 = 0;
			GameObject gameObject = transform.GetChild(num3).gameObject;
			int num4 = 0;
			gameObject.SetActive(num4 != 0);
			uint num5;
			ulong num6;
			this.head.transform.GetChild((int)num5).gameObject.SetActive(num6 != 0UL);
			SpriteRenderer component2 = this.thumb.GetComponent<SpriteRenderer>();
			int num7 = 0;
			component2.enabled = num7 != 0;
			Transform transform2 = this.thumb.transform;
			int num8 = 0;
			GameObject gameObject2 = transform2.GetChild(num8).gameObject;
			int num9 = 0;
			gameObject2.SetActive(num9 != 0);
			uint num10;
			ulong num11;
			this.thumb.transform.GetChild((int)num10).gameObject.SetActive(num11 != 0UL);
			SpriteRenderer component3 = this.jaw.GetComponent<SpriteRenderer>();
			int num12 = 0;
			component3.enabled = num12 != 0;
			Transform transform3 = this.jaw.transform;
			int num13 = 0;
			GameObject gameObject3 = transform3.GetChild(num13).gameObject;
			int num14 = 0;
			gameObject3.SetActive(num14 != 0);
			uint num15;
			ulong num16;
			this.jaw.transform.GetChild((int)num15).gameObject.SetActive(num16 != 0UL);
			SpriteRenderer component4 = this.hand.GetComponent<SpriteRenderer>();
			int num17 = 0;
			component4.enabled = num17 != 0;
			Transform transform4 = this.hand.transform;
			int num18 = 0;
			GameObject gameObject4 = transform4.GetChild(num18).gameObject;
			int num19 = 0;
			gameObject4.SetActive(num19 != 0);
			uint num20;
			ulong num21;
			this.hand.transform.GetChild((int)num20).gameObject.SetActive(num21 != 0UL);
			SpriteRenderer component5 = this.foot_outter.GetComponent<SpriteRenderer>();
			int num22 = 0;
			component5.enabled = num22 != 0;
			Transform transform5 = this.foot_outter.transform;
			int num23 = 0;
			ulong num24;
			transform5.GetChild(num23).gameObject.SetActive(num24 != 0UL);
			uint num25;
			ulong num26;
			this.head.transform.GetChild((int)num25).gameObject.SetActive(num26 != 0UL);
			uint num27;
			ulong num28;
			this.head.transform.GetChild((int)num27).gameObject.SetActive(num28 != 0UL);
			return;
		}
		SpriteRenderer component6 = this.head.GetComponent<SpriteRenderer>();
		int num29 = 0;
		component6.enabled = num29 != 0;
		Transform transform6 = this.head.transform;
		int num30 = 0;
		ulong num31;
		transform6.GetChild(num30).gameObject.SetActive(num31 != 0UL);
		uint num32;
		GameObject gameObject5 = this.head.transform.GetChild((int)num32).gameObject;
		int num33 = 0;
		gameObject5.SetActive(num33 != 0);
		SpriteRenderer component7 = this.thumb.GetComponent<SpriteRenderer>();
		int num34 = 0;
		component7.enabled = num34 != 0;
		Transform transform7 = this.thumb.transform;
		int num35 = 0;
		ulong num36;
		transform7.GetChild(num35).gameObject.SetActive(num36 != 0UL);
		uint num37;
		GameObject gameObject6 = this.thumb.transform.GetChild((int)num37).gameObject;
		int num38 = 0;
		gameObject6.SetActive(num38 != 0);
		SpriteRenderer component8 = this.jaw.GetComponent<SpriteRenderer>();
		int num39 = 0;
		component8.enabled = num39 != 0;
		Transform transform8 = this.jaw.transform;
		int num40 = 0;
		ulong num41;
		transform8.GetChild(num40).gameObject.SetActive(num41 != 0UL);
		uint num42;
		GameObject gameObject7 = this.jaw.transform.GetChild((int)num42).gameObject;
		int num43 = 0;
		gameObject7.SetActive(num43 != 0);
		SpriteRenderer component9 = this.hand.GetComponent<SpriteRenderer>();
		int num44 = 0;
		component9.enabled = num44 != 0;
		Transform transform9 = this.hand.transform;
		int num45 = 0;
		ulong num46;
		transform9.GetChild(num45).gameObject.SetActive(num46 != 0UL);
		uint num47;
		GameObject gameObject8 = this.hand.transform.GetChild((int)num47).gameObject;
		int num48 = 0;
		gameObject8.SetActive(num48 != 0);
		SpriteRenderer component10 = this.foot_inner.GetComponent<SpriteRenderer>();
		int num49 = 0;
		component10.enabled = num49 != 0;
		Transform transform10 = this.foot_inner.transform;
		throw new NullReferenceException();
	}

	// Token: 0x06002526 RID: 9510 RVA: 0x000C3890 File Offset: 0x000C1A90
	[Token(Token = "0x6002526")]
	[Address(RVA = "0x5D0230", Offset = "0x5CE830", VA = "0x1805D0230", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Collider2D col = this.col;
		this.theStatus = (ZombieStatus)((ulong)21L);
		this.bossStatus = (ZombieBoss.BossStatus)((ulong)0L);
		int num = 0;
		col.enabled = num != 0;
	}

	// Token: 0x06002527 RID: 9511 RVA: 0x000C38CC File Offset: 0x000C1ACC
	[Token(Token = "0x6002527")]
	[Address(RVA = "0x5D2950", Offset = "0x5D0F50", VA = "0x1805D2950", Slot = "16")]
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

	// Token: 0x06002528 RID: 9512 RVA: 0x000C3950 File Offset: 0x000C1B50
	[Token(Token = "0x6002528")]
	[Address(RVA = "0x5D0BF0", Offset = "0x5CF1F0", VA = "0x1805D0BF0")]
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

	// Token: 0x06002529 RID: 9513 RVA: 0x000C39CC File Offset: 0x000C1BCC
	[Token(Token = "0x6002529")]
	[Address(RVA = "0x5D2590", Offset = "0x5D0B90", VA = "0x1805D2590")]
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

	// Token: 0x0600252A RID: 9514 RVA: 0x000C3AA4 File Offset: 0x000C1CA4
	[Token(Token = "0x600252A")]
	[Address(RVA = "0x5D1B90", Offset = "0x5D0190", VA = "0x1805D1B90")]
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

	// Token: 0x0600252B RID: 9515 RVA: 0x000C3BE4 File Offset: 0x000C1DE4
	[Token(Token = "0x600252B")]
	[Address(RVA = "0x5D2340", Offset = "0x5D0940", VA = "0x1805D2340")]
	public void Skill()
	{
		int theMaxHealth = this.theMaxHealth;
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

	// Token: 0x0600252C RID: 9516 RVA: 0x000C3C90 File Offset: 0x000C1E90
	[Token(Token = "0x600252C")]
	[Address(RVA = "0x5D2250", Offset = "0x5D0850", VA = "0x1805D2250", Slot = "74")]
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

	// Token: 0x0600252D RID: 9517 RVA: 0x000C3CD4 File Offset: 0x000C1ED4
	[Token(Token = "0x600252D")]
	[Address(RVA = "0x5CF6C0", Offset = "0x5CDCC0", VA = "0x1805CF6C0")]
	private void AnimBungi()
	{
		this.SetBungi(1);
		this.SetBungi(2);
	}

	// Token: 0x0600252E RID: 9518 RVA: 0x000C3CF0 File Offset: 0x000C1EF0
	[Token(Token = "0x600252E")]
	[Address(RVA = "0x5D20B0", Offset = "0x5D06B0", VA = "0x1805D20B0")]
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

	// Token: 0x0600252F RID: 9519 RVA: 0x000C3D58 File Offset: 0x000C1F58
	[Token(Token = "0x600252F")]
	[Address(RVA = "0x5D1400", Offset = "0x5CFA00", VA = "0x1805D1400")]
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

	// Token: 0x06002530 RID: 9520 RVA: 0x000C3D9C File Offset: 0x000C1F9C
	[Token(Token = "0x6002530")]
	[Address(RVA = "0x5D2050", Offset = "0x5D0650", VA = "0x1805D2050")]
	private void RemoveDeBuff()
	{
		int num = 0;
		bool flag = base.RemoveBuff((EffectType)num);
		bool flag2 = base.RemoveBuff((EffectType)((uint)2));
		bool flag3 = base.RemoveBuff((EffectType)((uint)1));
		bool flag4 = base.RemoveBuff((EffectType)((uint)3));
		bool flag5 = base.RemoveBuff((EffectType)((uint)10));
	}

	// Token: 0x06002531 RID: 9521 RVA: 0x000C3DDC File Offset: 0x000C1FDC
	[Token(Token = "0x6002531")]
	[Address(RVA = "0x5D0D20", Offset = "0x5CF320", VA = "0x1805D0D20")]
	public IEnumerator ColoredEye(Color color)
	{
		ZombieBoss.<ColoredEye>d__35 <ColoredEye>d__;
		<ColoredEye>d__.System.IDisposable.Dispose();
		<ColoredEye>d__.<>1__state = (int)((ulong)0L);
		<ColoredEye>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06002532 RID: 9522 RVA: 0x000C3E00 File Offset: 0x000C2000
	[Token(Token = "0x6002532")]
	[Address(RVA = "0x5D1FC0", Offset = "0x5D05C0", VA = "0x1805D1FC0")]
	private void MachineSound2()
	{
		GameAPP.PlaySound(149, 0.5f, 1f);
	}

	// Token: 0x06002533 RID: 9523 RVA: 0x000C3E24 File Offset: 0x000C2024
	[Token(Token = "0x6002533")]
	[Address(RVA = "0x5D0110", Offset = "0x5CE710", VA = "0x1805D0110")]
	private void AnimSpawn()
	{
		Board board = this.board;
		CreateZombie instance = CreateZombie.Instance;
		ZombieType zombieType = this.GetZombieType();
		Transform transform = this.spawnPosition;
	}

	// Token: 0x06002534 RID: 9524 RVA: 0x000C3E60 File Offset: 0x000C2060
	[Token(Token = "0x6002534")]
	[Address(RVA = "0x5CFA60", Offset = "0x5CE060", VA = "0x1805CFA60")]
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

	// Token: 0x06002535 RID: 9525 RVA: 0x000C3F64 File Offset: 0x000C2164
	[Token(Token = "0x6002535")]
	[Address(RVA = "0x5CFEF0", Offset = "0x5CE4F0", VA = "0x1805CFEF0", Slot = "75")]
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

	// Token: 0x06002536 RID: 9526 RVA: 0x000C401C File Offset: 0x000C221C
	[Token(Token = "0x6002536")]
	[Address(RVA = "0x5CF720", Offset = "0x5CDD20", VA = "0x1805CF720")]
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

	// Token: 0x06002537 RID: 9527 RVA: 0x000C40C4 File Offset: 0x000C22C4
	[Token(Token = "0x6002537")]
	[Address(RVA = "0x5D14D0", Offset = "0x5CFAD0", VA = "0x1805D14D0")]
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

	// Token: 0x06002538 RID: 9528 RVA: 0x000C41AC File Offset: 0x000C23AC
	[Token(Token = "0x6002538")]
	[Address(RVA = "0x546F50", Offset = "0x545550", VA = "0x180546F50", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		int num;
		if (num > 5000)
		{
		}
		return num;
	}

	// Token: 0x06002539 RID: 9529 RVA: 0x000C41C8 File Offset: 0x000C23C8
	[Token(Token = "0x6002539")]
	[Address(RVA = "0x546D50", Offset = "0x545350", VA = "0x180546D50", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x0600253A RID: 9530 RVA: 0x000C41D8 File Offset: 0x000C23D8
	[Token(Token = "0x600253A")]
	[Address(RVA = "0x5D2920", Offset = "0x5D0F20", VA = "0x1805D2920", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x0600253B RID: 9531 RVA: 0x000C41E8 File Offset: 0x000C23E8
	[Token(Token = "0x600253B")]
	[Address(RVA = "0x5CF9D0", Offset = "0x5CDFD0", VA = "0x1805CF9D0")]
	private void AnimFootSound()
	{
		ScreenShake.TriggerShake(0.02f);
		GameAPP.PlaySound(74, 0.5f, 1f);
	}

	// Token: 0x0600253C RID: 9532 RVA: 0x000C4210 File Offset: 0x000C2410
	[Token(Token = "0x600253C")]
	[Address(RVA = "0x5D1290", Offset = "0x5CF890", VA = "0x1805D1290")]
	private void DieExplode()
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		float num = global::UnityEngine.Random.Range(4f, 9f);
		float num2 = global::UnityEngine.Random.Range(-1f, 5f);
		ScreenShake.TriggerShake(0.05f);
	}

	// Token: 0x0600253D RID: 9533 RVA: 0x000C425C File Offset: 0x000C245C
	[Token(Token = "0x600253D")]
	[Address(RVA = "0x5D0E50", Offset = "0x5CF450", VA = "0x1805D0E50", Slot = "28")]
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
		if (10 > 0)
		{
			int num4 = 0;
			Zombie zombie;
			if (zombie != num4 && zombie.theZombieType != ZombieType.ZombieBoss && zombie.theZombieType != ZombieType.ZombieBoss2)
			{
				zombie.Die(1);
			}
		}
		int num5 = 0;
		Zombie zombie2;
		if (zombie2 != num5 && zombie2.theZombieType != ZombieType.ZombieBoss && zombie2.theZombieType != ZombieType.ZombieBoss2)
		{
			zombie2.Die(1);
		}
		ZombieBoss.<ColoredEye>d__35 <ColoredEye>d__;
		<ColoredEye>d__.<>1__state = (int)((ulong)0L);
		<ColoredEye>d__.<>4__this = 0;
	}

	// Token: 0x0600253E RID: 9534 RVA: 0x000C4328 File Offset: 0x000C2528
	[Token(Token = "0x600253E")]
	[Address(RVA = "0x5D13B0", Offset = "0x5CF9B0", VA = "0x1805D13B0")]
	private void DriverDie()
	{
		this.animDriver.SetTrigger("Die");
	}

	// Token: 0x0600253F RID: 9535 RVA: 0x000C434C File Offset: 0x000C254C
	[Token(Token = "0x600253F")]
	[Address(RVA = "0x5D0DA0", Offset = "0x5CF3A0", VA = "0x1805D0DA0")]
	private void DieAnimOver()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002540 RID: 9536 RVA: 0x000C436C File Offset: 0x000C256C
	[Token(Token = "0x6002540")]
	[Address(RVA = "0x5D1390", Offset = "0x5CF990", VA = "0x1805D1390", Slot = "27")]
	public override void Die(int reason = 0)
	{
		this.isDoom = false;
		int num = 0;
		base.Die(num);
	}

	// Token: 0x06002541 RID: 9537 RVA: 0x000C438C File Offset: 0x000C258C
	[Token(Token = "0x6002541")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06002542 RID: 9538 RVA: 0x000C439C File Offset: 0x000C259C
	[Token(Token = "0x6002542")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06002543 RID: 9539 RVA: 0x000C43AC File Offset: 0x000C25AC
	[Token(Token = "0x6002543")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "52")]
	public override void SetPoison(float time = 10f)
	{
	}

	// Token: 0x06002544 RID: 9540 RVA: 0x000C43BC File Offset: 0x000C25BC
	[Token(Token = "0x6002544")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "53")]
	public override void AddPoisonLevel()
	{
	}

	// Token: 0x06002545 RID: 9541 RVA: 0x000C43CC File Offset: 0x000C25CC
	[Token(Token = "0x6002545")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "58")]
	public override void EatGarlic(Plant plant, float time = 1f, bool withSound = true)
	{
	}

	// Token: 0x06002546 RID: 9542 RVA: 0x000C43DC File Offset: 0x000C25DC
	[Token(Token = "0x6002546")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "59")]
	public override void Garliced(bool playSound = false, bool certainRow = false)
	{
	}

	// Token: 0x06002547 RID: 9543 RVA: 0x000C43EC File Offset: 0x000C25EC
	[Token(Token = "0x6002547")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002548 RID: 9544 RVA: 0x000C43FC File Offset: 0x000C25FC
	[Token(Token = "0x6002548")]
	[Address(RVA = "0x5D2320", Offset = "0x5D0920", VA = "0x1805D2320", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		base.SetCold(time, coldLevel, freeze);
	}

	// Token: 0x06002549 RID: 9545 RVA: 0x000C4414 File Offset: 0x000C2614
	[Token(Token = "0x6002549")]
	[Address(RVA = "0x58A6B0", Offset = "0x588CB0", VA = "0x18058A6B0", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x0600254A RID: 9546 RVA: 0x000C4430 File Offset: 0x000C2630
	[Token(Token = "0x600254A")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "70")]
	public override void RealKnockBack(float x)
	{
	}

	// Token: 0x0600254B RID: 9547 RVA: 0x000C4440 File Offset: 0x000C2640
	[Token(Token = "0x600254B")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x0600254C RID: 9548 RVA: 0x000C4450 File Offset: 0x000C2650
	[Token(Token = "0x600254C")]
	[Address(RVA = "0x5CF650", Offset = "0x5CDC50", VA = "0x1805CF650")]
	public ZombieBoss()
	{
	}

	// Token: 0x0400129E RID: 4766
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400129E")]
	public int targetRow;

	// Token: 0x0400129F RID: 4767
	[FieldOffset(Offset = "0x25C")]
	[Token(Token = "0x400129F")]
	public int targetColumn;

	// Token: 0x040012A0 RID: 4768
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x40012A0")]
	public int ballType;

	// Token: 0x040012A1 RID: 4769
	[FieldOffset(Offset = "0x264")]
	[Token(Token = "0x40012A1")]
	public int summonCount;

	// Token: 0x040012A2 RID: 4770
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x40012A2")]
	public int spawnCount = (int)((ulong)8L);

	// Token: 0x040012A3 RID: 4771
	[FieldOffset(Offset = "0x26C")]
	[Token(Token = "0x40012A3")]
	public int summonBallCount;

	// Token: 0x040012A4 RID: 4772
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x40012A4")]
	public float summonTime = 5f;

	// Token: 0x040012A5 RID: 4773
	[FieldOffset(Offset = "0x274")]
	[Token(Token = "0x40012A5")]
	public float ballCountDown = 3f;

	// Token: 0x040012A6 RID: 4774
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40012A6")]
	public bool ball;

	// Token: 0x040012A7 RID: 4775
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40012A7")]
	public Animator animDriver;

	// Token: 0x040012A8 RID: 4776
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x40012A8")]
	public Animator animRV;

	// Token: 0x040012A9 RID: 4777
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x40012A9")]
	public Transform ballPosition;

	// Token: 0x040012AA RID: 4778
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x40012AA")]
	public Transform spawnPosition;

	// Token: 0x040012AB RID: 4779
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x40012AB")]
	public SpriteRenderer eye;

	// Token: 0x040012AC RID: 4780
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x40012AC")]
	public ZombieBoss.BossStatus bossStatus;

	// Token: 0x040012AD RID: 4781
	[FieldOffset(Offset = "0x2B0")]
	[Token(Token = "0x40012AD")]
	public GameObject head;

	// Token: 0x040012AE RID: 4782
	[FieldOffset(Offset = "0x2B8")]
	[Token(Token = "0x40012AE")]
	public GameObject thumb;

	// Token: 0x040012AF RID: 4783
	[FieldOffset(Offset = "0x2C0")]
	[Token(Token = "0x40012AF")]
	public GameObject jaw;

	// Token: 0x040012B0 RID: 4784
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x40012B0")]
	public GameObject hand;

	// Token: 0x040012B1 RID: 4785
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x40012B1")]
	public GameObject foot_inner;

	// Token: 0x040012B2 RID: 4786
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x40012B2")]
	public GameObject foot_outter;

	// Token: 0x040012B3 RID: 4787
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x40012B3")]
	public GameObject eyes;

	// Token: 0x02000728 RID: 1832
	[Token(Token = "0x2000728")]
	public enum BossStatus
	{
		// Token: 0x040012B5 RID: 4789
		[Token(Token = "0x40012B5")]
		enter,
		// Token: 0x040012B6 RID: 4790
		[Token(Token = "0x40012B6")]
		idle,
		// Token: 0x040012B7 RID: 4791
		[Token(Token = "0x40012B7")]
		spawn,
		// Token: 0x040012B8 RID: 4792
		[Token(Token = "0x40012B8")]
		foot,
		// Token: 0x040012B9 RID: 4793
		[Token(Token = "0x40012B9")]
		rv,
		// Token: 0x040012BA RID: 4794
		[Token(Token = "0x40012BA")]
		head_enter,
		// Token: 0x040012BB RID: 4795
		[Token(Token = "0x40012BB")]
		head_idle,
		// Token: 0x040012BC RID: 4796
		[Token(Token = "0x40012BC")]
		head_leave,
		// Token: 0x040012BD RID: 4797
		[Token(Token = "0x40012BD")]
		bungi
	}
}
