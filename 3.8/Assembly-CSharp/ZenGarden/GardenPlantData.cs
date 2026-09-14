using System;
using Cpp2IlInjected;
using UnityEngine;

namespace ZenGarden
{
	// Token: 0x02000A24 RID: 2596
	[Token(Token = "0x2000A24")]
	[Serializable]
	public class GardenPlantData
	{
		// Token: 0x0600357B RID: 13691 RVA: 0x0011F624 File Offset: 0x0011D824
		[Token(Token = "0x600357B")]
		[Address(RVA = "0x751160", Offset = "0x74F760", VA = "0x180751160")]
		public GardenPlantData(int thePlantColumn, int thePlantRow, PlantType thePlantType, int page)
		{
			this.thePlantColumn = thePlantColumn;
			this.thePlantType = thePlantType;
			this.page = 0;
			this.thePlantRow = thePlantRow;
		}

		// Token: 0x0600357C RID: 13692 RVA: 0x0011F660 File Offset: 0x0011D860
		[Token(Token = "0x600357C")]
		[Address(RVA = "0x751060", Offset = "0x74F660", VA = "0x180751060")]
		public GardenPlant CreatePlant(GardenUI manager)
		{
			int num = this.thePlantColumn;
			PlantType plantType = this.thePlantType;
			Transform transform = manager.background.transform;
			GardenPlant gardenPlant;
			GardenPlant component = gardenPlant.GetComponent<GardenPlant>();
			component.data = this;
			return component;
		}

		// Token: 0x040028C8 RID: 10440
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40028C8")]
		public int thePlantRow;

		// Token: 0x040028C9 RID: 10441
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40028C9")]
		public int thePlantColumn;

		// Token: 0x040028CA RID: 10442
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40028CA")]
		public PlantType thePlantType;

		// Token: 0x040028CB RID: 10443
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40028CB")]
		public int growStage;

		// Token: 0x040028CC RID: 10444
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40028CC")]
		public int waterLevel;

		// Token: 0x040028CD RID: 10445
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40028CD")]
		public int love;

		// Token: 0x040028CE RID: 10446
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40028CE")]
		public long nextTime;

		// Token: 0x040028CF RID: 10447
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40028CF")]
		public GardenToolType needTool = (GardenToolType)((ulong)1L);

		// Token: 0x040028D0 RID: 10448
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40028D0")]
		public int page;
	}
}
