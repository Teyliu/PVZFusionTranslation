using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200026D RID: 621
[Token(Token = "0x200026D")]
public class SnowMap : MonoBehaviour
{
	// Token: 0x06000B25 RID: 2853 RVA: 0x00040210 File Offset: 0x0003E410
	[Token(Token = "0x6000B25")]
	[Address(RVA = "0x8A8D20", Offset = "0x8A7320", VA = "0x1808A8D20")]
	private void Awake()
	{
		SnowMap.Instance = this;
	}

	// Token: 0x06000B26 RID: 2854 RVA: 0x00040224 File Offset: 0x0003E424
	[Token(Token = "0x6000B26")]
	[Address(RVA = "0x8A9A60", Offset = "0x8A8060", VA = "0x1808A9A60")]
	private void Start()
	{
		Board instance = Board.Instance;
		this.board = instance;
		ParticleSystem.MainModule main = this.particle.main;
		this.emission = main;
		throw new NullReferenceException();
	}

	// Token: 0x06000B27 RID: 2855 RVA: 0x00040258 File Offset: 0x0003E458
	[Token(Token = "0x6000B27")]
	[Address(RVA = "0x8A9AD0", Offset = "0x8A80D0", VA = "0x1808A9AD0")]
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

	// Token: 0x06000B28 RID: 2856 RVA: 0x000402C8 File Offset: 0x0003E4C8
	[Token(Token = "0x6000B28")]
	[Address(RVA = "0x8A9620", Offset = "0x8A7C20", VA = "0x1808A9620")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000B29 RID: 2857 RVA: 0x000402D8 File Offset: 0x0003E4D8
	[Token(Token = "0x6000B29")]
	[Address(RVA = "0x8A95A0", Offset = "0x8A7BA0", VA = "0x1808A95A0")]
	public void HugeWave()
	{
		SnowMap.<BigSnow>d__13 <BigSnow>d__;
		<BigSnow>d__.System.IDisposable.Dispose();
		<BigSnow>d__.<>1__state = (int)((ulong)0L);
		<BigSnow>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<BigSnow>d__);
	}

	// Token: 0x06000B2A RID: 2858 RVA: 0x00040304 File Offset: 0x0003E504
	[Token(Token = "0x6000B2A")]
	[Address(RVA = "0x8A9660", Offset = "0x8A7C60", VA = "0x1808A9660")]
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

	// Token: 0x06000B2B RID: 2859 RVA: 0x00040350 File Offset: 0x0003E550
	[Token(Token = "0x6000B2B")]
	[Address(RVA = "0x8A8D80", Offset = "0x8A7380", VA = "0x1808A8D80")]
	private IEnumerator BigSnow()
	{
		SnowMap.<BigSnow>d__13 <BigSnow>d__;
		<BigSnow>d__.System.IDisposable.Dispose();
		<BigSnow>d__.<>1__state = (int)((ulong)0L);
		<BigSnow>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000B2C RID: 2860 RVA: 0x00040374 File Offset: 0x0003E574
	[Token(Token = "0x6000B2C")]
	[Address(RVA = "0x8A9760", Offset = "0x8A7D60", VA = "0x1808A9760")]
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

	// Token: 0x06000B2D RID: 2861 RVA: 0x000403D8 File Offset: 0x0003E5D8
	[Token(Token = "0x6000B2D")]
	[Address(RVA = "0x8A8DF0", Offset = "0x8A73F0", VA = "0x1808A8DF0")]
	private void Freeze()
	{
		int num3;
		do
		{
			int num = 0;
			SynergyManager instance = SynergyManager.Instance;
			int num2 = 0;
			List<SynergyType> activeSynergies = instance.GetActiveSynergies(num2 != 0);
			bool flag;
			if (flag)
			{
				break;
			}
			HashSet<Vector2Int> hashSet = new HashSet();
			num3 = 0;
			Board board = this.board;
			if (num3 < board.columnNum)
			{
				Board board2 = this.board;
				if (num3 < board2.rowNum)
				{
					bool flag2 = hashSet.Add(num3);
					num3++;
				}
				num3++;
			}
			this.Remove(hashSet);
			List<Plant> plantHead = this.board.boardEntity.plantHead;
			Func<Plant, bool> func;
			if (SnowMap.<>c.<>9__15_0 == 0)
			{
				SnowMap.<>c.<>9__15_0 = func;
			}
			Plant plant = Enumerable.FirstOrDefault<Plant>(plantHead, func);
			int num4 = 0;
			if (plant != num4)
			{
				int thePlantColumn = plant.thePlantColumn;
				int thePlantRow = plant.thePlantRow;
			}
			bool flag3;
			if (flag3)
			{
				List<Plant> list = Lawnf.Get1x1Plants(num, num);
				int num5 = 0;
				bool flag4;
				if (flag4)
				{
					if (flag4 || flag4 <= true)
					{
					}
					while (num5 != 0)
					{
					}
					SavePlantData savePlantData = new SavePlantData(num);
					ParticleManager instance2 = ParticleManager.Instance;
					Vector3 vector;
					float z = vector.z;
				}
				if (num3 != 0)
				{
					goto IL_012D;
				}
			}
		}
		while (num3 != 0);
		return;
		IL_012D:
		throw new NullReferenceException();
	}

	// Token: 0x06000B2E RID: 2862 RVA: 0x00040518 File Offset: 0x0003E718
	[Token(Token = "0x6000B2E")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public SnowMap()
	{
	}

	// Token: 0x0400073E RID: 1854
	[Token(Token = "0x400073E")]
	public static SnowMap Instance;

	// Token: 0x0400073F RID: 1855
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400073F")]
	public ParticleSystem particle;

	// Token: 0x04000740 RID: 1856
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000740")]
	public bool bigSnow;

	// Token: 0x04000741 RID: 1857
	[Token(Token = "0x4000741")]
	public static bool baofengxue;

	// Token: 0x04000742 RID: 1858
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000742")]
	private float timer;

	// Token: 0x04000743 RID: 1859
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000743")]
	private Board board;

	// Token: 0x04000744 RID: 1860
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000744")]
	private ParticleSystem.EmissionModule emission;
}
