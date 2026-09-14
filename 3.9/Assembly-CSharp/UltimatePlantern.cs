using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020004A6 RID: 1190
[Token(Token = "0x20004A6")]
public class UltimatePlantern : Plantern
{
	// Token: 0x0600162B RID: 5675 RVA: 0x00079F54 File Offset: 0x00078154
	[Token(Token = "0x600162B")]
	[Address(RVA = "0x4E8C40", Offset = "0x4E7240", VA = "0x1804E8C40", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 3f;
		SortingGroup sortingGroup = this.ultimateLight.AddComponent<SortingGroup>();
		sortingGroup.sortAtRoot = true;
		sortingGroup.sortingLayerName = "particle11";
	}

	// Token: 0x0600162C RID: 5676 RVA: 0x00079F98 File Offset: 0x00078198
	[Token(Token = "0x600162C")]
	[Address(RVA = "0x4E9530", Offset = "0x4E7B30", VA = "0x1804E9530", Slot = "15")]
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

	// Token: 0x0600162D RID: 5677 RVA: 0x00079FF4 File Offset: 0x000781F4
	[Token(Token = "0x600162D")]
	[Address(RVA = "0x4E9470", Offset = "0x4E7A70", VA = "0x1804E9470")]
	private void Shrink()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x0600162E RID: 5678 RVA: 0x0007A018 File Offset: 0x00078218
	[Token(Token = "0x600162E")]
	[Address(RVA = "0x4E9000", Offset = "0x4E7600", VA = "0x1804E9000")]
	public void OnSuperCharge()
	{
		SpriteRenderer spriteRenderer = this.ultimateLight;
		int num = 0;
		spriteRenderer.enabled = num != 0;
	}

	// Token: 0x0600162F RID: 5679 RVA: 0x0007A0B0 File Offset: 0x000782B0
	[Token(Token = "0x600162F")]
	[Address(RVA = "0x4E8EA0", Offset = "0x4E74A0", VA = "0x1804E8EA0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.Active)
		{
			this.AttributeEvent();
			this.OnSuperCharge();
		}
	}

	// Token: 0x06001630 RID: 5680 RVA: 0x0007A0DC File Offset: 0x000782DC
	[Token(Token = "0x6001630")]
	[Address(RVA = "0x4E88F0", Offset = "0x4E6EF0", VA = "0x1804E88F0", Slot = "39")]
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

	// Token: 0x06001631 RID: 5681 RVA: 0x0007A184 File Offset: 0x00078384
	[Token(Token = "0x6001631")]
	[Address(RVA = "0x4E8CE0", Offset = "0x4E72E0", VA = "0x1804E8CE0", Slot = "51")]
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

	// Token: 0x06001632 RID: 5682 RVA: 0x0007A1FC File Offset: 0x000783FC
	[Token(Token = "0x6001632")]
	[Address(RVA = "0x4E9370", Offset = "0x4E7970", VA = "0x1804E9370")]
	private void ResetLightLevel1()
	{
		Board board = this.board;
		int num = 0;
		if (board != num)
		{
			this.board.AddLightLevel(-10);
		}
	}

	// Token: 0x06001633 RID: 5683 RVA: 0x0007A230 File Offset: 0x00078430
	[Token(Token = "0x6001633")]
	[Address(RVA = "0x4E93F0", Offset = "0x4E79F0", VA = "0x1804E93F0")]
	private void ResetLightLevel2()
	{
		Board board = this.board;
		int num = 0;
		if (board != num)
		{
			this.board.AddLightLevel(-30);
		}
	}

	// Token: 0x06001634 RID: 5684 RVA: 0x0007A264 File Offset: 0x00078464
	[Token(Token = "0x6001634")]
	[Address(RVA = "0x4E8F30", Offset = "0x4E7530", VA = "0x1804E8F30", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001635 RID: 5685 RVA: 0x0007A284 File Offset: 0x00078484
	[Token(Token = "0x6001635")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public UltimatePlantern()
	{
	}

	// Token: 0x04000DC3 RID: 3523
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000DC3")]
	public GameObject laserPrefab;

	// Token: 0x04000DC4 RID: 3524
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000DC4")]
	public SpriteRenderer ultimateLight;
}
