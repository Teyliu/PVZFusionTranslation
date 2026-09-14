using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003CB RID: 971
[Token(Token = "0x20003CB")]
public class LanternNut : WallNut
{
	// Token: 0x060011B5 RID: 4533 RVA: 0x00063F68 File Offset: 0x00062168
	[Token(Token = "0x60011B5")]
	[Address(RVA = "0x446CB0", Offset = "0x4452B0", VA = "0x180446CB0", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.AttributeCountdown = 15f;
		int num = 0;
		ulong num2;
		ulong num3;
		base.Recover(15f, (DamageType)num, num2 != 0UL, num3 != 0UL);
	}

	// Token: 0x060011B6 RID: 4534 RVA: 0x00063F94 File Offset: 0x00062194
	[Token(Token = "0x60011B6")]
	[Address(RVA = "0x446F60", Offset = "0x445560", VA = "0x180446F60", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 15f;
		GameAPP.PlaySound(85, 0.5f, 1f);
		Transform axis = this.axis;
		GameObject gameObject = GameAPP.particlePrefab[40];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		this.lanternLight = gameObject2;
		throw new NullReferenceException();
	}

	// Token: 0x060011B7 RID: 4535 RVA: 0x00063FF8 File Offset: 0x000621F8
	[Token(Token = "0x60011B7")]
	[Address(RVA = "0x447170", Offset = "0x445770", VA = "0x180447170", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Transform transform = this.lanternLight.transform;
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x060011B8 RID: 4536 RVA: 0x0006402C File Offset: 0x0006222C
	[Token(Token = "0x60011B8")]
	[Address(RVA = "0x446D20", Offset = "0x445320", VA = "0x180446D20", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		CreatePlant instance = CreatePlant.Instance;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		ulong num;
		instance.AdjustLightLevel(thePlantColumn, thePlantRow, -1, (int)num);
		global::UnityEngine.Object.Destroy(this.lanternLight);
	}

	// Token: 0x060011B9 RID: 4537 RVA: 0x0006406C File Offset: 0x0006226C
	[Token(Token = "0x60011B9")]
	[Address(RVA = "0x446E90", Offset = "0x445490", VA = "0x180446E90", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, originalRow, -1, (int)num);
		ulong num2;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, (int)num2, 1, (int)num);
	}

	// Token: 0x060011BA RID: 4538 RVA: 0x0006409C File Offset: 0x0006229C
	[Token(Token = "0x60011BA")]
	[Address(RVA = "0x446DE0", Offset = "0x4453E0", VA = "0x180446DE0", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		base.OnCreate(theColumn, theRow);
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(theColumn, theRow, 1, (int)num);
	}

	// Token: 0x060011BB RID: 4539 RVA: 0x000640C8 File Offset: 0x000622C8
	[Token(Token = "0x60011BB")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public LanternNut()
	{
	}

	// Token: 0x04000BCC RID: 3020
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BCC")]
	protected GameObject lanternLight;

	// Token: 0x04000BCD RID: 3021
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000BCD")]
	private Vector3 lightPos;
}
