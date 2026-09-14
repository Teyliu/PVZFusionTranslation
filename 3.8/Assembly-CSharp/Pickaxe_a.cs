using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020006B2 RID: 1714
[Token(Token = "0x20006B2")]
public class Pickaxe_a : Zombie
{
	// Token: 0x06002176 RID: 8566 RVA: 0x000B05CC File Offset: 0x000AE7CC
	[Token(Token = "0x6002176")]
	[Address(RVA = "0x565910", Offset = "0x563F10", VA = "0x180565910", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		SortingGroup component = this.progressText.GetComponent<SortingGroup>();
		this.textGroup = component;
		this.textGroup.sortAtRoot = true;
		GameObject gameObject = this.progressText.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x06002177 RID: 8567 RVA: 0x000B061C File Offset: 0x000AE81C
	[Token(Token = "0x6002177")]
	[Address(RVA = "0x565A10", Offset = "0x564010", VA = "0x180565A10", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06002178 RID: 8568 RVA: 0x000B065C File Offset: 0x000AE85C
	[Token(Token = "0x6002178")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06002179 RID: 8569 RVA: 0x000B066C File Offset: 0x000AE86C
	[Token(Token = "0x6002179")]
	[Address(RVA = "0x565AB0", Offset = "0x5640B0", VA = "0x180565AB0", Slot = "18")]
	protected override void ZombieUpdate()
	{
		IDamageable theAttackTarget = this.theAttackTarget;
		bool flag;
		if (flag)
		{
			float num = this.digSpeed;
			float deltaTime = Time.deltaTime;
			this.progress = deltaTime;
			this.progress = 0f;
			GameObject gameObject = this.progressText.gameObject;
			gameObject.SetActive(true);
			SortingGroup sortingGroup = this.textGroup;
			string text = string.Format("bullet{0}", gameObject);
			sortingGroup.sortingLayerName = text;
			float num2 = this.progress * 100f;
			TextMeshPro textMeshPro = this.progressText;
			string text2 = string.Format("{0:F0}%", text);
			textMeshPro.text = text2;
			GameObject gameObject2 = this.progressText.gameObject;
			Transform transform = gameObject2.transform;
			int num3 = 0;
			Vector3 vector;
			float z = vector.z;
			if (this.progress > (float)num3)
			{
				this.CancelAttack();
			}
		}
	}

	// Token: 0x0600217A RID: 8570 RVA: 0x000B0748 File Offset: 0x000AE948
	[Token(Token = "0x600217A")]
	[Address(RVA = "0x5659C0", Offset = "0x563FC0", VA = "0x1805659C0", Slot = "42")]
	protected override void CancelAttack()
	{
		base.CancelAttack();
		TextMeshPro textMeshPro = this.progressText;
		this.progress = 0f;
		GameObject gameObject = textMeshPro.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x0600217B RID: 8571 RVA: 0x000B0784 File Offset: 0x000AE984
	[Token(Token = "0x600217B")]
	[Address(RVA = "0x565DD0", Offset = "0x5643D0", VA = "0x180565DD0")]
	public Pickaxe_a()
	{
	}

	// Token: 0x0400110D RID: 4365
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400110D")]
	public TextMeshPro progressText;

	// Token: 0x0400110E RID: 4366
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400110E")]
	protected SortingGroup textGroup;

	// Token: 0x0400110F RID: 4367
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x400110F")]
	protected float progress;

	// Token: 0x04001110 RID: 4368
	[FieldOffset(Offset = "0x26C")]
	[Token(Token = "0x4001110")]
	protected float digSpeed = 40f;
}
