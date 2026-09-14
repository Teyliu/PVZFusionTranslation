using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D2B RID: 3371
	[Token(Token = "0x2000D2B")]
	public class HypnoShroom : BaseConfig
	{
		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06004613 RID: 17939 RVA: 0x00165AE4 File Offset: 0x00163CE4
		[Token(Token = "0x1700075F")]
		public override string Role
		{
			[Token(Token = "0x6004613")]
			[Address(RVA = "0x8AE010", Offset = "0x8AC610", VA = "0x1808AE010", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06004614 RID: 17940 RVA: 0x00165AF8 File Offset: 0x00163CF8
		[Token(Token = "0x17000760")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004614")]
			[Address(RVA = "0x3F6B70", Offset = "0x3F5170", VA = "0x1803F6B70", Slot = "4")]
			get
			{
				return PlantType.HypnoShroom;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06004615 RID: 17941 RVA: 0x00165B08 File Offset: 0x00163D08
		[Token(Token = "0x17000761")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004615")]
			[Address(RVA = "0x8ADF00", Offset = "0x8AC500", VA = "0x1808ADF00", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004616 RID: 17942 RVA: 0x00165B34 File Offset: 0x00163D34
		[Token(Token = "0x6004616")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x06004617 RID: 17943 RVA: 0x00165B44 File Offset: 0x00163D44
		[Token(Token = "0x6004617")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public HypnoShroom()
		{
		}
	}
}
