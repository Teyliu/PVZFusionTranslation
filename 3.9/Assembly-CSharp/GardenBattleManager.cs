using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using ZenGarden;

// Token: 0x02000799 RID: 1945
[Token(Token = "0x2000799")]
public class GardenBattleManager : MonoBehaviour
{
	// Token: 0x0600277A RID: 10106 RVA: 0x000D126C File Offset: 0x000CF46C
	[Token(Token = "0x600277A")]
	[Address(RVA = "0x63DAA0", Offset = "0x63C0A0", VA = "0x18063DAA0")]
	private void Awake()
	{
		Board instance = Board.Instance;
		this.board = instance;
		Queue<GardenPlantData> avaliablePlants = this.GetAvaliablePlants();
		int num = 0;
		Board board = this.board;
		if (num < board.rowNum)
		{
			GardenPlantData gardenPlantData = avaliablePlants.Dequeue();
			PlantType thePlantType = gardenPlantData.thePlantType;
			Transform transform = base.transform;
			GardenPlant gardenPlant;
			gardenPlant.GetComponent<GardenPlant>().data = gardenPlantData;
			List<GardenPlant> gardenPlants = this.board.boardEntity.gardenPlants;
			num++;
		}
	}

	// Token: 0x0600277B RID: 10107 RVA: 0x000D12E4 File Offset: 0x000CF4E4
	[Token(Token = "0x600277B")]
	[Address(RVA = "0x63E1B0", Offset = "0x63C7B0", VA = "0x18063E1B0")]
	private Queue<GardenPlantData> GetAvaliablePlants()
	{
		Queue<GardenPlantData> queue;
		ulong num3;
		do
		{
			int num = 0;
			GardenUnifiedData data = GardenUI.Data;
			int num2 = 0;
			List<GardenPlantData> plants = data.GetPlants(num2);
			queue = new Queue();
			List<PlantType> list = new List();
			bool flag;
			if (flag)
			{
				while (num == 0)
				{
				}
				bool flag2;
				while (flag2)
				{
				}
				queue.Enqueue(num);
			}
		}
		while (num3 != (ulong)0L);
		return queue;
	}

	// Token: 0x0600277C RID: 10108 RVA: 0x000D1354 File Offset: 0x000CF554
	[Token(Token = "0x600277C")]
	[Address(RVA = "0x63E790", Offset = "0x63CD90", VA = "0x18063E790")]
	private void Update()
	{
		this.BattleUpdate();
	}

	// Token: 0x0600277D RID: 10109 RVA: 0x000D1368 File Offset: 0x000CF568
	[Token(Token = "0x600277D")]
	[Address(RVA = "0x63DC80", Offset = "0x63C280", VA = "0x18063DC80")]
	private void BattleUpdate()
	{
		if (this.progress <= 7)
		{
			Board board = this.board;
			board.theLimPlantCount = (int)((ulong)10L);
			InGameText instance = InGameText.Instance;
			int theLimPlantCount = this.board.theLimPlantCount;
			string text = string.Format("参战植物数量增加到{0}", instance);
			Board board2 = this.board;
			board2.theLimPlantCount = (int)((ulong)15L);
			InGameText instance2 = InGameText.Instance;
			int theLimPlantCount2 = this.board.theLimPlantCount;
			string text2 = string.Format("参战植物数量增加到{0}", instance2);
			Board board3 = this.board;
			board3.theLimPlantCount = (int)((ulong)20L);
			InGameText instance3 = InGameText.Instance;
			int theLimPlantCount3 = this.board.theLimPlantCount;
			string text3 = string.Format("参战植物数量增加到{0}", instance3);
			Board board4 = this.board;
			board4.theLimPlantCount = (int)((ulong)25L);
			InGameText instance4 = InGameText.Instance;
			int theLimPlantCount4 = this.board.theLimPlantCount;
			string text4 = string.Format("参战植物数量增加到{0}", instance4);
			Board board5 = this.board;
			board5.theLimPlantCount = (int)((ulong)30L);
			InGameText instance5 = InGameText.Instance;
			int theLimPlantCount5 = this.board.theLimPlantCount;
			string text5 = string.Format("参战植物数量增加到{0}", instance5);
			Board board6 = this.board;
			this.Supply();
			Board board7 = this.board;
			board7.theLimPlantCount = (int)((ulong)35L);
			InGameText instance6 = InGameText.Instance;
			int theLimPlantCount6 = this.board.theLimPlantCount;
			string text6 = string.Format("补给已到达，参战植物数量增加到{0}", instance6);
			Board board8 = this.board;
			this.Supply();
			Board board9 = this.board;
			board9.theLimPlantCount = (int)((ulong)40L);
			InGameText instance7 = InGameText.Instance;
			int theLimPlantCount7 = this.board.theLimPlantCount;
			string text7 = string.Format("补给已到达，参战植物数量增加到{0}", instance7);
			Board board10 = this.board;
			this.Supply();
			Board board11 = this.board;
			board11.theLimPlantCount = (int)((ulong)50L);
			InGameText instance8 = InGameText.Instance;
			int theLimPlantCount8 = this.board.theLimPlantCount;
			string text8 = string.Format("补给已到达，参战植物数量增加到{0}", instance8);
		}
	}

	// Token: 0x0600277E RID: 10110 RVA: 0x000D156C File Offset: 0x000CF76C
	[Token(Token = "0x600277E")]
	[Address(RVA = "0x63E400", Offset = "0x63CA00", VA = "0x18063E400")]
	private void Supply()
	{
		List<GardenPlantData> list;
		uint num;
		int num2;
		ulong num3;
		do
		{
			list = Enumerable.ToList<GardenPlantData>(this.GetAvaliablePlants());
			if (num >= (uint)(-1))
			{
				return;
			}
			num2 = 0;
			Board board = this.board;
			if (num2 >= board.rowNum)
			{
				goto IL_00AC;
			}
			List<GardenPlant> gardenPlants = board.boardEntity.gardenPlants;
			bool flag;
			if (flag)
			{
			}
		}
		while (num3 != (ulong)0L);
		ulong num4;
		if (num4 != (ulong)0L)
		{
			int num5 = list._size;
			int num6 = global::UnityEngine.Random.Range(0, num5);
			num5 = num6;
			GardenPlantData gardenPlantData = list[num5];
			num5 = num6;
			list.RemoveAt(num5);
			PlantType thePlantType = gardenPlantData.thePlantType;
			GardenPlant gardenPlant;
			GardenPlant component = gardenPlant.GetComponent<GardenPlant>();
			component.data = gardenPlantData;
			Transform plantTargetAxis = component.plantTargetAxis;
		}
		num2++;
		IL_00AC:
		num += (uint)1;
	}

	// Token: 0x0600277F RID: 10111 RVA: 0x000D163C File Offset: 0x000CF83C
	[Token(Token = "0x600277F")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public GardenBattleManager()
	{
	}

	// Token: 0x040014BE RID: 5310
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40014BE")]
	private Board board;

	// Token: 0x040014BF RID: 5311
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014BF")]
	private int progress;
}
