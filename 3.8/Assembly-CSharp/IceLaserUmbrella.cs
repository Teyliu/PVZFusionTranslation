using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003AF RID: 943
[Token(Token = "0x20003AF")]
public class IceLaserUmbrella : CornUmbrella
{
	// Token: 0x06001142 RID: 4418 RVA: 0x0006234C File Offset: 0x0006054C
	[Token(Token = "0x6001142")]
	[Address(RVA = "0x43F0F0", Offset = "0x43D6F0", VA = "0x18043F0F0", Slot = "70")]
	protected override void BlockEffect(Zombie zombie)
	{
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(40, this, (DamageType)((uint)4), thePlantType, num != 0UL);
		Plant umbrellaPot = base.UmbrellaPot;
		int num2 = 0;
		if (!(umbrellaPot == num2))
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001143 RID: 4419 RVA: 0x00062388 File Offset: 0x00060588
	[Token(Token = "0x6001143")]
	[Address(RVA = "0x440820", Offset = "0x43EE20", VA = "0x180440820", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
			base.PlantShootUpdate();
			this.LightUpdate();
		}
		Transform transform = this.lanternLight.transform;
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06001144 RID: 4420 RVA: 0x000623D4 File Offset: 0x000605D4
	[Token(Token = "0x6001144")]
	[Address(RVA = "0x43F720", Offset = "0x43DD20", VA = "0x18043F720")]
	private void LightUpdate()
	{
		int num;
		do
		{
			Dictionary<int, LineRenderer> dictionary = this.lineRenderers;
			num = 0;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				GameObject gameObject;
				gameObject.SetActive(num2 != 0);
			}
		}
		while (num != 0);
		int num3 = 0;
		IceLaserUmbrella.<>c__DisplayClass6_0 CS$<>8__locals1;
		List<Zombie> list;
		CS$<>8__locals1.zombies = list;
		Func<KeyValuePair<Zombie, float>, Zombie> func;
		if (IceLaserUmbrella.<>c.<>9__6_1 == 0)
		{
			IceLaserUmbrella.<>c.<>9__6_1 = func;
		}
		Func<KeyValuePair<Zombie, float>, float> func2;
		if (IceLaserUmbrella.<>c.<>9__6_2 == 0)
		{
			IceLaserUmbrella.<>c.<>9__6_2 = func2;
		}
		IEnumerable<KeyValuePair<Zombie, float>> enumerable;
		Dictionary<KeyValuePair<Zombie, float>, Zombie> dictionary2 = Enumerable.ToDictionary<KeyValuePair<Zombie, float>, Zombie, float>(enumerable, func, func2);
		List<Zombie> zombies = CS$<>8__locals1.zombies;
		Zombie zombie = CS$<>8__locals1.zombies[num3];
		Dictionary<Zombie, float> dictionary3 = this.zombieCheckings;
		bool flag2;
		if (!flag2)
		{
			float deltaTime = Time.deltaTime;
		}
		float num4 = dictionary3[zombie];
		float deltaTime2 = Time.deltaTime;
		Vector3 vector;
		float z = vector.z;
		Collider2D col = zombie.col;
		int num5 = 0;
		if (!(col != num5))
		{
			Transform axis = CS$<>8__locals1.zombies[num3].axis;
			Vector3 vector2;
			float z2 = vector2.z;
		}
		Collider2D col2 = zombie.col;
		LineRenderer lineRenderer;
		ulong num6;
		lineRenderer.gameObject.SetActive(num6 != 0UL);
		lineRenderer.startWidth = 0.15f;
		lineRenderer.endWidth = 0.15f;
		Color color;
		float g = color.g;
		Color color2;
		float b = color2.b;
		Color color3;
		float g2 = color3.g;
		Color color4;
		float b2 = color4.b;
		num3++;
		lineRenderer.startWidth = 0.3f;
		lineRenderer.endWidth = 0.3f;
		Color color5;
		float g3 = color5.g;
		Color color6;
		float b3 = color6.b;
		Color color7;
		float g4 = color7.g;
		Color color8;
		float b4 = color8.b;
		num3++;
	}

	// Token: 0x06001145 RID: 4421 RVA: 0x0006256C File Offset: 0x0006076C
	[Token(Token = "0x6001145")]
	[Address(RVA = "0x43E920", Offset = "0x43CF20", VA = "0x18043E920")]
	private void AnimShoot()
	{
		int num10;
		do
		{
			int num = 0;
			int num2 = 0;
			List<Zombie> zombies = this.GetZombies();
			int currentLightLevel = this.currentLightLevel;
			bool flag = Lawnf.TravelAdvanced((AdvBuff)((uint)22));
			int num3 = 0;
			bool flag2;
			if (flag2)
			{
				CreateBullet instance = CreateBullet.Instance;
				Transform shoot = this.shoot;
				float num4 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
				Transform shoot2 = this.shoot;
				float num5 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
				Bullet bullet;
				bullet.targetZombie = num;
				float num6 = global::UnityEngine.Random.Range(9f, 10f);
				bullet.trackSpeed = num6;
				PlantType thePlantType = this.thePlantType;
				bullet.fromType = thePlantType;
				if (!this.zombieCheckings.TryGetValue(num, num) || num2 <= num)
				{
				}
				bullet.Damage = 34;
			}
			if (num3 != 0)
			{
				goto IL_0160;
			}
			GameAPP.PlaySound(68, 0.5f, 1f);
			int num7 = 0;
			int attributeCount = this.attributeCount;
			this.attributeCount = zombies;
			this.theStatus = (PlantStatus)num7;
			int num8 = attributeCount + 1;
			this.attributeCount = num8;
			int num9 = attributeCount + 1;
			this.theStatus = (PlantStatus)((ulong)25L);
			base.UpdateText();
			if (Lawnf.TravelAdvanced((AdvBuff)((uint)23)))
			{
				Dictionary<Zombie, float> dictionary = this.zombieCheckings;
				bool flag3;
				if (flag3)
				{
					bool flag4;
					while (!flag4)
					{
					}
				}
				if (num7 != 0)
				{
					goto IL_0166;
				}
				num10 = 0;
			}
			bool flag5;
			if (flag5)
			{
				bool flag6;
				while (!flag6)
				{
				}
			}
		}
		while (num10 != 0);
		return;
		IL_0160:
		throw new NullReferenceException();
		IL_0166:
		throw new NullReferenceException();
	}

	// Token: 0x06001146 RID: 4422 RVA: 0x000626E8 File Offset: 0x000608E8
	[Token(Token = "0x6001146")]
	[Address(RVA = "0x43F3F0", Offset = "0x43D9F0", VA = "0x18043F3F0")]
	private List<Zombie> GetZombies()
	{
		List<Zombie> list;
		ulong num3;
		do
		{
			int num = 0;
			list = new List();
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				float vision = this.vision;
				bool flag2;
				if (!flag2)
				{
				}
			}
		}
		while (num3 != (ulong)0L);
		Func<Zombie, float> func;
		uint num4;
		return Enumerable.ToList<Zombie>(Enumerable.Take<Zombie>(Enumerable.OrderBy<Zombie, float>(list, func), (int)num4));
	}

	// Token: 0x06001147 RID: 4423 RVA: 0x0006276C File Offset: 0x0006096C
	[Token(Token = "0x6001147")]
	[Address(RVA = "0x4402C0", Offset = "0x43E8C0", VA = "0x1804402C0", Slot = "44")]
	protected override GameObject SearchZombie()
	{
		for (;;)
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			ulong num3;
			if (flag)
			{
				int num2 = 0;
				if (num != num2)
				{
					break;
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_2;
			}
		}
		float vision = this.vision;
		bool flag2;
		if (!flag2)
		{
		}
		GameObject gameObject;
		return gameObject;
		Block_2:
		throw new NullReferenceException();
	}

	// Token: 0x06001148 RID: 4424 RVA: 0x000627CC File Offset: 0x000609CC
	[Token(Token = "0x6001148")]
	[Address(RVA = "0x43F2A0", Offset = "0x43D8A0", VA = "0x18043F2A0")]
	private LineRenderer GetLineRenderer(int id)
	{
		Dictionary<int, LineRenderer> dictionary = this.lineRenderers;
		bool flag;
		if (!flag)
		{
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.lightPrefab);
			Transform transform = gameObject.transform;
			Transform transform2 = base.transform;
			transform.parentInternal = transform2;
			LineRenderer component = gameObject.GetComponent<LineRenderer>();
			this.lineRenderers.Add(id, component);
			return component;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001149 RID: 4425 RVA: 0x0006282C File Offset: 0x00060A2C
	[Token(Token = "0x6001149")]
	[Address(RVA = "0x440070", Offset = "0x43E670", VA = "0x180440070", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x0600114A RID: 4426 RVA: 0x0006284C File Offset: 0x00060A4C
	[Token(Token = "0x600114A")]
	[Address(RVA = "0x4404E0", Offset = "0x43EAE0", VA = "0x1804404E0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		GameAPP.PlaySound(85, 0.5f, 1f);
		Transform axis = this.axis;
		GameObject gameObject = this.lanternShine;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		this.lanternLight = gameObject2;
		throw new NullReferenceException();
	}

	// Token: 0x0600114B RID: 4427 RVA: 0x000628A0 File Offset: 0x00060AA0
	[Token(Token = "0x600114B")]
	[Address(RVA = "0x43F1E0", Offset = "0x43D7E0", VA = "0x18043F1E0", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		CreatePlant instance = CreatePlant.Instance;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		ulong num;
		instance.AdjustLightLevel(thePlantColumn, thePlantRow, -1, (int)num);
		global::UnityEngine.Object.Destroy(this.lanternLight);
	}

	// Token: 0x0600114C RID: 4428 RVA: 0x000628E0 File Offset: 0x00060AE0
	[Token(Token = "0x600114C")]
	[Address(RVA = "0x4401F0", Offset = "0x43E7F0", VA = "0x1804401F0", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, originalRow, -1, (int)num);
		ulong num2;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, (int)num2, 1, (int)num);
	}

	// Token: 0x0600114D RID: 4429 RVA: 0x00062910 File Offset: 0x00060B10
	[Token(Token = "0x600114D")]
	[Address(RVA = "0x440140", Offset = "0x43E740", VA = "0x180440140", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		base.OnCreate(theColumn, theRow);
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(theColumn, theRow, 1, (int)num);
	}

	// Token: 0x0600114E RID: 4430 RVA: 0x0006293C File Offset: 0x00060B3C
	[Token(Token = "0x600114E")]
	[Address(RVA = "0x4408F0", Offset = "0x43EEF0", VA = "0x1804408F0")]
	public IceLaserUmbrella()
	{
		Dictionary<int, LineRenderer> dictionary = new Dictionary();
		this.lineRenderers = dictionary;
		Dictionary<Zombie, float> dictionary2 = new Dictionary();
		this.zombieCheckings = dictionary2;
		base..ctor();
	}

	// Token: 0x04000BAD RID: 2989
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000BAD")]
	public GameObject lanternShine;

	// Token: 0x04000BAE RID: 2990
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000BAE")]
	public GameObject lightPrefab;

	// Token: 0x04000BAF RID: 2991
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000BAF")]
	private readonly Dictionary<int, LineRenderer> lineRenderers;

	// Token: 0x04000BB0 RID: 2992
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000BB0")]
	private Dictionary<Zombie, float> zombieCheckings;

	// Token: 0x04000BB1 RID: 2993
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000BB1")]
	protected GameObject lanternLight;

	// Token: 0x04000BB2 RID: 2994
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000BB2")]
	protected Vector3 lightPos;
}
