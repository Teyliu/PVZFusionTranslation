using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x02000346 RID: 838
[Token(Token = "0x2000346")]
public class BigWallNut : Plant
{
	// Token: 0x06000F61 RID: 3937 RVA: 0x00059784 File Offset: 0x00057984
	[Token(Token = "0x6000F61")]
	[Address(RVA = "0x41AF60", Offset = "0x419560", VA = "0x18041AF60", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (PlantStatus)((ulong)27L);
	}

	// Token: 0x06000F62 RID: 3938 RVA: 0x000597A4 File Offset: 0x000579A4
	[Token(Token = "0x6000F62")]
	[Address(RVA = "0x41B930", Offset = "0x419F30", VA = "0x18041B930", Slot = "15")]
	protected override void Start()
	{
		Board board = this.board;
		RoofEntity roofEntity = this.AddComponent<RoofEntity>();
		int thePlantRow = this.thePlantRow;
		roofEntity.entityRow = thePlantRow;
		throw new NullReferenceException();
	}

	// Token: 0x06000F63 RID: 3939 RVA: 0x000597D4 File Offset: 0x000579D4
	[Token(Token = "0x6000F63")]
	[Address(RVA = "0x41B8A0", Offset = "0x419EA0", VA = "0x18041B8A0", Slot = "69")]
	protected virtual void Round()
	{
		GameAPP.PlaySound(53, 0.5f, 1f);
		this.anim.Play("Round");
	}

	// Token: 0x06000F64 RID: 3940 RVA: 0x00059808 File Offset: 0x00057A08
	[Token(Token = "0x6000F64")]
	[Address(RVA = "0x41AF80", Offset = "0x419580", VA = "0x18041AF80", Slot = "17")]
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

	// Token: 0x06000F65 RID: 3941 RVA: 0x0005985C File Offset: 0x00057A5C
	[Token(Token = "0x6000F65")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "33")]
	protected override bool Instead(int theDamage)
	{
		return false;
	}

	// Token: 0x06000F66 RID: 3942 RVA: 0x0005986C File Offset: 0x00057A6C
	[Token(Token = "0x6000F66")]
	[Address(RVA = "0x41B9B0", Offset = "0x419FB0", VA = "0x18041B9B0", Slot = "16")]
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

	// Token: 0x06000F67 RID: 3943 RVA: 0x000598A8 File Offset: 0x00057AA8
	[Token(Token = "0x6000F67")]
	[Address(RVA = "0x41B090", Offset = "0x419690", VA = "0x18041B090")]
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
				if (num == 260)
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

	// Token: 0x06000F68 RID: 3944 RVA: 0x0005992C File Offset: 0x00057B2C
	[Token(Token = "0x6000F68")]
	[Address(RVA = "0x41B3A0", Offset = "0x4199A0", VA = "0x18041B3A0")]
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
				if (collision != (ulong)260L)
				{
					goto IL_0054;
				}
			}
			while (collision == (ulong)4294967293L)
			{
			}
			IL_0054:
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

	// Token: 0x06000F69 RID: 3945 RVA: 0x00059A44 File Offset: 0x00057C44
	[Token(Token = "0x6000F69")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "35")]
	public override void Crashed(int type = 0, int soundid = 0, [Optional] Zombie zombie)
	{
	}

	// Token: 0x06000F6A RID: 3946 RVA: 0x00059A54 File Offset: 0x00057C54
	[Token(Token = "0x6000F6A")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x00059A64 File Offset: 0x00057C64
	[Token(Token = "0x6000F6B")]
	[Address(RVA = "0x41AEE0", Offset = "0x4194E0", VA = "0x18041AEE0")]
	public BigWallNut()
	{
		List<BigWallNut.DamageZombie> list = new List();
		this.damageZombies = list;
		base..ctor();
	}

	// Token: 0x04000B43 RID: 2883
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B43")]
	private readonly List<BigWallNut.DamageZombie> damageZombies;

	// Token: 0x04000B44 RID: 2884
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000B44")]
	public bool ulti;

	// Token: 0x04000B45 RID: 2885
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x221")]
	[Token(Token = "0x4000B45")]
	public bool jala;

	// Token: 0x04000B46 RID: 2886
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000B46")]
	public Action<Zombie> onCrash;

	// Token: 0x02000347 RID: 839
	[Token(Token = "0x2000347")]
	public struct DamageZombie
	{
		// Token: 0x04000B47 RID: 2887
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B47")]
		public Zombie Zombie;

		// Token: 0x04000B48 RID: 2888
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000B48")]
		public int dmg;
	}
}
