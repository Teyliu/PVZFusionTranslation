using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000478 RID: 1144
[Token(Token = "0x2000478")]
public class UltimateIceShroom : Plant
{
	// Token: 0x06001536 RID: 5430 RVA: 0x00075770 File Offset: 0x00073970
	[Token(Token = "0x6001536")]
	[Address(RVA = "0x4013E0", Offset = "0x3FF9E0", VA = "0x1804013E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x06001537 RID: 5431 RVA: 0x00075790 File Offset: 0x00073990
	[Token(Token = "0x6001537")]
	[Address(RVA = "0x489CA0", Offset = "0x4882A0", VA = "0x180489CA0", Slot = "40")]
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

	// Token: 0x06001538 RID: 5432 RVA: 0x0007587C File Offset: 0x00073A7C
	[Token(Token = "0x6001538")]
	[Address(RVA = "0x48A190", Offset = "0x488790", VA = "0x18048A190")]
	private float GetMultiplier(float a)
	{
		bool flag = global::Lawnf.TravelAdvanced((AdvBuff)((uint)38));
		return 0f;
	}

	// Token: 0x06001539 RID: 5433 RVA: 0x00075898 File Offset: 0x00073A98
	[Token(Token = "0x6001539")]
	[Address(RVA = "0x4896A0", Offset = "0x487CA0", VA = "0x1804896A0")]
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

	// Token: 0x0600153A RID: 5434 RVA: 0x000759E8 File Offset: 0x00073BE8
	[Token(Token = "0x600153A")]
	[Address(RVA = "0x48A100", Offset = "0x488700", VA = "0x18048A100", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x0600153B RID: 5435 RVA: 0x00075A10 File Offset: 0x00073C10
	[Token(Token = "0x600153B")]
	[Address(RVA = "0x48A1E0", Offset = "0x4887E0", VA = "0x18048A1E0", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x0600153C RID: 5436 RVA: 0x00075A30 File Offset: 0x00073C30
	[Token(Token = "0x600153C")]
	[Address(RVA = "0x48A400", Offset = "0x488A00", VA = "0x18048A400")]
	public UltimateIceShroom()
	{
	}

	// Token: 0x04000D01 RID: 3329
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D01")]
	public GameObject spark;

	// Token: 0x04000D02 RID: 3330
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000D02")]
	private int cnt;

	// Token: 0x04000D03 RID: 3331
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x4000D03")]
	private int limit = (int)((ulong)50L);
}
