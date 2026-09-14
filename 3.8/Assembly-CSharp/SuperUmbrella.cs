using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200044E RID: 1102
[Token(Token = "0x200044E")]
public class SuperUmbrella : MoneyUmbrella
{
	// Token: 0x0600145B RID: 5211 RVA: 0x00071934 File Offset: 0x0006FB34
	[Token(Token = "0x600145B")]
	[Address(RVA = "0x475EC0", Offset = "0x4744C0", VA = "0x180475EC0", Slot = "72")]
	protected override void ConvertZombie(Zombie zombie, float goldRatio, float silverRatio)
	{
		if (!zombie.beforeDying)
		{
			int thePlantRow = this.thePlantRow;
			if (zombie.theZombieRow == thePlantRow)
			{
				int num = 0;
				int num2 = 0;
				zombie.Garliced(num2 != 0, num != 0);
			}
			return;
		}
		int theZombieType = (int)zombie.theZombieType;
		bool flag;
		if (!flag)
		{
			if (zombie.BoxType == BoxType.Water)
			{
				Transform axis = zombie.axis;
				CreateItem instance = CreateItem.Instance;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				uint num6;
				Vector3 vector;
				GameObject gameObject = instance.SetCoin(num5, num4, (int)num6, num3, vector, num3 != 0);
			}
			Transform axis2 = zombie.axis;
			CreateZombie instance2 = CreateZombie.Instance;
		}
		Transform axis3 = zombie.axis;
		CreateItem instance3 = CreateItem.Instance;
		int theZombieType2 = (int)zombie.theZombieType;
		bool flag2;
		if (!flag2)
		{
			if (zombie.BoxType == BoxType.Water)
			{
				Transform axis4 = zombie.axis;
				CreateItem instance4 = CreateItem.Instance;
				int num7 = 0;
				int num8 = 0;
				int num9 = 0;
				uint num10;
				Vector3 vector2;
				GameObject gameObject2 = instance4.SetCoin(num9, num8, (int)num10, num7, vector2, num7 != 0);
				Transform axis5 = zombie.axis;
				CreateItem instance5 = CreateItem.Instance;
				int num11 = 0;
				int num12 = 0;
				uint num13;
				Vector3 vector3;
				GameObject gameObject3 = instance5.SetCoin(num12, num11, (int)num13, num7, vector3, num7 != 0);
				Transform axis6 = zombie.axis;
				CreateItem instance6 = CreateItem.Instance;
				int num14 = 0;
				int num15 = 0;
				uint num16;
				Vector3 vector4;
				GameObject gameObject4 = instance6.SetCoin(num15, num14, (int)num16, num7, vector4, num7 != 0);
				uint num17;
				GameAPP.PlaySound((int)num17, 0.5f, 1f);
			}
			Transform axis7 = zombie.axis;
			CreateZombie instance7 = CreateZombie.Instance;
			Transform axis8 = zombie.axis;
			uint num18;
			zombie.Die((int)num18);
		}
		PlantType thePlantType = this.thePlantType;
		Transform axis9 = zombie.axis;
		CreateItem instance8 = CreateItem.Instance;
		int num19 = 0;
		int num20 = 0;
		int num21 = 0;
		uint num22;
		Vector3 vector5;
		GameObject gameObject5 = instance8.SetCoin(num21, num20, (int)num22, num19, vector5, num19 != 0);
		Transform axis10 = zombie.axis;
		CreateItem instance9 = CreateItem.Instance;
		int num23 = 0;
		int num24 = 0;
		uint num25;
		Vector3 vector6;
		GameObject gameObject6 = instance9.SetCoin(num24, num23, (int)num25, num19, vector6, num19 != 0);
		Transform axis11 = zombie.axis;
		CreateItem instance10 = CreateItem.Instance;
		int num26 = 0;
		int num27 = 0;
		uint num28;
		Vector3 vector7;
		GameObject gameObject7 = instance10.SetCoin(num27, num26, (int)num28, num19, vector7, num19 != 0);
		uint num29;
		GameAPP.PlaySound((int)num29, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x0600145C RID: 5212 RVA: 0x00071B38 File Offset: 0x0006FD38
	[Token(Token = "0x600145C")]
	[Address(RVA = "0x475DB0", Offset = "0x4743B0", VA = "0x180475DB0", Slot = "70")]
	protected override void BlockEffect(Zombie zombie)
	{
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(40, this, (DamageType)((uint)4), thePlantType, num != 0UL);
		int num2 = 0;
		int num3 = 0;
		zombie.Garliced(num3 != 0, num2 != 0);
		Plant umbrellaPot = base.UmbrellaPot;
		int num4 = 0;
		if (!(umbrellaPot == num4))
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600145D RID: 5213 RVA: 0x00071B84 File Offset: 0x0006FD84
	[Token(Token = "0x600145D")]
	[Address(RVA = "0x41A9A0", Offset = "0x418FA0", VA = "0x18041A9A0")]
	public SuperUmbrella()
	{
	}
}
