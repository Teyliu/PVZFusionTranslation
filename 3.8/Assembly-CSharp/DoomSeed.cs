using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200037F RID: 895
[Token(Token = "0x200037F")]
public class DoomSeed : Plant
{
	// Token: 0x0600106C RID: 4204 RVA: 0x0005E2F4 File Offset: 0x0005C4F4
	[Token(Token = "0x600106C")]
	[Address(RVA = "0x431B90", Offset = "0x430190", VA = "0x180431B90", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 30f;
	}

	// Token: 0x0600106D RID: 4205 RVA: 0x0005E314 File Offset: 0x0005C514
	[Token(Token = "0x600106D")]
	[Address(RVA = "0x431DF0", Offset = "0x4303F0", VA = "0x180431DF0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
			Transform axis = this.axis;
			int num = 0;
			Vector3 vector;
			float z = vector.z;
			float num2;
			if (num > (int)num2 || num2 > 1f)
			{
			}
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			Vector3 vector2;
			float z2 = vector2.z;
			float deltaTime = Time.deltaTime;
			if (num > (int)deltaTime || deltaTime > 1f)
			{
			}
		}
	}

	// Token: 0x0600106E RID: 4206 RVA: 0x0005E388 File Offset: 0x0005C588
	[Token(Token = "0x600106E")]
	[Address(RVA = "0x431BC0", Offset = "0x4301C0", VA = "0x180431BC0", Slot = "17")]
	protected override void FixedUpdate()
	{
		int num = 0;
		base.FixedUpdate();
		Transform axis = this.axis;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
			}
			num++;
			int num3 = 0;
			base.Die((Plant.DieReason)num3);
			BoardAction boardAction = this.board.boardAction;
			PlantType thePlantType = this.thePlantType;
		}
	}

	// Token: 0x0600106F RID: 4207 RVA: 0x0005E3F0 File Offset: 0x0005C5F0
	[Token(Token = "0x600106F")]
	[Address(RVA = "0x431B20", Offset = "0x430120", VA = "0x180431B20", Slot = "40")]
	protected override void AttributeEvent()
	{
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		int num2 = 0;
		child.GetChild(num2).gameObject.SetActive(true);
		this.theStatus = (PlantStatus)((ulong)25L);
	}

	// Token: 0x06001070 RID: 4208 RVA: 0x0005E434 File Offset: 0x0005C634
	[Token(Token = "0x6001070")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public DoomSeed()
	{
	}
}
