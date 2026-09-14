using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020006B0 RID: 1712
[Token(Token = "0x20006B0")]
public class PickaxeZombie : ConeZombie
{
	// Token: 0x0600216F RID: 8559 RVA: 0x000B02DC File Offset: 0x000AE4DC
	[Token(Token = "0x600216F")]
	[Address(RVA = "0x5651F0", Offset = "0x5637F0", VA = "0x1805651F0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		uint num2;
		int num = global::UnityEngine.Random.Range(0, (int)num2);
		Transform transform = this.pickaxe;
		int num3 = 0;
		int childCount = transform.childCount;
		if (num3 < childCount)
		{
			Transform child = this.pickaxe.GetChild(num3);
			if (num3 != num)
			{
				GameObject gameObject = child.gameObject;
				int num4 = 0;
				gameObject.SetActive(num4 != 0);
				GameObject gameObject2 = this.hat.GetChild(num3).gameObject;
				int num5 = 0;
				gameObject2.SetActive(num5 != 0);
			}
			ulong num6;
			child.gameObject.SetActive(num6 != 0UL);
			ulong num7;
			this.hat.GetChild(num3).gameObject.SetActive(num7 != 0UL);
			GameObject gameObject3 = this.hat.GetChild(num3).gameObject;
			this.theFirstArmor = gameObject3;
			Transform transform2 = this.pickaxe;
			num3++;
		}
		SortingGroup component = this.progressText.GetComponent<SortingGroup>();
		this.textGroup = component;
		ulong num8;
		this.textGroup.sortAtRoot = num8 != 0UL;
		GameObject gameObject4 = this.progressText.gameObject;
		int num9 = 0;
		gameObject4.SetActive(num9 != 0);
		this.pickaxeType = (PickaxeZombie.PickaxeType)num;
		if (num != 0 && num != 0)
		{
			if (num == 1)
			{
				this.digSpeed = 10f;
			}
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002170 RID: 8560 RVA: 0x000B0404 File Offset: 0x000AE604
	[Token(Token = "0x6002170")]
	[Address(RVA = "0x5654C0", Offset = "0x563AC0", VA = "0x1805654C0", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06002171 RID: 8561 RVA: 0x000B0444 File Offset: 0x000AE644
	[Token(Token = "0x6002171")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06002172 RID: 8562 RVA: 0x000B0454 File Offset: 0x000AE654
	[Token(Token = "0x6002172")]
	[Address(RVA = "0x5655B0", Offset = "0x563BB0", VA = "0x1805655B0", Slot = "18")]
	protected override void ZombieUpdate()
	{
		IDamageable theAttackTarget = this.theAttackTarget;
		PickaxeZombie.PickaxeType pickaxeType = this.pickaxeType;
		if (pickaxeType != PickaxeZombie.PickaxeType.Iron && pickaxeType != PickaxeZombie.PickaxeType.Iron)
		{
			if (pickaxeType != PickaxeZombie.PickaxeType.Gold)
			{
				goto IL_0030;
			}
			float deltaTime = Time.deltaTime;
		}
		while (typeof(Plant).TypeHandle <= (ulong)16000L)
		{
		}
		IL_0030:
		int num = 0;
		this.progress = (float)num;
		GameObject gameObject = this.progressText.gameObject;
		ulong num2;
		gameObject.SetActive(num2 != 0UL);
		SortingGroup sortingGroup = this.textGroup;
		string text = string.Format("bullet{0}", gameObject);
		sortingGroup.sortingLayerName = text;
		float num3 = this.progress * 100f;
		TextMeshPro textMeshPro = this.progressText;
		string text2 = string.Format("{0:F0}%", text);
		textMeshPro.text = text2;
		GameObject gameObject2 = this.progressText.gameObject;
		Transform transform = gameObject2.transform;
		Vector3 vector;
		float y = vector.y;
		float z = vector.z;
		if (this.progress > y)
		{
			this.CancelAttack();
		}
	}

	// Token: 0x06002173 RID: 8563 RVA: 0x000B0540 File Offset: 0x000AE740
	[Token(Token = "0x6002173")]
	[Address(RVA = "0x565560", Offset = "0x563B60", VA = "0x180565560")]
	private float GetLevelSpeed(int health)
	{
		PickaxeZombie.PickaxeType pickaxeType = this.pickaxeType;
		if (pickaxeType != PickaxeZombie.PickaxeType.Iron && pickaxeType != PickaxeZombie.PickaxeType.Iron && pickaxeType != PickaxeZombie.PickaxeType.Gold)
		{
			return 0f;
		}
		if (health > 16000)
		{
			return 0f;
		}
		return 0f;
	}

	// Token: 0x06002174 RID: 8564 RVA: 0x000B057C File Offset: 0x000AE77C
	[Token(Token = "0x6002174")]
	[Address(RVA = "0x565470", Offset = "0x563A70", VA = "0x180565470", Slot = "42")]
	protected override void CancelAttack()
	{
		base.CancelAttack();
		TextMeshPro textMeshPro = this.progressText;
		this.progress = 0f;
		GameObject gameObject = textMeshPro.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x06002175 RID: 8565 RVA: 0x000B05B8 File Offset: 0x000AE7B8
	[Token(Token = "0x6002175")]
	[Address(RVA = "0x55BE80", Offset = "0x55A480", VA = "0x18055BE80")]
	public PickaxeZombie()
	{
	}

	// Token: 0x04001102 RID: 4354
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001102")]
	public Transform pickaxe;

	// Token: 0x04001103 RID: 4355
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4001103")]
	public Transform hat;

	// Token: 0x04001104 RID: 4356
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4001104")]
	public TextMeshPro progressText;

	// Token: 0x04001105 RID: 4357
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4001105")]
	private SortingGroup textGroup;

	// Token: 0x04001106 RID: 4358
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001106")]
	private PickaxeZombie.PickaxeType pickaxeType;

	// Token: 0x04001107 RID: 4359
	[FieldOffset(Offset = "0x27C")]
	[Token(Token = "0x4001107")]
	private float digSpeed;

	// Token: 0x04001108 RID: 4360
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001108")]
	private float progress;

	// Token: 0x020006B1 RID: 1713
	[Token(Token = "0x20006B1")]
	private enum PickaxeType
	{
		// Token: 0x0400110A RID: 4362
		[Token(Token = "0x400110A")]
		Iron,
		// Token: 0x0400110B RID: 4363
		[Token(Token = "0x400110B")]
		Gold,
		// Token: 0x0400110C RID: 4364
		[Token(Token = "0x400110C")]
		Diamond
	}
}
