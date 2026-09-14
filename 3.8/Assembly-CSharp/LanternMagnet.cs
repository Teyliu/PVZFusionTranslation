using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003CA RID: 970
[Token(Token = "0x20003CA")]
public class LanternMagnet : Magnetshroom
{
	// Token: 0x060011B0 RID: 4528 RVA: 0x00063DAC File Offset: 0x00061FAC
	[Token(Token = "0x60011B0")]
	[Address(RVA = "0x4469E0", Offset = "0x444FE0", VA = "0x1804469E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie", "Ladder" });
		this.magnetLayer = layerMask;
		ParticleSystem component = base.transform.Find("LanternShine").GetComponent<ParticleSystem>();
		this.lightShine = component;
		throw new NullReferenceException();
	}

	// Token: 0x060011B1 RID: 4529 RVA: 0x00063E14 File Offset: 0x00062014
	[Token(Token = "0x60011B1")]
	[Address(RVA = "0x446B30", Offset = "0x445130", VA = "0x180446B30", Slot = "69")]
	protected override void MagnetUpdate()
	{
		this.SetRange();
	}

	// Token: 0x060011B2 RID: 4530 RVA: 0x00063E28 File Offset: 0x00062028
	[Token(Token = "0x60011B2")]
	[Address(RVA = "0x446B80", Offset = "0x445180", VA = "0x180446B80", Slot = "78")]
	protected virtual void SetRange()
	{
		ParticleSystem.MainModule main = this.lightShine.main;
		this.attrackMaxTime = 5f;
		this.attrackRange = 7f;
		this.rangeRow = 5f;
	}

	// Token: 0x060011B3 RID: 4531 RVA: 0x00063EC4 File Offset: 0x000620C4
	[Token(Token = "0x60011B3")]
	[Address(RVA = "0x446730", Offset = "0x444D30", VA = "0x180446730", Slot = "73")]
	protected override Bucket AttrackItem(GameObject item, int theRow)
	{
		int num = 0;
		if (!(item == num))
		{
			Transform transform = item.transform;
			Vector3 vector;
			float z = vector.z;
			LayerMask zombieLayer = this.zombieLayer;
			int num2 = 0;
			int num3 = 0;
			Collider2D[] array;
			if (num2 < array.Length)
			{
				bool flag;
				bool flag2;
				if (flag && flag2)
				{
					PlantType thePlantType = this.thePlantType;
				}
				num3++;
			}
			return base.AttrackItem(item, theRow);
		}
		throw new IndexOutOfRangeException();
	}

	// Token: 0x060011B4 RID: 4532 RVA: 0x00063F34 File Offset: 0x00062134
	[Token(Token = "0x60011B4")]
	[Address(RVA = "0x446C80", Offset = "0x445280", VA = "0x180446C80")]
	public LanternMagnet()
	{
		this.attrackRange = 4f;
		this.attrackMaxTime = 15f;
		this.rangeRow = 2f;
		base..ctor();
	}

	// Token: 0x04000BCB RID: 3019
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000BCB")]
	private ParticleSystem lightShine;
}
