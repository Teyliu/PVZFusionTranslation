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

// Token: 0x0200076C RID: 1900
[Token(Token = "0x200076C")]
public class CheatKey : MonoBehaviour
{
	// Token: 0x060026A4 RID: 9892 RVA: 0x000CA870 File Offset: 0x000C8A70
	[Token(Token = "0x60026A4")]
	[Address(RVA = "0x61F370", Offset = "0x61D970", VA = "0x18061F370")]
	private void Awake()
	{
		KeyCode[] enumValues = global::Core.Lawnf.GetEnumValues<KeyCode>();
		Func<KeyCode, bool> func;
		if (CheatKey.<>c.<>9__4_0 == 0)
		{
			func = (KeyCode a) => a < KeyCode.JoystickButton0;
			CheatKey.<>c.<>9__4_0 = func;
		}
		CheatKey.keyCodes = Enumerable.ToArray<KeyCode>(Enumerable.Where<KeyCode>(enumValues, func));
	}

	// Token: 0x060026A5 RID: 9893 RVA: 0x000CA8B4 File Offset: 0x000C8AB4
	[Token(Token = "0x60026A5")]
	[Address(RVA = "0x61F7E0", Offset = "0x61DDE0", VA = "0x18061F7E0")]
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

	// Token: 0x060026A6 RID: 9894 RVA: 0x000CA9A0 File Offset: 0x000C8BA0
	[Token(Token = "0x60026A6")]
	[Address(RVA = "0x61F510", Offset = "0x61DB10", VA = "0x18061F510")]
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

	// Token: 0x060026A7 RID: 9895 RVA: 0x000CA9F0 File Offset: 0x000C8BF0
	[Token(Token = "0x60026A7")]
	[Address(RVA = "0x61F710", Offset = "0x61DD10", VA = "0x18061F710")]
	[ProButton]
	public void Test(PetType petType)
	{
		Board instance = Board.Instance;
	}

	// Token: 0x060026A8 RID: 9896 RVA: 0x000CAA04 File Offset: 0x000C8C04
	[Token(Token = "0x60026A8")]
	[Address(RVA = "0x61FB30", Offset = "0x61E130", VA = "0x18061FB30")]
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
			};
		}
		dictionary.Add("cheatmode", <>9__8_);
		Action action;
		if (CheatKey.<>c.<>9__8_1 == 0)
		{
			action = delegate
			{
				Board instance2 = Board.Instance;
				int num = 0;
				if (instance2 != num)
				{
					Board.Instance.GetSun(5000f, true);
					InGameText instance3 = InGameText.Instance;
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
				int num2 = 0;
				if (instance4 != num2)
				{
					GameObject gameObject = Resources.Load<GameObject>("Items/BoardGame/NutShooting/Cannon");
					Transform transform = Board.Instance.transform;
					GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform);
					InGameText instance5 = InGameText.Instance;
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
				int num3 = 0;
				if (instance6 != num3)
				{
					Board instance7 = Board.Instance;
					int theMaxWave = instance7.theMaxWave;
					instance7.theWave = theMaxWave;
					CreateZombie instance8 = CreateZombie.Instance;
					int num4 = 0;
					int num5 = 0;
					ulong num6;
					Zombie zombie = instance8.SetZombie(num5, (ZombieType)num4, 9.9f, num6 != 0UL);
					int size = Board.Instance.zombieArray._size;
					int num7 = size - 1;
					if (size > 0)
					{
						Zombie zombie2 = Board.Instance.zombieArray[num7];
						int num8 = 0;
						if (zombie2 != num8)
						{
							Board.Instance.zombieArray[num7].Die(2);
						}
						if (num7 > 0)
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
				ulong num10;
				do
				{
					Board instance9 = Board.Instance;
					int num9 = 0;
					if (!(instance9 != num9))
					{
						return;
					}
					List<Plant> allPlants = global::Lawnf.GetAllPlants();
					bool flag;
					if (flag)
					{
					}
				}
				while (num10 != (ulong)0L);
				InGameText instance10 = InGameText.Instance;
			};
			CheatKey.<>c.<>9__8_4 = action4;
		}
		dictionary.Add("clearplant", action4);
		Action action5;
		if (CheatKey.<>c.<>9__8_5 == 0)
		{
			action5 = delegate
			{
				ulong num12;
				do
				{
					Board instance11 = Board.Instance;
					int num11 = 0;
					if (!(instance11 != num11))
					{
						return;
					}
					List<Zombie> allZombies = global::Lawnf.GetAllZombies(false);
					bool flag2;
					if (flag2)
					{
					}
				}
				while (num12 != (ulong)0L);
				InGameText instance12 = InGameText.Instance;
			};
			CheatKey.<>c.<>9__8_5 = action5;
		}
		dictionary.Add("clearzombie", action5);
		Action action6;
		if (CheatKey.<>c.<>9__8_6 == 0)
		{
			action6 = delegate
			{
				int num13 = TreasureData.treasureMoney;
				num13 += 1000000;
				TreasureData.treasureMoney = num13;
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
				int num14 = 0;
				if (instance13 != num14)
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
				int num15 = 0;
				if ((config2.debug ? 1 : 0) == num15)
				{
					InGameText instance15 = InGameText.Instance;
					return;
				}
				InGameText instance16 = InGameText.Instance;
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
				int num16 = 0;
				if (instance17 != num16)
				{
					MiniPet pet = Board.Instance.pet;
					int num17 = 0;
					if (pet != num17)
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
				int num18 = 0;
				if (instance18 != num18)
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
				AdvantureManager instance19 = AdvantureManager.Instance;
				int num19 = 0;
				if (instance19 != num19)
				{
					AdvantureManager instance20 = AdvantureManager.Instance;
					if (instance20.mission != (ulong)0L)
					{
						instance20.mission.result = (MissionResult)((ulong)1L);
					}
				}
			};
			CheatKey.<>c.<>9__8_12 = action12;
		}
		dictionary.Add("missiona", action12);
		Action action13;
		if (CheatKey.<>c.<>9__8_13 == 0)
		{
			action13 = delegate
			{
				AdvantureManager instance21 = AdvantureManager.Instance;
				int num20 = 0;
				if (instance21 != num20)
				{
					AdvantureManager instance22 = AdvantureManager.Instance;
					if (instance22.mission != (ulong)0L)
					{
						instance22.mission.result = (MissionResult)((ulong)2L);
					}
				}
			};
			CheatKey.<>c.<>9__8_13 = action13;
		}
		dictionary.Add("missionb", action13);
		Action action14;
		if (CheatKey.<>c.<>9__8_14 == 0)
		{
			action14 = delegate
			{
				UIResourcesLoader uimanager = GameAPP.UIManager;
				Transform canvasUp = GameAPP.canvasUp;
				int num21 = 0;
				BaseMenu baseMenu = uimanager.Push((UIType)((uint)73), canvasUp, num21 != 0);
			};
			CheatKey.<>c.<>9__8_14 = action14;
		}
		dictionary.Add("online", action14);
		Action action15;
		if (CheatKey.<>c.<>9__8_15 == 0)
		{
			action15 = delegate
			{
				ShootingManager instance23 = ShootingManager.Instance;
				int num22 = 0;
				if (instance23 != num22)
				{
					ShootingManager.Instance.CheatHard();
					return;
				}
			};
			CheatKey.<>c.<>9__8_15 = action15;
		}
		dictionary.Add("shoothard", action15);
		Action action16;
		if (CheatKey.<>c.<>9__8_16 == 0)
		{
			action16 = delegate
			{
				UIResourcesLoader uimanager2 = GameAPP.UIManager;
				int num23 = 0;
				BaseMenu baseMenu2 = uimanager2.Push((UIType)((uint)90), num23 != 0);
			};
			CheatKey.<>c.<>9__8_16 = action16;
		}
		dictionary.Add("openblive", action16);
		this.CheatKeys = dictionary;
		base..ctor();
	}

	// Token: 0x040013AB RID: 5035
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013AB")]
	[SerializeField]
	private string key = "";

	// Token: 0x040013AC RID: 5036
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013AC")]
	private float timer;

	// Token: 0x040013AD RID: 5037
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40013AD")]
	private readonly Dictionary<string, Action> CheatKeys;

	// Token: 0x040013AE RID: 5038
	[Token(Token = "0x40013AE")]
	public static KeyCode[] keyCodes;
}
