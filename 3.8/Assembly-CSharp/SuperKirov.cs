using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006E0 RID: 1760
[Token(Token = "0x20006E0")]
public class SuperKirov : KirovAirship
{
	// Token: 0x17000167 RID: 359
	// (get) Token: 0x060022BE RID: 8894 RVA: 0x000B669C File Offset: 0x000B489C
	[Token(Token = "0x17000167")]
	public override float CrashNeedCount
	{
		[Token(Token = "0x60022BE")]
		[Address(RVA = "0x55AB60", Offset = "0x559160", VA = "0x18055AB60", Slot = "78")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060022BF RID: 8895 RVA: 0x000B66B0 File Offset: 0x000B48B0
	[Token(Token = "0x60022BF")]
	[Address(RVA = "0x579520", Offset = "0x577B20", VA = "0x180579520", Slot = "81")]
	protected override void CreateBomb()
	{
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)7)))
		{
			Zombie zombie;
			Lawnf.SetZombieHealth(zombie, 50f);
		}
	}

	// Token: 0x060022C0 RID: 8896 RVA: 0x000B66F8 File Offset: 0x000B48F8
	[Token(Token = "0x60022C0")]
	[Address(RVA = "0x579480", Offset = "0x577A80", VA = "0x180579480", Slot = "80")]
	protected override void BombUpdate()
	{
		this.anim.SetTrigger("throw");
		this.existBomb = false;
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
	}

	// Token: 0x060022C1 RID: 8897 RVA: 0x000B6738 File Offset: 0x000B4938
	[Token(Token = "0x60022C1")]
	[Address(RVA = "0x534110", Offset = "0x532710", VA = "0x180534110")]
	public SuperKirov()
	{
	}
}
