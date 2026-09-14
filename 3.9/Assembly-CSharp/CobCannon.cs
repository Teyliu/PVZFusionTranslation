using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200037F RID: 895
[Token(Token = "0x200037F")]
public class CobCannon : Plant
{
	// Token: 0x0600106B RID: 4203 RVA: 0x0005DE24 File Offset: 0x0005C024
	[Token(Token = "0x600106B")]
	[Address(RVA = "0x47E380", Offset = "0x47C980", VA = "0x18047E380", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		this.shoot = child;
		this.firstLoad = true;
	}

	// Token: 0x0600106C RID: 4204 RVA: 0x0005DE5C File Offset: 0x0005C05C
	[Token(Token = "0x600106C")]
	[Address(RVA = "0x47E550", Offset = "0x47CB50", VA = "0x18047E550", Slot = "15")]
	protected override void Start()
	{
		do
		{
			base.Start();
		}
		while (this.firstLoad);
		float thePlantAttackInterval = this.thePlantAttackInterval;
		base.AttributeCountdown = thePlantAttackInterval;
	}

	// Token: 0x0600106D RID: 4205 RVA: 0x0005DE88 File Offset: 0x0005C088
	[Token(Token = "0x600106D")]
	[Address(RVA = "0x47E3E0", Offset = "0x47C9E0", VA = "0x18047E3E0", Slot = "68")]
	protected virtual void FirstLoad()
	{
		base.AttributeCountdown = 5f;
	}

	// Token: 0x0600106E RID: 4206 RVA: 0x0005DEB0 File Offset: 0x0005C0B0
	[Token(Token = "0x600106E")]
	[Address(RVA = "0x47E4E0", Offset = "0x47CAE0", VA = "0x18047E4E0", Slot = "69")]
	public virtual void StartShoot()
	{
		this.anim.SetTrigger("shoot");
		float thePlantAttackInterval = this.thePlantAttackInterval;
		this.avaliable = false;
		base.AttributeCountdown = thePlantAttackInterval;
	}

	// Token: 0x0600106F RID: 4207 RVA: 0x0005DEE8 File Offset: 0x0005C0E8
	[Token(Token = "0x600106F")]
	[Address(RVA = "0x47E330", Offset = "0x47C930", VA = "0x18047E330", Slot = "39")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("charge");
	}

	// Token: 0x06001070 RID: 4208 RVA: 0x0005DF0C File Offset: 0x0005C10C
	[Token(Token = "0x6001070")]
	[Address(RVA = "0x47E160", Offset = "0x47C760", VA = "0x18047E160", Slot = "70")]
	protected virtual void AnimShoot()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot2 = this.shoot;
		Mouse instance2 = Mouse.Instance;
		Bullet bullet;
		Rigidbody2D rb = bullet.rb;
		bullet.cannonPos = 0;
		bullet.cannonPos.y = (float)0;
		Board instance3 = Board.Instance;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001071 RID: 4209 RVA: 0x0005DF84 File Offset: 0x0005C184
	[Token(Token = "0x6001071")]
	[Address(RVA = "0x47E480", Offset = "0x47CA80", VA = "0x18047E480")]
	private void ShootSound()
	{
		GameAPP.PlaySound(107, 0.5f, 1f);
	}

	// Token: 0x06001072 RID: 4210 RVA: 0x0005DFA4 File Offset: 0x0005C1A4
	[Token(Token = "0x6001072")]
	[Address(RVA = "0x47E410", Offset = "0x47CA10", VA = "0x18047E410")]
	private void Shoop()
	{
		GameAPP.PlaySound(108, 0.5f, 1f);
		this.avaliable = true;
	}

	// Token: 0x06001073 RID: 4211 RVA: 0x0005DFCC File Offset: 0x0005C1CC
	[Token(Token = "0x6001073")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public CobCannon()
	{
	}

	// Token: 0x04000BC0 RID: 3008
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BC0")]
	public bool avaliable;

	// Token: 0x04000BC1 RID: 3009
	[FieldOffset(Offset = "0x219")]
	[Token(Token = "0x4000BC1")]
	public bool firstLoad;
}
