﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace MoonSharp.Interpreter.Tests
{
	[TestFixture]
	public class TestMoreTests
	{
		[Test]
		public void TestMore_000_sanity()
		{
			TapRunner.Run(@"TestMore\000-sanity.t");
		}


		[Test]
		public void TestMore_001_if()
		{
			TapRunner.Run(@"TestMore\001-if.t");
		}


		[Test]
		public void TestMore_002_table()
		{
			TapRunner.Run(@"TestMore\002-table.t");
		}


		[Test]
		public void TestMore_011_while()
		{
			TapRunner.Run(@"TestMore\011-while.t");
		}


		[Test]
		public void TestMore_012_repeat()
		{
			TapRunner.Run(@"TestMore\012-repeat.t");
		}


		[Test]
		public void TestMore_014_fornum()
		{
			TapRunner.Run(@"TestMore\014-fornum.t");
		}


		[Test]
		public void TestMore_015_forlist()
		{
			TapRunner.Run(@"TestMore\015-forlist.t");
		}


		[Test]
		//[Ignore]
		public void TestMore_101_boolean()
		{
			TapRunner.Run(@"TestMore\101-boolean.t");
		}


		[Test]
		[Ignore]
		public void TestMore_102_function()
		{
			TapRunner.Run(@"TestMore\102-function.t");
		}


		[Test]
		[Ignore]
		public void TestMore_103_nil()
		{
			TapRunner.Run(@"TestMore\103-nil.t");
		}


		[Test]
		[Ignore]
		public void TestMore_104_number()
		{
			TapRunner.Run(@"TestMore\104-number.t");
		}


		[Test]
		[Ignore]
		public void TestMore_105_string()
		{
			TapRunner.Run(@"TestMore\105-string.t");
		}


		[Test]
		[Ignore]
		public void TestMore_106_table()
		{
			TapRunner.Run(@"TestMore\106-table.t");
		}


		[Test]
		[Ignore]
		public void TestMore_107_thread()
		{
			TapRunner.Run(@"TestMore\107-thread.t");
		}


		[Test]
		[Ignore]
		public void TestMore_108_userdata()
		{
			TapRunner.Run(@"TestMore\108-userdata.t");
		}


		[Test]
		[Ignore]
		public void TestMore_200_examples()
		{
			TapRunner.Run(@"TestMore\200-examples.t");
		}


		[Test]
		[Ignore]
		public void TestMore_201_assign()
		{
			TapRunner.Run(@"TestMore\201-assign.t");
		}


		[Test]
		[Ignore]
		public void TestMore_202_expr()
		{
			TapRunner.Run(@"TestMore\202-expr.t");
		}


		[Test]
		[Ignore]
		public void TestMore_203_lexico()
		{
			TapRunner.Run(@"TestMore\203-lexico.t");
		}


		[Test]
		[Ignore]
		public void TestMore_211_scope()
		{
			TapRunner.Run(@"TestMore\211-scope.t");
		}


		[Test]
		[Ignore]
		public void TestMore_212_function()
		{
			TapRunner.Run(@"TestMore\212-function.t");
		}


		[Test]
		[Ignore]
		public void TestMore_213_closure()
		{
			TapRunner.Run(@"TestMore\213-closure.t");
		}


		[Test]
		[Ignore]
		public void TestMore_214_coroutine()
		{
			TapRunner.Run(@"TestMore\214-coroutine.t");
		}


		[Test]
		[Ignore]
		public void TestMore_221_table()
		{
			TapRunner.Run(@"TestMore\221-table.t");
		}


		[Test]
		[Ignore]
		public void TestMore_222_constructor()
		{
			TapRunner.Run(@"TestMore\222-constructor.t");
		}


		[Test]
		[Ignore]
		public void TestMore_223_iterator()
		{
			TapRunner.Run(@"TestMore\223-iterator.t");
		}


		[Test]
		[Ignore]
		public void TestMore_231_metatable()
		{
			TapRunner.Run(@"TestMore\231-metatable.t");
		}


		[Test]
		[Ignore]
		public void TestMore_232_object()
		{
			TapRunner.Run(@"TestMore\232-object.t");
		}


		[Test]
		[Ignore]
		public void TestMore_241_standalone()
		{
			TapRunner.Run(@"TestMore\241-standalone.t");
		}


		[Test]
		[Ignore]
		public void TestMore_301_basic()
		{
			TapRunner.Run(@"TestMore\301-basic.t");
		}


		[Test]
		[Ignore]
		public void TestMore_303_package()
		{
			TapRunner.Run(@"TestMore\303-package.t");
		}


		[Test]
		[Ignore]
		public void TestMore_304_string()
		{
			TapRunner.Run(@"TestMore\304-string.t");
		}


		[Test]
		[Ignore]
		public void TestMore_305_table()
		{
			TapRunner.Run(@"TestMore\305-table.t");
		}


		[Test]
		[Ignore]
		public void TestMore_306_math()
		{
			TapRunner.Run(@"TestMore\306-math.t");
		}


		[Test]
		[Ignore]
		public void TestMore_307_io()
		{
			TapRunner.Run(@"TestMore\307-io.t");
		}


		[Test]
		[Ignore]
		public void TestMore_308_os()
		{
			TapRunner.Run(@"TestMore\308-os.t");
		}


		[Test]
		[Ignore]
		public void TestMore_310_stdin()
		{
			TapRunner.Run(@"TestMore\310-stdin.t");
		}


		[Test]
		[Ignore]
		public void TestMore_314_regex()
		{
			TapRunner.Run(@"TestMore\314-regex.t");
		}
	}
}
