using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003E2 RID: 994
[Token(Token = "0x20003E2")]
public class LanternUmbrella : CornUmbrella
{
	// Token: 0x06001222 RID: 4642 RVA: 0x00065890 File Offset: 0x00063A90
	[Token(Token = "0x6001222")]
	[Address(RVA = "0x49BB00", Offset = "0x49A100", VA = "0x18049BB00", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		int num = this.maxEnergy;
		this.attributeCount = num;
	}

	// Token: 0x06001223 RID: 4643 RVA: 0x000658B4 File Offset: 0x00063AB4
	[Token(Token = "0x6001223")]
	[Address(RVA = "0x49BB30", Offset = "0x49A130", VA = "0x18049BB30", Slot = "70")]
	protected override void BlockEffect(Zombie zombie)
	{
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(40, this, (DamageType)((uint)4), thePlantType, num != 0UL);
		Plant umbrellaPot = base.UmbrellaPot;
		int num2 = 0;
		if (!(umbrellaPot == num2))
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001224 RID: 4644 RVA: 0x000658F0 File Offset: 0x00063AF0
	[Token(Token = "0x6001224")]
	[Address(RVA = "0x49C040", Offset = "0x49A640", VA = "0x18049C040", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		GameAPP.PlaySound(85, 0.5f, 1f);
		Transform axis = this.axis;
		GameObject gameObject = GameAPP.particlePrefab[40];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		this.lanternLight = gameObject2;
		ParticleSystem component = this.lanternLight.GetComponent<ParticleSystem>();
		this.par = component;
		Transform transform2 = this.lanternLight.transform;
		int num = 0;
		this.UseEnergy(num);
	}

	// Token: 0x06001225 RID: 4645 RVA: 0x00065978 File Offset: 0x00063B78
	[Token(Token = "0x6001225")]
	[Address(RVA = "0x49C4F0", Offset = "0x49AAF0", VA = "0x18049C4F0")]
	public void UseEnergy(int cost)
	{
		GameObject gameObject = this.lanternLight;
		int num = 0;
		if (!(gameObject == num))
		{
			int num2 = this.attributeCount;
			GameObject gameObject2 = this.lanternLight;
			num2 -= cost;
			this.attributeCount = num2;
			if (num2 > 0)
			{
				ulong num3;
				gameObject2.SetActive(num3 != 0UL);
			}
			this.attributeCount = (int)((ulong)0L);
			int num4 = 0;
			gameObject2.SetActive(num4 != 0);
			this.recoverEnergyTimer = 5f;
			int num5 = this.maxEnergy;
			this.attributeCount = num5;
			if (0 * (int)0.1f <= (int)1f)
			{
			}
			ParticleSystem.MainModule main = this.par.main;
			ParticleSystem.MinMaxGradient minMaxGradient;
			Gradient gradientMax = minMaxGradient.m_GradientMax;
			float b = minMaxGradient.m_ColorMin.b;
			if (cost > 0)
			{
				base.FlashOnce();
			}
			base.UpdateText();
		}
	}

	// Token: 0x06001226 RID: 4646 RVA: 0x00065A40 File Offset: 0x00063C40
	[Token(Token = "0x6001226")]
	[Address(RVA = "0x49BCE0", Offset = "0x49A2E0", VA = "0x18049BCE0", Slot = "31")]
	protected override int GetDamage(int damage)
	{
		int num = base.GetDamage(damage);
		num -= damage;
		this.UseEnergy(damage);
		return num;
	}

	// Token: 0x06001227 RID: 4647 RVA: 0x00065A64 File Offset: 0x00063C64
	[Token(Token = "0x6001227")]
	[Address(RVA = "0x49C3A0", Offset = "0x49A9A0", VA = "0x18049C3A0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Transform transform = this.lanternLight.transform;
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		float num = this.recoverEnergyTimer;
		float deltaTime = Time.deltaTime;
		this.recoverEnergyTimer = num;
		this.recoverEnergyTimer = 1f;
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)22)))
		{
		}
		int num2 = this.shootingLevel;
		int num3 = this.theLevel;
		num2++;
		num3++;
		long num5;
		int num4 = (int)((long)(num2 * num3) * num5);
		this.UseEnergy(num4);
	}

	// Token: 0x06001228 RID: 4648 RVA: 0x00065AFC File Offset: 0x00063CFC
	[Token(Token = "0x6001228")]
	[Address(RVA = "0x49BF90", Offset = "0x49A590", VA = "0x18049BF90")]
	protected void RecoverEnergyUpdate()
	{
		float num = this.recoverEnergyTimer;
		float deltaTime = Time.deltaTime;
		this.recoverEnergyTimer = num;
		this.recoverEnergyTimer = 1f;
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)22)))
		{
		}
		int num2 = this.shootingLevel;
		int num3 = this.theLevel;
		num2++;
		num3++;
		long num5;
		int num4 = (int)((long)(num2 * num3) * num5);
		this.UseEnergy(num4);
	}

	// Token: 0x06001229 RID: 4649 RVA: 0x00065B68 File Offset: 0x00063D68
	[Token(Token = "0x6001229")]
	[Address(RVA = "0x49BC20", Offset = "0x49A220", VA = "0x18049BC20", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		CreatePlant instance = CreatePlant.Instance;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		ulong num;
		instance.AdjustLightLevel(thePlantColumn, thePlantRow, -1, (int)num);
		global::UnityEngine.Object.Destroy(this.lanternLight);
	}

	// Token: 0x0600122A RID: 4650 RVA: 0x00065BA8 File Offset: 0x00063DA8
	[Token(Token = "0x600122A")]
	[Address(RVA = "0x49BEC0", Offset = "0x49A4C0", VA = "0x18049BEC0", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, originalRow, -1, (int)num);
		ulong num2;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, (int)num2, 1, (int)num);
	}

	// Token: 0x0600122B RID: 4651 RVA: 0x00065BD8 File Offset: 0x00063DD8
	[Token(Token = "0x600122B")]
	[Address(RVA = "0x49BE10", Offset = "0x49A410", VA = "0x18049BE10", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		base.OnCreate(theColumn, theRow);
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(theColumn, theRow, 1, (int)num);
	}

	// Token: 0x0600122C RID: 4652 RVA: 0x00065C04 File Offset: 0x00063E04
	[Token(Token = "0x600122C")]
	[Address(RVA = "0x49BD40", Offset = "0x49A340", VA = "0x18049BD40", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x0600122D RID: 4653 RVA: 0x00065C24 File Offset: 0x00063E24
	[Token(Token = "0x600122D")]
	[Address(RVA = "0x49C6F0", Offset = "0x49ACF0", VA = "0x18049C6F0")]
	public LanternUmbrella()
	{
	}

	// Token: 0x04000C34 RID: 3124
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C34")]
	private float recoverEnergyTimer = 1f;

	// Token: 0x04000C35 RID: 3125
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000C35")]
	public int maxEnergy = (int)((ulong)2000L);

	// Token: 0x04000C36 RID: 3126
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000C36")]
	protected GameObject lanternLight;

	// Token: 0x04000C37 RID: 3127
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000C37")]
	private Vector3 lightPos;

	// Token: 0x04000C38 RID: 3128
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000C38")]
	private ParticleSystem par;
}
