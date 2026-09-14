using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000417 RID: 1047
[Token(Token = "0x2000417")]
public class SeaNut : WallNut
{
	// Token: 0x06001354 RID: 4948 RVA: 0x0006CC94 File Offset: 0x0006AE94
	[Token(Token = "0x6001354")]
	[Address(RVA = "0x44D3D0", Offset = "0x44B9D0", VA = "0x18044D3D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 10f;
	}

	// Token: 0x06001355 RID: 4949 RVA: 0x0006CCB4 File Offset: 0x0006AEB4
	[Token(Token = "0x6001355")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "29")]
	protected override void ReplaceSprite()
	{
	}

	// Token: 0x06001356 RID: 4950 RVA: 0x0006CCC4 File Offset: 0x0006AEC4
	[Token(Token = "0x6001356")]
	[Address(RVA = "0x4650E0", Offset = "0x4636E0", VA = "0x1804650E0", Slot = "40")]
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

	// Token: 0x06001357 RID: 4951 RVA: 0x0006CD38 File Offset: 0x0006AF38
	[Token(Token = "0x6001357")]
	[Address(RVA = "0x465440", Offset = "0x463A40", VA = "0x180465440", Slot = "15")]
	protected override void Start()
	{
		Transform transform = base.transform;
		base.Start();
	}

	// Token: 0x06001358 RID: 4952 RVA: 0x0006CD5C File Offset: 0x0006AF5C
	[Token(Token = "0x6001358")]
	[Address(RVA = "0x465200", Offset = "0x463800", VA = "0x180465200")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (!flag || this.thePlantRow > 4)
		{
		}
	}

	// Token: 0x06001359 RID: 4953 RVA: 0x0006CDB4 File Offset: 0x0006AFB4
	[Token(Token = "0x6001359")]
	[Address(RVA = "0x465340", Offset = "0x463940", VA = "0x180465340", Slot = "69")]
	protected override void OnTriggerStay2D(Collider2D collision)
	{
		base.OnTriggerStay2D(collision);
	}

	// Token: 0x0600135A RID: 4954 RVA: 0x0006CDFC File Offset: 0x0006AFFC
	[Token(Token = "0x600135A")]
	[Address(RVA = "0x4654E0", Offset = "0x463AE0", VA = "0x1804654E0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Transform axis = this.axis;
		Board board = this.board;
		int num = 0;
		base.Die((Plant.DieReason)num);
	}

	// Token: 0x0600135B RID: 4955 RVA: 0x0006CE6C File Offset: 0x0006B06C
	[Token(Token = "0x600135B")]
	[Address(RVA = "0x4654B0", Offset = "0x463AB0", VA = "0x1804654B0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x0600135C RID: 4956 RVA: 0x0006CE7C File Offset: 0x0006B07C
	[Token(Token = "0x600135C")]
	[Address(RVA = "0x4651E0", Offset = "0x4637E0", VA = "0x1804651E0", Slot = "35")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		base.Crashed(level, soundID, zombie);
	}

	// Token: 0x0600135D RID: 4957 RVA: 0x0006CE94 File Offset: 0x0006B094
	[Token(Token = "0x600135D")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public SeaNut()
	{
	}

	// Token: 0x04000C68 RID: 3176
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C68")]
	private Vector2 originalScale;
}
