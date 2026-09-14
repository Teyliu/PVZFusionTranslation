using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005CC RID: 1484
[Token(Token = "0x20005CC")]
public class TowerNut : TowerPlant
{
	// Token: 0x06001BBF RID: 7103 RVA: 0x00094794 File Offset: 0x00092994
	[Token(Token = "0x6001BBF")]
	[Address(RVA = "0x41A120", Offset = "0x418720", VA = "0x18041A120", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06001BC0 RID: 7104 RVA: 0x000947A4 File Offset: 0x000929A4
	[Token(Token = "0x6001BC0")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "47")]
	protected override bool Shootable()
	{
		return false;
	}

	// Token: 0x06001BC1 RID: 7105 RVA: 0x000947B4 File Offset: 0x000929B4
	[Token(Token = "0x6001BC1")]
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

	// Token: 0x06001BC2 RID: 7106 RVA: 0x00094908 File Offset: 0x00092B08
	[Token(Token = "0x6001BC2")]
	[Address(RVA = "0x50C5A0", Offset = "0x50ABA0", VA = "0x18050C5A0", Slot = "76")]
	protected virtual void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			this.thePlantSpeed = 0f;
		}
	}

	// Token: 0x06001BC3 RID: 7107 RVA: 0x00094934 File Offset: 0x00092B34
	[Token(Token = "0x6001BC3")]
	[Address(RVA = "0x42A060", Offset = "0x428660", VA = "0x18042A060", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		float theOriginSpeed = this.theOriginSpeed;
		this.thePlantSpeed = theOriginSpeed;
	}

	// Token: 0x06001BC4 RID: 7108 RVA: 0x00094958 File Offset: 0x00092B58
	[Token(Token = "0x6001BC4")]
	[Address(RVA = "0x50C640", Offset = "0x50AC40", VA = "0x18050C640")]
	public TowerNut()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}
}
