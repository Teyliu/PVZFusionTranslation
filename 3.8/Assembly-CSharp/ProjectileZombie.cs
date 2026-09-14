using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020006B9 RID: 1721
[Token(Token = "0x20006B9")]
public class ProjectileZombie : Zombie
{
	// Token: 0x060021B4 RID: 8628 RVA: 0x000B1828 File Offset: 0x000AFA28
	[Token(Token = "0x60021B4")]
	[Address(RVA = "0x557870", Offset = "0x555E70", VA = "0x180557870", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)10L);
	}

	// Token: 0x060021B5 RID: 8629 RVA: 0x000B1848 File Offset: 0x000AFA48
	[Token(Token = "0x60021B5")]
	[Address(RVA = "0x569720", Offset = "0x567D20", VA = "0x180569720", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.theHealth = (int)((ulong)1000L);
	}

	// Token: 0x060021B6 RID: 8630 RVA: 0x000B1868 File Offset: 0x000AFA68
	[Token(Token = "0x60021B6")]
	[Address(RVA = "0x5697D0", Offset = "0x567DD0", VA = "0x1805697D0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Transform axis = this.axis;
		Transform transform = base.transform;
		Mouse instance = Mouse.Instance;
		Transform transform2 = base.transform;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
	}

	// Token: 0x060021B7 RID: 8631 RVA: 0x000B18A8 File Offset: 0x000AFAA8
	[Token(Token = "0x60021B7")]
	[Address(RVA = "0x569330", Offset = "0x567930", VA = "0x180569330", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		this.RbUpdate();
	}

	// Token: 0x060021B8 RID: 8632 RVA: 0x000B18C4 File Offset: 0x000AFAC4
	[Token(Token = "0x60021B8")]
	[Address(RVA = "0x569740", Offset = "0x567D40", VA = "0x180569740", Slot = "72")]
	public override void UpdateHealthText()
	{
		TextMeshPro healthText = this.healthText;
		int num = 0;
		if (healthText != num)
		{
			TextMeshPro healthText2 = this.healthText;
			int num2 = 0;
			healthText2.text = num2;
		}
	}

	// Token: 0x060021B9 RID: 8633 RVA: 0x000B18FC File Offset: 0x000AFAFC
	[Token(Token = "0x60021B9")]
	[Address(RVA = "0x5693B0", Offset = "0x5679B0", VA = "0x1805693B0")]
	private void RbUpdate()
	{
		Rigidbody2D rb = this.rb;
		Vector2 vector = this.a;
		float y = this.a.y;
		float fixedDeltaTime = Time.fixedDeltaTime;
		Rigidbody2D rb2 = this.rb;
		this.v.y = y;
		this.v = vector;
		Vector2 velocity = rb2.velocity;
		Vector3 vector2;
		float z = vector2.z;
		Vector3 vector3;
		float z2 = vector3.z;
		rb2.rotation = z2;
		Transform transform = base.transform;
		Vector3 vector4;
		float y2 = vector4.y;
		Mouse instance = Mouse.Instance;
		Transform transform2 = base.transform;
		Vector2 velocity2 = this.rb.velocity;
		Board board = this.board;
		Transform transform3 = base.transform;
		Transform transform4 = base.transform;
		this.Die(2);
	}

	// Token: 0x060021BA RID: 8634 RVA: 0x000B19CC File Offset: 0x000AFBCC
	[Token(Token = "0x60021BA")]
	[Address(RVA = "0x561440", Offset = "0x55FA40", VA = "0x180561440", Slot = "27")]
	public override void Die(int reason = 0)
	{
		base.Die(2);
	}

	// Token: 0x060021BB RID: 8635 RVA: 0x000B19E0 File Offset: 0x000AFBE0
	[Token(Token = "0x60021BB")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "21")]
	protected override void PositionUpdate()
	{
	}

	// Token: 0x060021BC RID: 8636 RVA: 0x000B19F0 File Offset: 0x000AFBF0
	[Token(Token = "0x60021BC")]
	[Address(RVA = "0x533DF0", Offset = "0x5323F0", VA = "0x180533DF0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
	}

	// Token: 0x060021BD RID: 8637 RVA: 0x000B1A00 File Offset: 0x000AFC00
	[Token(Token = "0x60021BD")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
	}

	// Token: 0x060021BE RID: 8638 RVA: 0x000B1A10 File Offset: 0x000AFC10
	[Token(Token = "0x60021BE")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x060021BF RID: 8639 RVA: 0x000B1A20 File Offset: 0x000AFC20
	[Token(Token = "0x60021BF")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x060021C0 RID: 8640 RVA: 0x000B1A30 File Offset: 0x000AFC30
	[Token(Token = "0x60021C0")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "49")]
	public override void SetJalaed()
	{
	}

	// Token: 0x060021C1 RID: 8641 RVA: 0x000B1A40 File Offset: 0x000AFC40
	[Token(Token = "0x60021C1")]
	[Address(RVA = "0x3CAD30", Offset = "0x3C9330", VA = "0x1803CAD30", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		return theDamage;
	}

	// Token: 0x060021C2 RID: 8642 RVA: 0x000B1A50 File Offset: 0x000AFC50
	[Token(Token = "0x60021C2")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x060021C3 RID: 8643 RVA: 0x000B1A60 File Offset: 0x000AFC60
	[Token(Token = "0x60021C3")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "59")]
	public override void Garliced(bool playSound = false, bool certainRow = false)
	{
	}

	// Token: 0x060021C4 RID: 8644 RVA: 0x000B1A70 File Offset: 0x000AFC70
	[Token(Token = "0x60021C4")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "52")]
	public override void SetPoison(float time = 10f)
	{
	}

	// Token: 0x060021C5 RID: 8645 RVA: 0x000B1A80 File Offset: 0x000AFC80
	[Token(Token = "0x60021C5")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "48")]
	public override void SetPortaled(float timer = 1.5f)
	{
	}

	// Token: 0x060021C6 RID: 8646 RVA: 0x000B1A90 File Offset: 0x000AFC90
	[Token(Token = "0x60021C6")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x060021C7 RID: 8647 RVA: 0x000B1AA0 File Offset: 0x000AFCA0
	[Token(Token = "0x60021C7")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "50")]
	public override void SetEmbered(bool ulti = false)
	{
	}

	// Token: 0x060021C8 RID: 8648 RVA: 0x000B1AB0 File Offset: 0x000AFCB0
	[Token(Token = "0x60021C8")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "69")]
	public override void BeSmall(float scale = 0.7f)
	{
	}

	// Token: 0x060021C9 RID: 8649 RVA: 0x000B1AC0 File Offset: 0x000AFCC0
	[Token(Token = "0x60021C9")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "53")]
	public override void AddPoisonLevel()
	{
	}

	// Token: 0x060021CA RID: 8650 RVA: 0x000B1AD0 File Offset: 0x000AFCD0
	[Token(Token = "0x60021CA")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060021CB RID: 8651 RVA: 0x000B1AE0 File Offset: 0x000AFCE0
	[Token(Token = "0x60021CB")]
	[Address(RVA = "0x569930", Offset = "0x567F30", VA = "0x180569930")]
	public ProjectileZombie()
	{
	}

	// Token: 0x0400111D RID: 4381
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400111D")]
	public Vector2 v;

	// Token: 0x0400111E RID: 4382
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400111E")]
	public Vector2 a;
}
