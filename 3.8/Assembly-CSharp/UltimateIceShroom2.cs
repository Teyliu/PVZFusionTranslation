using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000479 RID: 1145
[Token(Token = "0x2000479")]
public class UltimateIceShroom2 : Plant
{
	// Token: 0x0600153F RID: 5439 RVA: 0x00075AD8 File Offset: 0x00073CD8
	[Token(Token = "0x600153F")]
	[Address(RVA = "0x4895F0", Offset = "0x487BF0", VA = "0x1804895F0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)5), action, num != 0);
	}

	// Token: 0x06001540 RID: 5440 RVA: 0x00075AF8 File Offset: 0x00073CF8
	[Token(Token = "0x6001540")]
	[Address(RVA = "0x488DD0", Offset = "0x4873D0", VA = "0x180488DD0", Slot = "40")]
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

	// Token: 0x06001541 RID: 5441 RVA: 0x00075B4C File Offset: 0x00073D4C
	[Token(Token = "0x6001541")]
	[Address(RVA = "0x489160", Offset = "0x487760", VA = "0x180489160")]
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

	// Token: 0x06001542 RID: 5442 RVA: 0x00075BC8 File Offset: 0x00073DC8
	[Token(Token = "0x6001542")]
	[Address(RVA = "0x489060", Offset = "0x487660", VA = "0x180489060")]
	private void FromTo(Vector2 from, Vector2 to, int row)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001543 RID: 5443 RVA: 0x00075BE8 File Offset: 0x00073DE8
	[Token(Token = "0x6001543")]
	[Address(RVA = "0x488FC0", Offset = "0x4875C0", VA = "0x180488FC0", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)5), action);
	}

	// Token: 0x06001544 RID: 5444 RVA: 0x00075C00 File Offset: 0x00073E00
	[Token(Token = "0x6001544")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public UltimateIceShroom2()
	{
	}
}
