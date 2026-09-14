using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x02000356 RID: 854
[Token(Token = "0x2000356")]
public class BigWallNut : Plant
{
	// Token: 0x06000FAD RID: 4013 RVA: 0x0005A6E4 File Offset: 0x000588E4
	[Token(Token = "0x6000FAD")]
	[Address(RVA = "0x471E00", Offset = "0x470400", VA = "0x180471E00", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (PlantStatus)((ulong)27L);
	}

	// Token: 0x06000FAE RID: 4014 RVA: 0x0005A704 File Offset: 0x00058904
	[Token(Token = "0x6000FAE")]
	[Address(RVA = "0x4727D0", Offset = "0x470DD0", VA = "0x1804727D0", Slot = "15")]
	protected override void Start()
	{
		Board board = this.board;
		RoofEntity roofEntity = this.AddComponent<RoofEntity>();
		int thePlantRow = this.thePlantRow;
		roofEntity.entityRow = thePlantRow;
		throw new NullReferenceException();
	}

	// Token: 0x06000FAF RID: 4015 RVA: 0x0005A734 File Offset: 0x00058934
	[Token(Token = "0x6000FAF")]
	[Address(RVA = "0x472740", Offset = "0x470D40", VA = "0x180472740", Slot = "68")]
	protected virtual void Round()
	{
		GameAPP.PlaySound(53, 0.5f, 1f);
		this.anim.Play("Round");
	}

	// Token: 0x06000FB0 RID: 4016 RVA: 0x0005A768 File Offset: 0x00058968
	[Token(Token = "0x6000FB0")]
	[Address(RVA = "0x471E20", Offset = "0x470420", VA = "0x180471E20", Slot = "17")]
	protected override void FixedUpdate()
	{
		Transform axis = this.axis;
		float boardMaxX = this.board.boardMaxX;
		int num = 0;
		base.Die((Plant.DieReason)num);
		List<BigWallNut.DamageZombie> list = this.damageZombies;
		int num2 = 0;
		List<BigWallNut.DamageZombie> list2 = this.damageZombies;
		List<BigWallNut.DamageZombie> list3 = this.damageZombies;
		num2++;
	}

	// Token: 0x06000FB1 RID: 4017 RVA: 0x0005A7BC File Offset: 0x000589BC
	[Token(Token = "0x6000FB1")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "32")]
	protected override bool Instead(int theDamage)
	{
		return false;
	}

	// Token: 0x06000FB2 RID: 4018 RVA: 0x0005A7CC File Offset: 0x000589CC
	[Token(Token = "0x6000FB2")]
	[Address(RVA = "0x472850", Offset = "0x470E50", VA = "0x180472850", Slot = "16")]
	protected override void Update()
	{
		float attributeCountdown = this.attributeCountdown;
		int num = 0;
		if (attributeCountdown > (float)num)
		{
			float deltaTime = Time.deltaTime;
			base.AttributeCountdown = attributeCountdown;
			int num2 = 0;
			base.AttributeCountdown = (float)num2;
			base.AttributeEvent();
		}
	}

	// Token: 0x06000FB3 RID: 4019 RVA: 0x0005A808 File Offset: 0x00058A08
	[Token(Token = "0x6000FB3")]
	[Address(RVA = "0x471F30", Offset = "0x470530", VA = "0x180471F30")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		bool flag = collision.TryGetComponent<Zombie>(num);
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			if (collision > (ulong)12L)
			{
				if (thePlantRow <= 4 || collision == (ulong)44L)
				{
					return;
				}
			}
			else
			{
				while (flag)
				{
				}
			}
			if (thePlantRow > 46)
			{
				if (thePlantRow == 228)
				{
					return;
				}
				while (num == 231)
				{
				}
				num += -260;
				if (num <= 1)
				{
					return;
				}
			}
			else
			{
				num += -44;
				while (num == -3)
				{
				}
			}
			CreateItem instance = CreateItem.Instance;
			Vector3 vector;
			float z = vector.z;
			ScreenShake.TriggerShake(0.02f);
			return;
		}
	}

	// Token: 0x06000FB4 RID: 4020 RVA: 0x0005A890 File Offset: 0x00058A90
	[Token(Token = "0x6000FB4")]
	[Address(RVA = "0x472240", Offset = "0x470840", VA = "0x180472240")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		bool flag;
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			if (collision > (ulong)12L)
			{
				if (thePlantRow <= 4 || collision == (ulong)44L)
				{
					return;
				}
			}
			else
			{
				while (flag)
				{
				}
			}
			if (thePlantRow > 46)
			{
				if (thePlantRow == 228)
				{
				}
				while (collision == (ulong)231L)
				{
				}
				if (collision > (ulong)1L)
				{
					goto IL_0050;
				}
			}
			while (collision == (ulong)4294967293L)
			{
			}
			IL_0050:
			if ((this.ulti ? 1 : 0) != num)
			{
				Animator anim = this.anim;
				if ((this.jala ? 1 : 0) == num)
				{
					float deltaTime = Time.deltaTime;
					float fixedDeltaTime = Time.fixedDeltaTime;
				}
				float deltaTime2 = Time.deltaTime;
				float fixedDeltaTime2 = Time.fixedDeltaTime;
			}
			int num2 = this.attackDamage;
			bool flag2;
			if ((this.jala ? 1 : 0) != num && flag2)
			{
				num2 += num2;
			}
			PlantType thePlantType = this.thePlantType;
			if (this.onCrash != 0)
			{
			}
			List<BigWallNut.DamageZombie> list = this.damageZombies;
			List<BigWallNut.DamageZombie> list2 = this.damageZombies;
			List<BigWallNut.DamageZombie> list3 = this.damageZombies;
			bool flag3;
			if (!flag3)
			{
				num++;
			}
			List<BigWallNut.DamageZombie> list4 = this.damageZombies;
			num += num2;
			list4[num] = num;
			int size = list4._size;
			throw new NullReferenceException();
		}
	}

	// Token: 0x06000FB5 RID: 4021 RVA: 0x0005A9A4 File Offset: 0x00058BA4
	[Token(Token = "0x6000FB5")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "34")]
	public override void Crashed(int type = 0, int soundid = 0, [Optional] Zombie zombie)
	{
	}

	// Token: 0x06000FB6 RID: 4022 RVA: 0x0005A9B4 File Offset: 0x00058BB4
	[Token(Token = "0x6000FB6")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000FB7 RID: 4023 RVA: 0x0005A9C4 File Offset: 0x00058BC4
	[Token(Token = "0x6000FB7")]
	[Address(RVA = "0x471D80", Offset = "0x470380", VA = "0x180471D80")]
	public BigWallNut()
	{
		List<BigWallNut.DamageZombie> list = new List();
		this.damageZombies = list;
		base..ctor();
	}

	// Token: 0x04000B94 RID: 2964
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B94")]
	private readonly List<BigWallNut.DamageZombie> damageZombies;

	// Token: 0x04000B95 RID: 2965
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000B95")]
	public bool ulti;

	// Token: 0x04000B96 RID: 2966
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x221")]
	[Token(Token = "0x4000B96")]
	public bool jala;

	// Token: 0x04000B97 RID: 2967
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000B97")]
	public Action<Zombie> onCrash;

	// Token: 0x02000357 RID: 855
	[Token(Token = "0x2000357")]
	public struct DamageZombie
	{
		// Token: 0x04000B98 RID: 2968
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B98")]
		public Zombie Zombie;

		// Token: 0x04000B99 RID: 2969
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000B99")]
		public int dmg;
	}
}
