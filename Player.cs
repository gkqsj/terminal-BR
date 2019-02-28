using namespace Player;
 class Player
    {
        int PosX;
        int PosY;
        int HealthPoints;
        String PlayerName;
        int PlayerNumber;

        public Player(string newPlayerName, int Pcont, int Qlinhas, int Qcolunas)
        {
            this.HealthPoints = 100;
            this.PlayerName = newPlayerName;
            this.PlayerNumber = Pcont;

            if(Pcont == 1)
            {
                this.PosX = 0;
                this.PosY = 0;
                informStatus(PlayerName, PosX, PosY);
            }
            else if (Pcont == 2)
            {
                this.PosX = Qlinhas-1;
                this.PosY = 0;
                informStatus(PlayerName, PosX, PosY);
            }
            else if (Pcont == 3)
            {
                this.PosX = Qlinhas-1;
                this.PosY = Qcolunas-1;
                informStatus(PlayerName, PosX, PosY);
            }
            else if (Pcont == 4)
            {
                this.PosX = 0;
                this.PosY = Qcolunas-1;
                informStatus(PlayerName, PosX, PosY);
            }
            else if (Pcont == 5)
            {
                this.PosX = Qlinhas / 2;
                this.PosY = 0;
                informStatus(PlayerName, PosX, PosY);
            }
            else if (Pcont == 6)
            {
                this.PosX = Qlinhas - 1;
                this.PosY = Qcolunas / 2;
                informStatus(PlayerName, PosX, PosY);
            }
            else if (Pcont == 7)
            {
                this.PosX = Qlinhas / 2;
                this.PosY = Qcolunas - 1;
                informStatus(PlayerName, PosX, PosY);
            }
            else if (Pcont == 8)
            {
                this.PosX = 0;
                this.PosY = Qcolunas / 2;
                informStatus(PlayerName, PosX, PosY);
            }
        }
    
