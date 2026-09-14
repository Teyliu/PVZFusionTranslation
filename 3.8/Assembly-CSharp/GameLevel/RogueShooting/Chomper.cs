using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C37 RID: 3127
	[Token(Token = "0x2000C37")]
	public class Chomper : BaseConfig
	{
		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06004166 RID: 16742 RVA: 0x00157010 File Offset: 0x00155210
		[Token(Token = "0x1700057B")]
		public override string Role
		{
			[Token(Token = "0x6004166")]
			[Address(RVA = "0x82F980", Offset = "0x82DF80", VA = "0x18082F980", Slot = "7")]
			get
			{
				return "输出/防御";
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06004167 RID: 16743 RVA: 0x00157024 File Offset: 0x00155224
		[Token(Token = "0x1700057C")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004167")]
			[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "4")]
			get
			{
				return PlantType.Chomper;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06004168 RID: 16744 RVA: 0x00157034 File Offset: 0x00155234
		[Token(Token = "0x1700057D")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004168")]
			[Address(RVA = "0x82F7E0", Offset = "0x82DDE0", VA = "0x18082F7E0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)5L);
				upgradeBuff.targetType = (PlantType)((ulong)1016L);
				int size = list._size;
				UpgradeBuff upgradeBuff2;
				upgradeBuff2.sourceType = (PlantType)((ulong)5L);
				upgradeBuff2.targetType = (PlantType)((ulong)1174L);
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06004169 RID: 16745 RVA: 0x00157094 File Offset: 0x00155294
		[Token(Token = "0x6004169")]
		[Address(RVA = "0x82F740", Offset = "0x82DD40", VA = "0x18082F740", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			bool flag = "{il2cpp field on {'Chomper' (constant value of type Mono.Cecil.TypeReference)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(Chomper).TypeHandle;
		}

		// Token: 0x0600416A RID: 16746 RVA: 0x001570B8 File Offset: 0x001552B8
		[Token(Token = "0x600416A")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public Chomper()
		{
		}
	}
}
