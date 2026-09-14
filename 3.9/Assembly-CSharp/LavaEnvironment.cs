using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000263 RID: 611
[Token(Token = "0x2000263")]
public class LavaEnvironment : IBoardEnvironment
{
	// Token: 0x06000AFA RID: 2810 RVA: 0x0003EA10 File Offset: 0x0003CC10
	[Token(Token = "0x6000AFA")]
	[Address(RVA = "0x9342B0", Offset = "0x9328B0", VA = "0x1809342B0")]
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

	// Token: 0x06000AFB RID: 2811 RVA: 0x0003EB1C File Offset: 0x0003CD1C
	[Token(Token = "0x6000AFB")]
	[Address(RVA = "0x9341D0", Offset = "0x9327D0", VA = "0x1809341D0", Slot = "4")]
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

	// Token: 0x06000AFC RID: 2812 RVA: 0x0003EB90 File Offset: 0x0003CD90
	[Token(Token = "0x6000AFC")]
	[Address(RVA = "0x934050", Offset = "0x932650", VA = "0x180934050")]
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

	// Token: 0x06000AFD RID: 2813 RVA: 0x0003EBFC File Offset: 0x0003CDFC
	[Token(Token = "0x6000AFD")]
	[Address(RVA = "0x934120", Offset = "0x932720", VA = "0x180934120")]
	private IEnumerator LavaExplode()
	{
		LavaEnvironment.<LavaExplode>d__13 <LavaExplode>d__;
		<LavaExplode>d__.System.IDisposable.Dispose();
		<LavaExplode>d__.<>1__state = (int)((ulong)0L);
		<LavaExplode>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000AFE RID: 2814 RVA: 0x0003EC20 File Offset: 0x0003CE20
	[Token(Token = "0x6000AFE")]
	[Address(RVA = "0x933B10", Offset = "0x932110", VA = "0x180933B10")]
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

	// Token: 0x06000AFF RID: 2815 RVA: 0x0003ECBC File Offset: 0x0003CEBC
	[Token(Token = "0x6000AFF")]
	[Address(RVA = "0x933AE0", Offset = "0x9320E0", VA = "0x180933AE0")]
	private bool CheckPlant(Plant plant)
	{
		if (plant.plantTag != (ulong)0L)
		{
		}
		bool flag;
		return flag;
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x0003ECE0 File Offset: 0x0003CEE0
	[Token(Token = "0x6000B00")]
	[Address(RVA = "0x4AF670", Offset = "0x4ADC70", VA = "0x1804AF670")]
	private bool CheckZombie(Zombie zombie)
	{
		return zombie.theStatus != ZombieStatus.Flying;
	}

	// Token: 0x06000B01 RID: 2817 RVA: 0x0003ED00 File Offset: 0x0003CF00
	[Token(Token = "0x6000B01")]
	[Address(RVA = "0x934190", Offset = "0x932790", VA = "0x180934190", Slot = "5")]
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

	// Token: 0x06000B02 RID: 2818 RVA: 0x0003ED40 File Offset: 0x0003CF40
	[Token(Token = "0x6000B02")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "6")]
	public void OnFire(int row)
	{
	}

	// Token: 0x040006FB RID: 1787
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006FB")]
	private float lavaTimer;

	// Token: 0x040006FC RID: 1788
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40006FC")]
	private float explodeTimer;

	// Token: 0x040006FD RID: 1789
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006FD")]
	private readonly Board board;

	// Token: 0x040006FE RID: 1790
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006FE")]
	private readonly List<BoardGrid> lavaGrid;

	// Token: 0x040006FF RID: 1791
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006FF")]
	private readonly HashSet<int> lavaRows;

	// Token: 0x04000700 RID: 1792
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000700")]
	private BoardGrid explodeGrid;

	// Token: 0x04000701 RID: 1793
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000701")]
	private LayerMask zombieLayer;

	// Token: 0x04000702 RID: 1794
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000702")]
	private Coroutine explodeCoroutine;

	// Token: 0x04000703 RID: 1795
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000703")]
	private readonly int normalDamage;

	// Token: 0x04000704 RID: 1796
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000704")]
	private readonly int explodeDamage;
}
