using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200050B RID: 1291
[Token(Token = "0x200050B")]
public class HyponoFume : FumeShroom
{
	// Token: 0x0600181C RID: 6172 RVA: 0x00083220 File Offset: 0x00081420
	[Token(Token = "0x600181C")]
	[Address(RVA = "0x4CC030", Offset = "0x4CA630", VA = "0x1804CC030", Slot = "74")]
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

	// Token: 0x0600181D RID: 6173 RVA: 0x00083264 File Offset: 0x00081464
	[Token(Token = "0x600181D")]
	[Address(RVA = "0x4CC1C0", Offset = "0x4CA7C0", VA = "0x1804CC1C0", Slot = "69")]
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

	// Token: 0x0600181E RID: 6174 RVA: 0x000832FC File Offset: 0x000814FC
	[Token(Token = "0x600181E")]
	[Address(RVA = "0x4CC030", Offset = "0x4CA630", VA = "0x1804CC030")]
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

	// Token: 0x0600181F RID: 6175 RVA: 0x00083340 File Offset: 0x00081540
	[Token(Token = "0x600181F")]
	[Address(RVA = "0x4C7F30", Offset = "0x4C6530", VA = "0x1804C7F30")]
	public HyponoFume()
	{
		this.range = 7f;
		base..ctor();
	}
}
