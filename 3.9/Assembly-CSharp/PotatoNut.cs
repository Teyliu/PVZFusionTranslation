using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000342 RID: 834
[Token(Token = "0x2000342")]
public class PotatoNut : WallNut
{
	// Token: 0x06000F3A RID: 3898 RVA: 0x00058478 File Offset: 0x00056678
	[Token(Token = "0x6000F3A")]
	[Address(RVA = "0x469140", Offset = "0x467740", VA = "0x180469140", Slot = "16")]
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

	// Token: 0x06000F3B RID: 3899 RVA: 0x0005850C File Offset: 0x0005670C
	[Token(Token = "0x6000F3B")]
	[Address(RVA = "0x468D20", Offset = "0x467320", VA = "0x180468D20", Slot = "28")]
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

	// Token: 0x06000F3C RID: 3900 RVA: 0x00058678 File Offset: 0x00056878
	[Token(Token = "0x6000F3C")]
	[Address(RVA = "0x468B70", Offset = "0x467170", VA = "0x180468B70", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		this.Explode(1800, true);
	}

	// Token: 0x06000F3D RID: 3901 RVA: 0x00058694 File Offset: 0x00056894
	[Token(Token = "0x6000F3D")]
	[Address(RVA = "0x468B80", Offset = "0x467180", VA = "0x180468B80")]
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

	// Token: 0x06000F3E RID: 3902 RVA: 0x00058708 File Offset: 0x00056908
	[Token(Token = "0x6000F3E")]
	[Address(RVA = "0x469080", Offset = "0x467680", VA = "0x180469080")]
	private void SetFlash()
	{
		this.flashInterval = 5f;
		this.flashInterval = 1f;
		this.flashInterval = 5f;
		this.flashInterval = 1f;
		this.flashInterval = 5f;
		this.flashInterval = 1f;
	}

	// Token: 0x06000F3F RID: 3903 RVA: 0x00058758 File Offset: 0x00056958
	[Token(Token = "0x6000F3F")]
	[Address(RVA = "0x469280", Offset = "0x467880", VA = "0x180469280")]
	public PotatoNut()
	{
	}

	// Token: 0x04000B71 RID: 2929
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B71")]
	private bool isExplode1;

	// Token: 0x04000B72 RID: 2930
	[FieldOffset(Offset = "0x219")]
	[Token(Token = "0x4000B72")]
	private bool isExplode2;

	// Token: 0x04000B73 RID: 2931
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000B73")]
	private float flashInterval = 3f;

	// Token: 0x04000B74 RID: 2932
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000B74")]
	private float flashTime;
}
