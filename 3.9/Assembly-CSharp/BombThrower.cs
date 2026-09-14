using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000669 RID: 1641
[Token(Token = "0x2000669")]
public class BombThrower : KirovAirship
{
	// Token: 0x17000199 RID: 409
	// (get) Token: 0x06001F16 RID: 7958 RVA: 0x000A548C File Offset: 0x000A368C
	[Token(Token = "0x17000199")]
	public override float CrashNeedCount
	{
		[Token(Token = "0x6001F16")]
		[Address(RVA = "0x58AE00", Offset = "0x589400", VA = "0x18058AE00", Slot = "80")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06001F17 RID: 7959 RVA: 0x000A54A0 File Offset: 0x000A36A0
	[Token(Token = "0x6001F17")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "81")]
	protected override void PlayMachineSound()
	{
	}

	// Token: 0x06001F18 RID: 7960 RVA: 0x000A54B0 File Offset: 0x000A36B0
	[Token(Token = "0x6001F18")]
	[Address(RVA = "0x58AAD0", Offset = "0x5890D0", VA = "0x18058AAD0", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
	}

	// Token: 0x06001F19 RID: 7961 RVA: 0x000A54C0 File Offset: 0x000A36C0
	[Token(Token = "0x6001F19")]
	[Address(RVA = "0x58AAE0", Offset = "0x5890E0", VA = "0x18058AAE0", Slot = "83")]
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

	// Token: 0x06001F1A RID: 7962 RVA: 0x000A5564 File Offset: 0x000A3764
	[Token(Token = "0x6001F1A")]
	[Address(RVA = "0x58AD90", Offset = "0x589390", VA = "0x18058AD90", Slot = "21")]
	protected override void MoveUpdate()
	{
		Rigidbody2D rb = this.rb;
		float theSpeed = this.theSpeed;
	}

	// Token: 0x06001F1B RID: 7963 RVA: 0x000A5588 File Offset: 0x000A3788
	[Token(Token = "0x6001F1B")]
	[Address(RVA = "0x58ADF0", Offset = "0x5893F0", VA = "0x18058ADF0")]
	public BombThrower()
	{
	}

	// Token: 0x04001106 RID: 4358
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001106")]
	public GameObject patels1;

	// Token: 0x04001107 RID: 4359
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4001107")]
	public GameObject patels2;
}
