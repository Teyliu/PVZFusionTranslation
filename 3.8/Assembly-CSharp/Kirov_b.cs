using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000695 RID: 1685
[Token(Token = "0x2000695")]
public class Kirov_b : Kirov_a
{
	// Token: 0x17000162 RID: 354
	// (get) Token: 0x060020A1 RID: 8353 RVA: 0x000ACA20 File Offset: 0x000AAC20
	[Token(Token = "0x17000162")]
	public override float CrashNeedCount
	{
		[Token(Token = "0x60020A1")]
		[Address(RVA = "0x55AE40", Offset = "0x559440", VA = "0x18055AE40", Slot = "78")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060020A2 RID: 8354 RVA: 0x000ACA34 File Offset: 0x000AAC34
	[Token(Token = "0x60020A2")]
	[Address(RVA = "0x55AD70", Offset = "0x559370", VA = "0x18055AD70", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)10L);
		this.attributeCountDown = 3f;
	}

	// Token: 0x060020A3 RID: 8355 RVA: 0x000ACA5C File Offset: 0x000AAC5C
	[Token(Token = "0x60020A3")]
	[Address(RVA = "0x55ADA0", Offset = "0x5593A0", VA = "0x18055ADA0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.SetTrigger("Start");
	}

	// Token: 0x060020A4 RID: 8356 RVA: 0x000ACA88 File Offset: 0x000AAC88
	[Token(Token = "0x60020A4")]
	[Address(RVA = "0x55AB90", Offset = "0x559190", VA = "0x18055AB90")]
	private void AnimShoot()
	{
		uint num;
		uint num2;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 0.5f, 1f);
		this.attributeCountDown = 3f;
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
		Transform axis2 = this.axis;
		CreateZombie instance2 = CreateZombie.Instance;
		Zombie zombie;
		Zombie component = zombie.GetComponent<Zombie>();
	}

	// Token: 0x060020A5 RID: 8357 RVA: 0x000ACAE4 File Offset: 0x000AACE4
	[Token(Token = "0x60020A5")]
	[Address(RVA = "0x55AB10", Offset = "0x559110", VA = "0x18055AB10")]
	public Kirov_b()
	{
	}
}
