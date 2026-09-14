using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200025D RID: 605
[Token(Token = "0x200025D")]
public class LavaEnvironment : IBoardEnvironment
{
	// Token: 0x06000ADE RID: 2782 RVA: 0x0003EB64 File Offset: 0x0003CD64
	[Token(Token = "0x6000ADE")]
	[Address(RVA = "0x8A42D0", Offset = "0x8A28D0", VA = "0x1808A42D0")]
	public LavaEnvironment(Board board)
	{
		int num;
		do
		{
			num = 0;
			this.explodeTimer = 60f;
			List<BoardGrid> list = new List();
			this.lavaGrid = list;
			HashSet<int> hashSet = new HashSet();
			this.lavaRows = hashSet;
			this.normalDamage = (int)((ulong)30L);
			this.explodeDamage = (int)((ulong)1800L);
			int num2 = 0;
			this.OnFire(num2);
			this.board = board;
			if (board.gridSystem.GetEnumerator() != 0)
			{
				if (num >= typeof(IEnumerator).TypeHandle)
				{
					goto IL_0074;
				}
				num += num;
				if (num != typeof(IEnumerator).TypeHandle)
				{
					num++;
					goto IL_0074;
				}
				IL_0094:
				HashSet<int> hashSet2;
				hashSet2 += hashSet2;
				goto IL_009B;
				IL_0074:
				int columnNum = board.columnNum;
				int rowNum = board.rowNum;
				List<BoardGrid> list2 = this.lavaGrid;
				hashSet2 = this.lavaRows;
				goto IL_0094;
			}
			IL_009B:
			if ("{il2cpp array field local9->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
		int mask = LayerMask.GetMask(new string[] { "Zombie", "Plant" });
	}

	// Token: 0x06000ADF RID: 2783 RVA: 0x0003EC70 File Offset: 0x0003CE70
	[Token(Token = "0x6000ADF")]
	[Address(RVA = "0x8A41F0", Offset = "0x8A27F0", VA = "0x1808A41F0", Slot = "4")]
	public void OnUpdate()
	{
		this.DamageUpdate();
		float num = this.explodeTimer;
		float deltaTime = Time.deltaTime;
		this.explodeTimer = num;
		Board board = this.board;
		this.explodeTimer = 60f;
		LavaEnvironment.<LavaExplode>d__13 <LavaExplode>d__;
		<LavaExplode>d__.System.IDisposable.Dispose();
		<LavaExplode>d__.<>1__state = (int)((ulong)0L);
		<LavaExplode>d__.<>4__this = this;
		Coroutine coroutine = board.StartCoroutine(<LavaExplode>d__);
		this.explodeCoroutine = coroutine;
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x0003ECE4 File Offset: 0x0003CEE4
	[Token(Token = "0x6000AE0")]
	[Address(RVA = "0x8A4070", Offset = "0x8A2670", VA = "0x1808A4070")]
	private void ExplodeUpdate()
	{
		float num = this.explodeTimer;
		float deltaTime = Time.deltaTime;
		this.explodeTimer = num;
		Board board = this.board;
		this.explodeTimer = 60f;
		LavaEnvironment.<LavaExplode>d__13 <LavaExplode>d__;
		<LavaExplode>d__.System.IDisposable.Dispose();
		<LavaExplode>d__.<>1__state = (int)((ulong)0L);
		<LavaExplode>d__.<>4__this = this;
		Coroutine coroutine = board.StartCoroutine(<LavaExplode>d__);
		this.explodeCoroutine = coroutine;
	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x0003ED50 File Offset: 0x0003CF50
	[Token(Token = "0x6000AE1")]
	[Address(RVA = "0x8A4140", Offset = "0x8A2740", VA = "0x1808A4140")]
	private IEnumerator LavaExplode()
	{
		LavaEnvironment.<LavaExplode>d__13 <LavaExplode>d__;
		<LavaExplode>d__.System.IDisposable.Dispose();
		<LavaExplode>d__.<>1__state = (int)((ulong)0L);
		<LavaExplode>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000AE2 RID: 2786 RVA: 0x0003ED74 File Offset: 0x0003CF74
	[Token(Token = "0x6000AE2")]
	[Address(RVA = "0x8A3B30", Offset = "0x8A2130", VA = "0x1808A3B30")]
	private void DamageUpdate()
	{
		int num4;
		do
		{
			int num = 0;
			float num2 = this.lavaTimer;
			float deltaTime = Time.deltaTime;
			this.lavaTimer = num2;
			this.lavaTimer = 1f;
			List<BoardGrid> list = this.lavaGrid;
			int num3 = 0;
			bool flag;
			if (flag)
			{
				bool flag2;
				if (flag2)
				{
				}
				if (num3 != 0)
				{
					goto IL_0076;
				}
			}
			if (num3 != 0)
			{
				goto IL_0082;
			}
			num4 = 0;
			bool flag3;
			if (flag3)
			{
				int num5 = 0;
				List<Zombie> zombiesByRow = Lawnf.GetZombiesByRow(num, num5 != 0);
				bool flag4;
				if (flag4)
				{
				}
				if (num4 != 0)
				{
					goto IL_0088;
				}
			}
		}
		while (num4 != 0);
		return;
		IL_0076:
		throw new NullReferenceException();
		IL_0082:
		throw new NullReferenceException();
		IL_0088:
		throw new NullReferenceException();
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x0003EE10 File Offset: 0x0003D010
	[Token(Token = "0x6000AE3")]
	[Address(RVA = "0x8A3B00", Offset = "0x8A2100", VA = "0x1808A3B00")]
	private bool CheckPlant(Plant plant)
	{
		if (plant.plantTag != (ulong)0L)
		{
		}
		bool flag;
		return flag;
	}

	// Token: 0x06000AE4 RID: 2788 RVA: 0x0003EE34 File Offset: 0x0003D034
	[Token(Token = "0x6000AE4")]
	[Address(RVA = "0x458030", Offset = "0x456630", VA = "0x180458030")]
	private bool CheckZombie(Zombie zombie)
	{
		return zombie.theStatus != ZombieStatus.Flying;
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x0003EE54 File Offset: 0x0003D054
	[Token(Token = "0x6000AE5")]
	[Address(RVA = "0x8A41B0", Offset = "0x8A27B0", VA = "0x1808A41B0", Slot = "5")]
	public void OnFreeze()
	{
		if (this.explodeCoroutine != (ulong)0L)
		{
			Board board = this.board;
			Coroutine coroutine = this.explodeCoroutine;
			board.StopCoroutine(coroutine);
		}
		this.explodeTimer = 60f;
	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x0003EE94 File Offset: 0x0003D094
	[Token(Token = "0x6000AE6")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "6")]
	public void OnFire(int row)
	{
	}

	// Token: 0x040006EF RID: 1775
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006EF")]
	private float lavaTimer;

	// Token: 0x040006F0 RID: 1776
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40006F0")]
	private float explodeTimer;

	// Token: 0x040006F1 RID: 1777
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006F1")]
	private readonly Board board;

	// Token: 0x040006F2 RID: 1778
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006F2")]
	private readonly List<BoardGrid> lavaGrid;

	// Token: 0x040006F3 RID: 1779
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006F3")]
	private readonly HashSet<int> lavaRows;

	// Token: 0x040006F4 RID: 1780
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006F4")]
	private BoardGrid explodeGrid;

	// Token: 0x040006F5 RID: 1781
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40006F5")]
	private LayerMask zombieLayer;

	// Token: 0x040006F6 RID: 1782
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40006F6")]
	private Coroutine explodeCoroutine;

	// Token: 0x040006F7 RID: 1783
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40006F7")]
	private readonly int normalDamage;

	// Token: 0x040006F8 RID: 1784
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40006F8")]
	private readonly int explodeDamage;
}
