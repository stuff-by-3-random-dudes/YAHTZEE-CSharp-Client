using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAHTZEE_CSharp_Client.Classes
{
    class Player
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private ResultTable result = new ResultTable();

		public ResultTable Result
		{
			get { return result; }
			set { result = value; }
		}

		public Player(string pname)
		{
			Name = pname;
		}
		public Player(string pname, ResultTable table) : this(pname)
		{
			Result = table;
		}
	}
}
