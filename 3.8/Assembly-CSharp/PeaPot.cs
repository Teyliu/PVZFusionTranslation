using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003F9 RID: 1017
[Token(Token = "0x20003F9")]
public class PeaPot : Pot
{
	// Token: 0x060012BB RID: 4795 RVA: 0x00069508 File Offset: 0x00067708
	[Token(Token = "0x60012BB")]
	[Address(RVA = "0x459F90", Offset = "0x458590", VA = "0x180459F90", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)6), action, num != 0);
	}

	// Token: 0x060012BC RID: 4796 RVA: 0x00069530 File Offset: 0x00067730
	[Token(Token = "0x60012BC")]
	[Address(RVA = "0x459C50", Offset = "0x458250", VA = "0x180459C50", Slot = "69")]
	protected virtual void OnPlantShoot(object obj)
	{
		int num = 0;
		if (obj != 0 && obj != 0)
		{
			int thePlantColumn = this.thePlantColumn;
			int thePlantRow = this.thePlantRow;
			Dictionary<PlantType, int> peaPlant = PeaPumpkin.PeaPlant;
			bool flag;
			if (flag)
			{
				int num2 = this.attributeCount;
				num2++;
				this.attributeCount = num2;
				if (num2 == 30)
				{
					this.attributeCount = num;
					int num3 = 0;
					Bullet bullet;
					if (bullet != num3)
					{
						Transform transform = bullet.transform;
						Transform transform2 = bullet.transform;
						Vector3 vector;
						float z = vector.z;
						float num4 = global::UnityEngine.Random.Range(-0.3f, 0.5f);
						Vector3 vector2;
						float z2 = vector2.z;
						float num5 = global::UnityEngine.Random.Range(-0.3f, 0.3f);
						Vector3 vector3;
						float z3 = vector3.z;
					}
					num++;
				}
			}
		}
	}

	// Token: 0x060012BD RID: 4797 RVA: 0x000695F8 File Offset: 0x000677F8
	[Token(Token = "0x60012BD")]
	[Address(RVA = "0x459BA0", Offset = "0x4581A0", VA = "0x180459BA0", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)6), action);
	}

	// Token: 0x060012BE RID: 4798 RVA: 0x00069614 File Offset: 0x00067814
	[Token(Token = "0x60012BE")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public PeaPot()
	{
	}
}
