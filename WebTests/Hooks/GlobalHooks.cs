﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Tests;

namespace WebTests.Hooks
{
	[Binding]
	public class GlobalHooks
	{
		// For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

		[BeforeScenario]
		public void BeforeScenario()
		{
			//TODO: implement logic that has to run before executing each scenario
		}

		[AfterScenario]
		public void AfterScenario()
		{
			Browser.Close();
		}
	}
}
