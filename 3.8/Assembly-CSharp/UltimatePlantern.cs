using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000484 RID: 1156
[Token(Token = "0x2000484")]
public class UltimatePlantern : Plantern
{
	// Token: 0x0600158B RID: 5515 RVA: 0x000775D8 File Offset: 0x000757D8
	[Token(Token = "0x600158B")]
	[Address(RVA = "0x48F6C0", Offset = "0x48DCC0", VA = "0x18048F6C0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 3f;
		SortingGroup sortingGroup = this.ultimateLight.AddComponent<SortingGroup>();
		sortingGroup.sortAtRoot = true;
		sortingGroup.sortingLayerName = "particle11";
	}

	// Token: 0x0600158C RID: 5516 RVA: 0x0007761C File Offset: 0x0007581C
	[Token(Token = "0x600158C")]
	[Address(RVA = "0x48FFB0", Offset = "0x48E5B0", VA = "0x18048FFB0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		ParticleSystem.MainModule main = this.lanternLight.GetComponent<ParticleSystem>().main;
		ParticleSystem.MinMaxGradient minMaxGradient;
		Gradient gradientMax = minMaxGradient.m_GradientMax;
		float b = minMaxGradient.m_ColorMin.b;
		List<SpriteRenderer> spriteRenderers = this.spriteRenderers;
		SpriteRenderer spriteRenderer = this.ultimateLight;
		bool flag = spriteRenderers.Remove(spriteRenderer);
	}

	// Token: 0x0600158D RID: 5517 RVA: 0x00077678 File Offset: 0x00075878
	[Token(Token = "0x600158D")]
	[Address(RVA = "0x48FEF0", Offset = "0x48E4F0", VA = "0x18048FEF0")]
	private void Shrink()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x0600158E RID: 5518 RVA: 0x0007769C File Offset: 0x0007589C
	[Token(Token = "0x600158E")]
	[Address(RVA = "0x48FA80", Offset = "0x48E080", VA = "0x18048FA80")]
	public void OnSuperCharge()
	{
		SpriteRenderer spriteRenderer = this.ultimateLight;
		int num = 0;
		spriteRenderer.enabled = num != 0;
	}

	// Token: 0x0600158F RID: 5519 RVA: 0x00077734 File Offset: 0x00075934
	[Token(Token = "0x600158F")]
	[Address(RVA = "0x48F920", Offset = "0x48DF20", VA = "0x18048F920", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.Active)
		{
			this.AttributeEvent();
			this.OnSuperCharge();
		}
	}

	// Token: 0x06001590 RID: 5520 RVA: 0x00077760 File Offset: 0x00075960
	[Token(Token = "0x6001590")]
	[Address(RVA = "0x48F370", Offset = "0x48D970", VA = "0x18048F370", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.zombieLayer;
		int attackDamage = this.attackDamage;
		bool flag;
		if (flag)
		{
		}
		int num3 = 0;
		int num4 = 0;
		Collider2D[] array;
		if (num4 < array.Length)
		{
			bool flag2;
			if (flag2)
			{
				int num5 = this.currentLightLevel;
				PlantType thePlantType = this.thePlantType;
				num5++;
			}
			num3++;
		}
		if (num != 0)
		{
			uint num6;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num6), 0.5f, 1f);
			ParticleManager instance = ParticleManager.Instance;
		}
		base.AttributeCountdown = 3f;
	}

	// Token: 0x06001591 RID: 5521 RVA: 0x00077808 File Offset: 0x00075A08
	[Token(Token = "0x6001591")]
	[Address(RVA = "0x48F760", Offset = "0x48DD60", VA = "0x18048F760", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason != Plant.DieReason.ByMix)
		{
			Board board = this.board;
			Transform axis = this.axis;
			BoardAction boardAction = board.boardAction;
			if (!Lawnf.TravelUltimate((UltiBuff)((uint)10)))
			{
				Action action = new Action(this.ResetLightLevel2);
			}
			DelayAction delayAction = GameAPP.delayAction;
			Action action2 = new Action(this.ResetLightLevel2);
			delayAction.SetAction(action2, 10f);
			this.board.AddLightLevel(30);
		}
	}

	// Token: 0x06001592 RID: 5522 RVA: 0x00077880 File Offset: 0x00075A80
	[Token(Token = "0x6001592")]
	[Address(RVA = "0x48FDF0", Offset = "0x48E3F0", VA = "0x18048FDF0")]
	private void ResetLightLevel1()
	{
		Board board = this.board;
		int num = 0;
		if (board != num)
		{
			this.board.AddLightLevel(-10);
		}
	}

	// Token: 0x06001593 RID: 5523 RVA: 0x000778B4 File Offset: 0x00075AB4
	[Token(Token = "0x6001593")]
	[Address(RVA = "0x48FE70", Offset = "0x48E470", VA = "0x18048FE70")]
	private void ResetLightLevel2()
	{
		Board board = this.board;
		int num = 0;
		if (board != num)
		{
			this.board.AddLightLevel(-30);
		}
	}

	// Token: 0x06001594 RID: 5524 RVA: 0x000778E8 File Offset: 0x00075AE8
	[Token(Token = "0x6001594")]
	[Address(RVA = "0x48F9B0", Offset = "0x48DFB0", VA = "0x18048F9B0", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001595 RID: 5525 RVA: 0x00077908 File Offset: 0x00075B08
	[Token(Token = "0x6001595")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public UltimatePlantern()
	{
	}

	// Token: 0x04000D2A RID: 3370
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000D2A")]
	public GameObject laserPrefab;

	// Token: 0x04000D2B RID: 3371
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000D2B")]
	public SpriteRenderer ultimateLight;
}
