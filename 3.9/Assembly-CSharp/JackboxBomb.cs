using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002D0 RID: 720
[Token(Token = "0x20002D0")]
public class JackboxBomb : MonoBehaviour
{
	// Token: 0x06000CD6 RID: 3286 RVA: 0x00049058 File Offset: 0x00047258
	[Token(Token = "0x6000CD6")]
	[Address(RVA = "0x434E50", Offset = "0x433450", VA = "0x180434E50")]
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

	// Token: 0x06000CD7 RID: 3287 RVA: 0x000490F4 File Offset: 0x000472F4
	[Token(Token = "0x6000CD7")]
	[Address(RVA = "0x4350C0", Offset = "0x4336C0", VA = "0x1804350C0")]
	public JackboxBomb()
	{
	}

	// Token: 0x040008E8 RID: 2280
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008E8")]
	public int theRow;

	// Token: 0x040008E9 RID: 2281
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40008E9")]
	public int damageToPlant = (int)((ulong)1000000L);

	// Token: 0x040008EA RID: 2282
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008EA")]
	public int damage = (int)((ulong)1800L);

	// Token: 0x040008EB RID: 2283
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40008EB")]
	public Vector3 v;

	// Token: 0x040008EC RID: 2284
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008EC")]
	public bool isMindConrolled;

	// Token: 0x040008ED RID: 2285
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008ED")]
	public Board board;
}
