using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002C6 RID: 710
[Token(Token = "0x20002C6")]
public class FireOcean : MonoBehaviour
{
	// Token: 0x06000C78 RID: 3192 RVA: 0x00047158 File Offset: 0x00045358
	[Token(Token = "0x6000C78")]
	[Address(RVA = "0x4208B0", Offset = "0x41EEB0", VA = "0x1804208B0")]
	private void Awake()
	{
		Transform transform = base.transform;
		int num = 0;
		ParticleSystem component = transform.GetChild(num).GetComponent<ParticleSystem>();
		this.particle = component;
		if (Lawnf.TravelUltimate((UltiBuff)((uint)27)))
		{
			this.timer = 6f;
		}
	}

	// Token: 0x06000C79 RID: 3193 RVA: 0x000471A0 File Offset: 0x000453A0
	[Token(Token = "0x6000C79")]
	[Address(RVA = "0x420AC0", Offset = "0x41F0C0", VA = "0x180420AC0")]
	private void Update()
	{
		float num = this.timer;
		float deltaTime = Time.deltaTime;
		int num2 = 0;
		this.timer = num;
		if (num2 > (int)num)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
		ParticleSystem.MainModule main = this.particle.main;
		this.timer2 = 10f;
		float num3 = this.timer2;
		float deltaTime2 = Time.deltaTime;
		this.timer2 = num3;
		if (num2 > (int)num3)
		{
			GameAPP.PlaySound(global::UnityEngine.Random.Range(59, 61), 0.5f, 1f);
			this.timer2 = 0.5f;
		}
	}

	// Token: 0x06000C7A RID: 3194 RVA: 0x00047238 File Offset: 0x00045438
	[Token(Token = "0x6000C7A")]
	[Address(RVA = "0x420940", Offset = "0x41EF40", VA = "0x180420940")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (!flag || this.theRow <= 8)
		{
		}
	}

	// Token: 0x06000C7B RID: 3195 RVA: 0x00047264 File Offset: 0x00045464
	[Token(Token = "0x6000C7B")]
	[Address(RVA = "0x420C20", Offset = "0x41F220", VA = "0x180420C20")]
	public FireOcean()
	{
	}

	// Token: 0x0400088F RID: 2191
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400088F")]
	public int theRow;

	// Token: 0x04000890 RID: 2192
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000890")]
	public int theDamage;

	// Token: 0x04000891 RID: 2193
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000891")]
	public PlantType fromType;

	// Token: 0x04000892 RID: 2194
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000892")]
	public float timer = 3f;

	// Token: 0x04000893 RID: 2195
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000893")]
	private float timer2 = 0.5f;

	// Token: 0x04000894 RID: 2196
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000894")]
	private ParticleSystem particle;
}
