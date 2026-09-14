using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200038F RID: 911
[Token(Token = "0x200038F")]
public class DoomSeed : Plant
{
	// Token: 0x060010B8 RID: 4280 RVA: 0x0005F318 File Offset: 0x0005D518
	[Token(Token = "0x60010B8")]
	[Address(RVA = "0x482420", Offset = "0x480A20", VA = "0x180482420", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 30f;
	}

	// Token: 0x060010B9 RID: 4281 RVA: 0x0005F338 File Offset: 0x0005D538
	[Token(Token = "0x60010B9")]
	[Address(RVA = "0x482680", Offset = "0x480C80", VA = "0x180482680", Slot = "16")]
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

	// Token: 0x060010BA RID: 4282 RVA: 0x0005F3AC File Offset: 0x0005D5AC
	[Token(Token = "0x60010BA")]
	[Address(RVA = "0x482450", Offset = "0x480A50", VA = "0x180482450", Slot = "17")]
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

	// Token: 0x060010BB RID: 4283 RVA: 0x0005F414 File Offset: 0x0005D614
	[Token(Token = "0x60010BB")]
	[Address(RVA = "0x4823B0", Offset = "0x4809B0", VA = "0x1804823B0", Slot = "39")]
	protected override void AttributeEvent()
	{
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		int num2 = 0;
		child.GetChild(num2).gameObject.SetActive(true);
		this.theStatus = (PlantStatus)((ulong)25L);
	}

	// Token: 0x060010BC RID: 4284 RVA: 0x0005F458 File Offset: 0x0005D658
	[Token(Token = "0x60010BC")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public DoomSeed()
	{
	}
}
