using System;
using System.Collections.Generic;
using System.Linq;
using AlmanacData;
using com.cyborgAssets.inspectorButtonPro;
using Core;
using Cpp2IlInjected;
using GameLevel.EventNodes;
using GameLevel.RogueShooting;
using UnityEngine;

// Token: 0x02000733 RID: 1843
[Token(Token = "0x2000733")]
public class CheatKey : MonoBehaviour
{
	// Token: 0x0600257F RID: 9599 RVA: 0x000C58D4 File Offset: 0x000C3AD4
	[Token(Token = "0x600257F")]
	[Address(RVA = "0x5BE7F0", Offset = "0x5BCDF0", VA = "0x1805BE7F0")]
	private void Awake()
	{
		KeyCode[] enumValues = global::Core.Lawnf.GetEnumValues<KeyCode>();
		Func<KeyCode, bool> <>9__4_ = CheatKey.<>c.<>9__4_0;
		if (<>9__4_ == 0)
		{
			CheatKey.<>c.<>9__4_0 = (KeyCode a) => a < KeyCode.JoystickButton0;
		}
		CheatKey.keyCodes = Enumerable.ToArray<KeyCode>(Enumerable.Where<KeyCode>(enumValues, <>9__4_));
	}

	// Token: 0x06002580 RID: 9600 RVA: 0x000C5918 File Offset: 0x000C3B18
	[Token(Token = "0x6002580")]
	[Address(RVA = "0x5BEC60", Offset = "0x5BD260", VA = "0x1805BEC60")]
	private void Update()
	{
		int num3;
		ulong num6;
		do
		{
			float num = this.timer;
			int num2 = 0;
			if (num > (float)num2)
			{
				float deltaTime = Time.deltaTime;
				this.timer = num;
				this.key = "";
				this.timer = 0f;
			}
			KeyCode[] array = CheatKey.keyCodes;
			num3 = 0;
			if (num3 >= array.Length)
			{
				goto IL_00CF;
			}
			int num4 = (int)array[num3];
			if (num3 == 0)
			{
				break;
			}
			if (num3 <= 25)
			{
				string text = this.key;
				string text3;
				string text2 = text3.ToLower();
				string text4 = text + text2;
				this.key = text4;
				this.timer = 3f;
			}
			Board instance = Board.Instance;
			int num5 = 0;
			if (!(instance != num5))
			{
				break;
			}
			List<OnKeyPressNode> keyPressNodes = EventNodeManager.Instance.keyPressNodes;
			bool flag;
			if (flag)
			{
			}
		}
		while (num6 != (ulong)0L);
		num3++;
		IL_00CF:
		this.CheckCheatCodes();
	}

	// Token: 0x06002581 RID: 9601 RVA: 0x000C5A04 File Offset: 0x000C3C04
	[Token(Token = "0x6002581")]
	[Address(RVA = "0x5BE990", Offset = "0x5BCF90", VA = "0x1805BE990")]
	private void CheckCheatCodes()
	{
		ulong num;
		do
		{
			Dictionary<string, Action> cheatKeys = this.CheatKeys;
			bool flag;
			if (flag)
			{
				string text = this.key;
				bool flag2;
				while (!flag2)
				{
				}
				this.key = "";
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06002582 RID: 9602 RVA: 0x000C5A54 File Offset: 0x000C3C54
	[Token(Token = "0x6002582")]
	[Address(RVA = "0x5BEB90", Offset = "0x5BD190", VA = "0x1805BEB90")]
	[ProButton]
	public void Test(PetType petType)
	{
		Board instance = Board.Instance;
	}

	// Token: 0x06002583 RID: 9603 RVA: 0x000C5A68 File Offset: 0x000C3C68
	[Token(Token = "0x6002583")]
	[Address(RVA = "0x5BEFB0", Offset = "0x5BD5B0", VA = "0x1805BEFB0")]
	public CheatKey()
	{
		Dictionary<string, Action> dictionary = new Dictionary();
		Action <>9__8_ = CheatKey.<>c.<>9__8_0;
		if (<>9__8_ == 0)
		{
			CheatKey.<>c.<>9__8_0 = delegate
			{
				GameAPP.developerMode = "{il2cpp field on {'constant10' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0xAC}" == (ulong)0L;
				InGameText instance = InGameText.Instance;
				int num = 0;
				instance.ShowText(" 作弊模式已开启", 3f, num != 0);
			};
		}
		dictionary.Add("cheatmode", <>9__8_);
		Action action;
		if (CheatKey.<>c.<>9__8_1 == 0)
		{
			action = delegate
			{
				Board instance2 = Board.Instance;
				int num2 = 0;
				if (instance2 != num2)
				{
					Board.Instance.GetSun(5000f, true);
					InGameText instance3 = InGameText.Instance;
					int num3 = 0;
					instance3.ShowText("获得5000阳光（作弊）", 3f, num3 != 0);
				}
			};
			CheatKey.<>c.<>9__8_1 = action;
		}
		dictionary.Add("moresun", action);
		Action action2;
		if (CheatKey.<>c.<>9__8_2 == 0)
		{
			action2 = delegate
			{
				Board instance4 = Board.Instance;
				int num4 = 0;
				if (instance4 != num4)
				{
					GameObject gameObject = Resources.Load<GameObject>("Items/BoardGame/NutShooting/Cannon");
					Transform transform = Board.Instance.transform;
					GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform);
					InGameText instance5 = InGameText.Instance;
					int num5 = 0;
					instance5.ShowText("神秘大炮（作弊）", 3f, num5 != 0);
				}
			};
			CheatKey.<>c.<>9__8_2 = action2;
		}
		dictionary.Add("bigcannon", action2);
		Action action3;
		if (CheatKey.<>c.<>9__8_3 == 0)
		{
			action3 = delegate
			{
				Board instance6 = Board.Instance;
				int num6 = 0;
				if (instance6 != num6)
				{
					Board instance7 = Board.Instance;
					int theMaxWave = instance7.theMaxWave;
					instance7.theWave = theMaxWave;
					CreateZombie instance8 = CreateZombie.Instance;
					int num7 = 0;
					int num8 = 0;
					ulong num9;
					Zombie zombie = instance8.SetZombie(num8, (ZombieType)num7, 9.9f, num9 != 0UL);
					int size = Board.Instance.zombieArray._size;
					int num10 = size - 1;
					if (size > 0)
					{
						Zombie zombie2 = Board.Instance.zombieArray[num10];
						int num11 = 0;
						if (zombie2 != num11)
						{
							Board.Instance.zombieArray[num10].Die(2);
						}
						if (num10 > 0)
						{
						}
					}
				}
			};
			CheatKey.<>c.<>9__8_3 = action3;
		}
		dictionary.Add("irwinner", action3);
		Action action4;
		if (CheatKey.<>c.<>9__8_4 == 0)
		{
			action4 = delegate
			{
				ulong num13;
				do
				{
					Board instance9 = Board.Instance;
					int num12 = 0;
					if (!(instance9 != num12))
					{
						return;
					}
					List<Plant> allPlants = global::Lawnf.GetAllPlants();
					bool flag;
					if (flag)
					{
					}
				}
				while (num13 != (ulong)0L);
				InGameText instance10 = InGameText.Instance;
				int num14 = 0;
				instance10.ShowText("清理植物（作弊）", 3f, num14 != 0);
			};
			CheatKey.<>c.<>9__8_4 = action4;
		}
		dictionary.Add("clearplant", action4);
		Action action5;
		if (CheatKey.<>c.<>9__8_5 == 0)
		{
			action5 = delegate
			{
				ulong num16;
				do
				{
					Board instance11 = Board.Instance;
					int num15 = 0;
					if (!(instance11 != num15))
					{
						return;
					}
					List<Zombie> allZombies = global::Lawnf.GetAllZombies(false);
					bool flag2;
					if (flag2)
					{
					}
				}
				while (num16 != (ulong)0L);
				InGameText instance12 = InGameText.Instance;
				int num17 = 0;
				instance12.ShowText("清理僵尸（作弊）", 3f, num17 != 0);
			};
			CheatKey.<>c.<>9__8_5 = action5;
		}
		dictionary.Add("clearzombie", action5);
		Action action6;
		if (CheatKey.<>c.<>9__8_6 == 0)
		{
			action6 = delegate
			{
				int num18 = TreasureData.treasureMoney;
				num18 += 1000000;
				TreasureData.treasureMoney = num18;
			};
			CheatKey.<>c.<>9__8_6 = action6;
		}
		dictionary.Add("mysmoney", action6);
		Action action7;
		if (CheatKey.<>c.<>9__8_7 == 0)
		{
			action7 = delegate
			{
				Board instance13 = Board.Instance;
				int num19 = 0;
				if (instance13 != num19)
				{
				}
			};
			CheatKey.<>c.<>9__8_7 = action7;
		}
		dictionary.Add("givecard", action7);
		Action action8;
		if (CheatKey.<>c.<>9__8_8 == 0)
		{
			action8 = delegate
			{
				InGameText instance14 = InGameText.Instance;
				int num20 = 0;
				instance14.ShowText("已重新加载配方关卡数据", 3f, num20 != 0);
				ExploreDataManager.LoadData();
				AlmanacDataLoader.Reload();
			};
			CheatKey.<>c.<>9__8_8 = action8;
		}
		dictionary.Add("reload", action8);
		Action action9;
		if (CheatKey.<>c.<>9__8_9 == 0)
		{
			action9 = delegate
			{
				GameConfig config = GameAPP.config;
				bool flag3 = !config.debug;
				config.debug = flag3;
				GameConfig config2 = GameAPP.config;
				int num21 = 0;
				if ((config2.debug ? 1 : 0) == num21)
				{
					InGameText instance15 = InGameText.Instance;
					int num22 = 0;
					instance15.ShowText("debug模式关闭", 3f, num22 != 0);
					return;
				}
				InGameText instance16 = InGameText.Instance;
				int num23 = 0;
				instance16.ShowText("debug模式开启", 3f, num23 != 0);
			};
			CheatKey.<>c.<>9__8_9 = action9;
		}
		dictionary.Add("debug", action9);
		Action action10;
		if (CheatKey.<>c.<>9__8_10 == 0)
		{
			action10 = delegate
			{
				Board instance17 = Board.Instance;
				int num24 = 0;
				if (instance17 != num24)
				{
					MiniPet pet = Board.Instance.pet;
					int num25 = 0;
					if (pet != num25)
					{
						Board.Instance.pet.GetExperience(3000);
						return;
					}
				}
			};
			CheatKey.<>c.<>9__8_10 = action10;
		}
		dictionary.Add("upup", action10);
		Action action11;
		if (CheatKey.<>c.<>9__8_11 == 0)
		{
			action11 = delegate
			{
				Board instance18 = Board.Instance;
				int num26 = 0;
				if (instance18 != num26)
				{
					GameAPP.PlaySound(95, 0.5f, 1f);
					GameObject gameObject3 = Resources.Load<GameObject>("Plants/Travel/SuperSunNut/UltimateJalaNut/Nut");
					Transform transform2 = Board.Instance.transform;
					GameObject gameObject4 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject3, transform2);
				}
			};
			CheatKey.<>c.<>9__8_11 = action11;
		}
		dictionary.Add("kill", action11);
		Action action12;
		if (CheatKey.<>c.<>9__8_12 == 0)
		{
			action12 = delegate
			{
				Board instance19 = Board.Instance;
				int num27 = 0;
				if (instance19 != num27)
				{
					Board.Instance.damageReporter.ReportToFile();
					return;
				}
			};
			CheatKey.<>c.<>9__8_12 = action12;
		}
		dictionary.Add("report", action12);
		Action action13;
		if (CheatKey.<>c.<>9__8_13 == 0)
		{
			action13 = delegate
			{
				AdvantureManager instance20 = AdvantureManager.Instance;
				int num28 = 0;
				if (instance20 != num28)
				{
					AdvantureManager instance21 = AdvantureManager.Instance;
					if (instance21.mission != (ulong)0L)
					{
						instance21.mission.result = (MissionResult)((ulong)1L);
					}
				}
			};
			CheatKey.<>c.<>9__8_13 = action13;
		}
		dictionary.Add("missiona", action13);
		Action action14;
		if (CheatKey.<>c.<>9__8_14 == 0)
		{
			action14 = delegate
			{
				AdvantureManager instance22 = AdvantureManager.Instance;
				int num29 = 0;
				if (instance22 != num29)
				{
					AdvantureManager instance23 = AdvantureManager.Instance;
					if (instance23.mission != (ulong)0L)
					{
						instance23.mission.result = (MissionResult)((ulong)2L);
					}
				}
			};
			CheatKey.<>c.<>9__8_14 = action14;
		}
		dictionary.Add("missionb", action14);
		Action action15;
		if (CheatKey.<>c.<>9__8_15 == 0)
		{
			action15 = delegate
			{
				UIResourcesLoader uimanager = GameAPP.UIManager;
				Transform canvasUp = GameAPP.canvasUp;
				int num30 = 0;
				BaseMenu baseMenu = uimanager.Push((UIType)((uint)73), canvasUp, num30 != 0);
			};
			CheatKey.<>c.<>9__8_15 = action15;
		}
		dictionary.Add("online", action15);
		Action action16;
		if (CheatKey.<>c.<>9__8_16 == 0)
		{
			action16 = delegate
			{
				ShootingManager instance24 = ShootingManager.Instance;
				int num31 = 0;
				if (instance24 != num31)
				{
					ShootingManager.Instance.CheatHard();
					return;
				}
			};
			CheatKey.<>c.<>9__8_16 = action16;
		}
		dictionary.Add("shoothard", action16);
		this.CheatKeys = dictionary;
		base..ctor();
	}

	// Token: 0x040012D5 RID: 4821
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40012D5")]
	[SerializeField]
	private string key = "";

	// Token: 0x040012D6 RID: 4822
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40012D6")]
	private float timer;

	// Token: 0x040012D7 RID: 4823
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40012D7")]
	private readonly Dictionary<string, Action> CheatKeys;

	// Token: 0x040012D8 RID: 4824
	[Token(Token = "0x40012D8")]
	public static KeyCode[] keyCodes;
}
