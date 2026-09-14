using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002A6 RID: 678
[Token(Token = "0x20002A6")]
public class BigSnowBall : MonoBehaviour
{
	// Token: 0x06000BF3 RID: 3059 RVA: 0x00044790 File Offset: 0x00042990
	[Token(Token = "0x6000BF3")]
	[Address(RVA = "0x3CC960", Offset = "0x3CAF60", VA = "0x1803CC960")]
	private void Update()
	{
		this.PositionUpdate();
	}

	// Token: 0x06000BF4 RID: 3060 RVA: 0x000447A4 File Offset: 0x000429A4
	[Token(Token = "0x6000BF4")]
	[Address(RVA = "0x3CC7B0", Offset = "0x3CADB0", VA = "0x1803CC7B0")]
	private void PositionUpdate()
	{
		if (!this.land)
		{
			Transform transform = base.transform;
			float deltaTime = Time.deltaTime;
			Vector2 gravity = Physics2D.gravity;
			float deltaTime2 = Time.deltaTime;
			this.velocity.y = deltaTime2;
			Transform transform2 = base.transform;
			Vector3 vector;
			float y = vector.y;
			Mouse instance = Mouse.Instance;
			Transform transform3 = base.transform;
			float num;
			if (num > y)
			{
				this.land = true;
				this.LandEvent();
				global::UnityEngine.Object.Destroy(base.gameObject);
			}
		}
	}

	// Token: 0x06000BF5 RID: 3061 RVA: 0x00044834 File Offset: 0x00042A34
	[Token(Token = "0x6000BF5")]
	[Address(RVA = "0x3CC450", Offset = "0x3CAA50", VA = "0x1803CC450")]
	private void LandEvent()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int mask = LayerMask.GetMask(new string[] { "Plant", "TorchWood" });
		int num = 0;
		int num2 = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int num3 = 0;
				Plant plant;
				if (plant == num3)
				{
				}
			}
			num2++;
		}
	}

	// Token: 0x06000BF6 RID: 3062 RVA: 0x000448B0 File Offset: 0x00042AB0
	[Token(Token = "0x6000BF6")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public BigSnowBall()
	{
	}

	// Token: 0x040007E5 RID: 2021
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007E5")]
	public int theRow;

	// Token: 0x040007E6 RID: 2022
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40007E6")]
	public int damage;

	// Token: 0x040007E7 RID: 2023
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007E7")]
	public Vector2 velocity;

	// Token: 0x040007E8 RID: 2024
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40007E8")]
	private bool land;
}
