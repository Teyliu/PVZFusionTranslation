using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000458 RID: 1112
[Token(Token = "0x2000458")]
public class ThreePlantern : Plantern
{
	// Token: 0x06001482 RID: 5250 RVA: 0x0007242C File Offset: 0x0007062C
	[Token(Token = "0x6001482")]
	[Address(RVA = "0x4786C0", Offset = "0x476CC0", VA = "0x1804786C0", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		CreatePlant instance = CreatePlant.Instance;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		ulong num;
		instance.AdjustLightLevel(thePlantColumn, thePlantRow, -3, (int)num);
		global::UnityEngine.Object.Destroy(this.lanternLight);
	}

	// Token: 0x06001483 RID: 5251 RVA: 0x0007246C File Offset: 0x0007066C
	[Token(Token = "0x6001483")]
	[Address(RVA = "0x478810", Offset = "0x476E10", VA = "0x180478810", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, originalRow, -3, (int)num);
		ulong num2;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, (int)num2, 3, (int)num);
	}

	// Token: 0x06001484 RID: 5252 RVA: 0x000724A0 File Offset: 0x000706A0
	[Token(Token = "0x6001484")]
	[Address(RVA = "0x478780", Offset = "0x476D80", VA = "0x180478780", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(theColumn, theRow, 3, (int)num);
	}

	// Token: 0x06001485 RID: 5253 RVA: 0x000724C4 File Offset: 0x000706C4
	[Token(Token = "0x6001485")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public ThreePlantern()
	{
	}

	// Token: 0x04000CC8 RID: 3272
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000CC8")]
	public Transform shoot3;
}
