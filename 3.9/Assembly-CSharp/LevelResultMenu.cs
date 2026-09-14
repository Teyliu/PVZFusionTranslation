using System;
using Cpp2IlInjected;
using RhythmGame;
using TMPro;
using UnityEngine;

// Token: 0x02000823 RID: 2083
[Token(Token = "0x2000823")]
public class LevelResultMenu : BaseMenu
{
	// Token: 0x06002A85 RID: 10885 RVA: 0x000E5FD8 File Offset: 0x000E41D8
	[Token(Token = "0x6002A85")]
	[Address(RVA = "0x6A15C0", Offset = "0x69FBC0", VA = "0x1806A15C0")]
	private void Start()
	{
		BoardStatistics boardStatistics = LevelResultMenu.boardStatistics;
		this.ShowResult(boardStatistics);
	}

	// Token: 0x06002A86 RID: 10886 RVA: 0x000E5FF4 File Offset: 0x000E41F4
	[Token(Token = "0x6002A86")]
	[Address(RVA = "0x6A1240", Offset = "0x69F840", VA = "0x1806A1240")]
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

	// Token: 0x06002A87 RID: 10887 RVA: 0x000E60E0 File Offset: 0x000E42E0
	[Token(Token = "0x6002A87")]
	[Address(RVA = "0x6A05B0", Offset = "0x69EBB0", VA = "0x1806A05B0")]
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

	// Token: 0x06002A88 RID: 10888 RVA: 0x000E6158 File Offset: 0x000E4358
	[Token(Token = "0x6002A88")]
	[Address(RVA = "0x6A0280", Offset = "0x69E880", VA = "0x1806A0280")]
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

	// Token: 0x06002A89 RID: 10889 RVA: 0x000E61B0 File Offset: 0x000E43B0
	[Token(Token = "0x6002A89")]
	[Address(RVA = "0x6A14C0", Offset = "0x69FAC0", VA = "0x1806A14C0")]
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

	// Token: 0x06002A8A RID: 10890 RVA: 0x000E61F8 File Offset: 0x000E43F8
	[Token(Token = "0x6002A8A")]
	[Address(RVA = "0x6A0050", Offset = "0x69E650", VA = "0x1806A0050")]
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

	// Token: 0x06002A8B RID: 10891 RVA: 0x000E62C4 File Offset: 0x000E44C4
	[Token(Token = "0x6002A8B")]
	[Address(RVA = "0x6A0C30", Offset = "0x69F230", VA = "0x1806A0C30")]
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

	// Token: 0x06002A8C RID: 10892 RVA: 0x000E638C File Offset: 0x000E458C
	[Token(Token = "0x6002A8C")]
	[Address(RVA = "0x6A0E50", Offset = "0x69F450", VA = "0x1806A0E50")]
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

	// Token: 0x06002A8D RID: 10893 RVA: 0x000E650C File Offset: 0x000E470C
	[Token(Token = "0x6002A8D")]
	[Address(RVA = "0x6A0B40", Offset = "0x69F140", VA = "0x1806A0B40")]
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

	// Token: 0x06002A8E RID: 10894 RVA: 0x000E6558 File Offset: 0x000E4758
	[Token(Token = "0x6002A8E")]
	[Address(RVA = "0x6A0790", Offset = "0x69ED90", VA = "0x1806A0790")]
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

	// Token: 0x06002A8F RID: 10895 RVA: 0x000E66F8 File Offset: 0x000E48F8
	[Token(Token = "0x6002A8F")]
	[Address(RVA = "0x69FEF0", Offset = "0x69E4F0", VA = "0x18069FEF0")]
	public void LookDamage()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)59), canvasUp, num != 0);
		DamageReporter damageReporter = this.damageReporter;
		throw new NullReferenceException();
	}

	// Token: 0x06002A90 RID: 10896 RVA: 0x000E6730 File Offset: 0x000E4930
	[Token(Token = "0x6002A90")]
	[Address(RVA = "0x6A0030", Offset = "0x69E630", VA = "0x1806A0030", Slot = "8")]
	public override void OnExit()
	{
		if (this.endAction != 0)
		{
		}
	}

	// Token: 0x06002A91 RID: 10897 RVA: 0x000E6748 File Offset: 0x000E4948
	[Token(Token = "0x6002A91")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public LevelResultMenu()
	{
	}

	// Token: 0x0400186E RID: 6254
	[Token(Token = "0x400186E")]
	public static BoardStatistics boardStatistics;

	// Token: 0x0400186F RID: 6255
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400186F")]
	public DamageReporter damageReporter;

	// Token: 0x04001870 RID: 6256
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001870")]
	public Action endAction;

	// Token: 0x04001871 RID: 6257
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001871")]
	[Header("样板")]
	public RectTransform sampleParent;

	// Token: 0x04001872 RID: 6258
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001872")]
	public TextMeshProUGUI sampleTitle;

	// Token: 0x04001873 RID: 6259
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001873")]
	public TextMeshProUGUI sampleText;

	// Token: 0x04001874 RID: 6260
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001874")]
	public GameObject sampleLine;

	// Token: 0x04001875 RID: 6261
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001875")]
	[Header("游戏结果")]
	public TextMeshProUGUI resultText;

	// Token: 0x04001876 RID: 6262
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001876")]
	[Header("游戏时长")]
	public TextMeshProUGUI durationText;

	// Token: 0x04001877 RID: 6263
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001877")]
	public TextMeshProUGUI realdurationText;

	// Token: 0x04001878 RID: 6264
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001878")]
	[Header("波次信息")]
	public TextMeshProUGUI waveText;

	// Token: 0x04001879 RID: 6265
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001879")]
	[Header("战斗统计")]
	public TextMeshProUGUI zombiesKilledText;

	// Token: 0x0400187A RID: 6266
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400187A")]
	public TextMeshProUGUI zombiesMindControlledText;

	// Token: 0x0400187B RID: 6267
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400187B")]
	public TextMeshProUGUI zombieDamageText;

	// Token: 0x0400187C RID: 6268
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400187C")]
	[Header("植物统计")]
	public TextMeshProUGUI plantsPlantedText;

	// Token: 0x0400187D RID: 6269
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400187D")]
	public TextMeshProUGUI plantsDeathText;

	// Token: 0x0400187E RID: 6270
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400187E")]
	public TextMeshProUGUI plantsShoveledText;

	// Token: 0x0400187F RID: 6271
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400187F")]
	[Header("资源统计")]
	public TextMeshProUGUI finalSunText;

	// Token: 0x04001880 RID: 6272
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4001880")]
	public TextMeshProUGUI sunProducedText;

	// Token: 0x04001881 RID: 6273
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4001881")]
	public TextMeshProUGUI sunConsumedText;

	// Token: 0x04001882 RID: 6274
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4001882")]
	public TextMeshProUGUI finalMoneyText;

	// Token: 0x04001883 RID: 6275
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4001883")]
	public TextMeshProUGUI moneyEarnedText;

	// Token: 0x04001884 RID: 6276
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4001884")]
	public TextMeshProUGUI moneyConsumedText;

	// Token: 0x04001885 RID: 6277
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4001885")]
	[Header("扣分项")]
	public TextMeshProUGUI mowerUsedText;
}
