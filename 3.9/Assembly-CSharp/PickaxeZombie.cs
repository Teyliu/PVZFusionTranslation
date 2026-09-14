using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020006E7 RID: 1767
[Token(Token = "0x20006E7")]
public class PickaxeZombie : ConeZombie
{
	// Token: 0x06002286 RID: 8838 RVA: 0x000B4F8C File Offset: 0x000B318C
	[Token(Token = "0x6002286")]
	[Address(RVA = "0x5C8AA0", Offset = "0x5C70A0", VA = "0x1805C8AA0", Slot = "10")]
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

	// Token: 0x06002287 RID: 8839 RVA: 0x000B50B4 File Offset: 0x000B32B4
	[Token(Token = "0x6002287")]
	[Address(RVA = "0x5C8D70", Offset = "0x5C7370", VA = "0x1805C8D70", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06002288 RID: 8840 RVA: 0x000B50F4 File Offset: 0x000B32F4
	[Token(Token = "0x6002288")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06002289 RID: 8841 RVA: 0x000B5104 File Offset: 0x000B3304
	[Token(Token = "0x6002289")]
	[Address(RVA = "0x5C8E60", Offset = "0x5C7460", VA = "0x1805C8E60", Slot = "19")]
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

	// Token: 0x0600228A RID: 8842 RVA: 0x000B51F0 File Offset: 0x000B33F0
	[Token(Token = "0x600228A")]
	[Address(RVA = "0x5C8E10", Offset = "0x5C7410", VA = "0x1805C8E10")]
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

	// Token: 0x0600228B RID: 8843 RVA: 0x000B522C File Offset: 0x000B342C
	[Token(Token = "0x600228B")]
	[Address(RVA = "0x5C8D20", Offset = "0x5C7320", VA = "0x1805C8D20", Slot = "44")]
	protected override void CancelAttack()
	{
		base.CancelAttack();
		TextMeshPro textMeshPro = this.progressText;
		this.progress = 0f;
		GameObject gameObject = textMeshPro.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x0600228C RID: 8844 RVA: 0x000B5268 File Offset: 0x000B3468
	[Token(Token = "0x600228C")]
	[Address(RVA = "0x58B130", Offset = "0x589730", VA = "0x18058B130")]
	public PickaxeZombie()
	{
	}

	// Token: 0x040011CF RID: 4559
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40011CF")]
	public Transform pickaxe;

	// Token: 0x040011D0 RID: 4560
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40011D0")]
	public Transform hat;

	// Token: 0x040011D1 RID: 4561
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x40011D1")]
	public TextMeshPro progressText;

	// Token: 0x040011D2 RID: 4562
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x40011D2")]
	private SortingGroup textGroup;

	// Token: 0x040011D3 RID: 4563
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x40011D3")]
	private PickaxeZombie.PickaxeType pickaxeType;

	// Token: 0x040011D4 RID: 4564
	[FieldOffset(Offset = "0x29C")]
	[Token(Token = "0x40011D4")]
	private float digSpeed;

	// Token: 0x040011D5 RID: 4565
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x40011D5")]
	private float progress;

	// Token: 0x020006E8 RID: 1768
	[Token(Token = "0x20006E8")]
	private enum PickaxeType
	{
		// Token: 0x040011D7 RID: 4567
		[Token(Token = "0x40011D7")]
		Iron,
		// Token: 0x040011D8 RID: 4568
		[Token(Token = "0x40011D8")]
		Gold,
		// Token: 0x040011D9 RID: 4569
		[Token(Token = "0x40011D9")]
		Diamond
	}
}
