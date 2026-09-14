using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020006E9 RID: 1769
[Token(Token = "0x20006E9")]
public class Pickaxe_a : Zombie
{
	// Token: 0x0600228D RID: 8845 RVA: 0x000B527C File Offset: 0x000B347C
	[Token(Token = "0x600228D")]
	[Address(RVA = "0x5C91C0", Offset = "0x5C77C0", VA = "0x1805C91C0", Slot = "10")]
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

	// Token: 0x0600228E RID: 8846 RVA: 0x000B52CC File Offset: 0x000B34CC
	[Token(Token = "0x600228E")]
	[Address(RVA = "0x5C92C0", Offset = "0x5C78C0", VA = "0x1805C92C0", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x0600228F RID: 8847 RVA: 0x000B530C File Offset: 0x000B350C
	[Token(Token = "0x600228F")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06002290 RID: 8848 RVA: 0x000B531C File Offset: 0x000B351C
	[Token(Token = "0x6002290")]
	[Address(RVA = "0x5C9360", Offset = "0x5C7960", VA = "0x1805C9360", Slot = "19")]
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

	// Token: 0x06002291 RID: 8849 RVA: 0x000B53F8 File Offset: 0x000B35F8
	[Token(Token = "0x6002291")]
	[Address(RVA = "0x5C9270", Offset = "0x5C7870", VA = "0x1805C9270", Slot = "44")]
	protected override void CancelAttack()
	{
		base.CancelAttack();
		TextMeshPro textMeshPro = this.progressText;
		this.progress = 0f;
		GameObject gameObject = textMeshPro.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x06002292 RID: 8850 RVA: 0x000B5434 File Offset: 0x000B3634
	[Token(Token = "0x6002292")]
	[Address(RVA = "0x5C9680", Offset = "0x5C7C80", VA = "0x1805C9680")]
	public Pickaxe_a()
	{
	}

	// Token: 0x040011DA RID: 4570
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40011DA")]
	public TextMeshPro progressText;

	// Token: 0x040011DB RID: 4571
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40011DB")]
	protected SortingGroup textGroup;

	// Token: 0x040011DC RID: 4572
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x40011DC")]
	protected float progress;

	// Token: 0x040011DD RID: 4573
	[FieldOffset(Offset = "0x28C")]
	[Token(Token = "0x40011DD")]
	protected float digSpeed = 40f;
}
