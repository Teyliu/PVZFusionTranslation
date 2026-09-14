using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200084B RID: 2123
[Token(Token = "0x200084B")]
public class Hammer : InGameTool, IDamageMaker
{
	// Token: 0x06002B3A RID: 11066 RVA: 0x000ED594 File Offset: 0x000EB794
	[Token(Token = "0x6002B3A")]
	[Address(RVA = "0x665D00", Offset = "0x664300", VA = "0x180665D00")]
	private void Awake()
	{
		Hammer.Instance = this;
	}

	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x06002B3B RID: 11067 RVA: 0x000ED5A8 File Offset: 0x000EB7A8
	// (set) Token: 0x06002B3C RID: 11068 RVA: 0x000ED5C0 File Offset: 0x000EB7C0
	[Token(Token = "0x170001B6")]
	public Team Team
	{
		[Token(Token = "0x6002B3B")]
		[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "12")]
		get
		{
			return Team.Player;
		}
		[Token(Token = "0x6002B3C")]
		[Address(RVA = "0x666AE0", Offset = "0x6650E0", VA = "0x180666AE0", Slot = "13")]
		set
		{
			NotImplementedException ex = new NotImplementedException();
		}
	}

	// Token: 0x06002B3D RID: 11069 RVA: 0x000ED5D4 File Offset: 0x000EB7D4
	[Token(Token = "0x6002B3D")]
	[Address(RVA = "0x666290", Offset = "0x664890", VA = "0x180666290")]
	public bool SwitchType(PlantType plantType)
	{
		if (this.theHammerEffect == plantType)
		{
		}
		this.theHammerEffect = plantType;
		if (plantType == PlantType.CherryBomb)
		{
		}
		if (plantType == PlantType.IceShroom)
		{
		}
		if ("锤击附带红温" != 0)
		{
			InGameText instance = InGameText.Instance;
			int num = 0;
			instance.ShowText("锤击附带红温", 5f, num != 0);
		}
		return true;
	}

	// Token: 0x06002B3E RID: 11070 RVA: 0x000ED62C File Offset: 0x000EB82C
	[Token(Token = "0x6002B3E")]
	[Address(RVA = "0x666370", Offset = "0x664970", VA = "0x180666370")]
	private void SwitchUpdate()
	{
		if (!Input.GetKeyDownInt((KeyCode)((uint)49)))
		{
			if (!Input.GetKeyDownInt((KeyCode)((uint)50)))
			{
				if (Input.GetKeyDownInt((KeyCode)((uint)101)) && this.theHammerEffect != PlantType.Jalapeno)
				{
					this.theHammerEffect = (PlantType)((ulong)16L);
					if ("锤击附带红温" != 0)
					{
						InGameText instance = InGameText.Instance;
						int num = 0;
						instance.ShowText("锤击附带红温", 5f, num != 0);
						return;
					}
				}
			}
			else if (this.theHammerEffect != PlantType.IceShroom)
			{
				this.theHammerEffect = (PlantType)((ulong)10L);
				if ("锤击附带减速" != 0)
				{
					InGameText instance2 = InGameText.Instance;
					int num2 = 0;
					instance2.ShowText("锤击附带减速", 5f, num2 != 0);
					return;
				}
			}
			return;
		}
		bool flag = this.SwitchType((PlantType)((uint)2));
	}

	// Token: 0x06002B3F RID: 11071 RVA: 0x000ED6E8 File Offset: 0x000EB8E8
	[Token(Token = "0x6002B3F")]
	[Address(RVA = "0x665E30", Offset = "0x664430", VA = "0x180665E30")]
	public void EffectZombie(Zombie zombie)
	{
		PlantType plantType = this.theHammerEffect;
		if (plantType == PlantType.CherryBomb)
		{
			BoardAction boardAction = Board.Instance.boardAction;
			Collider2D col = zombie.col;
			return;
		}
		if (plantType == PlantType.IceShroom)
		{
			int num = 0;
			int num2 = 0;
			zombie.SetCold(15f, num2, num != 0);
			int num3 = 0;
			zombie.AddfreezeLevel(50, num3);
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002B40 RID: 11072 RVA: 0x000ED744 File Offset: 0x000EB944
	[Token(Token = "0x6002B40")]
	[Address(RVA = "0x6661F0", Offset = "0x6647F0", VA = "0x1806661F0", Slot = "6")]
	protected override void Start()
	{
		base.Start();
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		Board instance = Board.Instance;
		float num = this.fullCD * 3f;
		this.fullCD = num;
	}

	// Token: 0x06002B41 RID: 11073 RVA: 0x000ED788 File Offset: 0x000EB988
	[Token(Token = "0x6002B41")]
	[Address(RVA = "0x665FA0", Offset = "0x6645A0", VA = "0x180665FA0", Slot = "7")]
	protected override void OnUpdate()
	{
		if (Input.GetKeyDownInt(KeyCodeManager.Hammer))
		{
			Mouse mouse = this.mouse;
			bool flag = base.OnClick(mouse);
		}
		if (!Input.GetKeyDownInt((KeyCode)((uint)49)))
		{
			if (!Input.GetKeyDownInt((KeyCode)((uint)50)))
			{
				if (Input.GetKeyDownInt((KeyCode)((uint)101)) && this.theHammerEffect != PlantType.Jalapeno)
				{
					this.theHammerEffect = (PlantType)((ulong)16L);
					if ("锤击附带红温" != 0)
					{
						InGameText instance = InGameText.Instance;
						int num = 0;
						instance.ShowText("锤击附带红温", 5f, num != 0);
						return;
					}
				}
			}
			else if ("锤击附带减速" != 0)
			{
				InGameText instance2 = InGameText.Instance;
				int num2 = 0;
				instance2.ShowText("锤击附带减速", 5f, num2 != 0);
				return;
			}
		}
	}

	// Token: 0x06002B42 RID: 11074 RVA: 0x000ED840 File Offset: 0x000EBA40
	[Token(Token = "0x6002B42")]
	[Address(RVA = "0x666500", Offset = "0x664B00", VA = "0x180666500", Slot = "11")]
	protected override void UpdateCDTimer()
	{
		if (global::Lawnf.TravelAdvanced((AdvBuff)((uint)1005)))
		{
			float num = Time.deltaTime * 9f;
			this.CD = num;
		}
	}

	// Token: 0x06002B43 RID: 11075 RVA: 0x000ED870 File Offset: 0x000EBA70
	[Token(Token = "0x6002B43")]
	[Address(RVA = "0x665DA0", Offset = "0x6643A0", VA = "0x180665DA0")]
	public void CrushZombie()
	{
		this.anim.SetTrigger("crush");
		GameAPP.PlaySound(93, 0.5f, 1f);
		this.isPickUp = false;
	}

	// Token: 0x06002B44 RID: 11076 RVA: 0x000ED8AC File Offset: 0x000EBAAC
	[Token(Token = "0x6002B44")]
	[Address(RVA = "0x665A00", Offset = "0x664000", VA = "0x180665A00")]
	private void AnimCrush()
	{
		Board instance = Board.Instance;
		Transform transform = base.transform;
		base.PutDown();
		int mask = LayerMask.GetMask(new string[] { "Zombie" });
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		Collider2D[] array;
		if (num2 < array.Length)
		{
			bool flag;
			bool flag2;
			if (!flag || flag2)
			{
			}
			num3++;
		}
		if (num != 0)
		{
			uint num4;
			GameAPP.PlaySound((int)num4, 0.5f, 1f);
		}
	}

	// Token: 0x06002B45 RID: 11077 RVA: 0x000ED938 File Offset: 0x000EBB38
	[Token(Token = "0x6002B45")]
	[Address(RVA = "0x665D60", Offset = "0x664360", VA = "0x180665D60", Slot = "14")]
	public bool CanAttack(IDamageable target)
	{
		NotImplementedException ex = new NotImplementedException();
		return false;
	}

	// Token: 0x06002B46 RID: 11078 RVA: 0x000ED94C File Offset: 0x000EBB4C
	[Token(Token = "0x6002B46")]
	[Address(RVA = "0x666550", Offset = "0x664B50", VA = "0x180666550", Slot = "9")]
	public override void Use(Mouse mouse)
	{
		int num = 0;
		this.anim.SetTrigger("crush");
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		Board board = this.board;
		this.isPickUp = num != 0;
		Vector2 mousePosition = mouse.MousePosition;
		Camera main = Camera.main;
		float z = Input.mousePosition.z;
		Vector3 vector;
		float z2 = vector.z;
		int mask = LayerMask.GetMask(new string[] { "Zombie" });
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
			}
			num++;
			int num3 = 0;
			int num4;
			if (!(num != num3))
			{
				num4 = 0;
				if (!(num != num4))
				{
				}
			}
			num4 += num4;
			num4 += 200;
			int num5 = num.System.IConvertible.ToInt32(num4);
			if (this.theHammerEffect == PlantType.CherryBomb)
			{
				BoardAction boardAction = Board.Instance.boardAction;
			}
			BombCherry bombCherry;
			if (bombCherry == (ulong)10L)
			{
			}
			uint num6;
			GameAPP.PlaySound((int)num6, 0.5f, 1f);
			base.PutDown();
		}
	}

	// Token: 0x06002B47 RID: 11079 RVA: 0x000EDA60 File Offset: 0x000EBC60
	[Token(Token = "0x6002B47")]
	[Address(RVA = "0x6659E0", Offset = "0x663FE0", VA = "0x1806659E0")]
	public Hammer()
	{
		this.fullCD = 10f;
		this.avaliable = true;
		this.coolSpeed = 1f;
		base..ctor();
	}

	// Token: 0x0400196D RID: 6509
	[Token(Token = "0x400196D")]
	public static Hammer Instance;

	// Token: 0x0400196E RID: 6510
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400196E")]
	public PlantType theHammerEffect;

	// Token: 0x0400196F RID: 6511
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400196F")]
	private Animator anim;
}
