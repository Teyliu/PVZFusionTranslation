using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000415 RID: 1045
[Token(Token = "0x2000415")]
public class SeaLantern : Plantern
{
	// Token: 0x0600134A RID: 4938 RVA: 0x0006C9C8 File Offset: 0x0006ABC8
	[Token(Token = "0x600134A")]
	[Address(RVA = "0x464E60", Offset = "0x463460", VA = "0x180464E60", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		GameAPP.PlaySound(85, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		this.lightPos.z = z;
		GameObject light = base.GetLight();
		this.lanternLight = light;
		base.AttributeCountdown = 30f;
	}

	// Token: 0x0600134B RID: 4939 RVA: 0x0006CA28 File Offset: 0x0006AC28
	[Token(Token = "0x600134B")]
	[Address(RVA = "0x464980", Offset = "0x462F80", VA = "0x180464980", Slot = "40")]
	protected override void AttributeEvent()
	{
		if (!this.isGrowen)
		{
			this.Grow();
			return;
		}
	}

	// Token: 0x0600134C RID: 4940 RVA: 0x0006CA48 File Offset: 0x0006AC48
	[Token(Token = "0x600134C")]
	[Address(RVA = "0x464AA0", Offset = "0x4630A0", VA = "0x180464AA0")]
	private void Grow()
	{
		Animator anim = this.anim;
		this.isGrowen = true;
		anim.SetTrigger("grow");
		GameAPP.PlaySound(56, 0.5f, 1f);
		CreatePlant instance = CreatePlant.Instance;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		ulong num;
		instance.AdjustLightLevel(thePlantColumn, thePlantRow, -1, (int)num);
		CreatePlant instance2 = CreatePlant.Instance;
		int thePlantRow2 = this.thePlantRow;
		int thePlantColumn2 = this.thePlantColumn;
		ulong num2;
		instance2.AdjustLightLevel(thePlantColumn2, thePlantRow2, 1, (int)num2);
		Transform transform = this.lanternLight.transform;
		Transform transform2 = this.lanternLight.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x0600134D RID: 4941 RVA: 0x0006CAF4 File Offset: 0x0006ACF4
	[Token(Token = "0x600134D")]
	[Address(RVA = "0x4649A0", Offset = "0x462FA0", VA = "0x1804649A0", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (!this.isGrowen)
		{
			CreatePlant instance = CreatePlant.Instance;
		}
		CreatePlant instance2 = CreatePlant.Instance;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		uint num;
		instance2.AdjustLightLevel(thePlantColumn, thePlantRow, -1, (int)num);
		global::UnityEngine.Object.Destroy(this.lanternLight);
	}

	// Token: 0x0600134E RID: 4942 RVA: 0x0006CB40 File Offset: 0x0006AD40
	[Token(Token = "0x600134E")]
	[Address(RVA = "0x464D00", Offset = "0x463300", VA = "0x180464D00", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		if (!this.isGrowen)
		{
			CreatePlant instance = CreatePlant.Instance;
			ulong num;
			instance.AdjustLightLevel(originalColumn, originalRow, -1, (int)num);
			CreatePlant instance2 = CreatePlant.Instance;
		}
		CreatePlant instance3 = CreatePlant.Instance;
		ulong num2;
		instance3.AdjustLightLevel(originalColumn, originalRow, -1, (int)num2);
		CreatePlant instance4 = CreatePlant.Instance;
	}

	// Token: 0x0600134F RID: 4943 RVA: 0x0006CB94 File Offset: 0x0006AD94
	[Token(Token = "0x600134F")]
	[Address(RVA = "0x464C70", Offset = "0x463270", VA = "0x180464C70", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(theColumn, theRow, 1, (int)num);
	}

	// Token: 0x06001350 RID: 4944 RVA: 0x0006CBB8 File Offset: 0x0006ADB8
	[Token(Token = "0x6001350")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public SeaLantern()
	{
	}

	// Token: 0x04000C65 RID: 3173
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000C65")]
	private bool isGrowen;
}
