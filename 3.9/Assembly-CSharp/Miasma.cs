using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002D9 RID: 729
[Token(Token = "0x20002D9")]
public class Miasma : MonoBehaviour
{
	// Token: 0x06000D0B RID: 3339 RVA: 0x0004A8E4 File Offset: 0x00048AE4
	[Token(Token = "0x6000D0B")]
	[Address(RVA = "0x43A4C0", Offset = "0x438AC0", VA = "0x18043A4C0")]
	private void Awake()
	{
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie" });
		this.zombieLayer = layerMask;
	}

	// Token: 0x06000D0C RID: 3340 RVA: 0x0004A920 File Offset: 0x00048B20
	[Token(Token = "0x6000D0C")]
	[Address(RVA = "0x43ABC0", Offset = "0x4391C0", VA = "0x18043ABC0")]
	private void Start()
	{
		float num = this.maxTimer;
		this.timer = num;
	}

	// Token: 0x06000D0D RID: 3341 RVA: 0x0004A93C File Offset: 0x00048B3C
	[Token(Token = "0x6000D0D")]
	[Address(RVA = "0x43ABD0", Offset = "0x4391D0", VA = "0x18043ABD0")]
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

	// Token: 0x06000D0E RID: 3342 RVA: 0x0004AA0C File Offset: 0x00048C0C
	[Token(Token = "0x6000D0E")]
	[Address(RVA = "0x43A560", Offset = "0x438B60", VA = "0x18043A560")]
	private void OnDestroy()
	{
		bool flag = Miasma.miasmas.Remove(this);
	}

	// Token: 0x06000D0F RID: 3343 RVA: 0x0004AA2C File Offset: 0x00048C2C
	[Token(Token = "0x6000D0F")]
	[Address(RVA = "0x43A5E0", Offset = "0x438BE0", VA = "0x18043A5E0")]
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

	// Token: 0x06000D10 RID: 3344 RVA: 0x0004ABB4 File Offset: 0x00048DB4
	[Token(Token = "0x6000D10")]
	[Address(RVA = "0x43B300", Offset = "0x439900", VA = "0x18043B300")]
	public Miasma()
	{
	}

	// Token: 0x0400092E RID: 2350
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400092E")]
	public float timer;

	// Token: 0x0400092F RID: 2351
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400092F")]
	public float maxTimer;

	// Token: 0x04000930 RID: 2352
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000930")]
	public int theRow;

	// Token: 0x04000931 RID: 2353
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000931")]
	public bool sniper;

	// Token: 0x04000932 RID: 2354
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x4000932")]
	public bool big;

	// Token: 0x04000933 RID: 2355
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000933")]
	public float range = 1f;

	// Token: 0x04000934 RID: 2356
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000934")]
	public float dmgMultiplier = 1f;

	// Token: 0x04000935 RID: 2357
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000935")]
	private LayerMask zombieLayer;

	// Token: 0x04000936 RID: 2358
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000936")]
	private float lifeTimer;

	// Token: 0x04000937 RID: 2359
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000937")]
	private float totalLifeTimer = 6f;

	// Token: 0x04000938 RID: 2360
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000938")]
	private Vector3 randomVector;

	// Token: 0x04000939 RID: 2361
	[Token(Token = "0x4000939")]
	public static readonly List<Miasma> miasmas = new List();
}
