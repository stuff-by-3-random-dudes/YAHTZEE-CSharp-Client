using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace YAHTZEE_CSharp_Client.Classes
{
    class Dice
    {
		private static Random random = new Random();

		private int eyes;

		public int Eyes
		{
			get { return eyes; }
			set 
			{ 
				eyes = value;
				diceButton.Content = eyes;
			}
		}

		private bool isSaved;

		public bool IsSaved
		{
			get { return isSaved; }
			set 
			{ 
				isSaved = value;
				if (isSaved)
				{
					diceButton.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
				}
				else
				{
					diceButton.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
				}
			}
		}

		private Button diceButton;

		public Button DiceButton
		{
			get { return diceButton; }
			set { diceButton = value; }
		}

		public Dice(Button b)
		{
			diceButton = b;
			b.Click += Save;
		}

		public void Save(object sender, RoutedEventArgs e)
		{
			IsSaved = !IsSaved;
		}

		public void Roll()
		{
			if (!IsSaved)
			{
				Eyes = random.Next(1, 7);
			}
		}
		public static void RollAll(List<Dice> dices)
		{
			foreach(Dice d in dices)
			{
				d.Roll();
			}
		}
	}
}
