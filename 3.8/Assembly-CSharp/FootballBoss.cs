using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000668 RID: 1640
[Token(Token = "0x2000668")]
public class FootballBoss : Zombie
{
	// Token: 0x06001F39 RID: 7993 RVA: 0x000A6330 File Offset: 0x000A4530
	[Token(Token = "0x6001F39")]
	[Address(RVA = "0x547500", Offset = "0x545B00", VA = "0x180547500", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("enter");
		this.theStatus = (ZombieStatus)((ulong)43L);
		this.theZombieRow = (int)((ulong)1L);
		int rowNum = this.board.rowNum;
		int rowNum2 = this.board.rowNum;
		this.theZombieRow = rowNum2;
		int theZombieRow = this.theZombieRow;
		SortingGroup sortingGroup = this.sortingGroup;
		string text = string.Format("zombie{0}", theZombieRow);
		sortingGroup.sortingLayerName = text;
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(this.board.columnNum);
		Mouse instance = Mouse.Instance;
		int theZombieRow2 = this.theZombieRow;
		float landY = instance.GetLandY(boxXFromColumn, theZombieRow2);
		Collider2D col = this.col;
		int num = 0;
		col.enabled = num != 0;
	}

	// Token: 0x06001F3A RID: 7994 RVA: 0x000A63F4 File Offset: 0x000A45F4
	[Token(Token = "0x6001F3A")]
	[Address(RVA = "0x546F90", Offset = "0x545590", VA = "0x180546F90", Slot = "22")]
	protected override void OnFixedUpdate()
	{
		base.OnFixedUpdate();
		int column = base.Column;
		if (base.Alive)
		{
			base.ChangeStatus((ZombieStatus)((uint)43));
			this.anim.SetTrigger("jump");
			Collider2D col = this.col;
			int num = 0;
			col.enabled = num != 0;
			return;
		}
	}

	// Token: 0x06001F3B RID: 7995 RVA: 0x000A6448 File Offset: 0x000A4648
	[Token(Token = "0x6001F3B")]
	[Address(RVA = "0x546900", Offset = "0x544F00", VA = "0x180546900")]
	private void AnimJump()
	{
		List<int> list = new List();
		Board board = this.board;
		int num = 0;
		int num2 = 0;
		if (num < board.rowNum)
		{
			int size = list._size;
			BoxType[] roadType = board.roadType;
			list._size = board;
			Board board2 = this.board;
			num2++;
		}
		int size2 = list._size;
		int num3 = size2 - 1;
		if (size2 > 0)
		{
			BoxType[] roadType2 = this.board.roadType;
			list.RemoveAt(num3);
		}
		Mouse instance = Mouse.Instance;
		Board board3 = this.board;
		int num4 = 0;
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(global::UnityEngine.Random.Range(-4, num4));
		int random = ListExtensions.GetRandom<int>(list);
		ulong num5;
		bool flag = instance.MoveZombie(this, boxXFromColumn, random, num5 != 0UL);
		this.anim.Play("enter");
	}

	// Token: 0x06001F3C RID: 7996 RVA: 0x000A6514 File Offset: 0x000A4714
	[Token(Token = "0x6001F3C")]
	[Address(RVA = "0x546E60", Offset = "0x545460", VA = "0x180546E60")]
	private void FlagUpdate(Transform flag, int row)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001F3D RID: 7997 RVA: 0x000A6538 File Offset: 0x000A4738
	[Token(Token = "0x6001F3D")]
	[Address(RVA = "0x546BB0", Offset = "0x5451B0", VA = "0x180546BB0")]
	private void AnimLand()
	{
		this.col.enabled = true;
	}

	// Token: 0x06001F3E RID: 7998 RVA: 0x000A6558 File Offset: 0x000A4758
	[Token(Token = "0x6001F3E")]
	[Address(RVA = "0x5466C0", Offset = "0x544CC0", VA = "0x1805466C0")]
	private void AnimFlagLand()
	{
		Transform transform = this.flag1;
		Transform parent = transform.transform.parent;
		Transform transform2 = global::UnityEngine.Object.Instantiate<Transform>(transform, parent);
		Transform transform3 = this.flag2;
		Transform parent2 = transform3.transform.parent;
		Transform transform4 = global::UnityEngine.Object.Instantiate<Transform>(transform3, parent2);
		Transform transform5 = this.flag3;
		Transform parent3 = transform5.transform.parent;
		Transform transform6 = global::UnityEngine.Object.Instantiate<Transform>(transform5, parent3);
		Transform transform7 = transform2.transform;
		Transform transform8 = this.board.transform;
		transform7.parentInternal = transform8;
		Transform transform9 = transform4.transform;
		Transform transform10 = this.board.transform;
		transform9.parentInternal = transform10;
		Transform transform11 = transform6.transform;
		Transform transform12 = this.board.transform;
		transform11.parentInternal = transform12;
		int theZombieRow = this.theZombieRow;
		int num = theZombieRow - 1;
		this.FlagUpdate(transform2, num);
		num = theZombieRow;
		this.FlagUpdate(transform4, num);
		int num2 = theZombieRow + 1;
		this.FlagUpdate(transform6, num2);
	}

	// Token: 0x06001F3F RID: 7999 RVA: 0x000A6658 File Offset: 0x000A4858
	[Token(Token = "0x6001F3F")]
	[Address(RVA = "0x546DA0", Offset = "0x5453A0", VA = "0x180546DA0", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		int num = 0;
		this.KnockBack((float)reason, (Zombie.KnockBackReason)num);
		global::UnityEngine.Object.Destroy(this.flag1.gameObject);
		global::UnityEngine.Object.Destroy(this.flag2.gameObject);
		global::UnityEngine.Object.Destroy(this.flag3.gameObject);
	}

	// Token: 0x06001F40 RID: 8000 RVA: 0x000A66A8 File Offset: 0x000A48A8
	[Token(Token = "0x6001F40")]
	[Address(RVA = "0x547040", Offset = "0x545640", VA = "0x180547040")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num;
		for (;;)
		{
			num = 0;
			if (collision.TryGetComponent<Plant>(num))
			{
				break;
			}
			if (collision.TryGetComponent<Zombie>(num))
			{
				goto Block_1;
			}
		}
		int theZombieRow = this.theZombieRow;
		CreateZombie instance = CreateZombie.Instance;
		ParticleManager instance2 = ParticleManager.Instance;
		Vector3 vector;
		float z = vector.z;
		int num2 = 0;
		ulong num3;
		Particle particle = instance2.SetParticle((ParticleType)((uint)11), num, num, num3 != 0UL, (float)num2);
		return;
		Block_1:
		int theZombieRow2 = this.theZombieRow;
		throw new NullReferenceException();
	}

	// Token: 0x06001F41 RID: 8001 RVA: 0x000A6710 File Offset: 0x000A4910
	[Token(Token = "0x6001F41")]
	[Address(RVA = "0x547310", Offset = "0x545910", VA = "0x180547310")]
	private void SetZombie(int row, Transform flag)
	{
		int num = 0;
		ParticleManager instance = ParticleManager.Instance;
		Vector3 vector;
		float z = vector.z;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)11), num, row, num3 != 0UL, (float)num2);
		List<ZombieType> list = this.zombies;
		CreateZombie instance2 = CreateZombie.Instance;
		ZombieType random = ListExtensions.GetRandom<ZombieType>(list);
	}

	// Token: 0x06001F42 RID: 8002 RVA: 0x000A6760 File Offset: 0x000A4960
	[Token(Token = "0x6001F42")]
	[Address(RVA = "0x546BE0", Offset = "0x5451E0", VA = "0x180546BE0", Slot = "29")]
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

	// Token: 0x06001F43 RID: 8003 RVA: 0x000A679C File Offset: 0x000A499C
	[Token(Token = "0x6001F43")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06001F44 RID: 8004 RVA: 0x000A67AC File Offset: 0x000A49AC
	[Token(Token = "0x6001F44")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06001F45 RID: 8005 RVA: 0x000A67BC File Offset: 0x000A49BC
	[Token(Token = "0x6001F45")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06001F46 RID: 8006 RVA: 0x000A67CC File Offset: 0x000A49CC
	[Token(Token = "0x6001F46")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06001F47 RID: 8007 RVA: 0x000A67DC File Offset: 0x000A49DC
	[Token(Token = "0x6001F47")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "59")]
	public override void Garliced(bool playSound = false, bool certainRow = false)
	{
	}

	// Token: 0x06001F48 RID: 8008 RVA: 0x000A67EC File Offset: 0x000A49EC
	[Token(Token = "0x6001F48")]
	[Address(RVA = "0x546D50", Offset = "0x545350", VA = "0x180546D50", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06001F49 RID: 8009 RVA: 0x000A67FC File Offset: 0x000A49FC
	[Token(Token = "0x6001F49")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "58")]
	public override void EatGarlic(Plant plant, float time = 1f, bool withSound = true)
	{
	}

	// Token: 0x06001F4A RID: 8010 RVA: 0x000A680C File Offset: 0x000A4A0C
	[Token(Token = "0x6001F4A")]
	[Address(RVA = "0x546F50", Offset = "0x545550", VA = "0x180546F50", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		int num;
		if (num > 5000)
		{
		}
		return num;
	}

	// Token: 0x06001F4B RID: 8011 RVA: 0x000A6828 File Offset: 0x000A4A28
	[Token(Token = "0x6001F4B")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06001F4C RID: 8012 RVA: 0x000A6838 File Offset: 0x000A4A38
	[Token(Token = "0x6001F4C")]
	[Address(RVA = "0x5476D0", Offset = "0x545CD0", VA = "0x1805476D0")]
	public FootballBoss()
	{
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
		this.zombies = list;
		base..ctor();
	}

	// Token: 0x04001078 RID: 4216
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001078")]
	public Transform flag1;

	// Token: 0x04001079 RID: 4217
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4001079")]
	public Transform flag2;

	// Token: 0x0400107A RID: 4218
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x400107A")]
	public Transform flag3;

	// Token: 0x0400107B RID: 4219
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x400107B")]
	public List<ZombieType> zombies;
}
