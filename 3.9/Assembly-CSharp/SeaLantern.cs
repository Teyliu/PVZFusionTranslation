using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000432 RID: 1074
[Token(Token = "0x2000432")]
public class SeaLantern : Plantern
{
	// Token: 0x060013CA RID: 5066 RVA: 0x0006EA14 File Offset: 0x0006CC14
	[Token(Token = "0x60013CA")]
	[Address(RVA = "0x4BB910", Offset = "0x4B9F10", VA = "0x1804BB910", Slot = "15")]
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

	// Token: 0x060013CB RID: 5067 RVA: 0x0006EA74 File Offset: 0x0006CC74
	[Token(Token = "0x60013CB")]
	[Address(RVA = "0x4BB430", Offset = "0x4B9A30", VA = "0x1804BB430", Slot = "39")]
	protected override void AttributeEvent()
	{
		if (!this.isGrowen)
		{
			this.Grow();
			return;
		}
	}

	// Token: 0x060013CC RID: 5068 RVA: 0x0006EA94 File Offset: 0x0006CC94
	[Token(Token = "0x60013CC")]
	[Address(RVA = "0x4BB550", Offset = "0x4B9B50", VA = "0x1804BB550")]
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

	// Token: 0x060013CD RID: 5069 RVA: 0x0006EB40 File Offset: 0x0006CD40
	[Token(Token = "0x60013CD")]
	[Address(RVA = "0x4BB450", Offset = "0x4B9A50", VA = "0x1804BB450", Slot = "52")]
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

	// Token: 0x060013CE RID: 5070 RVA: 0x0006EB8C File Offset: 0x0006CD8C
	[Token(Token = "0x60013CE")]
	[Address(RVA = "0x4BB7B0", Offset = "0x4B9DB0", VA = "0x1804BB7B0", Slot = "53")]
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

	// Token: 0x060013CF RID: 5071 RVA: 0x0006EBE0 File Offset: 0x0006CDE0
	[Token(Token = "0x60013CF")]
	[Address(RVA = "0x4BB720", Offset = "0x4B9D20", VA = "0x1804BB720", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(theColumn, theRow, 1, (int)num);
	}

	// Token: 0x060013D0 RID: 5072 RVA: 0x0006EC04 File Offset: 0x0006CE04
	[Token(Token = "0x60013D0")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public SeaLantern()
	{
	}

	// Token: 0x04000CE4 RID: 3300
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000CE4")]
	private bool isGrowen;
}
