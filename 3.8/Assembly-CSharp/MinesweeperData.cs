using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000C9 RID: 201
[Token(Token = "0x20000C9")]
public class MinesweeperData : ScriptableObject
{
	// Token: 0x060003A0 RID: 928 RVA: 0x00011314 File Offset: 0x0000F514
	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x4B6F10", Offset = "0x4B5510", VA = "0x1804B6F10")]
	public MinesweeperData()
	{
	}

	// Token: 0x040001F8 RID: 504
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001F8")]
	[Tooltip("地雷密度（0-1之间）")]
	[Range(0f, 0.5f)]
	[Header("地雷配置")]
	public float mineDensity = 0.15f;

	// Token: 0x040001F9 RID: 505
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40001F9")]
	[Tooltip("地雷伤害")]
	public int mineDamage = (int)((ulong)100L);

	// Token: 0x040001FA RID: 506
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001FA")]
	[Tooltip("地雷爆炸半径")]
	public float explosionRadius = 1f;

	// Token: 0x040001FB RID: 507
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40001FB")]
	[Header("奖励配置")]
	[Tooltip("完成扫雷奖励的金钱")]
	public int rewardMoney = (int)((ulong)500L);

	// Token: 0x040001FC RID: 508
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001FC")]
	[Tooltip("完成扫雷奖励的卡片类型")]
	public PlantType rewardPlantType = (PlantType)((ulong)4294967295L);

	// Token: 0x040001FD RID: 509
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40001FD")]
	[Header("视觉效果")]
	[Tooltip("是否显示数字坚果")]
	public bool showNumberNuts = true;

	// Token: 0x040001FE RID: 510
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001FE")]
	[Tooltip("地雷爆炸特效路径")]
	public string explosionEffectPath = "_Other/Explosion";

	// Token: 0x040001FF RID: 511
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001FF")]
	[Header("游戏规则")]
	[Tooltip("是否允许踩到地雷后继续游戏")]
	public bool continueAfterMineHit;

	// Token: 0x04000200 RID: 512
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000200")]
	[Tooltip("是否在打开第一个格子时生成地雷（保证第一格安全）")]
	public bool safeFirstHit = true;

	// Token: 0x04000201 RID: 513
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x4000201")]
	[Tooltip("是否启用标记功能（右键标记疑似地雷）")]
	public bool enableFlagging;
}
