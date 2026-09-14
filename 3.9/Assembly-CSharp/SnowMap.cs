using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000273 RID: 627
[Token(Token = "0x2000273")]
public class SnowMap : MonoBehaviour
{
	// Token: 0x06000B41 RID: 2881 RVA: 0x000400D0 File Offset: 0x0003E2D0
	[Token(Token = "0x6000B41")]
	[Address(RVA = "0x938D40", Offset = "0x937340", VA = "0x180938D40")]
	private void Awake()
	{
		SnowMap.Instance = this;
	}

	// Token: 0x06000B42 RID: 2882 RVA: 0x000400E4 File Offset: 0x0003E2E4
	[Token(Token = "0x6000B42")]
	[Address(RVA = "0x939650", Offset = "0x937C50", VA = "0x180939650")]
	private void Start()
	{
		Board instance = Board.Instance;
		this.board = instance;
		ParticleSystem.MainModule main = this.particle.main;
		this.emission = main;
		throw new NullReferenceException();
	}

	// Token: 0x06000B43 RID: 2883 RVA: 0x00040118 File Offset: 0x0003E318
	[Token(Token = "0x6000B43")]
	[Address(RVA = "0x9396C0", Offset = "0x937CC0", VA = "0x1809396C0")]
	private void Update()
	{
		if (this.bigSnow)
		{
			float num = this.timer;
			float deltaTime = Time.deltaTime;
			int num2 = 0;
			this.timer = num;
			if (num2 > (int)num)
			{
				this.timer = 1f;
				ParticleSystem.MinMaxCurve minMaxCurve;
				AnimationCurve curveMax = minMaxCurve.m_CurveMax;
				ParticleSystem.MinMaxCurve minMaxCurve2;
				AnimationCurve curveMax2 = minMaxCurve2.m_CurveMax;
				ParticleSystem.MinMaxCurve minMaxCurve3;
				AnimationCurve curveMax3 = minMaxCurve3.m_CurveMax;
				ParticleSystem.MinMaxCurve minMaxCurve4;
				AnimationCurve curveMax4 = minMaxCurve4.m_CurveMax;
				this.bigSnow = false;
			}
		}
	}

	// Token: 0x06000B44 RID: 2884 RVA: 0x00040188 File Offset: 0x0003E388
	[Token(Token = "0x6000B44")]
	[Address(RVA = "0x939210", Offset = "0x937810", VA = "0x180939210")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000B45 RID: 2885 RVA: 0x00040198 File Offset: 0x0003E398
	[Token(Token = "0x6000B45")]
	[Address(RVA = "0x939190", Offset = "0x937790", VA = "0x180939190")]
	public void HugeWave()
	{
		SnowMap.<BigSnow>d__13 <BigSnow>d__;
		<BigSnow>d__.System.IDisposable.Dispose();
		<BigSnow>d__.<>1__state = (int)((ulong)0L);
		<BigSnow>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<BigSnow>d__);
	}

	// Token: 0x06000B46 RID: 2886 RVA: 0x000401C4 File Offset: 0x0003E3C4
	[Token(Token = "0x6000B46")]
	[Address(RVA = "0x939250", Offset = "0x937850", VA = "0x180939250")]
	public void QuickSnow()
	{
		SnowMap.<BigSnow>d__13 <BigSnow>d__;
		<BigSnow>d__.System.IDisposable.Dispose();
		<BigSnow>d__.<>1__state = (int)((ulong)0L);
		<BigSnow>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<BigSnow>d__);
		this.timer = 1f;
		ParticleSystem.MinMaxCurve minMaxCurve;
		AnimationCurve curveMax = minMaxCurve.m_CurveMax;
		this.bigSnow = true;
		this.Freeze();
	}

	// Token: 0x06000B47 RID: 2887 RVA: 0x00040210 File Offset: 0x0003E410
	[Token(Token = "0x6000B47")]
	[Address(RVA = "0x938DA0", Offset = "0x9373A0", VA = "0x180938DA0")]
	private IEnumerator BigSnow()
	{
		SnowMap.<BigSnow>d__13 <BigSnow>d__;
		<BigSnow>d__.System.IDisposable.Dispose();
		<BigSnow>d__.<>1__state = (int)((ulong)0L);
		<BigSnow>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000B48 RID: 2888 RVA: 0x00040234 File Offset: 0x0003E434
	[Token(Token = "0x6000B48")]
	[Address(RVA = "0x939350", Offset = "0x937950", VA = "0x180939350")]
	private void Remove(HashSet<Vector2Int> boxes)
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Plant> plantHead = this.board.boardEntity.plantHead;
			Predicate<Plant> <>9__14_ = SnowMap.<>c.<>9__14_0;
			if (<>9__14_ == 0)
			{
				Predicate<Plant> predicate;
				SnowMap.<>c.<>9__14_0 = predicate;
			}
			List<Plant> list = plantHead.FindAll(<>9__14_);
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
	}

	// Token: 0x06000B49 RID: 2889 RVA: 0x00040298 File Offset: 0x0003E498
	[Token(Token = "0x6000B49")]
	[Address(RVA = "0x938E10", Offset = "0x937410", VA = "0x180938E10")]
	private void Freeze()
	{
		int num;
		do
		{
			num = 0;
			Board board = this.board;
			if (num >= board.rowNum)
			{
				return;
			}
			List<Plant> plantsByRow = Lawnf.GetPlantsByRow(board, num);
			Func<Plant, int> <>9__15_ = SnowMap.<>c.<>9__15_0;
			if (<>9__15_ == 0)
			{
				Func<Plant, int> func;
				SnowMap.<>c.<>9__15_0 = func;
			}
			IOrderedEnumerable<Plant> orderedEnumerable = Enumerable.OrderByDescending<Plant, int>(plantsByRow, <>9__15_);
			if (orderedEnumerable != 0)
			{
				int num2 = 0;
				if ((orderedEnumerable > (ulong)1222L && (num2 == -33 || orderedEnumerable == (ulong)1403L)) || orderedEnumerable == (ulong)37L || orderedEnumerable == (ulong)947L || orderedEnumerable <= (ulong)1L)
				{
				}
				int num3 = 0;
				FreezedPlant freezedPlant;
				if (!(freezedPlant != num3))
				{
					continue;
				}
			}
			if ("{il2cpp array field local11->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
		num++;
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x00040354 File Offset: 0x0003E554
	[Token(Token = "0x6000B4A")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public SnowMap()
	{
	}

	// Token: 0x0400074A RID: 1866
	[Token(Token = "0x400074A")]
	public static SnowMap Instance;

	// Token: 0x0400074B RID: 1867
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400074B")]
	public ParticleSystem particle;

	// Token: 0x0400074C RID: 1868
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400074C")]
	public bool bigSnow;

	// Token: 0x0400074D RID: 1869
	[Token(Token = "0x400074D")]
	public static bool baofengxue;

	// Token: 0x0400074E RID: 1870
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400074E")]
	private float timer;

	// Token: 0x0400074F RID: 1871
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400074F")]
	private Board board;

	// Token: 0x04000750 RID: 1872
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000750")]
	private ParticleSystem.EmissionModule emission;
}
