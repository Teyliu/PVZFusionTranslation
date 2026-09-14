using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006CC RID: 1740
[Token(Token = "0x20006CC")]
public class Kirov_b : Kirov_a
{
	// Token: 0x170001A8 RID: 424
	// (get) Token: 0x060021B8 RID: 8632 RVA: 0x000B1668 File Offset: 0x000AF868
	[Token(Token = "0x170001A8")]
	public override float CrashNeedCount
	{
		[Token(Token = "0x60021B8")]
		[Address(RVA = "0x5BDB90", Offset = "0x5BC190", VA = "0x1805BDB90", Slot = "80")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060021B9 RID: 8633 RVA: 0x000B167C File Offset: 0x000AF87C
	[Token(Token = "0x60021B9")]
	[Address(RVA = "0x5BDAC0", Offset = "0x5BC0C0", VA = "0x1805BDAC0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)10L);
		this.attributeCountDown = 3f;
	}

	// Token: 0x060021BA RID: 8634 RVA: 0x000B16A4 File Offset: 0x000AF8A4
	[Token(Token = "0x60021BA")]
	[Address(RVA = "0x5BDAF0", Offset = "0x5BC0F0", VA = "0x1805BDAF0", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		this.anim.SetTrigger("Start");
	}

	// Token: 0x060021BB RID: 8635 RVA: 0x000B16D0 File Offset: 0x000AF8D0
	[Token(Token = "0x60021BB")]
	[Address(RVA = "0x5BD8D0", Offset = "0x5BBED0", VA = "0x1805BD8D0")]
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

	// Token: 0x060021BC RID: 8636 RVA: 0x000B172C File Offset: 0x000AF92C
	[Token(Token = "0x60021BC")]
	[Address(RVA = "0x5BD850", Offset = "0x5BBE50", VA = "0x1805BD850")]
	public Kirov_b()
	{
	}
}
