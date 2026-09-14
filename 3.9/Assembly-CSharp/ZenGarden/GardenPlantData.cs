using System;
using Cpp2IlInjected;
using UnityEngine;

namespace ZenGarden
{
	// Token: 0x02000A64 RID: 2660
	[Token(Token = "0x2000A64")]
	[Serializable]
	public class GardenPlantData
	{
		// Token: 0x060036BE RID: 14014 RVA: 0x001248C0 File Offset: 0x00122AC0
		[Token(Token = "0x60036BE")]
		[Address(RVA = "0x7B7C90", Offset = "0x7B6290", VA = "0x1807B7C90")]
		public GardenPlantData(int thePlantColumn, int thePlantRow, PlantType thePlantType, int page)
		{
			this.thePlantColumn = thePlantColumn;
			this.thePlantType = thePlantType;
			this.page = 0;
			this.thePlantRow = thePlantRow;
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x001248FC File Offset: 0x00122AFC
		[Token(Token = "0x60036BF")]
		[Address(RVA = "0x7B7B90", Offset = "0x7B6190", VA = "0x1807B7B90")]
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

		// Token: 0x04002A3B RID: 10811
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002A3B")]
		public int thePlantRow;

		// Token: 0x04002A3C RID: 10812
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4002A3C")]
		public int thePlantColumn;

		// Token: 0x04002A3D RID: 10813
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002A3D")]
		public PlantType thePlantType;

		// Token: 0x04002A3E RID: 10814
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4002A3E")]
		public int growStage;

		// Token: 0x04002A3F RID: 10815
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002A3F")]
		public int waterLevel;

		// Token: 0x04002A40 RID: 10816
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4002A40")]
		public int love;

		// Token: 0x04002A41 RID: 10817
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002A41")]
		public long nextTime;

		// Token: 0x04002A42 RID: 10818
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002A42")]
		public GardenToolType needTool = (GardenToolType)((ulong)1L);

		// Token: 0x04002A43 RID: 10819
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4002A43")]
		public int page;
	}
}
