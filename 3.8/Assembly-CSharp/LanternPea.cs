using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000528 RID: 1320
[Token(Token = "0x2000528")]
public class LanternPea : Shooter
{
	// Token: 0x17000130 RID: 304
	// (get) Token: 0x0600188D RID: 6285 RVA: 0x000856A8 File Offset: 0x000838A8
	[Token(Token = "0x17000130")]
	protected virtual int TargetCount
	{
		[Token(Token = "0x600188D")]
		[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "73")]
		get
		{
			return 1;
		}
	}

	// Token: 0x0600188E RID: 6286 RVA: 0x000856B8 File Offset: 0x000838B8
	[Token(Token = "0x600188E")]
	[Address(RVA = "0x4D28A0", Offset = "0x4D0EA0", VA = "0x1804D28A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 0.5f;
		int num = 0;
		if (this.TargetCount > 0)
		{
			List<LanternPea.Target> list = this.targets;
			LineRenderer lineRenderer = this.laserPrefab;
			Transform transform = base.transform;
			LineRenderer lineRenderer2 = global::UnityEngine.Object.Instantiate<LineRenderer>(lineRenderer, transform);
			LanternPea.Target target;
			target.laser = lineRenderer2;
			int size = list._size;
			list._size = lineRenderer2;
			num++;
			int targetCount = this.TargetCount;
		}
	}

	// Token: 0x0600188F RID: 6287 RVA: 0x0008572C File Offset: 0x0008392C
	[Token(Token = "0x600188F")]
	[Address(RVA = "0x4D27E0", Offset = "0x4D0DE0", VA = "0x1804D27E0", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.AttributeCountdown = 0.5f;
		int num;
		if (num == 1)
		{
		}
		uint num2;
		num2 += (uint)num;
		this.attributeCount = (int)num2;
	}

	// Token: 0x06001890 RID: 6288 RVA: 0x00085754 File Offset: 0x00083954
	[Token(Token = "0x6001890")]
	[Address(RVA = "0x4D3F80", Offset = "0x4D2580", VA = "0x1804D3F80", Slot = "16")]
	protected override void Update()
	{
		ulong num;
		do
		{
			base.Update();
			List<LanternPea.Target> list = this.targets;
			bool flag;
			if (flag)
			{
				GameObject gameObject;
				if (!gameObject.activeSelf)
				{
					continue;
				}
				Transform shoot = this.shoot;
				Vector3 vector;
				float z = vector.z;
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06001891 RID: 6289 RVA: 0x000857B8 File Offset: 0x000839B8
	[Token(Token = "0x6001891")]
	[Address(RVA = "0x4D39B0", Offset = "0x4D1FB0", VA = "0x1804D39B0")]
	private void StartShoot()
	{
		List<LanternPea.Target> list;
		int num4;
		do
		{
			int num = 0;
			Plant targetPlant = this.targetPlant;
			int num2 = 0;
			bool flag = targetPlant != num2;
			list = this.targets;
			if (flag)
			{
				break;
			}
			int num3 = 0;
			bool flag2;
			if (flag2)
			{
				LanternPea.<AttackZombie>d__9 <AttackZombie>d__;
				<AttackZombie>d__.<>1__state = num3;
				<AttackZombie>d__.<>4__this = this;
				<AttackZombie>d__.target = num;
				Coroutine coroutine = base.StartCoroutine(<AttackZombie>d__);
			}
			if (num3 != 0)
			{
				goto IL_0138;
			}
			num4 = 0;
			bool flag3;
			if (flag3)
			{
				bool flag4;
				while (!flag4)
				{
				}
				GameObject gameObject;
				gameObject.SetActive(true);
				Vector3 vector;
				float z = vector.z;
				Vector3 vector2;
				float z2 = vector2.z;
			}
		}
		while (num4 != 0);
		int num5 = 0;
		list[num5].laser.gameObject.SetActive(true);
		List<LanternPea.Target> list2 = this.targets;
		int num6 = 0;
		LineRenderer laser = list2[num6].laser;
		Transform shoot = this.shoot;
		Vector3 vector3;
		float z3 = vector3.z;
		List<LanternPea.Target> list3 = this.targets;
		int num7 = 0;
		LineRenderer laser2 = list3[num7].laser;
		Transform shoot2 = this.shoot;
		Vector3 vector4;
		float z4 = vector4.z;
		Plant targetPlant2 = this.targetPlant;
		int num8 = 0;
		LanternPea.<ChargePlant>d__10 <ChargePlant>d__;
		<ChargePlant>d__.<>1__state = num8;
		<ChargePlant>d__.<>4__this = this;
		<ChargePlant>d__.plant = targetPlant2;
		Coroutine coroutine2 = base.StartCoroutine(<ChargePlant>d__);
		return;
		IL_0138:
		throw new NullReferenceException();
	}

	// Token: 0x06001892 RID: 6290 RVA: 0x00085928 File Offset: 0x00083B28
	[Token(Token = "0x6001892")]
	[Address(RVA = "0x4D26F0", Offset = "0x4D0CF0", VA = "0x1804D26F0", Slot = "74")]
	protected virtual void ActionOnZombie(Zombie zombie, int damage)
	{
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)1), thePlantType, num != 0UL);
	}

	// Token: 0x06001893 RID: 6291 RVA: 0x00085950 File Offset: 0x00083B50
	[Token(Token = "0x6001893")]
	[Address(RVA = "0x4D2750", Offset = "0x4D0D50", VA = "0x1804D2750")]
	private IEnumerator AttackZombie(LanternPea.Target target)
	{
		LanternPea.<AttackZombie>d__9 <AttackZombie>d__;
		<AttackZombie>d__.System.IDisposable.Dispose();
		<AttackZombie>d__.<>1__state = (int)((ulong)0L);
		<AttackZombie>d__.<>4__this = this;
		<AttackZombie>d__.target = target;
		return null;
	}

	// Token: 0x06001894 RID: 6292 RVA: 0x0008597C File Offset: 0x00083B7C
	[Token(Token = "0x6001894")]
	[Address(RVA = "0x4D2A70", Offset = "0x4D1070", VA = "0x1804D2A70")]
	private IEnumerator ChargePlant(Plant plant)
	{
		LanternPea.<ChargePlant>d__10 <ChargePlant>d__;
		<ChargePlant>d__.System.IDisposable.Dispose();
		<ChargePlant>d__.<>1__state = (int)((ulong)0L);
		<ChargePlant>d__.<>4__this = this;
		<ChargePlant>d__.plant = plant;
		return null;
	}

	// Token: 0x06001895 RID: 6293 RVA: 0x000859A8 File Offset: 0x00083BA8
	[Token(Token = "0x6001895")]
	[Address(RVA = "0x4D3500", Offset = "0x4D1B00", VA = "0x1804D3500", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		Animator anim = this.anim;
		this.thePlantAttackCountDown = num;
		if (!anim.GetBool("shooting"))
		{
			Animator anim2 = this.anim;
			bool flag = this.Shootable();
			anim2.SetBool("shooting", flag);
		}
	}

	// Token: 0x06001896 RID: 6294 RVA: 0x00085A0C File Offset: 0x00083C0C
	[Token(Token = "0x6001896")]
	[Address(RVA = "0x4D35F0", Offset = "0x4D1BF0", VA = "0x1804D35F0", Slot = "44")]
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
				if (num != num2 && this.CheckZombie(num))
				{
					break;
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_3;
			}
		}
		GameObject gameObject;
		return gameObject;
		Block_3:
		throw new NullReferenceException();
	}

	// Token: 0x06001897 RID: 6295 RVA: 0x00085A60 File Offset: 0x00083C60
	[Token(Token = "0x6001897")]
	[Address(RVA = "0x4D3280", Offset = "0x4D1880", VA = "0x1804D3280")]
	private bool HasAnyTarget()
	{
		for (;;)
		{
			List<LanternPea.Target> list = this.targets;
			bool flag;
			if (flag)
			{
				break;
			}
			ulong num;
			if (num == (ulong)0L)
			{
				goto Block_1;
			}
		}
		bool flag2;
		while (!flag2)
		{
		}
		return true;
		Block_1:
		throw new NullReferenceException();
	}

	// Token: 0x06001898 RID: 6296 RVA: 0x00085A9C File Offset: 0x00083C9C
	[Token(Token = "0x6001898")]
	[Address(RVA = "0x4D2EA0", Offset = "0x4D14A0", VA = "0x1804D2EA0")]
	private Zombie GetNearestAvailableZombie(LanternPea.Target currentTarget)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3) || !this.CheckZombie(num))
				{
					continue;
				}
				List<LanternPea.Target> list = this.targets;
				bool flag2;
				if (flag2)
				{
					while (num == currentTarget)
					{
					}
					bool flag3;
					while (!flag3)
					{
					}
				}
				if (num2 != 0)
				{
					goto IL_0068;
				}
				Vector3 vector;
				float z = vector.z;
			}
		}
		while (num2 != 0);
		throw new NullReferenceException();
		IL_0068:
		throw new NullReferenceException();
	}

	// Token: 0x06001899 RID: 6297 RVA: 0x00085B2C File Offset: 0x00083D2C
	[Token(Token = "0x6001899")]
	[Address(RVA = "0x4D34C0", Offset = "0x4D1AC0", VA = "0x1804D34C0", Slot = "62")]
	public override bool OnClicked(Mouse mouse)
	{
		this.EndShoot();
		base.StopAllCoroutines();
		float attributeCountdown = this.attributeCountdown;
		base.AttributeCountdown = attributeCountdown;
		return true;
	}

	// Token: 0x0600189A RID: 6298 RVA: 0x00085B54 File Offset: 0x00083D54
	[Token(Token = "0x600189A")]
	[Address(RVA = "0x4D2CF0", Offset = "0x4D12F0", VA = "0x1804D2CF0")]
	private void EndShoot()
	{
		int num2;
		do
		{
			Animator anim = this.anim;
			int num = 0;
			anim.SetBool("shooting", num != 0);
			float attributeCountdown = this.attributeCountdown;
			base.AttributeCountdown = 0.15f;
			List<LanternPea.Target> list = this.targets;
			num2 = 0;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				GameObject gameObject;
				gameObject.SetActive(num3 != 0);
			}
		}
		while (num2 != 0);
	}

	// Token: 0x0600189B RID: 6299 RVA: 0x00085BC4 File Offset: 0x00083DC4
	[Token(Token = "0x600189B")]
	[Address(RVA = "0x4D2BC0", Offset = "0x4D11C0", VA = "0x1804D2BC0")]
	private bool CheckZombie(Zombie zombie)
	{
		if (!zombie.isMindControlled && Lawnf.InLandStatus(zombie.theStatus))
		{
			Collider2D col = zombie.col;
			int num = 0;
			if (col != num)
			{
				int thePlantRow = this.thePlantRow;
				if (zombie.theZombieRow == thePlantRow)
				{
					Transform axis = zombie.axis;
					float vision = this.vision;
					Transform axis2 = zombie.axis;
					Transform shoot = this.shoot;
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600189C RID: 6300 RVA: 0x00085C34 File Offset: 0x00083E34
	[Token(Token = "0x600189C")]
	[Address(RVA = "0x4D33F0", Offset = "0x4D19F0", VA = "0x1804D33F0", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x0600189D RID: 6301 RVA: 0x00085C54 File Offset: 0x00083E54
	[Token(Token = "0x600189D")]
	[Address(RVA = "0x4D3790", Offset = "0x4D1D90", VA = "0x1804D3790", Slot = "47")]
	protected override bool Shootable()
	{
		Plant targetPlant = this.targetPlant;
		int num = 0;
		if (targetPlant != num)
		{
			Plant targetPlant2 = this.targetPlant;
			if (this.CheckPlant(targetPlant2))
			{
			}
		}
		Board board = this.board;
		int num2 = this.thePlantColumn;
		num2 += 2;
		if (num2 < board.columnNum)
		{
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get1x1Plants(num2, thePlantRow);
			Func<Plant, bool> <>9__20_ = LanternPea.<>c.<>9__20_0;
			if (<>9__20_ == 0)
			{
				Func<Plant, bool> func;
				LanternPea.<>c.<>9__20_0 = func;
			}
			Plant plant = Enumerable.FirstOrDefault<Plant>(list, <>9__20_);
			this.targetPlant = plant;
			Plant targetPlant3 = this.targetPlant;
			int num3 = 0;
			if (!(targetPlant3 != num3))
			{
				Board board2 = this.board;
				num2++;
			}
		}
		bool flag = base.Shootable();
		throw new NullReferenceException();
	}

	// Token: 0x0600189E RID: 6302 RVA: 0x00085D14 File Offset: 0x00083F14
	[Token(Token = "0x600189E")]
	[Address(RVA = "0x4D2B00", Offset = "0x4D1100", VA = "0x1804D2B00")]
	protected bool CheckPlant(Plant plant)
	{
		int num = 0;
		if (!(plant == num))
		{
			int num2 = this.thePlantColumn;
			num2++;
			if (plant.thePlantColumn > num2)
			{
				if (Lawnf.TravelAdvanced((AdvBuff)((uint)3007)) && plant.thePlantType == PlantType.UltimatePlantern)
				{
					return true;
				}
				int thePlantRow = this.thePlantRow;
				return plant.thePlantRow == thePlantRow;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600189F RID: 6303 RVA: 0x00085D78 File Offset: 0x00083F78
	[Token(Token = "0x600189F")]
	[Address(RVA = "0x4D4150", Offset = "0x4D2750", VA = "0x1804D4150")]
	public LanternPea()
	{
		List<LanternPea.Target> list = new List();
		this.targets = list;
		base..ctor();
	}

	// Token: 0x04000E11 RID: 3601
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E11")]
	public LineRenderer laserPrefab;

	// Token: 0x04000E12 RID: 3602
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000E12")]
	private readonly List<LanternPea.Target> targets;

	// Token: 0x02000529 RID: 1321
	[Token(Token = "0x2000529")]
	private class Target
	{
		// Token: 0x060018A1 RID: 6305 RVA: 0x00085DB8 File Offset: 0x00083FB8
		[Token(Token = "0x60018A1")]
		[Address(RVA = "0x4D7690", Offset = "0x4D5C90", VA = "0x1804D7690")]
		public Target(LanternPea plant)
		{
			LineRenderer laserPrefab = plant.laserPrefab;
			Transform transform = plant.transform;
			LineRenderer lineRenderer = global::UnityEngine.Object.Instantiate<LineRenderer>(laserPrefab, transform);
			this.laser = lineRenderer;
			throw new NullReferenceException();
		}

		// Token: 0x04000E13 RID: 3603
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000E13")]
		public LineRenderer laser;

		// Token: 0x04000E14 RID: 3604
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000E14")]
		public Zombie zombie;
	}
}
