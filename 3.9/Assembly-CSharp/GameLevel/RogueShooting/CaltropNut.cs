using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D58 RID: 3416
	[Token(Token = "0x2000D58")]
	public class CaltropNut : BaseConfig
	{
		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06004715 RID: 18197 RVA: 0x00167970 File Offset: 0x00165B70
		[Token(Token = "0x170007FC")]
		public override string Role
		{
			[Token(Token = "0x6004715")]
			[Address(RVA = "0x8A95B0", Offset = "0x8A7BB0", VA = "0x1808A95B0", Slot = "7")]
			get
			{
				return "输出/防御";
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06004716 RID: 18198 RVA: 0x00167984 File Offset: 0x00165B84
		[Token(Token = "0x170007FD")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004716")]
			[Address(RVA = "0x8A95A0", Offset = "0x8A7BA0", VA = "0x1808A95A0", Slot = "4")]
			get
			{
				return PlantType.CaltropNut;
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06004717 RID: 18199 RVA: 0x00167998 File Offset: 0x00165B98
		[Token(Token = "0x170007FE")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004717")]
			[Address(RVA = "0x8A9490", Offset = "0x8A7A90", VA = "0x1808A9490", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004718 RID: 18200 RVA: 0x001679C4 File Offset: 0x00165BC4
		[Token(Token = "0x6004718")]
		[Address(RVA = "0x8A9410", Offset = "0x8A7A10", VA = "0x1808A9410", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			plant.uncrashable = true;
			TravelData data = TravelMgr.Instance.data;
			PlantType thePlantType = plant.thePlantType;
			data.SetDamage(thePlantType, 4f);
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x00167A00 File Offset: 0x00165C00
		[Token(Token = "0x6004719")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public CaltropNut()
		{
		}
	}
}
