using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020006D5 RID: 1749
[Token(Token = "0x20006D5")]
public class MachineNutZombie : Zombie
{
	// Token: 0x060021FB RID: 8699 RVA: 0x000B2DA4 File Offset: 0x000B0FA4
	[Token(Token = "0x60021FB")]
	[Address(RVA = "0x5C2C60", Offset = "0x5C1260", VA = "0x1805C2C60", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		GameAPP.PlaySound(53, 0.5f, 1f);
	}

	// Token: 0x060021FC RID: 8700 RVA: 0x000B2DC8 File Offset: 0x000B0FC8
	[Token(Token = "0x60021FC")]
	[Address(RVA = "0x5C2410", Offset = "0x5C0A10", VA = "0x1805C2410", Slot = "76")]
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

	// Token: 0x060021FD RID: 8701 RVA: 0x000B2FA4 File Offset: 0x000B11A4
	[Token(Token = "0x60021FD")]
	[Address(RVA = "0x5C2360", Offset = "0x5C0960", VA = "0x1805C2360", Slot = "18")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Board board = this.board;
		Transform axis = this.axis;
		this.uniqueSpeed = 1f;
	}

	// Token: 0x060021FE RID: 8702 RVA: 0x000B2FF8 File Offset: 0x000B11F8
	[Token(Token = "0x60021FE")]
	[Address(RVA = "0x5C19D0", Offset = "0x5BFFD0", VA = "0x1805C19D0", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		long num = this.theHealth;
		num -= (long)theDamage;
		this.theHealth = num;
		int num2 = 0;
		float num3;
		float num4;
		if (!global::Core.Lawnf.ValueBetween(num3, (float)num2, num4))
		{
			int num5 = 0;
			float num6;
			if (num6 > (float)num5)
			{
				Transform transform = base.transform;
				int num7 = 0;
				GameObject gameObject = transform.GetChild(num7).gameObject;
				int num8 = 0;
				gameObject.SetActive(num8 != 0);
				uint num9;
				GameObject gameObject2 = base.transform.GetChild((int)num9).gameObject;
				int num10 = 0;
				gameObject2.SetActive(num10 != 0);
				uint num11;
				ulong num12;
				base.transform.GetChild((int)num11).gameObject.SetActive(num12 != 0UL);
			}
			return;
		}
		Transform transform2 = base.transform;
		int num13 = 0;
		GameObject gameObject3 = transform2.GetChild(num13).gameObject;
		int num14 = 0;
		gameObject3.SetActive(num14 != 0);
		uint num15;
		ulong num16;
		base.transform.GetChild((int)num15).gameObject.SetActive(num16 != 0UL);
		uint num17;
		GameObject gameObject4 = base.transform.GetChild((int)num17).gameObject;
		throw new NullReferenceException();
	}

	// Token: 0x060021FF RID: 8703 RVA: 0x000B30E8 File Offset: 0x000B12E8
	[Token(Token = "0x60021FF")]
	[Address(RVA = "0x58EA00", Offset = "0x58D000", VA = "0x18058EA00", Slot = "28")]
	public override void Die(int reason = 0)
	{
		base.Die(reason);
	}

	// Token: 0x06002200 RID: 8704 RVA: 0x000B30FC File Offset: 0x000B12FC
	[Token(Token = "0x6002200")]
	[Address(RVA = "0x5C2890", Offset = "0x5C0E90", VA = "0x1805C2890", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
		base.KnockBack(x, reason);
		if (reason == Zombie.KnockBackReason.ByUmbrella)
		{
			this.theOriginSpeed = (float)reason;
		}
	}

	// Token: 0x06002201 RID: 8705 RVA: 0x000B3120 File Offset: 0x000B1320
	[Token(Token = "0x6002201")]
	[Address(RVA = "0x5C1C60", Offset = "0x5C0260", VA = "0x1805C1C60", Slot = "29")]
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

	// Token: 0x06002202 RID: 8706 RVA: 0x000B32C8 File Offset: 0x000B14C8
	[Token(Token = "0x6002202")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = false)
	{
	}

	// Token: 0x06002203 RID: 8707 RVA: 0x000B32D8 File Offset: 0x000B14D8
	[Token(Token = "0x6002203")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "54")]
	public override void SetPoison(float time = 10f)
	{
	}

	// Token: 0x06002204 RID: 8708 RVA: 0x000B32E8 File Offset: 0x000B14E8
	[Token(Token = "0x6002204")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "61")]
	public override void Garliced(bool playSound = false, bool certainRow = false)
	{
	}

	// Token: 0x06002205 RID: 8709 RVA: 0x000B32F8 File Offset: 0x000B14F8
	[Token(Token = "0x6002205")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "55")]
	public override void AddPoisonLevel()
	{
	}

	// Token: 0x06002206 RID: 8710 RVA: 0x000B3308 File Offset: 0x000B1508
	[Token(Token = "0x6002206")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "60")]
	public override void EatGarlic(Plant plant, float time = 1f, bool withSound = true)
	{
	}

	// Token: 0x06002207 RID: 8711 RVA: 0x000B3318 File Offset: 0x000B1518
	[Token(Token = "0x6002207")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002208 RID: 8712 RVA: 0x000B3328 File Offset: 0x000B1528
	[Token(Token = "0x6002208")]
	[Address(RVA = "0x5C28C0", Offset = "0x5C0EC0", VA = "0x1805C28C0")]
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

	// Token: 0x06002209 RID: 8713 RVA: 0x000B33F4 File Offset: 0x000B15F4
	[Token(Token = "0x6002209")]
	[Address(RVA = "0x5C2CE0", Offset = "0x5C12E0", VA = "0x1805C2CE0")]
	public MachineNutZombie()
	{
	}

	// Token: 0x040011B4 RID: 4532
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40011B4")]
	private MachineNutZombie.MachineType machineType;

	// Token: 0x020006D6 RID: 1750
	[Token(Token = "0x20006D6")]
	private enum MachineType
	{
		// Token: 0x040011B6 RID: 4534
		[Token(Token = "0x40011B6")]
		Default,
		// Token: 0x040011B7 RID: 4535
		[Token(Token = "0x40011B7")]
		Red,
		// Token: 0x040011B8 RID: 4536
		[Token(Token = "0x40011B8")]
		Blue
	}
}
