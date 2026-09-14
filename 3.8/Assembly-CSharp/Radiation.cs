using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002D5 RID: 725
[Token(Token = "0x20002D5")]
public class Radiation : MonoBehaviour
{
	// Token: 0x06000D03 RID: 3331 RVA: 0x0004B120 File Offset: 0x00049320
	[Token(Token = "0x6000D03")]
	[Address(RVA = "0x3F9620", Offset = "0x3F7C20", VA = "0x1803F9620")]
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

	// Token: 0x06000D04 RID: 3332 RVA: 0x0004B188 File Offset: 0x00049388
	[Token(Token = "0x6000D04")]
	[Address(RVA = "0x3F9B90", Offset = "0x3F8190", VA = "0x1803F9B90")]
	private void Start()
	{
		ParticleSystem.MainModule main = base.GetComponent<ParticleSystem>().main;
		ParticleSystem.MinMaxCurve minMaxCurve;
		AnimationCurve curveMax = minMaxCurve.m_CurveMax;
	}

	// Token: 0x06000D05 RID: 3333 RVA: 0x0004B1B0 File Offset: 0x000493B0
	[Token(Token = "0x6000D05")]
	[Address(RVA = "0x3F9C30", Offset = "0x3F8230", VA = "0x1803F9C30")]
	private void Update()
	{
		float num = this.lifeTimer;
		float deltaTime = Time.deltaTime;
		this.lifeTimer = num;
		this.Die();
	}

	// Token: 0x06000D06 RID: 3334 RVA: 0x0004B1DC File Offset: 0x000493DC
	[Token(Token = "0x6000D06")]
	[Address(RVA = "0x3F9780", Offset = "0x3F7D80", VA = "0x1803F9780")]
	private void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000D07 RID: 3335 RVA: 0x0004B1F4 File Offset: 0x000493F4
	[Token(Token = "0x6000D07")]
	[Address(RVA = "0x3F9810", Offset = "0x3F7E10", VA = "0x1803F9810")]
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

	// Token: 0x06000D08 RID: 3336 RVA: 0x0004B284 File Offset: 0x00049484
	[Token(Token = "0x6000D08")]
	[Address(RVA = "0x3F9A90", Offset = "0x3F8090", VA = "0x1803F9A90")]
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

	// Token: 0x06000D09 RID: 3337 RVA: 0x0004B2C0 File Offset: 0x000494C0
	[Token(Token = "0x6000D09")]
	[Address(RVA = "0x3F9C70", Offset = "0x3F8270", VA = "0x1803F9C70")]
	public Radiation()
	{
	}

	// Token: 0x0400092E RID: 2350
	[Token(Token = "0x400092E")]
	private static Radiation radiation;

	// Token: 0x0400092F RID: 2351
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400092F")]
	private LayerMask zombieLayer;

	// Token: 0x04000930 RID: 2352
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000930")]
	private float timer = 0.5f;

	// Token: 0x04000931 RID: 2353
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000931")]
	public float lifeTimer = 10f;

	// Token: 0x04000932 RID: 2354
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000932")]
	public PlantType fromType = (PlantType)((ulong)959L);

	// Token: 0x04000933 RID: 2355
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000933")]
	public int damage;
}
