using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000456 RID: 1110
[Token(Token = "0x2000456")]
public class ThreeGoldPlantern : ThreePlantern
{
	// Token: 0x06001476 RID: 5238 RVA: 0x000721B4 File Offset: 0x000703B4
	[Token(Token = "0x6001476")]
	[Address(RVA = "0x477FC0", Offset = "0x4765C0", VA = "0x180477FC0", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		CreatePlant instance = CreatePlant.Instance;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		ulong num;
		instance.AdjustLightLevel(thePlantColumn, thePlantRow, -3, (int)num);
		global::UnityEngine.Object.Destroy(this.lanternLight);
	}

	// Token: 0x06001477 RID: 5239 RVA: 0x000721F4 File Offset: 0x000703F4
	[Token(Token = "0x6001477")]
	[Address(RVA = "0x478260", Offset = "0x476860", VA = "0x180478260", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, originalRow, -3, (int)num);
		ulong num2;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, (int)num2, 3, (int)num);
	}

	// Token: 0x06001478 RID: 5240 RVA: 0x00072228 File Offset: 0x00070428
	[Token(Token = "0x6001478")]
	[Address(RVA = "0x4781D0", Offset = "0x4767D0", VA = "0x1804781D0", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(theColumn, theRow, 3, (int)num);
	}

	// Token: 0x06001479 RID: 5241 RVA: 0x0007224C File Offset: 0x0007044C
	[Token(Token = "0x6001479")]
	[Address(RVA = "0x478080", Offset = "0x476680", VA = "0x180478080")]
	public float GetDamageAmplification()
	{
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)20)))
		{
			Board board = this.board;
		}
		float num;
		return num;
	}

	// Token: 0x0600147A RID: 5242 RVA: 0x00072278 File Offset: 0x00070478
	[Token(Token = "0x600147A")]
	[Address(RVA = "0x478100", Offset = "0x476700", VA = "0x180478100", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x0600147B RID: 5243 RVA: 0x00072298 File Offset: 0x00070498
	[Token(Token = "0x600147B")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public ThreeGoldPlantern()
	{
	}

	// Token: 0x04000CC6 RID: 3270
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000CC6")]
	public GameObject laserPrefab;
}
