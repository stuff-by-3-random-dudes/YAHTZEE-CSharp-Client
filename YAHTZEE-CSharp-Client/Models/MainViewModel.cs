using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using YAHTZEE_CSharp_Client.Classes;

namespace YAHTZEE_CSharp_Client
{
    class MainViewModel : BaseModel
    {
        private List<Player> playerList = new List<Player>();

        public List<Player> PlayerList
        {
            get { return playerList; }
            set { playerList = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {

        }

        public void AddPlayer(Player p)
        {
            
            PlayerList.Add(p);
            var save = PlayerList;
            PlayerList = null;
            PlayerList = save;
            //OnPropertyChanged("PlayerList");
        }

        public void ResetPlayerList()
        {
            PlayerList = new List<Player>();
        }
    }
}
