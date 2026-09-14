using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006CD RID: 1741
[Token(Token = "0x20006CD")]
public class Kirov_c : Kirov_b
{
	// Token: 0x170001A9 RID: 425
	// (get) Token: 0x060021BD RID: 8637 RVA: 0x000B1740 File Offset: 0x000AF940
	[Token(Token = "0x170001A9")]
	public override float CrashNeedCount
	{
		[Token(Token = "0x60021BD")]
		[Address(RVA = "0x5BDEE0", Offset = "0x5BC4E0", VA = "0x1805BDEE0", Slot = "80")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060021BE RID: 8638 RVA: 0x000B1754 File Offset: 0x000AF954
	[Token(Token = "0x60021BE")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "24")]
	protected override void AttributeEvent()
	{
	}

	// Token: 0x060021BF RID: 8639 RVA: 0x000B1764 File Offset: 0x000AF964
	[Token(Token = "0x60021BF")]
	[Address(RVA = "0x5BDBA0", Offset = "0x5BC1A0", VA = "0x1805BDBA0")]
	private void AnimShoot()
	{
		Transform shoot = this.shoot;
		GameObject gameObject = this.bombPrefab;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		KirovBomb kirovBomb = gameObject2.AddComponent<KirovBomb>();
		int theZombieRow = this.theZombieRow;
		int num = 0;
		kirovBomb.bombRow = theZombieRow;
		bool isMindControlled = this.isMindControlled;
		kirovBomb.fromHypno = isMindControlled;
		kirovBomb.bombDamage = (int)((ulong)300L);
		kirovBomb.damageType = (DamageType)num;
		SpriteRenderer component = gameObject2.GetComponent<SpriteRenderer>();
		int theZombieRow2 = this.theZombieRow;
		string text = string.Format("bullet{0}", component);
		component.sortingLayerName = text;
		Transform transform2 = this.shoot2;
		GameObject gameObject3 = this.bombPrefab;
		Vector3 vector2;
		float z2 = vector2.z;
		Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
		Transform transform3 = this.board.transform;
		GameObject gameObject4;
		KirovBomb kirovBomb2 = gameObject4.AddComponent<KirovBomb>();
		int theZombieRow3 = this.theZombieRow;
		kirovBomb2.bombRow = theZombieRow3;
		bool isMindControlled2 = this.isMindControlled;
		kirovBomb2.fromHypno = isMindControlled2;
		kirovBomb2.bombDamage = (int)((ulong)300L);
		kirovBomb2.damageType = (DamageType)num;
		SpriteRenderer component2 = gameObject4.GetComponent<SpriteRenderer>();
		int theZombieRow4 = this.theZombieRow;
		string text2 = string.Format("bullet{0}", component2);
		component2.sortingLayerName = text2;
	}

	// Token: 0x060021C0 RID: 8640 RVA: 0x000B18A8 File Offset: 0x000AFAA8
	[Token(Token = "0x60021C0")]
	[Address(RVA = "0x5BD850", Offset = "0x5BBE50", VA = "0x1805BD850")]
	public Kirov_c()
	{
	}

	// Token: 0x040011A5 RID: 4517
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40011A5")]
	public Transform shoot2;

	// Token: 0x040011A6 RID: 4518
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x40011A6")]
	public GameObject bombPrefab;
}
