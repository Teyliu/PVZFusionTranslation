using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000522 RID: 1314
[Token(Token = "0x2000522")]
public class JalaStar : Plant
{
	// Token: 0x0600186E RID: 6254 RVA: 0x00084D98 File Offset: 0x00082F98
	[Token(Token = "0x600186E")]
	[Address(RVA = "0x4013E0", Offset = "0x3FF9E0", VA = "0x1804013E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x0600186F RID: 6255 RVA: 0x00084DB8 File Offset: 0x00082FB8
	[Token(Token = "0x600186F")]
	[Address(RVA = "0x4D0610", Offset = "0x4CEC10", VA = "0x1804D0610", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.SetTrigger("shake");
		GameAPP.PlaySound(39, 0.5f, 1f);
	}

	// Token: 0x06001870 RID: 6256 RVA: 0x00084DF4 File Offset: 0x00082FF4
	[Token(Token = "0x6001870")]
	[Address(RVA = "0x41C540", Offset = "0x41AB40", VA = "0x18041C540", Slot = "40")]
	protected override void AttributeEvent()
	{
	}

	// Token: 0x06001871 RID: 6257 RVA: 0x00084E04 File Offset: 0x00083004
	[Token(Token = "0x6001871")]
	[Address(RVA = "0x4D0210", Offset = "0x4CE810", VA = "0x1804D0210", Slot = "52")]
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

	// Token: 0x06001872 RID: 6258 RVA: 0x00084ED8 File Offset: 0x000830D8
	[Token(Token = "0x6001872")]
	[Address(RVA = "0x4D01E0", Offset = "0x4CE7E0", VA = "0x1804D01E0", Slot = "35")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		this.isCrashed = true;
	}

	// Token: 0x06001873 RID: 6259 RVA: 0x00084EF0 File Offset: 0x000830F0
	[Token(Token = "0x6001873")]
	[Address(RVA = "0x4D06A0", Offset = "0x4CECA0", VA = "0x1804D06A0")]
	public JalaStar()
	{
		List<Transform> list = new List();
		this.shoots = list;
		base..ctor();
	}

	// Token: 0x04000E0D RID: 3597
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000E0D")]
	public List<Transform> shoots;
}
