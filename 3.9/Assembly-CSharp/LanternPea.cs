using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000555 RID: 1365
[Token(Token = "0x2000555")]
public class LanternPea : Shooter
{
	// Token: 0x17000176 RID: 374
	// (get) Token: 0x0600195D RID: 6493 RVA: 0x0008935C File Offset: 0x0008755C
	[Token(Token = "0x17000176")]
	protected virtual int TargetCount
	{
		[Token(Token = "0x600195D")]
		[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "72")]
		get
		{
			return 1;
		}
	}

	// Token: 0x0600195E RID: 6494 RVA: 0x0008936C File Offset: 0x0008756C
	[Token(Token = "0x600195E")]
	[Address(RVA = "0x533180", Offset = "0x531780", VA = "0x180533180", Slot = "10")]
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

	// Token: 0x0600195F RID: 6495 RVA: 0x000893E0 File Offset: 0x000875E0
	[Token(Token = "0x600195F")]
	[Address(RVA = "0x5330C0", Offset = "0x5316C0", VA = "0x1805330C0", Slot = "39")]
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

	// Token: 0x06001960 RID: 6496 RVA: 0x00089408 File Offset: 0x00087608
	[Token(Token = "0x6001960")]
	[Address(RVA = "0x534860", Offset = "0x532E60", VA = "0x180534860", Slot = "16")]
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

	// Token: 0x06001961 RID: 6497 RVA: 0x0008946C File Offset: 0x0008766C
	[Token(Token = "0x6001961")]
	[Address(RVA = "0x534290", Offset = "0x532890", VA = "0x180534290")]
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

	// Token: 0x06001962 RID: 6498 RVA: 0x000895DC File Offset: 0x000877DC
	[Token(Token = "0x6001962")]
	[Address(RVA = "0x532FD0", Offset = "0x5315D0", VA = "0x180532FD0", Slot = "73")]
	protected virtual void ActionOnZombie(Zombie zombie, int damage)
	{
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)1), thePlantType, num != 0UL);
	}

	// Token: 0x06001963 RID: 6499 RVA: 0x00089604 File Offset: 0x00087804
	[Token(Token = "0x6001963")]
	[Address(RVA = "0x533030", Offset = "0x531630", VA = "0x180533030")]
	private IEnumerator AttackZombie(LanternPea.Target target)
	{
		LanternPea.<AttackZombie>d__9 <AttackZombie>d__;
		<AttackZombie>d__.System.IDisposable.Dispose();
		<AttackZombie>d__.<>1__state = (int)((ulong)0L);
		<AttackZombie>d__.<>4__this = this;
		<AttackZombie>d__.target = target;
		return null;
	}

	// Token: 0x06001964 RID: 6500 RVA: 0x00089630 File Offset: 0x00087830
	[Token(Token = "0x6001964")]
	[Address(RVA = "0x533350", Offset = "0x531950", VA = "0x180533350")]
	private IEnumerator ChargePlant(Plant plant)
	{
		LanternPea.<ChargePlant>d__10 <ChargePlant>d__;
		<ChargePlant>d__.System.IDisposable.Dispose();
		<ChargePlant>d__.<>1__state = (int)((ulong)0L);
		<ChargePlant>d__.<>4__this = this;
		<ChargePlant>d__.plant = plant;
		return null;
	}

	// Token: 0x06001965 RID: 6501 RVA: 0x0008965C File Offset: 0x0008785C
	[Token(Token = "0x6001965")]
	[Address(RVA = "0x533DE0", Offset = "0x5323E0", VA = "0x180533DE0", Slot = "44")]
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

	// Token: 0x06001966 RID: 6502 RVA: 0x000896C0 File Offset: 0x000878C0
	[Token(Token = "0x6001966")]
	[Address(RVA = "0x533ED0", Offset = "0x5324D0", VA = "0x180533ED0", Slot = "43")]
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

	// Token: 0x06001967 RID: 6503 RVA: 0x00089714 File Offset: 0x00087914
	[Token(Token = "0x6001967")]
	[Address(RVA = "0x533B60", Offset = "0x532160", VA = "0x180533B60")]
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

	// Token: 0x06001968 RID: 6504 RVA: 0x00089750 File Offset: 0x00087950
	[Token(Token = "0x6001968")]
	[Address(RVA = "0x533780", Offset = "0x531D80", VA = "0x180533780")]
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

	// Token: 0x06001969 RID: 6505 RVA: 0x000897E0 File Offset: 0x000879E0
	[Token(Token = "0x6001969")]
	[Address(RVA = "0x533DA0", Offset = "0x5323A0", VA = "0x180533DA0", Slot = "61")]
	public override bool OnClicked(Mouse mouse)
	{
		this.EndShoot();
		base.StopAllCoroutines();
		float attributeCountdown = this.attributeCountdown;
		base.AttributeCountdown = attributeCountdown;
		return true;
	}

	// Token: 0x0600196A RID: 6506 RVA: 0x00089808 File Offset: 0x00087A08
	[Token(Token = "0x600196A")]
	[Address(RVA = "0x5335D0", Offset = "0x531BD0", VA = "0x1805335D0")]
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

	// Token: 0x0600196B RID: 6507 RVA: 0x00089878 File Offset: 0x00087A78
	[Token(Token = "0x600196B")]
	[Address(RVA = "0x5334A0", Offset = "0x531AA0", VA = "0x1805334A0")]
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

	// Token: 0x0600196C RID: 6508 RVA: 0x000898E8 File Offset: 0x00087AE8
	[Token(Token = "0x600196C")]
	[Address(RVA = "0x533CD0", Offset = "0x5322D0", VA = "0x180533CD0", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x0600196D RID: 6509 RVA: 0x00089908 File Offset: 0x00087B08
	[Token(Token = "0x600196D")]
	[Address(RVA = "0x534070", Offset = "0x532670", VA = "0x180534070", Slot = "46")]
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
				LanternPea.<>c.<>9__20_0 = (Plant p) => p.thePlantType == PlantType.LanternSplit || p.thePlantType == PlantType.UltimateLanternSplit;
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

	// Token: 0x0600196E RID: 6510 RVA: 0x000899D8 File Offset: 0x00087BD8
	[Token(Token = "0x600196E")]
	[Address(RVA = "0x5333E0", Offset = "0x5319E0", VA = "0x1805333E0")]
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

	// Token: 0x0600196F RID: 6511 RVA: 0x00089A3C File Offset: 0x00087C3C
	[Token(Token = "0x600196F")]
	[Address(RVA = "0x534A30", Offset = "0x533030", VA = "0x180534A30")]
	public LanternPea()
	{
		List<LanternPea.Target> list = new List();
		this.targets = list;
		base..ctor();
	}

	// Token: 0x04000ECC RID: 3788
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000ECC")]
	public LineRenderer laserPrefab;

	// Token: 0x04000ECD RID: 3789
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000ECD")]
	private readonly List<LanternPea.Target> targets;

	// Token: 0x02000556 RID: 1366
	[Token(Token = "0x2000556")]
	private class Target
	{
		// Token: 0x06001971 RID: 6513 RVA: 0x00089A7C File Offset: 0x00087C7C
		[Token(Token = "0x6001971")]
		[Address(RVA = "0x545CD0", Offset = "0x5442D0", VA = "0x180545CD0")]
		public Target(LanternPea plant)
		{
			LineRenderer laserPrefab = plant.laserPrefab;
			Transform transform = plant.transform;
			LineRenderer lineRenderer = global::UnityEngine.Object.Instantiate<LineRenderer>(laserPrefab, transform);
			this.laser = lineRenderer;
			throw new NullReferenceException();
		}

		// Token: 0x04000ECE RID: 3790
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000ECE")]
		public LineRenderer laser;

		// Token: 0x04000ECF RID: 3791
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000ECF")]
		public Zombie zombie;
	}
}
