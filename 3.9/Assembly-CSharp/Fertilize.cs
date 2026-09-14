using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200079F RID: 1951
[Token(Token = "0x200079F")]
public class Fertilize : Bucket
{
	// Token: 0x0600279B RID: 10139 RVA: 0x000D1CA8 File Offset: 0x000CFEA8
	[Token(Token = "0x600279B")]
	[Address(RVA = "0x63C0B0", Offset = "0x63A6B0", VA = "0x18063C0B0")]
	private void Awake()
	{
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
	}

	// Token: 0x0600279C RID: 10140 RVA: 0x000D1CC4 File Offset: 0x000CFEC4
	[Token(Token = "0x600279C")]
	[Address(RVA = "0x63C160", Offset = "0x63A760", VA = "0x18063C160", Slot = "6")]
	protected override void Start()
	{
		base.Start();
		this.gravity = 15f;
	}

	// Token: 0x0600279D RID: 10141 RVA: 0x000D1CE4 File Offset: 0x000CFEE4
	[Token(Token = "0x600279D")]
	[Address(RVA = "0x63C180", Offset = "0x63A780", VA = "0x18063C180", Slot = "7")]
	protected override void Update()
	{
		base.PositionUpdate();
		GameObject theItemOnMouse = Mouse.Instance.theItemOnMouse;
		GameObject gameObject = base.gameObject;
		if (theItemOnMouse != gameObject && !this.isUsing)
		{
			float deltaTime = Time.deltaTime;
			this.existTime = deltaTime;
			if (deltaTime > 30f)
			{
				global::UnityEngine.Object.Destroy(base.gameObject);
			}
			Board instance = Board.Instance;
			if (this.zombie && this.existTime > 5f)
			{
				List<Plant> allPlants = Lawnf.GetAllPlants();
				Func<Plant, bool> func;
				if (Fertilize.<>c.<>9__8_0 == 0)
				{
					func = delegate(Plant p)
					{
						bool flag = FreezedPlant.CanFreeze(p);
						if (!flag)
						{
							return flag;
						}
						return p.thePlantType != PlantType.ZombieEndoFlame;
					};
					Fertilize.<>c.<>9__8_0 = func;
				}
				List<Plant> list = Enumerable.ToList<Plant>(Enumerable.Where<Plant>(allPlants, func));
				global::UnityEngine.Object.Destroy(base.gameObject);
			}
		}
	}

	// Token: 0x0600279E RID: 10142 RVA: 0x000D1DCC File Offset: 0x000CFFCC
	[Token(Token = "0x600279E")]
	[Address(RVA = "0x63C100", Offset = "0x63A700", VA = "0x18063C100", Slot = "8")]
	public override void Pick()
	{
		base.Pick();
		this.anim.SetTrigger("idleToStatic");
	}

	// Token: 0x0600279F RID: 10143 RVA: 0x000D1DF8 File Offset: 0x000CFFF8
	[Token(Token = "0x600279F")]
	[Address(RVA = "0x63D390", Offset = "0x63B990", VA = "0x18063D390")]
	public void Use(int theColumn, int theRow)
	{
		int num4;
		do
		{
			int num = 0;
			if ((this.zombie ? 1 : 0) == num)
			{
				List<GridItem> griditemArray = Board.Instance.griditemArray;
				int num2 = 0;
				bool flag;
				if (flag)
				{
					int num3 = 0;
					if (!(num != num3))
					{
						continue;
					}
					this.targetFreezedPlant = num;
					Transform transform = base.transform;
					Vector3 vector;
					float z = vector.z;
					Vector3 vector2;
					float z2 = vector2.z;
					this.anim.CrossFade("use", 0.2f);
					this.isUsing = true;
					GameAPP.PlaySound(65, 0.5f, 1f);
				}
				if (num2 != 0)
				{
					goto IL_0139;
				}
			}
			num4 = 0;
			List<Plant> plantArray = Board.Instance.boardEntity.plantArray;
			bool flag2;
			if (flag2)
			{
				int num5 = 0;
				if (!(num != num5))
				{
					continue;
				}
				this.theTargetPlant = num;
				Transform transform2 = base.transform;
				Vector3 vector3;
				float z3 = vector3.z;
				Vector3 vector4;
				float z4 = vector4.z;
				if (!this.isUsing)
				{
					this.anim.CrossFade("use", 0.2f);
				}
				this.isUsing = true;
				GameAPP.PlaySound(65, 0.5f, 1f);
			}
		}
		while (num4 != 0);
		Collider2D collider2D;
		collider2D.enabled = true;
		return;
		IL_0139:
		throw new NullReferenceException();
	}

	// Token: 0x060027A0 RID: 10144 RVA: 0x000D1F58 File Offset: 0x000D0158
	[Token(Token = "0x60027A0")]
	[Address(RVA = "0x63DA20", Offset = "0x63C020", VA = "0x18063DA20", Slot = "9")]
	public override void Use()
	{
		Mouse m = this.m;
		int theMouseRow = m.theMouseRow;
		int theMouseColumn = m.theMouseColumn;
		this.Use(theMouseColumn, theMouseRow);
	}

	// Token: 0x060027A1 RID: 10145 RVA: 0x000D1F88 File Offset: 0x000D0188
	[Token(Token = "0x60027A1")]
	[Address(RVA = "0x63C500", Offset = "0x63AB00", VA = "0x18063C500")]
	private void Upgrade()
	{
		int num;
		int num5;
		do
		{
			num = 0;
			if ((this.zombie ? 1 : 0) == num)
			{
				FreezedPlant freezedPlant = this.targetFreezedPlant;
				int num2 = 0;
				if (freezedPlant != num2)
				{
					goto IL_0037;
				}
				Plant plant = this.theTargetPlant;
				int num3 = 0;
				if (!(plant != num3))
				{
					goto IL_0037;
				}
			}
			else
			{
				Plant plant2 = this.theTargetPlant;
				int num4 = 0;
				if (plant2 == num4)
				{
					goto IL_0243;
				}
			}
			Plant plant3 = this.theTargetPlant;
			int thePlantRow = plant3.thePlantRow;
			int thePlantColumn = plant3.thePlantColumn;
			List<Plant> list = Lawnf.Get1x1Plants(thePlantColumn, thePlantRow);
			num5 = 0;
			bool flag;
			if (flag)
			{
				if (this.zombie)
				{
					FreezedPlant freezedPlant2 = FreezedPlant.FreezePlant(num, true);
					int num6 = 0;
					bool flag2 = freezedPlant2 != num6;
					if (flag2)
					{
					}
				}
				bool flag3 = Lawnf.HasZombie((ZombieType)((uint)259));
				while (flag3)
				{
				}
				while (this.zombie != flag3)
				{
				}
				Board instance = Board.Instance;
				CreatePlant instance2 = CreatePlant.Instance;
				Plant plant4;
				while (plant4 != (ulong)1235L)
				{
				}
				CreatePlant instance3 = CreatePlant.Instance;
				Plant plant5;
				if (plant5 == (ulong)1180L)
				{
					CreatePlant instance4 = CreatePlant.Instance;
				}
				Plant plant6;
				while (plant6 != (ulong)1189L)
				{
				}
				CreatePlant instance5 = CreatePlant.Instance;
				Plant plant7;
				if (plant7 == (ulong)1037L)
				{
					CreatePlant instance6 = CreatePlant.Instance;
				}
				Plant plant8;
				if (plant8 == (ulong)1058L)
				{
					CreatePlant instance7 = CreatePlant.Instance;
				}
				Plant plant9;
				while (plant9 != (ulong)1062L)
				{
				}
				CreatePlant instance8 = CreatePlant.Instance;
				Plant plant10;
				if (plant10 > (ulong)12L)
				{
					if (plant10 > (ulong)28L)
					{
						if (plant10 == (ulong)36L)
						{
							CreatePlant instance9 = CreatePlant.Instance;
						}
						Plant plant11;
						while (plant11 != (ulong)228L)
						{
						}
						Vector3 vector;
						float z = vector.z;
					}
					DroppedCard droppedCard;
					if (droppedCard == (ulong)17L)
					{
						CreatePlant instance10 = CreatePlant.Instance;
					}
					Plant plant12;
					while (plant12 != (ulong)28L)
					{
					}
					CreatePlant instance11 = CreatePlant.Instance;
				}
				Plant plant13;
				if (plant13 == (ulong)3L)
				{
					CreatePlant instance12 = CreatePlant.Instance;
				}
				Plant plant14;
				if (plant14 == (ulong)7L)
				{
					CreatePlant instance13 = CreatePlant.Instance;
				}
				Plant plant15;
				while (plant15 != (ulong)12L)
				{
				}
				CreatePlant instance14 = CreatePlant.Instance;
			}
		}
		while (num5 != 0);
		ulong num7;
		while (num7 != (ulong)0L)
		{
		}
		Vector3 vector2;
		float z2 = vector2.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform;
		Transform parent = transform.parent;
		Fertilize fertilize;
		fertilize.existTime = (float)num;
		goto IL_0243;
		IL_0037:
		this.targetFreezedPlant.Die();
		FreezedPlant freezedPlant3 = this.targetFreezedPlant;
		int num8 = 0;
		freezedPlant3.SetEntity((Team)num8);
		global::UnityEngine.Object.Destroy(base.gameObject);
		return;
		IL_0243:
		GameObject gameObject;
		global::UnityEngine.Object.Destroy(gameObject);
		Vector3 vector3;
		float z3 = vector3.z;
		Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
		Transform transform2;
		Transform parent2 = transform2.parent;
		Fertilize fertilize2;
		fertilize2.existTime = gameObject;
		throw new NullReferenceException();
	}

	// Token: 0x060027A2 RID: 10146 RVA: 0x000D2268 File Offset: 0x000D0468
	[Token(Token = "0x60027A2")]
	[Address(RVA = "0x63DA50", Offset = "0x63C050", VA = "0x18063DA50")]
	public Fertilize()
	{
	}

	// Token: 0x040014E4 RID: 5348
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40014E4")]
	public Fertilize zombieFertilizePrefab;

	// Token: 0x040014E5 RID: 5349
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40014E5")]
	public bool zombie;

	// Token: 0x040014E6 RID: 5350
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40014E6")]
	private FreezedPlant targetFreezedPlant;

	// Token: 0x040014E7 RID: 5351
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40014E7")]
	private Plant theTargetPlant;

	// Token: 0x040014E8 RID: 5352
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40014E8")]
	private Animator anim;

	// Token: 0x040014E9 RID: 5353
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40014E9")]
	private bool isUsing;
}
