using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200054F RID: 1359
[Token(Token = "0x200054F")]
public class JalaStar : Plant
{
	// Token: 0x0600193D RID: 6461 RVA: 0x0008892C File Offset: 0x00086B2C
	[Token(Token = "0x600193D")]
	[Address(RVA = "0x4454A0", Offset = "0x443AA0", VA = "0x1804454A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x0600193E RID: 6462 RVA: 0x0008894C File Offset: 0x00086B4C
	[Token(Token = "0x600193E")]
	[Address(RVA = "0x52CF40", Offset = "0x52B540", VA = "0x18052CF40", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.SetTrigger("shake");
		GameAPP.PlaySound(39, 0.5f, 1f);
	}

	// Token: 0x0600193F RID: 6463 RVA: 0x00088988 File Offset: 0x00086B88
	[Token(Token = "0x600193F")]
	[Address(RVA = "0x4733E0", Offset = "0x4719E0", VA = "0x1804733E0", Slot = "39")]
	protected override void AttributeEvent()
	{
	}

	// Token: 0x06001940 RID: 6464 RVA: 0x00088998 File Offset: 0x00086B98
	[Token(Token = "0x6001940")]
	[Address(RVA = "0x52CB40", Offset = "0x52B140", VA = "0x18052CB40", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		int num2;
		do
		{
			int num = 0;
			BoardAction boardAction = this.board.boardAction;
			PlantType thePlantType = this.thePlantType;
			num2 = 0;
			int num3 = 0;
			int attackDamage = this.attackDamage;
			int thePlantRow = this.thePlantRow;
			ulong num4;
			boardAction.CreateFireLine(thePlantRow, attackDamage, num3 != 0, num2 != 0, num4 != 0UL, num2, thePlantType);
			List<Transform> list = this.shoots;
			bool flag;
			if (flag)
			{
				CreateBullet instance = CreateBullet.Instance;
				num += num;
				Bullet bullet;
				bullet.Damage = num;
				float normalSpeed = bullet.normalSpeed;
				bullet.normalSpeed = normalSpeed;
				PlantType thePlantType2 = this.thePlantType;
				bullet.fromType = thePlantType2;
				Transform transform = bullet.transform;
				Vector3 vector;
				float z = vector.z;
				Vector3 vector2;
				vector2 += vector2;
				uint num5;
				num5 += (uint)1;
			}
		}
		while (num2 != 0);
	}

	// Token: 0x06001941 RID: 6465 RVA: 0x00088A6C File Offset: 0x00086C6C
	[Token(Token = "0x6001941")]
	[Address(RVA = "0x52CB10", Offset = "0x52B110", VA = "0x18052CB10", Slot = "34")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		this.isCrashed = true;
	}

	// Token: 0x06001942 RID: 6466 RVA: 0x00088A84 File Offset: 0x00086C84
	[Token(Token = "0x6001942")]
	[Address(RVA = "0x52CFD0", Offset = "0x52B5D0", VA = "0x18052CFD0")]
	public JalaStar()
	{
		List<Transform> list = new List();
		this.shoots = list;
		base..ctor();
	}

	// Token: 0x04000EC6 RID: 3782
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000EC6")]
	public List<Transform> shoots;
}
