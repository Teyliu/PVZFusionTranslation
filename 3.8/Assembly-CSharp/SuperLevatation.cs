using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020006E2 RID: 1762
[Token(Token = "0x20006E2")]
public class SuperLevatation : Zombie
{
	// Token: 0x060022C4 RID: 8900 RVA: 0x000B68B0 File Offset: 0x000B4AB0
	[Token(Token = "0x60022C4")]
	[Address(RVA = "0x579EF0", Offset = "0x5784F0", VA = "0x180579EF0", Slot = "10")]
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

	// Token: 0x060022C5 RID: 8901 RVA: 0x000B6904 File Offset: 0x000B4B04
	[Token(Token = "0x60022C5")]
	[Address(RVA = "0x579DF0", Offset = "0x5783F0", VA = "0x180579DF0", Slot = "23")]
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

	// Token: 0x060022C6 RID: 8902 RVA: 0x000B6964 File Offset: 0x000B4B64
	[Token(Token = "0x60022C6")]
	[Address(RVA = "0x579A40", Offset = "0x578040", VA = "0x180579A40")]
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

	// Token: 0x060022C7 RID: 8903 RVA: 0x000B6A90 File Offset: 0x000B4C90
	[Token(Token = "0x60022C7")]
	[Address(RVA = "0x57B000", Offset = "0x579600", VA = "0x18057B000")]
	private IEnumerator LaserFade(LineRenderer lineRenderer)
	{
		SuperLevatation.<LaserFade>d__6 <LaserFade>d__;
		<LaserFade>d__.System.IDisposable.Dispose();
		<LaserFade>d__.<>1__state = (int)((ulong)0L);
		<LaserFade>d__.<>4__this = this;
		<LaserFade>d__.lineRenderer = lineRenderer;
		return null;
	}

	// Token: 0x060022C8 RID: 8904 RVA: 0x000B6ABC File Offset: 0x000B4CBC
	[Token(Token = "0x60022C8")]
	[Address(RVA = "0x57B090", Offset = "0x579690", VA = "0x18057B090", Slot = "16")]
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

	// Token: 0x060022C9 RID: 8905 RVA: 0x000B6B00 File Offset: 0x000B4D00
	[Token(Token = "0x60022C9")]
	[Address(RVA = "0x57A200", Offset = "0x578800", VA = "0x18057A200", Slot = "17")]
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

	// Token: 0x060022CA RID: 8906 RVA: 0x000B6BD0 File Offset: 0x000B4DD0
	[Token(Token = "0x60022CA")]
	[Address(RVA = "0x57A870", Offset = "0x578E70", VA = "0x18057A870")]
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
				SuperLevatation.<>c.<>9__9_4 = func;
			}
			IOrderedEnumerable<Plant> orderedEnumerable = Enumerable.OrderBy<Plant, bool>(list, func);
			Func<Plant, bool> func2;
			if (SuperLevatation.<>c.<>9__9_5 == 0)
			{
				SuperLevatation.<>c.<>9__9_5 = func2;
			}
			orderedEnumerable2 = Enumerable.ThenBy<Plant, bool>(orderedEnumerable, func2);
			Func<Plant, bool> func3;
			if (SuperLevatation.<>c.<>9__9_6 == 0)
			{
				SuperLevatation.<>c.<>9__9_6 = func3;
			}
			Func<Plant, float> func4;
			IOrderedEnumerable<Plant> orderedEnumerable3 = Enumerable.ThenBy<Plant, float>(Enumerable.ThenBy<Plant, bool>(orderedEnumerable2, func3), func4);
		}
		Func<Plant, bool> func5;
		if (SuperLevatation.<>c.<>9__9_0 == 0)
		{
			SuperLevatation.<>c.<>9__9_0 = func5;
		}
		IOrderedEnumerable<Plant> orderedEnumerable4 = Enumerable.OrderBy<Plant, bool>(orderedEnumerable2, func5);
		Func<Plant, bool> func6;
		if (SuperLevatation.<>c.<>9__9_1 == 0)
		{
			SuperLevatation.<>c.<>9__9_1 = func6;
		}
		IOrderedEnumerable<Plant> orderedEnumerable5 = Enumerable.ThenBy<Plant, bool>(orderedEnumerable4, func6);
		Func<Plant, bool> func7;
		if (SuperLevatation.<>c.<>9__9_2 == 0)
		{
			SuperLevatation.<>c.<>9__9_2 = func7;
		}
		Func<Plant, float> func8;
		return Enumerable.FirstOrDefault<Plant>(Enumerable.ToList<Plant>(Enumerable.ThenByDescending<Plant, float>(Enumerable.ThenBy<Plant, bool>(orderedEnumerable5, func7), func8)));
	}

	// Token: 0x060022CB RID: 8907 RVA: 0x000B6CD0 File Offset: 0x000B4ED0
	[Token(Token = "0x60022CB")]
	[Address(RVA = "0x579F80", Offset = "0x578580", VA = "0x180579F80", Slot = "29")]
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
				Lawnf.ChangeSprite((float)num2, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060022CC RID: 8908 RVA: 0x000B6D0C File Offset: 0x000B4F0C
	[Token(Token = "0x60022CC")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060022CD RID: 8909 RVA: 0x000B6D1C File Offset: 0x000B4F1C
	[Token(Token = "0x60022CD")]
	[Address(RVA = "0x57A0F0", Offset = "0x5786F0", VA = "0x18057A0F0", Slot = "45")]
	public override void DestoryZombie()
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x060022CE RID: 8910 RVA: 0x000B6D5C File Offset: 0x000B4F5C
	[Token(Token = "0x60022CE")]
	[Address(RVA = "0x57B190", Offset = "0x579790", VA = "0x18057B190")]
	public SuperLevatation()
	{
	}

	// Token: 0x0400113C RID: 4412
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400113C")]
	public GameObject LinePrefab;

	// Token: 0x0400113D RID: 4413
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400113D")]
	public ParticleSystem attrackParticle;

	// Token: 0x0400113E RID: 4414
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x400113E")]
	private LineRenderer lineRenderer;
}
