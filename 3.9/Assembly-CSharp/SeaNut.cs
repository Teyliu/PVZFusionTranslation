using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000434 RID: 1076
[Token(Token = "0x2000434")]
public class SeaNut : WallNut
{
	// Token: 0x060013D4 RID: 5076 RVA: 0x0006ECE0 File Offset: 0x0006CEE0
	[Token(Token = "0x60013D4")]
	[Address(RVA = "0x4A1B90", Offset = "0x4A0190", VA = "0x1804A1B90", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 10f;
	}

	// Token: 0x060013D5 RID: 5077 RVA: 0x0006ED00 File Offset: 0x0006CF00
	[Token(Token = "0x60013D5")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "28")]
	protected override void ReplaceSprite()
	{
	}

	// Token: 0x060013D6 RID: 5078 RVA: 0x0006ED10 File Offset: 0x0006CF10
	[Token(Token = "0x60013D6")]
	[Address(RVA = "0x4BBB90", Offset = "0x4BA190", VA = "0x1804BBB90", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.AttributeCountdown = 10f;
		int num = this.attributeCount;
		num += 2000;
		this.attributeCount = num;
		if (num < 6000)
		{
		}
		this.anim.SetTrigger("round");
		this.theStatus = (PlantStatus)((ulong)25L);
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		base.RemoveFromList();
		this.freeMoving = false;
		throw new NullReferenceException();
	}

	// Token: 0x060013D7 RID: 5079 RVA: 0x0006ED84 File Offset: 0x0006CF84
	[Token(Token = "0x60013D7")]
	[Address(RVA = "0x4BBEF0", Offset = "0x4BA4F0", VA = "0x1804BBEF0", Slot = "15")]
	protected override void Start()
	{
		Transform transform = base.transform;
		base.Start();
	}

	// Token: 0x060013D8 RID: 5080 RVA: 0x0006EDA8 File Offset: 0x0006CFA8
	[Token(Token = "0x60013D8")]
	[Address(RVA = "0x4BBCB0", Offset = "0x4BA2B0", VA = "0x1804BBCB0")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (!flag || this.thePlantRow > 4)
		{
		}
	}

	// Token: 0x060013D9 RID: 5081 RVA: 0x0006EE00 File Offset: 0x0006D000
	[Token(Token = "0x60013D9")]
	[Address(RVA = "0x4BBDF0", Offset = "0x4BA3F0", VA = "0x1804BBDF0", Slot = "68")]
	protected override void OnTriggerStay2D(Collider2D collision)
	{
		base.OnTriggerStay2D(collision);
	}

	// Token: 0x060013DA RID: 5082 RVA: 0x0006EE48 File Offset: 0x0006D048
	[Token(Token = "0x60013DA")]
	[Address(RVA = "0x4BBF90", Offset = "0x4BA590", VA = "0x1804BBF90", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Transform axis = this.axis;
		Board board = this.board;
		int num = 0;
		base.Die((Plant.DieReason)num);
	}

	// Token: 0x060013DB RID: 5083 RVA: 0x0006EEB8 File Offset: 0x0006D0B8
	[Token(Token = "0x60013DB")]
	[Address(RVA = "0x4BBF60", Offset = "0x4BA560", VA = "0x1804BBF60", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x060013DC RID: 5084 RVA: 0x0006EEC8 File Offset: 0x0006D0C8
	[Token(Token = "0x60013DC")]
	[Address(RVA = "0x4BBC90", Offset = "0x4BA290", VA = "0x1804BBC90", Slot = "34")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		base.Crashed(level, soundID, zombie);
	}

	// Token: 0x060013DD RID: 5085 RVA: 0x0006EEE0 File Offset: 0x0006D0E0
	[Token(Token = "0x60013DD")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public SeaNut()
	{
	}

	// Token: 0x04000CE7 RID: 3303
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000CE7")]
	private Vector2 originalScale;
}
