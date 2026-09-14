using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004CE RID: 1230
[Token(Token = "0x20004CE")]
public class FireSunshroom : Producer
{
	// Token: 0x06001731 RID: 5937 RVA: 0x0007F4F0 File Offset: 0x0007D6F0
	[Token(Token = "0x6001731")]
	[Address(RVA = "0x50E800", Offset = "0x50CE00", VA = "0x18050E800", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (PlantStatus)((ulong)34L);
		base.AttributeCountdown = 120f;
		this.attributeCount = (int)((ulong)12L);
	}

	// Token: 0x06001732 RID: 5938 RVA: 0x0007F524 File Offset: 0x0007D724
	[Token(Token = "0x6001732")]
	[Address(RVA = "0x50EC40", Offset = "0x50D240", VA = "0x18050EC40", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		if (this.thePlantType <= PlantType.SunFlower)
		{
			this.anim.SetFloat("IdleType", 1f);
			return;
		}
	}

	// Token: 0x06001733 RID: 5939 RVA: 0x0007F55C File Offset: 0x0007D75C
	[Token(Token = "0x6001733")]
	[Address(RVA = "0x50ECB0", Offset = "0x50D2B0", VA = "0x18050ECB0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
			float num = this.timer;
			int num2 = 0;
			if (num > (float)num2)
			{
				float deltaTime = Time.deltaTime;
				this.timer = num;
				if (num2 > (int)num)
				{
					PlantType thePlantType = this.thePlantType;
					int num3 = 0;
					if (thePlantType == PlantType.FireSunshroom_a)
					{
						int num4 = 0;
						base.Die((Plant.DieReason)num4);
						CreatePlant instance = CreatePlant.Instance;
						int num5 = 0;
						Plant plant;
						if (!(plant != num5))
						{
							goto IL_0105;
						}
						float attributeCountdown = this.attributeCountdown;
						plant.AttributeCountdown = attributeCountdown;
						if (plant != 0)
						{
							goto IL_0105;
						}
						Transform axis = plant.axis;
						Transform transform = plant.transform;
					}
					if (thePlantType == PlantType.FireSunshroom_b)
					{
						int num6 = 0;
						base.Die((Plant.DieReason)num6);
						CreatePlant instance2 = CreatePlant.Instance;
						int num7 = 0;
						Plant plant2;
						if (plant2 != num7)
						{
							float attributeCountdown2 = this.attributeCountdown;
							plant2.AttributeCountdown = attributeCountdown2;
							if (plant2 == 0)
							{
								Transform axis2 = plant2.axis;
								Vector3 vector;
								float z = vector.z;
								Transform transform2 = plant2.transform;
								Vector3 vector2;
								float z2 = vector2.z;
							}
						}
					}
					IL_0105:
					this.timer = (float)num3;
				}
			}
		}
	}

	// Token: 0x06001734 RID: 5940 RVA: 0x0007F680 File Offset: 0x0007D880
	[Token(Token = "0x6001734")]
	[Address(RVA = "0x50E720", Offset = "0x50CD20", VA = "0x18050E720", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.theStatus = (PlantStatus)((ulong)0L);
		FireSunshroom.<Grow>d__5 <Grow>d__;
		<Grow>d__.System.IDisposable.Dispose();
		<Grow>d__.<>1__state = (int)((ulong)0L);
		<Grow>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Grow>d__);
		GameAPP.PlaySound(56, 0.5f, 1f);
	}

	// Token: 0x06001735 RID: 5941 RVA: 0x0007F6CC File Offset: 0x0007D8CC
	[Token(Token = "0x6001735")]
	[Address(RVA = "0x50EAD0", Offset = "0x50D0D0", VA = "0x18050EAD0")]
	private IEnumerator Grow()
	{
		FireSunshroom.<Grow>d__5 <Grow>d__;
		<Grow>d__.System.IDisposable.Dispose();
		<Grow>d__.<>1__state = (int)((ulong)0L);
		<Grow>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001736 RID: 5942 RVA: 0x0007F6F0 File Offset: 0x0007D8F0
	[Token(Token = "0x6001736")]
	[Address(RVA = "0x50EB40", Offset = "0x50D140", VA = "0x18050EB40", Slot = "69")]
	protected override void ProduceSun()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.3f, 1f);
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x06001737 RID: 5943 RVA: 0x0007F724 File Offset: 0x0007D924
	[Token(Token = "0x6001737")]
	[Address(RVA = "0x50E840", Offset = "0x50CE40", VA = "0x18050E840", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num = this.zombieLayer;
		int num2 = 0;
		int num3 = 0;
		Collider2D[] array;
		if (num2 < array.Length)
		{
			bool flag;
			bool flag2;
			if (flag && flag2)
			{
				int attributeCount = this.attributeCount;
			}
			num3++;
		}
		Transform axis2 = this.axis;
		ParticleManager instance = ParticleManager.Instance;
	}

	// Token: 0x06001738 RID: 5944 RVA: 0x0007F794 File Offset: 0x0007D994
	[Token(Token = "0x6001738")]
	[Address(RVA = "0x50F0C0", Offset = "0x50D6C0", VA = "0x18050F0C0")]
	public FireSunshroom()
	{
	}

	// Token: 0x04000E25 RID: 3621
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000E25")]
	private float timer = 150f;
}
