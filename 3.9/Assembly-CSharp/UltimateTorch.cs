using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004B7 RID: 1207
[Token(Token = "0x20004B7")]
public class UltimateTorch : SquashTorch
{
	// Token: 0x0600168B RID: 5771 RVA: 0x0007C1F0 File Offset: 0x0007A3F0
	[Token(Token = "0x600168B")]
	[Address(RVA = "0x519440", Offset = "0x517A40", VA = "0x180519440", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCount = (int)((ulong)60L);
		this.attributeCountdown = 3f;
	}

	// Token: 0x0600168C RID: 5772 RVA: 0x0007C218 File Offset: 0x0007A418
	[Token(Token = "0x600168C")]
	[Address(RVA = "0x519080", Offset = "0x517680", VA = "0x180519080", Slot = "39")]
	protected override void AttributeEvent()
	{
		int num = 0;
		base.OnFixedUpdate();
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (Lawnf.InLandStatus((ZombieStatus)num))
				{
					PlantType thePlantType = this.thePlantType;
					num3 += num3;
					uint num4;
					if (num4 > (uint)0)
					{
						ParticleManager instance = ParticleManager.Instance;
					}
				}
			}
			num++;
		}
		this.attributeCountdown = 3f;
	}

	// Token: 0x17000158 RID: 344
	// (get) Token: 0x0600168D RID: 5773 RVA: 0x0007C298 File Offset: 0x0007A498
	// (set) Token: 0x0600168E RID: 5774 RVA: 0x0007C2AC File Offset: 0x0007A4AC
	[Token(Token = "0x17000158")]
	[TupleElementNames(new string[] { "fixedValue", "multiplier", "targetType", "summonCount" })]
	protected virtual Dictionary<BulletType, ValueTuple<int, int, BulletType, int>> TorchDic
	{
		[Token(Token = "0x600168D")]
		[Address(RVA = "0x51A1B0", Offset = "0x5187B0", VA = "0x18051A1B0", Slot = "70")]
		get;
		[Token(Token = "0x600168E")]
		[Address(RVA = "0x51A1C0", Offset = "0x5187C0", VA = "0x18051A1C0", Slot = "71")]
		[param: TupleElementNames(new string[] { "fixedValue", "multiplier", "targetType", "summonCount" })]
		set;
	}

	// Token: 0x0600168F RID: 5775 RVA: 0x0007C2C0 File Offset: 0x0007A4C0
	[Token(Token = "0x600168F")]
	[Address(RVA = "0x5194D0", Offset = "0x517AD0", VA = "0x1805194D0", Slot = "68")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		bool flag2;
		if (flag && flag2)
		{
			int num = 0;
			int num2 = this.attributeCount;
			num2 -= num;
			int num3 = 0;
			bool flag3;
			if (flag3)
			{
				flag3 = (flag3 ? 1 : 0) - num3 != 0;
			}
			Dictionary<BulletType, ValueTuple<int, int, BulletType, int>> torchDic = this.TorchDic;
			bool flag4;
			if (flag4)
			{
				BoardAction boardAction = this.board.boardAction;
				int fireTimes = this.fireTimes;
				this.fireTimes = fireTimes;
				if (fireTimes > num2)
				{
					this.fireTimes = (int)((ulong)0L);
					uint num4;
					bool flag5 = this.SummonPlant((int)num4);
				}
			}
		}
	}

	// Token: 0x06001690 RID: 5776 RVA: 0x0007C344 File Offset: 0x0007A544
	[Token(Token = "0x6001690")]
	[Address(RVA = "0x5196A0", Offset = "0x517CA0", VA = "0x1805196A0", Slot = "69")]
	protected override bool SummonPlant(int dmg = 300)
	{
		int num;
		Plant plant;
		for (;;)
		{
			num = 0;
			Board board = this.board;
			int num2 = this.thePlantColumn;
			int columnNum = board.columnNum;
			uint num3;
			num2 += (int)num3;
			GridSystem gridSystem = board.gridSystem;
			int num4 = this.thePlantColumn;
			int thePlantRow = this.thePlantRow;
			num4 += (int)num3;
			if (gridSystem.GetGrid(num4, thePlantRow).boxType == BoxType.Water)
			{
				goto IL_008D;
			}
			GridSystem gridSystem2 = this.board.gridSystem;
			int num5 = this.thePlantColumn;
			int thePlantRow2 = this.thePlantRow;
			num5 += (int)num3;
			if (gridSystem2.GetGrid(num5, thePlantRow2).boxType == BoxType.Roof)
			{
				CreatePlant instance = CreatePlant.Instance;
				goto IL_008D;
			}
			IL_00A5:
			CreatePlant instance2 = CreatePlant.Instance;
			int num6 = this.thePlantColumn;
			num6 += (int)num3;
			num3 += (uint)1;
			int num7 = 0;
			if (!(plant == num7))
			{
				break;
			}
			continue;
			IL_008D:
			CreatePlant instance3 = CreatePlant.Instance;
			int num8 = this.thePlantColumn;
			num8 += (int)num3;
			goto IL_00A5;
		}
		int num9 = 0;
		if (!(plant != num9))
		{
			bool flag;
			if (!flag)
			{
			}
			Board board2 = this.board;
			bool flag2;
			if (!flag2)
			{
				BoardAction boardAction = board2.boardAction;
				PlantType thePlantType = this.thePlantType;
				int num10 = 0;
				int thePlantRow3 = this.thePlantRow;
				uint num11;
				boardAction.CreateFireLine(thePlantRow3, (int)num11, num10 != 0, num != 0, num != 0, num, thePlantType);
				this.fireTimes = num;
			}
			BoardAction boardAction2 = this.board.boardAction;
			PlantType thePlantType2 = this.thePlantType;
			int num12 = 0;
			uint num13;
			boardAction2.CreateFireLine(num, (int)num13, num12 != 0, num != 0, num != 0, num, thePlantType2);
			Board board3 = this.board;
			num++;
		}
		Transform axis = plant.axis;
		int attackDamage = this.attackDamage;
		plant.attackDamage = attackDamage;
		Vector3 vector;
		float z = vector.z;
		this.fireTimes = num;
		throw new NullReferenceException();
	}

	// Token: 0x06001691 RID: 5777 RVA: 0x0007C4EC File Offset: 0x0007A6EC
	[Token(Token = "0x6001691")]
	[Address(RVA = "0x519470", Offset = "0x517A70", VA = "0x180519470", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int num = 0;
		int attackDamage = this.attackDamage;
		int num2 = 0;
		int thePlantRow = this.thePlantRow;
		boardAction.CreateFireLine(thePlantRow, attackDamage, num2 != 0, num != 0, num != 0, num, thePlantType);
	}

	// Token: 0x06001692 RID: 5778 RVA: 0x0007C538 File Offset: 0x0007A738
	[Token(Token = "0x6001692")]
	[Address(RVA = "0x519AB0", Offset = "0x5180B0", VA = "0x180519AB0")]
	public UltimateTorch()
	{
		Dictionary<BulletType, ValueTuple<int, int, BulletType, int>> dictionary = new Dictionary();
		int num = 0;
		dictionary[(uint)153] = num;
		int num2 = 0;
		dictionary[(uint)175] = num2;
		int num3 = 0;
		int num4 = 0;
		dictionary[num4] = num3;
		int num5 = 0;
		dictionary[(uint)7] = num5;
		int num6 = 0;
		dictionary[(uint)25] = num6;
		int num7 = 0;
		dictionary[(uint)26] = num7;
		int num8 = 0;
		dictionary[(uint)231] = num8;
		int num9 = 0;
		dictionary[(uint)1] = num9;
		int num10 = 0;
		dictionary[(uint)15] = num10;
		int num11 = 0;
		dictionary[(uint)87] = num11;
		int num12 = 0;
		dictionary[(uint)11] = num12;
		int num13 = 0;
		dictionary[(uint)8] = num13;
		int num14 = 0;
		dictionary[(uint)204] = num14;
		int num15 = 0;
		dictionary[(uint)3] = num15;
		int num16 = 0;
		dictionary[(uint)23] = num16;
		int num17 = 0;
		dictionary[(uint)194] = num17;
		int num18 = 0;
		dictionary[(uint)126] = num18;
		int num19 = 0;
		dictionary[(uint)195] = num19;
		int num20 = 0;
		dictionary[(uint)93] = num20;
		this.TorchDic = dictionary;
		base..ctor();
	}
}
