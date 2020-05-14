using System;
using System.Collections.Generic;
using YAHTZEE_CSharp_Client.Classes;

namespace YAHTZEE_CSharp_Client
{
    class MainViewModel : BaseModel
    {
        private List<Player> playerList = new List<Player>();

        public List<Player> PlayerList
        {
            get { return playerList; }
            set
            {
                playerList = value;
                OnPropertyChanged();
            }
        }

        public Player SelectedPlayer { get; set; }

        public MainViewModel()
        {

        }

        public void RemoveSelectedPlayer()
        {
            if (SelectedPlayer == null)
            {
                // ToDo Exception mit richtiger sprache aus der datei
                throw new YahtzeeException("Es wurde kein Spieler zum löschen ausgewählt.");
            }
            else
            {
                PlayerList.Remove(SelectedPlayer);
                UpdatePlayerList();
            }
        }

        public void AddPlayer(string name)
        {
            if (!String.IsNullOrWhiteSpace(name))
            {
                if (PlayerList.Exists((item) => item.Name.Equals(name)))
                {
                    // ToDo richtige sprache aus der datei
                    throw new YahtzeeException($"Der Name '{name}' ist schon vergeben.");
                }
                else
                {
                    PlayerList.Add(new Player(name));
                    UpdatePlayerList();
                }
            }
        }

        public void ResetPlayerList()
        {
            PlayerList = new List<Player>();
        }

        public void UpdatePlayerList()
        {
            var save = PlayerList;
            PlayerList = null;
            PlayerList = save;
            //OnPropertyChanged("PlayerList");
        }
    }
}
