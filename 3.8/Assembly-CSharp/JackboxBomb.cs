using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002C2 RID: 706
[Token(Token = "0x20002C2")]
public class JackboxBomb : MonoBehaviour
{
	// Token: 0x06000C93 RID: 3219 RVA: 0x00048488 File Offset: 0x00046688
	[Token(Token = "0x6000C93")]
	[Address(RVA = "0x3E41B0", Offset = "0x3E27B0", VA = "0x1803E41B0")]
	private void Update()
	{
		Transform transform = base.transform;
		float deltaTime = Time.deltaTime;
		float y = this.v.y;
		float deltaTime2 = Time.deltaTime;
		int num = 0;
		this.v.y = y;
		if (num > (int)y)
		{
			Transform transform2 = base.transform;
			Vector3 vector;
			float y2 = vector.y;
			Mouse instance = Mouse.Instance;
			Transform transform3 = base.transform;
			float num2;
			if (num2 > y2)
			{
				global::UnityEngine.Object.Destroy(base.gameObject);
				Transform transform4 = base.transform;
				int num3 = this.damageToPlant;
				int num4 = this.damage;
			}
		}
	}

	// Token: 0x06000C94 RID: 3220 RVA: 0x00048524 File Offset: 0x00046724
	[Token(Token = "0x6000C94")]
	[Address(RVA = "0x3E4420", Offset = "0x3E2A20", VA = "0x1803E4420")]
	public JackboxBomb()
	{
	}

	// Token: 0x040008AB RID: 2219
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008AB")]
	public int theRow;

	// Token: 0x040008AC RID: 2220
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40008AC")]
	public int damageToPlant = (int)((ulong)1000000L);

	// Token: 0x040008AD RID: 2221
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008AD")]
	public int damage = (int)((ulong)1800L);

	// Token: 0x040008AE RID: 2222
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40008AE")]
	public Vector3 v;

	// Token: 0x040008AF RID: 2223
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008AF")]
	public bool isMindConrolled;

	// Token: 0x040008B0 RID: 2224
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008B0")]
	public Board board;
}
