using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using ZenGarden;

// Token: 0x02000760 RID: 1888
[Token(Token = "0x2000760")]
public class GardenBattleManager : MonoBehaviour
{
	// Token: 0x06002653 RID: 9811 RVA: 0x000CC228 File Offset: 0x000CA428
	[Token(Token = "0x6002653")]
	[Address(RVA = "0x5DABB0", Offset = "0x5D91B0", VA = "0x1805DABB0")]
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

	// Token: 0x06002654 RID: 9812 RVA: 0x000CC2A0 File Offset: 0x000CA4A0
	[Token(Token = "0x6002654")]
	[Address(RVA = "0x5DB2B0", Offset = "0x5D98B0", VA = "0x1805DB2B0")]
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

	// Token: 0x06002655 RID: 9813 RVA: 0x000CC310 File Offset: 0x000CA510
	[Token(Token = "0x6002655")]
	[Address(RVA = "0x5DB890", Offset = "0x5D9E90", VA = "0x1805DB890")]
	private void Update()
	{
		this.BattleUpdate();
	}

	// Token: 0x06002656 RID: 9814 RVA: 0x000CC324 File Offset: 0x000CA524
	[Token(Token = "0x6002656")]
	[Address(RVA = "0x5DAD90", Offset = "0x5D9390", VA = "0x1805DAD90")]
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
			int num = 0;
			instance8.ShowText(text8, 5f, num != 0);
		}
	}

	// Token: 0x06002657 RID: 9815 RVA: 0x000CC53C File Offset: 0x000CA73C
	[Token(Token = "0x6002657")]
	[Address(RVA = "0x5DB500", Offset = "0x5D9B00", VA = "0x1805DB500")]
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

	// Token: 0x06002658 RID: 9816 RVA: 0x000CC60C File Offset: 0x000CA80C
	[Token(Token = "0x6002658")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public GardenBattleManager()
	{
	}

	// Token: 0x040013E6 RID: 5094
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013E6")]
	private Board board;

	// Token: 0x040013E7 RID: 5095
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013E7")]
	private int progress;
}
