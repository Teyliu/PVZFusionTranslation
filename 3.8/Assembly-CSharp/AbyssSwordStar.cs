using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004BC RID: 1212
[Token(Token = "0x20004BC")]
public class AbyssSwordStar : SwordStarfruit
{
	// Token: 0x060016DE RID: 5854 RVA: 0x0007DD74 File Offset: 0x0007BF74
	[Token(Token = "0x60016DE")]
	[Address(RVA = "0x4981B0", Offset = "0x4967B0", VA = "0x1804981B0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		if (!global::Lawnf.TravelAdvanced((AdvBuff)((uint)5002)))
		{
			AbyssSwordStar instance = AbyssSwordStar.Instance;
			int num = 0;
			if (instance != num)
			{
				AbyssSwordStar instance2 = AbyssSwordStar.Instance;
				int num2 = 0;
				instance2.Die((Plant.DieReason)num2);
				InGameText instance3 = InGameText.Instance;
				int num3 = 0;
				instance3.ShowText("该植物只能存在一株", 3f, num3 != 0);
			}
			AbyssSwordStar.Instance = this;
		}
	}

	// Token: 0x060016DF RID: 5855 RVA: 0x0007DDE4 File Offset: 0x0007BFE4
	[Token(Token = "0x60016DF")]
	[Address(RVA = "0x498A60", Offset = "0x497060", VA = "0x180498A60", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		Board board = this.board;
		this.anim.Play("idle2");
	}

	// Token: 0x060016E0 RID: 5856 RVA: 0x0007DE18 File Offset: 0x0007C018
	[Token(Token = "0x60016E0")]
	[Address(RVA = "0x498690", Offset = "0x496C90", VA = "0x180498690", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.thePlantAttackCountDown = num;
		if (base.Shootable())
		{
			Board board = this.board;
			string text;
			this.anim.SetTrigger(text);
			return;
		}
	}

	// Token: 0x060016E1 RID: 5857 RVA: 0x0007DE68 File Offset: 0x0007C068
	[Token(Token = "0x60016E1")]
	[Address(RVA = "0x498780", Offset = "0x496D80", VA = "0x180498780")]
	public void SetStatus(PlantStatus plantStatus)
	{
		this.theStatus = plantStatus;
	}

	// Token: 0x060016E2 RID: 5858 RVA: 0x0007DE7C File Offset: 0x0007C07C
	[Token(Token = "0x60016E2")]
	[Address(RVA = "0x498790", Offset = "0x496D90", VA = "0x180498790")]
	private void SetSwords()
	{
		int num = this.attributeCount;
		int num2 = 0;
		num++;
		if (num > 0)
		{
			GameObject gameObject = this.bigSwordPrefab;
			float num3 = global::UnityEngine.Random.Range(-3f, 8f);
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = this.board.transform;
			GameObject gameObject2;
			BigSword component = gameObject2.GetComponent<BigSword>();
			int size = this.bigSwords._size;
			component.targetPosition = component;
			component.plant = this;
			Action<Vector2> action;
			component.action = action;
			int num4 = this.attributeCount;
			num2++;
			num4++;
		}
	}

	// Token: 0x060016E3 RID: 5859 RVA: 0x0007DF10 File Offset: 0x0007C110
	[Token(Token = "0x60016E3")]
	[Address(RVA = "0x4983D0", Offset = "0x4969D0", VA = "0x1804983D0", Slot = "18")]
	protected override void OnFixedUpdate()
	{
		int num = 0;
		int num2 = 0;
		base.OnFixedUpdate();
		Board board = this.board;
		num2 += num2;
		Transform shoot = this.shoot;
		int num3 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (!flag)
			{
				goto IL_0060;
			}
			int num4 = 0;
			if (num4 > 12)
			{
				if (18446744073709551600UL <= (ulong)8L)
				{
				}
				if (num4 != 44)
				{
					PlantType thePlantType = this.thePlantType;
					int num5 = num.System.IConvertible.ToInt32(num4);
					goto IL_0060;
				}
				goto IL_0060;
			}
			IL_0064:
			while (flag > true)
			{
			}
			return;
			IL_0060:
			num++;
			goto IL_0064;
		}
	}

	// Token: 0x060016E4 RID: 5860 RVA: 0x0007DF90 File Offset: 0x0007C190
	[Token(Token = "0x60016E4")]
	[Address(RVA = "0x498320", Offset = "0x496920", VA = "0x180498320")]
	public bool CheckStatus(Zombie zombie)
	{
		ZombieStatus theStatus = zombie.theStatus;
		if (theStatus <= ZombieStatus.Miner_digging || theStatus == ZombieStatus.Bungi_awake)
		{
			while (theStatus == ZombieStatus.Pol_jump)
			{
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060016E5 RID: 5861 RVA: 0x0007DFBC File Offset: 0x0007C1BC
	[Token(Token = "0x60016E5")]
	[Address(RVA = "0x497F70", Offset = "0x496570", VA = "0x180497F70")]
	private void AttackZombie(Vector2 position)
	{
		LayerMask zombieLayer = this.zombieLayer;
		int num = 0;
		int num2 = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				PlantType thePlantType = this.thePlantType;
			}
			num2++;
		}
		float num3 = global::UnityEngine.Random.Range(1.2f, 1.4f);
		uint num4;
		GameAPP.PlaySound((int)num4, 0.5f, num3);
		ParticleManager instance = ParticleManager.Instance;
		Mouse instance2 = Mouse.Instance;
	}

	// Token: 0x060016E6 RID: 5862 RVA: 0x0007E02C File Offset: 0x0007C22C
	[Token(Token = "0x60016E6")]
	[Address(RVA = "0x498AD0", Offset = "0x4970D0", VA = "0x180498AD0")]
	public AbyssSwordStar()
	{
		List<BigSword> list = new List();
		this.bigSwords = list;
		base..ctor();
	}

	// Token: 0x04000DA5 RID: 3493
	[Token(Token = "0x4000DA5")]
	public static AbyssSwordStar Instance;

	// Token: 0x04000DA6 RID: 3494
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000DA6")]
	private readonly List<BigSword> bigSwords;

	// Token: 0x04000DA7 RID: 3495
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000DA7")]
	public GameObject bigSwordPrefab;
}
