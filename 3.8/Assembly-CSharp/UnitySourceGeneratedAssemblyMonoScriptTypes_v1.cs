using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

// Token: 0x02000A05 RID: 2565
[Token(Token = "0x2000A05")]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
[EditorBrowsable(EditorBrowsableState.Never)]
[CompilerGenerated]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	// Token: 0x060034B2 RID: 13490 RVA: 0x0011A020 File Offset: 0x00118220
	[Token(Token = "0x60034B2")]
	[Address(RVA = "0x748ED0", Offset = "0x7474D0", VA = "0x180748ED0")]
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
	{
		RuntimeHelpers.InitializeArray(new byte[104889], fieldof(<PrivateImplementationDetails>.BD3255170CDCBD6BA0A8AE3840A4FFE457BBBC9057094C8C4B5EB94E80E731E6).FieldHandle);
		RuntimeHelpers.InitializeArray(new byte[59834], fieldof(<PrivateImplementationDetails>.A53D9BD738227D4C8F703E2E4A91AB4A0EC3D3516B48322C2424032DDE28A78D).FieldHandle);
		return default(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData);
	}

	// Token: 0x060034B3 RID: 13491 RVA: 0x0011A060 File Offset: 0x00118260
	[Token(Token = "0x60034B3")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}

	// Token: 0x02000A06 RID: 2566
	[Token(Token = "0x2000A06")]
	private struct MonoScriptData
	{
		// Token: 0x040027F4 RID: 10228
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40027F4")]
		public byte[] FilePathsData;

		// Token: 0x040027F5 RID: 10229
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40027F5")]
		public byte[] TypesData;

		// Token: 0x040027F6 RID: 10230
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40027F6")]
		public int TotalTypes;

		// Token: 0x040027F7 RID: 10231
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40027F7")]
		public int TotalFiles;

		// Token: 0x040027F8 RID: 10232
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40027F8")]
		public bool IsEditorOnly;
	}
}
