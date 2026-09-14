using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200045E RID: 1118
[Token(Token = "0x200045E")]
public class SuperCaltropPot : Pot
{
	// Token: 0x06001497 RID: 5271 RVA: 0x0007247C File Offset: 0x0007067C
	[Token(Token = "0x6001497")]
	[Address(RVA = "0x4C8680", Offset = "0x4C6C80", VA = "0x1804C8680", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
			float num = this.timer;
			float deltaTime = Time.deltaTime;
			int num2 = 0;
			this.timer = num;
			float butterTime = (float)num2;
			Transform axis = this.axis;
			GameObject gameObject = this.butterPrefab;
			Vector3 vector;
			float z = vector.z;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = this.board.transform;
			GameObject gameObject2;
			LittleSquash component = gameObject2.GetComponent<LittleSquash>();
			LittleSquash squash = component;
			LittleSquash squash4 = squash;
			int thePlantRow = this.thePlantRow;
			squash4.theRow = thePlantRow;
			LittleSquash squash2 = squash;
			PlantType thePlantType = this.thePlantType;
			squash2.thePlantType = thePlantType;
			int thePlantRow2 = this.thePlantRow;
			int thePlantColumn = this.thePlantColumn;
			LittleSquash squash3 = squash;
			List<Plant> list = Lawnf.Get1x1Plants(thePlantColumn, thePlantRow2);
			Func<Plant, int> <>9__2_ = SuperCaltropPot.<>c.<>9__2_0;
			if (<>9__2_ == 0)
			{
				Func<Plant, int> func;
				SuperCaltropPot.<>c.<>9__2_0 = func;
			}
			int attackDamage = Enumerable.FirstOrDefault<Plant>(Enumerable.OrderByDescending<Plant, int>(list, <>9__2_)).attackDamage;
			squash3.theDamage = attackDamage;
			Action<int, int> action;
			squash.crashAction = action;
			this.timer = 8f;
		}
	}

	// Token: 0x06001498 RID: 5272 RVA: 0x000725AC File Offset: 0x000707AC
	[Token(Token = "0x6001498")]
	[Address(RVA = "0x4C8620", Offset = "0x4C6C20", VA = "0x1804C8620", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason == Plant.DieReason.ByShovel)
		{
			Transform axis = this.axis;
			return;
		}
	}

	// Token: 0x06001499 RID: 5273 RVA: 0x000725CC File Offset: 0x000707CC
	[Token(Token = "0x6001499")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public SuperCaltropPot()
	{
	}

	// Token: 0x04000D34 RID: 3380
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000D34")]
	public GameObject butterPrefab;

	// Token: 0x04000D35 RID: 3381
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000D35")]
	private float timer;
}
