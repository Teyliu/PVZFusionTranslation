using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200049A RID: 1178
[Token(Token = "0x200049A")]
public class WallNut : Plant
{
	// Token: 0x06001611 RID: 5649 RVA: 0x0007A718 File Offset: 0x00078918
	[Token(Token = "0x6001611")]
	[Address(RVA = "0x41A120", Offset = "0x418720", VA = "0x18041A120", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06001612 RID: 5650 RVA: 0x0007A728 File Offset: 0x00078928
	[Token(Token = "0x6001612")]
	[Address(RVA = "0x472240", Offset = "0x470840", VA = "0x180472240", Slot = "29")]
	protected override void ReplaceSprite()
	{
		int num = this.thePlantMaxHealth;
		num += num;
		Transform transform = base.transform;
		int num2 = 0;
		ulong num3;
		transform.GetChild(num2).gameObject.SetActive(num3 != 0UL);
		uint num4;
		GameObject gameObject = base.transform.GetChild((int)num4).gameObject;
		int num5 = 0;
		gameObject.SetActive(num5 != 0);
		uint num6;
		GameObject gameObject2 = base.transform.GetChild((int)num6).gameObject;
		int num7 = 0;
		gameObject2.SetActive(num7 != 0);
		int num8 = this.thePlantMaxHealth;
		num8 += num8;
		Transform transform2 = base.transform;
		int num9 = 0;
		GameObject gameObject3 = transform2.GetChild(num9).gameObject;
		int num10 = 0;
		gameObject3.SetActive(num10 != 0);
		uint num11;
		ulong num12;
		base.transform.GetChild((int)num11).gameObject.SetActive(num12 != 0UL);
		uint num13;
		GameObject gameObject4 = base.transform.GetChild((int)num13).gameObject;
		int num14 = 0;
		gameObject4.SetActive(num14 != 0);
		num14 += num14;
		Transform transform3 = base.transform;
		int num15 = 0;
		GameObject gameObject5 = transform3.GetChild(num15).gameObject;
		int num16 = 0;
		gameObject5.SetActive(num16 != 0);
		uint num17;
		GameObject gameObject6 = base.transform.GetChild((int)num17).gameObject;
		int num18 = 0;
		gameObject6.SetActive(num18 != 0);
		uint num19;
		ulong num20;
		base.transform.GetChild((int)num19).gameObject.SetActive(num20 != 0UL);
	}

	// Token: 0x06001613 RID: 5651 RVA: 0x0007A87C File Offset: 0x00078A7C
	[Token(Token = "0x6001613")]
	[Address(RVA = "0x4AD450", Offset = "0x4ABA50", VA = "0x1804AD450", Slot = "69")]
	protected virtual void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			this.thePlantSpeed = 0f;
		}
	}

	// Token: 0x06001614 RID: 5652 RVA: 0x0007A8A8 File Offset: 0x00078AA8
	[Token(Token = "0x6001614")]
	[Address(RVA = "0x42A060", Offset = "0x428660", VA = "0x18042A060", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		float theOriginSpeed = this.theOriginSpeed;
		this.thePlantSpeed = theOriginSpeed;
	}

	// Token: 0x06001615 RID: 5653 RVA: 0x0007A8CC File Offset: 0x00078ACC
	[Token(Token = "0x6001615")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public WallNut()
	{
	}
}
