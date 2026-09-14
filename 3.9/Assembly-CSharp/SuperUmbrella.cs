using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200046E RID: 1134
[Token(Token = "0x200046E")]
public class SuperUmbrella : MoneyUmbrella
{
	// Token: 0x060014EB RID: 5355 RVA: 0x00073C74 File Offset: 0x00071E74
	[Token(Token = "0x60014EB")]
	[Address(RVA = "0x4CD770", Offset = "0x4CBD70", VA = "0x1804CD770", Slot = "73")]
	protected override void ConvertZombie(Zombie zombie, float goldRatio, float silverRatio)
	{
		int num = 0;
		if (goldRatio <= (float)num)
		{
			if (silverRatio <= (float)num && !zombie.beforeDying)
			{
				int thePlantRow = this.thePlantRow;
				if (zombie.theZombieRow == thePlantRow)
				{
					int num2 = 0;
					int num3 = 0;
					zombie.Garliced(num3 != 0, num2 != 0);
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
					int num4 = 0;
					int num5 = 0;
					int num6 = 0;
					uint num7;
					Vector3 vector;
					GameObject gameObject = instance.SetCoin(num6, num5, (int)num7, num4, vector, num4 != 0);
				}
				Transform axis2 = zombie.axis;
				CreateZombie instance2 = CreateZombie.Instance;
			}
			Transform axis3 = zombie.axis;
			CreateItem instance3 = CreateItem.Instance;
		}
		int theZombieType2 = (int)zombie.theZombieType;
		bool flag2;
		if (!flag2)
		{
			if (zombie.BoxType == BoxType.Water)
			{
				Transform axis4 = zombie.axis;
				CreateItem instance4 = CreateItem.Instance;
				int num8 = 0;
				int num9 = 0;
				int num10 = 0;
				uint num11;
				Vector3 vector2;
				GameObject gameObject2 = instance4.SetCoin(num10, num9, (int)num11, num8, vector2, num8 != 0);
				Transform axis5 = zombie.axis;
				CreateItem instance5 = CreateItem.Instance;
				int num12 = 0;
				int num13 = 0;
				uint num14;
				Vector3 vector3;
				GameObject gameObject3 = instance5.SetCoin(num13, num12, (int)num14, num8, vector3, num8 != 0);
				Transform axis6 = zombie.axis;
				CreateItem instance6 = CreateItem.Instance;
				int num15 = 0;
				int num16 = 0;
				uint num17;
				Vector3 vector4;
				GameObject gameObject4 = instance6.SetCoin(num16, num15, (int)num17, num8, vector4, num8 != 0);
				uint num18;
				GameAPP.PlaySound((int)num18, 0.5f, 1f);
			}
			Transform axis7 = zombie.axis;
			CreateZombie instance7 = CreateZombie.Instance;
			Transform axis8 = zombie.axis;
			uint num19;
			zombie.Die((int)num19);
		}
		PlantType thePlantType = this.thePlantType;
		Transform axis9 = zombie.axis;
		CreateItem instance8 = CreateItem.Instance;
		int num20 = 0;
		int num21 = 0;
		int num22 = 0;
		uint num23;
		Vector3 vector5;
		GameObject gameObject5 = instance8.SetCoin(num22, num21, (int)num23, num20, vector5, num20 != 0);
		Transform axis10 = zombie.axis;
		CreateItem instance9 = CreateItem.Instance;
		int num24 = 0;
		int num25 = 0;
		uint num26;
		Vector3 vector6;
		GameObject gameObject6 = instance9.SetCoin(num25, num24, (int)num26, num20, vector6, num20 != 0);
		Transform axis11 = zombie.axis;
		CreateItem instance10 = CreateItem.Instance;
		int num27 = 0;
		int num28 = 0;
		uint num29;
		Vector3 vector7;
		GameObject gameObject7 = instance10.SetCoin(num28, num27, (int)num29, num20, vector7, num20 != 0);
		uint num30;
		GameAPP.PlaySound((int)num30, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x060014EC RID: 5356 RVA: 0x00073E88 File Offset: 0x00072088
	[Token(Token = "0x60014EC")]
	[Address(RVA = "0x4CD660", Offset = "0x4CBC60", VA = "0x1804CD660", Slot = "70")]
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

	// Token: 0x060014ED RID: 5357 RVA: 0x00073ED4 File Offset: 0x000720D4
	[Token(Token = "0x60014ED")]
	[Address(RVA = "0x497370", Offset = "0x495970", VA = "0x180497370")]
	public SuperUmbrella()
	{
	}
}
