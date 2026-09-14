using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C3C RID: 3132
	[Token(Token = "0x2000C3C")]
	public class BigChomper : BaseConfig
	{
		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06004184 RID: 16772 RVA: 0x00157398 File Offset: 0x00155598
		[Token(Token = "0x1700058F")]
		public override string Role
		{
			[Token(Token = "0x6004184")]
			[Address(RVA = "0x82E240", Offset = "0x82C840", VA = "0x18082E240", Slot = "7")]
			get
			{
				return "防御";
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06004185 RID: 16773 RVA: 0x001573AC File Offset: 0x001555AC
		[Token(Token = "0x17000590")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004185")]
			[Address(RVA = "0x82E230", Offset = "0x82C830", VA = "0x18082E230", Slot = "4")]
			get
			{
				return PlantType.BigChomper;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06004186 RID: 16774 RVA: 0x001573C0 File Offset: 0x001555C0
		[Token(Token = "0x17000591")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004186")]
			[Address(RVA = "0x82E110", Offset = "0x82C710", VA = "0x18082E110", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1174L);
				upgradeBuff.targetType = (PlantType)((ulong)951L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004187 RID: 16775 RVA: 0x00157408 File Offset: 0x00155608
		[Token(Token = "0x6004187")]
		[Address(RVA = "0x82E070", Offset = "0x82C670", VA = "0x18082E070", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			bool flag = "{il2cpp field on {'Chomper' (constant value of type Mono.Cecil.TypeReference)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(Chomper).TypeHandle;
		}

		// Token: 0x06004188 RID: 16776 RVA: 0x0015742C File Offset: 0x0015562C
		[Token(Token = "0x6004188")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public BigChomper()
		{
		}
	}
}
