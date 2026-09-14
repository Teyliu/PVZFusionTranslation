using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200069E RID: 1694
[Token(Token = "0x200069E")]
public class MachineNutZombie : Zombie
{
	// Token: 0x060020E4 RID: 8420 RVA: 0x000AE110 File Offset: 0x000AC310
	[Token(Token = "0x60020E4")]
	[Address(RVA = "0x55FEE0", Offset = "0x55E4E0", VA = "0x18055FEE0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		GameAPP.PlaySound(53, 0.5f, 1f);
	}

	// Token: 0x060020E5 RID: 8421 RVA: 0x000AE134 File Offset: 0x000AC334
	[Token(Token = "0x60020E5")]
	[Address(RVA = "0x55F690", Offset = "0x55DC90", VA = "0x18055F690", Slot = "74")]
	protected virtual void InitType()
	{
		int num = global::UnityEngine.Random.Range(0, 3);
		Board board = this.board;
		int num2 = global::UnityEngine.Random.Range(1, 3);
		if (num == 1)
		{
			this.machineType = (MachineNutZombie.MachineType)((ulong)1L);
			Transform transform = base.transform;
			int num3 = 0;
			SpriteRenderer component = transform.GetChild(num3).GetComponent<SpriteRenderer>();
			int num4 = 0;
			component.enabled = num4 != 0;
			SpriteRenderer component2 = base.transform.GetChild(1).GetComponent<SpriteRenderer>();
			int num5 = 0;
			component2.enabled = num5 != 0;
			SpriteRenderer component3 = base.transform.GetChild(2).GetComponent<SpriteRenderer>();
			int num6 = 0;
			component3.enabled = num6 != 0;
			Transform transform2 = base.transform;
			int num7 = 0;
			transform2.GetChild(num7).GetChild(1).gameObject.SetActive(true);
			base.transform.GetChild(1).GetChild(1).gameObject.SetActive(true);
			Transform child = base.transform.GetChild(2);
			throw new NullReferenceException();
		}
		if (num == 2)
		{
			this.machineType = (MachineNutZombie.MachineType)num;
			Transform transform3 = base.transform;
			int num8 = 0;
			SpriteRenderer component4 = transform3.GetChild(num8).GetComponent<SpriteRenderer>();
			int num9 = 0;
			component4.enabled = num9 != 0;
			SpriteRenderer component5 = base.transform.GetChild(1).GetComponent<SpriteRenderer>();
			int num10 = 0;
			component5.enabled = num10 != 0;
			SpriteRenderer component6 = base.transform.GetChild(2).GetComponent<SpriteRenderer>();
			int num11 = 0;
			component6.enabled = num11 != 0;
			Transform transform4 = base.transform;
			int num12 = 0;
			Transform child2 = transform4.GetChild(num12);
			int num13 = 0;
			child2.GetChild(num13).gameObject.SetActive(true);
			Transform child3 = base.transform.GetChild(1);
			int num14 = 0;
			child3.GetChild(num14).gameObject.SetActive(true);
			Transform child4 = base.transform.GetChild(2);
			int num15 = 0;
			child4.GetChild(num15).gameObject.SetActive(true);
			return;
		}
	}

	// Token: 0x060020E6 RID: 8422 RVA: 0x000AE310 File Offset: 0x000AC510
	[Token(Token = "0x60020E6")]
	[Address(RVA = "0x55F5E0", Offset = "0x55DBE0", VA = "0x18055F5E0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Board board = this.board;
		Transform axis = this.axis;
		this.uniqueSpeed = 1f;
	}

	// Token: 0x060020E7 RID: 8423 RVA: 0x000AE364 File Offset: 0x000AC564
	[Token(Token = "0x60020E7")]
	[Address(RVA = "0x55EC50", Offset = "0x55D250", VA = "0x18055EC50", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		int num = this.theHealth;
		num -= theDamage;
		this.theHealth = num;
		float num2;
		float num3;
		if (!global::Core.Lawnf.ValueBetween(num2, (float)theDamage, num3))
		{
			Transform transform = base.transform;
			int num4 = 0;
			GameObject gameObject = transform.GetChild(num4).gameObject;
			int num5 = 0;
			gameObject.SetActive(num5 != 0);
			uint num6;
			GameObject gameObject2 = base.transform.GetChild((int)num6).gameObject;
			int num7 = 0;
			gameObject2.SetActive(num7 != 0);
			uint num8;
			ulong num9;
			base.transform.GetChild((int)num8).gameObject.SetActive(num9 != 0UL);
			return;
		}
		Transform transform2 = base.transform;
		int num10 = 0;
		GameObject gameObject3 = transform2.GetChild(num10).gameObject;
		int num11 = 0;
		gameObject3.SetActive(num11 != 0);
		uint num12;
		ulong num13;
		base.transform.GetChild((int)num12).gameObject.SetActive(num13 != 0UL);
		uint num14;
		GameObject gameObject4 = base.transform.GetChild((int)num14).gameObject;
		throw new NullReferenceException();
	}

	// Token: 0x060020E8 RID: 8424 RVA: 0x000AE44C File Offset: 0x000AC64C
	[Token(Token = "0x60020E8")]
	[Address(RVA = "0x537D20", Offset = "0x536320", VA = "0x180537D20", Slot = "27")]
	public override void Die(int reason = 0)
	{
		base.Die(reason);
	}

	// Token: 0x060020E9 RID: 8425 RVA: 0x000AE460 File Offset: 0x000AC660
	[Token(Token = "0x60020E9")]
	[Address(RVA = "0x55FB10", Offset = "0x55E110", VA = "0x18055FB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
		base.KnockBack(x, reason);
		if (reason == Zombie.KnockBackReason.ByUmbrella)
		{
			this.theOriginSpeed = (float)reason;
		}
	}

	// Token: 0x060020EA RID: 8426 RVA: 0x000AE484 File Offset: 0x000AC684
	[Token(Token = "0x60020EA")]
	[Address(RVA = "0x55EEE0", Offset = "0x55D4E0", VA = "0x18055EEE0", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		int num = 0;
		GameObject gameObject = GameAPP.particlePrefab[54];
		Board board = this.board;
		int num2 = 0;
		Transform transform = board.transform;
		GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, num2, num, transform);
		if (this.machineType != MachineNutZombie.MachineType.Default)
		{
			int num3 = 0;
			GridSystem gridSystem = this.board.gridSystem;
			int column = base.Column;
			int theZombieRow = this.theZombieRow;
			Vector2 position = gridSystem.GetGrid(column, theZombieRow).Position;
			MachineNutZombie.MachineType machineType = this.machineType;
			if (machineType == MachineNutZombie.MachineType.Red)
			{
				GameObject[] itemPrefab = GameAPP.itemPrefab;
			}
			if (machineType == MachineNutZombie.MachineType.Blue)
			{
				GameObject gameObject3 = GameAPP.itemPrefab[33];
				Transform transform2 = this.board.transform;
			}
			int num4 = 0;
			if (num3 != num4)
			{
				int theZombieRow2 = this.theZombieRow;
				Obstacle obstacle;
				obstacle.theBallRow = theZombieRow2;
				int sortingOrder = this.sortingGroup.sortingOrder;
				SortingGroup sortingGroup;
				sortingGroup.sortingOrder = sortingOrder;
				int sortingLayerID = this.sortingGroup.sortingLayerID;
				SortingGroup sortingGroup2;
				sortingGroup2.sortingLayerID = sortingLayerID;
			}
			Transform axis2 = this.axis;
			int theZombieRow3 = this.theZombieRow;
			CreateZombie instance = CreateZombie.Instance;
			float num5 = global::UnityEngine.Random.Range(-1f, 1f);
			Zombie zombie = instance.SetZombie(theZombieRow3, (ZombieType)((uint)37), num5, num3 != 0);
			num3++;
			return;
		}
		Transform axis3 = this.axis;
		int num6 = 0;
		GameObject gameObject4 = GameAPP.itemPrefab[41];
		Board board2 = this.board;
		int num7 = 0;
		Transform transform3 = board2.transform;
		GameObject gameObject5 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject4, num7, num6, transform3);
		throw new NullReferenceException();
	}

	// Token: 0x060020EB RID: 8427 RVA: 0x000AE62C File Offset: 0x000AC82C
	[Token(Token = "0x60020EB")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = false)
	{
	}

	// Token: 0x060020EC RID: 8428 RVA: 0x000AE63C File Offset: 0x000AC83C
	[Token(Token = "0x60020EC")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "52")]
	public override void SetPoison(float time = 10f)
	{
	}

	// Token: 0x060020ED RID: 8429 RVA: 0x000AE64C File Offset: 0x000AC84C
	[Token(Token = "0x60020ED")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "59")]
	public override void Garliced(bool playSound = false, bool certainRow = false)
	{
	}

	// Token: 0x060020EE RID: 8430 RVA: 0x000AE65C File Offset: 0x000AC85C
	[Token(Token = "0x60020EE")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "53")]
	public override void AddPoisonLevel()
	{
	}

	// Token: 0x060020EF RID: 8431 RVA: 0x000AE66C File Offset: 0x000AC86C
	[Token(Token = "0x60020EF")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "58")]
	public override void EatGarlic(Plant plant, float time = 1f, bool withSound = true)
	{
	}

	// Token: 0x060020F0 RID: 8432 RVA: 0x000AE67C File Offset: 0x000AC87C
	[Token(Token = "0x60020F0")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060020F1 RID: 8433 RVA: 0x000AE68C File Offset: 0x000AC88C
	[Token(Token = "0x60020F1")]
	[Address(RVA = "0x55FB40", Offset = "0x55E140", VA = "0x18055FB40")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		float attributeCountDown = this.attributeCountDown;
		int num = 0;
		if (attributeCountDown <= (float)num)
		{
			bool flag;
			if (!flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
				GameAPP.PlaySound(global::UnityEngine.Random.Range(54, 56), 0.5f, 1f);
				throw new NullReferenceException();
			}
			int theZombieRow = this.theZombieRow;
			bool flag3;
			if (flag3)
			{
				return;
			}
			int num2 = 0;
			Plant plant;
			if (plant != num2)
			{
			}
			GameAPP.PlaySound(global::UnityEngine.Random.Range(54, 56), 0.5f, 1f);
			float num3 = this.theOriginSpeed * 0.6f;
			this.theOriginSpeed = num3;
			this.theOriginSpeed = 0.2f;
			int num4 = this.theZombieRow;
			num4 = base.GetAvaliableRow(num4);
			base.ChangeRow(num4);
			this.attributeCountDown = 1f;
		}
	}

	// Token: 0x060020F2 RID: 8434 RVA: 0x000AE758 File Offset: 0x000AC958
	[Token(Token = "0x60020F2")]
	[Address(RVA = "0x55FF60", Offset = "0x55E560", VA = "0x18055FF60")]
	public MachineNutZombie()
	{
	}

	// Token: 0x040010E7 RID: 4327
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40010E7")]
	private MachineNutZombie.MachineType machineType;

	// Token: 0x0200069F RID: 1695
	[Token(Token = "0x200069F")]
	private enum MachineType
	{
		// Token: 0x040010E9 RID: 4329
		[Token(Token = "0x40010E9")]
		Default,
		// Token: 0x040010EA RID: 4330
		[Token(Token = "0x40010EA")]
		Red,
		// Token: 0x040010EB RID: 4331
		[Token(Token = "0x40010EB")]
		Blue
	}
}
