using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using AlmanacData;
using Core;
using Cpp2IlInjected;
using OpenBLive.Runtime;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CA9 RID: 3241
	[Token(Token = "0x2000CA9")]
	public class ShootingManager : MonoBehaviour
	{
		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x0600431D RID: 17181 RVA: 0x0015D44C File Offset: 0x0015B64C
		[Token(Token = "0x170005DD")]
		public static RogueShootingData Data
		{
			[Token(Token = "0x600431D")]
			[Address(RVA = "0x89E620", Offset = "0x89CC20", VA = "0x18089E620")]
			get
			{
				return GameAPP.config.shootingData;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x0600431E RID: 17182 RVA: 0x0015D46C File Offset: 0x0015B66C
		[Token(Token = "0x170005DE")]
		private bool SuperQualitative
		{
			[Token(Token = "0x600431E")]
			[Address(RVA = "0x89E800", Offset = "0x89CE00", VA = "0x18089E800")]
			get
			{
				float value = global::UnityEngine.Random.value;
				return false;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x0600431F RID: 17183 RVA: 0x0015D484 File Offset: 0x0015B684
		// (set) Token: 0x06004320 RID: 17184 RVA: 0x0015D498 File Offset: 0x0015B698
		[Token(Token = "0x170005DF")]
		public float Lucky
		{
			[Token(Token = "0x600431F")]
			[Address(RVA = "0x89E7C0", Offset = "0x89CDC0", VA = "0x18089E7C0")]
			get
			{
				return this._lucky;
			}
			[Token(Token = "0x6004320")]
			[Address(RVA = "0x89E820", Offset = "0x89CE20", VA = "0x18089E820")]
			set
			{
				this._lucky = value;
				Dictionary<Quality, float> dictionary = new Dictionary();
				this.qualityWeights = dictionary;
				throw new NullReferenceException();
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06004321 RID: 17185 RVA: 0x0015D4C0 File Offset: 0x0015B6C0
		[Token(Token = "0x170005E0")]
		public string LuckyString
		{
			[Token(Token = "0x6004321")]
			[Address(RVA = "0x89E750", Offset = "0x89CD50", VA = "0x18089E750")]
			get
			{
				float num = this._lucky * 100f;
				return string.Format("{0:F0}", "{0:F0}");
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06004322 RID: 17186 RVA: 0x0015D4EC File Offset: 0x0015B6EC
		[Token(Token = "0x170005E1")]
		private float LuckyMultiplier
		{
			[Token(Token = "0x6004322")]
			[Address(RVA = "0x89E730", Offset = "0x89CD30", VA = "0x18089E730")]
			get
			{
				return this._lucky * 0.3f;
			}
		}

		// Token: 0x06004323 RID: 17187 RVA: 0x0015D508 File Offset: 0x0015B708
		[Token(Token = "0x6004323")]
		[Address(RVA = "0x893020", Offset = "0x891620", VA = "0x180893020")]
		private void Awake()
		{
			ShootingManager.Instance = this;
			List<PlantType> list = new List(this.AllPlants);
			this.RestPlants = list;
			this.RandomSettings();
			bool flag = GameAPP.config.shootingData.victoryTimes >= 20;
			this.canTab = flag;
		}

		// Token: 0x06004324 RID: 17188 RVA: 0x0015D558 File Offset: 0x0015B758
		[Token(Token = "0x6004324")]
		[Address(RVA = "0x89A950", Offset = "0x898F50", VA = "0x18089A950")]
		private void Start()
		{
			bool flag = GameAPP.soundManager.musics[(uint)18].LoadAudioData();
			if (GameAPP.config.ra2Sound)
			{
				bool flag2 = GameAPP.soundManager.musics[(uint)26].LoadAudioData();
			}
			Action action = delegate
			{
				Board board3 = this.board;
				int num7 = board3.theWave;
				if (board3 < 0)
				{
					num7++;
				}
				if (num7 != 0)
				{
					if (this.hellMode && this.stage == 1)
					{
						int theWave = this.board.theWave;
						if (theWave == 10 || theWave == 50 || theWave == 90)
						{
							int num8 = 0;
							this.ShowBuff();
							float lucky = this._lucky;
							num8 += num8;
							this.Lucky = lucky;
							return;
						}
					}
					return;
				}
				this.ShowBuff();
			};
			int num = 0;
			EventManager.AddListener(GameEvent.BoardWaveAdd, action, num != 0);
			Action action2 = new Action(this.SummonBoss);
			int num2 = 0;
			EventManager.AddListener((GameEvent)((uint)3), action2, num2 != 0);
			int num3 = 0;
			Action<object> action3;
			EventManager.AddListener_obj((GameEvent)((uint)2), action3, num3 != 0);
			Action action4 = delegate
			{
				GameAPP.config.shootingData.OnBoardWin(this);
			};
			int num4 = 0;
			EventManager.AddListener((GameEvent)((uint)19), action4, num4 != 0);
			float num5 = this.shieldHealth;
			this.shieldHealth = num5;
			this.UpdateZombieData();
			if (this.scene1 != SceneType.Day)
			{
				Board board = this.board;
				SceneType sceneType = this.scene1;
				board.sceneType = sceneType;
				Board board2 = this.board;
				int num6 = (int)this.scene1;
				GameObject gameObject;
				board2.ChangeMap(gameObject);
			}
		}

		// Token: 0x06004325 RID: 17189 RVA: 0x0015D658 File Offset: 0x0015B858
		[Token(Token = "0x6004325")]
		[Address(RVA = "0x896DA0", Offset = "0x8953A0", VA = "0x180896DA0")]
		public void RandomSettings()
		{
			List<RandomZombieType> list = Enumerable.ToList<RandomZombieType>(global::Core.Lawnf.GetEnumValues<RandomZombieType>());
			bool flag = list.Remove((uint)4);
			ShootingManager.randomType = ListExtensions.GetRandom<RandomZombieType>(list);
			this.scene2 = (SceneType)((uint)42);
			if (global::UnityEngine.Random.Range(0, 2) == 0)
			{
				this.scene3 = (SceneType)((ulong)43L);
			}
			if (global::UnityEngine.Random.Range(0, 2) == 0)
			{
				this.scene1 = (SceneType)((ulong)31L);
			}
			bool flag2;
			if (this.scene2 == SceneType.Night)
			{
				flag2 = GameAPP.soundManager.musics[(uint)17].LoadAudioData();
				return;
			}
			while (!flag2)
			{
			}
			Dictionary<MusicType, AudioClip> musics = GameAPP.soundManager.musics;
			throw new NullReferenceException();
		}

		// Token: 0x06004326 RID: 17190 RVA: 0x0015D6EC File Offset: 0x0015B8EC
		[Token(Token = "0x6004326")]
		[Address(RVA = "0x893830", Offset = "0x891E30", VA = "0x180893830")]
		private void EnterNextRound(object obj)
		{
			this.UpdateZombieData();
			if (this.endless)
			{
				int num = this.stage;
				InGameUI instance = InGameUI.Instance;
				string text = string.Format("诸神进化：无尽，第{0}轮", num);
				instance.SetLevelName(text);
			}
		}

		// Token: 0x06004327 RID: 17191 RVA: 0x0015D730 File Offset: 0x0015B930
		[Token(Token = "0x6004327")]
		[Address(RVA = "0x893150", Offset = "0x891750", VA = "0x180893150")]
		public void BossSpawn(ZombieBoss boss)
		{
			int num = 0;
			List<ZombieType> list = this.zombieTypes3;
			ZombieType random = ListExtensions.GetRandom<ZombieType>(Enumerable.ToList<ZombieType>(Enumerable.Concat<ZombieType>(this.zombieTypes2, list)));
			Board board = this.board;
			if (num < board.rowNum)
			{
				CreateZombie instance = CreateZombie.Instance;
				int num2 = 0;
				Zombie zombie;
				if (zombie != num2 && global::Lawnf.TravelDebuff((TravelDebuff)((uint)10033)))
				{
					global::Lawnf.SetZombieHealth(zombie, 1.6f);
				}
				num++;
			}
			num++;
			int num3 = 0;
			if (!(boss == num3))
			{
				if (boss != 0)
				{
				}
				CreateZombie instance2 = CreateZombie.Instance;
				List<ZombieType> list2 = this.zombieTypes3;
				ZombieType random2 = ListExtensions.GetRandom<ZombieType>(Enumerable.ToList<ZombieType>(Enumerable.Concat<ZombieType>(this.zombieTypes2, list2)));
				Transform spawnPosition = boss.spawnPosition;
				int num4 = 0;
				Zombie zombie2;
				if (zombie2 != num4 && global::Lawnf.TravelDebuff((TravelDebuff)((uint)10033)))
				{
					global::Lawnf.SetZombieHealth(zombie2, 1.6f);
				}
			}
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x0015D818 File Offset: 0x0015BA18
		[Token(Token = "0x6004328")]
		[Address(RVA = "0x89AC80", Offset = "0x899280", VA = "0x18089AC80")]
		private void SummonBoss()
		{
			Board board = this.board;
			int theMaxWave = board.theMaxWave;
			if (board.theWave == theMaxWave && this.maxStage != 0)
			{
				SceneType sceneType = board.sceneType;
				if (sceneType > SceneType.Night)
				{
					if (sceneType == SceneType.NormalBeach)
					{
						CreateZombie instance = CreateZombie.Instance;
						int num = 0;
						Zombie zombie;
						if (zombie != 0)
						{
						}
						global::Lawnf.SetZombieHealth(num, 100f);
					}
					uint num2;
					if (num2 != (uint)0)
					{
						if (num2 != (uint)0)
						{
							if (sceneType != SceneType.Night)
							{
								return;
							}
							CreateZombie instance2 = CreateZombie.Instance;
							int num3 = 0;
							Zombie zombie2;
							if (zombie2 != 0)
							{
							}
							global::Lawnf.SetZombieHealth(num3, 50f);
							GameAPP instance3 = GameAPP.Instance;
						}
						CreateZombie instance4 = CreateZombie.Instance;
						Zombie zombie3;
						global::Lawnf.SetZombieHealth(zombie3, 70f);
						GameAPP instance5 = GameAPP.Instance;
						this.AsBoss(zombie3);
					}
					CreateZombie instance6 = CreateZombie.Instance;
					Zombie zombie4;
					while (zombie4 == 0)
					{
					}
				}
				GameAPP instance7;
				if (sceneType != SceneType.Day)
				{
					while (instance7 != (ulong)1L)
					{
					}
					CreateZombie instance8 = CreateZombie.Instance;
					Zombie zombie5;
					if (zombie5 != 0)
					{
					}
					global::Lawnf.SetZombieHealth(zombie5, 50f);
					GameAPP instance9 = GameAPP.Instance;
					throw new NullReferenceException();
				}
				CreateZombie instance10 = CreateZombie.Instance;
				Zombie zombie6;
				if (zombie6 != 0)
				{
				}
				global::Lawnf.SetZombieHealth(zombie6, 100f);
				List<ZombieType> list = new List(this.zombieTypes1);
				this.AsBoss(zombie6);
				instance7 = GameAPP.Instance;
			}
		}

		// Token: 0x06004329 RID: 17193 RVA: 0x0015D94C File Offset: 0x0015BB4C
		[Token(Token = "0x6004329")]
		[Address(RVA = "0x896080", Offset = "0x894680", VA = "0x180896080")]
		private void HorseBoss()
		{
			CreateZombie instance = CreateZombie.Instance;
			int num = 0;
			if (instance.SetZombie(2, (ZombieType)((uint)231), 9.9f, num != 0) != 0)
			{
			}
			global::Lawnf.SetZombieHealth(num, 100f);
			List<ZombieType> list = new List(this.zombieTypes1);
			this.AsBoss(num);
			GameAPP.Instance.PlayMusic((MusicType)((uint)26));
		}

		// Token: 0x0600432A RID: 17194 RVA: 0x0015D9AC File Offset: 0x0015BBAC
		[Token(Token = "0x600432A")]
		[Address(RVA = "0x8938F0", Offset = "0x891EF0", VA = "0x1808938F0")]
		private void FootballBoss()
		{
			CreateZombie instance = CreateZombie.Instance;
			int num = 0;
			if (instance.SetZombie(2, (ZombieType)((uint)260), 9.9f, num != 0) != 0)
			{
			}
			global::Lawnf.SetZombieHealth(num, 100f);
			this.AsBoss(num);
			GameAPP.Instance.PlayMusic((MusicType)((uint)26));
		}

		// Token: 0x0600432B RID: 17195 RVA: 0x0015DA00 File Offset: 0x0015BC00
		[Token(Token = "0x600432B")]
		[Address(RVA = "0x89D030", Offset = "0x89B630", VA = "0x18089D030")]
		private void ZombieBoss()
		{
			CreateZombie instance = CreateZombie.Instance;
			int num = 0;
			int num2 = 0;
			if (instance.SetZombie(num2, (ZombieType)((uint)44), 9.9f, num != 0) != 0)
			{
			}
			global::Lawnf.SetZombieHealth(num, 50f);
			GameAPP.Instance.PlayMusic((MusicType)((uint)17));
			this.AsBoss(num);
		}

		// Token: 0x0600432C RID: 17196 RVA: 0x0015DA50 File Offset: 0x0015BC50
		[Token(Token = "0x600432C")]
		[Address(RVA = "0x89CEF0", Offset = "0x89B4F0", VA = "0x18089CEF0")]
		private void ZombieBoss2()
		{
			CreateZombie instance = CreateZombie.Instance;
			int num = 0;
			int num2 = 0;
			if (instance.SetZombie(num2, (ZombieType)((uint)46), 9.9f, num != 0) != 0)
			{
			}
			global::Lawnf.SetZombieHealth(num, 50f);
			GameAPP.Instance.PlayMusic((MusicType)((uint)18));
			this.AsBoss(num);
		}

		// Token: 0x0600432D RID: 17197 RVA: 0x0015DAA0 File Offset: 0x0015BCA0
		[Token(Token = "0x600432D")]
		[Address(RVA = "0x89A250", Offset = "0x898850", VA = "0x18089A250")]
		private void SnowBoss()
		{
			ulong num;
			Zombie zombie = CreateZombie.Instance.SetZombie(2, (ZombieType)((uint)228), 9.9f, num != 0UL);
			global::Lawnf.SetZombieHealth(zombie, 70f);
			GameAPP.Instance.PlayMusic((MusicType)((uint)21));
			this.AsBoss(zombie);
		}

		// Token: 0x0600432E RID: 17198 RVA: 0x0015DAEC File Offset: 0x0015BCEC
		[Token(Token = "0x600432E")]
		[Address(RVA = "0x896240", Offset = "0x894840", VA = "0x180896240")]
		private void JacksonDriverBoss()
		{
			CreateZombie instance = CreateZombie.Instance;
			int num = 0;
			if (instance.SetZombie(2, (ZombieType)((uint)261), 9.9f, num != 0) != 0)
			{
			}
			global::Lawnf.SetZombieHealth(num, 50f);
			GameAPP.Instance.PlayMusic((MusicType)((uint)18));
			this.AsBoss(num);
		}

		// Token: 0x0600432F RID: 17199 RVA: 0x0015DB40 File Offset: 0x0015BD40
		[Token(Token = "0x600432F")]
		[Address(RVA = "0x895E80", Offset = "0x894480", VA = "0x180895E80")]
		private void GoNewScene()
		{
			RogueShootingData shootingData = GameAPP.config.shootingData;
			int num = GameAPP.config.shootingData.maxStage;
			int num2 = this.stage;
			if (num <= num2)
			{
				num = num2;
			}
			shootingData.maxStage = num;
			BlackMask instance = BlackMask.Instance;
			if (this.stage == 2)
			{
				Action action = delegate
				{
					SceneType sceneType = this.scene3;
					GameAPP instance2 = GameAPP.Instance;
					Board board = this.board;
					SceneType sceneType2 = this.scene3;
					board.sceneType = sceneType2;
					Board board2 = this.board;
					int num5 = (int)this.scene3;
					GameObject gameObject;
					board2.ChangeMap(gameObject);
				};
			}
			Action action2 = delegate
			{
				SceneType sceneType3 = this.scene3;
				GameAPP instance3 = GameAPP.Instance;
				Board board3 = this.board;
				SceneType sceneType4 = this.scene3;
				board3.sceneType = sceneType4;
				Board board4 = this.board;
				int num6 = (int)this.scene3;
				GameObject gameObject2;
				board4.ChangeMap(gameObject2);
			};
			instance.Active(action2);
			if (this.endless)
			{
				int num3 = 0;
				int num4 = 0;
				InitZombieList.InitZombie((LevelType)((uint)1), 140, (SceneType)num4, num3);
			}
		}

		// Token: 0x06004330 RID: 17200 RVA: 0x0015DBD8 File Offset: 0x0015BDD8
		[Token(Token = "0x6004330")]
		[Address(RVA = "0x892EE0", Offset = "0x8914E0", VA = "0x180892EE0")]
		public void AsBoss(Zombie zombie)
		{
			if (global::Lawnf.TravelDebuff((TravelDebuff)((uint)10033)))
			{
				global::Lawnf.SetZombieHealth(zombie, 1.3f);
			}
			int num = this.maxStage;
			if (this.stage != num)
			{
				Action<Zombie> action;
				Delegate @delegate = Delegate.Combine(zombie.onDeath, action);
				if (@delegate == 0)
				{
					zombie.onDeath = @delegate;
				}
				if (@delegate != 0)
				{
					zombie.onDeath = @delegate;
					if (@delegate != 0)
					{
						return;
					}
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x06004331 RID: 17201 RVA: 0x0015DC44 File Offset: 0x0015BE44
		[Token(Token = "0x6004331")]
		[Address(RVA = "0x893CF0", Offset = "0x8922F0", VA = "0x180893CF0")]
		public int GetPlantBuffsCount(PlantType plantType)
		{
			Dictionary<PlantType, Dictionary<string, int>> dictionary = this.plantBuffRecords;
			bool flag;
			if (!flag)
			{
				return 0;
			}
			if (ShootingManager.<>c.<>9__73_0 == 0)
			{
				Func<KeyValuePair<string, int>, int> func;
				ShootingManager.<>c.<>9__73_0 = func;
			}
			int num;
			return num;
		}

		// Token: 0x06004332 RID: 17202 RVA: 0x0015DC78 File Offset: 0x0015BE78
		[Token(Token = "0x6004332")]
		[Address(RVA = "0x89C3D0", Offset = "0x89A9D0", VA = "0x18089C3D0")]
		public void UpdateZombieData()
		{
			Board board = this.board;
			BoardConfig config = board.config;
			float num = this.healthMultiplier3 * this.BaseHealthMulitpier;
			config.zombieHealthMultiplier = num;
			BoardConfig config2 = this.board.config;
			float num2 = this.damageMultiplier3 * this.BaseDamageMultiplier;
			config2.zombieDamageMultiplier = num2;
			BoardConfig config3 = this.board.config;
			float num3 = this.speedMultiplier3 * this.BaseSpeedMultiplier;
			config3.zombieSpeedMultiplier = num3;
		}

		// Token: 0x06004333 RID: 17203 RVA: 0x0015DDCC File Offset: 0x0015BFCC
		[Token(Token = "0x6004333")]
		[Address(RVA = "0x8934F0", Offset = "0x891AF0", VA = "0x1808934F0")]
		public void CheatHard()
		{
			if (!this.cheatHard)
			{
				this.cheatHard = true;
				List<TextMeshProUGUI> levelNameText = InGameUI.Instance.levelNameText;
				Action<TextMeshProUGUI> <>9__75_ = ShootingManager.<>c.<>9__75_0;
				if (<>9__75_ == 0)
				{
					Action<TextMeshProUGUI> action;
					ShootingManager.<>c.<>9__75_0 = action;
				}
				levelNameText.ForEach(<>9__75_);
				Action action2 = delegate
				{
					BoardConfig config = this.board.config;
					int num2 = this.stage;
					int num3 = num2 * num2;
					int theWave = this.board.theWave;
					uint num4;
					num4 += num4;
					if (theWave == (int)num4)
					{
						List<ZombieType> list = new List(this.leaders);
						Board board = this.board;
						CreateZombie instance = CreateZombie.Instance;
						int rowNum = board.rowNum;
						int num5 = global::UnityEngine.Random.Range(0, rowNum);
						ZombieType random = ListExtensions.GetRandom<ZombieType>(list);
					}
				};
				int num = 0;
				EventManager.AddListener(GameEvent.BoardWaveAdd, action2, num != 0);
			}
		}

		// Token: 0x06004334 RID: 17204 RVA: 0x0015DE30 File Offset: 0x0015C030
		[Token(Token = "0x6004334")]
		[Address(RVA = "0x896D90", Offset = "0x895390", VA = "0x180896D90")]
		public void QuickShowBuff()
		{
			this.ShowBuff();
		}

		// Token: 0x06004335 RID: 17205 RVA: 0x0015DE44 File Offset: 0x0015C044
		[Token(Token = "0x6004335")]
		[Address(RVA = "0x894130", Offset = "0x892730", VA = "0x180894130")]
		public Quality GetRandomQuality(bool checkInGuaranteedMinimum = true, bool canIridescent = false)
		{
			int num;
			for (;;)
			{
				num = 0;
				int i = 0;
				if (checkInGuaranteedMinimum)
				{
					if ((this.superUpgrade ? 1 : 0) == num)
					{
						if ((this.pityEnabled ? 1 : 0) != num)
						{
							break;
						}
					}
					else
					{
						this.noDiamondCount = num;
					}
				}
				float num2 = Enumerable.Sum(this.qualityWeights.Values);
				float value = global::UnityEngine.Random.value;
				Dictionary<Quality, float> dictionary = this.qualityWeights;
				bool flag;
				if (flag)
				{
					while (i <= (int)value)
					{
					}
				}
				if (num == 0)
				{
					goto Block_3;
				}
			}
			float num3 = this._lucky * 0.3f;
			this.noDiamondCount = num;
			InGameText instance = InGameText.Instance;
			int num4 = this.pityThreshold;
			string text = string.Format("出保底了，当前保底阈值：{0}", instance);
			GameAPP.PlaySound((SoundType)((uint)125), 0.5f, 1f);
			return Quality.diamond;
			Block_3:
			int num5 = 0;
			if (num != 3)
			{
				int num6 = this.noDiamondCount;
				num6++;
			}
			this.noDiamondCount = num5;
			if (global::Lawnf.TravelDebuff((TravelDebuff)((uint)10038)))
			{
			}
			if ((!global::Lawnf.TravelDebuff((TravelDebuff)((uint)10040)) && (!global::Lawnf.TravelDebuff((TravelDebuff)((uint)10038)) || (ulong)((uint)2) != (ulong)3L)) || !global::Lawnf.TravelDebuff((TravelDebuff)((uint)10038)) || (ulong)((uint)2) == (ulong)3L || (ulong)((uint)2) == (ulong)2L)
			{
			}
			bool flag2 = global::Lawnf.TravelAdvanced((AdvBuff)((uint)13101));
			if ((ulong)((uint)1) <= (ulong)2L)
			{
			}
			throw new NullReferenceException();
		}

		// Token: 0x06004336 RID: 17206 RVA: 0x0015DF80 File Offset: 0x0015C180
		[Token(Token = "0x6004336")]
		[Address(RVA = "0x893E60", Offset = "0x892460", VA = "0x180893E60")]
		public float GetQualityValue(float baseValue, Quality quality)
		{
			if (this.superUpgrade && quality == Quality.diamond)
			{
				return baseValue * 25f;
			}
			bool flag2;
			float num2;
			if (quality > Quality.silver)
			{
				bool flag;
				float num;
				if (flag)
				{
					num = baseValue * 1.1f;
				}
				if (!flag2)
				{
					goto IL_0053;
				}
				num2 = num * 0.7f;
			}
			float num3;
			if (flag2)
			{
				num3 = num2 * 0.7f;
			}
			bool flag3;
			float num4;
			if (flag3)
			{
				num4 = num3 * 1.1f;
			}
			IL_0053:
			if (quality <= Quality.iridescent)
			{
				return num4;
			}
			flag3.m_value = flag3;
			return 0f;
		}

		// Token: 0x06004337 RID: 17207 RVA: 0x0015E004 File Offset: 0x0015C204
		[Token(Token = "0x6004337")]
		[Address(RVA = "0x893F90", Offset = "0x892590", VA = "0x180893F90")]
		public int GetQualityValue(int baseValue, Quality quality)
		{
			if (this.superUpgrade && quality == Quality.diamond)
			{
				long num = (long)(baseValue * (int)((uint)25));
			}
			bool flag2;
			if (quality > Quality.silver)
			{
				bool flag;
				if (flag)
				{
					int num2 = baseValue.Multiply(1.25f);
				}
				if (!flag2)
				{
					goto IL_0053;
				}
			}
			if (flag2)
			{
				int num3 = baseValue.Multiply(0.85f);
			}
			bool flag3;
			if (flag3)
			{
				int num4 = baseValue.Multiply(1.05f);
			}
			IL_0053:
			if (quality == Quality.Default)
			{
				return baseValue;
			}
			int num5;
			if (quality == Quality.Default)
			{
				return num5;
			}
			if (quality == Quality.Default)
			{
				return num5;
			}
			if (quality != Quality.silver)
			{
				num5 = 0;
				return num5;
			}
			return num5;
		}

		// Token: 0x06004338 RID: 17208 RVA: 0x0015E088 File Offset: 0x0015C288
		[Token(Token = "0x6004338")]
		[Address(RVA = "0x89B3E0", Offset = "0x8999E0", VA = "0x18089B3E0")]
		public bool TryGetPlant(PlantType thePlantType, [Out] Plant plant)
		{
			List<Plant> plantHead = Board.Instance.boardEntity.plantHead;
			Func<Plant, bool> func = delegate(Plant p)
			{
				PlantType thePlantType2 = thePlantType;
				return p.thePlantType == thePlantType2;
			};
			Plant plant2 = Enumerable.FirstOrDefault<Plant>(plantHead, func);
			bool flag;
			return flag;
		}

		// Token: 0x06004339 RID: 17209 RVA: 0x0015E0DC File Offset: 0x0015C2DC
		[Token(Token = "0x6004339")]
		[Address(RVA = "0x893B50", Offset = "0x892150", VA = "0x180893B50")]
		public void GetNewPlant(PlantType thePlantType)
		{
			CreatePlant instance = CreatePlant.Instance;
			List<PlantType> yourPlants = this.YourPlants;
			int size = yourPlants._size;
			Plant plant;
			HealthSlider healthSlider = plant.snakePre.healthSlider;
			int num = (int)(thePlantType + 1);
			yourPlants._size = num;
			healthSlider.fillObject = thePlantType;
			List<PlantType> restPlants = this.RestPlants;
			List<PlantType> currentPlants = this.CurrentPlants;
			int size2 = currentPlants._size;
		}

		// Token: 0x0600433A RID: 17210 RVA: 0x0015E164 File Offset: 0x0015C364
		[Token(Token = "0x600433A")]
		[Address(RVA = "0x89C9C0", Offset = "0x89AFC0", VA = "0x18089C9C0")]
		public void UpgradePlant(PlantType from, PlantType to)
		{
			int num3;
			do
			{
				this.upgrading = true;
				List<Plant> allPlants = global::Lawnf.GetAllPlants();
				int num = 0;
				bool flag;
				if (flag)
				{
					CreatePlant instance = CreatePlant.Instance;
				}
				if (num != 0)
				{
					goto IL_0064;
				}
				int num2 = 0;
				List<PlantType> list = new List();
				bool flag2;
				if (flag2)
				{
				}
				if (num2 != 0)
				{
					goto IL_006A;
				}
				num3 = 0;
				bool flag3;
				if (flag3)
				{
				}
			}
			while (num3 != 0);
			return;
			IL_0064:
			throw new NullReferenceException();
			IL_006A:
			throw new NullReferenceException();
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x0015E1E4 File Offset: 0x0015C3E4
		[Token(Token = "0x600433B")]
		[Address(RVA = "0x8965B0", Offset = "0x894BB0", VA = "0x1808965B0")]
		public void LosePlant(Plant plant)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x0015E204 File Offset: 0x0015C404
		[Token(Token = "0x600433C")]
		[Address(RVA = "0x899590", Offset = "0x897B90", VA = "0x180899590")]
		public void ReinforcePlant(Plant plant)
		{
			Dictionary<PlantType, Action<Plant>> dictionary = this.reinforceActions;
			bool flag;
			ulong num;
			if (!flag || num != (ulong)0L)
			{
			}
			float num2 = this.shieldHealth;
			int num3 = 0;
			if (num2 > (float)num3)
			{
				plant.GetShield(num2);
			}
			bool flag2 = this.uncrashable;
			plant.uncrashable = flag2;
		}

		// Token: 0x0600433D RID: 17213 RVA: 0x0015E250 File Offset: 0x0015C450
		[Token(Token = "0x600433D")]
		[Address(RVA = "0x896FD0", Offset = "0x8955D0", VA = "0x180896FD0")]
		public void RecordBuffChoice(PlantType plantType, string buffTitle)
		{
			if (!string.IsNullOrEmpty(buffTitle))
			{
				Dictionary<PlantType, Dictionary<string, int>> dictionary = this.plantBuffRecords;
				bool flag;
				if (!flag)
				{
					Dictionary<PlantType, Dictionary<string, int>> dictionary2 = this.plantBuffRecords;
					Dictionary<string, int> dictionary3 = new Dictionary();
				}
				Dictionary<PlantType, Dictionary<string, int>> dictionary4 = this.plantBuffRecords;
				Dictionary<string, int> dictionary5;
				if (!dictionary5.ContainsKey(buffTitle))
				{
					Dictionary<PlantType, Dictionary<string, int>> dictionary6 = this.plantBuffRecords;
					int num = 0;
					Dictionary<string, int> dictionary7;
					dictionary7[buffTitle] = num;
				}
				Dictionary<PlantType, Dictionary<string, int>> dictionary8 = this.plantBuffRecords;
				Dictionary<string, int> dictionary9;
				int num2 = dictionary9[buffTitle];
				int num3 = num2 + 1;
				dictionary9[buffTitle] = num3;
				Dictionary<PlantType, Dictionary<string, int>> dictionary10 = this.plantBuffRecords;
				Dictionary<string, int> dictionary11;
				int num4 = dictionary11[buffTitle];
				Debug.Log(string.Format("[BuffRecord] {0} 选择了词条 {1}，累计 {2} 次", num2, buffTitle, num4));
			}
		}

		// Token: 0x0600433E RID: 17214 RVA: 0x0015E2FC File Offset: 0x0015C4FC
		[Token(Token = "0x600433E")]
		[Address(RVA = "0x893A40", Offset = "0x892040", VA = "0x180893A40")]
		public int GetBuffChoiceCount(PlantType plantType, string buffTitle)
		{
			Dictionary<PlantType, Dictionary<string, int>> dictionary = this.plantBuffRecords;
			bool flag;
			if (flag)
			{
				Dictionary<PlantType, Dictionary<string, int>> dictionary2 = this.plantBuffRecords;
				Dictionary<string, int> dictionary3;
				if (dictionary3.ContainsKey(buffTitle))
				{
					Dictionary<PlantType, Dictionary<string, int>> dictionary4 = this.plantBuffRecords;
					Dictionary<string, int> dictionary5;
					return dictionary5[buffTitle];
				}
			}
			return 0;
		}

		// Token: 0x0600433F RID: 17215 RVA: 0x0015E340 File Offset: 0x0015C540
		[Token(Token = "0x600433F")]
		[Address(RVA = "0x899650", Offset = "0x897C50", VA = "0x180899650")]
		private void ShowBuff()
		{
			int num = 0;
			bool flag;
			if (flag)
			{
				uint num3;
				uint num4;
				int num2 = global::UnityEngine.Random.Range((int)num3, (int)num4);
				InGameText instance = InGameText.Instance;
				string text = string.Format("命运无常：获得了{0}幸运", instance);
				uint num5;
				instance.DelayShow(text, 3f, (int)num5);
				float num6;
				this.Lucky = num6;
			}
			UIResourcesLoader uimanager = GameAPP.UIManager;
			MultipleChoiceMenu menu;
			BaseMenu baseMenu;
			if (baseMenu == 0)
			{
				menu = num;
			}
			menu = baseMenu;
			MultipleChoiceMenu menu12 = menu;
			this.RegisterCoreBuff(menu12);
			MultipleChoiceMenu menu2 = menu;
			this.RegisterOtherBuff(menu2);
			if ((this.hellMode ? 1 : 0) != num)
			{
				MultipleChoiceMenu menu3 = menu;
				this.RefisterMissionBuff(menu3);
			}
			MultipleChoiceMenu menu4 = menu;
			this.RegisterExpertBuff(menu4);
			if (this.maxPlantCount > 0)
			{
				MultipleChoiceMenu menu5 = menu;
				ShootingManager.<>c__DisplayClass95_0 CS$<>8__locals2 = new ShootingManager.<>c__DisplayClass95_0();
				CS$<>8__locals2.baseMenu = menu5;
				CS$<>8__locals2.<>4__this = this;
				MultipleChoiceMenu baseMenu2 = CS$<>8__locals2.baseMenu;
				UnityAction unityAction = delegate
				{
					ShootingManager.<>c__DisplayClass95_1 CS$<>8__locals3 = new ShootingManager.<>c__DisplayClass95_1();
					CS$<>8__locals3.CS$<>8__locals1 = CS$<>8__locals2;
					CS$<>8__locals3.unlocked = false;
					MultipleChoiceMenu baseMenu3 = CS$<>8__locals2.baseMenu;
					Action actionOnExit = baseMenu3.actionOnExit;
					Action action3 = delegate
					{
						int num16 = 0;
						int num17 = 0;
						UIResourcesLoader uimanager2 = GameAPP.UIManager;
						int num18 = 0;
						if (uimanager2.Push((UIType)((uint)81), num18 != 0) == 0)
						{
						}
						List<PlantType> restPlants = CS$<>8__locals3.CS$<>8__locals1.<>4__this.RestPlants;
						bool flag4;
						if (flag4)
						{
							ShootingManager.<>c__DisplayClass95_2 CS$<>8__locals4;
							CS$<>8__locals4.CS$<>8__locals2 = CS$<>8__locals3;
							CS$<>8__locals4.plant = (PlantType)num16;
							RogueShootingData shootingData = GameAPP.config.shootingData;
							RogueShootingData shootingData2 = GameAPP.config.shootingData;
							PlantType plant = CS$<>8__locals4.plant;
							List<DataRecord<PlantType>> plant2 = shootingData2.plant;
							int value = shootingData.GetValue<PlantType>(plant2, plant);
							RogueShootingData data = ShootingManager.Data;
							RogueShootingData data2 = ShootingManager.Data;
							PlantType plant3 = CS$<>8__locals4.plant;
							List<DataRecord<PlantType>> plant4 = data2.plant;
							int value2 = data.GetValue<PlantType>(plant4, plant3);
							string text2 = string.Format("获得新植物\n\n已使用该植物通关了{0}次", value2);
							Dictionary<PlantType, BaseConfig> configs = Config.configs;
							PlantType plant5 = CS$<>8__locals4.plant;
							if (configs.TryGetValue(plant5, num17))
							{
							}
							string name = global::Lawnf.GetName(CS$<>8__locals4.plant);
							UnityAction unityAction2 = delegate
							{
								CS$<>8__locals4.CS$<>8__locals2.unlocked = true;
								ShootingManager <>4__this = CS$<>8__locals4.CS$<>8__locals2.CS$<>8__locals1.<>4__this;
								PlantType plant7 = CS$<>8__locals4.plant;
								<>4__this.GetNewPlant(plant7);
							};
							PlantType plant6 = CS$<>8__locals4.plant;
						}
						if (num17 == 0)
						{
							int num19;
							if (num19 == 0)
							{
							}
							Delegate delegate4;
							if (delegate4 == 0)
							{
							}
							if (delegate4 != 0 && delegate4 != 0)
							{
								return;
							}
						}
						throw new InvalidCastException();
					};
					Delegate delegate3 = Delegate.Combine(actionOnExit, action3);
					int num15 = 0;
					if (delegate3 == 0)
					{
						baseMenu3.actionOnExit = num15;
					}
					if (delegate3 != 0)
					{
						baseMenu3.actionOnExit = delegate3;
						if (delegate3 != 0)
						{
							throw new NullReferenceException();
						}
					}
					throw new InvalidCastException();
				};
			}
			if (menu.OptionCount == 0)
			{
				MultipleChoiceMenu menu6 = menu;
			}
			MultipleChoiceMenu menu7 = menu;
			uint num8;
			int num7 = Mathf.Min(menu7.OptionCount, (int)num8);
			menu7.RegisterWindow(num7);
			MultipleChoiceMenu menu8 = menu;
			int num9 = 0;
			ulong num10;
			menu8.SetCancelable(num9 != 0, num10 != 0UL);
			MultipleChoiceMenu menu9 = menu;
			int num11 = this.refreshCount;
			bool flag2 = this.refreshCount > num;
			int num12 = 0;
			ulong num13;
			ulong num14;
			menu9.SetRefreshable(num13 != 0UL, num11, num12 != 0, flag2, num14 != 0UL);
			menu.<KeySelect>k__BackingField = true;
			MultipleChoiceMenu menu10 = menu;
			Action actionOnRefresh = menu10.actionOnRefresh;
			Action action = delegate
			{
				ShootingManager <>4__this2 = this;
				ShootingManager <>4__this3 = this;
				int num20 = <>4__this2.refreshCount;
				<>4__this3.refreshCount = num20;
				menu.PopMenu();
				this.ShowBuff();
			};
			Delegate @delegate = Delegate.Combine(actionOnRefresh, action);
			if (@delegate == 0)
			{
				menu10.actionOnRefresh = num;
			}
			if (@delegate != 0)
			{
				menu10.actionOnRefresh = @delegate;
				if (@delegate != 0)
				{
					bool flag3;
					if (flag3)
					{
						MultipleChoiceMenu menu11 = menu;
						Action actionOnRefresh2 = menu11.actionOnRefresh;
						Action action2 = delegate
						{
							ShootingManager <>4__this4 = this;
							float lucky = <>4__this4._lucky;
							<>4__this4.Lucky = lucky;
						};
						Delegate delegate2 = Delegate.Combine(actionOnRefresh2, action2);
						if (delegate2 == 0)
						{
							menu11.actionOnRefresh = num;
						}
						if (delegate2 == 0)
						{
							goto IL_021B;
						}
						menu11.actionOnRefresh = delegate2;
						if (delegate2 == 0)
						{
							goto IL_021B;
						}
					}
					return;
				}
			}
			IL_021B:
			throw new InvalidCastException();
		}

		// Token: 0x06004340 RID: 17216 RVA: 0x0015E570 File Offset: 0x0015C770
		[Token(Token = "0x6004340")]
		[Address(RVA = "0x8977B0", Offset = "0x895DB0", VA = "0x1808977B0")]
		private void RegisterCoreBuff(MultipleChoiceMenu menu)
		{
			ulong num4;
			do
			{
				int num = 0;
				List<PlantType> currentPlants = this.CurrentPlants;
				bool flag;
				if (flag)
				{
					if (!Config.configs.TryGetValue(num, num))
					{
						continue;
					}
					if (this.board.damageReporter == 0)
					{
					}
					long damage = this.board.damageReporter.GetDamage((PlantType)num);
					int plantBuffsCount = this.GetPlantBuffsCount((PlantType)num);
					TypeCode typeCode = num.GetTypeCode();
					bool flag2;
					if (flag2)
					{
						ShootingManager.<>c__DisplayClass94_0 CS$<>8__locals1;
						CS$<>8__locals1.<>4__this = this;
						TypeCode typeCode2 = num.GetTypeCode();
						int i;
						sbyte b;
						while (i >= (int)b)
						{
						}
						TypeCode typeCode3 = num.GetTypeCode();
						bool flag3;
						if (flag3 && this.plantBuffRecords.TryGetValue(num, num))
						{
							Func<KeyValuePair<string, int>, bool> func;
							if (ShootingManager.<>c.<>9__94_0 == 0)
							{
								func = delegate(KeyValuePair<string, int> a)
								{
									bool flag6;
									return flag6;
								};
								ShootingManager.<>c.<>9__94_0 = func;
							}
							if (Enumerable.Any<KeyValuePair<string, int>>(num, func))
							{
								continue;
							}
						}
						float value = global::UnityEngine.Random.value;
						CS$<>8__locals1.capturedPlant = (PlantType)num;
						TypeCode typeCode4 = num.GetTypeCode();
						CS$<>8__locals1.capturedBuffTitle = typeCode4;
						UnityAction unityAction;
						CS$<>8__locals1.originalOnGet = unityAction;
						if (i > 0)
						{
							bool flag4;
							string text = string.Format("{0}\n已选了{1}次", flag4, flag4);
						}
						Dictionary<PlantType, BaseConfig> configs = Config.configs;
						bool flag5;
						if (flag5)
						{
							float num2;
							string text2 = string.Format("\n\n伤害占比：{0:F2}%\n总词条数：{1}", num2, num2);
							string text4;
							string text3 = text4 + text2;
						}
						TypeCode typeCode5 = num.GetTypeCode();
						UnityAction unityAction2 = new UnityAction(CS$<>8__locals1.<RegisterCoreBuff>g__wrappedOnGet|1);
					}
					ulong num3;
					if (num3 != (ulong)0L)
					{
						goto IL_017C;
					}
				}
			}
			while (num4 != (ulong)0L);
			return;
			IL_017C:
			throw new NullReferenceException();
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x0015E718 File Offset: 0x0015C918
		[Token(Token = "0x6004341")]
		[Address(RVA = "0x8983D0", Offset = "0x8969D0", VA = "0x1808983D0")]
		private void RegisterGetPlantBuff(MultipleChoiceMenu baseMenu)
		{
			ShootingManager.<>c__DisplayClass95_0 CS$<>8__locals1 = new ShootingManager.<>c__DisplayClass95_0();
			CS$<>8__locals1.baseMenu = baseMenu;
			CS$<>8__locals1.<>4__this = this;
			MultipleChoiceMenu baseMenu2 = CS$<>8__locals1.baseMenu;
			UnityAction unityAction = delegate
			{
				ShootingManager.<>c__DisplayClass95_1 CS$<>8__locals2 = new ShootingManager.<>c__DisplayClass95_1();
				CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
				CS$<>8__locals2.unlocked = false;
				MultipleChoiceMenu baseMenu3 = CS$<>8__locals1.baseMenu;
				Action actionOnExit = baseMenu3.actionOnExit;
				Action action = delegate
				{
					int num2 = 0;
					int num3 = 0;
					UIResourcesLoader uimanager = GameAPP.UIManager;
					int num4 = 0;
					if (uimanager.Push((UIType)((uint)81), num4 != 0) == 0)
					{
					}
					List<PlantType> restPlants = CS$<>8__locals2.CS$<>8__locals1.<>4__this.RestPlants;
					bool flag;
					if (flag)
					{
						ShootingManager.<>c__DisplayClass95_2 CS$<>8__locals3;
						CS$<>8__locals3.CS$<>8__locals2 = CS$<>8__locals2;
						CS$<>8__locals3.plant = (PlantType)num2;
						RogueShootingData shootingData = GameAPP.config.shootingData;
						RogueShootingData shootingData2 = GameAPP.config.shootingData;
						PlantType plant = CS$<>8__locals3.plant;
						List<DataRecord<PlantType>> plant2 = shootingData2.plant;
						int value = shootingData.GetValue<PlantType>(plant2, plant);
						RogueShootingData data = ShootingManager.Data;
						RogueShootingData data2 = ShootingManager.Data;
						PlantType plant3 = CS$<>8__locals3.plant;
						List<DataRecord<PlantType>> plant4 = data2.plant;
						int value2 = data.GetValue<PlantType>(plant4, plant3);
						string text = string.Format("获得新植物\n\n已使用该植物通关了{0}次", value2);
						Dictionary<PlantType, BaseConfig> configs = Config.configs;
						PlantType plant5 = CS$<>8__locals3.plant;
						if (configs.TryGetValue(plant5, num3))
						{
						}
						string name = global::Lawnf.GetName(CS$<>8__locals3.plant);
						UnityAction unityAction2 = delegate
						{
							CS$<>8__locals3.CS$<>8__locals2.unlocked = true;
							ShootingManager <>4__this = CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.<>4__this;
							PlantType plant7 = CS$<>8__locals3.plant;
							<>4__this.GetNewPlant(plant7);
						};
						PlantType plant6 = CS$<>8__locals3.plant;
					}
					if (num3 == 0)
					{
						int num5;
						if (num5 == 0)
						{
						}
						Delegate delegate2;
						if (delegate2 == 0)
						{
						}
						if (delegate2 != 0 && delegate2 != 0)
						{
							return;
						}
					}
					throw new InvalidCastException();
				};
				Delegate @delegate = Delegate.Combine(actionOnExit, action);
				int num = 0;
				if (@delegate == 0)
				{
					baseMenu3.actionOnExit = num;
				}
				if (@delegate != 0)
				{
					baseMenu3.actionOnExit = @delegate;
					if (@delegate != 0)
					{
						throw new NullReferenceException();
					}
				}
				throw new InvalidCastException();
			};
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x0015E754 File Offset: 0x0015C954
		[Token(Token = "0x6004342")]
		[Address(RVA = "0x898500", Offset = "0x896B00", VA = "0x180898500")]
		private void RegisterOtherBuff(MultipleChoiceMenu menu)
		{
			float value12 = global::UnityEngine.Random.value;
			float lucky = this._lucky;
			int num = 0;
			if (lucky > value12 && this.maxLucky > this._lucky)
			{
				int num2 = 0;
				ulong num3;
				Quality randomQuality = this.GetRandomQuality(num3 != 0UL, num2 != 0);
				float num4;
				float value13 = num4;
				float lucky2 = this._lucky;
				string text = string.Format("{0:F0}", "{0:F0}");
				float num5 = this.maxLucky;
				string text2 = string.Format("幸运提高{0:F0}，幸运可以提高好词条出现概率\n当前幸运值：{1}/{2:F0}", randomQuality, text, text);
				UnityAction unityAction = delegate
				{
					ShootingManager <>4__this = this;
					float lucky3 = <>4__this._lucky;
					<>4__this.Lucky = lucky3;
				};
			}
			float value2 = global::UnityEngine.Random.value;
			string text3;
			UnityAction unityAction2;
			if (this._lucky > value2)
			{
				int num6 = 0;
				ulong num8;
				int num7 = (int)this.GetRandomQuality(num8 != 0UL, num6 != 0);
				float num9;
				float value = num9;
				TravelMgr instance = TravelMgr.Instance;
				float value3 = value;
				float damageAmplification = instance.damageAmplification;
				text3 = string.Format("全体植物获得{0:F0}%伤害增幅\n当前增幅：{1:F0}%", instance, instance);
				unityAction2 = delegate
				{
					TravelMgr instance2 = TravelMgr.Instance;
					float damageAmplification2 = instance2.damageAmplification;
					instance2.damageAmplification = damageAmplification2;
				};
			}
			float value4 = global::UnityEngine.Random.value;
			string text4;
			UnityAction unityAction3;
			if (this._lucky > value4)
			{
				int num10 = 0;
				ShootingManager.<>c__DisplayClass96_2 CS$<>8__locals3;
				CS$<>8__locals3.FieldGetter(num10, text3, unityAction2);
				CS$<>8__locals3.<>4__this = this;
				int num11 = 0;
				ulong num12;
				int randomQuality2 = (int)this.GetRandomQuality(num12 != 0UL, num11 != 0);
				int num13;
				int num7 = num13;
				uint num15;
				int num14 = Mathf.Max(num7, (int)num15);
				CS$<>8__locals3.value = num14;
				text4 = string.Format("获得{0}次词条刷新的机会", num14);
				unityAction3 = delegate
				{
					int num25 = CS$<>8__locals3.<>4__this.refreshCount;
					CS$<>8__locals3.<>4__this.refreshCount = num25;
				};
			}
			float value5 = global::UnityEngine.Random.value;
			string text5;
			UnityAction unityAction4;
			if (this._lucky > value5)
			{
				int num16 = 0;
				ShootingManager.<>c__DisplayClass96_3 CS$<>8__locals4;
				CS$<>8__locals4.FieldGetter(num16, text4, unityAction3);
				CS$<>8__locals4.<>4__this = this;
				int num17 = 0;
				ulong num18;
				int randomQuality3 = (int)this.GetRandomQuality(num18 != 0UL, num17 != 0);
				CS$<>8__locals4.value = value5;
				float num19 = value5 * 10f;
				CS$<>8__locals4.value = num19;
				float value6 = CS$<>8__locals4.value;
				int num20;
				text5 = string.Format("全体植物获得{0}护盾，复活后依然生效", num20);
				unityAction4 = delegate
				{
					List<Plant> allPlants = global::Lawnf.GetAllPlants();
					Action<Plant> <>9__ = CS$<>8__locals4.<>9__8;
					if (<>9__ == 0)
					{
						Action<Plant> action;
						CS$<>8__locals4.<>9__8 = action;
					}
					global::Core.Lawnf.Foreach<Plant>(allPlants, <>9__);
					ShootingManager <>4__this2 = CS$<>8__locals4.<>4__this;
					float num26 = <>4__this2.shieldHealth;
					<>4__this2.shieldHealth = num26;
				};
			}
			float value7 = global::UnityEngine.Random.value;
			if (this._lucky > value7)
			{
				if ((this.superUpgrade ? 1 : 0) == num)
				{
					int num21 = 0;
					ShootingManager.<>c__DisplayClass96_4 CS$<>8__locals5;
					CS$<>8__locals5.FieldGetter(num21, text5, unityAction4);
					CS$<>8__locals5.<>4__this = this;
					int num22 = 0;
					ulong num23;
					Quality randomQuality4 = this.GetRandomQuality(num23 != 0UL, num22 != 0);
					float num24;
					CS$<>8__locals5.value = num24;
					string text6 = string.Format("复活时间降低{0:F0}%\n当前标准复活时长：{1:F1}秒", randomQuality4, randomQuality4);
					UnityAction unityAction5 = delegate
					{
						float num27;
						CS$<>8__locals5.<>4__this.reviveTimer = num27;
					};
				}
				UnityAction unityAction6 = delegate
				{
					this.reviveTimer = 1f;
				};
			}
			float value8 = global::UnityEngine.Random.value;
			if (this._lucky > value8 && (this.uncrashable ? 1 : 0) == num)
			{
				UnityAction unityAction7 = delegate
				{
					List<Plant> allPlants2 = global::Lawnf.GetAllPlants();
					Action<Plant> <>9__96_ = ShootingManager.<>c.<>9__96_10;
					if (<>9__96_ == 0)
					{
						Action<Plant> action2;
						ShootingManager.<>c.<>9__96_10 = action2;
					}
					global::Core.Lawnf.Foreach<Plant>(allPlants2, <>9__96_);
					float num28 = this.shieldHealth;
					this.uncrashable = true;
					this.shieldHealth = num28;
					List<Plant> allPlants3 = global::Lawnf.GetAllPlants();
					Action<Plant> action3;
					if (ShootingManager.<>c.<>9__96_11 == 0)
					{
						ShootingManager.<>c.<>9__96_11 = action3;
					}
					allPlants3.ForEach(action3);
				};
			}
			float value9 = global::UnityEngine.Random.value;
			bool flag;
			if (this._lucky > value9 && !flag)
			{
				UnityAction unityAction8 = delegate
				{
					TravelMgr instance3 = TravelMgr.Instance;
					float num29 = this.shieldHealth;
					this.shieldHealth = num29;
					List<Plant> allPlants4 = global::Lawnf.GetAllPlants();
					Action<Plant> <>9__96_2 = ShootingManager.<>c.<>9__96_12;
					if (<>9__96_2 == 0)
					{
						Action<Plant> action4;
						ShootingManager.<>c.<>9__96_12 = action4;
					}
					allPlants4.ForEach(<>9__96_2);
				};
			}
			float value10 = global::UnityEngine.Random.value;
			bool flag2;
			UnityAction unityAction9;
			if (this._lucky > value10 && !flag2)
			{
				unityAction9 = delegate
				{
					TravelMgr instance4 = TravelMgr.Instance;
					float num30 = this.shieldHealth;
					this.shieldHealth = num30;
					List<Plant> allPlants5 = global::Lawnf.GetAllPlants();
					Action<Plant> <>9__96_3 = ShootingManager.<>c.<>9__96_13;
					if (<>9__96_3 == 0)
					{
						Action<Plant> action5;
						ShootingManager.<>c.<>9__96_13 = action5;
					}
					allPlants5.ForEach(<>9__96_3);
				};
			}
			float value11 = global::UnityEngine.Random.value;
			if (unityAction9 != 0)
			{
				UnityAction unityAction10;
				if (unityAction9 != 0)
				{
					if (unityAction9 != 0)
					{
						if (unityAction9 != (ulong)1L)
						{
							return;
						}
						if (ShootingManager.<>c.<>9__96_17 == 0)
						{
							unityAction10 = delegate
							{
								GameObject gameObject = Resources.Load<GameObject>("Items/BoardGame/NutShooting/Cannon");
								Transform transform = Board.Instance.transform;
								GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform);
							};
							ShootingManager.<>c.<>9__96_17 = unityAction10;
						}
					}
					string text8;
					string text9;
					string text10;
					string text7 = string.Concat(new string[] { "获得词条：力量会给予希望\n获得植物：", text8, "\n获得植物：", text9, "\n", text10, "获得600%攻击力加成" });
					UnityAction unityAction11 = delegate
					{
						TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)3005));
						unityAction10.GetNewPlant((PlantType)((uint)969));
						unityAction10.GetNewPlant((PlantType)((uint)953));
						TravelMgr.Instance.data.AddDamage((PlantType)((uint)969), 6f);
						TravelMgr.Instance.data.AddDamage((PlantType)((uint)953), 6f);
					};
					return;
				}
				UnityAction unityAction12 = delegate
				{
					unityAction10.superUpgrade = true;
				};
			}
			if (ShootingManager.<>c.<>9__96_14 == 0)
			{
				ShootingManager.<>c.<>9__96_14 = delegate
				{
					TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)2007));
				};
			}
			throw new NullReferenceException();
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x0015EB38 File Offset: 0x0015CD38
		[Token(Token = "0x6004343")]
		[Address(RVA = "0x898190", Offset = "0x896790", VA = "0x180898190")]
		private void RegisterExpertBuff(MultipleChoiceMenu menu)
		{
			float value = global::UnityEngine.Random.value;
			float lucky = this._lucky;
			int num = 0;
			float num2 = lucky * 0.3f * 0.01f;
			if (num != 0)
			{
				List<PlantType> expertPlants = this.ExpertPlants;
				Func<PlantType, bool> func = delegate(PlantType p)
				{
					List<PlantType> yourPlants = this.YourPlants;
					bool flag;
					return flag;
				};
				PlantType random = ListExtensions.GetRandom<PlantType>(Enumerable.ToList<PlantType>(Enumerable.Where<PlantType>(expertPlants, func)));
				MultipleChoiceMenu menu2 = menu;
				UnityAction unityAction = delegate
				{
					MultipleChoiceMenu menu3 = menu;
					ShootingManager <>4__this = this;
					Action actionOnExit = menu3.actionOnExit;
					Action action = new Action(<>4__this.ShowExpertBuffMenu);
					Delegate @delegate = Delegate.Combine(actionOnExit, action);
					int num3 = 0;
					if (@delegate == 0)
					{
						menu3.actionOnExit = num3;
					}
					if (@delegate != 0)
					{
						menu3.actionOnExit = @delegate;
						if (@delegate != 0)
						{
							throw new NullReferenceException();
						}
					}
					throw new InvalidCastException();
				};
			}
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x0015EBC8 File Offset: 0x0015CDC8
		[Token(Token = "0x6004344")]
		[Address(RVA = "0x899C90", Offset = "0x898290", VA = "0x180899C90")]
		private void ShowExpertBuffMenu()
		{
			int num = 0;
			ShootingManager.<>c__DisplayClass98_0 CS$<>8__locals1;
			CS$<>8__locals1.<>4__this = this;
			UIResourcesLoader uimanager = GameAPP.UIManager;
			int num2 = 0;
			BaseMenu baseMenu = uimanager.Push((UIType)((uint)81), num2 != 0);
			if (baseMenu == 0)
			{
				int num3 = 0;
				CS$<>8__locals1.menu = num3;
			}
			int num4 = 0;
			CS$<>8__locals1.menu = baseMenu;
			MultipleChoiceMenu menu = CS$<>8__locals1.menu;
			int num5 = 0;
			menu.SetCancelable(num5 != 0, true);
			MultipleChoiceMenu menu2 = CS$<>8__locals1.menu;
			int num6 = 0;
			menu2.SetCancelable(num6 != 0, true);
			MultipleChoiceMenu menu3 = CS$<>8__locals1.menu;
			int num7 = 0;
			int num8 = 0;
			int num9 = 0;
			ulong num10;
			ulong num11;
			menu3.SetRefreshable(num9 != 0, num8, num7 != 0, num10 != 0UL, num11 != 0UL);
			MultipleChoiceMenu menu4 = CS$<>8__locals1.menu;
			bool flag = this.refreshCount > 0;
			int num12 = 0;
			int num13 = this.refreshCount;
			ulong num14;
			menu4.SetRefreshable(true, num13, num12 != 0, flag, num14 != 0UL);
			List<PlantType> expertPlants = this.ExpertPlants;
			Func<PlantType, bool> func = delegate(PlantType p)
			{
				List<PlantType> yourPlants = CS$<>8__locals1.<>4__this.YourPlants;
				bool flag3;
				return flag3;
			};
			List<PlantType> list = Enumerable.ToList<PlantType>(Enumerable.Where<PlantType>(expertPlants, func));
			MultipleChoiceMenu menu5 = CS$<>8__locals1.menu;
			int num15 = Mathf.Min(list._size, 3);
			menu5.RegisterWindow(num15);
			bool flag2;
			if (flag2)
			{
				ShootingManager.<>c__DisplayClass98_1 CS$<>8__locals2;
				CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
				CS$<>8__locals2.plantType = (PlantType)num;
				MultipleChoiceMenu menu6 = CS$<>8__locals2.CS$<>8__locals1.menu;
				string name = global::Lawnf.GetName((PlantType)num);
				string text = "获得新植物：" + name;
				UnityAction unityAction = delegate
				{
					ShootingManager <>4__this = CS$<>8__locals2.CS$<>8__locals1.<>4__this;
					PlantType plantType2 = CS$<>8__locals2.plantType;
					<>4__this.GetNewPlant(plantType2);
				};
				PlantType plantType = CS$<>8__locals2.plantType;
			}
			if (num4 == 0)
			{
				int num16 = 0;
				MultipleChoiceMenu menu7 = CS$<>8__locals1.menu;
				Action actionOnRefresh = menu7.actionOnRefresh;
				Action action = delegate
				{
					ShootingManager <>4__this2 = CS$<>8__locals1.<>4__this;
					ShootingManager <>4__this3 = CS$<>8__locals1.<>4__this;
					int num17 = <>4__this2.refreshCount;
					<>4__this3.refreshCount = num17;
					CS$<>8__locals1.menu.PopMenu();
					CS$<>8__locals1.<>4__this.ShowExpertBuffMenu();
				};
				Delegate @delegate = Delegate.Combine(actionOnRefresh, action);
				if (@delegate == 0)
				{
					menu7.actionOnRefresh = num16;
				}
				if (@delegate != 0)
				{
					menu7.actionOnRefresh = @delegate;
					if (@delegate != 0)
					{
						return;
					}
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x0015ED94 File Offset: 0x0015CF94
		[Token(Token = "0x6004345")]
		[Address(RVA = "0x897290", Offset = "0x895890", VA = "0x180897290")]
		private void RefisterMissionBuff(MultipleChoiceMenu menu)
		{
			float value = global::UnityEngine.Random.value;
			if (this._lucky * 0.3f * 0.1f > value)
			{
				List<AdvBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				Func<AdvBuff, bool> <>9__99_ = ShootingManager.<>c.<>9__99_0;
				if (<>9__99_ == 0)
				{
					ShootingManager.<>c.<>9__99_0 = delegate(AdvBuff a)
					{
						Dictionary<AdvBuff, BaseBuff<AdvBuff>> advBuffData2 = TravelMgr.AdvBuffData;
						throw new NullReferenceException();
					};
				}
				List<AdvBuff> list2 = Enumerable.ToList<AdvBuff>(Enumerable.Where<AdvBuff>(list, <>9__99_));
				AdvBuff random = ListExtensions.GetRandom<AdvBuff>(list2);
				AdvBuff buff = random;
				Dictionary<AdvBuff, BaseBuff<AdvBuff>> advBuffData = TravelMgr.AdvBuffData;
				AdvBuff buff3 = buff;
				string description = advBuffData[buff3].Description;
				string text = description.Before("：");
				string text2 = "试炼：" + text;
				string text3 = description.After("：");
				UnityAction unityAction = delegate
				{
					TravelMgr instance = TravelMgr.Instance;
					AdvBuff buff2 = buff;
					instance.GetNormalBuff(buff2);
				};
			}
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x0015EE90 File Offset: 0x0015D090
		[Token(Token = "0x6004346")]
		[Address(RVA = "0x8969F0", Offset = "0x894FF0", VA = "0x1808969F0")]
		[ContextMenu("打印词条记录")]
		public void PrintBuffRecords()
		{
			int num;
			do
			{
				Debug.Log("=== 植物词条选择记录 ===");
				Dictionary<PlantType, Dictionary<string, int>> dictionary = this.plantBuffRecords;
				num = 0;
				bool flag;
				if (flag)
				{
					string text = string.Format("植物: {0}", flag);
					Debug.Log(text);
					bool flag2;
					if (flag2)
					{
						string text2;
						Debug.Log(text2);
					}
					if (num != 0)
					{
						goto IL_004E;
					}
				}
			}
			while (num != 0);
			return;
			IL_004E:
			throw new NullReferenceException();
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x0015EEF4 File Offset: 0x0015D0F4
		[Token(Token = "0x6004347")]
		[Address(RVA = "0x89C570", Offset = "0x89AB70", VA = "0x18089C570")]
		private void Update()
		{
			List<Plant> allPlants = global::Lawnf.GetAllPlants();
			if (allPlants != 0 && this.canTab)
			{
				Plant plant = Enumerable.FirstOrDefault<Plant>(allPlants);
				List<Zombie> allZombies = global::Lawnf.GetAllZombies(false);
				Func<Zombie, bool> <>9__101_ = ShootingManager.<>c.<>9__101_1;
				if (<>9__101_ == 0)
				{
					ShootingManager.<>c.<>9__101_1 = delegate(Zombie z)
					{
						throw new NullReferenceException();
					};
				}
				IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(allZombies, <>9__101_);
				Func<Zombie, float> func;
				if (ShootingManager.<>c.<>9__101_2 == 0)
				{
					ShootingManager.<>c.<>9__101_2 = func;
				}
				Zombie zombie = Enumerable.FirstOrDefault<Zombie>(Enumerable.OrderBy<Zombie, float>(enumerable, func));
				int num = 0;
				if (zombie != num)
				{
					int theZombieRow = zombie.theZombieRow;
					if (plant.thePlantRow != theZombieRow)
					{
						CreatePlant instance = CreatePlant.Instance;
					}
				}
			}
			UIZombieNum instance2 = UIZombieNum.Instance;
			int num2 = 0;
			if (instance2 != num2)
			{
				Action<TextMeshProUGUI> action;
				instance2.textUpdate = action;
			}
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x0015EFC8 File Offset: 0x0015D1C8
		[Token(Token = "0x6004348")]
		[Address(RVA = "0x894560", Offset = "0x892B60", VA = "0x180894560")]
		public static ZombieType GetZombieType(int wave, int waveToAdd = 5)
		{
			for (;;)
			{
				ShootingManager instance = ShootingManager.Instance;
				int num = 0;
				if (instance != num)
				{
					ShootingManager instance2 = ShootingManager.Instance;
				}
				int num2 = waveToAdd - 1;
				bool flag;
				if (!flag)
				{
					num2 = waveToAdd;
				}
				flag += flag;
				long num3 = (long)(num2 * (int)((uint)7));
				num3 += num3;
				long num4 = (long)(num2 * (int)((uint)11));
				long num5 = (long)(num2 * (int)((uint)13));
				long num6 = (long)(num2 * (int)((uint)14));
				long num7 = (long)(num2 * (int)((uint)15));
				long num8 = (long)(num2 * (int)((uint)17));
				num8 += num8;
				long num9 = (long)(num2 * (int)((uint)19));
				List<ZombieType> list = new List();
				List<ZombieType> list2 = new List();
				List<ZombieType> list3 = new List();
				List<ZombieType> list4 = new List();
				List<ZombieType> list5 = new List();
				List<ZombieType> list6 = new List();
				List<ZombieType> list7 = new List();
				List<ZombieType> list8 = new List();
				List<ZombieType> list9 = new List();
				List<ZombieType> list10 = new List();
				List<ZombieType> list11 = new List();
				List<ZombieType> list12 = new List();
				List<ZombieType> list13 = new List();
				List<ZombieType> list14 = new List();
				List<ZombieType> list15 = new List();
				List<ZombieType> list16 = new List();
				List<ZombieType> list17 = new List();
				List<ZombieType> list18 = new List();
				int size = list18._size;
				list18._size = list18;
				int size2 = list18._size;
				list18._size = list18;
				int size3 = list18._size;
				list18._size = list18;
				List<ZombieType> list19 = new List();
				int size4 = list19._size;
				list19._size = list19;
				uint num10;
				if (ShootingManager.randomType == (RandomZombieType)num10)
				{
					List<RandomZombieType> list20 = Enumerable.ToList<RandomZombieType>(global::Core.Lawnf.GetEnumValues<RandomZombieType>());
					RandomZombieType randomZombieType = ShootingManager.randomType;
					bool flag2 = list20.Remove(randomZombieType);
					int num11 = ListExtensions.GetRandom<RandomZombieType>(list20) - RandomZombieType.Machine;
					if (num11 != 0 && num11 != 0)
					{
						if (num11 == 0)
						{
							goto IL_01A9;
						}
						if (num11 != 0 && num11 == 1)
						{
							break;
						}
					}
				}
			}
			return ZombieType.NormalZombie;
			IL_01A9:
			return ZombieType.NormalZombie;
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06004349 RID: 17225 RVA: 0x0015F188 File Offset: 0x0015D388
		[Token(Token = "0x170005E2")]
		public static BLiveConfig LiveConfig
		{
			[Token(Token = "0x6004349")]
			[Address(RVA = "0x89E690", Offset = "0x89CC90", VA = "0x18089E690")]
			get
			{
				return GameAPP.config.liveConfig;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x0600434A RID: 17226 RVA: 0x0015F1A8 File Offset: 0x0015D3A8
		[Token(Token = "0x170005E3")]
		private bool CanSpawn
		{
			[Token(Token = "0x600434A")]
			[Address(RVA = "0x89E590", Offset = "0x89CB90", VA = "0x18089E590")]
			get
			{
				int enermyCount = this.board.enermyCount;
				BLiveConfig liveConfig = ShootingManager.LiveConfig;
				return enermyCount < liveConfig.maxZombieCount;
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x0600434B RID: 17227 RVA: 0x0015F1DC File Offset: 0x0015D3DC
		[Token(Token = "0x170005E4")]
		private ZombieType LiveSpawn
		{
			[Token(Token = "0x600434B")]
			[Address(RVA = "0x89E700", Offset = "0x89CD00", VA = "0x18089E700")]
			get
			{
				return ShootingManager.GetZombieType(this.board.theWave, 5);
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x0600434C RID: 17228 RVA: 0x0015F200 File Offset: 0x0015D400
		[Token(Token = "0x170005E5")]
		private int RandomRow
		{
			[Token(Token = "0x600434C")]
			[Address(RVA = "0x89E7D0", Offset = "0x89CDD0", VA = "0x18089E7D0")]
			get
			{
				int rowNum = this.board.rowNum;
				return global::UnityEngine.Random.Range(0, rowNum);
			}
		}

		// Token: 0x0600434D RID: 17229 RVA: 0x0015F228 File Offset: 0x0015D428
		[Token(Token = "0x600434D")]
		[Address(RVA = "0x893740", Offset = "0x891D40", VA = "0x180893740")]
		public void DanmakuSpawn(int level, string msg)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x0600434E RID: 17230 RVA: 0x0015F24C File Offset: 0x0015D44C
		[Token(Token = "0x600434E")]
		[Address(RVA = "0x89A870", Offset = "0x898E70", VA = "0x18089A870")]
		private void SpawnZombie(int level, int row, int count)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x0015F26C File Offset: 0x0015D46C
		[Token(Token = "0x600434F")]
		[Address(RVA = "0x895CB0", Offset = "0x8942B0", VA = "0x180895CB0")]
		public void GiftSpawn(long count, string giftName)
		{
			int num = 0;
			if (GameAPP.config.liveConfig.spawnMode == SpawnMode.礼物模式 && this.CanSpawn && this.Spawns.TryGetValue(giftName, num))
			{
				Board board = this.board;
				CreateZombie instance = CreateZombie.Instance;
				ZombieType zombieType = ShootingManager.GetZombieType(board.theWave, 5);
				num++;
			}
		}

		// Token: 0x06004350 RID: 17232 RVA: 0x0015F2CC File Offset: 0x0015D4CC
		[Token(Token = "0x6004350")]
		[Address(RVA = "0x896390", Offset = "0x894990", VA = "0x180896390")]
		public void LikeSpawn(long msg)
		{
			if (GameAPP.config.liveConfig.spawnMode == SpawnMode.点赞模式)
			{
				int num = 0;
				if (this.CanSpawn)
				{
					this.totalLike = msg;
					int likePerSpawn = ShootingManager.LiveConfig.likePerSpawn;
					long num2 = this.totalLike;
					BLiveConfig liveConfig = ShootingManager.LiveConfig;
					BLiveConfig liveConfig2 = ShootingManager.LiveConfig;
					int num3 = 0;
					Board board = this.board;
					CreateZombie instance = CreateZombie.Instance;
					int rowNum = board.rowNum;
					int num4 = global::UnityEngine.Random.Range(0, rowNum);
					uint num5;
					ZombieType zombieType = ShootingManager.GetZombieType(this.board.theWave, (int)num5);
					num3++;
					this.totalLike = (long)num;
				}
			}
		}

		// Token: 0x06004351 RID: 17233 RVA: 0x0015F378 File Offset: 0x0015D578
		[Token(Token = "0x6004351")]
		[Address(RVA = "0x896990", Offset = "0x894F90", VA = "0x180896990")]
		public bool OnSc(string name, string msg)
		{
			if (!this.LuckySc(name, msg))
			{
				bool flag = this.SpawnSc(name, msg);
				if (!flag)
				{
					return flag;
				}
			}
			return true;
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x0015F3A0 File Offset: 0x0015D5A0
		[Token(Token = "0x6004352")]
		[Address(RVA = "0x89A3A0", Offset = "0x8989A0", VA = "0x18089A3A0")]
		public bool SpawnSc(string name, string msg)
		{
			int num3;
			do
			{
				Match match = Regex.Match(msg, "在(\\d+)路放置(\\d+)个(.+)");
				if (!match.Success)
				{
					break;
				}
				int num = int.Parse(match.Groups[1].Value);
				int num2 = int.Parse(match.Groups[2].Value);
				string value = match.Groups[3].Value;
				Board board = this.board;
				Dictionary<ZombieType, ZombieInfo> zombieDatas = AlmanacDataLoader.zombieDatas;
				num3 = 0;
				bool flag;
				if (flag)
				{
					while (!flag)
					{
					}
					int num4 = this.refreshCount;
					if (num4 != 44 && num4 != 46)
					{
						if (num3 < num2)
						{
							CreateZombie instance = CreateZombie.Instance;
							num3++;
						}
						InGameText instance2 = InGameText.Instance;
						string text = string.Format("{0}给你放了{1}个僵尸", name, instance2);
					}
				}
			}
			while (num3 != 0);
			throw new NullReferenceException();
		}

		// Token: 0x06004353 RID: 17235 RVA: 0x0015F498 File Offset: 0x0015D698
		[Token(Token = "0x6004353")]
		[Address(RVA = "0x896680", Offset = "0x894C80", VA = "0x180896680")]
		private bool LuckySc(string name, string msg)
		{
			Match match = Regex.Match(msg, "(加|扣)(\\d+\\.?\\d*)(幸运)");
			if (!match.Success)
			{
			}
			string value = match.Groups[1].Value;
			string value2 = match.Groups[2].Value;
			float num = float.Parse(value2);
			if (value2 == 0)
			{
				if (value2 == 0)
				{
					return true;
				}
				InGameText instance = InGameText.Instance;
				string text = string.Format("{0}给你扣了{1}幸运", name, instance);
			}
			InGameText instance2 = InGameText.Instance;
			string text2 = string.Format("{0}给你加了{1}幸运", name, instance2);
			float num2;
			this.Lucky = num2;
			return true;
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x0015F530 File Offset: 0x0015D730
		[Token(Token = "0x6004354")]
		[Address(RVA = "0x89D170", Offset = "0x89B770", VA = "0x18089D170")]
		public ShootingManager()
		{
			Dictionary<Quality, float> dictionary = new Dictionary();
			this.qualityWeights = dictionary;
			Dictionary<PlantType, Dictionary<string, int>> dictionary2 = new Dictionary();
			this.plantBuffRecords = dictionary2;
			Dictionary<PlantType, Action<Plant>> dictionary3 = new Dictionary();
			this.reinforceActions = dictionary3;
			Dictionary<PlantType, PlantType> dictionary4 = new Dictionary();
			this.revivingPlants = dictionary4;
			List<ZombieType> list = new List();
			int size = list._size;
			int size2 = list._size;
			int size3 = list._size;
			int size4 = list._size;
			int size5 = list._size;
			int size6 = list._size;
			int size7 = list._size;
			int size8 = list._size;
			this.zombieTypes1 = list;
			List<ZombieType> list2 = new List();
			int size9 = list2._size;
			int size10 = list2._size;
			int size11 = list2._size;
			int size12 = list2._size;
			int size13 = list2._size;
			int size14 = list2._size;
			int size15 = list2._size;
			this.zombieTypes2 = list2;
			List<ZombieType> list3 = new List();
			int size16 = list3._size;
			int size17 = list3._size;
			int size18 = list3._size;
			int size19 = list3._size;
			int size20 = list3._size;
			int size21 = list3._size;
			this.zombieTypes3 = list3;
			List<ZombieType> list4 = new List();
			int size22 = list4._size;
			int size23 = list4._size;
			int size24 = list4._size;
			int size25 = list4._size;
			int size26 = list4._size;
			int size27 = list4._size;
			this.leaders = list4;
			List<PlantType> list5 = new List();
			this.YourPlants = list5;
			List<PlantType> list6 = new List();
			this.CurrentPlants = list6;
			List<PlantType> list7 = new List();
			this.RestPlants = list7;
			List<PlantType> list8 = new List();
			int size28 = list8._size;
			int num = 0;
			list8._size = 1;
			list8._syncRoot = num;
			int size29 = list8._size;
			list8._size = 1;
			int size30 = list8._size;
			list8._size = 1;
			int size31 = list8._size;
			list8._size = 1;
			int size32 = list8._size;
			list8._size = 1;
			int size33 = list8._size;
			list8._size = 1;
			int size34 = list8._size;
			list8._size = 1;
			int size35 = list8._size;
			list8._size = 1;
			int size36 = list8._size;
			list8._size = 1;
			int size37 = list8._size;
			list8._size = 1;
			int size38 = list8._size;
			list8._size = 1;
			this.AllPlants = list8;
			List<PlantType> list9 = new List();
			this.ExpertPlants = list9;
			Dictionary<string, ValueTuple<int, int>> dictionary5 = new Dictionary();
			dictionary5["人气票"] = num;
			dictionary5["粉丝团灯牌"] = num;
		}

		// Token: 0x040032B3 RID: 12979
		[Token(Token = "0x40032B3")]
		public static ShootingManager Instance;

		// Token: 0x040032B4 RID: 12980
		[Token(Token = "0x40032B4")]
		public static RandomZombieType randomType;

		// Token: 0x040032B5 RID: 12981
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40032B5")]
		public Board board;

		// Token: 0x040032B6 RID: 12982
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40032B6")]
		public int refreshCount;

		// Token: 0x040032B7 RID: 12983
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40032B7")]
		public int maxPlantCount = (int)((ulong)5L);

		// Token: 0x040032B8 RID: 12984
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40032B8")]
		public int currentPlantCount;

		// Token: 0x040032B9 RID: 12985
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40032B9")]
		public int stage = (int)((ulong)1L);

		// Token: 0x040032BA RID: 12986
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40032BA")]
		public int maxStage = (int)((ulong)1L);

		// Token: 0x040032BB RID: 12987
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40032BB")]
		public int difficulty;

		// Token: 0x040032BC RID: 12988
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40032BC")]
		public int debuffPoint;

		// Token: 0x040032BD RID: 12989
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Token(Token = "0x40032BD")]
		public bool endless;

		// Token: 0x040032BE RID: 12990
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Token(Token = "0x40032BE")]
		public bool superUpgrade;

		// Token: 0x040032BF RID: 12991
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Token(Token = "0x40032BF")]
		public bool cheatHard;

		// Token: 0x040032C0 RID: 12992
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x47")]
		[Token(Token = "0x40032C0")]
		public bool hellMode;

		// Token: 0x040032C1 RID: 12993
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40032C1")]
		private bool upgrading;

		// Token: 0x040032C2 RID: 12994
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Token(Token = "0x40032C2")]
		private bool uncrashable;

		// Token: 0x040032C3 RID: 12995
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Token(Token = "0x40032C3")]
		private bool canTab;

		// Token: 0x040032C4 RID: 12996
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x40032C4")]
		private float shieldHealth;

		// Token: 0x040032C5 RID: 12997
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40032C5")]
		private float reviveTimer = 3000f;

		// Token: 0x040032C6 RID: 12998
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Token(Token = "0x40032C6")]
		public SceneType scene1;

		// Token: 0x040032C7 RID: 12999
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40032C7")]
		public SceneType scene2 = (SceneType)((ulong)1L);

		// Token: 0x040032C8 RID: 13000
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x40032C8")]
		public SceneType scene3 = (SceneType)((ulong)41L);

		// Token: 0x040032C9 RID: 13001
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40032C9")]
		public float BaseHealthMulitpier = 1f;

		// Token: 0x040032CA RID: 13002
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Token(Token = "0x40032CA")]
		public float healthMultiplier1 = 1f;

		// Token: 0x040032CB RID: 13003
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40032CB")]
		public float healthMultiplier2 = 4f;

		// Token: 0x040032CC RID: 13004
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x40032CC")]
		public float healthMultiplier3 = 28f;

		// Token: 0x040032CD RID: 13005
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40032CD")]
		public float BaseDamageMultiplier = 1f;

		// Token: 0x040032CE RID: 13006
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Token(Token = "0x40032CE")]
		public float damageMultiplier1 = 1f;

		// Token: 0x040032CF RID: 13007
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40032CF")]
		public float damageMultiplier2 = 2f;

		// Token: 0x040032D0 RID: 13008
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Token(Token = "0x40032D0")]
		public float damageMultiplier3 = 4f;

		// Token: 0x040032D1 RID: 13009
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40032D1")]
		public float BaseSpeedMultiplier = 1f;

		// Token: 0x040032D2 RID: 13010
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Token(Token = "0x40032D2")]
		public float speedMultiplier1 = 1f;

		// Token: 0x040032D3 RID: 13011
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40032D3")]
		public float speedMultiplier2 = 1f;

		// Token: 0x040032D4 RID: 13012
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Token(Token = "0x40032D4")]
		public float speedMultiplier3 = 1f;

		// Token: 0x040032D5 RID: 13013
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Token(Token = "0x40032D5")]
		private int noDiamondCount;

		// Token: 0x040032D6 RID: 13014
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Token(Token = "0x40032D6")]
		public int pityThreshold = (int)((ulong)50L);

		// Token: 0x040032D7 RID: 13015
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40032D7")]
		public bool pityEnabled = true;

		// Token: 0x040032D8 RID: 13016
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Token(Token = "0x40032D8")]
		public int totalPityTriggered;

		// Token: 0x040032D9 RID: 13017
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40032D9")]
		public float maxLucky = 2.5f;

		// Token: 0x040032DA RID: 13018
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Token(Token = "0x40032DA")]
		[SerializeField]
		private float _lucky;

		// Token: 0x040032DB RID: 13019
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40032DB")]
		private Dictionary<Quality, float> qualityWeights;

		// Token: 0x040032DC RID: 13020
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x40032DC")]
		public readonly Dictionary<PlantType, Dictionary<string, int>> plantBuffRecords;

		// Token: 0x040032DD RID: 13021
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x40032DD")]
		private readonly Dictionary<PlantType, Action<Plant>> reinforceActions;

		// Token: 0x040032DE RID: 13022
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x40032DE")]
		private readonly Dictionary<PlantType, PlantType> revivingPlants;

		// Token: 0x040032DF RID: 13023
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x40032DF")]
		public List<ZombieType> zombieTypes1;

		// Token: 0x040032E0 RID: 13024
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x40032E0")]
		public List<ZombieType> zombieTypes2;

		// Token: 0x040032E1 RID: 13025
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x40032E1")]
		public List<ZombieType> zombieTypes3;

		// Token: 0x040032E2 RID: 13026
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x40032E2")]
		public List<ZombieType> leaders;

		// Token: 0x040032E3 RID: 13027
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x40032E3")]
		private bool laseFree;

		// Token: 0x040032E4 RID: 13028
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Token(Token = "0x40032E4")]
		public List<PlantType> YourPlants;

		// Token: 0x040032E5 RID: 13029
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x40032E5")]
		public List<PlantType> CurrentPlants;

		// Token: 0x040032E6 RID: 13030
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Token(Token = "0x40032E6")]
		public List<PlantType> RestPlants;

		// Token: 0x040032E7 RID: 13031
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Token(Token = "0x40032E7")]
		public List<PlantType> AllPlants;

		// Token: 0x040032E8 RID: 13032
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Token(Token = "0x40032E8")]
		public List<PlantType> ExpertPlants;

		// Token: 0x040032E9 RID: 13033
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Token(Token = "0x40032E9")]
		private long totalLike;

		// Token: 0x040032EA RID: 13034
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Token(Token = "0x40032EA")]
		[TupleElementNames(new string[] { "row", "count" })]
		private readonly Dictionary<string, ValueTuple<int, int>> Spawns;
	}
}
