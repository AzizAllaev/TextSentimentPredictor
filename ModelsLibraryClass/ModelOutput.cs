using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibraryClass
{
	public class ModelOutput
	{
		public float PredictedLabel { get; set; }
		public float[] Score { get; set; }
	}

}
