using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x02000355 RID: 853
[Token(Token = "0x2000355")]
public class BigSunNut : BigWallNut
{
	// Token: 0x06000FA7 RID: 4007 RVA: 0x0005A504 File Offset: 0x00058704
	[Token(Token = "0x6000FA7")]
	[Address(RVA = "0x4718B0", Offset = "0x46FEB0", VA = "0x1804718B0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (PlantStatus)((ulong)27L);
		base.AttributeCountdown = 1f;
		this.anim.SetFloat("Speed", 1f);
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x06000FA8 RID: 4008 RVA: 0x0005A554 File Offset: 0x00058754
	[Token(Token = "0x6000FA8")]
	[Address(RVA = "0x471BA0", Offset = "0x4701A0", VA = "0x180471BA0", Slot = "15")]
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

	// Token: 0x06000FA9 RID: 4009 RVA: 0x0005A604 File Offset: 0x00058804
	[Token(Token = "0x6000FA9")]
	[Address(RVA = "0x471960", Offset = "0x46FF60", VA = "0x180471960")]
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

	// Token: 0x06000FAA RID: 4010 RVA: 0x0005A684 File Offset: 0x00058884
	[Token(Token = "0x6000FAA")]
	[Address(RVA = "0x471850", Offset = "0x46FE50", VA = "0x180471850", Slot = "39")]
	protected override void AttributeEvent()
	{
		this.anim.Play("Round");
		this.theStatus = (PlantStatus)((ulong)27L);
	}

	// Token: 0x06000FAB RID: 4011 RVA: 0x0005A6B4 File Offset: 0x000588B4
	[Token(Token = "0x6000FAB")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "68")]
	protected override void Round()
	{
	}

	// Token: 0x06000FAC RID: 4012 RVA: 0x0005A6C4 File Offset: 0x000588C4
	[Token(Token = "0x6000FAC")]
	[Address(RVA = "0x471D80", Offset = "0x470380", VA = "0x180471D80")]
	public BigSunNut()
	{
		List<BigWallNut.DamageZombie> list = new List();
		this.damageZombies = list;
		base..ctor();
	}
}
