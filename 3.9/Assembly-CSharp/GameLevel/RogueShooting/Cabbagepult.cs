using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D6F RID: 3439
	[Token(Token = "0x2000D6F")]
	public class Cabbagepult : BaseConfig
	{
		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x0600478F RID: 18319 RVA: 0x00168860 File Offset: 0x00166A60
		[Token(Token = "0x17000843")]
		public override string Role
		{
			[Token(Token = "0x600478F")]
			[Address(RVA = "0x8A92A0", Offset = "0x8A78A0", VA = "0x1808A92A0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06004790 RID: 18320 RVA: 0x00168874 File Offset: 0x00166A74
		[Token(Token = "0x17000844")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004790")]
			[Address(RVA = "0x71B300", Offset = "0x719900", VA = "0x18071B300", Slot = "4")]
			get
			{
				return PlantType.Cabbagepult;
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06004791 RID: 18321 RVA: 0x00168884 File Offset: 0x00166A84
		[Token(Token = "0x17000845")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004791")]
			[Address(RVA = "0x8A9100", Offset = "0x8A7700", VA = "0x1808A9100", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06004792 RID: 18322 RVA: 0x001688B8 File Offset: 0x00166AB8
		[Token(Token = "0x6004792")]
		[Address(RVA = "0x8A90B0", Offset = "0x8A76B0", VA = "0x1808A90B0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 14f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004793 RID: 18323 RVA: 0x001688EC File Offset: 0x00166AEC
		[Token(Token = "0x6004793")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public Cabbagepult()
		{
		}
	}
}
