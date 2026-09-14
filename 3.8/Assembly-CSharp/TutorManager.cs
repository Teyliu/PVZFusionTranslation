using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200061C RID: 1564
[Token(Token = "0x200061C")]
public class TutorManager : MonoBehaviour
{
	// Token: 0x06001D86 RID: 7558 RVA: 0x0009DB70 File Offset: 0x0009BD70
	[Token(Token = "0x6001D86")]
	[Address(RVA = "0x52A880", Offset = "0x528E80", VA = "0x18052A880")]
	private void Awake()
	{
		Board instance = Board.Instance;
		this.board = instance;
		this.progress = (int)((ulong)0L);
	}

	// Token: 0x06001D87 RID: 7559 RVA: 0x0009DB94 File Offset: 0x0009BD94
	[Token(Token = "0x6001D87")]
	[Address(RVA = "0x52F390", Offset = "0x52D990", VA = "0x18052F390")]
	private void Update()
	{
		float num = this.timer;
		float deltaTime = Time.deltaTime;
		this.timer = num;
		Board board = this.board;
		int num2 = this.id;
		if (num2 > 15)
		{
			if (num2 > 24)
			{
				if (num2 == 30)
				{
					this.TutorUpdate30();
					return;
				}
				if (num2 == 35)
				{
					this.TutorUpdate35();
					return;
				}
				while (this != (ulong)42L)
				{
				}
				this.TutorUpdate42();
				return;
			}
			else
			{
				if (num2 == 22)
				{
					this.TutorUpdate22();
					return;
				}
				while (this != (ulong)24L)
				{
				}
				this.TutorUpdate24();
				return;
			}
		}
		else if (num2 > 10)
		{
			if (num2 == 13)
			{
				this.TutorUpdate13();
				return;
			}
			while (this != (ulong)15L)
			{
			}
			this.TutorUpdate15();
			return;
		}
		else
		{
			if (this == (ulong)1L)
			{
				this.TutorUpdate1();
				return;
			}
			while (board > (ulong)6L)
			{
			}
			this.TutorUpdate4();
			return;
		}
	}

	// Token: 0x06001D88 RID: 7560 RVA: 0x0009DC78 File Offset: 0x0009BE78
	[Token(Token = "0x6001D88")]
	[Address(RVA = "0x52AAB0", Offset = "0x5290B0", VA = "0x18052AAB0")]
	private void TowerUpdate()
	{
		if (this.progress <= 6)
		{
			ulong num;
			InGameText.Instance.ShowText("欢迎来到沙滩，这是你的第一站", 3f, num != 0UL);
			this.timer = 3f;
		}
	}

	// Token: 0x06001D89 RID: 7561 RVA: 0x0009DD5C File Offset: 0x0009BF5C
	[Token(Token = "0x6001D89")]
	[Address(RVA = "0x52BB90", Offset = "0x52A190", VA = "0x18052BB90")]
	private void TutorUpdate1()
	{
		if (this.progress <= 6)
		{
			InGameText instance = InGameText.Instance;
			ulong num;
			instance.ShowText("欢迎来到植物大战僵尸融合版。", 3f, num != 0UL);
			this.timer = 3f;
		}
	}

	// Token: 0x06001D8A RID: 7562 RVA: 0x0009DEF8 File Offset: 0x0009C0F8
	[Token(Token = "0x6001D8A")]
	[Address(RVA = "0x52E8B0", Offset = "0x52CEB0", VA = "0x18052E8B0")]
	private void TutorUpdate4()
	{
		int num = this.progress;
		if (num == 0)
		{
			InGameText instance = InGameText.Instance;
			ulong num2;
			instance.ShowText("恭喜你解锁了手套，这是非常重要的道具", 4f, num2 != 0UL);
			this.timer = 4f;
			return;
		}
		if (num != 0)
		{
			if (num != 0)
			{
				if (num == 1)
				{
					Plant plant = this.missionPlant;
					int num3 = 0;
					if (plant != num3 && this.missionPlant.thePlantColumn < 5)
					{
						InGameText instance2 = InGameText.Instance;
						ulong num4;
						instance2.ShowText("你已经学会使用手套了！种植更多的植物，抵御僵尸的入侵吧！", 5f, num4 != 0UL);
						this.TutorOver();
						return;
					}
				}
			}
			else
			{
				InGameText instance3 = InGameText.Instance;
				ulong num5;
				instance3.ShowText("现在试试将这个双子向日葵移动到坚果后面去", 60f, num5 != 0UL);
				uint num6;
				uint num7;
				this.ClearPlant((int)num6, (int)num7);
				uint num8;
				uint num9;
				this.ClearPlant((int)num8, (int)num9);
				CreatePlant instance4 = CreatePlant.Instance;
				Plant plant2;
				this.missionPlant = plant2;
				CreatePlant instance5 = CreatePlant.Instance;
			}
			return;
		}
		InGameText instance6 = InGameText.Instance;
		ulong num10;
		instance6.ShowText("使用手套可以挪动植物，也可以使用手套挪动植物进行融合", 5f, num10 != 0UL);
		this.timer = 5f;
	}

	// Token: 0x06001D8B RID: 7563 RVA: 0x0009E01C File Offset: 0x0009C21C
	[Token(Token = "0x6001D8B")]
	[Address(RVA = "0x52EBB0", Offset = "0x52D1B0", VA = "0x18052EBB0")]
	private void TutorUpdate7()
	{
		int num;
		for (;;)
		{
			num = this.progress;
			if (num == 0)
			{
				goto IL_0119;
			}
			if (num == 0)
			{
				goto IL_00DC;
			}
			if (num != 0)
			{
				break;
			}
			Plant plant = this.missionPlant;
			int num2 = 0;
			if (plant == num2)
			{
				goto Block_6;
			}
		}
		if (num != 0)
		{
			if (num == 1)
			{
				Zombie zombie = this.missionZombie;
				int num3 = 0;
				if (zombie == num3)
				{
					InGameText instance = InGameText.Instance;
					ulong num4;
					instance.ShowText("干得好！种植更多的植物，抵御僵尸的入侵吧！", 5f, num4 != 0UL);
					this.TutorOver();
					return;
				}
			}
		}
		else
		{
			InGameText instance2 = InGameText.Instance;
			ulong num5;
			instance2.ShowText("注意看1路有一个樱桃读报僵尸！用樱桃坚果防御他的子弹吧！", 5f, num5 != 0UL);
			CreateZombie instance3 = CreateZombie.Instance;
			Zombie zombie2;
			Zombie component = zombie2.GetComponent<Zombie>();
			this.missionZombie = component;
		}
		return;
		Block_6:
		InGameText instance4 = InGameText.Instance;
		ulong num6;
		instance4.ShowText("你已经学会了如何使用礼盒！让我们进行下一步吧！", 3f, num6 != 0UL);
		this.timer = 3f;
		return;
		IL_00DC:
		InGameText instance5 = InGameText.Instance;
		ulong num7;
		instance5.ShowText("现在试试将礼盒放到这个双发射手上", 60f, num7 != 0UL);
		uint num8;
		uint num9;
		this.ClearPlant((int)num8, (int)num9);
		CreatePlant instance6 = CreatePlant.Instance;
		Plant plant2;
		this.missionPlant = plant2;
		return;
		IL_0119:
		InGameText instance7 = InGameText.Instance;
		ulong num10;
		instance7.ShowText("礼盒，能开出全部的基础植物", 6f, num10 != 0UL);
		this.timer = 6f;
	}

	// Token: 0x06001D8C RID: 7564 RVA: 0x0009E174 File Offset: 0x0009C374
	[Token(Token = "0x6001D8C")]
	[Address(RVA = "0x52EF40", Offset = "0x52D540", VA = "0x18052EF40")]
	private void TutorUpdate8()
	{
		int num3;
		do
		{
			int num = 0;
			int num2 = this.progress;
			if (num2 == 0)
			{
				goto IL_0113;
			}
			if (num2 == 0)
			{
				goto IL_00DB;
			}
			if (num2 == 0)
			{
				goto IL_009E;
			}
			if (num2 != 0 && num2 == 1)
			{
				break;
			}
			List<Plant> plantArray = this.board.boardEntity.plantArray;
			num3 = 0;
			bool flag;
			if (flag)
			{
				int num4 = 0;
				if (!(num != num4))
				{
					continue;
				}
				ulong num5;
				InGameText.Instance.ShowText("铁系植物！你前期的好伙伴！", 3f, num5 != 0UL);
				this.timer = 3f;
			}
		}
		while (num3 != 0);
		InGameText instance = InGameText.Instance;
		ulong num6;
		instance.ShowText("种植更多的植物，抵御僵尸的入侵吧！", 5f, num6 != 0UL);
		this.TutorOver();
		IL_009E:
		Zombie zombie = this.missionZombie;
		if (zombie.beforeDying || zombie.theStatus == ZombieStatus.Dying)
		{
			InGameText instance2 = InGameText.Instance;
			ulong num7;
			instance2.ShowText("点击僵尸掉落的铁桶，放到豌豆射手或者坚果墙上吧！", 60f, num7 != 0UL);
		}
		return;
		IL_00DB:
		InGameText instance3 = InGameText.Instance;
		ulong num8;
		instance3.ShowText("击败1路这个铁桶坚果僵尸！注意不要使用樱桃炸弹和大嘴花！", 60f, num8 != 0UL);
		CreateZombie instance4 = CreateZombie.Instance;
		Zombie zombie2;
		Zombie component = zombie2.GetComponent<Zombie>();
		this.missionZombie = component;
		IL_0113:
		InGameText instance5 = InGameText.Instance;
		ulong num9;
		instance5.ShowText("你是否想过把僵尸的装备放到植物身上？", 4f, num9 != 0UL);
		this.timer = 4f;
		throw new NullReferenceException();
	}

	// Token: 0x06001D8D RID: 7565 RVA: 0x0009E2D4 File Offset: 0x0009C4D4
	[Token(Token = "0x6001D8D")]
	[Address(RVA = "0x52AD60", Offset = "0x529360", VA = "0x18052AD60")]
	private void TutorUpdate10()
	{
		int num = this.progress;
		if (num != 0)
		{
			if (num != 0)
			{
				if (num != 0)
				{
					if (num == 1)
					{
						InGameText instance = InGameText.Instance;
						ulong num2;
						instance.ShowText("种植更多的植物，抵御僵尸的入侵吧！", 5f, num2 != 0UL);
						this.TutorOver();
						return;
					}
					return;
				}
				else
				{
					InGameText instance2 = InGameText.Instance;
					ulong num3;
					instance2.ShowText("往小喷菇聚落里面融合可以直接得到3个小喷菇的融合体", 4f, num3 != 0UL);
					CreatePlant instance3 = CreatePlant.Instance;
				}
			}
			InGameText instance4 = InGameText.Instance;
			ulong num4;
			instance4.ShowText("一个格子里可以放3个小喷菇", 4f, num4 != 0UL);
			uint num5;
			this.ClearPlant((int)num5, (int)num5);
			CreatePlant instance5 = CreatePlant.Instance;
			CreatePlant instance6 = CreatePlant.Instance;
			CreatePlant instance7 = CreatePlant.Instance;
			this.timer = 4f;
			return;
		}
		InGameText instance8 = InGameText.Instance;
		ulong num6;
		instance8.ShowText("小喷菇是黑夜里十分重要的植物", 4f, num6 != 0UL);
		throw new NullReferenceException();
	}

	// Token: 0x06001D8E RID: 7566 RVA: 0x0009E3C0 File Offset: 0x0009C5C0
	[Token(Token = "0x6001D8E")]
	[Address(RVA = "0x52B060", Offset = "0x529660", VA = "0x18052B060")]
	private void TutorUpdate13()
	{
		if (this.progress <= 8)
		{
			InGameText instance = InGameText.Instance;
			InGameText instance2 = InGameText.Instance;
			InGameText instance3 = InGameText.Instance;
			InGameText instance4 = InGameText.Instance;
			InGameText instance5 = InGameText.Instance;
			ulong num;
			instance5.ShowText("这里有一个坚果墙，试试给他肥料会有什么效果", 60f, num != 0UL);
			uint num2;
			this.ClearPlant((int)num2, (int)num2);
			GameObject gameObject = Resources.Load<GameObject>("Items/Fertilize/Ferilize");
			CreatePlant instance6 = CreatePlant.Instance;
			Plant plant;
			Transform transform = plant.transform;
			Vector3 vector;
			float z = vector.z;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform2 = Board.Instance.transform;
			uint num3;
			GameAPP.PlaySound((int)num3, 0.5f, 1f);
		}
	}

	// Token: 0x06001D8F RID: 7567 RVA: 0x0009E550 File Offset: 0x0009C750
	[Token(Token = "0x6001D8F")]
	[Address(RVA = "0x52B620", Offset = "0x529C20", VA = "0x18052B620")]
	private void TutorUpdate15()
	{
		int num = this.progress;
		if (num != 0)
		{
			if (num != 0)
			{
				if (num != 0)
				{
					if (num == 1)
					{
						InGameText instance = InGameText.Instance;
						ulong num2;
						instance.ShowText("种植更多的植物，抵御僵尸的入侵吧！", 5f, num2 != 0UL);
						uint num3;
						uint num4;
						this.ClearPlant((int)num3, (int)num4);
						uint num5;
						uint num6;
						this.ClearPlant((int)num5, (int)num6);
						uint num7;
						this.ClearPlant((int)num7, (int)num7);
						uint num8;
						uint num9;
						this.ClearPlant((int)num8, (int)num9);
						uint num10;
						uint num11;
						this.ClearPlant((int)num10, (int)num11);
						uint num12;
						uint num13;
						this.ClearPlant((int)num12, (int)num13);
						this.TutorOver();
						return;
					}
					return;
				}
				else
				{
					Board board = this.board;
					if (board.enermyCount != 0)
					{
						return;
					}
					board.showZombieHealth = false;
					InGameText instance2 = InGameText.Instance;
				}
			}
			InGameText instance3 = InGameText.Instance;
			ulong num14;
			instance3.ShowText("寒冰类植物的攻击都会附带冻结值\n当冻结值满时僵尸会被冻结并清空冻结值，冻结的僵尸受到寒冰类子弹的伤害都将x4", 60f, num14 != 0UL);
			this.board.showZombieHealth = true;
			uint num15;
			uint num16;
			this.ClearPlant((int)num15, (int)num16);
			uint num17;
			uint num18;
			this.ClearPlant((int)num17, (int)num18);
			uint num19;
			this.ClearPlant((int)num19, (int)num19);
			uint num20;
			uint num21;
			this.ClearPlant((int)num20, (int)num21);
			uint num22;
			uint num23;
			this.ClearPlant((int)num22, (int)num23);
			uint num24;
			uint num25;
			this.ClearPlant((int)num24, (int)num25);
			CreatePlant instance4 = CreatePlant.Instance;
			CreatePlant instance5 = CreatePlant.Instance;
			CreatePlant instance6 = CreatePlant.Instance;
			CreatePlant instance7 = CreatePlant.Instance;
			CreatePlant instance8 = CreatePlant.Instance;
			CreatePlant instance9 = CreatePlant.Instance;
			CreateZombie instance10 = CreateZombie.Instance;
			CreateZombie instance11 = CreateZombie.Instance;
			CreateZombie instance12 = CreateZombie.Instance;
			return;
		}
		InGameText instance13 = InGameText.Instance;
		ulong num26;
		instance13.ShowText("让我们来看看寒冰系的新功能：冻结值", 4f, num26 != 0UL);
		this.timer = 4f;
	}

	// Token: 0x06001D90 RID: 7568 RVA: 0x0009E6E0 File Offset: 0x0009C8E0
	[Token(Token = "0x6001D90")]
	[Address(RVA = "0x52C200", Offset = "0x52A800", VA = "0x18052C200")]
	private void TutorUpdate22()
	{
		int num = this.progress;
		if (num == 0)
		{
			InGameText instance = InGameText.Instance;
			ulong num2;
			instance.ShowText("水草子弹是水路中最强大的子弹", 4f, num2 != 0UL);
			uint num3;
			uint num4;
			this.ClearPlant((int)num3, (int)num4);
			uint num5;
			uint num6;
			this.ClearPlant((int)num5, (int)num6);
			uint num7;
			this.ClearPlant((int)num7, (int)num7);
			uint num8;
			uint num9;
			this.ClearPlant((int)num8, (int)num9);
			CreatePlant instance2 = CreatePlant.Instance;
			CreatePlant instance3 = CreatePlant.Instance;
			CreatePlant instance4 = CreatePlant.Instance;
			CreatePlant instance5 = CreatePlant.Instance;
			throw new NullReferenceException();
		}
		if (num != 0)
		{
			if (num != 0)
			{
				if (num == 1)
				{
					InGameText instance6 = InGameText.Instance;
					ulong num10;
					instance6.ShowText("种植更多的植物，抵御僵尸的入侵吧！", 5f, num10 != 0UL);
					this.TutorOver();
					return;
				}
			}
			else
			{
				Zombie zombie = this.missionZombie;
				int num11 = 0;
				if (zombie == num11)
				{
					Board board = this.board;
					board.showZombieHealth = false;
					InGameText instance7 = InGameText.Instance;
					ulong num12;
					instance7.ShowText("水草子弹命中水里的僵尸会造成额外的百分比伤害\n击中30次以上会直接秒杀僵尸！", 4f, num12 != 0UL);
					this.timer = 4f;
				}
			}
			return;
		}
		InGameText instance8 = InGameText.Instance;
		ulong num13;
		instance8.ShowText("让我们来看看这个一百万血的机械海豚僵尸是怎么被轻松干掉的", 4f, num13 != 0UL);
		this.board.showZombieHealth = true;
		CreateZombie instance9 = CreateZombie.Instance;
		Zombie zombie2;
		Zombie component = zombie2.GetComponent<Zombie>();
		this.missionZombie = component;
		this.missionZombie.theHealth = (int)((ulong)1000000L);
		this.missionZombie.theMaxHealth = (int)((ulong)1000000L);
	}

	// Token: 0x06001D91 RID: 7569 RVA: 0x0009E858 File Offset: 0x0009CA58
	[Token(Token = "0x6001D91")]
	[Address(RVA = "0x52C670", Offset = "0x52AC70", VA = "0x18052C670")]
	private void TutorUpdate24()
	{
		int num = this.progress;
		if (num != 0)
		{
			if (num != 0)
			{
				if (num != 0)
				{
					if (num == 1 && this.board.enermyCount == 0)
					{
						InGameText instance = InGameText.Instance;
						ulong num2;
						instance.ShowText("种植更多的植物，抵御僵尸的入侵吧！", 5f, num2 != 0UL);
						this.TutorOver();
						return;
					}
				}
				else
				{
					Board board = this.board;
					if (board.enermyCount == 0)
					{
						board.showZombieHealth = false;
						InGameText instance2 = InGameText.Instance;
						int num3 = 0;
						ulong num4;
						instance2.ShowText("红温的僵尸死亡时会对附近的僵尸造成100点伤害并传递红温效果", 4f, num4 != 0UL);
						CreatePlant instance3 = CreatePlant.Instance;
						CreateZombie instance4 = CreateZombie.Instance;
						int num5 = 0;
						int num6 = 0;
						Zombie zombie = instance4.SetZombie(num6, (ZombieType)num5, 9f, num3 != 0);
						CreateZombie instance5 = CreateZombie.Instance;
						int num7 = 0;
						uint num8;
						Zombie zombie2 = instance5.SetZombie((int)num8, (ZombieType)num7, 9f, num3 != 0);
						CreateZombie instance6 = CreateZombie.Instance;
						int num9 = 0;
						int num10 = 0;
						Zombie zombie3 = instance6.SetZombie(num10, (ZombieType)num9, 9f, num3 != 0);
						CreateZombie instance7 = CreateZombie.Instance;
						int num11 = 0;
						uint num12;
						Zombie zombie4 = instance7.SetZombie((int)num12, (ZombieType)num11, 9f, num3 != 0);
						CreateZombie instance8 = CreateZombie.Instance;
						int num13 = 0;
						int num14 = 0;
						Zombie zombie5 = instance8.SetZombie(num14, (ZombieType)num13, 9f, num3 != 0);
						CreateZombie instance9 = CreateZombie.Instance;
						int num15 = 0;
						uint num16;
						Zombie zombie6 = instance9.SetZombie((int)num16, (ZombieType)num15, 9f, num3 != 0);
						CreateZombie instance10 = CreateZombie.Instance;
						int num17 = 0;
						int num18 = 0;
						Zombie zombie7 = instance10.SetZombie(num18, (ZombieType)num17, 9f, num3 != 0);
						CreateZombie instance11 = CreateZombie.Instance;
						int num19 = 0;
						uint num20;
						Zombie zombie8 = instance11.SetZombie((int)num20, (ZombieType)num19, 9f, num3 != 0);
						CreateZombie instance12 = CreateZombie.Instance;
						int num21 = 0;
						int num22 = 0;
						Zombie zombie9 = instance12.SetZombie(num22, (ZombieType)num21, 9f, num3 != 0);
						CreateZombie instance13 = CreateZombie.Instance;
						int num23 = 0;
						uint num24;
						Zombie zombie10 = instance13.SetZombie((int)num24, (ZombieType)num23, 9f, num3 != 0);
						CreateZombie instance14 = CreateZombie.Instance;
						int num25 = 0;
						int num26 = 0;
						Zombie zombie11 = instance14.SetZombie(num26, (ZombieType)num25, 9f, num3 != 0);
						CreateZombie instance15 = CreateZombie.Instance;
						int num27 = 0;
						uint num28;
						Zombie zombie12 = instance15.SetZombie((int)num28, (ZombieType)num27, 9f, num3 != 0);
						CreateZombie instance16 = CreateZombie.Instance;
						int num29 = 0;
						int num30 = 0;
						Zombie zombie13 = instance16.SetZombie(num30, (ZombieType)num29, 9f, num3 != 0);
						CreateZombie instance17 = CreateZombie.Instance;
						int num31 = 0;
						uint num32;
						Zombie zombie14 = instance17.SetZombie((int)num32, (ZombieType)num31, 9f, num3 != 0);
						CreateZombie instance18 = CreateZombie.Instance;
						int num33 = 0;
						int num34 = 0;
						Zombie zombie15 = instance18.SetZombie(num34, (ZombieType)num33, 9f, num3 != 0);
						CreateZombie instance19 = CreateZombie.Instance;
						int num35 = 0;
						uint num36;
						Zombie zombie16 = instance19.SetZombie((int)num36, (ZombieType)num35, 9f, num3 != 0);
						CreateZombie instance20 = CreateZombie.Instance;
						int num37 = 0;
						int num38 = 0;
						Zombie zombie17 = instance20.SetZombie(num38, (ZombieType)num37, 9f, num3 != 0);
						CreateZombie instance21 = CreateZombie.Instance;
						int num39 = 0;
						uint num40;
						Zombie zombie18 = instance21.SetZombie((int)num40, (ZombieType)num39, 9f, num3 != 0);
						CreateZombie instance22 = CreateZombie.Instance;
						int num41 = 0;
						int num42 = 0;
						Zombie zombie19 = instance22.SetZombie(num42, (ZombieType)num41, 9f, num3 != 0);
						CreateZombie instance23 = CreateZombie.Instance;
						int num43 = 0;
						uint num44;
						Zombie zombie20 = instance23.SetZombie((int)num44, (ZombieType)num43, 9f, num3 != 0);
						CreateZombie instance24 = CreateZombie.Instance;
						int num45 = 0;
						int num46 = 0;
						Zombie zombie21 = instance24.SetZombie(num46, (ZombieType)num45, 9f, num3 != 0);
						CreateZombie instance25 = CreateZombie.Instance;
						int num47 = 0;
						uint num48;
						Zombie zombie22 = instance25.SetZombie((int)num48, (ZombieType)num47, 9f, num3 != 0);
						CreateZombie instance26 = CreateZombie.Instance;
						int num49 = 0;
						int num50 = 0;
						Zombie zombie23 = instance26.SetZombie(num50, (ZombieType)num49, 9f, num3 != 0);
						CreateZombie instance27 = CreateZombie.Instance;
						int num51 = 0;
						uint num52;
						Zombie zombie24 = instance27.SetZombie((int)num52, (ZombieType)num51, 9f, num3 != 0);
						CreateZombie instance28 = CreateZombie.Instance;
						int num53 = 0;
						int num54 = 0;
						Zombie zombie25 = instance28.SetZombie(num54, (ZombieType)num53, 9f, num3 != 0);
						CreateZombie instance29 = CreateZombie.Instance;
						int num55 = 0;
						uint num56;
						Zombie zombie26 = instance29.SetZombie((int)num56, (ZombieType)num55, 9f, num3 != 0);
						CreateZombie instance30 = CreateZombie.Instance;
						int num57 = 0;
						int num58 = 0;
						Zombie zombie27 = instance30.SetZombie(num58, (ZombieType)num57, 9f, num3 != 0);
						CreateZombie instance31 = CreateZombie.Instance;
						int num59 = 0;
						uint num60;
						Zombie zombie28 = instance31.SetZombie((int)num60, (ZombieType)num59, 9f, num3 != 0);
						CreateZombie instance32 = CreateZombie.Instance;
						int num61 = 0;
						int num62 = 0;
						Zombie zombie29 = instance32.SetZombie(num62, (ZombieType)num61, 9f, num3 != 0);
						CreateZombie instance33 = CreateZombie.Instance;
						int num63 = 0;
						uint num64;
						Zombie zombie30 = instance33.SetZombie((int)num64, (ZombieType)num63, 9f, num3 != 0);
					}
				}
				return;
			}
			InGameText instance34 = InGameText.Instance;
			ulong num65;
			instance34.ShowText("当僵尸处于红温状态时会额外受到50%的伤害", 4f, num65 != 0UL);
			this.board.showZombieHealth = true;
			uint num66;
			uint num67;
			this.ClearPlant((int)num66, (int)num67);
			int num68 = 0;
			uint num69;
			this.ClearPlant((int)num69, num68);
			uint num70;
			this.ClearPlant((int)num70, (int)num70);
			CreatePlant instance35 = CreatePlant.Instance;
			CreatePlant instance36 = CreatePlant.Instance;
			CreatePlant instance37 = CreatePlant.Instance;
			CreatePlant instance38 = CreatePlant.Instance;
			CreateZombie instance39 = CreateZombie.Instance;
		}
		InGameText instance40 = InGameText.Instance;
		ulong num71;
		instance40.ShowText("让我们来看看僵尸的一种新状态：红温", 4f, num71 != 0UL);
		this.timer = 4f;
	}

	// Token: 0x06001D92 RID: 7570 RVA: 0x0009ED58 File Offset: 0x0009CF58
	[Token(Token = "0x6001D92")]
	[Address(RVA = "0x52D080", Offset = "0x52B680", VA = "0x18052D080")]
	private void TutorUpdate30()
	{
		if (this.progress <= 5)
		{
			InGameText instance = InGameText.Instance;
			InGameText instance2 = InGameText.Instance;
			ulong num;
			instance2.ShowText("让我们来看看路灯花的新系统：光照系统", 4f, num != 0UL);
			this.timer = 4f;
		}
	}

	// Token: 0x06001D93 RID: 7571 RVA: 0x0009EF04 File Offset: 0x0009D104
	[Token(Token = "0x6001D93")]
	[Address(RVA = "0x52D650", Offset = "0x52BC50", VA = "0x18052D650")]
	private void TutorUpdate35()
	{
		if (this.progress <= 6)
		{
			InGameText instance = InGameText.Instance;
			ulong num;
			instance.ShowText("让我们来看看磁力菇带来的新系统\n磁力系统", 5f, num != 0UL);
			this.timer = 5f;
			return;
		}
	}

	// Token: 0x06001D94 RID: 7572 RVA: 0x0009F128 File Offset: 0x0009D328
	[Token(Token = "0x6001D94")]
	[Address(RVA = "0x52DE50", Offset = "0x52C450", VA = "0x18052DE50")]
	private void TutorUpdate42()
	{
		if (this.progress <= 5)
		{
			InGameText instance = InGameText.Instance;
			ulong num;
			instance.ShowText("让我们来看看金盏花带来的新系统\n金钱系统", 5f, num != 0UL);
			this.timer = 5f;
			InGameText instance2 = InGameText.Instance;
			ulong num2;
			instance2.ShowText("种植金盏花会在屏幕左下角启用钱币", 5f, num2 != 0UL);
			uint num3;
			this.ClearPlant((int)num3, (int)num3);
			CreatePlant instance3 = CreatePlant.Instance;
			CreatePlant instance4 = CreatePlant.Instance;
			InGameText instance5 = InGameText.Instance;
			int num4 = 0;
			ulong num5;
			instance5.ShowText("赚的钱可以对银植物升级\n点击屏幕左下角的咖啡豆，对卷心菜使用吧", 60f, num5 != 0UL);
			CreateZombie instance6 = CreateZombie.Instance;
			int num6 = 0;
			int num7 = 0;
			Zombie zombie = instance6.SetZombie(num7, (ZombieType)num6, 8f, num4 != 0);
			CreateZombie instance7 = CreateZombie.Instance;
			int num8 = 0;
			uint num9;
			Zombie zombie2 = instance7.SetZombie((int)num9, (ZombieType)num8, 8f, num4 != 0);
			CreateZombie instance8 = CreateZombie.Instance;
			int num10 = 0;
			uint num11;
			Zombie zombie3 = instance8.SetZombie((int)num11, (ZombieType)num10, 8f, num4 != 0);
			CreateZombie instance9 = CreateZombie.Instance;
			int num12 = 0;
			uint num13;
			Zombie zombie4 = instance9.SetZombie((int)num13, (ZombieType)num12, 8f, num4 != 0);
			CreateZombie instance10 = CreateZombie.Instance;
			int num14 = 0;
			uint num15;
			Zombie zombie5 = instance10.SetZombie((int)num15, (ZombieType)num14, 8f, num4 != 0);
			uint num16;
			uint num17;
			this.ClearPlant((int)num16, (int)num17);
			CreatePlant instance11 = CreatePlant.Instance;
			CreatePlant instance12 = CreatePlant.Instance;
			this.board.GetMoney(1000f);
		}
	}

	// Token: 0x06001D95 RID: 7573 RVA: 0x0009F3E4 File Offset: 0x0009D5E4
	[Token(Token = "0x6001D95")]
	[Address(RVA = "0x52AA00", Offset = "0x529000", VA = "0x18052AA00")]
	private void SetMissionCard(int theColumn, int theRow, PlantType theSeedType)
	{
		float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(theColumn);
		float boxYFromRow = Mouse.Instance.GetBoxYFromRow(theColumn);
	}

	// Token: 0x06001D96 RID: 7574 RVA: 0x0009F410 File Offset: 0x0009D610
	[Token(Token = "0x6001D96")]
	[Address(RVA = "0x52A8D0", Offset = "0x528ED0", VA = "0x18052A8D0")]
	private void ClearPlant(int theColumn, int theRow)
	{
		ulong num;
		do
		{
			List<Plant> list = global::Lawnf.Get1x1Plants(theColumn, theColumn);
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06001D97 RID: 7575 RVA: 0x0009F43C File Offset: 0x0009D63C
	[Token(Token = "0x6001D97")]
	[Address(RVA = "0x52ACE0", Offset = "0x5292E0", VA = "0x18052ACE0")]
	private void TutorOver()
	{
		this.board.boardTag.isTutor = false;
		this.board.timeUntilNextWave = 5f;
		global::UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06001D98 RID: 7576 RVA: 0x0009F478 File Offset: 0x0009D678
	[Token(Token = "0x6001D98")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public TutorManager()
	{
	}

	// Token: 0x04001022 RID: 4130
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001022")]
	public int id;

	// Token: 0x04001023 RID: 4131
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001023")]
	private int progress;

	// Token: 0x04001024 RID: 4132
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001024")]
	private float timer;

	// Token: 0x04001025 RID: 4133
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001025")]
	private Board board;

	// Token: 0x04001026 RID: 4134
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001026")]
	private Plant missionPlant;

	// Token: 0x04001027 RID: 4135
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001027")]
	private Zombie missionZombie;
}
