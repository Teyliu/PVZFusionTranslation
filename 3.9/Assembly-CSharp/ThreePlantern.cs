using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000478 RID: 1144
[Token(Token = "0x2000478")]
public class ThreePlantern : Plantern
{
	// Token: 0x06001512 RID: 5394 RVA: 0x00074784 File Offset: 0x00072984
	[Token(Token = "0x6001512")]
	[Address(RVA = "0x4CFF80", Offset = "0x4CE580", VA = "0x1804CFF80", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		CreatePlant instance = CreatePlant.Instance;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		ulong num;
		instance.AdjustLightLevel(thePlantColumn, thePlantRow, -3, (int)num);
		global::UnityEngine.Object.Destroy(this.lanternLight);
	}

	// Token: 0x06001513 RID: 5395 RVA: 0x000747C4 File Offset: 0x000729C4
	[Token(Token = "0x6001513")]
	[Address(RVA = "0x4D00D0", Offset = "0x4CE6D0", VA = "0x1804D00D0", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, originalRow, -3, (int)num);
		ulong num2;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, (int)num2, 3, (int)num);
	}

	// Token: 0x06001514 RID: 5396 RVA: 0x000747F8 File Offset: 0x000729F8
	[Token(Token = "0x6001514")]
	[Address(RVA = "0x4D0040", Offset = "0x4CE640", VA = "0x1804D0040", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(theColumn, theRow, 3, (int)num);
	}

	// Token: 0x06001515 RID: 5397 RVA: 0x0007481C File Offset: 0x00072A1C
	[Token(Token = "0x6001515")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public ThreePlantern()
	{
	}

	// Token: 0x04000D54 RID: 3412
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000D54")]
	public Transform shoot3;
}
