using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200049B RID: 1179
[Token(Token = "0x200049B")]
public class UltimateIceShroom2 : Plant
{
	// Token: 0x060015DF RID: 5599 RVA: 0x000784A8 File Offset: 0x000766A8
	[Token(Token = "0x60015DF")]
	[Address(RVA = "0x4E2B50", Offset = "0x4E1150", VA = "0x1804E2B50", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)5), action, num != 0);
	}

	// Token: 0x060015E0 RID: 5600 RVA: 0x000784C8 File Offset: 0x000766C8
	[Token(Token = "0x60015E0")]
	[Address(RVA = "0x4E2320", Offset = "0x4E0920", VA = "0x1804E2320", Slot = "39")]
	protected override void AttributeEvent()
	{
		ulong num2;
		do
		{
			int num = 0;
			Board board = this.board;
			List<Plant> plants = Lawnf.GetPlants((PlantType)((uint)992), board, num != 0);
			bool flag;
			if (flag)
			{
			}
		}
		while (num2 != (ulong)0L);
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)38)))
		{
		}
	}

	// Token: 0x060015E1 RID: 5601 RVA: 0x0007851C File Offset: 0x0007671C
	[Token(Token = "0x60015E1")]
	[Address(RVA = "0x4E26B0", Offset = "0x4E0CB0", VA = "0x1804E26B0")]
	private void OnZombieTakeDamage(object obj)
	{
		int num = 0;
		bool flag;
		if (obj != 0 && obj != 0 && flag)
		{
			Vector3 vector;
			float z = vector.z;
			ParticleManager instance = ParticleManager.Instance;
			Transform shoot = this.shoot;
			int thePlantRow = this.thePlantRow;
			LayerMask zombieLayer = this.zombieLayer;
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag2;
				bool flag3;
				if (flag2 && flag3)
				{
					PlantType thePlantType = this.thePlantType;
				}
				num++;
			}
			bool flag4;
			if (flag4)
			{
			}
		}
	}

	// Token: 0x060015E2 RID: 5602 RVA: 0x00078598 File Offset: 0x00076798
	[Token(Token = "0x60015E2")]
	[Address(RVA = "0x4E25B0", Offset = "0x4E0BB0", VA = "0x1804E25B0")]
	private void FromTo(Vector2 from, Vector2 to, int row)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060015E3 RID: 5603 RVA: 0x000785B8 File Offset: 0x000767B8
	[Token(Token = "0x60015E3")]
	[Address(RVA = "0x4E2510", Offset = "0x4E0B10", VA = "0x1804E2510", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)5), action);
	}

	// Token: 0x060015E4 RID: 5604 RVA: 0x000785D0 File Offset: 0x000767D0
	[Token(Token = "0x60015E4")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public UltimateIceShroom2()
	{
	}
}
