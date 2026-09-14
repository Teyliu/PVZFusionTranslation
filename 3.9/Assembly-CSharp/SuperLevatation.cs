using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200071A RID: 1818
[Token(Token = "0x200071A")]
public class SuperLevatation : Zombie
{
	// Token: 0x060023E0 RID: 9184 RVA: 0x000BB68C File Offset: 0x000B988C
	[Token(Token = "0x60023E0")]
	[Address(RVA = "0x5F44D0", Offset = "0x5F2AD0", VA = "0x1805F44D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform shoot = this.shoot;
		this.theStatus = (ZombieStatus)((ulong)10L);
		this.attributeCountDown = 2f;
		GameObject gameObject = shoot.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
		ParticleSystem.MainModule main = this.attrackParticle.main;
	}

	// Token: 0x060023E1 RID: 9185 RVA: 0x000BB6E0 File Offset: 0x000B98E0
	[Token(Token = "0x60023E1")]
	[Address(RVA = "0x5F43D0", Offset = "0x5F29D0", VA = "0x1805F43D0", Slot = "24")]
	protected override void AttributeEvent()
	{
		if (this.GetPlant())
		{
			this.shoot.gameObject.SetActive(true);
			this.anim.SetTrigger("shoot");
			GameAPP.PlaySound(127, 0.4f, 1f);
		}
		this.attributeCountDown = 2f;
	}

	// Token: 0x060023E2 RID: 9186 RVA: 0x000BB740 File Offset: 0x000B9940
	[Token(Token = "0x60023E2")]
	[Address(RVA = "0x5F4020", Offset = "0x5F2620", VA = "0x1805F4020")]
	private void AnimShoot()
	{
		Plant plant = this.GetPlant();
		int num = 0;
		if (!(plant != num))
		{
			GameObject gameObject = this.shoot.gameObject;
			int num2 = 0;
			gameObject.SetActive(num2 != 0);
			return;
		}
		GameObject linePrefab = this.LinePrefab;
		Transform transform = base.transform;
		GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(linePrefab, transform);
		SortingGroup sortingGroup = gameObject2.AddComponent<SortingGroup>();
		sortingGroup.sortAtRoot = true;
		LineRenderer componentInChildren = gameObject2.GetComponentInChildren<LineRenderer>();
		this.lineRenderer = componentInChildren;
		Transform shoot = this.shoot;
		LineRenderer lineRenderer = this.lineRenderer;
		Vector3 vector;
		float z = vector.z;
		LineRenderer lineRenderer2 = this.lineRenderer;
		Transform axis = plant.axis;
		Vector3 vector2;
		float z2 = vector2.z;
		int thePlantRow = plant.thePlantRow;
		int theZombieRow = this.theZombieRow;
		if (thePlantRow >= theZombieRow)
		{
		}
		string text = string.Format("particle{0}", theZombieRow);
		sortingGroup.sortingLayerName = text;
		LineRenderer lineRenderer3 = this.lineRenderer;
		SuperLevatation.<LaserFade>d__6 <LaserFade>d__;
		<LaserFade>d__.System.IDisposable.Dispose();
		<LaserFade>d__.<>1__state = (int)((ulong)0L);
		<LaserFade>d__.<>4__this = this;
		<LaserFade>d__.lineRenderer = lineRenderer3;
		Coroutine coroutine = base.StartCoroutine(<LaserFade>d__);
		GameAPP.PlaySound(128, 0.3f, 1f);
		plant.FlashOnce();
	}

	// Token: 0x060023E3 RID: 9187 RVA: 0x000BB86C File Offset: 0x000B9A6C
	[Token(Token = "0x60023E3")]
	[Address(RVA = "0x5F55E0", Offset = "0x5F3BE0", VA = "0x1805F55E0")]
	private IEnumerator LaserFade(LineRenderer lineRenderer)
	{
		SuperLevatation.<LaserFade>d__6 <LaserFade>d__;
		<LaserFade>d__.System.IDisposable.Dispose();
		<LaserFade>d__.<>1__state = (int)((ulong)0L);
		<LaserFade>d__.<>4__this = this;
		<LaserFade>d__.lineRenderer = lineRenderer;
		return null;
	}

	// Token: 0x060023E4 RID: 9188 RVA: 0x000BB898 File Offset: 0x000B9A98
	[Token(Token = "0x60023E4")]
	[Address(RVA = "0x5F5670", Offset = "0x5F3C70", VA = "0x1805F5670", Slot = "17")]
	protected override void Update()
	{
		base.Update();
		LineRenderer lineRenderer = this.lineRenderer;
		int num = 0;
		if (lineRenderer != num)
		{
			Transform shoot = this.shoot;
			LineRenderer lineRenderer2 = this.lineRenderer;
			Vector3 vector;
			float z = vector.z;
		}
	}

	// Token: 0x060023E5 RID: 9189 RVA: 0x000BB8DC File Offset: 0x000B9ADC
	[Token(Token = "0x60023E5")]
	[Address(RVA = "0x5F47E0", Offset = "0x5F2DE0", VA = "0x1805F47E0", Slot = "18")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		int column = base.Column;
		int theZombieRow = this.theZombieRow;
		List<Plant> list = Lawnf.Get1x1Plants(column, theZombieRow);
		Predicate<Plant> <>9__8_ = SuperLevatation.<>c.<>9__8_0;
		if (<>9__8_ == 0)
		{
			Predicate<Plant> predicate;
			SuperLevatation.<>c.<>9__8_0 = predicate;
		}
		int num = list.RemoveAll(<>9__8_);
		ParticleSystem.MainModule main = this.attrackParticle.main;
	}

	// Token: 0x060023E6 RID: 9190 RVA: 0x000BB9AC File Offset: 0x000B9BAC
	[Token(Token = "0x60023E6")]
	[Address(RVA = "0x5F4E50", Offset = "0x5F3450", VA = "0x1805F4E50")]
	private Plant GetPlant()
	{
		int num = 0;
		List<Plant> list = new List();
		Transform axis = this.axis;
		int num2 = this.plantLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			bool flag2;
			if (!flag || !flag2)
			{
			}
			num++;
		}
		bool flag3;
		IOrderedEnumerable<Plant> orderedEnumerable2;
		if (!flag3)
		{
			Func<Plant, bool> func;
			if (SuperLevatation.<>c.<>9__9_4 == 0)
			{
				func = (Plant p) => p.plantTag.pumpkinPlant;
				SuperLevatation.<>c.<>9__9_4 = func;
			}
			IOrderedEnumerable<Plant> orderedEnumerable = Enumerable.OrderBy<Plant, bool>(list, func);
			Func<Plant, bool> func2;
			if (SuperLevatation.<>c.<>9__9_5 == 0)
			{
				func2 = delegate(Plant p)
				{
					Plant.PlantTag plantTag = p.plantTag;
					throw new NullReferenceException();
				};
				SuperLevatation.<>c.<>9__9_5 = func2;
			}
			orderedEnumerable2 = Enumerable.ThenBy<Plant, bool>(orderedEnumerable, func2);
			Func<Plant, bool> func3;
			if (SuperLevatation.<>c.<>9__9_6 == 0)
			{
				func3 = (Plant p) => p.plantTag.potPlant;
				SuperLevatation.<>c.<>9__9_6 = func3;
			}
			Func<Plant, float> func4;
			IOrderedEnumerable<Plant> orderedEnumerable3 = Enumerable.ThenBy<Plant, float>(Enumerable.ThenBy<Plant, bool>(orderedEnumerable2, func3), func4);
		}
		Func<Plant, bool> func5;
		if (SuperLevatation.<>c.<>9__9_0 == 0)
		{
			func5 = (Plant p) => p.plantTag.pumpkinPlant;
			SuperLevatation.<>c.<>9__9_0 = func5;
		}
		IOrderedEnumerable<Plant> orderedEnumerable4 = Enumerable.OrderBy<Plant, bool>(orderedEnumerable2, func5);
		Func<Plant, bool> func6;
		if (SuperLevatation.<>c.<>9__9_1 == 0)
		{
			func6 = delegate(Plant p)
			{
				Plant.PlantTag plantTag2 = p.plantTag;
				throw new NullReferenceException();
			};
			SuperLevatation.<>c.<>9__9_1 = func6;
		}
		IOrderedEnumerable<Plant> orderedEnumerable5 = Enumerable.ThenBy<Plant, bool>(orderedEnumerable4, func6);
		Func<Plant, bool> func7;
		if (SuperLevatation.<>c.<>9__9_2 == 0)
		{
			func7 = (Plant p) => p.plantTag.potPlant;
			SuperLevatation.<>c.<>9__9_2 = func7;
		}
		Func<Plant, float> func8;
		return Enumerable.FirstOrDefault<Plant>(Enumerable.ToList<Plant>(Enumerable.ThenByDescending<Plant, float>(Enumerable.ThenBy<Plant, bool>(orderedEnumerable5, func7), func8)));
	}

	// Token: 0x060023E7 RID: 9191 RVA: 0x000BBB1C File Offset: 0x000B9D1C
	[Token(Token = "0x60023E7")]
	[Address(RVA = "0x5F4560", Offset = "0x5F2B60", VA = "0x1805F4560", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num2;
		do
		{
			List<Transform> changeSprites = this.changeSprites;
			bool flag;
			if (flag)
			{
				int num = 0;
				GameObject gameObject;
				Lawnf.ChangeSprite((float)0, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060023E8 RID: 9192 RVA: 0x000BBB54 File Offset: 0x000B9D54
	[Token(Token = "0x60023E8")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060023E9 RID: 9193 RVA: 0x000BBB64 File Offset: 0x000B9D64
	[Token(Token = "0x60023E9")]
	[Address(RVA = "0x5F46D0", Offset = "0x5F2CD0", VA = "0x1805F46D0", Slot = "47")]
	public override void DestoryZombie()
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x060023EA RID: 9194 RVA: 0x000BBBA4 File Offset: 0x000B9DA4
	[Token(Token = "0x60023EA")]
	[Address(RVA = "0x5F5770", Offset = "0x5F3D70", VA = "0x1805F5770")]
	public SuperLevatation()
	{
	}

	// Token: 0x04001209 RID: 4617
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001209")]
	public GameObject LinePrefab;

	// Token: 0x0400120A RID: 4618
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x400120A")]
	public ParticleSystem attrackParticle;

	// Token: 0x0400120B RID: 4619
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x400120B")]
	private LineRenderer lineRenderer;
}
