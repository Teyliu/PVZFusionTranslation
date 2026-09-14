using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200043F RID: 1087
[Token(Token = "0x200043F")]
public class SuperCaltropPot : Pot
{
	// Token: 0x0600140D RID: 5133 RVA: 0x000701D0 File Offset: 0x0006E3D0
	[Token(Token = "0x600140D")]
	[Address(RVA = "0x470E20", Offset = "0x46F420", VA = "0x180470E20", Slot = "16")]
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

	// Token: 0x0600140E RID: 5134 RVA: 0x00070300 File Offset: 0x0006E500
	[Token(Token = "0x600140E")]
	[Address(RVA = "0x470DC0", Offset = "0x46F3C0", VA = "0x180470DC0", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason == Plant.DieReason.ByShovel)
		{
			Transform axis = this.axis;
			return;
		}
	}

	// Token: 0x0600140F RID: 5135 RVA: 0x00070320 File Offset: 0x0006E520
	[Token(Token = "0x600140F")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public SuperCaltropPot()
	{
	}

	// Token: 0x04000CAA RID: 3242
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000CAA")]
	public GameObject butterPrefab;

	// Token: 0x04000CAB RID: 3243
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000CAB")]
	private float timer;
}
