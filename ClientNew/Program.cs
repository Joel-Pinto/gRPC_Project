namespace ClientNew
{
    static class Program
    {
        public delegate Task<double> UpdateWallet();

        /*Views*/
        public static Views.AddHostView? ViewAddHost { get; private set; }
        public static Views.BoughtTicketView? ViewBoughtTicket { get; private set; }
        public static Views.SearchView? ViewSearch { get; private set; }
        public static MainPage? ViewMainPage { get; private set; }
        public static Views.TheaterDetails? ViewTheaterDetails { get; private set; }
        public static Views.LoginView? ViewLogin { get; private set; }
        public static Views.RegistarView? ViewRegistar { get; private set; }


        /*Models*/
        public static Models.Theater? ModelTheater { get; private set; }
        public static Models.LocalHost? ModelLocalHost { get; private set; }
        public static Models.Show? ModelShow { get; private set; }
        public static Models.Session? ModelSession { get; private set; }
        public static Models.User? ModelUser { get; private set; }

        /*Controllers*/
        public static Controllers.ControllerTheater? ControllerTheater { get; private set; }
        public static Controllers.ControllerShow? ControllerShow { get; private set; }
        public static Controllers.ControllerSession? ControllerSession { get; private set; }
        public static Controllers.ControllerUser? ControllerUser { get; private set; }
        public static Controllers.ControllerTicket? ControllerTicket { get; private set; }
        public static Controllers.ControllerWallet? ControllerWallet { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            /*Views*/
            ViewAddHost = new Views.AddHostView();
            ViewBoughtTicket = new Views.BoughtTicketView();
            ViewSearch = new Views.SearchView();
            ViewMainPage = new MainPage();
            ViewTheaterDetails = new Views.TheaterDetails();
            ViewLogin = new Views.LoginView();
            ViewRegistar = new Views.RegistarView();

            /*Models*/
            ModelTheater = new Models.Theater();
            ModelLocalHost = new Models.LocalHost();
            ModelShow = new Models.Show();
            ModelSession = new Models.Session();
            ModelUser = new Models.User();

            /*Controllers*/
            ControllerTheater = new Controllers.ControllerTheater();
            ControllerShow = new Controllers.ControllerShow();
            ControllerSession = new Controllers.ControllerSession();
            ControllerUser = new Controllers.ControllerUser();
            ControllerTicket = new Controllers.ControllerTicket();
            ControllerWallet = new Controllers.ControllerWallet();

            Application.Run(new Views.AddHostView());
        }
    }
}