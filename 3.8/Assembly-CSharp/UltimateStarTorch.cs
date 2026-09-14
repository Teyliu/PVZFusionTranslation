using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005C3 RID: 1475
[Token(Token = "0x20005C3")]
public class UltimateStarTorch : UltimateTorch
{
	// Token: 0x06001B7D RID: 7037 RVA: 0x0009314C File Offset: 0x0009134C
	[Token(Token = "0x6001B7D")]
	[Address(RVA = "0x516AC0", Offset = "0x5150C0", VA = "0x180516AC0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCount = (int)((ulong)120L);
	}

	// Token: 0x17000140 RID: 320
	// (get) Token: 0x06001B7E RID: 7038 RVA: 0x0009316C File Offset: 0x0009136C
	// (set) Token: 0x06001B7F RID: 7039 RVA: 0x00093180 File Offset: 0x00091380
	[Token(Token = "0x17000140")]
	[TupleElementNames(new string[] { "fixedValue", "multiplier", "targetType", "summonCount" })]
	protected override Dictionary<BulletType, ValueTuple<int, int, BulletType, int>> TorchDic
	{
		[Token(Token = "0x6001B7E")]
		[Address(RVA = "0x463B60", Offset = "0x462160", VA = "0x180463B60", Slot = "71")]
		get;
		[Token(Token = "0x6001B7F")]
		[Address(RVA = "0x463B70", Offset = "0x462170", VA = "0x180463B70", Slot = "72")]
		[param: TupleElementNames(new string[] { "fixedValue", "multiplier", "targetType", "summonCount" })]
		set;
	}

	// Token: 0x06001B80 RID: 7040 RVA: 0x00093194 File Offset: 0x00091394
	[Token(Token = "0x6001B80")]
	[Address(RVA = "0x516D40", Offset = "0x515340", VA = "0x180516D40", Slot = "69")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		int num2 = 0;
		if (collision.TryGetComponent<Bullet>(num) && base.CheckFire(num))
		{
			int num3 = 0;
			int num4 = this.attributeCount;
			num4 -= num3;
			int num5 = this.shootingLevel;
			num3 += num3;
			num4 -= num3;
			if (num != 0)
			{
				num5 = num4;
				if (num != 0)
				{
					uint num6;
					uint num7;
					if (num5 == (int)num6 || num4 <= 1 || num5 == (int)num7)
					{
						return;
					}
					if (typeof(GameAPP).TypeHandle == (ulong)49L)
					{
					}
					CreateBullet createBullet = CreateBullet.Instance;
					Bullet bullet;
					bullet.theExistTime = createBullet;
					createBullet += createBullet;
					bullet._damage = createBullet;
					bullet.trackSpeed = createBullet;
					Transform transform = bullet.transform;
					Rigidbody2D rb = bullet.rb;
					Quaternion quaternion;
					bullet.accelerate = quaternion != null;
					Vector2 vector;
					rb.velocity = vector;
					bullet.torchWood = this;
					bullet.fromType = vector;
					uint num8;
					GameAPP.PlaySound((int)num8, 0.5f, 1f);
					int num9 = this.fireTimes;
					num9++;
					this.fireTimes = num9;
				}
			}
			if (this.TorchDic.TryGetValue(num, num2))
			{
				BoardAction boardAction = this.board.boardAction;
				Bullet bullet2;
				if (bullet2.theBulletType == BulletType.Bullet_cherryStar)
				{
				}
				int fireTimes = this.fireTimes;
				this.fireTimes = fireTimes;
				if (fireTimes > num4)
				{
					this.fireTimes = num;
					uint num10;
					bool flag = this.SummonPlant((int)num10);
				}
			}
		}
	}

	// Token: 0x06001B81 RID: 7041 RVA: 0x000932F8 File Offset: 0x000914F8
	[Token(Token = "0x6001B81")]
	[Address(RVA = "0x5171F0", Offset = "0x5157F0", VA = "0x1805171F0", Slot = "70")]
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
			if (flag)
			{
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
		Vector3 vector;
		float z = vector.z;
		int theLevel = this.theLevel;
		int num14 = 0;
		ulong num15;
		bool flag3 = plant.Upgrade(theLevel, num15 != 0UL, num14 != 0);
		this.fireTimes = num;
		throw new NullReferenceException();
	}

	// Token: 0x06001B82 RID: 7042 RVA: 0x000934A8 File Offset: 0x000916A8
	[Token(Token = "0x6001B82")]
	[Address(RVA = "0x516AE0", Offset = "0x5150E0", VA = "0x180516AE0")]
	private void FireStar(Bullet bullet)
	{
		if (bullet.theBulletType == BulletType.Bullet_ultimateStar)
		{
		}
		CreateBullet instance = CreateBullet.Instance;
		Transform transform = bullet.transform;
		Transform transform2 = bullet.transform;
		BulletMoveWay moveWay = bullet._moveWay;
		float theExistTime = bullet.theExistTime;
		int num = bullet._damage;
		num += num;
		float trackSpeed = bullet.trackSpeed;
		Transform transform3 = bullet.transform;
		bool accelerate = bullet.accelerate;
		Vector2 velocity = bullet.rb.velocity;
		Rigidbody2D rigidbody2D;
		rigidbody2D.velocity = velocity;
		PlantType fromType = bullet.fromType;
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		bullet.Die();
	}

	// Token: 0x06001B83 RID: 7043 RVA: 0x00093548 File Offset: 0x00091748
	[Token(Token = "0x6001B83")]
	[Address(RVA = "0x517610", Offset = "0x515C10", VA = "0x180517610")]
	public UltimateStarTorch()
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
		dictionary[(uint)93] = num16;
		this.TorchDic = dictionary;
		base..ctor();
	}
}
