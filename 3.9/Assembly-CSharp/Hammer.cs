using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000887 RID: 2183
[Token(Token = "0x2000887")]
public class Hammer : InGameTool, IDamageMaker
{
	// Token: 0x06002C6C RID: 11372 RVA: 0x000F22A0 File Offset: 0x000F04A0
	[Token(Token = "0x6002C6C")]
	[Address(RVA = "0x6CA870", Offset = "0x6C8E70", VA = "0x1806CA870")]
	private void Awake()
	{
		Hammer.Instance = this;
	}

	// Token: 0x170001FE RID: 510
	// (get) Token: 0x06002C6D RID: 11373 RVA: 0x000F22B4 File Offset: 0x000F04B4
	// (set) Token: 0x06002C6E RID: 11374 RVA: 0x000F22CC File Offset: 0x000F04CC
	[Token(Token = "0x170001FE")]
	public Team Team
	{
		[Token(Token = "0x6002C6D")]
		[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "12")]
		get
		{
			return Team.Player;
		}
		[Token(Token = "0x6002C6E")]
		[Address(RVA = "0x6CB5E0", Offset = "0x6C9BE0", VA = "0x1806CB5E0", Slot = "13")]
		set
		{
			NotImplementedException ex = new NotImplementedException();
		}
	}

	// Token: 0x06002C6F RID: 11375 RVA: 0x000F22E0 File Offset: 0x000F04E0
	[Token(Token = "0x6002C6F")]
	[Address(RVA = "0x6CAD90", Offset = "0x6C9390", VA = "0x1806CAD90")]
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
		}
		return true;
	}

	// Token: 0x06002C70 RID: 11376 RVA: 0x000F2324 File Offset: 0x000F0524
	[Token(Token = "0x6002C70")]
	[Address(RVA = "0x6CAE80", Offset = "0x6C9480", VA = "0x1806CAE80")]
	private void SwitchUpdate()
	{
		if (Input.GetKeyDownInt((KeyCode)((uint)49)))
		{
			bool flag = this.SwitchType((PlantType)((uint)2));
			return;
		}
		if (!Input.GetKeyDownInt((KeyCode)((uint)50)))
		{
			if (Input.GetKeyDownInt((KeyCode)((uint)101)) && this.theHammerEffect != PlantType.Jalapeno)
			{
				this.theHammerEffect = (PlantType)((ulong)16L);
				if ("锤击附带红温" != 0)
				{
					InGameText instance = InGameText.Instance;
					return;
				}
			}
			return;
		}
		bool flag2 = this.SwitchType((PlantType)((uint)10));
	}

	// Token: 0x06002C71 RID: 11377 RVA: 0x000F2394 File Offset: 0x000F0594
	[Token(Token = "0x6002C71")]
	[Address(RVA = "0x6CA9A0", Offset = "0x6C8FA0", VA = "0x1806CA9A0")]
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

	// Token: 0x06002C72 RID: 11378 RVA: 0x000F23F0 File Offset: 0x000F05F0
	[Token(Token = "0x6002C72")]
	[Address(RVA = "0x6CACF0", Offset = "0x6C92F0", VA = "0x1806CACF0", Slot = "6")]
	protected override void Start()
	{
		base.Start();
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		Board instance = Board.Instance;
		float num = this.fullCD * 3f;
		this.fullCD = num;
	}

	// Token: 0x06002C73 RID: 11379 RVA: 0x000F2434 File Offset: 0x000F0634
	[Token(Token = "0x6002C73")]
	[Address(RVA = "0x6CAB10", Offset = "0x6C9110", VA = "0x1806CAB10", Slot = "7")]
	protected override void OnUpdate()
	{
		if (Input.GetKeyDownInt(KeyCodeManager.Hammer))
		{
			Mouse mouse = this.mouse;
			bool flag = base.OnClick(mouse);
		}
		if (Input.GetKeyDownInt((KeyCode)((uint)49)))
		{
			return;
		}
		if (!Input.GetKeyDownInt((KeyCode)((uint)50)))
		{
			if (Input.GetKeyDownInt((KeyCode)((uint)101)) && this.theHammerEffect != PlantType.Jalapeno)
			{
				this.theHammerEffect = (PlantType)((ulong)16L);
				if ("锤击附带红温" != 0)
				{
					InGameText instance = InGameText.Instance;
					return;
				}
			}
			return;
		}
	}

	// Token: 0x06002C74 RID: 11380 RVA: 0x000F24AC File Offset: 0x000F06AC
	[Token(Token = "0x6002C74")]
	[Address(RVA = "0x6CAFA0", Offset = "0x6C95A0", VA = "0x1806CAFA0", Slot = "11")]
	protected override void UpdateCDTimer()
	{
		if (global::Lawnf.TravelAdvanced((AdvBuff)((uint)1005)))
		{
			float num = Time.deltaTime * 9f;
			this.CD = num;
		}
	}

	// Token: 0x06002C75 RID: 11381 RVA: 0x000F24DC File Offset: 0x000F06DC
	[Token(Token = "0x6002C75")]
	[Address(RVA = "0x6CA910", Offset = "0x6C8F10", VA = "0x1806CA910")]
	public void CrushZombie()
	{
		this.anim.SetTrigger("crush");
		GameAPP.PlaySound(93, 0.5f, 1f);
		this.isPickUp = false;
	}

	// Token: 0x06002C76 RID: 11382 RVA: 0x000F2518 File Offset: 0x000F0718
	[Token(Token = "0x6002C76")]
	[Address(RVA = "0x6CA570", Offset = "0x6C8B70", VA = "0x1806CA570")]
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

	// Token: 0x06002C77 RID: 11383 RVA: 0x000F25A4 File Offset: 0x000F07A4
	[Token(Token = "0x6002C77")]
	[Address(RVA = "0x6CA8D0", Offset = "0x6C8ED0", VA = "0x1806CA8D0", Slot = "14")]
	public bool CanAttack(IDamageable target)
	{
		NotImplementedException ex = new NotImplementedException();
		return false;
	}

	// Token: 0x06002C78 RID: 11384 RVA: 0x000F25B8 File Offset: 0x000F07B8
	[Token(Token = "0x6002C78")]
	[Address(RVA = "0x6CAFF0", Offset = "0x6C95F0", VA = "0x1806CAFF0", Slot = "9")]
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
			if (!(num != num3))
			{
				int num4 = 0;
				if (!(num != num4))
				{
				}
			}
			int num5;
			num5 += num5;
			num5 += 200;
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

	// Token: 0x06002C79 RID: 11385 RVA: 0x000F26C0 File Offset: 0x000F08C0
	[Token(Token = "0x6002C79")]
	[Address(RVA = "0x6CA550", Offset = "0x6C8B50", VA = "0x1806CA550")]
	public Hammer()
	{
		this.fullCD = 10f;
		this.avaliable = true;
		this.coolSpeed = 1f;
		base..ctor();
	}

	// Token: 0x04001A5B RID: 6747
	[Token(Token = "0x4001A5B")]
	public static Hammer Instance;

	// Token: 0x04001A5C RID: 6748
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001A5C")]
	public PlantType theHammerEffect;

	// Token: 0x04001A5D RID: 6749
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001A5D")]
	private Animator anim;
}
