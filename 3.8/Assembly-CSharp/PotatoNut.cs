using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000332 RID: 818
[Token(Token = "0x2000332")]
public class PotatoNut : WallNut
{
	// Token: 0x06000EEF RID: 3823 RVA: 0x000574BC File Offset: 0x000556BC
	[Token(Token = "0x6000EEF")]
	[Address(RVA = "0x429350", Offset = "0x427950", VA = "0x180429350", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		this.flashInterval = 5f;
		this.flashInterval = 1f;
		this.flashInterval = 5f;
		this.flashInterval = 1f;
		this.flashInterval = 5f;
		this.flashInterval = 1f;
		float deltaTime = Time.deltaTime;
		this.flashTime = deltaTime;
		if (deltaTime > this.flashInterval)
		{
			Animator anim = this.anim;
			this.flashTime = 0f;
			anim.Play("flash");
		}
	}

	// Token: 0x06000EF0 RID: 3824 RVA: 0x00057550 File Offset: 0x00055750
	[Token(Token = "0x6000EF0")]
	[Address(RVA = "0x428F30", Offset = "0x427530", VA = "0x180428F30", Slot = "29")]
	protected override void ReplaceSprite()
	{
		int num = this.thePlantMaxHealth;
		num += num;
		Transform transform = base.transform;
		int num2 = 0;
		GameObject gameObject = transform.GetChild(num2).gameObject;
		int num3 = 0;
		gameObject.SetActive(num3 != 0);
		uint num4;
		ulong num5;
		base.transform.GetChild((int)num4).gameObject.SetActive(num5 != 0UL);
		uint num6;
		GameObject gameObject2 = base.transform.GetChild((int)num6).gameObject;
		int num7 = 0;
		gameObject2.SetActive(num7 != 0);
		if (!this.isExplode1)
		{
			int num8 = 0;
			uint num9;
			this.Explode((int)num9, num8 != 0);
			this.isExplode1 = true;
		}
	}

	// Token: 0x06000EF1 RID: 3825 RVA: 0x000576BC File Offset: 0x000558BC
	[Token(Token = "0x6000EF1")]
	[Address(RVA = "0x428D80", Offset = "0x427380", VA = "0x180428D80", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		this.Explode(1800, true);
	}

	// Token: 0x06000EF2 RID: 3826 RVA: 0x000576D8 File Offset: 0x000558D8
	[Token(Token = "0x6000EF2")]
	[Address(RVA = "0x428D90", Offset = "0x427390", VA = "0x180428D90")]
	private void Explode(int dmg, bool isShake)
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		PlantType thePlantType = this.thePlantType;
		Transform axis2 = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num = 0;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)8), num, 11, num3 != 0UL, (float)num2);
		GameAPP.PlaySound(47, 0.5f, 1f);
		if (isShake)
		{
			ScreenShake.TriggerShake(0.15f);
		}
	}

	// Token: 0x06000EF3 RID: 3827 RVA: 0x0005774C File Offset: 0x0005594C
	[Token(Token = "0x6000EF3")]
	[Address(RVA = "0x429290", Offset = "0x427890", VA = "0x180429290")]
	private void SetFlash()
	{
		this.flashInterval = 5f;
		this.flashInterval = 1f;
		this.flashInterval = 5f;
		this.flashInterval = 1f;
		this.flashInterval = 5f;
		this.flashInterval = 1f;
	}

	// Token: 0x06000EF4 RID: 3828 RVA: 0x0005779C File Offset: 0x0005599C
	[Token(Token = "0x6000EF4")]
	[Address(RVA = "0x429490", Offset = "0x427A90", VA = "0x180429490")]
	public PotatoNut()
	{
	}

	// Token: 0x04000B20 RID: 2848
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B20")]
	private bool isExplode1;

	// Token: 0x04000B21 RID: 2849
	[FieldOffset(Offset = "0x219")]
	[Token(Token = "0x4000B21")]
	private bool isExplode2;

	// Token: 0x04000B22 RID: 2850
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000B22")]
	private float flashInterval = 3f;

	// Token: 0x04000B23 RID: 2851
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000B23")]
	private float flashTime;
}
