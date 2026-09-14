using System;
using Cpp2IlInjected;
using RhythmGame;
using TMPro;
using UnityEngine;

// Token: 0x020007E8 RID: 2024
[Token(Token = "0x20007E8")]
public class LevelResultMenu : BaseMenu
{
	// Token: 0x0600294F RID: 10575 RVA: 0x000E0E98 File Offset: 0x000DF098
	[Token(Token = "0x600294F")]
	[Address(RVA = "0x63D050", Offset = "0x63B650", VA = "0x18063D050")]
	private void Start()
	{
		BoardStatistics boardStatistics = LevelResultMenu.boardStatistics;
		this.ShowResult(boardStatistics);
	}

	// Token: 0x06002950 RID: 10576 RVA: 0x000E0EB4 File Offset: 0x000DF0B4
	[Token(Token = "0x6002950")]
	[Address(RVA = "0x63CCD0", Offset = "0x63B2D0", VA = "0x18063CCD0")]
	public void ShowResult(BoardStatistics stats)
	{
		if (stats != 0)
		{
			LevelResultMenu.boardStatistics = stats;
			GameResult gameResult = stats.gameResult;
			this.ShowGameResult(gameResult);
			long endTimeTicks = stats.endTimeTicks;
			float gameDuration = stats.gameDuration;
			this.ShowDuration(gameDuration, endTimeTicks);
			int currentWave = stats.currentWave;
			int maxWave = stats.maxWave;
			TextMeshProUGUI textMeshProUGUI = this.waveText;
			int num = 0;
			bool flag = textMeshProUGUI == num;
			if (!flag)
			{
				TextMeshProUGUI textMeshProUGUI2 = this.waveText;
				string text = string.Format("波次：{0}/{1}", flag, flag);
				textMeshProUGUI2.text = text;
			}
			this.ShowCombatStats(stats);
			this.ShowPlantStats(stats);
			this.ShowResourceStats(stats);
			TextMeshProUGUI textMeshProUGUI3 = this.mowerUsedText;
			int num2 = 0;
			if (textMeshProUGUI3 != num2)
			{
				int mowerUsedCount = stats.mowerUsedCount;
				TextMeshProUGUI textMeshProUGUI4 = this.mowerUsedText;
				string text2 = string.Format("小推车使用：{0}", mowerUsedCount);
				textMeshProUGUI4.text = text2;
			}
			this.ShowOther(stats);
		}
	}

	// Token: 0x06002951 RID: 10577 RVA: 0x000E0FA0 File Offset: 0x000DF1A0
	[Token(Token = "0x6002951")]
	[Address(RVA = "0x63C040", Offset = "0x63A640", VA = "0x18063C040")]
	private void ShowGameResult(GameResult result)
	{
		TextMeshProUGUI textMeshProUGUI = this.resultText;
		int num = 0;
		if (!(textMeshProUGUI == num))
		{
			TextMeshProUGUI textMeshProUGUI2 = this.resultText;
			int num2 = result - GameResult.Victory;
			if (num2 != 0)
			{
				if (num2 != 0)
				{
					if (num2 != 0 && num2 != 1)
					{
						textMeshProUGUI2.text = "";
						return;
					}
					textMeshProUGUI.text = "放弃";
				}
				textMeshProUGUI.text = "失败";
			}
			textMeshProUGUI.text = "关卡胜利";
			return;
		}
	}

	// Token: 0x06002952 RID: 10578 RVA: 0x000E1018 File Offset: 0x000DF218
	[Token(Token = "0x6002952")]
	[Address(RVA = "0x63BD10", Offset = "0x63A310", VA = "0x18063BD10")]
	private void ShowDuration(float duration, long realDuration)
	{
		TextMeshProUGUI textMeshProUGUI = this.durationText;
		int num = 0;
		if (!(textMeshProUGUI == num))
		{
			string text;
			this.durationText.text = text;
			TextMeshProUGUI textMeshProUGUI2 = this.realdurationText;
			int num2 = 0;
			if (!(textMeshProUGUI2 == num2))
			{
				string text2;
				this.realdurationText.text = text2;
			}
		}
	}

	// Token: 0x06002953 RID: 10579 RVA: 0x000E1070 File Offset: 0x000DF270
	[Token(Token = "0x6002953")]
	[Address(RVA = "0x63CF50", Offset = "0x63B550", VA = "0x18063CF50")]
	private void ShowWaveInfo(int currentWave, int maxWave)
	{
		TextMeshProUGUI textMeshProUGUI = this.waveText;
		int num = 0;
		bool flag = textMeshProUGUI == num;
		if (!flag)
		{
			TextMeshProUGUI textMeshProUGUI2 = this.waveText;
			string text = string.Format("波次：{0}/{1}", flag, flag);
			textMeshProUGUI2.text = text;
		}
	}

	// Token: 0x06002954 RID: 10580 RVA: 0x000E10B8 File Offset: 0x000DF2B8
	[Token(Token = "0x6002954")]
	[Address(RVA = "0x63BAE0", Offset = "0x63A0E0", VA = "0x18063BAE0")]
	private void ShowCombatStats(BoardStatistics stats)
	{
		TextMeshProUGUI textMeshProUGUI = this.zombiesKilledText;
		int num = 0;
		if (textMeshProUGUI != num)
		{
			TextMeshProUGUI textMeshProUGUI2 = this.zombiesKilledText;
			int zombiesKilled = stats.zombiesKilled;
			string text = string.Format("击杀僵尸：{0}", zombiesKilled);
			textMeshProUGUI2.text = text;
		}
		TextMeshProUGUI textMeshProUGUI3 = this.zombiesMindControlledText;
		int num2 = 0;
		if (textMeshProUGUI3 != num2)
		{
			TextMeshProUGUI textMeshProUGUI4 = this.zombiesMindControlledText;
			int zombiesMindControlled = stats.zombiesMindControlled;
			string text2 = string.Format("魅惑僵尸：{0}", zombiesMindControlled);
			textMeshProUGUI4.text = text2;
		}
		TextMeshProUGUI textMeshProUGUI5 = this.zombieDamageText;
		int num3 = 0;
		bool flag = textMeshProUGUI5 != num3;
		if (flag)
		{
			TextMeshProUGUI textMeshProUGUI6 = this.zombieDamageText;
			float totalZombieDamage = stats.totalZombieDamage;
			string text3 = string.Format("总伤害：{0:F0}", flag);
			textMeshProUGUI6.text = text3;
		}
	}

	// Token: 0x06002955 RID: 10581 RVA: 0x000E1184 File Offset: 0x000DF384
	[Token(Token = "0x6002955")]
	[Address(RVA = "0x63C6C0", Offset = "0x63ACC0", VA = "0x18063C6C0")]
	private void ShowPlantStats(BoardStatistics stats)
	{
		TextMeshProUGUI textMeshProUGUI = this.plantsPlantedText;
		int num = 0;
		if (textMeshProUGUI != num)
		{
			TextMeshProUGUI textMeshProUGUI2 = this.plantsPlantedText;
			int plantsPlanted = stats.plantsPlanted;
			string text = string.Format("种植植物：{0}", plantsPlanted);
			textMeshProUGUI2.text = text;
		}
		TextMeshProUGUI textMeshProUGUI3 = this.plantsDeathText;
		int num2 = 0;
		if (textMeshProUGUI3 != num2)
		{
			TextMeshProUGUI textMeshProUGUI4 = this.plantsDeathText;
			int plantsDeath = stats.plantsDeath;
			string text2 = string.Format("死亡植物：{0}", plantsDeath);
			textMeshProUGUI4.text = text2;
		}
		TextMeshProUGUI textMeshProUGUI5 = this.plantsShoveledText;
		int num3 = 0;
		if (textMeshProUGUI5 != num3)
		{
			TextMeshProUGUI textMeshProUGUI6 = this.plantsShoveledText;
			int plantsShoveled = stats.plantsShoveled;
			string text3 = string.Format("铲除植物：{0}", plantsShoveled);
			textMeshProUGUI6.text = text3;
		}
	}

	// Token: 0x06002956 RID: 10582 RVA: 0x000E124C File Offset: 0x000DF44C
	[Token(Token = "0x6002956")]
	[Address(RVA = "0x63C8E0", Offset = "0x63AEE0", VA = "0x18063C8E0")]
	private void ShowResourceStats(BoardStatistics stats)
	{
		TextMeshProUGUI textMeshProUGUI = this.finalSunText;
		int num = 0;
		if (textMeshProUGUI != num)
		{
			TextMeshProUGUI textMeshProUGUI2 = this.finalSunText;
			int finalSun = stats.finalSun;
			string text = string.Format("剩余阳光：{0}", finalSun);
			textMeshProUGUI2.text = text;
		}
		TextMeshProUGUI textMeshProUGUI3 = this.sunProducedText;
		int num2 = 0;
		if (textMeshProUGUI3 != num2)
		{
			TextMeshProUGUI textMeshProUGUI4 = this.sunProducedText;
			int sunProduced = stats.sunProduced;
			string text2 = string.Format("产生阳光：{0}", sunProduced);
			textMeshProUGUI4.text = text2;
		}
		TextMeshProUGUI textMeshProUGUI5 = this.sunConsumedText;
		int num3 = 0;
		if (textMeshProUGUI5 != num3)
		{
			TextMeshProUGUI textMeshProUGUI6 = this.sunConsumedText;
			int sunConsumed = stats.sunConsumed;
			string text3 = string.Format("消耗阳光：{0}", sunConsumed);
			textMeshProUGUI6.text = text3;
		}
		TextMeshProUGUI textMeshProUGUI7 = this.finalMoneyText;
		int num4 = 0;
		if (textMeshProUGUI7 != num4)
		{
			TextMeshProUGUI textMeshProUGUI8 = this.finalMoneyText;
			int finalMoney = stats.finalMoney;
			string text4 = string.Format("剩余金币：{0}", finalMoney);
			textMeshProUGUI8.text = text4;
		}
		TextMeshProUGUI textMeshProUGUI9 = this.moneyEarnedText;
		int num5 = 0;
		if (textMeshProUGUI9 != num5)
		{
			TextMeshProUGUI textMeshProUGUI10 = this.moneyEarnedText;
			int moneyEarned = stats.moneyEarned;
			string text5 = string.Format("获得金币：{0}", moneyEarned);
			textMeshProUGUI10.text = text5;
		}
		TextMeshProUGUI textMeshProUGUI11 = this.moneyConsumedText;
		int num6 = 0;
		if (textMeshProUGUI11 != num6)
		{
			TextMeshProUGUI textMeshProUGUI12 = this.moneyConsumedText;
			int moneyConsumed = stats.moneyConsumed;
			string text6 = string.Format("消耗金币：{0}", moneyConsumed);
			textMeshProUGUI12.text = text6;
		}
	}

	// Token: 0x06002957 RID: 10583 RVA: 0x000E13CC File Offset: 0x000DF5CC
	[Token(Token = "0x6002957")]
	[Address(RVA = "0x63C5D0", Offset = "0x63ABD0", VA = "0x18063C5D0")]
	private void ShowPenaltyStats(BoardStatistics stats)
	{
		TextMeshProUGUI textMeshProUGUI = this.mowerUsedText;
		int num = 0;
		if (textMeshProUGUI != num)
		{
			TextMeshProUGUI textMeshProUGUI2 = this.mowerUsedText;
			int mowerUsedCount = stats.mowerUsedCount;
			string text = string.Format("小推车使用：{0}", mowerUsedCount);
			textMeshProUGUI2.text = text;
		}
	}

	// Token: 0x06002958 RID: 10584 RVA: 0x000E1418 File Offset: 0x000DF618
	[Token(Token = "0x6002958")]
	[Address(RVA = "0x63C220", Offset = "0x63A820", VA = "0x18063C220")]
	private void ShowOther(BoardStatistics statistics)
	{
		if (statistics.comboManager != (ulong)0L)
		{
			ComboManager comboManager = statistics.comboManager;
			RectTransform rectTransform = this.sampleParent;
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.sampleLine, rectTransform);
			RectTransform rectTransform2 = this.sampleParent;
			global::UnityEngine.Object.Instantiate<TextMeshProUGUI>(this.sampleTitle, rectTransform2).text = "【其他统计】";
			RectTransform rectTransform3 = this.sampleParent;
			TextMeshProUGUI textMeshProUGUI = global::UnityEngine.Object.Instantiate<TextMeshProUGUI>(this.sampleText, rectTransform3);
			int currentCombo = comboManager.currentCombo;
			string text = string.Format("连击数：{0}", textMeshProUGUI);
			textMeshProUGUI.text = text;
			RectTransform rectTransform4 = this.sampleParent;
			TextMeshProUGUI textMeshProUGUI2 = global::UnityEngine.Object.Instantiate<TextMeshProUGUI>(this.sampleText, rectTransform4);
			int maxCombo = comboManager.maxCombo;
			string text2 = string.Format("最大连击数：{0}", textMeshProUGUI2);
			textMeshProUGUI2.text = text2;
			RectTransform rectTransform5 = this.sampleParent;
			TextMeshProUGUI textMeshProUGUI3 = global::UnityEngine.Object.Instantiate<TextMeshProUGUI>(this.sampleText, rectTransform5);
			int perfectCount = comboManager.perfectCount;
			string text3 = string.Format("Perfect：{0}", textMeshProUGUI3);
			textMeshProUGUI3.text = text3;
			RectTransform rectTransform6 = this.sampleParent;
			TextMeshProUGUI textMeshProUGUI4 = global::UnityEngine.Object.Instantiate<TextMeshProUGUI>(this.sampleText, rectTransform6);
			int greatCount = comboManager.greatCount;
			string text4 = string.Format("Great：{0}", textMeshProUGUI4);
			textMeshProUGUI4.text = text4;
			RectTransform rectTransform7 = this.sampleParent;
			TextMeshProUGUI textMeshProUGUI5 = global::UnityEngine.Object.Instantiate<TextMeshProUGUI>(this.sampleText, rectTransform7);
			int goodCount = comboManager.goodCount;
			string text5 = string.Format("Good：{0}", textMeshProUGUI5);
			textMeshProUGUI5.text = text5;
			RectTransform rectTransform8 = this.sampleParent;
			TextMeshProUGUI textMeshProUGUI6 = global::UnityEngine.Object.Instantiate<TextMeshProUGUI>(this.sampleText, rectTransform8);
			int missCount = comboManager.missCount;
			string text6 = string.Format("Miss：{0}", textMeshProUGUI6);
			textMeshProUGUI6.text = text6;
		}
	}

	// Token: 0x06002959 RID: 10585 RVA: 0x000E15B8 File Offset: 0x000DF7B8
	[Token(Token = "0x6002959")]
	[Address(RVA = "0x63B980", Offset = "0x639F80", VA = "0x18063B980")]
	public void LookDamage()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)59), canvasUp, num != 0);
		DamageReporter damageReporter = this.damageReporter;
		throw new NullReferenceException();
	}

	// Token: 0x0600295A RID: 10586 RVA: 0x000E15F0 File Offset: 0x000DF7F0
	[Token(Token = "0x600295A")]
	[Address(RVA = "0x63BAC0", Offset = "0x63A0C0", VA = "0x18063BAC0", Slot = "8")]
	public override void OnExit()
	{
		if (this.endAction != 0)
		{
		}
	}

	// Token: 0x0600295B RID: 10587 RVA: 0x000E1608 File Offset: 0x000DF808
	[Token(Token = "0x600295B")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public LevelResultMenu()
	{
	}

	// Token: 0x04001785 RID: 6021
	[Token(Token = "0x4001785")]
	public static BoardStatistics boardStatistics;

	// Token: 0x04001786 RID: 6022
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001786")]
	public DamageReporter damageReporter;

	// Token: 0x04001787 RID: 6023
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001787")]
	public Action endAction;

	// Token: 0x04001788 RID: 6024
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001788")]
	[Header("样板")]
	public RectTransform sampleParent;

	// Token: 0x04001789 RID: 6025
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001789")]
	public TextMeshProUGUI sampleTitle;

	// Token: 0x0400178A RID: 6026
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400178A")]
	public TextMeshProUGUI sampleText;

	// Token: 0x0400178B RID: 6027
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400178B")]
	public GameObject sampleLine;

	// Token: 0x0400178C RID: 6028
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400178C")]
	[Header("游戏结果")]
	public TextMeshProUGUI resultText;

	// Token: 0x0400178D RID: 6029
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400178D")]
	[Header("游戏时长")]
	public TextMeshProUGUI durationText;

	// Token: 0x0400178E RID: 6030
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400178E")]
	public TextMeshProUGUI realdurationText;

	// Token: 0x0400178F RID: 6031
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400178F")]
	[Header("波次信息")]
	public TextMeshProUGUI waveText;

	// Token: 0x04001790 RID: 6032
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001790")]
	[Header("战斗统计")]
	public TextMeshProUGUI zombiesKilledText;

	// Token: 0x04001791 RID: 6033
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001791")]
	public TextMeshProUGUI zombiesMindControlledText;

	// Token: 0x04001792 RID: 6034
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001792")]
	public TextMeshProUGUI zombieDamageText;

	// Token: 0x04001793 RID: 6035
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001793")]
	[Header("植物统计")]
	public TextMeshProUGUI plantsPlantedText;

	// Token: 0x04001794 RID: 6036
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001794")]
	public TextMeshProUGUI plantsDeathText;

	// Token: 0x04001795 RID: 6037
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001795")]
	public TextMeshProUGUI plantsShoveledText;

	// Token: 0x04001796 RID: 6038
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4001796")]
	[Header("资源统计")]
	public TextMeshProUGUI finalSunText;

	// Token: 0x04001797 RID: 6039
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4001797")]
	public TextMeshProUGUI sunProducedText;

	// Token: 0x04001798 RID: 6040
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4001798")]
	public TextMeshProUGUI sunConsumedText;

	// Token: 0x04001799 RID: 6041
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4001799")]
	public TextMeshProUGUI finalMoneyText;

	// Token: 0x0400179A RID: 6042
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400179A")]
	public TextMeshProUGUI moneyEarnedText;

	// Token: 0x0400179B RID: 6043
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400179B")]
	public TextMeshProUGUI moneyConsumedText;

	// Token: 0x0400179C RID: 6044
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400179C")]
	[Header("扣分项")]
	public TextMeshProUGUI mowerUsedText;
}
