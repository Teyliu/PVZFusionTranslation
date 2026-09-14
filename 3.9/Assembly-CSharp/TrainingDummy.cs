using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000727 RID: 1831
[Token(Token = "0x2000727")]
public class TrainingDummy : Zombie
{
	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x06002425 RID: 9253 RVA: 0x000BC834 File Offset: 0x000BAA34
	// (set) Token: 0x06002426 RID: 9254 RVA: 0x000BC848 File Offset: 0x000BAA48
	[Token(Token = "0x170001B0")]
	public float CurrentDPS
	{
		[Token(Token = "0x6002425")]
		[Address(RVA = "0x5F7BD0", Offset = "0x5F61D0", VA = "0x1805F7BD0")]
		get;
		[Token(Token = "0x6002426")]
		[Address(RVA = "0x5F7C00", Offset = "0x5F6200", VA = "0x1805F7C00")]
		private set;
	}

	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x06002427 RID: 9255 RVA: 0x000BC85C File Offset: 0x000BAA5C
	// (set) Token: 0x06002428 RID: 9256 RVA: 0x000BC870 File Offset: 0x000BAA70
	[Token(Token = "0x170001B1")]
	public float Average10SecDPS
	{
		[Token(Token = "0x6002427")]
		[Address(RVA = "0x5F7BC0", Offset = "0x5F61C0", VA = "0x1805F7BC0")]
		get;
		[Token(Token = "0x6002428")]
		[Address(RVA = "0x5F7BF0", Offset = "0x5F61F0", VA = "0x1805F7BF0")]
		private set;
	}

	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x06002429 RID: 9257 RVA: 0x000BC884 File Offset: 0x000BAA84
	[Token(Token = "0x170001B2")]
	public long LastDamage
	{
		[Token(Token = "0x6002429")]
		[Address(RVA = "0x5F7BE0", Offset = "0x5F61E0", VA = "0x1805F7BE0")]
		get
		{
			return this.lastDamage;
		}
	}

	// Token: 0x0600242A RID: 9258 RVA: 0x000BC898 File Offset: 0x000BAA98
	[Token(Token = "0x600242A")]
	[Address(RVA = "0x5F7360", Offset = "0x5F5960", VA = "0x1805F7360", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		this.flashTime = 0.2f;
		long num;
		this.lastDamage = num;
		if (theDamageType == DamageType.MaxDamage)
		{
			this.lastDamage = (long)((ulong)5000L);
		}
		if (theDamageType == DamageType.IceShieldless)
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

	// Token: 0x0600242B RID: 9259 RVA: 0x000BC90C File Offset: 0x000BAB0C
	[Token(Token = "0x600242B")]
	[Address(RVA = "0x5F7310", Offset = "0x5F5910", VA = "0x1805F7310", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x0600242C RID: 9260 RVA: 0x000BC91C File Offset: 0x000BAB1C
	[Token(Token = "0x600242C")]
	[Address(RVA = "0x5F7A60", Offset = "0x5F6060", VA = "0x1805F7A60", Slot = "17")]
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

	// Token: 0x0600242D RID: 9261 RVA: 0x000BC984 File Offset: 0x000BAB84
	[Token(Token = "0x600242D")]
	[Address(RVA = "0x5F7460", Offset = "0x5F5A60", VA = "0x1805F7460")]
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

	// Token: 0x0600242E RID: 9262 RVA: 0x000BC9D0 File Offset: 0x000BABD0
	[Token(Token = "0x600242E")]
	[Address(RVA = "0x5F7660", Offset = "0x5F5C60", VA = "0x1805F7660", Slot = "74")]
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

	// Token: 0x0600242F RID: 9263 RVA: 0x000BCAD4 File Offset: 0x000BACD4
	[Token(Token = "0x600242F")]
	[Address(RVA = "0x5C4230", Offset = "0x5C2830", VA = "0x1805C4230", Slot = "28")]
	public override void Die(int reason = 0)
	{
		base.Die(2);
	}

	// Token: 0x06002430 RID: 9264 RVA: 0x000BCAE8 File Offset: 0x000BACE8
	[Token(Token = "0x6002430")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06002431 RID: 9265 RVA: 0x000BCAF8 File Offset: 0x000BACF8
	[Token(Token = "0x6002431")]
	[Address(RVA = "0x5F7350", Offset = "0x5F5950", VA = "0x1805F7350", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		long num;
		return num;
	}

	// Token: 0x06002432 RID: 9266 RVA: 0x000BCB0C File Offset: 0x000BAD0C
	[Token(Token = "0x6002432")]
	[Address(RVA = "0x586E80", Offset = "0x585480", VA = "0x180586E80", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002433 RID: 9267 RVA: 0x000BCB1C File Offset: 0x000BAD1C
	[Token(Token = "0x6002433")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002434 RID: 9268 RVA: 0x000BCB2C File Offset: 0x000BAD2C
	[Token(Token = "0x6002434")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "50")]
	public override void SetPortaled(float timer = 1.5f)
	{
	}

	// Token: 0x06002435 RID: 9269 RVA: 0x000BCB3C File Offset: 0x000BAD3C
	[Token(Token = "0x6002435")]
	[Address(RVA = "0x5F7B20", Offset = "0x5F6120", VA = "0x1805F7B20")]
	public TrainingDummy()
	{
		Queue<float> queue = new Queue();
		this.last10SecondDamages = queue;
		base..ctor();
	}

	// Token: 0x04001224 RID: 4644
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001224")]
	private long lastDamage;

	// Token: 0x04001225 RID: 4645
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001225")]
	private long currentSecondDamage;

	// Token: 0x04001226 RID: 4646
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4001226")]
	private readonly Queue<float> last10SecondDamages;

	// Token: 0x04001227 RID: 4647
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4001227")]
	private float dpsUpdateTimer;

	// Token: 0x0400122A RID: 4650
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x400122A")]
	public long totalDamage;
}
