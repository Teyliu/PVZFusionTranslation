using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000B13 RID: 2835
	[Token(Token = "0x2000B13")]
	[Serializable]
	public class BoardConfig
	{
		// Token: 0x06003B28 RID: 15144 RVA: 0x001362D4 File Offset: 0x001344D4
		[Token(Token = "0x6003B28")]
		[Address(RVA = "0x79FEB0", Offset = "0x79E4B0", VA = "0x18079FEB0")]
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

		// Token: 0x06003B29 RID: 15145 RVA: 0x001364B8 File Offset: 0x001346B8
		[Token(Token = "0x6003B29")]
		[Address(RVA = "0x79FFF0", Offset = "0x79E5F0", VA = "0x18079FFF0")]
		public BoardConfig()
		{
		}

		// Token: 0x04002B6C RID: 11116
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002B6C")]
		public int izDropCount;

		// Token: 0x04002B6D RID: 11117
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4002B6D")]
		public int redLineColumn = (int)((ulong)5L);

		// Token: 0x04002B6E RID: 11118
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002B6E")]
		[Header("僵尸设置")]
		public float zombieStartAmmor;

		// Token: 0x04002B6F RID: 11119
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4002B6F")]
		public float zombieHealthMultiplier = 1f;

		// Token: 0x04002B70 RID: 11120
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002B70")]
		public float zombieDamageMultiplier = 1f;

		// Token: 0x04002B71 RID: 11121
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4002B71")]
		public float zombieSpeedMultiplier = 1f;

		// Token: 0x04002B72 RID: 11122
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002B72")]
		public float zombieCountMultiplier = 1f;

		// Token: 0x04002B73 RID: 11123
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4002B73")]
		public float minOriginalSpeed = 1f;

		// Token: 0x04002B74 RID: 11124
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002B74")]
		public float maxOriginalSpeed = 1.4f;

		// Token: 0x04002B75 RID: 11125
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4002B75")]
		[Header("波次")]
		public float waveInterval = 30f;

		// Token: 0x04002B76 RID: 11126
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002B76")]
		public float firstWaveArrivedTimer = 15f;

		// Token: 0x04002B77 RID: 11127
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4002B77")]
		public float conveyInterval = 6f;

		// Token: 0x04002B78 RID: 11128
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002B78")]
		public float gloveSpeed = 10f;

		// Token: 0x04002B79 RID: 11129
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4002B79")]
		public float holdTimer = 4.2f;

		// Token: 0x04002B7A RID: 11130
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002B7A")]
		public float holdTimer2 = 1.8f;

		// Token: 0x04002B7B RID: 11131
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4002B7B")]
		public float holdTimer3 = 5f;

		// Token: 0x04002B7C RID: 11132
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002B7C")]
		[Header("开局提示词")]
		public string startTip;

		// Token: 0x04002B7D RID: 11133
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002B7D")]
		public float tipTime = 6f;

		// Token: 0x04002B7E RID: 11134
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x4002B7E")]
		[Header("随机设置")]
		public bool applyRandomData;

		// Token: 0x04002B7F RID: 11135
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002B7F")]
		public float plantModifyMin = 0.2f;

		// Token: 0x04002B80 RID: 11136
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x4002B80")]
		public float plantModifyMax = 6f;

		// Token: 0x04002B81 RID: 11137
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002B81")]
		public float plantSpeedMin = 0.2f;

		// Token: 0x04002B82 RID: 11138
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x4002B82")]
		public float plantSpeedMax = 6f;

		// Token: 0x04002B83 RID: 11139
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002B83")]
		public float plantSpeedAvg = 1.5f;

		// Token: 0x04002B84 RID: 11140
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x4002B84")]
		public float zombieModifyMin = 0.1f;

		// Token: 0x04002B85 RID: 11141
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002B85")]
		public float zombieModifyMax = 10f;

		// Token: 0x04002B86 RID: 11142
		[FieldOffset(Offset = "0x7C")]
		[Token(Token = "0x4002B86")]
		public float zombieModifyAvg = 3f;

		// Token: 0x04002B87 RID: 11143
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002B87")]
		public float zombieSpeedMin = 0.3f;

		// Token: 0x04002B88 RID: 11144
		[FieldOffset(Offset = "0x84")]
		[Token(Token = "0x4002B88")]
		public float zombieSpeedMax = 4f;

		// Token: 0x04002B89 RID: 11145
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002B89")]
		public float zombieSpeedAvg = 1.5f;

		// Token: 0x04002B8A RID: 11146
		[FieldOffset(Offset = "0x8C")]
		[Token(Token = "0x4002B8A")]
		public float zombieScaleMin = 0.33f;

		// Token: 0x04002B8B RID: 11147
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002B8B")]
		public float zombieScaleMax = 2.5f;

		// Token: 0x04002B8C RID: 11148
		[FieldOffset(Offset = "0x94")]
		[Token(Token = "0x4002B8C")]
		public float zombieScaleAvg = 1f;
	}
}
