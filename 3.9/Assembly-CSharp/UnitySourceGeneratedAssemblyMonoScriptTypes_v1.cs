using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

// Token: 0x02000A44 RID: 2628
[Token(Token = "0x2000A44")]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
[EditorBrowsable(EditorBrowsableState.Never)]
[CompilerGenerated]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	// Token: 0x060035F3 RID: 13811 RVA: 0x0011F164 File Offset: 0x0011D364
	[Token(Token = "0x60035F3")]
	[Address(RVA = "0x7AF800", Offset = "0x7ADE00", VA = "0x1807AF800")]
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
	{
		RuntimeHelpers.InitializeArray(new byte[109189], fieldof(<PrivateImplementationDetails>.0BF14B28BD3E23EB0E2E9A7E3C20CAF44D40BB5CD4A7FE54295A5EF181F46E6E).FieldHandle);
		RuntimeHelpers.InitializeArray(new byte[66558], fieldof(<PrivateImplementationDetails>.BFCC76BAD263DD6723CBA783DC80BCBDB105BA5EFDE4AA5E267E4819E0646155).FieldHandle);
		return default(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData);
	}

	// Token: 0x060035F4 RID: 13812 RVA: 0x0011F1A4 File Offset: 0x0011D3A4
	[Token(Token = "0x60035F4")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}

	// Token: 0x02000A45 RID: 2629
	[Token(Token = "0x2000A45")]
	private struct MonoScriptData
	{
		// Token: 0x04002962 RID: 10594
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4002962")]
		public byte[] FilePathsData;

		// Token: 0x04002963 RID: 10595
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4002963")]
		public byte[] TypesData;

		// Token: 0x04002964 RID: 10596
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002964")]
		public int TotalTypes;

		// Token: 0x04002965 RID: 10597
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4002965")]
		public int TotalFiles;

		// Token: 0x04002966 RID: 10598
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002966")]
		public bool IsEditorOnly;
	}
}
