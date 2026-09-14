using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200049A RID: 1178
[Token(Token = "0x200049A")]
public class UltimateIceShroom : Plant
{
	// Token: 0x060015D6 RID: 5590 RVA: 0x00078140 File Offset: 0x00076340
	[Token(Token = "0x60015D6")]
	[Address(RVA = "0x4454A0", Offset = "0x443AA0", VA = "0x1804454A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x060015D7 RID: 5591 RVA: 0x00078160 File Offset: 0x00076360
	[Token(Token = "0x60015D7")]
	[Address(RVA = "0x4E3200", Offset = "0x4E1800", VA = "0x1804E3200", Slot = "39")]
	protected override void AttributeEvent()
	{
		int num = 0;
		base.OnFixedUpdate();
		List<Zombie> list = new List();
		bool flag;
		if (flag)
		{
		}
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag2;
			BoxType boxType;
			if (!flag2 || !global::Lawnf.InLandStatus((ZombieStatus)num) || boxType != BoxType.Water)
			{
			}
			num++;
		}
		Func<Zombie, float> func;
		Zombie zombie = Enumerable.FirstOrDefault<Zombie>(Enumerable.OrderBy<Zombie, float>(list, func));
		this.targetZombie = zombie;
		this.anim.SetTrigger("shoot");
		Transform transform2 = this.spark.transform;
		Transform axis = this.targetZombie.axis;
		Vector3 vector2;
		float z2 = vector2.z;
		SortingGroup component = this.spark.GetComponent<SortingGroup>();
		int theZombieRow = this.targetZombie.theZombieRow;
		string text = string.Format("bullet{0}", component);
		component.sortingLayerName = text;
		base.AttributeCountdown = 1f;
	}

	// Token: 0x060015D8 RID: 5592 RVA: 0x0007824C File Offset: 0x0007644C
	[Token(Token = "0x60015D8")]
	[Address(RVA = "0x4E36F0", Offset = "0x4E1CF0", VA = "0x1804E36F0")]
	private float GetMultiplier(float a)
	{
		bool flag = global::Lawnf.TravelAdvanced((AdvBuff)((uint)38));
		return 0f;
	}

	// Token: 0x060015D9 RID: 5593 RVA: 0x00078268 File Offset: 0x00076468
	[Token(Token = "0x60015D9")]
	[Address(RVA = "0x4E2C00", Offset = "0x4E1200", VA = "0x1804E2C00")]
	private void AnimShoot()
	{
		int num = 0;
		Zombie targetZombie = this.targetZombie;
		int num2 = 0;
		if (targetZombie != num2)
		{
			uint num3;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num3), 0.5f, 1f);
			global::Core.Lawnf.LessThan(3f, 0.5f);
			Transform transform = this.spark.transform;
			float num4;
			this.anim.SetFloat("attackSpeed", num4);
			Zombie targetZombie2 = this.targetZombie;
			int num5 = 0;
			float num6;
			targetZombie2.SetFreeze(num6, num5);
			Transform axis = this.targetZombie.axis;
			float num7;
			num4 = num7;
			ParticleManager instance = ParticleManager.Instance;
			Zombie targetZombie3 = this.targetZombie;
			num7 = num4;
			LayerMask zombieLayer = this.zombieLayer;
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag;
				bool flag2;
				if (flag && flag2)
				{
					PlantType thePlantType = this.thePlantType;
				}
				num++;
			}
			int num8 = this.cnt;
			num8++;
			this.cnt = num8;
			if (num8 == 60)
			{
				this.cnt = num;
				if (this.limit > num)
				{
				}
				Board board = this.board;
				Zombie targetZombie4 = this.targetZombie;
				BoardAction boardAction = board.boardAction;
				int num9 = 0;
				int column = targetZombie4.Column;
				Zombie targetZombie5 = this.targetZombie;
				PlantType thePlantType2 = this.thePlantType;
				num9 += num9;
			}
			this.targetZombie = num;
			base.UpdateText();
		}
	}

	// Token: 0x060015DA RID: 5594 RVA: 0x000783B8 File Offset: 0x000765B8
	[Token(Token = "0x60015DA")]
	[Address(RVA = "0x4E3660", Offset = "0x4E1C60", VA = "0x1804E3660", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x060015DB RID: 5595 RVA: 0x000783E0 File Offset: 0x000765E0
	[Token(Token = "0x60015DB")]
	[Address(RVA = "0x4E3740", Offset = "0x4E1D40", VA = "0x1804E3740", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060015DC RID: 5596 RVA: 0x00078400 File Offset: 0x00076600
	[Token(Token = "0x60015DC")]
	[Address(RVA = "0x4E3960", Offset = "0x4E1F60", VA = "0x1804E3960")]
	public UltimateIceShroom()
	{
	}

	// Token: 0x04000D9A RID: 3482
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D9A")]
	public GameObject spark;

	// Token: 0x04000D9B RID: 3483
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000D9B")]
	private int cnt;

	// Token: 0x04000D9C RID: 3484
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x4000D9C")]
	private int limit = (int)((ulong)50L);
}
