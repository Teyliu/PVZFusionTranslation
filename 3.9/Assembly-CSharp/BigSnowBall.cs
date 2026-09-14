using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002B1 RID: 689
[Token(Token = "0x20002B1")]
public class BigSnowBall : MonoBehaviour
{
	// Token: 0x06000C1B RID: 3099 RVA: 0x00044A80 File Offset: 0x00042C80
	[Token(Token = "0x6000C1B")]
	[Address(RVA = "0x4197E0", Offset = "0x417DE0", VA = "0x1804197E0")]
	private void Update()
	{
		this.PositionUpdate();
	}

	// Token: 0x06000C1C RID: 3100 RVA: 0x00044A94 File Offset: 0x00042C94
	[Token(Token = "0x6000C1C")]
	[Address(RVA = "0x419630", Offset = "0x417C30", VA = "0x180419630")]
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

	// Token: 0x06000C1D RID: 3101 RVA: 0x00044B24 File Offset: 0x00042D24
	[Token(Token = "0x6000C1D")]
	[Address(RVA = "0x4192D0", Offset = "0x4178D0", VA = "0x1804192D0")]
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

	// Token: 0x06000C1E RID: 3102 RVA: 0x00044BA0 File Offset: 0x00042DA0
	[Token(Token = "0x6000C1E")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public BigSnowBall()
	{
	}

	// Token: 0x04000803 RID: 2051
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000803")]
	public int theRow;

	// Token: 0x04000804 RID: 2052
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000804")]
	public int damage;

	// Token: 0x04000805 RID: 2053
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000805")]
	public Vector2 velocity;

	// Token: 0x04000806 RID: 2054
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000806")]
	private bool land;
}
