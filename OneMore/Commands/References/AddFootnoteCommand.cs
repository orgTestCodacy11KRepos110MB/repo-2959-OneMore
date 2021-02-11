﻿//************************************************************************************************
// Copyright © 2020 Steven M Cohn.  All rights reserved.
//************************************************************************************************

namespace River.OneMoreAddIn
{
	using System.Threading.Tasks;


	internal class AddFootnoteCommand : Command
	{

		public AddFootnoteCommand()
		{
		}


		public override async Task Execute(params object[] args)
		{
			using (var one = new OneNote())
			{
				await new FootnoteEditor(one).AddFootnote();
			}
		}
	}
}
