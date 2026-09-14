using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000662 RID: 1634
[Token(Token = "0x2000662")]
public class BlackHorse : SuperHorse
{
	// Token: 0x06001EEB RID: 7915 RVA: 0x000A4988 File Offset: 0x000A2B88
	[Token(Token = "0x6001EEB")]
	[Address(RVA = "0x588A80", Offset = "0x587080", VA = "0x180588A80", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)43L);
	}

	// Token: 0x06001EEC RID: 7916 RVA: 0x000A49A8 File Offset: 0x000A2BA8
	[Token(Token = "0x6001EEC")]
	[Address(RVA = "0x588E40", Offset = "0x587440", VA = "0x180588E40", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("run");
	}

	// Token: 0x06001EED RID: 7917 RVA: 0x000A49D4 File Offset: 0x000A2BD4
	[Token(Token = "0x6001EED")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06001EEE RID: 7918 RVA: 0x000A49E4 File Offset: 0x000A2BE4
	[Token(Token = "0x6001EEE")]
	[Address(RVA = "0x588D20", Offset = "0x587320", VA = "0x180588D20", Slot = "78")]
	protected override void ReviveZombie()
	{
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
		int num = 0;
		Transform child = axis.GetChild(num);
		int num2 = 0;
		Zombie zombie;
		if (zombie != num2)
		{
			long theMaxHealth = this.theMaxHealth;
			zombie.theHealth = theMaxHealth;
			long theMaxHealth2 = this.theMaxHealth;
			zombie.theMaxHealth = theMaxHealth2;
		}
	}

	// Token: 0x06001EEF RID: 7919 RVA: 0x000A4A40 File Offset: 0x000A2C40
	[Token(Token = "0x6001EEF")]
	[Address(RVA = "0x588AA0", Offset = "0x5870A0", VA = "0x180588AA0", Slot = "68")]
	protected override Plant CrashEntity(Collider2D collision, bool inWater = false, float knockBack = 1f)
	{
		Plant plant = base.CrashEntity(collision, inWater, knockBack);
		int num = 0;
		if (plant != num)
		{
			bool flag = plant.SetEffect((EffectType)((uint)103), 1f, 1f);
		}
		return plant;
	}

	// Token: 0x06001EF0 RID: 7920 RVA: 0x000A4AF0 File Offset: 0x000A2CF0
	[Token(Token = "0x6001EF0")]
	[Address(RVA = "0x588EA0", Offset = "0x5874A0", VA = "0x180588EA0")]
	public BlackHorse()
	{
	}
}
