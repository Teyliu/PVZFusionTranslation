using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000633 RID: 1587
[Token(Token = "0x2000633")]
public class BombThrower : KirovAirship
{
	// Token: 0x17000153 RID: 339
	// (get) Token: 0x06001E14 RID: 7700 RVA: 0x000A0D3C File Offset: 0x0009EF3C
	[Token(Token = "0x17000153")]
	public override float CrashNeedCount
	{
		[Token(Token = "0x6001E14")]
		[Address(RVA = "0x534120", Offset = "0x532720", VA = "0x180534120", Slot = "78")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06001E15 RID: 7701 RVA: 0x000A0D50 File Offset: 0x0009EF50
	[Token(Token = "0x6001E15")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "79")]
	protected override void PlayMachineSound()
	{
	}

	// Token: 0x06001E16 RID: 7702 RVA: 0x000A0D60 File Offset: 0x0009EF60
	[Token(Token = "0x6001E16")]
	[Address(RVA = "0x533DF0", Offset = "0x5323F0", VA = "0x180533DF0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
	}

	// Token: 0x06001E17 RID: 7703 RVA: 0x000A0D70 File Offset: 0x0009EF70
	[Token(Token = "0x6001E17")]
	[Address(RVA = "0x533E00", Offset = "0x532400", VA = "0x180533E00", Slot = "81")]
	protected override void CreateBomb()
	{
		GameObject gameObject = GameAPP.itemPrefab[14];
		Transform transform = base.transform.Find("Superbomb_1").transform;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform2 = this.board.transform;
		GameObject gameObject2;
		KirovBomb kirovBomb = gameObject2.AddComponent<KirovBomb>();
		int theZombieRow = this.theZombieRow;
		kirovBomb.bombRow = theZombieRow;
		SpriteRenderer component = gameObject2.GetComponent<SpriteRenderer>();
		int theZombieRow2 = this.theZombieRow;
		string text = string.Format("bullet{0}", component);
		component.sortingLayerName = text;
		gameObject2.GetComponent<KirovBomb>().fromHypno = true;
	}

	// Token: 0x06001E18 RID: 7704 RVA: 0x000A0E14 File Offset: 0x0009F014
	[Token(Token = "0x6001E18")]
	[Address(RVA = "0x5340B0", Offset = "0x5326B0", VA = "0x1805340B0", Slot = "20")]
	protected override void MoveUpdate()
	{
		Rigidbody2D rb = this.rb;
		float theSpeed = this.theSpeed;
	}

	// Token: 0x06001E19 RID: 7705 RVA: 0x000A0E38 File Offset: 0x0009F038
	[Token(Token = "0x6001E19")]
	[Address(RVA = "0x534110", Offset = "0x532710", VA = "0x180534110")]
	public BombThrower()
	{
	}

	// Token: 0x0400103A RID: 4154
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400103A")]
	public GameObject patels1;

	// Token: 0x0400103B RID: 4155
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x400103B")]
	public GameObject patels2;
}
