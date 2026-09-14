using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000536 RID: 1334
[Token(Token = "0x2000536")]
public class HyponoFume : FumeShroom
{
	// Token: 0x060018E5 RID: 6373 RVA: 0x00086A60 File Offset: 0x00084C60
	[Token(Token = "0x60018E5")]
	[Address(RVA = "0x528350", Offset = "0x526950", VA = "0x180528350", Slot = "73")]
	protected override void Attack(Zombie zombie)
	{
		bool[] controlledLevel = zombie.controlledLevel;
		int num = 0;
		int length = controlledLevel.Length;
		if (num < length)
		{
			num++;
		}
		if (global::UnityEngine.Random.value < 0.75f)
		{
			PlantType thePlantType = this.thePlantType;
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060018E6 RID: 6374 RVA: 0x00086AAC File Offset: 0x00084CAC
	[Token(Token = "0x60018E6")]
	[Address(RVA = "0x5284E0", Offset = "0x526AE0", VA = "0x1805284E0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[21];
		Transform transform2 = this.board.transform;
		GameObject gameObject2;
		Renderer component = gameObject2.GetComponent<ParticleSystem>().GetComponent<Renderer>();
		int thePlantRow = this.thePlantRow;
		string text = string.Format("particle{0}", component);
		component.sortingLayerName = text;
		GameAPP.PlaySound(58, 0.5f, 1f);
		base.AttackZombie();
		throw new NullReferenceException();
	}

	// Token: 0x060018E7 RID: 6375 RVA: 0x00086B44 File Offset: 0x00084D44
	[Token(Token = "0x60018E7")]
	[Address(RVA = "0x528350", Offset = "0x526950", VA = "0x180528350")]
	private void TrySetMindControl(Zombie zombie)
	{
		bool[] controlledLevel = zombie.controlledLevel;
		int num = 0;
		int length = controlledLevel.Length;
		if (num < length)
		{
			num++;
		}
		if (global::UnityEngine.Random.value < 0.75f)
		{
			PlantType thePlantType = this.thePlantType;
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060018E8 RID: 6376 RVA: 0x00086B90 File Offset: 0x00084D90
	[Token(Token = "0x60018E8")]
	[Address(RVA = "0x523270", Offset = "0x521870", VA = "0x180523270")]
	public HyponoFume()
	{
		this.range = 7f;
		base..ctor();
	}
}
