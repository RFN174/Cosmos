using System;
using System.IO;
using Mono.Cecil.Cil;
using CPU = Indy.IL2CPU.Assembler.X86;

namespace Indy.IL2CPU.IL.X86 {
	public class Refanyval: IL.Refanyval {
		public override void Assemble(Instruction aInstruction, BinaryWriter aOutput) {
			throw new NotImplementedException("This file has been autogenerated and not been changed afterwards!");
		}
	}
}