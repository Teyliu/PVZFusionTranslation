using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003F0 RID: 1008
[Token(Token = "0x20003F0")]
public class NutUmbrella : CornUmbrella
{
	// Token: 0x06001297 RID: 4759 RVA: 0x00068C3C File Offset: 0x00066E3C
	[Token(Token = "0x6001297")]
	[Address(RVA = "0x457430", Offset = "0x455A30", VA = "0x180457430", Slot = "70")]
	protected override void BlockEffect(Zombie zombie)
	{
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(40, this, (DamageType)((uint)4), thePlantType, num != 0UL);
		Plant umbrellaPot = base.UmbrellaPot;
		int num2 = 0;
		if (!(umbrellaPot == num2))
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001298 RID: 4760 RVA: 0x00068C78 File Offset: 0x00066E78
	[Token(Token = "0x6001298")]
	[Address(RVA = "0x41A120", Offset = "0x418720", VA = "0x18041A120", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06001299 RID: 4761 RVA: 0x00068C88 File Offset: 0x00066E88
	[Token(Token = "0x6001299")]
	[Address(RVA = "0x457520", Offset = "0x455B20", VA = "0x180457520", Slot = "29")]
	protected override void ReplaceSprite()
	{
		int num;
		do
		{
			num = 0;
			IEnumerator enumerator = this._sortingGroup.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				enumerator += enumerator;
				int num2 = this.thePlantMaxHealth;
				num2 += num2;
				Transform transform;
				ulong num3;
				transform.gameObject.SetActive(num3 != 0UL);
				Transform transform2;
				GameObject gameObject = transform2.gameObject;
				int num4 = 0;
				gameObject.SetActive(num4 != 0);
				Transform transform3;
				GameObject gameObject2 = transform3.gameObject;
				int num5 = 0;
				gameObject2.SetActive(num5 != 0);
				num5 += num5;
				int num6 = this.thePlantMaxHealth;
				num6 += num6;
				Transform transform4;
				GameObject gameObject3 = transform4.gameObject;
				int num7 = 0;
				gameObject3.SetActive(num7 != 0);
				Transform transform5;
				ulong num8;
				transform5.gameObject.SetActive(num8 != 0UL);
				Transform transform6;
				GameObject gameObject4 = transform6.gameObject;
				int num9 = 0;
				gameObject4.SetActive(num9 != 0);
				num9 += num9;
				Transform transform7;
				GameObject gameObject5 = transform7.gameObject;
				int num10 = 0;
				gameObject5.SetActive(num10 != 0);
				Transform transform8;
				GameObject gameObject6 = transform8.gameObject;
				int num11 = 0;
				gameObject6.SetActive(num11 != 0);
				Transform transform9;
				ulong num12;
				transform9.gameObject.SetActive(num12 != 0UL);
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x0600129A RID: 4762 RVA: 0x00068E38 File Offset: 0x00067038
	[Token(Token = "0x600129A")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public NutUmbrella()
	{
	}
}
