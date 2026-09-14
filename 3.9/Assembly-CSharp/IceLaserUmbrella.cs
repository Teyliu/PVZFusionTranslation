using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003C3 RID: 963
[Token(Token = "0x20003C3")]
public class IceLaserUmbrella : CornUmbrella
{
	// Token: 0x0600119E RID: 4510 RVA: 0x00063958 File Offset: 0x00061B58
	[Token(Token = "0x600119E")]
	[Address(RVA = "0x492F80", Offset = "0x491580", VA = "0x180492F80", Slot = "70")]
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

	// Token: 0x0600119F RID: 4511 RVA: 0x00063994 File Offset: 0x00061B94
	[Token(Token = "0x600119F")]
	[Address(RVA = "0x494650", Offset = "0x492C50", VA = "0x180494650", Slot = "16")]
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

	// Token: 0x060011A0 RID: 4512 RVA: 0x000639E0 File Offset: 0x00061BE0
	[Token(Token = "0x60011A0")]
	[Address(RVA = "0x4935B0", Offset = "0x491BB0", VA = "0x1804935B0")]
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
		Func<KeyValuePair<Zombie, float>, bool> func = delegate(KeyValuePair<Zombie, float> kv)
		{
			List<Zombie> zombies2 = CS$<>8__locals1.zombies;
			bool flag3;
			return flag3;
		};
		Func<KeyValuePair<Zombie, float>, Zombie> func2;
		if (IceLaserUmbrella.<>c.<>9__6_1 == 0)
		{
			IceLaserUmbrella.<>c.<>9__6_1 = func2;
		}
		Func<KeyValuePair<Zombie, float>, float> func3;
		if (IceLaserUmbrella.<>c.<>9__6_2 == 0)
		{
			IceLaserUmbrella.<>c.<>9__6_2 = func3;
		}
		IEnumerable<KeyValuePair<Zombie, float>> enumerable;
		Dictionary<KeyValuePair<Zombie, float>, Zombie> dictionary2 = Enumerable.ToDictionary<KeyValuePair<Zombie, float>, Zombie, float>(enumerable, func2, func3);
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

	// Token: 0x060011A1 RID: 4513 RVA: 0x00063B88 File Offset: 0x00061D88
	[Token(Token = "0x60011A1")]
	[Address(RVA = "0x4927B0", Offset = "0x490DB0", VA = "0x1804927B0")]
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

	// Token: 0x060011A2 RID: 4514 RVA: 0x00063D04 File Offset: 0x00061F04
	[Token(Token = "0x60011A2")]
	[Address(RVA = "0x493280", Offset = "0x491880", VA = "0x180493280")]
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

	// Token: 0x060011A3 RID: 4515 RVA: 0x00063D88 File Offset: 0x00061F88
	[Token(Token = "0x60011A3")]
	[Address(RVA = "0x494150", Offset = "0x492750", VA = "0x180494150", Slot = "43")]
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

	// Token: 0x060011A4 RID: 4516 RVA: 0x00063DE8 File Offset: 0x00061FE8
	[Token(Token = "0x60011A4")]
	[Address(RVA = "0x493130", Offset = "0x491730", VA = "0x180493130")]
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

	// Token: 0x060011A5 RID: 4517 RVA: 0x00063E48 File Offset: 0x00062048
	[Token(Token = "0x60011A5")]
	[Address(RVA = "0x493F00", Offset = "0x492500", VA = "0x180493F00", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060011A6 RID: 4518 RVA: 0x00063E68 File Offset: 0x00062068
	[Token(Token = "0x60011A6")]
	[Address(RVA = "0x494370", Offset = "0x492970", VA = "0x180494370", Slot = "15")]
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

	// Token: 0x060011A7 RID: 4519 RVA: 0x00063EBC File Offset: 0x000620BC
	[Token(Token = "0x60011A7")]
	[Address(RVA = "0x493070", Offset = "0x491670", VA = "0x180493070", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		CreatePlant instance = CreatePlant.Instance;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		ulong num;
		instance.AdjustLightLevel(thePlantColumn, thePlantRow, -1, (int)num);
		global::UnityEngine.Object.Destroy(this.lanternLight);
	}

	// Token: 0x060011A8 RID: 4520 RVA: 0x00063EFC File Offset: 0x000620FC
	[Token(Token = "0x60011A8")]
	[Address(RVA = "0x494080", Offset = "0x492680", VA = "0x180494080", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, originalRow, -1, (int)num);
		ulong num2;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, (int)num2, 1, (int)num);
	}

	// Token: 0x060011A9 RID: 4521 RVA: 0x00063F2C File Offset: 0x0006212C
	[Token(Token = "0x60011A9")]
	[Address(RVA = "0x493FD0", Offset = "0x4925D0", VA = "0x180493FD0", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		base.OnCreate(theColumn, theRow);
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(theColumn, theRow, 1, (int)num);
	}

	// Token: 0x060011AA RID: 4522 RVA: 0x00063F58 File Offset: 0x00062158
	[Token(Token = "0x60011AA")]
	[Address(RVA = "0x494720", Offset = "0x492D20", VA = "0x180494720")]
	public IceLaserUmbrella()
	{
		Dictionary<int, LineRenderer> dictionary = new Dictionary();
		this.lineRenderers = dictionary;
		Dictionary<Zombie, float> dictionary2 = new Dictionary();
		this.zombieCheckings = dictionary2;
		base..ctor();
	}

	// Token: 0x04000C13 RID: 3091
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C13")]
	public GameObject lanternShine;

	// Token: 0x04000C14 RID: 3092
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000C14")]
	public GameObject lightPrefab;

	// Token: 0x04000C15 RID: 3093
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000C15")]
	private readonly Dictionary<int, LineRenderer> lineRenderers;

	// Token: 0x04000C16 RID: 3094
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000C16")]
	private Dictionary<Zombie, float> zombieCheckings;

	// Token: 0x04000C17 RID: 3095
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000C17")]
	protected GameObject lanternLight;

	// Token: 0x04000C18 RID: 3096
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000C18")]
	protected Vector3 lightPos;
}
