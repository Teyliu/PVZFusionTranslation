using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000476 RID: 1142
[Token(Token = "0x2000476")]
public class ThreeGoldPlantern : ThreePlantern
{
	// Token: 0x06001506 RID: 5382 RVA: 0x0007450C File Offset: 0x0007270C
	[Token(Token = "0x6001506")]
	[Address(RVA = "0x4CF880", Offset = "0x4CDE80", VA = "0x1804CF880", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		CreatePlant instance = CreatePlant.Instance;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		ulong num;
		instance.AdjustLightLevel(thePlantColumn, thePlantRow, -3, (int)num);
		global::UnityEngine.Object.Destroy(this.lanternLight);
	}

	// Token: 0x06001507 RID: 5383 RVA: 0x0007454C File Offset: 0x0007274C
	[Token(Token = "0x6001507")]
	[Address(RVA = "0x4CFB20", Offset = "0x4CE120", VA = "0x1804CFB20", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, originalRow, -3, (int)num);
		ulong num2;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, (int)num2, 3, (int)num);
	}

	// Token: 0x06001508 RID: 5384 RVA: 0x00074580 File Offset: 0x00072780
	[Token(Token = "0x6001508")]
	[Address(RVA = "0x4CFA90", Offset = "0x4CE090", VA = "0x1804CFA90", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(theColumn, theRow, 3, (int)num);
	}

	// Token: 0x06001509 RID: 5385 RVA: 0x000745A4 File Offset: 0x000727A4
	[Token(Token = "0x6001509")]
	[Address(RVA = "0x4CF940", Offset = "0x4CDF40", VA = "0x1804CF940")]
	public float GetDamageAmplification()
	{
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)20)))
		{
			Board board = this.board;
		}
		float num;
		return num;
	}

	// Token: 0x0600150A RID: 5386 RVA: 0x000745D0 File Offset: 0x000727D0
	[Token(Token = "0x600150A")]
	[Address(RVA = "0x4CF9C0", Offset = "0x4CDFC0", VA = "0x1804CF9C0", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x0600150B RID: 5387 RVA: 0x000745F0 File Offset: 0x000727F0
	[Token(Token = "0x600150B")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public ThreeGoldPlantern()
	{
	}

	// Token: 0x04000D52 RID: 3410
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000D52")]
	public GameObject laserPrefab;
}
