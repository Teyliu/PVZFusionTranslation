using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000B55 RID: 2901
	[Token(Token = "0x2000B55")]
	[Serializable]
	public class BoardConfig
	{
		// Token: 0x06003C79 RID: 15481 RVA: 0x0013B624 File Offset: 0x00139824
		[Token(Token = "0x6003C79")]
		[Address(RVA = "0x81AF20", Offset = "0x819520", VA = "0x18081AF20")]
		public BoardConfig Copy()
		{
			BoardConfig boardConfig = new BoardConfig();
			int num = this.izDropCount;
			boardConfig.izDropCount = num;
			int num2 = this.redLineColumn;
			boardConfig.redLineColumn = num2;
			float num3 = this.zombieHealthMultiplier;
			boardConfig.zombieHealthMultiplier = num3;
			float num4 = this.zombieDamageMultiplier;
			boardConfig.zombieDamageMultiplier = num4;
			float num5 = this.zombieSpeedMultiplier;
			boardConfig.zombieSpeedMultiplier = num5;
			float num6 = this.zombieCountMultiplier;
			boardConfig.zombieCountMultiplier = num6;
			float num7 = this.minOriginalSpeed;
			boardConfig.minOriginalSpeed = num7;
			float num8 = this.maxOriginalSpeed;
			boardConfig.maxOriginalSpeed = num8;
			float num9 = this.waveInterval;
			boardConfig.waveInterval = num9;
			float num10 = this.firstWaveArrivedTimer;
			boardConfig.firstWaveArrivedTimer = num10;
			float num11 = this.conveyInterval;
			boardConfig.conveyInterval = num11;
			float num12 = this.gloveSpeed;
			boardConfig.gloveSpeed = num12;
			string text = this.startTip;
			boardConfig.startTip = text;
			float num13 = this.tipTime;
			boardConfig.tipTime = num13;
			bool flag = this.applyRandomData;
			boardConfig.applyRandomData = flag;
			float num14 = this.plantModifyMin;
			boardConfig.plantModifyMin = num14;
			float num15 = this.plantModifyMax;
			boardConfig.plantModifyMax = num15;
			float num16 = this.plantSpeedMin;
			boardConfig.plantSpeedMin = num16;
			float num17 = this.plantSpeedMax;
			boardConfig.plantSpeedMax = num17;
			float num18 = this.plantSpeedAvg;
			boardConfig.plantSpeedAvg = num18;
			float num19 = this.zombieModifyMin;
			boardConfig.zombieModifyMin = num19;
			float num20 = this.zombieModifyMax;
			boardConfig.zombieModifyMax = num20;
			float num21 = this.zombieModifyAvg;
			boardConfig.zombieModifyAvg = num21;
			float num22 = this.zombieSpeedMin;
			boardConfig.zombieSpeedMin = num22;
			float num23 = this.zombieSpeedMax;
			boardConfig.zombieSpeedMax = num23;
			float num24 = this.zombieSpeedAvg;
			boardConfig.zombieSpeedAvg = num24;
			float num25 = this.zombieScaleMin;
			boardConfig.zombieScaleMin = num25;
			float num26 = this.zombieScaleMax;
			boardConfig.zombieScaleMax = num26;
			float num27 = this.zombieScaleAvg;
			boardConfig.zombieScaleAvg = num27;
			return boardConfig;
		}

		// Token: 0x06003C7A RID: 15482 RVA: 0x0013B808 File Offset: 0x00139A08
		[Token(Token = "0x6003C7A")]
		[Address(RVA = "0x81B060", Offset = "0x819660", VA = "0x18081B060")]
		public BoardConfig()
		{
		}

		// Token: 0x04002CE0 RID: 11488
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002CE0")]
		public int izDropCount;

		// Token: 0x04002CE1 RID: 11489
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4002CE1")]
		public int redLineColumn = (int)((ulong)5L);

		// Token: 0x04002CE2 RID: 11490
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002CE2")]
		[Header("僵尸设置")]
		public float zombieStartAmmor;

		// Token: 0x04002CE3 RID: 11491
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4002CE3")]
		public float zombieHealthMultiplier = 1f;

		// Token: 0x04002CE4 RID: 11492
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002CE4")]
		public float zombieDamageMultiplier = 1f;

		// Token: 0x04002CE5 RID: 11493
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4002CE5")]
		public float zombieSpeedMultiplier = 1f;

		// Token: 0x04002CE6 RID: 11494
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002CE6")]
		public float zombieCountMultiplier = 1f;

		// Token: 0x04002CE7 RID: 11495
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4002CE7")]
		public float minOriginalSpeed = 1f;

		// Token: 0x04002CE8 RID: 11496
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002CE8")]
		public float maxOriginalSpeed = 1.4f;

		// Token: 0x04002CE9 RID: 11497
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4002CE9")]
		[Header("波次")]
		public float waveInterval = 30f;

		// Token: 0x04002CEA RID: 11498
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002CEA")]
		public float firstWaveArrivedTimer = 15f;

		// Token: 0x04002CEB RID: 11499
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4002CEB")]
		public float conveyInterval = 6f;

		// Token: 0x04002CEC RID: 11500
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002CEC")]
		public float gloveSpeed = 10f;

		// Token: 0x04002CED RID: 11501
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4002CED")]
		public float holdTimer = 4.2f;

		// Token: 0x04002CEE RID: 11502
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002CEE")]
		public float holdTimer2 = 1.8f;

		// Token: 0x04002CEF RID: 11503
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4002CEF")]
		public float holdTimer3 = 5f;

		// Token: 0x04002CF0 RID: 11504
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002CF0")]
		[Header("开局提示词")]
		public string startTip;

		// Token: 0x04002CF1 RID: 11505
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002CF1")]
		public float tipTime = 6f;

		// Token: 0x04002CF2 RID: 11506
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x4002CF2")]
		[Header("随机设置")]
		public bool applyRandomData;

		// Token: 0x04002CF3 RID: 11507
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002CF3")]
		public float plantModifyMin = 0.2f;

		// Token: 0x04002CF4 RID: 11508
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x4002CF4")]
		public float plantModifyMax = 6f;

		// Token: 0x04002CF5 RID: 11509
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002CF5")]
		public float plantSpeedMin = 0.2f;

		// Token: 0x04002CF6 RID: 11510
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x4002CF6")]
		public float plantSpeedMax = 6f;

		// Token: 0x04002CF7 RID: 11511
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002CF7")]
		public float plantSpeedAvg = 1.5f;

		// Token: 0x04002CF8 RID: 11512
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x4002CF8")]
		public float zombieModifyMin = 0.1f;

		// Token: 0x04002CF9 RID: 11513
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002CF9")]
		public float zombieModifyMax = 10f;

		// Token: 0x04002CFA RID: 11514
		[FieldOffset(Offset = "0x7C")]
		[Token(Token = "0x4002CFA")]
		public float zombieModifyAvg = 3f;

		// Token: 0x04002CFB RID: 11515
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002CFB")]
		public float zombieSpeedMin = 0.3f;

		// Token: 0x04002CFC RID: 11516
		[FieldOffset(Offset = "0x84")]
		[Token(Token = "0x4002CFC")]
		public float zombieSpeedMax = 4f;

		// Token: 0x04002CFD RID: 11517
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002CFD")]
		public float zombieSpeedAvg = 1.5f;

		// Token: 0x04002CFE RID: 11518
		[FieldOffset(Offset = "0x8C")]
		[Token(Token = "0x4002CFE")]
		public float zombieScaleMin = 0.33f;

		// Token: 0x04002CFF RID: 11519
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002CFF")]
		public float zombieScaleMax = 2.5f;

		// Token: 0x04002D00 RID: 11520
		[FieldOffset(Offset = "0x94")]
		[Token(Token = "0x4002D00")]
		public float zombieScaleAvg = 1f;
	}
}
