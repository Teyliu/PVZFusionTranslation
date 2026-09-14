using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200036F RID: 879
[Token(Token = "0x200036F")]
public class CobCannon : Plant
{
	// Token: 0x06001020 RID: 4128 RVA: 0x0005CEA0 File Offset: 0x0005B0A0
	[Token(Token = "0x6001020")]
	[Address(RVA = "0x427720", Offset = "0x425D20", VA = "0x180427720", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		this.shoot = child;
		this.firstLoad = true;
	}

	// Token: 0x06001021 RID: 4129 RVA: 0x0005CED8 File Offset: 0x0005B0D8
	[Token(Token = "0x6001021")]
	[Address(RVA = "0x4278F0", Offset = "0x425EF0", VA = "0x1804278F0", Slot = "15")]
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

	// Token: 0x06001022 RID: 4130 RVA: 0x0005CF04 File Offset: 0x0005B104
	[Token(Token = "0x6001022")]
	[Address(RVA = "0x427780", Offset = "0x425D80", VA = "0x180427780", Slot = "69")]
	protected virtual void FirstLoad()
	{
		base.AttributeCountdown = 5f;
	}

	// Token: 0x06001023 RID: 4131 RVA: 0x0005CF2C File Offset: 0x0005B12C
	[Token(Token = "0x6001023")]
	[Address(RVA = "0x427880", Offset = "0x425E80", VA = "0x180427880", Slot = "70")]
	public virtual void StartShoot()
	{
		this.anim.SetTrigger("shoot");
		float thePlantAttackInterval = this.thePlantAttackInterval;
		this.avaliable = false;
		base.AttributeCountdown = thePlantAttackInterval;
	}

	// Token: 0x06001024 RID: 4132 RVA: 0x0005CF64 File Offset: 0x0005B164
	[Token(Token = "0x6001024")]
	[Address(RVA = "0x4276D0", Offset = "0x425CD0", VA = "0x1804276D0", Slot = "40")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("charge");
	}

	// Token: 0x06001025 RID: 4133 RVA: 0x0005CF88 File Offset: 0x0005B188
	[Token(Token = "0x6001025")]
	[Address(RVA = "0x427500", Offset = "0x425B00", VA = "0x180427500", Slot = "71")]
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

	// Token: 0x06001026 RID: 4134 RVA: 0x0005D000 File Offset: 0x0005B200
	[Token(Token = "0x6001026")]
	[Address(RVA = "0x427820", Offset = "0x425E20", VA = "0x180427820")]
	private void ShootSound()
	{
		GameAPP.PlaySound(107, 0.5f, 1f);
	}

	// Token: 0x06001027 RID: 4135 RVA: 0x0005D020 File Offset: 0x0005B220
	[Token(Token = "0x6001027")]
	[Address(RVA = "0x4277B0", Offset = "0x425DB0", VA = "0x1804277B0")]
	private void Shoop()
	{
		GameAPP.PlaySound(108, 0.5f, 1f);
		this.avaliable = true;
	}

	// Token: 0x06001028 RID: 4136 RVA: 0x0005D048 File Offset: 0x0005B248
	[Token(Token = "0x6001028")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public CobCannon()
	{
	}

	// Token: 0x04000B70 RID: 2928
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B70")]
	public bool avaliable;

	// Token: 0x04000B71 RID: 2929
	[FieldOffset(Offset = "0x219")]
	[Token(Token = "0x4000B71")]
	public bool firstLoad;
}
