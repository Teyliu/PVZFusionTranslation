using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C73 RID: 3187
	[Token(Token = "0x2000C73")]
	public class ThreeSquash : BaseConfig
	{
		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x060042BD RID: 17085 RVA: 0x001596E4 File Offset: 0x001578E4
		[Token(Token = "0x17000655")]
		public override string Role
		{
			[Token(Token = "0x60042BD")]
			[Address(RVA = "0x83C010", Offset = "0x83A610", VA = "0x18083C010", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060042BE RID: 17086 RVA: 0x001596F8 File Offset: 0x001578F8
		[Token(Token = "0x17000656")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60042BE")]
			[Address(RVA = "0x83C000", Offset = "0x83A600", VA = "0x18083C000", Slot = "4")]
			get
			{
				return PlantType.ThreeSquash;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x060042BF RID: 17087 RVA: 0x0015970C File Offset: 0x0015790C
		[Token(Token = "0x17000657")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60042BF")]
			[Address(RVA = "0x83BEE0", Offset = "0x83A4E0", VA = "0x18083BEE0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1047L);
				upgradeBuff.targetType = (PlantType)((ulong)919L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060042C0 RID: 17088 RVA: 0x00159754 File Offset: 0x00157954
		[Token(Token = "0x60042C0")]
		[Address(RVA = "0x83BDD0", Offset = "0x83A3D0", VA = "0x18083BDD0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
			Action<object> action;
			EventManager.RemoveListener((GameEvent)((uint)5), action);
			int num3 = 0;
			Action<object> action2;
			EventManager.AddListener_obj((GameEvent)((uint)5), action2, num3 != 0);
		}

		// Token: 0x060042C1 RID: 17089 RVA: 0x00159794 File Offset: 0x00157994
		[Token(Token = "0x60042C1")]
		[Address(RVA = "0x83BD20", Offset = "0x83A320", VA = "0x18083BD20")]
		private void OnZombieTakeDamage(object obj)
		{
			if (obj == 0 || obj != 0)
			{
			}
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x001597B0 File Offset: 0x001579B0
		[Token(Token = "0x60042C2")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public ThreeSquash()
		{
		}
	}
}
