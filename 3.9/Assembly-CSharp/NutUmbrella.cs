using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200040A RID: 1034
[Token(Token = "0x200040A")]
public class NutUmbrella : CornUmbrella
{
	// Token: 0x0600130A RID: 4874 RVA: 0x0006A9E8 File Offset: 0x00068BE8
	[Token(Token = "0x600130A")]
	[Address(RVA = "0x4AC8C0", Offset = "0x4AAEC0", VA = "0x1804AC8C0", Slot = "70")]
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

	// Token: 0x0600130B RID: 4875 RVA: 0x0006AA24 File Offset: 0x00068C24
	[Token(Token = "0x600130B")]
	[Address(RVA = "0x466C80", Offset = "0x465280", VA = "0x180466C80", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x0600130C RID: 4876 RVA: 0x0006AA34 File Offset: 0x00068C34
	[Token(Token = "0x600130C")]
	[Address(RVA = "0x4AC9B0", Offset = "0x4AAFB0", VA = "0x1804AC9B0", Slot = "28")]
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

	// Token: 0x0600130D RID: 4877 RVA: 0x0006ABE4 File Offset: 0x00068DE4
	[Token(Token = "0x600130D")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public NutUmbrella()
	{
	}
}
