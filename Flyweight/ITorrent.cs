﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	public interface ITorrent
	{
		void Start();
		void Cancel();
		void Pause();

	}
}
