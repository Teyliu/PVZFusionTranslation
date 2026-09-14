using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200028A RID: 650
[Token(Token = "0x200028A")]
public class LawnShooter : Mower
{
	// Token: 0x06000BBA RID: 3002 RVA: 0x00043B3C File Offset: 0x00041D3C
	[Token(Token = "0x6000BBA")]
	[Address(RVA = "0x3D6000", Offset = "0x3D4600", VA = "0x1803D6000")]
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

	// Token: 0x06000BBB RID: 3003 RVA: 0x00043B94 File Offset: 0x00041D94
	[Token(Token = "0x6000BBB")]
	[Address(RVA = "0x3D5D20", Offset = "0x3D4320", VA = "0x1803D5D20")]
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

	// Token: 0x06000BBC RID: 3004 RVA: 0x00043BDC File Offset: 0x00041DDC
	[Token(Token = "0x6000BBC")]
	[Address(RVA = "0x3D6060", Offset = "0x3D4660", VA = "0x1803D6060", Slot = "5")]
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

	// Token: 0x06000BBD RID: 3005 RVA: 0x00043C50 File Offset: 0x00041E50
	[Token(Token = "0x6000BBD")]
	[Address(RVA = "0x3D5D60", Offset = "0x3D4360", VA = "0x1803D5D60")]
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

	// Token: 0x06000BBE RID: 3006 RVA: 0x00043CC0 File Offset: 0x00041EC0
	[Token(Token = "0x6000BBE")]
	[Address(RVA = "0x3D5CD0", Offset = "0x3D42D0", VA = "0x1803D5CD0", Slot = "6")]
	protected override void AttackZombie(Zombie zombie)
	{
	}

	// Token: 0x06000BBF RID: 3007 RVA: 0x00043CD4 File Offset: 0x00041ED4
	[Token(Token = "0x6000BBF")]
	[Address(RVA = "0x3D5E10", Offset = "0x3D4410", VA = "0x1803D5E10")]
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

	// Token: 0x06000BC0 RID: 3008 RVA: 0x00043D2C File Offset: 0x00041F2C
	[Token(Token = "0x6000BC0")]
	[Address(RVA = "0x3D5B90", Offset = "0x3D4190", VA = "0x1803D5B90")]
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

	// Token: 0x06000BC1 RID: 3009 RVA: 0x00043D8C File Offset: 0x00041F8C
	[Token(Token = "0x6000BC1")]
	[Address(RVA = "0x3D6170", Offset = "0x3D4770", VA = "0x1803D6170")]
	public LawnShooter()
	{
		this.speed = 5f;
		base..ctor();
	}

	// Token: 0x040007C9 RID: 1993
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40007C9")]
	private float timer;

	// Token: 0x040007CA RID: 1994
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40007CA")]
	public Transform shoot;

	// Token: 0x040007CB RID: 1995
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40007CB")]
	private int attackDamage = (int)((ulong)300L);

	// Token: 0x040007CC RID: 1996
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40007CC")]
	private int shootRange = (int)((ulong)8L);
}
