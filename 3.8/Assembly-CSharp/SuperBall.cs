using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006D7 RID: 1751
[Token(Token = "0x20006D7")]
public class SuperBall : MonoBehaviour
{
	// Token: 0x06002280 RID: 8832 RVA: 0x000B4C48 File Offset: 0x000B2E48
	[Token(Token = "0x6002280")]
	[Address(RVA = "0x5740D0", Offset = "0x5726D0", VA = "0x1805740D0")]
	private void Awake()
	{
		this.velocity = (ulong)3225419776L;
		this.velocity.y = 2f;
	}

	// Token: 0x06002281 RID: 8833 RVA: 0x000B4C78 File Offset: 0x000B2E78
	[Token(Token = "0x6002281")]
	[Address(RVA = "0x5740E0", Offset = "0x5726E0", VA = "0x1805740E0")]
	private void Update()
	{
		float y = this.velocity.y;
		float deltaTime = Time.deltaTime;
		Vector2 vector = this.velocity;
		this.velocity = vector;
		this.velocity.y = y;
		Transform transform = base.transform;
		float deltaTime2 = Time.deltaTime;
		Transform transform2 = base.transform;
		Vector3 vector2;
		float y2 = vector2.y;
		Mouse instance = Mouse.Instance;
		Transform transform3 = base.transform;
		float num;
		if (num > y2)
		{
			Transform transform4 = base.transform;
			Vector3 vector3;
			float z = vector3.z;
			ScreenShake.TriggerShake(0.05f);
			GameAPP.PlaySound(43, 0.5f, 1f);
			int num2 = this.theRow;
			CreateZombie instance2 = CreateZombie.Instance;
			Transform transform5 = base.transform;
			float num3 = global::UnityEngine.Random.Range(-1f, 1f);
			ulong num4;
			Zombie zombie = instance2.SetZombie(num2, (ZombieType)((uint)40), num3, num4 != 0UL);
			GameAPP.PlaySound(43, 0.5f, 1f);
			ScreenShake.TriggerShake(0.15f);
			Transform transform6 = base.transform;
			Vector3 vector4;
			float z2 = vector4.z;
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06002282 RID: 8834 RVA: 0x000B4D98 File Offset: 0x000B2F98
	[Token(Token = "0x6002282")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public SuperBall()
	{
	}

	// Token: 0x04001137 RID: 4407
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001137")]
	private Vector2 velocity;

	// Token: 0x04001138 RID: 4408
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001138")]
	public int theRow;
}
