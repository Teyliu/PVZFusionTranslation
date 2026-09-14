using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005DF RID: 1503
[Token(Token = "0x20005DF")]
public class UltimateGloom : IceGloom
{
	// Token: 0x06001BF0 RID: 7152 RVA: 0x0009544C File Offset: 0x0009364C
	[Token(Token = "0x6001BF0")]
	[Address(RVA = "0x5654A0", Offset = "0x563AA0", VA = "0x1805654A0")]
	private void CheckDie()
	{
		float value;
		float num;
		do
		{
			value = global::UnityEngine.Random.value;
		}
		while (0 <= (int)num && num <= 1f);
		if (0 > (int)value)
		{
		}
	}

	// Token: 0x06001BF1 RID: 7153 RVA: 0x00095474 File Offset: 0x00093674
	[Token(Token = "0x6001BF1")]
	[Address(RVA = "0x565450", Offset = "0x563A50", VA = "0x180565450", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		base.UpdateText();
		this.CheckDie();
		this.attributeCountdown = 1f;
	}

	// Token: 0x06001BF2 RID: 7154 RVA: 0x000954A0 File Offset: 0x000936A0
	[Token(Token = "0x6001BF2")]
	[Address(RVA = "0x565760", Offset = "0x563D60", VA = "0x180565760", Slot = "56")]
	protected override bool OnStarUp()
	{
		this.anim.SetBool("starUp", true);
		this.range = 5f;
		base.AddSpeed(0.5f);
		return true;
	}

	// Token: 0x06001BF3 RID: 7155 RVA: 0x000954DC File Offset: 0x000936DC
	[Token(Token = "0x6001BF3")]
	[Address(RVA = "0x565AF0", Offset = "0x5640F0", VA = "0x180565AF0")]
	private void StarShoot(Vector2 center, int depth, bool spread = true)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001BF4 RID: 7156 RVA: 0x000954FC File Offset: 0x000936FC
	[Token(Token = "0x6001BF4")]
	[Address(RVA = "0x5657D0", Offset = "0x563DD0", VA = "0x1805657D0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		float num;
		this.range = num;
		if (num > 4f)
		{
			this.maxRow = (int)((ulong)2L);
		}
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = this.center.transform;
		int num2 = 0;
		int thePlantRow = this.thePlantRow;
		int num3 = 0;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)52), num2, thePlantRow, num4 != 0UL, (float)num3);
		Transform transform2 = this.center.transform;
		base.AttackZombie();
		Transform transform3 = this.center.transform;
		throw new NullReferenceException();
	}

	// Token: 0x06001BF5 RID: 7157 RVA: 0x0009557C File Offset: 0x0009377C
	[Token(Token = "0x6001BF5")]
	[Address(RVA = "0x565360", Offset = "0x563960", VA = "0x180565360")]
	private void AttackZombie2(Vector2[] vectors, float range)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001BF6 RID: 7158 RVA: 0x0009559C File Offset: 0x0009379C
	[Token(Token = "0x6001BF6")]
	[Address(RVA = "0x565520", Offset = "0x563B20", VA = "0x180565520", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		bool flag = Lawnf.TravelUltimate((UltiBuff)((uint)10));
		if (flag)
		{
			BoardAction boardAction = this.board.boardAction;
			PlantType thePlantType = this.thePlantType;
		}
		bool flag2 = Lawnf.TravelAdvanced((AdvBuff)((uint)12005));
		BoardAction boardAction2 = this.board.boardAction;
		if (!flag2)
		{
			PlantType thePlantType2 = this.thePlantType;
		}
		PlantType thePlantType3 = this.thePlantType;
	}

	// Token: 0x06001BF7 RID: 7159 RVA: 0x0009560C File Offset: 0x0009380C
	[Token(Token = "0x6001BF7")]
	[Address(RVA = "0x565BF0", Offset = "0x5641F0", VA = "0x180565BF0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (!Lawnf.TravelUltimate((UltiBuff)((uint)11)))
		{
			return;
		}
		this.attributeCountdown = 5f;
		base.UpdateText();
		this.CheckDie();
	}

	// Token: 0x06001BF8 RID: 7160 RVA: 0x00095640 File Offset: 0x00093840
	[Token(Token = "0x6001BF8")]
	[Address(RVA = "0x565690", Offset = "0x563C90", VA = "0x180565690", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001BF9 RID: 7161 RVA: 0x00095660 File Offset: 0x00093860
	[Token(Token = "0x6001BF9")]
	[Address(RVA = "0x565D00", Offset = "0x564300", VA = "0x180565D00")]
	public UltimateGloom()
	{
	}
}
