using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020000B0 RID: 176
[Token(Token = "0x20000B0")]
public class ContestedFlag : MonoBehaviour
{
	// Token: 0x0600031B RID: 795 RVA: 0x0000D49C File Offset: 0x0000B69C
	[Token(Token = "0x600031B")]
	[Address(RVA = "0x40C3A0", Offset = "0x40A9A0", VA = "0x18040C3A0")]
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
					goto IL_00AD;
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
		if (zombie.takeDmgMultiplier == 0f)
		{
		}
		CreateZombie instance2 = CreateZombie.Instance;
		ParticleManager instance3 = ParticleManager.Instance;
		if (Time.deltaTime > 60f)
		{
		}
		return;
		IL_00AD:
		throw new NullReferenceException();
	}

	// Token: 0x0600031C RID: 796 RVA: 0x0000D55C File Offset: 0x0000B75C
	[Token(Token = "0x600031C")]
	[Address(RVA = "0x40C1E0", Offset = "0x40A7E0", VA = "0x18040C1E0")]
	private ZombieType GetZombieType()
	{
		if (this.level <= 6)
		{
		}
		return ZombieType.NormalZombie;
	}

	// Token: 0x0600031D RID: 797 RVA: 0x0000D580 File Offset: 0x0000B780
	[Token(Token = "0x600031D")]
	[Address(RVA = "0x40BC30", Offset = "0x40A230", VA = "0x18040BC30")]
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

	// Token: 0x0600031E RID: 798 RVA: 0x0000D680 File Offset: 0x0000B880
	[Token(Token = "0x600031E")]
	[Address(RVA = "0x40C240", Offset = "0x40A840", VA = "0x18040C240")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int num = this.theRow;
			List<Zombie> list = this.zombies;
		}
	}

	// Token: 0x0600031F RID: 799 RVA: 0x0000D6A8 File Offset: 0x0000B8A8
	[Token(Token = "0x600031F")]
	[Address(RVA = "0x40C2F0", Offset = "0x40A8F0", VA = "0x18040C2F0")]
	private void OnTriggerExit2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int num = this.theRow;
			List<Zombie> list = this.zombies;
		}
	}

	// Token: 0x06000320 RID: 800 RVA: 0x0000D6D0 File Offset: 0x0000B8D0
	[Token(Token = "0x6000320")]
	[Address(RVA = "0x40BBD0", Offset = "0x40A1D0", VA = "0x18040BBD0")]
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

	// Token: 0x06000321 RID: 801 RVA: 0x0000D720 File Offset: 0x0000B920
	[Token(Token = "0x6000321")]
	[Address(RVA = "0x40C910", Offset = "0x40AF10", VA = "0x18040C910")]
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

	// Token: 0x06000322 RID: 802 RVA: 0x0000D7BC File Offset: 0x0000B9BC
	[Token(Token = "0x6000322")]
	[Address(RVA = "0x40CBA0", Offset = "0x40B1A0", VA = "0x18040CBA0")]
	public ContestedFlag()
	{
		List<Zombie> list = new List();
		this.zombies = list;
		List<Zombie> list2 = new List();
		this.hypnoZombies = list2;
		this.summonTimer = 60f;
		base..ctor();
	}

	// Token: 0x04000158 RID: 344
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000158")]
	public GameObject plantFlag;

	// Token: 0x04000159 RID: 345
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000159")]
	public GameObject zombieFlag;

	// Token: 0x0400015A RID: 346
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400015A")]
	public Board board;

	// Token: 0x0400015B RID: 347
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400015B")]
	public Team team;

	// Token: 0x0400015C RID: 348
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400015C")]
	public int theColumn;

	// Token: 0x0400015D RID: 349
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400015D")]
	public int theRow;

	// Token: 0x0400015E RID: 350
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400015E")]
	public List<Zombie> zombies;

	// Token: 0x0400015F RID: 351
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400015F")]
	public List<Zombie> hypnoZombies;

	// Token: 0x04000160 RID: 352
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000160")]
	private float summonTimer;

	// Token: 0x04000161 RID: 353
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000161")]
	private int level;

	// Token: 0x04000162 RID: 354
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000162")]
	private float levelUpTimer;
}
