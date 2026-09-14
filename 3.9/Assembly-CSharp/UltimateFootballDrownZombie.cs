using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200072D RID: 1837
[Token(Token = "0x200072D")]
public class UltimateFootballDrownZombie : FootballDrown
{
	// Token: 0x06002465 RID: 9317 RVA: 0x000BD7E0 File Offset: 0x000BB9E0
	[Token(Token = "0x6002465")]
	[Address(RVA = "0x5FD190", Offset = "0x5FB790", VA = "0x1805FD190", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 1.5f;
	}

	// Token: 0x06002466 RID: 9318 RVA: 0x000BD800 File Offset: 0x000BBA00
	[Token(Token = "0x6002466")]
	[Address(RVA = "0x5FCE90", Offset = "0x5FB490", VA = "0x1805FCE90", Slot = "24")]
	protected override void AttributeEvent()
	{
		int num;
		do
		{
			List<KeyValuePair<int, Zombie>> list = Enumerable.ToList<KeyValuePair<int, Zombie>>(this.zombies);
			num = 0;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				bool flag2;
				while (!flag2)
				{
				}
				ulong num3;
				Zombie zombie = CreateZombie.Instance.SetZombie(num2, (ZombieType)((uint)202), 9.9f, num3 != 0UL);
				int num4 = 0;
				if (!(zombie != num4))
				{
					bool flag3 = this.zombies.Remove(num4);
				}
				this.board.SetHealthInTravel(zombie);
				Dictionary<int, Zombie> dictionary = this.zombies;
			}
		}
		while (num != 0);
	}

	// Token: 0x06002467 RID: 9319 RVA: 0x000BD89C File Offset: 0x000BBA9C
	[Token(Token = "0x6002467")]
	[Address(RVA = "0x5FD410", Offset = "0x5FBA10", VA = "0x1805FD410", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		int num = global::UnityEngine.Random.Range(2, (int)6E-45f);
		Board board = this.board;
		Lawnf.SetZombieHealth(this, 6E-45f);
		Board board2 = this.board;
		int num2 = 0;
		if (num2 < board2.rowNum)
		{
			Dictionary<int, Zombie> dictionary = this.zombies;
			int num3 = 0;
			dictionary[num2] = num3;
			Board board3 = this.board;
			num2++;
		}
	}

	// Token: 0x06002468 RID: 9320 RVA: 0x000BD908 File Offset: 0x000BBB08
	[Token(Token = "0x6002468")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
	}

	// Token: 0x06002469 RID: 9321 RVA: 0x000BD918 File Offset: 0x000BBB18
	[Token(Token = "0x6002469")]
	[Address(RVA = "0x5FD1B0", Offset = "0x5FB7B0", VA = "0x1805FD1B0", Slot = "76")]
	protected override DrownProjectile GetDrownWeapon()
	{
		global::UnityEngine.Object.Destroy(this.w);
		Transform transform = base.transform.Find("Shoot");
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = this.weapon;
		Transform transform2 = this.board.transform;
		GameObject gameObject2;
		SortingGroup component = gameObject2.GetComponent<SortingGroup>();
		int theZombieRow = this.theZombieRow;
		string text = string.Format("bullet{0}", component);
		component.sortingLayerName = text;
		DrownProjectile drownProjectile = gameObject2.AddComponent<DrownProjectile>();
		int theZombieRow2 = this.theZombieRow;
		drownProjectile.theRow = theZombieRow2;
		drownProjectile.big = true;
		drownProjectile.horizontal = true;
		return drownProjectile;
	}

	// Token: 0x0600246A RID: 9322 RVA: 0x000BD9BC File Offset: 0x000BBBBC
	[Token(Token = "0x600246A")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x0600246B RID: 9323 RVA: 0x000BD9CC File Offset: 0x000BBBCC
	[Token(Token = "0x600246B")]
	[Address(RVA = "0x5A9160", Offset = "0x5A7760", VA = "0x1805A9160", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		long num;
		return num;
	}

	// Token: 0x0600246C RID: 9324 RVA: 0x000BD9E0 File Offset: 0x000BBBE0
	[Token(Token = "0x600246C")]
	[Address(RVA = "0x5A9020", Offset = "0x5A7620", VA = "0x1805A9020", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x0600246D RID: 9325 RVA: 0x000BD9F0 File Offset: 0x000BBBF0
	[Token(Token = "0x600246D")]
	[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
	public UltimateFootballDrownZombie()
	{
		Dictionary<int, Zombie> dictionary = new Dictionary();
		this.zombies = dictionary;
		base..ctor();
	}

	// Token: 0x04001248 RID: 4680
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001248")]
	public GameObject weapon;

	// Token: 0x04001249 RID: 4681
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4001249")]
	public GameObject w;

	// Token: 0x0400124A RID: 4682
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x400124A")]
	private readonly Dictionary<int, Zombie> zombies;
}
