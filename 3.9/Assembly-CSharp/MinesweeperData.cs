using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000CE RID: 206
[Token(Token = "0x20000CE")]
public class MinesweeperData : ScriptableObject
{
	// Token: 0x060003BB RID: 955 RVA: 0x00011688 File Offset: 0x0000F888
	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x4F65D0", Offset = "0x4F4BD0", VA = "0x1804F65D0")]
	public MinesweeperData()
	{
	}

	// Token: 0x04000205 RID: 517
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000205")]
	[Range(0f, 0.5f)]
	[Tooltip("地雷密度（0-1之间）")]
	[Header("地雷配置")]
	public float mineDensity = 0.15f;

	// Token: 0x04000206 RID: 518
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000206")]
	[Tooltip("地雷伤害")]
	public int mineDamage = (int)((ulong)100L);

	// Token: 0x04000207 RID: 519
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000207")]
	[Tooltip("地雷爆炸半径")]
	public float explosionRadius = 1f;

	// Token: 0x04000208 RID: 520
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000208")]
	[Tooltip("完成扫雷奖励的金钱")]
	[Header("奖励配置")]
	public int rewardMoney = (int)((ulong)500L);

	// Token: 0x04000209 RID: 521
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000209")]
	[Tooltip("完成扫雷奖励的卡片类型")]
	public PlantType rewardPlantType = (PlantType)((ulong)4294967295L);

	// Token: 0x0400020A RID: 522
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400020A")]
	[Tooltip("是否显示数字坚果")]
	[Header("视觉效果")]
	public bool showNumberNuts = true;

	// Token: 0x0400020B RID: 523
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400020B")]
	[Tooltip("地雷爆炸特效路径")]
	public string explosionEffectPath = "_Other/Explosion";

	// Token: 0x0400020C RID: 524
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400020C")]
	[Header("游戏规则")]
	[Tooltip("是否允许踩到地雷后继续游戏")]
	public bool continueAfterMineHit;

	// Token: 0x0400020D RID: 525
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x400020D")]
	[Tooltip("是否在打开第一个格子时生成地雷（保证第一格安全）")]
	public bool safeFirstHit = true;

	// Token: 0x0400020E RID: 526
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x400020E")]
	[Tooltip("是否启用标记功能（右键标记疑似地雷）")]
	public bool enableFlagging;
}
