using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C91 RID: 3217
	[Token(Token = "0x2000C91")]
	public class Shooting_斗转星移 : BaseDebuff
	{
		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060042C3 RID: 17091 RVA: 0x0015CB64 File Offset: 0x0015AD64
		[Token(Token = "0x170005AD")]
		public override int Point
		{
			[Token(Token = "0x60042C3")]
			[Address(RVA = "0x88CB90", Offset = "0x88B190", VA = "0x18088CB90", Slot = "21")]
			get
			{
				return 150;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060042C4 RID: 17092 RVA: 0x0015CB78 File Offset: 0x0015AD78
		[Token(Token = "0x170005AE")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x60042C4")]
			[Address(RVA = "0x89F640", Offset = "0x89DC40", VA = "0x18089F640", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_斗转星移;
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060042C5 RID: 17093 RVA: 0x0015CB8C File Offset: 0x0015AD8C
		[Token(Token = "0x170005AF")]
		public override string Description
		{
			[Token(Token = "0x60042C5")]
			[Address(RVA = "0x89F650", Offset = "0x89DC50", VA = "0x18089F650", Slot = "13")]
			get
			{
				return "斗转星移：每一波僵尸刷新时，使你的植物移动到随机位置";
			}
		}

		// Token: 0x060042C6 RID: 17094 RVA: 0x0015CBA0 File Offset: 0x0015ADA0
		[Token(Token = "0x60042C6")]
		[Address(RVA = "0x89F560", Offset = "0x89DB60", VA = "0x18089F560", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Action action = delegate
			{
				int num2;
				do
				{
					List<Plant> allPlants = Lawnf.GetAllPlants();
					num2 = 0;
					bool flag;
					if (flag)
					{
						int columnNum = board.columnNum;
						int num3 = global::UnityEngine.Random.Range(0, columnNum);
						int rowNum = board.rowNum;
						int num4 = global::UnityEngine.Random.Range(0, rowNum);
						CreatePlant instance = CreatePlant.Instance;
					}
				}
				while (num2 != 0);
			};
			int num = 0;
			EventManager.AddListener((GameEvent)((uint)3), action, num != 0);
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x0015CBD8 File Offset: 0x0015ADD8
		[Token(Token = "0x60042C7")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_斗转星移()
		{
		}
	}
}
