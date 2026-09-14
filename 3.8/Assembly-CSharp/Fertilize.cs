using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000766 RID: 1894
[Token(Token = "0x2000766")]
public class Fertilize : Bucket
{
	// Token: 0x0600266C RID: 9836 RVA: 0x000CCC44 File Offset: 0x000CAE44
	[Token(Token = "0x600266C")]
	[Address(RVA = "0x5D91A0", Offset = "0x5D77A0", VA = "0x1805D91A0")]
	private void Awake()
	{
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
	}

	// Token: 0x0600266D RID: 9837 RVA: 0x000CCC60 File Offset: 0x000CAE60
	[Token(Token = "0x600266D")]
	[Address(RVA = "0x5D9250", Offset = "0x5D7850", VA = "0x1805D9250", Slot = "6")]
	protected override void Start()
	{
		base.Start();
		this.gravity = 15f;
	}

	// Token: 0x0600266E RID: 9838 RVA: 0x000CCC80 File Offset: 0x000CAE80
	[Token(Token = "0x600266E")]
	[Address(RVA = "0x5D9270", Offset = "0x5D7870", VA = "0x1805D9270", Slot = "7")]
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
					Fertilize.<>c.<>9__8_0 = func;
				}
				List<Plant> list = Enumerable.ToList<Plant>(Enumerable.Where<Plant>(allPlants, func));
				global::UnityEngine.Object.Destroy(base.gameObject);
			}
		}
	}

	// Token: 0x0600266F RID: 9839 RVA: 0x000CCD54 File Offset: 0x000CAF54
	[Token(Token = "0x600266F")]
	[Address(RVA = "0x5D91F0", Offset = "0x5D77F0", VA = "0x1805D91F0", Slot = "8")]
	public override void Pick()
	{
		base.Pick();
		this.anim.SetTrigger("idleToStatic");
	}

	// Token: 0x06002670 RID: 9840 RVA: 0x000CCD80 File Offset: 0x000CAF80
	[Token(Token = "0x6002670")]
	[Address(RVA = "0x5DA4A0", Offset = "0x5D8AA0", VA = "0x1805DA4A0")]
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

	// Token: 0x06002671 RID: 9841 RVA: 0x000CCEE0 File Offset: 0x000CB0E0
	[Token(Token = "0x6002671")]
	[Address(RVA = "0x5DAB30", Offset = "0x5D9130", VA = "0x1805DAB30", Slot = "9")]
	public override void Use()
	{
		Mouse m = this.m;
		int theMouseRow = m.theMouseRow;
		int theMouseColumn = m.theMouseColumn;
		this.Use(theMouseColumn, theMouseRow);
	}

	// Token: 0x06002672 RID: 9842 RVA: 0x000CCF10 File Offset: 0x000CB110
	[Token(Token = "0x6002672")]
	[Address(RVA = "0x5D95F0", Offset = "0x5D7BF0", VA = "0x1805D95F0")]
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

	// Token: 0x06002673 RID: 9843 RVA: 0x000CD1F0 File Offset: 0x000CB3F0
	[Token(Token = "0x6002673")]
	[Address(RVA = "0x5DAB60", Offset = "0x5D9160", VA = "0x1805DAB60")]
	public Fertilize()
	{
	}

	// Token: 0x04001408 RID: 5128
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001408")]
	public Fertilize zombieFertilizePrefab;

	// Token: 0x04001409 RID: 5129
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001409")]
	public bool zombie;

	// Token: 0x0400140A RID: 5130
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400140A")]
	private FreezedPlant targetFreezedPlant;

	// Token: 0x0400140B RID: 5131
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400140B")]
	private Plant theTargetPlant;

	// Token: 0x0400140C RID: 5132
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400140C")]
	private Animator anim;

	// Token: 0x0400140D RID: 5133
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400140D")]
	private bool isUsing;
}
