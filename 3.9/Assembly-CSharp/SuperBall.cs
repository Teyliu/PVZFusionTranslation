using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200070F RID: 1807
[Token(Token = "0x200070F")]
public class SuperBall : MonoBehaviour
{
	// Token: 0x0600239A RID: 9114 RVA: 0x000B9A00 File Offset: 0x000B7C00
	[Token(Token = "0x600239A")]
	[Address(RVA = "0x5D7740", Offset = "0x5D5D40", VA = "0x1805D7740")]
	private void Awake()
	{
		this.velocity = (ulong)3225419776L;
		this.velocity.y = 2f;
	}

	// Token: 0x0600239B RID: 9115 RVA: 0x000B9A30 File Offset: 0x000B7C30
	[Token(Token = "0x600239B")]
	[Address(RVA = "0x5D7750", Offset = "0x5D5D50", VA = "0x1805D7750")]
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

	// Token: 0x0600239C RID: 9116 RVA: 0x000B9B50 File Offset: 0x000B7D50
	[Token(Token = "0x600239C")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public SuperBall()
	{
	}

	// Token: 0x04001204 RID: 4612
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001204")]
	private Vector2 velocity;

	// Token: 0x04001205 RID: 4613
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001205")]
	public int theRow;
}
