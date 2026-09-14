using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002CB RID: 715
[Token(Token = "0x20002CB")]
public class Miasma : MonoBehaviour
{
	// Token: 0x06000CC8 RID: 3272 RVA: 0x00049CFC File Offset: 0x00047EFC
	[Token(Token = "0x6000CC8")]
	[Address(RVA = "0x3E9980", Offset = "0x3E7F80", VA = "0x1803E9980")]
	private void Awake()
	{
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie" });
		this.zombieLayer = layerMask;
	}

	// Token: 0x06000CC9 RID: 3273 RVA: 0x00049D38 File Offset: 0x00047F38
	[Token(Token = "0x6000CC9")]
	[Address(RVA = "0x3EA080", Offset = "0x3E8680", VA = "0x1803EA080")]
	private void Start()
	{
		float num = this.maxTimer;
		this.timer = num;
	}

	// Token: 0x06000CCA RID: 3274 RVA: 0x00049D54 File Offset: 0x00047F54
	[Token(Token = "0x6000CCA")]
	[Address(RVA = "0x3EA090", Offset = "0x3E8690", VA = "0x1803EA090")]
	private void Update()
	{
		int num;
		do
		{
			num = 0;
			float num2 = this.timer;
			float deltaTime = Time.deltaTime;
			this.timer = num2;
			float num3 = this.maxTimer;
			this.timer = num3;
			int num4 = this.theRow;
			List<Plant> plantsByRow = Lawnf.GetPlantsByRow(Board.Instance, num4);
			bool flag;
			if (flag)
			{
				num += 4;
				num += 2;
				num++;
				num += 3;
			}
		}
		while (num != 0);
		int num5 = 0;
		Vector3 vector;
		float z = vector.z;
		Collider2D[] array;
		if (num5 < array.Length)
		{
			bool flag2;
			if (flag2 && Lawnf.InLandStatus((ZombieStatus)num) && num > 0)
			{
				num5++;
			}
			num5++;
		}
		float deltaTime2 = Time.deltaTime;
		float deltaTime3 = Time.deltaTime;
		GameObject gameObject;
		global::UnityEngine.Object.Destroy(gameObject);
	}

	// Token: 0x06000CCB RID: 3275 RVA: 0x00049E24 File Offset: 0x00048024
	[Token(Token = "0x6000CCB")]
	[Address(RVA = "0x3E9A20", Offset = "0x3E8020", VA = "0x1803E9A20")]
	private void OnDestroy()
	{
		bool flag = Miasma.miasmas.Remove(this);
	}

	// Token: 0x06000CCC RID: 3276 RVA: 0x00049E44 File Offset: 0x00048044
	[Token(Token = "0x6000CCC")]
	[Address(RVA = "0x3E9AA0", Offset = "0x3E80A0", VA = "0x1803E9AA0")]
	public static Miasma SetMiasma(Vector2 position, int row, Board board, bool sniper = false, bool big = false)
	{
		position.y = (float)0;
		int row = row;
		if (!sniper)
		{
			Predicate<Miasma> predicate;
			if (!Miasma.miasmas.Find(predicate))
			{
				GameObject gameObject = Resources.Load<GameObject>("Particle/Prefabs/Miasma");
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				Transform transform = board.transform;
				GameObject gameObject2;
				Miasma component = gameObject2.GetComponent<Miasma>();
				List<Miasma> list = Miasma.miasmas;
				int row2 = row;
				component.theRow = row2;
				component.totalLifeTimer = 6f;
				return component;
			}
		}
		else
		{
			List<Miasma> list2 = Miasma.miasmas;
			GameObject gameObject3 = Resources.Load<GameObject>("Particle/Prefabs/Miasma2");
			Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
			Transform transform2 = board.transform;
			GameObject gameObject4;
			Miasma component2 = gameObject4.GetComponent<Miasma>();
			List<Miasma> list3 = Miasma.miasmas;
			int row3 = row;
			component2.theRow = row3;
			component2.sniper = true;
			component2.totalLifeTimer = 15f;
			float num = global::UnityEngine.Random.Range(-1f, 1f);
			float num2 = global::UnityEngine.Random.Range(-1f, 1f);
			component2.randomVector.z = identityQuaternion2;
			component2.big = true;
			component2.range = 2f;
			float num3 = component2.maxTimer * 0.5f;
			component2.maxTimer = num3;
			Func<Miasma, float> func;
			Miasma miasma = Enumerable.FirstOrDefault<Miasma>(Enumerable.OrderBy<Miasma, float>(Miasma.miasmas, func));
			float num4 = miasma.range;
			miasma.range = num4;
			float num5 = miasma.dmgMultiplier;
			miasma.dmgMultiplier = num5;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000CCD RID: 3277 RVA: 0x00049FCC File Offset: 0x000481CC
	[Token(Token = "0x6000CCD")]
	[Address(RVA = "0x3EA7B0", Offset = "0x3E8DB0", VA = "0x1803EA7B0")]
	public Miasma()
	{
	}

	// Token: 0x040008F1 RID: 2289
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008F1")]
	public float timer;

	// Token: 0x040008F2 RID: 2290
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40008F2")]
	public float maxTimer;

	// Token: 0x040008F3 RID: 2291
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008F3")]
	public int theRow;

	// Token: 0x040008F4 RID: 2292
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40008F4")]
	public bool sniper;

	// Token: 0x040008F5 RID: 2293
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x40008F5")]
	public bool big;

	// Token: 0x040008F6 RID: 2294
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008F6")]
	public float range = 1f;

	// Token: 0x040008F7 RID: 2295
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40008F7")]
	public float dmgMultiplier = 1f;

	// Token: 0x040008F8 RID: 2296
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008F8")]
	private LayerMask zombieLayer;

	// Token: 0x040008F9 RID: 2297
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40008F9")]
	private float lifeTimer;

	// Token: 0x040008FA RID: 2298
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008FA")]
	private float totalLifeTimer = 6f;

	// Token: 0x040008FB RID: 2299
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40008FB")]
	private Vector3 randomVector;

	// Token: 0x040008FC RID: 2300
	[Token(Token = "0x40008FC")]
	public static readonly List<Miasma> miasmas = new List();
}
