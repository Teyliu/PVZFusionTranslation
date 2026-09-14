using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000290 RID: 656
[Token(Token = "0x2000290")]
public class LawnShooter : Mower
{
	// Token: 0x06000BD6 RID: 3030 RVA: 0x000439A8 File Offset: 0x00041BA8
	[Token(Token = "0x6000BD6")]
	[Address(RVA = "0x423750", Offset = "0x421D50", VA = "0x180423750")]
	private void Start()
	{
		if (RogueManager.Instance.leaderType == LeaderType.UltimateGatling)
		{
			if (this.board.theCurrentSurvivalRound > 1)
			{
				int num = this.attackDamage;
				num += -450;
				long num2;
				num2 += (long)num;
				this.attackDamage = (int)num2;
			}
			this.shootRange = (int)((ulong)10L);
		}
	}

	// Token: 0x06000BD7 RID: 3031 RVA: 0x00043A00 File Offset: 0x00041C00
	[Token(Token = "0x6000BD7")]
	[Address(RVA = "0x423470", Offset = "0x421A70", VA = "0x180423470")]
	public void SetEffect()
	{
		if (this.board.theCurrentSurvivalRound > 1)
		{
			int num = this.attackDamage;
			num += -450;
			long num2;
			num2 += (long)num;
			this.attackDamage = (int)num2;
		}
		this.shootRange = (int)((ulong)10L);
	}

	// Token: 0x06000BD8 RID: 3032 RVA: 0x00043A48 File Offset: 0x00041C48
	[Token(Token = "0x6000BD8")]
	[Address(RVA = "0x4237B0", Offset = "0x421DB0", VA = "0x1804237B0", Slot = "5")]
	protected override void Update()
	{
		base.Update();
		bool flag = Lawnf.TravelAdvanced((AdvBuff)((uint)6000));
		float num = this.timer;
		if (!flag)
		{
			float deltaTime = Time.deltaTime;
		}
		float deltaTime2 = Time.deltaTime;
		int num2 = 0;
		this.timer = num;
		if (num2 > (int)num)
		{
			this.timer = 6f;
			if (this.Shootable())
			{
				this.anim.SetTrigger("shoot");
				return;
			}
		}
	}

	// Token: 0x06000BD9 RID: 3033 RVA: 0x00043ABC File Offset: 0x00041CBC
	[Token(Token = "0x6000BD9")]
	[Address(RVA = "0x4234B0", Offset = "0x421AB0", VA = "0x1804234B0")]
	private void ShootUpdate()
	{
		bool flag = Lawnf.TravelAdvanced((AdvBuff)((uint)6000));
		float num = this.timer;
		if (!flag)
		{
			float deltaTime = Time.deltaTime;
		}
		float deltaTime2 = Time.deltaTime;
		int num2 = 0;
		this.timer = num;
		if (num2 > (int)num)
		{
			this.timer = 6f;
			if (this.Shootable())
			{
				this.anim.SetTrigger("shoot");
			}
		}
	}

	// Token: 0x06000BDA RID: 3034 RVA: 0x00043B2C File Offset: 0x00041D2C
	[Token(Token = "0x6000BDA")]
	[Address(RVA = "0x423420", Offset = "0x421A20", VA = "0x180423420", Slot = "6")]
	protected override void AttackZombie(Zombie zombie)
	{
	}

	// Token: 0x06000BDB RID: 3035 RVA: 0x00043B40 File Offset: 0x00041D40
	[Token(Token = "0x6000BDB")]
	[Address(RVA = "0x423560", Offset = "0x421B60", VA = "0x180423560")]
	private bool Shootable()
	{
		int num = 0;
		Transform transform = this.shoot;
		Transform transform2 = this.shoot;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && Lawnf.InLandStatus((ZombieStatus)num))
			{
				int theMowerRow = this.theMowerRow;
			}
			num++;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000BDC RID: 3036 RVA: 0x00043B98 File Offset: 0x00041D98
	[Token(Token = "0x6000BDC")]
	[Address(RVA = "0x4232E0", Offset = "0x4218E0", VA = "0x1804232E0")]
	private void AnimShoot()
	{
		CreateBullet instance = CreateBullet.Instance;
		Transform transform = this.shoot;
		Transform transform2 = this.shoot;
		int num = 0;
		if (!Lawnf.TravelAdvanced((AdvBuff)((uint)6000)))
		{
		}
		int num2 = this.attackDamage;
		Bullet bullet;
		bullet.Damage = num;
		GameAPP.PlaySound(num2, 0.5f, 1f);
	}

	// Token: 0x06000BDD RID: 3037 RVA: 0x00043BF8 File Offset: 0x00041DF8
	[Token(Token = "0x6000BDD")]
	[Address(RVA = "0x4238C0", Offset = "0x421EC0", VA = "0x1804238C0")]
	public LawnShooter()
	{
		this.speed = 5f;
		base..ctor();
	}

	// Token: 0x040007D5 RID: 2005
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40007D5")]
	private float timer;

	// Token: 0x040007D6 RID: 2006
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40007D6")]
	public Transform shoot;

	// Token: 0x040007D7 RID: 2007
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40007D7")]
	private int attackDamage = (int)((ulong)300L);

	// Token: 0x040007D8 RID: 2008
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40007D8")]
	private int shootRange = (int)((ulong)8L);
}
