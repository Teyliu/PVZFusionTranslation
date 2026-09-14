using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000324 RID: 804
[Token(Token = "0x2000324")]
public class KelpMine_land : PotatoMine
{
	// Token: 0x06000E92 RID: 3730 RVA: 0x000530C4 File Offset: 0x000512C4
	[Token(Token = "0x6000E92")]
	[Address(RVA = "0x4486A0", Offset = "0x446CA0", VA = "0x1804486A0", Slot = "17")]
	protected override void FixedUpdate()
	{
		int num = 0;
		base.FlashUpdate();
		if (base.Timers[1] > (float)num)
		{
		}
		Animator anim = this.anim;
		float speed = anim.speed;
		if (anim != 0)
		{
			base.OnFixedUpdate();
		}
		Animator anim2 = this.anim;
		float speed2 = anim2.speed;
		if (anim2 != 0)
		{
			Zombie targetZombie = this.targetZombie;
			int num2 = 0;
			if (targetZombie == num2)
			{
				this.GrabUpdate();
			}
		}
		GridSystem gridSystem = this.board.gridSystem;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		int num3 = Mathf.Min(gridSystem.GetGrid(thePlantColumn, thePlantRow).WaterLevel, 1);
		float num4;
		base.ModifySpeed((PlantSpeedAdder)((uint)4), num4);
	}

	// Token: 0x06000E93 RID: 3731 RVA: 0x0005317C File Offset: 0x0005137C
	[Token(Token = "0x6000E93")]
	[Address(RVA = "0x4488D0", Offset = "0x446ED0", VA = "0x1804488D0", Slot = "75")]
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

	// Token: 0x06000E94 RID: 3732 RVA: 0x00053290 File Offset: 0x00051490
	[Token(Token = "0x6000E94")]
	[Address(RVA = "0x448560", Offset = "0x446B60", VA = "0x180448560", Slot = "52")]
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

	// Token: 0x06000E95 RID: 3733 RVA: 0x00053304 File Offset: 0x00051504
	[Token(Token = "0x6000E95")]
	[Address(RVA = "0x448210", Offset = "0x446810", VA = "0x180448210")]
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
		Board board = this.board;
		LayerMask zombieLayer = this.zombieLayer;
		int thePlantRow2 = this.thePlantRow;
		Vector3 vector3;
		float z3 = vector3.z;
		GridSystem gridSystem = board.gridSystem;
		int thePlantColumn = this.thePlantColumn;
		long num8 = (long)(Mathf.Min(gridSystem.GetGrid(thePlantColumn, thePlantRow2).WaterLevel, 1) * (int)((uint)1800));
		PlantType thePlantType = this.thePlantType;
		GameAPP.PlaySound(47, 0.5f, 1f);
		ScreenShake.TriggerShake(0.15f);
		throw new NullReferenceException();
	}

	// Token: 0x06000E96 RID: 3734 RVA: 0x00053430 File Offset: 0x00051630
	[Token(Token = "0x6000E96")]
	[Address(RVA = "0x446250", Offset = "0x444850", VA = "0x180446250")]
	public KelpMine_land()
	{
	}

	// Token: 0x04000B2F RID: 2863
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000B2F")]
	public SortingGroup grab;
}
