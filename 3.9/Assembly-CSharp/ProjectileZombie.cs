using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020006F1 RID: 1777
[Token(Token = "0x20006F1")]
public class ProjectileZombie : Zombie
{
	// Token: 0x060022CE RID: 8910 RVA: 0x000B6530 File Offset: 0x000B4730
	[Token(Token = "0x60022CE")]
	[Address(RVA = "0x5BBD10", Offset = "0x5BA310", VA = "0x1805BBD10", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)10L);
	}

	// Token: 0x060022CF RID: 8911 RVA: 0x000B6550 File Offset: 0x000B4750
	[Token(Token = "0x60022CF")]
	[Address(RVA = "0x5CCFF0", Offset = "0x5CB5F0", VA = "0x1805CCFF0", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		this.theHealth = (long)((ulong)1000L);
	}

	// Token: 0x060022D0 RID: 8912 RVA: 0x000B6570 File Offset: 0x000B4770
	[Token(Token = "0x60022D0")]
	[Address(RVA = "0x5CD0B0", Offset = "0x5CB6B0", VA = "0x1805CD0B0", Slot = "17")]
	protected override void Update()
	{
		base.Update();
		Transform axis = this.axis;
		Transform transform = base.transform;
		Mouse instance = Mouse.Instance;
		Transform transform2 = base.transform;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
	}

	// Token: 0x060022D1 RID: 8913 RVA: 0x000B65B0 File Offset: 0x000B47B0
	[Token(Token = "0x60022D1")]
	[Address(RVA = "0x5CCBF0", Offset = "0x5CB1F0", VA = "0x1805CCBF0", Slot = "18")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		this.RbUpdate();
	}

	// Token: 0x060022D2 RID: 8914 RVA: 0x000B65CC File Offset: 0x000B47CC
	[Token(Token = "0x60022D2")]
	[Address(RVA = "0x5CD020", Offset = "0x5CB620", VA = "0x1805CD020", Slot = "74")]
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

	// Token: 0x060022D3 RID: 8915 RVA: 0x000B6604 File Offset: 0x000B4804
	[Token(Token = "0x60022D3")]
	[Address(RVA = "0x5CCC80", Offset = "0x5CB280", VA = "0x1805CCC80")]
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

	// Token: 0x060022D4 RID: 8916 RVA: 0x000B66D4 File Offset: 0x000B48D4
	[Token(Token = "0x60022D4")]
	[Address(RVA = "0x5C4230", Offset = "0x5C2830", VA = "0x1805C4230", Slot = "28")]
	public override void Die(int reason = 0)
	{
		base.Die(2);
	}

	// Token: 0x060022D5 RID: 8917 RVA: 0x000B66E8 File Offset: 0x000B48E8
	[Token(Token = "0x60022D5")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "22")]
	protected override void PositionUpdate()
	{
	}

	// Token: 0x060022D6 RID: 8918 RVA: 0x000B66F8 File Offset: 0x000B48F8
	[Token(Token = "0x60022D6")]
	[Address(RVA = "0x58AAD0", Offset = "0x5890D0", VA = "0x18058AAD0", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
	}

	// Token: 0x060022D7 RID: 8919 RVA: 0x000B6708 File Offset: 0x000B4908
	[Token(Token = "0x60022D7")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
	}

	// Token: 0x060022D8 RID: 8920 RVA: 0x000B6718 File Offset: 0x000B4918
	[Token(Token = "0x60022D8")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x060022D9 RID: 8921 RVA: 0x000B6728 File Offset: 0x000B4928
	[Token(Token = "0x60022D9")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x060022DA RID: 8922 RVA: 0x000B6738 File Offset: 0x000B4938
	[Token(Token = "0x60022DA")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "51")]
	public override void SetJalaed()
	{
	}

	// Token: 0x060022DB RID: 8923 RVA: 0x000B6748 File Offset: 0x000B4948
	[Token(Token = "0x60022DB")]
	[Address(RVA = "0x5CCC70", Offset = "0x5CB270", VA = "0x1805CCC70", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		return theDamage;
	}

	// Token: 0x060022DC RID: 8924 RVA: 0x000B6758 File Offset: 0x000B4958
	[Token(Token = "0x60022DC")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x060022DD RID: 8925 RVA: 0x000B6768 File Offset: 0x000B4968
	[Token(Token = "0x60022DD")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "61")]
	public override void Garliced(bool playSound = false, bool certainRow = false)
	{
	}

	// Token: 0x060022DE RID: 8926 RVA: 0x000B6778 File Offset: 0x000B4978
	[Token(Token = "0x60022DE")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "54")]
	public override void SetPoison(float time = 10f)
	{
	}

	// Token: 0x060022DF RID: 8927 RVA: 0x000B6788 File Offset: 0x000B4988
	[Token(Token = "0x60022DF")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "50")]
	public override void SetPortaled(float timer = 1.5f)
	{
	}

	// Token: 0x060022E0 RID: 8928 RVA: 0x000B6798 File Offset: 0x000B4998
	[Token(Token = "0x60022E0")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x060022E1 RID: 8929 RVA: 0x000B67A8 File Offset: 0x000B49A8
	[Token(Token = "0x60022E1")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "52")]
	public override void SetEmbered(bool ulti = false)
	{
	}

	// Token: 0x060022E2 RID: 8930 RVA: 0x000B67B8 File Offset: 0x000B49B8
	[Token(Token = "0x60022E2")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "71")]
	public override void BeSmall(float scale = 0.7f)
	{
	}

	// Token: 0x060022E3 RID: 8931 RVA: 0x000B67C8 File Offset: 0x000B49C8
	[Token(Token = "0x60022E3")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "55")]
	public override void AddPoisonLevel()
	{
	}

	// Token: 0x060022E4 RID: 8932 RVA: 0x000B67D8 File Offset: 0x000B49D8
	[Token(Token = "0x60022E4")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060022E5 RID: 8933 RVA: 0x000B67E8 File Offset: 0x000B49E8
	[Token(Token = "0x60022E5")]
	[Address(RVA = "0x5CD210", Offset = "0x5CB810", VA = "0x1805CD210")]
	public ProjectileZombie()
	{
	}

	// Token: 0x040011EA RID: 4586
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40011EA")]
	public Vector2 v;

	// Token: 0x040011EB RID: 4587
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40011EB")]
	public Vector2 a;
}
