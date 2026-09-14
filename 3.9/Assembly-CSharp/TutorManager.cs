using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000651 RID: 1617
[Token(Token = "0x2000651")]
public class TutorManager : MonoBehaviour
{
	// Token: 0x06001E85 RID: 7813 RVA: 0x000A25C8 File Offset: 0x000A07C8
	[Token(Token = "0x6001E85")]
	[Address(RVA = "0x595A70", Offset = "0x594070", VA = "0x180595A70")]
	private void Awake()
	{
		Board instance = Board.Instance;
		this.board = instance;
		this.progress = (int)((ulong)0L);
	}

	// Token: 0x06001E86 RID: 7814 RVA: 0x000A25EC File Offset: 0x000A07EC
	[Token(Token = "0x6001E86")]
	[Address(RVA = "0x59A910", Offset = "0x598F10", VA = "0x18059A910")]
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

	// Token: 0x06001E87 RID: 7815 RVA: 0x000A26D0 File Offset: 0x000A08D0
	[Token(Token = "0x6001E87")]
	[Address(RVA = "0x595CA0", Offset = "0x5942A0", VA = "0x180595CA0")]
	private void TowerUpdate()
	{
		if (this.progress <= 6)
		{
			InGameText instance = InGameText.Instance;
			this.timer = 3f;
		}
	}

	// Token: 0x06001E88 RID: 7816 RVA: 0x000A2768 File Offset: 0x000A0968
	[Token(Token = "0x6001E88")]
	[Address(RVA = "0x596E50", Offset = "0x595450", VA = "0x180596E50")]
	private void TutorUpdate1()
	{
		if (this.progress <= 6)
		{
			InGameText instance = InGameText.Instance;
			this.timer = 3f;
		}
	}

	// Token: 0x06001E89 RID: 7817 RVA: 0x000A289C File Offset: 0x000A0A9C
	[Token(Token = "0x6001E89")]
	[Address(RVA = "0x599D50", Offset = "0x598350", VA = "0x180599D50")]
	private void TutorUpdate4()
	{
		int num = this.progress;
		if (num == 0)
		{
			InGameText instance = InGameText.Instance;
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
					int num2 = 0;
					if (plant != num2 && this.missionPlant.thePlantColumn < 5)
					{
						InGameText instance2 = InGameText.Instance;
						this.TutorOver();
						return;
					}
				}
			}
			else
			{
				InGameText instance3 = InGameText.Instance;
				uint num3;
				uint num4;
				this.ClearPlant((int)num3, (int)num4);
				uint num5;
				uint num6;
				this.ClearPlant((int)num5, (int)num6);
				CreatePlant instance4 = CreatePlant.Instance;
				Plant plant2;
				this.missionPlant = plant2;
				CreatePlant instance5 = CreatePlant.Instance;
			}
			return;
		}
		InGameText instance6 = InGameText.Instance;
		this.timer = 5f;
	}

	// Token: 0x06001E8A RID: 7818 RVA: 0x000A2970 File Offset: 0x000A0B70
	[Token(Token = "0x6001E8A")]
	[Address(RVA = "0x59A090", Offset = "0x598690", VA = "0x18059A090")]
	private void TutorUpdate7()
	{
		int num;
		for (;;)
		{
			num = this.progress;
			if (num == 0)
			{
				goto IL_00CA;
			}
			if (num == 0)
			{
				goto IL_00A0;
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
					this.TutorOver();
					return;
				}
			}
		}
		else
		{
			InGameText instance2 = InGameText.Instance;
			CreateZombie instance3 = CreateZombie.Instance;
			Zombie zombie2;
			Zombie component = zombie2.GetComponent<Zombie>();
			this.missionZombie = component;
		}
		return;
		Block_6:
		InGameText instance4 = InGameText.Instance;
		this.timer = 3f;
		return;
		IL_00A0:
		InGameText instance5 = InGameText.Instance;
		uint num4;
		uint num5;
		this.ClearPlant((int)num4, (int)num5);
		CreatePlant instance6 = CreatePlant.Instance;
		Plant plant2;
		this.missionPlant = plant2;
		return;
		IL_00CA:
		InGameText instance7 = InGameText.Instance;
		this.timer = 6f;
	}

	// Token: 0x06001E8B RID: 7819 RVA: 0x000A2A68 File Offset: 0x000A0C68
	[Token(Token = "0x6001E8B")]
	[Address(RVA = "0x59A470", Offset = "0x598A70", VA = "0x18059A470")]
	private void TutorUpdate8()
	{
		int num3;
		do
		{
			int num = 0;
			int num2 = this.progress;
			if (num2 == 0)
			{
				goto IL_00C8;
			}
			if (num2 == 0)
			{
				goto IL_00A3;
			}
			if (num2 == 0)
			{
				goto IL_0079;
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
				InGameText instance = InGameText.Instance;
				this.timer = 3f;
			}
		}
		while (num3 != 0);
		InGameText instance2 = InGameText.Instance;
		this.TutorOver();
		IL_0079:
		Zombie zombie = this.missionZombie;
		if (zombie.beforeDying || zombie.theStatus == ZombieStatus.Dying)
		{
			InGameText instance3 = InGameText.Instance;
		}
		return;
		IL_00A3:
		InGameText instance4 = InGameText.Instance;
		CreateZombie instance5 = CreateZombie.Instance;
		Zombie zombie2;
		Zombie component = zombie2.GetComponent<Zombie>();
		this.missionZombie = component;
		IL_00C8:
		InGameText instance6 = InGameText.Instance;
		this.timer = 4f;
		throw new NullReferenceException();
	}

	// Token: 0x06001E8C RID: 7820 RVA: 0x000A2B68 File Offset: 0x000A0D68
	[Token(Token = "0x6001E8C")]
	[Address(RVA = "0x595F90", Offset = "0x594590", VA = "0x180595F90")]
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
						this.TutorOver();
						return;
					}
					return;
				}
				else
				{
					InGameText instance2 = InGameText.Instance;
					CreatePlant instance3 = CreatePlant.Instance;
				}
			}
			InGameText instance4 = InGameText.Instance;
			uint num2;
			this.ClearPlant((int)num2, (int)num2);
			CreatePlant instance5 = CreatePlant.Instance;
			CreatePlant instance6 = CreatePlant.Instance;
			CreatePlant instance7 = CreatePlant.Instance;
			this.timer = 4f;
			return;
		}
		InGameText instance8 = InGameText.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x06001E8D RID: 7821 RVA: 0x000A2C04 File Offset: 0x000A0E04
	[Token(Token = "0x6001E8D")]
	[Address(RVA = "0x5962C0", Offset = "0x5948C0", VA = "0x1805962C0")]
	private void TutorUpdate13()
	{
		if (this.progress <= 8)
		{
			InGameText instance = InGameText.Instance;
			InGameText instance2 = InGameText.Instance;
			InGameText instance3 = InGameText.Instance;
			InGameText instance4 = InGameText.Instance;
			InGameText instance5 = InGameText.Instance;
			uint num;
			this.ClearPlant((int)num, (int)num);
			GameObject gameObject = Resources.Load<GameObject>("Items/Fertilize/Ferilize");
			CreatePlant instance6 = CreatePlant.Instance;
			Plant plant;
			Transform transform = plant.transform;
			Vector3 vector;
			float z = vector.z;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform2 = Board.Instance.transform;
			uint num2;
			GameAPP.PlaySound((int)num2, 0.5f, 1f);
		}
	}

	// Token: 0x06001E8E RID: 7822 RVA: 0x000A2D48 File Offset: 0x000A0F48
	[Token(Token = "0x6001E8E")]
	[Address(RVA = "0x5968B0", Offset = "0x594EB0", VA = "0x1805968B0")]
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
						uint num2;
						uint num3;
						this.ClearPlant((int)num2, (int)num3);
						uint num4;
						uint num5;
						this.ClearPlant((int)num4, (int)num5);
						uint num6;
						this.ClearPlant((int)num6, (int)num6);
						uint num7;
						uint num8;
						this.ClearPlant((int)num7, (int)num8);
						uint num9;
						uint num10;
						this.ClearPlant((int)num9, (int)num10);
						uint num11;
						uint num12;
						this.ClearPlant((int)num11, (int)num12);
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
			this.board.showZombieHealth = true;
			uint num13;
			uint num14;
			this.ClearPlant((int)num13, (int)num14);
			uint num15;
			uint num16;
			this.ClearPlant((int)num15, (int)num16);
			uint num17;
			this.ClearPlant((int)num17, (int)num17);
			uint num18;
			uint num19;
			this.ClearPlant((int)num18, (int)num19);
			uint num20;
			uint num21;
			this.ClearPlant((int)num20, (int)num21);
			uint num22;
			uint num23;
			this.ClearPlant((int)num22, (int)num23);
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
		this.timer = 4f;
	}

	// Token: 0x06001E8F RID: 7823 RVA: 0x000A2EA0 File Offset: 0x000A10A0
	[Token(Token = "0x6001E8F")]
	[Address(RVA = "0x597520", Offset = "0x595B20", VA = "0x180597520")]
	private void TutorUpdate22()
	{
		int num = this.progress;
		if (num == 0)
		{
			InGameText instance = InGameText.Instance;
			uint num2;
			uint num3;
			this.ClearPlant((int)num2, (int)num3);
			uint num4;
			uint num5;
			this.ClearPlant((int)num4, (int)num5);
			uint num6;
			this.ClearPlant((int)num6, (int)num6);
			uint num7;
			uint num8;
			this.ClearPlant((int)num7, (int)num8);
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
					this.TutorOver();
					return;
				}
			}
			else
			{
				Zombie zombie = this.missionZombie;
				int num9 = 0;
				if (zombie == num9)
				{
					Board board = this.board;
					board.showZombieHealth = false;
					InGameText instance7 = InGameText.Instance;
					this.timer = 4f;
				}
			}
			return;
		}
		InGameText instance8 = InGameText.Instance;
		this.board.showZombieHealth = true;
		CreateZombie instance9 = CreateZombie.Instance;
		Zombie zombie2;
		Zombie component = zombie2.GetComponent<Zombie>();
		this.missionZombie = component;
		this.missionZombie.theHealth = (long)((ulong)1000000L);
		this.missionZombie.theMaxHealth = (long)((ulong)1000000L);
	}

	// Token: 0x06001E90 RID: 7824 RVA: 0x000A2FC8 File Offset: 0x000A11C8
	[Token(Token = "0x6001E90")]
	[Address(RVA = "0x5979C0", Offset = "0x595FC0", VA = "0x1805979C0")]
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
						int num2 = 0;
						CreatePlant instance3 = CreatePlant.Instance;
						CreateZombie instance4 = CreateZombie.Instance;
						int num3 = 0;
						int num4 = 0;
						Zombie zombie = instance4.SetZombie(num4, (ZombieType)num3, 9f, num2 != 0);
						CreateZombie instance5 = CreateZombie.Instance;
						int num5 = 0;
						uint num6;
						Zombie zombie2 = instance5.SetZombie((int)num6, (ZombieType)num5, 9f, num2 != 0);
						CreateZombie instance6 = CreateZombie.Instance;
						int num7 = 0;
						int num8 = 0;
						Zombie zombie3 = instance6.SetZombie(num8, (ZombieType)num7, 9f, num2 != 0);
						CreateZombie instance7 = CreateZombie.Instance;
						int num9 = 0;
						uint num10;
						Zombie zombie4 = instance7.SetZombie((int)num10, (ZombieType)num9, 9f, num2 != 0);
						CreateZombie instance8 = CreateZombie.Instance;
						int num11 = 0;
						int num12 = 0;
						Zombie zombie5 = instance8.SetZombie(num12, (ZombieType)num11, 9f, num2 != 0);
						CreateZombie instance9 = CreateZombie.Instance;
						int num13 = 0;
						uint num14;
						Zombie zombie6 = instance9.SetZombie((int)num14, (ZombieType)num13, 9f, num2 != 0);
						CreateZombie instance10 = CreateZombie.Instance;
						int num15 = 0;
						int num16 = 0;
						Zombie zombie7 = instance10.SetZombie(num16, (ZombieType)num15, 9f, num2 != 0);
						CreateZombie instance11 = CreateZombie.Instance;
						int num17 = 0;
						uint num18;
						Zombie zombie8 = instance11.SetZombie((int)num18, (ZombieType)num17, 9f, num2 != 0);
						CreateZombie instance12 = CreateZombie.Instance;
						int num19 = 0;
						int num20 = 0;
						Zombie zombie9 = instance12.SetZombie(num20, (ZombieType)num19, 9f, num2 != 0);
						CreateZombie instance13 = CreateZombie.Instance;
						int num21 = 0;
						uint num22;
						Zombie zombie10 = instance13.SetZombie((int)num22, (ZombieType)num21, 9f, num2 != 0);
						CreateZombie instance14 = CreateZombie.Instance;
						int num23 = 0;
						int num24 = 0;
						Zombie zombie11 = instance14.SetZombie(num24, (ZombieType)num23, 9f, num2 != 0);
						CreateZombie instance15 = CreateZombie.Instance;
						int num25 = 0;
						uint num26;
						Zombie zombie12 = instance15.SetZombie((int)num26, (ZombieType)num25, 9f, num2 != 0);
						CreateZombie instance16 = CreateZombie.Instance;
						int num27 = 0;
						int num28 = 0;
						Zombie zombie13 = instance16.SetZombie(num28, (ZombieType)num27, 9f, num2 != 0);
						CreateZombie instance17 = CreateZombie.Instance;
						int num29 = 0;
						uint num30;
						Zombie zombie14 = instance17.SetZombie((int)num30, (ZombieType)num29, 9f, num2 != 0);
						CreateZombie instance18 = CreateZombie.Instance;
						int num31 = 0;
						int num32 = 0;
						Zombie zombie15 = instance18.SetZombie(num32, (ZombieType)num31, 9f, num2 != 0);
						CreateZombie instance19 = CreateZombie.Instance;
						int num33 = 0;
						uint num34;
						Zombie zombie16 = instance19.SetZombie((int)num34, (ZombieType)num33, 9f, num2 != 0);
						CreateZombie instance20 = CreateZombie.Instance;
						int num35 = 0;
						int num36 = 0;
						Zombie zombie17 = instance20.SetZombie(num36, (ZombieType)num35, 9f, num2 != 0);
						CreateZombie instance21 = CreateZombie.Instance;
						int num37 = 0;
						uint num38;
						Zombie zombie18 = instance21.SetZombie((int)num38, (ZombieType)num37, 9f, num2 != 0);
						CreateZombie instance22 = CreateZombie.Instance;
						int num39 = 0;
						int num40 = 0;
						Zombie zombie19 = instance22.SetZombie(num40, (ZombieType)num39, 9f, num2 != 0);
						CreateZombie instance23 = CreateZombie.Instance;
						int num41 = 0;
						uint num42;
						Zombie zombie20 = instance23.SetZombie((int)num42, (ZombieType)num41, 9f, num2 != 0);
						CreateZombie instance24 = CreateZombie.Instance;
						int num43 = 0;
						int num44 = 0;
						Zombie zombie21 = instance24.SetZombie(num44, (ZombieType)num43, 9f, num2 != 0);
						CreateZombie instance25 = CreateZombie.Instance;
						int num45 = 0;
						uint num46;
						Zombie zombie22 = instance25.SetZombie((int)num46, (ZombieType)num45, 9f, num2 != 0);
						CreateZombie instance26 = CreateZombie.Instance;
						int num47 = 0;
						int num48 = 0;
						Zombie zombie23 = instance26.SetZombie(num48, (ZombieType)num47, 9f, num2 != 0);
						CreateZombie instance27 = CreateZombie.Instance;
						int num49 = 0;
						uint num50;
						Zombie zombie24 = instance27.SetZombie((int)num50, (ZombieType)num49, 9f, num2 != 0);
						CreateZombie instance28 = CreateZombie.Instance;
						int num51 = 0;
						int num52 = 0;
						Zombie zombie25 = instance28.SetZombie(num52, (ZombieType)num51, 9f, num2 != 0);
						CreateZombie instance29 = CreateZombie.Instance;
						int num53 = 0;
						uint num54;
						Zombie zombie26 = instance29.SetZombie((int)num54, (ZombieType)num53, 9f, num2 != 0);
						CreateZombie instance30 = CreateZombie.Instance;
						int num55 = 0;
						int num56 = 0;
						Zombie zombie27 = instance30.SetZombie(num56, (ZombieType)num55, 9f, num2 != 0);
						CreateZombie instance31 = CreateZombie.Instance;
						int num57 = 0;
						uint num58;
						Zombie zombie28 = instance31.SetZombie((int)num58, (ZombieType)num57, 9f, num2 != 0);
						CreateZombie instance32 = CreateZombie.Instance;
						int num59 = 0;
						int num60 = 0;
						Zombie zombie29 = instance32.SetZombie(num60, (ZombieType)num59, 9f, num2 != 0);
						CreateZombie instance33 = CreateZombie.Instance;
						int num61 = 0;
						uint num62;
						Zombie zombie30 = instance33.SetZombie((int)num62, (ZombieType)num61, 9f, num2 != 0);
					}
				}
				return;
			}
			InGameText instance34 = InGameText.Instance;
			int num63 = 0;
			this.board.showZombieHealth = true;
			uint num64;
			uint num65;
			this.ClearPlant((int)num64, (int)num65);
			int num66 = 0;
			uint num67;
			this.ClearPlant((int)num67, num66);
			uint num68;
			this.ClearPlant((int)num68, (int)num68);
			CreatePlant instance35 = CreatePlant.Instance;
			CreatePlant instance36 = CreatePlant.Instance;
			CreatePlant instance37 = CreatePlant.Instance;
			int num69 = 0;
			int num70 = 0;
			uint num71;
			ulong num72;
			Plant plant = instance37.SetPlant((int)num71, num70, (PlantType)num69, num63, num63, num63 != 0, num72 != 0UL, num63);
			CreatePlant instance38 = CreatePlant.Instance;
			int num73 = 0;
			uint num74;
			ulong num75;
			Plant plant2 = instance38.SetPlant((int)num74, (int)num74, (PlantType)num73, num63, num63, num63 != 0, num75 != 0UL, num63);
			CreateZombie instance39 = CreateZombie.Instance;
		}
		InGameText instance40 = InGameText.Instance;
		this.timer = 4f;
	}

	// Token: 0x06001E91 RID: 7825 RVA: 0x000A34B8 File Offset: 0x000A16B8
	[Token(Token = "0x6001E91")]
	[Address(RVA = "0x598410", Offset = "0x596A10", VA = "0x180598410")]
	private void TutorUpdate30()
	{
		if (this.progress <= 5)
		{
			InGameText instance = InGameText.Instance;
			InGameText instance2 = InGameText.Instance;
			this.timer = 4f;
		}
	}

	// Token: 0x06001E92 RID: 7826 RVA: 0x000A3608 File Offset: 0x000A1808
	[Token(Token = "0x6001E92")]
	[Address(RVA = "0x598A30", Offset = "0x597030", VA = "0x180598A30")]
	private void TutorUpdate35()
	{
		if (this.progress <= 6)
		{
			InGameText instance = InGameText.Instance;
			this.timer = 5f;
			return;
		}
	}

	// Token: 0x06001E93 RID: 7827 RVA: 0x000A37A8 File Offset: 0x000A19A8
	[Token(Token = "0x6001E93")]
	[Address(RVA = "0x5992A0", Offset = "0x5978A0", VA = "0x1805992A0")]
	private void TutorUpdate42()
	{
		if (this.progress <= 5)
		{
			InGameText instance = InGameText.Instance;
			this.timer = 5f;
			InGameText instance2 = InGameText.Instance;
			uint num;
			this.ClearPlant((int)num, (int)num);
			CreatePlant instance3 = CreatePlant.Instance;
			CreatePlant instance4 = CreatePlant.Instance;
			InGameText instance5 = InGameText.Instance;
			int num2 = 0;
			CreateZombie instance6 = CreateZombie.Instance;
			int num3 = 0;
			int num4 = 0;
			Zombie zombie = instance6.SetZombie(num4, (ZombieType)num3, 8f, num2 != 0);
			CreateZombie instance7 = CreateZombie.Instance;
			int num5 = 0;
			uint num6;
			Zombie zombie2 = instance7.SetZombie((int)num6, (ZombieType)num5, 8f, num2 != 0);
			CreateZombie instance8 = CreateZombie.Instance;
			int num7 = 0;
			uint num8;
			Zombie zombie3 = instance8.SetZombie((int)num8, (ZombieType)num7, 8f, num2 != 0);
			CreateZombie instance9 = CreateZombie.Instance;
			int num9 = 0;
			uint num10;
			Zombie zombie4 = instance9.SetZombie((int)num10, (ZombieType)num9, 8f, num2 != 0);
			CreateZombie instance10 = CreateZombie.Instance;
			int num11 = 0;
			uint num12;
			Zombie zombie5 = instance10.SetZombie((int)num12, (ZombieType)num11, 8f, num2 != 0);
			uint num13;
			uint num14;
			this.ClearPlant((int)num13, (int)num14);
			CreatePlant instance11 = CreatePlant.Instance;
			CreatePlant instance12 = CreatePlant.Instance;
			this.board.GetMoney(1000f);
		}
	}

	// Token: 0x06001E94 RID: 7828 RVA: 0x000A39F4 File Offset: 0x000A1BF4
	[Token(Token = "0x6001E94")]
	[Address(RVA = "0x595BF0", Offset = "0x5941F0", VA = "0x180595BF0")]
	private void SetMissionCard(int theColumn, int theRow, PlantType theSeedType)
	{
		float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(theColumn);
		float boxYFromRow = Mouse.Instance.GetBoxYFromRow(theColumn);
	}

	// Token: 0x06001E95 RID: 7829 RVA: 0x000A3A20 File Offset: 0x000A1C20
	[Token(Token = "0x6001E95")]
	[Address(RVA = "0x595AC0", Offset = "0x5940C0", VA = "0x180595AC0")]
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

	// Token: 0x06001E96 RID: 7830 RVA: 0x000A3A4C File Offset: 0x000A1C4C
	[Token(Token = "0x6001E96")]
	[Address(RVA = "0x595F10", Offset = "0x594510", VA = "0x180595F10")]
	private void TutorOver()
	{
		this.board.boardTag.isTutor = false;
		this.board.timeUntilNextWave = 5f;
		global::UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06001E97 RID: 7831 RVA: 0x000A3A88 File Offset: 0x000A1C88
	[Token(Token = "0x6001E97")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public TutorManager()
	{
	}

	// Token: 0x040010EA RID: 4330
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010EA")]
	public int id;

	// Token: 0x040010EB RID: 4331
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40010EB")]
	private int progress;

	// Token: 0x040010EC RID: 4332
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40010EC")]
	private float timer;

	// Token: 0x040010ED RID: 4333
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40010ED")]
	private Board board;

	// Token: 0x040010EE RID: 4334
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40010EE")]
	private Plant missionPlant;

	// Token: 0x040010EF RID: 4335
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40010EF")]
	private Zombie missionZombie;
}
