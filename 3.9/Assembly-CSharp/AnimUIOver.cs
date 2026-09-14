using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200008C RID: 140
[Token(Token = "0x200008C")]
public class AnimUIOver : MonoBehaviour
{
	// Token: 0x06000240 RID: 576 RVA: 0x00007B4C File Offset: 0x00005D4C
	[Token(Token = "0x6000240")]
	[Address(RVA = "0x3EB6B0", Offset = "0x3E9CB0", VA = "0x1803EB6B0")]
	private void Start()
	{
		Board instance = Board.Instance;
		this.board = instance;
	}

	// Token: 0x06000241 RID: 577 RVA: 0x00007B68 File Offset: 0x00005D68
	[Token(Token = "0x6000241")]
	[Address(RVA = "0x3E8FA0", Offset = "0x3E75A0", VA = "0x1803E8FA0")]
	public void Die()
	{
		for (;;)
		{
			int num = 0;
			int num2 = 0;
			GameAPP.theGameStatus = (GameStatus)num;
			List<GameObject> zombiePreviews = this.board.boardEntity.zombiePreviews;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num2 != num3))
				{
					continue;
				}
				global::UnityEngine.Object.Destroy(num2);
			}
			if (num == 0)
			{
				int num4 = 0;
				InGameUI.Instance.ConveyorBelt.SetActive(true);
				AdvantureManager instance = AdvantureManager.Instance;
				int num5 = 0;
				if (instance != num5)
				{
					AdvantureManager.Instance.OnGameStart();
				}
				RectTransform component = InGameUI.Instance.ShovelBank.GetComponent<RectTransform>();
				RectTransform component2 = InGameUI.Instance.GloveBank.GetComponent<RectTransform>();
				RectTransform component3 = InGameUI.Instance.HammerBank.GetComponent<RectTransform>();
				Camera.main.transform.position = num;
				Camera.main.orthographicSize = 12.5f;
				InGameUI.Instance.ShovelBank.SetActive(true);
				InGameUI.Instance.SlowTrigger.SetActive(true);
				InGameUI.Instance.LevelName2.gameObject.SetActive(true);
				InGameUI.Instance.IngameMenu.SetActive(true);
				InGameUI.Instance.ZombieNum.SetActive(true);
				GameObject bossHealth = InGameUI.Instance.bossHealth;
				int num6 = 0;
				if (bossHealth != num6)
				{
					InGameUI.Instance.bossHealth.SetActive(true);
				}
				InGameUI.Instance.StartBattle.SetActive(true);
				TowerData.SetCamera();
				InGameUI.Instance.CameraCtrl.SetActive(true);
				bool flag2 = global::Lawnf.TravelAdvanced((AdvBuff)((uint)1006));
				InGameUI.Instance.ShowCardBank.SetActive(true);
				InGameUI.Instance.evacuate.SetActive(true);
				GameObject lookBuff = InGameUI.Instance.lookBuff;
				int num7 = 0;
				lookBuff.SetActive(num7 != 0);
				InGameUI.Instance.ShowCardBank.SetActive(true);
				bool[] advLevelCompleted = GameAPP.advLevelCompleted;
				if ("{il2cpp array field local97->}" == (ulong)0L)
				{
				}
				InGameUI.Instance.GloveBank.SetActive(true);
				bool[] clgLevelCompleted = GameAPP.clgLevelCompleted;
				if ("{il2cpp array field local101->}" != (ulong)0L)
				{
					InGameUI.Instance.WheelBank.SetActive(true);
				}
				bool[] advLevelCompleted2 = GameAPP.advLevelCompleted;
				if ("{il2cpp array field local105->}" == (ulong)0L)
				{
				}
				GameObject hammerBank = InGameUI.Instance.HammerBank;
				hammerBank.SetActive(true);
				IntPtr cachedPtr = hammerBank.m_CachedPtr;
				bool flag3;
				if (flag3)
				{
					int num8 = 0;
					if (!(num2 != num8))
					{
						continue;
					}
					if (num2 <= 923)
					{
						goto IL_0284;
					}
					GameObject stars;
					if (num2 <= 1140 || 18446744073709550473UL > (ulong)1L)
					{
						if (num2 == 1104)
						{
							stars = InGameUI.Instance.Stars;
							stars.SetActive(true);
							goto IL_0284;
						}
						goto IL_0284;
					}
					IL_02A2:
					InGameUI.Instance.MoneyBank.SetActive(true);
					goto IL_02B2;
					IL_0284:
					if (stars != (ulong)31L && stars != (ulong)916L)
					{
						while (stars != (ulong)923L)
						{
						}
						goto IL_02A2;
					}
					goto IL_02A2;
				}
				IL_02B2:
				if (num4 == 0)
				{
					int num9 = 0;
					InGameUI.Instance.LevProgress.SetActive(true);
					GameObject gameObject = InGameUI.Instance.LevelName2.gameObject;
					int num10 = 0;
					gameObject.SetActive(num10 != 0);
					InGameUI.Instance.LevelName3.gameObject.SetActive(true);
					BejeweledManager.Instance.SetBejeweledPlant();
					BilliardManager instance2 = BilliardManager.Instance;
					int num11 = 0;
					if (instance2 != num11)
					{
						BilliardManager.Instance.billiardRod.gameObject.SetActive(true);
						BilliardManager.Instance.whiteBall.gameObject.SetActive(true);
						List<BilliardBall> billiardBalls = BilliardManager.Instance.billiardBalls;
						bool flag4;
						if (flag4)
						{
							GameObject gameObject2;
							gameObject2.SetActive(true);
						}
						if (num9 != 0)
						{
							continue;
						}
					}
					Camera.main.orthographicSize = 8f;
					Board instance3 = Board.Instance;
					Transform transform = Camera.main.transform;
					Camera.main.transform.position = num9;
					ulong num12;
					Zombie component4 = CreateZombie.Instance.SetZombie(2, (ZombieType)((uint)228), 9.9f, num12 != 0UL).GetComponent<Zombie>();
					component4.theMaxHealth = (long)((uint)60000);
					bool flag5 = "{il2cpp field on 0xEA60, offset 0xFFFFFFFFFFFFFFF8}" == typeof(UltimateSnowZombie).TypeHandle;
					component4.theAttackDamage = (int)((ulong)100L);
					if (component4.dieReason != 0)
					{
						ulong num13;
						Zombie zombie = CreateZombie.Instance.SetZombie(2, (ZombieType)((uint)231), 9.9f, num13 != 0UL);
					}
					SeedLibrary instance4 = SeedLibrary.Instance;
					int num14 = 0;
					if (instance4 != num14)
					{
						SeedLibrary.Instance.OnStartGame();
					}
					bool flag6;
					if (flag6 && !global::Lawnf.TravelAdvanced((AdvBuff)((uint)4000)))
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000242 RID: 578 RVA: 0x00007FC0 File Offset: 0x000061C0
	[Token(Token = "0x6000242")]
	[Address(RVA = "0x3EA8B0", Offset = "0x3E8EB0", VA = "0x1803EA8B0")]
	private void OppsiteConfig()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000243 RID: 579 RVA: 0x00007FE0 File Offset: 0x000061E0
	[Token(Token = "0x6000243")]
	[Address(RVA = "0x3EA960", Offset = "0x3E8F60", VA = "0x1803EA960")]
	private void ShowText()
	{
		int theBoardLevel = GameAPP.theBoardLevel;
		if (theBoardLevel > 3)
		{
			if (theBoardLevel == 9)
			{
			}
			if (theBoardLevel != 31)
			{
				goto IL_001A;
			}
		}
		if (theBoardLevel == 2)
		{
		}
		IL_001A:
		int theBoardLevel2 = GameAPP.theBoardLevel;
		if (theBoardLevel2 > 108)
		{
			if (theBoardLevel2 > 132)
			{
				if (theBoardLevel2 > 162)
				{
					if (theBoardLevel2 == 165)
					{
					}
					if (theBoardLevel2 == 169)
					{
					}
					if (theBoardLevel2 != 170)
					{
						goto IL_00B6;
					}
				}
				if (theBoardLevel2 == 138)
				{
					goto IL_0096;
				}
				if (theBoardLevel2 != 162)
				{
					goto IL_00B6;
				}
			}
			if (theBoardLevel2 > 114)
			{
				if (theBoardLevel2 == 121)
				{
				}
				if (theBoardLevel2 == 128)
				{
				}
				if (theBoardLevel2 != 132)
				{
					goto IL_00B6;
				}
			}
			if (theBoardLevel2 == 111)
			{
			}
			if (theBoardLevel2 != 114)
			{
				goto IL_00B6;
			}
		}
		if (theBoardLevel2 <= 36)
		{
			goto IL_009B;
		}
		if (theBoardLevel2 <= 55 || theBoardLevel2 == 60)
		{
		}
		IL_0096:
		if (theBoardLevel2 == 40)
		{
		}
		IL_009B:
		if (theBoardLevel2 > 19)
		{
			if (theBoardLevel2 == 22)
			{
			}
			if (theBoardLevel2 == 25)
			{
			}
		}
		if (theBoardLevel2 - 1 <= 9)
		{
			int num = theBoardLevel2 - 1;
		}
		IL_00B6:
		Dictionary<AdvantureLevel, ILevelStrategy> levelStrategies = AdvantureConfig._levelStrategies;
		bool flag;
		bool flag2;
		if (flag && flag2)
		{
			int theBoardLevel3 = GameAPP.theBoardLevel;
			LevelData levelData;
			string tips = levelData.tips;
			if (tips == 0 || tips._stringLength == 0)
			{
				return;
			}
		}
		else
		{
			while ("按V切换僵尸手套，此关卡僵尸手套无cd" == 0)
			{
			}
		}
		InGameText instance = InGameText.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x06000244 RID: 580 RVA: 0x000080F4 File Offset: 0x000062F4
	[Token(Token = "0x6000244")]
	[Address(RVA = "0x3E8EA0", Offset = "0x3E74A0", VA = "0x1803E8EA0")]
	public void Die1()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000245 RID: 581 RVA: 0x0000810C File Offset: 0x0000630C
	[Token(Token = "0x6000245")]
	[Address(RVA = "0x3E8F00", Offset = "0x3E7500", VA = "0x1803E8F00")]
	public void DieHugeWave()
	{
		Board board = this.board;
		OppsiteBuff.ShowChoice();
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000246 RID: 582 RVA: 0x0000813C File Offset: 0x0000633C
	[Token(Token = "0x6000246")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public AnimUIOver()
	{
	}

	// Token: 0x04000095 RID: 149
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000095")]
	private Board board;
}
