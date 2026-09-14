using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006CF RID: 1743
[Token(Token = "0x20006CF")]
public class SubmarineZombie : Zombie
{
	// Token: 0x06002251 RID: 8785 RVA: 0x000B40BC File Offset: 0x000B22BC
	[Token(Token = "0x6002251")]
	[Address(RVA = "0x572690", Offset = "0x570C90", VA = "0x180572690", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.inWater = true;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		this.startPos.z = z;
		Vector3 vector2 = this.startPos;
		float z2 = this.startPos.z;
		this.startPos.z = z2;
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)4)))
		{
			float theOriginSpeed = this.theOriginSpeed;
			this.theOriginSpeed = theOriginSpeed;
		}
	}

	// Token: 0x06002252 RID: 8786 RVA: 0x000B4134 File Offset: 0x000B2334
	[Token(Token = "0x6002252")]
	[Address(RVA = "0x5725E0", Offset = "0x570BE0", VA = "0x1805725E0", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix = false, PlantType fromType = PlantType.Nothing)
	{
		bool flag;
		if (!flag || !fix)
		{
		}
		int num;
		return num;
	}

	// Token: 0x06002253 RID: 8787 RVA: 0x000B4150 File Offset: 0x000B2350
	[Token(Token = "0x6002253")]
	[Address(RVA = "0x572750", Offset = "0x570D50", VA = "0x180572750", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (Lawnf.EveBalaced())
		{
			Transform transform = base.transform;
			float z = this.startPos.z;
		}
	}

	// Token: 0x06002254 RID: 8788 RVA: 0x000B4188 File Offset: 0x000B2388
	[Token(Token = "0x6002254")]
	[Address(RVA = "0x571E20", Offset = "0x570420", VA = "0x180571E20", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		int num = this.theHealth;
		num -= theDamage;
		this.theHealth = num;
		int num2 = this.theMaxHealth;
		num2 += num2;
		Transform transform = base.transform;
		int num3 = 0;
		ulong num4;
		transform.GetChild(num3).gameObject.SetActive(num4 != 0UL);
		uint num5;
		GameObject gameObject = base.transform.GetChild((int)num5).gameObject;
		int num6 = 0;
		gameObject.SetActive(num6 != 0);
		uint num7;
		GameObject gameObject2 = base.transform.GetChild((int)num7).gameObject;
		int num8 = 0;
		gameObject2.SetActive(num8 != 0);
		uint num9;
		ulong num10;
		base.transform.GetChild((int)num9).gameObject.SetActive(num10 != 0UL);
		uint num11;
		GameObject gameObject3 = base.transform.GetChild((int)num11).gameObject;
		int num12 = 0;
		gameObject3.SetActive(num12 != 0);
		uint num13;
		GameObject gameObject4 = base.transform.GetChild((int)num13).gameObject;
		int num14 = 0;
		gameObject4.SetActive(num14 != 0);
		int num15 = this.theMaxHealth;
		num15 += num15;
		Transform transform2 = base.transform;
		int num16 = 0;
		GameObject gameObject5 = transform2.GetChild(num16).gameObject;
		int num17 = 0;
		gameObject5.SetActive(num17 != 0);
		uint num18;
		ulong num19;
		base.transform.GetChild((int)num18).gameObject.SetActive(num19 != 0UL);
		uint num20;
		GameObject gameObject6 = base.transform.GetChild((int)num20).gameObject;
		int num21 = 0;
		gameObject6.SetActive(num21 != 0);
		uint num22;
		GameObject gameObject7 = base.transform.GetChild((int)num22).gameObject;
		int num23 = 0;
		gameObject7.SetActive(num23 != 0);
		uint num24;
		ulong num25;
		base.transform.GetChild((int)num24).gameObject.SetActive(num25 != 0UL);
		uint num26;
		GameObject gameObject8 = base.transform.GetChild((int)num26).gameObject;
		int num27 = 0;
		gameObject8.SetActive(num27 != 0);
		Transform transform3 = base.transform;
		int num28 = 0;
		GameObject gameObject9 = transform3.GetChild(num28).gameObject;
		int num29 = 0;
		gameObject9.SetActive(num29 != 0);
		uint num30;
		GameObject gameObject10 = base.transform.GetChild((int)num30).gameObject;
		int num31 = 0;
		gameObject10.SetActive(num31 != 0);
		uint num32;
		ulong num33;
		base.transform.GetChild((int)num32).gameObject.SetActive(num33 != 0UL);
		uint num34;
		GameObject gameObject11 = base.transform.GetChild((int)num34).gameObject;
		int num35 = 0;
		gameObject11.SetActive(num35 != 0);
		uint num36;
		GameObject gameObject12 = base.transform.GetChild((int)num36).gameObject;
		int num37 = 0;
		gameObject12.SetActive(num37 != 0);
		uint num38;
		ulong num39;
		base.transform.GetChild((int)num38).gameObject.SetActive(num39 != 0UL);
	}

	// Token: 0x06002255 RID: 8789 RVA: 0x000B43F0 File Offset: 0x000B25F0
	[Token(Token = "0x6002255")]
	[Address(RVA = "0x572420", Offset = "0x570A20", VA = "0x180572420", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[34];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
	}

	// Token: 0x06002256 RID: 8790 RVA: 0x000B4448 File Offset: 0x000B2648
	[Token(Token = "0x6002256")]
	[Address(RVA = "0x572660", Offset = "0x570C60", VA = "0x180572660")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		Plant plant = base.CrashEntity(collision, true, 1f);
	}

	// Token: 0x06002257 RID: 8791 RVA: 0x000B4464 File Offset: 0x000B2664
	[Token(Token = "0x6002257")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002258 RID: 8792 RVA: 0x000B4474 File Offset: 0x000B2674
	[Token(Token = "0x6002258")]
	[Address(RVA = "0x537D20", Offset = "0x536320", VA = "0x180537D20", Slot = "27")]
	public override void Die(int reason = 0)
	{
		base.Die(reason);
	}

	// Token: 0x06002259 RID: 8793 RVA: 0x000B4488 File Offset: 0x000B2688
	[Token(Token = "0x6002259")]
	[Address(RVA = "0x5727C0", Offset = "0x570DC0", VA = "0x1805727C0")]
	public SubmarineZombie()
	{
	}

	// Token: 0x04001133 RID: 4403
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001133")]
	private Vector3 startPos;
}
