using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D3E RID: 3390
	[Token(Token = "0x2000D3E")]
	public class Squash : BaseConfig
	{
		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x0600467A RID: 18042 RVA: 0x001665BC File Offset: 0x001647BC
		[Token(Token = "0x1700079D")]
		public override string Role
		{
			[Token(Token = "0x600467A")]
			[Address(RVA = "0x8B5D90", Offset = "0x8B4390", VA = "0x1808B5D90", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x0600467B RID: 18043 RVA: 0x001665D0 File Offset: 0x001647D0
		[Token(Token = "0x1700079E")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600467B")]
			[Address(RVA = "0x3F6DC0", Offset = "0x3F53C0", VA = "0x1803F6DC0", Slot = "4")]
			get
			{
				return PlantType.Squash;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x0600467C RID: 18044 RVA: 0x001665E0 File Offset: 0x001647E0
		[Token(Token = "0x1700079F")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600467C")]
			[Address(RVA = "0x8B5BF0", Offset = "0x8B41F0", VA = "0x1808B5BF0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600467D RID: 18045 RVA: 0x00166614 File Offset: 0x00164814
		[Token(Token = "0x600467D")]
		[Address(RVA = "0x8A98D0", Offset = "0x8A7ED0", VA = "0x1808A98D0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 1f, num2 != 0, num);
		}

		// Token: 0x0600467E RID: 18046 RVA: 0x0016663C File Offset: 0x0016483C
		[Token(Token = "0x600467E")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public Squash()
		{
		}
	}
}
