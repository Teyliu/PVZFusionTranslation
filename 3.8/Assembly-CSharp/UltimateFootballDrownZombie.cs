using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020006F5 RID: 1781
[Token(Token = "0x20006F5")]
public class UltimateFootballDrownZombie : FootballDrown
{
	// Token: 0x06002349 RID: 9033 RVA: 0x000B8994 File Offset: 0x000B6B94
	[Token(Token = "0x6002349")]
	[Address(RVA = "0x5814F0", Offset = "0x57FAF0", VA = "0x1805814F0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 1.5f;
	}

	// Token: 0x0600234A RID: 9034 RVA: 0x000B89B4 File Offset: 0x000B6BB4
	[Token(Token = "0x600234A")]
	[Address(RVA = "0x5811F0", Offset = "0x57F7F0", VA = "0x1805811F0", Slot = "23")]
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

	// Token: 0x0600234B RID: 9035 RVA: 0x000B8A50 File Offset: 0x000B6C50
	[Token(Token = "0x600234B")]
	[Address(RVA = "0x581770", Offset = "0x57FD70", VA = "0x180581770", Slot = "15")]
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

	// Token: 0x0600234C RID: 9036 RVA: 0x000B8ABC File Offset: 0x000B6CBC
	[Token(Token = "0x600234C")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
	}

	// Token: 0x0600234D RID: 9037 RVA: 0x000B8ACC File Offset: 0x000B6CCC
	[Token(Token = "0x600234D")]
	[Address(RVA = "0x581510", Offset = "0x57FB10", VA = "0x180581510", Slot = "74")]
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

	// Token: 0x0600234E RID: 9038 RVA: 0x000B8B70 File Offset: 0x000B6D70
	[Token(Token = "0x600234E")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x0600234F RID: 9039 RVA: 0x000B8B80 File Offset: 0x000B6D80
	[Token(Token = "0x600234F")]
	[Address(RVA = "0x546F50", Offset = "0x545550", VA = "0x180546F50", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		int num;
		if (num > 5000)
		{
		}
		return num;
	}

	// Token: 0x06002350 RID: 9040 RVA: 0x000B8B9C File Offset: 0x000B6D9C
	[Token(Token = "0x6002350")]
	[Address(RVA = "0x546D50", Offset = "0x545350", VA = "0x180546D50", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06002351 RID: 9041 RVA: 0x000B8BAC File Offset: 0x000B6DAC
	[Token(Token = "0x6002351")]
	[Address(RVA = "0x581840", Offset = "0x57FE40", VA = "0x180581840")]
	public UltimateFootballDrownZombie()
	{
		Dictionary<int, Zombie> dictionary = new Dictionary();
		this.zombies = dictionary;
		base..ctor();
	}

	// Token: 0x0400117B RID: 4475
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400117B")]
	public GameObject weapon;

	// Token: 0x0400117C RID: 4476
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x400117C")]
	public GameObject w;

	// Token: 0x0400117D RID: 4477
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x400117D")]
	private readonly Dictionary<int, Zombie> zombies;
}
