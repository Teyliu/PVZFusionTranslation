using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020006EF RID: 1775
[Token(Token = "0x20006EF")]
public class TrainingDummy : Zombie
{
	// Token: 0x1700016A RID: 362
	// (get) Token: 0x06002309 RID: 8969 RVA: 0x000B79F0 File Offset: 0x000B5BF0
	// (set) Token: 0x0600230A RID: 8970 RVA: 0x000B7A04 File Offset: 0x000B5C04
	[Token(Token = "0x1700016A")]
	public float CurrentDPS
	{
		[Token(Token = "0x6002309")]
		[Address(RVA = "0x57D5F0", Offset = "0x57BBF0", VA = "0x18057D5F0")]
		get;
		[Token(Token = "0x600230A")]
		[Address(RVA = "0x57D620", Offset = "0x57BC20", VA = "0x18057D620")]
		private set;
	}

	// Token: 0x1700016B RID: 363
	// (get) Token: 0x0600230B RID: 8971 RVA: 0x000B7A18 File Offset: 0x000B5C18
	// (set) Token: 0x0600230C RID: 8972 RVA: 0x000B7A2C File Offset: 0x000B5C2C
	[Token(Token = "0x1700016B")]
	public float Average10SecDPS
	{
		[Token(Token = "0x600230B")]
		[Address(RVA = "0x57D5E0", Offset = "0x57BBE0", VA = "0x18057D5E0")]
		get;
		[Token(Token = "0x600230C")]
		[Address(RVA = "0x57D610", Offset = "0x57BC10", VA = "0x18057D610")]
		private set;
	}

	// Token: 0x1700016C RID: 364
	// (get) Token: 0x0600230D RID: 8973 RVA: 0x000B7A40 File Offset: 0x000B5C40
	[Token(Token = "0x1700016C")]
	public long LastDamage
	{
		[Token(Token = "0x600230D")]
		[Address(RVA = "0x57D600", Offset = "0x57BC00", VA = "0x18057D600")]
		get
		{
			return this.lastDamage;
		}
	}

	// Token: 0x0600230E RID: 8974 RVA: 0x000B7A54 File Offset: 0x000B5C54
	[Token(Token = "0x600230E")]
	[Address(RVA = "0x57CD80", Offset = "0x57B380", VA = "0x18057CD80", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		this.flashTime = 0.2f;
		int num;
		this.lastDamage = (long)num;
		if (theDamageType == DamageType.MaxDamage)
		{
			this.lastDamage = (long)((ulong)5000L);
		}
		if (num <= 1 || theDamageType == DamageType.IceShieldless)
		{
			int num2 = 0;
			int num3 = 0;
			base.SetCold(10f, num3, num2 != 0);
		}
		long num4 = this.currentSecondDamage;
		this.currentSecondDamage = num4;
		long num5 = this.totalDamage;
		this.totalDamage = num5;
		this.lastTakeDamageDuring = 0f;
	}

	// Token: 0x0600230F RID: 8975 RVA: 0x000B7ACC File Offset: 0x000B5CCC
	[Token(Token = "0x600230F")]
	[Address(RVA = "0x57CD30", Offset = "0x57B330", VA = "0x18057CD30", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06002310 RID: 8976 RVA: 0x000B7ADC File Offset: 0x000B5CDC
	[Token(Token = "0x6002310")]
	[Address(RVA = "0x57D480", Offset = "0x57BA80", VA = "0x18057D480", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		float deltaTime = Time.deltaTime;
		this.dpsUpdateTimer = deltaTime;
		if (this.lastTakeDamageDuring > 10f)
		{
			this.totalDamage = (long)((ulong)0L);
		}
		this.UpdateDPSRecords();
		this.UpdateHealthText();
		this.dpsUpdateTimer = 0f;
		this.healthText.gameObject.SetActive(true);
	}

	// Token: 0x06002311 RID: 8977 RVA: 0x000B7B44 File Offset: 0x000B5D44
	[Token(Token = "0x6002311")]
	[Address(RVA = "0x57CE80", Offset = "0x57B480", VA = "0x18057CE80")]
	private void UpdateDPSRecords()
	{
		ulong num3;
		do
		{
			int num = 0;
			this.<CurrentDPS>k__BackingField = (float)num;
			Queue<float> queue = this.last10SecondDamages;
			float num2 = this.last10SecondDamages.Dequeue();
			Queue<float> queue2 = this.last10SecondDamages;
			bool flag;
			if (flag)
			{
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06002312 RID: 8978 RVA: 0x000B7B90 File Offset: 0x000B5D90
	[Token(Token = "0x6002312")]
	[Address(RVA = "0x57D080", Offset = "0x57B680", VA = "0x18057D080", Slot = "72")]
	public override void UpdateHealthText()
	{
		TextMeshPro healthText = this.healthText;
		int num = 0;
		if (healthText != num)
		{
			long num2 = this.lastDamage;
			TextMeshPro healthText2 = this.healthText;
			string text = string.Format("最后一击：{0}\n", num2);
			healthText2.text = text;
			float num3 = this.<Average10SecDPS>k__BackingField;
			TextMeshPro healthText3 = this.healthText;
			if (num3 <= 100000000f)
			{
				if (num3 <= 10000f)
				{
					string text2 = healthText3.text;
					float num4 = this.<Average10SecDPS>k__BackingField;
				}
				string text3 = healthText3.text;
			}
			string text4 = healthText3.text;
			string text5 = string.Format("DPS：{0:F2}亿\n", text4);
			string text6 = text4 + text5;
			healthText3.text = text6;
			TextMeshPro healthText4 = this.healthText;
			string text7 = healthText4.text;
			long num5 = this.totalDamage;
			string text8 = healthText4.text;
			string text9 = healthText4.text;
			ulong num6;
			string text10 = string.Format("总伤害：{0:F2}亿\n", num6);
			string text11 = text9 + text10;
			healthText4.text = text11;
		}
	}

	// Token: 0x06002313 RID: 8979 RVA: 0x000B7C94 File Offset: 0x000B5E94
	[Token(Token = "0x6002313")]
	[Address(RVA = "0x561440", Offset = "0x55FA40", VA = "0x180561440", Slot = "27")]
	public override void Die(int reason = 0)
	{
		base.Die(2);
	}

	// Token: 0x06002314 RID: 8980 RVA: 0x000B7CA8 File Offset: 0x000B5EA8
	[Token(Token = "0x6002314")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06002315 RID: 8981 RVA: 0x000B7CB8 File Offset: 0x000B5EB8
	[Token(Token = "0x6002315")]
	[Address(RVA = "0x57CD70", Offset = "0x57B370", VA = "0x18057CD70", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		int num;
		return num;
	}

	// Token: 0x06002316 RID: 8982 RVA: 0x000B7CC8 File Offset: 0x000B5EC8
	[Token(Token = "0x6002316")]
	[Address(RVA = "0x530300", Offset = "0x52E900", VA = "0x180530300", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002317 RID: 8983 RVA: 0x000B7CD8 File Offset: 0x000B5ED8
	[Token(Token = "0x6002317")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002318 RID: 8984 RVA: 0x000B7CE8 File Offset: 0x000B5EE8
	[Token(Token = "0x6002318")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "48")]
	public override void SetPortaled(float timer = 1.5f)
	{
	}

	// Token: 0x06002319 RID: 8985 RVA: 0x000B7CF8 File Offset: 0x000B5EF8
	[Token(Token = "0x6002319")]
	[Address(RVA = "0x57D540", Offset = "0x57BB40", VA = "0x18057D540")]
	public TrainingDummy()
	{
		Queue<float> queue = new Queue();
		this.last10SecondDamages = queue;
		base..ctor();
	}

	// Token: 0x04001157 RID: 4439
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001157")]
	private long lastDamage;

	// Token: 0x04001158 RID: 4440
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4001158")]
	private long currentSecondDamage;

	// Token: 0x04001159 RID: 4441
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4001159")]
	private readonly Queue<float> last10SecondDamages;

	// Token: 0x0400115A RID: 4442
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x400115A")]
	private float dpsUpdateTimer;

	// Token: 0x0400115D RID: 4445
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x400115D")]
	public long totalDamage;
}
