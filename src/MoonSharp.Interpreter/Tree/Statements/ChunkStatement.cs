﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Antlr4.Runtime;
using MoonSharp.Interpreter.Diagnostics;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using MoonSharp.Interpreter.Grammar;
using MoonSharp.Interpreter.Tree.Statements;

namespace MoonSharp.Interpreter.Tree.Statements
{
	class ChunkStatement : Statement
	{
		Statement m_Block;
		RuntimeScopeFrame m_StackFrame;

		public ChunkStatement(LuaParser.ChunkContext context, ScriptLoadingContext lcontext)
			: base(context, lcontext)
		{
			lcontext.Scope.PushFunction();
			m_Block = NodeFactory.CreateStatement(context.block(), lcontext);
			m_StackFrame = lcontext.Scope.PopFunction();
		}

		public override void Compile(Execution.VM.ByteCode bc)
		{
			bc.BeginFn(m_StackFrame, "<chunk-root>");
			m_Block.Compile(bc);
			bc.Ret(0);
			//bc.Leave(m_StackFrame);
		}
	}
}
