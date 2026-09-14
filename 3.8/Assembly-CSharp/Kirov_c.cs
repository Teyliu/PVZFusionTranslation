using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000696 RID: 1686
[Token(Token = "0x2000696")]
public class Kirov_c : Kirov_b
{
	// Token: 0x17000163 RID: 355
	// (get) Token: 0x060020A6 RID: 8358 RVA: 0x000ACAF8 File Offset: 0x000AACF8
	[Token(Token = "0x17000163")]
	public override float CrashNeedCount
	{
		[Token(Token = "0x60020A6")]
		[Address(RVA = "0x55B190", Offset = "0x559790", VA = "0x18055B190", Slot = "78")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060020A7 RID: 8359 RVA: 0x000ACB0C File Offset: 0x000AAD0C
	[Token(Token = "0x60020A7")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "23")]
	protected override void AttributeEvent()
	{
	}

	// Token: 0x060020A8 RID: 8360 RVA: 0x000ACB1C File Offset: 0x000AAD1C
	[Token(Token = "0x60020A8")]
	[Address(RVA = "0x55AE50", Offset = "0x559450", VA = "0x18055AE50")]
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

	// Token: 0x060020A9 RID: 8361 RVA: 0x000ACC60 File Offset: 0x000AAE60
	[Token(Token = "0x60020A9")]
	[Address(RVA = "0x55AB10", Offset = "0x559110", VA = "0x18055AB10")]
	public Kirov_c()
	{
	}

	// Token: 0x040010D8 RID: 4312
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x40010D8")]
	public Transform shoot2;

	// Token: 0x040010D9 RID: 4313
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x40010D9")]
	public GameObject bombPrefab;
}
