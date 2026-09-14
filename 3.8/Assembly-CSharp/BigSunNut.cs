using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x02000345 RID: 837
[Token(Token = "0x2000345")]
public class BigSunNut : BigWallNut
{
	// Token: 0x06000F5B RID: 3931 RVA: 0x000595A4 File Offset: 0x000577A4
	[Token(Token = "0x6000F5B")]
	[Address(RVA = "0x41AA10", Offset = "0x419010", VA = "0x18041AA10", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (PlantStatus)((ulong)27L);
		base.AttributeCountdown = 1f;
		this.anim.SetFloat("Speed", 1f);
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x06000F5C RID: 3932 RVA: 0x000595F4 File Offset: 0x000577F4
	[Token(Token = "0x6000F5C")]
	[Address(RVA = "0x41AD00", Offset = "0x419300", VA = "0x18041AD00", Slot = "15")]
	protected override void Start()
	{
		Board board = this.board;
		RoofEntity roofEntity = this.AddComponent<RoofEntity>();
		int thePlantRow = this.thePlantRow;
		roofEntity.entityRow = thePlantRow;
		this.Round();
		Transform transform = base.transform;
		int num = 0;
		transform.GetChild(num).GetChild(2).gameObject.SetActive(true);
		Transform transform2 = base.transform;
		int num2 = 0;
		SpriteRenderer component = transform2.GetChild(num2).GetComponent<SpriteRenderer>();
		int num3 = 0;
		component.enabled = num3 != 0;
	}

	// Token: 0x06000F5D RID: 3933 RVA: 0x000596A4 File Offset: 0x000578A4
	[Token(Token = "0x6000F5D")]
	[Address(RVA = "0x41AAC0", Offset = "0x4190C0", VA = "0x18041AAC0")]
	public void Larger()
	{
		base.AttributeCountdown = 1f;
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		float num2;
		float num = num2 * 0.1f;
		Board board = this.board;
		int num3 = this.attributeCount;
		num3++;
		this.attributeCount = num3;
		int num4 = num3 - 1;
		float num6;
		float num5 = num6 * 600f;
		this.anim.SetFloat("Speed", 1f);
	}

	// Token: 0x06000F5E RID: 3934 RVA: 0x00059724 File Offset: 0x00057924
	[Token(Token = "0x6000F5E")]
	[Address(RVA = "0x41A9B0", Offset = "0x418FB0", VA = "0x18041A9B0", Slot = "40")]
	protected override void AttributeEvent()
	{
		this.anim.Play("Round");
		this.theStatus = (PlantStatus)((ulong)27L);
	}

	// Token: 0x06000F5F RID: 3935 RVA: 0x00059754 File Offset: 0x00057954
	[Token(Token = "0x6000F5F")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "69")]
	protected override void Round()
	{
	}

	// Token: 0x06000F60 RID: 3936 RVA: 0x00059764 File Offset: 0x00057964
	[Token(Token = "0x6000F60")]
	[Address(RVA = "0x41AEE0", Offset = "0x4194E0", VA = "0x18041AEE0")]
	public BigSunNut()
	{
		List<BigWallNut.DamageZombie> list = new List();
		this.damageZombies = list;
		base..ctor();
	}
}
