using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000314 RID: 788
[Token(Token = "0x2000314")]
public class KelpMine_land : PotatoMine
{
	// Token: 0x06000E49 RID: 3657 RVA: 0x000521A0 File Offset: 0x000503A0
	[Token(Token = "0x6000E49")]
	[Address(RVA = "0x4043E0", Offset = "0x4029E0", VA = "0x1804043E0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Animator anim = this.anim;
		float speed = anim.speed;
		if (anim != 0)
		{
			Zombie targetZombie = this.targetZombie;
			int num = 0;
			if (targetZombie == num)
			{
			}
		}
	}

	// Token: 0x06000E4A RID: 3658 RVA: 0x000521E0 File Offset: 0x000503E0
	[Token(Token = "0x6000E4A")]
	[Address(RVA = "0x4044A0", Offset = "0x402AA0", VA = "0x1804044A0", Slot = "76")]
	protected virtual void GrabUpdate()
	{
		Transform axis = this.axis;
		LayerMask zombieLayer = this.zombieLayer;
		int num = 0;
		int num2 = zombieLayer;
		int num3 = 0;
		int num4 = 0;
		Collider2D[] array;
		if (num3 < array.Length)
		{
			bool flag;
			bool flag2;
			if (flag && base.PotatoSearchZombie(num) && !flag2)
			{
				int thePlantRow = this.thePlantRow;
			}
			num4++;
			this.targetZombie = num;
			this.anim.SetTrigger("grab");
			SortingGroup sortingGroup = this.grab;
			bool flag3;
			string text = string.Format("bullet{0}", flag3);
			sortingGroup.sortingLayerName = text;
			SortingGroup sortingGroup2 = this.grab;
			int num5 = 0;
			sortingGroup2.transform.position = num5;
			this.theStatus = (PlantStatus)((ulong)20L);
			uint num6;
			GameAPP.PlaySound((int)num6, 0.5f, 1f);
			base.Invoke("AnimKill", 1f);
			GameObject[] particlePrefab = GameAPP.particlePrefab;
			GameObject gameObject = particlePrefab[9];
			GameObject gameObject2 = particlePrefab[3];
			Transform transform = this.board.transform;
		}
	}

	// Token: 0x06000E4B RID: 3659 RVA: 0x000522F4 File Offset: 0x000504F4
	[Token(Token = "0x6000E4B")]
	[Address(RVA = "0x4042A0", Offset = "0x4028A0", VA = "0x1804042A0", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		if (targetZombie != num)
		{
			Zombie targetZombie2 = this.targetZombie;
			ParticleManager instance = ParticleManager.Instance;
			Transform axis = targetZombie2.axis;
			int num2 = 0;
			int thePlantRow = this.thePlantRow;
			int num3 = 0;
			ulong num4;
			Particle particle = instance.SetParticle((ParticleType)((uint)104), num2, thePlantRow, num4 != 0UL, (float)num3);
			this.targetZombie.Die(2);
			this.targetZombie = (ulong)0L;
		}
	}

	// Token: 0x06000E4C RID: 3660 RVA: 0x00052368 File Offset: 0x00050568
	[Token(Token = "0x6000E4C")]
	[Address(RVA = "0x403FE0", Offset = "0x4025E0", VA = "0x180403FE0")]
	private void AnimKill()
	{
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		bool flag = targetZombie != num;
		int num2 = 0;
		int num3 = 0;
		if (flag)
		{
			this.targetZombie.Die(2);
			Zombie targetZombie2 = this.targetZombie;
			ParticleManager instance = ParticleManager.Instance;
			Transform axis = targetZombie2.axis;
			int num4 = 0;
			Vector3 vector;
			float z = vector.z;
			int thePlantRow = this.thePlantRow;
			ulong num5;
			Particle particle = instance.SetParticle((ParticleType)((uint)104), num4, thePlantRow, num5 != 0UL, (float)num3);
			this.targetZombie = num2;
		}
		Transform axis2 = this.axis;
		ParticleManager instance2 = ParticleManager.Instance;
		int num6 = 0;
		Vector3 vector2;
		float z2 = vector2.z;
		ulong num7;
		Particle particle2 = instance2.SetParticle((ParticleType)((uint)8), num6, 11, num7 != 0UL, (float)num3);
		Transform axis3 = this.axis;
		Vector3 vector3;
		float z3 = vector3.z;
		PlantType thePlantType = this.thePlantType;
		GameAPP.PlaySound(47, 0.5f, 1f);
		ScreenShake.TriggerShake(0.15f);
		throw new NullReferenceException();
	}

	// Token: 0x06000E4D RID: 3661 RVA: 0x0005244C File Offset: 0x0005064C
	[Token(Token = "0x6000E4D")]
	[Address(RVA = "0x401F90", Offset = "0x400590", VA = "0x180401F90")]
	public KelpMine_land()
	{
		this.flashInterval = 3f;
		base..ctor();
	}

	// Token: 0x04000ADE RID: 2782
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000ADE")]
	public SortingGroup grab;
}
