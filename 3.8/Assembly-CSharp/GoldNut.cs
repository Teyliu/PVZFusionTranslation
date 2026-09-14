using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000396 RID: 918
[Token(Token = "0x2000396")]
public class GoldNut : WallNut
{
	// Token: 0x060010D6 RID: 4310 RVA: 0x00060348 File Offset: 0x0005E548
	[Token(Token = "0x60010D6")]
	[Address(RVA = "0x438620", Offset = "0x436C20", VA = "0x180438620", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int attributeCount = this.attributeCount;
	}

	// Token: 0x060010D7 RID: 4311 RVA: 0x00060364 File Offset: 0x0005E564
	[Token(Token = "0x60010D7")]
	[Address(RVA = "0x438650", Offset = "0x436C50", VA = "0x180438650", Slot = "43")]
	public override bool SuperSkill()
	{
		float flashCountDown = this.flashCountDown;
		int num = 0;
		if (flashCountDown <= (float)num)
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			int num2 = 0;
			ulong num3;
			ulong num4;
			base.Recover(z, (DamageType)num2, num3 != 0UL, num4 != 0UL);
			uint num5;
			GameAPP.PlaySound((int)num5, 0.5f, 1f);
			this.flashCountDown = 5f;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060010D8 RID: 4312 RVA: 0x000603C4 File Offset: 0x0005E5C4
	[Token(Token = "0x60010D8")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public GoldNut()
	{
	}
}
