using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002E3 RID: 739
[Token(Token = "0x20002E3")]
public class Radiation : MonoBehaviour
{
	// Token: 0x06000D46 RID: 3398 RVA: 0x0004BCF4 File Offset: 0x00049EF4
	[Token(Token = "0x6000D46")]
	[Address(RVA = "0x43D320", Offset = "0x43B920", VA = "0x18043D320")]
	private void Awake()
	{
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie" });
		this.zombieLayer = layerMask;
		Radiation radiation = Radiation.radiation;
		int num = 0;
		if (radiation != num)
		{
			Radiation.radiation.Die();
		}
		if (!Lawnf.TravelAdvanced((AdvBuff)((uint)30)))
		{
		}
		Radiation.radiation = this;
		throw new NullReferenceException();
	}

	// Token: 0x06000D47 RID: 3399 RVA: 0x0004BD5C File Offset: 0x00049F5C
	[Token(Token = "0x6000D47")]
	[Address(RVA = "0x43D890", Offset = "0x43BE90", VA = "0x18043D890")]
	private void Start()
	{
		ParticleSystem.MainModule main = base.GetComponent<ParticleSystem>().main;
		ParticleSystem.MinMaxCurve minMaxCurve;
		AnimationCurve curveMax = minMaxCurve.m_CurveMax;
	}

	// Token: 0x06000D48 RID: 3400 RVA: 0x0004BD84 File Offset: 0x00049F84
	[Token(Token = "0x6000D48")]
	[Address(RVA = "0x43D930", Offset = "0x43BF30", VA = "0x18043D930")]
	private void Update()
	{
		float num = this.lifeTimer;
		float deltaTime = Time.deltaTime;
		this.lifeTimer = num;
		this.Die();
	}

	// Token: 0x06000D49 RID: 3401 RVA: 0x0004BDB0 File Offset: 0x00049FB0
	[Token(Token = "0x6000D49")]
	[Address(RVA = "0x43D480", Offset = "0x43BA80", VA = "0x18043D480")]
	private void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000D4A RID: 3402 RVA: 0x0004BDC8 File Offset: 0x00049FC8
	[Token(Token = "0x6000D4A")]
	[Address(RVA = "0x43D510", Offset = "0x43BB10", VA = "0x18043D510")]
	private void FixedUpdate()
	{
		float num = this.timer;
		int num2 = 0;
		float fixedDeltaTime = Time.fixedDeltaTime;
		this.timer = num;
		this.timer = 0.5f;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Transform transform2 = base.transform;
		int num3 = this.zombieLayer;
		Collider2D[] array;
		if (num2 < array.Length)
		{
			bool flag;
			if (flag)
			{
				int num4 = 0;
				bool flag2;
				if (flag2)
				{
				}
				PlantType plantType = this.fromType;
				int num5 = num2.System.IConvertible.ToInt32(num4);
			}
			num2++;
		}
	}

	// Token: 0x06000D4B RID: 3403 RVA: 0x0004BE58 File Offset: 0x0004A058
	[Token(Token = "0x6000D4B")]
	[Address(RVA = "0x43D790", Offset = "0x43BD90", VA = "0x18043D790")]
	private Collider2D[] GetCollider2Ds()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Transform transform2 = base.transform;
		int num = this.zombieLayer;
		Collider2D[] array;
		return array;
	}

	// Token: 0x06000D4C RID: 3404 RVA: 0x0004BE94 File Offset: 0x0004A094
	[Token(Token = "0x6000D4C")]
	[Address(RVA = "0x43D970", Offset = "0x43BF70", VA = "0x18043D970")]
	public Radiation()
	{
	}

	// Token: 0x0400096B RID: 2411
	[Token(Token = "0x400096B")]
	private static Radiation radiation;

	// Token: 0x0400096C RID: 2412
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400096C")]
	private LayerMask zombieLayer;

	// Token: 0x0400096D RID: 2413
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400096D")]
	private float timer = 0.5f;

	// Token: 0x0400096E RID: 2414
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400096E")]
	public float lifeTimer = 10f;

	// Token: 0x0400096F RID: 2415
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400096F")]
	public PlantType fromType = (PlantType)((ulong)959L);

	// Token: 0x04000970 RID: 2416
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000970")]
	public int damage;
}
