using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C33 RID: 3123
	[Token(Token = "0x2000C33")]
	public class PeaMine : BaseConfig
	{
		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x0600414D RID: 16717 RVA: 0x00156D44 File Offset: 0x00154F44
		[Token(Token = "0x1700056A")]
		public override string Role
		{
			[Token(Token = "0x600414D")]
			[Address(RVA = "0x8351B0", Offset = "0x8337B0", VA = "0x1808351B0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x0600414E RID: 16718 RVA: 0x00156D58 File Offset: 0x00154F58
		[Token(Token = "0x1700056B")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600414E")]
			[Address(RVA = "0x3AB140", Offset = "0x3A9740", VA = "0x1803AB140", Slot = "4")]
			get
			{
				return PlantType.PeaMine;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x0600414F RID: 16719 RVA: 0x00156D6C File Offset: 0x00154F6C
		[Token(Token = "0x1700056C")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600414F")]
			[Address(RVA = "0x835090", Offset = "0x833690", VA = "0x180835090", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1007L);
				upgradeBuff.targetType = (PlantType)((ulong)1240L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004150 RID: 16720 RVA: 0x00156DB4 File Offset: 0x00154FB4
		[Token(Token = "0x6004150")]
		[Address(RVA = "0x82FD50", Offset = "0x82E350", VA = "0x18082FD50", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 19f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004151 RID: 16721 RVA: 0x00156DE8 File Offset: 0x00154FE8
		[Token(Token = "0x6004151")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public PeaMine()
		{
		}
	}
}
