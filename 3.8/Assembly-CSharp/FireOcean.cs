using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002BB RID: 699
[Token(Token = "0x20002BB")]
public class FireOcean : MonoBehaviour
{
	// Token: 0x06000C4F RID: 3151 RVA: 0x00046E10 File Offset: 0x00045010
	[Token(Token = "0x6000C4F")]
	[Address(RVA = "0x3D3A60", Offset = "0x3D2060", VA = "0x1803D3A60")]
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

	// Token: 0x06000C50 RID: 3152 RVA: 0x00046E58 File Offset: 0x00045058
	[Token(Token = "0x6000C50")]
	[Address(RVA = "0x3D3C70", Offset = "0x3D2270", VA = "0x1803D3C70")]
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

	// Token: 0x06000C51 RID: 3153 RVA: 0x00046EF0 File Offset: 0x000450F0
	[Token(Token = "0x6000C51")]
	[Address(RVA = "0x3D3AF0", Offset = "0x3D20F0", VA = "0x1803D3AF0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (!flag || this.theRow <= 8)
		{
		}
	}

	// Token: 0x06000C52 RID: 3154 RVA: 0x00046F1C File Offset: 0x0004511C
	[Token(Token = "0x6000C52")]
	[Address(RVA = "0x3D3DD0", Offset = "0x3D23D0", VA = "0x1803D3DD0")]
	public FireOcean()
	{
	}

	// Token: 0x04000870 RID: 2160
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000870")]
	public int theRow;

	// Token: 0x04000871 RID: 2161
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000871")]
	public int theDamage;

	// Token: 0x04000872 RID: 2162
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000872")]
	public PlantType fromType;

	// Token: 0x04000873 RID: 2163
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000873")]
	public float timer = 3f;

	// Token: 0x04000874 RID: 2164
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000874")]
	private float timer2 = 0.5f;

	// Token: 0x04000875 RID: 2165
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000875")]
	private ParticleSystem particle;
}
