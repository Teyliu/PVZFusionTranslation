using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000413 RID: 1043
[Token(Token = "0x2000413")]
public class PeaPot : Pot
{
	// Token: 0x0600132E RID: 4910 RVA: 0x0006B2BC File Offset: 0x000694BC
	[Token(Token = "0x600132E")]
	[Address(RVA = "0x4B02E0", Offset = "0x4AE8E0", VA = "0x1804B02E0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)6), action, num != 0);
	}

	// Token: 0x0600132F RID: 4911 RVA: 0x0006B2E4 File Offset: 0x000694E4
	[Token(Token = "0x600132F")]
	[Address(RVA = "0x4AFFA0", Offset = "0x4AE5A0", VA = "0x1804AFFA0", Slot = "68")]
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

	// Token: 0x06001330 RID: 4912 RVA: 0x0006B3AC File Offset: 0x000695AC
	[Token(Token = "0x6001330")]
	[Address(RVA = "0x4AFEF0", Offset = "0x4AE4F0", VA = "0x1804AFEF0", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)6), action);
	}

	// Token: 0x06001331 RID: 4913 RVA: 0x0006B3C8 File Offset: 0x000695C8
	[Token(Token = "0x6001331")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public PeaPot()
	{
	}
}
