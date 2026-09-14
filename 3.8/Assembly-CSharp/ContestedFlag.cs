using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020000AB RID: 171
[Token(Token = "0x20000AB")]
public class ContestedFlag : MonoBehaviour
{
	// Token: 0x06000300 RID: 768 RVA: 0x0000D100 File Offset: 0x0000B300
	[Token(Token = "0x6000300")]
	[Address(RVA = "0x3BF5F0", Offset = "0x3BDBF0", VA = "0x1803BF5F0")]
	public void OnUpdate()
	{
		ulong num5;
		do
		{
			int num = 0;
			if (this.team == (Team)num)
			{
				List<Zombie> zombieArray = this.board.zombieArray;
				bool flag;
				if (flag)
				{
					Team team = this.team;
					int num2 = this.theRow;
				}
				ulong num3;
				if (num3 != (ulong)0L)
				{
					goto IL_00A6;
				}
			}
			List<Zombie> zombieArray2 = this.board.zombieArray;
			bool flag2;
			if (flag2)
			{
				Team team2 = this.team;
				int num4 = this.theRow;
			}
		}
		while (num5 != (ulong)0L);
		float deltaTime = Time.deltaTime;
		CreateZombie instance = CreateZombie.Instance;
		Zombie zombie;
		if (zombie.read == 0)
		{
		}
		CreateZombie instance2 = CreateZombie.Instance;
		ParticleManager instance3 = ParticleManager.Instance;
		if (Time.deltaTime > 60f)
		{
		}
		return;
		IL_00A6:
		throw new NullReferenceException();
	}

	// Token: 0x06000301 RID: 769 RVA: 0x0000D1BC File Offset: 0x0000B3BC
	[Token(Token = "0x6000301")]
	[Address(RVA = "0x3BF430", Offset = "0x3BDA30", VA = "0x1803BF430")]
	private ZombieType GetZombieType()
	{
		if (this.level <= 6)
		{
		}
		return ZombieType.NormalZombie;
	}

	// Token: 0x06000302 RID: 770 RVA: 0x0000D1E0 File Offset: 0x0000B3E0
	[Token(Token = "0x6000302")]
	[Address(RVA = "0x3BEE80", Offset = "0x3BD480", VA = "0x1803BEE80")]
	private void FixedUpdate()
	{
		int num6;
		do
		{
			int num = 0;
			List<Zombie> list = this.zombies;
			Predicate<Zombie> <>9__13_ = ContestedFlag.<>c.<>9__13_0;
			if (<>9__13_ == 0)
			{
				Predicate<Zombie> predicate;
				ContestedFlag.<>c.<>9__13_0 = predicate;
			}
			int num2 = list.RemoveAll(<>9__13_);
			List<Zombie> list2 = this.hypnoZombies;
			Predicate<Zombie> predicate2;
			if (ContestedFlag.<>c.<>9__13_1 == 0)
			{
				ContestedFlag.<>c.<>9__13_1 = predicate2;
			}
			int num3 = list2.RemoveAll(predicate2);
			List<Zombie> list3 = new List(this.zombies);
			int num4 = 0;
			bool flag;
			if (flag)
			{
				int num5 = this.theRow;
				bool flag2 = this.zombies.Remove(num);
				List<Zombie> list4 = this.hypnoZombies;
				bool flag3 = this.zombies.Remove(num);
			}
			if (num4 != 0)
			{
				goto IL_00DB;
			}
			num6 = 0;
			bool flag4;
			if (flag4)
			{
			}
		}
		while (num6 != 0);
		List<Zombie> list5 = this.hypnoZombies;
		CancellationTokenSource cancellationTokenSource = this.m_CancellationTokenSource;
		return;
		IL_00DB:
		throw new NullReferenceException();
	}

	// Token: 0x06000303 RID: 771 RVA: 0x0000D2E0 File Offset: 0x0000B4E0
	[Token(Token = "0x6000303")]
	[Address(RVA = "0x3BF490", Offset = "0x3BDA90", VA = "0x1803BF490")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int num = this.theRow;
			List<Zombie> list = this.zombies;
		}
	}

	// Token: 0x06000304 RID: 772 RVA: 0x0000D308 File Offset: 0x0000B508
	[Token(Token = "0x6000304")]
	[Address(RVA = "0x3BF540", Offset = "0x3BDB40", VA = "0x1803BF540")]
	private void OnTriggerExit2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int num = this.theRow;
			List<Zombie> list = this.zombies;
		}
	}

	// Token: 0x06000305 RID: 773 RVA: 0x0000D330 File Offset: 0x0000B530
	[Token(Token = "0x6000305")]
	[Address(RVA = "0x3BEE20", Offset = "0x3BD420", VA = "0x1803BEE20")]
	private void ChangeTeam(Team team)
	{
		this.team = team;
		GameObject gameObject = this.plantFlag;
		bool flag = team == Team.Player;
		gameObject.SetActive(flag);
		GameObject gameObject2 = this.zombieFlag;
		bool flag2 = team == Team.AI;
		gameObject2.SetActive(flag2);
		int num = 0;
		this.level = num;
	}

	// Token: 0x06000306 RID: 774 RVA: 0x0000D380 File Offset: 0x0000B580
	[Token(Token = "0x6000306")]
	[Address(RVA = "0x3BFB60", Offset = "0x3BE160", VA = "0x1803BFB60")]
	public static ContestedFlag SetFlag(Board board, int theColumn, int theRow)
	{
		float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(theColumn);
		float landY = Mouse.Instance.GetLandY(boxXFromColumn, theRow);
		GameObject gameObject = Resources.Load<GameObject>("Items/ContestedFlag");
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = board.transform;
		GameObject gameObject2;
		ContestedFlag component = gameObject2.GetComponent<ContestedFlag>();
		component.theColumn = theColumn;
		component.theRow = theRow;
		component.board = board;
		component.team = (Team)((ulong)1L);
		SortingGroup component2 = component.GetComponent<SortingGroup>();
		string text = string.Format("plant{0}", component2);
		component2.sortingLayerName = text;
		return component;
	}

	// Token: 0x06000307 RID: 775 RVA: 0x0000D41C File Offset: 0x0000B61C
	[Token(Token = "0x6000307")]
	[Address(RVA = "0x3BFDF0", Offset = "0x3BE3F0", VA = "0x1803BFDF0")]
	public ContestedFlag()
	{
		List<Zombie> list = new List();
		this.zombies = list;
		List<Zombie> list2 = new List();
		this.hypnoZombies = list2;
		this.summonTimer = 60f;
		base..ctor();
	}

	// Token: 0x0400014B RID: 331
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400014B")]
	public GameObject plantFlag;

	// Token: 0x0400014C RID: 332
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400014C")]
	public GameObject zombieFlag;

	// Token: 0x0400014D RID: 333
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400014D")]
	public Board board;

	// Token: 0x0400014E RID: 334
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400014E")]
	public Team team;

	// Token: 0x0400014F RID: 335
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400014F")]
	public int theColumn;

	// Token: 0x04000150 RID: 336
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000150")]
	public int theRow;

	// Token: 0x04000151 RID: 337
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000151")]
	public List<Zombie> zombies;

	// Token: 0x04000152 RID: 338
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000152")]
	public List<Zombie> hypnoZombies;

	// Token: 0x04000153 RID: 339
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000153")]
	private float summonTimer;

	// Token: 0x04000154 RID: 340
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000154")]
	private int level;

	// Token: 0x04000155 RID: 341
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000155")]
	private float levelUpTimer;
}
